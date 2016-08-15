Public Class AccountsPayables
    Private Sub AccountsPayables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_SHARE_WITHDRAWALS' table. You can move, or remove it, as needed.
            Me.SP_SHARE_WITHDRAWALSTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_SHARE_WITHDRAWALS)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_LOAN_DISBURSEMENT' table. You can move, or remove it, as needed.
            Me.SP_LOAN_DISBURSEMENTTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_LOAN_DISBURSEMENT)
        ElseIf TabControl1.SelectedIndex = 2 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_ASSET_PURCHASES' table. You can move, or remove it, as needed.
            Me.SP_ASSET_PURCHASESTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_ASSET_PURCHASES)
        ElseIf TabControl1.SelectedIndex = 3 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.sp_BillerList' table. You can move, or remove it, as needed.
            Me.Sp_BillerListTableAdapter.Fill(Me.MBv8LedgerDataSet.sp_BillerList)
        ElseIf TabControl1.SelectedIndex = 4 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_VENDOR_LIST' table. You can move, or remove it, as needed.
            Me.SP_VENDOR_LISTTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_VENDOR_LIST)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_SHARE_WITHDRAWALS' table. You can move, or remove it, as needed.
            Me.SP_SHARE_WITHDRAWALSTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_SHARE_WITHDRAWALS)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_LOAN_DISBURSEMENT' table. You can move, or remove it, as needed.
            Me.SP_LOAN_DISBURSEMENTTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_LOAN_DISBURSEMENT)
        ElseIf TabControl1.SelectedIndex = 2 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_ASSET_PURCHASES' table. You can move, or remove it, as needed.
            Me.SP_ASSET_PURCHASESTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_ASSET_PURCHASES)
        ElseIf TabControl1.SelectedIndex = 3 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.sp_BillerList' table. You can move, or remove it, as needed.
            Me.Sp_BillerListTableAdapter.Fill(Me.MBv8LedgerDataSet.sp_BillerList)
        ElseIf TabControl1.SelectedIndex = 4 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_VENDOR_LIST' table. You can move, or remove it, as needed.
            Me.SP_VENDOR_LISTTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_VENDOR_LIST)
        End If
    End Sub

    Private Sub SP_SHARE_WITHDRAWALSDataGridView_Click(sender As Object, e As EventArgs) Handles SP_SHARE_WITHDRAWALSDataGridView.Click

        Dim SD As New SuperDisburse
        SD.TabControl1.SelectedIndex = 1
        SD.ShowDialog()

    End Sub

    Private Sub SP_LOAN_DISBURSEMENTDataGridView_Click(sender As Object, e As EventArgs) Handles SP_LOAN_DISBURSEMENTDataGridView.Click
        Dim SD As New SuperDisburse
        SD.TabControl1.SelectedIndex = 2
        SD.ShowDialog()
    End Sub
End Class