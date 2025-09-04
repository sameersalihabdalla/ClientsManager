<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmclient_daialy
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblclient_id = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbalance = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totaldocumentscount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltd = New System.Windows.Forms.Label()
        Me.lbltc = New System.Windows.Forms.Label()
        Me.lastdebit = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.phoneNumBox = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtclientname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.from = New System.Windows.Forms.Label()
        Me.tooo = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.lastdebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Red
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1001, 63)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 44)
        Me.DateTimePicker1.TabIndex = 68
        '
        'lblclient_id
        '
        Me.lblclient_id.BackColor = System.Drawing.Color.Navy
        Me.lblclient_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblclient_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblclient_id.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblclient_id.ForeColor = System.Drawing.Color.White
        Me.lblclient_id.Location = New System.Drawing.Point(745, 13)
        Me.lblclient_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblclient_id.Name = "lblclient_id"
        Me.lblclient_id.Size = New System.Drawing.Size(83, 48)
        Me.lblclient_id.TabIndex = 64
        Me.lblclient_id.Text = "0"
        Me.lblclient_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Navy
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(537, 13)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(14)
        Me.Label7.Size = New System.Drawing.Size(209, 49)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "الرصيد"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbalance
        '
        Me.tbalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbalance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbalance.ForeColor = System.Drawing.Color.Navy
        Me.tbalance.Location = New System.Drawing.Point(537, 61)
        Me.tbalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbalance.Name = "tbalance"
        Me.tbalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbalance.Size = New System.Drawing.Size(209, 46)
        Me.tbalance.TabIndex = 88
        Me.tbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Navy
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(397, 13)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(14)
        Me.Label6.Size = New System.Drawing.Size(142, 48)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "عدد المعاملات"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totaldocumentscount
        '
        Me.totaldocumentscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.totaldocumentscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totaldocumentscount.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.totaldocumentscount.ForeColor = System.Drawing.Color.Navy
        Me.totaldocumentscount.Location = New System.Drawing.Point(397, 61)
        Me.totaldocumentscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totaldocumentscount.Name = "totaldocumentscount"
        Me.totaldocumentscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.totaldocumentscount.Size = New System.Drawing.Size(142, 46)
        Me.totaldocumentscount.TabIndex = 86
        Me.totaldocumentscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(195, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(14)
        Me.Label4.Size = New System.Drawing.Size(203, 48)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "عليه"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(14)
        Me.Label3.Size = New System.Drawing.Size(176, 48)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "له"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltd
        '
        Me.lbltd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbltd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltd.ForeColor = System.Drawing.Color.Navy
        Me.lbltd.Location = New System.Drawing.Point(195, 61)
        Me.lbltd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltd.Name = "lbltd"
        Me.lbltd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltd.Size = New System.Drawing.Size(203, 46)
        Me.lbltd.TabIndex = 83
        Me.lbltd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltc
        '
        Me.lbltc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbltc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltc.ForeColor = System.Drawing.Color.Navy
        Me.lbltc.Location = New System.Drawing.Point(24, 61)
        Me.lbltc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltc.Name = "lbltc"
        Me.lbltc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltc.Size = New System.Drawing.Size(176, 46)
        Me.lbltc.TabIndex = 82
        Me.lbltc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lastdebit
        '
        Me.lastdebit.AllowUserToAddRows = False
        Me.lastdebit.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastdebit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.lastdebit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastdebit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lastdebit.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastdebit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.lastdebit.ColumnHeadersHeight = 40
        Me.lastdebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.lastdebit.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lastdebit.DefaultCellStyle = DataGridViewCellStyle13
        Me.lastdebit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lastdebit.Location = New System.Drawing.Point(24, 137)
        Me.lastdebit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lastdebit.Name = "lastdebit"
        Me.lastdebit.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lastdebit.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.lastdebit.RowHeadersVisible = False
        Me.lastdebit.RowHeadersWidth = 44
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.NullValue = Nothing
        Me.lastdebit.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.lastdebit.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastdebit.RowTemplate.Height = 35
        Me.lastdebit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lastdebit.Size = New System.Drawing.Size(988, 472)
        Me.lastdebit.TabIndex = 91
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "معرف العملية"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 102
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "اسم العميل"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "نوع المعاملة"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "تاريخ المعاملة"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "###,##"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "المبلغ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 67
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "###,##"
        DataGridViewCellStyle7.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "المدفوع"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 77
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "###,##"
        DataGridViewCellStyle8.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column7.FillWeight = 20.0!
        Me.Column7.HeaderText = "المتبقى"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 73
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column8.FillWeight = 20.0!
        Me.Column8.HeaderText = "طريقة الدفع"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 97
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = "لم تسدد"
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column9.FillWeight = 30.0!
        Me.Column9.HeaderText = "تاريخ السداد"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column10.FillWeight = 50.0!
        Me.Column10.HeaderText = "اسم المؤمن له"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column11.FillWeight = 50.0!
        Me.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column11.HeaderText = "العملية"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column11.Width = 72
        '
        'phoneNumBox
        '
        Me.phoneNumBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneNumBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.phoneNumBox.Location = New System.Drawing.Point(1137, 114)
        Me.phoneNumBox.Margin = New System.Windows.Forms.Padding(1)
        Me.phoneNumBox.Name = "phoneNumBox"
        Me.phoneNumBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.phoneNumBox.Size = New System.Drawing.Size(224, 29)
        Me.phoneNumBox.TabIndex = 94
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(1017, 145)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.RichTextBox1.Multiline = True
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(451, 464)
        Me.RichTextBox1.TabIndex = 95
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(1266, 627)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(1)
        Me.Button1.Size = New System.Drawing.Size(202, 45)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "إرسال  واتساب ويب"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtclientname
        '
        Me.txtclientname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtclientname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtclientname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclientname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclientname.ForeColor = System.Drawing.Color.Navy
        Me.txtclientname.Location = New System.Drawing.Point(736, 61)
        Me.txtclientname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtclientname.Name = "txtclientname"
        Me.txtclientname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtclientname.Size = New System.Drawing.Size(265, 46)
        Me.txtclientname.TabIndex = 88
        Me.txtclientname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(817, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(14)
        Me.Label1.Size = New System.Drawing.Size(184, 49)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "العميــل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Arial", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.Red
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.ClientsManager.My.MySettings.Default, "sa", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.ForeColor = Global.ClientsManager.My.MySettings.Default.sa
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker2.Location = New System.Drawing.Point(1218, 63)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker2.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker2.Size = New System.Drawing.Size(250, 44)
        Me.DateTimePicker2.TabIndex = 67
        '
        'Timer1
        '
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(1384, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 29)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "رقم الهاتف"
        '
        'from
        '
        Me.from.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.from.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.from.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.from.Location = New System.Drawing.Point(1218, 13)
        Me.from.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(250, 49)
        Me.from.TabIndex = 110
        Me.from.Text = "تاريخ البداية"
        Me.from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tooo
        '
        Me.tooo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tooo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tooo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tooo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tooo.Location = New System.Drawing.Point(1001, 13)
        Me.tooo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tooo.Name = "tooo"
        Me.tooo.Size = New System.Drawing.Size(219, 49)
        Me.tooo.TabIndex = 111
        Me.tooo.Text = "تاريخ النهاية"
        Me.tooo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(1052, 627)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(1)
        Me.Button2.Size = New System.Drawing.Size(202, 45)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "إرسال  واتساب ويب"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmclient_daialy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1480, 693)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tooo)
        Me.Controls.Add(Me.from)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.phoneNumBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblclient_id)
        Me.Controls.Add(Me.tbalance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.totaldocumentscount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltd)
        Me.Controls.Add(Me.lbltc)
        Me.Controls.Add(Me.lastdebit)
        Me.Controls.Add(Me.txtclientname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmclient_daialy"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lastdebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblclient_id As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbalance As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents totaldocumentscount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltd As Label
    Friend WithEvents lbltc As Label
    Friend WithEvents lastdebit As DataGridView
    Friend WithEvents phoneNumBox As TextBox
    Friend WithEvents RichTextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtclientname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewButtonColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents from As Label
    Friend WithEvents tooo As Label
    Friend WithEvents Button2 As Button
End Class
