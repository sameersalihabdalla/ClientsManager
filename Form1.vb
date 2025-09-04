
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Nothing
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
        Exit Sub
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1, d2
        Try
            d1 = Format(Me.datee1.Value, "yyyy-MM-dd")
            d2 = Format(Me.datee2.Value, "yyyy-MM-dd")

        Catch ex As Exception
        End Try

        Dim searchqry As String = "select * from tbl_tranc where(   `tbl_tranc`.`datee` BETWEEN '" & d1 & "' AND'" & d2 & "' )  ORDER BY trancid"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, myconn)
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
        Dim table As New DataTable
        Try

            adapter.Fill(table)

            Dim rp As New fullreport
            rp.DataSourceConnections.Clear()
            fullreport1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = "كشف كل المعاملات"
            rp.SummaryInfo.ReportComments = ""
            rp.SummaryInfo.ReportAuthor = "كشف المعاملات من " & Format(Me.datee1.Value, "yyyy/MM/dd") & "   إلى    " & Format(Me.datee2.Value, "yyyy/MM/dd")

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Public Function StrToHex(ByRef Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & sVal
        End While
        Return sHex
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d1, d2
        Try
            d1 = Format(Me.datee1.Value, "yyyy-MM-dd")
            d2 = Format(Me.datee2.Value, "yyyy-MM-dd")

        Catch ex As Exception
        End Try

        Dim searchqry As String = "select * from tbl_tranc where(   `tbl_tranc`.`datee` BETWEEN '" & d1 & "' AND '" & d2 & "' ) AND  tranc_type<> 'عمليات أخرى' ORDER BY trancid"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, myconn)
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
        Dim table As New DataTable
        Try

            adapter.Fill(table)

            Dim rp As New fullreport
            rp.DataSourceConnections.Clear()
            fullreport1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = "كشف وثائق الطرف الثالث"
            rp.SummaryInfo.ReportComments = ""
            rp.SummaryInfo.ReportAuthor = "كشف المعاملات من " & Format(Me.datee1.Value, "yyyy/MM/dd") & "   إلى    " & Format(Me.datee2.Value, "yyyy/MM/dd")

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d1, d2
        Try
            d1 = Format(Me.datee1.Value, "yyyy-MM-dd")
            d2 = Format(Me.datee2.Value, "yyyy-MM-dd")

        Catch ex As Exception
        End Try

        Dim searchqry As String = "select * from tbl_tranc where(   `tbl_tranc`.`datee` BETWEEN '" & d1 & "' AND '" & d2 & "' ) AND clientid= '" & Val(cmbclient.SelectedValue) & "' ORDER BY trancid"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, myconn)
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
        Dim table As New DataTable
        Try

            adapter.Fill(table)

            Dim rp As New fullreport
            rp.DataSourceConnections.Clear()
            fullreport1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = "كشف وثائق الطرف الثالث"
            rp.SummaryInfo.ReportComments = ""
            rp.SummaryInfo.ReportAuthor = "كشف المعاملات من " & Format(Me.datee1.Value, "yyyy/MM/dd") & "   إلى    " & Format(Me.datee2.Value, "yyyy/MM/dd")

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class