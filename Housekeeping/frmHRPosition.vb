Public Class frmHRPosition
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents cboSuperiorId As System.Windows.Forms.ComboBox
    Friend WithEvents lblSuperiorName As System.Windows.Forms.Label
    Friend WithEvents lblPositionName As System.Windows.Forms.Label
    Friend WithEvents cboPositionId As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHRPosition))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPositionName = New System.Windows.Forms.Label()
        Me.cboPositionId = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSuperiorName = New System.Windows.Forms.Label()
        Me.cboSuperiorId = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
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
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPositionName, Me.cboPositionId, Me.Label4, Me.lblSuperiorName, Me.cboSuperiorId, Me.Label2, Me.btnSelect, Me.Label1})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'lblPositionName
        '
        Me.lblPositionName.AutoSize = True
        Me.lblPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionName.ForeColor = System.Drawing.Color.Black
        Me.lblPositionName.Location = New System.Drawing.Point(204, 48)
        Me.lblPositionName.Name = "lblPositionName"
        Me.lblPositionName.Size = New System.Drawing.Size(87, 14)
        Me.lblPositionName.TabIndex = 6
        Me.lblPositionName.Text = "Position Name"
        '
        'cboPositionId
        '
        Me.cboPositionId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboPositionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositionId.Location = New System.Drawing.Point(88, 45)
        Me.cboPositionId.Name = "cboPositionId"
        Me.cboPositionId.Size = New System.Drawing.Size(112, 21)
        Me.cboPositionId.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Position Id:"
        '
        'lblSuperiorName
        '
        Me.lblSuperiorName.AutoSize = True
        Me.lblSuperiorName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperiorName.ForeColor = System.Drawing.Color.Black
        Me.lblSuperiorName.Location = New System.Drawing.Point(205, 75)
        Me.lblSuperiorName.Name = "lblSuperiorName"
        Me.lblSuperiorName.Size = New System.Drawing.Size(89, 14)
        Me.lblSuperiorName.TabIndex = 3
        Me.lblSuperiorName.Text = "Superior Name"
        '
        'cboSuperiorId
        '
        Me.cboSuperiorId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboSuperiorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSuperiorId.Location = New System.Drawing.Point(88, 72)
        Me.cboSuperiorId.Name = "cboSuperiorId"
        Me.cboSuperiorId.Size = New System.Drawing.Size(112, 21)
        Me.cboSuperiorId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Superior Id:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Black
        Me.btnSelect.Location = New System.Drawing.Point(469, 69)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select the options below and click on select button !"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 224)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position Information"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(558, 204)
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
        Me.ColumnHeader2.Text = "Position Id"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Position Name"
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Superior Id"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Superior Name"
        Me.ColumnHeader5.Width = 180
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(480, 336)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(392, 336)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(304, 336)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(216, 336)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'frmHRPosition
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(564, 365)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnDelete, Me.btnModify, Me.btnAddNew, Me.GroupBox2, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHRPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review HR Position"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrPosition() As String
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim dsPosition As New DataSet()
        Dim lngRow As Long
        Dim objItem As ListViewItem
        Dim strSuperiorId As String
        Dim strPositionId As String

        Try
            If cboSuperiorId.Items.Count > 0 Then
                If cboSuperiorId.SelectedItem <> "" Then
                    strSuperiorId = cboSuperiorId.SelectedItem
                End If
            End If
            If cboPositionId.Items.Count > 0 Then
                If cboPositionId.SelectedItem <> "" Then
                    strPositionId = cboPositionId.SelectedItem
                End If
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            dsPosition = svcHRIS.GetHRPosition(strPositionId, strSuperiorId, APP_ID)
            If dsPosition.Tables("POSITION").Rows.Count > 0 Then
                lvwList.Items.Clear()
                For lngRow = 0 To dsPosition.Tables("POSITION").Rows.Count - 1
                    objItem = New ListViewItem(lngRow + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                    objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_NAME"))
                    objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("SUPERIOR_ID"))
                    objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("SUPERIOR_NAME"))
                Next lngRow
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("The Position Data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            If lvwList.Items.Count > 12 Then
                lvwList.Columns(4).Width = 164
            Else
                lvwList.Columns(4).Width = 180
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
            If Not (dsPosition Is Nothing) Then
                dsPosition.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub frmHRPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim dsPosition As New DataSet()
        Dim lngRow As Long

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lblSuperiorName.Text = ""
            lblPositionName.Text = ""
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "HRMODULE", APP_ID)
            dsPosition = svcHRIS.GetHRPosition("", "", APP_ID)
            If dsPosition.Tables("POSITION").Rows.Count > 0 Then
                ReDim arrPosition(dsPosition.Tables("POSITION").Rows.Count - 1)
                For lngRow = 0 To dsPosition.Tables("POSITION").Rows.Count - 1
                    cboSuperiorId.Items.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                    cboPositionId.Items.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                    arrPosition(lngRow) = dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_NAME")
                Next lngRow
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            btnSelect.Enabled = False
            btnAddNew.Enabled = False
            btnModify.Enabled = False
            btnDelete.Enabled = False
        Finally
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            If Not (dsPosition Is Nothing) Then
                dsPosition.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cboPositionId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPositionId.SelectedIndexChanged
        lvwList.Items.Clear()
        If lvwList.Items.Count > 12 Then
            lvwList.Columns(4).Width = 164
        Else
            lvwList.Columns(4).Width = 180
        End If
        If cboPositionId.Items.Count > 0 Then
            If cboPositionId.SelectedItem <> "" Then
                lblPositionName.Text = arrPosition(cboPositionId.SelectedIndex)
            Else
                lblPositionName.Text = ""
            End If
        End If
    End Sub

    Private Sub cboSuperiorId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSuperiorId.SelectedIndexChanged
        lvwList.Items.Clear()
        If lvwList.Items.Count > 12 Then
            lvwList.Columns(4).Width = 164
        Else
            lvwList.Columns(4).Width = 180
        End If
        If cboSuperiorId.Items.Count > 0 Then
            If cboSuperiorId.SelectedItem <> "" Then
                lblSuperiorName.Text = arrPosition(cboSuperiorId.SelectedIndex)
            Else
                lblSuperiorName.Text = ""
            End If
        End If
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmHRPosition01()
        Dim lngRow As Long
        Dim strPositionId As String
        Dim blnAddNew As Boolean

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            blnAddNew = True
            myForm.Initialize(blnAddNew, "")

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet()
                strResult = svcHRIS.AddNewHRPosition(adoDS, APP_ID)
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo Form_Loop
                Else
                    strPositionId = adoDS.Tables("POSITION").Rows(lngRow)("POSITION_ID")
                    adoDS.Dispose()

                    adoDS = svcHRIS.GetHRPosition(strPositionId, "", APP_ID)
                    If adoDS.Tables("POSITION").Rows.Count > 0 Then
                        lvwList.Items.Clear()
                        For lngRow = 0 To adoDS.Tables("POSITION").Rows.Count - 1
                            objItem = New ListViewItem(lngRow + 1)
                            lvwList.Items.Add(objItem)
                            objItem.SubItems.Add(adoDS.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                            objItem.SubItems.Add(adoDS.Tables("POSITION").Rows(lngRow)("POSITION_NAME"))
                            objItem.SubItems.Add(adoDS.Tables("POSITION").Rows(lngRow)("SUPERIOR_ID"))
                            objItem.SubItems.Add(adoDS.Tables("POSITION").Rows(lngRow)("SUPERIOR_NAME"))
                        Next lngRow
                    End If

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

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim dsPosition As New DataSet()
        Dim myForm As New frmHRPosition01()
        Dim objItem As ListViewItem
        Dim lngRow As Long
        Dim strPositionId As String
        Dim strPositionName As String
        Dim strSuperiorId As String
        Dim blnAddNew As Boolean

        Try
            blnAddNew = False
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            strPositionId = lvwList.SelectedItems.Item(0).SubItems(1).Text
            strPositionName = lvwList.SelectedItems.Item(0).SubItems(2).Text
            strSuperiorId = lvwList.SelectedItems.Item(0).SubItems(3).Text

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            dsPosition = svcHRIS.GetHRPosition(strPositionId, "", APP_ID)

            myForm.Initialize(blnAddNew, strSuperiorId)
            myForm.FillField(dsPosition)
            dsPosition.Dispose()
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                dsPosition = myForm.GetDataSet()
                svcHRIS.UpdateHRPosition(dsPosition, APP_ID)

                strPositionId = dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID")
                dsPosition.Dispose()

                dsPosition = svcHRIS.GetHRPosition(strPositionId, "", APP_ID)
                If dsPosition.Tables("POSITION").Rows.Count > 0 Then
                    lvwList.Items.Clear()
                    For lngRow = 0 To dsPosition.Tables("POSITION").Rows.Count - 1
                        objItem = New ListViewItem(lngRow + 1)
                        lvwList.Items.Add(objItem)
                        objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                        objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_NAME"))
                        objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("SUPERIOR_ID"))
                        objItem.SubItems.Add(dsPosition.Tables("POSITION").Rows(lngRow)("SUPERIOR_NAME"))
                    Next lngRow
                End If

                If lvwList.Items.Count > 0 Then
                    btnModify.Enabled = True
                    If intAccessValue = 9 Then
                        btnDelete.Enabled = True
                    Else
                        btnDelete.Enabled = False
                    End If
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
            If Not (dsPosition Is Nothing) Then
                dsPosition.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim svcHRIS As New HRIS.svcHRIS()
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
                svcHRIS.DeleteHRPosition(lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)

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

                If lvwList.Items.Count > 12 Then
                    lvwList.Columns(4).Width = 164
                Else
                    lvwList.Columns(4).Width = 180
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
        End Try
    End Sub

End Class
