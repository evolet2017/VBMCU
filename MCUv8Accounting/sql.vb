Module sql

#Region "Connection"
    Public con As New SqlClient.SqlConnection
    Public cmd As New SqlClient.SqlCommand
    Public adptr As New SqlClient.SqlDataAdapter
    Public rdr As SqlClient.SqlDataReader
    Public username As String
    Public Mv8rundate As Integer

    Public Sub OpenDB()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = My.Settings.MBv8LedgerConnectionString
            con.Open()

        End If
    End Sub

    Public Sub CloseDB()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
#End Region

#Region "Command"
    Public Sub ExecSP_Reader(ByVal sqlQuery As String)
        OpenDB()

        With cmd
            .CommandText = sqlQuery
            .Connection = con
            .CommandType = CommandType.StoredProcedure
        End With

        rdr = cmd.ExecuteReader()

    End Sub

    Public Sub ExecText_Reader(ByVal sqlQuery As String)
        OpenDB()

        With cmd
            .CommandText = sqlQuery
            .Connection = con
            .CommandType = CommandType.Text
        End With

        rdr = cmd.ExecuteReader()

    End Sub

    Public Sub Close_ExecSP_Reader()
        rdr.Close()
        CloseDB()
    End Sub

    Public Sub ExecSP_Adptr(ByVal sqlQuery As String, ByVal dt As DataTable)
        OpenDB()

        With cmd
            .CommandText = sqlQuery
            .Connection = con
            .CommandType = CommandType.Text
        End With

        With adptr
            .SelectCommand = cmd
            .Fill(dt)
        End With

        CloseDB()
    End Sub

    Public Sub ExecNonQuery(ByVal sqlQuery As String)
        OpenDB()

        With cmd
            .CommandText = sqlQuery
            .CommandType = CommandType.StoredProcedure
            .Connection = con
            .ExecuteNonQuery()
        End With

        CloseDB()
    End Sub

    Public Sub EOD(ByVal sqlQuery As String, ByVal val1 As Decimal, ByVal val2 As Decimal, ByVal val3 As Decimal, ByVal val4 As Decimal, ByVal uptag As Integer)
        OpenDB()

        With cmd
            .CommandText = sqlQuery
            .CommandType = CommandType.StoredProcedure
            With .Parameters
                .Add("@val1", SqlDbType.Decimal).Value = val1
                .Add("@val2", SqlDbType.Decimal).Value = val2
                .Add("@val3", SqlDbType.Decimal).Value = val3
                .Add("@val4", SqlDbType.Decimal).Value = val4
                .Add("@uptag", SqlDbType.Int).Value = uptag
            End With
            .Connection = con
            .ExecuteNonQuery()
        End With

        CloseDB()
    End Sub

    Public Sub EOD2(ByVal sqlQuery2 As String, ByVal val1 As Decimal, ByVal val2 As Decimal, ByVal val3 As Decimal, ByVal val4 As Decimal, ByVal uptag As Integer)
        OpenDB()

        With cmd
            .CommandText = sqlQuery2
            .CommandType = CommandType.StoredProcedure
            With .Parameters
                .Add("@val1", SqlDbType.Decimal).Value = val1
                .Add("@val2", SqlDbType.Decimal).Value = val2
                .Add("@val3", SqlDbType.Decimal).Value = val3
                .Add("@val4", SqlDbType.Decimal).Value = val4
                .Add("@uptag", SqlDbType.Int).Value = uptag
            End With
            .Connection = con
            .ExecuteNonQuery()
        End With

        CloseDB()
    End Sub

    Public Sub EOD3(ByVal sqlQuery3 As String, ByVal val1 As Decimal, ByVal val2 As Decimal, ByVal val3 As Decimal, ByVal val4 As Decimal, ByVal uptag As Integer)
        OpenDB()

        With cmd
            .CommandText = sqlQuery3
            .CommandType = CommandType.StoredProcedure
            With .Parameters
                .Add("@val1", SqlDbType.Decimal).Value = val1
                .Add("@val2", SqlDbType.Decimal).Value = val2
                .Add("@val3", SqlDbType.Decimal).Value = val3
                .Add("@val4", SqlDbType.Decimal).Value = val4
                .Add("@uptag", SqlDbType.Int).Value = uptag
            End With
            .Connection = con
            .ExecuteNonQuery()
        End With

        CloseDB()
    End Sub
#End Region
End Module
