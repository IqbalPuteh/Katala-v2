Public Class frmEmployeePosition01
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents lblPositionName As System.Windows.Forms.Label
    Friend WithEvents cboPositionId As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents cboReason As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEffectiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents grbEmployee As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeePosition01))
        Me.grbEmployee = New System.Windows.Forms.GroupBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.cboReason = New System.Windows.Forms.ComboBox()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEffectiveDate = New System.Windows.Forms.DateTimePicker()
        Me.cboPositionId = New System.Windows.Forms.ComboBox()
        Me.lblPositionName = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblTitleLast = New System.Windows.Forms.Label()
        Me.grbEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEmployee
        '
        Me.grbEmployee.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEndDate, Me.Label11, Me.txtComments, Me.cboReason, Me.lblReason, Me.Label6, Me.Label1, Me.dtpEffectiveDate, Me.cboPositionId, Me.lblPositionName, Me.lblEmployeeName, Me.Label5, Me.txtEmployeeId, Me.Label3, Me.Label2})
        Me.grbEmployee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEmployee.ForeColor = System.Drawing.Color.Blue
        Me.grbEmployee.Location = New System.Drawing.Point(0, 8)
        Me.grbEmployee.Name = "grbEmployee"
        Me.grbEmployee.Size = New System.Drawing.Size(600, 384)
        Me.grbEmployee.TabIndex = 3
        Me.grbEmployee.TabStop = False
        Me.grbEmployee.Text = "Employee Position Information"
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtEndDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndDate.Enabled = False
        Me.txtEndDate.Location = New System.Drawing.Point(94, 101)
        Me.txtEndDate.MaxLength = 10
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(106, 21)
        Me.txtEndDate.TabIndex = 78
        Me.txtEndDate.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(33, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 14)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Comments:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComments.Location = New System.Drawing.Point(94, 150)
        Me.txtComments.MaxLength = 2000
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(490, 64)
        Me.txtComments.TabIndex = 76
        Me.txtComments.Text = ""
        '
        'cboReason
        '
        Me.cboReason.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReason.Location = New System.Drawing.Point(94, 125)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(106, 21)
        Me.cboReason.TabIndex = 67
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.ForeColor = System.Drawing.Color.Black
        Me.lblReason.Location = New System.Drawing.Point(211, 128)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(76, 14)
        Me.lblReason.TabIndex = 66
        Me.lblReason.Text = "Reason Desc"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(45, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Reason:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "End Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEffectiveDate
        '
        Me.dtpEffectiveDate.CustomFormat = "dd MMM yyyy"
        Me.dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEffectiveDate.Location = New System.Drawing.Point(94, 77)
        Me.dtpEffectiveDate.Name = "dtpEffectiveDate"
        Me.dtpEffectiveDate.Size = New System.Drawing.Size(106, 21)
        Me.dtpEffectiveDate.TabIndex = 62
        '
        'cboPositionId
        '
        Me.cboPositionId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboPositionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositionId.Location = New System.Drawing.Point(94, 53)
        Me.cboPositionId.Name = "cboPositionId"
        Me.cboPositionId.Size = New System.Drawing.Size(106, 21)
        Me.cboPositionId.TabIndex = 61
        '
        'lblPositionName
        '
        Me.lblPositionName.AutoSize = True
        Me.lblPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionName.ForeColor = System.Drawing.Color.Black
        Me.lblPositionName.Location = New System.Drawing.Point(211, 56)
        Me.lblPositionName.Name = "lblPositionName"
        Me.lblPositionName.Size = New System.Drawing.Size(87, 14)
        Me.lblPositionName.TabIndex = 60
        Me.lblPositionName.Text = "Position Name"
        Me.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label5.Location = New System.Drawing.Point(14, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Effective Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(94, 29)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Position Id:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(430, 398)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(518, 398)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "&Close"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(69, 407)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 14)
        Me.lblLastUpdate.TabIndex = 22
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(5, 407)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 14)
        Me.lblTitleLast.TabIndex = 21
        Me.lblTitleLast.Text = "Last Update:"
        '
        'frmEmployeePosition01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(601, 425)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.lblTitleLast, Me.btnSave, Me.btnClose, Me.grbEmployee})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeePosition01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Position - Edit Screen"
        Me.grbEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim strPositionId As String
    Dim arrPosition() As String
    Dim strReasonCode As String
    Dim arrReason() As String
    Dim strRecordId As String

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

    Private Sub frmEmployeePosition01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim dsPosition As New DataSet()
        Dim lngRow As Long
        Dim adoDS As DataSet

        Try
            blnCancel = True

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lblPositionName.Text = ""
            lblReason.Text = ""
            dsPosition = svcHRIS.GetHRPosition("", "", APP_ID)
            If dsPosition.Tables("POSITION").Rows.Count > 0 Then
                If cboPositionId.Items.Count < 1 Then
                    ReDim arrPosition(dsPosition.Tables("POSITION").Rows.Count - 1)
                    For lngRow = 0 To dsPosition.Tables("POSITION").Rows.Count - 1
                        cboPositionId.Items.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                        arrPosition(lngRow) = dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_NAME")
                    Next lngRow
                End If
            End If
            dsPosition.Dispose()

            dsPosition = svcHouseKeeping.GetResourceCode("HRIS", "REASON", APP_ID)
            If dsPosition.Tables("ResourceCode").Rows.Count > 0 Then
                If cboReason.Items.Count < 1 Then
                    ReDim arrReason(dsPosition.Tables("ResourceCode").Rows.Count - 1)
                    For lngRow = 0 To dsPosition.Tables("ResourceCode").Rows.Count - 1
                        cboReason.Items.Add(dsPosition.Tables("ResourceCode").Rows(lngRow)("RESOURCE_CODE"))
                        arrReason(lngRow) = dsPosition.Tables("ResourceCode").Rows(lngRow)("RESOURCE_DESC")
                    Next lngRow
                End If
            End If
            dsPosition.Dispose()

            If blnAddNew = False Then
                For lngRow = 0 To cboPositionId.Items.Count - 1
                    If strPositionId = cboPositionId.Items(lngRow) Then
                        cboPositionId.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow
                For lngRow = 0 To cboReason.Items.Count - 1
                    If strReasonCode = cboReason.Items(lngRow) Then
                        cboReason.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow

                adoDS = svcHRIS.GetLatestEMPPost(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPPOST").Rows.Count > 0 Then
                    If adoDS.Tables("LATEMPPOST").Rows(0)("ACTIVE_STATUS") = "A" Then
                        If strRecordId = CStr(adoDS.Tables("LATEMPPOST").Rows(0)("RECORD_ID")) Then
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
                cboPositionId.Enabled = False
                dtpEffectiveDate.Enabled = True
                lblTitleLast.Visible = True
                lblLastUpdate.Visible = True
            Else
                adoDS = svcHRIS.GetLatestEMPPost(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPPOST").Rows.Count > 0 Then
                    If adoDS.Tables("LATEMPPOST").Rows(0)("ACTIVE_STATUS") = "N" Then
                        grbEmployee.Enabled = False
                        btnSave.Enabled = False
                    End If
                End If
                adoDS.Dispose()

                txtEmployeeId.Enabled = False
                cboPositionId.Enabled = True
                dtpEffectiveDate.Enabled = True
                lblTitleLast.Visible = False
                lblLastUpdate.Visible = False
                lblPositionName.Text = ""
                lblReason.Text = ""
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

        adoDataTable = adoDS.Tables("EMPPOSITION")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("EMPLOYEE_ID") = txtEmployeeId.Text
        adoDataRow("POSITION_ID") = cboPositionId.SelectedItem
        adoDataRow("EFFECTIVE_DATE") = dtpEffectiveDate.Value
        adoDataRow("REASON") = cboReason.SelectedItem
        adoDataRow("COMMENT") = txtComments.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("EMPPOSITION")

        adoColumn = New DataColumn("EMPLOYEE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POSITION_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EFFECTIVE_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("END_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REASON")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPPOSITION").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean, ByVal strPosition As String, _
                          ByVal strReason As String, ByVal strEmployeeId As String, ByVal strEmployeeName As String)
        Try
            blnAddNew = blnAdd
            strPositionId = strPosition
            strReasonCode = strReason
            txtEmployeeId.Text = strEmployeeId
            lblEmployeeName.Text = strEmployeeName
            dtpEffectiveDate.Value = Now
        Catch ex As Exception
            grbEmployee.Enabled = False
            btnSave.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Throw ex
        End Try
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow

        If adoDS.Tables("EMPPOSITION").Rows.Count > 0 Then
            adoRow = adoDS.Tables("EMPPOSITION").Rows(0)
            strRecordId = adoRow!RECORD_ID
            dtpEffectiveDate.Value = adoRow!EFFECTIVE_DATE
            If Not IsDBNull(adoRow!END_DATE) Then
                txtEndDate.Text = Format(adoRow!END_DATE, "dd MMM yyyy")
            End If
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
        If ValidateEmptyField(cboPositionId) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboReason) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub cboPositionId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPositionId.SelectedIndexChanged
        If cboPositionId.Items.Count > 0 Then
            If cboPositionId.SelectedItem <> "" Then
                lblPositionName.Text = arrPosition(cboPositionId.SelectedIndex)
            Else
                lblPositionName.Text = ""
            End If
        End If
    End Sub

    Private Sub cboReason_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReason.SelectedIndexChanged
        If cboReason.Items.Count > 0 Then
            If cboReason.SelectedItem <> "" Then
                lblReason.Text = arrReason(cboReason.SelectedIndex)
            Else
                lblReason.Text = ""
            End If
        End If
    End Sub

End Class
