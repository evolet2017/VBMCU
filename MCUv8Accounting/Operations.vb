Public Class Operations
    Private Sub Operations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectionIndex()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        selectionIndex()
    End Sub

    Public Sub selectionIndex()
        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_CASH_ADVANCE' table. You can move, or remove it, as needed.
            Me.SP_CASH_ADVANCETableAdapter.Fill(Me.MBv8LedgerDataSet.SP_CASH_ADVANCE)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_PETTY_CASH' table. You can move, or remove it, as needed.
            Me.SP_PETTY_CASHTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_PETTY_CASH)
        End If
    End Sub
End Class