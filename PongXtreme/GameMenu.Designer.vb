<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resumeBtn = New System.Windows.Forms.Button()
        Me.newGameBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, -3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(445, 108)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PAUSED"
        '
        'resumeBtn
        '
        Me.resumeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.resumeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.resumeBtn.Location = New System.Drawing.Point(13, 131)
        Me.resumeBtn.Name = "resumeBtn"
        Me.resumeBtn.Size = New System.Drawing.Size(160, 69)
        Me.resumeBtn.TabIndex = 2
        Me.resumeBtn.Text = "RESUME"
        Me.resumeBtn.UseVisualStyleBackColor = False
        '
        'newGameBtn
        '
        Me.newGameBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newGameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.newGameBtn.Location = New System.Drawing.Point(179, 131)
        Me.newGameBtn.Name = "newGameBtn"
        Me.newGameBtn.Size = New System.Drawing.Size(160, 69)
        Me.newGameBtn.TabIndex = 3
        Me.newGameBtn.Text = "NEW GAME"
        Me.newGameBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exitBtn.Location = New System.Drawing.Point(342, 131)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(160, 69)
        Me.exitBtn.TabIndex = 4
        Me.exitBtn.Text = "EXIT"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'GameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(516, 207)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.newGameBtn)
        Me.Controls.Add(Me.resumeBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents resumeBtn As Button
    Friend WithEvents newGameBtn As Button
    Friend WithEvents exitBtn As Button
End Class
