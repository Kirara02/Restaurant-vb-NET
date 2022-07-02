Imports System.Data
Imports System.Data.SqlClient
Public Class Form5
    Dim sql As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Sub clear()
        cr.Text = ""
        id.Text = ""
        nm.Text = ""
        ml.Text = ""
        hp.Text = ""
    End Sub
    Sub tampil()
        da = New SqlDataAdapter("select * from MsMember", konek)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
    End Sub
    Sub cari(cari)
        da = New SqlDataAdapter("select * from MsMember where CAST(id as varchar)='" & cari & "' OR CAST(name as varchar) like '%" & cari & "%' OR CAST(email as varchar) like '%" & cari & "%' OR CAST(handphone as varchar) like '%" & cari & "%' ", konek)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        WindowState = FormWindowState.Maximized
        FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub s_Click(sender As Object, e As EventArgs) Handles s.Click
        Try
            sql = New SqlCommand("select * from MsMember where CAST(id as varchar)='" & cr.Text & "' OR CAST(name as varchar) like '%" & cr.Text & "%' OR CAST(email as varchar) like '%" & cr.Text & "%' OR CAST(handphone as varchar) like '%" & cr.Text & "%' ", konek)
            dr = sql.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                id.Text = dr.Item("id")
                nm.Text = dr.Item("name")
                ml.Text = dr.Item("email")
                hp.Text = dr.Item("handphone")
                cari(cr.Text)
            Else
                tampil()
                clear()
                MsgBox("Data tidak ditemukan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub i_Click(sender As Object, e As EventArgs) Handles i.Click
        Try
            If (MsgBox("Tambah data ini?", vbOKCancel, "Insert")) = vbOK Then
                Dim waktu As String = Format(Now, "yyyyMMdd")
                sql = New SqlCommand("insert into MsMember (name,email,handphone,joindate) values ('" & nm.Text & "','" & ml.Text & "','" & hp.Text & "','" & waktu & "')", konek)
                sql.ExecuteNonQuery()
                tampil()
                clear()
                MsgBox("Data berhasil ditambahkan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub u_Click(sender As Object, e As EventArgs) Handles u.Click
        Try
            If (MsgBox("Edit data ini?", vbOKCancel, "Update")) = vbOK Then
                sql = New SqlCommand("update MsMember set name='" & nm.Text & "',email='" & ml.Text & "',handphone='" & hp.Text & "' where id='" & id.Text & "' ", konek)
                sql.ExecuteNonQuery()
                tampil()
                clear()
                MsgBox("Data berhasil diedit")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub d_Click(sender As Object, e As EventArgs) Handles d.Click
        Try
            If (MsgBox("Hapus data ini?", vbOKCancel, "Delete")) = vbOK Then
                sql = New SqlCommand("delete from MsMember where id='" & id.Text & "'", konek)
                sql.ExecuteNonQuery()
                tampil()
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        Try
            id.Text = dgv.Rows(e.RowIndex).Cells("id").Value
            nm.Text = dgv.Rows(e.RowIndex).Cells("name").Value
            ml.Text = dgv.Rows(e.RowIndex).Cells("email").Value
            hp.Text = dgv.Rows(e.RowIndex).Cells("handphone").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
        Me.Hide()
    End Sub
End Class