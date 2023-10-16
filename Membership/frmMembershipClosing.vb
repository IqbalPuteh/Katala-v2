Public Class frmMembershipClosing
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAcctPeriod As System.Windows.Forms.Label
    Friend WithEvents lblNextAcctPeriod As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAdministrationFee As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipClosing))
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNextAcctPeriod = New System.Windows.Forms.Label
        Me.lblCurrentAcctPeriod = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnProcess = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAdministrationFee = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(512, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAdministrationFee)
        Me.GroupBox1.Controls.Add(Me.lblNextAcctPeriod)
        Me.GroupBox1.Controls.Add(Me.lblCurrentAcctPeriod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 256)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Closing Parameters"
        '
        'lblNextAcctPeriod
        '
        Me.lblNextAcctPeriod.AutoSize = True
        Me.lblNextAcctPeriod.ForeColor = System.Drawing.Color.Blue
        Me.lblNextAcctPeriod.Location = New System.Drawing.Point(168, 80)
        Me.lblNextAcctPeriod.Name = "lblNextAcctPeriod"
        Me.lblNextAcctPeriod.Size = New System.Drawing.Size(106, 17)
        Me.lblNextAcctPeriod.TabIndex = 14
        Me.lblNextAcctPeriod.Text = "lblNextAcctPeriod"
        '
        'lblCurrentAcctPeriod
        '
        Me.lblCurrentAcctPeriod.AutoSize = True
        Me.lblCurrentAcctPeriod.ForeColor = System.Drawing.Color.Blue
        Me.lblCurrentAcctPeriod.Location = New System.Drawing.Point(168, 56)
        Me.lblCurrentAcctPeriod.Name = "lblCurrentAcctPeriod"
        Me.lblCurrentAcctPeriod.Size = New System.Drawing.Size(123, 17)
        Me.lblCurrentAcctPeriod.TabIndex = 13
        Me.lblCurrentAcctPeriod.Text = "lblCurrentAcctPeriod"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Next Accounting Period:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Current Accounting Period:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select option below and click on process button."
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(424, 264)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(80, 24)
        Me.btnProcess.TabIndex = 1
        Me.btnProcess.Text = "&Process"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Administration Fee per Period:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAdministrationFee
        '
        Me.lblAdministrationFee.AutoSize = True
        Me.lblAdministrationFee.ForeColor = System.Drawing.Color.Blue
        Me.lblAdministrationFee.Location = New System.Drawing.Point(168, 104)
        Me.lblAdministrationFee.Name = "lblAdministrationFee"
        Me.lblAdministrationFee.Size = New System.Drawing.Size(123, 17)
        Me.lblAdministrationFee.TabIndex = 16
        Me.lblAdministrationFee.Text = "lblAdministrationFee"
        '
        'frmMembershipClosing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(594, 294)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProcess)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipClosing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership - Close Accounting Period"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmMembershipClosing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcMembership As New Membership.svcMembership()
        Dim adoDS As New DataSet()
        Dim intYear As Integer
        Dim intMonth As Integer

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)

            lblCurrentAcctPeriod.Text = adoDS.Tables("MEMBERINFO").Rows(0)!ACCT_PERIOD
            intYear = Mid(lblCurrentAcctPeriod.Text, 1, 4)
            intMonth = Mid(lblCurrentAcctPeriod.Text, 5, 2)
            If intMonth = 12 Then
                intMonth = 1
                intYear = intYear + 1
            Else
                intMonth = intMonth + 1
            End If
            lblNextAcctPeriod.Text = intYear & Microsoft.VisualBasic.Right("0" & intMonth, 2)

            adoDS = svcMembership.GetMemberSystemInfo(APP_ID)
            Me.lblAdministrationFee.Text = "Rp. " & Format(adoDS.Tables("MEMBERINFO").Rows(0)!ADMIN_FEE, "#,##0")

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            GroupBox1.Enabled = False
            btnProcess.Enabled = False
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

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim svcMembership As New Membership.svcMembership()

        Try
            If MessageBox.Show("Are you sure want to process this?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                svcMembership.Timeout = -1
                svcMembership.MembershipClosingProcess(lblCurrentAcctPeriod.Text, lblNextAcctPeriod.Text, USER_ID, APP_ID)

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Closing process has completed.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Me.Dispose()
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
