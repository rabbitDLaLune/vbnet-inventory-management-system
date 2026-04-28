Public Class CategoryForm

    Private selectedCategoryId As Integer = 0
    Private ReadOnly categoryService As New CategoryService()

    Private Sub CategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Try
            dgvCategories.DataSource = categoryService.GetCategories(txtSearch.Text)

            If dgvCategories.Columns.Contains("CategoryId") Then
                dgvCategories.Columns("CategoryId").Visible = False
            End If

            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Failed to load categories: " & ex.Message)
        End Try
    End Sub

    Private Function BuildCategoryFromForm() As Category
        Return New Category With {
            .CategoryId = selectedCategoryId,
            .CategoryName = txtCategoryName.Text.Trim(),
            .Description = txtDescription.Text.Trim()
        }
    End Function

    Private Sub ClearForm()
        selectedCategoryId = 0
        txtCategoryName.Clear()
        txtDescription.Clear()
        txtCategoryName.Focus()
    End Sub

    Private Sub dgvCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvCategories.Rows(e.RowIndex)

        selectedCategoryId = Convert.ToInt32(row.Cells("CategoryId").Value)
        txtCategoryName.Text = row.Cells("CategoryName").Value.ToString()

        If IsDBNull(row.Cells("Description").Value) Then
            txtDescription.Text = ""
        Else
            txtDescription.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim category = BuildCategoryFromForm()

            categoryService.AddCategory(category)

            MessageBox.Show("Category added successfully.")

            ClearForm()
            LoadCategories()

        Catch ex As Exception
            MessageBox.Show("Failed to add category: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim category = BuildCategoryFromForm()

            categoryService.UpdateCategory(category)

            MessageBox.Show("Category updated successfully.")

            ClearForm()
            LoadCategories()

        Catch ex As Exception
            MessageBox.Show("Failed to update category: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selectedCategoryId <= 0 Then
                MessageBox.Show("Please select a category to delete.")
                Return
            End If

            Dim confirm = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If confirm = DialogResult.No Then
                Return
            End If

            categoryService.DeleteCategory(selectedCategoryId)

            MessageBox.Show("Category deleted successfully.")

            ClearForm()
            LoadCategories()

        Catch ex As Exception
            MessageBox.Show("Failed to delete category: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCategories()
    End Sub

End Class