Public Class frmMembershipRptIndividual
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
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblActiveStatus As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipRptIndividual))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblActiveStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(512, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(424, 264)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 13
        Me.btnPreview.Text = "&Preview"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblActiveStatus, Me.Label5, Me.lblName, Me.txtMemberId, Me.Label2, Me.Label3})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 256)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Criteria"
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(120, 80)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(90, 14)
        Me.lblActiveStatus.TabIndex = 7
        Me.lblActiveStatus.Text = "lblActiveStatus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(45, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Active Status:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(232, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 14)
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
        Me.txtMemberId.TabIndex = 1
        Me.txtMemberId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Membership No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(409, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Please enter the options below and click on preview to view the report."
        '
        'frmMembershipRptIndividual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(594, 294)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.btnClose, Me.btnPreview})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipRptIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Individual Members Information - Report"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As DataSet
        Dim adoDS01 As DataSet
        Dim sngTotalSaving As Single
        Dim sngSSRate As Single
        Dim sngNSrate As Single

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcMembership.GetMemberInfo(txtMemberId.Text, "", APP_ID)

            If adoDS.Tables("MEMBERINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("No record selected with selected options.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                svcMembership.Timeout = -1
                sngTotalSaving = svcMembership.GetTotalSaving(txtMemberId.Text, APP_ID)

                adoDS01 = svcMembership.GetMemberSystemInfo(APP_ID)
                Generate_Report(adoDS, adoDS01, sngTotalSaving)
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (adoDS01 Is Nothing) Then
                adoDS01.Dispose()
            End If
            If Not (svcMembership Is Nothing) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report(ByVal adoDS As DataSet, ByVal adoDS01 As DataSet, ByVal sngTotalSaving As Single)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        'Dim xlApp As Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet
        'Dim intNou As Int16
        'Dim I As Int16
        Dim adoRow As DataRow
        Dim adoRow01 As DataRow
        Dim strTemplate As String
        Dim sngTotalCapital As Single

        Try
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\MEMBER_INFO.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            adoRow = adoDS.Tables("MEMBERINFO").Rows(0)
            adoRow01 = adoDS01.Tables(0).Rows(0)

            xlWs.Cells(3, 2) = xlWs.Cells(3, 2).Text & Format(adoRow!ENTRY_DATE, "dd MMM yyyy")
            xlWs.Cells(4, 2) = xlWs.Cells(4, 2).Text & IIf(NullToString(adoRow!MEMBERSHIP_STATUS) = "NEW", "Tidak", "Ya")
            xlWs.Cells(6, 2) = xlWs.Cells(6, 2).Text & Format(adoRow!MEMBERSHIP_DATE, "dd MMM yyyy")
            xlWs.Cells(7, 2) = xlWs.Cells(7, 2).Text & Format(sngTotalSaving, "##,##0")

            If NullToString(adoRow!MEMBER_TYPE) = "NAT" Then
                xlWs.Cells(12, 1) = "' >>"
                xlWs.Cells(12, 1).font.bold = True
                xlWs.Cells(12, 2).font.bold = True
                sngTotalCapital = adoRow01!POKOK_NT + adoRow01!WAJIB_NT + adoRow!SUKARELA

            Else
                xlWs.Cells(13, 1) = "' >>"
                xlWs.Cells(13, 1).font.bold = True
                xlWs.Cells(13, 2).font.bold = True
                sngTotalCapital = adoRow01!POKOK_EX + adoRow01!WAJIB_EX + adoRow!SUKARELA
            End If

            If NullToString(adoRow!STAFF_TYPE) = "STAFF" Then
                xlWs.Cells(18, 1) = "' >>"
                xlWs.Cells(18, 1).font.bold = True
                xlWs.Cells(18, 2).font.bold = True
            Else
                xlWs.Cells(19, 1) = "' >>"
                xlWs.Cells(19, 1).font.bold = True
                xlWs.Cells(19, 2).font.bold = True
            End If
            xlWs.Cells(18, 3) = ("'- Bunga " & NullToString(adoRow01!INTEREST_SS) & "% per tahun")
            xlWs.Cells(19, 3) = ("'- Bunga " & NullToString(adoRow01!INTEREST_NS) & "% per tahun")
            xlWs.Cells(20, 5) = "'Rp. " & Format(sngTotalCapital, "##,##0")


            xlWs.Cells(23, 1) = xlWs.Cells(23, 1).Text & NullToString(adoRow!FIRST_NAME)
            xlWs.Cells(23, 5) = xlWs.Cells(23, 5).Text & NullToString(adoRow!FAMILY_NAME)

            xlWs.Cells(24, 1) = xlWs.Cells(24, 1).Text & NullToString(adoRow!BADGE_ID)
            xlWs.Cells(24, 5) = xlWs.Cells(24, 5).Text & NullToString(adoRow!DEPARTMENT_NAME)

            xlWs.Cells(25, 1) = xlWs.Cells(25, 1).Text & NullToString(adoRow!HOME_ADDRESS)
            xlWs.Cells(26, 1) = xlWs.Cells(26, 1).Text & NullToString(adoRow!CITY)

            xlWs.Cells(27, 1) = xlWs.Cells(27, 1).Text & NullToString(adoRow!POSTAL_CODE)
            xlWs.Cells(27, 5) = xlWs.Cells(27, 5).Text & NullToString(adoRow!PROVINCE)

            xlWs.Cells(28, 1) = xlWs.Cells(28, 1).Text & NullToString(adoRow!CAMP_ADDRESS)

            xlWs.Cells(29, 1) = xlWs.Cells(29, 1).Text & NullToString(adoRow!OFFICE_PHONE)
            xlWs.Cells(29, 5) = xlWs.Cells(29, 5).Text & NullToString(adoRow!EMAIL)

            xlWs.Cells(30, 1) = xlWs.Cells(30, 1).Text & NullToString(adoRow!HOME_PHONE)
            xlWs.Cells(30, 5) = xlWs.Cells(30, 5).Text & NullToString(adoRow!CELL_PHONE)


            xlApp.UserControl = True
            xlWb.Application.Visible = True
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWb) Then
                    xlWb.Close(False)
                End If
                xlApp.Application.Quit()
            End If
            Err.Clear()
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
            xlWb = Nothing
            xlWs = Nothing
        End Try
    End Sub

    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        lblName.Text = ""
        lblActiveStatus.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub frmMembershipRptIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblActiveStatus.Text = ""
        lblName.Text = ""
        btnPreview.Enabled = False
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
                    MessageBox.Show("The Member Name data is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnPreview.Enabled = False
                    Exit Sub
                Else
                    lblName.Text = adoDS.Tables("MEMBERINFO").Rows(0)("FIRST_NAME") & " " & adoDS.Tables("MEMBERINFO").Rows(0)("FAMILY_NAME")
                    lblActiveStatus.Text = IIf(adoDS.Tables("MEMBERINFO").Rows(0)("ACTIVE_STATUS") = "A", "ACTIVE", "NOT ACTIVE")
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    btnPreview.Enabled = True
                End If
                adoDS.Dispose()
                svcMembership.Dispose()
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
