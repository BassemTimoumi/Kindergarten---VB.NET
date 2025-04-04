<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form9))
        TextBoxFilePath = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        DomainUpDown1 = New DomainUpDown()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxFilePath
        ' 
        TextBoxFilePath.AutoSize = True
        TextBoxFilePath.BackColor = SystemColors.ControlLightLight
        TextBoxFilePath.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxFilePath.Location = New Point(35, 372)
        TextBoxFilePath.Name = "TextBoxFilePath"
        TextBoxFilePath.Size = New Size(0, 25)
        TextBoxFilePath.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLightLight
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(449, 195)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 25)
        Label9.TabIndex = 48
        Label9.Text = "Horaire:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlLightLight
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(449, 351)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 25)
        Label8.TabIndex = 47
        Label8.Text = "Clubs:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlLightLight
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(449, 244)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 25)
        Label7.TabIndex = 46
        Label7.Text = "Repas:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLightLight
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(449, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 25)
        Label6.TabIndex = 45
        Label6.Text = "Transport"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Sport", "Musique", "Coran", "Beaux Art"})
        ComboBox4.Location = New Point(552, 348)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(160, 33)
        ComboBox4.TabIndex = 44
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Avec transport", "Sans transport"})
        ComboBox3.Location = New Point(552, 294)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(160, 33)
        ComboBox3.TabIndex = 43
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Avec repas", "Sans repas"})
        ComboBox2.Location = New Point(552, 241)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(160, 33)
        ComboBox2.TabIndex = 42
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Journée complète", "Demi-journée"})
        ComboBox1.Location = New Point(552, 192)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(160, 33)
        ComboBox1.TabIndex = 41
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(35, 407)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(185, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(227, 335)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 29)
        Button2.TabIndex = 39
        Button2.Text = "Ouvrir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(227, 291)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 33)
        DateTimePicker1.TabIndex = 38
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(537, 449)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 55)
        Button1.TabIndex = 37
        Button1.Text = "Modifier"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(227, 241)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(177, 33)
        TextBox2.TabIndex = 36
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(227, 192)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 33)
        TextBox1.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLightLight
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(35, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 25)
        Label5.TabIndex = 34
        Label5.Text = "Photo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLightLight
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(35, 297)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 25)
        Label4.TabIndex = 33
        Label4.Text = "Date de naissance:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLightLight
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(35, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 32
        Label3.Text = "Prenom:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(35, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 25)
        Label2.TabIndex = 31
        Label2.Text = "Nom:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLightLight
        Label10.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(227, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(362, 55)
        Label10.TabIndex = 50
        Label10.Text = "Jardin d’enfants"
        ' 
        ' DomainUpDown1
        ' 
        DomainUpDown1.Location = New Point(354, 433)
        DomainUpDown1.Name = "DomainUpDown1"
        DomainUpDown1.Size = New Size(120, 23)
        DomainUpDown1.TabIndex = 51
        DomainUpDown1.Text = "DomainUpDown1"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(736, 561)
        Controls.Add(DomainUpDown1)
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
        Controls.Add(Button2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBoxFilePath)
        Name = "Form9"
        Text = "Form9"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBoxFilePath As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DomainUpDown1 As DomainUpDown
End Class
