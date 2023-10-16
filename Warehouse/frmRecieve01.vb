Public Class frmRecieve01
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
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblContactPerson As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpPODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents txtSupplierNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPONO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpRecieveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboPOStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpPO As System.Windows.Forms.GroupBox
    Friend WithEvents grpItem As System.Windows.Forms.GroupBox
    Friend WithEvents grpRecieve As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecieve01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grpPO = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboPOStatus = New System.Windows.Forms.ComboBox
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
        Me.grpItem = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.grpRecieve = New System.Windows.Forms.GroupBox
        Me.dtpRecieveDate = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboWarehouse = New System.Windows.Forms.ComboBox
        Me.grpPO.SuspendLayout()
        Me.grpItem.SuspendLayout()
        Me.grpRecieve.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(70, 448)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 45
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(6, 448)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 44
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grpPO
        '
        Me.grpPO.Controls.Add(Me.Label9)
        Me.grpPO.Controls.Add(Me.cboPOStatus)
        Me.grpPO.Controls.Add(Me.lblActive)
        Me.grpPO.Controls.Add(Me.lblContactPerson)
        Me.grpPO.Controls.Add(Me.Label3)
        Me.grpPO.Controls.Add(Me.Label2)
        Me.grpPO.Controls.Add(Me.dtpPODate)
        Me.grpPO.Controls.Add(Me.lblTransDate)
        Me.grpPO.Controls.Add(Me.lblSupplierName)
        Me.grpPO.Controls.Add(Me.txtSupplierNo)
        Me.grpPO.Controls.Add(Me.Label5)
        Me.grpPO.Controls.Add(Me.txtPONO)
        Me.grpPO.Controls.Add(Me.Label1)
        Me.grpPO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPO.ForeColor = System.Drawing.Color.Blue
        Me.grpPO.Location = New System.Drawing.Point(2, 5)
        Me.grpPO.Name = "grpPO"
        Me.grpPO.Size = New System.Drawing.Size(735, 115)
        Me.grpPO.TabIndex = 8
        Me.grpPO.TabStop = False
        Me.grpPO.Text = "PO - Purchase Order Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(557, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "PO Status:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPOStatus
        '
        Me.cboPOStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboPOStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPOStatus.Items.AddRange(New Object() {"Open", "Closed"})
        Me.cboPOStatus.Location = New System.Drawing.Point(616, 24)
        Me.cboPOStatus.Name = "cboPOStatus"
        Me.cboPOStatus.Size = New System.Drawing.Size(104, 21)
        Me.cboPOStatus.TabIndex = 2
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.ForeColor = System.Drawing.Color.Black
        Me.lblActive.Location = New System.Drawing.Point(107, 93)
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
        Me.lblContactPerson.Location = New System.Drawing.Point(107, 74)
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
        Me.Label3.Location = New System.Drawing.Point(23, 93)
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
        Me.Label2.Location = New System.Drawing.Point(20, 74)
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
        Me.dtpPODate.Location = New System.Drawing.Point(616, 48)
        Me.dtpPODate.Name = "dtpPODate"
        Me.dtpPODate.Size = New System.Drawing.Size(104, 21)
        Me.dtpPODate.TabIndex = 12
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(562, 51)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(53, 17)
        Me.lblTransDate.TabIndex = 60
        Me.lblTransDate.Text = "PO Date :"
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierName.ForeColor = System.Drawing.Color.Black
        Me.lblSupplierName.Location = New System.Drawing.Point(223, 51)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(98, 17)
        Me.lblSupplierName.TabIndex = 58
        Me.lblSupplierName.Text = "lblSupplierName"
        Me.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupplierNo
        '
        Me.txtSupplierNo.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtSupplierNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplierNo.Enabled = False
        Me.txtSupplierNo.Location = New System.Drawing.Point(107, 48)
        Me.txtSupplierNo.MaxLength = 10
        Me.txtSupplierNo.Name = "txtSupplierNo"
        Me.txtSupplierNo.Size = New System.Drawing.Size(112, 21)
        Me.txtSupplierNo.TabIndex = 11
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
        Me.btnSave.Location = New System.Drawing.Point(567, 444)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(655, 444)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'grpItem
        '
        Me.grpItem.Controls.Add(Me.lvwList)
        Me.grpItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItem.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(2, 180)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(735, 257)
        Me.grpItem.TabIndex = 10
        Me.grpItem.TabStop = False
        Me.grpItem.Text = "Item Detail Information"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(1, 20)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(732, 232)
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
        Me.ColumnHeader4.Width = 225
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Order QTY"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Total Recive"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Outstanding QTY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 115
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Recieve QTY"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 90
        '
        'grpRecieve
        '
        Me.grpRecieve.Controls.Add(Me.dtpRecieveDate)
        Me.grpRecieve.Controls.Add(Me.Label15)
        Me.grpRecieve.Controls.Add(Me.Label16)
        Me.grpRecieve.Controls.Add(Me.cboWarehouse)
        Me.grpRecieve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRecieve.ForeColor = System.Drawing.Color.Blue
        Me.grpRecieve.Location = New System.Drawing.Point(2, 124)
        Me.grpRecieve.Name = "grpRecieve"
        Me.grpRecieve.Size = New System.Drawing.Size(735, 56)
        Me.grpRecieve.TabIndex = 9
        Me.grpRecieve.TabStop = False
        Me.grpRecieve.Text = "Recieve Information"
        '
        'dtpRecieveDate
        '
        Me.dtpRecieveDate.Checked = False
        Me.dtpRecieveDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpRecieveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRecieveDate.Location = New System.Drawing.Point(106, 24)
        Me.dtpRecieveDate.Name = "dtpRecieveDate"
        Me.dtpRecieveDate.ShowCheckBox = True
        Me.dtpRecieveDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpRecieveDate.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(31, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 17)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Recieve Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(400, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 17)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "Warehouse Recieve :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboWarehouse
        '
        Me.cboWarehouse.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarehouse.Location = New System.Drawing.Point(512, 24)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(208, 21)
        Me.cboWarehouse.TabIndex = 4
        '
        'frmRecieve01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(738, 472)
        Me.Controls.Add(Me.grpRecieve)
        Me.Controls.Add(Me.grpItem)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grpPO)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecieve01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recieve Detail - Edit Screen"
        Me.grpPO.ResumeLayout(False)
        Me.grpItem.ResumeLayout(False)
        Me.grpRecieve.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim adoDsSupplier As DataSet
    Dim adoDSItem As DataSet
    Dim arrWarehouseId() As String
    Dim strWarehouseId As String
    Dim lngRecId As Long
    Dim blnCount As Integer
    Dim blnModify As Boolean
    Dim adoDsPO As DataSet

    Private Sub frmCreatePO01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim AdoDS As DataSet
        Dim AdoRow As DataRow
        Dim I As Long

        Try
            blnCancel = True
            blnCount = 1
            dtpPODate.Enabled = False

            AdoDS = svcHouseKeeping.GetWarehouse("Y", APP_ID)
            If AdoDS.Tables(0).Rows.Count = 0 Then
                Close()
            End If

            ReDim arrWarehouseId(AdoDS.Tables("WAREHOUSE").Rows.Count - 1)
            I = 0
            For Each AdoRow In AdoDS.Tables(0).Rows
                cboWarehouse.Items.Add(AdoRow!RESOURCE_DESC)
                arrWarehouseId(I) = AdoRow!RESOURCE_CODE
                I = I + 1
            Next

            If blnAddNew Then
                adoDsPO = svcWarehouse.GetPOLOV("", APP_ID)
                txtPONO.Enabled = True
                lblSupplierName.Text = ""
                lblContactPerson.Text = ""
                lblActive.Text = ""
                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                txtPONO.Enabled = False
                I = 0
                For I = 0 To cboWarehouse.Items.Count - 1
                    If arrWarehouseId(I) = strWarehouseId Then
                        cboWarehouse.SelectedIndex = I
                        Exit For
                    End If
                Next
                lblTitleLast.Visible = True
            End If
            If cboPOStatus.SelectedIndex = 1 Then
                grpPO.Enabled = False
                grpRecieve.Enabled = False
                btnSave.Enabled = False
            End If

        Catch ex As Exception
            grpPO.Enabled = False
            grpRecieve.Enabled = False
            grpItem.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (AdoDS Is Nothing) Then
                AdoDS.Dispose()
            End If
            If Not (svcHouseKeeping Is Nothing) Then
                svcHouseKeeping.Dispose()
            End If
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
            adoDataTable = adoDSHeader.Tables("RECIEVE_HEADER")
            adoDataRow = adoDataTable.NewRow()

            If blnAddNew = False Then
                adoDataRow("REC_ID") = lngRecId
            End If
            adoDataRow("PO_NO") = txtPONO.Text
            If cboPOStatus.SelectedIndex = 0 Then
                adoDataRow("PO_STATUS") = "O"
            Else
                adoDataRow("PO_STATUS") = "C"
            End If
            adoDataRow("RECIEVE_BY") = USER_ID
            adoDataRow("RECIEVE_DATE") = dtpRecieveDate.Value
            adoDataRow("WAREHOUSE_ID") = arrWarehouseId(cboWarehouse.SelectedIndex)
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
            adoDataTable = adoDSDetail.Tables("RECIEVE_DETAIL")
            For I = 0 To lvwList.Items.Count - 1
                adoDataRow = adoDataTable.NewRow()

                If blnAddNew = False Then
                    adoDataRow("REC_ID") = lngRecId
                    adoDataRow("PO_NO") = txtPONO.Text
                End If
                adoDataRow("ITEM_NO") = lvwList.Items(I).SubItems(1).Text
                adoDataRow("OUTSTANDING_QTY") = lvwList.Items(I).SubItems(5).Text
                adoDataRow("RECIEVE_QTY") = lvwList.Items(I).SubItems(6).Text
                adoDataTable.Rows.Add(adoDataRow)
            Next
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
    End Sub

    Public Sub FillField(ByVal adoDSHeader As DataSet, ByVal adoDSDetail As DataSet)
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim objItem As ListViewItem
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim lngMaxRecId As Long
        Dim lngOrder As Long
        Dim lngTotalRecieve As Long
        Dim lngOutstanding As Long

        Try
            If adoDSHeader.Tables("RECIEVEHEADER").Rows.Count > 0 Then
                blnModify = True

                adoRow = adoDSHeader.Tables("RECIEVEHEADER").Rows(0)
                txtPONO.Text = adoRow!PO_NO
                dtpPODate.Checked = True
                dtpPODate.Value = adoRow!PO_DATE
                txtSupplierNo.Text = adoRow!SUPPLIER_NO
                If adoRow!PO_STATUS = "O" Then
                    cboPOStatus.SelectedIndex = 0
                Else
                    cboPOStatus.SelectedIndex = 1
                End If
                dtpRecieveDate.Checked = True
                dtpRecieveDate.Value = adoRow!RECIEVE_DATE
                strWarehouseId = adoRow!WAREHOUSE_ID

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

            lngRecId = adoDSDetail.Tables("RECIEVEDETAIL").Rows(0)("REC_ID")

            adoDS = svcWarehouse.GetMaxRecId(txtPONO.Text, APP_ID)
            If adoDS.Tables("MAX_RECID").Rows.Count > 0 Then
                lngMaxRecId = adoDS.Tables("MAX_RECID").Rows(0)("MAX_REC_ID")
            Else
                lngMaxRecId = 0
            End If
            adoDS.Dispose()

            For Each adoRow In adoDSDetail.Tables("RECIEVEDETAIL").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)

                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(adoRow!QTY)
                lngOrder = adoRow!QTY

                If lngRecId = lngMaxRecId Then
                    adoDS = svcWarehouse.GetTotalRecieve(txtPONO.Text, adoRow!ITEM_NO, APP_ID)
                    If IsDBNull(adoDS.Tables("TOTALRECIEVE").Rows(0)("TOTAL_RECIEVE_QTY")) Then
                        lngTotalRecieve = 0
                    Else
                        lngTotalRecieve = adoDS.Tables("TOTALRECIEVE").Rows(0)("TOTAL_RECIEVE_QTY")
                    End If
                    lngOutstanding = lngOrder - lngTotalRecieve

                    objItem.SubItems.Add(lngTotalRecieve)
                    If lngOutstanding > 0 Then
                        objItem.SubItems.Add(lngOutstanding)
                    Else
                        objItem.SubItems.Add("0")
                    End If
                    adoDS.Dispose()
                Else
                    objItem.SubItems.Add("0")
                    objItem.SubItems.Add("0")
                End If
                objItem.SubItems.Add(adoRow!RECIEVE_QTY)
            Next
            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 210
            Else
                lvwList.Columns(2).Width = 225
            End If

            If lngRecId = lngMaxRecId Then
                grpPO.Enabled = True
                grpRecieve.Enabled = True
                grpItem.Enabled = True
                btnSave.Enabled = True
            Else
                grpPO.Enabled = False
                grpRecieve.Enabled = False
                btnSave.Enabled = False
            End If

        Catch ex As Exception
            grpPO.Enabled = False
            grpRecieve.Enabled = False
            grpItem.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Public Sub Recieve(ByVal adoDSHeader As DataSet)
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim objItem As ListViewItem
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim adoDSDetail As New DataSet()
        Dim lngOrder As Long
        Dim lngTotalRecieve As Long
        Dim lngOutstanding As Long

        Try
            If adoDSHeader.Tables("POINFORMATION").Rows.Count > 0 Then
                blnModify = False

                adoRow = adoDSHeader.Tables("POINFORMATION").Rows(0)
                txtPONO.Text = adoRow!PO_NO
                dtpPODate.Checked = True
                dtpPODate.Value = adoRow!PO_DATE
                txtSupplierNo.Text = adoRow!SUPPLIER_NO
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

            adoDSDetail = svcWarehouse.GetPODetailInfo(txtPONO.Text, "", APP_ID)
            For Each adoRow In adoDSDetail.Tables("POINFORMATION").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)

                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(adoRow!QTY)
                lngOrder = adoRow!QTY

                adoDS = svcWarehouse.GetTotalRecieve(txtPONO.Text, adoRow!ITEM_NO, APP_ID)
                If IsDBNull(adoDS.Tables("TOTALRECIEVE").Rows(0)("TOTAL_RECIEVE_QTY")) Then
                    lngTotalRecieve = 0
                Else
                    lngTotalRecieve = adoDS.Tables("TOTALRECIEVE").Rows(0)("TOTAL_RECIEVE_QTY")
                End If
                lngOutstanding = lngOrder - lngTotalRecieve

                objItem.SubItems.Add(lngTotalRecieve)
                If lngOutstanding > 0 Then
                    objItem.SubItems.Add(lngOutstanding)
                Else
                    objItem.SubItems.Add("0")
                End If
                objItem.SubItems.Add("0")
                adoDS.Dispose()
            Next
            adoDSDetail.Dispose()
            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 210
            Else
                lvwList.Columns(2).Width = 225
            End If


        Catch ex As Exception
            grpPO.Enabled = False
            grpRecieve.Enabled = False
            grpItem.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            If Not (adoDSDetail Is Nothing) Then
                adoDSDetail.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim I As Integer
        Dim intTotal As Integer
        Dim intRecieve As Integer
        Dim intOrder As Integer

        If ValidateEmptyField(txtPONO) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtSupplierNo) Then
            Exit Sub
        End If
        If ValidateEmptyField(lblSupplierName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboPOStatus) Then
            Exit Sub
        End If
        If dtpRecieveDate.Checked = False Then
            MessageBox.Show("Please fill the recieve date first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ValidateEmptyField(cboWarehouse) Then
            Exit Sub
        End If
        If lvwList.Items.Count < 1 Then
            MessageBox.Show("Please input the item first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If cboPOStatus.SelectedIndex = 1 Then
            If lvwList.Items.Count > 0 Then
                For I = 0 To lvwList.Items.Count - 1
                    intTotal = lvwList.Items(I).SubItems(4).Text
                    intRecieve = lvwList.Items(I).SubItems(6).Text
                    intOrder = lvwList.Items(I).SubItems(3).Text
                    If (intTotal + intRecieve) < intOrder Then
                        MessageBox.Show("The Order QTY still bigger then the recieve QTY" & ", Item No. '" & lvwList.Items(I).SubItems(1).Text & "' ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lvwList.Items(I).Selected = True
                        cboPOStatus.SelectedIndex = 0
                        Exit For
                    End If
                Next
            End If
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateResourceCodeRs01() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("RECIEVE_HEADER")

        adoColumn = New DataColumn("REC_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PO_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PO_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("WAREHOUSE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RECIEVE_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RECIEVE_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_HEADER").Columns.Add(adoColumn)

        CreateResourceCodeRs01 = adoDS
    End Function

    Private Function CreateResourceCodeRs02() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("RECIEVE_DETAIL")

        adoColumn = New DataColumn("REC_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PO_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RECIEVE_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OUTSTANDING_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE_DETAIL").Columns.Add(adoColumn)

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
            If e.KeyCode = e.KeyCode.Enter Then
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
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtSupplierNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplierNo.DoubleClick
        txtSupplierNo_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim myForm As New frmRecieve02()
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If cboPOStatus.SelectedIndex = 1 Then
                Exit Sub
            End If
            If btnSave.Enabled = False Then
                Exit Sub
            End If
            If blnModify Then
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialize(blnAddNew)
            myForm.FillField(lvwList.SelectedItems.Item(0).SubItems(1).Text, lvwList.SelectedItems.Item(0).SubItems(2).Text, lvwList.SelectedItems.Item(0).SubItems(3).Text, lvwList.SelectedItems.Item(0).SubItems(4).Text, lvwList.SelectedItems.Item(0).SubItems(5).Text, lvwList.SelectedItems.Item(0).SubItems(6).Text)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()

                If adoDS.Tables("RECIEVE").Rows.Count > 0 Then
                    For Each adoRow In adoDS.Tables("RECIEVE").Rows
                        lvwList.SelectedItems.Item(0).SubItems(5).Text = adoRow!OUTSTANDING_QTY
                        lvwList.SelectedItems.Item(0).SubItems(6).Text = adoRow!RECIEVE_QTY
                    Next
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
        End Try
    End Sub

    Private Sub cboPOStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPOStatus.SelectedIndexChanged
        Dim I As Integer
        Dim intTotal As Integer
        Dim intRecieve As Integer
        Dim intOrder As Integer

        If blnCount > 0 Then
            blnCount = blnCount + 1
            If cboPOStatus.SelectedIndex = 1 Then
                If lvwList.Items.Count > 0 Then
                    For I = 0 To lvwList.Items.Count - 1
                        intTotal = lvwList.Items(I).SubItems(4).Text
                        intRecieve = lvwList.Items(I).SubItems(6).Text
                        intOrder = lvwList.Items(I).SubItems(3).Text

                        If blnAddNew Then
                            If (intTotal + intRecieve) < intOrder Then
                                MessageBox.Show("The Order QTY still bigger then the recieve QTY" & ", Item No. '" & lvwList.Items(I).SubItems(1).Text & "' ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                lvwList.Items(I).Selected = True
                                cboPOStatus.SelectedIndex = 0
                                Exit For
                            End If
                        Else
                            If intTotal < intOrder Then
                                MessageBox.Show("The Order QTY still bigger then the recieve QTY" & ", Item No. '" & lvwList.Items(I).SubItems(1).Text & "' ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                lvwList.Items(I).Selected = True
                                cboPOStatus.SelectedIndex = 0
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub txtPONO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPONO.TextChanged
        cboPOStatus.Items.Clear()
        cboPOStatus.Items.Add("Open")
        cboPOStatus.Items.Add("Closed")
        txtSupplierNo.Text = ""
        lblSupplierName.Text = ""
        lblContactPerson.Text = ""
        lblActive.Text = ""
        lvwList.Items.Clear()
    End Sub

    Private Sub txtPONO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPONO.KeyDown
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim strResult As String
        Dim myForm As New frmLOV()
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim lngOrder As Long
        Dim lngTotalRecieve As Long
        Dim lngOutstanding As Long

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                myForm.Initialize(txtPONO.Text, adoDsPO, "POLOV")

Form_Loop:
                myForm.ShowDialog()
                If myForm.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDS = myForm.GetDataSet()
                    If adoDS.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("RESOURCEINFO").Rows(0)
                        txtPONO.Text = adoRow!RESOURCE_CODE
                        lblSupplierName.Text = adoRow!RESOURCE_DESC
                        adoDS.Dispose()

                        adoDS = svcWarehouse.GetPOHeadInfo("", "", txtPONO.Text, "", APP_ID)
                        If adoDS.Tables("POINFORMATION").Rows.Count > 0 Then
                            adoRow = adoDS.Tables("POINFORMATION").Rows(0)
                            dtpPODate.Value = adoRow!PO_DATE
                            txtSupplierNo.Text = adoRow!SUPPLIER_NO
                            lblSupplierName.Text = adoRow!SUPPLIER_NAME
                            lblContactPerson.Text = adoRow!CONTACT_PERSON
                            If adoRow!ACTIVE_STATUS = "Y" Then
                                lblActive.Text = "Active"
                            Else
                                lblActive.Text = "Not Active"
                            End If
                            If Not IsDBNull(adoRow!PO_STATUS) Then
                                If adoRow!PO_STATUS = "O" Then
                                    cboPOStatus.Enabled = True
                                    cboPOStatus.SelectedIndex = 0
                                    btnSave.Enabled = True
                                    grpRecieve.Enabled = True
                                Else
                                    cboPOStatus.Enabled = False
                                    cboPOStatus.SelectedIndex = 1
                                    btnSave.Enabled = False
                                    grpRecieve.Enabled = False
                                End If
                            End If
                        End If
                        adoDS.Dispose()

                        adoDS = svcWarehouse.GetPODetailInfo(txtPONO.Text, "", APP_ID)
                        For Each adoRow In adoDS.Tables("POINFORMATION").Rows
                            objItem = New ListViewItem(lvwList.Items.Count + 1)

                            lvwList.Items.Add(objItem)
                            objItem.SubItems.Add(adoRow!ITEM_NO)
                            objItem.SubItems.Add(adoRow!ITEM_NAME)
                            objItem.SubItems.Add(adoRow!QTY)
                            lngOrder = adoRow!QTY

                            adoDS = svcWarehouse.GetTotalRecieve(txtPONO.Text, adoRow!ITEM_NO, APP_ID)
                            If IsDBNull(adoDS.Tables("TOTALRECIEVE").Rows(0)("TOTAL_RECIEVE_QTY")) Then
                                lngTotalRecieve = 0
                            Else
                                lngTotalRecieve = adoDS.Tables("TOTALRECIEVE").Rows(0)("TOTAL_RECIEVE_QTY")
                            End If
                            lngOutstanding = lngOrder - lngTotalRecieve

                            objItem.SubItems.Add(lngTotalRecieve)
                            If lngOutstanding > 0 Then
                                objItem.SubItems.Add(lngOutstanding)
                            Else
                                objItem.SubItems.Add("0")
                            End If
                            objItem.SubItems.Add("0")
                        Next
                        adoDS.Dispose()
                    End If
                    adoDS.Dispose()
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtPONO_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPONO.DoubleClick
        txtPONO_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                lvwList_DoubleClick(sender, e)
            End If
        End If
    End Sub

    Private Sub frmRecieve01_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtPONO.Focus()
    End Sub
End Class
