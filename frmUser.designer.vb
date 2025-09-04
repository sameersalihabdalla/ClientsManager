<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.btn_saveuser = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.dtg_listUser = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_saveuser
        '
        Me.btn_saveuser.BackColor = System.Drawing.Color.Transparent
        Me.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_saveuser.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveuser.Location = New System.Drawing.Point(13, 493)
        Me.btn_saveuser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.Size = New System.Drawing.Size(101, 48)
        Me.btn_saveuser.TabIndex = 19
        Me.btn_saveuser.Text = "حفظ"
        Me.btn_saveuser.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Enabled = False
        Me.btn_update.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(122, 493)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(101, 48)
        Me.btn_update.TabIndex = 21
        Me.btn_update.Text = "تحديث"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.BackColor = System.Drawing.Color.Transparent
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(231, 493)
        Me.btn_New.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(101, 48)
        Me.btn_New.TabIndex = 23
        Me.btn_New.Text = "جديد +"
        Me.btn_New.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(231, 493)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(101, 48)
        Me.btn_delete.TabIndex = 25
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'dtg_listUser
        '
        Me.dtg_listUser.AllowUserToAddRows = False
        Me.dtg_listUser.AllowUserToDeleteRows = False
        Me.dtg_listUser.AllowUserToResizeColumns = False
        Me.dtg_listUser.AllowUserToResizeRows = False
        Me.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_listUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.Column1, Me.Column2, Me.Column3})
        Me.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_listUser.Location = New System.Drawing.Point(13, 237)
        Me.dtg_listUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtg_listUser.Name = "dtg_listUser"
        Me.dtg_listUser.RowHeadersVisible = False
        Me.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_listUser.Size = New System.Drawing.Size(428, 242)
        Me.dtg_listUser.TabIndex = 27
        '
        'UserID
        '
        Me.UserID.HeaderText = "المعرف"
        Me.UserID.Name = "UserID"
        '
        'Column1
        '
        Me.Column1.HeaderText = "الاسم"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "اسم المستخدم"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "الصلاحية"
        Me.Column3.Name = "Column3"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(341, 493)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 48)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "&إغلاق"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_pass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_type)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 189)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات المستخدم   "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(100, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "صلاحية المستخدم"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(213, 68)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(208, 25)
        Me.txt_name.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(349, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "كلمة المرور"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(5, 68)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(205, 25)
        Me.txt_username.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(110, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "اسم المستخدم"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(213, 128)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(210, 25)
        Me.txt_pass.TabIndex = 27
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(378, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "الاسم"
        '
        'cbo_type
        '
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Items.AddRange(New Object() {"Administrator", "Cashier"})
        Me.cbo_type.Location = New System.Drawing.Point(5, 128)
        Me.cbo_type.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(205, 25)
        Me.cbo_type.TabIndex = 30
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(402, 72)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_id.TabIndex = 33
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(455, 555)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtg_listUser)
        Me.Controls.Add(Me.btn_saveuser)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_delete)
        Me.Font = New System.Drawing.Font("Droid Arabic Kufi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmUser"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إدارة المستخدمين"
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_saveuser As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents dtg_listUser As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents lbl_id As Label
End Class
