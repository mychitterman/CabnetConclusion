Public Class Policy

    Private Sub Policy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = " Understanding the nature of policy implementation is important because international experience shows that policies, once adopted, are not always implemented as envisioned and do not necessarily achieve intended results (Bhuyan et al., 2010)."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PolicyFrameWork.ShowDialog()
    End Sub
End Class