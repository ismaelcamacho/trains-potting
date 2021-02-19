Public Class Query3
    Public Property DateStart As Date
    Public Property DateEnd As Date
    Public Property query3Dao As Query3DAO

    Public Sub New()
        Me.query3Dao = New Query3DAO
    End Sub

    Public Sub New(DateStart As Date, DateEnd As Date)
        Me.query3Dao = New Query3DAO
        Me.DateStart = DateStart
        Me.DateEnd = DateEnd
    End Sub


    Public Sub Read()
        Me.query3Dao.ReadQuery3(Me)
    End Sub
End Class
