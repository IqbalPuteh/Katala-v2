Option Compare Text

Public Class frmMembershipRptInstallmentSummary
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
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipRptInstallmentSummary))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpDate, Me.Label2, Me.Label1})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 256)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MMM yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(136, 56)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShowUpDown = True
        Me.dtpDate.Size = New System.Drawing.Size(88, 21)
        Me.dtpDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(92, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Period:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select option below and click on Preview button to view the report."
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(416, 264)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 19
        Me.btnPreview.Text = "&Preview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(504, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "&Close"
        '
        'frmMembershipRptInstallmentSummary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(592, 292)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnPreview, Me.btnClose})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipRptInstallmentSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members Installment Summary Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            svcMembership.Timeout = -1
            adoDS = svcMembership.GetMemberInstallmentSummary(Format(dtpDate.Value, "yyyyMM"), APP_ID)
            If adoDS.Tables("TRANSACTION").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("No record selected with selected options.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Generate_Report(adoDS)
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (svcMembership Is Nothing) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report(ByVal adoDS As DataSet)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        'Dim xlApp As Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet

        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim adoRow1 As DataRow
        Dim strTemplate As String
        Dim strMemberNo As String
        Dim intPokok As Int64
        Dim intWajib As Int64
        Dim intSukarela As Int64
        Dim intBunga As Int64
        Dim intPokokTot As Int64
        Dim intWajibTot As Int64
        Dim intSukarelaTot As Int64
        Dim intBungaTot As Int64

        Try
            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\MEMBER_INSTALLMENT_SUMMARY.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(4, 1) = "Period : " & Format(dtpDate.Value, "MMM yyyy")
            xlWs.Cells(3, 8) = "Print Date: " & Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 8) = "Print Time: " & Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1
            strMemberNo = ""
            intPokok = 0
            intWajib = 0
            intSukarela = 0
            intBunga = 0
            intPokokTot = 0
            intWajibTot = 0
            intSukarelaTot = 0
            intBungaTot = 0

            For Each adoRow In adoDS.Tables("TRANSACTION").Rows
                If strMemberNo <> adoRow!MEMBERSHIP_NO Then
                    If (intPokok + intWajib + intSukarela) <> 0 Then
                        xlWs.Cells(I, 1) = intNou & "."
                        xlWs.Cells(I, 2) = NullToString(adoRow1!MEMBERSHIP_NO)
                        xlWs.Cells(I, 3) = NullToString(adoRow1!FIRST_NAME) & " " & NullToString(adoRow1!FAMILY_NAME)
                        xlWs.Cells(I, 4) = IIf(adoRow1!ACTIVE_STATUS = "A", "ACTIVE", "NOT ACTIVE")
                        xlWs.Cells(I, 5) = Format(intPokok, "#,##0")
                        xlWs.Cells(I, 6) = Format(intWajib, "#,##0")
                        xlWs.Cells(I, 7) = Format(intSukarela, "#,##0")
                        xlWs.Cells(I, 8) = Format(intBunga, "#,##0")
                        xlWs.Cells(I, 9) = Format(intPokok + intWajib + intSukarela + intBunga, "#,##0")
                        I = I + 1
                        intNou = intNou + 1
                    End If
                    adoRow1 = adoRow
                    strMemberNo = adoRow!MEMBERSHIP_NO
                    intPokok = 0
                    intWajib = 0
                    intSukarela = 0
                    intBunga = 0
                End If
                Dim strCase As String
                strCase = Convert.ToString(adoRow!TRANSACTION_CODE)
                Select Case strCase
                    Case "POKOK", "POKOKDB"
                        intPokok = intPokok + adoRow!amount
                        intPokokTot = intPokokTot + adoRow!amount
                    Case "WAJIB", "WAJIBDB", "305", "306"
                        intWajib = intWajib + adoRow!amount
                        intWajibTot = intWajibTot + adoRow!amount
                    Case "BUNGA", "SHUBUNGA"
                        intBunga = intBunga + adoRow!amount
                        intBungaTot = intBungaTot + adoRow!amount
                    Case "SUKARELA"
                        intSukarela = intSukarela + adoRow!amount
                        intSukarelaTot = intSukarelaTot + adoRow!amount
                    Case Else
                        intSukarela = intSukarela + adoRow!amount
                        intSukarelaTot = intSukarelaTot + adoRow!amount
                End Select
            Next
            If (intPokok + intWajib + intSukarela) <> 0 Then
                xlWs.Cells(I, 1) = intNou & "."
                xlWs.Cells(I, 2) = NullToString(adoRow1!MEMBERSHIP_NO)
                xlWs.Cells(I, 3) = NullToString(adoRow1!FIRST_NAME) & " " & NullToString(adoRow1!FAMILY_NAME)
                xlWs.Cells(I, 4) = IIf(adoRow1!ACTIVE_STATUS = "A", "ACTIVE", "NOT ACTIVE")
                xlWs.Cells(I, 5) = Format(intPokok, "#,##0")
                xlWs.Cells(I, 6) = Format(intWajib, "#,##0")
                xlWs.Cells(I, 7) = Format(intSukarela, "#,##0")
                xlWs.Cells(I, 8) = Format(intBunga, "#,##0")
                xlWs.Cells(I, 9) = Format(intPokok + intWajib + intSukarela + intBunga, "#,##0")
            End If

            I = I + 2
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Cells(I, 1) = "Total:"
            xlWs.Cells(I, 5) = Format(intPokokTot, "#,##0")
            xlWs.Cells(I, 6) = Format(intWajibTot, "#,##0")
            xlWs.Cells(I, 7) = Format(intSukarelaTot, "#,##0")
            xlWs.Cells(I, 8) = Format(intBungaTot, "#,##0")
            xlWs.Cells(I, 9) = Format(intPokokTot + intWajibTot + intSukarelaTot + intBungaTot, "#,##0")

            I = I + 2
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 9)).Merge()
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

    Private Sub frmMembershipRptMemberList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcMembership As New Membership.svcMembership
        Dim adoDS As New DataSet
        Dim adoRow As DataRow

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
            dtpDate.MaxDate = DateSerial(Mid(adoRow!ACCT_PERIOD, 1, 4), Mid(adoRow!ACCT_PERIOD, 5, 2), 1)
            dtpDate.Value = dtpDate.MaxDate
            btnPreview.Enabled = True
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            GroupBox1.Enabled = False
            btnPreview.Enabled = False
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
End Class
