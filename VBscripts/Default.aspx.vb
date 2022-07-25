Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim obj As New Class1()
    Dim con1 As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim i As Integer
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String
            sql = "insert into test(name) values('" + TextBox1.Text + "')"
            i = obj.commonDML(sql)
            If (i >= 1) Then
                Response.Write("successful")
            Else
                Response.Write("failed")
            End If
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con1 = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Inetpub\wwwroot\EDUWEB\App_Data\Database.mdf;Integrated Security=True;User Instance=True")
        con1.Open()
        Dim sql1 As String
        sql1 = "select * from  test"
        da = New SqlDataAdapter(sql1, con1)
        dt = New DataTable()
        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim sql As String
            sql = "update table test set name='" + TextBox1.Text + "'"
            i = obj.commonDML(sql)
            If (i >= 1) Then
                Response.Write("successful")
            Else
                Response.Write("failed")
            End If
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
End Class
