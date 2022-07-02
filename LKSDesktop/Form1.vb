Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim sql As SqlCommand
    Dim dr As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = New SqlCommand("select * from MsEmployee where email='" & ml.Text & "' AND password='" & ps.Text & "'", konek)
        dr = sql.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If (dr.Item("position") = "admin") Then
                sessionid = dr.Item("id")
                sessionnm = dr.Item("name")
                Form2.Show()
                Me.Hide()
            Else
                sessionid = dr.Item("id")
                sessionnm = dr.Item("name")
                Form3.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Maap data tidak valid")
        End If
    End Sub

End Class
