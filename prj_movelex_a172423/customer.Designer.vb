<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_create_customer = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(12, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(349, 56)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Customers List"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_home.BackgroundImage = CType(resources.GetObject("btn_home.BackgroundImage"), System.Drawing.Image)
        Me.btn_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Location = New System.Drawing.Point(642, 26)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(52, 53)
        Me.btn_home.TabIndex = 2
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_customer.BackgroundColor = System.Drawing.Color.Orange
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(57, 85)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.Size = New System.Drawing.Size(635, 270)
        Me.grd_customer.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_total.Location = New System.Drawing.Point(54, 358)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 16)
        Me.lbl_total.TabIndex = 4
        '
        'btn_create_customer
        '
        Me.btn_create_customer.BackColor = System.Drawing.Color.Lime
        Me.btn_create_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_customer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_customer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_create_customer.Location = New System.Drawing.Point(561, 40)
        Me.btn_create_customer.Name = "btn_create_customer"
        Me.btn_create_customer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_create_customer.Size = New System.Drawing.Size(75, 23)
        Me.btn_create_customer.TabIndex = 5
        Me.btn_create_customer.Text = "Create"
        Me.btn_create_customer.UseVisualStyleBackColor = False
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(755, 388)
        Me.Controls.Add(Me.btn_create_customer)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "customer"
        Me.Text = "Customer"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_create_customer As Button
End Class
