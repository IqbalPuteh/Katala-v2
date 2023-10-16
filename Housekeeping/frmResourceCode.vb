Public Class frmResourceCode
    Inherits System.Windows.Forms.Form
    Dim arrResourceType() As String
    Dim intAccessValue As Integer
    Public strProgramId As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboResourceType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmResourceCode))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboResourceType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboResourceType, Me.Label2, Me.btnSelect, Me.Label1})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'cboResourceType
        '
        Me.cboResourceType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboResourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResourceType.Location = New System.Drawing.Point(120, 48)
        Me.cboResourceType.Name = "cboResourceType"
        Me.cboResourceType.Size = New System.Drawing.Size(288, 21)
        Me.cboResourceType.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resource Type:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Black
        Me.btnSelect.Location = New System.Drawing.Point(456, 48)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select the options below and click on the select button !"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 240)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resources Details Information"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(560, 220)
        Me.lvwList.TabIndex = 2
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Resource Code"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 246
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Default Value"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sequence"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 88
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(218, 339)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 3
        Me.btnAddNew.Text = "&Add New"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(306, 339)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "&Modify"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(394, 339)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Delete"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(482, 339)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'frmResourceCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(566, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnDelete, Me.btnModify, Me.btnAddNew, Me.GroupBox2, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResourceCode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Resources Code"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcHousekeeping As New HouseKeeping.svcHousekeeping()
        Dim myForm As New frmResourceCode01()
        Dim adoDS As New DataSet()
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim intSequence As Integer

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialization(arrResourceType(cboResourceType.SelectedIndex), cboResourceType.Text)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet(strProgramId)
                strResult = svcHousekeeping.AddNewResourceCode(adoDS, APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoDS.Tables("RESOURCE_CODE").Rows(0)("RESOURCE_CODE"))
                    objItem.SubItems.Add(adoDS.Tables("RESOURCE_CODE").Rows(0)("RESOURCE_DESC"))
                    objItem.SubItems.Add(adoDS.Tables("RESOURCE_CODE").Rows(0)("DEFAULT_VALUE"))
                    intSequence = Convert.ToInt16(adoDS.Tables("RESOURCE_CODE").Rows(0)("SEQUENCE_NO"))
                    objItem.SubItems.Add(Microsoft.VisualBasic.Right("00" & Convert.ToString(intSequence), 3))
                    objItem.Selected = True

                    If lvwList.Items.Count > 0 Then
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

                    If lvwList.Items.Count > 14 Then
                        lvwList.Columns(3).Width = 72
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
            If Not (svcHousekeeping Is Nothing) Then
                svcHousekeeping.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmResourceCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHousekeeping As New HouseKeeping.svcHousekeeping()
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim dsResourceType As New DataSet()
        Dim lngRow As Long

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "HRMODULE", APP_ID)
            dsResourceType = svcHousekeeping.GetResourceType(strProgramId, APP_ID)
            ReDim arrResourceType(dsResourceType.Tables("ResourceType").Rows.Count - 1)
            For lngRow = 0 To dsResourceType.Tables("ResourceType").Rows.Count - 1
                arrResourceType(lngRow) = dsResourceType.Tables("ResourceType").Rows(lngRow)("RESOURCE_TYPE")
                cboResourceType.Items.Add(dsResourceType.Tables("ResourceType").Rows(lngRow)("RESOURCE_DESC"))
            Next lngRow
            If cboResourceType.Items.Count > 0 Then
                cboResourceType.SelectedIndex = 0
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            btnSelect.Enabled = False
            btnAddNew.Enabled = False
            btnModify.Enabled = False
            btnDelete.Enabled = False
        Finally
            If Not (svcHousekeeping Is Nothing) Then
                svcHousekeeping.Dispose()
            End If
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            If Not (dsResourceType Is Nothing) Then
                dsResourceType.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcHousekeeping As New HouseKeeping.svcHousekeeping()
        Dim dsResourceCode As New DataSet()
        Dim lngRow As Long
        Dim objItem As ListViewItem
        Dim intSequence As Integer

        Try
            If cboResourceType.Items.Count = 0 Then
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            dsResourceCode = svcHousekeeping.GetResourceCode(strProgramId, arrResourceType(cboResourceType.SelectedIndex), APP_ID)
            lvwList.Items.Clear()
            lvwList.Columns(0).Width = 34
            lvwList.Columns(1).Width = 100
            lvwList.Columns(2).Width = 246
            lvwList.Columns(3).Width = 88
            lvwList.Columns(4).Width = 88
            For lngRow = 0 To dsResourceCode.Tables("ResourceCode").Rows.Count - 1
                objItem = New ListViewItem((lngRow + 1) & ".")
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(dsResourceCode.Tables("ResourceCode").Rows(lngRow)("RESOURCE_CODE"))
                objItem.SubItems.Add(dsResourceCode.Tables("ResourceCode").Rows(lngRow)("RESOURCE_DESC"))
                objItem.SubItems.Add(dsResourceCode.Tables("ResourceCode").Rows(lngRow)("DEFAULT_VALUE"))
                intSequence = Convert.ToInt16(dsResourceCode.Tables("ResourceCode").Rows(lngRow)("SEQUENCE_NO"))
                objItem.SubItems.Add(Microsoft.VisualBasic.Right("00" & Convert.ToString(intSequence), 3))
            Next lngRow
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

            If lvwList.Items.Count > 14 Then
                lvwList.Columns(4).Width = 72
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcHousekeeping Is Nothing) Then
                svcHousekeeping.Dispose()
            End If
            If Not (dsResourceCode Is Nothing) Then
                dsResourceCode.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cboResourceType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboResourceType.SelectedIndexChanged
        lvwList.Items.Clear()
        lvwList.Columns(0).Width = 34
        lvwList.Columns(1).Width = 100
        lvwList.Columns(2).Width = 246
        lvwList.Columns(3).Width = 88
        lvwList.Columns(4).Width = 88
        btnAddNew.Enabled = False
        btnModify.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcHousekeeping As New HouseKeeping.svcHousekeeping()
        Dim dsResourceCode As New DataSet()
        Dim myForm As New frmResourceCode01()
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

            dsResourceCode = svcHousekeeping.GetResourceCodeDetail(strProgramId, arrResourceType(cboResourceType.SelectedIndex), lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            If dsResourceCode.Tables("ResourceCode").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            myForm.Initialization(arrResourceType(cboResourceType.SelectedIndex), cboResourceType.Text)
            myForm.FillField(dsResourceCode)
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                dsResourceCode = myForm.GetDataSet(strProgramId)
                svcHousekeeping.UpdateResourceCode(dsResourceCode, APP_ID)
                lvwList.SelectedItems.Item(0).SubItems(1).Text = dsResourceCode.Tables("RESOURCE_CODE").Rows(0)("RESOURCE_CODE")
                lvwList.SelectedItems.Item(0).SubItems(2).Text = dsResourceCode.Tables("RESOURCE_CODE").Rows(0)("RESOURCE_DESC")
                lvwList.SelectedItems.Item(0).SubItems(3).Text = dsResourceCode.Tables("RESOURCE_CODE").Rows(0)("DEFAULT_VALUE")
                intSequence = Convert.ToInt16(dsResourceCode.Tables("RESOURCE_CODE").Rows(0)("SEQUENCE_NO"))
                lvwList.SelectedItems.Item(0).SubItems(4).Text = Microsoft.VisualBasic.Right("00" & Convert.ToString(intSequence), 3)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcHousekeeping Is Nothing) Then
                svcHousekeeping.Dispose()
            End If
            If Not (dsResourceCode Is Nothing) Then
                dsResourceCode.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcHousekeeping As New HouseKeeping.svcHousekeeping()
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
                svcHousekeeping.DeleteResourceCode(strProgramId, arrResourceType(cboResourceType.SelectedIndex), lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
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
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcHousekeeping Is Nothing) Then
                svcHousekeeping.Dispose()
            End If
        End Try
    End Sub

End Class
