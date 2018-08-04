<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditeItemExpire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditeItemExpire))
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblItemName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtQTY = New System.Windows.Forms.TextBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LblExpireID = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name:"
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Location = New System.Drawing.Point(82, 22)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(13, 13)
        Me.LblItemName.TabIndex = 1
        Me.LblItemName.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edit QTY :"
        '
        'TxtQTY
        '
        Me.TxtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTY.Location = New System.Drawing.Point(82, 54)
        Me.TxtQTY.Name = "TxtQTY"
        Me.TxtQTY.Size = New System.Drawing.Size(196, 26)
        Me.TxtQTY.TabIndex = 3
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(122, 91)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Save"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(203, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblExpireID
        '
        Me.LblExpireID.AutoSize = True
        Me.LblExpireID.Location = New System.Drawing.Point(23, 97)
        Me.LblExpireID.Name = "LblExpireID"
        Me.LblExpireID.Size = New System.Drawing.Size(13, 13)
        Me.LblExpireID.TabIndex = 6
        Me.LblExpireID.Text = "0"
        Me.LblExpireID.Visible = False
        '
        'EditeItemExpire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 119)
        Me.Controls.Add(Me.LblExpireID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtQTY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblItemName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditeItemExpire"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditeItemExpire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblItemName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtQTY As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblExpireID As System.Windows.Forms.Label
End Class
