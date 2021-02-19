Public Class TrainType
    Public Property TrainTypeID As Integer
    Public Property TrainTypeDescription As String
    Public Property MaxCapacity As Integer
    Public Property TypDao As TrainTypeDAO

    Public Sub New()
        Me.TypDao = New TrainTypeDAO
    End Sub

    Public Sub New(TrainTypeID As Integer)
        Me.TypDao = New TrainTypeDAO
        Me.TrainTypeID = TrainTypeID
    End Sub

    Public Sub New(TrainTypeDescription As String)
        Me.TypDao = New TrainTypeDAO
        Me.TrainTypeDescription = TrainTypeDescription
    End Sub

    Public Sub ReadAllTrainType(path As String)
        Me.TypDao.ReadAll(path)
    End Sub

    Public Sub ReadTrainTypeDescription()
        Me.TypDao.ReadDescription(Me)
    End Sub

    Public Sub ReadTrainType()
        Me.TypDao.Read(Me)
    End Sub

    Public Function isType() As Integer
        Return Me.TypDao.isTrainType(Me)
    End Function

    Public Function InsertTrainType() As Integer
        Return Me.TypDao.Insert(Me)
    End Function

    Public Function UpdateTrainType() As Integer
        Return Me.TypDao.Change(Me)
    End Function

    Public Function DeleteTrainType() As Integer
        Return Me.TypDao.Delete(Me)
    End Function

End Class
