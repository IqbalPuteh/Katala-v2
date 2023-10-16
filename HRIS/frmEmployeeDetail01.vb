Public Class frmEmployeeDetail01
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPositionName As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents cboActiveStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrefName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaritalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents dtpBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBirthPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPointHire As System.Windows.Forms.TextBox
    Friend WithEvents dtpHireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRetireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents txtDependants As System.Windows.Forms.NumericUpDown
    Friend WithEvents grbEmployee As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeDetail01))
        Me.grbEmployee = New System.Windows.Forms.GroupBox()
        Me.txtDependants = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpRetireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.cboReligion = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.cboMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPositionName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPointHire = New System.Windows.Forms.TextBox()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.cboActiveStatus = New System.Windows.Forms.ComboBox()
        Me.txtPrefName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblTitleLast = New System.Windows.Forms.Label()
        Me.grbEmployee.SuspendLayout()
        CType(Me.txtDependants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbEmployee
        '
        Me.grbEmployee.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDependants, Me.Label11, Me.txtComments, Me.Label4, Me.dtpRetireDate, Me.Label1, Me.dtpHireDate, Me.cboReligion, Me.Label16, Me.Label14, Me.dtpBirthDate, Me.cboMaritalStatus, Me.cboGender, Me.Label15, Me.Label9, Me.Label8, Me.lblPositionName, Me.Label13, Me.Label12, Me.Label10, Me.Label7, Me.Label5, Me.txtPointHire, Me.txtBirthPlace, Me.txtNationality, Me.txtPosition, Me.cboActiveStatus, Me.txtPrefName, Me.Label6, Me.txtEmployeeId, Me.txtEmployeeName, Me.Label3, Me.Label2})
        Me.grbEmployee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEmployee.ForeColor = System.Drawing.Color.Blue
        Me.grbEmployee.Location = New System.Drawing.Point(0, 5)
        Me.grbEmployee.Name = "grbEmployee"
        Me.grbEmployee.Size = New System.Drawing.Size(720, 387)
        Me.grbEmployee.TabIndex = 3
        Me.grbEmployee.TabStop = False
        Me.grbEmployee.Text = "Employee Detail Information"
        '
        'txtDependants
        '
        Me.txtDependants.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDependants.Location = New System.Drawing.Point(512, 160)
        Me.txtDependants.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtDependants.Name = "txtDependants"
        Me.txtDependants.Size = New System.Drawing.Size(48, 21)
        Me.txtDependants.TabIndex = 13
        Me.txtDependants.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 14)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Comments:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComments.Location = New System.Drawing.Point(80, 232)
        Me.txtComments.MaxLength = 2000
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(632, 64)
        Me.txtComments.TabIndex = 16
        Me.txtComments.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 14)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Retire Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpRetireDate
        '
        Me.dtpRetireDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpRetireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRetireDate.Location = New System.Drawing.Point(80, 208)
        Me.dtpRetireDate.Name = "dtpRetireDate"
        Me.dtpRetireDate.ShowCheckBox = True
        Me.dtpRetireDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpRetireDate.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Hire Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpHireDate
        '
        Me.dtpHireDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHireDate.Location = New System.Drawing.Point(80, 184)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpHireDate.TabIndex = 14
        '
        'cboReligion
        '
        Me.cboReligion.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReligion.Items.AddRange(New Object() {"Budha", "Hindu", "Islam", "Katolik", "Kristen"})
        Me.cboReligion.Location = New System.Drawing.Point(512, 136)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.Size = New System.Drawing.Size(112, 21)
        Me.cboReligion.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(463, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 14)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Religion:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(20, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 14)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Birth Date:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthDate.Location = New System.Drawing.Point(80, 136)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(104, 21)
        Me.dtpBirthDate.TabIndex = 9
        '
        'cboMaritalStatus
        '
        Me.cboMaritalStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaritalStatus.Items.AddRange(New Object() {"Single", "Married", "Widow"})
        Me.cboMaritalStatus.Location = New System.Drawing.Point(266, 112)
        Me.cboMaritalStatus.Name = "cboMaritalStatus"
        Me.cboMaritalStatus.Size = New System.Drawing.Size(112, 21)
        Me.cboMaritalStatus.TabIndex = 7
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(80, 112)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(104, 21)
        Me.cboGender.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(444, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 14)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Dependants:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(22, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Point Hire:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(205, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 14)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Birth Place:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPositionName
        '
        Me.lblPositionName.AutoSize = True
        Me.lblPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionName.ForeColor = System.Drawing.Color.Black
        Me.lblPositionName.Location = New System.Drawing.Point(168, 80)
        Me.lblPositionName.Name = "lblPositionName"
        Me.lblPositionName.Size = New System.Drawing.Size(83, 14)
        Me.lblPositionName.TabIndex = 50
        Me.lblPositionName.Text = "PositionName"
        Me.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(32, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 14)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Position:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(35, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 14)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Gender:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(189, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Marital Status:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(450, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Nationality:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(448, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Pref. Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPointHire
        '
        Me.txtPointHire.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPointHire.Location = New System.Drawing.Point(80, 160)
        Me.txtPointHire.MaxLength = 50
        Me.txtPointHire.Name = "txtPointHire"
        Me.txtPointHire.Size = New System.Drawing.Size(296, 21)
        Me.txtPointHire.TabIndex = 12
        Me.txtPointHire.Text = ""
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtBirthPlace.Location = New System.Drawing.Point(266, 136)
        Me.txtBirthPlace.MaxLength = 50
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(174, 21)
        Me.txtBirthPlace.TabIndex = 10
        Me.txtBirthPlace.Text = ""
        '
        'txtNationality
        '
        Me.txtNationality.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtNationality.Location = New System.Drawing.Point(512, 112)
        Me.txtNationality.MaxLength = 50
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(200, 21)
        Me.txtNationality.TabIndex = 8
        Me.txtNationality.Text = ""
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.LightGray
        Me.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosition.Location = New System.Drawing.Point(80, 77)
        Me.txtPosition.MaxLength = 10
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(80, 21)
        Me.txtPosition.TabIndex = 4
        Me.txtPosition.Text = ""
        '
        'cboActiveStatus
        '
        Me.cboActiveStatus.BackColor = System.Drawing.Color.LightGray
        Me.cboActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActiveStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.cboActiveStatus.Location = New System.Drawing.Point(512, 77)
        Me.cboActiveStatus.Name = "cboActiveStatus"
        Me.cboActiveStatus.Size = New System.Drawing.Size(112, 21)
        Me.cboActiveStatus.TabIndex = 5
        '
        'txtPrefName
        '
        Me.txtPrefName.BackColor = System.Drawing.Color.LightGray
        Me.txtPrefName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrefName.Location = New System.Drawing.Point(512, 53)
        Me.txtPrefName.MaxLength = 10
        Me.txtPrefName.Name = "txtPrefName"
        Me.txtPrefName.Size = New System.Drawing.Size(112, 21)
        Me.txtPrefName.TabIndex = 3
        Me.txtPrefName.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(439, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Active Status:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.LightGray
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(80, 29)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BackColor = System.Drawing.Color.LightGray
        Me.txtEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeName.Location = New System.Drawing.Point(80, 53)
        Me.txtEmployeeName.MaxLength = 150
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(360, 21)
        Me.txtEmployeeName.TabIndex = 2
        Me.txtEmployeeName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Emp. Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Employee Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(548, 397)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(636, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(72, 402)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 14)
        Me.lblLastUpdate.TabIndex = 26
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(8, 402)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 14)
        Me.lblTitleLast.TabIndex = 25
        Me.lblTitleLast.Text = "Last Update:"
        '
        'frmEmployeeDetail01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 425)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.lblTitleLast, Me.btnSave, Me.btnClose, Me.grbEmployee})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeDetail01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Detail - Edit Screen"
        Me.grbEmployee.ResumeLayout(False)
        CType(Me.txtDependants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean
    Dim blnAddNew As Boolean
    Dim strRecordId As String

    Private Sub frmEmployeeInfo01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adoDS As DataSet
        Dim myDS As DataSet
        Dim svcHRIS As New HRIS.svcHRIS()

        Try
            blnCancel = True
            adoDS = svcHRIS.GetLatestEMPPosition(txtEmployeeId.Text, APP_ID)
            If adoDS.Tables("LATEMPPOSITION").Rows.Count > 0 Then
                txtPosition.Text = adoDS.Tables("LATEMPPOSITION").Rows(0)("POSITION_ID")
                lblPositionName.Text = adoDS.Tables("LATEMPPOSITION").Rows(0)("POSITION_NAME")
            Else
                lblPositionName.Text = ""
            End If
            adoDS.Dispose()

            txtEmployeeId.Enabled = False
            txtEmployeeName.Enabled = False
            txtPrefName.Enabled = False
            txtPosition.Enabled = False
            cboActiveStatus.Enabled = False
            If blnAddNew Then
                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
                dtpRetireDate.Checked = False
                adoDS = svcHRIS.GetLatestEMPDetail(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPDETAIL").Rows.Count > 0 Then
                    myDS = svcHRIS.GetEmpDetail(txtEmployeeId.Text, adoDS.Tables("LATEMPDETAIL").Rows(0)("RECORD_ID"), APP_ID)
                    FillField(myDS)
                    If adoDS.Tables("LATEMPDETAIL").Rows(0)("ACTIVE_STATUS") = "N" Then
                        grbEmployee.Enabled = False
                        btnSave.Enabled = False
                    End If
                    myDS.Dispose()
                End If
                adoDS.Dispose()
            Else
                adoDS = svcHRIS.GetLatestEMPDetail(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPDETAIL").Rows.Count > 0 Then
                    If adoDS.Tables("LATEMPDETAIL").Rows(0)("ACTIVE_STATUS") = "A" Then
                        If strRecordId = CStr(adoDS.Tables("LATEMPDETAIL").Rows(0)("RECORD_ID")) Then
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
            End If

        Catch ex As Exception
            grbEmployee.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddNew = blnAdd
        dtpBirthDate.Value = Now
        dtpHireDate.Value = Now
        dtpRetireDate.Value = Now
    End Sub

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

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("EMPLOYEEDETAIL")
        adoDataRow = adoDataTable.NewRow()
        If blnAddNew = False Then
            adoDataRow("RECORD_ID") = strRecordId
        End If
        adoDataRow("EMPLOYEE_ID") = txtEmployeeId.Text
        If cboGender.Text = "Male" Then
            adoDataRow("GENDER") = "M"
        Else
            adoDataRow("GENDER") = "F"
        End If
        Select Case cboMaritalStatus.Text
            Case "Single"
                adoDataRow("MARITAL_STATUS") = "S"
            Case "Married"
                adoDataRow("MARITAL_STATUS") = "M"
            Case "Widow"
                adoDataRow("MARITAL_STATUS") = "W"
        End Select
        adoDataRow("NATIONALITY") = txtNationality.Text
        adoDataRow("BIRTH_DATE") = dtpBirthDate.Value
        adoDataRow("BIRTH_PLACE") = txtBirthPlace.Text
        adoDataRow("RELIGION") = cboReligion.Text
        adoDataRow("POINT_HIRE") = txtPointHire.Text
        adoDataRow("HIRE_DATE") = dtpHireDate.Value
        If dtpRetireDate.Checked Then
            adoDataRow("RETIRE_DATE") = dtpRetireDate.Value
        End If
        adoDataRow("DEPENDANTS") = txtDependants.Text
        adoDataRow("COMMENTS") = txtComments.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("EMPLOYEEDETAIL")

        adoColumn = New DataColumn("RECORD_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EMPLOYEE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("GENDER")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MARITAL_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("NATIONALITY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("BIRTH_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("BIRTH_PLACE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RELIGION")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POINT_HIRE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("HIRE_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RETIRE_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DEPENDANTS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENTS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEDETAIL").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow
        Try
            If adoDS.Tables("EMPDETAIL").Rows.Count > 0 Then
                adoRow = adoDS.Tables("EMPDETAIL").Rows(0)
                strRecordId = adoRow!RECORD_ID
                txtEmployeeId.Text = adoRow!EMPLOYEE_ID
                If adoRow!GENDER = "M" Then
                    cboGender.SelectedIndex = 0
                Else
                    cboGender.SelectedIndex = 1
                End If
                If adoRow!MARITAL_STATUS = "S" Then
                    cboMaritalStatus.SelectedIndex = 0
                ElseIf adoRow!MARITAL_STATUS = "M" Then
                    cboMaritalStatus.SelectedIndex = 1
                Else
                    cboMaritalStatus.SelectedIndex = 2
                End If
                txtNationality.Text = adoRow!NATIONALITY
                dtpBirthDate.Value = adoRow!BIRTH_DATE
                txtBirthPlace.Text = adoRow!BIRTH_PLACE
                Select Case adoRow!RELIGION
                    Case "Budha"
                        cboReligion.SelectedIndex = 0
                    Case "Hindu"
                        cboReligion.SelectedIndex = 1
                    Case "Islam"
                        cboReligion.SelectedIndex = 2
                    Case "Katolik"
                        cboReligion.SelectedIndex = 3
                    Case "Kristen"
                        cboReligion.SelectedIndex = 4
                End Select
                txtPointHire.Text = adoRow!POINT_HIRE
                txtDependants.Text = adoRow!DEPENDANTS
                dtpHireDate.Value = adoRow!HIRE_DATE
                If Not IsDBNull(adoRow!RETIRE_DATE) Then
                    dtpRetireDate.Value = adoRow!RETIRE_DATE
                Else
                    dtpRetireDate.Checked = False
                End If
                txtComments.Text = adoRow!COMMENTS
                lblTitleLast.Visible = True
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
            End If

        Catch ex As Exception
            grbEmployee.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Public Sub AddNew(ByVal adoDS As DataSet)
        Dim adoRow As DataRow
        Try
            If adoDS.Tables("EMPINFO").Rows.Count > 0 Then
                adoRow = adoDS.Tables("EMPINFO").Rows(0)
                txtEmployeeId.Text = adoRow!EMPLOYEE_ID
                txtEmployeeName.Text = Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & Trim(NullToString(adoRow!LAST_NAME))))
                If adoRow!ACTIVE_STATUS = "A" Then
                    cboActiveStatus.SelectedIndex = 0
                Else
                    cboActiveStatus.SelectedIndex = 1
                End If
                If NullToString(adoRow!PREF_NAME) <> "" Then
                    txtPrefName.Text = adoRow!PREF_NAME
                End If
            End If
        Catch ex As Exception
            grbEmployee.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtEmployeeId) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtEmployeeName) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtPrefName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboActiveStatus) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboGender) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboMaritalStatus) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtNationality) Then
            Exit Sub
        End If
        If dtpRetireDate.Checked Then
            If dtpHireDate.Value > dtpRetireDate.Value Then
                MessageBox.Show("Retire Date must be greater than Hire Date!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If ValidateEmptyField(txtBirthPlace) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboReligion) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtPointHire) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

End Class
