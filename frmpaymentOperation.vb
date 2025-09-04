Imports MySql.Data.MySqlClient

Public Class frmpaymentOperation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub frmpos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpolicy.Text = ""
        txtmbok.Text = "-"
        If txtcat.Text = "أخرى" Then
            rother.Enabled = True
            rother.Checked = True
            rthirdparty.Enabled = False
            txtcost.Enabled = True
            txtcom.Text = ""
        Else
            rthirdparty.Enabled = True
            rthirdparty.Checked = True
            rother.Enabled = False
            txtcost.Enabled = False
            If Val(txtcost.Text) = 0 Then
                txtcost.Enabled = True

            End If


        End If
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim SQL As String
        SQL = "SELECT * FROM tbl_clients order by clientname"
        myCommand.Connection = myconn()
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(myData)

        cmbclient.DisplayMember = "Text"
        cmbclient.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        For Each drRow As DataRow In myData.Rows
            tb.Rows.Add(drRow.Item("clientName"), Val(drRow.Item("clientID")))



        Next
        cmbclient.DataSource = tb

        Me.txttime.Text = DateTime.Now

        Me.cmbclient.SelectedIndex = 0


        Dim sql2 As String = "select*from  tbl_cat where catName='" & txtcat.Text & "'"
        Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
        Dim dReader2 As MySqlDataReader
        Try
            If Not con.State = ConnectionState.Closed Then
                con.Close()

            End If
            con.Open()
            dReader2 = cmd2.ExecuteReader()

            If dReader2.Read Then
                txtcom.Text = dReader2(3)
            End If

            con.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbclient_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub rthirdparty_CheckedChanged(sender As Object, e As EventArgs) Handles rthirdparty.CheckedChanged
        selections()

    End Sub

    Private Sub selections()

        If rthirdparty.Checked = True Then
        ElseIf rother.Checked = True Then

            txtcat.Text = "-"
            txtcost.Text = ""

        End If

    End Sub

    Private Sub rpublic_CheckedChanged(sender As Object, e As EventArgs)
        selections()

    End Sub

    Private Sub rpart_CheckedChanged(sender As Object, e As EventArgs)
        selections()

    End Sub

    Private Sub rother_CheckedChanged(sender As Object, e As EventArgs) Handles rother.CheckedChanged
        selections()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cmbclient.Text = "" Then
            MsgBox("فضلا حدد اسم العميل ", "")
            cmbclient.Focus()

            Exit Sub
        End If
        If rthirdparty.Checked = True Then
            If txtpolicy.Text = "" Then
                MsgBox("أدخل رقم وثيقة الطرف الثالث صحيحة")
                Exit Sub
                txtpolicy.Focus()

            End If
        End If
        If txtcost.Text = "" Then
            MsgBox("فضلا أدخل مبلغ المعاملة", "")
            cmbclient.Focus()

            Exit Sub
        End If







        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String
        Dim rtranc_type As String
        rtranc_type = ""

        If rthirdparty.Checked = True Then
            rtranc_type = "وثيقة طرف ثالث جديدة"
        ElseIf rother.Checked = True Then
            rtranc_type = "عمليات أخرى"

        End If
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Dim XX As Double
        XX = txtcost.Text
        If rthirdparty.Checked = True And cmbclient.Text = "المكتب" Then

            Dim sure = InputBox("أدخل المبلغ المسدد من قبل العميل")
            If IsNumeric(sure) And sure <> "" Then
                txtcom.Text = XX - Val(sure)
                sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat,tranc_cost) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & Val(XX - Val(txtcom.Text)) & ",0,'-','" & txtcat.Text & "'," & XX & ")"


            End If

        Else

            sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat,tranc_cost) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & Val(XX - Val(txtcom.Text)) & ",0,'-','" & txtcat.Text & "'," & XX & ")"

        End If

        If con.State = ConnectionState.Open Then con.Close()

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql



                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else
                    MsgBox("تم حفظ البيانات")
                    Close()

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbclient.Text = "" Then
            MsgBox("فضلا حدد اسم العميل ", "")
            cmbclient.Focus()

            Exit Sub
        End If
        If rthirdparty.Checked = True Then
            If txtpolicy.Text = "" Then
                MsgBox("أدخل رقم وثيقة الطرف الثالث صحيحة")
                Exit Sub
                txtpolicy.Focus()

            End If
        End If
        If txtcost.Text = "" Then
            MsgBox("فضلا أدخل مبلغ المعاملة", "")
            cmbclient.Focus()

            Exit Sub
        End If

        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String
        Dim rtranc_type As String
        rtranc_type = ""

        If rthirdparty.Checked = True Then
            rtranc_type = "وثيقة طرف ثالث جديدة"
        ElseIf rother.Checked = True Then
            rtranc_type = "عمليات أخرى"

        End If
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Dim XX As Double
        XX = txtcost.Text
        If rthirdparty.Checked = True And cmbclient.Text = "المكتب" Then

            Dim sure = InputBox("أدخل المبلغ المسدد من قبل العميل")
            If IsNumeric(sure) And sure <> "" Then
                txtcom.Text = XX - Val(sure)
                sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat,tranc_cost) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & Val(XX - Val(txtcom.Text)) & ",0,'-','" & txtcat.Text & "'," & XX & ")"


            End If

        Else

            sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat,tranc_cost) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & Val(XX - Val(txtcom.Text)) & ",0,'-','" & txtcat.Text & "'," & XX & ")"


        End If

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql



                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else
                    MsgBox("تم حفظ البيانات")
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
        If cmbclient.Text = "" Then
            MsgBox("فضلا حدد اسم العميل ", "")
            cmbclient.Focus()

            Exit Sub
        End If
        If rthirdparty.Checked = True Then
            If txtpolicy.Text = "" Then
                MsgBox("أدخل رقم وثيقة الطرف الثالث صحيحة")
                Exit Sub
                txtpolicy.Focus()

            End If
        End If
        If txtcost.Text = "" Then
            MsgBox("فضلا أدخل مبلغ المعاملة", "")
            cmbclient.Focus()

            Exit Sub
        End If

        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String
        Dim rtranc_type As String
        rtranc_type = ""

        If rthirdparty.Checked = True Then
            rtranc_type = "وثيقة طرف ثالث جديدة"
        ElseIf rother.Checked = True Then
            rtranc_type = "عمليات أخرى"

        End If
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Dim XX As Double
        XX = txtcost.Text

        If txtcat.Text = "وثيقة طرف ثالث جديدة" And cmbclient.Text <> "المكتب" Then
            sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & Val(XX - Val(txtcom.Text)) & ",0,'PAN','" & txtcat.Text & "')"
        Else
            sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & XX & ",0,'PAN','" & txtcat.Text & "')"

        End If
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql



                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else
                    MsgBox("تم حفظ البيانات")
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
        If cmbclient.Text = "" Then
            MsgBox("فضلا حدد اسم العميل ", "")
            cmbclient.Focus()

            Exit Sub
        End If
        If rthirdparty.Checked = True Then
            If txtpolicy.Text = "" Then
                MsgBox("أدخل رقم وثيقة الطرف الثالث صحيحة")
                Exit Sub
                txtpolicy.Focus()

            End If
        End If
        If txtcost.Text = "" Then
            MsgBox("فضلا أدخل مبلغ المعاملة", "")
            cmbclient.Focus()

            Exit Sub
        End If

        If txtmbok.Text = "" Then
            MsgBox("فضلا أدخل رقم معاملة بنكك")
            txtmbok.Focus()
            Exit Sub
        End If

        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String
        Dim rtranc_type As String
        rtranc_type = ""

        If rthirdparty.Checked = True Then
            rtranc_type = "وثيقة طرف ثالث جديدة"
        ElseIf rother.Checked = True Then
            rtranc_type = "عمليات أخرى"

        End If
        Dim dd

        dd = Format(Now, "yyyy-MM-dd h:m:s")
        Dim XX As Double
        XX = txtcost.Text
        If txtcat.Text = "وثيقة طرف ثالث جديدة" And cmbclient.Text <> "المكتب" Then
            sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & Val(XX - Val(txtcom.Text)) & ",0,'MBOK','" & txtcat.Text & "')"
        Else
            sql = "insert into tbl_tranc (clientname,clientid,docid,tranc_type,datee,debit,credit,paymentmethod,cat) " & " values( '" & cmbclient.Text & "' ,'" & Val(cmbclient.SelectedValue) & "','" & txtpolicy.Text & "' ,'" & rtranc_type.ToString & "','" & dd & "'," & XX & ",0,'MBOK','" & txtcat.Text & "')"

        End If
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql



                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else
                    MsgBox("تم حفظ البيانات")
                    Close()

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try


    End Sub

    Private Sub cmbclient_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbclient.SelectedIndexChanged

    End Sub
End Class