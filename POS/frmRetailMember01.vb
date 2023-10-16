Public Class frmRetailMember01
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboMemberStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtMembershipNo As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents optKatala As System.Windows.Forms.RadioButton
    Friend WithEvents optNonKatala As System.Windows.Forms.RadioButton
    Friend WithEvents txtMemberAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents grpDetail As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRetailMember01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grpDetail = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMemberAddress = New System.Windows.Forms.TextBox
        Me.optNonKatala = New System.Windows.Forms.RadioButton
        Me.optKatala = New System.Windows.Forms.RadioButton
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.cboMemberStatus = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.txtMembershipNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(71, 397)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 39
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(7, 397)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 38
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grpDetail
        '
        Me.grpDetail.Controls.Add(Me.Label8)
        Me.grpDetail.Controls.Add(Me.txtMemberAddress)
        Me.grpDetail.Controls.Add(Me.optNonKatala)
        Me.grpDetail.Controls.Add(Me.optKatala)
        Me.grpDetail.Controls.Add(Me.txtMemberName)
        Me.grpDetail.Controls.Add(Me.Label6)
        Me.grpDetail.Controls.Add(Me.txtStatus)
        Me.grpDetail.Controls.Add(Me.lblStatus)
        Me.grpDetail.Controls.Add(Me.cboMemberStatus)
        Me.grpDetail.Controls.Add(Me.Label7)
        Me.grpDetail.Controls.Add(Me.txtMemberId)
        Me.grpDetail.Controls.Add(Me.Label1)
        Me.grpDetail.Controls.Add(Me.Label9)
        Me.grpDetail.Controls.Add(Me.txtComments)
        Me.grpDetail.Controls.Add(Me.txtMembershipNo)
        Me.grpDetail.Controls.Add(Me.Label2)
        Me.grpDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetail.ForeColor = System.Drawing.Color.Blue
        Me.grpDetail.Location = New System.Drawing.Point(2, 3)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(640, 384)
        Me.grpDetail.TabIndex = 37
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Retail Member - Detail Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(80, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Address:"
        '
        'txtMemberAddress
        '
        Me.txtMemberAddress.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMemberAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberAddress.Location = New System.Drawing.Point(136, 121)
        Me.txtMemberAddress.MaxLength = 20
        Me.txtMemberAddress.Multiline = True
        Me.txtMemberAddress.Name = "txtMemberAddress"
        Me.txtMemberAddress.Size = New System.Drawing.Size(336, 56)
        Me.txtMemberAddress.TabIndex = 6
        Me.txtMemberAddress.Text = ""
        '
        'optNonKatala
        '
        Me.optNonKatala.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNonKatala.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.optNonKatala.Location = New System.Drawing.Point(353, 51)
        Me.optNonKatala.Name = "optNonKatala"
        Me.optNonKatala.Size = New System.Drawing.Size(127, 16)
        Me.optNonKatala.TabIndex = 2
        Me.optNonKatala.Text = "Non Katala Member"
        '
        'optKatala
        '
        Me.optKatala.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optKatala.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.optKatala.Location = New System.Drawing.Point(136, 51)
        Me.optKatala.Name = "optKatala"
        Me.optKatala.Size = New System.Drawing.Size(104, 16)
        Me.optKatala.TabIndex = 1
        Me.optKatala.Text = "Katala Member"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberName.Location = New System.Drawing.Point(136, 97)
        Me.txtMemberName.MaxLength = 20
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(336, 21)
        Me.txtMemberName.TabIndex = 5
        Me.txtMemberName.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(49, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Member Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(352, 72)
        Me.txtStatus.MaxLength = 20
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(120, 21)
        Me.txtStatus.TabIndex = 4
        Me.txtStatus.Text = ""
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(304, 74)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 17)
        Me.lblStatus.TabIndex = 81
        Me.lblStatus.Text = "Status :"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMemberStatus
        '
        Me.cboMemberStatus.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboMemberStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberStatus.Location = New System.Drawing.Point(136, 180)
        Me.cboMemberStatus.Name = "cboMemberStatus"
        Me.cboMemberStatus.Size = New System.Drawing.Size(120, 21)
        Me.cboMemberStatus.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(46, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Member Status:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Enabled = False
        Me.txtMemberId.Location = New System.Drawing.Point(136, 24)
        Me.txtMemberId.MaxLength = 20
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(120, 21)
        Me.txtMemberId.TabIndex = 69
        Me.txtMemberId.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Retail Member Id.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(69, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Comments:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtComments.Location = New System.Drawing.Point(136, 204)
        Me.txtComments.MaxLength = 500
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(496, 80)
        Me.txtComments.TabIndex = 8
        Me.txtComments.Text = ""
        '
        'txtMembershipNo
        '
        Me.txtMembershipNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMembershipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMembershipNo.Location = New System.Drawing.Point(136, 72)
        Me.txtMembershipNo.MaxLength = 20
        Me.txtMembershipNo.Name = "txtMembershipNo"
        Me.txtMembershipNo.Size = New System.Drawing.Size(120, 21)
        Me.txtMembershipNo.TabIndex = 3
        Me.txtMembershipNo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Katala Membership No:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(473, 392)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(561, 392)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        '
        'frmRetailMember01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(644, 421)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetailMember01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Member - Edit Screen"
        Me.grpDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean
    Dim blnAddnew As Boolean
    Dim lngStatus As Long

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow

        Try
            If blnAddnew = False Then
                If adoDS.Tables("MEMBERDATA").Rows.Count > 0 Then
                    adoRow = adoDS.Tables("MEMBERDATA").Rows(0)
                    txtMemberId.Text = adoRow!MEMBER_ID
                    If Trim(adoRow!MEMBERSHIP_NO) <> "" Then
                        optKatala.Checked = True
                        txtMembershipNo.Text = adoRow!MEMBERSHIP_NO
                        Call txtMembershipNo_KeyDown(Keys.Return, New System.Windows.Forms.KeyEventArgs(Keys.Return))
                    Else
                        optNonKatala.Checked = True
                        txtMemberName.Text = adoRow!MEMBER_NAME
                        txtMemberAddress.Text = adoRow!ADDRESS
                    End If
                    If adoRow!STATUS = "A" Then
                        lngStatus = 0
                    Else
                        lngStatus = 1
                    End If
                    txtComments.Text = adoRow!COMMENTS

                    lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy")
                End If
            End If

        Catch ex As Exception
            grpDetail.Enabled = False
            btnSave.Enabled = False
            Throw ex
        End Try
    End Sub

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet

        Try
            myDS = CreateMemberRs()
            FillDataSet(myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable

        adoDataTable = adoDS.Tables("MEMBER_DATA")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("MEMBER_ID") = txtMemberId.Text
        adoDataRow("MEMBERSHIP_NO") = txtMembershipNo.Text
        adoDataRow("MEMBER_NAME") = txtMemberName.Text
        adoDataRow("ADDRESS") = txtMemberAddress.Text
        adoDataRow("STATUS") = IIf(cboMemberStatus.Text = "Active", "A", "N")
        adoDataRow("COMMENTS") = txtComments.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddnew = blnAdd
    End Sub

    Private Sub frmRetailMember01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcRetail As New Retail.svcRetail
        Dim intMemberId As Integer

        Try
            blnCancel = True
            cboMemberStatus.Items.Add("Active")
            cboMemberStatus.Items.Add("Not Active")
            cboMemberStatus.SelectedIndex = 0

            'optKatala.Focus()
            If blnAddnew Then
                intMemberId = svcRetail.GetMaxRetId(APP_ID)
                txtMemberId.Text = intMemberId
                optKatala.Checked = True
                lblTitleLast.Visible = False
                lblLastUpdate.Visible = False
            Else
                cboMemberStatus.SelectedIndex = lngStatus

                lblTitleLast.Visible = True
                lblLastUpdate.Visible = True
            End If

        Catch ex As Exception
            grpDetail.Enabled = False
            btnSave.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Function CreateMemberRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("MEMBER_DATA")

        adoColumn = New DataColumn("MEMBER_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBER_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ADDRESS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("STATUS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("COMMENTS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("MEMBER_DATA").Columns.Add(adoColumn)

        CreateMemberRs = adoDS
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If optKatala.Checked Then
            If ValidateEmptyField(txtMembershipNo) Then
                Exit Sub
            End If
        Else
            If ValidateEmptyField(txtMemberName) Then
                Exit Sub
            End If
            If ValidateEmptyField(txtMemberAddress) Then
                Exit Sub
            End If
        End If
        If ValidateEmptyField(cboMemberStatus) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub frmRetailMember01_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub txtMembershipNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembershipNo.TextChanged
        txtStatus.Text = ""
        txtMemberName.Text = ""
        txtMemberAddress.Text = ""
    End Sub

    Private Sub optKatala_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optKatala.CheckedChanged
        If optKatala.Checked Then
            txtMembershipNo.BackColor = txtComments.BackColor
            txtMemberName.BackColor = System.Drawing.Color.LightGray
            txtMemberAddress.BackColor = System.Drawing.Color.LightGray
            txtMembershipNo.Enabled = True
            txtMemberName.Enabled = False
            txtMemberAddress.Enabled = False

            txtMembershipNo.Text = ""
            txtStatus.Text = ""
            txtMemberName.Text = ""
            txtMemberAddress.Text = ""
        Else
            txtMembershipNo.BackColor = System.Drawing.Color.LightGray
            txtMemberName.BackColor = txtComments.BackColor
            txtMemberAddress.BackColor = txtComments.BackColor
            txtMembershipNo.Enabled = False
            txtMemberName.Enabled = True
            txtMemberAddress.Enabled = True

            txtMembershipNo.Text = ""
            txtStatus.Text = ""
            txtMemberName.Text = ""
            txtMemberAddress.Text = ""
        End If
    End Sub

    Private Sub optNonKatala_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNonKatala.CheckedChanged
        If optKatala.Checked Then
            txtMembershipNo.BackColor = txtComments.BackColor
            txtMemberName.BackColor = System.Drawing.Color.LightGray
            txtMemberAddress.BackColor = System.Drawing.Color.LightGray
            txtMembershipNo.Enabled = True
            txtMemberName.Enabled = False
            txtMemberAddress.Enabled = False

            txtMembershipNo.Text = ""
            txtStatus.Text = ""
            txtMemberName.Text = ""
            txtMemberAddress.Text = ""
        Else
            txtMembershipNo.BackColor = System.Drawing.Color.LightGray
            txtMemberName.BackColor = txtComments.BackColor
            txtMemberAddress.BackColor = txtComments.BackColor
            txtMembershipNo.Enabled = False
            txtMemberName.Enabled = True
            txtMemberAddress.Enabled = True

            txtMembershipNo.Text = ""
            txtStatus.Text = ""
            txtMemberName.Text = ""
            txtMemberAddress.Text = ""
        End If
    End Sub

    Private Sub txtMembershipNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMembershipNo.KeyDown
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As New DataSet
        Dim adorow As DataRow

        Try
            If e.KeyCode = Keys.Return Then
                If Trim(txtMembershipNo.Text) = "" Then
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcMembership.GetMemberInfo(txtMembershipNo.Text, "", APP_ID)
                If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                    txtStatus.Text = ""
                    txtMemberName.Text = ""
                    txtMemberAddress.Text = ""
                    MessageBox.Show("The Katala Membership No. is not correct.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtMembershipNo.Focus()
                Else
                    adorow = adoDS.Tables("MEMBERINFO").Rows(0)
                    txtMemberName.Text = Trim(adorow!FIRST_NAME & " " & adorow!FAMILY_NAME)
                    txtStatus.Text = IIf(adorow!ACTIVE_STATUS = "A", "Active", "Not Active")
                    txtMemberAddress.Text = NullToString(adorow!HOME_ADDRESS) & " " & NullToString(adorow!CAMP_ADDRESS) & " " & NullToString(adorow!HOME_PHONE) & " " & NullToString(adorow!CELL_PHONE)
                    cboMemberStatus.Focus()
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
