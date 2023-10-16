Public Class frmMembership01
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEntryDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPokok As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblWajib As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblMemberNo As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtCellPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeAddr As System.Windows.Forms.TextBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtBadgeId As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cboStaffType As System.Windows.Forms.ComboBox
    Friend WithEvents cboMemberStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboMemberType As System.Windows.Forms.ComboBox
    Friend WithEvents lblInterest As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtFamilyName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents dtpSince As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSukarela As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboActiveStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboLoanStatus As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembership01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboLoanStatus = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboActiveStatus = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtSukarela = New System.Windows.Forms.NumericUpDown
        Me.dtpSince = New System.Windows.Forms.DateTimePicker
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtCellPhone = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtHomePhone = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtOfficePhone = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtPostalCode = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtProvince = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtHomeAddr = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtBadgeId = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtFamilyName = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblMemberNo = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblInterest = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboStaffType = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblWajib = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblPokok = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboMemberStatus = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboMemberType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEntryDate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSukarela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboLoanStatus)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cboActiveStatus)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtSukarela)
        Me.GroupBox1.Controls.Add(Me.dtpSince)
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.txtCellPhone)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.txtHomePhone)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtOfficePhone)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtPostalCode)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtHomeAddr)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cboDepartment)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtBadgeId)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtFamilyName)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblMemberNo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblInterest)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboStaffType)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblWajib)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblPokok)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboMemberStatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboMemberType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblEntryDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 520)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Information"
        '
        'cboLoanStatus
        '
        Me.cboLoanStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboLoanStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoanStatus.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboLoanStatus.Location = New System.Drawing.Point(112, 440)
        Me.cboLoanStatus.Name = "cboLoanStatus"
        Me.cboLoanStatus.Size = New System.Drawing.Size(88, 21)
        Me.cboLoanStatus.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(39, 448)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Loan Status:"
        '
        'cboActiveStatus
        '
        Me.cboActiveStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActiveStatus.Enabled = False
        Me.cboActiveStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.cboActiveStatus.Location = New System.Drawing.Point(512, 24)
        Me.cboActiveStatus.Name = "cboActiveStatus"
        Me.cboActiveStatus.Size = New System.Drawing.Size(104, 21)
        Me.cboActiveStatus.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(437, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 17)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Active Status:"
        '
        'txtSukarela
        '
        Me.txtSukarela.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSukarela.Location = New System.Drawing.Point(512, 176)
        Me.txtSukarela.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtSukarela.Name = "txtSukarela"
        Me.txtSukarela.TabIndex = 7
        Me.txtSukarela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpSince
        '
        Me.dtpSince.CustomFormat = "yyyy-MM"
        Me.dtpSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSince.Location = New System.Drawing.Point(512, 80)
        Me.dtpSince.Name = "dtpSince"
        Me.dtpSince.ShowUpDown = True
        Me.dtpSince.Size = New System.Drawing.Size(80, 21)
        Me.dtpSince.TabIndex = 4
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComments.Location = New System.Drawing.Point(112, 464)
        Me.txtComments.MaxLength = 200
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(568, 48)
        Me.txtComments.TabIndex = 22
        Me.txtComments.Text = ""
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(45, 472)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(61, 17)
        Me.Label35.TabIndex = 57
        Me.Label35.Text = "Comments:"
        '
        'txtCellPhone
        '
        Me.txtCellPhone.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtCellPhone.Location = New System.Drawing.Point(448, 416)
        Me.txtCellPhone.MaxLength = 50
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(232, 21)
        Me.txtCellPhone.TabIndex = 20
        Me.txtCellPhone.Text = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(366, 419)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 17)
        Me.Label34.TabIndex = 55
        Me.Label34.Text = "Cellular Phone:"
        '
        'txtHomePhone
        '
        Me.txtHomePhone.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtHomePhone.Location = New System.Drawing.Point(112, 416)
        Me.txtHomePhone.MaxLength = 50
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(232, 21)
        Me.txtHomePhone.TabIndex = 19
        Me.txtHomePhone.Text = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(34, 419)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 17)
        Me.Label33.TabIndex = 53
        Me.Label33.Text = "Home Phone:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(448, 392)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(232, 21)
        Me.txtEmail.TabIndex = 18
        Me.txtEmail.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(411, 395)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 17)
        Me.Label31.TabIndex = 50
        Me.Label31.Text = "Email:"
        '
        'txtOfficePhone
        '
        Me.txtOfficePhone.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtOfficePhone.Location = New System.Drawing.Point(112, 392)
        Me.txtOfficePhone.MaxLength = 50
        Me.txtOfficePhone.Name = "txtOfficePhone"
        Me.txtOfficePhone.Size = New System.Drawing.Size(232, 21)
        Me.txtOfficePhone.TabIndex = 17
        Me.txtOfficePhone.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(34, 395)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 17)
        Me.Label30.TabIndex = 48
        Me.Label30.Text = "Office Phone:"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(112, 368)
        Me.TextBox9.MaxLength = 200
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(568, 21)
        Me.TextBox9.TabIndex = 16
        Me.TextBox9.Text = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(2, 371)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 17)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "House/Camp Addrs:"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(112, 344)
        Me.txtPostalCode.MaxLength = 10
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(104, 21)
        Me.txtPostalCode.TabIndex = 15
        Me.txtPostalCode.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(39, 347)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 17)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Postal Code:"
        '
        'txtProvince
        '
        Me.txtProvince.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(448, 320)
        Me.txtProvince.MaxLength = 100
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(232, 21)
        Me.txtProvince.TabIndex = 14
        Me.txtProvince.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(396, 323)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 17)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Province:"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtCity.Location = New System.Drawing.Point(112, 320)
        Me.txtCity.MaxLength = 100
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(232, 21)
        Me.txtCity.TabIndex = 13
        Me.txtCity.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(79, 323)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(27, 17)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "City:"
        '
        'txtHomeAddr
        '
        Me.txtHomeAddr.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtHomeAddr.Location = New System.Drawing.Point(112, 296)
        Me.txtHomeAddr.MaxLength = 200
        Me.txtHomeAddr.Name = "txtHomeAddr"
        Me.txtHomeAddr.Size = New System.Drawing.Size(568, 21)
        Me.txtHomeAddr.TabIndex = 12
        Me.txtHomeAddr.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(26, 299)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 17)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Home Address:"
        '
        'cboDepartment
        '
        Me.cboDepartment.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Location = New System.Drawing.Point(448, 272)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(232, 21)
        Me.cboDepartment.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(379, 275)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 17)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Department:"
        '
        'txtBadgeId
        '
        Me.txtBadgeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtBadgeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBadgeId.Location = New System.Drawing.Point(112, 272)
        Me.txtBadgeId.MaxLength = 10
        Me.txtBadgeId.Name = "txtBadgeId"
        Me.txtBadgeId.Size = New System.Drawing.Size(104, 21)
        Me.txtBadgeId.TabIndex = 10
        Me.txtBadgeId.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(53, 275)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 17)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Badge Id:"
        '
        'txtFamilyName
        '
        Me.txtFamilyName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtFamilyName.Location = New System.Drawing.Point(448, 248)
        Me.txtFamilyName.MaxLength = 50
        Me.txtFamilyName.Name = "txtFamilyName"
        Me.txtFamilyName.Size = New System.Drawing.Size(232, 21)
        Me.txtFamilyName.TabIndex = 9
        Me.txtFamilyName.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(373, 251)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 17)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Family Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(112, 248)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(232, 21)
        Me.txtFirstName.TabIndex = 8
        Me.txtFirstName.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(44, 251)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 17)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "First Name:"
        '
        'lblMemberNo
        '
        Me.lblMemberNo.AutoSize = True
        Me.lblMemberNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberNo.ForeColor = System.Drawing.Color.Black
        Me.lblMemberNo.Location = New System.Drawing.Point(112, 27)
        Me.lblMemberNo.Name = "lblMemberNo"
        Me.lblMemberNo.Size = New System.Drawing.Size(80, 17)
        Me.lblMemberNo.TabIndex = 29
        Me.lblMemberNo.Text = "lblMemberNo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(19, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 17)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Membership No:"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterest.ForeColor = System.Drawing.Color.Black
        Me.lblInterest.Location = New System.Drawing.Point(512, 208)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(65, 17)
        Me.lblInterest.TabIndex = 27
        Me.lblInterest.Text = "lblInterest"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(439, 208)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 17)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Interest (%):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(288, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 17)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "(Pokok+Wajib+Sukarela)"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(8, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(672, 1)
        Me.Label15.TabIndex = 24
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(112, 208)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 17)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "lblTotal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(72, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(459, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Sukarela:"
        '
        'cboStaffType
        '
        Me.cboStaffType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboStaffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffType.Items.AddRange(New Object() {"Staff", "Non Staff"})
        Me.cboStaffType.Location = New System.Drawing.Point(112, 176)
        Me.cboStaffType.Name = "cboStaffType"
        Me.cboStaffType.Size = New System.Drawing.Size(104, 21)
        Me.cboStaffType.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(46, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Staff Type:"
        '
        'lblWajib
        '
        Me.lblWajib.AutoSize = True
        Me.lblWajib.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWajib.ForeColor = System.Drawing.Color.Black
        Me.lblWajib.Location = New System.Drawing.Point(512, 123)
        Me.lblWajib.Name = "lblWajib"
        Me.lblWajib.Size = New System.Drawing.Size(51, 17)
        Me.lblWajib.TabIndex = 17
        Me.lblWajib.Text = "lblWajib"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(474, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Wajib:"
        '
        'lblPokok
        '
        Me.lblPokok.AutoSize = True
        Me.lblPokok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokok.ForeColor = System.Drawing.Color.Black
        Me.lblPokok.Location = New System.Drawing.Point(328, 123)
        Me.lblPokok.Name = "lblPokok"
        Me.lblPokok.Size = New System.Drawing.Size(53, 17)
        Me.lblPokok.TabIndex = 15
        Me.lblPokok.Text = "lblPokok"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(288, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pokok:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(8, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(672, 1)
        Me.Label8.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(8, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(672, 1)
        Me.Label7.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Deduction Period:"
        '
        'cboMemberStatus
        '
        Me.cboMemberStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboMemberStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberStatus.Items.AddRange(New Object() {"New", "Old"})
        Me.cboMemberStatus.Location = New System.Drawing.Point(112, 80)
        Me.cboMemberStatus.Name = "cboMemberStatus"
        Me.cboMemberStatus.Size = New System.Drawing.Size(104, 21)
        Me.cboMemberStatus.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Membership Status:"
        '
        'cboMemberType
        '
        Me.cboMemberType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberType.Items.AddRange(New Object() {"National", "Expatriate"})
        Me.cboMemberType.Location = New System.Drawing.Point(112, 120)
        Me.cboMemberType.Name = "cboMemberType"
        Me.cboMemberType.Size = New System.Drawing.Size(104, 21)
        Me.cboMemberType.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Membership Type:"
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.ForeColor = System.Drawing.Color.Black
        Me.lblEntryDate.Location = New System.Drawing.Point(512, 59)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(75, 17)
        Me.lblEntryDate.TabIndex = 5
        Me.lblEntryDate.Text = "lblEntryDate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(449, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Entry Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(112, 56)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(104, 21)
        Me.dtpDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Membership Date:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(608, 528)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(520, 528)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 536)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Last Update:"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(80, 536)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(83, 17)
        Me.lblLastUpdate.TabIndex = 11
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'frmMembership01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(690, 560)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembership01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Member Information"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtSukarela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim blnCancel As Boolean
    Dim arrDepartment() As String
    Dim dsParameters As New DataSet()

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoRow As DataRow
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("MEMBERINFO")
        adoRow = adoDataTable.NewRow()

        adoRow!MEMBERSHIP_NO = ValidateString(lblMemberNo.Text)
        adoRow!ACTIVE_STATUS = IIf(cboActiveStatus.SelectedIndex = 0, "A", "Z")
        adoRow!MEMBERSHIP_DATE = dtpDate.Value
        adoRow!MEMBERSHIP_STATUS = IIf(cboMemberStatus.SelectedIndex = 0, "NEW", "OLD")
        adoRow!DEDUCTION_PERIOD = Format(dtpSince.Value, "yyyyMM")
        adoRow!FIRST_NAME = ValidateString(txtFirstName.Text)
        adoRow!FAMILY_NAME = ValidateString(txtFamilyName.Text)
        adoRow!BADGE_ID = ValidateString(txtBadgeId.Text)
        adoRow!DEPARTMENT = arrDepartment(cboDepartment.SelectedIndex)
        adoRow!HOME_ADDRESS = ValidateString(txtHomeAddr.Text)
        adoRow!CITY = ValidateString(txtCity.Text)
        adoRow!PROVINCE = ValidateString(txtProvince.Text)
        adoRow!POSTAL_CODE = ValidateString(txtPostalCode.Text)
        adoRow!CAMP_ADDRESS = ValidateString(txtHomeAddr.Text)
        adoRow!OFFICE_PHONE = ValidateString(txtOfficePhone.Text)
        adoRow!EMAIL = ValidateString(txtEmail.Text)
        adoRow!HOME_PHONE = ValidateString(txtHomePhone.Text)
        adoRow!CELL_PHONE = ValidateString(txtCellPhone.Text)
        adoRow!COMMENTS = ValidateString(txtComments.Text)
        adoRow!LOAN_STATUS = IIf(cboLoanStatus.SelectedIndex = 0, "Y", "N")
        adoRow!REVIEWED_BY = ValidateString(USER_ID)
        adoRow!MEMBERSHIP_TYPE = IIf(cboMemberType.SelectedIndex = 0, "NAT", "EXPAT")
        adoRow!STAFF_TYPE = IIf(cboStaffType.SelectedIndex = 0, "STAFF", "NONSTAFF")
        adoRow!SUKARELA = txtSukarela.Value

        adoDataTable.Rows.Add(adoRow)
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow
        Dim I As Integer
        Dim blnFound As Boolean
        Dim adoParameters As DataRow

        If adoDS.Tables("MEMBERINFO").Rows.Count > 0 Then
            adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
            adoParameters = dsParameters.Tables("MEMBERINFO").Rows(0)

            lblMemberNo.Text = NullToString(adoRow!MEMBERSHIP_NO)
            cboActiveStatus.SelectedIndex = IIf(adoRow!ACTIVE_STATUS = "A", 0, 1)
            cboActiveStatus.Enabled = True
            dtpDate.Value = adoRow!MEMBERSHIP_DATE
            dtpDate.Enabled = False
            cboMemberStatus.Text = IIf(adoRow!MEMBERSHIP_STATUS = "NEW", 0, 1)
            cboMemberStatus.Enabled = False
            lblEntryDate.Text = Format(adoRow!ENTRY_DATE, "dd MMM yyyy, hh:mm:ss tt")
            dtpSince.Value = DateSerial(Mid(adoRow!DEDUCTION_PERIOD, 1, 4), Mid(adoRow!DEDUCTION_PERIOD, 5, 2), 1)
            dtpSince.Enabled = False
            cboMemberType.SelectedIndex = IIf(adoRow!MEMBER_TYPE = "NAT", 0, 1)
            cboMemberType.Enabled = False
            If cboMemberType.SelectedIndex = 0 Then
                lblPokok.Text = Format(adoParameters!POKOK_NT, "##,##0")
                lblWajib.Text = Format(adoParameters!WAJIB_NT, "##,##0")
            Else
                lblPokok.Text = Format(adoParameters!POKOK_EX, "##,##0")
                lblWajib.Text = Format(adoParameters!WAJIB_EX, "##,##0")
            End If
            cboStaffType.SelectedIndex = IIf(adoRow!STAFF_TYPE = "STAFF", 0, 1)
            cboStaffType.Enabled = False
            txtSukarela.Value = Format(adoRow!SUKARELA, "##,##0")
            txtSukarela.Enabled = False
            If cboStaffType.SelectedIndex = 0 Then
                lblInterest.Text = Format(adoParameters!INTEREST_SS, "##,##0")
            Else
                lblInterest.Text = Format(adoParameters!INTEREST_NS, "##,##0")
            End If
            lblTotal.Text = Format(CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value, "##,##0")

            txtFirstName.Text = NullToString(adoRow!FIRST_NAME)
            txtFamilyName.Text = NullToString(adoRow!FAMILY_NAME)
            txtBadgeId.Text = NullToString(adoRow!BADGE_ID)

            blnFound = False
            For I = 0 To UBound(arrDepartment)
                If arrDepartment(I) = adoRow!DEPARTMENT Then
                    blnFound = True
                    Exit For
                End If
            Next
            If blnFound Then
                cboDepartment.SelectedIndex = I
            Else
                cboDepartment.SelectedIndex = -1
            End If
            txtHomeAddr.Text = NullToString(adoRow!HOME_ADDRESS)
            txtCity.Text = NullToString(adoRow!CITY)
            txtProvince.Text = NullToString(adoRow!PROVINCE)
            txtPostalCode.Text = NullToString(adoRow!POSTAL_CODE)
            txtHomeAddr.Text = NullToString(adoRow!CAMP_ADDRESS)
            txtOfficePhone.Text = NullToString(adoRow!OFFICE_PHONE)
            txtHomePhone.Text = NullToString(adoRow!HOME_PHONE)
            txtEmail.Text = NullToString(adoRow!EMAIL)
            txtCellPhone.Text = NullToString(adoRow!CELL_PHONE)
            txtComments.Text = NullToString(adoRow!COMMENTS)
            cboLoanStatus.SelectedIndex = IIf(adoRow!LOAN_STATUS = "Y", 0, 1)
            lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy, hh:mm:ss tt")
            If adoRow!ACTIVE_STATUS <> "A" Then
                GroupBox1.Enabled = False
                btnSave.Enabled = False
            End If
        End If
    End Sub

    Public Sub Initialization(ByVal dsDepartment As DataSet)
        Dim svcMembership As New Membership.svcMembership()
        Dim adorow As DataRow
        Dim I As Integer

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            dsParameters = svcMembership.GetMemberSystemInfo(APP_ID)
            adorow = dsParameters.Tables("MEMBERINFO").Rows(0)

            lblMemberNo.Text = "None"
            dtpDate.Value = Now
            cboActiveStatus.SelectedIndex = 0
            cboActiveStatus.Enabled = False
            lblEntryDate.Text = Format(Now, "dd MMM yyyy, hh:mm:ss tt")
            cboMemberStatus.SelectedIndex = 0
            dtpSince.Value = Now
            cboMemberType.SelectedIndex = 0
            If cboMemberType.SelectedIndex = 0 Then
                lblPokok.Text = adorow!POKOK_NT
                lblWajib.Text = adorow!WAJIB_NT
            Else
                lblPokok.Text = adorow!POKOK_EX
                lblWajib.Text = adorow!WAJIB_EX
            End If
            cboStaffType.SelectedIndex = 0
            If cboStaffType.SelectedIndex = 0 Then
                lblInterest.Text = adorow!INTEREST_SS
            Else
                lblInterest.Text = adorow!INTEREST_NS
            End If
            txtSukarela.Value = 0
            lblTotal.Text = Format(CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value, "##,##0")
            txtFirstName.Text = ""
            txtFamilyName.Text = ""
            txtBadgeId.Text = ""
            cboDepartment.Items.Clear()
            I = 0
            ReDim arrDepartment(dsDepartment.Tables("ResourceCode").Rows.Count)
            For Each adorow In dsDepartment.Tables("ResourceCode").Rows
                cboDepartment.Items.Add(adorow!RESOURCE_DESC)
                arrDepartment(I) = adorow!RESOURCE_CODE
                I = I + 1
            Next
            If cboDepartment.Items.Count > 0 Then
                cboDepartment.SelectedIndex = 0
            End If
            txtHomeAddr.Text = ""
            txtCity.Text = ""
            txtProvince.Text = ""
            txtPostalCode.Text = ""
            txtHomeAddr.Text = ""
            txtOfficePhone.Text = ""
            txtHomePhone.Text = ""
            txtEmail.Text = ""
            txtCellPhone.Text = ""
            txtComments.Text = ""
            cboLoanStatus.SelectedIndex = 1
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

        adoColumn = New DataColumn("ACTIVE_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("DEDUCTION_PERIOD")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("FIRST_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("FAMILY_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("BADGE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("DEPARTMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("HOME_ADDRESS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("CITY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("PROVINCE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("POSTAL_CODE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("CAMP_ADDRESS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_PHONE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("HOME_PHONE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("EMAIL")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("CELL_PHONE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENTS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("LOAN_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("STAFF_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("SUKARELA")
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

        If ValidateEmptyField(txtFirstName) Then
            Exit Sub
        End If

        If ValidateEmptyField(txtBadgeId) Then
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
        lblTotal.Text = CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value
    End Sub

    Private Sub cboStaffType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStaffType.SelectedIndexChanged
        Dim adoRow As DataRow

        adoRow = dsParameters.Tables("MEMBERINFO").Rows(0)

        If cboStaffType.SelectedIndex = 0 Then
            lblInterest.Text = Format(adoRow!INTEREST_SS, "##,##0")
        Else
            lblInterest.Text = Format(adoRow!INTEREST_NS, "##,##0")
        End If
    End Sub

    Private Sub txtSukarela_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSukarela.ValueChanged
        lblTotal.Text = CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value
    End Sub

    Private Sub txtSukarela_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSukarela.Leave
        lblTotal.Text = CInt(lblPokok.Text) + CInt(lblWajib.Text) + txtSukarela.Value
    End Sub
End Class
