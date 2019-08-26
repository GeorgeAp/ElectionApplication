Imports Electoral_Commission_Voter.frmvoter
Imports Electoral_Commission_Voter.frmElectoralComOffice
Imports Electoral_Commission_Voter.frmLogin
'Imports System.Data
'Imports System.Data.Odbc


Public Class frmvoterLogin
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

    Dim counter As Integer = 0
    Dim totall As Integer = 0
    Dim F(187) As Boolean
    Dim passcode() As Integer = {200300, 919862013, 7654300, 10077, 5005009, 90010077, 2000133, 4104015, 4303016, 4502017, 4701018, 4905019, 5107020, 312013, 512113, 712213, 212313, 212413, 312513, 512613, 712713, 212813, 312913, 513013, 713113, 213213, 313313, 513413, 713513, 213613, 313713, 513813, 713913, 214013, 314113, 514213, 714313, 214413, 314513, 514613, 714713, 214813, 314913, 515013, 715113, 215213, 315313, 515413, 715513, 215613, 315713, 515813, 715913, 216013, 316113, 516213, 716313, 216413, 316513, 516613, 716713, 216813, 316913, 517013, 717113, 217213, 317313, 517413, 717513, 217613, 317713, 517813, 717913, 218013, 318113, 518213, 718313, 218913, 319013, 519113, 719213, 219313, 319413, 519513, 719613, 219713, 319813, 519913, 720113, 220213, 320313, 520413, 720513, 220613, 320713, 520813, 720913, 230113, 330213, 530313, 730413, 230513, 330613, 530713, 530813, 730913, 240113, 340213, 540313, 740413, 240513, 340613, 540713, 711113, 722223, 733333, 744443, 755553, 766663, 110901, 130802, 150703, 170604, 190505, 210406, 230307, 250208, 270109, 2909010, 3108011, 3507012, 3706013, 3905014, 777773, 788883, 799993, 710003, 100318, 101869, 103404, 108407, 105497, 105688, 107482, 100046, 102769, 104898, 105853, 102543, 109172, 104694, 704505, 707749, 700462, 704456, 702238, 708143, 702858, 700119, 700838, 708173, 700971, 706463, 707513, 702435, 507572, 503371, 502290, 508687, 508235, 507094, 502551, 509293, 507537, 501622, 509133, 500844, 506948, 507547, 505060, 503500, 503804, 507943, 501524, 303998, 303171, 302760}

    Private Sub btnVoterLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoterLogin.Click
        Dim vallue As Integer
        Dim S As String = txtVoterCode.Text
        If S = "a2p5p2p1" Then
            frmElectoralComOffice.Show()
            Me.Hide()
        Else
            Try
                vallue = CInt(S)
            Catch ex As Exception
                Beep()
                ' try again
            End Try
            Dim I As Integer
            For I = 0 To 186
                If vallue = passcode(I) Then Exit For
            Next
            If I > 186 Then MessageBox.Show("Passcode does not exist") : txtVoterCode.Clear() : Exit Sub ' try again
            If F(I) Then MessageBox.Show("You have already voted.") : txtVoterCode.Clear() : Exit Sub
            F(I) = True
            '' F() boolean values would have to be saved

            'sqlTest = Nothing
            'sqlTest = "SELECT * FROM voting_verif"
            ''FillData("voting")
            'Dim Cmb As New Odbc.OdbcCommandBuilder(Da)
            'Dim NRow As DataRow
            'NRow = Ds.Tables("voting_verif").NewRow
            'NRow.Item(1) = txtVoterCode.Text
            'NRow.Item(2) = datte.ToString(fomat)
            'Ds.Tables("voting_verif").Rows.Add(NRow)
            'Da.Update(Ds, "voting_verif")
            totall = totall + 1
            txtTotalVoters.Text = totall
            frmvoter.Show()
            Me.Hide()
        End If
        txtVoterCode.Clear()
    End Sub

    Private Sub frmvoterLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Now > #3/17/2014# Then
        '    MessageBox.Show("Application has expired", "Application Security", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End
        'End If
        txtVoterCode.Select()
    End Sub
End Class