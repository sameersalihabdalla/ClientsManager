<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWhatsApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dvg = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dvg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(817, 509)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(1)
        Me.Button1.Size = New System.Drawing.Size(202, 45)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "إرسال  واتساب ويب"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dvg
        '
        Me.dvg.AllowUserToAddRows = False
        Me.dvg.AllowUserToDeleteRows = False
        Me.dvg.AllowUserToResizeColumns = False
        Me.dvg.AllowUserToResizeRows = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dvg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dvg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvg.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dvg.ColumnHeadersHeight = 41
        Me.dvg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column12})
        Me.dvg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dvg.Location = New System.Drawing.Point(12, 13)
        Me.dvg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dvg.Name = "dvg"
        Me.dvg.ReadOnly = True
        Me.dvg.RowHeadersVisible = False
        Me.dvg.RowHeadersWidth = 65
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.NullValue = Nothing
        Me.dvg.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dvg.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dvg.RowTemplate.Height = 35
        Me.dvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg.Size = New System.Drawing.Size(1005, 485)
        Me.dvg.TabIndex = 107
        '
        'UserID
        '
        Me.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(5)
        Me.UserID.DefaultCellStyle = DataGridViewCellStyle12
        Me.UserID.HeaderText = "معرف العميل"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column1.FillWeight = 60.0!
        Me.Column1.HeaderText = "اسم العميل"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.Format = "###,##"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column2.FillWeight = 60.0!
        Me.Column2.HeaderText = "رقم العميل"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.Format = "###,##"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column3.FillWeight = 60.0!
        Me.Column3.HeaderText = "الرسالة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle16.Format = "###,##"
        DataGridViewCellStyle16.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column4.FillWeight = 60.0!
        Me.Column4.HeaderText = "رقم الهاتف"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column12.FillWeight = 60.0!
        Me.Column12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column12.HeaderText = "ارسال واتساب"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FrmWhatsApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 564)
        Me.Controls.Add(Me.dvg)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWhatsApp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmWhatsApp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dvg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents dvg As DataGridView
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewButtonColumn
End Class
