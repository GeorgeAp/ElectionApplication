Public Class frmhelp

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        frmElectoralComOffice.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        rtbHelp.Text = "WELCOME TO THE HELP CENTER" & vbCrLf & "" & vbCrLf & "Procedure for setting the application before votting begins:" & vbCrLf & "" & vbCrLf & "1. Select the number of CANDIDATES for each position from the drop down on the right-bottom part of the administrator form." & vbCrLf & "NB: The number of candidates that you will choose should correspond to the number of CANDIDATES you want to display." & vbCrLf & "" & vbCrLf & "2. Click on the positions indicated at the right-hand side of the administrator form, a screen will appears for each position that you will click on at the right. Enter the names of the candidates in the textboxs on top of the screen that will appear, each name should be entered at the position that you want the candidate picture to appear. Click on the 'import' button to insert the pictures of the CANDIDATES corresponding to the names in the textboxs." & vbCrLf & "" & vbCrLf & "3. Please ONLY click on the 'RESULTS' at right-hand side of the form after the elections. This will generate the final results of the election in a pdf file if not connected to a printer " & vbCrLf & "" & vbCrLf & "4. Click on the 'Generate Passcode' and use the form that will appear to generate the voting codes" & vbCrLf & "" & vbCrLf & "5. To 'START' the voting process, click on the 'File', select 'Votting Screen' and the voting process has begun" & vbCrLf & "" & vbCrLf & "NB: You can get back to the EC Office from the votting section by entering the passcode for the administrator ELSE you cannot go back to the administrator form"
    End Sub
End Class