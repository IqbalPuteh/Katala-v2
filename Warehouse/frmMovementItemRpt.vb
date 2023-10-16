Public Class frmMovementItemRpt
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMovementItemRpt))
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
        Me.btnPreview.Location = New System.Drawing.Point(411, 269)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "&Preview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(499, 269)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 15
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
        Me.GroupBox1.Size = New System.Drawing.Size(582, 264)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
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
        Me.Label9.Size = New System.Drawing.Size(17, 17)
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
        Me.lblTransDate.Size = New System.Drawing.Size(62, 17)
        Me.lblTransDate.TabIndex = 83
        Me.lblTransDate.Text = "Move Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(79, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please click on Preview button to view the report."
        '
        'frmMovementItemRpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(582, 296)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovementItemRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse Movement - Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean

    Public Sub Initialize(ByVal Cancel As Boolean)
        blnCancel = Cancel
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub frmMovementItemRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        blnCancel = False
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDS As New DataSet

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

            xlWs.Cells(5, 3) = Format(dtStartDate, "dd MMM yyyy") & " to " & Format(dtEndDate, "dd MMM yyyy")
            xlWs.Cells(3, 6) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 6) = Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1

            For Each adoRow In adoDS.Tables("PO_MOVEMENT_SUMMARY").Rows
                xlWs.Cells(I, 1) = "'" & CStr(intNou) & "."
                xlWs.Cells(I, 2) = NullToString(adoRow!MOV_BY)
                xlWs.Cells(I, 3) = Format(adoRow!MOV_DATE, "dd/MMM/yyyy")
                xlWs.Cells(I, 4) = IIf(NullToString(adoRow!MOV_STATUS) = "O", "OPEN", "CLOSED")
                xlWs.Cells(I, 5) = NullToString(adoRow!WAREHOUSE_TARGET)
                xlWs.Cells(I, 6) = NullToString(adoRow!TOTAL_QTY)
                intNou += 1
                I = I + 1
            Next
            I += 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

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
        Dim intMovId As Integer
        Dim lngTotalQTY As Integer
        Dim intItemNo As Integer
        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet

        Try

            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_MOVEMENT_DETAIL.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(5, 3) = Format(dtStartDate, "dd MMM yyyy") & " to " & Format(dtEndDate, "dd MMM yyyy")
            xlWs.Cells(3, 9) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 9) = Format(Now, "hh:mm:ss tt")
            I = 5
            intNou = 1

            For Each adoRow In adoDS.Tables("PO_MOVEMENT_DETAIL").Rows
                If intMovId <> CInt(adoRow!MOV_ID) Then
                    I += 2
                    intMovId = adoRow!MOV_ID
                    lngTotalQTY = 0
                    intItemNo = 1
                    xlWs.Cells(I, 1) = "'" & CStr(intNou) & "."
                    xlWs.Cells(I, 2) = NullToString(adoRow!MOV_BY)
                    xlWs.Cells(I, 3) = Format(adoRow!MOV_DATE, "dd MMM yyyy")
                    xlWs.Cells(I, 4) = IIf(NullToString(adoRow!MOV_STATUS) = "O", "OPEN", "CLOSED")
                    xlWs.Cells(I, 5) = NullToString(adoRow!WH_SOURCE)
                    xlWs.Cells(I, 6) = NullToString(adoRow!WH_DESTINATION)
                    xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
                    intNou += 1
                    I += 1

                    xlWs.Cells(I, 7) = "Item No."
                    xlWs.Cells(I, 8) = "Item Name"
                    xlWs.Cells(I, 9) = "Move QTY"
                    xlWs.Range(xlWs.Cells(I, 7), xlWs.Cells(I, 9)).Font.Bold = True
                    xlWs.Range(xlWs.Cells(I, 7), xlWs.Cells(I, 9)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
                    I += 1

                End If
                xlWs.Cells(I, 7) = "'" & intItemNo & ". " & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 8) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 9) = NullToString(adoRow!MOV_QTY)
                lngTotalQTY = lngTotalQTY + CInt(adoRow!MOV_QTY)
                xlWs.Cells(I + 1, 8) = "Total Move QTY : "
                xlWs.Cells(I + 1, 9) = CInt(lngTotalQTY)
                intItemNo += 1
                I += 1

            Next
            I += 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
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
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
