Public Class Transactions
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MBv8LedgerDataSet.sp_PostedTransactions' table. You can move, or remove it, as needed.
        Me.Sp_PostedTransactionsTableAdapter.Fill(Me.MBv8LedgerDataSet.sp_PostedTransactions)

        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class