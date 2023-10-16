Public Class frmRecieveRpt
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
    Friend WithEvents rbtDetail As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSummary As System.Windows.Forms.RadioButton
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecieveRpt))
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtDetail = New System.Windows.Forms.RadioButton
        Me.rbtSummary = New System.Windows.Forms.RadioButton
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.rbtDetail)
        Me.GroupBox1.Controls.Add(Me.rbtSummary)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 264)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'rbtDetail
        '
        Me.rbtDetail.Location = New System.Drawing.Point(185, 88)
        Me.rbtDetail.Name = "rbtDetail"
        Me.rbtDetail.Size = New System.Drawing.Size(56, 16)
        Me.rbtDetail.TabIndex = 4
        Me.rbtDetail.Text = "Detail"
        '
        'rbtSummary
        '
        Me.rbtSummary.Checked = True
        Me.rbtSummary.Location = New System.Drawing.Point(89, 88)
        Me.rbtSummary.Name = "rbtSummary"
        Me.rbtSummary.Size = New System.Drawing.Size(80, 16)
        Me.rbtSummary.TabIndex = 3
        Me.rbtSummary.TabStop = True
        Me.rbtSummary.Text = "Summary"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(234, 53)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpEndDate.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(212, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 17)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "To"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Checked = False
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(89, 53)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartDate.TabIndex = 1
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(14, 56)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(73, 17)
        Me.lblTransDate.TabIndex = 83
        Me.lblTransDate.Text = "Recieve Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(89, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please click on Preview button to view the report."
        '
        'frmRecieveRpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(584, 293)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecieveRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse Recieved PO - Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean

    Private Sub frmRecieveRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtpStartDate.Value = Now
            dtpEndDate.Value = Now
            rbtSummary.Checked = True
            rbtDetail.Checked = False
            blnCancel = False

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = False
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDS As New DataSet

        Try
            If rbtSummary.Checked Then
                adoDS = svcWarehouse.GetRecivedPOSummary(dtpStartDate.Value, dtpEndDate.Value, APP_ID)
                If adoDS.Tables("PO_REPORT_SUMMARY").Rows.Count > 0 Then
                    Generate_Report_Summary(adoDS, dtpStartDate.Value, dtpEndDate.Value)
                    Exit Sub
                Else
                    MessageBox.Show("No Recived PO data available !", "Recived PO - Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                adoDS = svcWarehouse.GetRecivedPODetail(dtpStartDate.Value, dtpEndDate.Value, APP_ID)
                If adoDS.Tables("PO_REPORT_DETAIL").Rows.Count > 0 Then
                    Generate_Report_Detail(adoDS, dtpStartDate.Value, dtpEndDate.Value)
                    Exit Sub
                Else
                    MessageBox.Show("No Recived PO data available !", "Recived PO - Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_RECEIVED_PO_SUMMARY.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)
            xlWs.Cells(5, 3) = Format(dtStartDate, "dd MMM yyyy") & " to " & Format(dtEndDate, "dd MMM yyyy")
            xlWs.Cells(3, 8) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 8) = Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1


            For Each adoRow In adoDS.Tables("PO_REPORT_SUMMARY").Rows
                xlWs.Cells(I, 1) = CInt(intNou) & "."
                xlWs.Cells(I, 2) = "'" & NullToString(adoRow!PO_NO)
                xlWs.Cells(I, 3) = NullToString(adoRow!SUPPLIER_NAME)
                xlWs.Cells(I, 4) = Format(adoRow!PO_DATE, "dd MMM yyyy")
                xlWs.Cells(I, 5) = IIf(NullToString(adoRow!PO_STATUS) = "O", "OPEN", "CLOSED")
                xlWs.Cells(I, 6) = NullToString(adoRow!RECIEVE_DATE)
                xlWs.Cells(I, 7) = NullToString(adoRow!RECIEVE_BY)
                I += 1
                intNou += 1
            Next
            I += 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
        Dim sngGrandTotal As Single
        Dim dtRecieveDate As Date
        Dim strCurrentPO As String
        Dim strPOStatus As String
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet

        Try

            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_RECEIVED_PO_DETAIL.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(5, 3) = Format(dtStartDate, "dd MMM yyyy") & " to " & Format(dtEndDate, "dd MMM yyyy")
            xlWs.Cells(3, 8) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 8) = Format(Now, "hh:mm:ss tt")
            I = 5
            intNou = 1

            strCurrentPO = ""

            For Each adoRow In adoDS.Tables("PO_REPORT_DETAIL").Rows
                If strCurrentPO <> NullToString(adoRow!PO_NO) Or _
                   Format(dtRecieveDate, "dd MMM yyyy") <> Format(adoRow!RECIEVE_DATE, "dd MMM yyyy") Then

                    I += 2
                    sngGrandTotal = 0
                    xlWs.Cells(I, 1) = "'" & CInt(intNou) & "."
                    xlWs.Cells(I, 2) = "'" & NullToString(adoRow!PO_NO)
                    strPOStatus = IIf(NullToString(adoRow!PO_STATUS) = "O", "OPEN", "CLOSED")
                    xlWs.Cells(I, 3) = strPOStatus
                    xlWs.Cells(I, 4) = NullToString(adoRow!SUPPLIER_NAME)
                    xlWs.Cells(I, 5) = Format(adoRow!RECIEVE_DATE, "dd MMM yyyy")
                    xlWs.Cells(I, 6) = NullToString(adoRow!RECIEVE_BY)
                    xlWs.Cells(I, 7) = NullToString(adoRow!RESOURCE_DESC)
                    xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

                    strCurrentPO = NullToString(adoRow!PO_NO)
                    dtRecieveDate = adoRow!RECIEVE_DATE

                    intNou += 1
                    I += 1
                    xlWs.Cells(I, 6) = "Item No."
                    xlWs.Cells(I, 7) = "Item Name"
                    xlWs.Cells(I, 8) = "QTY"
                    xlWs.Range(xlWs.Cells(I, 6), xlWs.Cells(I, 8)).Font.Bold = True
                    xlWs.Range(xlWs.Cells(I, 6), xlWs.Cells(I, 8)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
                    I += 1

                End If

                xlWs.Cells(I, 6) = "'" & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 7) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 8) = NullToString(adoRow!RECIEVE_QTY)
                sngGrandTotal = sngGrandTotal + adoRow!RECIEVE_QTY
                xlWs.Cells(I + 1, 7) = "Total : "
                xlWs.Cells(I + 1, 8) = sngGrandTotal
                I += 1

            Next
            I += 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Public Sub Initialize(ByVal strItemNo As String, ByVal strItemName As String)
        blnCancel = False
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function
End Class
