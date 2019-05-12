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
        Me.grpBoxOil = New System.Windows.Forms.GroupBox()
        Me.lblLube = New System.Windows.Forms.Label()
        Me.lblOil = New System.Windows.Forms.Label()
        Me.chkBoxOil = New System.Windows.Forms.CheckBox()
        Me.chkBoxLube = New System.Windows.Forms.CheckBox()
        Me.grpBoxRadiator = New System.Windows.Forms.GroupBox()
        Me.lblTransmission = New System.Windows.Forms.Label()
        Me.lblRadiator = New System.Windows.Forms.Label()
        Me.chkBoxRadiator = New System.Windows.Forms.CheckBox()
        Me.chkBoxTransmission = New System.Windows.Forms.CheckBox()
        Me.grpBoxMisc = New System.Windows.Forms.GroupBox()
        Me.lblInspection = New System.Windows.Forms.Label()
        Me.lblMuffler = New System.Windows.Forms.Label()
        Me.lblRotation = New System.Windows.Forms.Label()
        Me.chkBoxRotation = New System.Windows.Forms.CheckBox()
        Me.chkBoxMuffler = New System.Windows.Forms.CheckBox()
        Me.chkBoxInspection = New System.Windows.Forms.CheckBox()
        Me.grpBoxParts = New System.Windows.Forms.GroupBox()
        Me.grpBoxCharges = New System.Windows.Forms.GroupBox()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.txtBoxParts = New System.Windows.Forms.TextBox()
        Me.txtBoxLabor = New System.Windows.Forms.TextBox()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblCharges = New System.Windows.Forms.Label()
        Me.txtBoxServices = New System.Windows.Forms.TextBox()
        Me.txtBoxChargers = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxTax = New System.Windows.Forms.TextBox()
        Me.txtBoxTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpBoxOil.SuspendLayout()
        Me.grpBoxRadiator.SuspendLayout()
        Me.grpBoxMisc.SuspendLayout()
        Me.grpBoxParts.SuspendLayout()
        Me.grpBoxCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxOil
        '
        Me.grpBoxOil.Controls.Add(Me.lblLube)
        Me.grpBoxOil.Controls.Add(Me.lblOil)
        Me.grpBoxOil.Controls.Add(Me.chkBoxOil)
        Me.grpBoxOil.Controls.Add(Me.chkBoxLube)
        Me.grpBoxOil.Location = New System.Drawing.Point(12, 12)
        Me.grpBoxOil.Name = "grpBoxOil"
        Me.grpBoxOil.Size = New System.Drawing.Size(200, 100)
        Me.grpBoxOil.TabIndex = 0
        Me.grpBoxOil.TabStop = False
        Me.grpBoxOil.Text = "Oil and Lubrication"
        '
        'lblLube
        '
        Me.lblLube.AutoSize = True
        Me.lblLube.Location = New System.Drawing.Point(160, 63)
        Me.lblLube.Name = "lblLube"
        Me.lblLube.Size = New System.Drawing.Size(34, 13)
        Me.lblLube.TabIndex = 3
        Me.lblLube.Text = "28.00"
        '
        'lblOil
        '
        Me.lblOil.AutoSize = True
        Me.lblOil.Location = New System.Drawing.Point(160, 30)
        Me.lblOil.Name = "lblOil"
        Me.lblOil.Size = New System.Drawing.Size(34, 13)
        Me.lblOil.TabIndex = 1
        Me.lblOil.Text = "36.00"
        '
        'chkBoxOil
        '
        Me.chkBoxOil.AutoSize = True
        Me.chkBoxOil.Location = New System.Drawing.Point(6, 29)
        Me.chkBoxOil.Name = "chkBoxOil"
        Me.chkBoxOil.Size = New System.Drawing.Size(78, 17)
        Me.chkBoxOil.TabIndex = 0
        Me.chkBoxOil.Text = "&Oil Change"
        Me.ToolTip1.SetToolTip(Me.chkBoxOil, "Checking this will charge for oil change.")
        Me.chkBoxOil.UseVisualStyleBackColor = True
        '
        'chkBoxLube
        '
        Me.chkBoxLube.AutoSize = True
        Me.chkBoxLube.Location = New System.Drawing.Point(6, 62)
        Me.chkBoxLube.Name = "chkBoxLube"
        Me.chkBoxLube.Size = New System.Drawing.Size(70, 17)
        Me.chkBoxLube.TabIndex = 2
        Me.chkBoxLube.Text = "&Lube Job"
        Me.ToolTip1.SetToolTip(Me.chkBoxLube, "Checking this will charge for lube job.")
        Me.chkBoxLube.UseVisualStyleBackColor = True
        '
        'grpBoxRadiator
        '
        Me.grpBoxRadiator.Controls.Add(Me.lblTransmission)
        Me.grpBoxRadiator.Controls.Add(Me.lblRadiator)
        Me.grpBoxRadiator.Controls.Add(Me.chkBoxRadiator)
        Me.grpBoxRadiator.Controls.Add(Me.chkBoxTransmission)
        Me.grpBoxRadiator.Location = New System.Drawing.Point(243, 12)
        Me.grpBoxRadiator.Name = "grpBoxRadiator"
        Me.grpBoxRadiator.Size = New System.Drawing.Size(200, 100)
        Me.grpBoxRadiator.TabIndex = 1
        Me.grpBoxRadiator.TabStop = False
        Me.grpBoxRadiator.Text = "Radiator and Transmission"
        '
        'lblTransmission
        '
        Me.lblTransmission.AutoSize = True
        Me.lblTransmission.Location = New System.Drawing.Point(154, 60)
        Me.lblTransmission.Name = "lblTransmission"
        Me.lblTransmission.Size = New System.Drawing.Size(40, 13)
        Me.lblTransmission.TabIndex = 3
        Me.lblTransmission.Text = "120.00"
        '
        'lblRadiator
        '
        Me.lblRadiator.AutoSize = True
        Me.lblRadiator.Location = New System.Drawing.Point(160, 30)
        Me.lblRadiator.Name = "lblRadiator"
        Me.lblRadiator.Size = New System.Drawing.Size(34, 13)
        Me.lblRadiator.TabIndex = 1
        Me.lblRadiator.Text = "50.00"
        '
        'chkBoxRadiator
        '
        Me.chkBoxRadiator.AutoSize = True
        Me.chkBoxRadiator.Location = New System.Drawing.Point(6, 30)
        Me.chkBoxRadiator.Name = "chkBoxRadiator"
        Me.chkBoxRadiator.Size = New System.Drawing.Size(94, 17)
        Me.chkBoxRadiator.TabIndex = 0
        Me.chkBoxRadiator.Text = "&Radiator Flush"
        Me.ToolTip1.SetToolTip(Me.chkBoxRadiator, "Checking this will charge for radiator flush.")
        Me.chkBoxRadiator.UseVisualStyleBackColor = True
        '
        'chkBoxTransmission
        '
        Me.chkBoxTransmission.AutoSize = True
        Me.chkBoxTransmission.Location = New System.Drawing.Point(6, 59)
        Me.chkBoxTransmission.Name = "chkBoxTransmission"
        Me.chkBoxTransmission.Size = New System.Drawing.Size(115, 17)
        Me.chkBoxTransmission.TabIndex = 2
        Me.chkBoxTransmission.Text = "&Transmission Flush"
        Me.ToolTip1.SetToolTip(Me.chkBoxTransmission, "Checking this will charge for transmission flush.")
        Me.chkBoxTransmission.UseVisualStyleBackColor = True
        '
        'grpBoxMisc
        '
        Me.grpBoxMisc.Controls.Add(Me.lblInspection)
        Me.grpBoxMisc.Controls.Add(Me.lblMuffler)
        Me.grpBoxMisc.Controls.Add(Me.lblRotation)
        Me.grpBoxMisc.Controls.Add(Me.chkBoxRotation)
        Me.grpBoxMisc.Controls.Add(Me.chkBoxMuffler)
        Me.grpBoxMisc.Controls.Add(Me.chkBoxInspection)
        Me.grpBoxMisc.Location = New System.Drawing.Point(12, 118)
        Me.grpBoxMisc.Name = "grpBoxMisc"
        Me.grpBoxMisc.Size = New System.Drawing.Size(200, 100)
        Me.grpBoxMisc.TabIndex = 2
        Me.grpBoxMisc.TabStop = False
        Me.grpBoxMisc.Text = "Miscellaneous"
        '
        'lblInspection
        '
        Me.lblInspection.AutoSize = True
        Me.lblInspection.Location = New System.Drawing.Point(155, 20)
        Me.lblInspection.Name = "lblInspection"
        Me.lblInspection.Size = New System.Drawing.Size(34, 13)
        Me.lblInspection.TabIndex = 1
        Me.lblInspection.Text = "15.00"
        '
        'lblMuffler
        '
        Me.lblMuffler.AutoSize = True
        Me.lblMuffler.Location = New System.Drawing.Point(149, 43)
        Me.lblMuffler.Name = "lblMuffler"
        Me.lblMuffler.Size = New System.Drawing.Size(40, 13)
        Me.lblMuffler.TabIndex = 3
        Me.lblMuffler.Text = "200.00"
        '
        'lblRotation
        '
        Me.lblRotation.AutoSize = True
        Me.lblRotation.Location = New System.Drawing.Point(155, 66)
        Me.lblRotation.Name = "lblRotation"
        Me.lblRotation.Size = New System.Drawing.Size(34, 13)
        Me.lblRotation.TabIndex = 5
        Me.lblRotation.Text = "20.00"
        '
        'chkBoxRotation
        '
        Me.chkBoxRotation.AutoSize = True
        Me.chkBoxRotation.Location = New System.Drawing.Point(6, 65)
        Me.chkBoxRotation.Name = "chkBoxRotation"
        Me.chkBoxRotation.Size = New System.Drawing.Size(87, 17)
        Me.chkBoxRotation.TabIndex = 4
        Me.chkBoxRotation.Text = "Tire Rot&ation"
        Me.ToolTip1.SetToolTip(Me.chkBoxRotation, "Checking this will charge for tire rotation.")
        Me.chkBoxRotation.UseVisualStyleBackColor = True
        '
        'chkBoxMuffler
        '
        Me.chkBoxMuffler.AutoSize = True
        Me.chkBoxMuffler.Location = New System.Drawing.Point(6, 42)
        Me.chkBoxMuffler.Name = "chkBoxMuffler"
        Me.chkBoxMuffler.Size = New System.Drawing.Size(101, 17)
        Me.chkBoxMuffler.TabIndex = 2
        Me.chkBoxMuffler.Text = "Replace &Muffler"
        Me.ToolTip1.SetToolTip(Me.chkBoxMuffler, "Checking this will charge for muffler replacement.")
        Me.chkBoxMuffler.UseVisualStyleBackColor = True
        '
        'chkBoxInspection
        '
        Me.chkBoxInspection.AutoSize = True
        Me.chkBoxInspection.Location = New System.Drawing.Point(6, 19)
        Me.chkBoxInspection.Name = "chkBoxInspection"
        Me.chkBoxInspection.Size = New System.Drawing.Size(75, 17)
        Me.chkBoxInspection.TabIndex = 0
        Me.chkBoxInspection.Text = "&Inspection"
        Me.ToolTip1.SetToolTip(Me.chkBoxInspection, "Checking this will charge for inspection.")
        Me.chkBoxInspection.UseVisualStyleBackColor = True
        '
        'grpBoxParts
        '
        Me.grpBoxParts.Controls.Add(Me.lblMinutes)
        Me.grpBoxParts.Controls.Add(Me.lblDollars)
        Me.grpBoxParts.Controls.Add(Me.txtBoxParts)
        Me.grpBoxParts.Controls.Add(Me.txtBoxLabor)
        Me.grpBoxParts.Controls.Add(Me.lblParts)
        Me.grpBoxParts.Controls.Add(Me.lblLabor)
        Me.grpBoxParts.Location = New System.Drawing.Point(243, 118)
        Me.grpBoxParts.Name = "grpBoxParts"
        Me.grpBoxParts.Size = New System.Drawing.Size(200, 100)
        Me.grpBoxParts.TabIndex = 3
        Me.grpBoxParts.TabStop = False
        Me.grpBoxParts.Text = "Parts and Labor"
        '
        'grpBoxCharges
        '
        Me.grpBoxCharges.Controls.Add(Me.txtBoxTotal)
        Me.grpBoxCharges.Controls.Add(Me.txtBoxTax)
        Me.grpBoxCharges.Controls.Add(Me.Label2)
        Me.grpBoxCharges.Controls.Add(Me.lblTax)
        Me.grpBoxCharges.Controls.Add(Me.txtBoxChargers)
        Me.grpBoxCharges.Controls.Add(Me.txtBoxServices)
        Me.grpBoxCharges.Controls.Add(Me.lblServices)
        Me.grpBoxCharges.Controls.Add(Me.lblCharges)
        Me.grpBoxCharges.Location = New System.Drawing.Point(12, 240)
        Me.grpBoxCharges.Name = "grpBoxCharges"
        Me.grpBoxCharges.Size = New System.Drawing.Size(431, 100)
        Me.grpBoxCharges.TabIndex = 4
        Me.grpBoxCharges.TabStop = False
        Me.grpBoxCharges.Text = "Summary of Charges"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(6, 32)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(31, 13)
        Me.lblParts.TabIndex = 0
        Me.lblParts.Text = "&Parts"
        '
        'lblLabor
        '
        Me.lblLabor.AutoSize = True
        Me.lblLabor.Location = New System.Drawing.Point(6, 56)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(34, 13)
        Me.lblLabor.TabIndex = 2
        Me.lblLabor.Text = "La&bor"
        '
        'txtBoxParts
        '
        Me.txtBoxParts.Location = New System.Drawing.Point(46, 29)
        Me.txtBoxParts.Name = "txtBoxParts"
        Me.txtBoxParts.Size = New System.Drawing.Size(63, 20)
        Me.txtBoxParts.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtBoxParts, "Enter cost of parts in dollars.")
        '
        'txtBoxLabor
        '
        Me.txtBoxLabor.Location = New System.Drawing.Point(46, 53)
        Me.txtBoxLabor.Name = "txtBoxLabor"
        Me.txtBoxLabor.Size = New System.Drawing.Size(63, 20)
        Me.txtBoxLabor.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtBoxLabor, "Enter labor time in minutes.")
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(115, 32)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(37, 13)
        Me.lblDollars.TabIndex = 4
        Me.lblDollars.Text = "dollars"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(115, 56)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(43, 13)
        Me.lblMinutes.TabIndex = 5
        Me.lblMinutes.Text = "minutes"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Location = New System.Drawing.Point(6, 32)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(99, 13)
        Me.lblServices.TabIndex = 0
        Me.lblServices.Text = "&Services and Labor"
        Me.ToolTip1.SetToolTip(Me.lblServices, "Cost of all boxes that are checked, alont with cost of labor.")
        '
        'lblCharges
        '
        Me.lblCharges.AutoSize = True
        Me.lblCharges.Location = New System.Drawing.Point(66, 58)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(31, 13)
        Me.lblCharges.TabIndex = 2
        Me.lblCharges.Text = "Part&s"
        Me.ToolTip1.SetToolTip(Me.lblCharges, "Cost of parts.")
        '
        'txtBoxServices
        '
        Me.txtBoxServices.Location = New System.Drawing.Point(111, 29)
        Me.txtBoxServices.Name = "txtBoxServices"
        Me.txtBoxServices.ReadOnly = True
        Me.txtBoxServices.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxServices.TabIndex = 1
        '
        'txtBoxChargers
        '
        Me.txtBoxChargers.Location = New System.Drawing.Point(111, 55)
        Me.txtBoxChargers.Name = "txtBoxChargers"
        Me.txtBoxChargers.ReadOnly = True
        Me.txtBoxChargers.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxChargers.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(244, 32)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(69, 13)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "Tax(o&n parts)"
        Me.ToolTip1.SetToolTip(Me.lblTax, "Tax on parts at 6%.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total &Fees"
        Me.ToolTip1.SetToolTip(Me.Label2, "Total of all charges.")
        '
        'txtBoxTax
        '
        Me.txtBoxTax.Location = New System.Drawing.Point(319, 29)
        Me.txtBoxTax.Name = "txtBoxTax"
        Me.txtBoxTax.ReadOnly = True
        Me.txtBoxTax.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTax.TabIndex = 5
        '
        'txtBoxTotal
        '
        Me.txtBoxTotal.Location = New System.Drawing.Point(319, 55)
        Me.txtBoxTotal.Name = "txtBoxTotal"
        Me.txtBoxTotal.ReadOnly = True
        Me.txtBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTotal.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(59, 356)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Calculates and dsiplays Services and labor, parts, tax on parts, and total fees.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(208, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clears all checked boxes, parts and labor boxes, and all summary of changes resul" &
        "ts.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(340, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exits the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(460, 391)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpBoxCharges)
        Me.Controls.Add(Me.grpBoxParts)
        Me.Controls.Add(Me.grpBoxMisc)
        Me.Controls.Add(Me.grpBoxRadiator)
        Me.Controls.Add(Me.grpBoxOil)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TG Automotive by Nigel Mansell"
        Me.grpBoxOil.ResumeLayout(False)
        Me.grpBoxOil.PerformLayout()
        Me.grpBoxRadiator.ResumeLayout(False)
        Me.grpBoxRadiator.PerformLayout()
        Me.grpBoxMisc.ResumeLayout(False)
        Me.grpBoxMisc.PerformLayout()
        Me.grpBoxParts.ResumeLayout(False)
        Me.grpBoxParts.PerformLayout()
        Me.grpBoxCharges.ResumeLayout(False)
        Me.grpBoxCharges.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBoxOil As GroupBox
    Friend WithEvents lblLube As Label
    Friend WithEvents lblOil As Label
    Friend WithEvents chkBoxOil As CheckBox
    Friend WithEvents chkBoxLube As CheckBox
    Friend WithEvents grpBoxRadiator As GroupBox
    Friend WithEvents lblTransmission As Label
    Friend WithEvents lblRadiator As Label
    Friend WithEvents chkBoxRadiator As CheckBox
    Friend WithEvents chkBoxTransmission As CheckBox
    Friend WithEvents grpBoxMisc As GroupBox
    Friend WithEvents lblInspection As Label
    Friend WithEvents lblMuffler As Label
    Friend WithEvents lblRotation As Label
    Friend WithEvents chkBoxRotation As CheckBox
    Friend WithEvents chkBoxMuffler As CheckBox
    Friend WithEvents chkBoxInspection As CheckBox
    Friend WithEvents grpBoxParts As GroupBox
    Friend WithEvents grpBoxCharges As GroupBox
    Friend WithEvents lblParts As Label
    Friend WithEvents lblLabor As Label
    Friend WithEvents txtBoxParts As TextBox
    Friend WithEvents txtBoxLabor As TextBox
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblDollars As Label
    Friend WithEvents txtBoxTotal As TextBox
    Friend WithEvents txtBoxTax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtBoxChargers As TextBox
    Friend WithEvents txtBoxServices As TextBox
    Friend WithEvents lblServices As Label
    Friend WithEvents lblCharges As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
