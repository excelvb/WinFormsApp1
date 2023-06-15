<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        btnStatusCompleted = New FontAwesome.Sharp.IconButton()
        btnStatusError = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.InfoText
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.BackgroundColor = SystemColors.MenuHighlight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.MidnightBlue
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.InactiveBorder
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 34
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.GridColor = SystemColors.MenuHighlight
        DataGridView1.Location = New Point(26, 96)
        DataGridView1.Margin = New Padding(1)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.InactiveBorder
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 50
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(951, 338)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 196.926651F
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 4
        Column1.Name = "Column1"
        Column1.Width = 30
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 62.0319F
        Column2.HeaderText = "Date"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 95
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 62.0319F
        Column3.HeaderText = "Automation_Project"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 160
        ' 
        ' Column4
        ' 
        Column4.FillWeight = 62.0319F
        Column4.HeaderText = "User_Name"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 130
        ' 
        ' Column5
        ' 
        Column5.FillWeight = 62.0319F
        Column5.HeaderText = "Start_Time"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 95
        ' 
        ' Column6
        ' 
        Column6.FillWeight = 62.0319F
        Column6.HeaderText = "End_Time"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 95
        ' 
        ' Column7
        ' 
        Column7.FillWeight = 62.0319F
        Column7.HeaderText = "Duration"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 80
        ' 
        ' Column8
        ' 
        Column8.FillWeight = 62.0319F
        Column8.HeaderText = "Status"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.Width = 95
        ' 
        ' Column9
        ' 
        Column9.FillWeight = 62.0319F
        Column9.HeaderText = "Error_Description"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.Width = 140
        ' 
        ' btnStatusCompleted
        ' 
        btnStatusCompleted.Anchor = AnchorStyles.None
        btnStatusCompleted.BackColor = Color.Aquamarine
        btnStatusCompleted.BackgroundImageLayout = ImageLayout.None
        btnStatusCompleted.FlatStyle = FlatStyle.Flat
        btnStatusCompleted.ForeColor = SystemColors.ActiveCaptionText
        btnStatusCompleted.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        btnStatusCompleted.IconColor = Color.Black
        btnStatusCompleted.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnStatusCompleted.IconSize = 32
        btnStatusCompleted.ImageAlign = ContentAlignment.TopLeft
        btnStatusCompleted.Location = New Point(636, 43)
        btnStatusCompleted.Name = "btnStatusCompleted"
        btnStatusCompleted.Size = New Size(147, 38)
        btnStatusCompleted.TabIndex = 1
        btnStatusCompleted.Text = "Completed"
        btnStatusCompleted.TextAlign = ContentAlignment.TopLeft
        btnStatusCompleted.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStatusCompleted.UseVisualStyleBackColor = False
        ' 
        ' btnStatusError
        ' 
        btnStatusError.Anchor = AnchorStyles.None
        btnStatusError.BackColor = Color.OrangeRed
        btnStatusError.BackgroundImageLayout = ImageLayout.None
        btnStatusError.FlatStyle = FlatStyle.Flat
        btnStatusError.ForeColor = SystemColors.ActiveCaptionText
        btnStatusError.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        btnStatusError.IconColor = Color.Black
        btnStatusError.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnStatusError.IconSize = 32
        btnStatusError.ImageAlign = ContentAlignment.TopLeft
        btnStatusError.Location = New Point(805, 43)
        btnStatusError.Name = "btnStatusError"
        btnStatusError.Size = New Size(147, 38)
        btnStatusError.TabIndex = 2
        btnStatusError.Text = "Error"
        btnStatusError.TextAlign = ContentAlignment.TopLeft
        btnStatusError.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStatusError.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.PaleGreen
        Label1.Location = New Point(26, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 25)
        Label1.TabIndex = 11
        Label1.Text = "Automation Logs"
        ' 
        ' Details
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1000, 457)
        Controls.Add(Label1)
        Controls.Add(btnStatusError)
        Controls.Add(btnStatusCompleted)
        Controls.Add(DataGridView1)
        Name = "Details"
        Text = "Details"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnStatusCompleted As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStatusError As FontAwesome.Sharp.IconButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
