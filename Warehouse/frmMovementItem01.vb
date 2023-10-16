Public Class frmMovementItem01
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents cboMoveWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents dtpMoveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMovedBy As System.Windows.Forms.TextBox
    Friend WithEvents lblMovedBy As System.Windows.Forms.Label
    Friend WithEvents grpStock As System.Windows.Forms.GroupBox
    Friend WithEvents grpMovement As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMovementItem01))
        Me.grpStock = New System.Windows.Forms.GroupBox
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpMovement = New System.Windows.Forms.GroupBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMovedBy = New System.Windows.Forms.TextBox
        Me.lblMovedBy = New System.Windows.Forms.Label
        Me.cboMoveWarehouse = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpMoveDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.grpStock.SuspendLayout()
        Me.grpMovement.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStock
        '
        Me.grpStock.Controls.Add(Me.btnDeleteItem)
        Me.grpStock.Controls.Add(Me.btnAddItem)
        Me.grpStock.Controls.Add(Me.lvwList)
        Me.grpStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStock.ForeColor = System.Drawing.Color.Blue
        Me.grpStock.Location = New System.Drawing.Point(1, 104)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(664, 288)
        Me.grpStock.TabIndex = 26
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Item Detail Information"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteItem.Location = New System.Drawing.Point(94, 254)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(80, 24)
        Me.btnDeleteItem.TabIndex = 5
        Me.btnDeleteItem.Text = "&Delete Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.Black
        Me.btnAddItem.Location = New System.Drawing.Point(6, 254)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(80, 24)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "&Add Item"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(6, 19)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(652, 232)
        Me.lvwList.TabIndex = 3
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
        Me.ColumnHeader4.Width = 220
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Stock Warehouse"
        Me.ColumnHeader5.Width = 147
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Stock QTY"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Move QTY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "WarehouseID"
        Me.ColumnHeader7.Width = 0
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(68, 401)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 33
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(4, 401)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 32
        Me.lblTitleLast.Text = "Last Update:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(495, 394)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(583, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'grpMovement
        '
        Me.grpMovement.Controls.Add(Me.cboStatus)
        Me.grpMovement.Controls.Add(Me.Label1)
        Me.grpMovement.Controls.Add(Me.txtMovedBy)
        Me.grpMovement.Controls.Add(Me.lblMovedBy)
        Me.grpMovement.Controls.Add(Me.cboMoveWarehouse)
        Me.grpMovement.Controls.Add(Me.Label7)
        Me.grpMovement.Controls.Add(Me.dtpMoveDate)
        Me.grpMovement.Controls.Add(Me.lblTransDate)
        Me.grpMovement.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMovement.ForeColor = System.Drawing.Color.Blue
        Me.grpMovement.Location = New System.Drawing.Point(1, 8)
        Me.grpMovement.Name = "grpMovement"
        Me.grpMovement.Size = New System.Drawing.Size(664, 88)
        Me.grpMovement.TabIndex = 38
        Me.grpMovement.TabStop = False
        Me.grpMovement.Text = "Move Item Information"
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Location = New System.Drawing.Point(520, 24)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(104, 21)
        Me.cboStatus.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(447, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Move Status:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMovedBy
        '
        Me.txtMovedBy.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMovedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMovedBy.Enabled = False
        Me.txtMovedBy.Location = New System.Drawing.Point(96, 24)
        Me.txtMovedBy.MaxLength = 20
        Me.txtMovedBy.Name = "txtMovedBy"
        Me.txtMovedBy.Size = New System.Drawing.Size(118, 21)
        Me.txtMovedBy.TabIndex = 4
        Me.txtMovedBy.Text = ""
        '
        'lblMovedBy
        '
        Me.lblMovedBy.AutoSize = True
        Me.lblMovedBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovedBy.ForeColor = System.Drawing.Color.Black
        Me.lblMovedBy.Location = New System.Drawing.Point(35, 27)
        Me.lblMovedBy.Name = "lblMovedBy"
        Me.lblMovedBy.Size = New System.Drawing.Size(57, 17)
        Me.lblMovedBy.TabIndex = 92
        Me.lblMovedBy.Text = "Moved By:"
        Me.lblMovedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMoveWarehouse
        '
        Me.cboMoveWarehouse.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboMoveWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoveWarehouse.Location = New System.Drawing.Point(392, 49)
        Me.cboMoveWarehouse.Name = "cboMoveWarehouse"
        Me.cboMoveWarehouse.Size = New System.Drawing.Size(232, 21)
        Me.cboMoveWarehouse.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(281, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Move to Warehouse:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpMoveDate
        '
        Me.dtpMoveDate.Checked = False
        Me.dtpMoveDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMoveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMoveDate.Location = New System.Drawing.Point(96, 49)
        Me.dtpMoveDate.Name = "dtpMoveDate"
        Me.dtpMoveDate.ShowCheckBox = True
        Me.dtpMoveDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpMoveDate.TabIndex = 1
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(32, 52)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(62, 17)
        Me.lblTransDate.TabIndex = 60
        Me.lblTransDate.Text = "Move Date:"
        '
        'frmMovementItem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(666, 421)
        Me.Controls.Add(Me.grpMovement)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpStock)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovementItem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movement Item - Edit Screen"
        Me.grpStock.ResumeLayout(False)
        Me.grpMovement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim arrWarehouse() As String
    Dim strStockWarehouse As String
    Dim strMoveWarehouse As String
    Dim strStatus As String
    Dim intMovId As Integer

    Private Sub frmMovementItem01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As DataSet
        Dim lngRow As Long

        Try
            blnCancel = True
            adoDS = svcHouseKeeping.GetWarehouse("N", APP_ID)
            If adoDS.Tables("WAREHOUSE").Rows.Count > 0 Then
                If cboMoveWarehouse.Items.Count < 1 Then
                    ReDim arrWarehouse(adoDS.Tables("WAREHOUSE").Rows.Count - 1)
                    For lngRow = 0 To adoDS.Tables("WAREHOUSE").Rows.Count - 1
                        cboMoveWarehouse.Items.Add(adoDS.Tables("WAREHOUSE").Rows(lngRow)("RESOURCE_DESC"))
                        arrWarehouse(lngRow) = adoDS.Tables("WAREHOUSE").Rows(lngRow)("RESOURCE_CODE")
                    Next lngRow
                End If
            End If
            adoDS.Dispose()

            If blnAddNew Then
                cboStatus.Items.Clear()
                cboStatus.Items.Add("Open")
                cboStatus.SelectedIndex = 0
                'lblMovedBy.Visible = False
                'txtMovedBy.Visible = False
                txtMovedBy.Text = USER_ID
                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                cboStatus.Items.Clear()
                cboStatus.Items.Add("Open")
                cboStatus.Items.Add("Closed")
                For lngRow = 0 To cboMoveWarehouse.Items.Count - 1
                    If strMoveWarehouse = arrWarehouse(lngRow) Then
                        cboMoveWarehouse.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow
                cboMoveWarehouse.Enabled = False
                If strStatus = "O" Then
                    cboStatus.SelectedIndex = 0
                    grpMovement.Enabled = True
                    grpStock.Enabled = True
                    btnAddItem.Enabled = False
                    btnDeleteItem.Enabled = False
                    btnSave.Enabled = True
                Else
                    cboStatus.SelectedIndex = 1
                    grpMovement.Enabled = False
                    btnAddItem.Enabled = False
                    btnDeleteItem.Enabled = False
                    btnSave.Enabled = False
                End If
                lblMovedBy.Visible = True
                txtMovedBy.Visible = True
                lblTitleLast.Visible = True
            End If

        Catch ex As Exception
            grpStock.Enabled = False
            grpMovement.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddNew = blnAdd
    End Sub

    Public Function GetDataSet01() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateHeaderRs()
            FillDataSet01(myDS)
            GetDataSet01 = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDataSet02() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateDetailRs()
            FillDataSet02(myDS)
            GetDataSet02 = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FillDataSet01(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("MOVE_ITEM")
        adoDataRow = adoDataTable.NewRow()
        If blnAddNew = False Then
            adoDataRow("MOV_ID") = intMovId
        End If
        adoDataRow("MOV_DATE") = dtpMoveDate.Value
        adoDataRow("WAREHOUSE_ID") = arrWarehouse(cboMoveWarehouse.SelectedIndex)
        adoDataRow("MOV_BY") = USER_ID
        If cboStatus.SelectedIndex = 0 Then
            adoDataRow("MOV_STATUS") = "O"
        Else
            adoDataRow("MOV_STATUS") = "C"
        End If
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Sub FillDataSet02(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()
        Dim I As Long

        Try
            adoDataTable = adoDS.Tables("MOVE_ITEM")
            For I = 0 To lvwList.Items.Count - 1
                adoDataRow = adoDataTable.NewRow()
                If blnAddNew = False Then
                    adoDataRow("MOV_ID") = intMovId
                End If
                adoDataRow("ITEM_NO") = lvwList.Items(I).SubItems(1).Text
                adoDataRow("STOCK_QTY") = lvwList.Items(I).SubItems(4).Text
                adoDataRow("MOV_QTY") = lvwList.Items(I).SubItems(5).Text
                adoDataRow("STOCK_WAREHOUSE") = lvwList.Items(I).SubItems(6).Text
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
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim adoDS As DataSet
        Dim intTotalPrice As Integer

        Try
            If adoDSHeader.Tables("MOVE_ITEM").Rows.Count > 0 Then
                adoRow = adoDSHeader.Tables("MOVE_ITEM").Rows(0)
                intMovId = adoRow!MOV_ID
                txtMovedBy.Visible = True
                lblMovedBy.Visible = True
                txtMovedBy.Text = adoRow!MOV_BY
                dtpMoveDate.Checked = True
                dtpMoveDate.Value = adoRow!MOV_DATE
                strMoveWarehouse = adoRow!WAREHOUSE_ID
                strStatus = adoRow!MOV_STATUS
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
            End If

            For Each adoRow In adoDSDetail.Tables("MOVE_ITEM").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)

                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(adoRow!WAREHOUSE_NAME)
                objItem.SubItems.Add(adoRow!STOCK_QTY)
                objItem.SubItems.Add(adoRow!MOV_QTY)
                objItem.SubItems.Add(adoRow!STOCK_WAREHOUSE)
                objItem.Selected = True
            Next
            If lvwList.Items.Count > 15 Then
                lvwList.Columns(3).Width = 130
            Else
                lvwList.Columns(3).Width = 147
            End If

        Catch ex As Exception
            grpMovement.Enabled = False
            grpStock.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    'Public Sub ModifyData(ByVal adoDS As DataSet)
    '    Dim adoRow As DataRow
    '    Try
    '        If adoDS.Tables("MOVEMENT").Rows.Count > 0 Then
    '            'adoRow = adoDS.Tables("MOVEMENT").Rows(0)
    '            'intMovId = adoRow!MOV_ID
    '            'dtpMoveDate.Value = adoRow!MOV_DATE

    '            'txtMoveQTY.Text = adoRow!MOV_QTY
    '            'txtMovedBy.Text = adoRow!MOV_BY

    '            'lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
    '        End If

    '    Catch ex As Exception
    '        grpStock.Enabled = False
    '        grpMovement.Enabled = False
    '        btnSave.Enabled = False
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dtpMoveDate.Checked = False Then
            MessageBox.Show("Please select the Move Date first. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ValidateEmptyField(cboMoveWarehouse) Then
            Exit Sub
        End If
        If lvwList.Items.Count < 1 Then
            MessageBox.Show("Please input the item that you want to move first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateHeaderRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("MOVE_ITEM")

        adoColumn = New DataColumn("MOV_ID")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOV_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("WAREHOUSE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOV_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOV_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        CreateHeaderRs = adoDS
    End Function

    Private Function CreateDetailRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("MOVE_ITEM")

        adoColumn = New DataColumn("MOV_ID")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("STOCK_WAREHOUSE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("STOCK_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOV_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MOVE_ITEM").Columns.Add(adoColumn)

        CreateDetailRs = adoDS
    End Function

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim myForm As New frmMovementItem02()
        Dim adoRow As DataRow
        Dim blnExist As Boolean
        Dim I As Integer

        Try
            myForm.Initialize(True)

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
                    objItem.SubItems.Add(adoRow!WAREHOUSE_NAME)
                    objItem.SubItems.Add(adoRow!STOCK_QTY)
                    objItem.SubItems.Add(adoRow!MOVE_QTY)
                    objItem.SubItems.Add(adoRow!STOCK_WAREHOUSE)
                    objItem.Selected = True
                End If

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                End If
                If lvwList.Items.Count > 15 Then
                    lvwList.Columns(3).Width = 130
                Else
                    lvwList.Columns(3).Width = 147
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
        End Try
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        Dim intSelectedItem As Integer
        Dim intCount As Integer
        Dim I As Integer

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

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
            If lvwList.Items.Count > 15 Then
                lvwList.Columns(3).Width = 130
            Else
                lvwList.Columns(3).Width = 147
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub
End Class
