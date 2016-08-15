Imports System.Configuration
Imports System.Security.Cryptography
Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim con As New SqlClient.SqlConnection(My.Settings.MBv8LedgerConnectionString)

            Dim cmd As New SqlClient.SqlCommand("SP_VALIDATE_CREDENTIALS", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@USERNAME", SqlDbType.Int)
            cmd.Parameters("@USERNAME").Value = UsernameTextBox.Text
            'cmd.Parameters.Add("@PASSWORD", SqlDbType.Int)
            'cmd.Parameters("@PASSWORD").Value = MD5(PasswordTextBox.Text)
            Dim reader As SqlClient.SqlDataReader

            con.Open()

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While (reader.Read())
                    username = reader("username").ToString
                End While

                reader.Close()
                Dim cmd2 As New SqlClient.SqlCommand("SP_INITIAL_LOAD", con)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandTimeout = 0
                'cmd2.Parameters.Add("@USERNAME", SqlDbType.Int)
                'cmd2.Parameters("@USERNAME").Value = UsernameTextBox.Text
                cmd2.ExecuteNonQuery()
                con.Close()
                MsgBox("Login Success: " + username)

                Dim child_dashboard As New Dashboard

                child_dashboard.MdiParent = MDImain

                child_dashboard.WindowState = FormWindowState.Maximized

                child_dashboard.Show()

                Me.Close()
            Else
                MsgBox("No usuer")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
