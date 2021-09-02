<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewStaff))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_error_name = New System.Windows.Forms.Label()
        Me.lbl_error_id = New System.Windows.Forms.Label()
        Me.lbl_error_gender = New System.Windows.Forms.Label()
        Me.rbt_female = New System.Windows.Forms.RadioButton()
        Me.rbt_male = New System.Windows.Forms.RadioButton()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_created_at = New System.Windows.Forms.Label()
        Me.lbl_updated_at = New System.Windows.Forms.Label()
        Me.txt_created_at = New System.Windows.Forms.TextBox()
        Me.txt_updated_at = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(350, 313)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 29
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Yellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(117, 313)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 28
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'lbl_error_name
        '
        Me.lbl_error_name.AutoSize = True
        Me.lbl_error_name.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_name.Location = New System.Drawing.Point(20, 139)
        Me.lbl_error_name.Name = "lbl_error_name"
        Me.lbl_error_name.Size = New System.Drawing.Size(57, 13)
        Me.lbl_error_name.TabIndex = 27
        Me.lbl_error_name.Text = "name error"
        Me.lbl_error_name.Visible = False
        '
        'lbl_error_id
        '
        Me.lbl_error_id.AutoSize = True
        Me.lbl_error_id.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_id.Location = New System.Drawing.Point(219, 139)
        Me.lbl_error_id.Name = "lbl_error_id"
        Me.lbl_error_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_error_id.TabIndex = 26
        Me.lbl_error_id.Text = "error id"
        Me.lbl_error_id.Visible = False
        '
        'lbl_error_gender
        '
        Me.lbl_error_gender.AutoSize = True
        Me.lbl_error_gender.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_gender.Location = New System.Drawing.Point(392, 162)
        Me.lbl_error_gender.Name = "lbl_error_gender"
        Me.lbl_error_gender.Size = New System.Drawing.Size(64, 13)
        Me.lbl_error_gender.TabIndex = 25
        Me.lbl_error_gender.Text = "error gender"
        Me.lbl_error_gender.Visible = False
        '
        'rbt_female
        '
        Me.rbt_female.AutoSize = True
        Me.rbt_female.ForeColor = System.Drawing.Color.White
        Me.rbt_female.Location = New System.Drawing.Point(395, 142)
        Me.rbt_female.Name = "rbt_female"
        Me.rbt_female.Size = New System.Drawing.Size(59, 17)
        Me.rbt_female.TabIndex = 24
        Me.rbt_female.TabStop = True
        Me.rbt_female.Text = "Female"
        Me.rbt_female.UseVisualStyleBackColor = True
        '
        'rbt_male
        '
        Me.rbt_male.AutoSize = True
        Me.rbt_male.ForeColor = System.Drawing.Color.White
        Me.rbt_male.Location = New System.Drawing.Point(395, 119)
        Me.rbt_male.Name = "rbt_male"
        Me.rbt_male.Size = New System.Drawing.Size(48, 17)
        Me.rbt_male.TabIndex = 23
        Me.rbt_male.TabStop = True
        Me.rbt_male.Text = "Male"
        Me.rbt_male.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(23, 116)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 21
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(222, 116)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_id.TabIndex = 20
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.Color.White
        Me.lbl_gender.Location = New System.Drawing.Point(392, 97)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(57, 16)
        Me.lbl_gender.TabIndex = 19
        Me.lbl_gender.Text = "Gender"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(219, 97)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 16)
        Me.lbl_id.TabIndex = 18
        Me.lbl_id.Text = "ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(20, 97)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(47, 16)
        Me.lbl_name.TabIndex = 17
        Me.lbl_name.Text = "Name"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(275, 56)
        Me.lbl_title.TabIndex = 16
        Me.lbl_title.Text = "Staff Profile"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(232, 313)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 30
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_created_at
        '
        Me.lbl_created_at.AutoSize = True
        Me.lbl_created_at.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_created_at.ForeColor = System.Drawing.Color.White
        Me.lbl_created_at.Location = New System.Drawing.Point(20, 197)
        Me.lbl_created_at.Name = "lbl_created_at"
        Me.lbl_created_at.Size = New System.Drawing.Size(79, 16)
        Me.lbl_created_at.TabIndex = 31
        Me.lbl_created_at.Text = "Created At"
        '
        'lbl_updated_at
        '
        Me.lbl_updated_at.AutoSize = True
        Me.lbl_updated_at.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_updated_at.ForeColor = System.Drawing.Color.White
        Me.lbl_updated_at.Location = New System.Drawing.Point(219, 197)
        Me.lbl_updated_at.Name = "lbl_updated_at"
        Me.lbl_updated_at.Size = New System.Drawing.Size(82, 16)
        Me.lbl_updated_at.TabIndex = 32
        Me.lbl_updated_at.Text = "Updated At"
        '
        'txt_created_at
        '
        Me.txt_created_at.Location = New System.Drawing.Point(23, 216)
        Me.txt_created_at.Name = "txt_created_at"
        Me.txt_created_at.ReadOnly = True
        Me.txt_created_at.Size = New System.Drawing.Size(100, 20)
        Me.txt_created_at.TabIndex = 33
        '
        'txt_updated_at
        '
        Me.txt_updated_at.Location = New System.Drawing.Point(222, 216)
        Me.txt_updated_at.Name = "txt_updated_at"
        Me.txt_updated_at.ReadOnly = True
        Me.txt_updated_at.Size = New System.Drawing.Size(100, 20)
        Me.txt_updated_at.TabIndex = 34
        '
        'viewStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(571, 378)
        Me.Controls.Add(Me.txt_updated_at)
        Me.Controls.Add(Me.txt_created_at)
        Me.Controls.Add(Me.lbl_updated_at)
        Me.Controls.Add(Me.lbl_created_at)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_error_name)
        Me.Controls.Add(Me.lbl_error_id)
        Me.Controls.Add(Me.lbl_error_gender)
        Me.Controls.Add(Me.rbt_female)
        Me.Controls.Add(Me.rbt_male)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewStaff"
        Me.Text = "frm_viewStaff_a172423"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_error_name As Label
    Friend WithEvents lbl_error_id As Label
    Friend WithEvents lbl_error_gender As Label
    Friend WithEvents rbt_female As RadioButton
    Friend WithEvents rbt_male As RadioButton
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_gender As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_created_at As Label
    Friend WithEvents lbl_updated_at As Label
    Friend WithEvents txt_created_at As TextBox
    Friend WithEvents txt_updated_at As TextBox
End Class
