<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCart
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
        Me.components = New System.ComponentModel.Container()
        Me.grpBoxProducts = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtBoxSubtotal = New System.Windows.Forms.TextBox()
        Me.txtBoxTax = New System.Windows.Forms.TextBox()
        Me.txtBoxShipping = New System.Windows.Forms.TextBox()
        Me.txtBoxTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lstBoxProducts = New System.Windows.Forms.ListBox()
        Me.cntMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.toolFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolAudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpBoxProducts.SuspendLayout()
        Me.cntMenuStrip.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxProducts
        '
        Me.grpBoxProducts.Controls.Add(Me.btnRemove)
        Me.grpBoxProducts.Controls.Add(Me.txtBoxSubtotal)
        Me.grpBoxProducts.Controls.Add(Me.txtBoxTax)
        Me.grpBoxProducts.Controls.Add(Me.txtBoxShipping)
        Me.grpBoxProducts.Controls.Add(Me.txtBoxTotal)
        Me.grpBoxProducts.Controls.Add(Me.lblTotal)
        Me.grpBoxProducts.Controls.Add(Me.lblShipping)
        Me.grpBoxProducts.Controls.Add(Me.lblTax)
        Me.grpBoxProducts.Controls.Add(Me.lblSubtotal)
        Me.grpBoxProducts.Controls.Add(Me.lstBoxProducts)
        Me.grpBoxProducts.Location = New System.Drawing.Point(29, 29)
        Me.grpBoxProducts.Name = "grpBoxProducts"
        Me.grpBoxProducts.Size = New System.Drawing.Size(577, 259)
        Me.grpBoxProducts.TabIndex = 1
        Me.grpBoxProducts.TabStop = False
        Me.grpBoxProducts.Text = "Products Selected"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(114, 197)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(109, 43)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "R&emove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtBoxSubtotal
        '
        Me.txtBoxSubtotal.Location = New System.Drawing.Point(471, 32)
        Me.txtBoxSubtotal.Name = "txtBoxSubtotal"
        Me.txtBoxSubtotal.ReadOnly = True
        Me.txtBoxSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxSubtotal.TabIndex = 2
        '
        'txtBoxTax
        '
        Me.txtBoxTax.Location = New System.Drawing.Point(471, 78)
        Me.txtBoxTax.Name = "txtBoxTax"
        Me.txtBoxTax.ReadOnly = True
        Me.txtBoxTax.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTax.TabIndex = 4
        '
        'txtBoxShipping
        '
        Me.txtBoxShipping.Location = New System.Drawing.Point(471, 123)
        Me.txtBoxShipping.Name = "txtBoxShipping"
        Me.txtBoxShipping.ReadOnly = True
        Me.txtBoxShipping.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxShipping.TabIndex = 6
        '
        'txtBoxTotal
        '
        Me.txtBoxTotal.Location = New System.Drawing.Point(471, 166)
        Me.txtBoxTotal.Name = "txtBoxTotal"
        Me.txtBoxTotal.ReadOnly = True
        Me.txtBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTotal.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(405, 169)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(388, 126)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(51, 13)
        Me.lblShipping.TabIndex = 5
        Me.lblShipping.Text = "Shipping:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(411, 81)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(390, 35)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lstBoxProducts
        '
        Me.lstBoxProducts.ContextMenuStrip = Me.cntMenuStrip
        Me.lstBoxProducts.FormattingEnabled = True
        Me.lstBoxProducts.Location = New System.Drawing.Point(17, 35)
        Me.lstBoxProducts.Name = "lstBoxProducts"
        Me.lstBoxProducts.Size = New System.Drawing.Size(346, 147)
        Me.lstBoxProducts.TabIndex = 0
        '
        'cntMenuStrip
        '
        Me.cntMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.AudioToolStripMenuItem})
        Me.cntMenuStrip.Name = "cntMenuStrip"
        Me.cntMenuStrip.Size = New System.Drawing.Size(107, 48)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'AudioToolStripMenuItem
        '
        Me.AudioToolStripMenuItem.Name = "AudioToolStripMenuItem"
        Me.AudioToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.AudioToolStripMenuItem.Text = "Audio"
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolFile, Me.toolProducts, Me.toolHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(636, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'toolFile
        '
        Me.toolFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolReset, Me.toolExit})
        Me.toolFile.Name = "toolFile"
        Me.toolFile.Size = New System.Drawing.Size(37, 20)
        Me.toolFile.Text = "&File"
        '
        'toolReset
        '
        Me.toolReset.Name = "toolReset"
        Me.toolReset.Size = New System.Drawing.Size(102, 22)
        Me.toolReset.Text = "&Reset"
        '
        'toolExit
        '
        Me.toolExit.Name = "toolExit"
        Me.toolExit.Size = New System.Drawing.Size(102, 22)
        Me.toolExit.Text = "E&xit"
        '
        'toolProducts
        '
        Me.toolProducts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolPrint, Me.toolAudio})
        Me.toolProducts.Name = "toolProducts"
        Me.toolProducts.Size = New System.Drawing.Size(66, 20)
        Me.toolProducts.Text = "&Products"
        '
        'toolPrint
        '
        Me.toolPrint.Name = "toolPrint"
        Me.toolPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.toolPrint.Size = New System.Drawing.Size(184, 22)
        Me.toolPrint.Text = "P&rint Books"
        '
        'toolAudio
        '
        Me.toolAudio.Name = "toolAudio"
        Me.toolAudio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.toolAudio.Size = New System.Drawing.Size(184, 22)
        Me.toolAudio.Text = "&Audio Books"
        '
        'toolHelp
        '
        Me.toolHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolAbout})
        Me.toolHelp.Name = "toolHelp"
        Me.toolHelp.Size = New System.Drawing.Size(44, 20)
        Me.toolHelp.Text = "&Help"
        '
        'toolAbout
        '
        Me.toolAbout.Name = "toolAbout"
        Me.toolAbout.Size = New System.Drawing.Size(107, 22)
        Me.toolAbout.Text = "&About"
        '
        'frmCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 316)
        Me.Controls.Add(Me.grpBoxProducts)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart by Nigel Mansell"
        Me.grpBoxProducts.ResumeLayout(False)
        Me.grpBoxProducts.PerformLayout()
        Me.cntMenuStrip.ResumeLayout(False)
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBoxProducts As GroupBox
    Friend WithEvents txtBoxSubtotal As TextBox
    Friend WithEvents txtBoxTax As TextBox
    Friend WithEvents txtBoxShipping As TextBox
    Friend WithEvents txtBoxTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lstBoxProducts As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents toolFile As ToolStripMenuItem
    Friend WithEvents toolReset As ToolStripMenuItem
    Friend WithEvents toolExit As ToolStripMenuItem
    Friend WithEvents toolProducts As ToolStripMenuItem
    Friend WithEvents toolPrint As ToolStripMenuItem
    Friend WithEvents toolAudio As ToolStripMenuItem
    Friend WithEvents toolHelp As ToolStripMenuItem
    Friend WithEvents toolAbout As ToolStripMenuItem
    Friend WithEvents cntMenuStrip As ContextMenuStrip
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AudioToolStripMenuItem As ToolStripMenuItem
End Class
