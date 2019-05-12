<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.grpLicensing = New System.Windows.Forms.GroupBox()
        Me.optOneTime = New System.Windows.Forms.RadioButton()
        Me.optYearly = New System.Windows.Forms.RadioButton()
        Me.grpYearly = New System.Windows.Forms.GroupBox()
        Me.chkBackup = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkSupport = New System.Windows.Forms.CheckBox()
        Me.grpCostAndEmail = New System.Windows.Forms.GroupBox()
        Me.txtLicenseCount = New System.Windows.Forms.TextBox()
        Me.lblLicenseNumber = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.txtLicensing = New System.Windows.Forms.TextBox()
        Me.lblFeaturesCost = New System.Windows.Forms.Label()
        Me.lblLicensingCost = New System.Windows.Forms.Label()
        Me.lblEmailOut = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpLicensing.SuspendLayout()
        Me.grpYearly.SuspendLayout()
        Me.grpCostAndEmail.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLicensing
        '
        Me.grpLicensing.Controls.Add(Me.optOneTime)
        Me.grpLicensing.Controls.Add(Me.optYearly)
        Me.grpLicensing.Location = New System.Drawing.Point(12, 12)
        Me.grpLicensing.Name = "grpLicensing"
        Me.grpLicensing.Size = New System.Drawing.Size(200, 100)
        Me.grpLicensing.TabIndex = 0
        Me.grpLicensing.TabStop = False
        Me.grpLicensing.Text = "Licensing Options"
        '
        'optOneTime
        '
        Me.optOneTime.AutoSize = True
        Me.optOneTime.Location = New System.Drawing.Point(19, 62)
        Me.optOneTime.Name = "optOneTime"
        Me.optOneTime.Size = New System.Drawing.Size(119, 17)
        Me.optOneTime.TabIndex = 1
        Me.optOneTime.Text = "One-Time Purchase"
        Me.optOneTime.UseVisualStyleBackColor = True
        '
        'optYearly
        '
        Me.optYearly.AutoSize = True
        Me.optYearly.Checked = True
        Me.optYearly.Location = New System.Drawing.Point(19, 30)
        Me.optYearly.Name = "optYearly"
        Me.optYearly.Size = New System.Drawing.Size(90, 17)
        Me.optYearly.TabIndex = 0
        Me.optYearly.TabStop = True
        Me.optYearly.Text = "Yearly license"
        Me.optYearly.UseVisualStyleBackColor = True
        '
        'grpYearly
        '
        Me.grpYearly.Controls.Add(Me.chkBackup)
        Me.grpYearly.Controls.Add(Me.chkTraining)
        Me.grpYearly.Controls.Add(Me.chkSupport)
        Me.grpYearly.Location = New System.Drawing.Point(250, 12)
        Me.grpYearly.Name = "grpYearly"
        Me.grpYearly.Size = New System.Drawing.Size(200, 100)
        Me.grpYearly.TabIndex = 1
        Me.grpYearly.TabStop = False
        Me.grpYearly.Text = "Optional Features (yearly)"
        '
        'chkBackup
        '
        Me.chkBackup.AutoSize = True
        Me.chkBackup.Location = New System.Drawing.Point(24, 77)
        Me.chkBackup.Name = "chkBackup"
        Me.chkBackup.Size = New System.Drawing.Size(93, 17)
        Me.chkBackup.TabIndex = 2
        Me.chkBackup.Text = "Cloud Backup"
        Me.chkBackup.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Location = New System.Drawing.Point(24, 54)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(100, 17)
        Me.chkTraining.TabIndex = 1
        Me.chkTraining.Text = "On-site Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkSupport
        '
        Me.chkSupport.AutoSize = True
        Me.chkSupport.Location = New System.Drawing.Point(24, 30)
        Me.chkSupport.Name = "chkSupport"
        Me.chkSupport.Size = New System.Drawing.Size(151, 17)
        Me.chkSupport.TabIndex = 0
        Me.chkSupport.Text = "Level-3 Technical Support"
        Me.chkSupport.UseVisualStyleBackColor = True
        '
        'grpCostAndEmail
        '
        Me.grpCostAndEmail.Controls.Add(Me.txtLicenseCount)
        Me.grpCostAndEmail.Controls.Add(Me.lblLicenseNumber)
        Me.grpCostAndEmail.Controls.Add(Me.txtConfirm)
        Me.grpCostAndEmail.Controls.Add(Me.txtEmail)
        Me.grpCostAndEmail.Controls.Add(Me.lblConfirm)
        Me.grpCostAndEmail.Controls.Add(Me.lblEmail)
        Me.grpCostAndEmail.Controls.Add(Me.txtFeatures)
        Me.grpCostAndEmail.Controls.Add(Me.txtLicensing)
        Me.grpCostAndEmail.Controls.Add(Me.lblFeaturesCost)
        Me.grpCostAndEmail.Controls.Add(Me.lblLicensingCost)
        Me.grpCostAndEmail.Location = New System.Drawing.Point(15, 118)
        Me.grpCostAndEmail.Name = "grpCostAndEmail"
        Me.grpCostAndEmail.Size = New System.Drawing.Size(473, 131)
        Me.grpCostAndEmail.TabIndex = 2
        Me.grpCostAndEmail.TabStop = False
        '
        'txtLicenseCount
        '
        Me.txtLicenseCount.Location = New System.Drawing.Point(358, 17)
        Me.txtLicenseCount.Name = "txtLicenseCount"
        Me.txtLicenseCount.Size = New System.Drawing.Size(100, 20)
        Me.txtLicenseCount.TabIndex = 9
        '
        'lblLicenseNumber
        '
        Me.lblLicenseNumber.AutoSize = True
        Me.lblLicenseNumber.Location = New System.Drawing.Point(260, 20)
        Me.lblLicenseNumber.Name = "lblLicenseNumber"
        Me.lblLicenseNumber.Size = New System.Drawing.Size(92, 13)
        Me.lblLicenseNumber.TabIndex = 8
        Me.lblLicenseNumber.Text = "&Number of license"
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(84, 104)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(155, 20)
        Me.txtConfirm.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(84, 78)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(155, 20)
        Me.txtEmail.TabIndex = 5
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(3, 107)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(72, 13)
        Me.lblConfirm.TabIndex = 6
        Me.lblConfirm.Text = "&Confirm email:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(3, 81)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(62, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "&Enter email:"
        '
        'txtFeatures
        '
        Me.txtFeatures.Location = New System.Drawing.Point(139, 42)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.ReadOnly = True
        Me.txtFeatures.Size = New System.Drawing.Size(100, 20)
        Me.txtFeatures.TabIndex = 3
        '
        'txtLicensing
        '
        Me.txtLicensing.Location = New System.Drawing.Point(139, 13)
        Me.txtLicensing.Name = "txtLicensing"
        Me.txtLicensing.ReadOnly = True
        Me.txtLicensing.Size = New System.Drawing.Size(100, 20)
        Me.txtLicensing.TabIndex = 1
        '
        'lblFeaturesCost
        '
        Me.lblFeaturesCost.AutoSize = True
        Me.lblFeaturesCost.Location = New System.Drawing.Point(3, 45)
        Me.lblFeaturesCost.Name = "lblFeaturesCost"
        Me.lblFeaturesCost.Size = New System.Drawing.Size(124, 13)
        Me.lblFeaturesCost.TabIndex = 2
        Me.lblFeaturesCost.Text = "&Cost of optional features:"
        '
        'lblLicensingCost
        '
        Me.lblLicensingCost.AutoSize = True
        Me.lblLicensingCost.Location = New System.Drawing.Point(3, 16)
        Me.lblLicensingCost.Name = "lblLicensingCost"
        Me.lblLicensingCost.Size = New System.Drawing.Size(130, 13)
        Me.lblLicensingCost.TabIndex = 0
        Me.lblLicensingCost.Text = "&Cost of software licensing:"
        '
        'lblEmailOut
        '
        Me.lblEmailOut.Location = New System.Drawing.Point(45, 298)
        Me.lblEmailOut.Name = "lblEmailOut"
        Me.lblEmailOut.Size = New System.Drawing.Size(443, 61)
        Me.lblEmailOut.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 272)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(221, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(413, 272)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Cl&ose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSales
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(576, 362)
        Me.Controls.Add(Me.lblEmailOut)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpCostAndEmail)
        Me.Controls.Add(Me.grpYearly)
        Me.Controls.Add(Me.grpLicensing)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software Sales by Nigel"
        Me.grpLicensing.ResumeLayout(False)
        Me.grpLicensing.PerformLayout()
        Me.grpYearly.ResumeLayout(False)
        Me.grpYearly.PerformLayout()
        Me.grpCostAndEmail.ResumeLayout(False)
        Me.grpCostAndEmail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLicensing As GroupBox
    Friend WithEvents optOneTime As RadioButton
    Friend WithEvents optYearly As RadioButton
    Friend WithEvents grpYearly As GroupBox
    Friend WithEvents chkBackup As CheckBox
    Friend WithEvents chkTraining As CheckBox
    Friend WithEvents chkSupport As CheckBox
    Friend WithEvents grpCostAndEmail As GroupBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtFeatures As TextBox
    Friend WithEvents txtLicensing As TextBox
    Friend WithEvents lblFeaturesCost As Label
    Friend WithEvents lblLicensingCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblEmailOut As Label
    Friend WithEvents txtLicenseCount As TextBox
    Friend WithEvents lblLicenseNumber As Label
End Class
