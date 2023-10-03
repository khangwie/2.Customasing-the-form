Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(Val(TextBox1.Text) + Val(TextBox2.Text))
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        MsgBox("The sum is = " & Val(TextBox1.Text) + Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)

    End Sub

    Private Sub Btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        MsgBox("The Substration is = " & Val(TextBox1.Text) + Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)

    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        MsgBox("The Division is = " & Val(TextBox1.Text) + Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ListBox1.Item.Add("Redmi")

        Dim myitem

        myitem = InputBox("enter your fav phone ")
        ListBox1.Item.Add(myitem)

    End Sub
End Class
