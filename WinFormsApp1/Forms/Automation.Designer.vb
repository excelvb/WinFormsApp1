<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Automation
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
        btnInputPath = New FontAwesome.Sharp.IconButton()
        btnOutpatPath = New FontAwesome.Sharp.IconButton()
        lblInputPath = New Label()
        lblOutputPath = New Label()
        btnAutoRun = New FontAwesome.Sharp.IconButton()
        LabelStartTime = New Label()
        LabelEndTime = New Label()
        LabelDuration = New Label()
        LabelStatusRun = New Label()
        LabelErrorDisc = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnInputPath
        ' 
        btnInputPath.Anchor = AnchorStyles.None
        btnInputPath.FlatAppearance.BorderColor = Color.Black
        btnInputPath.FlatStyle = FlatStyle.Flat
        btnInputPath.IconChar = FontAwesome.Sharp.IconChar.Upload
        btnInputPath.IconColor = Color.Gainsboro
        btnInputPath.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnInputPath.IconSize = 20
        btnInputPath.Location = New Point(721, 105)
        btnInputPath.Name = "btnInputPath"
        btnInputPath.Size = New Size(105, 36)
        btnInputPath.TabIndex = 0
        btnInputPath.Text = "Browse"
        btnInputPath.TextAlign = ContentAlignment.MiddleLeft
        btnInputPath.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInputPath.UseVisualStyleBackColor = True
        ' 
        ' btnOutpatPath
        ' 
        btnOutpatPath.Anchor = AnchorStyles.None
        btnOutpatPath.FlatAppearance.BorderColor = Color.Black
        btnOutpatPath.FlatStyle = FlatStyle.Flat
        btnOutpatPath.IconChar = FontAwesome.Sharp.IconChar.Download
        btnOutpatPath.IconColor = Color.Gainsboro
        btnOutpatPath.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnOutpatPath.IconSize = 20
        btnOutpatPath.Location = New Point(721, 176)
        btnOutpatPath.Name = "btnOutpatPath"
        btnOutpatPath.Size = New Size(105, 36)
        btnOutpatPath.TabIndex = 1
        btnOutpatPath.Text = "Browse"
        btnOutpatPath.TextAlign = ContentAlignment.MiddleLeft
        btnOutpatPath.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOutpatPath.UseVisualStyleBackColor = True
        ' 
        ' lblInputPath
        ' 
        lblInputPath.Anchor = AnchorStyles.None
        lblInputPath.BorderStyle = BorderStyle.FixedSingle
        lblInputPath.ForeColor = Color.Gainsboro
        lblInputPath.Location = New Point(176, 105)
        lblInputPath.Name = "lblInputPath"
        lblInputPath.Size = New Size(539, 36)
        lblInputPath.TabIndex = 2
        lblInputPath.Text = "Input Path:"
        lblInputPath.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblOutputPath
        ' 
        lblOutputPath.Anchor = AnchorStyles.None
        lblOutputPath.BorderStyle = BorderStyle.FixedSingle
        lblOutputPath.ForeColor = Color.Gainsboro
        lblOutputPath.Location = New Point(176, 176)
        lblOutputPath.Name = "lblOutputPath"
        lblOutputPath.Size = New Size(539, 36)
        lblOutputPath.TabIndex = 3
        lblOutputPath.Text = "Output Path:"
        lblOutputPath.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnAutoRun
        ' 
        btnAutoRun.Anchor = AnchorStyles.None
        btnAutoRun.BackColor = Color.DodgerBlue
        btnAutoRun.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnAutoRun.FlatAppearance.BorderSize = 2
        btnAutoRun.FlatStyle = FlatStyle.Flat
        btnAutoRun.IconChar = FontAwesome.Sharp.IconChar.Robot
        btnAutoRun.IconColor = Color.Black
        btnAutoRun.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAutoRun.IconSize = 28
        btnAutoRun.Location = New Point(690, 270)
        btnAutoRun.Name = "btnAutoRun"
        btnAutoRun.Size = New Size(136, 40)
        btnAutoRun.TabIndex = 4
        btnAutoRun.Text = "Run"
        btnAutoRun.TextAlign = ContentAlignment.MiddleLeft
        btnAutoRun.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAutoRun.UseVisualStyleBackColor = False
        ' 
        ' LabelStartTime
        ' 
        LabelStartTime.Anchor = AnchorStyles.None
        LabelStartTime.FlatStyle = FlatStyle.Flat
        LabelStartTime.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LabelStartTime.ForeColor = Color.Gainsboro
        LabelStartTime.Location = New Point(176, 358)
        LabelStartTime.Name = "LabelStartTime"
        LabelStartTime.Size = New Size(180, 22)
        LabelStartTime.TabIndex = 5
        LabelStartTime.Text = "Start Time:"
        LabelStartTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelEndTime
        ' 
        LabelEndTime.Anchor = AnchorStyles.None
        LabelEndTime.FlatStyle = FlatStyle.Flat
        LabelEndTime.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LabelEndTime.ForeColor = Color.Gainsboro
        LabelEndTime.Location = New Point(390, 358)
        LabelEndTime.Name = "LabelEndTime"
        LabelEndTime.Size = New Size(180, 22)
        LabelEndTime.TabIndex = 6
        LabelEndTime.Text = "End Time:"
        LabelEndTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelDuration
        ' 
        LabelDuration.Anchor = AnchorStyles.None
        LabelDuration.FlatStyle = FlatStyle.Flat
        LabelDuration.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDuration.ForeColor = Color.Gainsboro
        LabelDuration.Location = New Point(613, 358)
        LabelDuration.Name = "LabelDuration"
        LabelDuration.Size = New Size(180, 22)
        LabelDuration.TabIndex = 7
        LabelDuration.Text = "Duration:"
        LabelDuration.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelStatusRun
        ' 
        LabelStatusRun.Anchor = AnchorStyles.None
        LabelStatusRun.FlatStyle = FlatStyle.Flat
        LabelStatusRun.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LabelStatusRun.ForeColor = Color.Gainsboro
        LabelStatusRun.Location = New Point(176, 392)
        LabelStatusRun.Name = "LabelStatusRun"
        LabelStatusRun.Size = New Size(180, 22)
        LabelStatusRun.TabIndex = 8
        LabelStatusRun.Text = "Status:"
        LabelStatusRun.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelErrorDisc
        ' 
        LabelErrorDisc.Anchor = AnchorStyles.None
        LabelErrorDisc.FlatStyle = FlatStyle.Flat
        LabelErrorDisc.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LabelErrorDisc.ForeColor = Color.Gainsboro
        LabelErrorDisc.Location = New Point(390, 392)
        LabelErrorDisc.Name = "LabelErrorDisc"
        LabelErrorDisc.Size = New Size(180, 22)
        LabelErrorDisc.TabIndex = 9
        LabelErrorDisc.Text = "Error Disc:"
        LabelErrorDisc.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.PaleGreen
        Label1.Location = New Point(35, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 25)
        Label1.TabIndex = 10
        Label1.Text = "Automation Project"
        ' 
        ' Automation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1000, 457)
        Controls.Add(Label1)
        Controls.Add(LabelErrorDisc)
        Controls.Add(LabelStatusRun)
        Controls.Add(LabelDuration)
        Controls.Add(LabelEndTime)
        Controls.Add(LabelStartTime)
        Controls.Add(btnAutoRun)
        Controls.Add(lblOutputPath)
        Controls.Add(lblInputPath)
        Controls.Add(btnOutpatPath)
        Controls.Add(btnInputPath)
        Name = "Automation"
        Text = "Automation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInputPath As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOutpatPath As FontAwesome.Sharp.IconButton
    Friend WithEvents lblInputPath As Label
    Friend WithEvents lblOutputPath As Label
    Friend WithEvents btnAutoRun As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelStartTime As Label
    Friend WithEvents LabelEndTime As Label
    Friend WithEvents LabelDuration As Label
    Friend WithEvents LabelStatusRun As Label
    Friend WithEvents LabelErrorDisc As Label
    Friend WithEvents Label1 As Label
End Class
