<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientFollowupByDoctor
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
        Dim GridFollowUp_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientFollowupByDoctor))
        Me.GridFollowUp = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        CType(Me.GridFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridFollowUp
        '
        Me.GridFollowUp.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFollowUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFollowUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(250, Byte), Integer))
        GridFollowUp_DesignTimeLayout.LayoutString = resources.GetString("GridFollowUp_DesignTimeLayout.LayoutString")
        Me.GridFollowUp.DesignTimeLayout = GridFollowUp_DesignTimeLayout
        Me.GridFollowUp.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridFollowUp.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.GridFollowUp.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridFollowUp.GroupByBoxVisible = False
        Me.GridFollowUp.HeaderFormatStyle.FontSize = 12.0!
        Me.GridFollowUp.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridFollowUp.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridFollowUp.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridFollowUp.Location = New System.Drawing.Point(3, 58)
        Me.GridFollowUp.Name = "GridFollowUp"
        Me.GridFollowUp.RecordNavigator = True
        Me.GridFollowUp.RowFormatStyle.FontSize = 12.0!
        Me.GridFollowUp.Size = New System.Drawing.Size(873, 451)
        Me.GridFollowUp.TabIndex = 8
        Me.GridFollowUp.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date To:"
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(70, 23)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(109, 20)
        Me.DateFrom.TabIndex = 11
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(249, 23)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(109, 20)
        Me.DateTo.TabIndex = 12
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Location = New System.Drawing.Point(529, 20)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(82, 23)
        Me.BtnPrintPreview.TabIndex = 13
        Me.BtnPrintPreview.Text = "View"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(364, 15)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(154, 28)
        Me.CboDoctor.TabIndex = 14
        '
        'PatientFollowupByDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 513)
        Me.Controls.Add(Me.CboDoctor)
        Me.Controls.Add(Me.BtnPrintPreview)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridFollowUp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientFollowupByDoctor"
        Me.Text = "Patient Followup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridFollowUp As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
End Class
