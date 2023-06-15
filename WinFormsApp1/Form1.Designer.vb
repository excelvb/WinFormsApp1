<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelMenu = New Panel()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        imgHome = New PictureBox()
        PanelTitleBar = New Panel()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        LabelUser = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelMenu.Controls.Add(IconButton4)
        PanelMenu.Controls.Add(IconButton3)
        PanelMenu.Controls.Add(IconButton2)
        PanelMenu.Controls.Add(IconButton1)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 644)
        PanelMenu.TabIndex = 0
        ' 
        ' IconButton4
        ' 
        IconButton4.Dock = DockStyle.Top
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.ForeColor = Color.Gainsboro
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        IconButton4.IconColor = Color.Gainsboro
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 32
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(0, 320)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New Padding(20, 0, 0, 0)
        IconButton4.Size = New Size(220, 60)
        IconButton4.TabIndex = 4
        IconButton4.Text = "Support"
        IconButton4.TextAlign = ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = True
        ' 
        ' IconButton3
        ' 
        IconButton3.Dock = DockStyle.Top
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.ForeColor = Color.Gainsboro
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.Whmcs
        IconButton3.IconColor = Color.Gainsboro
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.IconSize = 32
        IconButton3.ImageAlign = ContentAlignment.MiddleLeft
        IconButton3.Location = New Point(0, 260)
        IconButton3.Name = "IconButton3"
        IconButton3.Padding = New Padding(20, 0, 0, 0)
        IconButton3.Size = New Size(220, 60)
        IconButton3.TabIndex = 3
        IconButton3.Text = "Details"
        IconButton3.TextAlign = ContentAlignment.MiddleLeft
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.Dock = DockStyle.Top
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.ForeColor = Color.Gainsboro
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.Robot
        IconButton2.IconColor = Color.Gainsboro
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 32
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(0, 200)
        IconButton2.Name = "IconButton2"
        IconButton2.Padding = New Padding(20, 0, 0, 0)
        IconButton2.Size = New Size(220, 60)
        IconButton2.TabIndex = 2
        IconButton2.Text = "Automation"
        IconButton2.TextAlign = ContentAlignment.MiddleLeft
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Top
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = Color.Gainsboro
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(0, 140)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(20, 0, 0, 0)
        IconButton1.Size = New Size(220, 60)
        IconButton1.TabIndex = 1
        IconButton1.Text = "Info"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(imgHome)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(220, 140)
        PanelLogo.TabIndex = 1
        ' 
        ' imgHome
        ' 
        imgHome.Image = My.Resources.Resources.pngtree_cute_robot_mascot_logo_png_image_8493119_removebg_preview
        imgHome.Location = New Point(36, 10)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(150, 120)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 1
        imgHome.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PanelTitleBar.Controls.Add(IconButton7)
        PanelTitleBar.Controls.Add(IconButton6)
        PanelTitleBar.Controls.Add(IconButton5)
        PanelTitleBar.Controls.Add(lblFormTitle)
        PanelTitleBar.Controls.Add(IconCurrentForm)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(220, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(1044, 75)
        PanelTitleBar.TabIndex = 1
        ' 
        ' IconButton7
        ' 
        IconButton7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconButton7.FlatAppearance.BorderColor = Color.White
        IconButton7.FlatAppearance.BorderSize = 0
        IconButton7.FlatAppearance.MouseOverBackColor = Color.Silver
        IconButton7.FlatStyle = FlatStyle.Flat
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.Xmark
        IconButton7.IconColor = Color.Red
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.IconSize = 15
        IconButton7.Location = New Point(1022, 12)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(15, 15)
        IconButton7.TabIndex = 4
        IconButton7.UseVisualStyleBackColor = True
        ' 
        ' IconButton6
        ' 
        IconButton6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconButton6.FlatAppearance.BorderColor = Color.White
        IconButton6.FlatAppearance.BorderSize = 0
        IconButton6.FlatAppearance.MouseOverBackColor = Color.Silver
        IconButton6.FlatStyle = FlatStyle.Flat
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        IconButton6.IconColor = Color.Red
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.IconSize = 15
        IconButton6.Location = New Point(1001, 12)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(15, 15)
        IconButton6.TabIndex = 3
        IconButton6.UseVisualStyleBackColor = True
        ' 
        ' IconButton5
        ' 
        IconButton5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconButton5.FlatAppearance.BorderColor = Color.White
        IconButton5.FlatAppearance.BorderSize = 0
        IconButton5.FlatAppearance.MouseOverBackColor = Color.Silver
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IconButton5.IconColor = Color.Red
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.IconSize = 15
        IconButton5.Location = New Point(980, 12)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(15, 15)
        IconButton5.TabIndex = 2
        IconButton5.UseVisualStyleBackColor = True
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.ForeColor = Color.MediumPurple
        lblFormTitle.Location = New Point(53, 26)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(61, 25)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        IconCurrentForm.ForeColor = Color.MediumPurple
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        IconCurrentForm.IconColor = Color.MediumPurple
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.IconSize = 35
        IconCurrentForm.Location = New Point(18, 21)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(35, 35)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        PanelDesktop.Controls.Add(LabelUser)
        PanelDesktop.Controls.Add(Label2)
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(220, 75)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(1044, 569)
        PanelDesktop.TabIndex = 2
        ' 
        ' LabelUser
        ' 
        LabelUser.Anchor = AnchorStyles.None
        LabelUser.AutoSize = True
        LabelUser.Location = New Point(373, 391)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(84, 25)
        LabelUser.TabIndex = 3
        LabelUser.Text = "Test_User"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(373, 297)
        Label2.Name = "Label2"
        Label2.Size = New Size(295, 81)
        Label2.TabIndex = 2
        Label2.Text = "Welcome"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.pngtree_cute_robot_mascot_logo_png_image_8493119_removebg_preview
        PictureBox1.Location = New Point(424, 144)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(192, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 644)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        ForeColor = Color.Gainsboro
        MinimumSize = New Size(1264, 644)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        PanelDesktop.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelUser As Label
End Class
