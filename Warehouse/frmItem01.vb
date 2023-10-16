Public Class frmItem01
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
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents cboUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMaxValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPartNo As System.Windows.Forms.TextBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents txtMinValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDiscMember As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNonMember As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpItem As System.Windows.Forms.GroupBox
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents dtpExpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBuyPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtSellPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtGrossPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtStockWrHouse As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMarkUp As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtStockShRoom As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItem01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grpItem = New System.Windows.Forms.GroupBox
        Me.txtStockShRoom = New System.Windows.Forms.NumericUpDown
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtStockWrHouse = New System.Windows.Forms.NumericUpDown
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMarkUp = New System.Windows.Forms.NumericUpDown
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtGrossPrice = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtSellPrice = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpExpDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.txtBuyPrice = New System.Windows.Forms.NumericUpDown
        Me.txtNonMember = New System.Windows.Forms.NumericUpDown
        Me.txtDiscMember = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.txtPartNo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMaxValue = New System.Windows.Forms.NumericUpDown
        Me.txtMinValue = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUnitValue = New System.Windows.Forms.NumericUpDown
        Me.cboUnits = New System.Windows.Forms.ComboBox
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.lblPosition = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpItem.SuspendLayout()
        CType(Me.txtStockShRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockWrHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrossPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuyPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNonMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(70, 401)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 29
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(6, 401)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 28
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grpItem
        '
        Me.grpItem.Controls.Add(Me.txtStockShRoom)
        Me.grpItem.Controls.Add(Me.Label16)
        Me.grpItem.Controls.Add(Me.Label24)
        Me.grpItem.Controls.Add(Me.Label23)
        Me.grpItem.Controls.Add(Me.Label22)
        Me.grpItem.Controls.Add(Me.Label21)
        Me.grpItem.Controls.Add(Me.Label20)
        Me.grpItem.Controls.Add(Me.Label19)
        Me.grpItem.Controls.Add(Me.Label18)
        Me.grpItem.Controls.Add(Me.txtStockWrHouse)
        Me.grpItem.Controls.Add(Me.Label17)
        Me.grpItem.Controls.Add(Me.txtMarkUp)
        Me.grpItem.Controls.Add(Me.Label15)
        Me.grpItem.Controls.Add(Me.txtGrossPrice)
        Me.grpItem.Controls.Add(Me.Label14)
        Me.grpItem.Controls.Add(Me.txtSellPrice)
        Me.grpItem.Controls.Add(Me.Label13)
        Me.grpItem.Controls.Add(Me.Label6)
        Me.grpItem.Controls.Add(Me.Label1)
        Me.grpItem.Controls.Add(Me.dtpExpDate)
        Me.grpItem.Controls.Add(Me.lblTransDate)
        Me.grpItem.Controls.Add(Me.txtBuyPrice)
        Me.grpItem.Controls.Add(Me.txtNonMember)
        Me.grpItem.Controls.Add(Me.txtDiscMember)
        Me.grpItem.Controls.Add(Me.Label9)
        Me.grpItem.Controls.Add(Me.txtComment)
        Me.grpItem.Controls.Add(Me.txtPartNo)
        Me.grpItem.Controls.Add(Me.Label8)
        Me.grpItem.Controls.Add(Me.txtMaxValue)
        Me.grpItem.Controls.Add(Me.txtMinValue)
        Me.grpItem.Controls.Add(Me.Label4)
        Me.grpItem.Controls.Add(Me.txtUnitValue)
        Me.grpItem.Controls.Add(Me.cboUnits)
        Me.grpItem.Controls.Add(Me.cboCategory)
        Me.grpItem.Controls.Add(Me.lblPosition)
        Me.grpItem.Controls.Add(Me.Label12)
        Me.grpItem.Controls.Add(Me.Label7)
        Me.grpItem.Controls.Add(Me.Label5)
        Me.grpItem.Controls.Add(Me.txtItemNo)
        Me.grpItem.Controls.Add(Me.txtItemName)
        Me.grpItem.Controls.Add(Me.Label3)
        Me.grpItem.Controls.Add(Me.Label2)
        Me.grpItem.Controls.Add(Me.Label10)
        Me.grpItem.Controls.Add(Me.Label11)
        Me.grpItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItem.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(1, 7)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(640, 384)
        Me.grpItem.TabIndex = 25
        Me.grpItem.TabStop = False
        Me.grpItem.Text = "Item Detail Information"
        '
        'txtStockShRoom
        '
        Me.txtStockShRoom.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtStockShRoom.Enabled = False
        Me.txtStockShRoom.Location = New System.Drawing.Point(553, 220)
        Me.txtStockShRoom.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtStockShRoom.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.txtStockShRoom.Name = "txtStockShRoom"
        Me.txtStockShRoom.Size = New System.Drawing.Size(53, 21)
        Me.txtStockShRoom.TabIndex = 15
        Me.txtStockShRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockShRoom.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(456, 222)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 17)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Show Room Stock:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(608, 114)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 16)
        Me.Label24.TabIndex = 89
        Me.Label24.Text = "Qty"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(435, 114)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 16)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "Qty"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(606, 222)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 16)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Qty"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(431, 222)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 16)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "Qty"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(607, 162)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 16)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "%"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(434, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 16)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "%"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(144, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 16)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "%"
        '
        'txtStockWrHouse
        '
        Me.txtStockWrHouse.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtStockWrHouse.Enabled = False
        Me.txtStockWrHouse.Location = New System.Drawing.Point(377, 220)
        Me.txtStockWrHouse.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtStockWrHouse.Name = "txtStockWrHouse"
        Me.txtStockWrHouse.Size = New System.Drawing.Size(53, 21)
        Me.txtStockWrHouse.TabIndex = 14
        Me.txtStockWrHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockWrHouse.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(281, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 17)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Warehouse Stock:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMarkUp
        '
        Me.txtMarkUp.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMarkUp.Enabled = False
        Me.txtMarkUp.Location = New System.Drawing.Point(96, 184)
        Me.txtMarkUp.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtMarkUp.Name = "txtMarkUp"
        Me.txtMarkUp.Size = New System.Drawing.Size(46, 21)
        Me.txtMarkUp.TabIndex = 9
        Me.txtMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMarkUp.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(36, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Mark Up:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrossPrice
        '
        Me.txtGrossPrice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtGrossPrice.Location = New System.Drawing.Point(96, 136)
        Me.txtGrossPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtGrossPrice.Name = "txtGrossPrice"
        Me.txtGrossPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtGrossPrice.TabIndex = 7
        Me.txtGrossPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(20, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 17)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Gross Price:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSellPrice
        '
        Me.txtSellPrice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSellPrice.Location = New System.Drawing.Point(96, 160)
        Me.txtSellPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtSellPrice.TabIndex = 8
        Me.txtSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(32, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Sell Price:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(620, 1)
        Me.Label6.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(620, 1)
        Me.Label1.TabIndex = 71
        '
        'dtpExpDate
        '
        Me.dtpExpDate.Checked = False
        Me.dtpExpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpDate.Location = New System.Drawing.Point(96, 220)
        Me.dtpExpDate.Name = "dtpExpDate"
        Me.dtpExpDate.ShowCheckBox = True
        Me.dtpExpDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpExpDate.TabIndex = 16
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(27, 223)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(66, 17)
        Me.lblTransDate.TabIndex = 70
        Me.lblTransDate.Text = "Expire Date:"
        '
        'txtBuyPrice
        '
        Me.txtBuyPrice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtBuyPrice.Location = New System.Drawing.Point(96, 112)
        Me.txtBuyPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtBuyPrice.Name = "txtBuyPrice"
        Me.txtBuyPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtBuyPrice.TabIndex = 6
        Me.txtBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNonMember
        '
        Me.txtNonMember.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtNonMember.Location = New System.Drawing.Point(553, 160)
        Me.txtNonMember.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtNonMember.Name = "txtNonMember"
        Me.txtNonMember.Size = New System.Drawing.Size(53, 21)
        Me.txtNonMember.TabIndex = 13
        Me.txtNonMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscMember
        '
        Me.txtDiscMember.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDiscMember.Location = New System.Drawing.Point(378, 160)
        Me.txtDiscMember.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtDiscMember.Name = "txtDiscMember"
        Me.txtDiscMember.Size = New System.Drawing.Size(53, 21)
        Me.txtDiscMember.TabIndex = 12
        Me.txtDiscMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(37, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Comment:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComment
        '
        Me.txtComment.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComment.Location = New System.Drawing.Point(95, 268)
        Me.txtComment.MaxLength = 500
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(529, 80)
        Me.txtComment.TabIndex = 18
        Me.txtComment.Text = ""
        '
        'txtPartNo
        '
        Me.txtPartNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPartNo.Location = New System.Drawing.Point(95, 244)
        Me.txtPartNo.MaxLength = 50
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.Size = New System.Drawing.Size(225, 21)
        Me.txtPartNo.TabIndex = 17
        Me.txtPartNo.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(42, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Part No.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaxValue
        '
        Me.txtMaxValue.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMaxValue.Location = New System.Drawing.Point(553, 112)
        Me.txtMaxValue.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(53, 21)
        Me.txtMaxValue.TabIndex = 11
        Me.txtMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinValue
        '
        Me.txtMinValue.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMinValue.Location = New System.Drawing.Point(379, 112)
        Me.txtMinValue.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtMinValue.Name = "txtMinValue"
        Me.txtMinValue.Size = New System.Drawing.Size(53, 21)
        Me.txtMinValue.TabIndex = 10
        Me.txtMinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Buy Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitValue
        '
        Me.txtUnitValue.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtUnitValue.Location = New System.Drawing.Point(96, 87)
        Me.txtUnitValue.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtUnitValue.Name = "txtUnitValue"
        Me.txtUnitValue.Size = New System.Drawing.Size(53, 21)
        Me.txtUnitValue.TabIndex = 4
        Me.txtUnitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboUnits
        '
        Me.cboUnits.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnits.Location = New System.Drawing.Point(150, 87)
        Me.cboUnits.Name = "cboUnits"
        Me.cboUnits.Size = New System.Drawing.Size(170, 21)
        Me.cboUnits.TabIndex = 5
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Location = New System.Drawing.Point(400, 29)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(224, 21)
        Me.cboCategory.TabIndex = 2
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(478, 114)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(74, 17)
        Me.lblPosition.TabIndex = 49
        Me.lblPosition.Text = "Max. Usage:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(308, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 17)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Min. Usage:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(55, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Units:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(343, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Category:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNo.Location = New System.Drawing.Point(96, 29)
        Me.txtItemNo.MaxLength = 20
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(112, 21)
        Me.txtItemNo.TabIndex = 1
        Me.txtItemNo.Text = ""
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(96, 53)
        Me.txtItemName.MaxLength = 200
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(528, 21)
        Me.txtItemName.TabIndex = 3
        Me.txtItemName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Item Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(457, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Disc. Non Mmbr:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(293, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Disc. Member:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(471, 395)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        '
        'frmItem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grpItem)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Detail - Edit Screen"
        Me.grpItem.ResumeLayout(False)
        CType(Me.txtStockShRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockWrHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrossPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuyPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNonMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim strCategory As String
    Dim strUnits As String
    Dim arrCategory() As String
    Dim arrUnits() As String

    Private Sub frmItem01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim adoDS As DataSet
        Dim lngRow As Long
        blnCancel = True

        Try
            adoDS = svcHouseKeeping.GetResourceCode("WAREHOUSE", "CATEGORY", APP_ID)
            If adoDS.Tables("ResourceCode").Rows.Count > 0 Then
                If cboCategory.Items.Count < 1 Then
                    ReDim arrCategory(adoDS.Tables("ResourceCode").Rows.Count - 1)
                    For lngRow = 0 To adoDS.Tables("ResourceCode").Rows.Count - 1
                        cboCategory.Items.Add(adoDS.Tables("ResourceCode").Rows(lngRow)("RESOURCE_DESC"))
                        arrCategory(lngRow) = adoDS.Tables("ResourceCode").Rows(lngRow)("RESOURCE_CODE")
                    Next lngRow
                End If
            End If
            adoDS.Dispose()

            adoDS = svcHouseKeeping.GetResourceCode("WAREHOUSE", "UNITS", APP_ID)
            If adoDS.Tables("ResourceCode").Rows.Count > 0 Then
                If cboUnits.Items.Count < 1 Then
                    ReDim arrUnits(adoDS.Tables("ResourceCode").Rows.Count - 1)
                    For lngRow = 0 To adoDS.Tables("ResourceCode").Rows.Count - 1
                        cboUnits.Items.Add(adoDS.Tables("ResourceCode").Rows(lngRow)("RESOURCE_DESC"))
                        arrUnits(lngRow) = adoDS.Tables("ResourceCode").Rows(lngRow)("RESOURCE_CODE")
                    Next lngRow
                End If
            End If
            adoDS.Dispose()

            If blnAddNew Then
                txtItemNo.Enabled = True
                dtpExpDate.Checked = False
                'dtpExpDate.Value = Now

                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                For lngRow = 0 To cboCategory.Items.Count - 1
                    If strCategory = arrCategory(lngRow) Then
                        cboCategory.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow

                For lngRow = 0 To cboUnits.Items.Count - 1
                    If strUnits = arrUnits(lngRow) Then
                        cboUnits.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow

                txtItemNo.Enabled = False
                lblTitleLast.Visible = True
            End If

        Catch ex As Exception
            grpItem.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddNew = blnAdd
    End Sub

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet()

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
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("ITEMINFORMATION")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("ITEM_NO") = txtItemNo.Text
        adoDataRow("ITEM_NAME") = txtItemName.Text
        adoDataRow("CATEGORY") = arrCategory(cboCategory.SelectedIndex)
        adoDataRow("UNITS") = arrUnits(cboUnits.SelectedIndex)
        adoDataRow("MIN_VALUE") = txtMinValue.Text
        adoDataRow("MAX_VALUE") = txtMaxValue.Text
        adoDataRow("UNIT_VALUE") = txtUnitValue.Text
        adoDataRow("BUY_PRICE") = txtBuyPrice.Text
        adoDataRow("GROSS_PRICE") = txtGrossPrice.Text
        adoDataRow("SELL_PRICE") = txtSellPrice.Text
        adoDataRow("MARK_UP") = txtMarkUp.Text
        adoDataRow("DISC_MEMBER") = txtDiscMember.Text
        adoDataRow("DISC_NON_MEMBER") = txtNonMember.Text
        adoDataRow("EXPIRE_DATE") = dtpExpDate.Value
        adoDataRow("PART_NO") = txtPartNo.Text
        adoDataRow("COMMENT") = txtComment.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoRow As DataRow
        Dim myDS As DataSet
        Dim myDR As DataRow

        Try
            If adoDS.Tables("ITEMINFO").Rows.Count > 0 Then
                adoRow = adoDS.Tables("ITEMINFO").Rows(0)
                txtItemNo.Text = adoRow!ITEM_NO
                txtItemName.Text = adoRow!ITEM_NAME
                strCategory = adoRow!CATEGORY
                strUnits = adoRow!UNITS
                txtMinValue.Text = adoRow!MIN_VALUE
                txtMaxValue.Text = adoRow!MAX_VALUE
                txtUnitValue.Text = adoRow!UNIT_VALUE
                txtBuyPrice.Text = adoRow!BUY_PRICE
                txtGrossPrice.Text = adoRow!GROSS_PRICE
                txtSellPrice.Text = adoRow!SELL_PRICE
                txtMarkUp.Text = adoRow!MARK_UP
                txtDiscMember.Text = adoRow!DISC_MEMBER
                txtNonMember.Text = adoRow!DISC_NON_MEMBER
                dtpExpDate.Checked = True
                dtpExpDate.Value = adoRow!EXPIRE_DATE
                txtPartNo.Text = adoRow!PART_NO
                txtComment.Text = NullToString(adoRow!COMMENT)
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
                If blnAddNew = False Then
                    myDS = svcWarehouse.GetStockQTY(txtItemNo.Text, APP_ID)
                    For Each myDR In myDS.Tables("STOCK_QTY").Rows
                        If myDR!WAREHOUSE = "Y" Then
                            txtStockWrHouse.Text = myDR!STOCK_QTY
                        Else
                            txtStockShRoom.Text = myDR!STOCK_QTY
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            grpItem.Enabled = False
            btnSave.Enabled = False
            Throw ex
        Finally
            myDS.Dispose()
            svcWarehouse.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call Mark_Up()
        If ValidateEmptyField(txtItemNo) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtItemName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboCategory) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboUnits) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtMaxValue) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtMinValue) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtUnitValue) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtBuyPrice) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtGrossPrice) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtSellPrice) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtMarkUp) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtDiscMember) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtNonMember) Then
            Exit Sub
        End If
        If dtpExpDate.Checked = False Then
            MessageBox.Show("Please input the Expire Date first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("ITEMINFORMATION")

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("CATEGORY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("UNITS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MIN_VALUE")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MAX_VALUE")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("UNIT_VALUE")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("BUY_PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("GROSS_PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("SELL_PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MARK_UP")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DISC_MEMBER")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DISC_NON_MEMBER")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EXPIRE_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PART_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ITEMINFORMATION").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub txtUnitValue_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnitValue.Enter
        txtUnitValue.Select(0, txtUnitValue.Text.Length)
    End Sub

    Private Sub txtSellPrice_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSellPrice.Enter
        txtSellPrice.Select(0, txtSellPrice.Text.Length)
    End Sub

    Private Sub txtMaxValue_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaxValue.Enter
        txtMaxValue.Select(0, txtMaxValue.Text.Length)
    End Sub

    Private Sub txtMinValue_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinValue.Enter
        txtMinValue.Select(0, txtMinValue.Text.Length)
    End Sub

    Private Sub txtDiscMember_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscMember.Enter
        txtDiscMember.Select(0, txtDiscMember.Text.Length)
    End Sub

    Private Sub txtNonMember_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNonMember.Enter
        txtNonMember.Select(0, txtNonMember.Text.Length)
    End Sub

    Private Sub frmItem01_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtItemNo.Focus()
    End Sub

    Private Sub Mark_Up()
        Dim dblGross As Double
        Dim dblSell As Double
        Dim dblMarkUp As Double

        If txtBuyPrice.Text = "" Then
            txtBuyPrice.Text = "0"
        End If 
        If txtGrossPrice.Text = "" Then
            txtGrossPrice.Text = "0"
        End If
        If txtSellPrice.Text = "" Then
            txtSellPrice.Text = "0"
        End If
        If txtGrossPrice.Text <> 0 Or txtSellPrice.Text <> 0 Then
            dblGross = txtGrossPrice.Text
            dblSell = txtSellPrice.Text

            dblMarkUp = (dblSell - dblGross) / dblGross
            txtMarkUp.Text = Format(dblMarkUp * 100, "#0")
        End If
    End Sub

    Private Sub txtGrossPrice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrossPrice.Enter
        txtGrossPrice.Select(0, txtGrossPrice.Text.Length)
    End Sub

    Private Sub txtBuyPrice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuyPrice.Enter
        txtBuyPrice.Select(0, txtBuyPrice.Text.Length)
    End Sub

    Private Sub txtGrossPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrossPrice.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            Call Mark_Up()
        End If
    End Sub

    Private Sub txtSellPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSellPrice.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            Call Mark_Up()
        End If
    End Sub

    Private Sub txtBuyPrice_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuyPrice.ValueChanged
        If Trim(txtBuyPrice.Text) = "" Then
            txtBuyPrice.Text = 0
        End If
    End Sub

    Private Sub txtGrossPrice_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrossPrice.ValueChanged
        If Trim(txtGrossPrice.Text) = "" Then
            txtGrossPrice.Text = 0
        End If
    End Sub

    Private Sub txtSellPrice_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSellPrice.ValueChanged
        If Trim(txtSellPrice.Text) = "" Then
            txtSellPrice.Text = 0
        End If
    End Sub

    Private Sub txtMinValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinValue.ValueChanged
        If Trim(txtMinValue.Text) = "" Then
            txtMinValue.Text = 0
        End If
    End Sub

    Private Sub txtMaxValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxValue.ValueChanged
        If Trim(txtMaxValue.Text) = "" Then
            txtMaxValue.Text = 0
        End If
    End Sub

    Private Sub txtDiscMember_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscMember.ValueChanged
        If Trim(txtDiscMember.Text) = "" Then
            txtDiscMember.Text = 0
        End If
    End Sub

    Private Sub txtNonMember_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNonMember.ValueChanged
        If Trim(txtNonMember.Text) = "" Then
            txtNonMember.Text = 0
        End If
    End Sub
End Class
