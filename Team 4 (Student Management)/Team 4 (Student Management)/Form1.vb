Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        XVisualProgressBar1.Value = XVisualProgressBar1.Value + 5
        If XVisualProgressBar1.Value = XVisualProgressBar1.Maximum Then
            Timer1.Stop()
            k11.Show()
            XVisualProgressBar1.Visible = False
            Me.Hide()
        End If

    End Sub

    Private Sub AscButton3_Click_2(sender As Object, e As EventArgs) Handles AscButton3.Click
        Dim a As String = Nothing
        If TextBox1.Text = a Then
            TextBox1.Focus()
            TextBox1.Clear()
        ElseIf TextBox2.Text = a Then
            TextBox2.Focus()
            TextBox2.Clear()
        End If

        If TextBox1.Text = "team4" And
      TextBox2.Text = "umak" Then
            TextBox1.Visible = False
            TextBox2.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            AscButton1.Visible = True

            AscButton3.Hide()
            AscButton4.Visible = True
            ThirteenButton1.Visible = True
            ThirteenButton2.Visible = True
            ThirteenButton5.Visible = True
            ThirteenButton6.Visible = True
        Else
            MsgBox("Incorrect Username/Password", MsgBoxStyle.Critical, "Wrong combination")
            TextBox1.Focus()
            TextBox1.Clear()
            TextBox2.Focus()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub AscButton1_Click_1(sender As Object, e As EventArgs) Handles AscButton1.Click
        Timer1.Start()
        XVisualProgressBar1.Visible = True
    End Sub

    Private Sub AscButton4_Click_1(sender As Object, e As EventArgs) Handles AscButton4.Click
        TextBox1.Visible = True
        TextBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        AscButton1.Visible = False

        AscButton3.Show()
        AscButton4.Visible = False
        RichTextBox1.Visible = False
        ThirteenButton4.Visible = False
        Help1.Visible = False
        ThirteenButton3.Visible = False
        ThirteenButton2.Visible = False
        ThirteenButton1.Visible = False
        RichTextBox3.Visible = False
        RichTextBox2.Visible = False
        ThirteenButton6.Visible = False
        ThirteenButton5.Visible = False
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click
        Help1.Visible = True
        ThirteenButton1.Visible = False
        ThirteenButton3.Visible = True

    End Sub

    Private Sub ThirteenButton2_Click(sender As Object, e As EventArgs) Handles ThirteenButton2.Click
        RichTextBox1.Visible = True
        ThirteenButton2.Visible = False
        ThirteenButton4.Visible = True
    End Sub

    Private Sub ThirteenButton3_Click(sender As Object, e As EventArgs) Handles ThirteenButton3.Click
        Help1.Visible = False
        ThirteenButton3.Visible = False
        ThirteenButton1.Visible = True
    End Sub

    Private Sub ThirteenButton4_Click(sender As Object, e As EventArgs) Handles ThirteenButton4.Click
        RichTextBox1.Visible = False
        ThirteenButton4.Visible = False
        ThirteenButton2.Visible = True
    End Sub

    Private Sub ThirteenButton5_Click(sender As Object, e As EventArgs) Handles ThirteenButton5.Click
        RichTextBox2.Visible = True
        ThirteenButton5.Visible = False
        ThirteenButton7.Visible = True

    End Sub

  
    Private Sub ThirteenButton6_Click(sender As Object, e As EventArgs) Handles ThirteenButton6.Click
        RichTextBox3.Visible = True
        ThirteenButton6.Visible = False
        ThirteenButton8.Visible = True
    End Sub

    Private Sub ThirteenButton7_Click(sender As Object, e As EventArgs) Handles ThirteenButton7.Click
        RichTextBox2.Visible = False
        ThirteenButton7.Visible = False
        ThirteenButton5.Visible = True
    End Sub

    Private Sub ThirteenButton8_Click(sender As Object, e As EventArgs) Handles ThirteenButton8.Click
        RichTextBox3.Visible = False
        ThirteenButton8.Visible = False
        ThirteenButton6.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()
        If Me.PictureBox2.Visible = True Then
            Me.PictureBox2.Visible = False
        End If
        Me.PictureBox2.Visible = True
    End Sub
End Class
