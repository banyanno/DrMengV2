<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceivedItem
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceivedItem))
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.HospitalMS.My.Resources.Resources.referral_iconX
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(168, 25)
        Me.ToolStripButton1.Text = "New Receive Order"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(173, 25)
        Me.ToolStripButton2.Text = "Refresh Information"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'GridEX1
        '
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.Location = New System.Drawing.Point(0, 28)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(989, 550)
        Me.GridEX1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridEX2)
        Me.SplitContainer1.Size = New System.Drawing.Size(989, 550)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(737, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(221, 152)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(502, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(221, 152)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(267, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 152)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(31, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 152)
        Me.Panel1.TabIndex = 0
        '
        'GridEX2
        '
        Me.GridEX2.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridEX2.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Flat
        Me.GridEX2.ControlStyle.ControlColor = System.Drawing.Color.Coral
        Me.GridEX2.ControlStyle.ControlTextColor = System.Drawing.Color.Crimson
        Me.GridEX2.ControlStyle.HoverBaseColor = System.Drawing.Color.Honeydew
        Me.GridEX2.ControlStyle.ScrollBarColor = System.Drawing.Color.SeaGreen
        Me.GridEX2.ControlStyle.WindowTextColor = System.Drawing.Color.Yellow
        Me.GridEX2.DefaultAlphaMode = Janus.Windows.GridEX.AlphaMode.UseAlpha
        Me.GridEX2.DefaultBackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.UseAlpha
        Me.GridEX2.DefaultBlend = 1.0!
        GridEX2_DesignTimeLayout.LayoutString = resources.GetString("GridEX2_DesignTimeLayout.LayoutString")
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Flat
        Me.GridEX2.FlatBorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridEX2.FlatBorderInHeaders = False
        Me.GridEX2.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Sunken
        Me.GridEX2.HeaderFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.UseAlpha
        Me.GridEX2.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.GridEX2.HeaderFormatStyle.FontSize = 10.0!
        Me.GridEX2.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridEX2.Location = New System.Drawing.Point(0, 0)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.PreviewRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.RowFormatStyle.Alpha = 1
        Me.GridEX2.RowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEX2.RowHeaderFormatStyle.Alpha = 0
        Me.GridEX2.RowHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridEX2.Size = New System.Drawing.Size(989, 359)
        Me.GridEX2.TabIndex = 1
        Me.GridEX2.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        '
        'ReceivedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ReceivedItem"
        Me.Size = New System.Drawing.Size(989, 578)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager

End Class
