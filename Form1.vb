Public Class Form1
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CloseButton_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CloseButton_MouseEnter(sender As Object, e As EventArgs) Handles CloseButton.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ml_tb_TextChanged(sender As Object, e As EventArgs) Handles ml_tb.TextChanged

        If ml_tb.Text <> "" Then
            g_tb.Text = Format(Convert.ToInt32(ml_tb.Text) / My.Settings.Ratio, "0.00")
        End If

    End Sub

    Private Sub Ml_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ml_tb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub G_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles g_tb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub G_tb_TextChanged(sender As Object, e As EventArgs) Handles g_tb.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Ratio = 16

        If ml_tb.Text <> "" Then
            g_tb.Text = Format(Convert.ToInt32(ml_tb.Text) / My.Settings.Ratio, "0.00")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Ratio = 14

        If ml_tb.Text <> "" Then
            g_tb.Text = Format(Convert.ToInt32(ml_tb.Text) / My.Settings.Ratio, "0.00")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Ratio = 18

        If ml_tb.Text <> "" Then
            g_tb.Text = Format(Convert.ToInt32(ml_tb.Text) / My.Settings.Ratio, "0.00")
        End If

    End Sub
End Class
