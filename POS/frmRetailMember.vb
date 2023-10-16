Public Class frmRetailMember
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
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRetailMember))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtMemberName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 112)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberName.Location = New System.Drawing.Point(155, 80)
        Me.txtMemberName.MaxLength = 200
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(301, 21)
        Me.txtMemberName.TabIndex = 2
        Me.txtMemberName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(70, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Member Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(536, 78)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(52, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the Retail Member Id. then click on the select button to view item inform" & _
        "ation."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(155, 56)
        Me.txtMemberId.MaxLength = 20
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(152, 21)
        Me.txtMemberId.TabIndex = 1
        Me.txtMemberId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(52, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Retail Member Id.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(560, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(471, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(383, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(1, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 277)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Retail Member Information"
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
        Me.lvwList.Size = New System.Drawing.Size(636, 257)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Retail Member Id"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Membership No."
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Member Name"
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 120
        '
        'frmRetailMember
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(644, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetailMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Retail Member"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub frmRetailMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "WAREHOUSE", APP_ID)
            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnModify.Enabled = True
                'btnReports.Enabled = True
            Else
                btnModify.Enabled = False
                'btnReports.Enabled = False
            End If
            btnAddNew.Enabled = True
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
        Dim svcRetail As New Retail.svcRetail
        Dim myDS As New DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim I As Long

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            myDS = svcRetail.GetMemberData(txtMemberId.Text, txtMemberName.Text, APP_ID)

            If myDS.Tables("MEMBERDATA").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("MEMBERDATA").Rows
                    I = adoRow!MEMBER_ID
                    objItem = New ListViewItem(I)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!MEMBERSHIP_NO)
                    objItem.SubItems.Add(adoRow!MEMBER_NAME)
                    If adoRow!STATUS = "N" Then
                        objItem.SubItems.Add("Not Active")
                    Else
                        objItem.SubItems.Add("Active")
                    End If
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Item data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnModify.Enabled = True
                'If intAccessValue = 9 Then
                '    btnDelete.Enabled = True
                'Else
                '    btnDelete.Enabled = False
                'End If
                'btnReports.Enabled = True
            Else
                btnModify.Enabled = False
                'btnReports.Enabled = False
            End If
            If lvwList.Items.Count > 15 Then
                lvwList.Columns(2).Width = 235
            Else
                lvwList.Columns(2).Width = 250
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (svcRetail Is Nothing) Then
                svcRetail.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcRetail As New Retail.svcRetail
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmRetailMember01
        Dim adoRow As DataRow
        Dim I As Long

        Try
            myForm.Initialize(True)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcRetail.AddNewMember(adoDS, APP_ID)
                adoRow = adoDS.Tables("MEMBER_DATA").Rows(0)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    lvwList.Items.Clear()
                    I = adoRow!MEMBER_ID
                    objItem = New ListViewItem(I)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!MEMBERSHIP_NO)
                    objItem.SubItems.Add(adoRow!MEMBER_NAME)
                    objItem.SubItems.Add(IIf(adoRow!STATUS = "A", "Active", "Not Active"))
                    objItem.Selected = True

                    If lvwList.Items.Count > 0 Then
                        lvwList.Items(0).Selected = True
                        btnModify.Enabled = True
                        'If intAccessValue = 9 Then
                        '    btnDelete.Enabled = True
                        'Else
                        '    btnDelete.Enabled = False
                        'End If
                        'btnReports.Enabled = True
                    Else
                        btnModify.Enabled = False
                        'btnReports.Enabled = False
                    End If
                    If lvwList.Items.Count > 15 Then
                        lvwList.Columns(2).Width = 235
                    Else
                        lvwList.Columns(2).Width = 250
                    End If
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            'myForm.grpItem.Enabled = False
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
            If Not (svcRetail Is Nothing) Then
                svcRetail.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcRetail As New Retail.svcRetail
        Dim adoDS As New DataSet
        Dim myForm As New frmRetailMember01
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
            adoDS = svcRetail.GetMemberData(lvwList.SelectedItems.Item(0).SubItems(0).Text, "", APP_ID)
            If adoDS.Tables("MEMBERDATA").Rows.Count = 0 Then
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
                svcRetail.UpdateMember(adoDS, APP_ID)
                adoRow = adoDS.Tables("MEMBER_DATA").Rows(0)
                lvwList.SelectedItems.Item(0).SubItems(0).Text = adoRow!MEMBER_ID
                lvwList.SelectedItems.Item(0).SubItems(1).Text = adoRow!MEMBERSHIP_NO
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!MEMBER_NAME
                lvwList.SelectedItems.Item(0).SubItems(3).Text = IIf(adoRow!STATUS = "A", "Active", "Not Active")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            'myForm.grpItem.Enabled = False
            myForm.btnSave.Enabled = False
            GoTo Form_Loop
        Finally
            'If Not (svcWarehouse Is Nothing) Then
            'svcWarehouse.Dispose()
            'End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '    Dim svcWarehouse As New Warehouse.svcWarehouse
    '    Dim intSelectedItem As Integer
    '    Dim intCount As Integer
    '    Dim strResult As String

    '    Try
    '        If lvwList.Items.Count = 0 Then
    '            Exit Sub
    '        End If
    '        If lvwList.SelectedItems.Count = 0 Then
    '            MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        If Trim(lvwList.SelectedItems.Item(0).SubItems(3).Text) = "Not Active" Then
    '            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '            MessageBox.Show("Item Status = Not Active can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If

    '        If MessageBox.Show("Are you sure want to delete this Item Data?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '            strResult = svcWarehouse.DeleteItem(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
    '            If strResult <> "" Then
    '                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '                MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Exit Sub
    '            Else
    '                intSelectedItem = lvwList.SelectedItems.Item(0).Index
    '                lvwList.SelectedItems.Item(0).Remove()

    '                For intCount = 0 To lvwList.Items.Count - 1
    '                    lvwList.Items(intCount).Text = intCount + 1
    '                Next

    '                If lvwList.Items.Count > 0 Then
    '                    If (intSelectedItem) < lvwList.Items.Count Then
    '                        lvwList.Items(intSelectedItem).Selected = True
    '                    Else
    '                        If (intSelectedItem) = lvwList.Items.Count Then
    '                            lvwList.Items(intSelectedItem - 1).Selected = True
    '                        End If
    '                    End If

    '                    'If intAccessValue = 9 Then
    '                    '    btnDelete.Enabled = True
    '                    'Else
    '                    '    btnDelete.Enabled = False
    '                    'End If
    '                    'btnReports.Enabled = True
    '                Else
    '                    btnModify.Enabled = False
    '                    'btnReports.Enabled = False
    '                End If

    '                If lvwList.Items.Count > 15 Then
    '                    lvwList.Columns(2).Width = 235
    '                Else
    '                    lvwList.Columns(2).Width = 250
    '                End If
    '            End If
    '        End If
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    '    Catch ex As Exception
    '        ShowErrorMessage(ex.Message, ex.Source)
    '    Finally
    '        If Not (svcWarehouse Is Nothing) Then
    '            svcWarehouse.Dispose()
    '        End If
    '    End Try
    'End Sub

    Private Sub frmItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModify_Click(sender, e)
            End If
        End If
    End Sub

    '    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
    '        Dim myForm As New frmItemRpt

    '        Try
    '            If lvwList.Items.Count = 0 Then
    '                Exit Sub
    '            End If
    '            If lvwList.SelectedItems.Count = 0 Then
    '                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Exit Sub
    '            End If

    '            myForm.Initialize(lvwList.SelectedItems.Item(0).SubItems(1).Text, lvwList.SelectedItems.Item(0).SubItems(2).Text)
    'Form_Loop:
    '            myForm.ShowDialog()
    '            If myForm.GetCancelStatus = False Then

    '            End If

    '        Finally
    '            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '            If Not (myForm Is Nothing) Then
    '                myForm.Dispose()
    '            End If
    '        End Try
    '    End Sub

    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 250
        btnModify.Enabled = False
        'btnReports.Enabled = False
        If Trim(txtMemberId.Text) = "" Then
            txtMemberName.Enabled = True
        Else
            txtMemberName.Enabled = False
        End If
    End Sub

    Private Sub txtMemberName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberName.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(2).Width = 250
        btnModify.Enabled = False
        'btnReports.Enabled = False
        If Trim(txtMemberName.Text) = "" Then
            txtMemberId.Enabled = True
        Else
            txtMemberId.Enabled = False
        End If
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtMemberName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberName.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub
End Class
