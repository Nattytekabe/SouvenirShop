<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class make_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(make_order))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_staff = New System.Windows.Forms.GroupBox()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_error_quantity = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cmb_product = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dg_cart = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_make = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.grp_staff.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make Order"
        '
        'grp_staff
        '
        Me.grp_staff.Controls.Add(Me.cmb_staff)
        Me.grp_staff.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_staff.ForeColor = System.Drawing.Color.White
        Me.grp_staff.Location = New System.Drawing.Point(42, 95)
        Me.grp_staff.Name = "grp_staff"
        Me.grp_staff.Size = New System.Drawing.Size(200, 100)
        Me.grp_staff.TabIndex = 1
        Me.grp_staff.TabStop = False
        Me.grp_staff.Text = "Staff"
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(22, 47)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(166, 24)
        Me.cmb_staff.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_customer)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(42, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(22, 44)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(166, 24)
        Me.cmb_customer.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_quantity)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_error_quantity)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.cmb_product)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(329, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product List"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(281, 52)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(61, 23)
        Me.txt_quantity.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        '
        'lbl_error_quantity
        '
        Me.lbl_error_quantity.AutoSize = True
        Me.lbl_error_quantity.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_quantity.Location = New System.Drawing.Point(239, 78)
        Me.lbl_error_quantity.Name = "lbl_error_quantity"
        Me.lbl_error_quantity.Size = New System.Drawing.Size(210, 16)
        Me.lbl_error_quantity.TabIndex = 1
        Me.lbl_error_quantity.Text = "The quantity is more than stock"
        Me.lbl_error_quantity.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Product"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Location = New System.Drawing.Point(346, 52)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(103, 23)
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "Add To Cart"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'cmb_product
        '
        Me.cmb_product.FormattingEnabled = True
        Me.cmb_product.Location = New System.Drawing.Point(24, 52)
        Me.cmb_product.Name = "cmb_product"
        Me.cmb_product.Size = New System.Drawing.Size(251, 24)
        Me.cmb_product.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dg_cart)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(329, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 253)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cart"
        '
        'dg_cart
        '
        Me.dg_cart.AllowUserToAddRows = False
        Me.dg_cart.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.dg_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_name, Me.col_quantity, Me.col_total})
        Me.dg_cart.Location = New System.Drawing.Point(15, 22)
        Me.dg_cart.Name = "dg_cart"
        Me.dg_cart.ReadOnly = True
        Me.dg_cart.Size = New System.Drawing.Size(446, 199)
        Me.dg_cart.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_name
        '
        Me.col_name.HeaderText = "Product Name"
        Me.col_name.Name = "col_name"
        Me.col_name.ReadOnly = True
        '
        'col_quantity
        '
        Me.col_quantity.HeaderText = "Quantity"
        Me.col_quantity.Name = "col_quantity"
        Me.col_quantity.ReadOnly = True
        '
        'col_total
        '
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Yellow
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_back.Location = New System.Drawing.Point(717, 527)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.White
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(636, 527)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_make
        '
        Me.btn_make.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_make.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_make.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_make.Location = New System.Drawing.Point(531, 527)
        Me.btn_make.Name = "btn_make"
        Me.btn_make.Size = New System.Drawing.Size(99, 23)
        Me.btn_make.TabIndex = 8
        Me.btn_make.Text = "Order"
        Me.btn_make.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(342, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(794, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 48)
        Me.Button2.TabIndex = 14
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_total.Location = New System.Drawing.Point(425, 451)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(116, 31)
        Me.txt_total.TabIndex = 10
        Me.txt_total.Text = "Add Cart"
        '
        'make_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(879, 565)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_make)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_staff)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "make_order"
        Me.Text = "frm_make_order_a172423"
        Me.grp_staff.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dg_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grp_staff As GroupBox
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dg_cart As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_make As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents cmb_product As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_error_quantity As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_quantity As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_total As TextBox
End Class
