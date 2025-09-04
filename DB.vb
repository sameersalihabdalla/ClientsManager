Imports MySql.Data.MySqlClient



Module DB

    Dim MysqlConn As New MySqlConnection
    Public con As MySqlConnection = myconn()

    Dim cmd As New MySqlCommand
    Dim result As Integer

    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dReader As MySqlDataReader
    Public sql As String
    Public stud_sex As String
    Public bdaystring As String
    Public IsSuccessResult As Boolean
    Public varDate As Integer
    Public CASESWITCH As String = ""
    Public COURSEID As Integer
    Public ITEMTYPE As String = ""
    Public ITEMCODE As Integer
    Public SCHEFEEID As Integer
    Public SCHEDFEENAME As String
    Public SCHEDFEEAMOUNT As Double
    Public CASHIERINGBALANCE As Double
    Public CHANGE As Double
    Public CHECKBALANCE As Double
    Public AUTO_OR As Integer
    Public TOTALMONEY As Double
    Public CASHPAYEE As String
    Public CASHPAYDUE As Double
    Public CHECKPAYEE As String
    Public CHECKFEEAMOUNT As Double
    Public CHECKBANKNAME As String
    Public CHECKNO As String
    Public totalARSemEnroll As Double

    Public TERMNAME As String


    Public Function myconn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password='';character set=utf8;database=dbstudentpayment;sslMode=none")

    End Function

    Public Sub findthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally

            da.Dispose()
            con.Close()

        End Try

    End Sub

    Public Sub LoadData(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()

            Select Case param

                Case "LoadListStudents"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "CourseList"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "ItemList"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(6), dReader(1), dReader(2), dReader(3), dReader(4))
                    Loop
                Case "Registration"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop
                Case "loadfees"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop
                Case "loadfeesMiscellanous"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop

                Case "loadfeesCollege"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop
                Case ("loadpayment")
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "loaduser"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop

                Case "loadclient"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "loaddebit"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), "عرض")
                    Loop
                Case "loadcat"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop

                Case "loadlastdebit"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), Val(Val(dReader(4)) - Val(dReader(5))), dReader(7), dReader(8), dReader(9), "سداد")
                    Loop
                Case "loadlastdebitt"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), Val(Val(dReader(4)) - Val(dReader(5))), dReader(7), dReader(8), dReader(9), "سداد", dReader(10))
                    Loop
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Public Function saveInsert(ByVal sql As String) As Boolean

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function

    Public Function UpdateSave(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    Return False
                Else
                    Return True

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function



    Public Sub fillcombo(ByVal combo As Object, ByVal member As String, ByVal idparam As String)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            With combo
                .DataSource = publictable
                .displaymember = member
                .valuemember = idparam
                .SelectedIndex = -1
            End With

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub



    Public Sub disEnable()

    End Sub

    Public Sub yesEnable()
        With frmMain
            .tsclients.Enabled = True
            .tsUsers.Enabled = True
            .tsReports.Enabled = True

            .tsLogin.Text = "Logout"
            .tsproduction.Enabled = True
            .tsCat.Enabled = True
        End With

    End Sub

    Public Sub closeChildForm()
        For Each ChildForm As Form In frmMain.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Public Sub anyfrm(ByVal frm As Object)
        With frm
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub


    Public Function DefaultResult() As Boolean
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then
                ' MsgBox("Not empty")
                Return True
            Else
                ' MsgBox("empty")
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Function

    Public Function DefaultResultID() As Integer
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Return table.Rows(0).Item(0)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function






End Module
