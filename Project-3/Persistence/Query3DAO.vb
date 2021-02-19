Public Class Query3DAO
    Public ReadOnly Property query As Collection
    Public ReadOnly Property solution As DataTable

    Public Sub New()
        Me.query = New Collection
        Me.solution = New DataTable
    End Sub

    Public Sub ReadQuery3(ByRef q As Query3)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT p.ProductDescription, COUNT(*) AS Total FROM Products p INNER JOIN Trips t ON p.ProductID = t.Product
                                       WHERE (p.ProductID = t.Product) 
                                       AND (t.TripDate>=#" & q.DateStart & "# AND t.TripDate<#" & q.DateEnd & "#)
                                       GROUP BY p.ProductDescription
                                       ORDER BY COUNT(*) DESC;")

        'Here we create the table format in which we store the info of the query
        solution.Columns.Add("Product Description", GetType(String))
        solution.Columns.Add("Total of Products sent", GetType(String))

        For Each aux In col
            solution.Rows.Add(aux(1).ToString, aux(2).ToString)
        Next
    End Sub
End Class
