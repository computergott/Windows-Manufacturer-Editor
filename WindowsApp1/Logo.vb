Public Class Logo
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
    Private test As String
    Private backup As String
    Private restore As String
    Public Bild As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            pfad.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", Nothing)
            prelogo.Image = Image.FromFile(pfad.Text)
            pfad.Visible = True
            PictureBox3.Visible = True
        Catch ex As Exception
            MsgBox("Es ist kein Logo hinterlegt -_-", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        test = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", Nothing)
        If test = "" Then
            MsgBox("Es gibt einen Fehler bei der Aktion" + Environment.NewLine + "Die Funktion wurde abgebrochen")
        Else
            Try
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo_CGBackup", test)
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", "")
                prelogo.Image.Dispose()
                pfad.Text = ""
                pfad.Visible = False
                prelogo.Image = Nothing

                'Button Gedönse
                PictureBox3.Visible = False
                PictureBox4.Visible = True

                MsgBox("Das Logo wurde entfernt. Du bist Frei!" + Environment.NewLine + Environment.NewLine + "Das alte Logo wurde in einen Backup-Schlüssel verschoben" + Environment.NewLine + "Über den blauen Button kannst Du es wiederherstellen")
            Catch ex As Exception
                MsgBox("Die Anwendung hat keine Adminrechte!")
            End Try


        End If
    End Sub

    Private Sub Logo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prelogo.Image = Nothing
        pfad.Visible = False

        'Prüfen ob Backup da ist
        PictureBox4.Visible = False
        PictureBox3.Visible = False
        Try
            backup = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo_CGBackup", Nothing)
        Catch ex As Exception
            MsgBox("Error!")
        End Try

        If backup = "" Then

        Else
            PictureBox4.Visible = True
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Backup wiederherstellen
        Try
            backup = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo_CGBackup", Nothing)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", backup)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo_CGBackup", "")
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            MsgBox("Dein Logo ist wieder da! Puh o.O", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Das Wiederherstellen ist gescheitert ^_^", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim Höhe As Integer
        Dim Breite As Integer
        Bild = ""
        LogoWaehlen.FileName = ""

        'LogoWaehlen.Filter = "BMP-Logo (*.bmp)| *.bmp"
        LogoWaehlen.ShowDialog()

        Try
            Dim img As Image = Image.FromFile(LogoWaehlen.FileName)
            Höhe = img.Height
            Breite = img.Width
            Bild = LogoWaehlen.FileName.ToString
            'MsgBox(höhe.ToString)
            'MessageBox.Show("Width: " + img.Width.ToString() + ", Height: " + img.Height.ToString())
        Catch ex As Exception
            MsgBox("Die gewählte Datei ist nicht gültig!")
            Return
        End Try

        'Bildabmessungen prüfen

        Dim prüfung As Integer
        prüfung = 0

        If Höhe < 121 Then
            prüfung = prüfung + 1
        End If

        If Breite < 121 Then
            prüfung = prüfung + 1
        End If

        If Breite = Höhe Then
            prüfung = prüfung + 1
        End If

        If prüfung = 3 Then
            Try
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo", Bild)
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", "Logo_CGBackup", "")
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                MsgBox("Das gewählte Logo wurde gesetzt!")
            Catch ex As Exception
                MsgBox("Also das Logo wäre in Ordnung :)" + Environment.NewLine + "Allerdings konnte es nicht festgelegt werden!")
            End Try

        Else
            MsgBox("Das Logo ist nicht in Ordnung! ^_^" + Environment.NewLine + Environment.NewLine + "Klicke auf OK, um den Logo-Analysator zu starten")
            Logoanalysator.ShowDialog()
        End If

    End Sub

End Class