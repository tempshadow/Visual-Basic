<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.grpWorkshop = New System.Windows.Forms.GroupBox()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.grpCosts = New System.Windows.Forms.GroupBox()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCost = New System.Windows.Forms.Label()
        Me.grpWorkshop.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshop.Location = New System.Drawing.Point(6, 19)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(136, 121)
        Me.lstWorkshop.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstWorkshop, "The first three workshop last 3 days, Negotiation is 5, and the last only 1 days." &
        " From top to bottom, the Registration Fees are $595, $695, $995, $1,295, and $39" &
        "5")
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(6, 16)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(143, 121)
        Me.lstLocation.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstLocation, "Lodging daily fee from top to bottom is $95, $125, $110, $100, $92, $90")
        '
        'grpWorkshop
        '
        Me.grpWorkshop.Controls.Add(Me.lstWorkshop)
        Me.grpWorkshop.Location = New System.Drawing.Point(12, 9)
        Me.grpWorkshop.Name = "grpWorkshop"
        Me.grpWorkshop.Size = New System.Drawing.Size(148, 154)
        Me.grpWorkshop.TabIndex = 0
        Me.grpWorkshop.TabStop = False
        Me.grpWorkshop.Text = "Pick a Workshop"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lstLocation)
        Me.grpLocation.Location = New System.Drawing.Point(166, 12)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(155, 151)
        Me.grpLocation.TabIndex = 1
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Pick a Location"
        '
        'grpCosts
        '
        Me.grpCosts.Controls.Add(Me.lstCosts)
        Me.grpCosts.Location = New System.Drawing.Point(327, 12)
        Me.grpCosts.Name = "grpCosts"
        Me.grpCosts.Size = New System.Drawing.Size(145, 151)
        Me.grpCosts.TabIndex = 2
        Me.grpCosts.TabStop = False
        Me.grpCosts.Text = "List of Costs"
        '
        'lstCosts
        '
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.Location = New System.Drawing.Point(6, 16)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(133, 121)
        Me.lstCosts.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstCosts, "Displays the cost of each workshop")
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(31, 241)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 40)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add Workshop"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Once a workshop and location is selectd, this button will add the workshop cost t" &
        "o List of Costs.")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(166, 241)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 40)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "This will calculate all costs within the list of costs.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(277, 241)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 40)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Deselects all options and will clear all list of costs along with the total cost." &
        "")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(384, 241)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exits the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(169, 199)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total Cost:"
        Me.lblTotal.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(233, 199)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 13)
        Me.lblCost.TabIndex = 9
        '
        'Form1
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(482, 310)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.grpCosts)
        Me.Controls.Add(Me.grpWorkshop)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workshop Selector by Nigel Mansell"
        Me.grpWorkshop.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstWorkshop As ListBox
    Friend WithEvents lstLocation As ListBox
    Friend WithEvents grpWorkshop As GroupBox
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents grpCosts As GroupBox
    Friend WithEvents lstCosts As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblCost As Label
End Class
