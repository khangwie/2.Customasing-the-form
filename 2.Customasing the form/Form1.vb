Public Class btnClose
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My first App in 2023"
        Me.BackColor = Color.Blue
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Size = New Size(800, 400)
        Me.Opacity = 0.85   '
        Me.CenterToParent()  '
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub BtnEvans_Click(sender As Object, e As EventArgs) Handles btnEvans.Click

    End Sub
End Class
