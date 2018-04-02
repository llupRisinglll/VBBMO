
Public Class Form1
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim FirstNum, SecondNum As Double
        FirstNum = TextBox1.Text
        SecondNum = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = FirstNum + SecondNum
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = FirstNum - SecondNum
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = FirstNum * SecondNum
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = FirstNum / SecondNum
        End If


    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        End
    End Sub
End Class
