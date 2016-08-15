Public Class FixedAsset
    Private Sub FixedAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_ASSET_LISTING' table. You can move, or remove it, as needed.
            Me.SP_ASSET_LISTINGTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_ASSET_LISTING)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_SALES_DISPOSAL' table. You can move, or remove it, as needed.
            Me.SP_SALES_DISPOSALTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_SALES_DISPOSAL)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_ASSET_LISTING' table. You can move, or remove it, as needed.
            Me.SP_ASSET_LISTINGTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_ASSET_LISTING)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_SALES_DISPOSAL' table. You can move, or remove it, as needed.
            Me.SP_SALES_DISPOSALTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_SALES_DISPOSAL)
        End If
    End Sub
End Class