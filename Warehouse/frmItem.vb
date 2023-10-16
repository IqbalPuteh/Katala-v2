Public Class frmItem
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnExpiryReport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItem))
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
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnReports = New System.Windows.Forms.Button
        Me.btnExpiryReport = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(558, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(470, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(382, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(294, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
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
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Detail Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(636, 236)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item No."
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item Name"
        Me.ColumnHeader3.Width = 230
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Expire Date"
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Max. Usage"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Min. Usage"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 136)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemName.Location = New System.Drawing.Point(104, 80)
        Me.txtItemName.MaxLength = 200
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(368, 21)
        Me.txtItemName.TabIndex = 2
        Me.txtItemName.Text = ""
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(520, 78)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Item Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(50, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the Item No. or Item Name then click on the select button to view item in" & _
        "formation."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(104, 51)
        Me.txtItemCode.MaxLength = 20
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(168, 21)
        Me.txtItemCode.TabIndex = 1
        Me.txtItemCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(4, 395)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(80, 24)
        Me.btnReports.TabIndex = 9
        Me.btnReports.Text = "&Reports"
        '
        'btnExpiryReport
        '
        Me.btnExpiryReport.Location = New System.Drawing.Point(88, 395)
        Me.btnExpiryReport.Name = "btnExpiryReport"
        Me.btnExpiryReport.Size = New System.Drawing.Size(88, 24)
        Me.btnExpiryReport.TabIndex = 17
        Me.btnExpiryReport.Text = "&Expired Reports"
        '
        'frmItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.Add(Me.btnExpiryReport)
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
        Me.Name = "frmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Item Detail Information"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 230
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnReports.Enabled = False
        If Trim(txtItemCode.Text) = "" Then
            txtItemName.Enabled = True
        Else
            txtItemName.Enabled = False
        End If
    End Sub

    Private Sub txtItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemName.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 230
        btnModify.Enabled = False
        btnDelete.Enabled = False
        btnReports.Enabled = False
        If Trim(txtItemName.Text) = "" Then
            txtItemCode.Enabled = True
        Else
            txtItemCode.Enabled = False
        End If
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub frmEmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "WAREHOUSE", APP_ID)
            If intAccessValue = 9 Then
                btnAddNew.Enabled = True
            Else
                btnAddNew.Enabled = False
            End If
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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

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

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            myDS = svcWarehouse.GetItemInfo(txtItemCode.Text, txtItemName.Text, "", APP_ID)

            If myDS.Tables("ITEMINFO").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("ITEMINFO").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!ITEM_NO)
                    objItem.SubItems.Add(adoRow!ITEM_NAME)
                    objItem.SubItems.Add(Format(adoRow!EXPIRE_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(adoRow!MAX_VALUE)
                    objItem.SubItems.Add(adoRow!MIN_VALUE)
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Item data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

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
                lvwList.Columns(2).Width = 214
            Else
                lvwList.Columns(2).Width = 230
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
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmItem01()
        Dim adoRow As DataRow

        Try
            myForm.Initialize(True)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcWarehouse.AddNewItem(adoDS, APP_ID)
                adoRow = adoDS.Tables("ITEMINFORMATION").Rows(0)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    txtItemCode.Text = ""
                    txtItemName.Text = ""
                    lvwList.Items.Clear()
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!ITEM_NO)
                    objItem.SubItems.Add(adoRow!ITEM_NAME)
                    objItem.SubItems.Add(Format(adoRow!EXPIRE_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(adoRow!MAX_VALUE)
                    objItem.SubItems.Add(adoRow!MIN_VALUE)
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
                        lvwList.Columns(2).Width = 214
                    Else
                        lvwList.Columns(2).Width = 230
                    End If
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            myForm.grpItem.Enabled = False
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
        Dim myForm As New frmItem01()
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
            adoDS = svcWarehouse.GetItemInfo("", "", lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            If adoDS.Tables("ITEMINFO").Rows.Count = 0 Then
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
                svcWarehouse.UpdateItemInfo(adoDS, APP_ID)
                adoRow = adoDS.Tables("ITEMINFORMATION").Rows(0)
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!ITEM_NAME
                lvwList.SelectedItems.Item(0).SubItems(3).Text = Format(adoRow!EXPIRE_DATE, "dd MMM yyyy")
                lvwList.SelectedItems.Item(0).SubItems(4).Text = adoRow!MAX_VALUE
                lvwList.SelectedItems.Item(0).SubItems(5).Text = adoRow!MIN_VALUE 
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            myForm.grpItem.Enabled = False
            myForm.btnSave.Enabled = False
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
                MessageBox.Show("Item Status = Not Active can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure want to delete this Item Data?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                strResult = svcWarehouse.DeleteItem(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
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
                        lvwList.Columns(2).Width = 214
                    Else
                        lvwList.Columns(2).Width = 230
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

    Private Sub frmItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub txtItemCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtItemName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemName.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModify_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim myForm As New frmItemRpt

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            myForm.Initialize(lvwList.SelectedItems.Item(0).SubItems(1).Text, lvwList.SelectedItems.Item(0).SubItems(2).Text)
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

    Private Sub btnExpiryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpiryReport.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDS As New DataSet

        Try
            adoDS = svcWarehouse.GetItemExpired(Now.AddMonths(3), APP_ID)
            If adoDS.Tables(0).Rows.Count > 0 Then
                Generate_Report_Expiry(adoDS, Now, Now.AddMonths(+3))
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If

            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub Generate_Report_Expiry(ByVal adoDS As DataSet, ByVal dtStartDate As Date, ByVal dtEndDate As Date)
        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet

        Try

            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_ITEM_EXPIRY.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(5, 3) = Format(dtStartDate, "dd MMM yyyy") & " to " & Format(dtEndDate, "dd MMM yyyy")
            xlWs.Cells(3, 5) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 5) = Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1

            For Each adoRow In adoDS.Tables(0).Rows
                xlWs.Cells(I, 1) = "'" & CInt(intNou) & "."
                xlWs.Cells(I, 2) = "'" & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 3) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 4) = NullToString(adoRow!RESOURCE_DESC)
                xlWs.Cells(I, 5) = Format(adoRow!EXPIRE_DATE, "dd MMM yyyy")
                'xlWs.Cells(I, 6) = CInt(adoRow!TOTAL_MINUS)
                intNou += 1
                I += 1
            Next
            I += 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 5)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 5)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 5)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlApp.UserControl = True
            xlWb.Application.Visible = True
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWb) Then
                    xlWb.Close(False)
                End If
                xlApp.Application.Quit()
                xlApp = Nothing
                xlWb = Nothing
                xlWs = Nothing
            End If
            Err.Clear()
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

End Class
