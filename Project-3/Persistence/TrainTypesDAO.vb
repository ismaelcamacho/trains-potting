Public Class TrainTypeDAO
    Public ReadOnly Property TrainType As Collection

    Public Sub New()
        Me.TrainType = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim typ As TrainType
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM TrainTypes ORDER BY TrainTypeID")
        For Each aux In col
            typ = New TrainType(aux(1).ToString)
            typ.TrainTypeDescription = aux(2).ToString
            typ.MaxCapacity = aux(3).ToString
            Me.TrainType.Add(typ)
        Next
    End Sub

    Public Sub Read(ByRef typ As TrainType)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM TrainTypes WHERE TrainTypeID=" & typ.TrainTypeID & ";")
        For Each aux In col
            typ.TrainTypeDescription = aux(2).ToString
            typ.MaxCapacity = aux(3).ToString
        Next
    End Sub

    Public Sub ReadDescription(ByRef typ As TrainType)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT TrainTypeID FROM TrainTypes WHERE TrainTypeDescription='" & typ.TrainTypeDescription & "';")
        For Each aux In col
            typ.TrainTypeID = aux(1).ToString
        Next
    End Sub

    Public Function isTrainType(ByRef typ As TrainType) As Integer
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT TrainTypeID FROM TrainTypes WHERE TrainTypeDescription='" & typ.TrainTypeDescription & "';")
        For Each aux In col
            typ.TrainTypeID = aux(1).ToString
        Next
        Return typ.TrainTypeID <> 0
    End Function

    Public Function Insert(ByVal typ As TrainType) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO TrainTypes (TrainTypeDescription, MaxCapacity) VALUES ('" & typ.TrainTypeDescription & "', " & typ.MaxCapacity & ");")
    End Function

    Public Function Change(ByVal typ As TrainType) As Integer
        Return DBBroker.GetBroker.Change("UPDATE TrainTypes SET TrainTypeDescription='" & typ.TrainTypeDescription & "', MaxCapacity=" & typ.MaxCapacity & " WHERE TrainTypeID=" & typ.TrainTypeID & ";")
    End Function

    Public Function Delete(ByVal typ As TrainType) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM TrainTypes WHERE TrainTypeID=" & typ.TrainTypeID & ";")
    End Function
End Class
