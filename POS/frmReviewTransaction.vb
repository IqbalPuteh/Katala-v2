'Imports System.Globalization

Public Class frmReviewTransaction
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMembershipNo As System.Windows.Forms.TextBox
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReviewTransaction))
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtVoucherNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMembershipNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(557, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnView
        '
        Me.btnView.Enabled = False
        Me.btnView.Location = New System.Drawing.Point(469, 394)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(80, 24)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "&View"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 256)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master Transaction"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(635, 236)
        Me.lvwList.TabIndex = 6
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Trans Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "POS Id"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Membership No."
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Voucher No."
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Grand Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVoucherNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMembershipNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 136)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtVoucherNo.Location = New System.Drawing.Point(104, 98)
        Me.txtVoucherNo.MaxLength = 20
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(160, 21)
        Me.txtVoucherNo.TabIndex = 4
        Me.txtVoucherNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Voucher No.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEnd
        '
        Me.dtpEnd.Checked = False
        Me.dtpEnd.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(255, 48)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowCheckBox = True
        Me.dtpEnd.Size = New System.Drawing.Size(129, 21)
        Me.dtpEnd.TabIndex = 2
        Me.dtpEnd.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(234, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "To"
        '
        'dtpStart
        '
        Me.dtpStart.Checked = False
        Me.dtpStart.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(104, 48)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowCheckBox = True
        Me.dtpStart.Size = New System.Drawing.Size(128, 21)
        Me.dtpStart.TabIndex = 1
        Me.dtpStart.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(35, 51)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(67, 17)
        Me.lblTransDate.TabIndex = 62
        Me.lblTransDate.Text = "Trans. Date:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(528, 96)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(50, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the options below then click on the select button to view transaction inf" & _
        "ormation."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMembershipNo
        '
        Me.txtMembershipNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMembershipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMembershipNo.Location = New System.Drawing.Point(104, 73)
        Me.txtMembershipNo.MaxLength = 10
        Me.txtMembershipNo.Name = "txtMembershipNo"
        Me.txtMembershipNo.Size = New System.Drawing.Size(88, 21)
        Me.txtMembershipNo.TabIndex = 3
        Me.txtMembershipNo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Membership No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReviewTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(640, 421)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReviewTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review POS Transaction"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmReviewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity

        Try
            'Application.CurrentCulture = New CultureInfo("de-DE")

            dtpStart.Value = Now
            dtpEnd.Value = Now
            dtpStart.Checked = True
            dtpEnd.Checked = True
            dtpStart.Checked = False
            dtpEnd.Checked = False

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "POS", APP_ID)
            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnView.Enabled = True
            Else
                btnView.Enabled = False
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnView_Click(sender, e)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcPOS As New POS.svcPOS
        Dim myDS As New DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim strTransID As String
        Dim strStartDate As String
        Dim strEndDate As String

        Try
            svcPOS.Timeout = -1
            If dtpStart.Checked = True And _
                dtpEnd.Checked = True Then
                If dtpStart.Value > dtpEnd.Value Then
                    MessageBox.Show("Start Date must be equal or bigger than End Date. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            If dtpStart.Checked = True Then
                strStartDate = Format(dtpStart.Value, "yyyy-MM-dd")
            Else
                strStartDate = ""
            End If
            If dtpEnd.Checked = True Then
                strEndDate = Format(dtpEnd.Value, "yyyy-MM-dd")
            Else
                strEndDate = ""
            End If

            myDS = svcPOS.GetHeader(strStartDate, strEndDate, txtMembershipNo.Text, txtVoucherNo.Text, APP_ID)

            If myDS.Tables("HEADER").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("HEADER").Rows

                    strTransID = adoRow!TRANS_ID
                    objItem = New ListViewItem(strTransID)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adoRow!TRANS_DATE, "dd-MMM-yyyy, hh:mm tt"))
                    objItem.SubItems.Add(adoRow!POS_ID)
                    objItem.SubItems.Add(NullToString(adoRow!MEMBERSHIP_NO))
                    objItem.SubItems.Add(NullToString(adoRow!VOUCHER_NO))
                    If adoRow!AMOUNT = 0 Then
                        objItem.SubItems.Add("0.00")
                    ElseIf Not IsDBNull(adoRow!AMOUNT) Then
                        objItem.SubItems.Add(Format(adoRow!AMOUNT, "##,##0"))
                    End If
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Transaction data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnView.Enabled = True
            Else
                btnView.Enabled = False
            End If
            If lvwList.Items.Count > 15 Then
                lvwList.Columns(1).Width = 164
            Else
                lvwList.Columns(1).Width = 180
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (svcPOS Is Nothing) Then
                svcPOS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim svcPOS As New POS.svcPOS
        Dim adoDSHeader As New DataSet
        Dim adoDSDetail As New DataSet
        Dim myForm As New frmReviewTransaction01
        Dim adoRow As DataRow
        Dim strTransId As String

        Try
            svcPOS.Timeout = -1
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            strTransId = lvwList.SelectedItems.Item(0).SubItems(0).Text
            adoDSHeader = svcPOS.GetTransHeader(strTransId, APP_ID)
            adoDSDetail = svcPOS.GetTransDetail(strTransId, APP_ID)
            myForm.FillField(adoDSHeader, adoDSDetail)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

Form_Loop:
            myForm.ShowDialog()

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcPOS Is Nothing) Then
                svcPOS.Dispose()
            End If
            If Not (adoDSHeader Is Nothing) Then
                adoDSHeader.Dispose()
            End If
            If Not (adoDSDetail Is Nothing) Then
                adoDSDetail.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtMembershipNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembershipNo.TextChanged
        lvwList.Items.Clear()
        btnView.Enabled = False
    End Sub

    Private Sub txtVoucherNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoucherNo.TextChanged
        lvwList.Items.Clear()
        btnView.Enabled = False
    End Sub

    Private Sub frmReviewTransaction_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        lvwList.Items.Clear()
        btnView.Enabled = False
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        lvwList.Items.Clear()
        btnView.Enabled = False
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnView_Click(sender, e)
            End If
        End If
    End Sub
End Class
