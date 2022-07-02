Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbn.Text = sessionnm
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.TopLevel = False
        Panel1.Controls.Add(Form7)
        Form7.BringToFront()
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
        Me.Hide()
    End Sub
End Class