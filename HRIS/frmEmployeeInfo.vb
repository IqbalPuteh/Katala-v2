Public Class frmEmployeeInfo
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEmployeeId, Me.txtEmployeeName, Me.btnSelect, Me.Label3, Me.Label1, Me.Label2})
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(120, 48)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(120, 72)
        Me.txtEmployeeName.MaxLength = 150
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(312, 21)
        Me.txtEmployeeName.TabIndex = 2
        Me.txtEmployeeName.Text = ""
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Black
        Me.btnSelect.Location = New System.Drawing.Point(504, 66)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 27)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Employee Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(48, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Type the Employee Id or Name then click on the Select button."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 51)
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
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Profile Information"
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
        Me.ColumnHeader2.Text = "Employee Id"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Employee Name - Preferred Name"
        Me.ColumnHeader3.Width = 380
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 75
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(518, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(430, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(342, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(255, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'frmEmployeeInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(601, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnDelete, Me.btnModify, Me.btnAddNew, Me.GroupBox2, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Employee Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtEmployeeId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeId.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 380
        btnAddNew.Enabled = False
        btnModify.Enabled = False
        btnDelete.Enabled = False
        If Trim(txtEmployeeId.Text) = "" Then
            txtEmployeeName.Enabled = True
        Else
            txtEmployeeName.Enabled = False
        End If
    End Sub

    Private Sub txtEmployeename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeName.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 380
        btnAddNew.Enabled = False
        btnModify.Enabled = False
        btnDelete.Enabled = False
        If Trim(txtEmployeeName.Text) = "" Then
            txtEmployeeId.Enabled = True
        Else
            txtEmployeeId.Enabled = False
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            lvwList.Items.Clear()
            myDS = svcHRIS.GetEmployeeInfo(txtEmployeeId.Text, txtEmployeeName.Text, APP_ID)

            If myDS.Tables("EMPINFO").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("EMPINFO").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!EMPLOYEE_ID)
                    objItem.SubItems.Add(Trim(adoRow!FIRST_NAME & " " & Trim(NullToString(adoRow!MIDDLE_NAME)) & " " & Trim(NullToString(adoRow!LAST_NAME))) & "-" & adoRow!PREF_NAME)
                    objItem.SubItems.Add(IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active"))
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Employee data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            If lvwList.Items.Count > 15 Then
                lvwList.Columns(2).Width = 364
            Else
                lvwList.Columns(2).Width = 380
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            myDS.Dispose()
            svcHRIS.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmEmployeeInfo01()
        Dim adoRow As DataRow

        Try
            myForm.Initialize(True)
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcHRIS.AddNewEmployee(adoDS, APP_ID)
                adoRow = adoDS.Tables("EMPLOYEEPROFILE").Rows(0)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    txtEmployeeId.Text = ""
                    txtEmployeeName.Text = ""
                    lvwList.Items.Clear()
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!EMPLOYEE_ID)
                    objItem.SubItems.Add(Trim(adoRow!FIRST_NAME & " " & Trim(NullToString(adoRow!MIDDLE_NAME)) & " " & Trim(NullToString(adoRow!LAST_NAME))) & "-" & adoRow!PREF_NAME)
                    objItem.SubItems.Add(IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active"))
                    objItem.Selected = True

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
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim adoDS As New DataSet()
        Dim myForm As New frmEmployeeInfo01()
        Dim adoRow As DataRow

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcHRIS.GetEmployeeInfo(lvwList.SelectedItems.Item(0).SubItems(1).Text, "", APP_ID)
            If adoDS.Tables("EMPINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                svcHRIS.UpdateEmployeeInfo(adoDS, APP_ID)
                adoRow = adoDS.Tables("EMPLOYEEPROFILE").Rows(0)
                lvwList.SelectedItems.Item(0).SubItems(2).Text = Trim(adoRow!FIRST_NAME & " " & Trim(NullToString(adoRow!MIDDLE_NAME)) & " " & Trim(NullToString(adoRow!LAST_NAME))) & "-" & adoRow!PREF_NAME
                lvwList.SelectedItems.Item(0).SubItems(3).Text = IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim intSelectedItem As Integer
        Dim intCount As Integer
        Dim strResult As String

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If

            If Trim(lvwList.SelectedItems.Item(0).SubItems(3).Text) = "Not Active" Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Employee Status = Not Active can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure want to delete this Employee Data?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                strResult = svcHRIS.DeleteEmployee(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
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
                    Else
                            btnModify.Enabled = False
                            btnDelete.Enabled = False
                        End If

                        If lvwList.Items.Count > 15 Then
                            lvwList.Columns(2).Width = 364
                        Else
                            lvwList.Columns(2).Width = 380
                        End If
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

    Private Sub frmEmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "HRMODULE", APP_ID)

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

End Class
