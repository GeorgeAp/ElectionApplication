Imports Electoral_Commission_Voter.frmLogin
Imports Electoral_Commission_Voter.frmvoterLogin
Imports Electoral_Commission_Voter.frmvoter

Public Class frmElectoralComOffice

    Private Sub mnsVoterExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmLogin.Visible = True

    End Sub


    Private Sub frmElectoralComOffice_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mnsElectoralOfficeSettings.Visible = True
        gbPresident.Visible = False
        gbVPre.Visible = False
        gbSecretary.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = False
        gbCRecpt.Visible = False
        gbOfferR.Visible = False
        cmbPresident.SelectedIndex = 0
        cmbVPresident.SelectedIndex = 0
        cmbSecretary.SelectedIndex = 0
        cmbFSecretary.SelectedIndex = 0
        cmbOfferR.SelectedIndex = 0
        cmbPRO.SelectedIndex = 0

    End Sub

    Private Sub mnsPreSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsPreSetting.Click
        gbPresident.Visible = True
        gbVPre.Visible = False
        gbSecretary.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = False
        gbCRecpt.Visible = False
        gbOfferR.Visible = False

    End Sub

    Private Sub mnsPreVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbPresident.Visible = True

    End Sub

    Private Sub btnpbPre1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpbPre1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPre1.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnpbPre2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpbPre2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPre2.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnpbPre3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpbPre3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPre3.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnpbPre4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpbPre4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPre4.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnpbPre5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpbPre5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPre5.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub mnsSettingsExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsSettingsExit.Click
        Me.Hide()
        frmLogin.Visible = True
        frmLogin.txtLoginUsername.Focus()
    End Sub

    Private Sub mnsVotingScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsVotingScreen.Click
        Me.Hide()
        frmvoterLogin.Visible = True

    End Sub

    Private Sub mnsVPreSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsVPreSetting.Click
        gbPresident.Visible = False
        gbVPre.Visible = True
        gbSecretary.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = False
        gbCRecpt.Visible = False
        gbOfferR.Visible = False

    End Sub

    Private Sub btnImportVP1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportVP1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbVp1.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportVP2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportVP2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbVP2.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportVP3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportVP3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbVP3.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportVP4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportVP4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbVP4.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportVP5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportVP5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbVP5.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub mnsSecSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsSecSetting.Click
        gbSecretary.Visible = True
        gbPresident.Visible = False
        gbVPre.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = False
        gbCRecpt.Visible = False
        gbOfferR.Visible = False

    End Sub

    Private Sub btnSec1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbSec1.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnSec2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbSec2.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnSec3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbSec3.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnSec4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbSec4.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnSec5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSec5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbSec5.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub mnsFSecSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsFSecSetting.Click
        gbPresident.Visible = False
        gbVPre.Visible = False
        gbSecretary.Visible = False
        gbFSec.Visible = True
        gbPRO.Visible = False
        gbCRecpt.Visible = False
        gbOfferR.Visible = False

    End Sub

    Private Sub btnImportFS1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportFS1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbFSec1.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportFS2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportFS2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbFSec2.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportFS3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportFS3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbFSec3.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportFS4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportFS4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbFSec4.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportFS5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportFS5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbFSec5.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub mnsPROSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsPROSetting.Click
        gbPresident.Visible = False
        gbVPre.Visible = False
        gbSecretary.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = True
        gbCRecpt.Visible = False
        gbOfferR.Visible = False

    End Sub


    Private Sub btnImportPRO1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPRO1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPRO1.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub

    Private Sub btnImportPRO2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPRO2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPRO2.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub

    Private Sub btnImportPRO3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPRO3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPRO3.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub

    Private Sub btnImportPRO4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPRO4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPRO4.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub

    Private Sub btnImportPRO5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPRO5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbPRO5.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub
    Private Sub mnsCRecepSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbPresident.Visible = False
        gbVPre.Visible = False
        gbSecretary.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = False
        gbCRecpt.Visible = True
        gbOfferR.Visible = False

    End Sub

    Private Sub btnImportCRecpt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportCRecpt1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbCRecpt1.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub

    Private Sub btnImportCRecpt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportCRecpt2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbCRecpt2.Image = Image.FromFile(ofdPicBox.FileName)
        End If

    End Sub

    Private Sub btnImportCRecpt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportCRecpt3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbCRecpt3.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportCRecpt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportCRecpt4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbCRecpt4.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportCRecpt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportCRecpt5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbCRecpt5.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub mnsORaisOSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnsORaisOSetting.Click
        gbPresident.Visible = False
        gbVPre.Visible = False
        gbSecretary.Visible = False
        gbFSec.Visible = False
        gbPRO.Visible = False
        gbCRecpt.Visible = False
        gbOfferR.Visible = True


    End Sub

    Private Sub btnImportOfferR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportOfferR1.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbOfferR1.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportOfferR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportOfferR2.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbOfferR2.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportOfferR3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportOfferR3.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbOfferR3.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportOfferR4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportOfferR4.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbOfferR4.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub btnImportOfferR5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportOfferR5.Click
        If ofdPicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbOfferR5.Image = Image.FromFile(ofdPicBox.FileName)
        End If
    End Sub

    Private Sub RESULTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESULTSToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintDocument1.DefaultPageSettings.Margins.Left = 0
        PrintDocument1.DefaultPageSettings.Margins.Right = 0

        Dim horizontalPrintPosition As Single
        Dim verticalPrintPosition As Single
        Dim print1Font As New Font("Arial", 16)
        Dim print2Font As New Font("Arial", 15, GraphicsUnit.Point)
        Dim print3Font As New Font("Arial", 14, GraphicsUnit.Point)
        Dim print4Font As New Font("Arial", 12, GraphicsUnit.Point)
        Dim print5Font As New Font("Arial", 8, GraphicsUnit.Point)

        Dim x1 As Single = 40.0F
        Dim y1 As Single = 20.0F
        Dim width1 As Single = 95.0F
        Dim height1 As Single = 75.0F
        Dim drawRect1 As New RectangleF(x1, y1, width1, height1)

        horizontalPrintPosition = e.MarginBounds.Left
        verticalPrintPosition = e.MarginBounds.Top

        e.Graphics.DrawImage(PictureBox1.Image, drawRect1)
        e.Graphics.DrawString("IAESTE Ghana,", print5Font, Brushes.Black, 700, 5)
        e.Graphics.DrawString("KNUST Local Committee,", print5Font, Brushes.Black, 700, 30)
        e.Graphics.DrawString("KNUST Kumasi, Ghana.", print5Font, Brushes.Black, 700, 50)
        e.Graphics.DrawString("www.iaeste.org", print5Font, Brushes.Black, 700, 80)
        e.Graphics.DrawString("iaeste.knust@gmail.com", print5Font, Brushes.Black, 700, 100)
        e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------", print3Font, Brushes.Black, 0, 130)
        e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------", print3Font, Brushes.Black, 0, 135)
        e.Graphics.DrawString("ELECTION RESULTS:", print4Font, Brushes.Black, 150, 170)
        e.Graphics.DrawString("President", print4Font, Brushes.Black, 150, 220)
        If cmbPresident.SelectedIndex = 0 Then
            e.Graphics.DrawString(txtPre1Name.Text & "    ......    " & frmvoter.TextBox1.Text, print4Font, Brushes.Black, 150, 240)
        ElseIf cmbPresident.SelectedIndex = 1 Then
            e.Graphics.DrawString(txtPre1Name.Text & "    ......    " & frmvoter.TextBox1.Text, print4Font, Brushes.Black, 150, 240)
            e.Graphics.DrawString(txtPre2Name.Text & "    ......    " & frmvoter.TextBox2.Text, print4Font, Brushes.Black, 150, 260)
        ElseIf cmbPresident.SelectedIndex = 2 Then
            e.Graphics.DrawString(txtPre1Name.Text & "    ......    " & frmvoter.TextBox1.Text, print4Font, Brushes.Black, 150, 240)
            e.Graphics.DrawString(txtPre2Name.Text & "    ......    " & frmvoter.TextBox2.Text, print4Font, Brushes.Black, 150, 260)
            e.Graphics.DrawString(txtPre3Name.Text & "    ......    " & frmvoter.TextBox3.Text, print4Font, Brushes.Black, 150, 280)
        ElseIf cmbPresident.SelectedIndex = 3 Then
            e.Graphics.DrawString(txtPre1Name.Text & "    ......    " & frmvoter.TextBox1.Text, print4Font, Brushes.Black, 150, 240)
            e.Graphics.DrawString(txtPre2Name.Text & "    ......    " & frmvoter.TextBox2.Text, print4Font, Brushes.Black, 150, 260)
            e.Graphics.DrawString(txtPre3Name.Text & "    ......    " & frmvoter.TextBox3.Text, print4Font, Brushes.Black, 150, 280)
            e.Graphics.DrawString(txtPre4Name.Text & "    ......    " & frmvoter.TextBox4.Text, print4Font, Brushes.Black, 150, 300)
        ElseIf cmbPresident.SelectedIndex = 4 Then
            e.Graphics.DrawString(txtPre1Name.Text & "    ......    " & frmvoter.TextBox1.Text, print4Font, Brushes.Black, 150, 240)
            e.Graphics.DrawString(txtPre2Name.Text & "    ......    " & frmvoter.TextBox2.Text, print4Font, Brushes.Black, 150, 260)
            e.Graphics.DrawString(txtPre3Name.Text & "    ......    " & frmvoter.TextBox3.Text, print4Font, Brushes.Black, 150, 280)
            e.Graphics.DrawString(txtPre4Name.Text & "    ......    " & frmvoter.TextBox4.Text, print4Font, Brushes.Black, 150, 300)
            e.Graphics.DrawString(txtPre5Name.Text & "    ......    " & frmvoter.TextBox5.Text, print4Font, Brushes.Black, 150, 320)
        End If
        e.Graphics.DrawString("------------------------------------------------------------------", print3Font, Brushes.Black, 150, 340)
        e.Graphics.DrawString("Vice President", print4Font, Brushes.Black, 150, 360)
        If cmbVPresident.SelectedIndex = 0 Then
            e.Graphics.DrawString(txtVPname1.Text & "     ......    " & frmvoter.TextBox6.Text, print4Font, Brushes.Black, 150, 380)
        ElseIf cmbVPresident.SelectedIndex = 1 Then
            e.Graphics.DrawString(txtVPname1.Text & "     ......    " & frmvoter.TextBox6.Text, print4Font, Brushes.Black, 150, 380)
            e.Graphics.DrawString(txtVPname2.Text & "     ......    " & frmvoter.TextBox7.Text, print4Font, Brushes.Black, 150, 400)
        ElseIf cmbVPresident.SelectedIndex = 2 Then
            e.Graphics.DrawString(txtVPname1.Text & "     ......    " & frmvoter.TextBox6.Text, print4Font, Brushes.Black, 150, 380)
            e.Graphics.DrawString(txtVPname2.Text & "     ......    " & frmvoter.TextBox7.Text, print4Font, Brushes.Black, 150, 400)
            e.Graphics.DrawString(txtVPname3.Text & "     ......    " & frmvoter.TextBox8.Text, print4Font, Brushes.Black, 150, 420)
        ElseIf cmbVPresident.SelectedIndex = 3 Then
            e.Graphics.DrawString(txtVPname1.Text & "     ......    " & frmvoter.TextBox6.Text, print4Font, Brushes.Black, 150, 380)
            e.Graphics.DrawString(txtVPname2.Text & "     ......    " & frmvoter.TextBox7.Text, print4Font, Brushes.Black, 150, 400)
            e.Graphics.DrawString(txtVPname3.Text & "     ......    " & frmvoter.TextBox8.Text, print4Font, Brushes.Black, 150, 420)
            e.Graphics.DrawString(txtVPname4.Text & "     ......    " & frmvoter.TextBox9.Text, print4Font, Brushes.Black, 150, 440)
        ElseIf cmbVPresident.SelectedIndex = 4 Then
            e.Graphics.DrawString(txtVPname1.Text & "     ......    " & frmvoter.TextBox6.Text, print4Font, Brushes.Black, 150, 380)
            e.Graphics.DrawString(txtVPname2.Text & "     ......    " & frmvoter.TextBox7.Text, print4Font, Brushes.Black, 150, 400)
            e.Graphics.DrawString(txtVPname3.Text & "     ......    " & frmvoter.TextBox8.Text, print4Font, Brushes.Black, 150, 420)
            e.Graphics.DrawString(txtVPname4.Text & "     ......    " & frmvoter.TextBox9.Text, print4Font, Brushes.Black, 150, 440)
            e.Graphics.DrawString(txtVPname5.Text & "     ......    " & frmvoter.TextBox10.Text, print4Font, Brushes.Black, 150, 460)
        End If
        e.Graphics.DrawString("------------------------------------------------------------------", print3Font, Brushes.Black, 150, 480)
        e.Graphics.DrawString("Secretary", print4Font, Brushes.Black, 150, 500)
        If cmbSecretary.SelectedIndex = 0 Then
            e.Graphics.DrawString(txtSecName1.Text & "    ......    " & frmvoter.TextBox11.Text, print4Font, Brushes.Black, 150, 520)
        ElseIf cmbSecretary.SelectedIndex = 1 Then
            e.Graphics.DrawString(txtSecName1.Text & "    ......    " & frmvoter.TextBox11.Text, print4Font, Brushes.Black, 150, 520)
            e.Graphics.DrawString(txtSecName2.Text & "    ......    " & frmvoter.TextBox12.Text, print4Font, Brushes.Black, 150, 540)
        ElseIf cmbSecretary.SelectedIndex = 2 Then
            e.Graphics.DrawString(txtSecName1.Text & "    ......    " & frmvoter.TextBox11.Text, print4Font, Brushes.Black, 150, 520)
            e.Graphics.DrawString(txtSecName2.Text & "    ......    " & frmvoter.TextBox12.Text, print4Font, Brushes.Black, 150, 540)
            e.Graphics.DrawString(txtSecName3.Text & "    ......    " & frmvoter.TextBox13.Text, print4Font, Brushes.Black, 150, 560)
        ElseIf cmbSecretary.SelectedIndex = 3 Then
            e.Graphics.DrawString(txtSecName1.Text & "    ......    " & frmvoter.TextBox11.Text, print4Font, Brushes.Black, 150, 520)
            e.Graphics.DrawString(txtSecName2.Text & "    ......    " & frmvoter.TextBox12.Text, print4Font, Brushes.Black, 150, 540)
            e.Graphics.DrawString(txtSecName3.Text & "    ......    " & frmvoter.TextBox13.Text, print4Font, Brushes.Black, 150, 560)
            e.Graphics.DrawString(txtSecName4.Text & "    ......    " & frmvoter.TextBox14.Text, print4Font, Brushes.Black, 150, 580)
        ElseIf cmbSecretary.SelectedIndex = 4 Then
            e.Graphics.DrawString(txtSecName1.Text & "    ......    " & frmvoter.TextBox11.Text, print4Font, Brushes.Black, 150, 520)
            e.Graphics.DrawString(txtSecName2.Text & "    ......    " & frmvoter.TextBox12.Text, print4Font, Brushes.Black, 150, 540)
            e.Graphics.DrawString(txtSecName3.Text & "    ......    " & frmvoter.TextBox13.Text, print4Font, Brushes.Black, 150, 560)
            e.Graphics.DrawString(txtSecName4.Text & "    ......    " & frmvoter.TextBox14.Text, print4Font, Brushes.Black, 150, 580)
            e.Graphics.DrawString(txtSecName5.Text & "    ......    " & frmvoter.TextBox15.Text, print4Font, Brushes.Black, 150, 600)
        End If
        e.Graphics.DrawString("------------------------------------------------------------------", print3Font, Brushes.Black, 150, 620)
        e.Graphics.DrawString("Financial Secretary", print4Font, Brushes.Black, 150, 640)
        If cmbFSecretary.SelectedIndex = 0 Then
            e.Graphics.DrawString(txtFSecName1.Text & "    ......    " & frmvoter.TextBox16.Text, print4Font, Brushes.Black, 150, 660)
        ElseIf cmbFSecretary.SelectedIndex = 1 Then
            e.Graphics.DrawString(txtFSecName1.Text & "    ......    " & frmvoter.TextBox16.Text, print4Font, Brushes.Black, 150, 660)
            e.Graphics.DrawString(txtFSecName2.Text & "    ......    " & frmvoter.TextBox17.Text, print4Font, Brushes.Black, 150, 680)
        ElseIf cmbFSecretary.SelectedIndex = 2 Then
            e.Graphics.DrawString(txtFSecName1.Text & "    ......    " & frmvoter.TextBox16.Text, print4Font, Brushes.Black, 150, 660)
            e.Graphics.DrawString(txtFSecName2.Text & "    ......    " & frmvoter.TextBox17.Text, print4Font, Brushes.Black, 150, 680)
            e.Graphics.DrawString(txtFSecName3.Text & "    ......    " & frmvoter.TextBox18.Text, print4Font, Brushes.Black, 150, 700)
        ElseIf cmbFSecretary.SelectedIndex = 3 Then
            e.Graphics.DrawString(txtFSecName1.Text & "    ......    " & frmvoter.TextBox16.Text, print4Font, Brushes.Black, 150, 660)
            e.Graphics.DrawString(txtFSecName2.Text & "    ......    " & frmvoter.TextBox17.Text, print4Font, Brushes.Black, 150, 680)
            e.Graphics.DrawString(txtFSecName3.Text & "    ......    " & frmvoter.TextBox18.Text, print4Font, Brushes.Black, 150, 700)
            e.Graphics.DrawString(txtFSecName4.Text & "    ......    " & frmvoter.TextBox19.Text, print4Font, Brushes.Black, 150, 720)
        ElseIf cmbFSecretary.SelectedIndex = 4 Then
            e.Graphics.DrawString(txtFSecName1.Text & "    ......    " & frmvoter.TextBox16.Text, print4Font, Brushes.Black, 150, 660)
            e.Graphics.DrawString(txtFSecName2.Text & "    ......    " & frmvoter.TextBox17.Text, print4Font, Brushes.Black, 150, 680)
            e.Graphics.DrawString(txtFSecName3.Text & "    ......    " & frmvoter.TextBox18.Text, print4Font, Brushes.Black, 150, 700)
            e.Graphics.DrawString(txtFSecName4.Text & "    ......    " & frmvoter.TextBox19.Text, print4Font, Brushes.Black, 150, 720)
            e.Graphics.DrawString(txtFSecName5.Text & "    ......    " & frmvoter.TextBox20.Text, print4Font, Brushes.Black, 150, 740)
        End If
        e.Graphics.DrawString("------------------------------------------------------------------", print3Font, Brushes.Black, 150, 760)
        e.Graphics.DrawString("Public Relations Officer", print4Font, Brushes.Black, 150, 780)
        If cmbPRO.SelectedIndex = 0 Then
            e.Graphics.DrawString(txtPROname1.Text & "    ......    " & frmvoter.TextBox21.Text, print4Font, Brushes.Black, 150, 800)
        ElseIf cmbPRO.SelectedIndex = 1 Then
            e.Graphics.DrawString(txtPROname1.Text & "    ......    " & frmvoter.TextBox21.Text, print4Font, Brushes.Black, 150, 800)
            e.Graphics.DrawString(txtPROname2.Text & "    ......    " & frmvoter.TextBox22.Text, print4Font, Brushes.Black, 150, 820)
        ElseIf cmbPRO.SelectedIndex = 2 Then
            e.Graphics.DrawString(txtPROname1.Text & "    ......    " & frmvoter.TextBox21.Text, print4Font, Brushes.Black, 150, 800)
            e.Graphics.DrawString(txtPROname2.Text & "    ......    " & frmvoter.TextBox22.Text, print4Font, Brushes.Black, 150, 820)
            e.Graphics.DrawString(txtPROname3.Text & "    ......    " & frmvoter.TextBox23.Text, print4Font, Brushes.Black, 150, 840)
        ElseIf cmbPRO.SelectedIndex = 3 Then
            e.Graphics.DrawString(txtPROname1.Text & "    ......    " & frmvoter.TextBox21.Text, print4Font, Brushes.Black, 150, 800)
            e.Graphics.DrawString(txtPROname2.Text & "    ......    " & frmvoter.TextBox22.Text, print4Font, Brushes.Black, 150, 820)
            e.Graphics.DrawString(txtPROname3.Text & "    ......    " & frmvoter.TextBox23.Text, print4Font, Brushes.Black, 150, 840)
            e.Graphics.DrawString(txtPROname4.Text & "    ......    " & frmvoter.TextBox24.Text, print4Font, Brushes.Black, 150, 860)
        ElseIf cmbPRO.SelectedIndex = 4 Then
            e.Graphics.DrawString(txtPROname1.Text & "    ......    " & frmvoter.TextBox21.Text, print4Font, Brushes.Black, 150, 800)
            e.Graphics.DrawString(txtPROname2.Text & "    ......    " & frmvoter.TextBox22.Text, print4Font, Brushes.Black, 150, 820)
            e.Graphics.DrawString(txtPROname3.Text & "    ......    " & frmvoter.TextBox23.Text, print4Font, Brushes.Black, 150, 840)
            e.Graphics.DrawString(txtPROname4.Text & "    ......    " & frmvoter.TextBox24.Text, print4Font, Brushes.Black, 150, 860)
            e.Graphics.DrawString(txtPROname5.Text & "    ......    " & frmvoter.TextBox25.Text, print4Font, Brushes.Black, 150, 880)
        End If
        e.Graphics.DrawString("------------------------------------------------------------------", print3Font, Brushes.Black, 150, 900)
        e.Graphics.DrawString("Offer Raising Chairman", print4Font, Brushes.Black, 150, 920)
        If cmbOfferR.SelectedIndex = 0 Then
            e.Graphics.DrawString(txtOfferR1.Text & "    ......    " & frmvoter.TextBox26.Text, print4Font, Brushes.Black, 150, 940)
        ElseIf cmbOfferR.SelectedIndex = 1 Then
            e.Graphics.DrawString(txtOfferR1.Text & "    ......    " & frmvoter.TextBox26.Text, print4Font, Brushes.Black, 150, 940)
            e.Graphics.DrawString(txtOfferR2.Text & "    ......    " & frmvoter.TextBox27.Text, print4Font, Brushes.Black, 150, 960)
        ElseIf cmbOfferR.SelectedIndex = 2 Then
            e.Graphics.DrawString(txtOfferR1.Text & "    ......    " & frmvoter.TextBox26.Text, print4Font, Brushes.Black, 150, 940)
            e.Graphics.DrawString(txtOfferR2.Text & "    ......    " & frmvoter.TextBox27.Text, print4Font, Brushes.Black, 150, 960)
            e.Graphics.DrawString(txtOfferR3.Text & "    ......    " & frmvoter.TextBox28.Text, print4Font, Brushes.Black, 150, 980)
        ElseIf cmbOfferR.SelectedIndex = 3 Then
            e.Graphics.DrawString(txtOfferR1.Text & "    ......    " & frmvoter.TextBox26.Text, print4Font, Brushes.Black, 150, 940)
            e.Graphics.DrawString(txtOfferR2.Text & "    ......    " & frmvoter.TextBox27.Text, print4Font, Brushes.Black, 150, 960)
            e.Graphics.DrawString(txtOfferR3.Text & "    ......    " & frmvoter.TextBox28.Text, print4Font, Brushes.Black, 150, 980)
            e.Graphics.DrawString(txtOfferR4.Text & "    ......    " & frmvoter.TextBox29.Text, print4Font, Brushes.Black, 150, 1000)
        ElseIf cmbOfferR.SelectedIndex = 4 Then
            e.Graphics.DrawString(txtOfferR1.Text & "    ......    " & frmvoter.TextBox26.Text, print4Font, Brushes.Black, 150, 940)
            e.Graphics.DrawString(txtOfferR2.Text & "    ......    " & frmvoter.TextBox27.Text, print4Font, Brushes.Black, 150, 960)
            e.Graphics.DrawString(txtOfferR3.Text & "    ......    " & frmvoter.TextBox28.Text, print4Font, Brushes.Black, 150, 980)
            e.Graphics.DrawString(txtOfferR4.Text & "    ......    " & frmvoter.TextBox29.Text, print4Font, Brushes.Black, 150, 1000)
            e.Graphics.DrawString(txtOfferR5.Text & "    ......    " & frmvoter.TextBox30.Text, print4Font, Brushes.Black, 150, 1020)
        End If
        e.Graphics.DrawString("------------------------------------------------------------------", print3Font, Brushes.Black, 150, 1040)
        e.Graphics.DrawString("Electoral Commissioner:   ...............................", print4Font, Brushes.Black, 150, 1060)
        e.Graphics.DrawString("Total Votes: " & frmvoterLogin.txtTotalVoters.Text, print4Font, Brushes.Black, 670, 1060)
        e.Graphics.DrawString("Signature:   .......................................", print4Font, Brushes.Black, 150, 1080)
        e.Graphics.DrawString(Format(Now, "dd/MM/yyyy"), print4Font, Brushes.Black, 670, 1080)

    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Me.Hide()
        frmGenPasscode.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmhelp.Show()
    End Sub
End Class