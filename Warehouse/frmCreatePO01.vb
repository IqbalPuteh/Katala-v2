Public Class frmCreatePO01
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
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPONO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents txtSupplierNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpPODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblContactPerson As System.Windows.Forms.Label
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents cboPOStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxPrice As System.Windows.Forms.TextBox
    Friend WithEvents grpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents grpHeader As System.Windows.Forms.GroupBox
    Friend WithEvents btnModifyItem As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCreatePO01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grpHeader = New System.Windows.Forms.GroupBox
        Me.cboPOStatus = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblActive = New System.Windows.Forms.Label
        Me.lblContactPerson = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpPODate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.lblSupplierName = New System.Windows.Forms.Label
        Me.txtSupplierNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPONO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpDetail = New System.Windows.Forms.GroupBox
        Me.btnModifyItem = New System.Windows.Forms.Button
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.txtTaxPrice = New System.Windows.Forms.TextBox
        Me.txtDiscPrice = New System.Windows.Forms.TextBox
        Me.txtDisc = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTax = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.grpHeader.SuspendLayout()
        Me.grpDetail.SuspendLayout()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(68, 476)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 39
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(4, 476)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 38
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.cboPOStatus)
        Me.grpHeader.Controls.Add(Me.Label7)
        Me.grpHeader.Controls.Add(Me.lblActive)
        Me.grpHeader.Controls.Add(Me.lblContactPerson)
        Me.grpHeader.Controls.Add(Me.Label3)
        Me.grpHeader.Controls.Add(Me.Label2)
        Me.grpHeader.Controls.Add(Me.dtpPODate)
        Me.grpHeader.Controls.Add(Me.lblTransDate)
        Me.grpHeader.Controls.Add(Me.lblSupplierName)
        Me.grpHeader.Controls.Add(Me.txtSupplierNo)
        Me.grpHeader.Controls.Add(Me.Label5)
        Me.grpHeader.Controls.Add(Me.txtPONO)
        Me.grpHeader.Controls.Add(Me.Label1)
        Me.grpHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHeader.ForeColor = System.Drawing.Color.Blue
        Me.grpHeader.Location = New System.Drawing.Point(1, 4)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(640, 98)
        Me.grpHeader.TabIndex = 13
        Me.grpHeader.TabStop = False
        Me.grpHeader.Text = "PO - Purchase Order Information"
        '
        'cboPOStatus
        '
        Me.cboPOStatus.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cboPOStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPOStatus.Enabled = False
        Me.cboPOStatus.Items.AddRange(New Object() {"Open", "Closed"})
        Me.cboPOStatus.Location = New System.Drawing.Point(512, 24)
        Me.cboPOStatus.Name = "cboPOStatus"
        Me.cboPOStatus.Size = New System.Drawing.Size(120, 21)
        Me.cboPOStatus.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(454, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "PO Status:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.ForeColor = System.Drawing.Color.Black
        Me.lblActive.Location = New System.Drawing.Point(514, 74)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(53, 17)
        Me.lblActive.TabIndex = 65
        Me.lblActive.Text = "lblActive"
        Me.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = True
        Me.lblContactPerson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactPerson.ForeColor = System.Drawing.Color.Black
        Me.lblContactPerson.Location = New System.Drawing.Point(108, 74)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(101, 17)
        Me.lblContactPerson.TabIndex = 64
        Me.lblContactPerson.Text = "lblContactPerson"
        Me.lblContactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(432, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Supplier Status:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Contact Person:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpPODate
        '
        Me.dtpPODate.Checked = False
        Me.dtpPODate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPODate.Location = New System.Drawing.Point(304, 24)
        Me.dtpPODate.Name = "dtpPODate"
        Me.dtpPODate.ShowCheckBox = True
        Me.dtpPODate.Size = New System.Drawing.Size(120, 21)
        Me.dtpPODate.TabIndex = 2
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(254, 27)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(49, 17)
        Me.lblTransDate.TabIndex = 60
        Me.lblTransDate.Text = "PO Date:"
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierName.ForeColor = System.Drawing.Color.Black
        Me.lblSupplierName.Location = New System.Drawing.Point(224, 51)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(98, 17)
        Me.lblSupplierName.TabIndex = 58
        Me.lblSupplierName.Text = "lblSupplierName"
        Me.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupplierNo
        '
        Me.txtSupplierNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSupplierNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplierNo.Location = New System.Drawing.Point(107, 48)
        Me.txtSupplierNo.MaxLength = 10
        Me.txtSupplierNo.Name = "txtSupplierNo"
        Me.txtSupplierNo.Size = New System.Drawing.Size(112, 21)
        Me.txtSupplierNo.TabIndex = 3
        Me.txtSupplierNo.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Supplier No.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPONO
        '
        Me.txtPONO.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPONO.Location = New System.Drawing.Point(107, 24)
        Me.txtPONO.MaxLength = 10
        Me.txtPONO.Name = "txtPONO"
        Me.txtPONO.Size = New System.Drawing.Size(112, 21)
        Me.txtPONO.TabIndex = 1
        Me.txtPONO.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(61, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "PO No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(470, 468)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(558, 468)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        '
        'grpDetail
        '
        Me.grpDetail.Controls.Add(Me.btnModifyItem)
        Me.grpDetail.Controls.Add(Me.txtGrandTotal)
        Me.grpDetail.Controls.Add(Me.txtTaxPrice)
        Me.grpDetail.Controls.Add(Me.txtDiscPrice)
        Me.grpDetail.Controls.Add(Me.txtDisc)
        Me.grpDetail.Controls.Add(Me.Label11)
        Me.grpDetail.Controls.Add(Me.txtTotalPrice)
        Me.grpDetail.Controls.Add(Me.Label10)
        Me.grpDetail.Controls.Add(Me.Label9)
        Me.grpDetail.Controls.Add(Me.Label8)
        Me.grpDetail.Controls.Add(Me.txtTax)
        Me.grpDetail.Controls.Add(Me.Label6)
        Me.grpDetail.Controls.Add(Me.Label4)
        Me.grpDetail.Controls.Add(Me.btnDeleteItem)
        Me.grpDetail.Controls.Add(Me.btnAddItem)
        Me.grpDetail.Controls.Add(Me.lvwList)
        Me.grpDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetail.ForeColor = System.Drawing.Color.Blue
        Me.grpDetail.Location = New System.Drawing.Point(1, 102)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(640, 362)
        Me.grpDetail.TabIndex = 14
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Item Detail Information"
        '
        'btnModifyItem
        '
        Me.btnModifyItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyItem.ForeColor = System.Drawing.Color.Black
        Me.btnModifyItem.Location = New System.Drawing.Point(88, 260)
        Me.btnModifyItem.Name = "btnModifyItem"
        Me.btnModifyItem.Size = New System.Drawing.Size(80, 24)
        Me.btnModifyItem.TabIndex = 7
        Me.btnModifyItem.Text = "&Modify Item"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Location = New System.Drawing.Point(532, 331)
        Me.txtGrandTotal.MaxLength = 10
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGrandTotal.Size = New System.Drawing.Size(104, 21)
        Me.txtGrandTotal.TabIndex = 71
        Me.txtGrandTotal.Text = "0"
        '
        'txtTaxPrice
        '
        Me.txtTaxPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTaxPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTaxPrice.Enabled = False
        Me.txtTaxPrice.Location = New System.Drawing.Point(532, 308)
        Me.txtTaxPrice.MaxLength = 10
        Me.txtTaxPrice.Name = "txtTaxPrice"
        Me.txtTaxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxPrice.Size = New System.Drawing.Size(104, 21)
        Me.txtTaxPrice.TabIndex = 70
        Me.txtTaxPrice.Text = "0"
        '
        'txtDiscPrice
        '
        Me.txtDiscPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtDiscPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscPrice.Enabled = False
        Me.txtDiscPrice.Location = New System.Drawing.Point(532, 285)
        Me.txtDiscPrice.MaxLength = 10
        Me.txtDiscPrice.Name = "txtDiscPrice"
        Me.txtDiscPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDiscPrice.Size = New System.Drawing.Size(104, 21)
        Me.txtDiscPrice.TabIndex = 69
        Me.txtDiscPrice.Text = "0"
        '
        'txtDisc
        '
        Me.txtDisc.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDisc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(446, 285)
        Me.txtDisc.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(56, 21)
        Me.txtDisc.TabIndex = 9
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(503, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "%  +"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTotalPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(532, 261)
        Me.txtTotalPrice.MaxLength = 10
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalPrice.Size = New System.Drawing.Size(104, 21)
        Me.txtTotalPrice.TabIndex = 65
        Me.txtTotalPrice.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(470, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Total Price:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(503, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "%   -"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(413, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Disc.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(446, 308)
        Me.txtTax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(56, 21)
        Me.txtTax.TabIndex = 10
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(419, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 17)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Tax:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(464, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Grand Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteItem.Location = New System.Drawing.Point(171, 260)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(80, 24)
        Me.btnDeleteItem.TabIndex = 8
        Me.btnDeleteItem.Text = "&Delete Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.Black
        Me.btnAddItem.Location = New System.Drawing.Point(4, 260)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(80, 24)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "&Add Item"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader6})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 16)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(634, 240)
        Me.lvwList.TabIndex = 5
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item No."
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Name"
        Me.ColumnHeader4.Width = 240
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "QTY"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 47
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 100
        '
        'frmCreatePO01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 496)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grpHeader)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreatePO01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PO - Purchase Order - Edit Screen"
        Me.grpHeader.ResumeLayout(False)
        Me.grpDetail.ResumeLayout(False)
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim adoDsSupplier As DataSet
    Dim adoDSItem As DataSet

    Private Sub frmCreatePO01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()

        Try
            blnCancel = True
            adoDsSupplier = svcWarehouse.GetSupplierLOV("", APP_ID)

            If blnAddNew Then
                txtPONO.Text = svcWarehouse.GetMaxPOId(APP_ID)
                txtPONO.Enabled = False
                lblSupplierName.Text = ""
                lblContactPerson.Text = ""
                lblActive.Text = ""
                cboPOStatus.SelectedIndex = 0
                cboPOStatus.Enabled = False
                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                If cboPOStatus.SelectedIndex = 1 Then
                    grpHeader.Enabled = False
                    btnAddItem.Enabled = False
                    btnModifyItem.Enabled = False
                    btnDeleteItem.Enabled = False
                    txtDisc.Enabled = False
                    txtTax.Enabled = False
                    btnSave.Enabled = False
                End If
                txtPONO.Enabled = False
                lblTitleLast.Visible = True
            End If

        Catch ex As Exception
            grpHeader.Enabled = False
            grpDetail.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddNew = blnAdd
    End Sub

    Public Function GetDataSet01() As DataSet
        Dim myDSHeader As New DataSet()

        Try
            myDSHeader = CreateResourceCodeRs01()

            FillDataSet01(myDSHeader)
            GetDataSet01 = myDSHeader
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDataSet02() As DataSet
        Dim myDSDetail As New DataSet()

        Try
            myDSDetail = CreateResourceCodeRs02()

            FillDataSet02(myDSDetail)
            GetDataSet02 = myDSDetail
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FillDataSet01(ByRef adoDSHeader As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        Try
            adoDataTable = adoDSHeader.Tables("PO_HEADER")
            adoDataRow = adoDataTable.NewRow()
            adoDataRow("PO_NO") = txtPONO.Text
            adoDataRow("PO_DATE") = dtpPODate.Value
            adoDataRow("SUPPLIER_NO") = txtSupplierNo.Text
            If cboPOStatus.SelectedIndex = 0 Then
                adoDataRow("PO_STATUS") = "O"
            Else
                adoDataRow("PO_STATUS") = "C"
            End If
            adoDataRow("DISCOUNT") = txtDisc.Text
            adoDataRow("TAX") = txtTax.Text
            adoDataRow("CREATED_BY") = USER_ID
            adoDataRow("REVIEWED_BY") = USER_ID
            adoDataTable.Rows.Add(adoDataRow)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub FillDataSet02(ByRef adoDSDetail As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()
        Dim I As Long

        Try
            adoDataTable = adoDSDetail.Tables("PO_DETAIL")
            For I = 0 To lvwList.Items.Count - 1
                adoDataRow = adoDataTable.NewRow()

                adoDataRow("PO_NO") = txtPONO.Text
                adoDataRow("ITEM_NO") = lvwList.Items(I).SubItems(1).Text
                adoDataRow("QTY") = lvwList.Items(I).SubItems(3).Text
                adoDataRow("PRICE") = lvwList.Items(I).SubItems(4).Text
                adoDataRow("TOTAL_PRICE") = lvwList.Items(I).SubItems(5).Text
                adoDataTable.Rows.Add(adoDataRow)
            Next
            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 225
            Else
                lvwList.Columns(2).Width = 240
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()

        If Not (adoDsSupplier Is Nothing) Then
            adoDsSupplier.Dispose()
            adoDsSupplier = Nothing
        End If
        If Not (adoDSItem Is Nothing) Then
            adoDSItem.Dispose()
            adoDSItem = Nothing
        End If
    End Sub

    Public Sub FillField(ByVal adoDSHeader As DataSet, ByVal adoDSDetail As DataSet)
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim adoDS As DataSet
        Dim intTotalPrice As Integer

        Try
            If adoDSHeader.Tables("POINFORMATION").Rows.Count > 0 Then
                adoRow = adoDSHeader.Tables("POINFORMATION").Rows(0)
                txtPONO.Text = adoRow!PO_NO
                dtpPODate.Checked = True
                dtpPODate.Value = adoRow!PO_DATE
                txtSupplierNo.Text = adoRow!SUPPLIER_NO
                txtDisc.Text = adoRow!DISCOUNT
                txtTax.Text = adoRow!TAX
                If adoRow!PO_STATUS = "O" Then
                    cboPOStatus.SelectedIndex = 0
                Else
                    cboPOStatus.SelectedIndex = 1
                End If
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")

                If txtSupplierNo.Text <> "" Then
                    adoDS = svcWarehouse.GetSupplierLOV(txtSupplierNo.Text, APP_ID)
                    If adoDS.Tables("SUPPLIERLOV").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("SUPPLIERLOV").Rows(0)
                        lblSupplierName.Text = adoRow!SUPPLIER_NAME
                        lblContactPerson.Text = adoRow!CONTACT_PERSON
                        If adoRow!ACTIVE_STATUS = "Y" Then
                            lblActive.Text = "Active"
                        Else
                            lblActive.Text = "Not Active"
                        End If
                    End If
                    adoDS.Dispose()
                End If
            End If

            For Each adoRow In adoDSDetail.Tables("POINFORMATION").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)

                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(adoRow!QTY)
                objItem.SubItems.Add(Format(adoRow!PRICE, "##0"))
                objItem.SubItems.Add(Format(adoRow!TOTAL_PRICE, "##0"))
                intTotalPrice = txtTotalPrice.Text
                txtTotalPrice.Text = Format(intTotalPrice + adoRow!TOTAL_PRICE, "##0")
                objItem.Selected = True
            Next
            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 225
            Else
                lvwList.Columns(2).Width = 240
            End If

        Catch ex As Exception
            grpHeader.Enabled = False
            grpDetail.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtPONO) Then
            Exit Sub
        End If
        If dtpPODate.Checked = False Then
            MessageBox.Show("Please fill the registry date first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ValidateEmptyField(txtSupplierNo) Then
            Exit Sub
        End If
        If lvwList.Items.Count < 1 Then
            MessageBox.Show("Please input the item first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateResourceCodeRs01() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("PO_HEADER")

        adoColumn = New DataColumn("PO_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PO_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("SUPPLIER_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PO_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DISCOUNT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TAX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("CREATED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_HEADER").Columns.Add(adoColumn)

        CreateResourceCodeRs01 = adoDS
    End Function

    Private Function CreateResourceCodeRs02() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("PO_DETAIL")

        adoColumn = New DataColumn("PO_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TOTAL_PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("PO_DETAIL").Columns.Add(adoColumn)

        CreateResourceCodeRs02 = adoDS
    End Function

    Private Sub txtSupplierNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplierNo.TextChanged
        lblSupplierName.Text = ""
        lblContactPerson.Text = ""
        lblActive.Text = ""
    End Sub

    Private Sub txtSupplierNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSupplierNo.KeyDown
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmLOV()
        Dim adoRow As DataRow

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                myForm.Initialize(txtSupplierNo.Text, adoDsSupplier, "SUPPLIERLOV")

Form_Loop:
                myForm.ShowDialog()
                If myForm.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDS = myForm.GetDataSet()
                    If adoDS.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("RESOURCEINFO").Rows(0)
                        txtSupplierNo.Text = adoRow!RESOURCE_CODE
                        lblSupplierName.Text = adoRow!RESOURCE_DESC
                        adoDS.Dispose()

                        If Trim(txtSupplierNo.Text) <> "" And lblSupplierName.Text <> "" Then
                            adoDS = svcWarehouse.GetSupplierLOV(txtSupplierNo.Text, APP_ID)
                            If adoDS.Tables("SUPPLIERLOV").Rows.Count > 0 Then
                                adoRow = adoDS.Tables("SUPPLIERLOV").Rows(0)
                                lblContactPerson.Text = adoRow!CONTACT_PERSON
                                If adoRow!ACTIVE_STATUS = "Y" Then
                                    lblActive.Text = "Active"
                                Else
                                    lblActive.Text = "Not Active"
                                End If
                            End If
                            adoDS.Dispose()
                        End If
                    End If
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
                myForm = Nothing
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtSupplierNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierNo.DoubleClick
        txtSupplierNo_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim intTotalPrice As Long
        Dim myForm As New frmCreatePO02()
        Dim adoRow As DataRow
        Dim blnExist As Boolean
        Dim I As Integer

        Try
            myForm.Initialize(True)
            myForm.Add(txtPONO.Text)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                If adoDS.Tables("INPUTITEM").Rows.Count > 0 Then
                    adoRow = adoDS.Tables("INPUTITEM").Rows(0)
                    blnExist = False

                    If lvwList.Items.Count > 0 Then
                        For I = 0 To lvwList.Items.Count - 1
                            If Trim(lvwList.Items(I).SubItems(1).Text) = Trim(adoRow!ITEM_NO) Then
                                blnExist = True
                                Exit For
                            End If
                        Next
                    End If

                    If blnExist Then
                        MessageBox.Show("The Item No. already exist, Please change the Item No.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GoTo Form_Loop
                    End If

                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!ITEM_NO)
                    objItem.SubItems.Add(adoRow!ITEM_NAME)
                    objItem.SubItems.Add(adoRow!ITEM_QTY)
                    objItem.SubItems.Add(adoRow!ITEM_PRICE)
                    objItem.SubItems.Add(adoRow!ITEM_TOTALPRICE)
                    intTotalPrice = txtTotalPrice.Text
                    txtTotalPrice.Text = intTotalPrice + adoRow!ITEM_TOTALPRICE
                    objItem.Selected = True
                End If

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                End If
                If lvwList.Items.Count > 14 Then
                    lvwList.Columns(2).Width = 225
                Else
                    lvwList.Columns(2).Width = 240
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
                myForm = Nothing
            End If
        End Try
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        Dim intSelectedItem As Integer
        Dim intCount As Integer
        Dim I As Integer
        Dim dblTotalPrice As Double
        Dim myDS As DataSet
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim strItemNo As String
        Dim adoRow As DataRow

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            strItemNo = lvwList.SelectedItems.Item(0).SubItems(1).Text
            myDS = svcWarehouse.GetRptRecieveQTY(strItemNo, txtPONO.Text, APP_ID)
            For Each adoRow In myDS.Tables("RECIEVE_QTY").Rows
                If adoRow!RECIEVE_QTY <> 0 Then
                    MessageBox.Show("Data can Not be delete because already recieved. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intSelectedItem = lvwList.SelectedItems.Item(0).Index
            lvwList.SelectedItems.Item(0).Remove()

            For intCount = 0 To lvwList.Items.Count - 1
                lvwList.Items(intCount).Text = intCount + 1
            Next

            If lvwList.Items.Count > 0 Then
                If (intSelectedItem) < lvwList.Items.Count Then
                    lvwList.Items(intSelectedItem).Selected = True
                Else
                    If (intSelectedItem) = lvwList.Items.Count Then
                        lvwList.Items(intSelectedItem - 1).Selected = True
                    End If
                End If
            End If

            For I = 0 To lvwList.Items.Count - 1
                dblTotalPrice = dblTotalPrice + lvwList.Items(I).SubItems(5).Text
            Next
            txtTotalPrice.Text = dblTotalPrice

            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 225
            Else
                lvwList.Columns(2).Width = 240
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
                myDS = Nothing
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

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
        Dim dblTotalPrice As Double
        Dim dblDisc As Double
        Dim dblDiscPrice As Double
        Dim dblTax As Double
        Dim dblTaxPrice As Double
        Dim dblGrandTotal As Double

        Try
            dblTotalPrice = ValidateEmpty(txtTotalPrice.Text)
            dblDisc = txtDisc.Text
            dblDiscPrice = ValidateEmpty(txtDiscPrice.Text)
            dblTax = txtTax.Text
            dblTaxPrice = ValidateEmpty(txtTaxPrice.Text)
            dblGrandTotal = ValidateEmpty(txtGrandTotal.Text)

            'Count Discount
            If dblDisc > 0 Then
                dblDiscPrice = (dblDisc * dblTotalPrice) / 100
                txtDiscPrice.Text = Format(dblDiscPrice, "##,##0")
            End If

            'Count Tax
            If dblTax > 0 Then
                dblTotalPrice = dblTotalPrice - dblDiscPrice
                dblTaxPrice = (dblTax * dblTotalPrice) / 100
                txtTaxPrice.Text = Format(dblTaxPrice, "##,##0")
            End If

            'Count Grand Total
            dblTotalPrice = ValidateEmpty(txtTotalPrice.Text)
            dblDiscPrice = ValidateEmpty(txtDiscPrice.Text)
            dblTaxPrice = ValidateEmpty(txtTaxPrice.Text)
            dblGrandTotal = ((dblTotalPrice - dblDiscPrice) + dblTaxPrice)
            txtGrandTotal.Text = Format(dblGrandTotal, "##,##0")

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtDisc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc.Enter
        txtDisc.Select(0, txtDisc.Text.Length)
    End Sub

    Private Sub txtTax_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTax.Enter
        txtTax.Select(0, txtTax.Text.Length)
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If cboPOStatus.SelectedIndex <> 1 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModifyitem_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnModifyItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyItem.Click
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim intTotalPrice As Double
        Dim myForm As New frmCreatePO02
        Dim adoRow As DataRow
        Dim strItemNo As String
        Dim strItemName As String
        Dim strItemQTY As String
        Dim strItemPrice As String
        Dim strItemTotalPrice As String
        Dim intItemTotalPrice As Double
        Dim I As Integer
        Dim myDS As DataSet
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim intRecieve As Integer

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialize(False)
            myForm.Add(txtPONO.Text)
            strItemNo = lvwList.SelectedItems.Item(0).SubItems(1).Text
            strItemName = lvwList.SelectedItems.Item(0).SubItems(2).Text
            strItemQTY = lvwList.SelectedItems.Item(0).SubItems(3).Text
            strItemPrice = lvwList.SelectedItems.Item(0).SubItems(4).Text
            strItemTotalPrice = lvwList.SelectedItems.Item(0).SubItems(5).Text
            myDS = svcWarehouse.GetRptRecieveQTY(strItemNo, txtPONO.Text, APP_ID)
            intRecieve = 0
            For Each adoRow In myDS.Tables("RECIEVE_QTY").Rows
                intRecieve = adoRow!RECIEVE_QTY
            Next
            myForm.Modify(strItemNo, strItemName, strItemQTY, strItemPrice, strItemTotalPrice, intRecieve)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                If adoDS.Tables("INPUTITEM").Rows.Count > 0 Then
                    adoRow = adoDS.Tables("INPUTITEM").Rows(0)
                    lvwList.SelectedItems.Item(0).SubItems(3).Text = adoRow!ITEM_QTY
                    lvwList.SelectedItems.Item(0).SubItems(4).Text = adoRow!ITEM_PRICE
                    lvwList.SelectedItems.Item(0).SubItems(5).Text = adoRow!ITEM_TOTALPRICE
                    For I = 0 To lvwList.Items.Count - 1
                        intItemTotalPrice = lvwList.Items(I).SubItems(5).Text
                        intTotalPrice = intTotalPrice + intItemTotalPrice
                    Next
                    txtTotalPrice.Text = intTotalPrice
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
                myForm = Nothing
            End If
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
                myDS = Nothing
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        If cboPOStatus.SelectedIndex <> 1 Then
            btnModifyItem_Click(sender, e)
        End If
    End Sub
End Class
