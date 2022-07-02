Imports System.Data
Imports System.Data.SqlClient
Public Class Form7
    Dim sql As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim status As String = "diproses"
    Sub clear()
        o.Text = ""
        p.Text = ""
        n.Text = ""
        b.Text = ""
    End Sub
    Sub tampil()
        Dim total As Integer = 0
        da = New SqlDataAdapter("select name as menu,qty, price, qty*price as total from OrderDetail as od join MsMenu as m on m.id=od.menuId where orderid='" & o.Text & "' AND status='" & status & "'", konek)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        For i = 0 To DataGridView1.Rows.Count - 1
            total += Val(DataGridView1.Rows(i).Cells("total").Value)
        Next
        t.Text = total
    End Sub
    Sub orderid()
        sql = New SqlCommand("select orderid from OrderDetail where status='" & status & "' group by orderid", konek)
        dr = sql.ExecuteReader
        While (dr.Read)
            o.Items.Add(dr.Item("orderid"))
        End While
    End Sub
    Sub upstatus()
        Dim upsts As String = "dibayar"
        sql = New SqlCommand("update OrderDetail set status='" & upsts & "' where orderId='" & o.Text & "'", konek)
        sql.ExecuteNonQuery()
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        orderid()
        WindowState = FormWindowState.Maximized
        FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub o_SelectedIndexChanged(sender As Object, e As EventArgs) Handles o.SelectedIndexChanged
        tampil()
    End Sub

    Private Sub p_SelectedIndexChanged(sender As Object, e As EventArgs) Handles p.SelectedIndexChanged
        If p.Text = "Cash" Then
            b.Enabled = False
            n.Enabled = False
            Button1.Enabled = True
        ElseIf p.Text = "Credit Card" Then
            b.Enabled = True
            n.Enabled = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If p.Text = "Cash" Then
            Dim tb As Integer = Val(t.Text)
            Dim uang As String = Val(InputBox("Total bayar Rp." & tb, vbOKOnly, ""))
            Dim km As Integer = Val(uang - tb)
            If (uang >= tb) Then
                Dim waktu As String = Format(Now, "yyyyMMdd")
                sql = New SqlCommand("update OrderHeader set date='" & waktu & "',paymentType='" & p.Text & "',cardNumber='" & n.Text & "',bank='" & b.Text & "' where id='" & o.Text & "'", konek)
                sql.ExecuteNonQuery()
                upstatus()
                o.Items.Clear()
                orderid()
                clear()
                tampil()
                MsgBox("Pembayaran berhhasil, kembalian Rp." & km, vbOKOnly, "Kembalian")
            Else
                MsgBox("Pembayaran gagal, uang anda kurang")
            End If
        ElseIf p.Text = "Credit Card" Then
            Dim waktu As String = Format(Now, "yyyyMMdd")
            sql = New SqlCommand("update OrderHeader set date='" & waktu & "',paymentType='" & p.Text & "',cardNumber='" & n.Text & "',bank='" & b.Text & "' where id='" & o.Text & "'", konek)
            sql.ExecuteNonQuery()
            upstatus()
            o.Items.Clear()
            orderid()
            clear()
            tampil()
            MsgBox("Transaksi berhasil")
        End If
    End Sub

    Private Sub Form7_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form3.Show()
        Me.Hide()
    End Sub
End Class