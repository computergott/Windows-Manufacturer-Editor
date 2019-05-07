<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logoanalysator
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logoanalysator))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.vorschau = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.höhe = New System.Windows.Forms.Label()
        Me.breite = New System.Windows.Forms.Label()
        Me.Format = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vorschau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(451, 175)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'vorschau
        '
        Me.vorschau.Location = New System.Drawing.Point(359, 26)
        Me.vorschau.Name = "vorschau"
        Me.vorschau.Size = New System.Drawing.Size(141, 131)
        Me.vorschau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.vorschau.TabIndex = 15
        Me.vorschau.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Vorschau"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Bildmaße"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Breite"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Höhe"
        '
        'höhe
        '
        Me.höhe.AutoSize = True
        Me.höhe.Location = New System.Drawing.Point(76, 85)
        Me.höhe.Name = "höhe"
        Me.höhe.Size = New System.Drawing.Size(69, 13)
        Me.höhe.TabIndex = 21
        Me.höhe.Text = "Höhe in Pixel"
        '
        'breite
        '
        Me.breite.AutoSize = True
        Me.breite.Location = New System.Drawing.Point(76, 61)
        Me.breite.Name = "breite"
        Me.breite.Size = New System.Drawing.Size(70, 13)
        Me.breite.TabIndex = 20
        Me.breite.Text = "Breite in Pixel"
        '
        'Format
        '
        Me.Format.AutoSize = True
        Me.Format.Location = New System.Drawing.Point(75, 109)
        Me.Format.Name = "Format"
        Me.Format.Size = New System.Drawing.Size(39, 13)
        Me.Format.TabIndex = 23
        Me.Format.Text = "Format"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Format"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 78)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Damit das Logo verwendet werden kann, müssen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folgende Eigenschaften stimmen:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "+ Dateiformat .BMP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ Auflösung max. 120 x 120P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ Quadratisch"
        '
        'Logoanalysator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Format)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.höhe)
        Me.Controls.Add(Me.breite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vorschau)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Logoanalysator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gewähltes Logo analysieren"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vorschau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents vorschau As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents höhe As Label
    Friend WithEvents breite As Label
    Friend WithEvents Format As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
