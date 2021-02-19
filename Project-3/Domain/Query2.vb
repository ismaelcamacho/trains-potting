Public Class Query2
    Public Property DateStart As Date
    Public Property DateEnd As Date
    Public Property query2Dao As Query2DAO

    Public Sub New()
        Me.query2Dao = New Query2DAO
    End Sub

    Public Sub New(DateStart As Date, DateEnd As Date)
        Me.query2Dao = New Query2DAO
        Me.DateStart = DateStart
        Me.DateEnd = DateEnd
    End Sub

    Public Sub Read()
        Me.query2Dao.ReadQuery2(Me)
    End Sub
End Class
