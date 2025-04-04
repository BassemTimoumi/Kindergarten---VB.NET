<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form7))
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label4 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(495, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 43)
        Button1.TabIndex = 20
        Button1.Text = "Prix"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(355, 278)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(179, 43)
        TextBox2.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(355, 207)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(179, 43)
        TextBox1.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLightLight
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(193, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 37)
        Label3.TabIndex = 17
        Label3.Text = "Prenom:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(193, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 37)
        Label2.TabIndex = 16
        Label2.Text = "Nom:"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(495, 394)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 43)
        Button2.TabIndex = 21
        Button2.Text = "Payer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(261, 336)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 37)
        Label4.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLightLight
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(229, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(362, 55)
        Label1.TabIndex = 24
        Label1.Text = "Jardin d’enfants"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(736, 450)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
