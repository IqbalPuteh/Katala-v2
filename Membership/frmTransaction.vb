Public Class frmTransaction
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMembershipNo As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpAccPeriod As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransaction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpAccPeriod = New System.Windows.Forms.DateTimePicker()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMembershipNo = New System.Windows.Forms.Label()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.lblAccPeriod = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpAccPeriod, Me.lblName, Me.lblMembershipNo, Me.txtMemberId, Me.lblAccPeriod, Me.btnSelect, Me.Label1})
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 120)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpAccPeriod
        '
        Me.dtpAccPeriod.CustomFormat = "yyyy-MM"
        Me.dtpAccPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccPeriod.Location = New System.Drawing.Point(128, 48)
        Me.dtpAccPeriod.Name = "dtpAccPeriod"
        Me.dtpAccPeriod.ShowUpDown = True
        Me.dtpAccPeriod.Size = New System.Drawing.Size(72, 21)
        Me.dtpAccPeriod.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(248, 88)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 14)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "lblName"
        '
        'lblMembershipNo
        '
        Me.lblMembershipNo.AutoSize = True
        Me.lblMembershipNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembershipNo.ForeColor = System.Drawing.Color.Black
        Me.lblMembershipNo.Location = New System.Drawing.Point(37, 87)
        Me.lblMembershipNo.Name = "lblMembershipNo"
        Me.lblMembershipNo.Size = New System.Drawing.Size(90, 14)
        Me.lblMembershipNo.TabIndex = 4
        Me.lblMembershipNo.Text = "Membership No.:"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(128, 79)
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
        Me.lblAccPeriod.Location = New System.Drawing.Point(24, 56)
        Me.lblAccPeriod.Name = "lblAccPeriod"
        Me.lblAccPeriod.Size = New System.Drawing.Size(102, 14)
        Me.lblAccPeriod.TabIndex = 2
        Me.lblAccPeriod.Text = "Accounting Period :"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(496, 80)
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
        Me.Label1.Size = New System.Drawing.Size(336, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the options below and click on select button !"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 264)
        Me.GroupBox2.TabIndex = 13
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
        Me.lvwList.Size = New System.Drawing.Size(668, 244)
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
        Me.btnClose.Location = New System.Drawing.Point(592, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(419, 397)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(507, 397)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'frmTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 431)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnAddNew, Me.btnModify, Me.GroupBox1, Me.GroupBox2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private strAcctPeriod As String
    Public sngSavingAmount As Single

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet

        Try
            lblName.Text = ""
            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            strAcctPeriod = CStr(adoDS.Tables(0).Rows(0).Item(0))
            dtpAccPeriod.Value = DateSerial(strAcctPeriod.Substring(0, 4), strAcctPeriod.Substring(5), 1)
            dtpAccPeriod.Enabled = False
            btnAddNew.Enabled = True
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcMembership.Dispose()
            adoDS.Dispose()
        End Try
    End Sub

    Private Sub txtMemberNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyUp
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

    Private Sub txtMemberNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        lblName.Text = ""
        btnModify.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim recordcount As Int32

        Try
            lvwList.Items.Clear()
            If lblName.Text = "" Then Exit Sub
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcMembership.GetTransaction(txtMemberId.Text, Format(dtpAccPeriod.Value, "yyyyMM"), APP_ID)
            sngSavingAmount = svcMembership.GetTotalSaving(txtMemberId.Text, APP_ID)

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If adoDS.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record was selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnModify.Enabled = False
                lvwList.Items.Clear()
            Else
                recordcount = 0
                lvwList.Items.Clear()
                For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                    Dim lvwItem As New ListViewItem()
                    lvwList.Items.Add(lvwItem)
                    recordcount = recordcount + 1
                    lvwItem.Text = recordcount.ToString
                    lvwItem.SubItems.Add(Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy"))
                    lvwItem.SubItems.Add(NullToString(adoRow!RESOURCE_DESC))
                    lvwItem.SubItems.Add(IIf(adoRow!TRANSACTION_TYPE = "CR", "CREDIT", "DEBET"))
                    lvwItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
                    lvwItem.SubItems.Add(Format(adoRow!TOTAL, "#,##0"))
                Next
                btnModify.Enabled = True
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim myForm As New frmTransaction01()
        Dim adoDS As New DataSet()
        Dim strResult As String
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            myForm.Initialization(txtMemberId.Text, lblName.Text, dtpAccPeriod.Value, 0)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet(sngSavingAmount, 0)
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
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    If lvwList.Items.Count > 15 Then
                        lvwList.Columns(4).Width = 191
                    End If
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
        Dim myForm As New frmTransaction01()
        Dim adoDS As New DataSet()
        Dim strMemberId As String
        Dim intRowNumber As Int16
        Dim adoRow As DataRow
        Dim blnEditable As Boolean
        Dim sngLastValue As Single

        Try
            If lvwList.Items.Count = 0 Then
                MessageBox.Show("No data to Modify.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If lvwList.Items.Count <> CInt(lvwList.SelectedItems.Item(0).Text) Then
                MessageBox.Show("Only last data can be modify.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            sngSavingAmount = svcMembership.GetTotalSaving(txtMemberId.Text, APP_ID)
            sngLastValue = CSng(lvwList.SelectedItems.Item(0).SubItems(4).Text)
            myForm.Initialization(txtMemberId.Text, lblName.Text, dtpAccPeriod.Value, sngLastValue)
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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = myForm.GetDataSet(sngSavingAmount, sngLastValue)
                svcMembership.UpdateTransaction(adoDS, Format(dtpAccPeriod.Value, "yyyyMM"), USER_ID, APP_ID)
                adoRow = adoDS.Tables("TRANSACTION").Rows(0)

                lvwList.SelectedItems.Item(0).SubItems(1).Text = Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy")
                lvwList.SelectedItems.Item(0).SubItems(2).Text = NullToString(adoRow!RESOURCE_DESC)
                lvwList.SelectedItems.Item(0).SubItems(3).Text = IIf(adoRow!TRANSACTION_TYPE = "CR", "CREDIT", "DEBET")
                lvwList.SelectedItems.Item(0).SubItems(4).Text = Format(adoRow!AMOUNT, "#,##0")
                lvwList.SelectedItems.Item(0).SubItems(5).Text = Format(adoRow!TOTAL, "#,##0")

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


End Class
