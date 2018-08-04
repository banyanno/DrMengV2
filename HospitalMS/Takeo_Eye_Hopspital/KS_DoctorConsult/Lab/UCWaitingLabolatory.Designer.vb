<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCWaitingLabolatory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridPatientWaiting_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCWaitingLabolatory))
        Dim GridLaboDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewLabo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnComplete = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridPatientWaiting = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridLaboDetail = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtPatientTel = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtFPatientNo = New System.Windows.Forms.TextBox
        Me.RadPTel = New System.Windows.Forms.RadioButton
        Me.RadPName = New System.Windows.Forms.RadioButton
        Me.RadPNo = New System.Windows.Forms.RadioButton
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridPatientWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridLaboDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator1, Me.BtnNewLabo, Me.ToolStripSeparator3, Me.BtnComplete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1593, 42)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "Refresh"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Image = Global.HospitalMS.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(164, 39)
        Me.BtnRefresh.Text = " Refresh Waiting"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'BtnNewLabo
        '
        Me.BtnNewLabo.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewLabo.Image = Global.HospitalMS.My.Resources.Resources._1422017622_Terms_rev_5121
        Me.BtnNewLabo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewLabo.Name = "BtnNewLabo"
        Me.BtnNewLabo.Size = New System.Drawing.Size(132, 39)
        Me.BtnNewLabo.Text = "Enter Result"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 42)
        '
        'BtnComplete
        '
        Me.BtnComplete.ForeColor = System.Drawing.Color.Blue
        Me.BtnComplete.Image = Global.HospitalMS.My.Resources.Resources._1439492586_unit_completed
        Me.BtnComplete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(145, 39)
        Me.BtnComplete.Text = "Complete Lab"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1593, 824)
        Me.SplitContainer1.SplitterDistance = 1057
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1057, 824)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of patient labo check"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 22)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridPatientWaiting)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1051, 799)
        Me.SplitContainer2.SplitterDistance = 375
        Me.SplitContainer2.TabIndex = 10
        '
        'GridPatientWaiting
        '
        Me.GridPatientWaiting.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPatientWaiting.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridPatientWaiting.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridPatientWaiting_DesignTimeLayout.LayoutString = resources.GetString("GridPatientWaiting_DesignTimeLayout.LayoutString")
        Me.GridPatientWaiting.DesignTimeLayout = GridPatientWaiting_DesignTimeLayout
        Me.GridPatientWaiting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientWaiting.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridPatientWaiting.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridPatientWaiting.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridPatientWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientWaiting.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPatientWaiting.GroupByBoxVisible = False
        Me.GridPatientWaiting.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GridPatientWaiting.HeaderFormatStyle.FontSize = 14.0!
        Me.GridPatientWaiting.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridPatientWaiting.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientWaiting.Location = New System.Drawing.Point(0, 0)
        Me.GridPatientWaiting.Name = "GridPatientWaiting"
        Me.GridPatientWaiting.RecordNavigator = True
        Me.GridPatientWaiting.RowFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.RowHeaderFormatStyle.FontSize = 13.0!
        Me.GridPatientWaiting.SelectedFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridPatientWaiting.SelectedFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.FontSize = 12.0!
        Me.GridPatientWaiting.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridPatientWaiting.Size = New System.Drawing.Size(1051, 375)
        Me.GridPatientWaiting.TabIndex = 7
        Me.GridPatientWaiting.TableHeaderFormatStyle.FontSize = 13.0!
        Me.GridPatientWaiting.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridLaboDetail)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1051, 420)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check List"
        '
        'GridLaboDetail
        '
        Me.GridLaboDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridLaboDetail.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridLaboDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridLaboDetail_DesignTimeLayout.LayoutString = resources.GetString("GridLaboDetail_DesignTimeLayout.LayoutString")
        Me.GridLaboDetail.DesignTimeLayout = GridLaboDetail_DesignTimeLayout
        Me.GridLaboDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLaboDetail.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridLaboDetail.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridLaboDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLaboDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridLaboDetail.GroupByBoxVisible = False
        Me.GridLaboDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridLaboDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridLaboDetail.Location = New System.Drawing.Point(3, 22)
        Me.GridLaboDetail.Name = "GridLaboDetail"
        Me.GridLaboDetail.RecordNavigator = True
        Me.GridLaboDetail.RowFormatStyle.FontSize = 12.0!
        Me.GridLaboDetail.SelectedFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridLaboDetail.SelectedFormatStyle.FontSize = 12.0!
        Me.GridLaboDetail.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridLaboDetail.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridLaboDetail.SelectedInactiveFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridLaboDetail.SelectedInactiveFormatStyle.FontSize = 12.0!
        Me.GridLaboDetail.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridLaboDetail.Size = New System.Drawing.Size(1045, 395)
        Me.GridLaboDetail.TabIndex = 8
        Me.GridLaboDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer3.Size = New System.Drawing.Size(532, 824)
        Me.SplitContainer3.SplitterDistance = 412
        Me.SplitContainer3.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(532, 412)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnFind)
        Me.GroupBox3.Controls.Add(Me.TxtPatientTel)
        Me.GroupBox3.Controls.Add(Me.TxtPatientName)
        Me.GroupBox3.Controls.Add(Me.TxtFPatientNo)
        Me.GroupBox3.Controls.Add(Me.RadPTel)
        Me.GroupBox3.Controls.Add(Me.RadPName)
        Me.GroupBox3.Controls.Add(Me.RadPNo)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(532, 408)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Find History Labo By"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Location = New System.Drawing.Point(258, 142)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(111, 34)
        Me.BtnFind.TabIndex = 6
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtPatientTel
        '
        Me.TxtPatientTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientTel.Enabled = False
        Me.TxtPatientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientTel.Location = New System.Drawing.Point(142, 104)
        Me.TxtPatientTel.Name = "TxtPatientTel"
        Me.TxtPatientTel.Size = New System.Drawing.Size(227, 29)
        Me.TxtPatientTel.TabIndex = 5
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(142, 66)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(227, 29)
        Me.TxtPatientName.TabIndex = 4
        '
        'TxtFPatientNo
        '
        Me.TxtFPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFPatientNo.Location = New System.Drawing.Point(142, 28)
        Me.TxtFPatientNo.Name = "TxtFPatientNo"
        Me.TxtFPatientNo.Size = New System.Drawing.Size(227, 29)
        Me.TxtFPatientNo.TabIndex = 3
        '
        'RadPTel
        '
        Me.RadPTel.AutoSize = True
        Me.RadPTel.Location = New System.Drawing.Point(9, 109)
        Me.RadPTel.Name = "RadPTel"
        Me.RadPTel.Size = New System.Drawing.Size(106, 24)
        Me.RadPTel.TabIndex = 2
        Me.RadPTel.Text = "Patient Tel:"
        Me.RadPTel.UseVisualStyleBackColor = True
        '
        'RadPName
        '
        Me.RadPName.AutoSize = True
        Me.RadPName.Location = New System.Drawing.Point(9, 71)
        Me.RadPName.Name = "RadPName"
        Me.RadPName.Size = New System.Drawing.Size(127, 24)
        Me.RadPName.TabIndex = 1
        Me.RadPName.Text = "Patient Name:"
        Me.RadPName.UseVisualStyleBackColor = True
        '
        'RadPNo
        '
        Me.RadPNo.AutoSize = True
        Me.RadPNo.Checked = True
        Me.RadPNo.Location = New System.Drawing.Point(9, 33)
        Me.RadPNo.Name = "RadPNo"
        Me.RadPNo.Size = New System.Drawing.Size(105, 24)
        Me.RadPNo.TabIndex = 0
        Me.RadPNo.TabStop = True
        Me.RadPNo.Text = "Patient No:"
        Me.RadPNo.UseVisualStyleBackColor = True
        '
        'UCWaitingLabolatory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UCWaitingLabolatory"
        Me.Size = New System.Drawing.Size(1593, 866)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridPatientWaiting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridLaboDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnComplete As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPatientWaiting As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridLaboDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewLabo As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadPTel As System.Windows.Forms.RadioButton
    Friend WithEvents RadPName As System.Windows.Forms.RadioButton
    Friend WithEvents RadPNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtPatientTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtFPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer

End Class
