Public Class frmMembershipRptInstallment
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipRptInstallment))
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(424, 264)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "&Preview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(512, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpDate, Me.Label2, Me.Label1})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 256)
        Me.GroupBox1.TabIndex = 18
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
        'frmMembershipRptInstallment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(594, 294)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnPreview, Me.btnClose})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipRptInstallment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Installment Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            svcMembership.Timeout = -1
            adoDS = svcMembership.GetInstallmentInfo(dtpDate.Value, APP_ID)
            If adoDS.Tables("INSTALLMENT").Rows.Count = 0 Then
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
        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet
        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String

        Try
            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\MEMBER_INSTALLMENT.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 1) = "Period Date: " & Format(Now, "MMM yyyy")
            xlWs.Cells(3, 9) = "Print Date: " & Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 9) = "Print Time: " & Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1
            For Each adoRow In adoDS.Tables("INSTALLMENT").Rows
                xlWs.Cells(I, 1) = CInt(intNou) & "."
                xlWs.Cells(I, 2) = NullToString(adoRow!MEMBERSHIP_NO)
                xlWs.Cells(I, 3) = NullToString(adoRow!FIRST_NAME) & " " & NullToString(adoRow!FAMILY_NAME)
                xlWs.Cells(I, 4) = NullToString(adoRow!RESOURCE_DESC)
                xlWs.Cells(I, 5) = IIf(NullToString(adoRow!MEMBER_TYPE) = "NAT", "National", "Expat")
                xlWs.Cells(I, 6) = NullToString(adoRow!STAFF_TYPE)
                xlWs.Cells(I, 7) = NullToString(adoRow!MEMBERSHIP_DATE)
                If (CInt(CStr(adoRow!DEDUCTION_PERIOD).Substring(0, 4)) = CInt(dtpDate.Value.Year) And CInt(CStr(adoRow!DEDUCTION_PERIOD).Substring(5)) = CInt(dtpDate.Value.Month)) Then
                    xlWs.Cells(I, 8) = Format(CSng(adoRow!POKOK), "##,##0")
                Else
                    xlWs.Cells(I, 8) = Format(CSng("0"), "##,##0")
                End If
                xlWs.Cells(I, 9) = Format(CSng(adoRow!WAJIB), "##,##0")
                xlWs.Cells(I, 10) = Format(adoRow!SUKARELA, "##,##0")
                I = I + 1
                intNou = intNou + 1
            Next

            I = I + 1
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 10)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

            I = I + 1
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 10)).Merge()
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 10)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

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
        btnPreview.Enabled = True
    End Sub
End Class
