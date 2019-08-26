Imports Electoral_Commission_Voter.frmvoter
Imports Electoral_Commission_Voter.frmElectoralComOffice
Imports Electoral_Commission_Voter.frmvoterLogin

Public Class frmLogin
    Dim MyRand As New Random

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtLoginPasscode.Text = "" Or txtLoginUsername.Text = "" Then
            MessageBox.Show("Please fill all spaces", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtLoginUsername.Text = "admin" And txtLoginPasscode.Text = "a2p5p2p1" Then
            frmElectoralComOffice.Show()
            txtLoginPasscode.Clear()
            txtLoginUsername.Clear()
            txtLoginUsername.Focus()
            Me.Hide()
        Else
            MessageBox.Show("Please wrong input", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Now > #4/6/2018 6:00:00 PM# Then
            '     m, d,yyyy , hr, m, s   
            MessageBox.Show("Sorry, this application expired." & Environment.NewLine & "Contact george.apaaboah@gmail.com for update, Thank you", "Application Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Dim crassh As Integer
            Dim crr As Integer = 0
            Me.Close()
        ElseIf Now < #3/6/2016 6:00:00 AM# Then
            '         m, d,yyyy , hr, m, s     
            MessageBox.Show("Application uses your system date settings." & Environment.NewLine & "Set your system date correctly to run the application.", "Application Security", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            End
        End If
        'gbLogin.Select()
        txtLoginUsername.Select()
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    If Now = New Date(2013, 3, 17, 8, 2, 0) Then
    '        '             yyyy, m, d , hr, m, s
    '        For Each con As Control In Me.Controls
    '            With con
    '                .Left = MyRand.Next(0, Me.Width - con.Width)
    '                .Top = MyRand.Next(0, Me.Height - con.Height)
    '            End With
    '        Next
    '    End If
    'End Sub
End Class
