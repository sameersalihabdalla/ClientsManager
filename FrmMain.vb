Imports System.ComponentModel
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports RestSharp



Public Class frmMain

    Sub listdebit_f(ByVal x)



        Try

            dtg_listdebit.Rows.Clear()
            findthis("SELECT
    `tbl_clients`.`clientID`
    , `tbl_clients`.`clientName`
    
    , SUM(`tbl_tranc`.`debit`) AS SumDebit
    , SUM(`tbl_tranc`.`credit`) AS SumCredit
    , SUM(`tbl_tranc`.`credit`)-SUM(tbl_tranc.`debit`) AS newblance,`tbl_tranc`.`trancid`
FROM
    `dbstudentpayment`.`tbl_clients`
    INNER JOIN `dbstudentpayment`.`tbl_tranc` 
        ON (`tbl_clients`.`clientName` = `tbl_tranc`.`clientname`) AND (`tbl_clients`.`clientID` = `tbl_tranc`.`clientid`) WHERE (`tbl_tranc`.`datee`= '" & x & "')  GROUP BY tbl_clients.`clientID`  ORDER BY  tbl_tranc.trancid ;")
            LoadData(dtg_listdebit, "loaddebit")
            dtg_listdebit.Columns(0).Visible = False
        Catch ex As Exception

        End Try

        Dim dgv2 As DataGridView = Me.dtg_listdebit

        For ii As Integer = 0 To dgv2.Rows.Count - 1
            For ColNo As Integer = 4 To 5
                If Val(dgv2.Rows(ii).Cells(ColNo).Value) < 0 Then

                    dgv2.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1
                    dgv2.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                End If
            Next
        Next


        Dim dgv3 As DataGridView = Me.dtg_listdebit

        For ii As Integer = 0 To dgv3.Rows.Count - 1
            For ColNo As Integer = 4 To 5
                If Val(dgv3.Rows(ii).Cells(ColNo).Value) >= 0 And dgv3.Rows(ii).Cells(ColNo).Value <> Nothing Then

                    dgv3.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1

                    dgv3.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                End If
            Next
        Next

    End Sub
    Sub lastdebit_f(ByVal x)


        Try

            lastdebit.Rows.Clear()
            findthis("SELECT
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
    `dbstudentpayment`.`tbl_tranc`
    INNER JOIN `dbstudentpayment`.`tbl_clients` 
        ON (`tbl_tranc`.`clientid` = `tbl_clients`.`clientID`) WHERE (`tbl_tranc`.`datee`= '" & x & "')  ORDER BY `tbl_tranc`.`trancid`;")
            LoadData(lastdebit, "loadlastdebit")
            lastdebit.Columns(0).Visible = False


            Dim dgv As DataGridView = Me.lastdebit

            For i As Integer = 0 To dgv.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv.Rows(i).Cells(ColNo).Value) > 0 Then
                        dgv.Rows(i).Cells(10).Value = "تسديد"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1

                        dgv.Rows(i).Cells(ColNo).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(ColNo).Style.ForeColor = My.Settings.color2
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2
                    Else
                        dgv.Rows(i).Cells(10).Value = "مسددة"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2





                        dgv.Rows(i).Cells(9).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(9).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(8).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(8).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(7).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(7).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2



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

    Sub cash()


        Dim x
        x = Format(DateTimePicker2.Value, "yyyy-MM-dd")

        Dim cmd As New MySqlCommand
        Dim rd2 As MySqlDataReader
        Dim cmd2 As New MySqlCommand
        Dim sql As String
        sql = "SELECT
   sum( `credit`) AS cc
   
FROM
    `tbl_tranc` where datee='" & x & "' and paymentmethod='cash' ;"



        If Not con.State = ConnectionState.Closed Then
            con.Close()

        End If
        con.Open()


        cmd2.CommandText = sql
        cmd2.Connection = con
        rd2 = cmd2.ExecuteReader


        If rd2.Read Then
            Dim lbl
            lbl = rd2.Item(0)
            If Not rd2.Item(0).ToString = "" Then


                Dim r = Val(rd2.Item(0))
                lblcash1.Text = Format(Double.Parse(r), "###,### ")
            Else
                lblcash1.Text = 0

            End If
        End If





        con.Close()



    End Sub

    Sub pan()


        Dim x
        x = Format(DateTimePicker2.Value, "yyyy-MM-dd")

        Dim cmd As New MySqlCommand
        Dim rd2 As MySqlDataReader
        Dim cmd2 As New MySqlCommand
        Dim sql As String
        sql = "SELECT
   sum( `credit`) AS cc
   
FROM
    `tbl_tranc` where datee='" & x & "' and paymentmethod='PAN' ;"



        If Not con.State = ConnectionState.Closed Then
            con.Close()

        End If
        con.Open()


        cmd2.CommandText = sql
        cmd2.Connection = con
        rd2 = cmd2.ExecuteReader


        If rd2.Read Then
            tpan1.Text = rd2.Item(0).ToString
            If Not rd2.Item(0).ToString = "" Then


                Dim r = Val(rd2.Item(0))
                tpan1.Text = Format(Double.Parse(r), "###,### ")
            Else
                tpan1.Text = 0
            End If
        End If





        con.Close()



    End Sub

    Sub mbok()


        Dim x
        x = Format(DateTimePicker2.Value, "yyyy-MM-dd")

        Dim cmd As New MySqlCommand
        Dim rd2 As MySqlDataReader
        Dim cmd2 As New MySqlCommand
        Dim sql As String
        sql = "SELECT
   sum( `credit`) AS cc
   
FROM
    `tbl_tranc` where datee='" & x & "' and paymentmethod='mbok' ;"



        If Not con.State = ConnectionState.Closed Then
            con.Close()

        End If
        con.Open()


        cmd2.CommandText = sql
        cmd2.Connection = con
        rd2 = cmd2.ExecuteReader


        If rd2.Read Then
            mboktotal.Text = rd2.Item(0).ToString

            If Not rd2.Item(0).ToString = "" Then


                Dim r = Val(rd2.Item(0))
                mboktotal.Text = Format(Double.Parse(r), "###,### ")
            Else
                mboktotal.Text = 0
            End If
        End If





        con.Close()



    End Sub

    Sub loading2()
        Dim x
        x = Format(Me.DateTimePicker2.Value, "yyyy-MM-dd")

        Dim cmd As New MySqlCommand
        Dim rd2 As MySqlDataReader
        Dim cmd2 As New MySqlCommand
        Dim sql As String
        sql = "SELECT
   COUNT( `trancID`) AS counter
   
    , SUM(`debit`) AS tdebit
    , SUM(`credit`) AS tcridet
FROM
    `dbstudentpayment`.`tbl_tranc` where datee='" & x & "' and tranc_type='وثيقة طرف ثالث جديدة' ;"



        If Not con.State = ConnectionState.Closed Then
            con.Close()

        End If

       con.Open()


        cmd2.CommandText = sql
        cmd2.Connection = con
        rd2 = cmd2.ExecuteReader


        If rd2.Read Then
            totaldocumentscount.Text = rd2.Item(0)
            If Not rd2.Item(1).ToString = "" Then


                Dim r = Val(rd2.Item(1))
                Dim r2 = Val(rd2.Item(2))
                totaldaydocumentcost.Text = Format(Double.Parse(r), "###,###")
                debitdocuments.Text = Format(Double.Parse(r - r2), "###,### ")
                creditdocuments.Text = Format(Double.Parse(r2), "###,### ")
                Dim xx
                xx = Val(r2 / r) * 100
                cocolper.Text = "%" & Math.Truncate(xx)
            Else
                cocolper.Text = "0%"

            End If


        End If





        con.Close()


        Try

            Dim dgv4 As DataGridView = Me.dtg_listdebit
            Dim temp = 0
            lbl_full.Text = 0
            For ii As Integer = 0 To dgv4.Rows.Count - 1

                temp = Val(temp) + Val(dgv4.Rows(ii).Cells(4).Value)

            Next

            lbl_full.Text = Format(temp * -1, "###,##.00") & "   ج. س     "


        Catch ex As Exception

        End Try



    End Sub
    Sub loading_function()

        totaldaydocumentcost.Text = ""
        debitdocuments.Text = ""
        creditdocuments.Text = ""
        lbltotal.Text = ""
        mboktotal.Text = ""
        tpan1.Text = ""
        lblcash1.Text = ""
        cocolper.Text = ""
        lblper.Text = ""
        lbltc.Text = ""
        lbltd.Text = ""

        loading2()
        cash()
        pan()
        mbok()
        Timer1.Start()
        Dim x
        x = Format(DateTimePicker2.Value, "yyyy-MM-dd")

        Dim cmd As New MySqlCommand
        Dim rd2 As MySqlDataReader
        Dim cmd2 As New MySqlCommand
        Dim sql As String
        sql = "SELECT
   COUNT( `trancID`) AS counter
   
    , SUM(`debit`) AS tdebit
    , SUM(`credit`) AS tcridet
FROM
    `dbstudentpayment`.`tbl_tranc` where datee='" & x & "' ;"



        If Not con.State = ConnectionState.Closed Then
            con.Close()

        End If
        con.Open()


        cmd2.CommandText = sql
        cmd2.Connection = con
        rd2 = cmd2.ExecuteReader


        If rd2.Read Then
            lblcount.Text = rd2.Item(0)
            If Not rd2.Item(1).ToString = "" Then


                Dim r = Val(rd2.Item(1))
                Dim r2 = Val(rd2.Item(2))
                lbltotal.Text = Format(Double.Parse(r), "###,### ")
                lbltd.Text = Format(Double.Parse(r - r2), "###,### ")
                lbltc.Text = Format(Double.Parse(r2), "###,### ")
                Dim xx
                xx = Val(r2 / r) * 100


                lblper.Text = "%" & Math.Truncate(xx)
            Else
                lblper.Text = "0%"
            End If
        End If





        con.Close()



        Try

            Dim dgv4 As DataGridView = Me.dtg_listdebit
            Dim temp = 0
            lbl_full.Text = 0
            For ii As Integer = 0 To dgv4.Rows.Count - 1

                temp = Val(temp) + Val(dgv4.Rows(ii).Cells(4).Value)

            Next
            lbl_full.Text = Format(temp * -1, "###,##.00") & "   ج. س     "

        Catch ex As Exception

        End Try



    End Sub


    Private Sub tsLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogin.Click

        'If tsLogin.Text = "Login" Then
        '    LoginForm1.Show()
        'Else
        '    tsLogin.Text = "Login"
        '    Me.Text = ""
        '    disEnable()
        'End If
        'Me.Close()

    End Sub






    Private Sub tsReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReports.Click
        frm_get_data.ShowDialog()


    End Sub

    Private Sub tsCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCat.Click
        frminsuranceCategory.ShowDialog()

        'myReporting(" SELECT * FROM `tblpayments`", "CA")


    End Sub

    Private Sub tsUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUsers.Click

        frmUser.ShowDialog()
        frmUser.Focus()

    End Sub


    Private Sub tsStudents_Click(sender As Object, e As EventArgs) Handles tsclients.Click
        frmClientslist.ShowDialog()


    End Sub

    Private Sub tsCourse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsItems_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsEnrollment_Click(sender As Object, e As EventArgs) Handles tsproduction.Click
        frmProductions.ShowDialog()




    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  GroupBox1.Width = Val(Val(Me.Width * 60) / 100)
        ' GroupBox2.Left = Val(GroupBox1.Width) + 120
        coloring_ide()
        c1.Text = Me.DateTimePicker2.Value
        frmlogin.Close()


        Timer1.Interval = 100
        Dim x
        x = Format(Now, "yyyy-MM-dd")
        full_loading()

    End Sub

    Sub coloring_ide()

        dtg_listdebit.AlternatingRowsDefaultCellStyle.SelectionForeColor = My.Settings.color2
        dtg_listdebit.AlternatingRowsDefaultCellStyle.SelectionBackColor = My.Settings.color1
        dtg_listdebit.DefaultCellStyle.SelectionForeColor = My.Settings.color2
        dtg_listdebit.DefaultCellStyle.SelectionBackColor = My.Settings.color1
        dtg_listdebit.RowsDefaultCellStyle.SelectionForeColor = My.Settings.color2
        dtg_listdebit.RowsDefaultCellStyle.SelectionBackColor = My.Settings.color1
        dtg_listdebit.RowHeadersDefaultCellStyle.SelectionForeColor = My.Settings.color2
        dtg_listdebit.RowHeadersDefaultCellStyle.SelectionBackColor = My.Settings.color1

        lastdebit.AlternatingRowsDefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.AlternatingRowsDefaultCellStyle.SelectionBackColor = My.Settings.color1
        lastdebit.DefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.DefaultCellStyle.SelectionBackColor = My.Settings.color1
        lastdebit.RowsDefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.RowsDefaultCellStyle.SelectionBackColor = My.Settings.color1
        lastdebit.RowHeadersDefaultCellStyle.SelectionForeColor = My.Settings.color2
        lastdebit.RowHeadersDefaultCellStyle.SelectionBackColor = My.Settings.color1

        Me.Button1.BackColor = My.Settings.color1
        Me.Button1.ForeColor = My.Settings.color2
        Me.Button2.BackColor = My.Settings.color1
        Me.Button2.ForeColor = My.Settings.color2


        Me.tpan1.BackColor = My.Settings.color1
        Me.tpan1.ForeColor = My.Settings.color2

        Me.lblcash1.BackColor = My.Settings.color1
        Me.lblcash1.ForeColor = My.Settings.color2

        Me.mboktotal.BackColor = My.Settings.color1
        Me.mboktotal.ForeColor = My.Settings.color2


        Me.c1.BackColor = My.Settings.color1
        Me.c2.BackColor = My.Settings.color1
        Me.c3.BackColor = My.Settings.color1
        Me.c5.BackColor = My.Settings.color1
        Me.c6.BackColor = My.Settings.color1
        Me.c7.BackColor = My.Settings.color1
        Me.c8.BackColor = My.Settings.color1
        Me.c9.BackColor = My.Settings.color1
        Me.c10.BackColor = My.Settings.color1
        Me.c11.BackColor = My.Settings.color1
        lbl_full.BackColor = My.Settings.color1
        lbl_full.ForeColor = My.Settings.color2

        Me.tsclients.BackColor = My.Settings.color1
        Me.tsproduction.BackColor = My.Settings.color1
        Me.tsUsers.BackColor = My.Settings.color1
        Me.tsCat.BackColor = My.Settings.color1
        Me.tsReports.BackColor = My.Settings.color1
        Me.tsLogin.BackColor = My.Settings.color1

        '------------------------------------
        Me.c1.ForeColor = My.Settings.color2
        Me.c2.ForeColor = My.Settings.color2
        Me.c3.ForeColor = My.Settings.color2
        Me.c5.ForeColor = My.Settings.color2
        Me.c6.ForeColor = My.Settings.color2
        Me.c7.ForeColor = My.Settings.color2
        Me.c8.ForeColor = My.Settings.color2
        Me.c9.ForeColor = My.Settings.color2
        Me.c10.ForeColor = My.Settings.color2
        Me.c11.ForeColor = My.Settings.color2
        Me.t1.ForeColor = My.Settings.color1
        Me.t2.ForeColor = My.Settings.color1
        Me.t3.ForeColor = My.Settings.color1
        Me.t1.BackColor = My.Settings.color2
        Me.t2.BackColor = My.Settings.color2
        Me.t3.BackColor = My.Settings.color2

        lbl_full.ForeColor = My.Settings.color2
        Me.tsclients.ForeColor = My.Settings.color2
        Me.tsproduction.ForeColor = My.Settings.color2
        Me.tsUsers.ForeColor = My.Settings.color2
        Me.tsCat.ForeColor = My.Settings.color2
        Me.tsReports.ForeColor = My.Settings.color2
        Me.tsLogin.ForeColor = My.Settings.color2

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tstime.Text = TimeOfDay.ToLongTimeString






    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim xxx
        xxx = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        GroupBox2.Text = "ملخص يوم :" & Format(DateTimePicker2.Value, "D")

        Try

            lastdebit.Rows.Clear()
            findthis("SELECT
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
    `dbstudentpayment`.`tbl_tranc`
    INNER JOIN `dbstudentpayment`.`tbl_clients` 
        ON (`tbl_tranc`.`clientid` = `tbl_clients`.`clientID`) WHERE (`tbl_tranc`.`credit`= '0' )  ORDER BY `tbl_tranc`.`trancid`  ;")
            LoadData(lastdebit, "loadlastdebit")
            lastdebit.Columns(0).Visible = False


            Dim dgv As DataGridView = Me.lastdebit

            For i As Integer = 0 To dgv.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv.Rows(i).Cells(ColNo).Value) > 0 Then
                        dgv.Rows(i).Cells(10).Value = "تسديد"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2
                    Else
                        dgv.Rows(i).Cells(10).Value = "مسددة"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2






                        dgv.Rows(i).Cells(9).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(9).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(8).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(8).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(7).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(7).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2



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



            Dim dgv3 As DataGridView = Me.lastdebit

            For ii As Integer = 0 To dgv3.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv3.Rows(ii).Cells(ColNo).Value) < 0 And dgv3.Rows(ii).Cells(ColNo).Value <> Nothing Then

                        'dgv3.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1

                        ' dgv3.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                    End If
                Next
            Next



        Catch ex As Exception

        End Try

        Try

            dtg_listdebit.Rows.Clear()
            findthis("SELECT
    `tbl_clients`.`clientID`
    , `tbl_clients`.`clientName`
    
    , SUM(`tbl_tranc`.`debit`) AS SumDebit
    , SUM(`tbl_tranc`.`credit`) AS SumCredit
    , SUM(`tbl_tranc`.`credit`)-SUM(tbl_tranc.`debit`) AS newblance,`tbl_tranc`.`trancid`
FROM
    `dbstudentpayment`.`tbl_clients`
    INNER JOIN `dbstudentpayment`.`tbl_tranc` 
        ON (`tbl_clients`.`clientName` = `tbl_tranc`.`clientname`) AND (`tbl_clients`.`clientID` = `tbl_tranc`.`clientid`) WHERE (`tbl_tranc`.`credit`= '0')  GROUP BY tbl_clients.`clientID`  ORDER BY SumDebit DESC;")
            LoadData(dtg_listdebit, "loaddebit")
            dtg_listdebit.Columns(0).Visible = False
        Catch ex As Exception

        End Try

        Dim dgv2 As DataGridView = Me.dtg_listdebit

        For ii As Integer = 0 To dgv2.Rows.Count - 1
            For ColNo As Integer = 4 To 5
                If Val(dgv2.Rows(ii).Cells(ColNo).Value) < 0 Then

                    dgv2.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1
                    dgv2.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                End If
            Next
        Next






        loading_function()




        totaldaydocumentcost.Text = "-"
        debitdocuments.Text = "-"
        creditdocuments.Text = "-"
        lbltotal.Text = "-"
        mboktotal.Text = "-"
        tpan1.Text = "-"
        lblcash1.Text = "-"
        cocolper.Text = "-"
        lblper.Text = "-"
        lbltc.Text = "-"
        lbltd.Text = "-"
        totaldocumentscount.Text = "-"

    End Sub




    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        coloring_ide()
        full_loading()

    End Sub



    Private Sub passing()
        Try
            With lastdebit.CurrentRow

                frmCollections.txtr_no.Text = .Cells(0).Value
                frmCollections.clientid.Text = .Cells(11).Value

                frmCollections.ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lastdebit_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles lastdebit.CellContentClick



    End Sub

    Private Sub lastdebit_RowDividerDoubleClick(sender As Object, e As DataGridViewRowDividerDoubleClickEventArgs) Handles lastdebit.RowDividerDoubleClick
    End Sub

    Private Sub lastdebit_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles lastdebit.CellMouseClick


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dtg_listdebit.Width, Me.dtg_listdebit.Height)
        dtg_listdebit.DrawToBitmap(bm, New Rectangle(0, 0, Me.dtg_listdebit.Width, Me.dtg_listdebit.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        PrintDocument1.Print()
    End Sub

    Private Sub lastdebit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles lastdebit.CellClick
        If e.ColumnIndex = 10 Then

            If lastdebit.CurrentRow.Cells(10).Value = "مسددة" Then
                MsgBox("لا يمكن تسديد معاملة مسددة مسبقا", vbMsgBoxRtlReading + vbCritical)
                Exit Sub
            Else
                passing()
            End If


        End If
    End Sub

    Private Sub txtsearching_TextChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub mboktotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblcash_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtg_listdebit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_listdebit.CellClick
        If e.ColumnIndex = 6 Then

            Try
                With dtg_listdebit.CurrentRow

                    frmclient_daialy.lblclient_id.Text = .Cells(0).Value
                    frmclient_daialy.txtclientname.Text = .Cells(1).Value
                    frmclient_daialy.Text = .Cells(1).Value.ToString

                    frmclient_daialy.ShowDialog()
                End With
            Catch ex As Exception
            End Try


        End If
    End Sub

    Private Sub dtg_listdebit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_listdebit.CellContentClick

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        full_loading()
        coloring()
        coloring2()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'frmreports.ShowDialog()
        'customreport.Show()


    End Sub

    Private Sub creditdocuments_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbltc_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearching_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearching.TextChanged
        Dim xxx
        xxx = Format(DateTimePicker2.Value, "yyyy-MM-dd")

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
    `dbstudentpayment`.`tbl_tranc`
    INNER JOIN `dbstudentpayment`.`tbl_clients` 
        ON (`tbl_tranc`.`clientid` = `tbl_clients`.`clientID`) WHERE (`tbl_tranc`.`datee`= '" & xxx & "' and tbl_tranc.clientname like '" & txtsearching.Text & "%')  ORDER BY `tbl_tranc`.`trancid`  DESC;")
            LoadData(lastdebit, "loadlastdebit")
            lastdebit.Columns(0).Visible = False


            Dim dgv As DataGridView = Me.lastdebit

            For i As Integer = 0 To dgv.Rows.Count - 1
                For ColNo As Integer = 6 To 6
                    If Val(dgv.Rows(i).Cells(ColNo).Value) > 0 Then
                        dgv.Rows(i).Cells(10).Value = "تسديد"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1

                        dgv.Rows(i).Cells(ColNo).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(ColNo).Style.ForeColor = My.Settings.color2
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2
                    Else
                        dgv.Rows(i).Cells(10).Value = "مسددة"
                        dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2





                        dgv.Rows(i).Cells(9).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(9).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(8).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(8).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(7).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(7).Style.ForeColor = My.Settings.color2



                        dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2



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

        Try

            dtg_listdebit.Rows.Clear()
            findthis("SELECT
    `tbl_clients`.`clientID`
    , `tbl_clients`.`clientName`
    
    , SUM(`tbl_tranc`.`debit`) AS SumDebit
    , SUM(`tbl_tranc`.`credit`) AS SumCredit
    , SUM(`tbl_tranc`.`credit`)-SUM(tbl_tranc.`debit`) AS newblance,`tbl_tranc`.`trancid`
FROM
    `dbstudentpayment`.`tbl_clients`
    INNER JOIN `dbstudentpayment`.`tbl_tranc` 
        ON (`tbl_clients`.`clientName` = `tbl_tranc`.`clientname`) AND (`tbl_clients`.`clientID` = `tbl_tranc`.`clientid`) WHERE (`tbl_tranc`.`datee`= '" & xxx & "' and tbl_tranc.clientname like'" & txtsearching.Text & "%' )  GROUP BY tbl_clients.`clientID`  ORDER BY SumDebit DESC;")
            LoadData(dtg_listdebit, "loaddebit")
            dtg_listdebit.Columns(0).Visible = False
        Catch ex As Exception

        End Try

        Dim dgv2 As DataGridView = Me.dtg_listdebit

        For ii As Integer = 0 To dgv2.Rows.Count - 1
            For ColNo As Integer = 4 To 5
                If Val(dgv2.Rows(ii).Cells(ColNo).Value) < 0 Then

                    dgv2.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1
                    dgv2.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                End If
            Next
        Next





    End Sub



    Sub full_loading()

        Dim xxx
        xxx = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        GroupBox2.Text = "ملخص يوم :" & Format(DateTimePicker2.Value, "D")
        c1.Text = xxx

        Try

            lastdebit.Rows.Clear()
            findthis("SELECT
     `tbl_tranc`.`trancID`
    , `tbl_clients`.`clientName`
    , `tbl_tranc`.`cat`
    , `tbl_tranc`.`datee`
    , `tbl_tranc`.`debit`
    , `tbl_tranc`.`credit`
   ,`tbl_clients`.`clientID`
 , `tbl_tranc`.`paymentmethod`
, `tbl_tranc`.`paymentdate`,`tbl_tranc`.`docid`,`tbl_tranc`.`clientid`
FROM
    `dbstudentpayment`.`tbl_tranc`
    INNER JOIN `dbstudentpayment`.`tbl_clients` 
        ON (`tbl_tranc`.`clientid` = `tbl_clients`.`clientID`) WHERE (`tbl_tranc`.`datee`= '" & xxx & "' )  ORDER BY `tbl_tranc`.`trancid`  ;")
            LoadData(lastdebit, "loadlastdebitt")
            lastdebit.Columns(0).Visible = False


            coloring()




        Catch ex As Exception

        End Try

        Try

            dtg_listdebit.Rows.Clear()
            findthis("SELECT
    `tbl_clients`.`clientID`
    , `tbl_clients`.`clientName`
    
    , SUM(`tbl_tranc`.`debit`) AS SumDebit
    , SUM(`tbl_tranc`.`credit`) AS SumCredit
    , SUM(`tbl_tranc`.`credit`)-SUM(tbl_tranc.`debit`) AS newblance,`tbl_tranc`.`trancid`
FROM
    `dbstudentpayment`.`tbl_clients`
    INNER JOIN `dbstudentpayment`.`tbl_tranc` 
        ON (`tbl_clients`.`clientName` = `tbl_tranc`.`clientname`) AND (`tbl_clients`.`clientID` = `tbl_tranc`.`clientid`) WHERE (`tbl_tranc`.`datee`= '" & xxx & "')  GROUP BY tbl_clients.`clientID`  ORDER BY SumDebit DESC;")
            LoadData(dtg_listdebit, "loaddebit")
            dtg_listdebit.Columns(0).Visible = False
            coloring2()
        Catch ex As Exception

        End Try



        Try

            Dim dgv4 As DataGridView = Me.dtg_listdebit
            Dim temp = 0
            lbl_full.Text = 0
            For ii As Integer = 0 To dgv4.Rows.Count - 1

                temp = Val(temp) + Val(dgv4.Rows(ii).Cells(4).Value)

            Next

            lbl_full.Text = Format(temp * -1, "###,##.00") & "   ج. س     "

        Catch ex As Exception

        End Try


        loading_function()

    End Sub
    Sub coloring2()
        Dim dgv As DataGridView = Me.lastdebit

        For i As Integer = 0 To dgv.Rows.Count - 1
            For ColNo As Integer = 6 To 6
                If Val(dgv.Rows(i).Cells(ColNo).Value) > 0 Then
                    dgv.Rows(i).Cells(10).Value = "تسديد"
                    dgv.Rows(i).Cells(10).Style.BackColor = Color.DarkRed
                    dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2
                    dgv.Rows(i).Cells(10).Style.ForeColor = Color.White

                Else
                    dgv.Rows(i).Cells(10).Value = "مسددة"
                    dgv.Rows(i).Cells(10).Style.BackColor = Color.DarkGreen
                    dgv.Rows(i).Cells(10).Style.ForeColor = Color.White


                    dgv.Rows(i).Cells(9).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(9).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(8).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(8).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(7).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(7).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(5).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(5).Style.ForeColor = My.Settings.color2

                    dgv.Rows(i).Cells(4).Style.BackColor = Color.DarkGreen
                    dgv.Rows(i).Cells(4).Style.ForeColor = Color.White






                    dgv.Rows(i).Cells(3).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(3).Style.ForeColor = My.Settings.color2


                    dgv.Rows(i).Cells(2).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(2).Style.ForeColor = My.Settings.color2

                    dgv.Rows(i).Cells(1).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(1).Style.ForeColor = My.Settings.color2





                End If
            Next
        Next



        Dim dgv3 As DataGridView = Me.lastdebit

        For ii As Integer = 0 To dgv3.Rows.Count - 1
            For ColNo As Integer = 6 To 6
                If Val(dgv3.Rows(ii).Cells(ColNo).Value) < 0 And dgv3.Rows(ii).Cells(ColNo).Value <> Nothing Then

                    'dgv3.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1

                    ' dgv3.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                End If
            Next
        Next






        Dim dgv2 As DataGridView = Me.dtg_listdebit

        For ii As Integer = 0 To dgv2.Rows.Count - 1
            For ColNo As Integer = 4 To 5
                If Val(dgv2.Rows(ii).Cells(ColNo).Value) < 0 Then

                    dgv2.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1
                    dgv2.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2

                End If
            Next
        Next

    End Sub
    Sub coloring()
        Dim dgv As DataGridView = Me.lastdebit

        For i As Integer = 0 To dgv.Rows.Count - 1
            For ColNo As Integer = 6 To 6
                If Val(dgv.Rows(i).Cells(ColNo).Value) > 0 Then
                    dgv.Rows(i).Cells(10).Value = "تسديد"
                    dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2

                    If dgv.Rows(i).Cells(ColNo).Value > 0 Then
                        dgv.Rows(i).Cells(ColNo).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(ColNo).Style.ForeColor = My.Settings.color2
                    Else

                        dgv.Rows(i).Cells(ColNo).Style.BackColor = My.Settings.color1
                        dgv.Rows(i).Cells(ColNo).Style.ForeColor = My.Settings.color2

                    End If

                    dgv.Rows(i).Cells(ColNo).Style.ForeColor = My.Settings.color1
                    dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2

                Else
                    dgv.Rows(i).Cells(10).Value = "مسددة"
                    dgv.Rows(i).Cells(10).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(10).Style.ForeColor = My.Settings.color2


                    dgv.Rows(i).Cells(9).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(9).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(8).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(8).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(7).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(7).Style.ForeColor = My.Settings.color2



                    dgv.Rows(i).Cells(6).Style.BackColor = My.Settings.color1
                    dgv.Rows(i).Cells(6).Style.ForeColor = My.Settings.color2



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



        Dim dgv3 As DataGridView = Me.lastdebit

        For ii As Integer = 0 To dgv3.Rows.Count - 1
            For ColNo As Integer = 6 To 6
                If Val(dgv3.Rows(ii).Cells(ColNo).Value) < 0 And dgv3.Rows(ii).Cells(ColNo).Value <> Nothing Then

                    dgv3.Rows(ii).Cells(ColNo).Style.BackColor = My.Settings.color1

                    dgv3.Rows(ii).Cells(ColNo).Style.ForeColor = My.Settings.color2


                End If
            Next
        Next
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FrmcustomColors.ShowDialog()

    End Sub

    Private Sub GroupBox1_Validating(sender As Object, e As CancelEventArgs) Handles GroupBox1.Validating

    End Sub

    Private Sub frmMain_Validated(sender As Object, e As EventArgs) Handles Me.Validated

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmWhatsApp.ShowDialog()

    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click

        frmlogin.Show()
        Me.Close()

    End Sub
End Class
