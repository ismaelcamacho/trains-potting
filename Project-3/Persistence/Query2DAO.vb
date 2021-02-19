Public Class Query2DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution As DataTable

    Public Sub New()
        Me.query = New Collection
        Me.solution = New DataTable
    End Sub

    Public Sub ReadQuery2(ByRef q As Query2)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT TrainTypes.TrainTypeDescription, COUNT(TrainTypes.TrainTypeDescription) AS TotalTrips
                                        FROM (SELECT DISTINCT Trips.TripDate, TrainTypes.TrainTypeDescription 
                                        FROM TrainTypes INNER JOIN (Trains INNER JOIN Trips ON Trains.TrainID = Trips.Train) ON TrainTypes.TrainTypeID = Trains.TrainType 
                                        WHERE (((Trips.TripDate)>#" & q.DateStart & "# And (Trips.TripDate)<#" & q.DateEnd & "#) And (Trips.Train=Trains.TrainID) And (Trains.TrainType=TrainTypes.TrainTypeID)) 
                                        GROUP BY Trips.TripDate, TrainTypes.TrainTypeDescription)
                                        GROUP BY  TrainTypes.TrainTypeDescription
                                        ORDER BY COUNT(TrainTypes.TrainTypeDescription) DESC;")

        'Here we create the table format in which we store the info of the query
        solution.Columns.Add("Train Type", GetType(String))
        solution.Columns.Add("Total Trips", GetType(String))

        For Each aux In col
            solution.Rows.Add(aux(1).ToString, aux(2).ToString)
        Next
    End Sub
End Class
