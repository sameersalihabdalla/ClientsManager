<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientslist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_saveuser = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dtg_listClients = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtg_listClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_saveuser
        '
        Me.btn_saveuser.BackColor = System.Drawing.Color.Transparent
        Me.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_saveuser.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!)
        Me.btn_saveuser.Location = New System.Drawing.Point(135, 388)
        Me.btn_saveuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.Size = New System.Drawing.Size(76, 39)
        Me.btn_saveuser.TabIndex = 34
        Me.btn_saveuser.Text = "حفظ"
        Me.btn_saveuser.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Enabled = False
        Me.btn_update.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!)
        Me.btn_update.Location = New System.Drawing.Point(216, 388)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(76, 39)
        Me.btn_update.TabIndex = 36
        Me.btn_update.Text = "تحديث"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'dtg_listClients
        '
        Me.dtg_listClients.AllowUserToAddRows = False
        Me.dtg_listClients.AllowUserToDeleteRows = False
        Me.dtg_listClients.AllowUserToResizeColumns = False
        Me.dtg_listClients.AllowUserToResizeRows = False
        Me.dtg_listClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_listClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_listClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.Column1, Me.Column2})
        Me.dtg_listClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_listClients.Location = New System.Drawing.Point(15, 152)
        Me.dtg_listClients.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtg_listClients.Name = "dtg_listClients"
        Me.dtg_listClients.RowHeadersVisible = False
        Me.dtg_listClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_listClients.Size = New System.Drawing.Size(541, 196)
        Me.dtg_listClients.TabIndex = 42
        '
        'UserID
        '
        Me.UserID.HeaderText = "معرف العميل"
        Me.UserID.Name = "UserID"
        '
        'Column1
        '
        Me.Column1.HeaderText = "اسم العميل"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "رقم الهاتف الجوال"
        Me.Column2.Name = "Column2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(381, 388)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 39)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_New
        '
        Me.btn_New.BackColor = System.Drawing.Color.Transparent
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!)
        Me.btn_New.Location = New System.Drawing.Point(298, 388)
        Me.btn_New.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(76, 39)
        Me.btn_New.TabIndex = 39
        Me.btn_New.Text = "جديد"
        Me.btn_New.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Droid Arabic Kufi", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(210, 63)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(20, 4, 3, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(322, 27)
        Me.txt_name.TabIndex = 28
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Droid Arabic Kufi", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(6, 63)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(200, 27)
        Me.txt_phone.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(133, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "رقم الهاتف"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(485, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "الاسم"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(212, 65)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_id.TabIndex = 40
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(298, 388)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(76, 39)
        Me.btn_delete.TabIndex = 41
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Font = New System.Drawing.Font("Droid Arabic Kufi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 112)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات العميل"
        '
        'frmClientslist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(572, 447)
        Me.Controls.Add(Me.btn_saveuser)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.dtg_listClients)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Droid Arabic Kufi", 8.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientslist"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "العملاء"
        CType(Me.dtg_listClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_saveuser As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents dtg_listClients As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
