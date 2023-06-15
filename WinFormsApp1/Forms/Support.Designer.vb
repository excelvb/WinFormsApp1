<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Support
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
        Label2 = New Label()
        Label3 = New Label()
        TextBoxSupName = New TextBox()
        TextBoxSupEmail = New TextBox()
        TextBoxSupMessage = New TextBox()
        btnSupSend = New FontAwesome.Sharp.IconButton()
        btnSupClear = New FontAwesome.Sharp.IconButton()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(130, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gainsboro
        Label2.Location = New Point(524, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 1
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(130, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 25)
        Label3.TabIndex = 2
        Label3.Text = "Message Details:"
        ' 
        ' TextBoxSupName
        ' 
        TextBoxSupName.Anchor = AnchorStyles.None
        TextBoxSupName.BackColor = Color.WhiteSmoke
        TextBoxSupName.Location = New Point(199, 69)
        TextBoxSupName.Name = "TextBoxSupName"
        TextBoxSupName.Size = New Size(282, 31)
        TextBoxSupName.TabIndex = 3
        ' 
        ' TextBoxSupEmail
        ' 
        TextBoxSupEmail.Anchor = AnchorStyles.None
        TextBoxSupEmail.BackColor = Color.WhiteSmoke
        TextBoxSupEmail.Location = New Point(588, 69)
        TextBoxSupEmail.Name = "TextBoxSupEmail"
        TextBoxSupEmail.Size = New Size(282, 31)
        TextBoxSupEmail.TabIndex = 4
        ' 
        ' TextBoxSupMessage
        ' 
        TextBoxSupMessage.Anchor = AnchorStyles.None
        TextBoxSupMessage.BackColor = Color.WhiteSmoke
        TextBoxSupMessage.Location = New Point(130, 155)
        TextBoxSupMessage.Multiline = True
        TextBoxSupMessage.Name = "TextBoxSupMessage"
        TextBoxSupMessage.Size = New Size(750, 215)
        TextBoxSupMessage.TabIndex = 5
        ' 
        ' btnSupSend
        ' 
        btnSupSend.Anchor = AnchorStyles.None
        btnSupSend.FlatAppearance.BorderColor = Color.Black
        btnSupSend.FlatStyle = FlatStyle.Flat
        btnSupSend.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSupSend.ForeColor = Color.MediumSpringGreen
        btnSupSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        btnSupSend.IconColor = Color.LawnGreen
        btnSupSend.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSupSend.IconSize = 30
        btnSupSend.Location = New Point(588, 387)
        btnSupSend.Name = "btnSupSend"
        btnSupSend.Size = New Size(112, 34)
        btnSupSend.TabIndex = 6
        btnSupSend.Text = "Send"
        btnSupSend.TextAlign = ContentAlignment.TopLeft
        btnSupSend.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSupSend.UseVisualStyleBackColor = True
        ' 
        ' btnSupClear
        ' 
        btnSupClear.Anchor = AnchorStyles.None
        btnSupClear.FlatAppearance.BorderColor = Color.Black
        btnSupClear.FlatStyle = FlatStyle.Flat
        btnSupClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSupClear.ForeColor = Color.IndianRed
        btnSupClear.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        btnSupClear.IconColor = Color.OrangeRed
        btnSupClear.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSupClear.IconSize = 30
        btnSupClear.Location = New Point(719, 387)
        btnSupClear.Name = "btnSupClear"
        btnSupClear.Size = New Size(112, 34)
        btnSupClear.TabIndex = 7
        btnSupClear.Text = "Clear"
        btnSupClear.TextAlign = ContentAlignment.TopLeft
        btnSupClear.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSupClear.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.PaleGreen
        Label4.Location = New Point(21, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 25)
        Label4.TabIndex = 12
        Label4.Text = "Contact Us"
        ' 
        ' Support
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1000, 457)
        Controls.Add(Label4)
        Controls.Add(btnSupClear)
        Controls.Add(btnSupSend)
        Controls.Add(TextBoxSupMessage)
        Controls.Add(TextBoxSupEmail)
        Controls.Add(TextBoxSupName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Support"
        Text = "Support"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSupName As TextBox
    Friend WithEvents TextBoxSupEmail As TextBox
    Friend WithEvents TextBoxSupMessage As TextBox
    Friend WithEvents btnSupSend As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSupClear As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
End Class
