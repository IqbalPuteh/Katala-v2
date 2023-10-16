Public Class frmMembershipSaving
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
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipSaving))
        Me.btnClose = New System.Windows.Forms.Button
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(592, 408)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 288)
        Me.GroupBox2.TabIndex = 17
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
        Me.lvwList.Size = New System.Drawing.Size(668, 268)
        Me.lvwList.TabIndex = 5
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 34
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDateEnd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpDateStart)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Checked = False
        Me.dtpDateEnd.CustomFormat = "dd MMM yyyy"
        Me.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateEnd.Location = New System.Drawing.Point(320, 72)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.ShowCheckBox = True
        Me.dtpDateEnd.Size = New System.Drawing.Size(112, 21)
        Me.dtpDateEnd.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(264, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Date:"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.CustomFormat = "dd MMM yyyy"
        Me.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateStart.Location = New System.Drawing.Point(120, 72)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(96, 21)
        Me.dtpDateStart.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(58, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Start Date:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(224, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "lblName"
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Location = New System.Drawing.Point(120, 48)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(96, 21)
        Me.txtMemberId.TabIndex = 1
        Me.txtMemberId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Membership No.:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(496, 69)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 24)
        Me.btnSelect.TabIndex = 4
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
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(504, 408)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 18
        Me.btnPreview.Text = "&Preview"
        '
        'frmMembershipSaving
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(674, 440)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipSaving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Information - Review"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        If txtMemberId.Text = "" Then
            lblName.Text = ""
            btnSelect.Enabled = False
            lvwList.Items.Clear()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim recordcount As Int32
        Dim strTransDesc As String

        Try
            'If lblName.Text = "" Then Exit Sub
            lvwList.Items.Clear()
            If dtpDateEnd.Checked And (dtpDateEnd.Value < dtpDateStart.Value) Then
                MessageBox.Show("End date must be bigger than start date!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If dtpDateEnd.Checked Then
                adoDS = svcMembership.GetTransactionInfo(txtMemberId.Text, dtpDateStart.Value, dtpDateEnd.Value, APP_ID)
            Else
                adoDS = svcMembership.GetTransactionInfo(txtMemberId.Text, dtpDateStart.Value, Now.Date, APP_ID)
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If adoDS.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record was selected.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvwList.Items.Clear()
                btnPreview.Enabled = False
            Else
                btnPreview.Enabled = True
                recordcount = 0
                lvwList.Items.Clear()
                For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                    Dim lvwItem As New ListViewItem
                    lvwList.Items.Add(lvwItem)
                    recordcount = recordcount + 1
                    lvwItem.Text = recordcount.ToString
                    lvwItem.SubItems.Add(Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy"))
                    lvwItem.SubItems.Add(NullToString(adoRow!RESOURCE_DESC))
                    If adoRow!TRANSACTION_TYPE = "CR" Then
                        strTransDesc = "CREDIT"
                    Else
                        strTransDesc = "DEBET"
                    End If
                    lvwItem.SubItems.Add(strTransDesc)
                    lvwItem.SubItems.Add(Format(adoRow!AMOUNT, "#,##0"))
                    lvwItem.SubItems.Add(Format(adoRow!TOTAL, "#,##0"))
                Next
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try

    End Sub

    Private Sub frmMembershipSaving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblName.Text = ""
        btnSelect.Enabled = False
    End Sub

    Private Sub txtMemberId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMemberId.KeyDown
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet

        Try
            If e.KeyValue = Keys.Enter Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcMembership.GetMemberName(txtMemberId.Text, APP_ID)
                If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show("The Employee Name data is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnSelect.Enabled = False
                Else
                    lblName.Text = adoDS.Tables("MEMBERINFO").Rows(0)("FIRST_NAME") & " " & adoDS.Tables("MEMBERINFO").Rows(0)("FAMILY_NAME")
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    btnSelect.Enabled = True
                End If
                adoDS.Dispose()
                svcMembership.Dispose()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet
        Dim tempFile As New System.IO.FileInfo(Application.StartupPath & "\Reports\TEMP_MEMBERSHIP_SAVING.xls")
        Dim myForm As New frmMembershipSaving01

        Try
            If lvwList.Items.Count > 0 Then
                If MessageBox.Show("Are you sure to print the member saving?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Exit Sub
                End If
                If dtpDateEnd.Checked Then
                    adoDS = svcMembership.GetTransactionInfo(txtMemberId.Text, dtpDateStart.Value, dtpDateEnd.Value, APP_ID)
                Else
                    adoDS = svcMembership.GetTransactionInfo(txtMemberId.Text, dtpDateStart.Value, Now.Date, APP_ID)
                End If
                'Check file exits
                If tempFile.Exists Then
                    tempFile.Delete()
                End If
                'Generate_Report1(adoDS)
                myForm.Initialize(adoDS)
                myForm.ShowDialog(Me)
                myForm.Dispose()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
                svcMembership = Nothing
            End If
        End Try
    End Sub

    Private Sub Generate_Report1(ByVal adoDS As DataSet)
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
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\MEMBERSHIP_SAVING.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)
            xlWs.Cells(3, 3) = txtMemberId.Text & " - " & lblName.Text
            xlWs.Cells(4, 3) = Format(dtpDateStart.Value, "ddd, dd MMM yyyy")
            If dtpDateEnd.Checked Then
                xlWs.Cells(5, 3) = Format(dtpDateEnd.Value, "ddd, dd MMM yyyy")
            Else
                xlWs.Cells(5, 3) = Format(Now, "ddd, dd MMM yyyy")
            End If


            xlWs.Cells(3, 6) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 6) = Format(Now, "hh:mm tt")
            xlWs.Cells(5, 6) = USER_ID

            rowCount = 7
            intCount = 1
            For Each adoRow In adoDS.Tables(0).Rows
                xlWs.Cells(rowCount, 1) = "'" & intCount & "."
                xlWs.Cells(rowCount, 2) = Format(adoRow!TRANSACTION_DATE, "dd MMM yyyy")
                xlWs.Cells(rowCount, 3) = NullToString(adoRow!RESOURCE_DESC)
                If adoRow!TRANSACTION_TYPE = "CR" Then
                    strTransDesc = "CREDIT"
                Else
                    strTransDesc = "DEBET"
                End If
                xlWs.Cells(rowCount, 4) = strTransDesc
                xlWs.Cells(rowCount, 5) = Format(Format(adoRow!AMOUNT, "#,##0"))
                xlWs.Cells(rowCount, 6) = Format(adoRow!TOTAL, "#,##0")

                rowCount += 1
                intCount += 1
            Next

            rowCount = rowCount + 1
            xlApp.UserControl = False
            xlWb.Application.Visible = False
            xlWb.PrintOut()
            xlWb.SaveAs(Application.StartupPath & "\Reports\TEMP_MEMBERSHIP_SAVING.xls")
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
