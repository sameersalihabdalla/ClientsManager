Imports System.Web.UI.WebControls

Public Class frmlogin



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        If Me.UsernameTextBox.Text = "sameer" And Me.PasswordTextBox.Text = "sameersudani" Then
            frmMain.Show()
            Me.Close()

        Else
            MsgBox("يرجى ادخال كلمة مرور صحيحة و اسم مستخدم", vbMsgBoxRtlReading + vbMsgBoxRight, "info")

        End If


    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OK.BackColor = My.Settings.color1
        OK.ForeColor = My.Settings.color2

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class
