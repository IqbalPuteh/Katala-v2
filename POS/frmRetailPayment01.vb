Public Class frmRetailPayment01
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
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblTitleLast As System.Windows.Forms.Label
    Friend WithEvents grpReturnDetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMemberStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents txtTransId As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRetailPayment01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.lblTitleLast = New System.Windows.Forms.Label
        Me.grpReturnDetail = New System.Windows.Forms.GroupBox
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboMemberStatus = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTransId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.NumericUpDown
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.grpReturnDetail.SuspendLayout()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(71, 397)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(69, 17)
        Me.lblLastUpdate.TabIndex = 44
        Me.lblLastUpdate.Text = "LastUpdate"
        '
        'lblTitleLast
        '
        Me.lblTitleLast.AutoSize = True
        Me.lblTitleLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLast.ForeColor = System.Drawing.Color.Black
        Me.lblTitleLast.Location = New System.Drawing.Point(7, 397)
        Me.lblTitleLast.Name = "lblTitleLast"
        Me.lblTitleLast.Size = New System.Drawing.Size(68, 17)
        Me.lblTitleLast.TabIndex = 43
        Me.lblTitleLast.Text = "Last Update:"
        '
        'grpReturnDetail
        '
        Me.grpReturnDetail.Controls.Add(Me.dtpPaymentDate)
        Me.grpReturnDetail.Controls.Add(Me.lblTransDate)
        Me.grpReturnDetail.Controls.Add(Me.Label3)
        Me.grpReturnDetail.Controls.Add(Me.txtAmount)
        Me.grpReturnDetail.Controls.Add(Me.txtMemberName)
        Me.grpReturnDetail.Controls.Add(Me.Label6)
        Me.grpReturnDetail.Controls.Add(Me.cboMemberStatus)
        Me.grpReturnDetail.Controls.Add(Me.Label7)
        Me.grpReturnDetail.Controls.Add(Me.txtMemberId)
        Me.grpReturnDetail.Controls.Add(Me.Label1)
        Me.grpReturnDetail.Controls.Add(Me.txtTransId)
        Me.grpReturnDetail.Controls.Add(Me.Label2)
        Me.grpReturnDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReturnDetail.ForeColor = System.Drawing.Color.Blue
        Me.grpReturnDetail.Location = New System.Drawing.Point(2, 3)
        Me.grpReturnDetail.Name = "grpReturnDetail"
        Me.grpReturnDetail.Size = New System.Drawing.Size(640, 384)
        Me.grpReturnDetail.TabIndex = 42
        Me.grpReturnDetail.TabStop = False
        Me.grpReturnDetail.Text = "Retail Payment - Detail Information"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberName.Location = New System.Drawing.Point(128, 128)
        Me.txtMemberName.MaxLength = 20
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(336, 21)
        Me.txtMemberName.TabIndex = 5
        Me.txtMemberName.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(39, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Member Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMemberStatus
        '
        Me.cboMemberStatus.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cboMemberStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberStatus.Location = New System.Drawing.Point(128, 152)
        Me.cboMemberStatus.Name = "cboMemberStatus"
        Me.cboMemberStatus.Size = New System.Drawing.Size(120, 21)
        Me.cboMemberStatus.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(36, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Member Status:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Enabled = False
        Me.txtMemberId.Location = New System.Drawing.Point(128, 104)
        Me.txtMemberId.MaxLength = 20
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(120, 21)
        Me.txtMemberId.TabIndex = 69
        Me.txtMemberId.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Retail Member Id.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransId
        '
        Me.txtTransId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtTransId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransId.Location = New System.Drawing.Point(128, 80)
        Me.txtTransId.MaxLength = 20
        Me.txtTransId.Name = "txtTransId"
        Me.txtTransId.Size = New System.Drawing.Size(120, 21)
        Me.txtTransId.TabIndex = 3
        Me.txtTransId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Transaction Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(471, 393)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 393)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 41
        Me.btnClose.Text = "&Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(74, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(128, 56)
        Me.txtAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.TabIndex = 90
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(128, 32)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.ShowCheckBox = True
        Me.dtpPaymentDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpPaymentDate.TabIndex = 92
        Me.dtpPaymentDate.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(43, 34)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(79, 17)
        Me.lblTransDate.TabIndex = 93
        Me.lblTransDate.Text = "Payment Date:"
        '
        'frmRetailPayment01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(644, 421)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.lblTitleLast)
        Me.Controls.Add(Me.grpReturnDetail)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetailPayment01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Payment - Edit Screen"
        Me.grpReturnDetail.ResumeLayout(False)
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
