Public Class Form2
    Dim da As New Database
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = da.RollNo & da.Name & da.MobileNo & da.Address
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        da.next1()
        TextBox1.Text = da.RollNo & da.Name & da.MobileNo & da.Address
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        da.asd()
        TextBox1.Text = da.RollNo & da.Name & da.MobileNo & da.Address
    End Sub
End Class