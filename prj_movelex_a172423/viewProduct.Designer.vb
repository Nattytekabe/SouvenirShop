<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewProduct))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_battery = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.lbl_createdAt = New System.Windows.Forms.Label()
        Me.lbl_updatedAt = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_battery = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_created_at = New System.Windows.Forms.TextBox()
        Me.txt_updated_at = New System.Windows.Forms.TextBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_error_name = New System.Windows.Forms.Label()
        Me.lbl_error_quantity = New System.Windows.Forms.Label()
        Me.lbl_error_material = New System.Windows.Forms.Label()
        Me.lbl_error_price = New System.Windows.Forms.Label()
        Me.lbl_error_type = New System.Windows.Forms.Label()
        Me.lbl_error_country = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_filename_image = New System.Windows.Forms.Label()
        Me.lbl_error_image = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(12, 40)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(203, 56)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product"
        '
        'pic_product
        '
        Me.pic_product.Location = New System.Drawing.Point(33, 117)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(226, 161)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.ForeColor = System.Drawing.Color.White
        Me.lbl_product_name.Location = New System.Drawing.Point(308, 122)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(47, 16)
        Me.lbl_product_name.TabIndex = 2
        Me.lbl_product_name.Text = "Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(607, 121)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(40, 16)
        Me.lbl_price.TabIndex = 3
        Me.lbl_price.Text = "Price"
        '
        'lbl_battery
        '
        Me.lbl_battery.AutoSize = True
        Me.lbl_battery.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_battery.ForeColor = System.Drawing.Color.White
        Me.lbl_battery.Location = New System.Drawing.Point(585, 215)
        Me.lbl_battery.Name = "lbl_battery"
        Me.lbl_battery.Size = New System.Drawing.Size(62, 16)
        Me.lbl_battery.TabIndex = 4
        Me.lbl_battery.Text = "Made in"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.White
        Me.lbl_quantity.Location = New System.Drawing.Point(308, 168)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(64, 16)
        Me.lbl_quantity.TabIndex = 5
        Me.lbl_quantity.Text = "Quantity"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.Color.White
        Me.lbl_type.Location = New System.Drawing.Point(608, 167)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(39, 16)
        Me.lbl_type.TabIndex = 6
        Me.lbl_type.Text = "Type"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.ForeColor = System.Drawing.Color.White
        Me.lbl_material.Location = New System.Drawing.Point(308, 216)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(63, 16)
        Me.lbl_material.TabIndex = 7
        Me.lbl_material.Text = "Material"
        '
        'lbl_createdAt
        '
        Me.lbl_createdAt.AutoSize = True
        Me.lbl_createdAt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_createdAt.ForeColor = System.Drawing.Color.White
        Me.lbl_createdAt.Location = New System.Drawing.Point(296, 261)
        Me.lbl_createdAt.Name = "lbl_createdAt"
        Me.lbl_createdAt.Size = New System.Drawing.Size(79, 16)
        Me.lbl_createdAt.TabIndex = 8
        Me.lbl_createdAt.Text = "Created At"
        '
        'lbl_updatedAt
        '
        Me.lbl_updatedAt.AutoSize = True
        Me.lbl_updatedAt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_updatedAt.ForeColor = System.Drawing.Color.White
        Me.lbl_updatedAt.Location = New System.Drawing.Point(565, 260)
        Me.lbl_updatedAt.Name = "lbl_updatedAt"
        Me.lbl_updatedAt.Size = New System.Drawing.Size(82, 16)
        Me.lbl_updatedAt.TabIndex = 9
        Me.lbl_updatedAt.Text = "Updated At"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(381, 122)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(124, 20)
        Me.txt_name.TabIndex = 10
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(381, 165)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(124, 20)
        Me.txt_quantity.TabIndex = 11
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(381, 213)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(124, 20)
        Me.txt_material.TabIndex = 12
        '
        'txt_battery
        '
        Me.txt_battery.Location = New System.Drawing.Point(653, 212)
        Me.txt_battery.Name = "txt_battery"
        Me.txt_battery.Size = New System.Drawing.Size(100, 20)
        Me.txt_battery.TabIndex = 15
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(653, 118)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(595, 335)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(678, 335)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 21
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(503, 335)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_created_at
        '
        Me.txt_created_at.Location = New System.Drawing.Point(381, 258)
        Me.txt_created_at.Name = "txt_created_at"
        Me.txt_created_at.ReadOnly = True
        Me.txt_created_at.Size = New System.Drawing.Size(124, 20)
        Me.txt_created_at.TabIndex = 22
        '
        'txt_updated_at
        '
        Me.txt_updated_at.Location = New System.Drawing.Point(653, 257)
        Me.txt_updated_at.Name = "txt_updated_at"
        Me.txt_updated_at.ReadOnly = True
        Me.txt_updated_at.Size = New System.Drawing.Size(100, 20)
        Me.txt_updated_at.TabIndex = 23
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(653, 164)
        Me.cmb_type.MaxDropDownItems = 3
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(100, 21)
        Me.cmb_type.TabIndex = 24
        '
        'lbl_error_name
        '
        Me.lbl_error_name.AutoSize = True
        Me.lbl_error_name.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_name.Location = New System.Drawing.Point(378, 145)
        Me.lbl_error_name.Name = "lbl_error_name"
        Me.lbl_error_name.Size = New System.Drawing.Size(60, 13)
        Me.lbl_error_name.TabIndex = 25
        Me.lbl_error_name.Text = "error_name"
        Me.lbl_error_name.Visible = False
        '
        'lbl_error_quantity
        '
        Me.lbl_error_quantity.AutoSize = True
        Me.lbl_error_quantity.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_quantity.Location = New System.Drawing.Point(378, 188)
        Me.lbl_error_quantity.Name = "lbl_error_quantity"
        Me.lbl_error_quantity.Size = New System.Drawing.Size(71, 13)
        Me.lbl_error_quantity.TabIndex = 26
        Me.lbl_error_quantity.Text = "error_quantity"
        Me.lbl_error_quantity.Visible = False
        '
        'lbl_error_material
        '
        Me.lbl_error_material.AutoSize = True
        Me.lbl_error_material.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_material.Location = New System.Drawing.Point(378, 236)
        Me.lbl_error_material.Name = "lbl_error_material"
        Me.lbl_error_material.Size = New System.Drawing.Size(70, 13)
        Me.lbl_error_material.TabIndex = 27
        Me.lbl_error_material.Text = "error_material"
        Me.lbl_error_material.Visible = False
        '
        'lbl_error_price
        '
        Me.lbl_error_price.AutoSize = True
        Me.lbl_error_price.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_price.Location = New System.Drawing.Point(650, 141)
        Me.lbl_error_price.Name = "lbl_error_price"
        Me.lbl_error_price.Size = New System.Drawing.Size(57, 13)
        Me.lbl_error_price.TabIndex = 29
        Me.lbl_error_price.Text = "error_price"
        Me.lbl_error_price.Visible = False
        '
        'lbl_error_type
        '
        Me.lbl_error_type.AutoSize = True
        Me.lbl_error_type.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_type.Location = New System.Drawing.Point(650, 188)
        Me.lbl_error_type.Name = "lbl_error_type"
        Me.lbl_error_type.Size = New System.Drawing.Size(54, 13)
        Me.lbl_error_type.TabIndex = 30
        Me.lbl_error_type.Text = "error_type"
        Me.lbl_error_type.Visible = False
        '
        'lbl_error_country
        '
        Me.lbl_error_country.AutoSize = True
        Me.lbl_error_country.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_country.Location = New System.Drawing.Point(650, 235)
        Me.lbl_error_country.Name = "lbl_error_country"
        Me.lbl_error_country.Size = New System.Drawing.Size(69, 13)
        Me.lbl_error_country.TabIndex = 31
        Me.lbl_error_country.Text = "error_country"
        Me.lbl_error_country.Visible = False
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.White
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(33, 284)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 32
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_filename_image
        '
        Me.lbl_filename_image.AutoSize = True
        Me.lbl_filename_image.Location = New System.Drawing.Point(114, 284)
        Me.lbl_filename_image.Name = "lbl_filename_image"
        Me.lbl_filename_image.Size = New System.Drawing.Size(68, 13)
        Me.lbl_filename_image.TabIndex = 33
        Me.lbl_filename_image.Text = "picture name"
        Me.lbl_filename_image.Visible = False
        '
        'lbl_error_image
        '
        Me.lbl_error_image.AutoSize = True
        Me.lbl_error_image.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_image.Location = New System.Drawing.Point(30, 310)
        Me.lbl_error_image.Name = "lbl_error_image"
        Me.lbl_error_image.Size = New System.Drawing.Size(78, 13)
        Me.lbl_error_image.TabIndex = 34
        Me.lbl_error_image.Text = "lbl_error_image"
        Me.lbl_error_image.Visible = False
        '
        'viewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(831, 407)
        Me.Controls.Add(Me.lbl_error_image)
        Me.Controls.Add(Me.lbl_filename_image)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.lbl_error_country)
        Me.Controls.Add(Me.lbl_error_type)
        Me.Controls.Add(Me.lbl_error_price)
        Me.Controls.Add(Me.lbl_error_material)
        Me.Controls.Add(Me.lbl_error_quantity)
        Me.Controls.Add(Me.lbl_error_name)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_updated_at)
        Me.Controls.Add(Me.txt_created_at)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_battery)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_updatedAt)
        Me.Controls.Add(Me.lbl_createdAt)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_battery)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewProduct"
        Me.Text = "Product Detail"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_battery As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents lbl_createdAt As Label
    Friend WithEvents lbl_updatedAt As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_battery As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_created_at As TextBox
    Friend WithEvents txt_updated_at As TextBox
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_error_name As Label
    Friend WithEvents lbl_error_quantity As Label
    Friend WithEvents lbl_error_material As Label
    Friend WithEvents lbl_error_price As Label
    Friend WithEvents lbl_error_type As Label
    Friend WithEvents lbl_error_country As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_filename_image As Label
    Friend WithEvents lbl_error_image As Label
End Class
