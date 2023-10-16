Public Class frmKreditUploadData
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
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKreditUploadData))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPath = New System.Windows.Forms.Button
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPeriod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnPath)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 136)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upload Criteria"
        '
        'cboPeriod
        '
        Me.cboPeriod.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.Location = New System.Drawing.Point(120, 48)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(88, 21)
        Me.cboPeriod.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Accounting Period:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(120, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Excel - Sheet 2, Start Row # 2, Coloum B."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(60, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "File Notes:"
        '
        'btnPath
        '
        Me.btnPath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath.ForeColor = System.Drawing.Color.Blue
        Me.btnPath.Location = New System.Drawing.Point(536, 72)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(21, 21)
        Me.btnPath.TabIndex = 3
        Me.btnPath.Text = "..."
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPath.Location = New System.Drawing.Point(120, 72)
        Me.txtPath.MaxLength = 50
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(416, 21)
        Me.txtPath.TabIndex = 2
        Me.txtPath.TabStop = False
        Me.txtPath.Text = "C:\"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(46, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 17)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "File Location:"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Blue
        Me.btnSelect.Location = New System.Drawing.Point(448, 104)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 344)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction List"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(596, 324)
        Me.lvwList.TabIndex = 5
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Badge Id"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 136
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(432, 488)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(80, 24)
        Me.btnProcess.TabIndex = 43
        Me.btnProcess.Text = "&Process"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(520, 488)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "&Close"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(40, 488)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 17)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "lblTotal"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 488)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 17)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Total:"
        '
        'frmKreditUploadData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(602, 520)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKreditUploadData"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Loan Payment Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsTransaction As New DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Dispose()
    End Sub

    Private Sub frmMembershipUploadTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcLoan As New Loan.svcLoan
        Dim strAcctPeriod As String
        Dim adoDS As New DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcLoan.GetAcctPeriod(APP_ID)
            strAcctPeriod = adoDS.Tables(0).Rows(0)!ACCT_PERIOD
            cboPeriod.Items.Clear()
            cboPeriod.Items.Add(CType(strAcctPeriod, String))
            cboPeriod.SelectedIndex = 0
            lblTotal.Text = 0
            Me.btnProcess.Enabled = False

        Catch ex As Exception
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPath.Click

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            txtPath.Text = OpenFileDialog.FileName()
        End If

    End Sub

    Private Function CreateRS() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn
        Dim adoTable As DataTable

        adoTable = New DataTable("LOANPAYMENT")
        adoDS.Tables.Add(adoTable)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.Int32")
        adoTable.Columns.Add(adoColumn)

        CreateRS = adoDS
    End Function

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcMembership As New Membership.svcMembership
        Dim xlApp As Excel.Application
        Dim xlWB As Excel.Workbook
        Dim xlWS As Excel.Worksheet
        Dim objItem As ListViewItem
        Dim adoTbl As New DataTable
        Dim adoDS As DataSet
        Dim strBadgeId As String
        Dim strName As String
        Dim sngAmount As Single
        Dim intAmount As Int64
        Dim intTotal As Int64
        Dim adoRow As DataRow
        Dim I As Integer

        Try
            If cboPeriod.SelectedItem = "" Then
                MessageBox.Show("Please select Upload period first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboPeriod.Focus()
                Exit Sub
            End If

            If (txtPath.Text.ToUpper = "C:\") Or Dir(txtPath.Text, FileAttribute.Normal) = "" Then
                MessageBox.Show("File name is not found.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Application.DoEvents()
            xlApp = CreateObject("Excel.Application")
            xlWB = xlApp.Workbooks.Open(txtPath.Text)
            xlWS = xlWB.Worksheets.Item(2)
            Application.DoEvents()
            dsTransaction = CreateRS()
            adoTbl = dsTransaction.Tables("LOANPAYMENT")

            I = 2
            strBadgeId = xlWS.Cells(I, 2).Text
            intTotal = 0
            lvwList.Items.Clear()
            While strBadgeId <> ""
                Application.DoEvents()
                Me.Refresh()
                strBadgeId = xlWS.Cells(I, 2).Text
                adoDS = svcMembership.GetDetailMemberInfo(strBadgeId.Trim, APP_ID)
                If adoDS.Tables(0).Rows.Count > 0 Then
                    strName = NullToString(adoDS.Tables(0).Rows(0).Item("FIRST_NAME")) & " " & _
                              NullToString(adoDS.Tables(0).Rows(0).Item("FAMILY_NAME"))
                    'strName = xlWS.Cells(I, 4).Text
                Else
                    strName = "."
                End If
                sngAmount = xlWS.Cells(I, 5).Text
                intAmount = CType(sngAmount, Int64)
                intTotal = intTotal + intAmount
                lblTotal.Text = Format(intTotal, "#,##0")
                lblTotal.Refresh()

                objItem = New ListViewItem(lvwList.Items.Count + 1 & ".")
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(strBadgeId)
                objItem.SubItems.Add(strName)
                objItem.SubItems.Add(Format(intAmount, "#,##0"))

                adoRow = adoTbl.NewRow()
                adoRow!MEMBERSHIP_NO = strBadgeId
                adoRow!AMOUNT = intAmount
                adoTbl.Rows.Add(adoRow)

                If lvwList.Items.Count > 21 Then
                    lvwList.Columns(3).Width = 119
                End If

                I = I + 1
                strBadgeId = xlWS.Cells(I, 3).Text
            End While
            lblTotal.Text = Format(intTotal, "#,##0")
            If lvwList.Items.Count > 0 Then
                btnProcess.Enabled = True
            Else
                btnProcess.Enabled = False
            End If
            xlWB.Close()
            xlApp.Application.Quit()
            ReleaseComObject(xlWB)
            ReleaseComObject(xlWS)
            ReleaseComObject(xlApp)
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWB) Then
                    xlWB.Close(False)
                End If
                xlApp.Application.Quit()
                ReleaseComObject(xlWB)
                ReleaseComObject(xlWS)
                ReleaseComObject(xlApp)
            End If
            Err.Clear()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        lvwList.Items.Clear()
        btnProcess.Enabled = False
        lblTotal.Text = 0
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim myForm As New frmKreditUploadData01
        Dim svcLoan As New Loan.svcLoan
        Dim strResult As String

        Try
            If MessageBox.Show("Are you sure want to upload these transactions?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                svcLoan.Timeout = -1
                strResult = svcLoan.UploadLoanPayment(dsTransaction, cboPeriod.Text, USER_ID, APP_ID)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                If strResult = "" Then
                    MessageBox.Show("Upload process has been completed.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    myForm.txtMessage.Text = strResult.Remove(strResult.Length - 1, 1) & "."
                    myForm.ShowDialog(Me)
                    myForm.Close()
                End If
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
            If Not IsNothing(myForm) Then
                myForm.Dispose()
            End If

        End Try
    End Sub
End Class
