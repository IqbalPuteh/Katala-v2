Public Class frmReviewItemSales
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
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents rbKonOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rbAllItem As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonKon As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReviewItemSales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnPreview = New System.Windows.Forms.Button
        Me.rbKonOnly = New System.Windows.Forms.RadioButton
        Me.rbAllItem = New System.Windows.Forms.RadioButton
        Me.rbNonKon = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbKonOnly)
        Me.GroupBox1.Controls.Add(Me.rbAllItem)
        Me.GroupBox1.Controls.Add(Me.rbNonKon)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 112)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpStart
        '
        Me.dtpStart.Checked = False
        Me.dtpStart.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(104, 51)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(112, 21)
        Me.dtpStart.TabIndex = 0
        Me.dtpStart.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(35, 54)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(71, 17)
        Me.lblTransDate.TabIndex = 67
        Me.lblTransDate.Text = "Review Date:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(528, 48)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(48, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select sales review date then click on the select button to view information."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(104, 80)
        Me.txtItemCode.MaxLength = 20
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(152, 21)
        Me.txtItemCode.TabIndex = 2
        Me.txtItemCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(52, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(558, 393)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "&Close"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(-2, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 277)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Sales Average Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader6})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(636, 257)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "No."
        Me.ColumnHeader5.Width = 35
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item No"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Category"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Name"
        Me.ColumnHeader2.Width = 164
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Price"
        Me.ColumnHeader7.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty "
        Me.ColumnHeader3.Width = 40
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.Width = 110
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(472, 393)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 16
        Me.btnPreview.Text = "&Preview"
        '
        'rbKonOnly
        '
        Me.rbKonOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKonOnly.Location = New System.Drawing.Point(384, 79)
        Me.rbKonOnly.Name = "rbKonOnly"
        Me.rbKonOnly.TabIndex = 74
        Me.rbKonOnly.Text = "Konsinyasi Only"
        '
        'rbAllItem
        '
        Me.rbAllItem.Checked = True
        Me.rbAllItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAllItem.Location = New System.Drawing.Point(272, 79)
        Me.rbAllItem.Name = "rbAllItem"
        Me.rbAllItem.TabIndex = 73
        Me.rbAllItem.TabStop = True
        Me.rbAllItem.Text = "View All Item"
        '
        'rbNonKon
        '
        Me.rbNonKon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNonKon.Location = New System.Drawing.Point(496, 79)
        Me.rbNonKon.Name = "rbNonKon"
        Me.rbNonKon.TabIndex = 72
        Me.rbNonKon.Text = "Non Konsinyasi"
        '
        'frmReviewItemSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 424)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReviewItemSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Item Sales Per Day"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Hide()
    End Sub

    Private Sub frmReviewItemSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lvwList.Items.Clear()
        dtpStart.Value = Today
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcPos As New POS.svcPOS
        Dim adoDS As DataSet
        Dim intCount As Int16 = 1

        Try
            lvwList.Items.Clear()
            If Me.rbAllItem.Checked Then
                adoDS = svcPos.GetItemSalesPerDay(txtItemCode.Text.Trim, dtpStart.Value, 0, APP_ID)
            ElseIf Me.rbKonOnly.Checked Then
                adoDS = svcPos.GetItemSalesPerDay(txtItemCode.Text.Trim, dtpStart.Value, 1, APP_ID)
            Else
                adoDS = svcPos.GetItemSalesPerDay(txtItemCode.Text.Trim, dtpStart.Value, 2, APP_ID)
            End If
            If adoDS.Tables(0).Rows.Count > 0 Then
                For Each adoRow As DataRow In adoDS.Tables(0).Rows
                    Dim objItem As New ListViewItem

                    objItem.SubItems.Item(0).Text = intCount & "."
                    objItem.SubItems.Add(adoRow!ITEM_NO)
                    objItem.SubItems.Add(adoRow!ITEM_CAT)
                    objItem.SubItems.Add(adoRow!ITEM_NAME)
                    objItem.SubItems.Add(Format(adoRow!ITEM_PRICE, "N"))
                    objItem.SubItems.Add(adoRow!ITEM_SOLD)
                    objItem.SubItems.Add(Format(adoRow!TOTAL, "N"))
                    lvwList.Items.Add(objItem)
                    intCount += 1
                Next
                btnPreview.Enabled = True
            Else
                btnPreview.Enabled = False
                MessageBox.Show("There is no data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcPos) Then
                svcPos.Dispose()
                svcPos = Nothing
            End If
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcPos As New POS.svcPOS
        Dim adoDS As DataSet

        Try
            If lvwList.Items.Count > 0 Then
                If Me.rbAllItem.Checked Then
                    adoDS = svcPos.GetItemSalesPerDay(txtItemCode.Text.Trim, dtpStart.Value, 0, APP_ID)
                ElseIf Me.rbKonOnly.Checked Then
                    adoDS = svcPos.GetItemSalesPerDay(txtItemCode.Text.Trim, dtpStart.Value, 1, APP_ID)
                Else
                    adoDS = svcPos.GetItemSalesPerDay(txtItemCode.Text.Trim, dtpStart.Value, 2, APP_ID)
                End If
                Generate_Report1(adoDS)
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcPos) Then
                svcPos.Dispose()
                svcPos = Nothing
            End If
        End Try
    End Sub

    Private Sub Generate_Report1(ByVal adoDS As DataSet)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        Dim intCount As Int16 = 1
        Dim rowCount As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String
        Dim intRowContMin As Int16
        'Dim dblAmount As Double
        'Dim lngTotItem As Long

        Try
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\POS_ITEM_SALES_PERDAY.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 3) = Format(dtpStart.Value, "ddd, dd MMM yyyy")
            xlWs.Cells(3, 9) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 9) = Format(Now, "hh:mm tt")

            rowCount = 7
            intCount = 1
            For Each adoRow In adoDS.Tables(0).Rows
                xlWs.Cells(rowCount, 1) = "'" & intCount & "."
                xlWs.Cells(rowCount, 2) = "'" & adoRow!ITEM_NO
                xlWs.Cells(rowCount, 3) = adoRow!ITEM_NAME
                xlWs.Cells(rowCount, 4) = adoRow!ITEM_CAT
                'xlWs.Cells(rowCount, 5) = Format(adoRow!ITEM_PRICE, "N")
                'xlWs.Cells(rowCount, 6) = adoRow!ITEM_SOLD
                'xlWs.Cells(rowCount, 7) = Format(adoRow!TOTAL, "N")
                xlWs.Cells(rowCount, 5) = Format(adoRow!TOTAL, "N")
                xlWs.Cells(rowCount, 6) = adoRow!GROSS_PRICE
                xlWs.Cells(rowCount, 7) = adoRow!ITEM_PRICE
                xlWs.Cells(rowCount, 8) = CInt(adoRow!ITEM_SOLD) * CDbl(adoRow!GROSS_PRICE)
                xlWs.Cells(rowCount, 9) = CInt(adoRow!ITEM_SOLD) * CDbl(adoRow!ITEM_PRICE)

                rowCount += 1
                intCount += 1
            Next
            intRowContMin = rowCount - 1
            xlWs.Cells(rowCount, 8) = "=SUM(H7:H" & intRowContMin.ToString & ")"
            xlWs.Cells(rowCount, 9) = "=SUM(I7:I" & intRowContMin.ToString & ")"
            xlWs.Cells(rowCount, 10) = "=I" & rowCount.ToString & "-" & "H" & rowCount.ToString

            rowCount = rowCount + 3
            xlWs.Range(xlWs.Cells(rowCount, 1), xlWs.Cells(rowCount, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            rowCount = rowCount + 1
            xlWs.Range(xlWs.Cells(rowCount, 1), xlWs.Cells(rowCount, 10)).Merge()
            xlWs.Cells(rowCount, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(rowCount, 1), xlWs.Cells(rowCount, 10)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
