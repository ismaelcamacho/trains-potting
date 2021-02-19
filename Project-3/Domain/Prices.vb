Public Class Prices
    Public Property ProductID As Integer
    Public Property PriceDate As Date
    Public Property EurosPerTon As Double
    Public Property PriDao As PricesDAO

    Public Sub New()
        Me.PriDao = New PricesDAO
    End Sub

    Public Sub New(ProductID As Integer)
        Me.PriDao = New PricesDAO
        Me.ProductID = ProductID
    End Sub

    Public Sub New(ProductID As Integer, PriceDate As Date)
        Me.PriDao = New PricesDAO
        Me.ProductID = ProductID
        Me.PriceDate = PriceDate
    End Sub

    Public Sub ReadAllPrices(path As String)
        Me.PriDao.ReadAll(path)
    End Sub

    Public Sub ReadPrice()
        Me.PriDao.Read(Me)
    End Sub

    Public Function InsertPrice() As Integer
        Return Me.PriDao.Insert(Me)
    End Function

    Public Function UpdatePrice() As Integer
        Return Me.PriDao.Change(Me)
    End Function

    Public Function DeletePrice() As Integer
        Return Me.PriDao.Delete(Me)
    End Function

End Class
