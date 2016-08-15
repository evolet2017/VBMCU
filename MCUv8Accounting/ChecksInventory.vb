Public Class ChecksInventory
    Private Sub ChecksInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_CHECKS_INVENTORY' table. You can move, or remove it, as needed.
        Me.SP_CHECKS_INVENTORYTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_CHECKS_INVENTORY)

        Banknames()

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub SP_CHECKS_INVENTORYDataGridView_Click(sender As Object, e As EventArgs) Handles SP_CHECKS_INVENTORYDataGridView.Click
        Me.SP_CHECKS_INVENTORY_DETAILTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_CHECKS_INVENTORY_DETAIL, SP_CHECKS_INVENTORYDataGridView.SelectedCells(0).Value.ToString, SP_CHECKS_INVENTORYDataGridView.SelectedCells(2).Value)
    End Sub

    Public Sub Banknames()

        Dim badt As New DataTable

        ExecSP_Adptr("SELECT DISTINCT BankName, BankAccountNum FROM BankAccounts", badt)

        With BankNameComboBox
            .DataSource = badt.DefaultView
            .DisplayMember = "Bankname"
            .ValueMember = "BankAccountNum"
        End With
    End Sub

End Class