Public Class Form1

    Private Sub Abstract_btn_Click(sender As Object, e As EventArgs) Handles Abstract_btn.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Proceed_btn_Click(sender As Object, e As EventArgs) Handles Proceed_btn.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
