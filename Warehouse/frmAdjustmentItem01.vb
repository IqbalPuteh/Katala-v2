Public Class frmAdjustmentItem01
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
    Friend WithEvents grpMovement As System.Windows.Forms.GroupBox
    Friend WithEvents lblMovedBy As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpStock As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtAdjustBy As System.Windows.Forms.TextBox
    Friend WithEvents dtpAdjustDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdjustmentItem01))
        Me.grpMovement = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.cboWarehouse = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAdjustBy = New System.Windows.Forms.TextBox
        Me.lblMovedBy = New System.Windows.Forms.Label
        Me.dtpAdjustDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpStock = New System.Windows.Forms.GroupBox
        Me.btnDeleteItem = New System.Windows.Forms.Button
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.grpMovement.SuspendLayout()
        Me.grpStock.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMovement
        '
        Me.grpMovement.Controls.Add(Me.Label9)
        Me.grpMovement.Controls.Add(Me.txtComment)
        Me.grpMovement.Controls.Add(Me.cboWarehouse)
        Me.grpMovement.Controls.Add(Me.Label7)
        Me.grpMovement.Controls.Add(Me.txtAdjustBy)
        Me.grpMovement.Controls.Add(Me.lblMovedBy)
        Me.grpMovement.Controls.Add(Me.dtpAdjustDate)
        Me.grpMovement.Controls.Add(Me.lblTransDate)
        Me.grpMovement.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMovement.ForeColor = System.Drawing.Color.Blue
        Me.grpMovement.Location = New System.Drawing.Point(1, 5)
        Me.grpMovement.Name = "grpMovement"
        Me.grpMovement.Size = New System.Drawing.Size(664, 131)
        Me.grpMovement.TabIndex = 9
        Me.grpMovement.TabStop = False
        Me.grpMovement.Text = "Adjustment Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(288, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Comment:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComment
        '
        Me.txtComment.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComment.Location = New System.Drawing.Point(344, 48)
        Me.txtComment.MaxLength = 500
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(312, 72)
        Me.txtComment.TabIndex = 3
        Me.txtComment.Text = ""
        '
        'cboWarehouse
        '
        Me.cboWarehouse.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarehouse.Location = New System.Drawing.Point(72, 48)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(200, 21)
        Me.cboWarehouse.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Warehouse:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdjustBy
        '
        Me.txtAdjustBy.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtAdjustBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdjustBy.Enabled = False
        Me.txtAdjustBy.Location = New System.Drawing.Point(72, 24)
        Me.txtAdjustBy.MaxLength = 20
        Me.txtAdjustBy.Name = "txtAdjustBy"
        Me.txtAdjustBy.Size = New System.Drawing.Size(118, 21)
        Me.txtAdjustBy.TabIndex = 4
        Me.txtAdjustBy.Text = ""
        '
        'lblMovedBy
        '
        Me.lblMovedBy.AutoSize = True
        Me.lblMovedBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovedBy.ForeColor = System.Drawing.Color.Black
        Me.lblMovedBy.Location = New System.Drawing.Point(16, 27)
        Me.lblMovedBy.Name = "lblMovedBy"
        Me.lblMovedBy.Size = New System.Drawing.Size(55, 17)
        Me.lblMovedBy.TabIndex = 92
        Me.lblMovedBy.Text = "Adjust By:"
        Me.lblMovedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpAdjustDate
        '
        Me.dtpAdjustDate.Checked = False
        Me.dtpAdjustDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAdjustDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAdjustDate.Location = New System.Drawing.Point(536, 24)
        Me.dtpAdjustDate.Name = "dtpAdjustDate"
        Me.dtpAdjustDate.ShowCheckBox = True
        Me.dtpAdjustDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpAdjustDate.TabIndex = 1
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(470, 27)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(67, 17)
        Me.lblTransDate.TabIndex = 60
        Me.lblTransDate.Text = "Adjust Date:"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(71, 380)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 43
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(7, 380)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 42
        Me.lblTitleLast.Text = "Last Update:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(495, 373)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(583, 373)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'grpStock
        '
        Me.grpStock.Controls.Add(Me.btnDeleteItem)
        Me.grpStock.Controls.Add(Me.btnAddItem)
        Me.grpStock.Controls.Add(Me.lvwList)
        Me.grpStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStock.ForeColor = System.Drawing.Color.Blue
        Me.grpStock.Location = New System.Drawing.Point(1, 141)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(664, 224)
        Me.grpStock.TabIndex = 10
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Item Detail Information"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteItem.Location = New System.Drawing.Point(93, 195)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(80, 24)
        Me.btnDeleteItem.TabIndex = 6
        Me.btnDeleteItem.Text = "&Delete Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.Black
        Me.btnAddItem.Location = New System.Drawing.Point(7, 195)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(80, 24)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "&Input Item"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(4, 19)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(656, 173)
        Me.lvwList.TabIndex = 4
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
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Name"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Stock QTY"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Add QTY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Minus QTY"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 80
        '
        'frmAdjustmentItem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(666, 400)
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
        Me.Name = "frmAdjustmentItem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjustment Stock Item - Edit Screen"
        Me.grpMovement.ResumeLayout(False)
        Me.grpStock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim arrWarehouse() As String
    Dim arrValWarehouse() As String
    Dim strStockWarehouse As String
    Dim strAdjWarehouse As String
    Dim intAdjId As Integer

    Private Sub frmAdjustmentItem01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As DataSet
        Dim lngRow As Long

        Try
            blnCancel = True
            adoDS = svcHouseKeeping.GetWarehouse("", APP_ID)
            If adoDS.Tables("WAREHOUSE").Rows.Count > 0 Then
                If cboWarehouse.Items.Count < 1 Then
                    ReDim arrWarehouse(adoDS.Tables("WAREHOUSE").Rows.Count - 1)
                    ReDim arrValWarehouse(adoDS.Tables("WAREHOUSE").Rows.Count - 1)
                    For lngRow = 0 To adoDS.Tables("WAREHOUSE").Rows.Count - 1
                        cboWarehouse.Items.Add(adoDS.Tables("WAREHOUSE").Rows(lngRow)("RESOURCE_DESC"))
                        arrWarehouse(lngRow) = adoDS.Tables("WAREHOUSE").Rows(lngRow)("RESOURCE_CODE")
                        arrValWarehouse(lngRow) = adoDS.Tables("WAREHOUSE").Rows(lngRow)("DEFAULT_VALUE")
                    Next lngRow
                End If
            End If
            adoDS.Dispose()

            If blnAddNew Then
                'lblMovedBy.Visible = False
                txtAdjustBy.Text = USER_ID
                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                For lngRow = 0 To cboWarehouse.Items.Count - 1
                    If strAdjWarehouse = arrWarehouse(lngRow) Then
                        cboWarehouse.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow
                cboWarehouse.Enabled = False
                grpMovement.Enabled = True
                grpStock.Enabled = True
                btnAddItem.Enabled = False
                btnDeleteItem.Enabled = False
                lblMovedBy.Visible = True
                txtAdjustBy.Visible = True
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

        adoDataTable = adoDS.Tables("ADJUST_STOCK")
        adoDataRow = adoDataTable.NewRow()
        If blnAddNew = False Then
            adoDataRow("ADJ_ID") = intAdjId
        End If
        adoDataRow("ADJ_BY") = USER_ID
        adoDataRow("ADJ_DATE") = dtpAdjustDate.Value
        adoDataRow("WAREHOUSE_ID") = arrWarehouse(cboWarehouse.SelectedIndex)
        adoDataRow("WAREHOUSE") = arrValWarehouse(cboWarehouse.SelectedIndex)
        adoDataRow("COMMENT") = txtComment.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Sub FillDataSet02(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()
        Dim I As Long

        Try
            adoDataTable = adoDS.Tables("ADJUST_STOCK")
            For I = 0 To lvwList.Items.Count - 1
                adoDataRow = adoDataTable.NewRow()
                If blnAddNew = False Then
                    adoDataRow("ADJ_ID") = intAdjId
                End If
                adoDataRow("ITEM_NO") = lvwList.Items(I).SubItems(1).Text
                adoDataRow("STOCK_QTY") = lvwList.Items(I).SubItems(3).Text
                adoDataRow("ADD_QTY") = lvwList.Items(I).SubItems(4).Text
                adoDataRow("MINUS_QTY") = lvwList.Items(I).SubItems(5).Text
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
            If adoDSHeader.Tables("ADJUST").Rows.Count > 0 Then
                adoRow = adoDSHeader.Tables("ADJUST").Rows(0)
                intAdjId = adoRow!ADJ_ID
                txtAdjustBy.Visible = True
                lblMovedBy.Visible = True
                txtAdjustBy.Text = adoRow!ADJ_BY
                dtpAdjustDate.Checked = True
                dtpAdjustDate.Value = adoRow!ADJ_DATE
                strAdjWarehouse = adoRow!WAREHOUSE_ID
                txtComment.Text = adoRow!COMMENT
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
            End If

            For Each adoRow In adoDSDetail.Tables("ADJUST").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)

                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(adoRow!STOCK_QTY)
                objItem.SubItems.Add(adoRow!ADD_QTY)
                objItem.SubItems.Add(adoRow!MINUS_QTY)
                objItem.Selected = True
            Next

        Catch ex As Exception
            grpMovement.Enabled = False
            grpStock.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dtpAdjustDate.Checked = False Then
            MessageBox.Show("Please select the Adjust Date first. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ValidateEmptyField(cboWarehouse) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtComment) Then
            Exit Sub
        End If
        If lvwList.Items.Count < 1 Then
            MessageBox.Show("Please input the item that you want to Adjust first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateHeaderRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("ADJUST_STOCK")

        adoColumn = New DataColumn("ADJ_ID")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ADJ_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ADJ_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("WAREHOUSE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("WAREHOUSE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        CreateHeaderRs = adoDS
    End Function

    Private Function CreateDetailRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("ADJUST_STOCK")

        adoColumn = New DataColumn("ADJ_ID")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("STOCK_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ADD_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MINUS_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("ADJUST_STOCK").Columns.Add(adoColumn)

        CreateDetailRs = adoDS
    End Function

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim myForm As New frmAdjustmentItem02()
        Dim adoRow As DataRow
        Dim blnExist As Boolean
        Dim I As Integer

        Try
            If ValidateEmptyField(cboWarehouse) Then
                Exit Sub
            End If

            myForm.Initialize(True, arrWarehouse(cboWarehouse.SelectedIndex), arrValWarehouse(cboWarehouse.SelectedIndex))

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
                    objItem.SubItems.Add(adoRow!STOCK_QTY)
                    objItem.SubItems.Add(adoRow!ADD_QTY)
                    objItem.SubItems.Add(adoRow!MINUS_QTY)
                    objItem.Selected = True
                End If

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub cboWarehouse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWarehouse.SelectedIndexChanged
        If blnAddNew = True Then
            lvwList.Items.Clear()
        End If
    End Sub

    Private Sub frmAdjustmentItem01_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        dtpAdjustDate.Focus()
    End Sub
End Class
