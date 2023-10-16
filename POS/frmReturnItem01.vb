Public Class frmReturnItem01
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
    Friend WithEvents txtUnitPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReturnBy As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboReasonId As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpReturnDetail As System.Windows.Forms.GroupBox
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents dtpReturnDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReturnItem01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grpReturnDetail = New System.Windows.Forms.GroupBox
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.cboReasonId = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtReturnBy = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.txtQTY = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPosition = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.lblItemName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpReturnDetail.SuspendLayout()
        CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(69, 398)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 34
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(5, 398)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 33
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grpReturnDetail
        '
        Me.grpReturnDetail.Controls.Add(Me.dtpReturnDate)
        Me.grpReturnDetail.Controls.Add(Me.lblTransDate)
        Me.grpReturnDetail.Controls.Add(Me.cboReasonId)
        Me.grpReturnDetail.Controls.Add(Me.Label7)
        Me.grpReturnDetail.Controls.Add(Me.txtReturnBy)
        Me.grpReturnDetail.Controls.Add(Me.Label1)
        Me.grpReturnDetail.Controls.Add(Me.txtUnitPrice)
        Me.grpReturnDetail.Controls.Add(Me.Label9)
        Me.grpReturnDetail.Controls.Add(Me.txtComment)
        Me.grpReturnDetail.Controls.Add(Me.txtQTY)
        Me.grpReturnDetail.Controls.Add(Me.Label4)
        Me.grpReturnDetail.Controls.Add(Me.lblPosition)
        Me.grpReturnDetail.Controls.Add(Me.txtItemNo)
        Me.grpReturnDetail.Controls.Add(Me.lblItemName)
        Me.grpReturnDetail.Controls.Add(Me.Label2)
        Me.grpReturnDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReturnDetail.ForeColor = System.Drawing.Color.Blue
        Me.grpReturnDetail.Location = New System.Drawing.Point(0, 4)
        Me.grpReturnDetail.Name = "grpReturnDetail"
        Me.grpReturnDetail.Size = New System.Drawing.Size(640, 384)
        Me.grpReturnDetail.TabIndex = 32
        Me.grpReturnDetail.TabStop = False
        Me.grpReturnDetail.Text = "Return Item - Detail Information"
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnDate.Location = New System.Drawing.Point(96, 48)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.ShowCheckBox = True
        Me.dtpReturnDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpReturnDate.TabIndex = 1
        Me.dtpReturnDate.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(26, 51)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(69, 17)
        Me.lblTransDate.TabIndex = 76
        Me.lblTransDate.Text = "Return Date:"
        '
        'cboReasonId
        '
        Me.cboReasonId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboReasonId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReasonId.Location = New System.Drawing.Point(96, 144)
        Me.cboReasonId.Name = "cboReasonId"
        Me.cboReasonId.Size = New System.Drawing.Size(232, 21)
        Me.cboReasonId.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(46, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Reason :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReturnBy
        '
        Me.txtReturnBy.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtReturnBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReturnBy.Enabled = False
        Me.txtReturnBy.Location = New System.Drawing.Point(96, 24)
        Me.txtReturnBy.MaxLength = 20
        Me.txtReturnBy.Name = "txtReturnBy"
        Me.txtReturnBy.Size = New System.Drawing.Size(120, 21)
        Me.txtReturnBy.TabIndex = 69
        Me.txtReturnBy.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Return By:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Location = New System.Drawing.Point(96, 96)
        Me.txtUnitPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.TabIndex = 8
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(39, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Comment:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComment
        '
        Me.txtComment.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComment.Location = New System.Drawing.Point(96, 168)
        Me.txtComment.MaxLength = 500
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(529, 80)
        Me.txtComment.TabIndex = 5
        Me.txtComment.Text = ""
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(96, 120)
        Me.txtQTY.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtQTY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(53, 21)
        Me.txtQTY.TabIndex = 3
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQTY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Unit Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(29, 123)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(66, 17)
        Me.lblPosition.TabIndex = 49
        Me.lblPosition.Text = "Return QTY:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNo.Location = New System.Drawing.Point(96, 72)
        Me.txtItemNo.MaxLength = 20
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(120, 21)
        Me.txtItemNo.TabIndex = 2
        Me.txtItemNo.Text = ""
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(218, 75)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(68, 17)
        Me.lblItemName.TabIndex = 26
        Me.lblItemName.Text = "Item Name"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(43, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(469, 394)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(557, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'frmReturnItem01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(640, 421)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grpReturnDetail)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReturnItem01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Item - Edit Screen"
        Me.grpReturnDetail.ResumeLayout(False)
        CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean
    Dim blnAddnew As Boolean
    Dim strReturnId As String
    Dim strReasonId As String
    Dim arrReason() As String

    Public Sub FillField(ByVal adoDS As DataSet, ByVal blnAdd As Boolean)
        Dim adoRow As DataRow

        Try
            blnAddnew = blnAdd
            If blnAddnew = False Then
                If adoDS.Tables("RETURN_ITEM").Rows.Count > 0 Then
                    adoRow = adoDS.Tables("RETURN_ITEM").Rows(0)
                    strReturnId = adoRow!RETURN_ID
                    dtpReturnDate.Value = adoRow!RETURN_DATE
                    dtpReturnDate.Checked = True
                    txtReturnBy.Text = adoRow!RETURN_BY
                    txtItemNo.Text = adoRow!ITEM_NO
                    lblItemName.Text = adoRow!ITEM_NAME
                    txtUnitPrice.Text = adoRow!PRICE
                    txtQTY.Text = adoRow!QTY
                    strReasonId = adoRow!REASON_ID
                    txtComment.Text = adoRow!COMMENT

                    lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
                End If
            End If

        Catch ex As Exception
            grpReturnDetail.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
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

        adoDataTable = adoDS.Tables("RETURN_ITEM")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("RETURN_ID") = strReturnId
        adoDataRow("RETURN_DATE") = dtpReturnDate.Value
        adoDataRow("RETURN_BY") = txtReturnBy.Text
        adoDataRow("ITEM_NO") = txtItemNo.Text
        adoDataRow("ITEM_NAME") = lblItemName.Text
        adoDataRow("QTY") = txtQTY.Text
        adoDataRow("PRICE") = txtUnitPrice.Text
        adoDataRow("REASON_ID") = arrReason(cboReasonId.SelectedIndex)
        adoDataRow("COMMENT") = txtComment.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Sub Initialize(ByVal blnCncl As Boolean)
        blnCancel = blnCncl
    End Sub

    Private Sub frmReturnItem01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcPos As New POS.svcPOS()
        Dim dtDate As Date
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim adoDS As New DataSet()
        Dim lngRow As Long

        Try

            adoDS = svcHouseKeeping.GetResourceCode("WAREHOUSE", "REASON", APP_ID)
            If adoDS.Tables("ResourceCode").Rows.Count > 0 Then
                If cboReasonId.Items.Count < 1 Then
                    ReDim arrReason(adoDS.Tables("ResourceCode").Rows.Count - 1)
                    For lngRow = 0 To adoDS.Tables("ResourceCode").Rows.Count - 1
                        cboReasonId.Items.Add(adoDS.Tables("ResourceCode").Rows(lngRow)("RESOURCE_DESC"))
                        arrReason(lngRow) = adoDS.Tables("ResourceCode").Rows(lngRow)("RESOURCE_CODE")
                    Next lngRow
                End If
            End If
            adoDS.Dispose()

            If blnAddnew Then
                dtDate = svcPos.GetDate(APP_ID)

                lblItemName.Text = ""
                txtUnitPrice.Text = "0"
                dtpReturnDate.Value = dtDate
                dtpReturnDate.Checked = False
                txtReturnBy.Text = USER_ID

                lblTitleLast.Visible = False
                lblLastUpdate.Visible = False
            Else
                lngRow = 0
                For lngRow = 0 To cboReasonId.Items.Count - 1
                    If strReasonId = arrReason(lngRow) Then
                        cboReasonId.SelectedIndex = lngRow
                        Exit For
                    End If
                Next
                dtpReturnDate.Checked = True
                lblTitleLast.Visible = True
                lblLastUpdate.Visible = True
            End If

        Catch ex As Exception
            grpReturnDetail.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("RETURN_ITEM")

        adoColumn = New DataColumn("RETURN_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RETURN_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RETURN_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REASON_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("RETURN_ITEM").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtItemNo) Then
            Exit Sub
        End If
        If ValidateEmptyField(lblItemName) Then
            Exit Sub
        End If
        If dtpReturnDate.Checked = False Then
            MessageBox.Show("Please select the Return Date fisrt. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpReturnDate.Focus()
            Exit Sub
        End If
        If txtQTY.Value <= 0 Then
            MessageBox.Show("The QTY must be greater than 0 value. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQTY.Focus()
            Exit Sub
        End If
        If ValidateEmptyField(cboReasonId) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtComment) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub txtItemNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemNo.TextChanged
        lblItemName.Text = ""
        txtUnitPrice.Text = "0"
    End Sub

    Private Sub txtItemNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemNo.KeyDown
        Dim svcPos As New POS.svcPOS()
        Dim adoDS As DataSet

        Try
            If e.KeyCode = Keys.F2 Then
                If Trim(txtItemNo.Text) = "" Then
                    MessageBox.Show("Please type the Item No first. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                adoDS = svcPos.CheckItemStock(txtItemNo.Text, APP_ID)
                If adoDS.Tables("ITEM_STOCK").Rows.Count > 0 Then
                    lblItemName.Text = adoDS.Tables("ITEM_STOCK").Rows(0)("ITEM_NAME")
                    txtUnitPrice.Text = adoDS.Tables("ITEM_STOCK").Rows(0)("SELL_PRICE")
                Else
                    MessageBox.Show("This Item is not available in the warehouse stock. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    adoDS.Dispose()
                    Exit Sub
                End If
                adoDS.Dispose()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (svcPos Is Nothing) Then
                svcPos.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtItemNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemNo.DoubleClick
        txtItemNo_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Private Sub txtQTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.Enter
        txtQTY.Select(0, txtQTY.Text.Length)
    End Sub
End Class
