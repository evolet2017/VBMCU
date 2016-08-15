Public Class Banking
    Private Sub Banking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MBv8LedgerDataSet.BankAccTrn' table. You can move, or remove it, as needed.
        Me.SP_BANKING_ACCOUNTSTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_BANKING_ACCOUNTS)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub SP_BANKING_ACCOUNTSDataGridView_Click(sender As Object, e As EventArgs) Handles SP_BANKING_ACCOUNTSDataGridView.Click
        Me.BankAccountsTableAdapter.Fill(Me.MBv8LedgerDataSet.BankAccounts, SP_BANKING_ACCOUNTSDataGridView.SelectedCells(0).Value.ToString)
        'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_BANKING_ACCOUNTS' table. You can move, or remove it, as needed.
        Me.BankAccTrnTableAdapter.Fill(Me.MBv8LedgerDataSet.BankAccTrn, SP_BANKING_ACCOUNTSDataGridView.SelectedCells(4).Value.ToString)
        'TODO: This line of code loads data into the 'MBv8LedgerDataSet.BankAccounts' table. You can move, or remove it, as needed.

        LabelDeposit_bank_name.Text = SP_BANKING_ACCOUNTSDataGridView.SelectedCells(1).Value.ToString
    End Sub

End Class