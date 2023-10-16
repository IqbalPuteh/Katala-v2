Public Class frmMembershipTransaction
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
    Friend WithEvents lblAccPeriod As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMembershipNo As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents dtpAccPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPokok As System.Windows.Forms.Label
    Friend WithEvents lblWajib As System.Windows.Forms.Label
    Friend WithEvents lblSukarela As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblLoanStatus As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCurYearInterest As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipTransaction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblLoanStatus = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtpAccPeriod = New System.Windows.Forms.DateTimePicker
        Me.lblName = New System.Windows.Forms.Label
        Me.lblMembershipNo = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.lblAccPeriod = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblCurYearInterest = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblSukarela = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblWajib = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPokok = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnPreview = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLoanStatus)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.dtpAccPeriod)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblMembershipNo)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.lblAccPeriod)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'lblLoanStatus
        '
        Me.lblLoanStatus.AutoSize = True
        Me.lblLoanStatus.ForeColor = System.Drawing.Color.Black
        Me.lblLoanStatus.Location = New System.Drawing.Point(128, 104)
        Me.lblLoanStatus.Name = "lblLoanStatus"
        Me.lblLoanStatus.Size = New System.Drawing.Size(82, 17)
        Me.lblLoanStatus.TabIndex = 63
        Me.lblLoanStatus.Text = "lblLoanStatus"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(55, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Loan Status:"
        '
        'dtpAccPeriod
        '
        Me.dtpAccPeriod.CustomFormat = "yyyy-MM"
        Me.dtpAccPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccPeriod.Location = New System.Drawing.Point(128, 48)
        Me.dtpAccPeriod.Name = "dtpAccPeriod"
        Me.dtpAccPeriod.ShowUpDown = True
        Me.dtpAccPeriod.Size = New System.Drawing.Size(80, 21)
        Me.dtpAccPeriod.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(248, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "lblName"
        '
        'lblMembershipNo
        '
        Me.lblMembershipNo.AutoSize = True
        Me.lblMembershipNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipNo.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipNo.Location = New System.Drawing.Point(31, 80)
        Me.lblMembershipNo.Name = "lblMembershipNo"
        Me.lblMembershipNo.Size = New System.Drawing.Size(90, 17)
        Me.lblMembershipNo.TabIndex = 4
        Me.lblMembershipNo.Text = "Membership No.:"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(128, 72)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(104, 21)
        Me.txtMemberId.TabIndex = 2
        Me.txtMemberId.Text = ""
        '
        'lblAccPeriod
        '
        Me.lblAccPeriod.AutoSize = True
        Me.lblAccPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccPeriod.ForeColor = System.Drawing.Color.Black
        Me.lblAccPeriod.Location = New System.Drawing.Point(19, 56)
        Me.lblAccPeriod.Name = "lblAccPeriod"
        Me.lblAccPeriod.Size = New System.Drawing.Size(102, 17)
        Me.lblAccPeriod.TabIndex = 2
        Me.lblAccPeriod.Text = "Accounting Period :"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(536, 76)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the options below and click on select button !"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(592, 443)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(416, 443)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(504, 443)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 312)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCurYearInterest)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblSukarela)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblWajib)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblPokok)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(668, 101)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Summary"
        '
        'lblCurYearInterest
        '
        Me.lblCurYearInterest.AutoSize = True
        Me.lblCurYearInterest.ForeColor = System.Drawing.Color.Black
        Me.lblCurYearInterest.Location = New System.Drawing.Point(560, 32)
        Me.lblCurYearInterest.Name = "lblCurYearInterest"
        Me.lblCurYearInterest.Size = New System.Drawing.Size(54, 17)
        Me.lblCurYearInterest.TabIndex = 15
        Me.lblCurYearInterest.Text = "lblBunga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(464, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Bunga Tahunan:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(432, 72)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 17)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "lblTotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(392, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total:"
        '
        'lblSukarela
        '
        Me.lblSukarela.AutoSize = True
        Me.lblSukarela.ForeColor = System.Drawing.Color.Black
        Me.lblSukarela.Location = New System.Drawing.Point(224, 72)
        Me.lblSukarela.Name = "lblSukarela"
        Me.lblSukarela.Size = New System.Drawing.Size(68, 17)
        Me.lblSukarela.TabIndex = 11
        Me.lblSukarela.Text = "lblSukarela"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(160, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Sukarela:"
        '
        'lblWajib
        '
        Me.lblWajib.AutoSize = True
        Me.lblWajib.ForeColor = System.Drawing.Color.Black
        Me.lblWajib.Location = New System.Drawing.Point(344, 32)
        Me.lblWajib.Name = "lblWajib"
        Me.lblWajib.Size = New System.Drawing.Size(51, 17)
        Me.lblWajib.TabIndex = 9
        Me.lblWajib.Text = "lblWajib"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(304, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Wajib:"
        '
        'lblPokok
        '
        Me.lblPokok.AutoSize = True
        Me.lblPokok.ForeColor = System.Drawing.Color.Black
        Me.lblPokok.Location = New System.Drawing.Point(112, 32)
        Me.lblPokok.Name = "lblPokok"
        Me.lblPokok.Size = New System.Drawing.Size(53, 17)
        Me.lblPokok.TabIndex = 7
        Me.lblPokok.Text = "lblPokok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(72, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pokok:"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(668, 191)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Transaction Desc"
        Me.ColumnHeader5.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 110
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(8, 443)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(104, 24)
        Me.btnPreview.TabIndex = 19
        Me.btnPreview.Text = "&Print Receipt"
        '
        'frmMembershipTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 472)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMembershipTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Transactions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim strAcctPeriod As String
    Dim sngSavingAmount As Double
    Dim intPokok As Int64
    Dim intWajib As Int64
    Dim intSukarela As Int64
    Dim strActive As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet

        Try
            lblName.Text = ""
            lblPokok.Text = ""
            lblWajib.Text = ""
            lblCurYearInterest.Text = ""
            lblSukarela.Text = ""
            lblTotal.Text = ""
            lblLoanStatus.Text = ""
            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            strAcctPeriod = CStr(adoDS.Tables(0).Rows(0).Item(0))
            dtpAccPeriod.Value = DateSerial(strAcctPeriod.Substring(0, 4), strAcctPeriod.Substring(4, 2), 1)
            dtpAccPeriod.Enabled = False
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcMembership.Dispose()
            adoDS.Dispose()
        End Try
    End Sub

    Private Sub txtMemberNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        lblName.Text = ""
        lblLoanStatus.Text = ""
        btnModify.Enabled = False
        btnAddNew.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim recordcount As Int64
        Dim adoDSIntrest As DataSet
        Dim IntYearIntrest As Int64
        Dim strYear As String

        Try
            svcMembership.Timeout = -1
            lvwList.Items.Clear()
            If lblName.Text = "" Then Exit Sub
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcMembership.GetTransaction(txtMemberId.Text, Format(dtpAccPeriod.Value, "yyyyMM"), APP_ID)
            adoDSIntrest = svcMembership.GetMemberYearlyIntrestVal(txtMemberId.Text, Format(dtpAccPeriod.Value, "yyyy"), APP_ID)
            sngSavingAmount = svcMembership.GetTotalSaving(txtMemberId.Text, APP_ID)
            If adoDSIntrest.Tables(0).Rows.Count = 0 Then
                IntYearIntrest = 0
            Else
                Dim adoRowInt As DataRow
                adoRowInt = adoDSIntrest.Tables(0).Rows(0)
                IntYearIntrest = adoRowInt!AMOUNT
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If adoDS.Tables(0).Rows.Count = 0 Then
                adoDS = svcMembership.GetMemberTransactionSummary(txtMemberId.Text, APP_ID)
                intPokok = 0
                intWajib = 0
                intSukarela = 0
                For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                    Select Case CStr(adoRow!TRANSACTION_CODE)
                        Case "POKOK", "POKOKDB"
                            intPokok = intPokok + adoRow!AMOUNT
                        Case "WAJIB", "WAJIBDB", "305", "306"
                            intWajib = intWajib + adoRow!AMOUNT
                        Case "BUNGA"
                            intSukarela = intSukarela + adoRow!AMOUNT
                        Case "SUKARELA"
                            intSukarela = intSukarela + adoRow!AMOUNT
                        Case Else
                            intSukarela = intSukarela + adoRow!AMOUNT
                    End Select
                Next
                lblPokok.Text = Format(intPokok, "#,##0")
                lblWajib.Text = Format(intWajib, "#,##0")
                lblCurYearInterest.Text = Format(IntYearIntrest, "#,##0")
                lblSukarela.Text = Format(intSukarela - IntYearIntrest, "#,##0")
                lblTotal.Text = Format(intPokok + intWajib + intSukarela, "#,##0")

                MessageBox.Show("No record was selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnModify.Enabled = False
                btnAddNew.Enabled = True
                lvwList.Items.Clear()
            Else
                recordcount = 0
                lvwList.Items.Clear()
                For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                    Dim lvwItem As New ListViewItem
                    lvwList.Items.Add(lvwItem)
                    recordcount = recordcount + 1
                    lvwItem.Text = recordcount.ToString
                    lvwItem.SubItems.Add(Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy"))
                    lvwItem.SubItems.Add(NullToString(adoRow!RESOURCE_DESC))
                    lvwItem.SubItems.Add(IIf(adoRow!TRANSACTION_TYPE = "CR", "CREDIT", "DEBET"))
                    lvwItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
                    lvwItem.SubItems.Add(Format(adoRow!TOTAL, "#,##0"))
                Next

                adoDS = svcMembership.GetMemberTransactionSummary(txtMemberId.Text, APP_ID)
                intPokok = 0
                intWajib = 0
                intSukarela = 0
                For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                    Select Case CStr(adoRow!TRANSACTION_CODE)
                        Case "POKOK", "POKOKDB"
                            intPokok = intPokok + adoRow!AMOUNT
                        Case "WAJIB", "WAJIBDB", "305", "306"
                            intWajib = intWajib + adoRow!AMOUNT
                        Case "BUNGA"
                            intSukarela = intSukarela + adoRow!AMOUNT
                        Case "SUKARELA"
                            intSukarela = intSukarela + adoRow!AMOUNT
                        Case Else
                            intSukarela = intSukarela + adoRow!AMOUNT
                    End Select
                Next
                lblPokok.Text = Format(intPokok, "#,##0")
                lblWajib.Text = Format(intWajib, "#,##0")
                lblCurYearInterest.Text = Format(IntYearIntrest, "#,##0")
                lblSukarela.Text = Format(intSukarela - IntYearIntrest, "#,##0")
                lblTotal.Text = Format(intPokok + intWajib + intSukarela, "#,##0")

                If strActive <> "A" Then
                    btnAddNew.Enabled = False
                    btnModify.Enabled = False
                Else
                    btnModify.Enabled = True
                    btnAddNew.Enabled = True
                End If
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcMembership As New Membership.svcMembership
        Dim myForm As New frmMembershipTransaction01
        Dim adoDS As New DataSet
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim adoRow As DataRow
        Dim strPeriod As String
        Dim blnEnableTrans As Boolean

        Try
            '\\@ Check apakah upload tabungan  & loan deduction terhadap simpanan (sukarela) telah dilakukan ? \\
            '\\ Jika 'YA' maka lanjutkan transaksi \\
            '\\ Jika 'Tidak' maka stop penambahan transaksi \\
            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            strPeriod = adoDS.Tables("MEMBERINFO").Rows(0)!ACCT_PERIOD
            blnEnableTrans = svcMembership.GetLoanDeductionUploadStatus(strPeriod, APP_ID)
            If Not blnEnableTrans Then
                MessageBox.Show("Cannot add transaction, Closing process is in progress!", mdlConstants.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Exit Sub
            End If


            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialization(txtMemberId.Text, lblName.Text, dtpAccPeriod.Value)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            sngSavingAmount = svcMembership.GetTotalSaving(txtMemberId.Text, APP_ID)
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet(sngSavingAmount)

                adoRow = adoDS.Tables("TRANSACTION").Rows(0)
                If adoRow!TRANSACTION_TYPE = "DB" Then
                    Select Case adoRow!TRANSACTION_CODE
                        Case "BUNGA"
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case "SUKARELA"
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case "POKOKDB", "305"
                            If adoRow!AMOUNT > intPokok Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case "WAJIBDB", "306"
                            If adoRow!AMOUNT > intWajib Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case Else
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Debet transaction cannot be less then voluntary - sukarela saving amount .", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                    End Select
                End If

                strResult = svcMembership.AddNewTransaction(adoDS, APP_ID)
                If strResult = "" Then
                    adoRow = adoDS.Tables("TRANSACTION").Rows(0)
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    objItem.Tag = Format(adoRow!TRANSACTION_DATE, "dd/MM/yyyy")
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(NullToString(adoRow!RESOURCE_DESC))
                    objItem.SubItems.Add(IIf(adoRow!TRANSACTION_TYPE = "CR", "CREDIT", "DEBET"))
                    objItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
                    objItem.SubItems.Add(Format(adoRow!TOTAL, "#,##0"))
                    objItem.Selected = True
                    btnModify.Enabled = True

                    adoDS = svcMembership.GetMemberTransactionSummary(txtMemberId.Text, APP_ID)
                    intPokok = 0
                    intWajib = 0
                    intSukarela = 0
                    'For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                    '    Select Case adoRow!TRANSACTION_CODE
                    '        Case "BUNGA"
                    '            intSukarela = intSukarela + adoRow!AMOUNT
                    '        Case "SUKARELA"
                    '            intSukarela = intSukarela + adoRow!AMOUNT
                    '        Case "POKOK"
                    '            intPokok = intPokok + adoRow!AMOUNT
                    '        Case "WAJIB"
                    '            intWajib = intWajib + adoRow!AMOUNT
                    '    End Select
                    'Next
                    'lblPokok.Text = Format(intPokok, "#,##0")
                    'lblWajib.Text = Format(intWajib, "#,##0")
                    'lblSukarela.Text = Format(intSukarela, "#,##0")
                    'lblTotal.Text = Format(intPokok + intWajib + intSukarela, "#,##0")

                    'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    'If lvwList.Items.Count > 15 Then
                    '    lvwList.Columns(4).Width = 191
                    'End If
                    Me.btnSelect_Click(sender, e)
                Else
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo Form_Loop
                End If
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcMembership Is Nothing) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim myForm As New frmMembershipTransaction01()
        Dim adoDS As New DataSet()
        Dim strMemberId As String
        Dim intRowNumber As Int16
        Dim adoRow As DataRow
        Dim blnEditable As Boolean
        Dim sngLastValue As Double

        Try
            If strActive <> "A" Then
                Exit Sub
            End If

            If lvwList.Items.Count = 0 Then
                MessageBox.Show("No data to Modify.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If lvwList.Items.Count <> CInt(lvwList.SelectedItems.Item(0).Text) Then
                MessageBox.Show("Only last data can be modified.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            sngSavingAmount = svcMembership.GetTotalSaving(txtMemberId.Text, APP_ID)
            sngLastValue = CSng(lvwList.SelectedItems.Item(0).SubItems(4).Text)

            myForm.Initialization(txtMemberId.Text, lblName.Text, dtpAccPeriod.Value)
            adoDS = svcMembership.GetTransactionDetail(txtMemberId.Text, Format(dtpAccPeriod.Value, "yyyyMM"), _
                                                       IIf(lvwList.SelectedItems.Item(0).SubItems(3).Text = "DEBET", "DB", "CR"), Format(sngLastValue, "0.00"), _
                                                       Format(sngSavingAmount, "0.00"), APP_ID)
            If adoDS.Tables("TRANSACTION").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If lvwList.SelectedItems(0).Index = lvwList.Items.Count - 1 Then
                blnEditable = True
            Else
                blnEditable = False
            End If
            myForm.FillField(adoDS, blnEditable)
            'If lblLoanStatus.Text = "YES" Then
            '    myForm.GroupBox2.Enabled = False
            '    myForm.btnSave.Enabled = False
            'End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                Dim prevSavingAmount As Single
                If lvwList.SelectedItems.Item(0).SubItems(3).Text = "DEBET" Then
                    prevSavingAmount = sngSavingAmount + sngLastValue
                Else
                    prevSavingAmount = sngSavingAmount - sngLastValue
                End If
                adoDS = myForm.GetDataSet(prevSavingAmount)

                adoRow = adoDS.Tables("TRANSACTION").Rows(0)
                If adoRow!TRANSACTION_TYPE = "DB" Then
                    Select Case adoRow!TRANSACTION_CODE
                        Case "BUNGA"
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case "SUKARELA"
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case "POKOKDB", "305"
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case "WAJIBDB", "306"
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Amount must be less or equal than selected total transaction amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                        Case Else
                            If adoRow!AMOUNT > intSukarela Then
                                MessageBox.Show("Debet transaction cannot be less then voluntary - sukarela saving amount .", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                GoTo Form_Loop
                            End If
                    End Select
                End If

                svcMembership.UpdateTransaction(adoDS, Format(dtpAccPeriod.Value, "yyyyMM"), USER_ID, APP_ID)
                adoRow = adoDS.Tables("TRANSACTION").Rows(0)

                lvwList.SelectedItems.Item(0).SubItems(1).Text = Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy")
                lvwList.SelectedItems.Item(0).SubItems(2).Text = NullToString(adoRow!RESOURCE_DESC)
                lvwList.SelectedItems.Item(0).SubItems(3).Text = IIf(adoRow!TRANSACTION_TYPE = "CR", "CREDIT", "DEBET")
                lvwList.SelectedItems.Item(0).SubItems(4).Text = Format(adoRow!AMOUNT, "#,##0")
                lvwList.SelectedItems.Item(0).SubItems(5).Text = Format(adoRow!TOTAL, "#,##0")
                btnSelect_Click(sender, e)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As New DataSet()
        Dim adorow As DataRow

        Try
            If e.KeyCode = Keys.Return Then
                If txtMemberId.Text = "" Then
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcMembership.GetMemberName(txtMemberId.Text, APP_ID)
                If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    txtMemberId.Enabled = False
                    MessageBox.Show("No record found for entered member id.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtMemberId.Enabled = True
                Else
                    adorow = adoDS.Tables("MEMBERINFO").Rows(0)
                    lblName.Text = Trim(adorow!FIRST_NAME & " " & adorow!FAMILY_NAME)
                    strActive = adorow!ACTIVE_STATUS
                    lblLoanStatus.Text = IIf(adorow!LOAN_STATUS = "Y", "YES", "NO")
                    btnSelect.Focus()
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

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim adoDS As DataSet
        Dim tempFile As New System.IO.FileInfo(Application.StartupPath & "\Reports\TEMP_MEMBERSHIP_BUKTI_PENARIKAN.xls")
        Dim svcMembership As New Membership.svcMembership
        Dim sngLastValue As Single

        Try
            If strActive <> "A" Then
                Exit Sub
            End If

            If lvwList.Items.Count = 0 Then
                MessageBox.Show("No data to Modify.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If lvwList.Items.Count <> CInt(lvwList.SelectedItems.Item(0).Text) Then
                MessageBox.Show("Only last data can be modified.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            sngLastValue = CSng(lvwList.SelectedItems.Item(0).SubItems(4).Text)
            adoDS = svcMembership.GetTransactionDetail(txtMemberId.Text, Format(dtpAccPeriod.Value, "yyyyMM"), _
                                           IIf(lvwList.SelectedItems.Item(0).SubItems(3).Text = "DEBET", "DB", "CR"), Format(sngLastValue, "0.00"), _
                                           Format(sngSavingAmount, "0.00"), APP_ID)
            If adoDS.Tables(0).Rows.Count = 0 Then Exit Sub
            'If tran type no tequal DEBET then don't print
            If lvwList.SelectedItems.Item(0).SubItems(3).Text <> "DEBET" Then Exit Sub

            'Check file exits
            If tempFile.Exists Then
                tempFile.Delete()
            End If
            Generate_Report1(adoDS, lblName.Text)
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
                svcMembership = Nothing
            End If
        End Try
    End Sub

    Private Sub Generate_Report1(ByVal adoDS As DataSet, ByVal strReciver As String)
        'Dim xlApp As Object
        'Dim xlWb As Object
        'Dim xlWs As Object
        Dim xlApp As Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlWs As Excel.Worksheet
        Dim intCount As Int16 = 1
        Dim rowCount As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String
        Dim strTransDesc As String

        Try
            adoRow = adoDS.Tables(0).Rows(0)
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\MEMBERSHIP_BUKTI_PENARIKAN.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(1, 8) = "-"
            xlWs.Cells(2, 8) = "'" & adoRow!TRANSACTION_ID & Format(adoRow!TRANSACTION_DATE, "yyyyMMdd")

            xlWs.Cells(5, 3) = "Rp. " & Format(adoRow!AMOUNT, "#,##0")
            xlWs.Cells(6, 3) = ConvertMoneyToAlphabet(CSng(adoRow!AMOUNT))
            xlWs.Cells(7, 3) = NullToString(adoRow!RESOURCE_DESC)
            xlWs.Cells(9, 3) = USER_ID & " - " & EMPLOYEE_NAME
            xlWs.Cells(11, 7) = Format(Now, "dddd - dd MMM yyyy")
            xlWs.Cells(15, 7) = "(_" & strReciver & "_)"

            xlApp.UserControl = False
            xlWb.Application.Visible = False
            xlWb.PrintOut()
            xlWb.SaveAs(Application.StartupPath & "\Reports\TEMP_MEMBERSHIP_BUKTI_PENARIKAN.xls")
            xlWb.Close(False)
            xlApp.Quit()
            xlApp = Nothing
            xlWb = Nothing
            xlWs = Nothing
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWb) Then
                    xlWb.Close(False)
                End If
                xlApp.Application.Quit()
                xlApp = Nothing
                xlWb = Nothing
                xlWs = Nothing
            End If
            Err.Clear()
            Throw ex
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


End Class
