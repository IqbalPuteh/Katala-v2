Public Class frmKreditApproval
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboRegPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboKreditType As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnUnApproved As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKreditApproval))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboRegPeriod = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboKreditType = New System.Windows.Forms.ComboBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnUnApproved = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboRegPeriod)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cboKreditType)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Registered For Period:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboRegPeriod
        '
        Me.cboRegPeriod.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboRegPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegPeriod.Location = New System.Drawing.Point(128, 101)
        Me.cboRegPeriod.Name = "cboRegPeriod"
        Me.cboRegPeriod.Size = New System.Drawing.Size(104, 21)
        Me.cboRegPeriod.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(56, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Credit Type:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboKreditType
        '
        Me.cboKreditType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboKreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKreditType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKreditType.ItemHeight = 13
        Me.cboKreditType.Location = New System.Drawing.Point(128, 72)
        Me.cboKreditType.Name = "cboKreditType"
        Me.cboKreditType.Size = New System.Drawing.Size(184, 21)
        Me.cboKreditType.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(240, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 91
        Me.lblName.Text = "lblName"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(128, 43)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.TabIndex = 0
        Me.txtMemberId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Membership No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type filters below then press the select button to view credit information."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(528, 70)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(598, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        '
        'btnView
        '
        Me.btnView.Enabled = False
        Me.btnView.Location = New System.Drawing.Point(422, 413)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(80, 24)
        Me.btnView.TabIndex = 10
        Me.btnView.Text = "&View"
        '
        'btnUnApproved
        '
        Me.btnUnApproved.Enabled = False
        Me.btnUnApproved.Location = New System.Drawing.Point(510, 413)
        Me.btnUnApproved.Name = "btnUnApproved"
        Me.btnUnApproved.Size = New System.Drawing.Size(80, 24)
        Me.btnUnApproved.TabIndex = 12
        Me.btnUnApproved.Text = "Un-Reviewed"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 272)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Credit Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(676, 252)
        Me.lvwList.TabIndex = 1
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Registration No."
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Membership No."
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 192
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Registred Date"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 103
        '
        'frmKreditApproval
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(682, 440)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnUnApproved)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKreditApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Loan Approval Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private arrStrKreditTypeCode() As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Dispose()
    End Sub

    Private Sub frmRegistryCredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As New DataSet
        Dim intCount As Int16 = 2
        Dim dtDate As Date
        Dim strDate As String
        Dim intAccessVal As Short

        Try
            lblName.Text = ""
            cboKreditType.Items.Add("ALL")
            ReDim Preserve arrStrKreditTypeCode(1)
            arrStrKreditTypeCode(1) = "ALL"
            adoDS = svcHouseKeeping.GetResourceCode("LOAN", "TYPE", APP_ID)
            For Each adoRow As DataRow In adoDS.Tables(0).Rows
                cboKreditType.Items.Add(adoRow!RESOURCE_DESC)
                ReDim Preserve arrStrKreditTypeCode(intCount)
                arrStrKreditTypeCode(intCount) = adoRow!RESOURCE_CODE
                intCount += 1
            Next
            cboKreditType.SelectedIndex = 0

            '// Using membership acct period as period //
            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            strDate = adoDS.Tables(0).Rows(0).Item(0)
            'cboRegPeriod.Items.Add("ALL")
            For intCount = 0 To 6
                dtDate = DateSerial(strDate.Substring(0, 4), strDate.Substring(4), 1)
                dtDate = dtDate.AddMonths(intCount)
                Me.cboRegPeriod.Items.Add(CType(dtDate.Year, String) & IIf(CType(dtDate.Month, String).Length = 1, "0" & CType(dtDate.Month, String), CType(dtDate.Month, String)))
            Next
            cboRegPeriod.SelectedIndex = 0
            intAccessVal = svcSecurity.GetUserAccessValue(USER_ID, "KREDIT", APP_ID)
            If intAccessVal < 6 Then
                Me.btnUnApproved.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
                svcMembership = Nothing
            End If
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        Try
            Refresh_ListView("")
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub Refresh_ListView(ByVal strLoanId As String)
        Dim svcKredit As New Loan.svcLoan
        Dim adoDS As DataSet
        Dim intCount As Int16 = 1
        Dim clrFontColor As System.Drawing.Color
        Dim strEmployeeID As String = ""
        Dim strRegPeriod As String = ""
        Dim strCreditType As String = ""
        Dim strStatus As String

        Try

            If Me.lblName.Text <> "" Then
                strEmployeeID = Me.txtMemberId.Text.Trim
            End If
            If Me.cboRegPeriod.SelectedIndex <> -1 Then
                strRegPeriod = CType(cboRegPeriod.Text, String)
            End If
            If Me.cboKreditType.SelectedIndex <> -1 Then
                strCreditType = arrStrKreditTypeCode(cboKreditType.SelectedIndex + 1)
            End If
            adoDS = svcKredit.GetLoanToBeApproved(Me.txtMemberId.Text.Trim, strRegPeriod, strCreditType, strLoanId, APP_ID)
            If adoDS.Tables(0).Rows.Count = 0 Then
                btnView.Enabled = False
                MessageBox.Show("No record was selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.lvwList.Items.Clear()
            For Each adoRow As DataRow In adoDS.Tables(0).Rows
                Dim lvItem As New ListViewItem
                Select Case adoRow!STATUS
                    Case "R" 'Reviewed
                        clrFontColor = System.Drawing.Color.Blue
                        strStatus = "+ANALIZED+"
                    Case "Y" 'Approved
                        clrFontColor = System.Drawing.Color.Red
                        strStatus = "**TRANSACTION**"
                    Case Else 'Not approved
                        clrFontColor = System.Drawing.Color.Black
                        strStatus = "REGISTERED"
                End Select

                lvItem.Text = CType(intCount, String) & "."
                lvItem.SubItems.Add(adoRow!LOAN_ID)
                lvItem.SubItems.Add(adoRow!MEMBERSHIP_NO)
                lvItem.SubItems.Add(adoRow!NAME)
                lvItem.SubItems.Add(Format(adoRow!REGISTER_DATE, "dd-MMM-yyyy"))
                lvItem.SubItems.Add(strStatus)
                lvItem.ForeColor = clrFontColor
                lvwList.Items.Add(lvItem)
                intCount += 1
            Next
            btnView.Enabled = True
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not IsNothing(svcKredit) Then
                svcKredit.Dispose()
                svcKredit = Nothing
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged

        lblName.Text = ""
        btnView.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub cboKreditType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKreditType.SelectedIndexChanged

        btnView.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet

        Try
            If e.KeyValue = Keys.Enter Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcMembership.GetMemberName(txtMemberId.Text, APP_ID)
                If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    lblName.Text = ""
                    MessageBox.Show("The Member Name data is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    lblName.Text = adoDS.Tables("MEMBERINFO").Rows(0)("FIRST_NAME") & " " & adoDS.Tables("MEMBERINFO").Rows(0)("FAMILY_NAME")
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim frmSubForm As New frmKreditApproval01
        Dim svcLoan As New Loan.svcLoan
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            If Me.lvwList.SelectedIndices.Count = 0 Then
                Exit Sub
            End If
            If Me.lvwList.SelectedItems.Item(0).SubItems(5).Text = "**TRANSACTION**" Then
                Exit Sub
            End If
            adoDS = svcLoan.GetRegistrationStatusDetail(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            frmSubForm.InitializeForm()
            frmSubForm.FillField(adoDS)
            frmSubForm.ShowDialog(Me)
            If Not frmSubForm.isCancelSave Then
                adoDS = frmSubForm.GetDataSet
                svcLoan.ModifyLoanApproval(adoDS, APP_ID)
                Refresh_ListView(adoDS.Tables(0).Rows(0).Item("LOAN_ID"))
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(frmSubForm) Then
                frmSubForm.Dispose()
                frmSubForm = Nothing
            End If
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
                svcLoan = Nothing
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub frmRegistryCredit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        txtMemberId.Focus()
    End Sub

    Private Sub txtMemberId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberId.Leave

        If Trim(txtMemberId.Text) <> "" Then
            txtMemberId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
        End If
    End Sub

    Private Sub cboRegPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegPeriod.SelectedIndexChanged

        btnView.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub btnUnApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnApproved.Click
        Dim frmSubForm As New frmKreditApproval01
        Dim svcKredit As New Loan.svcLoan
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            If Me.lvwList.SelectedIndices.Count = 0 Then
                Exit Sub
            End If
            If MessageBox.Show("Are you sure to UN-APPROVED this Loan Register # " & Me.lvwList.SelectedItems.Item(0).SubItems(1).Text & " ? ", "Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
            If Me.lvwList.SelectedItems.Item(0).SubItems(5).Text <> "+ANALIZED+" Then
                Exit Sub
            End If
            If svcKredit.DeleteLoanApproval(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID) Then
                Me.btnUnApproved.Enabled = False
                Refresh_ListView(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text)
            Else
                MessageBox.Show("Cannot UN-approve the loan registration # " & Me.lvwList.SelectedItems.Item(0).SubItems(1).Text & "." & _
                                Chr(13) & "Its already been paid to the requestor.", "LOAN", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(frmSubForm) Then
                frmSubForm.Dispose()
                frmSubForm = Nothing
            End If
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not IsNothing(svcKredit) Then
                svcKredit.Dispose()
                svcKredit = Nothing
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub lvwList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwList.Click
        Try
            If Me.lvwList.SelectedIndices.Count = 0 Then
                Exit Sub
            End If
            If Me.lvwList.SelectedItems.Item(0).SubItems(5).Text = "+ANALIZED+" Then
                Me.btnUnApproved.Enabled = True
            Else
                Me.btnUnApproved.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick

        btnView_Click(sender, e)
    End Sub
End Class
