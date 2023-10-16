Public Class frmEmployeeInfo01
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboActiveStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrefName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMobilePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeFax As System.Windows.Forms.TextBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficeFax As System.Windows.Forms.TextBox
    Friend WithEvents lblPositionName As System.Windows.Forms.Label
    Friend WithEvents txtPosAddress01 As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtResAddress01 As System.Windows.Forms.TextBox
    Friend WithEvents txtPosAddress02 As System.Windows.Forms.TextBox
    Friend WithEvents txtResAddress02 As System.Windows.Forms.TextBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtPositionId As System.Windows.Forms.TextBox
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents grbEmployee As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeInfo01))
        Me.grbEmployee = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHomeFax = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOfficeFax = New System.Windows.Forms.TextBox()
        Me.lblPositionName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPosAddress01 = New System.Windows.Forms.TextBox()
        Me.txtOfficePhone = New System.Windows.Forms.TextBox()
        Me.txtResAddress01 = New System.Windows.Forms.TextBox()
        Me.txtPosAddress02 = New System.Windows.Forms.TextBox()
        Me.txtResAddress02 = New System.Windows.Forms.TextBox()
        Me.txtPositionId = New System.Windows.Forms.TextBox()
        Me.cboActiveStatus = New System.Windows.Forms.ComboBox()
        Me.txtPrefName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
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
        Me.grbEmployee.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label15, Me.txtMobilePhone, Me.Label11, Me.txtHomeFax, Me.Label9, Me.txtHomePhone, Me.Label8, Me.txtOfficeFax, Me.lblPositionName, Me.lblPosition, Me.Label12, Me.Label10, Me.Label7, Me.Label5, Me.txtPosAddress01, Me.txtOfficePhone, Me.txtResAddress01, Me.txtPosAddress02, Me.txtResAddress02, Me.txtPositionId, Me.cboActiveStatus, Me.txtPrefName, Me.Label6, Me.txtMiddleName, Me.txtLastName, Me.Label1, Me.Label4, Me.txtEmployeeId, Me.txtFirstName, Me.Label3, Me.Label2})
        Me.grbEmployee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEmployee.ForeColor = System.Drawing.Color.Blue
        Me.grbEmployee.Location = New System.Drawing.Point(0, 5)
        Me.grbEmployee.Name = "grbEmployee"
        Me.grbEmployee.Size = New System.Drawing.Size(720, 387)
        Me.grbEmployee.TabIndex = 2
        Me.grbEmployee.TabStop = False
        Me.grbEmployee.Text = "Employee Profile Information"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(5, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 14)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Mobile Phone:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.BackColor = System.Drawing.Color.White
        Me.txtMobilePhone.Location = New System.Drawing.Point(80, 285)
        Me.txtMobilePhone.MaxLength = 50
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(272, 21)
        Me.txtMobilePhone.TabIndex = 16
        Me.txtMobilePhone.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(374, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 14)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Home Fax:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHomeFax
        '
        Me.txtHomeFax.BackColor = System.Drawing.Color.White
        Me.txtHomeFax.Location = New System.Drawing.Point(432, 261)
        Me.txtHomeFax.MaxLength = 50
        Me.txtHomeFax.Name = "txtHomeFax"
        Me.txtHomeFax.Size = New System.Drawing.Size(280, 21)
        Me.txtHomeFax.TabIndex = 15
        Me.txtHomeFax.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 14)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Home Phone:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHomePhone
        '
        Me.txtHomePhone.BackColor = System.Drawing.Color.White
        Me.txtHomePhone.Location = New System.Drawing.Point(80, 261)
        Me.txtHomePhone.MaxLength = 50
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(272, 21)
        Me.txtHomePhone.TabIndex = 14
        Me.txtHomePhone.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(374, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Office Fax:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOfficeFax
        '
        Me.txtOfficeFax.BackColor = System.Drawing.Color.White
        Me.txtOfficeFax.Location = New System.Drawing.Point(432, 237)
        Me.txtOfficeFax.MaxLength = 50
        Me.txtOfficeFax.Name = "txtOfficeFax"
        Me.txtOfficeFax.Size = New System.Drawing.Size(280, 21)
        Me.txtOfficeFax.TabIndex = 13
        Me.txtOfficeFax.Text = ""
        '
        'lblPositionName
        '
        Me.lblPositionName.AutoSize = True
        Me.lblPositionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionName.ForeColor = System.Drawing.Color.Black
        Me.lblPositionName.Location = New System.Drawing.Point(168, 104)
        Me.lblPositionName.Name = "lblPositionName"
        Me.lblPositionName.Size = New System.Drawing.Size(83, 14)
        Me.lblPositionName.TabIndex = 50
        Me.lblPositionName.Text = "PositionName"
        Me.lblPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(32, 104)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 14)
        Me.lblPosition.TabIndex = 49
        Me.lblPosition.Text = "Position:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 14)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Res. Address:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(360, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Post Address:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 14)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Office Phone:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Pref. Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPosAddress01
        '
        Me.txtPosAddress01.BackColor = System.Drawing.Color.White
        Me.txtPosAddress01.Location = New System.Drawing.Point(432, 125)
        Me.txtPosAddress01.MaxLength = 1000
        Me.txtPosAddress01.Multiline = True
        Me.txtPosAddress01.Name = "txtPosAddress01"
        Me.txtPosAddress01.Size = New System.Drawing.Size(280, 51)
        Me.txtPosAddress01.TabIndex = 10
        Me.txtPosAddress01.Text = ""
        '
        'txtOfficePhone
        '
        Me.txtOfficePhone.BackColor = System.Drawing.Color.White
        Me.txtOfficePhone.Location = New System.Drawing.Point(80, 237)
        Me.txtOfficePhone.MaxLength = 50
        Me.txtOfficePhone.Name = "txtOfficePhone"
        Me.txtOfficePhone.Size = New System.Drawing.Size(272, 21)
        Me.txtOfficePhone.TabIndex = 12
        Me.txtOfficePhone.Text = ""
        '
        'txtResAddress01
        '
        Me.txtResAddress01.BackColor = System.Drawing.Color.White
        Me.txtResAddress01.Location = New System.Drawing.Point(80, 125)
        Me.txtResAddress01.MaxLength = 1000
        Me.txtResAddress01.Multiline = True
        Me.txtResAddress01.Name = "txtResAddress01"
        Me.txtResAddress01.Size = New System.Drawing.Size(272, 51)
        Me.txtResAddress01.TabIndex = 8
        Me.txtResAddress01.Text = ""
        '
        'txtPosAddress02
        '
        Me.txtPosAddress02.BackColor = System.Drawing.Color.White
        Me.txtPosAddress02.Location = New System.Drawing.Point(432, 181)
        Me.txtPosAddress02.MaxLength = 1000
        Me.txtPosAddress02.Multiline = True
        Me.txtPosAddress02.Name = "txtPosAddress02"
        Me.txtPosAddress02.Size = New System.Drawing.Size(280, 51)
        Me.txtPosAddress02.TabIndex = 11
        Me.txtPosAddress02.Text = ""
        '
        'txtResAddress02
        '
        Me.txtResAddress02.BackColor = System.Drawing.Color.White
        Me.txtResAddress02.Location = New System.Drawing.Point(80, 181)
        Me.txtResAddress02.MaxLength = 1000
        Me.txtResAddress02.Multiline = True
        Me.txtResAddress02.Name = "txtResAddress02"
        Me.txtResAddress02.Size = New System.Drawing.Size(272, 51)
        Me.txtResAddress02.TabIndex = 9
        Me.txtResAddress02.Text = ""
        '
        'txtPositionId
        '
        Me.txtPositionId.BackColor = System.Drawing.Color.LightGray
        Me.txtPositionId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPositionId.Location = New System.Drawing.Point(80, 101)
        Me.txtPositionId.MaxLength = 10
        Me.txtPositionId.Name = "txtPositionId"
        Me.txtPositionId.Size = New System.Drawing.Size(80, 21)
        Me.txtPositionId.TabIndex = 7
        Me.txtPositionId.Text = ""
        '
        'cboActiveStatus
        '
        Me.cboActiveStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActiveStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.cboActiveStatus.Location = New System.Drawing.Point(552, 77)
        Me.cboActiveStatus.Name = "cboActiveStatus"
        Me.cboActiveStatus.Size = New System.Drawing.Size(112, 21)
        Me.cboActiveStatus.TabIndex = 6
        '
        'txtPrefName
        '
        Me.txtPrefName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPrefName.Location = New System.Drawing.Point(80, 77)
        Me.txtPrefName.MaxLength = 50
        Me.txtPrefName.Name = "txtPrefName"
        Me.txtPrefName.Size = New System.Drawing.Size(160, 21)
        Me.txtPrefName.TabIndex = 5
        Me.txtPrefName.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(473, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Active Status:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.White
        Me.txtMiddleName.Location = New System.Drawing.Point(320, 53)
        Me.txtMiddleName.MaxLength = 50
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(160, 21)
        Me.txtMiddleName.TabIndex = 3
        Me.txtMiddleName.Text = ""
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.Location = New System.Drawing.Point(552, 53)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(160, 21)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(488, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Last Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(248, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 14)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Middle Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(80, 29)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(80, 53)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(160, 21)
        Me.txtFirstName.TabIndex = 2
        Me.txtFirstName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "First Name:"
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
        Me.btnSave.Location = New System.Drawing.Point(549, 397)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(637, 397)
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
        Me.lblLastUpdate.Location = New System.Drawing.Point(72, 403)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 14)
        Me.lblLastUpdate.TabIndex = 24
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(8, 403)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 14)
        Me.lblTitleLast.TabIndex = 23
        Me.lblTitleLast.Text = "Last Update:"
        '
        'frmEmployeeInfo01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(720, 425)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.lblTitleLast, Me.grbEmployee, Me.btnSave, Me.btnClose})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeInfo01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Information - Edit Screen"
        Me.grbEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean

    Private Sub frmEmployeeInfo01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adoDS As DataSet
        Dim svcHRIS As New HRIS.svcHRIS()

        Try
            blnCancel = True

            If blnAddNew Then
                lblPosition.Visible = False
                txtPositionId.Visible = False
                lblPositionName.Text = ""

                txtEmployeeId.Enabled = True
                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                txtEmployeeId.Enabled = False
                lblTitleLast.Visible = True
                adoDS = svcHRIS.GetLatestEMPPosition(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("LATEMPPOSITION").Rows.Count > 0 Then
                    lblPosition.Visible = True
                    txtPositionId.Visible = True
                    lblPositionName.Text = ""

                    txtPositionId.Text = adoDS.Tables("LATEMPPOSITION").Rows(0)("POSITION_ID")
                    lblPositionName.Text = adoDS.Tables("LATEMPPOSITION").Rows(0)("POSITION_NAME")
                Else
                    lblPosition.Visible = False
                    txtPositionId.Visible = False
                    lblPositionName.Text = ""
                End If
                adoDS.Dispose()

                If cboActiveStatus.SelectedIndex = 1 Then
                    grbEmployee.Enabled = False
                    btnSave.Enabled = False
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

        adoDataTable = adoDS.Tables("EMPLOYEEPROFILE")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("EMPLOYEE_ID") = txtEmployeeId.Text
        adoDataRow("FIRST_NAME") = txtFirstName.Text
        adoDataRow("MIDDLE_NAME") = txtMiddleName.Text
        adoDataRow("LAST_NAME") = txtLastName.Text
        If cboActiveStatus.Text = "Active" Then
            adoDataRow("ACTIVE_STATUS") = "A"
        Else
            adoDataRow("ACTIVE_STATUS") = "N"
        End If
        adoDataRow("PREF_NAME") = txtPrefName.Text
        adoDataRow("POSITION") = txtPositionId.Text
        adoDataRow("RES_ADDRESS01") = txtResAddress01.Text
        adoDataRow("RES_ADDRESS02") = txtResAddress02.Text
        adoDataRow("POST_ADDRESS01") = txtPosAddress01.Text
        adoDataRow("POST_ADDRESS02") = txtPosAddress02.Text
        adoDataRow("OFFICE_PHONE") = txtOfficePhone.Text
        adoDataRow("OFFICE_FAX") = txtOfficeFax.Text
        adoDataRow("HOME_PHONE") = txtHomePhone.Text
        adoDataRow("HOME_FAX") = txtHomeFax.Text
        adoDataRow("MOBILE_PHONE") = txtMobilePhone.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("EMPLOYEEPROFILE")

        adoColumn = New DataColumn("EMPLOYEE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("FIRST_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MIDDLE_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("LAST_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ACTIVE_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PREF_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POSITION")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RES_ADDRESS01")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RES_ADDRESS02")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POST_ADDRESS01")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POST_ADDRESS02")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_PHONE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_FAX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("HOME_PHONE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("HOME_FAX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOBILE_PHONE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EMPLOYEEPROFILE").Columns.Add(adoColumn)

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
            If adoDS.Tables("EMPINFO").Rows.Count > 0 Then
                adoRow = adoDS.Tables("EMPINFO").Rows(0)
                txtEmployeeId.Text = adoRow!EMPLOYEE_ID
                txtFirstName.Text = adoRow!FIRST_NAME
                If NullToString(adoRow!MIDDLE_NAME) <> "" Then
                    txtMiddleName.Text = adoRow!MIDDLE_NAME
                End If
                If NullToString(adoRow!LAST_NAME) <> "" Then
                    txtLastName.Text = adoRow!LAST_NAME
                End If
                If adoRow!ACTIVE_STATUS = "A" Then
                    cboActiveStatus.SelectedIndex = 0
                Else
                    cboActiveStatus.SelectedIndex = 1
                End If
                If NullToString(adoRow!PREF_NAME) <> "" Then
                    txtPrefName.Text = adoRow!PREF_NAME
                End If
                If NullToString(adoRow!RES_ADDRESS01) <> "" Then
                    txtResAddress01.Text = adoRow!RES_ADDRESS01
                End If
                If NullToString(adoRow!RES_ADDRESS02) <> "" Then
                    txtResAddress02.Text = adoRow!RES_ADDRESS02
                End If
                If NullToString(adoRow!POST_ADDRESS01) <> "" Then
                    txtPosAddress01.Text = adoRow!POST_ADDRESS01
                End If
                If NullToString(adoRow!POST_ADDRESS02) <> "" Then
                    txtPosAddress02.Text = adoRow!POST_ADDRESS02
                End If
                If NullToString(adoRow!OFFICE_PHONE) <> "" Then
                    txtOfficePhone.Text = adoRow!OFFICE_PHONE
                End If
                If NullToString(adoRow!OFFICE_FAX) <> "" Then
                    txtOfficeFax.Text = adoRow!OFFICE_FAX
                End If
                If NullToString(adoRow!HOME_FAX) <> "" Then
                    txtHomeFax.Text = adoRow!HOME_FAX
                End If
                If NullToString(adoRow!HOME_PHONE) <> "" Then
                    txtHomePhone.Text = adoRow!HOME_PHONE
                End If
                If NullToString(adoRow!MOBILE_PHONE) <> "" Then
                    txtMobilePhone.Text = adoRow!MOBILE_PHONE
                End If
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
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
        If ValidateEmptyField(txtFirstName) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtPrefName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboActiveStatus) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

End Class
