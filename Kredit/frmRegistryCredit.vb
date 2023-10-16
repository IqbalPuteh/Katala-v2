Public Class frmRegistryCredit
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
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboKreditType As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboRegPeriod As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRegistryCredit))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnSelect = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboRegPeriod = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboKreditType = New System.Windows.Forms.ComboBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
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
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 272)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Credit Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Membership No."
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 192
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Registry Date"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 115
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(528, 70)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
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
        Me.Label3.Location = New System.Drawing.Point(21, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Register for Period:"
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(597, 412)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(509, 412)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 4
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(421, 412)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 3
        Me.btnAddNew.Text = "&Add New"
        '
        'frmRegistryCredit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(682, 440)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAddNew)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistryCredit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Loan Registration Screen"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private arrStrKreditTypeCode() As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Dispose()
    End Sub

    Private Sub frmRegistryCredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As New DataSet
        Dim intCount As Int16 = 2
        Dim dtDate As Date
        Dim strDate As String

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
            dtDate = DateSerial(strDate.Substring(0, 4), strDate.Substring(4), 1)
            dtDate = dtDate.AddYears(-1)
            For intCount = 0 To 2
                dtDate = dtDate.AddYears(1)
                cboRegPeriod.Items.Add(CType(dtDate.Year, String))
                If dtDate.Year = Now.Year Then cboRegPeriod.SelectedIndex = intCount
            Next
            cboRegPeriod.Items.Add("ALL")

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
            adoDS = svcKredit.GetLoanRegistration(Me.txtMemberId.Text.Trim, strRegPeriod, strCreditType, strLoanId, APP_ID)
            If adoDS.Tables(0).Rows.Count = 0 Then
                Me.btnModify.Enabled = False
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
                        strStatus = "**REALIZATION**"
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
            Me.btnModify.Enabled = True
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
        btnModify.Enabled = False
        lvwList.Items.Clear()
    End Sub

    Private Sub cboKreditType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKreditType.SelectedIndexChanged

        btnModify.Enabled = False
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
                    MessageBox.Show("The Member Name data is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim frmSubForm As New frmRegistryCredit01
        Dim svcKredit As New Loan.svcLoan
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim adoRow As DataRow

        Try
            If Me.lvwList.SelectedIndices.Count = 0 Then
                Exit Sub
            End If
            'If Me.lvwList.SelectedItems.Item(0).SubItems(5).Text <> "REGISTERED" Then
            '    MessageBox.Show("Cannot modify loan registration with status other than 'REGISTERED'", "Info", _
            '                     MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            '    Exit Sub
            'End If
            adoDS = svcKredit.GetRegistrationStatusDetail(Me.lvwList.SelectedItems.Item(0).SubItems(1).Text, APP_ID)
            frmSubForm.InitializeForm()
            frmSubForm.FillField(adoDS)
            frmSubForm.ShowDialog(Me)
            If Not frmSubForm.isCancelSave Then
                adoDS = frmSubForm.GetDataSet
                svcKredit.ModifyRegistration(adoDS, APP_ID)
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
            If Not IsNothing(svcKredit) Then
                svcKredit.Dispose()
                svcKredit = Nothing
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim adoDS As New DataSet
        Dim frmSubForm As New frmRegistryCredit01
        Dim svcKredit As New Loan.svcLoan

        Try
            If lblName.Text.Trim = "" Then
                MessageBox.Show("Please type the Membership #, if you want to add new registration data. ", APP_NAME, MessageBoxButtons.OK)
                Exit Sub
            End If
            frmSubForm.InitializeForm(Me.txtMemberId.Text)
            frmSubForm.ShowDialog(Me)
            If Not frmSubForm.isCancelSave Then
                adoDS = frmSubForm.GetDataSet
                svcKredit.AddLoanRegistration(adoDS, APP_ID)
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
        End Try
    End Sub

    Private Sub frmRegistryCredit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        txtMemberId.Focus()
    End Sub

    'Private Sub txtMemberId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberId.Leave

    '    If Trim(txtMemberId.Text) <> "" Then
    '        txtMemberId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
    '    End If
    'End Sub

    Private Sub cboRegPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegPeriod.SelectedIndexChanged

        btnModify.Enabled = False
        lvwList.Items.Clear()
    End Sub
End Class
