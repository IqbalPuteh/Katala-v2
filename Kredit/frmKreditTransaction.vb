Public Class frmKreditTransaction
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblMembershipNo As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAccPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblPinalty As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblLoanSum As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKreditTransaction))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblBalance = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblPinalty = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPayment = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblLoanSum = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpAccPeriod = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblMembershipNo = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox2.Size = New System.Drawing.Size(674, 272)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblBalance)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblPinalty)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblPayment)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblLoanSum)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(668, 61)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Summary"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.ForeColor = System.Drawing.Color.Blue
        Me.lblBalance.Location = New System.Drawing.Point(560, 32)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(63, 17)
        Me.lblBalance.TabIndex = 13
        Me.lblBalance.Text = "lblBalance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(512, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Balance:"
        '
        'lblPinalty
        '
        Me.lblPinalty.AutoSize = True
        Me.lblPinalty.ForeColor = System.Drawing.Color.Red
        Me.lblPinalty.Location = New System.Drawing.Point(408, 32)
        Me.lblPinalty.Name = "lblPinalty"
        Me.lblPinalty.Size = New System.Drawing.Size(58, 17)
        Me.lblPinalty.TabIndex = 11
        Me.lblPinalty.Text = "lblPinalty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(368, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Pinalty:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.ForeColor = System.Drawing.Color.Black
        Me.lblPayment.Location = New System.Drawing.Point(264, 32)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(68, 17)
        Me.lblPayment.TabIndex = 9
        Me.lblPayment.Text = "lblPayment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(215, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Payment:"
        '
        'lblLoanSum
        '
        Me.lblLoanSum.AutoSize = True
        Me.lblLoanSum.ForeColor = System.Drawing.Color.Red
        Me.lblLoanSum.Location = New System.Drawing.Point(120, 32)
        Me.lblLoanSum.Name = "lblLoanSum"
        Me.lblLoanSum.Size = New System.Drawing.Size(71, 17)
        Me.lblLoanSum.TabIndex = 7
        Me.lblLoanSum.Text = "lblLoanSum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Loan:"
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(592, 408)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(416, 408)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 16
        Me.btnAddNew.Text = "&Add New"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(504, 408)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 17
        Me.btnModify.Text = "&Modify"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpAccPeriod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblMembershipNo)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 128)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpAccPeriod
        '
        Me.dtpAccPeriod.CustomFormat = "yyyy-MM"
        Me.dtpAccPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccPeriod.Location = New System.Drawing.Point(128, 91)
        Me.dtpAccPeriod.Name = "dtpAccPeriod"
        Me.dtpAccPeriod.ShowUpDown = True
        Me.dtpAccPeriod.Size = New System.Drawing.Size(80, 21)
        Me.dtpAccPeriod.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(59, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Acct Period :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(248, 56)
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
        Me.lblMembershipNo.Location = New System.Drawing.Point(37, 56)
        Me.lblMembershipNo.Name = "lblMembershipNo"
        Me.lblMembershipNo.Size = New System.Drawing.Size(90, 17)
        Me.lblMembershipNo.TabIndex = 4
        Me.lblMembershipNo.Text = "Membership No.:"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(128, 54)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(104, 21)
        Me.txtMemberId.TabIndex = 2
        Me.txtMemberId.Text = ""
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
        'frmKreditTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(674, 440)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKreditTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Loan Transaction"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Dispose()
    End Sub

    Private Sub frmKreditTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adoDs As DataSet
        Dim svcLoan As New Loan.svcLoan
        Dim strAcctPeriod As String

        Try
            Me.lblName.Text = ""
            Me.lblLoanSum.Text = "0"
            Me.lblPinalty.Text = "0"
            Me.lblPayment.Text = "0"
            Me.lblBalance.Text = "0"
            Me.btnSelect.Enabled = False
            adoDs = svcLoan.GetAcctPeriod(APP_ID)
            strAcctPeriod = CType(adoDs.Tables(0).Rows(0).Item(0), String)
            dtpAccPeriod.Value = DateSerial(strAcctPeriod.Substring(0, 4), strAcctPeriod.Substring(4, 2), 1)
            dtpAccPeriod.Enabled = False

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim adoDS As DataSet
        Dim svcMembership As New Membership.svcMembership

        Try
            If e.KeyData = Keys.Enter Then
                If Me.txtMemberId.Text.Trim <> "" Then
                    adoDS = svcMembership.GetDetailMemberInfo(Me.txtMemberId.Text.Trim, APP_ID)
                    If adoDS.Tables(0).Rows.Count > 0 Then
                        Me.lblName.Text = CType(adoDS.Tables(0).Rows(0).Item("FIRST_NAME"), String) & _
                        " " & CType(adoDS.Tables(0).Rows(0).Item("FAMILY_NAME"), String)
                        Me.btnSelect.Enabled = True
                    Else
                        Me.lblName.Text = ""
                        btnAddNew.Enabled = False
                        btnModify.Enabled = False
                        Me.lblLoanSum.Text = "0"
                        Me.lblPinalty.Text = "0"
                        Me.lblPayment.Text = "0"
                        Me.lblBalance.Text = "0"
                        Me.lvwList.Items.Clear()
                        Me.btnSelect.Enabled = False
                        Exit Sub
                    End If
                End If
            Else
                Me.lblName.Text = ""
                btnAddNew.Enabled = False
                btnModify.Enabled = False
                Me.lblLoanSum.Text = "0"
                Me.lblPinalty.Text = "0"
                Me.lblPayment.Text = "0"
                Me.lblBalance.Text = "0"
                Me.lvwList.Items.Clear()
                Me.btnSelect.Enabled = False
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcLoan As New Loan.svcLoan
        Dim adoDS As DataSet
        Dim dtDatePeriod As Date
        Dim strAcctPeriod As String

        Try
            If Me.lblName.Text <> "" Then
                'Get Data
                strAcctPeriod = Format(dtpAccPeriod.Value, "yyyyMM")
                adoDS = svcLoan.GetLoanPaymentPeriod(Me.txtMemberId.Text.Trim, "", strAcctPeriod, APP_ID)
                btnAddNew.Enabled = True
                If adoDS.Tables(0).Rows.Count = 0 Then
                    btnModify.Enabled = False
                    Exit Sub
                End If
                Refresh_ListView(adoDS)

            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub Refresh_ListView(ByVal adoDS As DataSet)
        Dim intCount As Int32 = 0

        Try
            Me.lvwList.Items.Clear()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            For Each adoRow As DataRow In adoDS.Tables(0).Rows
                Dim lvItem As ListViewItem
                lvItem = New ListViewItem
                intCount += 1
                lvItem.Text = intCount & "."
                lvItem.SubItems.Add(Format(adoRow!TRANSACTION_DATE, "dd-MMM-yyyy"))
                lvItem.SubItems.Add(CType(adoRow!RESOURCE_DESC, String))
                lvItem.SubItems.Add(IIf(adoRow!TRANSACTION_TYPE = "CR", "Credit", "Debet"))
                lvItem.SubItems.Add(IIf(adoRow!TRANSACTION_TYPE = "CR", Format(adoRow!AMOUNT, "#,##0"), Format(adoRow!AMOUNT, "#,##0")))
                lvItem.SubItems.Add(Format(adoRow!TOTAL, "#,##0"))
                Me.lvwList.Items.Add(lvItem)
            Next
            btnModify.Enabled = True
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Calculate_Summary()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Calculate_Summary()
        Dim intTotalPayment, intPinalty As Int32
        Dim intLoan, intBalance As Int32
        Dim svcLoan As New Loan.svcLoan
        Dim adoRow As DataRow
        Dim adoDS As DataSet

        Try
            intLoan = 0
            intPinalty = 0
            intBalance = 0
            intTotalPayment = 0
            adoDS = svcLoan.GetLoanTransactionSummary(Me.txtMemberId.Text.Trim, APP_ID)
            adoRow = adoDS.Tables(0).Rows(0)

            For Each adoRow In adoDS.Tables(0).Rows
                Select Case adoRow!TRANSACTION_CODE
                    Case "INIT"
                        intLoan = intLoan + adoRow!AMOUNT
                    Case "PINALTY"
                        intPinalty = intPinalty + adoRow!AMOUNT
                    Case "SETORAN"
                        intTotalPayment = intTotalPayment + adoRow!AMOUNT
                    Case Else
                        intTotalPayment = intTotalPayment + adoRow!AMOUNT
                End Select
            Next
            Me.lblPayment.Text = Format(intTotalPayment, "#,##0")
            If intLoan < 0 Then
                Me.lblLoanSum.Text = Format(Math.Abs(intLoan), "(#,##0)")
            Else
                Me.lblLoanSum.Text = Format(intLoan, "#,##0")
            End If
            If intPinalty < 0 Then
                Me.lblPinalty.Text = Format(Math.Abs(intPinalty), "(#,##0)")
            Else
                Me.lblPinalty.Text = Format(intPinalty, "#,##0")
            End If
            intBalance = intTotalPayment + intLoan + intPinalty
            If intBalance < 0 Then
                Me.lblBalance.Text = Format(Math.Abs(intBalance), "(#,##0)")
            Else
                Me.lblBalance.Text = Format(intBalance, "#,##0")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim subForm As New frmKreditTransaction01
        Dim svcLoan As New Loan.svcLoan
        Dim adoDS As DataSet
        Dim strResult As String = ""

        Try
            subForm.Initialization(Me.txtMemberId.Text.Trim, Me.lblName.Text, Me.dtpAccPeriod.Value, "")
            subForm.ShowDialog(Me)
            '|| Save method
            If subForm.GetCancelStatus Then Exit Sub
            adoDS = subForm.GetDataSet(0)
            strResult = svcLoan.AddLoanTransaction(adoDS, APP_ID)
            If strResult <> "" Then
                ShowErrorMessage(strResult, "Loan Transaction")
                Exit Sub
            End If
            btnSelect_Click(sender, e)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If Not IsNothing(subForm) Then
                subForm.Dispose()
            End If
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity
        Dim subForm As New frmKreditTransaction01
        Dim svcLoan As New Loan.svcLoan
        Dim intUserAccessVal As Int16
        Dim intPreSavingAmount As Int64
        Dim strAcctPeriod As String
        Dim strResult As String
        Dim adoRow As DataRow
        Dim adoDS As DataSet
        Dim dtDate As Date

        Try
            If lvwList.Items.Count = 0 Then
                MessageBox.Show("No data to Modify.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("No row is selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If lvwList.Items.Count <> CInt(lvwList.SelectedItems.Item(0).Text) Then
                MessageBox.Show("Only last data can be modified.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            subForm.Initialization(Me.txtMemberId.Text, Me.lblName.Text, DateSerial(Me.dtpAccPeriod.Value.Year, Me.dtpAccPeriod.Value.Month, 1), "")
            intUserAccessVal = svcSecurity.GetUserAccessValue(USER_ID, "LOAN", APP_ID)
            dtDate = CDate(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text)
            adoDS = svcLoan.GetLoanPaymentDetail(Me.txtMemberId.Text.Trim, dtDate, Format(Me.dtpAccPeriod.Value, "yyyyMM"), CInt(Me.lvwList.SelectedItems.Item(0).SubItems(4).Text), APP_ID)
            adoRow = adoDS.Tables(0).Rows(0)
            If adoRow!TRANSACTION_CODE = "INIT" And intUserAccessVal < 5 Then
                MessageBox.Show("Cannot modify Realization Transaction.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            subForm.FillField(adoDS, True)
            subForm.ShowDialog(Me)
            '||=>> Update method
            If subForm.GetCancelStatus Then Exit Sub
            If Me.lvwList.SelectedItems(0).SubItems(3).Text.ToUpper = "CREDIT" Then
                intPreSavingAmount = CInt(lvwList.SelectedItems(0).SubItems(5).Text) - CInt(lvwList.SelectedItems(0).SubItems(4).Text)
            Else
                intPreSavingAmount = CInt(lvwList.SelectedItems(0).SubItems(5).Text) + CInt(lvwList.SelectedItems(0).SubItems(4).Text)
            End If
            adoDS = subForm.GetDataSet(intPreSavingAmount)
            strResult = svcLoan.UpdateLoanTransaction(adoDS, APP_ID)
            If strResult <> "" Then
                ShowErrorMessage(strResult, "Loan Transaction")
                Exit Sub
            End If
            btnSelect_Click(sender, e)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If Not IsNothing(subForm) Then
                subForm.Dispose()
            End If
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick

        btnModify_Click(sender, e)
    End Sub
End Class

#Region "Unused Function"


'Private Sub txtLoanId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanId.TextChanged

'    If Me.txtLoanId.Text.Trim = "" Then
'        Me.lblLoanStatus.Text = ""
'        Me.lvwList.Items.Clear()
'        Me.btnSelect.Enabled = False
'    Else
'        Dim svcLoan As New Loan.svcLoan
'        Dim adoDS As DataSet

'        adoDS = svcLoan.GetLoanInfo(Me.txtMemberId.Text.Trim, Me.txtLoanId.Text.Trim, APP_ID)
'        If adoDS.Tables(0).Rows.Count = 0 Then
'            Me.lblLoanStatus.Text = ""
'            Me.lvwList.Items.Clear()
'            Me.btnSelect.Enabled = False
'            Me.btnAddNew.Enabled = False
'            Me.lblLoanSum.Text = "0"
'            Me.lblPayment.Text = "0"
'            Me.lblPinalty.Text = "0"
'            Me.lblBalance.Text = "0"
'        Else
'            Me.btnAddNew.Enabled = True

'        End If
'    End If
'End Sub

'Private Sub txtLoanId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanId.KeyDown
'    Dim svcLoan As New Loan.svcLoan
'    Dim adoDS As DataSet
'    Dim adoDSLOV As New DataSet
'    Dim myFormLOV As New frmLOV
'    Dim adoRowLOV As DataRow

'    Try
'        If e.KeyCode = e.KeyCode.F2 Then
'            adoDS = svcLoan.GetMemberLoanId(Me.txtMemberId.Text.Trim, APP_ID)
'            myFormLOV.Initialize(txtMemberId.Text, adoDS, "MEMBER_LOAN_NO")

'            myFormLOV.ShowDialog()
'            If myFormLOV.GetCancelStatus = False Then
'                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'                adoDSLOV = myFormLOV.GetDataSet()
'                If adoDSLOV.Tables("RESOURCEINFO").Rows.Count > 0 Then
'                    adoRowLOV = adoDSLOV.Tables("RESOURCEINFO").Rows(0)
'                    Me.txtLoanId.Text = adoRowLOV!RESOURCE_CODE
'                    adoDSLOV.Dispose()
'                End If
'                txtLoanId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
'            End If
'            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
'        End If

'        If e.KeyData = Keys.Enter Then
'            If Me.txtMemberId.Text.Trim <> "" Then
'                adoDS = svcLoan.GetLoanInfo(Me.txtMemberId.Text.Trim, Me.txtLoanId.Text.Trim, APP_ID)
'                If adoDS.Tables(0).Rows.Count > 0 Then
'                    Me.lblLoanStatus.Text = _
'                    IIf(NullToString(adoDS.Tables(0).Rows(0).Item("AMORTIZE_FLAG")) <> "Y", "UN-FINNISHED", "FINNISHED")
'                    Me.btnSelect.Enabled = True
'                    btnSelect_Click(sender, e)
'                    Me.btnSelect.Focus()
'                Else
'                    Me.lblLoanStatus.Text = ""
'                    Me.lvwList.Items.Clear()
'                    Me.btnSelect.Enabled = False
'                End If
'            End If
'        End If

'    Catch ex As Exception
'        ShowErrorMessage(ex.Message, ex.Source)
'    Finally
'        If Not IsNothing(svcLoan) Then
'            svcLoan.Dispose()
'        End If
'        If Not (adoDSLOV Is Nothing) Then
'            adoDSLOV.Dispose()
'            adoDSLOV = Nothing
'        End If
'        If Not (myFormLOV Is Nothing) Then
'            myFormLOV.Dispose()
'            myFormLOV = Nothing
'        End If
'    End Try
'End Sub

#End Region
