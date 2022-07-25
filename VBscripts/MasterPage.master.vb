Imports System

Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Timertime_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timertime.Tick
        Labeltime.Text = System.DateTime.Now.ToLongTimeString()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Labeldate.Text = System.DateTime.Now.ToLongDateString()
        If (Session("uname") Is Nothing) Then
            LbLogin.Text = "Login"
            Labeluname.Visible = False
            Labelwelcome.Visible = False
            
        Else
            Labeluname.Visible = True
            Labelwelcome.Visible = True
            Labeluname.Text = Session("uname").ToString()
            LbLogin.Text = "Logout"
            
        End If
    End Sub

    Protected Sub LbLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LbLogin.Click
        If (LbLogin.Text = "Logout") Then


            Session.Abandon()
            Labelwelcome.Visible = False
            Labeluname.Text = ""
            LbLogin.Text = "Login"

        End If

        If (LbLogin.Text = "Login") Then

            Response.Redirect("Login.aspx")
        End If


    End Sub
End Class

