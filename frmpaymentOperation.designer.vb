<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpaymentOperation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpaymentOperation))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txtcat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rother = New System.Windows.Forms.RadioButton()
        Me.rthirdparty = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcom = New System.Windows.Forms.Label()
        Me.txtmbok = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtpolicy = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbclient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'txttime
        '
        resources.ApplyResources(Me.txttime, "txttime")
        Me.txttime.BackColor = System.Drawing.Color.White
        Me.txttime.ForeColor = System.Drawing.Color.Black
        Me.txttime.Name = "txttime"
        '
        'txtcost
        '
        resources.ApplyResources(Me.txtcost, "txtcost")
        Me.txtcost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcost.ForeColor = System.Drawing.Color.Black
        Me.txtcost.Name = "txtcost"
        '
        'txtcat
        '
        resources.ApplyResources(Me.txtcat, "txtcat")
        Me.txtcat.BackColor = System.Drawing.Color.White
        Me.txtcat.ForeColor = System.Drawing.Color.Black
        Me.txtcat.Name = "txtcat"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.rother)
        Me.GroupBox1.Controls.Add(Me.rthirdparty)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'rother
        '
        resources.ApplyResources(Me.rother, "rother")
        Me.rother.ForeColor = System.Drawing.Color.Black
        Me.rother.Name = "rother"
        Me.rother.UseVisualStyleBackColor = True
        '
        'rthirdparty
        '
        resources.ApplyResources(Me.rthirdparty, "rthirdparty")
        Me.rthirdparty.Checked = True
        Me.rthirdparty.ForeColor = System.Drawing.Color.Black
        Me.rthirdparty.Name = "rthirdparty"
        Me.rthirdparty.TabStop = True
        Me.rthirdparty.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtcom)
        Me.GroupBox2.Controls.Add(Me.txtmbok)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtpolicy)
        Me.GroupBox2.Controls.Add(Me.txttime)
        Me.GroupBox2.Controls.Add(Me.txtcost)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txtcom
        '
        Me.txtcom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.txtcom, "txtcom")
        Me.txtcom.Name = "txtcom"
        '
        'txtmbok
        '
        Me.txtmbok.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txtmbok, "txtmbok")
        Me.txtmbok.ForeColor = System.Drawing.Color.Black
        Me.txtmbok.Name = "txtmbok"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "credit_card_ssssPNG205.png")
        Me.ImageList1.Images.SetKeyName(1, "credit_card_PNG205.png")
        Me.ImageList1.Images.SetKeyName(2, "Untitled-1.png")
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Name = "Label8"
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtpolicy
        '
        resources.ApplyResources(Me.txtpolicy, "txtpolicy")
        Me.txtpolicy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtpolicy.BackColor = System.Drawing.Color.White
        Me.txtpolicy.ForeColor = System.Drawing.Color.Black
        Me.txtpolicy.Name = "txtpolicy"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbclient)
        Me.GroupBox3.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'cmbclient
        '
        resources.ApplyResources(Me.cmbclient, "cmbclient")
        Me.cmbclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbclient.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbclient.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cmbclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbclient.ForeColor = System.Drawing.Color.Black
        Me.cmbclient.FormattingEnabled = True
        Me.cmbclient.Name = "cmbclient"
        Me.cmbclient.UseWaitCursor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'frmpaymentOperation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpaymentOperation"
        Me.ShowInTaskbar = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttime As TextBox
    Friend WithEvents txtcost As TextBox
    Friend WithEvents txtcat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rother As RadioButton
    Friend WithEvents rthirdparty As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtpolicy As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtmbok As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbclient As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtcom As Label
End Class
