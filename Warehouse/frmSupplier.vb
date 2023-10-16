Public Class frmSupplier
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierCode As System.Windows.Forms.TextBox
    Friend WithEvents cboActiveStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnReports As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSupplier))
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboActiveStatus = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSupplierName = New System.Windows.Forms.TextBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSupplierCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnReports = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(560, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(472, 396)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(384, 396)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 7
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(296, 396)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "&Add New"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 256)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier Detail Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
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
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Supplier No."
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Supplier Name"
        Me.ColumnHeader3.Width = 320
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cboActiveStatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSupplierCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 128)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'cboActiveStatus
        '
        Me.cboActiveStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActiveStatus.Items.AddRange(New Object() {"All", "Active", "Not Active"})
        Me.cboActiveStatus.Location = New System.Drawing.Point(360, 51)
        Me.cboActiveStatus.Name = "cboActiveStatus"
        Me.cboActiveStatus.Size = New System.Drawing.Size(112, 21)
        Me.cboActiveStatus.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(285, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Active Status:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupplierName
        '
        Me.txtSupplierName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSupplierName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplierName.Location = New System.Drawing.Point(104, 80)
        Me.txtSupplierName.MaxLength = 20
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(368, 21)
        Me.txtSupplierName.TabIndex = 3
        Me.txtSupplierName.Text = ""
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(520, 78)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "&Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Supplier Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the Supplier No or Name then click on the select button to view supplier " & _
        "information."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupplierCode
        '
        Me.txtSupplierCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSupplierCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplierCode.Location = New System.Drawing.Point(104, 51)
        Me.txtSupplierCode.MaxLength = 20
        Me.txtSupplierCode.Name = "txtSupplierCode"
        Me.txtSupplierCode.Size = New System.Drawing.Size(120, 21)
        Me.txtSupplierCode.TabIndex = 1
        Me.txtSupplierCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Supplier No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnReports
        '
        Me.btnReports.Enabled = False
        Me.btnReports.Location = New System.Drawing.Point(4, 396)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(80, 24)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "&Reports"
        '
        'frmSupplier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Supplier Detail Information"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtSupplierCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplierCode.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(3).Width = 150
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnReports.Enabled = False
        If Trim(txtSupplierCode.Text) = "" Then
            txtSupplierName.Enabled = True
        Else
            txtSupplierName.Enabled = False
        End If
    End Sub

    Private Sub txtSupplierName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplierName.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(3).Width = 150
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnReports.Enabled = False
        If Trim(txtSupplierName.Text) = "" Then
            txtSupplierCode.Enabled = True
        Else
            txtSupplierCode.Enabled = False
        End If
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "WAREHOUSE", APP_ID)

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnModify.Enabled = True
                If intAccessValue = 9 Then
                    btnDelete.Enabled = True
                Else
                    btnDelete.Enabled = False
                End If
                btnReports.Enabled = True
            Else
                btnModify.Enabled = False
                btnDelete.Enabled = False
                btnReports.Enabled = False
            End If
            btnAddNew.Enabled = True
            cboActiveStatus.SelectedIndex = 0

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim strActiveStatus As String

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            myDS = svcWarehouse.GetSuppInfo(txtSupplierCode.Text, txtSupplierName.Text, "", APP_ID)

            If cboActiveStatus.SelectedIndex = 0 Then
                strActiveStatus = ""
            ElseIf cboActiveStatus.SelectedIndex = 1 Then
                strActiveStatus = "Y"
            ElseIf cboActiveStatus.SelectedIndex = 2 Then
                strActiveStatus = "N"
            End If
            If myDS.Tables("SUPPLIERINFO").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("SUPPLIERINFO").Rows
                    If Trim(strActiveStatus) <> "" Then
                        If Trim(adoRow!ACTIVE_STATUS) = Trim(strActiveStatus) Then
                            objItem = New ListViewItem(lvwList.Items.Count + 1)
                            lvwList.Items.Add(objItem)
                            objItem.SubItems.Add(adoRow!SUPPLIER_NO)
                            objItem.SubItems.Add(adoRow!SUPPLIER_NAME)
                            If adoRow!ACTIVE_STATUS = "Y" Then
                                objItem.SubItems.Add("Active")
                            Else
                                objItem.SubItems.Add("Not Active")
                            End If
                            objItem.Selected = True
                        End If
                    Else
                        objItem = New ListViewItem(lvwList.Items.Count + 1)
                        lvwList.Items.Add(objItem)
                        objItem.SubItems.Add(adoRow!SUPPLIER_NO)
                        objItem.SubItems.Add(adoRow!SUPPLIER_NAME)
                        If adoRow!ACTIVE_STATUS = "Y" Then
                            objItem.SubItems.Add("Active")
                        Else
                            objItem.SubItems.Add("Not Active")
                        End If
                        objItem.Selected = True
                    End If
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Supplier data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            btnAddNew.Enabled = True
            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnModify.Enabled = True
                If intAccessValue = 9 Then
                    btnDelete.Enabled = True
                Else
                    btnDelete.Enabled = False
                End If
                btnReports.Enabled = True
            Else
                btnModify.Enabled = False
                btnDelete.Enabled = False
                btnReports.Enabled = False
            End If

            If lvwList.Items.Count > 15 Then
                lvwList.Columns(3).Width = 134
            Else
                lvwList.Columns(3).Width = 150
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            myDS.Dispose()
            svcWarehouse.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmSupplier01()
        Dim adoRow As DataRow

        Try
            myForm.Initialize(True)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcWarehouse.AddNewSupp(adoDS, APP_ID)
                adoRow = adoDS.Tables("SUPPLIERINFO").Rows(0)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    txtSupplierCode.Text = ""
                    txtSupplierName.Text = ""
                    lvwList.Items.Clear()
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!SUPPLIER_NO)
                    objItem.SubItems.Add(adoRow!SUPPLIER_NAME)
                    If adoRow!ACTIVE_STATUS = "Y" Then
                        objItem.SubItems.Add("Active")
                    Else
                        objItem.SubItems.Add("Not Active")
                    End If
                    objItem.Selected = True

                    If lvwList.Items.Count > 0 Then
                        lvwList.Items(0).Selected = True
                        btnModify.Enabled = True
                        If intAccessValue = 9 Then
                            btnDelete.Enabled = True
                        Else
                            btnDelete.Enabled = False
                        End If
                        btnReports.Enabled = True
                    Else
                        btnModify.Enabled = False
                        btnDelete.Enabled = False
                        btnReports.Enabled = False
                    End If

                    If lvwList.Items.Count > 15 Then
                        lvwList.Columns(3).Width = 134
                    Else
                        lvwList.Columns(3).Width = 150
                    End If
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            myForm.grbSupplier.Enabled = False
            myForm.btnSave.Enabled = False
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

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()
        Dim myForm As New frmSupplier01()
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
            adoDS = svcWarehouse.GetSuppInfo("", "", lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            If adoDS.Tables("SUPPLIERINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            myForm.Initialize(False)
            myForm.FillField(adoDS)
            adoDS.Dispose()
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                svcWarehouse.UpdateSuppInfo(adoDS, APP_ID)
                adoRow = adoDS.Tables("SUPPLIERINFO").Rows(0)
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!SUPPLIER_NAME
                If adoRow!ACTIVE_STATUS = "Y" Then
                    lvwList.SelectedItems.Item(0).SubItems(3).Text = "Active"
                Else
                    lvwList.SelectedItems.Item(0).SubItems(3).Text = "Not Active"
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            myForm.grbSupplier.Enabled = False
            myForm.btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim intSelectedItem As Integer
        Dim intCount As Integer
        Dim strResult As String

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Trim(lvwList.SelectedItems.Item(0).SubItems(3).Text) = "Not Active" Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Supplier Status = Not Active can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure want to delete this Supplier Data?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                strResult = svcWarehouse.DeleteSupp(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
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

                        If intAccessValue = 9 Then
                            btnDelete.Enabled = True
                        Else
                            btnDelete.Enabled = False
                        End If
                        btnReports.Enabled = True
                    Else
                        btnModify.Enabled = False
                        btnDelete.Enabled = False
                        btnReports.Enabled = False
                    End If

                    If lvwList.Items.Count > 15 Then
                        lvwList.Columns(3).Width = 134
                    Else
                        lvwList.Columns(3).Width = 150
                    End If
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub frmSupplier_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub txtSupplierCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSupplierCode.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtSupplierName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSupplierName.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub cboActiveStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboActiveStatus.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub cboActiveStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboActiveStatus.SelectedIndexChanged
        lvwList.Items.Clear()
        lvwList.Columns(3).Width = 150
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModify_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim myForm As New frmSupplierRpt

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

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
