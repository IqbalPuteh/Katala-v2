Public Class frmEmployeeNote
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
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents lblActiveStatus As System.Windows.Forms.Label
    Friend WithEvents lblTitleActive As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeNote))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.lblActiveStatus = New System.Windows.Forms.Label()
        Me.lblTitleActive = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblActiveStatus, Me.lblTitleActive, Me.txtEmployeeId, Me.btnSelect, Me.lblEmployeeName, Me.Label1, Me.Label2})
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 112)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(120, 49)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Black
        Me.btnSelect.Location = New System.Drawing.Point(496, 64)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 27)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Location = New System.Drawing.Point(205, 52)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(96, 14)
        Me.lblEmployeeName.TabIndex = 22
        Me.lblEmployeeName.Text = "Employee Name"
        Me.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(48, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Type the Employee Id then click on the Select button."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(52, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Employee Id: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 264)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Performance"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(594, 244)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 35
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Position Id"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Position Name"
        Me.ColumnHeader3.Width = 350
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Entry Date"
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "RecordId"
        Me.ColumnHeader5.Width = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(518, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(430, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "&Delete"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(254, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 17
        Me.btnAddNew.Text = "&Add New"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(342, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 18
        Me.btnModify.Text = "&Modify"
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(119, 77)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(90, 14)
        Me.lblActiveStatus.TabIndex = 26
        Me.lblActiveStatus.Text = "lblActiveStatus"
        '
        'lblTitleActive
        '
        Me.lblTitleActive.AutoSize = True
        Me.lblTitleActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleActive.ForeColor = System.Drawing.Color.Black
        Me.lblTitleActive.Location = New System.Drawing.Point(47, 77)
        Me.lblTitleActive.Name = "lblTitleActive"
        Me.lblTitleActive.Size = New System.Drawing.Size(73, 14)
        Me.lblTitleActive.TabIndex = 25
        Me.lblTitleActive.Text = "Active Status:"
        '
        'frmEmployeeNote
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(601, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnDelete, Me.btnAddNew, Me.btnModify, Me.GroupBox2, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Employee Performance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmEmployeeNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "HRMODULE", APP_ID)
            lblEmployeeName.Text = ""
            lblActiveStatus.Text = ""
            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnModify.Enabled = True
            Else
                btnModify.Enabled = False
            End If
            If intAccessValue = 9 And lvwList.Items.Count > 0 Then
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            If lblEmployeeName.Text = "" Then
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            myDS = svcHRIS.GetEMPNote(txtEmployeeId.Text, "", APP_ID)
            If myDS.Tables("EMPNOTE").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("EMPNOTE").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!POSITION_ID)
                    objItem.SubItems.Add(adoRow!POSITION_NAME)
                    objItem.SubItems.Add(Format(adoRow!ENTRY_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(adoRow!RECORD_ID)
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Employee Performance data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 334
            Else
                lvwList.Columns(2).Width = 350
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
            Else
                btnModify.Enabled = False
                btnDelete.Enabled = False
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            myDS.Dispose()
            svcHRIS.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub txtEmployeeId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeId.TextChanged
        lblEmployeeName.Text = ""
        lblActiveStatus.Text = ""
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 350
        btnModify.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim myForm As New frmEmployeeNote01()
        Dim adoRow As DataRow
        Dim myDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim strEmployeeId As String
        Dim blnAdd As Boolean
        Dim strRecordId As String

        Try
            If lblEmployeeName.Text = "" Then
                Exit Sub
            End If
            If lblActiveStatus.Text = "Not Active" Then
                MessageBox.Show("Employee Status = Not Active can not be edit!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            blnAdd = True
            myForm.Initialize(blnAdd, txtEmployeeId.Text, lblEmployeeName.Text, "", "")

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                myDS = myForm.GetDataSet()
                svcHRIS.AddNewEMPNote(myDS, APP_ID)
                strEmployeeId = myDS.Tables("EMPNOTE").Rows(0)("EMPLOYEE_ID")
                myDS.Dispose()

                myDS = svcHRIS.GetLatestEMPNote(strEmployeeId, APP_ID)
                strRecordId = myDS.Tables("LATEMPNOTE").Rows(0)("RECORD_ID")
                myDS.Dispose()

                myDS = svcHRIS.GetEMPNote(strEmployeeId, strRecordId, APP_ID)
                lvwList.Items.Clear()
                lvwList.Columns(2).Width = 350
                If myDS.Tables("EMPNOTE").Rows.Count > 0 Then
                    For Each adoRow In myDS.Tables("EMPNOTE").Rows
                        objItem = New ListViewItem(lvwList.Items.Count + 1)
                        lvwList.Items.Add(objItem)
                        objItem.SubItems.Add(adoRow!POSITION_ID)
                        objItem.SubItems.Add(adoRow!POSITION_NAME)
                        objItem.SubItems.Add(Format(adoRow!ENTRY_DATE, "dd MMM yyyy"))
                        objItem.SubItems.Add(adoRow!RECORD_ID)
                        objItem.Selected = True
                    Next
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
                Else
                    btnModify.Enabled = False
                    btnDelete.Enabled = False
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim myDS As New DataSet()
        Dim myForm As New frmEmployeeNote01()
        Dim objItem As ListViewItem
        Dim lngRow As Long
        Dim blnAddNew As Boolean
        Dim adoRow As DataRow
        'Dim dtDate As Date
        Dim strRecordId As String
        Dim strPosId As String
        Dim strPosName As String

        Try
            blnAddNew = False
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If txtEmployeeId.Text = "" Then
                Exit Sub
            End If
            If lblEmployeeName.Text = "" Then
                Exit Sub
            End If

            strRecordId = lvwList.SelectedItems.Item(0).SubItems(4).Text
            strPosId = lvwList.SelectedItems.Item(0).SubItems(1).Text
            strPosName = lvwList.SelectedItems.Item(0).SubItems(2).Text

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myDS = svcHRIS.GetEMPNote(txtEmployeeId.Text, strRecordId, APP_ID)

            myForm.Initialize(blnAddNew, txtEmployeeId.Text, lblEmployeeName.Text, strPosId, strPosName)
            myForm.FillField(myDS)
            myDS.Dispose()

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                myDS = myForm.GetDataSet()
                svcHRIS.UpdateEMPNote(myDS, APP_ID)
                adoRow = myDS.Tables("EMPNOTE").Rows(0)
                If myDS.Tables("EMPNOTE").Rows.Count > 0 Then
                    lvwList.SelectedItems.Item(0).SubItems(3).Text = Format(adoRow!ENTRY_DATE, "dd MMM yyyy")
                    lvwList.SelectedItems.Item(0).SubItems(4).Text = CStr(adoRow!RECORD_ID)
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
                Else
                    btnModify.Enabled = False
                    btnDelete.Enabled = False
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim intSelectedItem As Integer
        Dim intCount As Integer
        Dim strRecordId As String
        Dim adoDS As DataSet

        Try
            If txtEmployeeId.Text = "" Then
                Exit Sub
            End If
            If lblEmployeeName.Text = "" Then
                Exit Sub
            End If
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If

            If MessageBox.Show("Are you sure want to delete this infromation?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcHRIS.GetLatestEMPNote(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPNOTE").Rows.Count > 0 Then
                    strRecordId = lvwList.SelectedItems.Item(0).SubItems(4).Text
                    If strRecordId <> CStr(adoDS.Tables("LATEMPNOTE").Rows(0)("RECORD_ID")) Then
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                        MessageBox.Show("Employee Peformance history can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If adoDS.Tables("LATEMPNOTE").Rows(0)("ACTIVE_STATUS") = "N" Then
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                        MessageBox.Show("Employee Status = Not Active can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                adoDS.Dispose()

                svcHRIS.DeleteEMPNote(txtEmployeeId.Text, lvwList.SelectedItems.Item(0).SubItems(4).Text, APP_ID)
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
                Else
                    btnModify.Enabled = False
                    btnDelete.Enabled = False
                End If

                If lvwList.Items.Count > 14 Then
                    lvwList.Columns(2).Width = 334
                Else
                    lvwList.Columns(2).Width = 350
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtEmployeeId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeId.KeyDown
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim myDS As New DataSet()

        If e.KeyCode = Keys.Enter Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myDS = svcHRIS.GetEmployeeName(txtEmployeeId.Text, APP_ID)
            If myDS.Tables("EMPINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("The Employee Name data is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblEmployeeName.Text = ""
                Exit Sub
            End If
            lblEmployeeName.Text = myDS.Tables("EMPINFO").Rows(0)("FIRST_NAME") & " " & myDS.Tables("EMPINFO").Rows(0)("MIDDLE_NAME") & " " & " " & myDS.Tables("EMPINFO").Rows(0)("LAST_NAME")
            If myDS.Tables("EMPINFO").Rows(0)("ACTIVE_STATUS") = "A" Then
                lblActiveStatus.Text = "Active"
            Else
                lblActiveStatus.Text = "Not Active"
            End If
            myDS.Dispose()
            btnSelect.Focus()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

End Class
