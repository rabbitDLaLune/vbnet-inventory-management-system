Public Class ProductForm

    Private selectedProductId As Integer = 0

    Private ReadOnly categoryService As New CategoryService()
    Private ReadOnly supplierService As New SupplierService()
    Private ReadOnly productService As New ProductService()

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadSuppliers()
        LoadProducts()
    End Sub

    Private Sub LoadCategories()
        Try
            Dim categories = categoryService.GetAllCategories()

            categories.Insert(0, New Category With {
            .CategoryId = 0,
            .CategoryName = "-- Select Category --",
            .Description = ""
        })

            cmbCategory.DataSource = Nothing
            cmbCategory.DataSource = categories
            cmbCategory.DisplayMember = "CategoryName"
            cmbCategory.ValueMember = "CategoryId"
            cmbCategory.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Failed to load categories: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSuppliers()
        Try
            Dim suppliers = supplierService.GetAllSuppliers()

            suppliers.Insert(0, New Supplier With {
            .SupplierId = 0,
            .SupplierName = "-- Select Supplier --",
            .Phone = "",
            .Email = "",
            .Address = ""
        })

            cmbSupplier.DataSource = Nothing
            cmbSupplier.DataSource = suppliers
            cmbSupplier.DisplayMember = "SupplierName"
            cmbSupplier.ValueMember = "SupplierId"
            cmbSupplier.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Failed to load suppliers: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadProducts()
        Try
            dgvProducts.DataSource = productService.GetProducts(txtSearch.Text)

            If dgvProducts.Columns.Contains("ProductId") Then
                dgvProducts.Columns("ProductId").Visible = False
            End If

            If dgvProducts.Columns.Contains("CategoryId") Then
                dgvProducts.Columns("CategoryId").Visible = False
            End If

            If dgvProducts.Columns.Contains("SupplierId") Then
                dgvProducts.Columns("SupplierId").Visible = False
            End If

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Failed to load products: " & ex.Message)
        End Try
    End Sub
    Private Function BuildProductFromForm() As Product
        Dim costPrice As Decimal
        Dim sellingPrice As Decimal
        Dim quantity As Integer
        Dim reorderLevel As Integer

        If Not Decimal.TryParse(txtCostPrice.Text, costPrice) Then
            Throw New Exception("Cost price must be a valid number.")
        End If

        If Not Decimal.TryParse(txtSellingPrice.Text, sellingPrice) Then
            Throw New Exception("Selling price must be a valid number.")
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            Throw New Exception("Quantity must be a valid whole number.")
        End If

        If Not Integer.TryParse(txtReorderLevel.Text, reorderLevel) Then
            Throw New Exception("Reorder level must be a valid whole number.")
        End If

        Dim categoryId As Integer = Convert.ToInt32(cmbCategory.SelectedValue)
        Dim supplierId As Integer = Convert.ToInt32(cmbSupplier.SelectedValue)

        Return New Product With {
        .ProductId = selectedProductId,
        .ProductName = txtProductName.Text.Trim(),
        .CategoryId = categoryId,
        .SupplierId = If(supplierId > 0, CType(supplierId, Integer?), Nothing),
        .CostPrice = costPrice,
        .SellingPrice = sellingPrice,
        .Quantity = quantity,
        .ReorderLevel = reorderLevel
    }
    End Function
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

        selectedProductId = Convert.ToInt32(row.Cells("ProductId").Value)

        txtProductName.Text = row.Cells("ProductName").Value.ToString()
        txtCostPrice.Text = row.Cells("CostPrice").Value.ToString()
        txtSellingPrice.Text = row.Cells("SellingPrice").Value.ToString()
        txtQuantity.Text = row.Cells("Quantity").Value.ToString()
        txtReorderLevel.Text = row.Cells("ReorderLevel").Value.ToString()

        cmbCategory.SelectedValue = Convert.ToInt32(row.Cells("CategoryId").Value)

        If IsDBNull(row.Cells("SupplierId").Value) Then
            cmbSupplier.SelectedValue = 0
        Else
            cmbSupplier.SelectedValue = Convert.ToInt32(row.Cells("SupplierId").Value)
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim product = BuildProductFromForm()

            productService.UpdateProduct(product)

            MessageBox.Show("Product updated successfully.")

            ClearForm()
            LoadProducts()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selectedProductId <= 0 Then
                MessageBox.Show("Please select a product to delete.")
                Return
            End If

            Dim confirm = MessageBox.Show(
            "Are you sure you want to delete this product?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

            If confirm = DialogResult.No Then
                Return
            End If

            productService.DeleteProduct(selectedProductId)

            MessageBox.Show("Product deleted successfully.")

            ClearForm()
            LoadProducts()

        Catch ex As Exception
            MessageBox.Show("Failed to delete product: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearForm()
        selectedProductId = 0

        txtProductName.Clear()
        txtCostPrice.Clear()
        txtSellingPrice.Clear()
        txtQuantity.Clear()
        txtReorderLevel.Clear()

        If cmbCategory.Items.Count > 0 Then
            cmbCategory.SelectedIndex = 0
        End If

        If cmbSupplier.Items.Count > 0 Then
            cmbSupplier.SelectedIndex = 0
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim product = BuildProductFromForm()

            productService.AddProduct(product)

            MessageBox.Show("Product added successfully.")

            ClearForm()
            LoadProducts()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close
    End Sub

End Class