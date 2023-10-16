Public Class frmUserProfile
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserProfile))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Users Profile"
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
        Me.lvwList.Size = New System.Drawing.Size(636, 372)
        Me.lvwList.TabIndex = 0
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Id"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Employee"
        Me.ColumnHeader3.Width = 359
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 116
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(471, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(383, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 8
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(295, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "&Add New"
        '
        'frmUserProfile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnDelete, Me.btnModify, Me.btnAddNew, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review User Profile"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmUserProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "SECURITY", APP_ID)

            lvwList.Items.Clear()
            myDS = svcSecurity.GetUserList(APP_ID)
            For Each adoRow In myDS.Tables("USER_LIST").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!USER_ID)
                objItem.SubItems.Add(Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME))) & " (" & adoRow!EMPLOYEE_ID & ")")
                objItem.SubItems.Add(IIf(NullToString(adoRow!ACTIVE_STATUS) = "A", "Active", "Not Active"))
            Next
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
            If lvwList.Items.Count > 24 Then
                lvwList.Columns(3).Width = 100
            End If

        Catch ex As Exception
            Me.Enabled = False
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
        Dim myForm As New frmUserProfile01()
        Dim adoDS As New DataSet()
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim intSequence As Integer

        Try
            myForm.Initialize()
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcSecurity.AddNewUser(adoDS, APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoDS.Tables("USERPROFILE").Rows(0)("USER_ID"))
                    objItem.SubItems.Add(adoDS.Tables("USERPROFILE").Rows(0)("EMPLOYEE_NAME") & " (" & adoDS.Tables("USERPROFILE").Rows(0)("EMPLOYEE_ID") & ")")
                    objItem.SubItems.Add("Active")
                    objItem.Selected = True
                    If lvwList.Items.Count = 1 Then
                        btnModify.Enabled = True
                        If intAccessValue = 9 Then
                            btnDelete.Enabled = True
                        Else
                            btnDelete.Enabled = False
                        End If
                    End If
                    If lvwList.Items.Count > 24 Then
                        lvwList.Columns(3).Width = 100
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
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
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
                svcSecurity.DeleteUser(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
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
        Dim adoDS As New DataSet()
        Dim myForm As New frmUserProfile01()
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

            adoDS = svcSecurity.GetUserInfo(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            If adoDS.Tables("USERPROFILE").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            myForm.Initialize()
            myForm.FillField(adoDS)
            adoDS.Dispose()
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                svcSecurity.UpdateUserInfo(adoDS, APP_ID)
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoDS.Tables("USERPROFILE").Rows(0)("EMPLOYEE_NAME") & " (" & adoDS.Tables("USERPROFILE").Rows(0)("EMPLOYEE_ID") & ")"
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
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
