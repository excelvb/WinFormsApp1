Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Reflection

Public Class Automation
    'Variables
    Private startTime As DateTime
    Private endTime As DateTime

    Dim cn As MySqlConnection
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader

    Dim inputpath As String
    Dim outputpath As String
    Dim folderPicker As New FolderBrowserDialog()

    'Input Folder Path Selection
    Private Sub btnInputPath_Click(sender As Object, e As EventArgs) Handles btnInputPath.Click
        With folderPicker
            .Description = "Select Input Folder"
            .ShowNewFolderButton = False
            If .ShowDialog() <> DialogResult.OK Then GoTo NextCode
            inputpath = folderPicker.SelectedPath & "\"
        End With
        lblInputPath.Text = "Input Path: " & inputpath
NextCode:
        If inputpath = "" Then
            MessageBox.Show("Please Select a Folder Path")
        End If
    End Sub

    'Output Folder Path Selection
    Private Sub btnOutpatPath_Click(sender As Object, e As EventArgs) Handles btnOutpatPath.Click
        With folderPicker
            .Description = "Select Output Folder"
            .ShowNewFolderButton = False
            If .ShowDialog() <> DialogResult.OK Then GoTo NextCode
            outputpath = folderPicker.SelectedPath & "\"
        End With
        lblOutputPath.Text = "Output Path: " & outputpath
NextCode:
        If outputpath = "" Then
            MessageBox.Show("Please Select a Folder Path")
        End If
    End Sub

    'Automation Run button to do the Task
    Private Sub btnAutoRun_Click(sender As Object, e As EventArgs) Handles btnAutoRun.Click

        ' Get the current date
        Dim currentDate As DateTime = DateTime.Now.Date

        ' Get the start time
        startTime = DateTime.Now

        ' Get the user name
        Dim userName As String = Environment.UserName
        'Automation Project Name
        Dim runauto_pj As String = "P_Name_test_1"

        Try
            ' Your automation code here
            '_____________________________________________________________________________________

            Dim xlApp As New Excel.Application()
            Dim wb As Workbook
            Dim ws As Worksheet
            wb = xlApp.Workbooks.Add
            ws = wb.Sheets(1)
            ws.Range("A1").Value = "Hello!"

            xlApp.Visible = True
            wb = Nothing
            ws = Nothing
            xlApp = Nothing

            ' If the automation completes successfully
            Dim status As String = "Completed"
            Dim errorDescription As String = ""

            '_____________________________________________________________________________________
            ' Get the end time
            endTime = DateTime.Now

            ' Calculate the duration
            Dim duration As TimeSpan = endTime - startTime
            ' Format the duration as "HH.MM.SS"
            Dim fmtDuration As String = $"{CInt(duration.TotalHours):00}.{duration.Minutes:00}.{duration.Seconds:00}"

            ' Output the results
            Dim rundate As String = currentDate.ToString("yyyy-MM-dd")

            Dim runStartTime As String = startTime.ToString("HH:mm:ss")
            LabelStartTime.Text = ("Start Time: " & startTime.ToString("HH:mm:ss"))

            Dim runEndTime As String = endTime.ToString("HH:mm:ss")
            LabelEndTime.Text = ("End Time: " & endTime.ToString("HH:mm:ss"))

            Dim runDuration As String = fmtDuration
            LabelDuration.Text = ("Duration: " & fmtDuration)

            Dim runUserName = userName
            'txtOutput.AppendText("User Name: " & userName)

            Dim runStatus As String = status
            LabelStatusRun.Text = ("Status: " & status)

            Dim runErrorDisc As String = errorDescription
            LabelErrorDisc.Text = ("Error Description: " & errorDescription)

            'SQL__________________
            Sq_dbadd(rundate, runauto_pj, runUserName, runStartTime, runEndTime, runDuration, runStatus, runErrorDisc)

        Catch ex As Exception
            ' If an error occurs
            Dim status As String = "Error"
            Dim errorDescription As String = ex.Message

            ' Get the end time
            endTime = DateTime.Now

            ' Calculate the duration
            Dim duration As TimeSpan = endTime - startTime
            ' Format the duration as "HH.MM.SS"
            Dim fmtDuration As String = $"{CInt(duration.TotalHours):00}.{duration.Minutes:00}.{duration.Seconds:00}"

            ' Output the results
            Dim rundate As String = currentDate.ToString("yyyy-MM-dd")

            Dim runStartTime As String = startTime.ToString("HH:mm:ss")
            LabelStartTime.Text = ("Start Time: " & startTime.ToString("HH:mm:ss"))

            Dim runEndTime As String = endTime.ToString("HH:mm:ss")
            LabelEndTime.Text = ("End Time: " & endTime.ToString("HH:mm:ss"))

            Dim runDuration As String = fmtDuration
            LabelDuration.Text = ("Duration: " & fmtDuration)

            Dim runUserName = userName
            'txtOutput.AppendText("User Name: " & userName)

            Dim runStatus As String = status
            LabelStatusRun.Text = ("Status: " & status)

            Dim runErrorDisc As String = errorDescription
            LabelErrorDisc.Text = ("Error Description: " & errorDescription)

            'SQL__________________
            Sq_dbadd(rundate, runauto_pj, runUserName, runStartTime, runEndTime, runDuration, runStatus, runErrorDisc)

        End Try

    End Sub

    'SQL Database connect
    'Add data
    Public Sub Sq_dbadd(rdate, rauto_p, ruser_n, rstart_t, rend_t, rdurat, rstatus, rerror_disc)
        Try
            cn.Open()
            cm = New MySqlCommand("INSERT INTO tblexcellog (date, automation_project, user_name, start_time, end_time, duration, status, error_description)values('" & rdate & "','" & rauto_p & "','" & ruser_n & "','" & rstart_t & "','" & rend_t & "','" & rdurat & "','" & rstatus & "','" & rerror_disc & "')", cn)
            cm.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Automation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        Try
            With cn
                .ConnectionString = "server=db4free.net;port=3306;user id=excelvb;password=01@Dec2019;database=excelvblog;Connect Timeout=10000000;pooling=true;old guids=true"
                .Open()
                .Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "Enable to connect to Database, Please contact Admin!")
            cn.Close()
        End Try
    End Sub
End Class