<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudio
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
        Me.lstBoxAudio = New System.Windows.Forms.ListBox()
        Me.grpBoxAudio = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpBoxAudio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBoxAudio
        '
        Me.lstBoxAudio.FormattingEnabled = True
        Me.lstBoxAudio.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstBoxAudio.Location = New System.Drawing.Point(17, 28)
        Me.lstBoxAudio.Name = "lstBoxAudio"
        Me.lstBoxAudio.Size = New System.Drawing.Size(286, 95)
        Me.lstBoxAudio.TabIndex = 0
        '
        'grpBoxAudio
        '
        Me.grpBoxAudio.Controls.Add(Me.lstBoxAudio)
        Me.grpBoxAudio.Location = New System.Drawing.Point(23, 30)
        Me.grpBoxAudio.Name = "grpBoxAudio"
        Me.grpBoxAudio.Size = New System.Drawing.Size(335, 148)
        Me.grpBoxAudio.TabIndex = 0
        Me.grpBoxAudio.TabStop = False
        Me.grpBoxAudio.Text = "GroupBox1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(75, 196)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 47)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add Books to Cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(209, 196)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 47)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmAudio
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(393, 261)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpBoxAudio)
        Me.Name = "frmAudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Audio Books"
        Me.grpBoxAudio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxAudio As ListBox
    Friend WithEvents grpBoxAudio As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
End Class
