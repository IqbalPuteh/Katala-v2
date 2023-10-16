Public Class frmResourceCode01
    Inherits System.Windows.Forms.Form
    Private blnCancel As Boolean
    Private arrTransDescDetailCR() As String
    Private arrTransDescDetailDB() As String
    Private arrTransCodeCR() As String
    Private arrTransCodeDB() As String
 
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtResourceType As System.Windows.Forms.TextBox
    Friend WithEvents lblResourceDesc As System.Windows.Forms.Label
    Friend WithEvents txtSequence As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtResourceCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboDefaultValue As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboTransType As System.Windows.Forms.ComboBox
    Friend WithEvents chkTransaction As System.Windows.Forms.CheckBox
    Friend WithEvents pnlTransaction As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmResourceCode01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboTransType = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkTransaction = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboDefaultValue = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblResourceDesc = New System.Windows.Forms.Label
        Me.txtResourceType = New System.Windows.Forms.TextBox
        Me.txtSequence = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtResourceCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.pnlTransaction = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlTransaction)
        Me.GroupBox1.Controls.Add(Me.cboTransType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkTransaction)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboDefaultValue)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblResourceDesc)
        Me.GroupBox1.Controls.Add(Me.txtResourceType)
        Me.GroupBox1.Controls.Add(Me.txtSequence)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtResourceCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resource Code Maintenance"
        '
        'cboTransType
        '
        Me.cboTransType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransType.Enabled = False
        Me.cboTransType.Location = New System.Drawing.Point(223, 162)
        Me.cboTransType.Name = "cboTransType"
        Me.cboTransType.Size = New System.Drawing.Size(104, 21)
        Me.cboTransType.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(176, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Type:"
        '
        'chkTransaction
        '
        Me.chkTransaction.Location = New System.Drawing.Point(112, 160)
        Me.chkTransaction.Name = "chkTransaction"
        Me.chkTransaction.Size = New System.Drawing.Size(72, 24)
        Me.chkTransaction.TabIndex = 16
        Me.chkTransaction.Text = "Yes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(73, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Type:"
        '
        'cboDefaultValue
        '
        Me.cboDefaultValue.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboDefaultValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDefaultValue.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboDefaultValue.Location = New System.Drawing.Point(112, 112)
        Me.cboDefaultValue.Name = "cboDefaultValue"
        Me.cboDefaultValue.Size = New System.Drawing.Size(88, 21)
        Me.cboDefaultValue.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Default Value:"
        '
        'lblResourceDesc
        '
        Me.lblResourceDesc.AutoSize = True
        Me.lblResourceDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceDesc.ForeColor = System.Drawing.Color.Black
        Me.lblResourceDesc.Location = New System.Drawing.Point(208, 43)
        Me.lblResourceDesc.Name = "lblResourceDesc"
        Me.lblResourceDesc.Size = New System.Drawing.Size(98, 17)
        Me.lblResourceDesc.TabIndex = 13
        Me.lblResourceDesc.Text = "lblResourceDesc"
        '
        'txtResourceType
        '
        Me.txtResourceType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtResourceType.Enabled = False
        Me.txtResourceType.Location = New System.Drawing.Point(112, 40)
        Me.txtResourceType.Name = "txtResourceType"
        Me.txtResourceType.Size = New System.Drawing.Size(88, 21)
        Me.txtResourceType.TabIndex = 0
        Me.txtResourceType.Text = ""
        '
        'txtSequence
        '
        Me.txtSequence.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSequence.Location = New System.Drawing.Point(112, 136)
        Me.txtSequence.MaxLength = 3
        Me.txtSequence.Name = "txtSequence"
        Me.txtSequence.Size = New System.Drawing.Size(48, 21)
        Me.txtSequence.TabIndex = 4
        Me.txtSequence.Text = "000"
        Me.txtSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sequence#:"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(112, 88)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(440, 21)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description:"
        '
        'txtResourceCode
        '
        Me.txtResourceCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtResourceCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResourceCode.Location = New System.Drawing.Point(112, 64)
        Me.txtResourceCode.MaxLength = 10
        Me.txtResourceCode.Name = "txtResourceCode"
        Me.txtResourceCode.Size = New System.Drawing.Size(88, 21)
        Me.txtResourceCode.TabIndex = 1
        Me.txtResourceCode.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Resource Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resource Type:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(480, 336)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(392, 336)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        '
        'pnlTransaction
        '
        Me.pnlTransaction.Location = New System.Drawing.Point(8, 160)
        Me.pnlTransaction.Name = "pnlTransaction"
        Me.pnlTransaction.Size = New System.Drawing.Size(328, 32)
        Me.pnlTransaction.TabIndex = 19
        '
        'frmResourceCode01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(564, 365)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResourceCode01"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resource Code - Edit Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function GetDataSet(ByVal strProgramId As String) As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateResourceCodeRs()
            FillDataSet(strProgramId, myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FillDataSet(ByVal strProgramId As String, ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()
        Dim intSequence As Integer

        adoDataTable = adoDS.Tables("RESOURCE_CODE")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("PROGRAM_TYPE") = strProgramId
        adoDataRow("RESOURCE_TYPE") = txtResourceType.Text
        adoDataRow("RESOURCE_CODE") = txtResourceCode.Text
        adoDataRow("RESOURCE_DESC") = txtDescription.Text
        adoDataRow("DEFAULT_VALUE") = IIf(cboDefaultValue.SelectedIndex = 0, "Y", "N")
        intSequence = Convert.ToInt16(txtSequence.Text)
        adoDataRow("SEQUENCE_NO") = Microsoft.VisualBasic.Right("00" & Convert.ToString(intSequence), 3)
        adoDataRow("REVIEWED_BY") = USER_ID
        If Me.chkTransaction.Checked Then
            adoDataRow("TYPE_1") = IIf(Me.cboTransType.SelectedIndex = 0, "CR", "DB")
        End If
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("RESOURCE_CODE")

        adoColumn = New DataColumn("PROGRAM_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RESOURCE_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RESOURCE_CODE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RESOURCE_DESC")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DEFAULT_VALUE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("SEQUENCE_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TYPE_1")
        adoColumn.AllowDBNull = True
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RESOURCE_CODE").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub Initialization(ByVal strResourceType As String, ByVal strDescription As String)
        txtResourceType.Text = strResourceType
        lblResourceDesc.Text = strDescription
        cboDefaultValue.SelectedIndex = 1
        cboTransType.Items.Clear()
        cboTransType.Items.Add("CREDIT")
        cboTransType.Items.Add("DEBET")
        If Me.txtResourceType.Text.ToUpper = "TRANTYPE" Then
            Me.pnlTransaction.Visible = False
        Else
            Me.pnlTransaction.Visible = True
        End If
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim intSequence As Integer

        If adoDS.Tables("ResourceCode").Rows.Count > 0 Then
            txtResourceCode.Text = adoDS.Tables("ResourceCode").Rows(0)("RESOURCE_CODE")
            txtDescription.Text = adoDS.Tables("ResourceCode").Rows(0)("RESOURCE_DESC")
            cboDefaultValue.SelectedIndex = IIf(adoDS.Tables("ResourceCode").Rows(0)("DEFAULT_VALUE") = "Y", 0, 1)
            intSequence = Convert.ToInt16(adoDS.Tables("ResourceCode").Rows(0)("SEQUENCE_NO"))
            txtSequence.Text = Microsoft.VisualBasic.Right("00" & Convert.ToString(intSequence), 3)
            If NullToString(adoDS.Tables("ResourceCode").Rows(0)("TYPE_1")) = "CR" Then
                Me.chkTransaction.Checked = True
                Me.cboTransType.SelectedIndex = 0
            ElseIf NullToString(adoDS.Tables("ResourceCode").Rows(0)("TYPE_1")) = "DB" Then
                Me.chkTransaction.Checked = True
                Me.cboTransType.SelectedIndex = 1
            Else
                Me.chkTransaction.CheckState = CheckState.Unchecked
                Me.cboTransType.Enabled = False
            End If
        End If
        txtResourceCode.ReadOnly = True
    End Sub

    Private Sub frmResourceCode01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blnCancel = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtResourceCode) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtDescription) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtSequence) Then
            Exit Sub
        End If
        If Not IsNumeric(txtSequence.Text) Then
            MessageBox.Show("Sequence# must be numeric!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSequence.Focus()
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub chkTransaction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransaction.CheckedChanged
        If Me.chkTransaction.Checked Then
            Me.cboTransType.Enabled = True
        Else
            Me.cboTransType.Enabled = False
        End If
    End Sub
End Class
