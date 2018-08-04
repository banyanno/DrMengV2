<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaboResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaboResult))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtLaboResult = New System.Windows.Forms.TextBox
        Me.TxtLabo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtLaboResult)
        Me.GroupBox1.Controls.Add(Me.TxtLabo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Result:"
        '
        'TxtLaboResult
        '
        Me.TxtLaboResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLaboResult.Location = New System.Drawing.Point(13, 81)
        Me.TxtLaboResult.Multiline = True
        Me.TxtLaboResult.Name = "TxtLaboResult"
        Me.TxtLaboResult.Size = New System.Drawing.Size(356, 132)
        Me.TxtLaboResult.TabIndex = 2
        '
        'TxtLabo
        '
        Me.TxtLabo.BackColor = System.Drawing.Color.White
        Me.TxtLabo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLabo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabo.Location = New System.Drawing.Point(61, 22)
        Me.TxtLabo.Name = "TxtLabo"
        Me.TxtLabo.ReadOnly = True
        Me.TxtLabo.Size = New System.Drawing.Size(308, 29)
        Me.TxtLabo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Labo:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(213, 233)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 32)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(304, 233)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(12, 243)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'LaboResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 273)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaboResult"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result Of Labo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtLaboResult As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
End Class
