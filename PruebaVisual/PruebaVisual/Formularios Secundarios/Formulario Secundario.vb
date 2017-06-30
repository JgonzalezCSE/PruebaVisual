Imports System.IO

Public Class Formulario_Secundario

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim sr As New StreamReader("Words.txt")
        Dim word As String = ""
        Dim words(9) As String
        Dim i As Integer = 0

        Do Until sr.Peek = -1
            'grab one word at a time from the text file
            word = sr.ReadLine()

            'plase word int array
            words(i) = word

            'output
            ListBox1.Items.Add(words(i))

            'increment array counter
            i = i + 1

        Loop

    End Sub
End Class