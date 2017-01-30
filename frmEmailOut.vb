Imports System.Net.Mail

Public Class frmEmailOut

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim AuditLog As New UsersDSTableAdapters.AuditTableTableAdapter
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            Dim attachment As System.Net.Mail.Attachment
            SmtpServer.Credentials = New  _
        Net.NetworkCredential("mychitterman@gmail.com", "SwissGear101")
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("mychitterman@gmail.com")
            mail.To.Add(TextBoxEmailAddress.Text)
            mail.Subject = "Grenada Carbinet Conclusion"
            mail.Body = "Please see the Cabinet Conclusion Requested." + vbNewLine +
                " Please do not reply to this address:" + vbNewLine +
                "If need be contact us on 14734406640"
            attachment = New System.Net.Mail.Attachment("C:/bcp/" + Form1.YEARLinkLabel.Text + "/" + Form1.filename) 'file path

            mail.Attachments.Add(attachment) 'attachment
            SmtpServer.Send(mail)

            Dim myAuditRecord = AuditLog.Insert(FormLogIn.TextBoxUser.Text, TextBoxEmailAddress.Text, Date.Today, "mail sent")
            MsgBox("mail send")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Dim myAuditRecord = AuditLog.Insert(FormLogIn.TextBoxUser.Text, TextBoxEmailAddress.Text, DateTime.Today, ex.ToString)

        End Try
        TextBoxEmailAddress.Text = ""
        Me.Close()
    End Sub
End Class