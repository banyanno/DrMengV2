<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainEyeExamForm
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
        Dim GridExEyeExam_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainEyeExamForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintForm = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFind = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.GridExEyeExam = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridExEyeExam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.BtnUpdate, Me.ToolStripSeparator2, Me.BtnPrintForm, Me.ToolStripSeparator3, Me.BtnFind, Me.ToolStripSeparator4, Me.BtnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.HospitalMS.My.Resources.Resources._1342235152_navigation_down_button_basic_blue
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(178, 29)
        Me.ToolStripButton1.Text = "New Eye Exam form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Image = Global.HospitalMS.My.Resources.Resources.edit
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(130, 29)
        Me.BtnUpdate.Text = "Update Exam"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnPrintForm
        '
        Me.BtnPrintForm.Image = Global.HospitalMS.My.Resources.Resources.printer
        Me.BtnPrintForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintForm.Name = "BtnPrintForm"
        Me.BtnPrintForm.Size = New System.Drawing.Size(131, 29)
        Me.BtnPrintForm.Text = "Print Preview"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'BtnFind
        '
        Me.BtnFind.Image = Global.HospitalMS.My.Resources.Resources.search
        Me.BtnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(92, 29)
        Me.BtnFind.Text = "Refresh"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = Global.HospitalMS.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(83, 29)
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.Visible = False
        '
        'GridExEyeExam
        '
        Me.GridExEyeExam.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridExEyeExam_DesignTimeLayout.LayoutString = resources.GetString("GridExEyeExam_DesignTimeLayout.LayoutString")
        Me.GridExEyeExam.DesignTimeLayout = GridExEyeExam_DesignTimeLayout
        Me.GridExEyeExam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExEyeExam.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridExEyeExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridExEyeExam.GroupByBoxVisible = False
        Me.GridExEyeExam.Location = New System.Drawing.Point(0, 0)
        Me.GridExEyeExam.Name = "GridExEyeExam"
        Me.GridExEyeExam.RecordNavigator = True
        Me.GridExEyeExam.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridExEyeExam.Size = New System.Drawing.Size(633, 401)
        Me.GridExEyeExam.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridExEyeExam)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(988, 401)
        Me.SplitContainer1.SplitterDistance = 633
        Me.SplitContainer1.TabIndex = 2
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(351, 401)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'MainEyeExamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainEyeExamForm"
        Me.Size = New System.Drawing.Size(988, 433)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridExEyeExam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintForm As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridExEyeExam As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
