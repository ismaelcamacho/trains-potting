Public Class Product
    Public Property ProductID As Integer
    Public Property ProductDescription As String
    Public Property ProDao As ProductDAO

    Public Sub New()
        Me.ProDao = New ProductDAO
    End Sub

    Public Sub New(ProductID As Integer)
        Me.ProDao = New ProductDAO
        Me.ProductID = ProductID
    End Sub

    Public Sub New(ProductDescription As String)
        Me.ProDao = New ProductDAO
        Me.ProductDescription = ProductDescription
    End Sub

    Public Sub ReadAllProduct(path As String)
        Me.ProDao.ReadAll(path)
    End Sub

    Public Sub ReadProduct()
        Me.ProDao.Read(Me)
    End Sub

    Public Sub ReadProductDescription()
        Me.ProDao.ReadDescription(Me)
    End Sub

    Public Function isProductDescription()
        Return Me.ProDao.isDescription(Me)
    End Function

    Public Function InsertProduct() As Integer
        Return Me.ProDao.Insert(Me)
    End Function

    Public Function UpdateProduct() As Integer
        Return Me.ProDao.Change(Me)
    End Function

    Public Function DeleteProduct() As Integer
        Return Me.ProDao.Delete(Me)
    End Function

End Class