Public Class frmPOS01
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
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblActiveStatus As System.Windows.Forms.Label
    Friend WithEvents ttlActiveStatus As System.Windows.Forms.Label
    Friend WithEvents lblBadgeId As System.Windows.Forms.Label
    Friend WithEvents ttlBadgeId As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents ttlName As System.Windows.Forms.Label
    Friend WithEvents txtMembershipNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents txtTaxPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemain As System.Windows.Forms.TextBox
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblRemain As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents optScanner As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPOS01))
        Me.grpPayment = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.optScanner = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblRemain = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRemain = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPay = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.txtTaxPrice = New System.Windows.Forms.TextBox
        Me.txtDiscPrice = New System.Windows.Forms.TextBox
        Me.txtDisc = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTax = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtVoucherNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblActiveStatus = New System.Windows.Forms.Label
        Me.ttlActiveStatus = New System.Windows.Forms.Label
        Me.lblBadgeId = New System.Windows.Forms.Label
        Me.ttlBadgeId = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.ttlName = New System.Windows.Forms.Label
        Me.txtMembershipNo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.grpPayment.SuspendLayout()
        CType(Me.txtPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.Label9)
        Me.grpPayment.Controls.Add(Me.optScanner)
        Me.grpPayment.Controls.Add(Me.Label7)
        Me.grpPayment.Controls.Add(Me.lblRemain)
        Me.grpPayment.Controls.Add(Me.Label5)
        Me.grpPayment.Controls.Add(Me.txtRemain)
        Me.grpPayment.Controls.Add(Me.Label1)
        Me.grpPayment.Controls.Add(Me.btnSave)
        Me.grpPayment.Controls.Add(Me.btnClose)
        Me.grpPayment.Controls.Add(Me.Label10)
        Me.grpPayment.Controls.Add(Me.txtTotalPrice)
        Me.grpPayment.Controls.Add(Me.Label3)
        Me.grpPayment.Controls.Add(Me.txtPay)
        Me.grpPayment.Controls.Add(Me.Label4)
        Me.grpPayment.Controls.Add(Me.txtGrandTotal)
        Me.grpPayment.Controls.Add(Me.txtTaxPrice)
        Me.grpPayment.Controls.Add(Me.txtDiscPrice)
        Me.grpPayment.Controls.Add(Me.txtDisc)
        Me.grpPayment.Controls.Add(Me.Label8)
        Me.grpPayment.Controls.Add(Me.txtTax)
        Me.grpPayment.Controls.Add(Me.Label6)
        Me.grpPayment.Controls.Add(Me.txtVoucherNo)
        Me.grpPayment.Controls.Add(Me.Label2)
        Me.grpPayment.Controls.Add(Me.lblActiveStatus)
        Me.grpPayment.Controls.Add(Me.ttlActiveStatus)
        Me.grpPayment.Controls.Add(Me.lblBadgeId)
        Me.grpPayment.Controls.Add(Me.ttlBadgeId)
        Me.grpPayment.Controls.Add(Me.lblName)
        Me.grpPayment.Controls.Add(Me.ttlName)
        Me.grpPayment.Controls.Add(Me.txtMembershipNo)
        Me.grpPayment.Controls.Add(Me.Label15)
        Me.grpPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayment.ForeColor = System.Drawing.Color.Blue
        Me.grpPayment.Location = New System.Drawing.Point(2, 2)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(607, 245)
        Me.grpPayment.TabIndex = 80
        Me.grpPayment.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(502, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Scanner"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optScanner
        '
        Me.optScanner.Checked = True
        Me.optScanner.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optScanner.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optScanner.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optScanner.Location = New System.Drawing.Point(550, 24)
        Me.optScanner.Name = "optScanner"
        Me.optScanner.Size = New System.Drawing.Size(48, 16)
        Me.optScanner.TabIndex = 6
        Me.optScanner.Text = "Yes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(24, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 42)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Rp. "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRemain
        '
        Me.lblRemain.AutoSize = True
        Me.lblRemain.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain.ForeColor = System.Drawing.Color.Red
        Me.lblRemain.Location = New System.Drawing.Point(88, 192)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(82, 46)
        Me.lblRemain.TabIndex = 95
        Me.lblRemain.Text = "0.00"
        Me.lblRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(31, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Remain:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemain
        '
        Me.txtRemain.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtRemain.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemain.Enabled = False
        Me.txtRemain.Location = New System.Drawing.Point(89, 160)
        Me.txtRemain.MaxLength = 12
        Me.txtRemain.Name = "txtRemain"
        Me.txtRemain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRemain.Size = New System.Drawing.Size(152, 21)
        Me.txtRemain.TabIndex = 93
        Me.txtRemain.Text = "0"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(8, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 1)
        Me.Label1.TabIndex = 92
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(360, 204)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(464, 204)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Total Price:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTotalPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(89, 21)
        Me.txtTotalPrice.MaxLength = 12
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalPrice.Size = New System.Drawing.Size(152, 21)
        Me.txtTotalPrice.TabIndex = 90
        Me.txtTotalPrice.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Pay:"
        '
        'txtPay
        '
        Me.txtPay.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(89, 120)
        Me.txtPay.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(152, 30)
        Me.txtPay.TabIndex = 2
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Grand Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(89, 93)
        Me.txtGrandTotal.MaxLength = 12
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGrandTotal.Size = New System.Drawing.Size(152, 21)
        Me.txtGrandTotal.TabIndex = 86
        Me.txtGrandTotal.Text = "0"
        '
        'txtTaxPrice
        '
        Me.txtTaxPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTaxPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTaxPrice.Enabled = False
        Me.txtTaxPrice.Location = New System.Drawing.Point(145, 69)
        Me.txtTaxPrice.MaxLength = 12
        Me.txtTaxPrice.Name = "txtTaxPrice"
        Me.txtTaxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxPrice.Size = New System.Drawing.Size(96, 21)
        Me.txtTaxPrice.TabIndex = 85
        Me.txtTaxPrice.Text = "0"
        '
        'txtDiscPrice
        '
        Me.txtDiscPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtDiscPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscPrice.Enabled = False
        Me.txtDiscPrice.Location = New System.Drawing.Point(145, 45)
        Me.txtDiscPrice.MaxLength = 12
        Me.txtDiscPrice.Name = "txtDiscPrice"
        Me.txtDiscPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDiscPrice.Size = New System.Drawing.Size(96, 21)
        Me.txtDiscPrice.TabIndex = 84
        Me.txtDiscPrice.Text = "0"
        '
        'txtDisc
        '
        Me.txtDisc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDisc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(89, 45)
        Me.txtDisc.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(56, 21)
        Me.txtDisc.TabIndex = 0
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(32, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Disc. %:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(89, 69)
        Me.txtTax.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(56, 21)
        Me.txtTax.TabIndex = 1
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(35, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Tax. %:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtVoucherNo.Location = New System.Drawing.Point(360, 117)
        Me.txtVoucherNo.MaxLength = 20
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(160, 21)
        Me.txtVoucherNo.TabIndex = 7
        Me.txtVoucherNo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(281, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Voucher No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(359, 96)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(90, 17)
        Me.lblActiveStatus.TabIndex = 68
        Me.lblActiveStatus.Text = "lblActiveStatus"
        Me.lblActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttlActiveStatus
        '
        Me.ttlActiveStatus.AutoSize = True
        Me.ttlActiveStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.ttlActiveStatus.Location = New System.Drawing.Point(271, 96)
        Me.ttlActiveStatus.Name = "ttlActiveStatus"
        Me.ttlActiveStatus.Size = New System.Drawing.Size(83, 17)
        Me.ttlActiveStatus.TabIndex = 67
        Me.ttlActiveStatus.Text = "Active Status:"
        Me.ttlActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBadgeId
        '
        Me.lblBadgeId.AutoSize = True
        Me.lblBadgeId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadgeId.ForeColor = System.Drawing.Color.Black
        Me.lblBadgeId.Location = New System.Drawing.Point(360, 72)
        Me.lblBadgeId.Name = "lblBadgeId"
        Me.lblBadgeId.Size = New System.Drawing.Size(66, 17)
        Me.lblBadgeId.TabIndex = 64
        Me.lblBadgeId.Text = "lblBadgeId"
        Me.lblBadgeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttlBadgeId
        '
        Me.ttlBadgeId.AutoSize = True
        Me.ttlBadgeId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlBadgeId.ForeColor = System.Drawing.Color.Black
        Me.ttlBadgeId.Location = New System.Drawing.Point(294, 72)
        Me.ttlBadgeId.Name = "ttlBadgeId"
        Me.ttlBadgeId.Size = New System.Drawing.Size(63, 17)
        Me.ttlBadgeId.TabIndex = 62
        Me.ttlBadgeId.Text = "Badge Id.:"
        Me.ttlBadgeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(360, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 58
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttlName
        '
        Me.ttlName.AutoSize = True
        Me.ttlName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlName.ForeColor = System.Drawing.Color.Black
        Me.ttlName.Location = New System.Drawing.Point(316, 48)
        Me.ttlName.Name = "ttlName"
        Me.ttlName.Size = New System.Drawing.Size(41, 17)
        Me.ttlName.TabIndex = 57
        Me.ttlName.Text = "Name:"
        Me.ttlName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMembershipNo
        '
        Me.txtMembershipNo.BackColor = System.Drawing.Color.White
        Me.txtMembershipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMembershipNo.ForeColor = System.Drawing.Color.White
        Me.txtMembershipNo.Location = New System.Drawing.Point(360, 21)
        Me.txtMembershipNo.MaxLength = 10
        Me.txtMembershipNo.Name = "txtMembershipNo"
        Me.txtMembershipNo.Size = New System.Drawing.Size(87, 21)
        Me.txtMembershipNo.TabIndex = 5
        Me.txtMembershipNo.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(258, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 17)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Membership No.:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPOS01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(610, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpPayment)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.grpPayment.ResumeLayout(False)
        CType(Me.txtPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean
    Dim dblPrice As Double
    Dim dblTotal As Double
    Dim dblTotalPrice As Double
    Dim frmPOS00 As frmPOS

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub frmPOS01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ttlName.Visible = False
            lblName.Text = ""
            ttlBadgeId.Visible = False
            lblBadgeId.Text = ""
            ttlActiveStatus.Visible = False
            lblActiveStatus.Text = ""
            txtDisc.Focus()
            optScanner.Checked = True
            txtMembershipNo.ForeColor = Color.White

        Catch ex As Exception
            grpPayment.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Private Function CreateEventRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("EVENT")

        adoColumn = New DataColumn("USER_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DATE_TIME")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TOTAL_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EVENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        CreateEventRs = adoDS
    End Function

    Private Sub FillEvent(ByRef adoDS As DataSet, ByVal strEvent As String)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable

        adoDataTable = adoDS.Tables("EVENT")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("USER_ID") = USER_ID
        adoDataRow("AMOUNT") = txtGrandTotal.Text
        adoDataRow("TOTAL_QTY") = 0
        adoDataRow("EVENT") = strEvent
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim adoDS As New DataSet
        Dim svcSystemSecurity As New SystemSecurity.svcSystemSecurity

        Try
            svcSystemSecurity.Timeout = -1
            If txtGrandTotal.Text <> 0 Then
                adoDS = CreateEventRs()
                FillEvent(adoDS, "CLOSE PAYMENT")
                svcSystemSecurity.syseventprocedure(adoDS, APP_ID)
            End If

            blnCancel = True
            Me.Dispose()

        Catch ex As Exception

        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (svcSystemSecurity Is Nothing) Then
                svcSystemSecurity.Dispose()
                svcSystemSecurity = Nothing
            End If
        End Try
    End Sub

    Public Sub FillField(ByVal dblTotalPrc As Double, ByVal frmPrevForm As frmPOS)

        Try
            dblTotalPrice = dblTotalPrc
            txtTotalPrice.Text = dblTotalPrc
            frmPOS00 = frmPrevForm
        Catch ex As Exception
            grpPayment.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dblPay As Double
        Dim dblGrandTotal As Double

        Try
            If CDbl(txtPay.Text) < 0 Then
                Exit Sub
            End If

        Catch ex As Exception
            txtPay.Text = 0
            Exit Sub
        End Try

        dblPay = txtPay.Text
        dblGrandTotal = txtGrandTotal.Text

        If dblPay < dblGrandTotal Then
            MessageBox.Show("The Payment value can not less than the Grand Total value. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Trim(txtMembershipNo.Text) <> "" And Trim(lblName.Text) = "" Then
            MessageBox.Show("Please re-type or delete the Membership No ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure want to save this data?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        blnCancel = False
        frmPOS00.dblLastChange = Me.lblRemain.Text
        Me.Hide()
    End Sub

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet

        Try
            myDS = CreateResourceCodeRs()
            FillDataSet(myDS)
            GetDataSet = myDS

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable

        adoDataTable = adoDS.Tables("PAYMENT_DATA")
        adoDataRow = adoDataTable.NewRow()

        adoDataRow("DISC") = txtDisc.Text
        adoDataRow("TAX") = txtTax.Text
        adoDataRow("AMOUNT") = txtGrandTotal.Text
        adoDataRow("PAY") = txtPay.Text
        adoDataRow("REMAIN") = txtRemain.Text
        adoDataRow("MEMBERSHIP_NO") = txtMembershipNo.Text
        adoDataRow("VOUCHER_NO") = txtVoucherNo.Text
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("PAYMENT_DATA")

        adoColumn = New DataColumn("DISC")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TAX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PAY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REMAIN")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("VOUCHER_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PAYMENT_DATA").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub txtDisc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc.TextChanged
        If Trim(txtDisc.Text) = "" Then
            txtDisc.Text = 0
        End If
        txtDiscPrice.Text = 0
        Call Calculation()
    End Sub

    Private Sub txtDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDisc.KeyDown

        Try
            If e.KeyCode = Keys.Return Then
                Call Calculation()
                txtTax.Focus()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtDisc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc.DoubleClick
        txtDisc_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub txtTax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTax.TextChanged
        If Trim(txtTax.Text) = "" Then
            txtTax.Text = 0
        End If
        txtTaxPrice.Text = 0
        Call Calculation()
    End Sub

    Private Sub txtTax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTax.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                Call Calculation()
                txtPay.Focus()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtTax_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTax.DoubleClick
        txtTax_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub txtTotalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPrice.TextChanged
        If txtTotalPrice.Text < 0 Then
            txtDiscPrice.Text = "0"
            txtTaxPrice.Text = "0"
            txtGrandTotal.Text = "0"
        Else
            Call Calculation()
        End If
    End Sub

    Private Sub Calculation()
        Dim dblDisc As Double
        Dim dblDiscPrice As Double
        Dim dblTax As Double
        Dim dblTaxPrice As Double
        Dim dblGrandTotal As Double

        Try
            dblDisc = txtDisc.Text
            dblDiscPrice = ValidateEmpty(txtDiscPrice.Text)
            dblTax = txtTax.Text
            dblTaxPrice = ValidateEmpty(txtTaxPrice.Text)
            dblGrandTotal = ValidateEmpty(txtGrandTotal.Text)

            'Count Discount
            If dblDisc > 0 Then
                dblDiscPrice = (dblDisc * dblTotalPrice) / 100
                txtDiscPrice.Text = dblDiscPrice
            End If

            'Count Tax
            If dblTax > 0 Then
                dblTotalPrice = dblTotalPrice - dblDiscPrice
                dblTaxPrice = (dblTax * dblTotalPrice) / 100
                txtTaxPrice.Text = dblTaxPrice
            End If

            'Count Grand Total
            dblTotalPrice = ValidateEmpty(txtTotalPrice.Text)
            dblDiscPrice = ValidateEmpty(txtDiscPrice.Text)
            dblTaxPrice = ValidateEmpty(txtTaxPrice.Text)
            dblGrandTotal = ((dblTotalPrice - dblDiscPrice) + dblTaxPrice)
            txtGrandTotal.Text = dblGrandTotal

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtPay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPay.TextChanged
        If Trim(txtPay.Text) = "" Then
            txtPay.Text = 0
        End If
        txtRemain.Text = 0
    End Sub

    Private Sub txtPay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPay.KeyDown
        Dim dblPay As Double
        Dim dblGrandTotal As Double

        Try
            If e.KeyCode = Keys.Return Then
                dblPay = txtPay.Text
                dblGrandTotal = txtGrandTotal.Text

                If dblPay >= dblGrandTotal Then
                    txtRemain.Text = txtPay.Text - txtGrandTotal.Text
                    btnSave.Focus()
                Else
                    MessageBox.Show("The Payment value can not less than the Grand Total value. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtPay.Focus()
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtPay_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPay.DoubleClick
        txtPay_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub txtMembershipNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMembershipNo.KeyDown
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim strMembershipNo As String

        Try
            svcMembership.Timeout = -1
            If e.KeyCode = e.KeyCode.Enter Then
                If optScanner.Checked Then
                    strMembershipNo = Mid(txtMembershipNo.Text, 1, txtMembershipNo.Text.Length - 1)
                Else
                    strMembershipNo = txtMembershipNo.Text
                End If

                If Trim(strMembershipNo) <> "" Then
                    adoDS = svcMembership.GetMemberInfo(strMembershipNo, "", APP_ID)
                    If adoDS.Tables("MEMBERINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("MEMBERINFO").Rows(0)

                        ttlName.Visible = True
                        lblName.Text = NullToString(adoRow!FIRST_NAME) & " " & NullToString(adoRow!FAMILY_NAME)
                        ttlBadgeId.Visible = True
                        lblBadgeId.Text = NullToString(adoRow!BADGE_ID)
                        If NullToString(adoRow!ACTIVE_STATUS) <> "" Then
                            If NullToString(adoRow!ACTIVE_STATUS) = "A" Then
                                ttlActiveStatus.Visible = True
                                lblActiveStatus.Text = "Active"
                            Else
                                ttlActiveStatus.Visible = True
                                lblActiveStatus.Text = "Not Active"
                            End If
                        End If
                        txtVoucherNo.Focus()
                    Else
                        MessageBox.Show("The Membership data is not found . ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    adoDS.Dispose()
                Else

                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (svcMembership Is Nothing) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtMembershipNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembershipNo.TextChanged
        ttlName.Visible = False
        lblName.Text = ""
        ttlBadgeId.Visible = False
        lblBadgeId.Text = ""
        ttlActiveStatus.Visible = False
        lblActiveStatus.Text = ""
    End Sub

    Private Sub txtVoucherNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoucherNo.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub frmPOS01_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtDisc.Focus()
    End Sub

    Private Sub txtDisc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc.Enter
        txtDisc.Select(0, txtDisc.Text.Length)
    End Sub

    Private Sub txtTax_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTax.Enter
        txtTax.Select(0, txtTax.Text.Length)
    End Sub

    Private Sub txtPay_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPay.Enter
        txtPay.Select(0, txtPay.Text.Length)
    End Sub

    Private Sub txtRemain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemain.TextChanged
        Dim dblRemain As Double

        dblRemain = txtRemain.Text
        lblRemain.Text = Format(dblRemain, "##,##0")
    End Sub

    Private Sub optScanner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optScanner.CheckedChanged
        If optScanner.Checked = False Then
            txtMembershipNo.ForeColor = Color.Black
        Else
            txtMembershipNo.ForeColor = Color.White
        End If
        txtMembershipNo.Text = ""
        txtMembershipNo.Focus()
    End Sub

    Private Sub txtDisc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisc.TextChanged, txtDisc.ValueChanged, txtDisc.Leave
        Try
            If CDbl(txtDisc.Text) > 10 Then
                txtDisc.Text = 10
            End If
        Catch ex As Exception
            txtDisc.Text = 0
        End Try
        If txtDisc.Text.Length > 2 Then
            txtDisc.Text = 0
        End If
    End Sub

    Private Sub txtPay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPay.ValueChanged, txtPay.Leave
        Try
            If CDbl(txtPay.Text) < 0 Then
                txtPay.Text = 0
            End If
        Catch ex As Exception
            txtPay.Text = 0
        End Try

    End Sub
End Class
