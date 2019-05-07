Public Class Editor

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Manufacturer", hersteller.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Model", Modell.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportHours", SuppTime.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportPhone", SuppTel.Text)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "SupportURL", web.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox("Das Setzen der Informationen ist gescheitert!" + Environment.NewLine + Environment.NewLine + "Beachte, dass die Anwendung als Admin laufen muss!")
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        hersteller.Text = Form1.hersteller
        Modell.Text = Form1.modell
        SuppTime.Text = Form1.support
        SuppTel.Text = Form1.telefon
        web.Text = Form1.webseite
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        hersteller.Text = ""
        Modell.Text = ""
        SuppTime.Text = ""
        SuppTel.Text = ""
        web.Text = ""
    End Sub
End Class