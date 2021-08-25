Public Class index

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles hardware.Click
        Dim f2 As New Form2
        f2.Show()

        f2.category.Text = hardware.Text
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles software.Click
        Dim f2 As New Form2
        f2.Show()

        f2.category.Text = software.Text
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles internet.Click
        Dim f2 As New Form2
        f2.Show()

        f2.category.Text = internet.Text
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles others.Click
        Dim f2 As New Form2
        f2.Show()

        f2.category.Text = others.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class
