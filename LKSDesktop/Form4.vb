Imports System.Data
Imports System.Data.SqlClient
Public Class Form4
    Dim sql As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Sub clear()
        cr.Text = ""
        id.Text = ""
        nm.Text = ""
        pr.Text = ""
        ph.Text = ""
        cb.Text = ""
        pt.Text = ""
        img.Image = Nothing
    End Sub
    Sub tampil()
        da = New SqlDataAdapter("select * from MsMenu", konek)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
    End Sub
    Sub cari(cari)
        da = New SqlDataAdapter("select * from MsMenu where CAST(id as varchar)='" & cari & "' OR CAST(name as varchar) like '%" & cari & "%' OR CAST(price as varchar)='" & cari & "' OR CAST(carbo as varchar)='" & cari & "' OR CAST(protein as varchar)='" & cari & "' ", konek)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        WindowState = FormWindowState.Maximized
        FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub s_Click(sender As Object, e As EventArgs) Handles s.Click
        Try
            sql = New SqlCommand("select * from MsMenu where CAST(id as varchar)='" & cr.Text & "' OR CAST(name as varchar) like '%" & cr.Text & "%' OR CAST(price as varchar)='" & cr.Text & "' OR CAST(carbo as varchar)='" & cr.Text & "' OR CAST(protein as varchar)='" & cr.Text & "' ", konek)
            dr = sql.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                id.Text = dr.Item("id")
                nm.Text = dr.Item("name")
                pr.Text = dr.Item("price")
                ph.Text = dr.Item("photo")
                cb.Text = dr.Item("carbo")
                pt.Text = dr.Item("protein")
                If dr.Item("photo") <> "" Then
                    img.Image = Image.FromFile("C:\Users\SERVER RPL\Documents\LKS\LKSDesktop\LKSDesktop\img\" & dr.Item("photo"))
                    img.SizeMode = PictureBoxSizeMode.StretchImage
                End If
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
                Dim fname As String = waktu & ph.Text
                Dim folder As String = "C:\Users\SERVER RPL\Documents\LKS\LKSDesktop\LKSDesktop\img\"
                Dim pathString As String = System.IO.Path.Combine(folder, fname)
                img.Image.Save(pathString)
                sql = New SqlCommand("insert into MsMenu (name,price,photo,carbo,protein) values ('" & nm.Text & "','" & pr.Text & "','" & fname & "','" & cb.Text & "','" & pt.Text & "')", konek)
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
                Dim waktu As String = Format(Now, "yyyyMMdd")
                Dim fname As String = waktu & ph.Text
                Dim folder As String = "C:\Users\SERVER RPL\Documents\LKS\LKSDesktop\LKSDesktop\img\"
                Dim pathString As String = System.IO.Path.Combine(folder, fname)
                img.Image.Save(pathString)
                sql = New SqlCommand("update MsMenu set name='" & nm.Text & "',price='" & pr.Text & "',photo='" & fname & "',carbo='" & cb.Text & "',protein='" & pt.Text & "' where id='" & id.Text & "' ", konek)
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
                sql = New SqlCommand("delete from MsMenu where id='" & id.Text & "'", konek)
                sql.ExecuteNonQuery()
                tampil()
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub g_Click(sender As Object, e As EventArgs) Handles g.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                img.Image = Image.FromFile(OpenFileDialog1.FileName)
                img.SizeMode = PictureBoxSizeMode.StretchImage
                ph.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        Try
            id.Text = dgv.Rows(e.RowIndex).Cells("id").Value
            nm.Text = dgv.Rows(e.RowIndex).Cells("name").Value
            pr.Text = dgv.Rows(e.RowIndex).Cells("price").Value
            ph.Text = dgv.Rows(e.RowIndex).Cells("photo").Value
            cb.Text = dgv.Rows(e.RowIndex).Cells("carbo").Value
            pt.Text = dgv.Rows(e.RowIndex).Cells("protein").Value
            If dgv.Rows(e.RowIndex).Cells("photo").Value <> "" Then
                img.Image = Image.FromFile("C:\Users\SERVER RPL\Documents\LKS\LKSDesktop\LKSDesktop\img\" & dgv.Rows(e.RowIndex).Cells("photo").Value)
                img.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
        Me.Hide()
    End Sub
End Class