Public Class frmAdjustmentItem
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdjustmentItem))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblItemName = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnReports = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 256)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adjustment Stock Item Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(636, 236)
        Me.lvwList.TabIndex = 5
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Adjust Date"
        Me.ColumnHeader2.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Adjsut By"
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Warehouse Name"
        Me.ColumnHeader4.Width = 300
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "AdjId"
        Me.ColumnHeader7.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 136)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(251, 81)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(65, 17)
        Me.lblItemName.TabIndex = 66
        Me.lblItemName.Text = "ItemName"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(248, 50)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpEndDate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(224, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "To"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Checked = False
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(96, 50)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartDate.TabIndex = 1
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(30, 53)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(67, 17)
        Me.lblTransDate.TabIndex = 62
        Me.lblTransDate.Text = "Adjust Date:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(536, 96)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(32, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select in the options below then click on the select button to view movement item" & _
        " information."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(96, 78)
        Me.txtItemCode.MaxLength = 20
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(152, 21)
        Me.txtItemCode.TabIndex = 3
        Me.txtItemCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(352, 396)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(112, 24)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "&Adjust Stock Item"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(472, 396)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 7
        Me.btnModify.Text = "&Modify"
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(4, 396)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(80, 24)
        Me.btnReports.TabIndex = 9
        Me.btnReports.Text = "&Reports"
        '
        'frmAdjustmentItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjustmentItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Adjustment Stock Item"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer
    Dim adoDSItem As DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(3).Width = 300
        lblItemName.Text = ""
        btnModify.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub txtItemCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyDown
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmLOV()
        Dim adoRow As DataRow

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                myForm.Initialize(txtItemCode.Text, adoDSItem, "ITEMSTOCKLOV")

Form_Loop:
                myForm.ShowDialog()
                If myForm.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDS = myForm.GetDataSet()
                    If adoDS.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("RESOURCEINFO").Rows(0)
                        txtItemCode.Text = adoRow!RESOURCE_CODE
                        lblItemName.Text = adoRow!RESOURCE_DESC
                        adoDS.Dispose()
                        btnSelect.Enabled = True
                        btnAddNew.Enabled = True
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

    Private Sub txtItemCode_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.DoubleClick
        txtItemCode_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strStartDate As String
        Dim strEndDate As String

        Try
            lvwList.Items.Clear()
            If Trim(txtItemCode.Text) <> "" And lblItemName.Text = "" Then
                MessageBox.Show("Please type the correct Item No.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtItemCode.Focus()
                Exit Sub
            End If
            If dtpEndDate.Value < dtpStartDate.Value Then
                MessageBox.Show("End Date must be greater than Start Date.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpStartDate.Focus()
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            If dtpStartDate.Checked Then
                strStartDate = Format(dtpStartDate.Value, "dd/MM/yyyy")
            Else
                strStartDate = ""
            End If
            If dtpEndDate.Checked Then
                strEndDate = Format(dtpEndDate.Value, "dd/MM/yyyy")
            Else
                strEndDate = ""
            End If
            myDS = svcWarehouse.GetAdjustmentItem(txtItemCode.Text, strStartDate, strEndDate, APP_ID)
            If myDS.Tables("ADJUST").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("ADJUST").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adoRow!ADJ_DATE, "dd-MMM-yy"))
                    objItem.SubItems.Add(adoRow!ADJ_BY)
                    objItem.SubItems.Add(adoRow!WAREHOUSE_NAME)
                    objItem.SubItems.Add(adoRow!ADJ_ID)
                    objItem.Selected = True
                Next
                btnModify.Enabled = True
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Adjustment Item data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                If intAccessValue = 9 Then
                    'btnDelete.Enabled = True
                Else
                    'btnDelete.Enabled = False
                End If
                btnModify.Enabled = True
                btnReports.Enabled = True
            Else
                btnModify.Enabled = False
                btnReports.Enabled = False
            End If
            If lvwList.Items.Count > 15 Then
                lvwList.Columns(3).Width = 284
            Else
                lvwList.Columns(3).Width = 300
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDSHeader As New DataSet()
        Dim adoDSDetail As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmAdjustmentItem01()
        Dim adoRow As DataRow
        Dim intMaxAdjId As Integer

        Try
            myForm.Initialize(True)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDSHeader = myForm.GetDataSet01()
                adoDSDetail = myForm.GetDataSet02()
                strResult = svcWarehouse.AddAdjustStock(adoDSHeader, adoDSDetail, APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    adoRow = adoDSHeader.Tables("ADJUST_STOCK").Rows(0)
                    intMaxAdjId = svcWarehouse.GetMaxAdjId(adoRow!ADJ_DATE, "", APP_ID)
                    If intMaxAdjId > 0 Then
                        adoDSHeader.Dispose()
                        adoDSHeader = svcWarehouse.GetAdjustment(intMaxAdjId, APP_ID)
                        adoRow = adoDSHeader.Tables("ADJUSTMENT").Rows(0)

                        lvwList.Items.Clear()
                        objItem = New ListViewItem(lvwList.Items.Count + 1)
                        lvwList.Items.Add(objItem)
                        objItem.SubItems.Add(Format(adoRow!ADJ_DATE, "dd-MMM-yy"))
                        objItem.SubItems.Add(adoRow!ADJ_BY)
                        objItem.SubItems.Add(adoRow!WAREHOUSE_NAME)
                        objItem.SubItems.Add(adoRow!ADJ_ID)
                        objItem.Selected = True
                    End If

                    If lvwList.Items.Count > 0 Then
                        lvwList.Items(0).Selected = True
                        btnSelect.Enabled = True
                        If intAccessValue = 9 Then
                            'btnDelete.Enabled = True
                        Else
                            'btnDelete.Enabled = False
                        End If
                        btnModify.Enabled = True
                        btnReports.Enabled = True
                    Else
                        btnModify.Enabled = False
                        btnReports.Enabled = False
                    End If
                    If lvwList.Items.Count > 15 Then
                        lvwList.Columns(3).Width = 284
                    Else
                        lvwList.Columns(3).Width = 300
                    End If
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            myForm.grpStock.Enabled = False
            myForm.grpMovement.Enabled = False
            myForm.btnSave.Enabled = False
            GoTo Form_Loop
        Finally
            If Not (adoDSHeader Is Nothing) Then
                adoDSHeader.Dispose()
            End If
            If Not (adoDSDetail Is Nothing) Then
                adoDSDetail.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub frmMovementItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        lvwList.Items.Clear()
        lvwList.Columns(3).Width = 300
        btnModify.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        lvwList.Items.Clear()
        lvwList.Columns(3).Width = 300
        btnModify.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub frmAdjustmentItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim svcWarehouse As New Warehouse.svcWarehouse()

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "WAREHOUSE", APP_ID)
            adoDSItem = svcWarehouse.GetItemStockLOV("", APP_ID)
            dtpStartDate.Value = Now
            dtpEndDate.Value = Now
            dtpStartDate.Checked = True
            dtpEndDate.Checked = True
            dtpStartDate.Checked = False
            dtpEndDate.Checked = False

            btnAddNew.Enabled = True
            btnSelect.Enabled = True
            lblItemName.Text = ""
            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                If intAccessValue = 9 Then
                    'btnDelete.Enabled = True
                Else
                    'btnDelete.Enabled = False
                End If
                btnModify.Enabled = True
                btnReports.Enabled = True
            Else
                btnModify.Enabled = False
                btnReports.Enabled = False
            End If
            dtpStartDate.Focus()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDSHeader As New DataSet()
        Dim adoDSDetail As New DataSet()
        Dim myForm As New frmAdjustmentItem01()
        Dim adoRow As DataRow

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDSHeader = svcWarehouse.GetAdjHeader(lvwList.SelectedItems.Item(0).SubItems(4).Text, APP_ID)
            adoDSDetail = svcWarehouse.GetAdjDetail(lvwList.SelectedItems.Item(0).SubItems(4).Text, APP_ID)
            myForm.Initialize(False)
            myForm.FillField(adoDSHeader, adoDSDetail)
            adoDSHeader.Dispose()
            adoDSDetail.Dispose()

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDSHeader = myForm.GetDataSet01()
                adoDSDetail = myForm.GetDataSet02()

                svcWarehouse.UpdateAdjustment(adoDSHeader, adoDSDetail, APP_ID)
                adoRow = adoDSHeader.Tables("ADJUST_STOCK").Rows(0)
                lvwList.SelectedItems.Item(0).SubItems(1).Text = Format(adoRow!ADJ_DATE, "dd-MMM-yy")
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!ADJ_BY
                btnSelect.Enabled = True
                btnModify.Enabled = True
                adoDSHeader.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            myForm.grpStock.Enabled = False
            myForm.grpMovement.Enabled = False
            myForm.btnSave.Enabled = False
            GoTo Form_Loop
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            If Not (adoDSHeader Is Nothing) Then
                adoDSHeader.Dispose()
            End If
            If Not (adoDSDetail Is Nothing) Then
                adoDSDetail.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModify_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim myForm As New frmAdjustmentItemRpt

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            myForm.Initialize(False)
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then

            End If

        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
        End Try
    End Sub
End Class
