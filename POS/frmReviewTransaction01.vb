'Imports System.Globalization

Public Class frmReviewTransaction01
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
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemain As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTransDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPOSId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents grpTrans As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReviewTransaction01))
        Me.grpTrans = New System.Windows.Forms.GroupBox
        Me.txtTransDate = New System.Windows.Forms.TextBox
        Me.txtPOSId = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.txtPay = New System.Windows.Forms.TextBox
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.txtDisc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRemain = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
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
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.grpTrans.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTrans
        '
        Me.grpTrans.Controls.Add(Me.txtTransDate)
        Me.grpTrans.Controls.Add(Me.txtPOSId)
        Me.grpTrans.Controls.Add(Me.Label7)
        Me.grpTrans.Controls.Add(Me.lblTransDate)
        Me.grpTrans.Controls.Add(Me.txtPay)
        Me.grpTrans.Controls.Add(Me.txtTax)
        Me.grpTrans.Controls.Add(Me.txtDisc)
        Me.grpTrans.Controls.Add(Me.Label5)
        Me.grpTrans.Controls.Add(Me.txtRemain)
        Me.grpTrans.Controls.Add(Me.Label3)
        Me.grpTrans.Controls.Add(Me.Label4)
        Me.grpTrans.Controls.Add(Me.txtGrandTotal)
        Me.grpTrans.Controls.Add(Me.Label8)
        Me.grpTrans.Controls.Add(Me.Label6)
        Me.grpTrans.Controls.Add(Me.txtVoucherNo)
        Me.grpTrans.Controls.Add(Me.Label2)
        Me.grpTrans.Controls.Add(Me.lblActiveStatus)
        Me.grpTrans.Controls.Add(Me.ttlActiveStatus)
        Me.grpTrans.Controls.Add(Me.lblBadgeId)
        Me.grpTrans.Controls.Add(Me.ttlBadgeId)
        Me.grpTrans.Controls.Add(Me.lblName)
        Me.grpTrans.Controls.Add(Me.ttlName)
        Me.grpTrans.Controls.Add(Me.txtMembershipNo)
        Me.grpTrans.Controls.Add(Me.Label15)
        Me.grpTrans.Controls.Add(Me.lvwList)
        Me.grpTrans.Location = New System.Drawing.Point(2, 3)
        Me.grpTrans.Name = "grpTrans"
        Me.grpTrans.Size = New System.Drawing.Size(686, 389)
        Me.grpTrans.TabIndex = 77
        Me.grpTrans.TabStop = False
        '
        'txtTransDate
        '
        Me.txtTransDate.BackColor = System.Drawing.Color.White
        Me.txtTransDate.Enabled = False
        Me.txtTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransDate.ForeColor = System.Drawing.Color.Black
        Me.txtTransDate.Location = New System.Drawing.Point(448, 16)
        Me.txtTransDate.MaxLength = 50
        Me.txtTransDate.Name = "txtTransDate"
        Me.txtTransDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTransDate.Size = New System.Drawing.Size(232, 21)
        Me.txtTransDate.TabIndex = 116
        Me.txtTransDate.Text = ""
        Me.txtTransDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPOSId
        '
        Me.txtPOSId.BackColor = System.Drawing.Color.White
        Me.txtPOSId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOSId.Enabled = False
        Me.txtPOSId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSId.ForeColor = System.Drawing.Color.Black
        Me.txtPOSId.Location = New System.Drawing.Point(58, 16)
        Me.txtPOSId.MaxLength = 10
        Me.txtPOSId.Name = "txtPOSId"
        Me.txtPOSId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPOSId.Size = New System.Drawing.Size(87, 21)
        Me.txtPOSId.TabIndex = 115
        Me.txtPOSId.Text = ""
        Me.txtPOSId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "POS Id.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(336, 19)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(105, 17)
        Me.lblTransDate.TabIndex = 113
        Me.lblTransDate.Text = "Transaction Date:"
        '
        'txtPay
        '
        Me.txtPay.BackColor = System.Drawing.Color.White
        Me.txtPay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPay.Enabled = False
        Me.txtPay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(572, 338)
        Me.txtPay.MaxLength = 12
        Me.txtPay.Name = "txtPay"
        Me.txtPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPay.Size = New System.Drawing.Size(108, 21)
        Me.txtPay.TabIndex = 112
        Me.txtPay.Text = "0"
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.White
        Me.txtTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTax.Enabled = False
        Me.txtTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(640, 290)
        Me.txtTax.MaxLength = 12
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(40, 21)
        Me.txtTax.TabIndex = 111
        Me.txtTax.Text = "0"
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDisc
        '
        Me.txtDisc.BackColor = System.Drawing.Color.White
        Me.txtDisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDisc.Enabled = False
        Me.txtDisc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(640, 266)
        Me.txtDisc.MaxLength = 12
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(40, 21)
        Me.txtDisc.TabIndex = 110
        Me.txtDisc.Text = "0"
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(517, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Remain:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemain
        '
        Me.txtRemain.BackColor = System.Drawing.Color.White
        Me.txtRemain.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemain.Enabled = False
        Me.txtRemain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemain.Location = New System.Drawing.Point(572, 362)
        Me.txtRemain.MaxLength = 12
        Me.txtRemain.Name = "txtRemain"
        Me.txtRemain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRemain.Size = New System.Drawing.Size(108, 21)
        Me.txtRemain.TabIndex = 108
        Me.txtRemain.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(538, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Pay:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(492, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Grand Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.White
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(572, 314)
        Me.txtGrandTotal.MaxLength = 12
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGrandTotal.Size = New System.Drawing.Size(108, 21)
        Me.txtGrandTotal.TabIndex = 105
        Me.txtGrandTotal.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(596, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Disc.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(600, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Tax.:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.BackColor = System.Drawing.Color.White
        Me.txtVoucherNo.Enabled = False
        Me.txtVoucherNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherNo.Location = New System.Drawing.Point(112, 362)
        Me.txtVoucherNo.MaxLength = 20
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(160, 21)
        Me.txtVoucherNo.TabIndex = 94
        Me.txtVoucherNo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Voucher No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(112, 341)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(77, 17)
        Me.lblActiveStatus.TabIndex = 101
        Me.lblActiveStatus.Text = "lblActiveStatus"
        Me.lblActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttlActiveStatus
        '
        Me.ttlActiveStatus.AutoSize = True
        Me.ttlActiveStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.ttlActiveStatus.Location = New System.Drawing.Point(26, 341)
        Me.ttlActiveStatus.Name = "ttlActiveStatus"
        Me.ttlActiveStatus.Size = New System.Drawing.Size(83, 17)
        Me.ttlActiveStatus.TabIndex = 100
        Me.ttlActiveStatus.Text = "Active Status:"
        Me.ttlActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttlActiveStatus.Visible = False
        '
        'lblBadgeId
        '
        Me.lblBadgeId.AutoSize = True
        Me.lblBadgeId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadgeId.ForeColor = System.Drawing.Color.Black
        Me.lblBadgeId.Location = New System.Drawing.Point(112, 317)
        Me.lblBadgeId.Name = "lblBadgeId"
        Me.lblBadgeId.Size = New System.Drawing.Size(57, 17)
        Me.lblBadgeId.TabIndex = 99
        Me.lblBadgeId.Text = "lblBadgeId"
        Me.lblBadgeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttlBadgeId
        '
        Me.ttlBadgeId.AutoSize = True
        Me.ttlBadgeId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlBadgeId.ForeColor = System.Drawing.Color.Black
        Me.ttlBadgeId.Location = New System.Drawing.Point(49, 317)
        Me.ttlBadgeId.Name = "ttlBadgeId"
        Me.ttlBadgeId.Size = New System.Drawing.Size(63, 17)
        Me.ttlBadgeId.TabIndex = 98
        Me.ttlBadgeId.Text = "Badge Id.:"
        Me.ttlBadgeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttlBadgeId.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(112, 293)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 97
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttlName
        '
        Me.ttlName.AutoSize = True
        Me.ttlName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlName.ForeColor = System.Drawing.Color.Black
        Me.ttlName.Location = New System.Drawing.Point(71, 293)
        Me.ttlName.Name = "ttlName"
        Me.ttlName.Size = New System.Drawing.Size(41, 17)
        Me.ttlName.TabIndex = 96
        Me.ttlName.Text = "Name:"
        Me.ttlName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttlName.Visible = False
        '
        'txtMembershipNo
        '
        Me.txtMembershipNo.BackColor = System.Drawing.Color.White
        Me.txtMembershipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMembershipNo.Enabled = False
        Me.txtMembershipNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembershipNo.Location = New System.Drawing.Point(112, 266)
        Me.txtMembershipNo.MaxLength = 10
        Me.txtMembershipNo.Name = "txtMembershipNo"
        Me.txtMembershipNo.Size = New System.Drawing.Size(87, 21)
        Me.txtMembershipNo.TabIndex = 93
        Me.txtMembershipNo.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(13, 269)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 17)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Membership No.:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader6})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(4, 43)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(678, 218)
        Me.lvwList.TabIndex = 75
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 32
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item No."
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Name"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "QTY"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Disc. %"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 50
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(607, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 78
        Me.btnClose.Text = "&Close"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 106
        '
        'frmReviewTransaction01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(690, 421)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpTrans)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReviewTransaction01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Transaction Information"
        Me.grpTrans.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub FillField(ByVal adoDSHeader As DataSet, ByVal adoDSDetail As DataSet)
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim dblTotalPrice As Double

        Try
            lblName.Text = ""
            lblBadgeId.Text = ""
            lblActiveStatus.Text = ""

            adoRow = adoDSHeader.Tables("TRANS_HEADER").Rows(0)
            txtPOSId.Text = adoRow!POS_ID
            txtTransDate.Text = Format(adoRow!TRANS_DATE, "dddd, dd MMMM yyyy hh:mm tt")
            txtMembershipNo.Text = NullToString(adoRow!MEMBERSHIP_NO)
            txtVoucherNo.Text = NullToString(adoRow!VOUCHER_NO)
            txtDisc.Text = adoRow!DISC & " %"
            txtTax.Text = adoRow!TAX & " %"
            txtGrandTotal.Text = Format(adoRow!AMOUNT, "##,##0")
            txtPay.Text = Format(adoRow!PAY, "##,##0")
            txtRemain.Text = Format(adoRow!REMAIN, "##,##0")

            For Each adoRow In adoDSDetail.Tables("TRANS_DETAIL").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(Format(adoRow!PRICE, "##,##0"))
                objItem.SubItems.Add(adoRow!QTY)
                objItem.SubItems.Add(adoRow!DISC)

                dblTotalPrice = adoRow!QTY * adoRow!PRICE
                If adoRow!DISC > 0 Then
                    dblTotalPrice = dblTotalPrice - ((dblTotalPrice * adoRow!DISC) / 100)
                End If
                objItem.SubItems.Add(Format(dblTotalPrice, "##,##0"))
                objItem.Selected = True
            Next

        Catch ex As Exception
            grpTrans.Enabled = False
            Throw ex
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtMembershipNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembershipNo.TextChanged
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet
        Dim adoRow As DataRow

        Try
            svcMembership.Timeout = -1
            If Trim(txtMembershipNo.Text) <> "" Then
                adoDS = svcMembership.GetMemberInfo(txtMembershipNo.Text, "", APP_ID)
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
                    ttlName.Visible = True
                    ttlBadgeId.Visible = True
                    ttlActiveStatus.Visible = True
                    txtVoucherNo.Focus()
                Else
                    ttlName.Visible = False
                    lblName.Text = ""
                    ttlBadgeId.Visible = False
                    lblBadgeId.Text = ""
                    ttlActiveStatus.Visible = False
                    lblActiveStatus.Text = ""
                End If
                adoDS.Dispose()
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

    Private Sub frmReviewTransaction01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Application.CurrentCulture = New CultureInfo("de-DE")
    End Sub
End Class
