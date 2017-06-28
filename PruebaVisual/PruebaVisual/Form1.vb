Public Class Form1

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For index As Integer = 1 To 5
            Label1.Text = index
            Me.Refresh()
            System.Threading.Thread.Sleep(1000)
        Next





        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
        'Label1.Text = "2"
        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
        'Label1.Text = "3"
        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
        'Label1.Text = "4"
        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
        'Label1.Text = "5"

    End Sub
End Class
