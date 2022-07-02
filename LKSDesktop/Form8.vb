Imports System.Data
Imports System.Data.SqlClient

Public Class Form8
    Dim sql As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Sub table()
        da = New SqlDataAdapter("select format(oh.date,'MMMM') as month, sum(m.price*od.qty/10000) as income from OrderHeader as oh join OrderDetail as od on oh.id=od.orderId join MsMenu as m on m.id=od.menuId group by format(oh.date,'MMMM')", konek)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Sub diagram()
        sql = New SqlCommand("select format(oh.date,'MMMM') as month, sum(m.price*od.qty/10000) as income from OrderHeader as oh join OrderDetail as od on oh.id=od.orderId join MsMenu as m on m.id=od.menuId group by format(oh.date,'MMMM')", konek)
        dr = sql.ExecuteReader
        Chart1.Series.Clear()
        Chart1.Titles.Add("Income in million")
        Dim i As Integer
        While (dr.Read())
            Chart1.Series.Add(dr.Item("month"))
            Chart1.Series(i).Points.Add(dr.Item("income"))
            i = i + 1
        End While
    End Sub
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 12
            f.Items.Add(MonthName(New DateTime(1, i, 1).Month.ToString))
            t.Items.Add(MonthName(New DateTime(1, i, 1).Month.ToString))
        Next
        table()
        diagram()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        da = New SqlDataAdapter("select format(oh.date,'MMMM') as month, sum(m.price*od.qty/10000) as income from OrderHeader as oh join OrderDetail as od on oh.id=od.orderId join MsMenu as m on m.id=od.menuId where format(oh.date,'MM') >= month('" & f.Text & " 02 2022') AND format(oh.date,'MM') <= month('" & t.Text & " 02 2022') group by format(oh.date,'MMMM')", konek)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        sql = New SqlCommand("select format(oh.date,'MMMM') as month, sum(m.price*od.qty/10000) as income from OrderHeader as oh join OrderDetail as od on oh.id=od.orderId join MsMenu as m on m.id=od.menuId where format(oh.date,'MM') >= month('" & f.Text & " 02 2022') AND format(oh.date,'MM') <= month('" & t.Text & " 02 2022') group by format(oh.date,'MMMM')", konek)
        dr = sql.ExecuteReader
        Chart1.Series.Clear()
        Dim i As Integer
        While (dr.Read())
            Chart1.Series.Add(dr.Item("month"))
            Chart1.Series(i).Points.Add(dr.Item("income"))
            i = i + 1
        End While
    End Sub
End Class