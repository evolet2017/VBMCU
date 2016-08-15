Public Class Dashboard
    Public cash As Integer
    Public check As Integer
    Public payables As Integer
    Public shares As Integer
    Public purchase As Integer
    Public bills As Integer
    Public cashadvance As Integer
    Public pettycash As Integer
    Public payroll As Integer

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BW_RELOAD.RunWorkerAsync()
        'ReloadDashBoard()
        'Dashboard()

    End Sub

    Public Sub Dashboard()
        Try

            ExecSP_Reader("SP_DASH_RELOAD")

            If rdr.HasRows Then
                While (rdr.Read())
                    'Dim a As ReloadDelegate
                    'a = New ReloadDelegate(AddressOf progress1)

                    'Dim b As ReloadDelegate
                    'b = New ReloadDelegate(AddressOf progress1)
                    'Me.Invoke(a, rdr("cash"))
                    'Me.Invoke(b, rdr("checks"))
                    Labelcash_receive.Text = rdr("cash").ToString
                    Labelchecks_receive.Text = rdr("checks").ToString
                    Labelloan_disbursement.Text = rdr("payables").ToString
                    Labelshare_withdrawals.Text = rdr("shares").ToString
                    Labelpuchases.Text = rdr("purchase").ToString
                    Labelbills_payment.Text = rdr("bills").ToString
                    Labelcash_advance.Text = rdr("cashadvance").ToString
                    Labelreflenish_pettycash.Text = rdr("pettycash").ToString
                    cash = rdr("cash")
                    check = rdr("checks")
                    payables = rdr("payables")
                    shares = rdr("shares")
                    purchase = rdr("purchase")
                    bills = rdr("bills")
                    cashadvance = rdr("cashadvance")
                    pettycash = rdr("pettycash")
                    payroll = rdr("payroll")
                End While
                Close_ExecSP_Reader()

                If ((cash + check + payables + shares) <> 0) Then
                    'EOD("sp_UpdateEOD", cash, check, payables, shares, 1)
                    OpenDB()

                    cmd = New SqlClient.SqlCommand("sp_UpdateEOD", con)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@val1", SqlDbType.Decimal).Value = cash
                        .Parameters.Add("@val2", SqlDbType.Decimal).Value = check
                        .Parameters.Add("@val3", SqlDbType.Decimal).Value = payables
                        .Parameters.Add("@val4", SqlDbType.Decimal).Value = shares
                        .Parameters.Add("@uptag", SqlDbType.Decimal).Value = 1
                        .ExecuteNonQuery()
                    End With

                    CloseDB()

                End If

                If ((purchase + bills) <> 0) Then
                    'EOD2("sp_UpdateEOD", purchase, bills, 0, 0, 2)
                    OpenDB()

                    cmd = New SqlClient.SqlCommand("sp_UpdateEOD", con)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@val1", SqlDbType.Decimal).Value = purchase
                        .Parameters.Add("@val2", SqlDbType.Decimal).Value = bills
                        .Parameters.Add("@val3", SqlDbType.Decimal).Value = 0
                        .Parameters.Add("@val4", SqlDbType.Decimal).Value = 0
                        .Parameters.Add("@uptag", SqlDbType.Decimal).Value = 2
                        .ExecuteNonQuery()
                    End With

                    CloseDB()
                End If

                If ((cashadvance + pettycash + payroll) <> 0) Then
                    'EOD3("sp_UpdateEOD", cashadvance, pettycash, payroll, 0, 3)
                    OpenDB()

                    cmd = New SqlClient.SqlCommand("sp_UpdateEOD", con)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@val1", SqlDbType.Decimal).Value = cashadvance
                        .Parameters.Add("@val2", SqlDbType.Decimal).Value = pettycash
                        .Parameters.Add("@val3", SqlDbType.Decimal).Value = payroll
                        .Parameters.Add("@val4", SqlDbType.Decimal).Value = 0
                        .Parameters.Add("@uptag", SqlDbType.Decimal).Value = 3
                        .ExecuteNonQuery()
                    End With

                    CloseDB()
                End If
            End If
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ReloadDashBoard()

        ExecText_Reader("SELECT mbvalue from appconfig where mbfield1 = 'sysdate'")

        Dim flag As Boolean = False

        If rdr.HasRows Then
            While (rdr.Read())
                If Mv8rundate = rdr("mbvalue") Then

                    flag = True

                End If
            End While
        End If
        Close_ExecSP_Reader()

        If flag = True Then
            'ExecNonQuery("sp_PitchTransaction")
            'ExecNonQuery("sp_GETSVUCDEP")
            'ExecNonQuery("sp_GetPayables")
            OpenDB()

            cmd = New SqlClient.SqlCommand("sp_PitchTransaction", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()

            cmd = New SqlClient.SqlCommand("sp_GETSVUCDEP", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()

            cmd = New SqlClient.SqlCommand("sp_GetPayables", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()

            CloseDB()
        End If

    End Sub

    Public Sub TotalCashDeposit()

        'ExecSP_Reader("SP_TOTAL_CASH_DEPOSITS")
        OpenDB()


        cmd = New SqlClient.SqlCommand("SP_TOTAL_CASH_DEPOSITS", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader

        If reader.HasRows Then
            While (reader.Read())
                LabelTotalCashDeposited.Text = reader("amt")
            End While
        End If

        reader.Close()

        CloseDB()

    End Sub

    Private Delegate Sub ReloadDelegate(ByVal cash As Integer, ByVal checks As Integer)

    Private Sub progress1(ByVal cash As Integer, ByVal checks As Integer)
        Labelcash_receive.Text = cash
        Labelchecks_receive.Text = checks
    End Sub

    Private Sub TimerDashboard_Tick(sender As Object, e As EventArgs) Handles TimerDashboard.Tick
        ReloadDashBoard()
        Dashboard()
        'MsgBox("Reload Complete!")
        'BW_RELOAD.RunWorkerAsync()

    End Sub

    Private Sub BW_RELOAD_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_RELOAD.DoWork
        ReloadDashBoard()
        Dashboard()
    End Sub

    Private Sub BW_RELOAD_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_RELOAD.RunWorkerCompleted
        Labelcash_receive.Text = cash
        Labelchecks_receive.Text = check
        Labelloan_disbursement.Text = payables
        Labelshare_withdrawals.Text = shares
        Labelpuchases.Text = purchase
        Labelbills_payment.Text = bills
        Labelcash_advance.Text = cashadvance
        Labelreflenish_pettycash.Text = pettycash
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReloadDashBoard()
        Dashboard()
        TotalCashDeposit()

    End Sub

    Private Sub LinkLabelCashReceived_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCashReceived.LinkClicked

        Dim child_cashrec As New CashChecksReceived
        child_cashrec.MdiParent = MDImain

        child_cashrec.TabControl1.SelectedIndex = 0
        child_cashrec.WindowState = FormWindowState.Maximized
        child_cashrec.Show()

    End Sub

    Private Sub LinkLabelChecksReceived_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelChecksReceived.LinkClicked
        Dim child_checkrec As New CashChecksReceived
        child_checkrec.MdiParent = MDImain

        child_checkrec.TabControl1.SelectedIndex = 1
        child_checkrec.WindowState = FormWindowState.Maximized
        child_checkrec.Show()
    End Sub
End Class