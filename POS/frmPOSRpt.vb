Public Class frmPOSRpt
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
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtDay02 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDay01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtMonth01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtHour As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtHourTime02 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtHourTime01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rbtDays As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rbtHours As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grbSales As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalItem As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPOSRpt))
        Me.grbSales = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGrandTotal = New System.Windows.Forms.TextBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtHourTime02 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtHourTime01 = New System.Windows.Forms.DateTimePicker
        Me.dtHour = New System.Windows.Forms.DateTimePicker
        Me.dtMonth01 = New System.Windows.Forms.DateTimePicker
        Me.rbtHours = New System.Windows.Forms.RadioButton
        Me.rbtDays = New System.Windows.Forms.RadioButton
        Me.rbtMonth = New System.Windows.Forms.RadioButton
        Me.dtDay02 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtDay01 = New System.Windows.Forms.DateTimePicker
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotalItem = New System.Windows.Forms.TextBox
        Me.grbSales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSales
        '
        Me.grbSales.Controls.Add(Me.Label5)
        Me.grbSales.Controls.Add(Me.txtTotalItem)
        Me.grbSales.Controls.Add(Me.Label2)
        Me.grbSales.Controls.Add(Me.txtGrandTotal)
        Me.grbSales.Controls.Add(Me.lvwList)
        Me.grbSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbSales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbSales.ForeColor = System.Drawing.Color.Blue
        Me.grbSales.Location = New System.Drawing.Point(0, 136)
        Me.grbSales.Name = "grbSales"
        Me.grbSales.Size = New System.Drawing.Size(638, 296)
        Me.grbSales.TabIndex = 12
        Me.grbSales.TabStop = False
        Me.grbSales.Text = "Sales Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(440, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Total Amount:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.White
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Enabled = False
        Me.txtGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(528, 268)
        Me.txtGrandTotal.MaxLength = 12
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGrandTotal.Size = New System.Drawing.Size(108, 21)
        Me.txtGrandTotal.TabIndex = 14
        Me.txtGrandTotal.Text = "0"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(2, 19)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(635, 245)
        Me.lvwList.TabIndex = 13
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pos Id."
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total Item"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "User"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Amount"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtHourTime02)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtHourTime01)
        Me.GroupBox1.Controls.Add(Me.dtHour)
        Me.GroupBox1.Controls.Add(Me.dtMonth01)
        Me.GroupBox1.Controls.Add(Me.rbtHours)
        Me.GroupBox1.Controls.Add(Me.rbtDays)
        Me.GroupBox1.Controls.Add(Me.rbtMonth)
        Me.GroupBox1.Controls.Add(Me.dtDay02)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtDay01)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtHourTime02
        '
        Me.dtHourTime02.Checked = False
        Me.dtHourTime02.CustomFormat = "HH:mm:ss"
        Me.dtHourTime02.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHourTime02.Location = New System.Drawing.Point(388, 98)
        Me.dtHourTime02.Name = "dtHourTime02"
        Me.dtHourTime02.ShowUpDown = True
        Me.dtHourTime02.Size = New System.Drawing.Size(104, 21)
        Me.dtHourTime02.TabIndex = 10
        Me.dtHourTime02.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(366, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "To"
        '
        'dtHourTime01
        '
        Me.dtHourTime01.Checked = False
        Me.dtHourTime01.CustomFormat = "HH:mm:ss"
        Me.dtHourTime01.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHourTime01.Location = New System.Drawing.Point(260, 98)
        Me.dtHourTime01.Name = "dtHourTime01"
        Me.dtHourTime01.ShowUpDown = True
        Me.dtHourTime01.Size = New System.Drawing.Size(104, 21)
        Me.dtHourTime01.TabIndex = 9
        Me.dtHourTime01.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'dtHour
        '
        Me.dtHour.Checked = False
        Me.dtHour.CustomFormat = "dd-MMM-yyyy"
        Me.dtHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHour.Location = New System.Drawing.Point(128, 98)
        Me.dtHour.Name = "dtHour"
        Me.dtHour.Size = New System.Drawing.Size(104, 21)
        Me.dtHour.TabIndex = 8
        Me.dtHour.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'dtMonth01
        '
        Me.dtMonth01.Checked = False
        Me.dtMonth01.CustomFormat = "MMM-yyyy"
        Me.dtMonth01.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtMonth01.Location = New System.Drawing.Point(128, 50)
        Me.dtMonth01.Name = "dtMonth01"
        Me.dtMonth01.ShowUpDown = True
        Me.dtMonth01.Size = New System.Drawing.Size(104, 21)
        Me.dtMonth01.TabIndex = 2
        Me.dtMonth01.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'rbtHours
        '
        Me.rbtHours.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtHours.ForeColor = System.Drawing.Color.Black
        Me.rbtHours.Location = New System.Drawing.Point(40, 96)
        Me.rbtHours.Name = "rbtHours"
        Me.rbtHours.Size = New System.Drawing.Size(72, 24)
        Me.rbtHours.TabIndex = 7
        Me.rbtHours.Text = "Per Hours"
        '
        'rbtDays
        '
        Me.rbtDays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDays.ForeColor = System.Drawing.Color.Black
        Me.rbtDays.Location = New System.Drawing.Point(40, 72)
        Me.rbtDays.Name = "rbtDays"
        Me.rbtDays.Size = New System.Drawing.Size(72, 24)
        Me.rbtDays.TabIndex = 4
        Me.rbtDays.Text = "Per Days"
        '
        'rbtMonth
        '
        Me.rbtMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMonth.ForeColor = System.Drawing.Color.Black
        Me.rbtMonth.Location = New System.Drawing.Point(40, 48)
        Me.rbtMonth.Name = "rbtMonth"
        Me.rbtMonth.Size = New System.Drawing.Size(80, 24)
        Me.rbtMonth.TabIndex = 1
        Me.rbtMonth.Text = "Per Month"
        '
        'dtDay02
        '
        Me.dtDay02.Checked = False
        Me.dtDay02.CustomFormat = "dd-MMM-yyyy"
        Me.dtDay02.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDay02.Location = New System.Drawing.Point(260, 74)
        Me.dtDay02.Name = "dtDay02"
        Me.dtDay02.Size = New System.Drawing.Size(104, 21)
        Me.dtDay02.TabIndex = 6
        Me.dtDay02.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(236, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "To"
        '
        'dtDay01
        '
        Me.dtDay01.Checked = False
        Me.dtDay01.CustomFormat = "dd-MMM-yyyy"
        Me.dtDay01.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDay01.Location = New System.Drawing.Point(128, 74)
        Me.dtDay01.Name = "dtDay01"
        Me.dtDay01.Size = New System.Drawing.Size(104, 21)
        Me.dtDay01.TabIndex = 5
        Me.dtDay01.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(528, 87)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 32)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(40, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the options below then click on the select button to view sales informati" & _
        "on."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(555, 437)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(472, 437)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "&Preview"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(256, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Total Item:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalItem
        '
        Me.txtTotalItem.BackColor = System.Drawing.Color.White
        Me.txtTotalItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalItem.Enabled = False
        Me.txtTotalItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItem.Location = New System.Drawing.Point(328, 268)
        Me.txtTotalItem.MaxLength = 12
        Me.txtTotalItem.Name = "txtTotalItem"
        Me.txtTotalItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalItem.Size = New System.Drawing.Size(96, 21)
        Me.txtTotalItem.TabIndex = 109
        Me.txtTotalItem.Text = "0"
        '
        'frmPOSRpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(638, 464)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grbSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOSRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Sales - Report"
        Me.grbSales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPOSRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            rbtMonth.Checked = True
            dtMonth01.Value = Now
            dtMonth01.Enabled = True

            dtDay01.Value = Now
            dtDay02.Value = Now
            dtDay01.Enabled = False
            dtDay02.Enabled = False

            dtHourTime01.Value = Now
            dtHourTime02.Value = Now
            dtHour.Enabled = False
            dtHourTime01.Enabled = False
            dtHourTime02.Enabled = False

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub rbtMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMonth.CheckedChanged
        If rbtMonth.Checked = True Then
            lvwList.Items.Clear()
            txtGrandTotal.Text = ""
            btnPreview.Enabled = False

            dtMonth01.Enabled = True

            dtDay01.Value = Now
            dtDay02.Value = Now
            dtDay01.Enabled = False
            dtDay02.Enabled = False

            dtHour.Enabled = False
            dtHour.Value = Now
            dtHourTime01.Value = Now
            dtHourTime02.Value = Now
            dtHourTime01.Enabled = False
            dtHourTime02.Enabled = False
        End If
    End Sub

    Private Sub rbtDays_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDays.CheckedChanged
        If rbtDays.Checked = True Then
            lvwList.Items.Clear()
            txtGrandTotal.Text = ""
            btnPreview.Enabled = False

            dtMonth01.Value = Now
            dtMonth01.Enabled = False

            dtDay01.Enabled = True
            dtDay02.Enabled = True

            dtHour.Enabled = False
            dtHourTime01.Value = Now
            dtHourTime02.Value = Now
            dtHourTime01.Enabled = False
            dtHourTime02.Enabled = False
        End If
    End Sub

    Private Sub rbtHours_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtHours.CheckedChanged
        If rbtHours.Checked = True Then
            lvwList.Items.Clear()
            txtGrandTotal.Text = ""
            btnPreview.Enabled = False

            dtMonth01.Value = Now
            dtMonth01.Enabled = False

            dtDay01.Value = Now
            dtDay02.Value = Now
            dtDay01.Enabled = False
            dtDay02.Enabled = False

            dtHour.Enabled = True
            dtHourTime01.Enabled = True
            dtHourTime02.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim svcPOS As New POS.svcPOS
        Dim myDS As New DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim dblAmount As Double
        Dim dblTotalAmount As Double
        Dim lngTotalItem As Long

        Try
            svcWarehouse.Timeout = -1
            svcPOS.Timeout = -1
            If rbtDays.Checked Then
                If dtDay01.Value > dtDay02.Value Then
                    MessageBox.Show("Start Date must be less or equal then End Date.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If rbtHours.Checked Then
                If dtHourTime01.Value > dtHourTime02.Value Then
                    MessageBox.Show("Start Time must be less or equal then End Time.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            If rbtMonth.Checked Then
                Dim strMonth01 As String
                Dim strMonth02 As String
                Dim DTTEMP As Date

                DTTEMP = DateSerial(Year(dtMonth01.Value), Month(dtMonth01.Value), 1)

                strMonth01 = Format(DTTEMP, "dd/MM/yyyy")
                DTTEMP = DateAdd(DateInterval.Month, 1, DTTEMP)
                DTTEMP = DateAdd(DateInterval.Day, -1, DTTEMP)
                strMonth02 = Format(DTTEMP, "dd/MM/yyyy")

                myDS = svcPOS.GetSumSalesPerMonth(strMonth01, strMonth02, APP_ID)
            ElseIf rbtDays.Checked Then
                Dim strDate01 As String
                Dim strDate02 As String

                strDate01 = Format(dtDay01.Value, "dd/MM/yyyy")
                strDate02 = Format(DateAdd(DateInterval.Day, 1, dtDay02.Value), "dd/MM/yyyy")

                myDS = svcPOS.GetSumSalesPerDays(strDate01, strDate02, APP_ID)
            ElseIf rbtHours.Checked Then
                Dim strDat01 As String
                Dim strDat02 As String
                Dim strHour01 As String
                Dim strHour02 As String

                strDat01 = Format(dtHour.Value, "dd/MM/yyyy")
                strDat02 = Format(DateAdd(DateInterval.Day, 1, dtHour.Value), "dd/MM/yyyy")
                strHour01 = Format(dtHourTime01.Value, "HH:mm:ss")
                strHour02 = Format(dtHourTime02.Value, "HH:mm:ss")
                myDS = svcPOS.GetSumSalesPerHours(strDat01, strDat02, strHour01, strHour02, APP_ID)
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            txtGrandTotal.Text = ""
            txtTotalItem.Text = ""

            If myDS.Tables("SalesReport").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("SalesReport").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    'objItem.SubItems.Add(adoRow!TRANS_ID)
                    objItem.SubItems.Add(Format(adoRow!TRANS_DATE, "dd MMM yyyy"))
                    objItem.SubItems.Add(Format(adoRow!TRANS_DATE, "hh:mm:ss tt"))
                    objItem.SubItems.Add(adoRow!POS_ID)
                    objItem.SubItems.Add(adoRow!TOTAL_ITEM)
                    objItem.SubItems.Add(adoRow!CREATED_BY)
                    objItem.SubItems.Add(Format(adoRow!AMOUNT, "##0"))
                    objItem.Selected = True

                    dblAmount = dblAmount + adoRow!AMOUNT
                    lngTotalItem = lngTotalItem + adoRow!TOTAL_ITEM
                Next
                txtTotalItem.Text = lngTotalItem
                txtGrandTotal.Text = dblAmount
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Item data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnPreview.Enabled = True
            Else
                btnPreview.Enabled = False
            End If
            'If lvwList.Items.Count > 15 Then
            '    lvwList.Columns(2).Width = 214
            'Else
            '    lvwList.Columns(2).Width = 230
            'End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub dtDay01_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDay01.ValueChanged
        lvwList.Items.Clear()
        txtGrandTotal.Text = ""
        txtTotalItem.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub dtDay02_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDay02.ValueChanged
        lvwList.Items.Clear()
        txtGrandTotal.Text = ""
        txtTotalItem.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub dtHour_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtHour.ValueChanged
        lvwList.Items.Clear()
        txtGrandTotal.Text = ""
        txtTotalItem.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub dtMonth01_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtMonth01.ValueChanged
        lvwList.Items.Clear()
        txtGrandTotal.Text = ""
        txtTotalItem.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub dtHourTime01_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtHourTime01.ValueChanged
        lvwList.Items.Clear()
        txtGrandTotal.Text = ""
        txtTotalItem.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub dtHourTime02_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtHourTime02.ValueChanged
        lvwList.Items.Clear()
        txtGrandTotal.Text = ""
        txtTotalItem.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcPos As New POS.svcPOS
        Dim myDS As New DataSet

        Try
            svcPos.Timeout = -1
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If

            If rbtDays.Checked Then
                If dtDay01.Value > dtDay02.Value Then
                    MessageBox.Show("Start Date must be less or equal then End Date.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If rbtHours.Checked Then
                If dtHourTime01.Value > dtHourTime02.Value Then
                    MessageBox.Show("Start Time must be less or equal then End Time.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            If rbtMonth.Checked Then
                Dim strMonth01 As String
                Dim strMonth02 As String
                Dim DTTEMP As Date

                DTTEMP = DateSerial(Year(dtMonth01.Value), Month(dtMonth01.Value), 1)

                strMonth01 = Format(DTTEMP, "dd/MM/yyyy")
                DTTEMP = DateAdd(DateInterval.Month, 1, DTTEMP)
                DTTEMP = DateAdd(DateInterval.Day, -1, DTTEMP)
                strMonth02 = Format(DTTEMP, "dd/MM/yyyy")

                myDS = svcPos.GetSumSalesPerMonth(strMonth01, strMonth02, APP_ID)
            ElseIf rbtDays.Checked Then
                Dim strDate01 As String
                Dim strDate02 As String

                strDate01 = Format(dtDay01.Value, "dd/MM/yyyy")
                strDate02 = Format(DateAdd(DateInterval.Day, 1, dtDay02.Value), "dd/MM/yyyy")

                myDS = svcPos.GetSumSalesPerDays(strDate01, strDate02, APP_ID)
            ElseIf rbtHours.Checked Then
                Dim strDat01 As String
                Dim strDat02 As String
                Dim strHour01 As String
                Dim strHour02 As String

                strDat01 = Format(dtHour.Value, "dd/MM/yyyy")
                strDat02 = Format(DateAdd(DateInterval.Day, 1, dtHour.Value), "dd/MM/yyyy")
                strHour01 = Format(dtHourTime01.Value, "HH:mm:ss")
                strHour02 = Format(dtHourTime02.Value, "HH:mm:ss")
                myDS = svcPos.GetSumSalesPerHours(strDat01, strDat02, strHour01, strHour02, APP_ID)
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Generate_Report1(myDS)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report1(ByVal DSSales As DataSet)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String
        Dim dblAmount As Double
        Dim lngTotItem As Long

        Try
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\POS_SALES_SUMMARY.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 9) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 9) = Format(Now, "hh:mm tt")

            I = 7
            intNou = 1
            For Each adoRow In DSSales.Tables("SalesReport").Rows
                xlWs.Cells(I, 1) = intNou
                xlWs.Cells(I, 2) = adoRow!TRANS_ID
                xlWs.Cells(I, 3) = Format(adoRow!TRANS_DATE, "dd MMM yyyy")
                xlWs.Cells(I, 4) = Format(adoRow!TRANS_DATE, "hh:mm:ss tt")
                xlWs.Cells(I, 5) = adoRow!POS_ID
                xlWs.Cells(I, 6) = adoRow!CREATED_BY
                xlWs.Cells(I, 7) = adoRow!TOTAL_ITEM
                xlWs.Cells(I, 8) = adoRow!AMOUNT

                I = I + 1
                intNou = intNou + 1
                dblAmount = dblAmount + adoRow!AMOUNT
                lngTotItem = lngTotItem + adoRow!TOTAL_ITEM
            Next

            I = I + 2
            xlWs.Cells(I, 6) = "Total: "
            xlWs.Cells(I, 7) = lngTotItem
            xlWs.Cells(I, 8) = dblAmount
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

            I = I + 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            I = I + 1
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlApp.UserControl = True
            xlWb.Application.Visible = True

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
