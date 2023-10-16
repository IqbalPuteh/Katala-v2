Public Class frmMembershipSystemSetup
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtWajibEX As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPokokEX As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtInterestNonStaff As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtInterestStaff As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPokokNT As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtWajibNT As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAdminFee As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipSystemSetup))
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWajibEX = New System.Windows.Forms.NumericUpDown
        Me.txtPokokEX = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWajibNT = New System.Windows.Forms.NumericUpDown
        Me.txtPokokNT = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtInterestNonStaff = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtInterestStaff = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAdminFee = New System.Windows.Forms.NumericUpDown
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtWajibEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPokokEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWajibNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPokokNT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtInterestNonStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInterestStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtAdminFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(392, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(480, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWajibEX)
        Me.GroupBox1.Controls.Add(Me.txtPokokEX)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtWajibNT)
        Me.GroupBox1.Controls.Add(Me.txtPokokNT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership Type"
        '
        'txtWajibEX
        '
        Me.txtWajibEX.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtWajibEX.Location = New System.Drawing.Point(224, 88)
        Me.txtWajibEX.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtWajibEX.Name = "txtWajibEX"
        Me.txtWajibEX.Size = New System.Drawing.Size(104, 21)
        Me.txtWajibEX.TabIndex = 4
        Me.txtWajibEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPokokEX
        '
        Me.txtPokokEX.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPokokEX.Location = New System.Drawing.Point(96, 88)
        Me.txtPokokEX.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtPokokEX.Name = "txtPokokEX"
        Me.txtPokokEX.Size = New System.Drawing.Size(104, 21)
        Me.txtPokokEX.TabIndex = 3
        Me.txtPokokEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Expatriate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(288, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Wajib"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(160, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pokok"
        '
        'txtWajibNT
        '
        Me.txtWajibNT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtWajibNT.Location = New System.Drawing.Point(224, 56)
        Me.txtWajibNT.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtWajibNT.Name = "txtWajibNT"
        Me.txtWajibNT.Size = New System.Drawing.Size(104, 21)
        Me.txtWajibNT.TabIndex = 2
        Me.txtWajibNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPokokNT
        '
        Me.txtPokokNT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPokokNT.Location = New System.Drawing.Point(96, 56)
        Me.txtPokokNT.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtPokokNT.Name = "txtPokokNT"
        Me.txtPokokNT.Size = New System.Drawing.Size(104, 21)
        Me.txtPokokNT.TabIndex = 1
        Me.txtPokokNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "National Staff:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtInterestNonStaff)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtInterestStaff)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff Type"
        '
        'txtInterestNonStaff
        '
        Me.txtInterestNonStaff.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtInterestNonStaff.DecimalPlaces = 2
        Me.txtInterestNonStaff.Location = New System.Drawing.Point(96, 88)
        Me.txtInterestNonStaff.Name = "txtInterestNonStaff"
        Me.txtInterestNonStaff.Size = New System.Drawing.Size(104, 21)
        Me.txtInterestNonStaff.TabIndex = 6
        Me.txtInterestNonStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Non Staff:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(120, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Interest (%)"
        '
        'txtInterestStaff
        '
        Me.txtInterestStaff.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtInterestStaff.DecimalPlaces = 2
        Me.txtInterestStaff.Location = New System.Drawing.Point(96, 56)
        Me.txtInterestStaff.Name = "txtInterestStaff"
        Me.txtInterestStaff.Size = New System.Drawing.Size(104, 21)
        Me.txtInterestStaff.TabIndex = 5
        Me.txtInterestStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(56, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Staff:"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(80, 376)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(83, 17)
        Me.lblLastUpdate.TabIndex = 13
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Last Update:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAdminFee)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 264)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 96)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Admininistration"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(88, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Administration Fee"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(70, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "All:"
        '
        'txtAdminFee
        '
        Me.txtAdminFee.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAdminFee.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtAdminFee.Location = New System.Drawing.Point(96, 56)
        Me.txtAdminFee.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtAdminFee.Name = "txtAdminFee"
        Me.txtAdminFee.Size = New System.Drawing.Size(104, 21)
        Me.txtAdminFee.TabIndex = 7
        Me.txtAdminFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmMembershipSystemSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(570, 400)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipSystemSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership - System Setup"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtWajibEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPokokEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWajibNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPokokNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtInterestNonStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInterestStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txtAdminFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Function CreateRS() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn
        Dim adoTable As DataTable

        adoTable = New DataTable("MEMBERINFO")
        adoDS.Tables.Add(adoTable)

        adoColumn = New DataColumn("POKOK_NT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("WAJIB_NT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("POKOK_EX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("WAJIB_EX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("INTEREST_NS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("INTEREST_SS")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("ADMIN_FEE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        CreateRS = adoDS
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        adoDataTable = adoDS.Tables("MEMBERINFO")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("POKOK_NT") = txtPokokNT.Value
        adoDataRow("WAJIB_NT") = txtPokokEX.Value
        adoDataRow("POKOK_EX") = txtWajibNT.Value
        adoDataRow("WAJIB_EX") = txtWajibEX.Value
        adoDataRow("INTEREST_NS") = txtInterestStaff.Value
        adoDataRow("INTEREST_SS") = txtInterestNonStaff.Value
        adoDataRow("ADMIN_FEE") = txtAdminFee.Value
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As New DataSet()
        Dim strResult As String

        Try
            If MsgBox("Are you sure want to save new parameters?", MsgBoxStyle.YesNo, APP_NAME) = MsgBoxResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = CreateRS()
                FillDataSet(adoDS)
                strResult = svcMembership.UpdateMembershipSystemParameters(adoDS, APP_ID)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Data has been saved successfully.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub

    Private Sub frmMembershipSystemSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As New DataSet()
        Dim adoRow As DataRow

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcMembership.GetMemberSystemInfo(APP_ID)
            If adoDS.Tables("MEMBERINFO").Rows.Count <> 0 Then
                adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
                txtPokokNT.Text = adoRow!POKOK_NT
                txtWajibNT.Text = adoRow!WAJIB_NT
                txtPokokEX.Text = adoRow!POKOK_EX
                txtWajibEX.Text = adoRow!WAJIB_EX
                txtInterestStaff.Text = adoRow!INTEREST_SS
                txtInterestNonStaff.Text = adoRow!INTEREST_NS
                txtAdminFee.Text = adoRow!ADMIN_FEE
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(adoRow!REVIEWED_DATE, "dd MMM yyyy, hh:mm:ss tt")
            Else
                lblLastUpdate.Text = adoRow!REVIEWED_BY & ", " & Format(Now, "dd MMM yyyy, hh:mm:ss tt")
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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
