Public Class CashChecksReceived
    Private Sub CashChecksReceived_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_BANK_CASH_INFO_LOAD' table. You can move, or remove it, as needed.
            Me.SP_BANK_CASH_INFO_LOADTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_BANK_CASH_INFO_LOAD)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.sp_bankcheckload' table. You can move, or remove it, as needed.
            Me.Sp_bankcheckloadTableAdapter.Fill(Me.MBv8LedgerDataSet.sp_bankcheckload)
        End If
        Banknames()

        If SP_BANK_CASH_INFO_LOADDataGridView.RowCount > 0 Then
            Dim total As Decimal
            For x As Integer = 0 To SP_BANK_CASH_INFO_LOADDataGridView.Rows.Count - 1
                total += SP_BANK_CASH_INFO_LOADDataGridView.Rows(x).Cells(2).Value
            Next

            TextBoxCashPostingAmount.Text = total
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.SP_BANK_CASH_INFO_LOAD' table. You can move, or remove it, as needed.
            Me.SP_BANK_CASH_INFO_LOADTableAdapter.Fill(Me.MBv8LedgerDataSet.SP_BANK_CASH_INFO_LOAD)
        ElseIf TabControl1.SelectedIndex = 1 Then
            'TODO: This line of code loads data into the 'MBv8LedgerDataSet.sp_bankcheckload' table. You can move, or remove it, as needed.
            Me.Sp_bankcheckloadTableAdapter.Fill(Me.MBv8LedgerDataSet.sp_bankcheckload)
        End If
    End Sub

    Public Sub Banknames()

        Dim badt As New DataTable

        ExecSP_Adptr("SELECT * FROM BankAccounts", badt)

        With ComboBoxCRDeposit
            .DataSource = badt
            .DisplayMember = "GLACC"
            .ValueMember = "GLACC"
        End With
    End Sub

    Private Sub ComboBoxCRDeposit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCRDeposit.SelectedIndexChanged

        ExecText_Reader("SELECT A.BankName, A.BankAccountNum, B.accounttype, C.EXPACC, C.TITLE, (SELECT SUM(amount) FROM BankAccTrn WHERE GLACC= '" & ComboBoxCRDeposit.Text & "') glbalance
        From BankAccounts A left Join accounttype b on a.BankAccountType=B.id left Join GLAC C ON A.GLACC=C.GLACC Where A.GLACC = '" & ComboBoxCRDeposit.Text & "'")

        If rdr.HasRows Then
            While (rdr.Read())
                LinkLabelAT.Text = rdr("accounttype").ToString
                LinkLabelAN.Text = rdr("BankAccountNum").ToString
                LinkLabelGLC.Text = rdr("EXPACC").ToString + " " + rdr("TITLE").ToString
                LinkLabelB.Text = rdr("glbalance")
            End While
        End If

        Close_ExecSP_Reader()

    End Sub

    Private Sub ButtonPostCashDeposit_Click(sender As Object, e As EventArgs) Handles ButtonPostCashDeposit.Click

        ExecSP_Reader("SP_TOTAL_CASH_DEPOSITS")
        Dim tcda As Decimal
        If rdr.HasRows Then
            While (rdr.Read())
                tcda = rdr("amt")
            End While

        End If
        rdr.Close()

        'MsgBox(Val(TextBoxCashPostingAmount.Text) - tcda)

        'If tcda = 0 Then
        'End If

        If Val(TextBoxCashPostingAmount.Text) = 0 Then
            MsgBox("The deposit amount does not match your cash deposit transaction!")
        Else
            OpenDB()
            'EXEC UpdateMaster '" + $('#frmSelect').val() + "','" + accounting.unformat($('#frmBankDepoAmt').val()) + "',1,'" + $('#frmReference').val() + "','DBDEPO','" + MB.getCookie('activeid') + "'";
            cmd = New SqlClient.SqlCommand("UpdateMaster", con)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@GLACC", SqlDbType.NVarChar).Value = ComboBoxCRDeposit.Text
                .Parameters.Add("@Amount", SqlDbType.Decimal).Value = Val(TextBoxCashPostingAmount.Text) - tcda
                .Parameters.Add("@TrnType", SqlDbType.Int).Value = 1
                .Parameters.Add("@TrnReference", SqlDbType.NVarChar).Value = TextBoxCash_posting_transaction_reference.Text
                .Parameters.Add("@TrnRemarks", SqlDbType.NVarChar).Value = "DBDEPO"
                .Parameters.Add("@UserID", SqlDbType.NVarChar).Value = 990
                .ExecuteNonQuery()
            End With

            CloseDB()

            MsgBox("Post Cash Deposit Complete!")
        End If
    End Sub

    Private Sub Sp_bankcheckloadDataGridView_Click(sender As Object, e As EventArgs) Handles Sp_bankcheckloadDataGridView.Click

        Dim SD As New SuperDisburse
        SD.TabControl1.SelectedIndex = 0
        SD.ShowDialog()

    End Sub
End Class