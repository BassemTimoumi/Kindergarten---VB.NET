<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        Button3 = New Button()
        Label4 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(506, 339)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 42)
        Button3.TabIndex = 13
        Button3.Text = "Consulter"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLightLight
        Label4.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(69, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(350, 37)
        Label4.TabIndex = 12
        Label4.Text = "Une attestation de diplôme"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(506, 275)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 42)
        Button2.TabIndex = 11
        Button2.Text = "Paiment"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(506, 213)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 42)
        Button1.TabIndex = 10
        Button1.Text = "Mise a jour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLightLight
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(69, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 37)
        Label3.TabIndex = 9
        Label3.Text = "Suivi de paiement"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(69, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(366, 37)
        Label2.TabIndex = 8
        Label2.Text = "Mise à jour un fiche d'enfant"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLightLight
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(227, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(362, 55)
        Label1.TabIndex = 14
        Label1.Text = "Jardin d’enfants"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(736, 450)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
