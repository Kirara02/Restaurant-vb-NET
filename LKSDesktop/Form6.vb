Imports System.Data
Imports System.Data.SqlClient
Public Class Form6
    Dim sql As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim orderid As String
    Sub clear()
        idm.Text = ""
        mn.Text = ""
        q.Text = ""
        ido.Text = ""
        img.Image = Nothing
    End Sub
    Sub fkode()
        Dim waktu As String = Format(Now, "yyyyMMdd")
        Dim urut As Integer
        sql = New SqlCommand("select top 1 orderid from OrderDetail where orderid like '%" & waktu & "%' order by orderid desc", konek)
        dr = sql.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            urut = Val(dr.Item("orderid").ToString.Substring(8, 4)) + 1
            orderid = waktu & Format(urut, "0000")
        Else
            orderid = waktu & "0001"
        End If
    End Sub
    Sub tmenu()
        da = New SqlDataAdapter("select * from MsMenu", konek)
        dt = New DataTable
        da.Fill(dt)
        dgv1.DataSource = dt
        dgv1.Columns("id").Visible = False
        dgv1.Columns("photo").Visible = False
    End Sub
    Sub torder()
        Dim total As Integer = 0
        Dim carbo As Integer = 0
        Dim protein As Integer = 0
        da = New SqlDataAdapter("select od.id as id,name as menu,qty,qty*carbo as carbo, qty*protein as protein, price, qty*price as total from OrderDetail as od join MsMenu as m on m.id=od.menuId where orderid=" & orderid, konek)
        dt = New DataTable
        da.Fill(dt)
        dgv2.DataSource = dt
        dgv2.Columns("id").Visible = False
        For i = 0 To dgv2.Rows.Count - 1
            total += Val(dgv2.Rows(i).Cells("total").Value)
        Next
        For i = 0 To dgv2.Rows.Count - 1
            carbo += Val(dgv2.Rows(i).Cells("carbo").Value)
        Next
        For i = 0 To dgv2.Rows.Count - 1
            protein += Val(dgv2.Rows(i).Cells("protein").Value)
        Next
        t.Text = total
        c.Text = carbo
        p.Text = protein
    End Sub
    Sub oid()
        Dim waktu As String = Format(Now, "yyyyMMdd")
        sql = New SqlCommand("insert into OrderHeader (id,employeeId,memberId,date) values ('" & orderid & "','" & sessionid & "','" & sessionid & "','" & waktu & "')", konek)
        sql.ExecuteNonQuery()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fkode()
        tmenu()
        torder()
        WindowState = FormWindowState.Maximized
        FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Try
            idm.Text = dgv1.Rows(e.RowIndex).Cells("id").Value
            mn.Text = dgv1.Rows(e.RowIndex).Cells("name").Value
            If dgv1.Rows(e.RowIndex).Cells("photo").Value <> "" Then
                img.Image = Image.FromFile("C:\Users\SERVER RPL\Documents\LKS\LKSDesktop\LKSDesktop\img\" & dgv1.Rows(e.RowIndex).Cells("photo").Value)
                img.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            q.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseClick
        Try
            ido.Text = dgv2.Rows(e.RowIndex).Cells("id").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub a_Click(sender As Object, e As EventArgs) Handles a.Click
        Try
            sql = New SqlCommand("select * from OrderHeader where id='" & orderid & "'", konek)
            dr = sql.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                sql = New SqlCommand("select * from OrderDetail where menuId='" & idm.Text & "' AND orderid=" & orderid, konek)
                dr = sql.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Dim qty As Integer = dr.Item("qty") + q.Text
                    sql = New SqlCommand("update OrderDetail set qty='" & qty & "' where menuId='" & idm.Text & "' AND orderid=" & orderid, konek)
                    sql.ExecuteNonQuery()
                    torder()
                    clear()
                Else
                    Dim status As String = "diproses"
                    sql = New SqlCommand("insert into OrderDetail (orderId,menuId,qty,status) values ('" & orderid & "','" & idm.Text & "','" & q.Text & "','" & status & "')", konek)
                    sql.ExecuteNonQuery()
                    torder()
                    clear()
                End If
            Else
                oid()
                Dim status As String = "diproses"
                sql = New SqlCommand("insert into OrderDetail (orderId,menuId,qty,status) values ('" & orderid & "','" & idm.Text & "','" & q.Text & "','" & status & "')", konek)
                sql.ExecuteNonQuery()
                torder()
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub d_Click(sender As Object, e As EventArgs) Handles d.Click
        Try
            sql = New SqlCommand("delete from OrderDetail where id='" & ido.Text & "' AND orderId=" & orderid, konek)
            sql.ExecuteNonQuery()
            torder()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub o_Click(sender As Object, e As EventArgs) Handles o.Click
        MsgBox("Pesanan sedang diproses")
        clear()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
        Me.Hide()
    End Sub
End Class