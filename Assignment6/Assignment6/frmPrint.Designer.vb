<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.grpBoxPrint = New System.Windows.Forms.GroupBox()
        Me.lstBoxPrint = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpBoxPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxPrint
        '
        Me.grpBoxPrint.Controls.Add(Me.lstBoxPrint)
        Me.grpBoxPrint.Location = New System.Drawing.Point(23, 30)
        Me.grpBoxPrint.Name = "grpBoxPrint"
        Me.grpBoxPrint.Size = New System.Drawing.Size(335, 148)
        Me.grpBoxPrint.TabIndex = 0
        Me.grpBoxPrint.TabStop = False
        Me.grpBoxPrint.Text = "Select a Print Book"
        '
        'lstBoxPrint
        '
        Me.lstBoxPrint.FormattingEnabled = True
        Me.lstBoxPrint.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstBoxPrint.Location = New System.Drawing.Point(17, 28)
        Me.lstBoxPrint.Name = "lstBoxPrint"
        Me.lstBoxPrint.Size = New System.Drawing.Size(286, 95)
        Me.lstBoxPrint.TabIndex = 0
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
        'frmPrint
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(393, 261)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpBoxPrint)
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Books"
        Me.grpBoxPrint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBoxPrint As GroupBox
    Friend WithEvents lstBoxPrint As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
End Class
