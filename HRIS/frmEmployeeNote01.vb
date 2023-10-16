Public Class frmEmployeeNote01
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
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEntryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPositionId As System.Windows.Forms.ComboBox
    Friend WithEvents lblPositionName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grbEmployee As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeNote01))
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblTitleLast = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grbEmployee = New System.Windows.Forms.GroupBox()
        Me.cboPositionId = New System.Windows.Forms.ComboBox()
        Me.lblPositionName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(69, 402)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 14)
        Me.lblLastUpdate.TabIndex = 31
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(5, 402)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 14)
        Me.lblTitleLast.TabIndex = 30
        Me.lblTitleLast.Text = "Last Update:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(429, 397)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(517, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "&Close"
        '
        'grbEmployee
        '
        Me.grbEmployee.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPositionId, Me.lblPositionName, Me.Label3, Me.Label11, Me.txtComments, Me.dtpEntryDate, Me.lblEmployeeName, Me.Label5, Me.txtEmployeeId, Me.Label2})
        Me.grbEmployee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEmployee.ForeColor = System.Drawing.Color.Blue
        Me.grbEmployee.Location = New System.Drawing.Point(0, 5)
        Me.grbEmployee.Name = "grbEmployee"
        Me.grbEmployee.Size = New System.Drawing.Size(600, 387)
        Me.grbEmployee.TabIndex = 27
        Me.grbEmployee.TabStop = False
        Me.grbEmployee.Text = "Employee Performance"
        '
        'cboPositionId
        '
        Me.cboPositionId.BackColor = System.Drawing.Color.LightGray
        Me.cboPositionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositionId.Location = New System.Drawing.Point(94, 78)
        Me.cboPositionId.Name = "cboPositionId"
        Me.cboPositionId.Size = New System.Drawing.Size(106, 21)
        Me.cboPositionId.TabIndex = 78
        '
        'lblPositionName
        '
        Me.lblPositionName.AutoSize = True
        Me.lblPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionName.ForeColor = System.Drawing.Color.Black
        Me.lblPositionName.Location = New System.Drawing.Point(208, 81)
        Me.lblPositionName.Name = "lblPositionName"
        Me.lblPositionName.Size = New System.Drawing.Size(87, 14)
        Me.lblPositionName.TabIndex = 77
        Me.lblPositionName.Text = "Position Name"
        Me.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Position Id:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(32, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 14)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Comments:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComments.Location = New System.Drawing.Point(94, 102)
        Me.txtComments.MaxLength = 2000
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(490, 234)
        Me.txtComments.TabIndex = 74
        Me.txtComments.Text = ""
        '
        'dtpEntryDate
        '
        Me.dtpEntryDate.CustomFormat = "dd MMM yyyy"
        Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntryDate.Location = New System.Drawing.Point(94, 53)
        Me.dtpEntryDate.Name = "dtpEntryDate"
        Me.dtpEntryDate.Size = New System.Drawing.Size(106, 21)
        Me.dtpEntryDate.TabIndex = 62
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Location = New System.Drawing.Point(178, 32)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(96, 14)
        Me.lblEmployeeName.TabIndex = 59
        Me.lblEmployeeName.Text = "Employee Name"
        Me.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Entry Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.LightGray
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(94, 29)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Employee Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmEmployeeNote01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(600, 425)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.lblTitleLast, Me.btnSave, Me.btnClose, Me.grbEmployee})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeNote01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Performance - Edit Screen"
        Me.grbEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim strRecordId As String
    Dim strPosId As String
    Dim strPosName As String

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateResourceCodeRs()
            FillDataSet(myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub frmEmployeeNote01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim dsPosition As New DataSet()
        Dim adoDS As DataSet
        Dim lngRow As Long

        Try
            blnCancel = True

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lblPositionName.Text = ""
            If blnAddNew = False Then
                adoDS = svcHRIS.GetLatestEMPNote(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPNOTE").Rows.Count > 0 Then
                    If adoDS.Tables("LATEMPNOTE").Rows(0)("ACTIVE_STATUS") = "A" Then
                        If strRecordId = CStr(adoDS.Tables("LATEMPNOTE").Rows(0)("RECORD_ID")) Then
                            grbEmployee.Enabled = True
                            btnSave.Enabled = True
                        Else
                            grbEmployee.Enabled = False
                            btnSave.Enabled = False
                        End If
                    Else
                        grbEmployee.Enabled = False
                        btnSave.Enabled = False
                    End If
                End If
                adoDS.Dispose()

                txtEmployeeId.Enabled = False
                dtpEntryDate.Enabled = True
                cboPositionId.Items.Add(strPosId)
                cboPositionId.SelectedIndex = 0
                cboPositionId.Enabled = False
                lblPositionName.Text = strPosName
                lblTitleLast.Visible = True
                lblLastUpdate.Visible = True
            Else
                cboPositionId.Items.Clear()
                dsPosition = svcHRIS.GetLatestEMPPosition(txtEmployeeId.Text, APP_ID)
                If dsPosition.Tables("LATEMPPOSITION").Rows.Count > 0 Then
                    cboPositionId.Items.Add(dsPosition.Tables(0).Rows(0).Item("POSITION_ID"))
                    lblPositionName.Text = dsPosition.Tables(0).Rows(0).Item("POSITION_NAME")
                    cboPositionId.SelectedIndex = 0
                End If
                dsPosition.Dispose()

                adoDS = svcHRIS.GetLatestEMPNote(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPNOTE").Rows.Count > 0 Then
                    If adoDS.Tables("LATEMPNOTE").Rows(0)("ACTIVE_STATUS") = "N" Then
                        grbEmployee.Enabled = False
                        btnSave.Enabled = False
                    End If
                End If
                adoDS.Dispose()

                cboPositionId.Enabled = False
                txtEmployeeId.Enabled = False
                lblTitleLast.Visible = False
                lblLastUpdate.Visible = False
            End If

        Catch ex As Exception
            grbEmployee.Enabled = False
            btnSave.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
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

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("EMPNOTE")
        adoDataRow = adoDataTable.NewRow()
        If blnAddNew = False Then
            adoDataRow("RECORD_ID") = strRecordId
        End If
        adoDataRow("EMPLOYEE_ID") = txtEmployeeId.Text
        adoDataRow("POSITION_ID") = cboPositionId.SelectedItem
        adoDataRow("ENTRY_DATE") = dtpEntryDate.Value
        adoDataRow("COMMENT") = txtComments.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("EMPNOTE")

        adoColumn = New DataColumn("RECORD_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPNOTE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EMPLOYEE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPNOTE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POSITION_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPNOTE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ENTRY_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EMPNOTE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPNOTE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPNOTE").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean, ByVal strEmployeeId As String, _
                          ByVal strEmployeeName As String, ByVal strPositionId As String, _
                          ByVal strPositionName As String)
        Try
            blnAddNew = blnAdd
            txtEmployeeId.Text = strEmployeeId
            lblEmployeeName.Text = strEmployeeName
            dtpEntryDate.Value = Now
            strPosId = strPositionId
            strPosName = strPositionName

        Catch ex As Exception
            grbEmployee.Enabled = False
            btnSave.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Throw ex
        End Try
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow

        If adoDS.Tables("EMPNOTE").Rows.Count > 0 Then
            adoRow = adoDS.Tables("EMPNOTE").Rows(0)
            strRecordId = adoRow!RECORD_ID
            cboPositionId.Text = adoRow!POSITION_ID
            dtpEntryDate.Value = adoRow!ENTRY_DATE
            txtComments.Text = adoRow!COMMENT
            lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtEmployeeId) Then
            Exit Sub
        End If
        If ValidateEmptyField(lblEmployeeName) Then
            Exit Sub
        End If
        If lblPositionName.Text = "" Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("The Employee doesn't have Position yet!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ValidateEmptyField(txtComments) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

End Class
