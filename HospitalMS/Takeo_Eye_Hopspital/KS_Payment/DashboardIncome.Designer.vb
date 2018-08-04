<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardIncome))
        Dim GridIncome_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridService_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPrescription_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintlabel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSurgery = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.GridIncome = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridService = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridPrescription = New Janus.Windows.GridEX.GridEX
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CboDoctor1 = New System.Windows.Forms.ComboBox
        Me.ChReport = New System.Windows.Forms.CheckBox
        Me.btnView = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintPreview, Me.ToolStripSeparator1, Me.BtnPrintlabel, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.BtnSurgery})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1253, 62)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintPreview.Image = Global.HospitalMS.My.Resources.Resources.printer
        Me.BtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(226, 59)
        Me.BtnPrintPreview.Text = "     Print Invoice / Prescription   "
        Me.BtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 62)
        '
        'BtnPrintlabel
        '
        Me.BtnPrintlabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintlabel.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintlabel.Image = Global.HospitalMS.My.Resources.Resources._1422017622_Terms_rev_512
        Me.BtnPrintlabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintlabel.Name = "BtnPrintlabel"
        Me.BtnPrintlabel.Size = New System.Drawing.Size(126, 59)
        Me.BtnPrintlabel.Text = "        Print Label         "
        Me.BtnPrintlabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 62)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.HospitalMS.My.Resources.Resources.Receipt_oop
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(169, 59)
        Me.ToolStripButton1.Text = "Print Preview In-Come         "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 62)
        '
        'BtnSurgery
        '
        Me.BtnSurgery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnSurgery.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnSurgery.ForeColor = System.Drawing.Color.Blue
        Me.BtnSurgery.Image = CType(resources.GetObject("BtnSurgery.Image"), System.Drawing.Image)
        Me.BtnSurgery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSurgery.Name = "BtnSurgery"
        Me.BtnSurgery.Size = New System.Drawing.Size(176, 59)
        Me.BtnSurgery.Text = " Report   Dr. Surgery     "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 62)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CboDoctor1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1253, 534)
        Me.SplitContainer1.SplitterDistance = 1026
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.AxAcroPDF1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridIncome)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 532)
        Me.SplitContainer2.SplitterDistance = 326
        Me.SplitContainer2.TabIndex = 2
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(842, 160)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(192, 192)
        Me.AxAcroPDF1.TabIndex = 1
        Me.AxAcroPDF1.Visible = False
        '
        'GridIncome
        '
        Me.GridIncome.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridIncome.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridIncome_DesignTimeLayout.LayoutString = resources.GetString("GridIncome_DesignTimeLayout.LayoutString")
        Me.GridIncome.DesignTimeLayout = GridIncome_DesignTimeLayout
        Me.GridIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridIncome.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridIncome.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridIncome.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridIncome.GroupByBoxVisible = False
        Me.GridIncome.HeaderFormatStyle.FontSize = 10.0!
        Me.GridIncome.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridIncome.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridIncome.Hierarchical = True
        Me.GridIncome.Location = New System.Drawing.Point(0, 0)
        Me.GridIncome.Name = "GridIncome"
        Me.GridIncome.RecordNavigator = True
        Me.GridIncome.RowFormatStyle.FontSize = 12.0!
        Me.GridIncome.Size = New System.Drawing.Size(1024, 326)
        Me.GridIncome.TabIndex = 0
        Me.GridIncome.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(1024, 202)
        Me.SplitContainer3.SplitterDistance = 556
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridService)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service Detail"
        '
        'GridService
        '
        Me.GridService.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridService.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridService_DesignTimeLayout.LayoutString = resources.GetString("GridService_DesignTimeLayout.LayoutString")
        Me.GridService.DesignTimeLayout = GridService_DesignTimeLayout
        Me.GridService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridService.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridService.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridService.GroupByBoxVisible = False
        Me.GridService.HeaderFormatStyle.FontSize = 10.0!
        Me.GridService.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridService.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridService.Hierarchical = True
        Me.GridService.Location = New System.Drawing.Point(3, 16)
        Me.GridService.Name = "GridService"
        Me.GridService.RecordNavigator = True
        Me.GridService.RowFormatStyle.FontSize = 12.0!
        Me.GridService.Size = New System.Drawing.Size(550, 183)
        Me.GridService.TabIndex = 1
        Me.GridService.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridPrescription)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 202)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prescription"
        '
        'GridPrescription
        '
        Me.GridPrescription.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPrescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridPrescription_DesignTimeLayout.LayoutString = resources.GetString("GridPrescription_DesignTimeLayout.LayoutString")
        Me.GridPrescription.DesignTimeLayout = GridPrescription_DesignTimeLayout
        Me.GridPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrescription.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPrescription.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPrescription.GroupByBoxVisible = False
        Me.GridPrescription.HeaderFormatStyle.FontSize = 10.0!
        Me.GridPrescription.HeaderFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.GridPrescription.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPrescription.Hierarchical = True
        Me.GridPrescription.Location = New System.Drawing.Point(3, 16)
        Me.GridPrescription.Name = "GridPrescription"
        Me.GridPrescription.RecordNavigator = True
        Me.GridPrescription.RowFormatStyle.FontSize = 12.0!
        Me.GridPrescription.Size = New System.Drawing.Size(458, 183)
        Me.GridPrescription.TabIndex = 1
        Me.GridPrescription.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(10, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Dr. Surgury report"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CboDoctor1
        '
        Me.CboDoctor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor1.FormattingEnabled = True
        Me.CboDoctor1.Location = New System.Drawing.Point(10, 149)
        Me.CboDoctor1.Name = "CboDoctor1"
        Me.CboDoctor1.Size = New System.Drawing.Size(208, 28)
        Me.CboDoctor1.TabIndex = 15
        '
        'ChReport
        '
        Me.ChReport.AutoSize = True
        Me.ChReport.ForeColor = System.Drawing.Color.Blue
        Me.ChReport.Location = New System.Drawing.Point(10, 95)
        Me.ChReport.Name = "ChReport"
        Me.ChReport.Size = New System.Drawing.Size(98, 17)
        Me.ChReport.TabIndex = 5
        Me.ChReport.Text = "View as Report"
        Me.ChReport.UseVisualStyleBackColor = True
        Me.ChReport.Visible = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(10, 193)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(102, 32)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View Data"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(72, 56)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(140, 26)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(72, 20)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(140, 26)
        Me.DateFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'DashboardIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardIncome"
        Me.Size = New System.Drawing.Size(1253, 596)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridIncome As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnView As System.Windows.Forms.Button

    Friend WithEvents ChReport As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintlabel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridService As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridPrescription As Janus.Windows.GridEX.GridEX
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSurgery As System.Windows.Forms.ToolStripButton
    Friend WithEvents CboDoctor1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
