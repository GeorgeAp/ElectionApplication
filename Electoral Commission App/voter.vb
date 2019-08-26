'Imports System.Data
'Imports System.Data.Odbc
Imports Electoral_Commission_Voter.frmElectoralComOffice
Imports Electoral_Commission_Voter.frmLogin

Public Class frmvoter
    Dim p1, p2, p3, p4, p5, vp1, vp2, vp3, vp4, vp5, s1, s2, s3, s4, s5, fs1, fs2, fs3, fs4, fs5, pro1, pro2, pro3, pro4, pro5, of1, of2, of3, of4, of5 As Integer
    'Dim myStrConnect As New dbconnection
    'Dim myStr As String = myStrConnect.eVoterr
    'Dim myConnection As New OdbcConnection(myStr)
    'Dim Da As OdbcDataAdapter
    'Dim Ds As DataSet
    'Dim Dv As DataView
    'Dim cm As CurrencyManager
    'Dim sqlTest As String
    'Dim cmd As New OdbcCommand
    'Dim cmb As New Odbc.OdbcCommandBuilder(Da)
    'Dim dr As OdbcDataReader

    'Dim datte As Date = Date.Now
    'Dim fomat As String = "dd - MM - yyyy"
    'Dim ID As Integer

    'Private Sub FillData(ByVal tableName As String)
    '    Da = New OdbcDataAdapter(sqlTest, myConnection)
    '    Ds = New DataSet
    '    Da.Fill(Ds, tableName)
    '    Dv = New DataView(Ds.Tables(tableName))
    '    cm = CType(Me.BindingContext(Dv), CurrencyManager)
    'End Sub

    Private Sub frmvoter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p2 = p3 = p4 = p5 = vp1 = vp2 = vp3 = vp4 = vp5 = s1 = s2 = s3 = s4 = s5 = fs1 = fs2 = fs3 = fs4 = fs5 = pro1 = pro2 = pro3 = pro4 = pro5 = of1 = of2 = of3 = of4 = of5 = 0
        p1 = 0
        pbPre1v.Image = frmElectoralComOffice.pbPre1.Image
        pbPre2v.Image = frmElectoralComOffice.pbPre2.Image
        pbPre3v.Image = frmElectoralComOffice.pbPre3.Image
        pbPre4v.Image = frmElectoralComOffice.pbPre4.Image
        pbPre5v.Image = frmElectoralComOffice.pbPre5.Image
        txtPre1v.Text = frmElectoralComOffice.txtPre1Name.Text
        txtPre2v.Text = frmElectoralComOffice.txtPre2Name.Text
        txtPre3v.Text = frmElectoralComOffice.txtPre3Name.Text
        txtPre4v.Text = frmElectoralComOffice.txtPre4Name.Text
        txtPre5v.Text = frmElectoralComOffice.txtPre5Name.Text

        PresidentToolStripMenuItem.Visible = True
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = False
        ChiefReceptionistToolStripMenuItem.Visible = False
        VicePresidentToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = True
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        'Label6.Visible = False
        'Label7.Visible = False
        'Label8.Visible = False
        'Label9.Visible = False
        'Label10.Visible = False
        'Label11.Visible = False
        'Label12.Visible = False

        pbVp1v.Image = frmElectoralComOffice.pbVp1.Image
        pbVP2v.Image = frmElectoralComOffice.pbVP2.Image
        pbVP3v.Image = frmElectoralComOffice.pbVP3.Image
        pbVP4v.Image = frmElectoralComOffice.pbVP4.Image
        pbVP5v.Image = frmElectoralComOffice.pbVP5.Image
        txtVPname1v.Text = frmElectoralComOffice.txtVPname1.Text
        txtVPname2v.Text = frmElectoralComOffice.txtVPname2.Text
        txtVPname3v.Text = frmElectoralComOffice.txtVPname3.Text
        txtVPname4v.Text = frmElectoralComOffice.txtVPname4.Text
        txtVPname5v.Text = frmElectoralComOffice.txtVPname5.Text

        pbSec1v.Image = frmElectoralComOffice.pbSec1.Image
        pbSec2v.Image = frmElectoralComOffice.pbSec2.Image
        pbSec3v.Image = frmElectoralComOffice.pbSec3.Image
        pbSec4v.Image = frmElectoralComOffice.pbSec4.Image
        pbSec5v.Image = frmElectoralComOffice.pbSec5.Image
        txtSecName1v.Text = frmElectoralComOffice.txtSecName1.Text
        txtSecName2v.Text = frmElectoralComOffice.txtSecName2.Text
        txtSecName3v.Text = frmElectoralComOffice.txtSecName3.Text
        txtSecName4v.Text = frmElectoralComOffice.txtSecName4.Text
        txtSecName5v.Text = frmElectoralComOffice.txtSecName5.Text

        pbFSec1v.Image = frmElectoralComOffice.pbFSec1.Image
        pbFSec2v.Image = frmElectoralComOffice.pbFSec2.Image
        pbFSec3v.Image = frmElectoralComOffice.pbFSec3.Image
        pbFSec4v.Image = frmElectoralComOffice.pbFSec4.Image
        pbFSec5v.Image = frmElectoralComOffice.pbFSec5.Image
        txtFSecName1v.Text = frmElectoralComOffice.txtFSecName1.Text
        txtFSecName2v.Text = frmElectoralComOffice.txtFSecName2.Text
        txtFSecName3v.Text = frmElectoralComOffice.txtFSecName3.Text
        txtFSecName4v.Text = frmElectoralComOffice.txtFSecName4.Text
        txtFSecName5v.Text = frmElectoralComOffice.txtFSecName5.Text

        pbCRecpt1v.Image = frmElectoralComOffice.pbCRecpt1.Image
        pbCRecpt2v.Image = frmElectoralComOffice.pbCRecpt2.Image
        pbCRecpt3v.Image = frmElectoralComOffice.pbCRecpt3.Image
        pbCRecpt4v.Image = frmElectoralComOffice.pbCRecpt4.Image
        pbCRecpt5v.Image = frmElectoralComOffice.pbCRecpt5.Image
        txtCRecptname1v.Text = frmElectoralComOffice.txtCRecptname1.Text
        txtCRecptname2v.Text = frmElectoralComOffice.txtCRecptname2.Text
        txtCRecptname3v.Text = frmElectoralComOffice.txtCRecptname3.Text
        txtCRecptname4v.Text = frmElectoralComOffice.txtCRecptname4.Text
        txtCRecptname5v.Text = frmElectoralComOffice.txtCRecptname5.Text

        pbPRO1v.Image = frmElectoralComOffice.pbPRO1.Image
        pbPRO2v.Image = frmElectoralComOffice.pbPRO2.Image
        pbPRO3v.Image = frmElectoralComOffice.pbPRO3.Image
        pbPRO4v.Image = frmElectoralComOffice.pbPRO4.Image
        pbPRO5v.Image = frmElectoralComOffice.pbPRO5.Image
        txtPROname1.Text = frmElectoralComOffice.txtPROname1.Text
        txtPROname2.Text = frmElectoralComOffice.txtPROname2.Text
        txtPROname3.Text = frmElectoralComOffice.txtPROname3.Text
        txtPROname4.Text = frmElectoralComOffice.txtPROname4.Text
        txtPROname5.Text = frmElectoralComOffice.txtPROname5.Text

        pbOfferR1v.Image = frmElectoralComOffice.pbOfferR1.Image
        pbOfferR2v.Image = frmElectoralComOffice.pbOfferR2.Image
        pbOfferR3v.Image = frmElectoralComOffice.pbOfferR3.Image
        pbOfferR4v.Image = frmElectoralComOffice.pbOfferR4.Image
        pbOfferR5v.Image = frmElectoralComOffice.pbOfferR5.Image
        txtOfferR1v.Text = frmElectoralComOffice.txtOfferR1.Text
        txtOfferR2v.Text = frmElectoralComOffice.txtOfferR2.Text
        txtOfferR3v.Text = frmElectoralComOffice.txtOfferR3.Text
        txtOfferR4v.Text = frmElectoralComOffice.txtOfferR4.Text
        txtOfferR5v.Text = frmElectoralComOffice.txtOfferR5.Text

        btnVote.Visible = False

        If frmElectoralComOffice.cmbPresident.SelectedIndex = 0 Then
            rbPre2Yes.Visible = False
            rbPre3Yes.Visible = False
            rbPre4Yes.Visible = False
            rbPre5Yes.Visible = False
            txtPre2v.Visible = False
            txtPre3v.Visible = False
            txtPre4v.Visible = False
            txtPre5v.Visible = False
            pbPre2v.Visible = False
            pbPre3v.Visible = False
            pbPre4v.Visible = False
            pbPre5v.Visible = False
        ElseIf frmElectoralComOffice.cmbPresident.SelectedIndex = 1 Then
            rbPre3Yes.Visible = False
            rbPre4Yes.Visible = False
            rbPre5Yes.Visible = False
            txtPre3v.Visible = False
            txtPre4v.Visible = False
            txtPre5v.Visible = False
            pbPre3v.Visible = False
            pbPre4v.Visible = False
            pbPre5v.Visible = False
        ElseIf frmElectoralComOffice.cmbPresident.SelectedIndex = 2 Then
            rbPre4Yes.Visible = False
            rbPre5Yes.Visible = False
            txtPre4v.Visible = False
            txtPre5v.Visible = False
            pbPre4v.Visible = False
            pbPre5v.Visible = False
        ElseIf frmElectoralComOffice.cmbPresident.SelectedIndex = 3 Then
            rbPre5Yes.Visible = False
            txtPre5v.Visible = False
            pbPre5v.Visible = False
        End If
        '
        If frmElectoralComOffice.cmbVPresident.SelectedIndex = 0 Then
            rbVP2.Visible = False
            rbVP3.Visible = False
            rbVP4.Visible = False
            rbVP5.Visible = False
            txtVPname2v.Visible = False
            txtVPname3v.Visible = False
            txtVPname4v.Visible = False
            txtVPname5v.Visible = False
            pbVP2v.Visible = False
            pbVP3v.Visible = False
            pbVP4v.Visible = False
            pbVP5v.Visible = False
        ElseIf frmElectoralComOffice.cmbVPresident.SelectedIndex = 1 Then
            rbVP3.Visible = False
            rbVP4.Visible = False
            rbVP5.Visible = False
            txtVPname3v.Visible = False
            txtVPname4v.Visible = False
            txtVPname5v.Visible = False
            pbVP3v.Visible = False
            pbVP4v.Visible = False
            pbVP5v.Visible = False
        ElseIf frmElectoralComOffice.cmbVPresident.SelectedIndex = 2 Then
            rbVP4.Visible = False
            rbVP5.Visible = False
            txtVPname4v.Visible = False
            txtVPname5v.Visible = False
            pbVP4v.Visible = False
            pbVP5v.Visible = False
        ElseIf frmElectoralComOffice.cmbVPresident.SelectedIndex = 3 Then
            rbVP5.Visible = False
            txtVPname5v.Visible = False
            pbVP5v.Visible = False
        End If
        '
        If frmElectoralComOffice.cmbSecretary.SelectedIndex = 0 Then
            rbSec2.Visible = False
            rbSec3.Visible = False
            rbSec4.Visible = False
            rbSec5.Visible = False
            txtSecName2v.Visible = False
            txtSecName3v.Visible = False
            txtSecName4v.Visible = False
            txtSecName5v.Visible = False
            pbSec2v.Visible = False
            pbSec3v.Visible = False
            pbSec4v.Visible = False
            pbSec5v.Visible = False
        ElseIf frmElectoralComOffice.cmbSecretary.SelectedIndex = 1 Then
            rbSec3.Visible = False
            rbSec4.Visible = False
            rbSec5.Visible = False
            txtSecName3v.Visible = False
            txtSecName4v.Visible = False
            txtSecName5v.Visible = False
            pbSec3v.Visible = False
            pbSec4v.Visible = False
            pbSec5v.Visible = False
        ElseIf frmElectoralComOffice.cmbSecretary.SelectedIndex = 2 Then
            rbSec4.Visible = False
            rbSec5.Visible = False
            txtSecName4v.Visible = False
            txtSecName5v.Visible = False
            pbSec4v.Visible = False
            pbSec5v.Visible = False
        ElseIf frmElectoralComOffice.cmbSecretary.SelectedIndex = 3 Then
            rbSec5.Visible = False
            txtSecName5v.Visible = False
            pbSec5v.Visible = False
        End If
        '
        If frmElectoralComOffice.cmbFSecretary.SelectedIndex = 0 Then
            rbFS2.Visible = False
            rbFS3.Visible = False
            rbFS4.Visible = False
            rbFS5.Visible = False
            txtFSecName2v.Visible = False
            txtFSecName3v.Visible = False
            txtFSecName4v.Visible = False
            txtFSecName5v.Visible = False
            pbFSec2v.Visible = False
            pbFSec3v.Visible = False
            pbFSec4v.Visible = False
            pbFSec5v.Visible = False
        ElseIf frmElectoralComOffice.cmbFSecretary.SelectedIndex = 1 Then
            rbFS3.Visible = False
            rbFS4.Visible = False
            rbFS5.Visible = False
            txtFSecName3v.Visible = False
            txtFSecName4v.Visible = False
            txtFSecName5v.Visible = False
            pbFSec3v.Visible = False
            pbFSec4v.Visible = False
            pbFSec5v.Visible = False
        ElseIf frmElectoralComOffice.cmbFSecretary.SelectedIndex = 2 Then
            rbFS4.Visible = False
            rbFS5.Visible = False
            txtFSecName4v.Visible = False
            txtFSecName5v.Visible = False
            pbFSec4v.Visible = False
            pbFSec5v.Visible = False
        ElseIf frmElectoralComOffice.cmbFSecretary.SelectedIndex = 3 Then
            rbFS5.Visible = False
            txtFSecName5v.Visible = False
            pbFSec5v.Visible = False
        End If
        '
        If frmElectoralComOffice.cmbPRO.SelectedIndex = 0 Then
            rbPRO2.Visible = False
            rbPRO3.Visible = False
            rbPRO4.Visible = False
            rbPRO5.Visible = False
            txtPROname2.Visible = False
            txtPROname3.Visible = False
            txtPROname4.Visible = False
            txtPROname5.Visible = False
            pbPRO2v.Visible = False
            pbPRO3v.Visible = False
            pbPRO4v.Visible = False
            pbPRO5v.Visible = False
        ElseIf frmElectoralComOffice.cmbPRO.SelectedIndex = 1 Then
            rbPRO3.Visible = False
            rbPRO4.Visible = False
            rbPRO5.Visible = False
            txtPROname3.Visible = False
            txtPROname4.Visible = False
            txtPROname5.Visible = False
            pbPRO3v.Visible = False
            pbPRO4v.Visible = False
            pbPRO5v.Visible = False
        ElseIf frmElectoralComOffice.cmbPRO.SelectedIndex = 2 Then
            rbPRO4.Visible = False
            rbPRO5.Visible = False
            txtPROname4.Visible = False
            txtPROname5.Visible = False
            pbPRO4v.Visible = False
            pbPRO5v.Visible = False
        ElseIf frmElectoralComOffice.cmbPRO.SelectedIndex = 3 Then
            rbPRO5.Visible = False
            txtPROname5.Visible = False
            pbPRO5v.Visible = False
        End If
        '
        If frmElectoralComOffice.cmbOfferR.SelectedIndex = 0 Then
            rbOfferR2.Visible = False
            rbOfferR3.Visible = False
            rbOfferR4.Visible = False
            rbOfferR5.Visible = False
            txtOfferR2v.Visible = False
            txtOfferR3v.Visible = False
            txtOfferR4v.Visible = False
            txtOfferR5v.Visible = False
            pbOfferR2v.Visible = False
            pbOfferR3v.Visible = False
            pbOfferR4v.Visible = False
            pbOfferR5v.Visible = False
        ElseIf frmElectoralComOffice.cmbOfferR.SelectedIndex = 1 Then
            rbOfferR3.Visible = False
            rbOfferR4.Visible = False
            rbOfferR5.Visible = False
            txtOfferR3v.Visible = False
            txtOfferR4v.Visible = False
            txtOfferR5v.Visible = False
            pbOfferR3v.Visible = False
            pbOfferR4v.Visible = False
            pbOfferR5v.Visible = False
        ElseIf frmElectoralComOffice.cmbOfferR.SelectedIndex = 2 Then
            rbOfferR4.Visible = False
            rbOfferR5.Visible = False
            txtOfferR4v.Visible = False
            txtOfferR5v.Visible = False
            pbOfferR4v.Visible = False
            pbOfferR5v.Visible = False
        ElseIf frmElectoralComOffice.cmbOfferR.SelectedIndex = 3 Then
            rbOfferR5.Visible = False
            txtOfferR5v.Visible = False
            pbOfferR5v.Visible = False
        End If
        rbPre5Yes.Checked = True
    End Sub


    Private Sub ExitVoterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitVoterToolStripMenuItem.Click
        Me.Close()
        frmvoterLogin.Show()
    End Sub

    Private Sub btnCandidateVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextCandidate.Click

        VicePresidentToolStripMenuItem.Visible = True
        PresidentToolStripMenuItem.Visible = False
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = False
        ChiefReceptionistToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = False
        gbVPrev.Visible = True
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub PresidentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresidentToolStripMenuItem.Click
        gbPresidentVoting.Visible = True
        gbVPrev.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub VicePresidentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VicePresidentToolStripMenuItem.Click
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub btnVPnext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVPnext.Click

        VicePresidentToolStripMenuItem.Visible = False
        PresidentToolStripMenuItem.Visible = False
        SecretaryToolStripMenuItem.Visible = True
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = False
        ChiefReceptionistToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub SecretaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecretaryToolStripMenuItem.Click
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub FinancialSecretaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialSecretaryToolStripMenuItem.Click
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub btnNextFSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextFSec.Click
        VicePresidentToolStripMenuItem.Visible = False
        PresidentToolStripMenuItem.Visible = False
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = True
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = False
        ChiefReceptionistToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub btnNextPRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPRO.Click
        VicePresidentToolStripMenuItem.Visible = False
        PresidentToolStripMenuItem.Visible = False
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = True
        OfferRaisingOfiicerToolStripMenuItem.Visible = False
        ChiefReceptionistToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub btnVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVote.Click
        If rbPre1Yes.Checked = True Then
            p1 = p1 + 1
        ElseIf rbPre2Yes.Checked = True Then
            p2 = p2 + 1
        ElseIf rbPre3Yes.Checked = True Then
            p3 = p3 + 1
        ElseIf rbPre4Yes.Checked = True Then
            p4 = p4 + 1
        ElseIf rbPre5Yes.Checked = True Then
            p5 = p5 + 1
        End If
        '
        If rbVP1.Checked = True Then
            vp1 = vp1 + 1
        ElseIf rbVP2.Checked = True Then
            vp2 = vp2 + 1
        ElseIf rbVP3.Checked = True Then
            vp3 = vp3 + 1
        ElseIf rbVP4.Checked = True Then
            vp4 = vp4 + 1
        ElseIf rbVP5.Checked = True Then
            vp5 = vp5 + 1
        End If
        '
        If rbSec1.Checked = True Then
            s1 = s1 + 1
        ElseIf rbSec2.Checked = True Then
            s2 = s2 + 1
        ElseIf rbSec3.Checked = True Then
            s3 = s3 + 1
        ElseIf rbSec4.Checked = True Then
            s4 = s4 + 1
        ElseIf rbSec5.Checked = True Then
            s5 = s5 + 1
        End If
        '
        If rbFS1.Checked = True Then
            fs1 = fs1 + 1
        ElseIf rbFS2.Checked = True Then
            fs2 = fs2 + 1
        ElseIf rbFS3.Checked = True Then
            fs3 = fs3 + 1
        ElseIf rbFS4.Checked = True Then
            fs4 = fs4 + 1
        ElseIf rbFS5.Checked = True Then
            fs5 = fs5 + 1
        End If
        '
        If rbPRO1.Checked = True Then
            pro1 = pro1 + 1
        ElseIf rbPRO2.Checked = True Then
            pro2 = pro2 + 1
        ElseIf rbPRO3.Checked = True Then
            pro3 = pro3 + 1
        ElseIf rbPRO4.Checked = True Then
            pro4 = pro4 + 1
        ElseIf rbPRO5.Checked = True Then
            pro5 = pro5 + 1
        End If
        '
        If rbOfferR1.Checked = True Then
            of1 = of1 + 1
        ElseIf rbOfferR2.Checked = True Then
            of2 = of2 + 1
        ElseIf rbOfferR3.Checked = True Then
            of3 = of3 + 1
        ElseIf rbOfferR4.Checked = True Then
            of4 = of4 + 1
        ElseIf rbOfferR5.Checked = True Then
            of5 = of5 + 1
        End If
        TextBox1.Text = p1
        TextBox2.Text = p2
        TextBox3.Text = p3
        TextBox4.Text = p4
        TextBox5.Text = p5
        TextBox6.Text = vp1
        TextBox7.Text = vp2
        TextBox8.Text = vp3
        TextBox9.Text = vp4
        TextBox10.Text = vp5
        TextBox11.Text = s1
        TextBox12.Text = s2
        TextBox13.Text = s3
        TextBox14.Text = s4
        TextBox15.Text = s5
        TextBox16.Text = fs1
        TextBox17.Text = fs2
        TextBox18.Text = fs3
        TextBox19.Text = fs4
        TextBox20.Text = fs5
        TextBox21.Text = pro1
        TextBox22.Text = pro2
        TextBox23.Text = pro3
        TextBox24.Text = pro4
        TextBox25.Text = pro5
        TextBox26.Text = of1
        TextBox27.Text = of2
        TextBox28.Text = of3
        TextBox29.Text = of4
        TextBox30.Text = of5

        'sqlTest = Nothing
        'sqlTest = "SELECT * FROM voting_casted"
        'FillData("members")
        'Dim Cmb As New Odbc.OdbcCommandBuilder(Da)
        'Dim NRow As DataRow
        'NRow = Ds.Tables("voting_casted").NewRow

        ''filling voted for presidential candidate into the database
        'If rbPre1Yes.Checked = True Then
        '    NRow.Item(1) = frmElectoralComOffice.txtPre1Name.Text
        'ElseIf rbPre2Yes.Checked = True Then
        '    NRow.Item(1) = frmElectoralComOffice.txtPre2Name.Text
        'ElseIf rbPre3Yes.Checked = True Then
        '    NRow.Item(1) = frmElectoralComOffice.txtPre3Name.Text
        'ElseIf rbPre4Yes.Checked = True Then
        '    NRow.Item(1) = frmElectoralComOffice.txtPre4Name.Text
        'ElseIf rbPre5Yes.Checked = True Then
        '    NRow.Item(1) = frmElectoralComOffice.txtPre5Name.Text
        'End If
        ''filling voted for vice presidential candidate into the database
        'If rbVP1.Checked = True Then
        '    NRow.Item(2) = frmElectoralComOffice.txtVPname1.Text
        'ElseIf rbVP2.Checked = True Then
        '    NRow.Item(2) = frmElectoralComOffice.txtVPname2.Text
        'ElseIf rbVP3.Checked = True Then
        '    NRow.Item(2) = frmElectoralComOffice.txtVPname3.Text
        'ElseIf rbVP4.Checked = True Then
        '    NRow.Item(2) = frmElectoralComOffice.txtVPname4.Text
        'ElseIf rbVP5.Checked = True Then
        '    NRow.Item(2) = frmElectoralComOffice.txtVPname5.Text
        'End If
        ''filling voted for secretary candidate into the database
        'If rbSec1.Checked = True Then
        '    NRow.Item(3) = frmElectoralComOffice.txtSecName1.Text
        'ElseIf rbSec2.Checked = True Then
        '    NRow.Item(3) = frmElectoralComOffice.txtSecName2.Text
        'ElseIf rbSec3.Checked = True Then
        '    NRow.Item(3) = frmElectoralComOffice.txtSecName3.Text
        'ElseIf rbSec4.Checked = True Then
        '    NRow.Item(3) = frmElectoralComOffice.txtSecName4.Text
        'ElseIf rbSec5.Checked = True Then
        '    NRow.Item(3) = frmElectoralComOffice.txtSecName5.Text
        'End If
        ''filling voted for financial secretary candidate into the database
        'If rbFS1.Checked = True Then
        '    NRow.Item(4) = frmElectoralComOffice.txtFSecName1.Text
        'ElseIf rbFS2.Checked = True Then
        '    NRow.Item(4) = frmElectoralComOffice.txtFSecName2.Text
        'ElseIf rbFS3.Checked = True Then
        '    NRow.Item(4) = frmElectoralComOffice.txtFSecName3.Text
        'ElseIf rbFS4.Checked = True Then
        '    NRow.Item(4) = frmElectoralComOffice.txtFSecName4.Text
        'ElseIf rbFS5.Checked = True Then
        '    NRow.Item(4) = frmElectoralComOffice.txtFSecName5.Text
        'End If
        ''filling voted for public relations officer candidate into the database
        'If rbPRO1.Checked = True Then
        '    NRow.Item(5) = frmElectoralComOffice.txtPROname1.Text
        'ElseIf rbPRO2.Checked = True Then
        '    NRow.Item(5) = frmElectoralComOffice.txtPROname2.Text
        'ElseIf rbPRO3.Checked = True Then
        '    NRow.Item(5) = frmElectoralComOffice.txtPROname3.Text
        'ElseIf rbPRO4.Checked = True Then
        '    NRow.Item(5) = frmElectoralComOffice.txtPROname4.Text
        'ElseIf rbPRO5.Checked = True Then
        '    NRow.Item(5) = frmElectoralComOffice.txtPROname5.Text
        'End If
        ''filling voted for offer raising officer candidate into the database
        'If rbOfferR1.Checked = True Then
        '    NRow.Item(6) = frmElectoralComOffice.txtOfferR1.Text
        'ElseIf rbOfferR2.Checked = True Then
        '    NRow.Item(6) = frmElectoralComOffice.txtOfferR2.Text
        'ElseIf rbOfferR3.Checked = True Then
        '    NRow.Item(6) = frmElectoralComOffice.txtOfferR3.Text
        'ElseIf rbOfferR4.Checked = True Then
        '    NRow.Item(6) = frmElectoralComOffice.txtOfferR4.Text
        'ElseIf rbOfferR5.Checked = True Then
        '    NRow.Item(6) = frmElectoralComOffice.txtOfferR5.Text
        'End If
        'filling voted for chief receptionist candidate into the database
        'If rbChief1.Checked = True Then
        '    NRow.Item(7) = frmElectoralComOffice.txtCRecptname1.Text
        'ElseIf rbChief2.Checked = True Then
        '    NRow.Item(7) = frmElectoralComOffice.txtCRecptname2.Text
        'ElseIf rbChief3.Checked = True Then
        '    NRow.Item(7) = frmElectoralComOffice.txtCRecptname3.Text
        'ElseIf rbChief4.Checked = True Then
        '    NRow.Item(7) = frmElectoralComOffice.txtCRecptname4.Text
        'ElseIf rbChief5.Checked = True Then
        '    NRow.Item(7) = frmElectoralComOffice.txtCRecptname5.Text
        'End If
        'NRow.Item(8) = datte.ToString(fomat)

        'Ds.Tables("voting_casted").Rows.Add(NRow)
        'Da.Update(Ds, "voting_casted")
        'MessageBox.Show("Thank you for voting", "Vote Accepted", MessageBoxButtons.OK)
        Me.Hide()
        ''these codes reset the voter form to default after a voter has voted
        gbPresidentVoting.Visible = True
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False

        pbPreSelected.Visible = False
        pbVPSelected.Visible = False
        pbSecSelected.Visible = False
        pbFSecSelected.Visible = False
        pbPROSelected.Visible = False
        pbOfferSelected.Visible = False

        PresidentToolStripMenuItem.Visible = True
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = False
        ChiefReceptionistToolStripMenuItem.Visible = False
        VicePresidentToolStripMenuItem.Visible = False

        btnVote.Visible = False

        rbPre5Yes.Checked = True
        rbVP5.Checked = True
        rbSec5.Checked = True
        rbFS5.Checked = True
        rbPRO5.Checked = True
        rbOfferR5.Checked = True
        frmvoterLogin.txtVoterCode.Focus()
        'frmvoter.Visible = False
        frmvoterLogin.Show()
    End Sub

    Private Sub PROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROToolStripMenuItem.Click
        gbPRO.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False

    End Sub

    Private Sub btnNextChiefRecep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextChiefRecep.Click
        VicePresidentToolStripMenuItem.Visible = False
        PresidentToolStripMenuItem.Visible = False
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = True
        ChiefReceptionistToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True

        btnVote.Visible = True

    End Sub

    Private Sub btnNextOfferR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextOfferR.Click
        VicePresidentToolStripMenuItem.Visible = False
        PresidentToolStripMenuItem.Visible = False
        SecretaryToolStripMenuItem.Visible = False
        FinancialSecretaryToolStripMenuItem.Visible = False
        PROToolStripMenuItem.Visible = False
        OfferRaisingOfiicerToolStripMenuItem.Visible = True
        ChiefReceptionistToolStripMenuItem.Visible = False

        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True

        btnVote.Visible = True
    End Sub

    Private Sub rbPre1Yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPre1Yes.Click
        pbPreSelected.Image = frmElectoralComOffice.pbPre1.Image
        pbPreSelected.Visible = True
        Label6.Visible = True
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub rbPre2Yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPre2Yes.Click
        pbPreSelected.Image = frmElectoralComOffice.pbPre2.Image
        pbPreSelected.Visible = True
        Label6.Visible = True
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbPre3Yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPre3Yes.Click
        pbPreSelected.Image = frmElectoralComOffice.pbPre3.Image
        pbPreSelected.Visible = True
        Label6.Visible = True
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub rbPre4Yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPre4Yes.Click
        pbPreSelected.Image = frmElectoralComOffice.pbPre4.Image
        pbPreSelected.Visible = True
        Label6.Visible = True
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbPre5Yes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPre5Yes.Click
        pbPreSelected.Image = frmElectoralComOffice.pbPre5.Image
        pbPreSelected.Visible = True
        Label6.Visible = True
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub rbVP1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVP1.Click
        pbVPSelected.Image = frmElectoralComOffice.pbVp1.Image
        pbVPSelected.Visible = True
        Label7.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbVP2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVP2.Click
        pbVPSelected.Image = frmElectoralComOffice.pbVP2.Image
        pbVPSelected.Visible = True
        Label7.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbVP3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVP3.Click
        pbVPSelected.Image = frmElectoralComOffice.pbVP3.Image
        pbVPSelected.Visible = True
        Label7.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbVP4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVP4.Click
        pbVPSelected.Image = frmElectoralComOffice.pbVP4.Image
        pbVPSelected.Visible = True
        Label7.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbVP5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVP5.Click
        pbVPSelected.Image = frmElectoralComOffice.pbVP5.Image
        pbVPSelected.Visible = True
        Label7.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub rbSec1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSec1.Click
        pbSecSelected.Image = frmElectoralComOffice.pbSec1.Image
        pbSecSelected.Visible = True
        Label8.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbSec2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSec2.Click
        pbSecSelected.Image = frmElectoralComOffice.pbSec2.Image
        pbSecSelected.Visible = True
        Label8.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbSec3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSec3.Click
        pbSecSelected.Image = frmElectoralComOffice.pbSec3.Image
        pbSecSelected.Visible = True
        Label8.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbSec4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSec4.Click
        pbSecSelected.Image = frmElectoralComOffice.pbSec4.Image
        pbSecSelected.Visible = True
        Label8.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbSec5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSec5.Click
        pbSecSelected.Image = frmElectoralComOffice.pbSec5.Image
        pbSecSelected.Visible = True
        Label8.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub rbFS1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFS1.Click
        pbFSecSelected.Image = frmElectoralComOffice.pbFSec1.Image
        pbFSecSelected.Visible = True
        Label9.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbFS2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFS2.Click
        pbFSecSelected.Image = frmElectoralComOffice.pbFSec2.Image
        pbFSecSelected.Visible = True
        Label9.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbFS3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFS3.Click
        pbFSecSelected.Image = frmElectoralComOffice.pbFSec3.Image
        pbFSecSelected.Visible = True
        Label9.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbFS4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFS4.Click
        pbFSecSelected.Image = frmElectoralComOffice.pbFSec4.Image
        pbFSecSelected.Visible = True
        Label9.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub
    Private Sub rbFS5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFS5.Click
        pbFSecSelected.Image = frmElectoralComOffice.pbFSec5.Image
        pbFSecSelected.Visible = True
        Label9.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub rbPRO1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPRO1.Click
        pbPROSelected.Image = frmElectoralComOffice.pbPRO1.Image
        pbPROSelected.Visible = True
        Label10.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True
    End Sub
    Private Sub rbPRO2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPRO2.Click
        pbPROSelected.Image = frmElectoralComOffice.pbPRO2.Image
        pbPROSelected.Visible = True
        Label10.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True
    End Sub
    Private Sub rbPRO3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPRO3.Click
        pbPROSelected.Image = frmElectoralComOffice.pbPRO3.Image
        pbPROSelected.Visible = True
        Label10.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True
    End Sub
    Private Sub rbPRO4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPRO4.Click
        pbPROSelected.Image = frmElectoralComOffice.pbPRO4.Image
        pbPROSelected.Visible = True
        Label10.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True
    End Sub
    Private Sub rbPRO5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPRO5.Click
        pbPROSelected.Image = frmElectoralComOffice.pbPRO5.Image
        pbPROSelected.Visible = True
        Label10.Visible = True
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True
    End Sub

    Private Sub rbOfferR1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOfferR1.Click
        pbOfferSelected.Image = frmElectoralComOffice.pbOfferR1.Image
        pbOfferSelected.Visible = True
        Label11.Visible = True
        btnVote.Visible = True
    End Sub
    Private Sub rbOfferR2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOfferR2.Click
        pbOfferSelected.Image = frmElectoralComOffice.pbOfferR2.Image
        pbOfferSelected.Visible = True
        Label11.Visible = True
        btnVote.Visible = True
    End Sub
    Private Sub rbOfferR3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOfferR3.Click
        pbOfferSelected.Image = frmElectoralComOffice.pbOfferR3.Image
        pbOfferSelected.Visible = True
        Label11.Visible = True
        btnVote.Visible = True
    End Sub
    Private Sub rbOfferR4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOfferR4.Click
        pbOfferSelected.Image = frmElectoralComOffice.pbOfferR4.Image
        pbOfferSelected.Visible = True
        Label11.Visible = True
        btnVote.Visible = True
    End Sub
    Private Sub rbOfferR5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOfferR5.Click
        pbOfferSelected.Image = frmElectoralComOffice.pbOfferR5.Image
        pbOfferSelected.Visible = True
        Label11.Visible = True
        btnVote.Visible = True
    End Sub

    Private Sub pbPreSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPreSelected.Click
        gbPresidentVoting.Visible = True
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub pbVPSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVPSelected.Click
        gbVPrev.Visible = True
        gbPresidentVoting.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub pbSecSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSecSelected.Click
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = True
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub pbFSecSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbFSecSelected.Click
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = True
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub pbPROSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPROSelected.Click
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = True
        gbCRecptv.Visible = False
        gbOfferRv.Visible = False
    End Sub

    Private Sub pbOfferSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbOfferSelected.Click
        gbPresidentVoting.Visible = False
        gbVPrev.Visible = False
        gbSecretaryv.Visible = False
        gbFSecv.Visible = False
        gbPRO.Visible = False
        gbCRecptv.Visible = False
        gbOfferRv.Visible = True
    End Sub
End Class