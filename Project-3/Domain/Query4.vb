Public Class Query4
    Public Property query4Dao As Query4DAO

    Public Sub New()
        Me.query4Dao = New Query4DAO
    End Sub

    Public Sub Read()
        Me.query4Dao.ReadQuery4(Me)
    End Sub
End Class
