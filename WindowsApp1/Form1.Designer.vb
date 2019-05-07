<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.get_hersteller = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.get_modell = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.get_telefon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.get_webseite = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.get_support = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.remove = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.edit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'get_hersteller
        '
        Me.get_hersteller.Location = New System.Drawing.Point(2, 18)
        Me.get_hersteller.Name = "get_hersteller"
        Me.get_hersteller.ReadOnly = True
        Me.get_hersteller.Size = New System.Drawing.Size(100, 20)
        Me.get_hersteller.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hersteller"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modell"
        '
        'get_modell
        '
        Me.get_modell.Location = New System.Drawing.Point(108, 18)
        Me.get_modell.Name = "get_modell"
        Me.get_modell.ReadOnly = True
        Me.get_modell.Size = New System.Drawing.Size(100, 20)
        Me.get_modell.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Support-Telefon"
        '
        'get_telefon
        '
        Me.get_telefon.Location = New System.Drawing.Point(2, 69)
        Me.get_telefon.Name = "get_telefon"
        Me.get_telefon.ReadOnly = True
        Me.get_telefon.Size = New System.Drawing.Size(100, 20)
        Me.get_telefon.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Webseite"
        '
        'get_webseite
        '
        Me.get_webseite.Location = New System.Drawing.Point(108, 69)
        Me.get_webseite.Name = "get_webseite"
        Me.get_webseite.ReadOnly = True
        Me.get_webseite.Size = New System.Drawing.Size(100, 20)
        Me.get_webseite.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Supportzeiten"
        '
        'get_support
        '
        Me.get_support.Location = New System.Drawing.Point(214, 69)
        Me.get_support.Name = "get_support"
        Me.get_support.ReadOnly = True
        Me.get_support.Size = New System.Drawing.Size(100, 20)
        Me.get_support.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(5, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Werte auslesen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Enabled = False
        Me.remove.Image = CType(resources.GetObject("remove.Image"), System.Drawing.Image)
        Me.remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.remove.Location = New System.Drawing.Point(5, 161)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(309, 23)
        Me.remove.TabIndex = 12
        Me.remove.Text = "Hersteller entfernen"
        Me.remove.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Funktionen"
        '
        'edit
        '
        Me.edit.Enabled = False
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.Location = New System.Drawing.Point(5, 190)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(309, 23)
        Me.edit.TabIndex = 14
        Me.edit.Text = "Eigene Werte eintragen (auf eigene Gefahr)"
        Me.edit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Version 1.3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 21)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Logo-Informationen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.edit)
        Me.Panel1.Controls.Add(Me.get_hersteller)
        Me.Panel1.Controls.Add(Me.remove)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.get_modell)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.get_telefon)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.get_webseite)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.get_support)
        Me.Panel1.Location = New System.Drawing.Point(15, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 223)
        Me.Panel1.TabIndex = 17
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 257)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(304, 30)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Ich verstehe, dass die Nutzung der Anwendung auf eigene" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gefahr geschieht"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(216, 236)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 13)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Tool by Computergott.eu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 288)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Manufacturer Editor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents get_hersteller As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents get_modell As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents get_telefon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents get_webseite As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents get_support As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents remove As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents edit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
