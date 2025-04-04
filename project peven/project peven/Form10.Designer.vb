<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form10))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PrintPreviewDialog1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog2 = New PrintPreviewDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(359, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 0
        Label1.Text = "Diplome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(339, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 1
        Label2.Text = "Congratulations"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(255, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(283, 30)
        Label3.TabIndex = 2
        Label3.Text = vbCrLf & "vous avez terminé la maternelle au [ jardin d'enfant ]"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(231, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(322, 15)
        Label4.TabIndex = 3
        Label4.Text = "et recevez ce certificat en reconnaissance de vos réalisations"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.Location = New Point(621, 191)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Size = New Size(75, 23)
        PrintPreviewDialog1.TabIndex = 4
        PrintPreviewDialog1.Text = "Imprimer"
        PrintPreviewDialog1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(346, 15)
        Label5.TabIndex = 5
        Label5.Text = "signé par : Timoumi Bassem, Essonni Hayfa, Neffati Mohammed" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(276, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(276, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(39, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(621, 148)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog2
        ' 
        PrintPreviewDialog2.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog2.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog2.ClientSize = New Size(400, 300)
        PrintPreviewDialog2.Document = PrintDocument1
        PrintPreviewDialog2.Enabled = True
        PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), Icon)
        PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        PrintPreviewDialog2.Visible = False
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PrintPreviewDialog1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form10"
        Text = "Form10"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintPreviewDialog1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
End Class
