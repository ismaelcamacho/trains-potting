Public Class Query4DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution As DataTable
    Public Property trip As Trip
    Public Property tr As Train
    Public Property type As TrainType

    Public Sub New()
        Me.query = New Collection
        Me.solution = New DataTable
    End Sub

    Public Sub ReadQuery4(ByRef q As Query4)
        Dim col As Collection : Dim aux As Collection
        Dim productsCol As Collection
        col = DBBroker.GetBroker.Read("SELECT  t2.TripDate, t2.Train, ty.TrainTypeDescription, SUM(t2.TonsTransported*pr2.EurosPerTon) As MaxProfit 
                                        FROM (SELECT MAX(pr3.PriceDate) As LatestDate, p3.ProductID As Product
                                              FROM Prices pr3, Products p3
                                              WHERE p3.ProductID = pr3.Product
                                              GROUP BY  p3.ProductID) As q,
                                        Prices pr2, Products p2, Trips t2, TrainTypes ty, Trains tra
                                        WHERE pr2.PriceDate = q.LatestDate AND p2.ProductID = q.Product AND p2.ProductID = t2.Product AND pr2.Product = p2.ProductID AND tra.TrainID = t2.Train AND tra.TrainType = ty.TrainTypeID
                                        GROUP BY t2.TripDate, t2.Train, ty.TrainTypeDescription
                                        HAVING SUM(t2.TonsTransported*pr2.EurosPerTon) = (SELECT MAX(tr.Profit) 
                                                                                          FROM (SELECT t.TripDate, t.Train, SUM(t.TonsTransported*pr.EurosPerTon) AS Profit FROM Trips AS t, Products AS p, Prices AS pr,
                                                                                               (SELECT MAX(pr.PriceDate) As LatestDate, p.ProductID As Product
                                                                                                FROM Prices pr, Products p
                                                                                                WHERE p.ProductID = pr.Product
                                                                                                GROUP BY  p.ProductID) As q
                                                                                                WHERE pr.PriceDate = q.LatestDate AND p.ProductID = q.Product AND p.ProductID = t.Product AND pr.Product = p.ProductID
                                                                                                GROUP BY t.TripDate, t.Train)  AS tr);")

        For Each aux In col
            Me.query.Add(FormatDateTime(aux(1), DateFormat.ShortDate).ToString)
            Me.query.Add(aux(2).ToString)
            Me.query.Add(aux(3).ToString)
            Me.query.Add(aux(4).ToString)
        Next
        tr = New Train(query(2).ToString)
        tr.ReadTrain()
        trip = New Trip(query(1).ToString, tr.TrainID)
        trip.ReadTrip()

        productsCol = DBBroker.GetBroker.Read("SELECT p2.ProductDescription, t2.TonsTransported, pr2.EurosPerTon, q.LatestDate, SUM(t2.TonsTransported*pr2.EurosPerTon) As Profit 
                                                FROM (SELECT MAX(pr3.PriceDate) As LatestDate, p3.ProductID As Product
                                                      FROM Prices pr3, Products p3
                                                      WHERE p3.ProductID = pr3.Product
                                                      GROUP BY  p3.ProductID) As q,
                                                Prices pr2, Products p2, Trips t2
                                                WHERE pr2.PriceDate = q.LatestDate AND p2.ProductID = q.Product AND p2.ProductID = t2.Product AND pr2.Product = p2.ProductID AND t2.TripDate = #" & trip.TripDate & "#
                                                GROUP BY p2.ProductDescription, t2.TonsTransported, pr2.EurosPerTon, q.LatestDate;")

        'Here we create the table format in which we store the info of the query
        solution.Columns.Add("Product Description", GetType(String))
        solution.Columns.Add("Tons Transported", GetType(Integer))
        solution.Columns.Add("Euros Per Ton", GetType(Double))
        solution.Columns.Add("Price Date", GetType(String))
        solution.Columns.Add("Profit", GetType(Double))

        For Each aux In productsCol
            solution.Rows.Add(aux(1).ToString, aux(2).ToString, aux(3).ToString, FormatDateTime(aux(4), DateFormat.ShortDate).ToString, aux(5).ToString)
        Next

    End Sub
End Class
