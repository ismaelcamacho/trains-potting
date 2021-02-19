Public Class Train
    Public Property TrainID As String
    Public Property TrainType As Integer
    Public Property TraDao As TrainDAO

    Public Sub New()
        Me.TraDao = New TrainDAO
    End Sub

    Public Sub New(TrainID As String)
        Me.TraDao = New TrainDAO
        Me.TrainID = TrainID
    End Sub

    Public Sub New(TrainType As Integer)
        Me.TraDao = New TrainDAO
        Me.TrainType = TrainType
    End Sub

    Public Sub ReadAllTrain(path As String)
        Me.TraDao.ReadAll(path)
    End Sub

    Public Sub ReadTrain()
        Me.TraDao.Read(Me)
    End Sub

    Public Function isTrain() As Integer
        Return Me.TraDao.isTrainID(Me)
    End Function

    Public Sub ReadTrainType()
        Me.TraDao.ReadTrainType(Me)
    End Sub

    Public Function InsertTrain() As Integer
        Return Me.TraDao.Insert(Me)
    End Function

    Public Function UpdateTrain() As Integer
        Return Me.TraDao.Change(Me)
    End Function

    Public Function DeleteTrain() As Integer
        Return Me.TraDao.Delete(Me)
    End Function

End Class
