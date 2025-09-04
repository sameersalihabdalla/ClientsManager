<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.t1 = New System.Windows.Forms.TabPage()
        Me.webView20 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.t2 = New System.Windows.Forms.TabPage()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.t3 = New System.Windows.Forms.TabPage()
        Me.WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.t4 = New System.Windows.Forms.TabPage()
        Me.WebView23 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.btnGos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Reload = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnHtml = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.t1.SuspendLayout()
        CType(Me.webView20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.t2.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.t3.SuspendLayout()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.t4.SuspendLayout()
        CType(Me.WebView23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(815, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(269, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(799, 359)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.t1)
        Me.TabControl1.Controls.Add(Me.t2)
        Me.TabControl1.Controls.Add(Me.t3)
        Me.TabControl1.Controls.Add(Me.t4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(799, 347)
        Me.TabControl1.TabIndex = 0
        '
        't1
        '
        Me.t1.Controls.Add(Me.webView20)
        Me.t1.Location = New System.Drawing.Point(4, 25)
        Me.t1.Margin = New System.Windows.Forms.Padding(0)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(791, 318)
        Me.t1.TabIndex = 0
        Me.t1.Text = "DFONIX 1       "
        Me.t1.UseVisualStyleBackColor = True
        '
        'webView20
        '
        Me.webView20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webView20.BackColor = System.Drawing.Color.White
        Me.webView20.CreationProperties = Nothing
        Me.webView20.DefaultBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.webView20.Location = New System.Drawing.Point(3, 3)
        Me.webView20.Margin = New System.Windows.Forms.Padding(0)
        Me.webView20.Name = "webView20"
        Me.webView20.Size = New System.Drawing.Size(785, 310)
        Me.webView20.Source = New System.Uri("http://35.154.250.192:8080", System.UriKind.Absolute)
        Me.webView20.TabIndex = 8
        Me.webView20.ZoomFactor = 1.0R
        '
        't2
        '
        Me.t2.Controls.Add(Me.WebView21)
        Me.t2.Location = New System.Drawing.Point(4, 25)
        Me.t2.Name = "t2"
        Me.t2.Padding = New System.Windows.Forms.Padding(3)
        Me.t2.Size = New System.Drawing.Size(791, 318)
        Me.t2.TabIndex = 1
        Me.t2.Text = "DFONIX 2                       "
        Me.t2.UseVisualStyleBackColor = True
        '
        'WebView21
        '
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(6, 6)
        Me.WebView21.Margin = New System.Windows.Forms.Padding(0)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(779, 243)
        Me.WebView21.Source = New System.Uri("http://35.154.250.192:8080", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 9
        Me.WebView21.ZoomFactor = 1.0R
        '
        't3
        '
        Me.t3.Controls.Add(Me.WebView22)
        Me.t3.Location = New System.Drawing.Point(4, 25)
        Me.t3.Name = "t3"
        Me.t3.Padding = New System.Windows.Forms.Padding(3)
        Me.t3.Size = New System.Drawing.Size(791, 318)
        Me.t3.TabIndex = 2
        Me.t3.Text = "DFONIX 3       "
        Me.t3.UseVisualStyleBackColor = True
        '
        'WebView22
        '
        Me.WebView22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView22.CreationProperties = Nothing
        Me.WebView22.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView22.Location = New System.Drawing.Point(6, 6)
        Me.WebView22.Name = "WebView22"
        Me.WebView22.Size = New System.Drawing.Size(779, 264)
        Me.WebView22.Source = New System.Uri("http://35.154.250.192:8080", System.UriKind.Absolute)
        Me.WebView22.TabIndex = 9
        Me.WebView22.ZoomFactor = 1.0R
        '
        't4
        '
        Me.t4.Controls.Add(Me.WebView23)
        Me.t4.Location = New System.Drawing.Point(4, 25)
        Me.t4.Name = "t4"
        Me.t4.Padding = New System.Windows.Forms.Padding(3)
        Me.t4.Size = New System.Drawing.Size(791, 318)
        Me.t4.TabIndex = 3
        Me.t4.Text = "DFONIX 3                     "
        Me.t4.UseVisualStyleBackColor = True
        '
        'WebView23
        '
        Me.WebView23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView23.CreationProperties = Nothing
        Me.WebView23.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView23.Location = New System.Drawing.Point(6, 6)
        Me.WebView23.Margin = New System.Windows.Forms.Padding(0)
        Me.WebView23.Name = "WebView23"
        Me.WebView23.Size = New System.Drawing.Size(779, 264)
        Me.WebView23.Source = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.WebView23.TabIndex = 9
        Me.WebView23.ZoomFactor = 1.0R
        '
        'btnGos
        '
        Me.btnGos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGos.BackColor = System.Drawing.Color.Navy
        Me.btnGos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGos.ForeColor = System.Drawing.Color.White
        Me.btnGos.Location = New System.Drawing.Point(288, 8)
        Me.btnGos.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGos.Name = "btnGos"
        Me.btnGos.Padding = New System.Windows.Forms.Padding(1)
        Me.btnGos.Size = New System.Drawing.Size(55, 30)
        Me.btnGos.TabIndex = 26
        Me.btnGos.Text = "Go"
        Me.btnGos.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(402, 8)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(1)
        Me.Button3.Size = New System.Drawing.Size(71, 30)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Forward"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(345, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(1)
        Me.Button1.Size = New System.Drawing.Size(55, 30)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Reload
        '
        Me.Reload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reload.BackColor = System.Drawing.Color.Yellow
        Me.Reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reload.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reload.Location = New System.Drawing.Point(629, 8)
        Me.Reload.Margin = New System.Windows.Forms.Padding(1)
        Me.Reload.Name = "Reload"
        Me.Reload.Padding = New System.Windows.Forms.Padding(1)
        Me.Reload.Size = New System.Drawing.Size(65, 30)
        Me.Reload.TabIndex = 30
        Me.Reload.Text = "Reload"
        Me.Reload.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(696, 8)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(1)
        Me.Button2.Size = New System.Drawing.Size(76, 30)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Refrsh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.Yellow
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(552, 8)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(1)
        Me.btnPrint.Size = New System.Drawing.Size(75, 30)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnHtml
        '
        Me.btnHtml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHtml.BackColor = System.Drawing.Color.Yellow
        Me.btnHtml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHtml.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHtml.Location = New System.Drawing.Point(475, 8)
        Me.btnHtml.Margin = New System.Windows.Forms.Padding(1)
        Me.btnHtml.Name = "btnHtml"
        Me.btnHtml.Padding = New System.Windows.Forms.Padding(1)
        Me.btnHtml.Size = New System.Drawing.Size(75, 30)
        Me.btnHtml.TabIndex = 27
        Me.btnHtml.Text = "Html"
        Me.btnHtml.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(15, 8)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textBox1.Size = New System.Drawing.Size(266, 30)
        Me.textBox1.TabIndex = 25
        Me.textBox1.Text = "http://35.154.250.192:8080/"
        '
        'frmProductions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1085, 391)
        Me.Controls.Add(Me.btnGos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Reload)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnHtml)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProductions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "المعاملات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.t1.ResumeLayout(False)
        CType(Me.webView20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.t2.ResumeLayout(False)
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.t3.ResumeLayout(False)
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.t4.ResumeLayout(False)
        CType(Me.WebView23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents t1 As TabPage
    Friend WithEvents t2 As TabPage
    Private WithEvents webView20 As Microsoft.Web.WebView2.WinForms.WebView2
    Private WithEvents btnGos As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button1 As Button
    Friend WithEvents Reload As Button
    Friend WithEvents Button2 As Button
    Private WithEvents btnPrint As Button
    Private WithEvents btnHtml As Button
    Private WithEvents textBox1 As TextBox
    Friend WithEvents t3 As TabPage
    Friend WithEvents t4 As TabPage
    Private WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Private WithEvents WebView22 As Microsoft.Web.WebView2.WinForms.WebView2
    Private WithEvents WebView23 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
