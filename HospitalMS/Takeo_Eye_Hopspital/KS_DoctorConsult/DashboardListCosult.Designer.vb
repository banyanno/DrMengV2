<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardListCosult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardListCosult))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTo1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateFrom1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnTotalInvestigate = New System.Windows.Forms.Button
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.ChDoctor = New System.Windows.Forms.CheckBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.CboDoctor1 = New System.Windows.Forms.ComboBox
        Me.ChDoctor1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.ChDoctor)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1109, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboDoctor1)
        Me.GroupBox2.Controls.Add(Me.ChDoctor1)
        Me.GroupBox2.Controls.Add(Me.DateTo1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DateFrom1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtnTotalInvestigate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(437, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 141)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Laser, Inves, Labo..."
        '
        'DateTo1
        '
        Me.DateTo1.CustomFormat = "dd-MM-yyyy"
        Me.DateTo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo1.Location = New System.Drawing.Point(140, 88)
        Me.DateTo1.Name = "DateTo1"
        Me.DateTo1.Size = New System.Drawing.Size(154, 26)
        Me.DateTo1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Date To:"
        '
        'DateFrom1
        '
        Me.DateFrom1.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom1.Location = New System.Drawing.Point(140, 59)
        Me.DateFrom1.Name = "DateFrom1"
        Me.DateFrom1.Size = New System.Drawing.Size(154, 26)
        Me.DateFrom1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date From:"
        '
        'BtnTotalInvestigate
        '
        Me.BtnTotalInvestigate.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.BtnTotalInvestigate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTotalInvestigate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTotalInvestigate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTotalInvestigate.ForeColor = System.Drawing.Color.White
        Me.BtnTotalInvestigate.Location = New System.Drawing.Point(311, 80)
        Me.BtnTotalInvestigate.Name = "BtnTotalInvestigate"
        Me.BtnTotalInvestigate.Size = New System.Drawing.Size(142, 30)
        Me.BtnTotalInvestigate.TabIndex = 8
        Me.BtnTotalInvestigate.Text = "Print Preview"
        Me.BtnTotalInvestigate.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.BackgroundImage = Global.HospitalMS.My.Resources.Resources.mZihS
        Me.BtnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPrintPreview.Location = New System.Drawing.Point(272, 106)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(104, 28)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(112, 106)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(154, 28)
        Me.CboDoctor.TabIndex = 5
        '
        'ChDoctor
        '
        Me.ChDoctor.AutoSize = True
        Me.ChDoctor.Location = New System.Drawing.Point(20, 117)
        Me.ChDoctor.Name = "ChDoctor"
        Me.ChDoctor.Size = New System.Drawing.Size(86, 17)
        Me.ChDoctor.TabIndex = 4
        Me.ChDoctor.Text = "With Doctor:"
        Me.ChDoctor.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(112, 65)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(154, 26)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(112, 25)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(154, 26)
        Me.DateFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 166)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(1109, 451)
        Me.AxAcroPDF1.TabIndex = 1
        '
        'CboDoctor1
        '
        Me.CboDoctor1.Enabled = False
        Me.CboDoctor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor1.FormattingEnabled = True
        Me.CboDoctor1.Location = New System.Drawing.Point(140, 23)
        Me.CboDoctor1.Name = "CboDoctor1"
        Me.CboDoctor1.Size = New System.Drawing.Size(154, 28)
        Me.CboDoctor1.TabIndex = 14
        '
        'ChDoctor1
        '
        Me.ChDoctor1.AutoSize = True
        Me.ChDoctor1.Location = New System.Drawing.Point(18, 27)
        Me.ChDoctor1.Name = "ChDoctor1"
        Me.ChDoctor1.Size = New System.Drawing.Size(116, 24)
        Me.ChDoctor1.TabIndex = 13
        Me.ChDoctor1.Text = "With Doctor:"
        Me.ChDoctor1.UseVisualStyleBackColor = True
        '
        'DashboardListCosult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DashboardListCosult"
        Me.Size = New System.Drawing.Size(1109, 617)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents ChDoctor As System.Windows.Forms.CheckBox
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTotalInvestigate As System.Windows.Forms.Button
    Friend WithEvents DateTo1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateFrom1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor1 As System.Windows.Forms.ComboBox
    Friend WithEvents ChDoctor1 As System.Windows.Forms.CheckBox


End Class
