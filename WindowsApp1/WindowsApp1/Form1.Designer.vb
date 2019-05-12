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
        Me.VirginiaButton = New System.Windows.Forms.Button()
        Me.NorthCarolinaButton = New System.Windows.Forms.Button()
        Me.SouthCarolinaButton = New System.Windows.Forms.Button()
        Me.GeorgiaButton = New System.Windows.Forms.Button()
        Me.AlabamaButton = New System.Windows.Forms.Button()
        Me.FloridaButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.CapAndAbbrevLabel = New System.Windows.Forms.Label()
        Me.FlagBox = New System.Windows.Forms.PictureBox()
        CType(Me.FlagBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VirginiaButton
        '
        Me.VirginiaButton.Location = New System.Drawing.Point(13, 13)
        Me.VirginiaButton.Name = "VirginiaButton"
        Me.VirginiaButton.Size = New System.Drawing.Size(75, 23)
        Me.VirginiaButton.TabIndex = 0
        Me.VirginiaButton.Text = "Virginia"
        Me.VirginiaButton.UseVisualStyleBackColor = True
        '
        'NorthCarolinaButton
        '
        Me.NorthCarolinaButton.Location = New System.Drawing.Point(94, 12)
        Me.NorthCarolinaButton.Name = "NorthCarolinaButton"
        Me.NorthCarolinaButton.Size = New System.Drawing.Size(84, 23)
        Me.NorthCarolinaButton.TabIndex = 1
        Me.NorthCarolinaButton.Text = "North Carolina"
        Me.NorthCarolinaButton.UseVisualStyleBackColor = True
        '
        'SouthCarolinaButton
        '
        Me.SouthCarolinaButton.Location = New System.Drawing.Point(184, 12)
        Me.SouthCarolinaButton.Name = "SouthCarolinaButton"
        Me.SouthCarolinaButton.Size = New System.Drawing.Size(88, 23)
        Me.SouthCarolinaButton.TabIndex = 2
        Me.SouthCarolinaButton.Text = "South Carolina"
        Me.SouthCarolinaButton.UseVisualStyleBackColor = True
        '
        'GeorgiaButton
        '
        Me.GeorgiaButton.Location = New System.Drawing.Point(13, 42)
        Me.GeorgiaButton.Name = "GeorgiaButton"
        Me.GeorgiaButton.Size = New System.Drawing.Size(75, 23)
        Me.GeorgiaButton.TabIndex = 3
        Me.GeorgiaButton.Text = "Georgia"
        Me.GeorgiaButton.UseVisualStyleBackColor = True
        '
        'AlabamaButton
        '
        Me.AlabamaButton.Location = New System.Drawing.Point(94, 41)
        Me.AlabamaButton.Name = "AlabamaButton"
        Me.AlabamaButton.Size = New System.Drawing.Size(84, 23)
        Me.AlabamaButton.TabIndex = 4
        Me.AlabamaButton.Text = "Alabama"
        Me.AlabamaButton.UseVisualStyleBackColor = True
        '
        'FloridaButton
        '
        Me.FloridaButton.Location = New System.Drawing.Point(184, 42)
        Me.FloridaButton.Name = "FloridaButton"
        Me.FloridaButton.Size = New System.Drawing.Size(88, 23)
        Me.FloridaButton.TabIndex = 5
        Me.FloridaButton.Text = "Florida"
        Me.FloridaButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(13, 226)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(197, 226)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'InstructionLabel
        '
        Me.InstructionLabel.Location = New System.Drawing.Point(10, 68)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(262, 30)
        Me.InstructionLabel.TabIndex = 8
        Me.InstructionLabel.Text = "Click on any of the state buttons above to see the corresponding abbreviation and" &
    " flag."
        '
        'CapAndAbbrevLabel
        '
        Me.CapAndAbbrevLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CapAndAbbrevLabel.Location = New System.Drawing.Point(91, 188)
        Me.CapAndAbbrevLabel.Name = "CapAndAbbrevLabel"
        Me.CapAndAbbrevLabel.Size = New System.Drawing.Size(100, 25)
        Me.CapAndAbbrevLabel.TabIndex = 9
        Me.CapAndAbbrevLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlagBox
        '
        Me.FlagBox.Location = New System.Drawing.Point(13, 101)
        Me.FlagBox.Name = "FlagBox"
        Me.FlagBox.Size = New System.Drawing.Size(259, 84)
        Me.FlagBox.TabIndex = 10
        Me.FlagBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.FlagBox)
        Me.Controls.Add(Me.CapAndAbbrevLabel)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.FloridaButton)
        Me.Controls.Add(Me.AlabamaButton)
        Me.Controls.Add(Me.GeorgiaButton)
        Me.Controls.Add(Me.SouthCarolinaButton)
        Me.Controls.Add(Me.NorthCarolinaButton)
        Me.Controls.Add(Me.VirginiaButton)
        Me.Name = "Form1"
        Me.Text = "State Information by Nigel Mansell"
        CType(Me.FlagBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VirginiaButton As Button
    Friend WithEvents NorthCarolinaButton As Button
    Friend WithEvents SouthCarolinaButton As Button
    Friend WithEvents GeorgiaButton As Button
    Friend WithEvents AlabamaButton As Button
    Friend WithEvents FloridaButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents CapAndAbbrevLabel As Label
    Friend WithEvents FlagBox As PictureBox
End Class
