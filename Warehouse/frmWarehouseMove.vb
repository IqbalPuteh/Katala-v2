Public Class frmWarehouseMove
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
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtDetail As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSummary As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWarehouseMove))
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTransDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtDetail = New System.Windows.Forms.RadioButton()
        Me.rbtSummary = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(413, 267)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 11
        Me.btnPreview.Text = "&Preview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(501, 267)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtDetail, Me.rbtSummary, Me.dtpEndDate, Me.Label9, Me.dtpStartDate, Me.lblTransDate, Me.Label1})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 264)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(224, 53)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpEndDate.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(201, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 14)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "To"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Checked = False
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(79, 53)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartDate.TabIndex = 1
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(16, 56)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(62, 14)
        Me.lblTransDate.TabIndex = 83
        Me.lblTransDate.Text = "Move Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(79, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please click on Preview button to view the report."
        '
        'rbtDetail
        '
        Me.rbtDetail.Location = New System.Drawing.Point(176, 88)
        Me.rbtDetail.Name = "rbtDetail"
        Me.rbtDetail.Size = New System.Drawing.Size(56, 16)
        Me.rbtDetail.TabIndex = 86
        Me.rbtDetail.Text = "Detail"
        '
        'rbtSummary
        '
        Me.rbtSummary.Checked = True
        Me.rbtSummary.Location = New System.Drawing.Point(80, 88)
        Me.rbtSummary.Name = "rbtSummary"
        Me.rbtSummary.Size = New System.Drawing.Size(80, 16)
        Me.rbtSummary.TabIndex = 85
        Me.rbtSummary.TabStop = True
        Me.rbtSummary.Text = "Summary"
        '
        'frmWarehouseMove
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(582, 291)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPreview, Me.btnClose, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWarehouseMove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse Movement - Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmWarehouseMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtpStartDate.Value = Now
            dtpEndDate.Value = Now
            rbtSummary.Checked = True
            rbtDetail.Checked = False

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse()
        Dim adoDS As New DataSet()

        Try
            If rbtSummary.Checked Then
                adoDS = svcWarehouse.GetMovementSummary(dtpStartDate.Value, dtpEndDate.Value, APP_ID)
                If adoDS.Tables("PO_MOVEMENT_SUMMARY").Rows.Count > 0 Then
                    Generate_Report_Summary(adoDS, dtpStartDate.Value, dtpEndDate.Value)
                    Exit Sub
                Else
                    MessageBox.Show("No Movement Made !", "Movement - Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                adoDS = svcWarehouse.GetMovementDetail(dtpStartDate.Value, dtpEndDate.Value, APP_ID)
                If adoDS.Tables("PO_MOVEMENT_DETAIL").Rows.Count > 0 Then
                    Generate_Report_Detail(adoDS, dtpStartDate.Value, dtpEndDate.Value)
                    Exit Sub
                Else
                    MessageBox.Show("No Movement Made !", "Movement - Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            btnPreview.Enabled = False
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub Generate_Report_Summary(ByVal adoDS As DataSet, ByVal dtStartDate As Date, ByVal dtEndDate As Date)
        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet

        Try

            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_MOVEMENT_SUMMARY.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 3) = Format(dtStartDate, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 3) = Format(dtEndDate, "ddd, dd MMM yyyy")
            xlWs.Cells(3, 6) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 6) = Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1

            For Each adoRow In adoDS.Tables("PO_MOVEMENT_SUMMARY").Rows
                xlWs.Cells(I, 1) = "'" & CStr(intNou) & "."
                xlWs.Cells(I, 2) = NullToString(adoRow!WH_SOURCE)
                xlWs.Cells(I, 3) = NullToString(adoRow!WH_DESTINATION)
                xlWs.Cells(I, 4) = "'" & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 5) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 6) = NullToString(adoRow!MOV_QTY)
                intNou += 1
                I = I + 1
            Next
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
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
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


    Private Sub Generate_Report_Detail(ByVal adoDS As DataSet, ByVal dtStartDate As Date, ByVal dtEndDate As Date)
        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet

        Try

            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_MOVEMENT_DETAIL.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 3) = Format(dtStartDate, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 3) = Format(dtEndDate, "ddd, dd MMM yyyy")
            xlWs.Cells(3, 10) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 10) = Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1

            For Each adoRow In adoDS.Tables("PO_MOVEMENT_DETAIL").Rows
                xlWs.Cells(I, 1) = "'" & CStr(intNou) & "."
                xlWs.Cells(I, 2) = Format(adoRow!MOV_DATE, "dd MMM yyyy")
                xlWs.Cells(I, 3) = "'" & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 4) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 5) = NullToString(adoRow!WH_SOURCE)
                xlWs.Cells(I, 6) = NullToString(adoRow!WH_DESTINATION)
                xlWs.Cells(I, 7) = NullToString(adoRow!MOV_QTY)
                xlWs.Cells(I, 8) = NullToString(adoRow!LEFT_QTY)
                xlWs.Cells(I, 9) = NullToString(adoRow!STOCK_QTY)
                xlWs.Cells(I, 10) = NullToString(adoRow!MOV_BY)
                intNou += 1
                I = I + 1
            Next
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 10)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
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
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

End Class

