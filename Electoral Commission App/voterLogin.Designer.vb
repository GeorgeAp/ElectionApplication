<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvoterLogin
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
        Me.txtVoterCode = New System.Windows.Forms.TextBox
        Me.lblVoterCode = New System.Windows.Forms.Label
        Me.btnVoterLogin = New System.Windows.Forms.Button
        Me.txtTotalVoters = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtVoterCode
        '
        Me.txtVoterCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoterCode.Location = New System.Drawing.Point(221, 133)
        Me.txtVoterCode.Multiline = True
        Me.txtVoterCode.Name = "txtVoterCode"
        Me.txtVoterCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVoterCode.Size = New System.Drawing.Size(245, 37)
        Me.txtVoterCode.TabIndex = 0
        '
        'lblVoterCode
        '
        Me.lblVoterCode.AutoSize = True
        Me.lblVoterCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblVoterCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoterCode.Location = New System.Drawing.Point(16, 133)
        Me.lblVoterCode.Name = "lblVoterCode"
        Me.lblVoterCode.Size = New System.Drawing.Size(199, 37)
        Me.lblVoterCode.TabIndex = 3
        Me.lblVoterCode.Text = "Voter Code:"
        '
        'btnVoterLogin
        '
        Me.btnVoterLogin.BackColor = System.Drawing.Color.Red
        Me.btnVoterLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoterLogin.Location = New System.Drawing.Point(264, 176)
        Me.btnVoterLogin.Name = "btnVoterLogin"
        Me.btnVoterLogin.Size = New System.Drawing.Size(146, 53)
        Me.btnVoterLogin.TabIndex = 4
        Me.btnVoterLogin.Text = "Enter"
        Me.btnVoterLogin.UseVisualStyleBackColor = False
        '
        'txtTotalVoters
        '
        Me.txtTotalVoters.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVoters.Location = New System.Drawing.Point(217, 274)
        Me.txtTotalVoters.Name = "txtTotalVoters"
        Me.txtTotalVoters.Size = New System.Drawing.Size(171, 31)
        Me.txtTotalVoters.TabIndex = 5
        Me.txtTotalVoters.Visible = False
        '
        'frmvoterLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotalVoters)
        Me.Controls.Add(Me.btnVoterLogin)
        Me.Controls.Add(Me.lblVoterCode)
        Me.Controls.Add(Me.txtVoterCode)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvoterLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voter Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVoterCode As System.Windows.Forms.TextBox
    Friend WithEvents lblVoterCode As System.Windows.Forms.Label
    Friend WithEvents btnVoterLogin As System.Windows.Forms.Button
    Friend WithEvents txtTotalVoters As System.Windows.Forms.TextBox
End Class
