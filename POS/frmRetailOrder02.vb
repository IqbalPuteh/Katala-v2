Public Class frmRetailOrder02
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRetailOrder02))
        Me.grpDetail = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtQTY = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.txtTaxPrice = New System.Windows.Forms.TextBox
        Me.txtDiscPrice = New System.Windows.Forms.TextBox
        Me.txtDisc = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTax = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.grpDetail.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDetail
        '
        Me.grpDetail.Controls.Add(Me.dtpEnd)
        Me.grpDetail.Controls.Add(Me.Label7)
        Me.grpDetail.Controls.Add(Me.dtpStart)
        Me.grpDetail.Controls.Add(Me.lblTransDate)
        Me.grpDetail.Controls.Add(Me.Label10)
        Me.grpDetail.Controls.Add(Me.txtTotalPrice)
        Me.grpDetail.Controls.Add(Me.Label4)
        Me.grpDetail.Controls.Add(Me.txtGrandTotal)
        Me.grpDetail.Controls.Add(Me.txtTaxPrice)
        Me.grpDetail.Controls.Add(Me.txtDiscPrice)
        Me.grpDetail.Controls.Add(Me.txtDisc)
        Me.grpDetail.Controls.Add(Me.Label8)
        Me.grpDetail.Controls.Add(Me.txtTax)
        Me.grpDetail.Controls.Add(Me.Label5)
        Me.grpDetail.Controls.Add(Me.txtQTY)
        Me.grpDetail.Controls.Add(Me.Label2)
        Me.grpDetail.Controls.Add(Me.GroupBox2)
        Me.grpDetail.Controls.Add(Me.GroupBox1)
        Me.grpDetail.Controls.Add(Me.TextBox1)
        Me.grpDetail.Controls.Add(Me.Label3)
        Me.grpDetail.Controls.Add(Me.txtMemberName)
        Me.grpDetail.Controls.Add(Me.Label6)
        Me.grpDetail.Controls.Add(Me.txtMemberId)
        Me.grpDetail.Controls.Add(Me.Label1)
        Me.grpDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetail.ForeColor = System.Drawing.Color.Blue
        Me.grpDetail.Location = New System.Drawing.Point(1, 5)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(640, 379)
        Me.grpDetail.TabIndex = 43
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Retail Order - Detail Information"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(136, 24)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 21)
        Me.TextBox1.TabIndex = 88
        Me.TextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Transaction Id.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberName.Location = New System.Drawing.Point(328, 47)
        Me.txtMemberName.MaxLength = 20
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(304, 21)
        Me.txtMemberName.TabIndex = 5
        Me.txtMemberName.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(264, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Item Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Enabled = False
        Me.txtMemberId.Location = New System.Drawing.Point(136, 47)
        Me.txtMemberId.MaxLength = 20
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(120, 21)
        Me.txtMemberId.TabIndex = 69
        Me.txtMemberId.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(80, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Item No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(472, 392)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 24)
        Me.btnOk.TabIndex = 44
        Me.btnOk.Text = "&Ok"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(560, 392)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 45
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(136, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 93)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(296, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 93)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(136, 70)
        Me.txtQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(56, 21)
        Me.txtQTY.TabIndex = 92
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(73, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Order QTY:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(85, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Amount:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtTotalPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(136, 94)
        Me.txtTotalPrice.MaxLength = 12
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalPrice.Size = New System.Drawing.Size(152, 21)
        Me.txtTotalPrice.TabIndex = 102
        Me.txtTotalPrice.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Total Amount:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(136, 166)
        Me.txtGrandTotal.MaxLength = 12
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGrandTotal.Size = New System.Drawing.Size(152, 21)
        Me.txtGrandTotal.TabIndex = 100
        Me.txtGrandTotal.Text = "0"
        '
        'txtTaxPrice
        '
        Me.txtTaxPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTaxPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTaxPrice.Enabled = False
        Me.txtTaxPrice.Location = New System.Drawing.Point(192, 142)
        Me.txtTaxPrice.MaxLength = 12
        Me.txtTaxPrice.Name = "txtTaxPrice"
        Me.txtTaxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxPrice.Size = New System.Drawing.Size(96, 21)
        Me.txtTaxPrice.TabIndex = 99
        Me.txtTaxPrice.Text = "0"
        '
        'txtDiscPrice
        '
        Me.txtDiscPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtDiscPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscPrice.Enabled = False
        Me.txtDiscPrice.Location = New System.Drawing.Point(192, 118)
        Me.txtDiscPrice.MaxLength = 12
        Me.txtDiscPrice.Name = "txtDiscPrice"
        Me.txtDiscPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDiscPrice.Size = New System.Drawing.Size(96, 21)
        Me.txtDiscPrice.TabIndex = 98
        Me.txtDiscPrice.Text = "0"
        '
        'txtDisc
        '
        Me.txtDisc.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDisc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(136, 118)
        Me.txtDisc.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(56, 21)
        Me.txtDisc.TabIndex = 94
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(84, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Disc. %:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(136, 142)
        Me.txtTax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(56, 21)
        Me.txtTax.TabIndex = 95
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(89, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Tax. %:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(15, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "&Daily"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(15, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "&Weekly"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(15, 67)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "&Monthly"
        '
        'dtpEnd
        '
        Me.dtpEnd.Checked = False
        Me.dtpEnd.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(264, 304)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(104, 21)
        Me.dtpEnd.TabIndex = 105
        Me.dtpEnd.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(242, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 17)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "To"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(136, 304)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(104, 21)
        Me.dtpStart.TabIndex = 104
        Me.dtpStart.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(69, 307)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(64, 17)
        Me.lblTransDate.TabIndex = 106
        Me.lblTransDate.Text = "Order Date:"
        '
        'frmRetailOrder02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 419)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpDetail)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetailOrder02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Order - Input Screen"
        Me.grpDetail.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
