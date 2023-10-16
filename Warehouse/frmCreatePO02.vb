Public Class frmCreatePO02
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPONO As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTotalPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAddnew As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRecieve As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnChangePrice As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCreatePO02))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTotalRecieve = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnAddnew = New System.Windows.Forms.Button
        Me.txtPrice = New System.Windows.Forms.NumericUpDown
        Me.txtTotalPrice = New System.Windows.Forms.NumericUpDown
        Me.txtQTY = New System.Windows.Forms.NumericUpDown
        Me.lblPONO = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.lblItemName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnInput = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnChangePrice = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTotalRecieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTotalRecieve)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.txtQTY)
        Me.GroupBox1.Controls.Add(Me.lblPONO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemNo)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 272)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Item"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(550, 1)
        Me.Label6.TabIndex = 79
        '
        'txtTotalRecieve
        '
        Me.txtTotalRecieve.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTotalRecieve.Enabled = False
        Me.txtTotalRecieve.Location = New System.Drawing.Point(400, 68)
        Me.txtTotalRecieve.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtTotalRecieve.Name = "txtTotalRecieve"
        Me.txtTotalRecieve.Size = New System.Drawing.Size(54, 21)
        Me.txtTotalRecieve.TabIndex = 77
        Me.txtTotalRecieve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(324, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Total Recieve:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddnew
        '
        Me.btnAddnew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddnew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddnew.Location = New System.Drawing.Point(8, 284)
        Me.btnAddnew.Name = "btnAddnew"
        Me.btnAddnew.Size = New System.Drawing.Size(96, 24)
        Me.btnAddnew.TabIndex = 47
        Me.btnAddnew.Text = "&Add New Item"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(72, 92)
        Me.txtPrice.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtPrice.TabIndex = 3
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(72, 120)
        Me.txtTotalPrice.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtTotalPrice.TabIndex = 4
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(72, 68)
        Me.txtQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(64, 21)
        Me.txtQTY.TabIndex = 2
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPONO
        '
        Me.lblPONO.AutoSize = True
        Me.lblPONO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPONO.ForeColor = System.Drawing.Color.Black
        Me.lblPONO.Location = New System.Drawing.Point(72, 24)
        Me.lblPONO.Name = "lblPONO"
        Me.lblPONO.Size = New System.Drawing.Size(38, 17)
        Me.lblPONO.TabIndex = 46
        Me.lblPONO.Text = "PO NO"
        Me.lblPONO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "PO No.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Total Price:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "QTY:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNo.Location = New System.Drawing.Point(72, 44)
        Me.txtItemNo.MaxLength = 20
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(112, 21)
        Me.txtItemNo.TabIndex = 1
        Me.txtItemNo.Text = ""
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(192, 47)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(60, 17)
        Me.lblItemName.TabIndex = 39
        Me.lblItemName.Text = "Item Name"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(399, 284)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(80, 24)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "&Input"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(487, 284)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Close"
        '
        'btnChangePrice
        '
        Me.btnChangePrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChangePrice.Location = New System.Drawing.Point(112, 284)
        Me.btnChangePrice.Name = "btnChangePrice"
        Me.btnChangePrice.Size = New System.Drawing.Size(80, 24)
        Me.btnChangePrice.TabIndex = 80
        Me.btnChangePrice.Text = "&Change Price"
        '
        'frmCreatePO02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(570, 312)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddnew)
        Me.Controls.Add(Me.btnChangePrice)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreatePO02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Item Information"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtTotalRecieve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim adoDSItem As DataSet

    Private Sub frmCreatePO02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim lngRow As Long

        Try
            blnCancel = True
            adoDSItem = svcWarehouse.GetItemLOV("", APP_ID)

            If blnAddNew Then
                If Trim(txtItemNo.Text) = "" Then
                    lblItemName.Text = ""
                End If
                txtTotalPrice.Enabled = False
            Else
                txtItemNo.Enabled = False
            End If
            btnChangePrice.Enabled = False

        Catch ex As Exception
            Throw ex
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddNew = blnAdd
    End Sub

    Public Sub Add(ByVal strPoNo As String)
        lblPONO.Text = strPoNo
    End Sub

    Public Sub Modify(ByVal strItemNo As String, _
                      ByVal strItemName As String, _
                      ByVal strItemQTY As String, _
                      ByVal strItemPrice As String, _
                      ByVal strItemTotalPrice As String, _
                      ByVal intRecieve As Integer)

        txtItemNo.Text = strItemNo
        lblItemName.Text = strItemName
        txtQTY.Text = strItemQTY
        txtPrice.Text = strItemPrice
        txtTotalPrice.Text = strItemTotalPrice
        txtTotalRecieve.Text = intRecieve
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

        Try
            adoDataTable = adoDS.Tables("INPUTITEM")
            adoDataRow = adoDataTable.NewRow()
            adoDataRow("ITEM_NO") = txtItemNo.Text
            adoDataRow("ITEM_NAME") = lblItemName.Text
            adoDataRow("ITEM_QTY") = txtQTY.Text
            adoDataRow("ITEM_PRICE") = txtPrice.Text
            adoDataRow("ITEM_TOTALPRICE") = txtTotalPrice.Text
            adoDataTable.Rows.Add(adoDataRow)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow

        Try
            If adoDS.Tables("INPUTITEM").Rows.Count > 0 Then
                adoRow = adoDS.Tables("INPUTITEM").Rows(0)
                txtItemNo.Text = adoRow!ITEM_NO
                lblItemName.Text = adoRow!ITEM_NAME
                txtQTY.Text = adoRow!ITEM_QTY
                txtPrice.Text = adoRow!ITEM_PRICE
                txtTotalPrice.Text = adoRow!ITEM_TOTALPRICE
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If ValidateEmptyField(txtItemNo) Then
            Exit Sub
        End If
        If ValidateEmptyField(lblItemName) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtQTY) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtPrice) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtTotalPrice) Then
            Exit Sub
        End If
        If txtQTY.Text = 0 Then
            MessageBox.Show("The Field can not be = 0, Please type the correct number.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQTY.Focus()
            Exit Sub
        End If
        If txtQTY.Text < txtTotalRecieve.Text Then
            MessageBox.Show("The QTY must be equal or bigger than the Recieve No.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQTY.Focus()
            Exit Sub
        End If
        If txtPrice.Text = 0 Then
            MessageBox.Show("The Field can not be = 0, Please type the correct number.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrice.Focus()
            Exit Sub
        End If
        txtPrice_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        Try
            adoDS.Tables.Add("INPUTITEM")

            adoColumn = New DataColumn("PO_NO")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ITEM_NO")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ITEM_NAME")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ITEM_QTY")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ITEM_PRICE")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            adoColumn = New DataColumn("ITEM_TOTALPRICE")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("INPUTITEM").Columns.Add(adoColumn)

            CreateResourceCodeRs = adoDS

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub txtItemNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemNo.KeyDown
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim myForm As New frmLOV
        Dim adoRow As DataRow

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                myForm.Initialize(txtItemNo.Text, adoDSItem, "ITEMLOV")

Form_Loop:
                myForm.ShowDialog()
                If myForm.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDS = myForm.GetDataSet()
                    If adoDS.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("RESOURCEINFO").Rows(0)
                        txtItemNo.Text = adoRow!RESOURCE_CODE
                        lblItemName.Text = adoRow!RESOURCE_DESC
                        adoDS.Dispose()
                        Me.btnChangePrice.Enabled = True
                    Else
                        Me.btnChangePrice.Enabled = False
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
        End Try
    End Sub

    Private Sub txtItemNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemNo.TextChanged
        If blnAddNew Then
            'If Trim(txtItemNo.Text) = "" Then
            lblItemName.Text = ""
            'End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        blnCancel = True
        Me.Dispose()

        If Not (adoDSItem Is Nothing) Then
            adoDSItem.Dispose()
            adoDSItem = Nothing
        End If
    End Sub

    Private Sub txtItemNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemNo.DoubleClick
        txtItemNo_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Private Sub txtPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyDown
        Dim lngQTY As Long
        Dim lngPrice As Long
        Dim lngTotalPrice As Long

        Try
            If e.KeyCode = Keys.Return Then
                lngQTY = txtQTY.Text
                lngPrice = txtPrice.Text
                If txtQTY.Text <> "" And txtPrice.Text <> "" Then
                    lngTotalPrice = lngQTY * lngPrice
                    txtTotalPrice.Text = lngTotalPrice
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtPrice_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.DoubleClick
        txtPrice_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        If blnAddNew Then
            txtTotalPrice.Text = 0
        End If
    End Sub

    Private Sub txtQTY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQTY.KeyDown
        Dim lngQTY As Long
        Dim lngPrice As Long
        Dim lngTotalPrice As Long

        Try
            If e.KeyCode = Keys.Return Then
                lngQTY = txtQTY.Text
                lngPrice = txtPrice.Text
                If txtQTY.Text <> "" And txtPrice.Text <> "" Then
                    lngTotalPrice = lngQTY * lngPrice
                    txtTotalPrice.Text = lngTotalPrice
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub txtQTY_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.DoubleClick
        txtQTY_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub txtQTY_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.TextChanged
        If blnAddNew Then
            txtTotalPrice.Text = 0
        End If
    End Sub

    Private Sub txtQTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.Enter
        txtQTY.Select(0, txtQTY.Text.Length)
    End Sub

    Private Sub txtPrice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.Enter
        txtPrice.Select(0, txtPrice.Text.Length)
    End Sub

    Private Sub frmCreatePO02_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtItemNo.Focus()
    End Sub

    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDS As New DataSet
        Dim strResult As String
        Dim myForm As New frmItem01
        Dim adoRow As DataRow

        Try
            myForm.Initialize(True)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                'Input new Item
                strResult = svcWarehouse.AddNewItem(adoDS, APP_ID)

                'Refresh Item List
                adoDSItem = svcWarehouse.GetItemLOV("", APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo Form_Loop
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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

    Private Sub btnChangePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePrice.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDS As New DataSet
        Dim myForm As New frmItem01
        Try

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcWarehouse.GetItemInfo("", "", Me.txtItemNo.Text, APP_ID)
            myForm.Initialize(False)
            myForm.FillField(adoDS)
            adoDS.Dispose()
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                svcWarehouse.UpdateItemInfo(adoDS, APP_ID)
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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
End Class
