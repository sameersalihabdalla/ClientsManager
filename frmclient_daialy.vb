Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Threading
Imports System.Web

Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Imports System.Globalization
Imports Microsoft.VisualBasic


Public Class frmclient_daialy
    Dim sec As Integer = 0

    Private Sub lblclient_id_Click(sender As Object, e As EventArgs) Handles lblclient_id.Click

    End Sub

    Private Sub lblclient_id_TextChanged(sender As Object, e As EventArgs) Handles lblclient_id.TextChanged



        Dim d1, d2

        d1 = Format(DateTimePicker2.Value, "yyyy-MM-dd").ToString
        d2 = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
        lastdebit_f(d1, d2)


        suma(d1, d2)


    End Sub


    Sub suma(ByVal x, ByVal y)
        totaldocumentscount.Text = ""
        lbltc.Text = ""
        tbalance.Text = ""
        lbltd.Text = ""
        Dim rdx As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim conn As MySqlConnection = myconn()
        sql = "SELECT COUNT(`trancID`) AS `counter` , SUM(`debit`) AS tdebit , SUM(`credit`) AS tcridet FROM  `tbl_tranc` where (`tbl_tranc`.`datee` BETWEEN '" & x & "' AND'" & y & "') and `tbl_tranc`.`clientid`='" & Me.lblclient_id.Text & "' "


        '  sql = "select * from tbl_tranc where clientid='" & Me.lblclient_id.Text & "'"
        cmd.CommandText = sql
        conn.Open()
        cmd.Connection = conn
        rdx = cmd.ExecuteReader()
        Try
            If rdx.Read() Then


                totaldocumentscount.Text = rdx.Item(0)


                Dim r = Val(rdx.Item(1))
                Dim r2 = Val(rdx.Item(2))
                lbltd.Text = Format(Double.Parse(r), "###,###.00")
                If Val(r2 - r) = 0 Then
                    tbalance.Text = "NIL"
                    tbalance.BackColor = My.Settings.color1
                    tbalance.ForeColor = My.Settings.color2



                Else
                    tbalance.BackColor = My.Settings.color1
                    tbalance.ForeColor = My.Settings.color2


                    tbalance.Text = Format(Double.Parse(r2 - r), "###,###")
                End If
                If r2 <> 0 Then
                    lbltc.Text = Format(Double.Parse(r2), "###,###.00")
                Else
                    lbltc.Text = 0
                End If

                Dim xx
                xx = Val(r2 / r) * 100

                'lblper.Text = "%" & Math.Truncate(xx)
            End If

        Catch ex As Exception

        End Try


        sms()


    End Sub
    Private Function StripSpaces(input As String) As String
        Return String.Join(" ", input.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
    End Function

    Sub sms()
        Dim collec As String

        collec = " "



        Try
            Dim dgv3 As DataGridView = Me.lastdebit

            For ii As Integer = 0 To dgv3.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv3.Rows(ii).Cells(5).Value) = 0 Then
                        collec = collec & vbNewLine & "*" & StripSpaces(dgv3.Rows(ii).Cells(9).Value) & "*  _" & StripSpaces(dgv3.Rows(ii).Cells(4).Value) & "_"
                    End If

                Next
            Next

        Catch ex As Exception

        End Try
        Me.RichTextBox1.Text = ""





        Dim dgv As DataGridView = Me.lastdebit




        Try
            Dim N

            N = -Me.tbalance.Text




            Me.RichTextBox1.Text = " جملة المطلوب سداده من " & vbNewLine & Format(DateTimePicker2.Value, "yyyy-MM-dd") & " *إلى* " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & vbNewLine & " هو : " & vbNewLine


            Me.RichTextBox1.Text = Me.RichTextBox1.Text & "*" & Format(N, "###,###.00 SDG").ToString & "*" & vbNewLine & " *التفاصيــل:*  " & vbNewLine & collec
        Catch ex As Exception

        End Try
        If lbltd.Text = lbltc.Text And lbltc.Text <> "" Then


            RichTextBox1.Text = " *تم سداد مطالبتك للفترة من* " & vbNewLine & Format(DateTimePicker2.Value, "yyyy-MM-dd") & " *إلى* " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & vbNewLine & " *البالغة*  *" & Me.lbltc.Text & "* بنجاح" & vbNewLine

            Dim dgv4 As DataGridView = Me.lastdebit
            Dim news
            For ii As Integer = 0 To dgv4.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv4.Rows(ii).Cells(5).Value) <> 0 Then
                        news = news & vbNewLine & "*" & StripSpaces(dgv4.Rows(ii).Cells(9).Value) & "*  _" & StripSpaces(dgv4.Rows(ii).Cells(4).Value) & "_" & vbNewLine & "____ ___________ _______"
                    End If

                Next
            Next
            RichTextBox1.Text = RichTextBox1.Text & news

        End If






    End Sub

    Sub lastdebit_f(ByVal x, ByVal y)

        Try

            lastdebit.Rows.Clear()
            findthis("Select
     `tbl_tranc`.`trancID`
    , `tbl_clients`.`clientName`
    , `tbl_tranc`.`cat`
    , `tbl_tranc`.`datee`
    , `tbl_tranc`.`debit`
    , `tbl_tranc`.`credit`
   ,`tbl_clients`.`clientID`
 , `tbl_tranc`.`paymentmethod`
, `tbl_tranc`.`paymentdate`,`tbl_tranc`.`docid`
FROM
    `tbl_tranc`
    INNER JOIN `dbstudentpayment`.`tbl_clients` 
        ON (`tbl_tranc`.`clientid` = `tbl_clients`.`clientID`) WHERE (`tbl_tranc`.`clientid`= '" & lblclient_id.Text & "' and `tbl_tranc`.`datee` BETWEEN '" & x & "' AND'" & y & "')  ORDER BY tbl_tranc.trancid ;")
            LoadData(lastdebit, "loadlastdebit")




            lastdebit.Columns(0).Visible = False


            Dim dgv As DataGridView = Me.lastdebit


            For i As Integer = 0 To dgv.Rows.Count - 1

                For ColNo As Integer = 6 To 6
                    If Val(dgv.Rows(i).Cells(ColNo).Value.ToString) > 0 Then
                        dgv.Rows(i).Cells(10).Value = "تسديد"
                        dgv.Rows(i).Cells(10).Style.ForeColor = Color.White
                        dgv.Rows(i).Cells(10).Style.BackColor = Color.DarkRed

                        dgv.Rows(i).Cells(ColNo).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(ColNo).Style.ForeColor = My.Settings.color2

                    End If

                    If Val(dgv.Rows(i).Cells(ColNo).Value.ToString) <0 Then
                        dgv.Rows(i).Cells(10).Value = "تسوية"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2
                    End If
                    If Val(dgv.Rows(i).Cells(ColNo).Value.ToString) = 0 Then
                        dgv.Rows(i).Cells(10).Value = "مسددة"

                        dgv.Rows(i).Cells(10).Style.BackColor = Color.DarkGreen
                        dgv.Rows(i).Cells(10).Style.ForeColor = Color.White

                    End If
                Next
            Next



            Dim dgv3 As DataGridView = Me.lastdebit

            For ii As Integer = 0 To dgv3.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv3.Rows(ii).Cells(ColNo).Value) < 0 And dgv3.Rows(ii).Cells(ColNo).Value <> Nothing Then

                        dgv3.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1

                        dgv3.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                    End If
                Next
            Next




        Catch ex As Exception

        End Try











    End Sub



    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim d1, d2

        d1 = Format(DateTimePicker2.Value, "yyyy-MM-dd")
            d2 = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            lastdebit_f(d1, d2)
            suma(d1, d2)
        sms()



    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim d1, d2

        d1 = Format(DateTimePicker2.Value, "yyyy-MM-dd")
            d2 = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        lastdebit_f(d1, d2)
        suma(d1, d2)
        sms()
    End Sub

    Private Sub frmclient_daialy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lastdebit.AlternatingRowsDefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.AlternatingRowsDefaultCellStyle.SelectionBackColor = My.Settings.color1
        lastdebit.DefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.DefaultCellStyle.SelectionBackColor = My.Settings.color1
        lastdebit.RowsDefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.RowsDefaultCellStyle.SelectionBackColor = My.Settings.color1
        lastdebit.RowHeadersDefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.RowHeadersDefaultCellStyle.SelectionBackColor = My.Settings.color1
        lblclient_id.BackColor = My.Settings.color1
        Label1.BackColor = My.Settings.color1
        Label3.BackColor = My.Settings.color1
        Label4.BackColor = My.Settings.color1
        Label6.BackColor = My.Settings.color1
        Label7.BackColor = My.Settings.color1
        Label9.BackColor = My.Settings.color1
        Button1.BackColor = My.Settings.color1
        Button1.ForeColor = My.Settings.color2

        Label1.ForeColor = My.Settings.color2
        Label3.ForeColor = My.Settings.color2
        Label4.ForeColor = My.Settings.color2
        Label6.ForeColor = My.Settings.color2
        Label7.ForeColor = My.Settings.color2
        Label9.ForeColor = My.Settings.color2
        lbltc.BackColor = My.Settings.color2
        lbltd.BackColor = My.Settings.color2
        lbltc.ForeColor = My.Settings.color1
        lbltd.ForeColor = My.Settings.color1
        txtclientname.BackColor = My.Settings.color2
        txtclientname.ForeColor = My.Settings.color1

        totaldocumentscount.BackColor = My.Settings.color2
        totaldocumentscount.ForeColor = My.Settings.color1



        tooo.BackColor = My.Settings.color1
        tooo.ForeColor = My.Settings.color2


        from.BackColor = My.Settings.color1
        from.ForeColor = My.Settings.color2


        DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"

        Dim d1, d2
        d1 = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        d2 = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        lastdebit_f(d1, d2)
        suma(d1, d2)


        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String
        sql = "SELECT * from tbl_clients where clientID=" & Me.lblclient_id.Text
        If Not con.State = ConnectionState.Closed Then
            con.Close()
        End If
        con.Open()
        cmd.CommandText = sql
        cmd.Connection = con
        rd = cmd.ExecuteReader
        If rd.Read Then
            Me.phoneNumBox.Text = "249" & rd.Item(2).ToString.Remove(0, 1)
        End If
        con.Close()
    End Sub


    Sub passing()
        Try
            With lastdebit.CurrentRow

                frmCollections.txtr_no.Text = .Cells(0).Value
                frmCollections.ShowDialog()
            End With
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmclient_daialy_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim d1, d2
        Try
            d1 = Format(DateTimePicker2.Value, "yyyy-MM-dd")
            d2 = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            lastdebit_f(d1, d2)
            suma(d1, d2)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub lastdebit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lastdebit.CellContentClick
        If e.ColumnIndex = 10 Then

            passing()
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim web As New WebBrowser
            web.Navigate("whatsapp://send?phone=" & phoneNumBox.Text & "&text=" & Me.RichTextBox1.Text.Replace(" ", "+").ToString.Replace(vbNewLine, "%0A") & "")

            Timer1.Start()
        Catch ex As Exception
            Timer1.Stop()
            Me.Close()

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec += 1
        If sec = 10 Then
            SendKeys.Send("{ENTER}")
            Timer1.Stop()
            sec = 0
        End If
    End Sub

    Private Sub phoneNumBox_TextChanged(sender As Object, e As EventArgs) Handles phoneNumBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class