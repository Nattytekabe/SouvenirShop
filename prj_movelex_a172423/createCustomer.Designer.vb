<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createCustomer))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_error_id = New System.Windows.Forms.Label()
        Me.lbl_error_name = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_error_address = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(538, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Create New Customer"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(91, 161)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(158, 20)
        Me.txt_name.TabIndex = 2
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(291, 161)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(69, 20)
        Me.txt_id.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(288, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(88, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(306, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CUST"
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.Lime
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.Location = New System.Drawing.Point(432, 324)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 7
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Yellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(513, 324)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'lbl_error_id
        '
        Me.lbl_error_id.AutoSize = True
        Me.lbl_error_id.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_id.Location = New System.Drawing.Point(288, 184)
        Me.lbl_error_id.Name = "lbl_error_id"
        Me.lbl_error_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_error_id.TabIndex = 9
        Me.lbl_error_id.Text = "Label6"
        Me.lbl_error_id.Visible = False
        '
        'lbl_error_name
        '
        Me.lbl_error_name.AutoSize = True
        Me.lbl_error_name.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_name.Location = New System.Drawing.Point(88, 184)
        Me.lbl_error_name.Name = "lbl_error_name"
        Me.lbl_error_name.Size = New System.Drawing.Size(39, 13)
        Me.lbl_error_name.TabIndex = 10
        Me.lbl_error_name.Text = "Label7"
        Me.lbl_error_name.Visible = False
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.White
        Me.lbl_address.Location = New System.Drawing.Point(409, 142)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(61, 16)
        Me.lbl_address.TabIndex = 11
        Me.lbl_address.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(412, 161)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(154, 82)
        Me.txt_address.TabIndex = 12
        '
        'lbl_error_address
        '
        Me.lbl_error_address.AutoSize = True
        Me.lbl_error_address.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_address.Location = New System.Drawing.Point(409, 246)
        Me.lbl_error_address.Name = "lbl_error_address"
        Me.lbl_error_address.Size = New System.Drawing.Size(39, 13)
        Me.lbl_error_address.TabIndex = 13
        Me.lbl_error_address.Text = "Label1"
        Me.lbl_error_address.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(584, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = False
        '
        'createCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(679, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_error_address)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lbl_error_name)
        Me.Controls.Add(Me.lbl_error_id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "createCustomer"
        Me.Text = "frm_createCustomer_a172423"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_error_id As Label
    Friend WithEvents lbl_error_name As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents lbl_error_address As Label
    Friend WithEvents Button1 As Button
End Class
