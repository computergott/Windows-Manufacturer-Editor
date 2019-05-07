Public Class Logoanalysator
    Dim Bildhöhe As Integer
    Dim Bildbreite As Integer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Logoanalysator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vorschau.Image = Image.FromFile(Logo.Bild.ToString)
        Dim img As Image = Image.FromFile(Logo.Bild)
        Bildhöhe = img.Height
        Bildbreite = img.Width

        If Bildbreite > 120 Then
            breite.Text = "[✘] Das Bild ist zu breit: " + Bildbreite.ToString + " Pixel"
        Else
            breite.Text = "[✔] Die Breite ist mit " + Bildbreite.ToString + " Pixeln in Ordnung"
        End If

        If Bildhöhe > 120 Then
            höhe.Text = "[✘] Das Bild ist zu hoch: " + Bildhöhe.ToString + " Pixel"
        Else
            höhe.Text = "[✔] Die Höhe ist mit " + Bildhöhe.ToString + " Pixeln in Ordnung"
        End If

        If Bildhöhe = Bildbreite Then
            Format.Text = "[✔] Das Format ist 1:1"
        Else
            Format.Text = "[✘] Das Bils muss quadratisch (1:1) sein"
        End If
    End Sub
End Class