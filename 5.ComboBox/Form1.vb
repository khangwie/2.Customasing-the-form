﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myItem
        myItem = InputBox("Enter your phone")

        ComboBox1.Items.Add(myItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myItem
        myItem = InputBox("Enter your phone")

        ComboBox1.Items.Add(myItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myItem2
        myItem2 = InputBox("Enter your phone")

        ComboBox1.Items.Remove(myItem2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()

    End Sub
End Class
