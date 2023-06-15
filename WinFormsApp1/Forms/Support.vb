Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop

Public Class Support
    Private Sub btnSupSend_Click(sender As Object, e As EventArgs) Handles btnSupSend.Click
        Dim outApp As New Outlook.Application
        Dim Supemail As String = TextBoxSupEmail.Text
        Dim Supname As String = TextBoxSupName.Text
        Dim Supmessage As String = TextBoxSupMessage.Text

        ' Check if name textbox is blank
        If String.IsNullOrWhiteSpace(Supname) Then
            MessageBox.Show("Name cannot be blank!")
            Exit Sub
        End If

        ' Check if Email is blank or has invalid format
        If Not IsEmailFormat(Supemail) Then
            MessageBox.Show("Invalid email format!")
            Exit Sub
        End If

        ' Check if message textbox is blank or has less than 10 words
        If String.IsNullOrWhiteSpace(Supmessage) OrElse Supmessage.Split(" "c, StringSplitOptions.RemoveEmptyEntries).Length < 10 Then
            MessageBox.Show("Message should contain at least 10 words!")
            Exit Sub
        End If

        Dim mailItem As Outlook.MailItem = DirectCast(outApp.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)

        ' Set up the email details
        mailItem.Subject = "Project Name Issue Request Logged"
        mailItem.Body = Supmessage
        mailItem.To = "dheerajrajaputhran@outlook.com"

        ' Send the email
        mailItem.Send()

        ' Release the Outlook objects
        System.Runtime.InteropServices.Marshal.ReleaseComObject(mailItem)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(outApp)

        ' Display a message after the email is sent
        MessageBox.Show("Email sent successfully!")

        ClearTextBoxes()
    End Sub

    ' Clear the Text box fields
    Private Sub ClearTextBoxes()
        TextBoxSupName.Clear()
        TextBoxSupEmail.Clear()
        TextBoxSupMessage.Clear()
    End Sub

    Private Function IsEmailFormat(email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(emailPattern)

        Return regex.IsMatch(email)
    End Function

    Private Sub btnSupClear_Click(sender As Object, e As EventArgs) Handles btnSupClear.Click
        ClearTextBoxes()
    End Sub
End Class
