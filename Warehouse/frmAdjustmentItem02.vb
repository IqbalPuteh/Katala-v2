Public Class frmAdjustmentItem02
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
    Friend WithEvents grpStock As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStockQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboStockWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMinusQTY As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdjustmentItem02))
        Me.grpStock = New System.Windows.Forms.GroupBox
        Me.txtMinusQTY = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddQTY = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStockQTY = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboStockWarehouse = New System.Windows.Forms.ComboBox
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnInput = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grpStock.SuspendLayout()
        CType(Me.txtMinusQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpStock
        '
        Me.grpStock.Controls.Add(Me.txtMinusQTY)
        Me.grpStock.Controls.Add(Me.Label6)
        Me.grpStock.Controls.Add(Me.txtAddQTY)
        Me.grpStock.Controls.Add(Me.Label4)
        Me.grpStock.Controls.Add(Me.txtStockQTY)
        Me.grpStock.Controls.Add(Me.Label1)
        Me.grpStock.Controls.Add(Me.Label16)
        Me.grpStock.Controls.Add(Me.cboStockWarehouse)
        Me.grpStock.Controls.Add(Me.cboCategory)
        Me.grpStock.Controls.Add(Me.Label5)
        Me.grpStock.Controls.Add(Me.txtItemNo)
        Me.grpStock.Controls.Add(Me.txtItemName)
        Me.grpStock.Controls.Add(Me.Label3)
        Me.grpStock.Controls.Add(Me.Label2)
        Me.grpStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStock.ForeColor = System.Drawing.Color.Blue
        Me.grpStock.Location = New System.Drawing.Point(1, 8)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(568, 272)
        Me.grpStock.TabIndex = 4
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Stock Item Detail Information"
        '
        'txtMinusQTY
        '
        Me.txtMinusQTY.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMinusQTY.Location = New System.Drawing.Point(336, 134)
        Me.txtMinusQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtMinusQTY.Name = "txtMinusQTY"
        Me.txtMinusQTY.Size = New System.Drawing.Size(54, 21)
        Me.txtMinusQTY.TabIndex = 3
        Me.txtMinusQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(277, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Minus QTY:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddQTY
        '
        Me.txtAddQTY.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAddQTY.Location = New System.Drawing.Point(72, 134)
        Me.txtAddQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtAddQTY.Name = "txtAddQTY"
        Me.txtAddQTY.Size = New System.Drawing.Size(54, 21)
        Me.txtAddQTY.TabIndex = 2
        Me.txtAddQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Add QTY:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStockQTY
        '
        Me.txtStockQTY.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtStockQTY.Enabled = False
        Me.txtStockQTY.Location = New System.Drawing.Point(72, 104)
        Me.txtStockQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtStockQTY.Name = "txtStockQTY"
        Me.txtStockQTY.Size = New System.Drawing.Size(54, 21)
        Me.txtStockQTY.TabIndex = 11
        Me.txtStockQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Stock QTY:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(7, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 17)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Warehouse:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboStockWarehouse
        '
        Me.cboStockWarehouse.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cboStockWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStockWarehouse.Enabled = False
        Me.cboStockWarehouse.Location = New System.Drawing.Point(72, 80)
        Me.cboStockWarehouse.Name = "cboStockWarehouse"
        Me.cboStockWarehouse.Size = New System.Drawing.Size(232, 21)
        Me.cboStockWarehouse.TabIndex = 10
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Enabled = False
        Me.cboCategory.Location = New System.Drawing.Point(336, 29)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(224, 21)
        Me.cboCategory.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(256, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Item Category:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNo.Location = New System.Drawing.Point(72, 29)
        Me.txtItemNo.MaxLength = 20
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(167, 21)
        Me.txtItemNo.TabIndex = 1
        Me.txtItemNo.Text = ""
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(72, 56)
        Me.txtItemName.MaxLength = 200
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(488, 21)
        Me.txtItemName.TabIndex = 9
        Me.txtItemName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 59)
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
        Me.Label2.Location = New System.Drawing.Point(19, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(399, 283)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(80, 24)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "&Input"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(487, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Close"
        '
        'frmAdjustmentItem02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(570, 310)
        Me.Controls.Add(Me.grpStock)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjustmentItem02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Item Information"
        Me.grpStock.ResumeLayout(False)
        CType(Me.txtMinusQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim adoDSItemStock As DataSet
    Dim strStockWarehouse As String
    Dim strWarehouseId As String
    Dim strDefaultValue As String

    Private Sub txtItemNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemNo.KeyDown
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmLOV()
        Dim adoRow As DataRow

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                myForm.Initialize(txtItemNo.Text, adoDSItemStock, "STOCK_LOV")

Form_Loop:
                myForm.ShowDialog()
                If myForm.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDS = myForm.GetDataSet()
                    If adoDS.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("RESOURCEINFO").Rows(0)
                        txtItemNo.Text = adoRow!RESOURCE_CODE
                        txtItemName.Text = adoRow!RESOURCE_DESC
                        adoDS.Dispose()

                        adoDS = svcWarehouse.GetStock(txtItemNo.Text, strWarehouseId, strDefaultValue, APP_ID)
                        If adoDS.Tables("STOCK").Rows.Count > 0 Then
                            adoRow = adoDS.Tables("STOCK").Rows(0)
                            cboCategory.Items.Clear()
                            cboCategory.Items.Add(adoRow!CATEGORY_NAME)
                            cboCategory.SelectedIndex = 0
                            strStockWarehouse = adoRow!WAREHOUSE_ID
                            cboStockWarehouse.Items.Clear()
                            cboStockWarehouse.Items.Add(adoRow!WAREHOUSE_NAME)
                            cboStockWarehouse.SelectedIndex = 0
                            txtStockQTY.Text = adoRow!STOCK_QTY
                        End If
                        adoDS.Dispose()
                    End If
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
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

    Private Sub txtItemNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemNo.TextChanged
        txtItemName.Text = ""
        cboCategory.Items.Clear()
        cboStockWarehouse.Items.Clear()
        txtStockQTY.Text = "0"
        txtAddQTY.Text = "0"
        txtMinusQTY.Text = "0"
    End Sub

    Private Sub txtItemNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemNo.DoubleClick
        txtItemNo_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean, _
                          ByVal strWarehouse As String, _
                          ByVal strDefValue As String)
        blnAddNew = blnAdd
        strWarehouseId = strWarehouse
        strDefaultValue = strDefValue
    End Sub

    Private Sub frmAdjustmentItem02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim lngRow As Long

        Try
            blnCancel = True
            If blnAddNew Then
                adoDSItemStock = svcWarehouse.GetStockLOV(strWarehouseId, strDefaultValue, APP_ID)
            End If

        Catch ex As Exception
            grpStock.Enabled = False
            btnInput.Enabled = False
            Throw ex
        End Try
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Private Sub frmAdjustmentItem02_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtItemNo.Focus()
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

        Try
            adoDataTable = adoDS.Tables("INPUTITEM")
            adoDataRow = adoDataTable.NewRow()
            adoDataRow("ITEM_NO") = txtItemNo.Text
            adoDataRow("ITEM_NAME") = txtItemName.Text
            adoDataRow("CATEGORY") = cboCategory.Text
            adoDataRow("WAREHOUSE_NAME") = cboStockWarehouse.Text
            adoDataRow("STOCK_QTY") = txtStockQTY.Text
            adoDataRow("ADD_QTY") = txtAddQTY.Text
            adoDataRow("MINUS_QTY") = txtMinusQTY.Text
            adoDataRow("STOCK_WAREHOUSE") = strStockWarehouse

            adoDataTable.Rows.Add(adoDataRow)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        Try
            adoDS.Tables.Add("INPUTITEM")

            adoColumn = New DataColumn("ITEM_NO")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ITEM_NAME")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("CATEGORY")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("WAREHOUSE_NAME")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("STOCK_QTY")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ADD_QTY")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("MINUS_QTY")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("STOCK_WAREHOUSE")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            CreateResourceCodeRs = adoDS

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If ValidateEmptyField(txtItemNo) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtItemName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboStockWarehouse) Then
            Exit Sub
        End If
        If txtAddQTY.Text = 0 And txtMinusQTY.Text = 0 Then
            MessageBox.Show("Please fill the Add QTY field or the Minus QTY field. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub txtAddQTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddQTY.Enter
        txtAddQTY.Select(0, txtAddQTY.Text.Length)
    End Sub

    Private Sub txtMinusQTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinusQTY.Enter
        txtMinusQTY.Select(0, txtMinusQTY.Text.Length)
    End Sub

    Private Sub txtAddQTY_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddQTY.ValueChanged
        txtMinusQTY.Text = "0"
    End Sub

    Private Sub txtMinusQTY_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinusQTY.ValueChanged
        txtAddQTY.Text = "0"
    End Sub
End Class
