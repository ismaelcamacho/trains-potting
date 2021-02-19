Public Class TrainDAO
    Public ReadOnly Property Train As Collection

    Public Sub New()
        Me.Train = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim t As Train
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Trains ORDER BY TrainID")
        For Each aux In col
            t = New Train(aux(1).ToString)
            t.TrainType = aux(2).ToString
            Me.Train.Add(t)
        Next
    End Sub

    Public Sub Read(ByRef t As Train)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trains WHERE TrainID='" & t.TrainID & "';")
        For Each aux In col
            t.TrainType = aux(2).ToString
        Next
    End Sub

    Public Sub ReadTrainType(ByRef t As Train)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT TrainID FROM Trains WHERE TrainID='" & t.TrainID & "';")
        For Each aux In col
            t.TrainID = aux(1).ToString
        Next
    End Sub

    Public Function isTrainID(ByRef t As Train) As Integer
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Trains WHERE TrainID='" & t.TrainID & "';")

        For Each aux In col
            If (t.TrainID = aux(1).ToString) Then
                Return -1
            ElseIf (t.TrainID <> aux(1).ToString) Then
                Return 0
            End If
        Next
    End Function

    Public Function Insert(ByVal t As Train) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Trains (TrainID, TrainType) VALUES ('" & t.TrainID & "', " & t.TrainType & " );")
    End Function

    Public Function Change(ByVal t As Train) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Trains SET TrainType=" & t.TrainType & " WHERE TrainID= '" & t.TrainID & "';")
    End Function

    Public Function Delete(ByVal t As Train) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Trains WHERE TrainID='" & t.TrainID & "';")
    End Function
End Class
