﻿
Partial Class contactList
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim ContactList As String
        ContactList = txtFirstName.Text & " " & txtLastName.Text & " | " & txtEmail.Text & " | " & RadioButtonList1.Text & " | " & CheckBoxList1.Items(0).Text & "" & CheckBoxList1.Items(1).Text & "" & CheckBoxList1.Items(2).Text & "" & CheckBoxList1.Items(3).Text & " ~ "
        My.Computer.FileSystem.WriteAllText(Server.MapPath("~/contact.txt"), ContactList, True)
        Label1.Text = "Thank you for submitting!"
    End Sub
End Class
