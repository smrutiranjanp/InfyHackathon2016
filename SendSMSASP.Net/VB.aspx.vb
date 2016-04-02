Imports ASPSnippets.SmsAPI
Imports System.Collections.Generic
Imports System.Linq
Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub btnSend_Click(sender As Object, e As EventArgs)
        SMS.APIType = SMSGateway.Site2SMS
        SMS.MashapeKey = "<Mashape API Key>"
        SMS.Username = txtNumber.Text.Trim()
        SMS.Password = txtPassword.Text.Trim()
        If txtRecipientNumber.Text.Trim().IndexOf(",") = -1 Then
            'Single SMS
            SMS.SendSms(txtRecipientNumber.Text.Trim(), txtMessage.Text.Trim())
        Else
            'Multiple SMS
            Dim numbers As List(Of String) = txtRecipientNumber.Text.Trim().Split(","c).ToList()
            SMS.SendSms(numbers, txtMessage.Text.Trim())
        End If
    End Sub
End Class
