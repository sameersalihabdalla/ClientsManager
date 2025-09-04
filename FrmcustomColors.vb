Public Class FrmcustomColors
    Private Sub customColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.lbl_color1.BackColor = My.Settings.color1
            Me.lbl_color2.ForeColor = My.Settings.color2
            Me.lbl_color2.BackColor = My.Settings.color1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_color1_Click(sender As Object, e As EventArgs) Handles lbl_color1.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color1.BackColor = Me.ColorDialog1.Color
            lbl_color2.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            My.Settings.color1 = Me.lbl_color1.BackColor
            My.Settings.color2 = Me.lbl_color2.ForeColor


            My.Settings.Save()

            Me.Close()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_color2_Click(sender As Object, e As EventArgs) Handles lbl_color2.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color2.ForeColor = Me.ColorDialog1.Color

        End If
    End Sub
End Class