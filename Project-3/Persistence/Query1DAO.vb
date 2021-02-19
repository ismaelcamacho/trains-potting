Public Class Query1DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution As DataTable

    Public Sub New()
        Me.query = New Collection
        Me.solution = New DataTable
    End Sub

    Public Sub ReadQuery(ByRef q As Query1)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT Trips.TripDate, Trips.Train, Products.ProductDescription FROM Products INNER JOIN Trips ON Products.ProductID = Trips.Product
                                       WHERE Trips.TripDate>=#" & q.DateStart & "# And Trips.TripDate<=# " & q.DateEnd & "# AND Trips.Train='" & q.TrainID & "';")

        'Here we create the table format in which we store the info of the query
        solution.Columns.Add("Trip Date", GetType(String))
        solution.Columns.Add("Train", GetType(String))
        solution.Columns.Add("Product", GetType(String))

        For Each aux In col
            solution.Rows.Add(FormatDateTime(aux(1), DateFormat.ShortDate).ToString, aux(2).ToString, aux(3).ToString)
        Next

        'Now we need the number of trips
        col = DBBroker.GetBroker.Read("SELECT COUNT(*) FROM (SELECT TripDate, Train FROM Trips GROUP BY TripDate, Train
                                                             HAVING TripDate>#" & q.DateStart & "# AND TripDate<#" & q.DateEnd & "#
                                                             AND Train='" & q.TrainID & "');")

        For Each aux In col
            Me.query.Add(aux(1).ToString)
        Next
    End Sub
End Class
