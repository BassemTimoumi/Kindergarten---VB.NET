<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Button2 = New Button()
        TextBoxFilePath = New Label()
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 3
        Label2.Text = "Nom:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLightLight
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(44, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 4
        Label3.Text = "Prenom:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLightLight
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(44, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 25)
        Label4.TabIndex = 5
        Label4.Text = "Date de naissance:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLightLight
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(44, 321)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 6
        Label5.Text = "Photo:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(235, 184)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(171, 33)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(235, 233)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(171, 33)
        TextBox2.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(528, 429)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 59)
        Button1.TabIndex = 11
        Button1.Text = "Envoyer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(235, 271)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(198, 33)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(235, 320)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 29)
        Button2.TabIndex = 13
        Button2.Text = "Ouvrir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBoxFilePath
        ' 
        TextBoxFilePath.AutoSize = True
        TextBoxFilePath.BackColor = SystemColors.ControlLightLight
        TextBoxFilePath.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxFilePath.Location = New Point(44, 352)
        TextBoxFilePath.Name = "TextBoxFilePath"
        TextBoxFilePath.Size = New Size(0, 25)
        TextBoxFilePath.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(44, 382)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(185, 165)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Journée complète", "Demi-journée"})
        ComboBox1.Location = New Point(562, 187)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(156, 33)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Avec repas", "Sans repas"})
        ComboBox2.Location = New Point(562, 236)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(156, 33)
        ComboBox2.TabIndex = 18
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Avec transport", "Sans transport"})
        ComboBox3.Location = New Point(562, 289)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(156, 33)
        ComboBox3.TabIndex = 19
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Sport", "Musique", "Coran", "Beaux Art"})
        ComboBox4.Location = New Point(562, 343)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(156, 33)
        ComboBox4.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLightLight
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(464, 292)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 25)
        Label6.TabIndex = 21
        Label6.Text = "Transport"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlLightLight
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(464, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 25)
        Label7.TabIndex = 22
        Label7.Text = "Repas:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlLightLight
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(464, 346)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 25)
        Label8.TabIndex = 23
        Label8.Text = "Clubs:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLightLight
        Label9.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(464, 190)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 25)
        Label9.TabIndex = 24
        Label9.Text = "Horaire:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLightLight
        Label10.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(235, 68)
        Label10.Name = "Label10"
        Label10.Size = New Size(362, 55)
        Label10.TabIndex = 52
        Label10.Text = "Jardin d’enfants"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(737, 559)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox1)
        Controls.Add(TextBoxFilePath)
        Controls.Add(Button2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxFilePath As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
