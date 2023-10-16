Public Class frmSupplier01
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
    Friend WithEvents cboActiveStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPostAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMobilePhone02 As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficePhone01 As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficeFax01 As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficePhone02 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeFax02 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMobilePhone01 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grbSupplier As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSupplier01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grbSupplier = New System.Windows.Forms.GroupBox
        Me.txtMobilePhone01 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOfficeFax02 = New System.Windows.Forms.TextBox
        Me.txtOfficePhone02 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtOfficeAddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMobilePhone02 = New System.Windows.Forms.TextBox
        Me.txtOfficePhone01 = New System.Windows.Forms.TextBox
        Me.txtPostAddress = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtOfficeFax01 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboActiveStatus = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSupplierCode = New System.Windows.Forms.TextBox
        Me.txtSupplierName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grbSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(69, 401)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 29
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(5, 401)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 28
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grbSupplier
        '
        Me.grbSupplier.Controls.Add(Me.txtMobilePhone01)
        Me.grbSupplier.Controls.Add(Me.Label4)
        Me.grbSupplier.Controls.Add(Me.Label5)
        Me.grbSupplier.Controls.Add(Me.txtOfficeFax02)
        Me.grbSupplier.Controls.Add(Me.txtOfficePhone02)
        Me.grbSupplier.Controls.Add(Me.Label9)
        Me.grbSupplier.Controls.Add(Me.txtComment)
        Me.grbSupplier.Controls.Add(Me.txtContact)
        Me.grbSupplier.Controls.Add(Me.Label8)
        Me.grbSupplier.Controls.Add(Me.txtOfficeAddress)
        Me.grbSupplier.Controls.Add(Me.Label1)
        Me.grbSupplier.Controls.Add(Me.txtMobilePhone02)
        Me.grbSupplier.Controls.Add(Me.txtOfficePhone01)
        Me.grbSupplier.Controls.Add(Me.txtPostAddress)
        Me.grbSupplier.Controls.Add(Me.Label15)
        Me.grbSupplier.Controls.Add(Me.txtOfficeFax01)
        Me.grbSupplier.Controls.Add(Me.Label12)
        Me.grbSupplier.Controls.Add(Me.Label10)
        Me.grbSupplier.Controls.Add(Me.cboActiveStatus)
        Me.grbSupplier.Controls.Add(Me.Label6)
        Me.grbSupplier.Controls.Add(Me.txtSupplierCode)
        Me.grbSupplier.Controls.Add(Me.txtSupplierName)
        Me.grbSupplier.Controls.Add(Me.Label3)
        Me.grbSupplier.Controls.Add(Me.Label2)
        Me.grbSupplier.Controls.Add(Me.Label11)
        Me.grbSupplier.Controls.Add(Me.Label13)
        Me.grbSupplier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbSupplier.ForeColor = System.Drawing.Color.Blue
        Me.grbSupplier.Location = New System.Drawing.Point(0, 5)
        Me.grbSupplier.Name = "grbSupplier"
        Me.grbSupplier.Size = New System.Drawing.Size(640, 387)
        Me.grbSupplier.TabIndex = 25
        Me.grbSupplier.TabStop = False
        Me.grbSupplier.Text = "Supplier Detail Information"
        '
        'txtMobilePhone01
        '
        Me.txtMobilePhone01.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMobilePhone01.Location = New System.Drawing.Point(84, 236)
        Me.txtMobilePhone01.MaxLength = 50
        Me.txtMobilePhone01.Name = "txtMobilePhone01"
        Me.txtMobilePhone01.Size = New System.Drawing.Size(240, 21)
        Me.txtMobilePhone01.TabIndex = 10
        Me.txtMobilePhone01.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Mob. Phone 1:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(342, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Off. Fax 2:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOfficeFax02
        '
        Me.txtOfficeFax02.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtOfficeFax02.Location = New System.Drawing.Point(400, 213)
        Me.txtOfficeFax02.MaxLength = 50
        Me.txtOfficeFax02.Name = "txtOfficeFax02"
        Me.txtOfficeFax02.Size = New System.Drawing.Size(232, 21)
        Me.txtOfficeFax02.TabIndex = 9
        Me.txtOfficeFax02.Text = ""
        '
        'txtOfficePhone02
        '
        Me.txtOfficePhone02.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtOfficePhone02.Location = New System.Drawing.Point(400, 189)
        Me.txtOfficePhone02.MaxLength = 50
        Me.txtOfficePhone02.Name = "txtOfficePhone02"
        Me.txtOfficePhone02.Size = New System.Drawing.Size(232, 21)
        Me.txtOfficePhone02.TabIndex = 7
        Me.txtOfficePhone02.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(26, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Comment:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComment
        '
        Me.txtComment.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComment.Location = New System.Drawing.Point(84, 283)
        Me.txtComment.MaxLength = 500
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(548, 80)
        Me.txtComment.TabIndex = 13
        Me.txtComment.Text = ""
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtContact.Location = New System.Drawing.Point(84, 259)
        Me.txtContact.MaxLength = 50
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(240, 21)
        Me.txtContact.TabIndex = 12
        Me.txtContact.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Cntct Person:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOfficeAddress
        '
        Me.txtOfficeAddress.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtOfficeAddress.Location = New System.Drawing.Point(84, 95)
        Me.txtOfficeAddress.MaxLength = 500
        Me.txtOfficeAddress.Multiline = True
        Me.txtOfficeAddress.Name = "txtOfficeAddress"
        Me.txtOfficeAddress.Size = New System.Drawing.Size(240, 91)
        Me.txtOfficeAddress.TabIndex = 4
        Me.txtOfficeAddress.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Off. Fax 1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobilePhone02
        '
        Me.txtMobilePhone02.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMobilePhone02.Location = New System.Drawing.Point(400, 236)
        Me.txtMobilePhone02.MaxLength = 50
        Me.txtMobilePhone02.Name = "txtMobilePhone02"
        Me.txtMobilePhone02.Size = New System.Drawing.Size(232, 21)
        Me.txtMobilePhone02.TabIndex = 11
        Me.txtMobilePhone02.Text = ""
        '
        'txtOfficePhone01
        '
        Me.txtOfficePhone01.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtOfficePhone01.Location = New System.Drawing.Point(84, 189)
        Me.txtOfficePhone01.MaxLength = 50
        Me.txtOfficePhone01.Name = "txtOfficePhone01"
        Me.txtOfficePhone01.Size = New System.Drawing.Size(240, 21)
        Me.txtOfficePhone01.TabIndex = 6
        Me.txtOfficePhone01.Text = ""
        '
        'txtPostAddress
        '
        Me.txtPostAddress.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPostAddress.Location = New System.Drawing.Point(400, 96)
        Me.txtPostAddress.MaxLength = 500
        Me.txtPostAddress.Multiline = True
        Me.txtPostAddress.Name = "txtPostAddress"
        Me.txtPostAddress.Size = New System.Drawing.Size(232, 90)
        Me.txtPostAddress.TabIndex = 5
        Me.txtPostAddress.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(322, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 17)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Mob. Phone 2:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOfficeFax01
        '
        Me.txtOfficeFax01.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtOfficeFax01.Location = New System.Drawing.Point(84, 213)
        Me.txtOfficeFax01.MaxLength = 50
        Me.txtOfficeFax01.Name = "txtOfficeFax01"
        Me.txtOfficeFax01.Size = New System.Drawing.Size(240, 21)
        Me.txtOfficeFax01.TabIndex = 8
        Me.txtOfficeFax01.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(11, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Off. Address:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(326, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Post Address:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboActiveStatus
        '
        Me.cboActiveStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActiveStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.cboActiveStatus.Location = New System.Drawing.Point(84, 71)
        Me.cboActiveStatus.Name = "cboActiveStatus"
        Me.cboActiveStatus.Size = New System.Drawing.Size(112, 21)
        Me.cboActiveStatus.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Active Status:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupplierCode
        '
        Me.txtSupplierCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSupplierCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplierCode.Location = New System.Drawing.Point(84, 23)
        Me.txtSupplierCode.MaxLength = 20
        Me.txtSupplierCode.Name = "txtSupplierCode"
        Me.txtSupplierCode.Size = New System.Drawing.Size(112, 21)
        Me.txtSupplierCode.TabIndex = 1
        Me.txtSupplierCode.Text = ""
        '
        'txtSupplierName
        '
        Me.txtSupplierName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSupplierName.Location = New System.Drawing.Point(84, 47)
        Me.txtSupplierName.MaxLength = 200
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(548, 21)
        Me.txtSupplierName.TabIndex = 2
        Me.txtSupplierName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(2, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Supplier Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Supplier No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Off. Phone 1:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(329, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Off. Phone 2:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(469, 395)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(557, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        '
        'frmSupplier01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(640, 423)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grbSupplier)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplier01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Detail - Edit Screen"
        Me.grbSupplier.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean
    Dim intAccessValue As Integer

    Private Sub frmSupplier01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity

        Try
            blnCancel = True

            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "WAREHOUSE", APP_ID)

            If blnAddNew Then
                txtSupplierCode.Enabled = True

                lblTitleLast.Visible = False
                lblLastUpdate.Text = ""
            Else
                txtSupplierCode.Enabled = False
                lblTitleLast.Visible = True

                If cboActiveStatus.SelectedIndex = 1 And intAccessValue < 9 Then
                    grbSupplier.Enabled = False
                    btnSave.Enabled = False
                End If
            End If

        Catch ex As Exception
            grbSupplier.Enabled = False
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

        adoDataTable = adoDS.Tables("SUPPLIERINFO")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("SUPPLIER_NO") = txtSupplierCode.Text
        adoDataRow("SUPPLIER_NAME") = txtSupplierName.Text
        If cboActiveStatus.SelectedIndex = 0 Then
            adoDataRow("ACTIVE_STATUS") = "Y"
        Else
            adoDataRow("ACTIVE_STATUS") = "N"
        End If
        adoDataRow("OFFICE_ADDRESS") = txtOfficeAddress.Text
        adoDataRow("POST_ADDRESS") = txtPostAddress.Text
        adoDataRow("OFFICE_PHONE01") = txtOfficePhone01.Text
        adoDataRow("OFFICE_PHONE02") = txtOfficePhone02.Text
        adoDataRow("OFFICE_FAX01") = txtOfficeFax01.Text
        adoDataRow("OFFICE_FAX02") = txtOfficeFax02.Text
        adoDataRow("MOBILE_PHONE01") = txtMobilePhone01.Text
        adoDataRow("MOBILE_PHONE02") = txtMobilePhone02.Text
        adoDataRow("CONTACT_PERSON") = txtContact.Text
        adoDataRow("COMMENT") = txtComment.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

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
            If adoDS.Tables("SUPPLIERINFO").Rows.Count > 0 Then
                adoRow = adoDS.Tables("SUPPLIERINFO").Rows(0)
                txtSupplierCode.Text = adoRow!SUPPLIER_NO
                txtSupplierName.Text = adoRow!SUPPLIER_NAME
                If adoRow!ACTIVE_STATUS = "Y" Then
                    cboActiveStatus.SelectedIndex = 0
                Else
                    cboActiveStatus.SelectedIndex = 1
                End If
                txtOfficeAddress.Text = adoRow!OFFICE_ADDRESS
                txtPostAddress.Text = adoRow!POST_ADDRESS
                txtOfficePhone01.Text = adoRow!OFFICE_PHONE01
                txtOfficePhone02.Text = adoRow!OFFICE_PHONE02
                txtOfficeFax01.Text = adoRow!OFFICE_FAX01
                txtOfficeFax02.Text = adoRow!OFFICE_FAX02
                txtMobilePhone01.Text = adoRow!MOBILE_PHONE01
                txtMobilePhone02.Text = adoRow!MOBILE_PHONE02
                txtContact.Text = adoRow!CONTACT_PERSON
                txtComment.Text = adoRow!COMMENT
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
            End If

        Catch ex As Exception
            grbSupplier.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtSupplierCode) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtSupplierName) Then
            Exit Sub
        End If
        If ValidateEmptyField(cboActiveStatus) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtOfficeAddress) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtPostAddress) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("SUPPLIERINFO")

        adoColumn = New DataColumn("SUPPLIER_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("SUPPLIER_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ACTIVE_STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_ADDRESS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POST_ADDRESS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_PHONE01")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_PHONE02")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_FAX01")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OFFICE_FAX02")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOBILE_PHONE01")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MOBILE_PHONE02")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("CONTACT_PERSON")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("SUPPLIERINFO").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function
End Class
