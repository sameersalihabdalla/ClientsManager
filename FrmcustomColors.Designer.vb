<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcustomColors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcustomColors))
        Me.lbl_color2 = New System.Windows.Forms.Label()
        Me.lbl_color1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'lbl_color2
        '
        Me.lbl_color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_color2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color2.Location = New System.Drawing.Point(30, 80)
        Me.lbl_color2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lbl_color2.Name = "lbl_color2"
        Me.lbl_color2.Size = New System.Drawing.Size(227, 29)
        Me.lbl_color2.TabIndex = 9
        Me.lbl_color2.Text = " اضغط لتحرير لون الخط"
        Me.lbl_color2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_color1
        '
        Me.lbl_color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_color1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color1.Location = New System.Drawing.Point(30, 37)
        Me.lbl_color1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lbl_color1.Name = "lbl_color1"
        Me.lbl_color1.Size = New System.Drawing.Size(225, 33)
        Me.lbl_color1.TabIndex = 8
        Me.lbl_color1.Text = "أضغط لتحرير اللون الحامل"
        Me.lbl_color1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(30, 212)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(20, 8, 20, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(82, 46)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "الغاء"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(117, 212)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(20, 8, 20, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(138, 46)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "حفظ"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmcustomColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 275)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_color2)
        Me.Controls.Add(Me.lbl_color1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmcustomColors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customColors"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_color2 As Label
    Friend WithEvents lbl_color1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
