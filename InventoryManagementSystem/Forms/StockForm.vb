Public Class StockForm

    Private ReadOnly productService As New ProductService()
    Private ReadOnly stockService As New StockService()

    Private Sub StockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        LoadTransactionTypes()
        LoadTransactions()
    End Sub

    Private Sub LoadProducts()
        Try
            Dim table = productService.GetProductList()

            Dim row = table.NewRow()
            row("ProductId") = 0
            row("ProductName") = "-- Select Product --"
            table.Rows.InsertAt(row, 0)

            cmbProduct.DataSource = table
            cmbProduct.DisplayMember = "ProductName"
            cmbProduct.ValueMember = "ProductId"
            cmbProduct.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Failed to load products: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTransactionTypes()
        cmbTransactionType.Items.Clear()
        cmbTransactionType.Items.Add("-- Select Type --")
        cmbTransactionType.Items.Add("IN")
        cmbTransactionType.Items.Add("OUT")
        cmbTransactionType.SelectedIndex = 0
    End Sub

    Private Sub LoadTransactions()
        Try
            dgvTransactions.DataSource = stockService.GetTransactions()

            If dgvTransactions.Columns.Contains("TransactionId") Then
                dgvTransactions.Columns("TransactionId").Visible = False
            End If

            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Failed to load transactions: " & ex.Message)
        End Try
    End Sub

    Private Function BuildTransactionFromForm() As StockTransaction
        Dim quantity As Integer

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            Throw New Exception("Quantity must be a valid whole number.")
        End If

        Return New StockTransaction With {
            .ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
            .TransactionType = cmbTransactionType.SelectedItem.ToString(),
            .Quantity = quantity,
            .Notes = txtNotes.Text.Trim()
        }
    End Function

    Private Sub ClearForm()
        cmbProduct.SelectedIndex = 0
        cmbTransactionType.SelectedIndex = 0
        txtQuantity.Clear()
        txtNotes.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim transaction = BuildTransactionFromForm()

            stockService.AddTransaction(transaction)

            MessageBox.Show("Stock transaction saved successfully.")

            ClearForm()
            LoadTransactions()

        Catch ex As Exception
            MessageBox.Show("Failed to save transaction: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblProduct_Click(sender As Object, e As EventArgs) Handles lblProduct.Click

    End Sub
End Class