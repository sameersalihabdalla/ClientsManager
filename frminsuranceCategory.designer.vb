<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminsuranceCategory
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_saveuser = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dtg_listClients = New System.Windows.Forms.DataGridView()
        Me.CatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_cost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.dtg_listClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_saveuser
        '
        Me.btn_saveuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_saveuser.BackColor = System.Drawing.Color.Transparent
        Me.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_saveuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_saveuser.Location = New System.Drawing.Point(93, 383)
        Me.btn_saveuser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.Size = New System.Drawing.Size(97, 47)
        Me.btn_saveuser.TabIndex = 47
        Me.btn_saveuser.Text = "حفظ"
        Me.btn_saveuser.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Enabled = False
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_update.Location = New System.Drawing.Point(196, 383)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(97, 47)
        Me.btn_update.TabIndex = 48
        Me.btn_update.Text = "تحديث"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'dtg_listClients
        '
        Me.dtg_listClients.AllowUserToAddRows = False
        Me.dtg_listClients.AllowUserToDeleteRows = False
        Me.dtg_listClients.AllowUserToResizeColumns = False
        Me.dtg_listClients.AllowUserToResizeRows = False
        Me.dtg_listClients.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_listClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_listClients.BackgroundColor = System.Drawing.Color.White
        Me.dtg_listClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_listClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatID, Me.Column1, Me.Column2})
        Me.dtg_listClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_listClients.Location = New System.Drawing.Point(8, 108)
        Me.dtg_listClients.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtg_listClients.Name = "dtg_listClients"
        Me.dtg_listClients.RowHeadersVisible = False
        Me.dtg_listClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_listClients.Size = New System.Drawing.Size(540, 258)
        Me.dtg_listClients.TabIndex = 53
        '
        'CatID
        '
        Me.CatID.HeaderText = "معرف الفئة"
        Me.CatID.Name = "CatID"
        '
        'Column1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "اسم الفئة"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.Format = "##,##.00    SDG"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "التكلفة"
        Me.Column2.Name = "Column2"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(401, 383)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 47)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_New
        '
        Me.btn_New.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_New.BackColor = System.Drawing.Color.Transparent
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_New.Location = New System.Drawing.Point(299, 383)
        Me.btn_New.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(97, 47)
        Me.btn_New.TabIndex = 50
        Me.btn_New.Text = "جديد"
        Me.btn_New.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(8, 56)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(406, 19)
        Me.txt_name.TabIndex = 43
        '
        'txt_cost
        '
        Me.txt_cost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cost.BackColor = System.Drawing.Color.White
        Me.txt_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cost.Location = New System.Drawing.Point(420, 56)
        Me.txt_cost.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_cost.Name = "txt_cost"
        Me.txt_cost.Size = New System.Drawing.Size(128, 19)
        Me.txt_cost.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(415, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "التكلفة"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "اسم الفئة"
        '
        'lbl_id
        '
        Me.lbl_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(16, 61)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_id.TabIndex = 51
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(366, 286)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(69, 32)
        Me.btn_delete.TabIndex = 52
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'frminsuranceCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 443)
        Me.Controls.Add(Me.btn_saveuser)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.dtg_listClients)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.txt_cost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_name)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frminsuranceCategory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التصنيفات"
        CType(Me.dtg_listClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_saveuser As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents dtg_listClients As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_cost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents CatID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
