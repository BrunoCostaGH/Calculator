Public Class Calculator
    Dim panelValue As String
    Dim historyValue, memoryValue As Double
    Dim pendingOperation As String
    Dim isFirstOperation, wasLastButtonOperation, wasLastStateReached, stateCient As Boolean
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isFirstOperation = True
        wasLastButtonOperation = False
        wasLastStateReached = False

        BtnEqual.Select()
        Me.TopMost = True
        If My.Settings.AppDisplaySplashScreen Then
            SplashScreen1.ShowDialog()
        End If
    End Sub
    Private Sub TxtPanel_ChangeText(sender As Object, e As EventArgs) Handles Btn0.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, BtnSum.Click, BtnMinus.Click, BtnMultiply.Click, BtnDivide.Click
        calculate(sender.text)
    End Sub
    Private Sub BtnSquareRoot_Click(sender As Object, e As EventArgs) Handles BtnSquareRoot.Click
        panelValue = panelValue_Round(Math.Sqrt(panelValue))
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    Private Sub BtnSquare_Click(sender As Object, e As EventArgs) Handles BtnSquare.Click
        panelValue = panelValue_Round(panelValue ^ 2)
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    Private Sub BtnMultiInverse_Click(sender As Object, e As EventArgs) Handles BtnMultiInverse.Click
        panelValue = panelValue_Round(1 / panelValue)
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        historyValue = panelValue
        TxtOperação.Clear()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If wasLastStateReached Then
            panelValue = 0
            historyValue = panelValue
            changeVisibilityC()
        Else
            If panelValue.ToString.Length > 1 Then
                panelValue = CDbl(panelValue.ToString.Substring(0, panelValue.ToString.Length - 1))
            ElseIf Not panelValue = 0 Then
                panelValue = 0
                changeVisibilityC()
            End If
        End If
        TxtPanel.Text = panelValue
    End Sub
    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        isFirstOperation = True
        wasLastButtonOperation = True
        TxtOperação.Clear()
        panelValue = 0
        historyValue = 0
        pendingOperation = ""
        TxtPanel.Text = panelValue
    End Sub
    Private Sub BtnMS_Click(sender As Object, e As EventArgs) Handles BtnMS.Click
        memoryValue = panelValue
        TxtOperação.Text = "MS"

        'https://docs.microsoft.com/en-us/dotnet/api/system.drawing.systemcolors?view=net-5.0
        BtnMR.Enabled = True
        BtnMR.ForeColor = SystemColors.ControlText
        BtnMC.Enabled = True
        BtnMC.ForeColor = SystemColors.ControlText

        wasLastButtonOperation = True
    End Sub
    Private Sub BtnMAdd_Click(sender As Object, e As EventArgs) Handles BtnMAdd.Click
        memoryValue = Math.Round(panelValue + memoryValue, 9)
        panelValue = panelValue_Round(memoryValue)
        TxtPanel.Text = panelValue
        TxtOperação.Text = "M+"

        BtnMR.Enabled = True
        BtnMR.ForeColor = SystemColors.ControlText
        BtnMC.Enabled = True
        BtnMC.ForeColor = SystemColors.ControlText

        wasLastButtonOperation = True
        pendingOperation = ""
    End Sub
    Private Sub BtnMR_Click(sender As Object, e As EventArgs) Handles BtnMR.Click
        panelValue = panelValue_Round(memoryValue)
        TxtPanel.Text = panelValue
        TxtOperação.Text = "MR"
    End Sub
    Private Sub BtnMC_Click(sender As Object, e As EventArgs) Handles BtnMC.Click
        memoryValue = 0

        BtnMR.Enabled = False
        BtnMR.ForeColor = SystemColors.ControlLightLight
        BtnMC.Enabled = False
        BtnMC.ForeColor = SystemColors.ControlLightLight
    End Sub
    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles BtnDecimal.Click
        'https://livemadeiraedu.sharepoint.com/sites/Turma1211/Shared%20Documents/General/calculadora.mp4
        Dim pos As Integer
        pos = InStr(TxtPanel.Text, ".")
        If TxtPanel.TextLength = 0 Then
            panelValue += "0" & "."
        ElseIf pos = 0 Then
            panelValue += "."
        End If
        TxtPanel.Text = panelValue
    End Sub
    Private Sub BtnCE_Click(sender As Object, e As EventArgs) Handles BtnCE.Click
        panelValue = 0
        TxtPanel.Text = panelValue
        changeVisibilityC()
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        'https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/storing-data-to-and-reading-from-the-clipboard
        My.Computer.Clipboard.SetText(TxtPanel.Text)
    End Sub
    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        If IsNumeric(My.Computer.Clipboard.GetText()) Then
            historyValue = TxtPanel.Text
            panelValue = panelValue_Round(My.Computer.Clipboard.GetText())
            TxtPanel.Text = panelValue

            wasLastButtonOperation = False
        End If
    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AcercaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaToolStripMenuItem.Click
        'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.applicationservices.applicationbase.info?view=net-5.0
        'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.strings.space?view=net-5.0
        'https://docs.microsoft.com/en-us/office/troubleshoot/access/force-new-line-msgbox-message
        MsgBox(My.Application.Info.ProductName.ToString & Space(1) & My.Application.Info.Version.ToString & vbCrLf & vbCrLf & My.Application.Info.CompanyName.ToString & vbCrLf & My.Application.Info.Copyright.ToString, vbInformation, "Acerca")
    End Sub
    Private Sub BtnNegate_Click(sender As Object, e As EventArgs) Handles BtnNegate.Click
        panelValue = -panelValue
        TxtPanel.Text = panelValue
    End Sub
    Private Sub BtnPercentage_Click(sender As Object, e As EventArgs) Handles BtnPercentage.Click
        panelValue = panelValue_Round(panelValue / 100)
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub

    Private Sub Calculator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.strings.chrw?view=net-5.0
            'https://theasciicode.com.ar/
            Case ChrW(8) 'Backspace
                BtnDelete_Click(sender, e)
            Case ChrW(27) 'Escape (ESC)
                BtnCE_Click(sender, e)
            Case ChrW(61) 'Equal (=)
                BtnEqual_Click(sender, e)
            Case ChrW(46) 'Period (.)
                BtnDecimal_Click(sender, e)
            Case Else
                If IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(42) Or e.KeyChar = ChrW(43) Or e.KeyChar = ChrW(45) Or e.KeyChar = ChrW(47) Then
                    calculate(e.KeyChar)
                End If
        End Select
    End Sub
    Private Sub RBPadrao_CheckedChanged(sender As Object, e As EventArgs) Handles RBPadrao.CheckedChanged, RBCientifica.CheckedChanged, PadrãoToolStripMenuItem.Click, CientToolStripMenuItem.Click
        If sender.checked Then
            Select Case sender.name
                Case RBPadrao.Name
                    stateCient = False
                Case RBCientifica.Name
                    stateCient = True
            End Select
        ElseIf sender.name = PadrãoToolStripMenuItem.Name Then
            stateCient = False
            RBPadrao.Checked = True
        ElseIf sender.name = CientToolStripMenuItem.Name Then
            stateCient = True
            RBCientifica.Checked = True
        End If
        'https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.location?view=net-5.0
        If stateCient Then
            resetVariables()
            Me.Height = 527
            PnlMain.Height = 372
            BtnCE.Location = BtnC.Location
            BtnCE.Hide()
            PnlCient.Show()
        Else
            resetVariables()
            Me.Height = 475
            PnlMain.Height = 320
            BtnCE.Location = New Point(81, 5)
            BtnC.Show()
            BtnCE.Show()
            PnlCient.Hide()
        End If
    End Sub
    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        Select Case pendingOperation
            Case BtnSum.Tag
                historyValue = historyValue + panelValue
            Case BtnMinus.Tag
                historyValue = historyValue - panelValue
            Case BtnMultiply.Tag
                historyValue = historyValue * panelValue
            Case BtnDivide.Tag
                historyValue = historyValue / panelValue
            Case Else
                historyValue = panelValue
        End Select
        TxtPanel.Text = historyValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
        panelValue = panelValue_Round(historyValue)
        pendingOperation = ""
    End Sub
    Private Sub BtnPi_Click(sender As Object, e As EventArgs) Handles BtnPi.Click
        panelValue = panelValue_Round(Math.PI)
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    Private Sub Btne_Click(sender As Object, e As EventArgs) Handles Btne.Click
        panelValue = panelValue_Round(Math.Exp(1))
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    'https://docs.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-5.0#System_Math_Abs_System_Double_
    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        panelValue = panelValue_Round(Math.Abs(CDbl(panelValue)))
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    Private Sub BtnEXP_Click(sender As Object, e As EventArgs) Handles BtnExpo.Click
        panelValue = panelValue_Round(10 ^ panelValue)
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    Private Sub BtnFactorial_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        panelValue = panelValue_Round(Math.Log10(panelValue))
        TxtPanel.Text = panelValue

        wasLastButtonOperation = True
        wasLastStateReached = True
        TxtOperação.Clear()
    End Sub
    'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/procedures/function-procedures
    Private Function panelValue_Round(value As Double) As Double
        If value.ToString.Length > 9 Then value = CDbl(value.ToString.Substring(0, 9))
        If Not (value = 0) And Not BtnCE.Visible Then
            changeVisibilityC()
        ElseIf value = 0 And BtnCE.Visible Then
            changeVisibilityC()
        End If
        Return value
    End Function
    Private Sub calculate(value As String)
        If IsNumeric(value) Then
            If wasLastButtonOperation Then
                panelValue = panelValue_Round(0 + CDbl(value))
                If wasLastStateReached Then
                    historyValue = panelValue
                    wasLastStateReached = False
                End If
            Else
                panelValue = panelValue_Round(panelValue & CDbl(value))
            End If
            wasLastButtonOperation = False
            TxtPanel.Text = panelValue
            Exit Sub
        ElseIf Not (wasLastButtonOperation) Then
            Select Case pendingOperation
                Case BtnSum.Tag
                    historyValue = historyValue + panelValue
                Case BtnMinus.Tag
                    historyValue = historyValue - panelValue
                Case BtnMultiply.Tag
                    historyValue = historyValue * panelValue
                Case BtnDivide.Tag
                    historyValue = historyValue / panelValue
            End Select
            If isFirstOperation Then
                panelValue = panelValue
                historyValue = panelValue
                isFirstOperation = False
            End If
            pendingOperation = value
            TxtPanel.Text = historyValue
            wasLastButtonOperation = True
            TxtOperação.Text = value
        Else
            If wasLastStateReached Then
                historyValue = panelValue
                panelValue = panelValue_Round(historyValue)
                wasLastStateReached = False
                TxtPanel.Text = panelValue
            End If
            pendingOperation = value
            TxtOperação.Text = value
        End If
    End Sub
    Private Sub changeVisibilityC()
        If stateCient Then
            BtnC.Visible = Not BtnC.Visible
            BtnCE.Visible = Not BtnCE.Visible
        End If
    End Sub
    Private Sub resetVariables()
        panelValue = 0
        historyValue = 0
        memoryValue = 0
        pendingOperation = ""
        isFirstOperation = True
        wasLastButtonOperation = False
        wasLastStateReached = False
        TxtOperação.Clear()
        TxtPanel.Text = panelValue
    End Sub
End Class
