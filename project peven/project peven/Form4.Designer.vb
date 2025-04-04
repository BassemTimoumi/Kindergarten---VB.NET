<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(166, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 37)
        Label2.TabIndex = 4
        Label2.Text = "Nom:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLightLight
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(166, 288)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 37)
        Label3.TabIndex = 5
        Label3.Text = "Prenom:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLightLight
        TextBox1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(310, 214)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 43)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlLightLight
        TextBox2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(310, 285)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(192, 43)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(470, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 56)
        Button1.TabIndex = 8
        Button1.Text = "Verifier"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLightLight
        Label10.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(230, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(362, 55)
        Label10.TabIndex = 53
        Label10.Text = "Jardin d’enfants"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(737, 450)
        Controls.Add(Label10)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
End Class
