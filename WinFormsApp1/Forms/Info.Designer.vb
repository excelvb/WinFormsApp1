<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.PaleGreen
        Label1.Location = New Point(26, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 25)
        Label1.TabIndex = 11
        Label1.Text = "Application Information"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.ForeColor = Color.Gainsboro
        RichTextBox1.Location = New Point(59, 74)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(879, 324)
        RichTextBox1.TabIndex = 12
        RichTextBox1.Text = "Info :" & vbLf & "Do :" & vbLf & "Donts :" & vbLf & "Steps :" & vbLf & "Process :" & vbLf & "Outcome :" & vbLf & "If Error :" & vbLf & "Support process :"
        ' 
        ' Info
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1000, 457)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Name = "Info"
        Text = "Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
