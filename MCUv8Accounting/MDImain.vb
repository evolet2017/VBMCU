Imports System.Windows.Forms

Public Class MDImain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click

        Dim child_dashboard As New Dashboard

        child_dashboard.MdiParent = Me

        child_dashboard.WindowState = FormWindowState.Maximized
        child_dashboard.Show()

    End Sub

    Private Sub MDImain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        v8rundate()
        Dim child_login As New Login

        child_login.MdiParent = Me

        child_login.Show()

    End Sub

    Public Sub v8rundate()

        ExecText_Reader("SELECT mbvalue from appconfig where mbfield1 = 'sysdate'")

        If rdr.HasRows Then
            While (rdr.Read())
                ToolStripStatusLabelDate.Text = "System Date : " + rdr("mbvalue").ToString
                Mv8rundate = rdr("mbvalue")
            End While
        End If

        Close_ExecSP_Reader()
    End Sub

    Private Sub PostedTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostedTransactionsToolStripMenuItem.Click

        Dim child_transactions As New Transactions
        child_transactions.MdiParent = Me
        child_transactions.Show()

        child_transactions.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BankAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankAccountsToolStripMenuItem.Click

        Dim child_banking As New Banking
        child_banking.MdiParent = Me

        child_banking.Show()

        child_banking.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CheckBookInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckBookInventoryToolStripMenuItem.Click

        Dim child_checkinventory As New ChecksInventory
        child_checkinventory.MdiParent = Me

        child_checkinventory.Show()
        child_checkinventory.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ShareWithdrawalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShareWithdrawalsToolStripMenuItem.Click

        Dim child_ap As New AccountsPayables
        With child_ap
            .MdiParent = Me
            .TabControl1.SelectedIndex = 0
            .Show()
        End With
        child_ap.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LoanDisbursementChecksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanDisbursementChecksToolStripMenuItem.Click
        Dim child_ap As New AccountsPayables
        With child_ap
            .MdiParent = Me
            .TabControl1.SelectedIndex = 1
            .Show()
        End With
        child_ap.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FixedAssetPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixedAssetPurchaseToolStripMenuItem.Click
        Dim child_ap As New AccountsPayables
        With child_ap
            .MdiParent = Me
            .TabControl1.SelectedIndex = 2
            .Show()
        End With
        child_ap.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub OtherPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherPaymentsToolStripMenuItem.Click
        Dim child_ap As New AccountsPayables
        With child_ap
            .MdiParent = Me
            .TabControl1.SelectedIndex = 3
            .Show()
        End With
        child_ap.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VendorManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorManagementToolStripMenuItem.Click
        Dim child_ap As New AccountsPayables
        With child_ap
            .MdiParent = Me
            .TabControl1.SelectedIndex = 4
            .Show()
        End With
        child_ap.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetsToolStripMenuItem.Click
        Dim child_asset As New FixedAsset
        With child_asset
            .MdiParent = Me
            .TabControl1.SelectedIndex = 0
            .Show()
        End With
        child_asset.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SaleAndDisposalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleAndDisposalToolStripMenuItem.Click
        Dim child_asset As New FixedAsset
        With child_asset
            .MdiParent = Me
            .TabControl1.SelectedIndex = 1
            .Show()
        End With
        child_asset.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ImportCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportCSVToolStripMenuItem.Click
        Dim child_asset As New FixedAsset
        With child_asset
            .MdiParent = Me
            .TabControl1.SelectedIndex = 2
            .Show()
        End With
        child_asset.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CashAdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashAdvanceToolStripMenuItem.Click
        Dim child_operation As New Operations
        With child_operation
            .MdiParent = Me
            .TabControl1.SelectedIndex = 0
            .Show()
        End With
        child_operation.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ReflenishPettyCashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReflenishPettyCashToolStripMenuItem.Click
        Dim child_operation As New Operations
        With child_operation
            .MdiParent = Me
            .TabControl1.SelectedIndex = 1
            .Show()
        End With
        child_operation.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PerformEndOfDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformEndOfDayToolStripMenuItem.Click
        Try
            Dim result3 As DialogResult = MessageBox.Show("Continue perform end of day?",
                                    "The Question",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2)

            If result3 = DialogResult.Yes Then
                ExecNonQuery("sp_OutputCSV")
                MsgBox("Export Successful!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PerformEndOfMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformEndOfMonthToolStripMenuItem.Click
        Try
            Dim result2 As DialogResult = MessageBox.Show("Continue perform end of month?",
                        "The Question",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

            If result2 = DialogResult.Yes Then
                ExecNonQuery("sp_MonthlyDepre2")
                ExecNonQuery("sp_OutputCSV")
                MsgBox("End of month successful!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SyncChartOfAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyncChartOfAccountsToolStripMenuItem.Click
        Try
            Dim result1 As DialogResult = MessageBox.Show("Sync chart of accounts?",
                        "The Question",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

            If result1 = DialogResult.Yes Then
                ExecNonQuery("sp_FetchGLACC")
                MsgBox("Sync successful!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CashReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashReceivedToolStripMenuItem.Click

        Dim child_cashrec As New CashChecksReceived
        child_cashrec.MdiParent = Me
        child_cashrec.TabControl1.SelectedIndex = 0
        child_cashrec.Show()
        child_cashrec.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ChecksReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChecksReceivedToolStripMenuItem.Click
        Dim child_cashrec As New CashChecksReceived
        child_cashrec.MdiParent = Me
        child_cashrec.TabControl1.SelectedIndex = 1
        child_cashrec.Show()
        child_cashrec.WindowState = FormWindowState.Maximized
    End Sub
End Class
