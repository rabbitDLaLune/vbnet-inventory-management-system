Public Class CategoryService

    Private ReadOnly categoryRepository As New CategoryRepository()

    Public Function GetAllCategories() As List(Of Category)
        Return categoryRepository.GetAll()
    End Function

    Public Function GetCategories(searchText As String) As DataTable
        Return categoryRepository.GetAllTable(searchText.Trim())
    End Function

    Public Sub AddCategory(category As Category)
        If String.IsNullOrWhiteSpace(category.CategoryName) Then
            Throw New Exception("Category name is required.")
        End If

        categoryRepository.AddCategory(category)
    End Sub

    Public Sub UpdateCategory(category As Category)
        If category.CategoryId <= 0 Then
            Throw New Exception("Please select a category to update.")
        End If

        If String.IsNullOrWhiteSpace(category.CategoryName) Then
            Throw New Exception("Category name is required.")
        End If

        categoryRepository.UpdateCategory(category)
    End Sub

    Public Sub DeleteCategory(categoryId As Integer)
        If categoryId <= 0 Then
            Throw New Exception("Please select a category to delete.")
        End If

        categoryRepository.DeleteCategory(categoryId)
    End Sub

End Class