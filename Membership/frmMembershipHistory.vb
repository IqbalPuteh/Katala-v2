Public Class frmMembershipHistory
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
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblActiveStatus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipHistory))
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.btnModify = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblActiveStatus = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Staff Type"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sukarela"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 207
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(536, 408)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(360, 408)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 4
        Me.btnAddNew.Text = "&Add New"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Employee Type"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 125
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Effective Date"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 264)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "History List"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(620, 244)
        Me.lvwList.TabIndex = 3
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(448, 408)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "&Modify"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblActiveStatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblName)
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
        Me.GroupBox1.Size = New System.Drawing.Size(626, 136)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(120, 104)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(90, 17)
        Me.lblActiveStatus.TabIndex = 7
        Me.lblActiveStatus.Text = "lblActiveStatus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(45, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Active Status:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(120, 80)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "lblName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(81, 79)
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
        Me.Label2.Location = New System.Drawing.Point(28, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Membership No:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(496, 88)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the options below and click on select button !"
        '
        'frmMembershipHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(626, 440)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Membership Information - Review Screen"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        lblName.Text = ""
        lblActiveStatus.Text = ""
        btnAddNew.Enabled = False
        btnModify.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As New DataSet()
        Dim adorow As DataRow

        Try
            If e.KeyCode = Keys.Return Then
                If txtMemberId.Text = "" Then
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcMembership.GetMemberName(txtMemberId.Text, APP_ID)
                If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show("No record found for entered member id.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    adorow = adoDS.Tables("MEMBERINFO").Rows(0)
                    lblName.Text = Trim(adorow!FIRST_NAME & " " & adorow!FAMILY_NAME)
                    lblActiveStatus.Text = IIf(adorow!ACTIVE_STATUS = "A", "Active", "Not Active")
                    btnSelect.Focus()
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub frmMembershipHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblName.Text = ""
        lblActiveStatus.Text = ""
    End Sub

    Private Sub txtMemberId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberId.Leave
        txtMemberId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As New DataSet()
        Dim adorow As DataRow
        Dim I As Integer
        Dim objItem As ListViewItem

        Try
            If lblName.Text = "" Then
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcMembership.GetMemberCapitalInfo(txtMemberId.Text, APP_ID)
            lvwList.Items.Clear()
            lvwList.Columns(0).Width = 34
            lvwList.Columns(1).Width = 125
            lvwList.Columns(2).Width = 125
            lvwList.Columns(3).Width = 125
            lvwList.Columns(4).Width = 207

            If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("No record selected for entered member id.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnAddNew.Enabled = False
                btnModify.Enabled = False
            Else
                I = 0
                For Each adorow In adoDS.Tables("MEMBERINFO").Rows
                    I = I + 1
                    objItem = New ListViewItem(I)
                    objItem.Tag = Format(adorow!EFFECTIVE_DATE, "dd/MM/yyyy")
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adorow!EFFECTIVE_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(adorow!MEMBER_TYPE)
                    objItem.SubItems.Add(adorow!STAFF_TYPE)
                    objItem.SubItems.Add(Format(adorow!SUKARELA, "#,##0"))
                Next

                If lblActiveStatus.Text = "Not Active" Then
                    btnAddNew.Enabled = False
                    btnModify.Enabled = False
                Else
                    If lvwList.Items.Count > 0 Then
                        lvwList.Items(0).Selected = True
                        btnModify.Enabled = True
                    Else
                        btnModify.Enabled = False
                    End If
                    btnAddNew.Enabled = True
                End If
                If lvwList.Items.Count > 15 Then
                    lvwList.Columns(4).Width = 191
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim myForm As New frmMembershipHistory01()
        Dim adoDS As New DataSet()
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialization(txtMemberId.Text, lblName.Text)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcMembership.AddNewMemberCapital(adoDS, APP_ID)
                If strResult = "" Then
                    adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    objItem.Tag = Format(adoRow!EFFECTIVE_DATE, "dd/MM/yyyy")
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adoRow!EFFECTIVE_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(adoRow!MEMBER_TYPE)
                    objItem.SubItems.Add(adoRow!STAFF_TYPE)
                    objItem.SubItems.Add(Format(CInt(adoRow!SUKARELA), "#,##0"))
                    objItem.Selected = True
                    btnModify.Enabled = True
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    If lvwList.Items.Count > 15 Then
                        lvwList.Columns(4).Width = 191
                    End If
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
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim myForm As New frmMembershipHistory01()
        Dim adoDS As New DataSet()
        Dim strMemberId As String
        Dim objItem As ListViewItem
        Dim adoRow As DataRow
        Dim blnEditable As Boolean

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialization(txtMemberId.Text, lblName.Text)

            adoDS = svcMembership.GetMemberDetailCapitalInfo(txtMemberId.Text, lvwList.SelectedItems.Item(0).Tag, APP_ID)
            If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If lvwList.SelectedItems(0).Index = lvwList.Items.Count - 1 Then
                blnEditable = True
            Else
                blnEditable = False
            End If
            myForm.FillField(adoDS, blnEditable)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strMemberId = svcMembership.UpdateMemberCapitalInfo(adoDS, APP_ID)
                adoRow = adoDS.Tables("MEMBERINFO").Rows(0)

                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!MEMBER_TYPE
                lvwList.SelectedItems.Item(0).SubItems(3).Text = adoRow!STAFF_TYPE
                lvwList.SelectedItems.Item(0).SubItems(4).Text = Format(CInt(adoRow!SUKARELA), "#,##0")
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
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Protected Overrides Sub OnActivated(ByVal e As System.EventArgs)
        txtMemberId.Focus()
    End Sub
End Class
