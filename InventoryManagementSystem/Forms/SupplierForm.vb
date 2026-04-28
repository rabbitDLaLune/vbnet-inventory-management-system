Public Class SupplierForm

    Private selectedSupplierId As Integer = 0
    Private ReadOnly supplierService As New SupplierService()

    Private Sub SupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
    End Sub

    Private Sub LoadSuppliers()
        Try
            dgvSuppliers.DataSource = supplierService.GetSuppliers(txtSearch.Text)

            If dgvSuppliers.Columns.Contains("SupplierId") Then
                dgvSuppliers.Columns("SupplierId").Visible = False
            End If

            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Failed to load suppliers: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSupplierFromForm() As Supplier
        Return New Supplier With {
            .SupplierId = selectedSupplierId,
            .SupplierName = txtSupplierName.Text.Trim(),
            .Phone = txtPhone.Text.Trim(),
            .Email = txtEmail.Text.Trim(),
            .Address = txtAddress.Text.Trim()
        }
    End Function

    Private Sub ClearForm()
        selectedSupplierId = 0
        txtSupplierName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtSupplierName.Focus()
    End Sub

    Private Sub dgvSuppliers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSuppliers.Rows(e.RowIndex)

        selectedSupplierId = Convert.ToInt32(row.Cells("SupplierId").Value)
        txtSupplierName.Text = row.Cells("SupplierName").Value.ToString()

        If IsDBNull(row.Cells("Phone").Value) Then
            txtPhone.Text = ""
        Else
            txtPhone.Text = row.Cells("Phone").Value.ToString()
        End If

        If IsDBNull(row.Cells("Email").Value) Then
            txtEmail.Text = ""
        Else
            txtEmail.Text = row.Cells("Email").Value.ToString()
        End If

        If IsDBNull(row.Cells("Address").Value) Then
            txtAddress.Text = ""
        Else
            txtAddress.Text = row.Cells("Address").Value.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim supplier = BuildSupplierFromForm()

            supplierService.AddSupplier(supplier)

            MessageBox.Show("Supplier added successfully.")

            ClearForm()
            LoadSuppliers()

        Catch ex As Exception
            MessageBox.Show("Failed to add supplier: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim supplier = BuildSupplierFromForm()

            supplierService.UpdateSupplier(supplier)

            MessageBox.Show("Supplier updated successfully.")

            ClearForm()
            LoadSuppliers()

        Catch ex As Exception
            MessageBox.Show("Failed to update supplier: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selectedSupplierId <= 0 Then
                MessageBox.Show("Please select a supplier to delete.")
                Return
            End If

            Dim confirm = MessageBox.Show(
                "Are you sure you want to delete this supplier?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If confirm = DialogResult.No Then
                Return
            End If

            supplierService.DeleteSupplier(selectedSupplierId)

            MessageBox.Show("Supplier deleted successfully.")

            ClearForm()
            LoadSuppliers()

        Catch ex As Exception
            MessageBox.Show("Failed to delete supplier: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadSuppliers()
    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub
End Class