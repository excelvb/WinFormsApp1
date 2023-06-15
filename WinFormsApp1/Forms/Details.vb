Imports MySql.Data.MySqlClient

Public Class Details
    Dim cn As MySqlConnection
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        Try
            With cn
                .ConnectionString = "server=db4free.net;port=3306;user id=excelvb;password=01@Dec2019;database=excelvblog;Connect Timeout=10000000;pooling=true;old guids=true"
                .Open()
                .Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "Enable to connect Database, Please contact Admin!")
            cn.Close()
        End Try
        Loadrecords(10) 'To display only 5 records
    End Sub

    Sub Loadrecords(fltr)
        'fltr = 1 for All, 2 for Completed, 3 for Error, 10 for 10 Records
        DataGridView1.Rows.Clear()
        Try
            Dim i As Integer
            cn.Open()
            'If fltr = 5 Then cm = New MySqlCommand("SELECT * FROM tblexcellog", cn)
            If fltr = 1 Then cm = New MySqlCommand("SELECT * FROM tblexcellog ORDER BY date DESC, start_time DESC", cn)
            If fltr = 2 Then cm = New MySqlCommand("SELECT * FROM tblexcellog WHERE status = 'Completed' ORDER BY date DESC, start_time DESC LIMIT 10", cn)
            If fltr = 3 Then cm = New MySqlCommand("SELECT * FROM tblexcellog WHERE status = 'Error' ORDER BY date DESC, start_time DESC LIMIT 10", cn)
            If fltr = 10 Then cm = New MySqlCommand("SELECT * FROM tblexcellog ORDER BY date DESC, start_time DESC LIMIT 10", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("date").ToString, dr.Item("automation_project").ToString, dr.Item("user_name").ToString, dr.Item("start_time").ToString, dr.Item("end_time").ToString, dr.Item("duration").ToString, dr.Item("status").ToString, dr.Item("error_description").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Enable to connect Database, Please contact Admin!")
        End Try
    End Sub

    Private Sub btnStatusCompleted_Click(sender As Object, e As EventArgs) Handles btnStatusCompleted.Click
        Loadrecords(2) 'To display status completed records
    End Sub

    Private Sub btnStatusError_Click(sender As Object, e As EventArgs) Handles btnStatusError.Click
        Loadrecords(3) 'To display status Error records
    End Sub

End Class