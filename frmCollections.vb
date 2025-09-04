Imports MySql.Data.MySqlClient

Public Class frmCollections
    Private Sub loading()
        txtmbokid.Text = ""
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Dim sql As String




        sql = "SELECT * from tbl_tranc where trancID=" & Val(txtr_no.Text) & ""



        If Not con.State = ConnectionState.Closed Then
            con.Close()

        End If
        con.Open()


        cmd.CommandText = sql
        cmd.Connection = con
        rd = cmd.ExecuteReader


        If rd.Read Then




            lbldate.Text = Format(rd.Item(6), "yyy-MM-dd")
            lbldebit.Text = rd.Item(8).ToString
            lblcreadit.Text = rd.Item(9).ToString
            lbltype.Text = rd.Item(3).ToString
            lblcat.Text = rd.Item(4).ToString
            lblname.Text = rd.Item(2).ToString
            lblmethod.Text = rd.Item(10).ToString
            txtmbokid.Text = rd.Item(13).ToString
            clientname.Text = rd.Item(1)
        End If
        con.Close()

        If lblcreadit.Text = lbldebit.Text Then
            Button3.Visible = False
            Button2.Visible = False
            Button4.Visible = False
            lbldebit.BackColor = Color.Green
        Else
            lbldebit.BackColor = Color.Red

            Button3.Visible = True
            Button2.Visible = True
            Button4.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtr_no_Click(sender As Object, e As EventArgs) Handles txtr_no.Click

    End Sub

    Private Sub txtr_no_TextChanged(sender As Object, e As EventArgs) Handles txtr_no.TextChanged
        loading()

    End Sub

    Private Sub peymentpost_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        loading()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New MySqlCommand
        Dim result As Boolean
        Dim sql As String
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Try
            con.Open()
            With cmd

                sql = "update tbl_tranc set credit =" & lbldebit.Text & " , paymentmethod='Cash', paymentdate='" & dd & "' where trancid=" & txtr_no.Text & ";"
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    MsgBox("")

                Else
                    MsgBox("تم سداد المعاملة بنجاح")
                    Close()


                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtmbokid.Text = "" Then
            MsgBox("ادخل رقم المعاملة من الاشعار")
            txtmbokid.Focus()
            Exit Sub

        End If
        Dim cmd As New MySqlCommand
        Dim result As Boolean
        Dim sql As String
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Try
            con.Open()
            With cmd

                sql = "update tbl_tranc set credit =" & lbldebit.Text & " , paymentmethod='Mbok',mbok_id='" & txtmbokid.Text & "', paymentdate='" & dd & "' where trancid=" & txtr_no.Text & ";"
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    MsgBox("")

                Else
                    MsgBox("تم سداد المعاملة بنجاح")
                    Close()


                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As New MySqlCommand
        Dim result As Boolean
        Dim sql As String
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Try
            con.Open()
            With cmd

                sql = "update tbl_tranc set credit =" & lbldebit.Text & " , paymentmethod='PAN', paymentdate='" & dd & "' where trancid=" & txtr_no.Text & ";"
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    MsgBox("")

                Else
                    MsgBox("تم سداد المعاملة بنجاح")
                    Close()



                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub lblcreadit_Click(sender As Object, e As EventArgs) Handles lblcreadit.Click

    End Sub

    Private Sub lblcat_Click(sender As Object, e As EventArgs) Handles lblcat.Click

    End Sub






    Private Sub lastdebit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub clientid_Click(sender As Object, e As EventArgs) Handles clientid.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Dim sql As String

        Dim sure = MsgBox("هل تريد فعلا حذف المعاملة ؟", vbYesNo)
        If sure = vbYes Then


            sql = "delete  from tbl_tranc where trancID=" & Val(txtr_no.Text) & ""



            If Not con.State = ConnectionState.Closed Then
                con.Close()

            End If
            con.Open()


            cmd.CommandText = sql
            cmd.Connection = con
            rd = cmd.ExecuteReader


            MsgBox("تم الحذف بنجاح")


            con.Close()
            Close()

        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class