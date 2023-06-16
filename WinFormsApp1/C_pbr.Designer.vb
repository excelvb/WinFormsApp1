<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_pbr
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
        components = New ComponentModel.Container()
        TimerR = New Timer(components)
        TimerG = New Timer(components)
        TimerB = New Timer(components)
        Timer4 = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TimerR
        ' 
        TimerR.Enabled = True
        TimerR.Interval = 20
        ' 
        ' TimerG
        ' 
        TimerG.Enabled = True
        TimerG.Interval = 10
        ' 
        ' TimerB
        ' 
        TimerB.Enabled = True
        TimerB.Interval = 10
        ' 
        ' Timer4
        ' 
        Timer4.Enabled = True
        Timer4.Interval = 1000
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources._585d0331234507_564a1d239ac5e
        PictureBox1.Location = New Point(364, 177)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(242, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' C_pbr
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1000, 457)
        Controls.Add(PictureBox1)
        Name = "C_pbr"
        Text = "C_pbr"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TimerR As Timer
    Friend WithEvents TimerG As Timer
    Friend WithEvents TimerB As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
