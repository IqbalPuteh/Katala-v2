Public Class frmHRPosition01
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPositionName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSuperiorName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPositionId As System.Windows.Forms.TextBox
    Friend WithEvents txtPositionName As System.Windows.Forms.TextBox
    Friend WithEvents cboSuperiorId As System.Windows.Forms.ComboBox
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHRPosition01))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSuperiorId = New System.Windows.Forms.ComboBox()
        Me.lblPositionName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSuperiorName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPositionId = New System.Windows.Forms.TextBox()
        Me.txtPositionName = New System.Windows.Forms.TextBox()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblTitleLast = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(481, 339)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(393, 339)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboSuperiorId, Me.lblPositionName, Me.Label6, Me.lblSuperiorName, Me.Label7, Me.txtPositionId, Me.txtPositionName})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 336)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position Information"
        '
        'cboSuperiorId
        '
        Me.cboSuperiorId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboSuperiorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSuperiorId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSuperiorId.Location = New System.Drawing.Point(88, 77)
        Me.cboSuperiorId.Name = "cboSuperiorId"
        Me.cboSuperiorId.Size = New System.Drawing.Size(112, 21)
        Me.cboSuperiorId.TabIndex = 3
        '
        'lblPositionName
        '
        Me.lblPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionName.ForeColor = System.Drawing.Color.Black
        Me.lblPositionName.Location = New System.Drawing.Point(8, 55)
        Me.lblPositionName.Name = "lblPositionName"
        Me.lblPositionName.Size = New System.Drawing.Size(80, 14)
        Me.lblPositionName.TabIndex = 18
        Me.lblPositionName.Text = "Position Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(26, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 14)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Position Id:"
        '
        'lblSuperiorName
        '
        Me.lblSuperiorName.AutoSize = True
        Me.lblSuperiorName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperiorName.ForeColor = System.Drawing.Color.Black
        Me.lblSuperiorName.Location = New System.Drawing.Point(204, 80)
        Me.lblSuperiorName.Name = "lblSuperiorName"
        Me.lblSuperiorName.Size = New System.Drawing.Size(89, 14)
        Me.lblSuperiorName.TabIndex = 16
        Me.lblSuperiorName.Text = "Superior Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(24, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Superior Id:"
        '
        'txtPositionId
        '
        Me.txtPositionId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPositionId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPositionId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositionId.Location = New System.Drawing.Point(88, 27)
        Me.txtPositionId.MaxLength = 10
        Me.txtPositionId.Name = "txtPositionId"
        Me.txtPositionId.Size = New System.Drawing.Size(112, 21)
        Me.txtPositionId.TabIndex = 1
        Me.txtPositionId.Text = ""
        '
        'txtPositionName
        '
        Me.txtPositionName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositionName.Location = New System.Drawing.Point(88, 52)
        Me.txtPositionName.MaxLength = 50
        Me.txtPositionName.Name = "txtPositionName"
        Me.txtPositionName.Size = New System.Drawing.Size(352, 21)
        Me.txtPositionName.TabIndex = 2
        Me.txtPositionName.Text = ""
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(72, 342)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 14)
        Me.lblLastUpdate.TabIndex = 18
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(5, 342)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 14)
        Me.lblTitleLast.TabIndex = 17
        Me.lblTitleLast.Text = "Last Update:"
        '
        'frmHRPosition01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(564, 365)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.lblTitleLast, Me.btnClose, Me.btnSave, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHRPosition01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR Position - Edit Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim arrPosition() As String
    Dim strSuperiorId As String

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

    Private Sub frmHRPosition01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim dsPosition As New DataSet()
        Dim lngRow As Long

        Try
            blnCancel = True

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lblSuperiorName.Text = ""
            dsPosition = svcHRIS.GetHRPosition("", "", APP_ID)
            If dsPosition.Tables("POSITION").Rows.Count > 0 Then
                ReDim arrPosition(dsPosition.Tables("POSITION").Rows.Count - 1)
                For lngRow = 0 To dsPosition.Tables("POSITION").Rows.Count - 1
                    cboSuperiorId.Items.Add(dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_ID"))
                    arrPosition(lngRow) = dsPosition.Tables("POSITION").Rows(lngRow)("POSITION_NAME")
                Next lngRow
            End If

            If blnAddNew = False Then
                For lngRow = 0 To cboSuperiorId.Items.Count - 1
                    If strSuperiorId = cboSuperiorId.Items(lngRow) Then
                        cboSuperiorId.SelectedIndex = lngRow
                        Exit For
                    End If
                Next lngRow
            Else
                lblTitleLast.Text = ""
                lblLastUpdate.Text = ""
            End If

        Catch ex As Exception
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

        adoDataTable = adoDS.Tables("POSITION")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("POSITION_ID") = txtPositionId.Text
        adoDataRow("POSITION_NAME") = txtPositionName.Text
        adoDataRow("SUPERIOR_ID") = cboSuperiorId.SelectedItem
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("POSITION")

        adoColumn = New DataColumn("POSITION_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("POSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POSITION_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("POSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("SUPERIOR_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("POSITION").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("POSITION").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean, ByVal strSuperior As String)
        blnAddNew = blnAdd
        strSuperiorId = strSuperior
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow

        txtPositionId.ReadOnly = True

        If adoDS.Tables("POSITION").Rows.Count > 0 Then
            adoRow = adoDS.Tables("POSITION").Rows(0)
            txtPositionId.Text = adoRow!POSITION_ID
            txtPositionName.Text = adoRow!POSITION_NAME
            lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd/MMMM/yyyy")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtPositionId) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtPositionName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboSuperiorId) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub cboSuperiorId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSuperiorId.SelectedIndexChanged
        If cboSuperiorId.Items.Count > 0 Then
            If cboSuperiorId.SelectedItem <> "" Then
                lblSuperiorName.Text = arrPosition(cboSuperiorId.SelectedIndex)
            Else
                lblSuperiorName.Text = ""
            End If
        End If
    End Sub

End Class
