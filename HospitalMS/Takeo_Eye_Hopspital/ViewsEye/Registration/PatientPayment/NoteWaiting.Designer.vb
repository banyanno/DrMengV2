<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteWaiting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteWaiting))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblPatientNo = New System.Windows.Forms.Label
        Me.AutoDotor = New AutocompleteMenuNS.AutocompleteMenu
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Waiting Note:"
        '
        'TxtNote
        '
        Me.AutoDotor.SetAutocompleteMenu(Me.TxtNote, Me.AutoDotor)
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNote.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNote.Location = New System.Drawing.Point(15, 34)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(440, 119)
        Me.TxtNote.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(299, 160)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 27)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(380, 159)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 27)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblPatientNo
        '
        Me.LblPatientNo.AutoSize = True
        Me.LblPatientNo.Location = New System.Drawing.Point(34, 167)
        Me.LblPatientNo.Name = "LblPatientNo"
        Me.LblPatientNo.Size = New System.Drawing.Size(13, 13)
        Me.LblPatientNo.TabIndex = 4
        Me.LblPatientNo.Text = "0"
        Me.LblPatientNo.Visible = False
        '
        'AutoDotor
        '
        Me.AutoDotor.AppearInterval = 100
        Me.AutoDotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AutoDotor.ImageList = Nothing
        Me.AutoDotor.Items = New String(-1) {}
        Me.AutoDotor.MinFragmentLength = 1
        Me.AutoDotor.TargetControlWrapper = Nothing
        Me.AutoDotor.ToolTipDuration = 3000
        '
        'NoteWaiting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 190)
        Me.Controls.Add(Me.LblPatientNo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtNote)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NoteWaiting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Note Waiting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblPatientNo As System.Windows.Forms.Label
    Friend WithEvents AutoDotor As AutocompleteMenuNS.AutocompleteMenu
End Class
