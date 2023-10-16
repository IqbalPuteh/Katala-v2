Public Class frmMembershipLoanDeduction
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipLoanDeduction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPath = New System.Windows.Forms.Button
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnProcess = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnPath)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cboPeriod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 152)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upload Criteria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(120, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Kredit - Sheet 1, Start Row # 2, Coloum B,C,D,E."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(56, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 35
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
        Me.txtPath.Size = New System.Drawing.Size(416, 21)
        Me.txtPath.TabIndex = 2
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
        'cboPeriod
        '
        Me.cboPeriod.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.Location = New System.Drawing.Point(120, 48)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(88, 21)
        Me.cboPeriod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Accounting Period:"
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
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 320)
        Me.GroupBox2.TabIndex = 46
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
        Me.lvwList.Size = New System.Drawing.Size(580, 300)
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
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "XLS"
        Me.OpenFileDialog.Filter = "Excel Document (*.XLS)|*.XLS"
        Me.OpenFileDialog.InitialDirectory = "C:\"
        Me.OpenFileDialog.Title = "Payroll Deduction File"
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(416, 492)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(80, 24)
        Me.btnProcess.TabIndex = 44
        Me.btnProcess.Text = "&Process"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(40, 496)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 17)
        Me.lblTotal.TabIndex = 48
        Me.lblTotal.Text = "lblTotal"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 496)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 17)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Total:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(504, 492)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 45
        Me.btnClose.Text = "&Close"
        '
        'frmMembershipLoanDeduction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(586, 520)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipLoanDeduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Upload Loan Deduction Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsTransaction As New DataSet
    Dim alcboSHUType As New ArrayList
    Dim strPeriod As String

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Function CreateRS() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn
        Dim adoTable As DataTable

        adoTable = New DataTable("LOAN_DEDUCTION")
        adoDS.Tables.Add(adoTable)

        adoColumn = New DataColumn("BADGE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TRANSACTION_CODE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("INFO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)


        CreateRS = adoDS
    End Function

    Private Sub frmMembershipLoanDeduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As New DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            cboPeriod.Items.Clear()
            cboPeriod.Items.Add(adoDS.Tables("MEMBERINFO").Rows(0)!ACCT_PERIOD)
            cboPeriod.SelectedIndex = 0

            lblTotal.Text = 0
        Catch ex As Exception
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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

    Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPath.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            txtPath.Text = OpenFileDialog.FileName()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim xlApp As Object
        Dim xlWB As Object
        Dim xlWS As Object
        Dim I As Integer
        Dim strBadgeId As String
        Dim strName As String
        Dim intAmount As Int64
        Dim strTransInfo As String
        Dim intTotal As Int64
        Dim objItem As ListViewItem
        Dim adoRow As DataRow
        Dim adoTbl As New DataTable

        Try
            If Dir(txtPath.Text, FileAttribute.Normal) = "" Then
                MessageBox.Show("File name is not found.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            xlApp = CreateObject("Excel.Application")

            '//@ Open copied file //
            '//@ Sheet #1 //
            xlWB = xlApp.Workbooks.Open(txtPath.Text)
            xlWS = xlWB.Worksheets(1)

            dsTransaction = CreateRS()
            adoTbl = dsTransaction.Tables("LOAN_DEDUCTION")

            I = 2
            strBadgeId = xlWS.Cells(I, 2).Text
            intTotal = 0
            lvwList.Items.Clear()
            While strBadgeId <> ""
                strBadgeId = xlWS.Cells(I, 2).Text
                strName = xlWS.Cells(I, 3).Text
                intAmount = xlWS.Cells(I, 4).Text
                strTransInfo = xlWS.Cells(I, 5).Text
                intTotal = intTotal + intAmount
                lblTotal.Text = Format(intTotal, "#,##0")
                lblTotal.Refresh()

                objItem = New ListViewItem(lvwList.Items.Count + 1)
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(strBadgeId)
                objItem.SubItems.Add(strName)
                objItem.SubItems.Add(Format(intAmount, "#,##0"))

                adoRow = adoTbl.NewRow()
                adoRow!BADGE_ID = strBadgeId
                adoRow!AMOUNT = intAmount
                adoRow!TRANSACTION_CODE = strTransInfo
                Select Case strTransInfo
                    Case "301"
                        adoRow!INFO = "Ang Pinjaman Khusus."
                    Case "302"
                        adoRow!INFO = "Ang Pinjaman Reguler."
                    Case "303"
                        adoRow!INFO = "Ang Kewajiban Barang."
                    Case "304"
                        adoRow!INFO = "Kewajiban lain-lain."
                    Case Else
                        adoRow!INFO = "Kewajiban lain-lain."

                End Select
                adoTbl.Rows.Add(adoRow)

                If lvwList.Items.Count > 21 Then
                    lvwList.Columns(3).Width = 119
                End If

                I = I + 1
                strBadgeId = xlWS.Cells(I, 2).Text
            End While

            lblTotal.Text = Format(intTotal, "#,##0")

            If lvwList.Items.Count > 0 Then
                btnProcess.Enabled = True
            Else
                btnProcess.Enabled = False
            End If
            xlWB.Close()

            xlApp.Application.Quit()
            xlApp = Nothing
            xlWB = Nothing
            xlWS = Nothing
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWB) Then
                    xlWB.Close(False)
                End If
                xlApp.Application.Quit()
                xlApp = Nothing
                xlWB = Nothing
                xlWS = Nothing
            End If
            Err.Clear()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim svcMembership As New Membership.svcMembership
        Dim strResult As String

        Try
            If MessageBox.Show("Are you sure want to upload these transactions?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                svcMembership.Timeout = -1
                strResult = svcMembership.UploadLoanDeduction(dsTransaction, cboPeriod.Text, USER_ID, APP_ID)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                If strResult = "" Then
                    MessageBox.Show("Upload process has been completed.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MessageBox.Show(strResult.Remove(strResult.Length - 1, 1) & ".", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
        End Try
    End Sub
End Class
