Public Class frmUserAccess
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeStatus As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserAccess))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblEmployeeStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
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
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSelect, Me.lblEmployeeStatus, Me.Label5, Me.lblEmployeeName, Me.Label3, Me.Label1, Me.txtUserId, Me.Label2})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 136)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(536, 96)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 18
        Me.btnSelect.Text = "&Select"
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.AutoSize = True
        Me.lblEmployeeStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeStatus.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(104, 104)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(110, 14)
        Me.lblEmployeeStatus.TabIndex = 17
        Me.lblEmployeeStatus.Text = "lblEmployeeStatus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(61, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Location = New System.Drawing.Point(104, 80)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(107, 14)
        Me.lblEmployeeName.TabIndex = 15
        Me.lblEmployeeName.Text = "lblEmployeeName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Employee Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in user id and click on Select button to view user information."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserId
        '
        Me.txtUserId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserId.Location = New System.Drawing.Point(104, 48)
        Me.txtUserId.MaxLength = 20
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(168, 21)
        Me.txtUserId.TabIndex = 6
        Me.txtUserId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 256)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System Access Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(636, 236)
        Me.lvwList.TabIndex = 1
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Program Name"
        Me.ColumnHeader2.Width = 384
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Access Value"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(471, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(383, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 12
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(295, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 11
        Me.btnAddNew.Text = "&Add New"
        '
        'frmUserAccess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnDelete, Me.btnModify, Me.btnAddNew, Me.GroupBox2, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review User Access Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmUserAccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblEmployeeName.Text = ""
        lblEmployeeStatus.Text = ""
    End Sub

    Private Sub txtUserId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserId.TextChanged
        lblEmployeeName.Text = ""
        lblEmployeeStatus.Text = ""
        btnAddNew.Enabled = False
        btnModify.Enabled = False
        btnDelete.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub txtUserId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserId.KeyDown
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim adoDS As New DataSet()
        Dim adoRow As DataRow

        Try
            If e.KeyCode = Keys.Return Then
                If txtUserId.Text = "" Then
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcSecurity.GetUserInfo(txtUserId.Text, APP_ID)
                If adoDS.Tables("USERPROFILE").Rows.Count = 0 Then
                    MessageBox.Show("User Id does not exist.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUserId.Focus()
                Else
                    adoRow = adoDS.Tables("USERPROFILE").Rows(0)
                    lblEmployeeName.Text = Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME)))
                    lblEmployeeStatus.Text = IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active")
                    btnSelect.Focus()
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            adoDS.Dispose()
        End Try
    End Sub

    Private Sub txtUserId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserId.Leave
        If lblEmployeeName.Text = "" And txtUserId.Text <> "" Then
            txtUserId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            If txtUserId.Text = "" Or lblEmployeeName.Text = "" Then
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myDS = svcSecurity.GetUserAccessRecord(txtUserId.Text, APP_ID)
            lvwList.Items.Clear()
            For Each adoRow In myDS.Tables("USER_ACCESS").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)
                objItem.Tag = adoRow!PROGRAM_ID
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(NullToString(adoRow!PROGRAM_NAME) & " (" & adoRow!PROGRAM_ID & ")")
                objItem.SubItems.Add(adoRow!ACCESS_VALUE)
            Next
            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnAddNew.Enabled = True
                btnModify.Enabled = True
                btnDelete.Enabled = True
            Else
                btnAddNew.Enabled = True
                btnModify.Enabled = False
                btnDelete.Enabled = False
            End If
            If lvwList.Items.Count > 14 Then
                lvwList.Columns(2).Width = 184
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            myDS.Dispose()
            svcSecurity.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim myForm As New frmUserAccess01()
        Dim adoDS As New DataSet()
        Dim strResult As String
        Dim objItem As ListViewItem

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcHouseKeeping.GetResourceCode("SECURITY", "MODULE", APP_ID)
            myForm.Initialization(adoDS, txtUserId.Text, lblEmployeeName.Text, lblEmployeeStatus.Text)
            adoDS.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcSecurity.AddNewProgramAccessToUser(adoDS, APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    objItem.Tag = adoDS.Tables("USER_ACCESS").Rows(0)("PROGRAM_ID")
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoDS.Tables("USER_ACCESS").Rows(0)("PROGRAM_NAME") & " (" & adoDS.Tables("USER_ACCESS").Rows(0)("PROGRAM_ID") & ")")
                    objItem.SubItems.Add(adoDS.Tables("USER_ACCESS").Rows(0)("ACCESS_VALUE"))
                    objItem.SubItems.Add("Active")
                    objItem.Selected = True
                    btnModify.Enabled = True
                    btnDelete.Enabled = True
                End If
                If lvwList.Items.Count > 14 Then
                    lvwList.Columns(2).Width = 184
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
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            If Not (svcHouseKeeping Is Nothing) Then
                svcHouseKeeping.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim intSelectedItem As Integer
        Dim intCount As Integer

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure want to delete this record?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                svcSecurity.DeleteUserAccess(txtUserId.Text, lvwList.SelectedItems.Item(0).Tag, APP_ID)
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
                Else
                    btnModify.Enabled = False
                    btnDelete.Enabled = False
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim adoDS As New DataSet()
        Dim myForm As New frmUserAccess01()
        Dim intSequence As Integer

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If

            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcHouseKeeping.GetResourceCode("SECURITY", "MODULE", APP_ID)
            myForm.Initialization(adoDS, txtUserId.Text, lblEmployeeName.Text, lblEmployeeStatus.Text)
            adoDS.Dispose()

            adoDS = svcSecurity.GetUserAccessInfo(txtUserId.Text, lvwList.SelectedItems.Item(0).Tag, APP_ID)
            If adoDS.Tables("USER_ACCESS").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            myForm.FillField(adoDS)
            adoDS.Dispose()
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                svcSecurity.UpdateUserAccess(adoDS, APP_ID)
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoDS.Tables("USER_ACCESS").Rows(0)("ACCESS_VALUE")
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcHouseKeeping Is Nothing) Then
                svcHouseKeeping.Dispose()
            End If
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub
End Class
