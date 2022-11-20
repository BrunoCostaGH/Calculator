Imports System.ComponentModel

Public NotInheritable Class SplashScreen1
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Size = Calculator.Size
        Me.CenterToScreen()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If CBNotAgain.Checked Then
            My.Settings.AppDisplaySplashScreen = False
        Else
            My.Settings.AppDisplaySplashScreen = True
        End If
        My.Settings.Save()
        Me.Close()
    End Sub
End Class
