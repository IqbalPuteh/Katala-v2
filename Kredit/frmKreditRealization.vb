Public Class frmKreditRealization
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
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboKreditType As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSetRealization As System.Windows.Forms.Button
    Friend WithEvents chkShowRealization As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblAcctPeriod As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKreditRealization))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblAcctPeriod = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkShowRealization = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboKreditType = New System.Windows.Forms.ComboBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSetRealization = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 272)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Credit Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(732, 252)
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
        Me.ColumnHeader3.Text = "Member No"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Req. Period"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Feasible Amount"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Loan ID"
        Me.ColumnHeader7.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblAcctPeriod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkShowRealization)
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
        Me.GroupBox1.Size = New System.Drawing.Size(738, 160)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'LblAcctPeriod
        '
        Me.LblAcctPeriod.AutoSize = True
        Me.LblAcctPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAcctPeriod.ForeColor = System.Drawing.Color.Black
        Me.LblAcctPeriod.Location = New System.Drawing.Point(128, 126)
        Me.LblAcctPeriod.Name = "LblAcctPeriod"
        Me.LblAcctPeriod.Size = New System.Drawing.Size(82, 17)
        Me.LblAcctPeriod.TabIndex = 130
        Me.LblAcctPeriod.Text = "LblAcctPeriod"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(54, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Acct Period :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkShowRealization
        '
        Me.chkShowRealization.ForeColor = System.Drawing.Color.Black
        Me.chkShowRealization.Location = New System.Drawing.Point(336, 75)
        Me.chkShowRealization.Name = "chkShowRealization"
        Me.chkShowRealization.Size = New System.Drawing.Size(168, 48)
        Me.chkShowRealization.TabIndex = 128
        Me.chkShowRealization.Text = "Show Loan that already in Realization Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(56, 91)
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
        Me.cboKreditType.Location = New System.Drawing.Point(128, 89)
        Me.cboKreditType.Name = "cboKreditType"
        Me.cboKreditType.Size = New System.Drawing.Size(184, 21)
        Me.cboKreditType.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(240, 54)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 91
        Me.lblName.Text = "lblName"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(128, 52)
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
        Me.Label2.Location = New System.Drawing.Point(32, 54)
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
        Me.btnSelect.Location = New System.Drawing.Point(568, 88)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(656, 438)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 25)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        '
        'btnSetRealization
        '
        Me.btnSetRealization.Location = New System.Drawing.Point(472, 438)
        Me.btnSetRealization.Name = "btnSetRealization"
        Me.btnSetRealization.Size = New System.Drawing.Size(96, 25)
        Me.btnSetRealization.TabIndex = 8
        Me.btnSetRealization.Text = "Set Realization"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(572, 438)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 25)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Member Name"
        Me.ColumnHeader8.Width = 240
        '
        'frmKreditRealization
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 472)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSetRealization)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKreditRealization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Loan Realization Screen"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private arrStrKreditType() As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Dispose()
    End Sub

    Private Sub frmKreditRealization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim svcMembership As New Membership.svcMembership
        Dim intAccessVal As Short
        Dim adoDS As DataSet
        Dim intCount As Int16 = 0

        Try
            adoDS = svcHouseKeeping.GetResourceCode("LOAN", "TYPE", APP_ID)
            ReDim arrStrKreditType(adoDS.Tables(0).Rows.Count + 1)
            cboKreditType.Items.Add("ALL")
            arrStrKreditType(intCount) = "ALL"
            For Each adoRow As DataRow In adoDS.Tables(0).Rows
                intCount += 1
                arrStrKreditType(intCount) = adoRow!RESOURCE_CODE
                cboKreditType.Items.Add(adoRow!RESOURCE_DESC)
            Next
            cboKreditType.SelectedIndex = 0
            Me.lblName.Text = ""
            '// Using membership acct period as period //
            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            Me.LblAcctPeriod.Text = adoDS.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet

        Try
            If e.KeyData = Keys.Enter Then
                If Me.txtMemberId.Text.Trim <> "" Then
                    adoDS = svcMembership.GetDetailMemberInfo(Me.txtMemberId.Text.Trim, APP_ID)
                    If adoDS.Tables(0).Rows.Count > 0 Then
                        Me.lblName.Text = CType(adoDS.Tables(0).Rows(0).Item("FIRST_NAME"), String) & " " & _
                        CType(adoDS.Tables(0).Rows(0).Item("FAMILY_NAME"), String)
                        Me.btnSelect.Enabled = True
                    Else
                        Me.lblName.Text = ""
                        Me.lvwList.Items.Clear()
                        Me.btnSelect.Enabled = False
                        Exit Sub
                    End If
                End If
            Else
                Me.lblName.Text = ""
                Me.lvwList.Items.Clear()
                Me.btnSelect.Enabled = False
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcLoan As New Loan.svcLoan
        Dim adoDS As DataSet
        Dim intCount As Int16 = 1
        Dim lvItem As ListViewItem
        Dim strStatus As String
        Dim strDate As String

        Try
            Refresh_ListView()

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick

        Try
            If Me.lvwList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
            btnSetRealization_Click(sender, e)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnSetRealization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetRealization.Click
        Dim SubForm As New frmKreditRealization01
        Dim svcLoan As New Loan.svcLoan
        Dim strLoanId, strMemberId As String
        Dim strStatus, strPeriod As String
        Dim intTerm, intCount As Int32
        Dim dtTransferDate As Date
        Dim intTotalDebt As Int64
        Dim blnResult As Boolean
        Dim adoDS As DataSet
        Dim lvItem As ListViewItem

        Try
            If Me.lvwList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Item(0).SubItems(4).Text <> "+ANALIZED+" Then Exit Sub
            SubForm.Initialization(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text)
            SubForm.ShowDialog(Me)
            '||intTotalDebt should be a calculation of total debt
            intTotalDebt = CInt(SubForm.txtMontlyPay.Text) * CInt(SubForm.txtTerm.Text)

            dtTransferDate = SubForm.dtpTransferDate.Value
            strPeriod = SubForm.lblPeriod.Text
            intTerm = CInt(SubForm.txtTerm.Text)
            strLoanId = SubForm.lblLoanID.Text
            strMemberId = SubForm.txtMemberId.Text
            If SubForm.isCancelSave Then
                Exit Sub
            End If
            svcLoan.SetLoanRealization(strLoanId, strMemberId, intTerm, strPeriod, intTotalDebt, dtTransferDate, USER_ID, APP_ID)
            SubForm.Close()
            Refresh_ListView()

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(SubForm) Then
                SubForm.Dispose()
            End If
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim SubForm As New frmKreditRealization01
        Dim svcLoan As New Loan.svcLoan
        Dim strLoanId, strMemberId As String
        Dim strStatus, strPeriod As String
        Dim intCount As Int32
        Dim dtTransferDate As Date
        Dim intTotalDebt As Int64
        Dim blnResult As Boolean

        Try
            If Me.lvwList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Item(0).SubItems(4).Text <> "**TRANSACTION**" Then Exit Sub
            If MessageBox.Show("Are you sure to DELETE this realization ?", APP_NAME, _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
            blnResult = svcLoan.DeleteRealization(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text, _
                                                  Me.lvwList.SelectedItems.Item(0).SubItems(2).Text, APP_ID)
            If Not blnResult Then
                MessageBox.Show("Cannot cancel realization, transaction is already exist for this loan id.", "LOAN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
            Refresh_ListView()

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(SubForm) Then
                SubForm.Dispose()
            End If
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub Refresh_ListView()
        Dim svcLoan As New Loan.svcLoan
        Dim strDate, strStatus As String
        Dim lvItem As ListViewItem
        Dim intCount As Int16 = 1
        Dim adoDS As DataSet

        Try
            adoDS = svcLoan.GetMembershipAcctPeriod(APP_ID)
            strDate = adoDS.Tables(0).Rows(0).Item(0)
            Me.lvwList.Items.Clear()
            If Me.chkShowRealization.Checked Then
                '||>> Show all data <<||
                '||>> but include loan req that waiting realization & all the previous realization history <<||
                adoDS = svcLoan.GetWaitingRealization(Me.txtMemberId.Text.Trim, strDate, True, APP_ID)
            Else
                '||>> Show only data that are waiting to be set to realization status <<||
                adoDS = svcLoan.GetWaitingRealization(Me.txtMemberId.Text.Trim, strDate, False, APP_ID)
            End If

            If adoDS.Tables(0).Rows.Count = 0 Then
                lvwList.Items.Clear()
                MessageBox.Show("No record was selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            For Each adoRow As DataRow In adoDS.Tables(0).Rows
                lvItem = New ListViewItem(intCount.ToString.Trim & ".")
                lvItem.SubItems.Add(adoRow!LOAN_ID)
                lvItem.SubItems.Add(adoRow!MEMBERSHIP_NO)
                lvItem.SubItems.Add(adoRow!NAME)
                Select Case adoRow!STATUS
                    Case "R" 'Reviewed
                        strStatus = "+ANALIZED+"
                    Case "Y" 'Approved
                        strStatus = "**TRANSACTION**"
                    Case Else 'Not approved
                        strStatus = "REGISTERED"
                End Select
                lvItem.SubItems.Add(strStatus)
                lvItem.SubItems.Add(adoRow!ACCT_PERIOD)
                If NullToString(adoRow!AMOUNT) = "" Then
                    lvItem.SubItems.Add("-")
                Else
                    lvItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
                End If
                lvwList.Items.Add(lvItem)
                intCount += 1
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
