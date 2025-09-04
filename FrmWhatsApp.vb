Imports MySql.Data.MySqlClient

Public Class FrmWhatsApp
    Dim sec As Integer = 0

    Private Sub FrmWhatsApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter = 1
        Dim phoneNum As String
        Dim msg
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String
        dvg.Rows.Clear()





        sql = "SELECT
    `tbl_clients`.`clientID`
    , `tbl_clients`.`clientName`
    , `tbl_clients`.`phoneNumber`
    , (SUM(`tbl_tranc`.`debit`)-SUM(`tbl_tranc`.`credit`)) AS Balance
   
FROM
    `dbstudentpayment`.`tbl_tranc`
    INNER JOIN `dbstudentpayment`.`tbl_clients`
        ON (`tbl_clients`.`clientID` = `tbl_tranc`.`clientid`)
        
        GROUP BY `tbl_clients`.`clientID`
     
       
        ;"
        If Not con.State = ConnectionState.Closed Then
            con.Close()
        End If
        con.Open()
        cmd.CommandText = sql
        cmd.Connection = con
        rd = cmd.ExecuteReader
        Dim total
        While (rd.Read())

            If (rd.Item(3) <> 0) Then
                Me.dvg.Rows.Add(counter, rd.Item(1), rd.Item(0), " ", "249" & rd.Item(2).ToString.Remove(0, 1).ToString, "إرسال الحساب")
                counter = counter + 1
            End If


        End While



        con.Close()

        Dim mmsg = ""
        Dim totalcost
        For i As Integer = 0 To Me.dvg.Rows.Count - 1




            Try

                sql = "select * from tbl_tranc where credit=0 and clientid=" & Me.dvg.Rows(i).Cells(2).Value & "  order by trancID"
                If Not con.State = ConnectionState.Closed Then
                    con.Close()
                End If
                con.Open()
                cmd.CommandText = sql
                cmd.Connection = con
                rd = cmd.ExecuteReader
                While (rd.Read())

                    totalcost = totalcost + rd.Item(8)
                    mmsg = mmsg & vbNewLine & "*" & rd.Item(8) & "* | " & rd.Item(1)


                End While

                dvg.Rows(i).Cells(3).Value = "Details : " & mmsg & vbNewLine & "Total Cost :        *" & totalcost & "* S.D.G " & vbNewLine
                mmsg = ""
                totalcost = 0
            Catch ex As Exception

            End Try

            con.Close()



        Next







        Dim dgv As DataGridView = Me.dvg

        For i As Integer = 0 To dgv.Rows.Count - 1
            For ColNo As Integer = 5 To 5


                If i Mod 2 = 0 Then



                    dgv.Rows(i).Cells(5).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(5).Style.ForeColor = My.Settings.color2

                    dgv.Rows(i).Cells(4).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(4).Style.ForeColor = My.Settings.color2





                    dgv.Rows(i).Cells(3).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(3).Style.ForeColor = My.Settings.color2


                    dgv.Rows(i).Cells(2).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(2).Style.ForeColor = My.Settings.color2

                    dgv.Rows(i).Cells(1).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(1).Style.ForeColor = My.Settings.color2


                End If

            Next
        Next


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec += 1
        If sec = 1 Then
            SendKeys.Send("{ENTER}")
            Timer1.Stop()
            sec = 0
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




    End Sub

    Private Sub dvg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg.CellContentClick
        If e.ColumnIndex = 5 Then

            passing()
        End If
    End Sub


    Sub passing()





        Try
            Dim web As New WebBrowser
            web.Navigate("whatsapp://send?phone=" & Me.dvg.CurrentRow.Cells(4).Value & "&text=" & Me.dvg.CurrentRow.Cells(3).Value.Replace(" ", "+").ToString.Replace(vbNewLine, "%0A") & "")

            Timer1.Start()
        Catch ex As Exception
            MsgBox("ربما تعذر الارسال")

            Timer1.Stop()

        End Try

    End Sub
End Class