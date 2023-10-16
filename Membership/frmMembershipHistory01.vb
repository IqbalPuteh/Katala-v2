Public Class frmMembershipHistory01
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMembershipNo As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMemberType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStaffType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblWajib As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblPokok As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSukarela As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblInterest As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipHistory01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSukarela = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblWajib = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPokok = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboStaffType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboMemberType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMembershipNo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSukarela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.lblInterest, Me.Label18, Me.Label16, Me.lblTotal, Me.Label12, Me.txtSukarela, Me.Label13, Me.lblWajib, Me.Label11, Me.lblPokok, Me.Label9, Me.cboStaffType, Me.Label10, Me.cboMemberType, Me.Label5, Me.dtpDate, Me.Label4, Me.lblMembershipNo, Me.lblName, Me.Label3, Me.Label2})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 400)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Information"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(608, 1)
        Me.Label6.TabIndex = 33
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterest.ForeColor = System.Drawing.Color.Black
        Me.lblInterest.Location = New System.Drawing.Point(496, 200)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(65, 14)
        Me.lblInterest.TabIndex = 32
        Me.lblInterest.Text = "lblInterest"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(424, 200)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 14)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Interest (%):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(256, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 14)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "(Pokok+Wajib+Sukarela)"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(112, 200)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 14)
        Me.lblTotal.TabIndex = 29
        Me.lblTotal.Text = "lblTotal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(72, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 14)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Total:"
        '
        'txtSukarela
        '
        Me.txtSukarela.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSukarela.Location = New System.Drawing.Point(112, 168)
        Me.txtSukarela.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtSukarela.Name = "txtSukarela"
        Me.txtSukarela.Size = New System.Drawing.Size(104, 21)
        Me.txtSukarela.TabIndex = 4
        Me.txtSukarela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(60, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 14)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Sukarela:"
        '
        'lblWajib
        '
        Me.lblWajib.AutoSize = True
        Me.lblWajib.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWajib.ForeColor = System.Drawing.Color.Black
        Me.lblWajib.Location = New System.Drawing.Point(496, 123)
        Me.lblWajib.Name = "lblWajib"
        Me.lblWajib.Size = New System.Drawing.Size(51, 14)
        Me.lblWajib.TabIndex = 24
        Me.lblWajib.Text = "lblWajib"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(456, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Wajib:"
        '
        'lblPokok
        '
        Me.lblPokok.AutoSize = True
        Me.lblPokok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokok.ForeColor = System.Drawing.Color.Black
        Me.lblPokok.Location = New System.Drawing.Point(312, 123)
        Me.lblPokok.Name = "lblPokok"
        Me.lblPokok.Size = New System.Drawing.Size(53, 14)
        Me.lblPokok.TabIndex = 22
        Me.lblPokok.Text = "lblPokok"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(272, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Pokok:"
        '
        'cboStaffType
        '
        Me.cboStaffType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboStaffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffType.Items.AddRange(New Object() {"Staff", "Non Staff"})
        Me.cboStaffType.Location = New System.Drawing.Point(112, 144)
        Me.cboStaffType.Name = "cboStaffType"
        Me.cboStaffType.Size = New System.Drawing.Size(104, 21)
        Me.cboStaffType.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(50, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Staff Type:"
        '
        'cboMemberType
        '
        Me.cboMemberType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberType.Items.AddRange(New Object() {"National", "Expatriate"})
        Me.cboMemberType.Location = New System.Drawing.Point(112, 120)
        Me.cboMemberType.Name = "cboMemberType"
        Me.cboMemberType.Size = New System.Drawing.Size(104, 21)
        Me.cboMemberType.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Membership Type:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(112, 96)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(104, 21)
        Me.dtpDate.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Effective Date:"
        '
        'lblMembershipNo
        '
        Me.lblMembershipNo.AutoSize = True
        Me.lblMembershipNo.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipNo.Location = New System.Drawing.Point(112, 32)
        Me.lblMembershipNo.Name = "lblMembershipNo"
        Me.lblMembershipNo.Size = New System.Drawing.Size(104, 14)
        Me.lblMembershipNo.TabIndex = 10
        Me.lblMembershipNo.Text = "lblMembershipNo"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(112, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 14)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "lblName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(73, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Membership No.:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(536, 408)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(448, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(80, 416)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(83, 14)
        Me.lblLastUpdate.TabIndex = 13
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Last Update:"
        '
        'frmMembershipHistory01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(624, 438)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.Label1, Me.GroupBox1, Me.btnClose, Me.btnSave})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipHistory01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Membership Information - Add/Modify Screen"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtSukarela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim blnCancel As Boolean
    Dim dsParameters As New DataSet()

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoRow As DataRow
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("MEMBERINFO")
        adoRow = adoDataTable.NewRow()

        adoRow!MEMBERSHIP_NO = ValidateString(lblMembershipNo.Text)
        adoRow!EFFECTIVE_DATE = dtpDate.Value
        adoRow!MEMBER_TYPE = IIf(cboMemberType.SelectedIndex = 0, "NAT", "EXPAT")
        adoRow!STAFF_TYPE = IIf(cboStaffType.SelectedIndex = 0, "STAFF", "NONSTAFF")
        adoRow!SUKARELA = txtSukarela.Value
        adoRow!REVIEWED_BY = ValidateString(USER_ID)

        adoDataTable.Rows.Add(adoRow)
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet, ByVal blnEditable As Boolean)
        Dim adoRow As DataRow
        Dim I As Integer
        Dim blnFound As Boolean
        Dim adoParameters As DataRow

        Try
            If adoDS.Tables("MEMBERINFO").Rows.Count > 0 Then
                adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
                adoParameters = dsParameters.Tables("MEMBERINFO").Rows(0)

                lblMembershipNo.Text = NullToString(adoRow!MEMBERSHIP_NO)
                dtpDate.MinDate = adoRow!EFFECTIVE_DATE
                dtpDate.Value = adoRow!EFFECTIVE_DATE
                dtpDate.Enabled = False
                cboMemberType.Text = IIf(adoRow!MEMBER_TYPE = "NAT", 0, 1)
                If cboMemberType.SelectedIndex = 0 Then
                    lblPokok.Text = adoParameters!POKOK_NT
                    lblWajib.Text = adoParameters!WAJIB_NT
                Else
                    lblPokok.Text = adoParameters!POKOK_EX
                    lblWajib.Text = adoParameters!WAJIB_EX
                End If
                cboStaffType.Text = IIf(adoRow!STAFF_TYPE = "STAFF", 0, 1)
                txtSukarela.Value = adoRow!SUKARELA
                If cboStaffType.SelectedIndex = 0 Then
                    lblInterest.Text = adoParameters!INTEREST_SS
                Else
                    lblInterest.Text = adoParameters!INTEREST_NS
                End If
                lblTotal.Text = CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value

                If adoRow!ACTIVE_STATUS <> "A" Then
                    GroupBox1.Enabled = False
                    btnSave.Enabled = False
                Else
                    If blnEditable = False Then
                        GroupBox1.Enabled = False
                        btnSave.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            GroupBox1.Enabled = False
            btnSave.Enabled = False
        End Try
    End Sub

    Public Sub Initialization(ByVal strMembershipNo As String, ByVal strName As String)
        Dim svcMembership As New Membership.svcMembership()
        Dim adorow As DataRow
        Dim I As Integer

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            dsParameters = svcMembership.GetMemberSystemInfo(APP_ID)
            adorow = dsParameters.Tables("MEMBERINFO").Rows(0)

            lblMembershipNo.Text = strMembershipNo
            lblName.Text = strName
            dtpDate.Value = Now
            dtpDate.MinDate = Now
            cboMemberType.SelectedIndex = 0
            If cboMemberType.SelectedIndex = 0 Then
                lblPokok.Text = Format(adorow!POKOK_NT, "##,##0")
                lblWajib.Text = Format(adorow!WAJIB_NT, "##,##0")
            Else
                lblPokok.Text = Format(adorow!POKOK_EX, "##,##0")
                lblWajib.Text = Format(adorow!WAJIB_EX, "##,##0")
            End If
            cboStaffType.SelectedIndex = 0
            If cboStaffType.SelectedIndex = 0 Then
                lblInterest.Text = adorow!INTEREST_SS
            Else
                lblInterest.Text = adorow!INTEREST_NS
            End If
            txtSukarela.Value = 0
            lblTotal.Text = Format(CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value, "##,##0")
            lblLastUpdate.Text = USER_ID & ", " & NullToString(Format(Now, "dd MMM yyyy, hh:mm:ss tt"))
        Catch ex As Exception
            GroupBox1.Enabled = False
            btnSave.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateRS()
            FillDataSet(myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CreateRS() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn
        Dim adoTable As DataTable

        adoTable = New DataTable("MEMBERINFO")
        adoDS.Tables.Add(adoTable)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("EFFECTIVE_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBER_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("STAFF_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("SUKARELA")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        CreateRS = adoDS
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lblPokok.Text = "" Then
            Exit Sub
        End If

        If lblInterest.Text = "" Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub frmMembership01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blnCancel = False
    End Sub

    Private Sub cboMemberType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMemberType.SelectedIndexChanged
        Dim adoRow As DataRow

        adoRow = dsParameters.Tables("MEMBERINFO").Rows(0)

        If cboMemberType.SelectedIndex = 0 Then
            lblPokok.Text = Format(adoRow!POKOK_NT, "##,##0")
            lblWajib.Text = Format(adoRow!WAJIB_NT, "##,##0")
        Else
            lblPokok.Text = Format(adoRow!POKOK_EX, "##,##0")
            lblWajib.Text = Format(adoRow!WAJIB_EX, "##,##0")
        End If
        lblTotal.Text = Format(CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value, "##,##0")
    End Sub

    Private Sub cboStaffType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStaffType.SelectedIndexChanged
        Dim adoRow As DataRow

        adoRow = dsParameters.Tables("MEMBERINFO").Rows(0)

        If cboStaffType.SelectedIndex = 0 Then
            lblInterest.Text = adoRow!INTEREST_SS
        Else
            lblInterest.Text = adoRow!INTEREST_NS
        End If
    End Sub

    Private Sub txtSukarela_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSukarela.ValueChanged
        lblTotal.Text = CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value
    End Sub

    Private Sub txtSukarela_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSukarela.Leave
        lblTotal.Text = CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value
    End Sub
End Class