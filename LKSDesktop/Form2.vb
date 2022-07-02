Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbn.Text = sessionnm
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.TopLevel = False
        Panel1.Controls.Add(Form6)
        Form6.BringToFront()
        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.TopLevel = False
        Panel1.Controls.Add(Form4)
        Form4.BringToFront()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.TopLevel = False
        Panel1.Controls.Add(Form5)
        Form5.BringToFront()
        Form5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
        Me.Hide()
    End Sub
End Class