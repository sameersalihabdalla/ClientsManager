
Imports Microsoft.Web.WebView2.Core
Imports MySql.Data.MySqlClient


Public Class frmProductions
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub RESIZEE()
        getbuttonslist()
    End Sub
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RESIZEE()

    End Sub

    Private Sub getbuttonslist()
        Dim cclor, cfoclor As Color

        Dim intleft As Integer = 10
        Dim inttop As Integer = 25
        Dim intwidth As Integer = 250
        Dim intheight As Integer = 50
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim SQL As String
        SQL = "SELECT * FROM tbl_cat order by catID"
        myCommand.Connection = myconn()
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(myData)
        Dim i As Integer = 0

        For Each drRow As DataRow In myData.Rows

            If intleft >= Me.GroupBox1.Width - intwidth Then
                intleft = 10
                inttop += 45
            End If
            i = Val(drRow.Item("catID"))
            Dim btn As New Button
            btn.Tag = drRow.Item("catcost").ToString
            btn.Name = drRow.Item("catName")
            btn.Text = drRow.Item("catName") & "     " & drRow.Item("catCost")
            btn.Left = intleft
            btn.Top = inttop
            btn.TextAlign = ContentAlignment.MiddleLeft
            'btn.FlatStyle = FlatStyle.Popup
            btn.BackColor = My.Settings.color1
            btn.TextAlign = ContentAlignment.MiddleCenter
            btn.ForeColor = My.Settings.color2
            btn.Width = intwidth
            btn.Height = intheight
            btn.Visible = True

            Me.GroupBox1.Controls.Add(btn)
            intleft += intwidth + 10
            AddHandler btn.Click, AddressOf onbutton_click
        Next
        Dim btn2 As New Button


        btn2.Tag = 0
        btn2.Name = "أخرى"
        btn2.Text = "أخرى" & "  " & " لم يحدد بعد"
        btn2.FlatStyle = FlatStyle.Popup

        btn2.Left = 10
        btn2.Top = inttop + 50
        btn2.Width = intwidth
        btn2.Height = intheight
        btn2.Visible = True
        btn2.BackColor = My.Settings.color1
        btn2.ForeColor = My.Settings.color2

        Me.GroupBox1.Controls.Add(btn2)


        intleft += intwidth + 10
        AddHandler btn2.Click, AddressOf onbutton_click
    End Sub

    Private Sub onbutton_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)
        frmpaymentOperation.txtcost.Text = Format(Double.Parse(btn.Tag), "###,###.00")
        frmpaymentOperation.txtcat.Text = btn.Name.ToString

        frmpaymentOperation.ShowDialog()

    End Sub



    Private Sub POS_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        RESIZEE()
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        webView20.CoreWebView2.ExecuteScriptAsync("window.print();")
    End Sub







    Private Sub Button3_Click(sender As Object, e As EventArgs)
        webView20.GoForward()

    End Sub



    Private Sub btnHtml_Click(sender As Object, e As EventArgs)
        If webView20?.CoreWebView2 Is Nothing Then
            MessageBox.Show("The WebView2 control does not seem to be ready. Retry in a few seconds.")
        Else
            Dim strHtml As String = "<h1>Hello World!!!</h1><h2>Enjoy this new control</h2>"
            webView20.NavigateToString(strHtml)
        End If
    End Sub

    Private Sub btnGos_Click(sender As Object, e As EventArgs) Handles btnGos.Click

        If TabControl1.SelectedIndex() = 0 Then
            If webView20?.CoreWebView2 Is Nothing Then
                MessageBox.Show("The WebView2 control does not seem to be ready. Retry in a few seconds.")
            Else
                Try
                    'webView21.CoreWebView2.Navigate(textBox1.Text)
                    webView20.Source = New Uri(textBox1.Text)
                Catch ex As UriFormatException
                    MessageBox.Show("It looks like your URL is malformed. It must begin with HTTP[S]://")
                Catch ex As Exception
                    MessageBox.Show($"Another exception happened: {ex}")
                End Try
            End If
        End If

        If TabControl1.SelectedIndex() = 1 Then
            If WebView21?.CoreWebView2 Is Nothing Then
                MessageBox.Show("The WebView2 control does not seem to be ready. Retry in a few seconds.")
            Else
                Try
                    'webView21.CoreWebView2.Navigate(textBox1.Text)
                    WebView21.Source = New Uri(textBox1.Text)
                Catch ex As UriFormatException
                    MessageBox.Show("It looks like your URL is malformed. It must begin with HTTP[S]://")
                Catch ex As Exception
                    MessageBox.Show($"Another exception happened: {ex}")
                End Try
            End If
        End If

        If TabControl1.SelectedIndex() = 2 Then
            If WebView22?.CoreWebView2 Is Nothing Then
                MessageBox.Show("The WebView2 control does not seem to be ready. Retry in a few seconds.")
            Else
                Try
                    'webView21.CoreWebView2.Navigate(textBox1.Text)
                    WebView22.Source = New Uri(textBox1.Text)
                Catch ex As UriFormatException
                    MessageBox.Show("It looks like your URL is malformed. It must begin with HTTP[S]://")
                Catch ex As Exception
                    MessageBox.Show($"Another exception happened: {ex}")
                End Try
            End If
        End If

        If TabControl1.SelectedIndex() = 3 Then
            If WebView23?.CoreWebView2 Is Nothing Then
                MessageBox.Show("The WebView2 control does not seem to be ready. Retry in a few seconds.")
            Else
                Try
                    'webView21.CoreWebView2.Navigate(textBox1.Text)
                    WebView23.Source = New Uri(textBox1.Text)
                Catch ex As UriFormatException
                    MessageBox.Show("It looks like your URL is malformed. It must begin with HTTP[S]://")
                Catch ex As Exception
                    MessageBox.Show($"Another exception happened: {ex}")
                End Try
            End If


        End If



    End Sub





    Private Sub WebView21_MouseMove(sender As Object, e As MouseEventArgs) Handles WebView21.MouseMove
        Try
            If WebView21.Source.ToString <> "about:blank" Then
                textBox1.Text = WebView21.Source.ToString
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub webView20_MouseMove(sender As Object, e As MouseEventArgs) Handles webView20.MouseMove

    End Sub

    Private Sub WebView22_MouseMove(sender As Object, e As MouseEventArgs) Handles WebView22.MouseMove
        Try
            If WebView22.Source.ToString <> "about:blank" Then
                textBox1.Text = WebView22.Source.ToString
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebView23_MouseMove(sender As Object, e As MouseEventArgs) Handles WebView23.MouseMove
        Try
            If WebView23.Source.ToString <> "about:blank" Then
                textBox1.Text = WebView23.Source.ToString
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub webView20_CoreWebView2InitializationCompleted(sender As Object, e As CoreWebView2InitializationCompletedEventArgs) Handles webView20.CoreWebView2InitializationCompleted
        If webView20.Source.ToString <> "about:blank" Then
            textBox1.Text = webView20.Source.ToString
        End If

        Try


        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub
End Class