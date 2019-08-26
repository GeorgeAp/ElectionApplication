<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container
        Me.pbLoginImage = New System.Windows.Forms.PictureBox
        Me.gbLogin = New System.Windows.Forms.GroupBox
        Me.txtLoginPasscode = New System.Windows.Forms.TextBox
        Me.txtLoginUsername = New System.Windows.Forms.TextBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.lblLoginPasscode = New System.Windows.Forms.Label
        Me.lblLoginUsername = New System.Windows.Forms.Label
        Me.lblDevelopedBy = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbLoginImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLoginImage
        '
        Me.pbLoginImage.Image = Global.Electoral_Commission_Voter.My.Resources.Resources.iaestelogo2
        Me.pbLoginImage.Location = New System.Drawing.Point(12, 12)
        Me.pbLoginImage.Name = "pbLoginImage"
        Me.pbLoginImage.Size = New System.Drawing.Size(182, 222)
        Me.pbLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoginImage.TabIndex = 0
        Me.pbLoginImage.TabStop = False
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.txtLoginPasscode)
        Me.gbLogin.Controls.Add(Me.txtLoginUsername)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.lblLoginPasscode)
        Me.gbLogin.Controls.Add(Me.lblLoginUsername)
        Me.gbLogin.Location = New System.Drawing.Point(200, 12)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(180, 183)
        Me.gbLogin.TabIndex = 1
        Me.gbLogin.TabStop = False
        '
        'txtLoginPasscode
        '
        Me.txtLoginPasscode.Location = New System.Drawing.Point(70, 77)
        Me.txtLoginPasscode.Name = "txtLoginPasscode"
        Me.txtLoginPasscode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPasscode.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginPasscode.TabIndex = 6
        '
        'txtLoginUsername
        '
        Me.txtLoginUsername.Location = New System.Drawing.Point(70, 25)
        Me.txtLoginUsername.Name = "txtLoginUsername"
        Me.txtLoginUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginUsername.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(56, 141)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblLoginPasscode
        '
        Me.lblLoginPasscode.AutoSize = True
        Me.lblLoginPasscode.Location = New System.Drawing.Point(6, 84)
        Me.lblLoginPasscode.Name = "lblLoginPasscode"
        Me.lblLoginPasscode.Size = New System.Drawing.Size(57, 13)
        Me.lblLoginPasscode.TabIndex = 2
        Me.lblLoginPasscode.Text = "Passcode:"
        '
        'lblLoginUsername
        '
        Me.lblLoginUsername.AutoSize = True
        Me.lblLoginUsername.Location = New System.Drawing.Point(6, 28)
        Me.lblLoginUsername.Name = "lblLoginUsername"
        Me.lblLoginUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblLoginUsername.TabIndex = 0
        Me.lblLoginUsername.Text = "Username:"
        '
        'lblDevelopedBy
        '
        Me.lblDevelopedBy.AutoSize = True
        Me.lblDevelopedBy.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDevelopedBy.Location = New System.Drawing.Point(206, 220)
        Me.lblDevelopedBy.Name = "lblDevelopedBy"
        Me.lblDevelopedBy.Size = New System.Drawing.Size(142, 13)
        Me.lblDevelopedBy.TabIndex = 3
        Me.lblDevelopedBy.Text = "Developed by Green Analyst"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 242)
        Me.Controls.Add(Me.lblDevelopedBy)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.pbLoginImage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Verification"
        CType(Me.pbLoginImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLoginImage As System.Windows.Forms.PictureBox
    Friend WithEvents gbLogin As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblLoginPasscode As System.Windows.Forms.Label
    Friend WithEvents lblLoginUsername As System.Windows.Forms.Label
    Friend WithEvents lblDevelopedBy As System.Windows.Forms.Label
    Friend WithEvents txtLoginPasscode As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginUsername As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
