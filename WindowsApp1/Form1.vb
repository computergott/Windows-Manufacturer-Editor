Public Class Form1

    Public hersteller As String
    Public modell As String
    Public webseite As String
    Public support As String
    Public telefon As String



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        get_hersteller.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", Nothing)
        get_modell.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", Nothing)
        get_support.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportHours", Nothing)
        get_telefon.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportPhone", Nothing)
        get_webseite.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportURL", Nothing)

        hersteller = get_hersteller.Text
        modell = get_modell.Text
        webseite = get_webseite.Text
        support = get_support.Text
        telefon = get_telefon.Text

        remove.Enabled = True
        edit.Enabled = True
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Editor.ShowDialog()

    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", "")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", "")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportHours", "")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportPhone", "")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportURL", "")
            MsgBox("Der Herstellerverweis wurde entfernt!")
        Catch ex As Exception
            MsgBox("Entfernen des Herstellerverweises Fehlgeschlagen!" + Environment.NewLine + "Hat die Anwendung Adminrechte?")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logo.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Enabled = False

        'Prüfen ob Adminrechte da sind
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Adminrechte", "true")
        Catch ex As Exception
            MsgBox("Diese Anwendung hat keine Adminrechte! O_O" + Environment.NewLine + "Funktionen können eingeschränkt sein!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Panel1.Enabled = True
        Else
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://computergott.eu/")
    End Sub
End Class
