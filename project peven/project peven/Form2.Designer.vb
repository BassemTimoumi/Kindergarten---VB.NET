<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(80, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(322, 37)
        Label2.TabIndex = 2
        Label2.Text = "Inscrire un nouvel enfant"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLightLight
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(80, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 37)
        Label3.TabIndex = 3
        Label3.Text = "Authentifier d’un enfant"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(440, 240)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 48)
        Button1.TabIndex = 4
        Button1.Text = "Inscrire"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(440, 316)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 48)
        Button2.TabIndex = 5
        Button2.Text = "Authentifier"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLightLight
        Label10.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(232, 70)
        Label10.Name = "Label10"
        Label10.Size = New Size(362, 55)
        Label10.TabIndex = 51
        Label10.Text = "Jardin d’enfants"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(740, 450)
        Controls.Add(Label10)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
End Class
