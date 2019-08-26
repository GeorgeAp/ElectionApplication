'Imports System.Data
'Imports System.Data.Odbc

Public Class frmGenPasscode
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

    Dim F(187) As Boolean
    Dim I(187) As String
    Dim vName As String
    Dim a, c As Integer
    Dim b As Integer
    Dim passcode() As Integer = {200300, 919862013, 7654300, 10077, 5005009, 90010077, 2000133, 4104015, 4303016, 4502017, 4701018, 4905019, 5107020, 312013, 512113, 712213, 212313, 212413, 312513, 512613, 712713, 212813, 312913, 513013, 713113, 213213, 313313, 513413, 713513, 213613, 313713, 513813, 713913, 214013, 314113, 514213, 714313, 214413, 314513, 514613, 714713, 214813, 314913, 515013, 715113, 215213, 315313, 515413, 715513, 215613, 315713, 515813, 715913, 216013, 316113, 516213, 716313, 216413, 316513, 516613, 716713, 216813, 316913, 517013, 717113, 217213, 317313, 517413, 717513, 217613, 317713, 517813, 717913, 218013, 318113, 518213, 718313, 218913, 319013, 519113, 719213, 219313, 319413, 519513, 719613, 219713, 319813, 519913, 720113, 220213, 320313, 520413, 720513, 220613, 320713, 520813, 720913, 230113, 330213, 530313, 730413, 230513, 330613, 530713, 530813, 730913, 240113, 340213, 540313, 740413, 240513, 340613, 540713, 711113, 722223, 733333, 744443, 755553, 766663, 110901, 130802, 150703, 170604, 190505, 210406, 230307, 250208, 270109, 2909010, 3108011, 3507012, 3706013, 3905014, 777773, 788883, 799993, 710003, 100318, 101869, 103404, 108407, 105497, 105688, 107482, 100046, 102769, 104898, 105853, 102543, 109172, 104694, 704505, 707749, 700462, 704456, 702238, 708143, 702858, 700119, 700838, 708173, 700971, 706463, 707513, 702435, 507572, 503371, 502290, 508687, 508235, 507094, 502551, 509293, 507537, 501622, 509133, 500844, 506948, 507547, 505060, 503500, 503804, 507943, 501524, 303998, 303171, 302760}
    'Dim passcode() As Integer = {100318, 101869, 103404, 108407, 105497, 105688, 107482, 100046, 102769, 104898, 105853, 102543, 109172, 104694, 704505, 707749, 700462, 704456, 702238, 708143, 702858, 700119, 700838, 708173, 700971, 706463, 707513, 702435, 507572, 503371, 502290, 508687, 508235, 507094, 502551, 509293, 507537, 501622, 509133, 500844, 506948, 507547, 505060, 503500, 503804, 507943, 501524, 303998, 303171, 302760, 96991, 201966, 5678, 103112, 2208258, 5602599, 7809502, 106797, 228909, 2511, 759, 285, 83, 8001, 344, 6551, 9593, 26160, 600540, 1656, 129961, 344314, 6704387, 919862013, 765430, 10077, 505009, 9001077, 2000133, 410415, 4303016, 402017, 470118, 49050191, 5107021, 312013, 512113, 114427, 181818, 2237655, 2214984, 101493, 308308, 1239340, 126541, 1067, 2638, 347952, 2309597, 12302575, 6755453, 901299, 1678892, 864319, 624455, 1361, 1839, 3897, 430, 306256, 908693, 902400, 902417, 9901690, 9907802, 7705797, 5604173, 7704039, 7706491, 7700811, 6605499, 6600497, 6600965, 4407317, 4409294, 4401450, 2209027, 2201320, 2226477, 1117757, 6668530, 6669448, 6669421, 6664509, 4194868, 4196221, 6664909, 3129561, 4565470, 564359, 383510, 384893, 26205752, 4562963, 4454468, 1195132, 1003377, 2000598, 8907447, 12343063, 234018, 129001, 562348, 861890, 4565085, 65320760, 98754692, 532, 9906868, 5108, 2302399, 111112, 218212, 183501835, 1768176, 2331233, 80307803, 15400154, 68503685, 94807948, 5041622, 5091433, 5008444, 5069418, 5075417, 5050601, 5035010, 5038104, 5079143, 5015124, 3031998, 3103171, 32760}
    'Private Sub FillData(ByVal tableName As String)
    '    Da = New OdbcDataAdapter(sqlTest, myConnection)
    '    Ds = New DataSet
    '    Da.Fill(Ds, tableName)
    '    Dv = New DataView(Ds.Tables(tableName))
    '    cm = CType(Me.BindingContext(Dv), CurrencyManager)
    'End Sub
    Private Sub btnGenPasscode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenPasscode.Click
        If Not IsNumeric(txtGenPassNum.Text) Then
            MessageBox.Show("Enter a numeric value in the number textbox", "Validation", MessageBoxButtons.OK)
            txtGenPassNum.Focus()
        ElseIf txtGenPassNum.Text < 1 Then
            MessageBox.Show("Voter Number cannot be less than 1", "Validation", MessageBoxButtons.OK)
            txtGenPassNum.Focus()
        ElseIf txtGenPassNum.Text > 105 Then
            MessageBox.Show("Voter Number exceeds total registered members", "Validation", MessageBoxButtons.OK)
            txtGenPassNum.Focus()
        ElseIf txtGenPassRefNumber.Text = "" Then
            MessageBox.Show("Enter Voter name", "Validation", MessageBoxButtons.OK)
            txtGenPassRefNumber.Focus()
        Else
            a = txtGenPassNum.Text
            c = a - 1
            b = passcode(c)
            txtGenPasscode.Text = b
            If F(a) Then txtGenPasscode.Clear() : MessageBox.Show("A passcode has already been created for this Reference Number.") : txtGenPassNum.Focus() : Exit Sub
            F(a) = True
        End If
        vName = txtGenPassRefNumber.Text
        I(c) = vName
        txtGenPassRefNumber.Clear()
        'sqlTest = Nothing
        'sqlTest = "SELECT * FROM voting_code"
        'FillData("voting")
        'Dim Cmb As New Odbc.OdbcCommandBuilder(Da)
        'Dim NRow As DataRow
        'NRow = Ds.Tables("voting_code").NewRow
        ''NRow.Item(1) = txtGenPassName.Text
        'NRow.Item(1) = txtGenPasscode.Text
        ''NRow.Item(3) = datte.ToString(fomat)
        'Ds.Tables("voting_code").Rows.Add(NRow)
        'Da.Update(Ds, "voting_code")
        'MessageBox.Show("Code generated", "Voting Code", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        frmElectoralComOffice.Show()
    End Sub

    Private Sub PrintVotersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintVotersToolStripMenuItem.Click
        'Dim I As Integer
        'Dim totalVal As Double
        'dgvVoters.Visible = True
        'dgvVoters.Rows.Clear()

        'If myConnection.State = ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'I = 0
        'totalVal = 0

        'Try
        '    sqlTest = Nothing
        '    sqlTest = "SELECT voterName,passCode FROM preregister WHERE voterName='" & txtGenPassName.Text.Trim & "'"
        '    FillData("checkReg")
        '    cmd = New OdbcCommand(sqlTest, myConnection)

        '    dr = cmd.ExecuteReader

        '    If dr.HasRows Then
        '        While dr.Read
        '            totalVal = totalVal + dr.GetString(dr.GetOrdinal("totalamt"))
        '            dgvVoters.Rows.Add()
        '            dgvVoters.Rows(I).Cells(0).Value = dr.GetString(dr.GetOrdinal("Name"))
        '            dgvVoters.Rows(I).Cells(1).Value = dr.GetString(dr.GetOrdinal("Passcode"))
        '            I = I + 1
        '        End While

        '        'lblAmount.Text = totalVal
        '        'Else
        '        'lblAmount.Text = "000000"
        '    End If

        '    dr.Close()

        '    If myConnection.State = ConnectionState.Open Then
        '        myConnection.Close()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
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
        e.Graphics.DrawString("List of Voters and their codes:", print4Font, Brushes.Black, 150, 170)
        Dim i As Integer
        For i = 1 To 130
            e.Graphics.DrawString(F(i - 1) & "    ......    " & passcode(i - 1), print4Font, Brushes.Black, 150, (240 + i + 9))
        Next i
    End Sub

    Private Sub frmGenPasscode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvVoters.Visible = False
    End Sub
End Class