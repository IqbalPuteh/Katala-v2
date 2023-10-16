Public Class frmLoanHistory
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
    Friend WithEvents lblLoanStatus As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents lblAccPeriod As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtLoanId As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLoanHistory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLoanId = New System.Windows.Forms.TextBox
        Me.lblLoanStatus = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.lblAccPeriod = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDateEnd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpDateStart)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLoanId)
        Me.GroupBox1.Controls.Add(Me.lblLoanStatus)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label71)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.lblAccPeriod)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 136)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Checked = False
        Me.dtpDateEnd.CustomFormat = "dd MMM yyyy"
        Me.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateEnd.Location = New System.Drawing.Point(320, 106)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.ShowCheckBox = True
        Me.dtpDateEnd.Size = New System.Drawing.Size(112, 21)
        Me.dtpDateEnd.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(264, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "End Date:"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.CustomFormat = "dd MMM yyyy"
        Me.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateStart.Location = New System.Drawing.Point(128, 106)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(96, 21)
        Me.dtpDateStart.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(65, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Start Date:"
        '
        'txtLoanId
        '
        Me.txtLoanId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtLoanId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoanId.Location = New System.Drawing.Point(128, 77)
        Me.txtLoanId.MaxLength = 20
        Me.txtLoanId.Name = "txtLoanId"
        Me.txtLoanId.Size = New System.Drawing.Size(176, 21)
        Me.txtLoanId.TabIndex = 2
        Me.txtLoanId.Text = ""
        '
        'lblLoanStatus
        '
        Me.lblLoanStatus.AutoSize = True
        Me.lblLoanStatus.ForeColor = System.Drawing.Color.Black
        Me.lblLoanStatus.Location = New System.Drawing.Point(416, 79)
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
        Me.Label17.Location = New System.Drawing.Point(350, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Loan Status:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(248, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "lblName"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(37, 50)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(90, 17)
        Me.Label71.TabIndex = 4
        Me.Label71.Text = "Membership No.:"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(128, 48)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(104, 21)
        Me.txtMemberId.TabIndex = 0
        Me.txtMemberId.Text = ""
        '
        'lblAccPeriod
        '
        Me.lblAccPeriod.AutoSize = True
        Me.lblAccPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccPeriod.ForeColor = System.Drawing.Color.Black
        Me.lblAccPeriod.Location = New System.Drawing.Point(52, 79)
        Me.lblAccPeriod.Name = "lblAccPeriod"
        Me.lblAccPeriod.Size = New System.Drawing.Size(75, 17)
        Me.lblAccPeriod.TabIndex = 2
        Me.lblAccPeriod.Text = "Loan Number:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(536, 76)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 5
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 298)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction List"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(674, 278)
        Me.lvwList.TabIndex = 6
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
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(592, 440)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "&Close"
        '
        'frmLoanHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(680, 470)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoanHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Loan Transaction History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
    End Sub

    Private Sub frmLoanHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblName.Text = ""
        Me.lblLoanStatus.Text = ""
        Me.txtLoanId.Text = ""
        Me.btnSelect.Enabled = False
        Me.dtpDateStart.Value = Now
        Me.txtMemberId.Focus()
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet

        Try
            If e.KeyData = Keys.Enter Then
                If Me.txtMemberId.Text.Trim <> "" Then
                    adoDS = svcMembership.GetDetailMemberInfo(Me.txtMemberId.Text.Trim, APP_ID)
                    If adoDS.Tables(0).Rows.Count > 0 Then
                        Me.lblName.Text = CType(adoDS.Tables(0).Rows(0).Item("FIRST_NAME"), String) & _
                        CType(adoDS.Tables(0).Rows(0).Item("FAMILY_NAME"), String)
                        Me.txtLoanId.Focus()
                    Else
                        Me.lblName.Text = ""
                        Me.lblLoanStatus.Text = ""
                        Me.txtLoanId.Text = ""
                        Me.lvwList.Items.Clear()
                        Me.btnSelect.Enabled = False
                        Exit Sub
                    End If
                End If
            Else
                Me.lblName.Text = ""
                Me.lblLoanStatus.Text = ""
                Me.txtLoanId.Text = ""
                Me.lvwList.Items.Clear()
                Me.btnSelect.Enabled = False
            End If
        Catch ex As Exception
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtLoanId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanId.KeyDown
        Dim svcLoan As New Loan.svcLoan
        Dim adoDS As DataSet
        Dim adoDSLOV As New DataSet
        Dim myFormLOV As New frmLOV
        Dim adoRowLOV As DataRow

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                adoDS = svcLoan.GetMemberLoanId(Me.txtMemberId.Text.Trim, APP_ID)
                myFormLOV.Initialize(txtMemberId.Text, adoDS, "MEMBER_LOAN_NO")

                myFormLOV.ShowDialog()
                If myFormLOV.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDSLOV = myFormLOV.GetDataSet()
                    If adoDSLOV.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRowLOV = adoDSLOV.Tables("RESOURCEINFO").Rows(0)
                        Me.txtLoanId.Text = adoRowLOV!RESOURCE_CODE
                        adoDSLOV.Dispose()
                    End If
                    txtLoanId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If

            If e.KeyData = Keys.Enter Then
                If Me.txtMemberId.Text.Trim <> "" Then
                    adoDS = svcLoan.GetLoanInfo(Me.txtMemberId.Text.Trim, Me.txtLoanId.Text.Trim, APP_ID)
                    If adoDS.Tables(0).Rows.Count > 0 Then
                        Me.lblLoanStatus.Text = _
                        IIf(NullToString(adoDS.Tables(0).Rows(0).Item("END_FLAG")) = "", "UN-FINNISHED", "FINNISHED")
                        Me.btnSelect.Enabled = True
                        Me.dtpDateStart.Focus()
                    Else
                        Me.lblLoanStatus.Text = ""
                        Me.lvwList.Items.Clear()
                        Me.btnSelect.Enabled = False
                    End If
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
            If Not (adoDSLOV Is Nothing) Then
                adoDSLOV.Dispose()
                adoDSLOV = Nothing
            End If
            If Not (myFormLOV Is Nothing) Then
                myFormLOV.Dispose()
                myFormLOV = Nothing
            End If
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcLoan As New Loan.svcLoan
        Dim adoDS As DataSet

        Try
            If Me.lblName.Text <> "" And Me.lblLoanStatus.Text <> "" Then
                'Get Data
                If Me.dtpDateEnd.Checked Then
                    Dim dtEnd As Date
                    dtEnd = DateSerial(1900, 1, 1)
                    adoDS = svcLoan.GetLoanPayment(Me.txtLoanId.Text.Trim, Me.dtpDateStart.Value, dtEnd, APP_ID)
                Else
                    adoDS = svcLoan.GetLoanPayment(Me.txtLoanId.Text.Trim, Me.dtpDateStart.Value, Me.dtpDateEnd.Value, APP_ID)
                End If
                Refresh_ListView(adoDS)
            Else
                MessageBox.Show("No data !", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If

        End Try
    End Sub

    Private Sub Refresh_ListView(ByVal adoDS As DataSet)
        Dim intCount As Int32 = 0

        Me.lvwList.Items.Clear()
        If adoDS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("No data!.", "Loan Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        For Each adoRow As DataRow In adoDS.Tables(0).Rows
            Dim lvItem As ListViewItem
            lvItem = New ListViewItem
            intCount += 1
            lvItem.Text = intCount & "."
            lvItem.SubItems.Add(CType(adoRow!TRANSACTION_DATE, String))
            lvItem.SubItems.Add(CType(adoRow!RESOURCE_DESC, String))
            lvItem.SubItems.Add(IIf(adoRow!TRANSACTION_TYPE = "CR", "Credit", "Debet"))
            lvItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
            lvItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
            Me.lvwList.Items.Add(lvItem)
        Next
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txtLoanId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanId.TextChanged

        If Me.txtLoanId.Text.Trim = "" Then
            Me.lblLoanStatus.Text = ""
            Me.lvwList.Items.Clear()
            Me.btnSelect.Enabled = False
        Else
            Dim svcLoan As New Loan.svcLoan
            Dim adoDS As DataSet

            adoDS = svcLoan.GetLoanInfo(Me.txtMemberId.Text.Trim, Me.txtMemberId.Text.Trim, APP_ID)
            If adoDS.Tables(0).Rows.Count = 0 Then
                Me.lblLoanStatus.Text = ""
                Me.lvwList.Items.Clear()
                Me.btnSelect.Enabled = False
            End If
        End If
    End Sub
End Class
