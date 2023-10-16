Public Class frmMembership
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
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembership))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMemberName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(120, 72)
        Me.txtMemberName.MaxLength = 100
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(408, 21)
        Me.txtMemberName.TabIndex = 2
        Me.txtMemberName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(82, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(120, 48)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.TabIndex = 1
        Me.txtMemberId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Membership No.:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(568, 69)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select the options below and click on select button !"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(706, 360)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Members Information"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(700, 340)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Member No."
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = " Name"
        Me.ColumnHeader3.Width = 230
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Employee Type"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Staff Type"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Active"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(624, 477)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(536, 477)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(448, 477)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(360, 477)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Loan Sts."
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 70
        '
        'frmMembership
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(706, 504)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembership"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Koperasi Membership Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet
        Dim recordCount As Int32
        Dim adoRow As DataRow

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If Trim(NullToString(txtMemberId.Text)) <> "" Then
                adoDS = svcMembership.GetMemberInfo(txtMemberId.Text, "", APP_ID)
            ElseIf Trim(NullToString(txtMemberName.Text)) <> "" Then
                adoDS = svcMembership.GetMemberInfo("", txtMemberName.Text, APP_ID)
            Else
                adoDS = svcMembership.GetMemberInfo("", "", APP_ID)
            End If
            If adoDS.Tables("MEMBERINFO").Rows.Count > 0 Then
                recordCount = 0
                lvwList.Items.Clear()
                For Each adoRow In adoDS.Tables("MEMBERINFO").Rows
                    Dim lvwItem As New ListViewItem()
                    lvwList.Items.Add(lvwItem)
                    recordCount = recordCount + 1
                    lvwItem.Text = recordCount.ToString
                    lvwItem.SubItems.Add(CStr(adoRow!MEMBERSHIP_NO))
                    lvwItem.SubItems.Add(NullToString(adoRow!FIRST_NAME) & " " & NullToString(adoRow!FAMILY_NAME))
                    lvwItem.SubItems.Add(adoRow!MEMBER_TYPE)
                    lvwItem.SubItems.Add(adoRow!STAFF_TYPE)
                    lvwItem.SubItems.Add(IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active"))
                    lvwItem.SubItems.Add(IIf(adoRow!LOAN_STATUS = "N", "No", "Yes"))
                    If adoRow!LOAN_STATUS <> "N" Then
                        lvwItem.ForeColor = Color.Red
                    Else
                        lvwItem.ForeColor = Color.Black
                    End If
                Next
                If lvwList.Items.Count > 0 Then
                    btnModify.Enabled = True
                    btnDelete.Enabled = True
                End If

                If lvwList.Items.Count > 22 Then
                    lvwList.Columns(5).Width = 100
                End If
            Else
                MessageBox.Show("No record was selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcMembership.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub frmMembership_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()

        intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "MEMBERSHIP", APP_ID)

        btnAddNew.Enabled = True
        svcSecurity.Dispose()
    End Sub

    Private Sub lvwList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.Click
        If Me.lvwList.Items.Count > 0 Then
            btnModify.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcMembership As New Membership.svcMembership()
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

            If intAccessValue <> 9 Then
                MessageBox.Show("You are not authorised to delete this record.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure want to delete this record?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If lvwList.SelectedItems.Item(0).SubItems(5).Text = "Not Active" Then
                    MessageBox.Show("The record is not active, not allowed to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                svcMembership.DeleteMemberInfo(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
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
            If Not (svcMembership Is Nothing) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim myForm As New frmMembership01()
        Dim adoDS As New DataSet()
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcHouseKeeping.GetResourceCode("MEMBERSHIP", "DEPARTMENT", APP_ID)
            myForm.Initialization(adoDS)
            adoDS.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcMembership.AddNewMemberInfo(adoDS, APP_ID)
                If strResult = "" Then
                    adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!BADGE_ID)
                    objItem.SubItems.Add(NullToString(adoRow!FIRST_NAME) & " " & NullToString(adoRow!FAMILY_NAME))
                    objItem.SubItems.Add(adoRow!MEMBERSHIP_TYPE)
                    objItem.SubItems.Add(adoRow!STAFF_TYPE)
                    objItem.SubItems.Add(IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active"))
                    objItem.SubItems.Add(IIf(adoRow!LOAN_STATUS = "N", "No", "Yes"))
                    If adoRow!LOAN_STATUS <> "N" Then
                        objItem.ForeColor = Color.Red
                    Else
                        objItem.ForeColor = Color.Black
                    End If
                    objItem.Selected = True
                    btnModify.Enabled = True
                    btnDelete.Enabled = True
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                Else
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                        MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GoTo Form_Loop
                    End If
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
            If Not (svcMembership Is Nothing) Then
                svcMembership.Dispose()
            End If
            If Not (svcHouseKeeping Is Nothing) Then
                svcHouseKeeping.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        btnModify.Enabled = False
        btnDelete.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub txtMemberName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberName.TextChanged
        btnModify.Enabled = False
        btnDelete.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim myForm As New frmMembership01()
        Dim adoDS As New DataSet()
        Dim strMemberId As String
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcHouseKeeping.GetResourceCode("MEMBERSHIP", "DEPARTMENT", APP_ID)
            myForm.Initialization(adoDS)
            adoDS.Dispose()

            adoDS = svcMembership.GetDetailMemberInfo(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            myForm.FillField(adoDS)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strMemberId = svcMembership.UpdateMemberInfo(adoDS, APP_ID)
                adoRow = adoDS.Tables("MEMBERINFO").Rows(0)

                lvwList.SelectedItems.Item(0).SubItems(2).Text = NullToString(adoRow!FIRST_NAME) & " " & NullToString(adoRow!FAMILY_NAME)
                lvwList.SelectedItems.Item(0).SubItems(3).Text = adoRow!MEMBERSHIP_TYPE
                lvwList.SelectedItems.Item(0).SubItems(4).Text = adoRow!STAFF_TYPE
                lvwList.SelectedItems.Item(0).SubItems(5).Text = IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active")
                lvwList.SelectedItems.Item(0).SubItems(6).Text = IIf(adoRow!LOAN_STATUS = "N", "No", "Yes")
                If adoRow!LOAN_STATUS <> "N" Then
                    lvwList.SelectedItems.Item(0).ForeColor = Color.Red
                Else
                    lvwList.SelectedItems.Item(0).ForeColor = Color.Black
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcHouseKeeping Is Nothing) Then
                svcHouseKeeping.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Protected Overrides Sub OnActivated(ByVal e As System.EventArgs)
        txtMemberId.Focus()
    End Sub
End Class
