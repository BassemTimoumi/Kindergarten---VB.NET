Imports System.IO
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New Form2()

        Me.Hide()

        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form5 As New Form5()

        Me.Hide()

        Form5.Show()
    End Sub
End Class
Public Class Form5
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form6 As New Form6()

        Me.Hide()

        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form7 As New Form7()

        Me.Hide()

        Form7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form8 As New Form8()

        Me.Hide()

        Form8.Show()
    End Sub

End Class

Public Class Form6
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True

        If IsValidName(nom) = False Then
            test = False
            MessageBox.Show("Veuillez saisir un nom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IsValidName(prenom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un prenom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If test = True Then

            If File.Exists("SavedInformation.txt") = True Then
                Dim trouve As Boolean = False
                Dim lines As List(Of String) = File.ReadAllLines("SavedInformation.txt").ToList()
                For i As Integer = 0 To lines.Count - 1

                    Dim parties As String() = lines(i).Split("*"c, StringSplitOptions.RemoveEmptyEntries)


                    If parties.Length = 8 AndAlso parties(0) = nom AndAlso parties(1) = prenom Then
                        trouve = True

                        lines.RemoveAt(i)

                        Exit For
                    End If
                Next

                If trouve Then
                    Try

                        File.WriteAllLines("SavedInformation.txt", lines)
                        Dim Form9 As New Form9()




                        Me.Hide()

                        Form9.Show()
                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}", "Error")
                    End Try
                Else
                    MessageBox.Show("L'enfant n'est pas inscrit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Le fichier n'existe pas.", "Erreur")
            End If
        End If

    End Sub
    Private Function IsValidName(name As String) As Boolean

        Return Not String.IsNullOrEmpty(name) AndAlso
               name.Length >= 3 AndAlso
               name.Length <= 20 AndAlso
               name.All(Function(c) Char.IsLetter(c)) AndAlso
               Not name.Contains(" ")
    End Function


End Class

Public Class Form7
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True
        Dim price As Integer = 0

        If IsValidName(nom) = False Then
            test = False
            MessageBox.Show("Veuillez saisir un nom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IsValidName(prenom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un prenom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If test = True Then
            Dim parties As String()

            If File.Exists("SavedInformation.txt") = True Then
                Dim trouve As Boolean = False
                Dim lignes As String() = File.ReadAllLines("SavedInformation.txt")
                For Each ligne As String In lignes
                    parties = ligne.Split("*"c, StringSplitOptions.RemoveEmptyEntries)

                    If parties.Length = 8 AndAlso parties(0) = nom AndAlso parties(1) = prenom Then
                        trouve = True
                        Exit For
                    End If
                Next

                If trouve Then
                    If parties(4) = "Journée complète" Then
                        price = price + 20
                    ElseIf parties(4) = "Demi-journée" Then
                        price = price + 10
                    End If

                    If parties(5) = "Avec repas" Then
                        price = price + 10
                    ElseIf parties(5) = "Sans repas" Then
                        price = price + 0
                    End If

                    If parties(6) = "Avec transport" Then
                        price = price + 5
                    ElseIf parties(6) = "Sans transport" Then
                        price = price + 0
                    End If

                    If parties(7) = "Sport" Then
                        price = price + 15
                    ElseIf parties(7) = "Musique" Then
                        price = price + 10
                    ElseIf parties(7) = "Coran" Then
                        price = price + 5
                    ElseIf parties(7) = "Beaux Art" Then
                        price = price + 10
                    End If

                    Label4.Text = price.ToString()
                Else

                    MessageBox.Show("L'enfant n'est pas inscrit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Le fichier n'existe pas.", "Erreur")
            End If
        End If





    End Sub

    Private Function IsValidName(name As String) As Boolean

        Return Not String.IsNullOrEmpty(name) AndAlso
               name.Length >= 3 AndAlso
               name.Length <= 20 AndAlso
               name.All(Function(c) Char.IsLetter(c)) AndAlso
               Not name.Contains(" ")
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True
        Dim price As Integer
        If Label4.Text <> "" Then
            price = Label4.Text
        End If

        If File.Exists("payment.txt") = True Then
                Dim trouve As Boolean = False
                Dim lignes As String() = File.ReadAllLines("payment.txt")
                For Each ligne As String In lignes
                    Dim parties As String() = ligne.Split("*"c, StringSplitOptions.RemoveEmptyEntries)

                    If parties.Length = 3 AndAlso parties(0) = nom AndAlso parties(1) = prenom Then
                        trouve = True
                        Exit For
                    End If
                Next

            If trouve Then
                MessageBox.Show("L'enfant déjà payé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If Label4.Text <> "" Then
                    Try

                        Dim fileName As String = "payment.txt"


                        Using writer As New StreamWriter(fileName, True)

                            writer.WriteLine($"{nom}*{prenom}*{price}")
                        End Using


                        MessageBox.Show("Information enregistrer au fichier.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception

                        MessageBox.Show($"Error saving information to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("Avoir le prix !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If



            End If
            Label4.Text = ""
        Else

                MessageBox.Show("Le fichier n'existe pas.", "Erreur")
            End If







    End Sub



End Class



Public Class Form9

    Dim selectedFilePath As String
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form6.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True


        If IsValidName(nom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un nom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



        If IsValidName(prenom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un prenom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If TextBoxFilePath.Text = "" Then
            test = False
            MessageBox.Show("Veuillez choisir une photo.", "Invalid photo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim selectedCategory1 As String
        Dim selectedCategory2 As String
        Dim selectedCategory3 As String
        Dim selectedCategory4 As String
        If ComboBox1.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> -1 And ComboBox3.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 Then

            selectedCategory1 = ComboBox1.SelectedItem.ToString()
            selectedCategory2 = ComboBox2.SelectedItem.ToString()
            selectedCategory3 = ComboBox3.SelectedItem.ToString()
            selectedCategory4 = ComboBox4.SelectedItem.ToString()


        Else
            test = False
            MessageBox.Show("Veuillez sélectionner une catégorie dans la ComboBox.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SelectedDate As DateTime

        SelectedDate = DateTimePicker1.Value
        Dim formattedDate As String = SelectedDate.ToString("yyyy-MM-dd")
        If test = True Then
            Try

                Dim fileName As String = "SavedInformation.txt"


                Using writer As New StreamWriter(fileName, True)

                    writer.WriteLine($"{nom}*{prenom}*{formattedDate}*{selectedFilePath}*{selectedCategory1}*{selectedCategory2}*{selectedCategory3}*{selectedCategory4}")
                End Using


                MessageBox.Show("Information saved to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception

                MessageBox.Show($"Error saving information to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function IsValidName(name As String) As Boolean

        Return Not String.IsNullOrEmpty(name) AndAlso
               name.Length >= 3 AndAlso
               name.Length <= 20 AndAlso
               name.All(Function(c) Char.IsLetter(c)) AndAlso
               Not name.Contains(" ")
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim openFileDialog As New OpenFileDialog()


        openFileDialog.Title = "Select a Photo"
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"


        If openFileDialog.ShowDialog() = DialogResult.OK Then

            selectedFilePath = openFileDialog.FileName



            TextBoxFilePath.Text = selectedFilePath
            PictureBox1.ImageLocation = selectedFilePath
        End If


    End Sub



End Class


Public Class Form8
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True


        If IsValidName(nom) = False Then
            test = False
            MessageBox.Show("Veuillez saisir un nom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IsValidName(prenom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un prenom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If test = True Then

            If File.Exists("SavedInformation.txt") = True Then
                Dim trouve As Boolean = False
                Dim lines As List(Of String) = File.ReadAllLines("SavedInformation.txt").ToList()
                For i As Integer = 0 To lines.Count - 1

                    Dim parties As String() = lines(i).Split("*"c, StringSplitOptions.RemoveEmptyEntries)


                    If parties.Length = 8 AndAlso parties(0) = nom AndAlso parties(1) = prenom Then
                        trouve = True



                        Exit For
                    End If
                Next

                If trouve Then

                    Dim Form10 As New Form10
                    Form10.Nom = nom
                    Form10.Prenom = prenom
                    Me.Hide()
                    Form10.Show()
                Else
                    MessageBox.Show("L'enfant n'est pas inscrit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Le fichier n'existe pas.", "Erreur")
            End If
        End If

    End Sub
    Private Function IsValidName(name As String) As Boolean

        Return Not String.IsNullOrEmpty(name) AndAlso
               name.Length >= 3 AndAlso
               name.Length <= 20 AndAlso
               name.All(Function(c) Char.IsLetter(c)) AndAlso
               Not name.Contains(" ")
    End Function
End Class


Public Class Form10
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form8.Show()
    End Sub

    Public Property Nom As String
    Public Property Prenom As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label6.Text = Nom
        Label7.Text = Prenom
        Dim photo As String

        If File.Exists("SavedInformation.txt") = True Then
            Dim lines As List(Of String) = File.ReadAllLines("SavedInformation.txt").ToList()
            For i As Integer = 0 To lines.Count - 1

                Dim parties As String() = lines(i).Split("*"c, StringSplitOptions.RemoveEmptyEntries)


                If parties.Length = 8 AndAlso parties(0) = Nom AndAlso parties(1) = Prenom Then
                    photo = parties(3)
                    PictureBox1.ImageLocation = photo


                    Exit For
                End If
            Next

        Else
            MessageBox.Show("Le fichier n'existe pas.", "Erreur")
        End If




    End Sub

    Private Sub PrintPreviewDialog1_Click(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Click
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub






End Class


Public Class Form2
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form3 As New Form3()

        Me.Hide()

        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form4 As New Form4()

        Me.Hide()

        Form4.Show()
    End Sub
End Class

Public Class Form3

    Dim selectedFilePath As String
    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True


        If IsValidName(nom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un nom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



        If IsValidName(prenom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un prenom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If TextBoxFilePath.Text = "" Then
            test = False
            MessageBox.Show("Veuillez choisir une photo.", "Invalid photo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim selectedCategory1 As String
        Dim selectedCategory2 As String
        Dim selectedCategory3 As String
        Dim selectedCategory4 As String
        If ComboBox1.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> -1 And ComboBox3.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 Then

            selectedCategory1 = ComboBox1.SelectedItem.ToString()
            selectedCategory2 = ComboBox2.SelectedItem.ToString()
            selectedCategory3 = ComboBox3.SelectedItem.ToString()
            selectedCategory4 = ComboBox4.SelectedItem.ToString()


        Else
            test = False
            MessageBox.Show("Veuillez sélectionner une catégorie dans la ComboBox.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SelectedDate As DateTime

        SelectedDate = DateTimePicker1.Value
        Dim formattedDate As String = SelectedDate.ToString("yyyy-MM-dd")
        If test = True Then
            Try

                Dim fileName As String = "SavedInformation.txt"


                Using writer As New StreamWriter(fileName, True)

                    writer.WriteLine($"{nom}*{prenom}*{formattedDate}*{selectedFilePath}*{selectedCategory1}*{selectedCategory2}*{selectedCategory3}*{selectedCategory4}")
                End Using


                MessageBox.Show("Information enregistrer au fichier.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception

                MessageBox.Show($"Erreur d'enregistrement au fichier: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function IsValidName(name As String) As Boolean

        Return Not String.IsNullOrEmpty(name) AndAlso
               name.Length >= 3 AndAlso
               name.Length <= 20 AndAlso
               name.All(Function(c) Char.IsLetter(c)) AndAlso
               Not name.Contains(" ")
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim openFileDialog As New OpenFileDialog()


        openFileDialog.Title = "Select a Photo"
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"


        If openFileDialog.ShowDialog() = DialogResult.OK Then

            selectedFilePath = openFileDialog.FileName



            TextBoxFilePath.Text = selectedFilePath
            PictureBox1.ImageLocation = selectedFilePath
        End If


    End Sub

End Class

Public Class Form4

    Private Sub SecondForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim test As Boolean = True

        If IsValidName(nom) = False Then
            test = False
            MessageBox.Show("Veuillez saisir un nom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If IsValidName(prenom) = False Then

            test = False
            MessageBox.Show("Veuillez saisir un prenom valide (alphabétique, sans espaces, maximum 20 lettres et minimum 3).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If test = True Then

            If File.Exists("SavedInformation.txt") = True Then
                Dim trouve As Boolean = False
                Dim lignes As String() = File.ReadAllLines("SavedInformation.txt")
                For Each ligne As String In lignes
                    Dim parties As String() = ligne.Split("*"c, StringSplitOptions.RemoveEmptyEntries)

                    If parties.Length = 8 AndAlso parties(0) = nom AndAlso parties(1) = prenom Then
                        trouve = True
                        Exit For
                    End If
                Next

                If trouve Then
                    MessageBox.Show("L'enfant déja inscrit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("L'enfant n'est pas inscrit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Else

                MessageBox.Show("Le fichier n'existe pas.", "Erreur")
            End If
        End If
    End Sub
    Private Function IsValidName(name As String) As Boolean

        Return Not String.IsNullOrEmpty(name) AndAlso
               name.Length >= 3 AndAlso
               name.Length <= 20 AndAlso
               name.All(Function(c) Char.IsLetter(c)) AndAlso
               Not name.Contains(" ")
    End Function


End Class
