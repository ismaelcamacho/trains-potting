Public Class Query1
    Public Property DateStart As Date
    Public Property DateEnd As Date
    Public Property TrainID As String
    Public Property query1Dao As Query1DAO

    Public Sub New()
        Me.query1Dao = New Query1DAO
    End Sub

    Public Sub New(DateStart As Date, DateEnd As Date)
        Me.query1Dao = New Query1DAO
        Me.DateStart = DateStart
        Me.DateEnd = DateEnd
    End Sub

    Public Sub New(DateStart As Date, DateEnd As Date, TrainID As String)
        Me.query1Dao = New Query1DAO
        Me.DateStart = DateStart
        Me.DateEnd = DateEnd
        Me.TrainID = TrainID
    End Sub

    Public Sub Read()
        Me.query1Dao.ReadQuery(Me)
    End Sub
End Class
