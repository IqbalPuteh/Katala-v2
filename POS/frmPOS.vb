Imports System.Text

Public Class frmPOS
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
    ' TODO StatusBar is no longer supported. Use StatusStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
                Public WithEvents stsBar As System.Windows.Forms.StatusBar
    ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
    Friend WithEvents stbDescription As System.Windows.Forms.StatusBarPanel
    ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
    Public WithEvents stbDate As System.Windows.Forms.StatusBarPanel
    ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
    Friend WithEvents stbTime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents tmrStatusBar As System.Windows.Forms.Timer
    ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
    Friend WithEvents stbUser As System.Windows.Forms.StatusBarPanel
    Friend WithEvents grpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTransDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPOSId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpTransaction As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpMaster As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents AxOPOSCashDrawer1 As AxOposCashDrawer_1_8_Lib.AxOPOSCashDrawer
    Friend WithEvents AxOPOSPOSPrinter1 As AxOposPOSPrinter_1_8_Lib.AxOPOSPOSPrinter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLastChange As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPOS))
        ' TODO StatusBar is no longer supported. Use StatusStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
        Me.stsBar = New System.Windows.Forms.StatusBar
        ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
        Me.stbUser = New System.Windows.Forms.StatusBarPanel
        ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
        Me.stbDescription = New System.Windows.Forms.StatusBarPanel
        ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
        Me.stbDate = New System.Windows.Forms.StatusBarPanel
        ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
        Me.stbTime = New System.Windows.Forms.StatusBarPanel
        Me.tmrStatusBar = New System.Windows.Forms.Timer(Me.components)
        Me.grpDetail = New System.Windows.Forms.GroupBox
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.grpTransaction = New System.Windows.Forms.GroupBox
        Me.lblLastChange = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.AxOPOSPOSPrinter1 = New AxOposPOSPrinter_1_8_Lib.AxOPOSPOSPrinter
        Me.chkPrint = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.txtTransDate = New System.Windows.Forms.TextBox
        Me.txtPOSId = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.AxOPOSCashDrawer1 = New AxOposCashDrawer_1_8_Lib.AxOPOSCashDrawer
        Me.grpMaster = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDisc = New System.Windows.Forms.NumericUpDown
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblPrice = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblItemName = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtQTY = New System.Windows.Forms.NumericUpDown
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.stbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetail.SuspendLayout()
        Me.grpTransaction.SuspendLayout()
        CType(Me.AxOPOSPOSPrinter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxOPOSCashDrawer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaster.SuspendLayout()
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBar
        '
        Me.stsBar.Location = New System.Drawing.Point(0, 719)
        Me.stsBar.Name = "stsBar"
        ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
        Me.stsBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.stbUser, Me.stbDescription, Me.stbDate, Me.stbTime})
        Me.stsBar.ShowPanels = True
        Me.stsBar.Size = New System.Drawing.Size(1018, 24)
        Me.stsBar.TabIndex = 6
        '
        'stbUser
        '
        ' TODO StatusBarPanel is no longer supported. Use ToolStripStatusLabel instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/windows-forms/5.0/winforms-deprecated-controls
                                Me.stbUser.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.stbUser.Text = "User:"
        Me.stbUser.Width = 202
        '
        'stbDescription
        '
        Me.stbDescription.Width = 500
        '
        'stbDate
        '
        Me.stbDate.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.stbDate.Text = "Date"
        Me.stbDate.Width = 200
        '
        'stbTime
        '
        Me.stbTime.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.stbTime.Text = "Time"
        '
        'tmrStatusBar
        '
        Me.tmrStatusBar.Enabled = True
        Me.tmrStatusBar.Interval = 1000
        '
        'grpDetail
        '
        Me.grpDetail.Controls.Add(Me.txtTotalPrice)
        Me.grpDetail.Controls.Add(Me.Label10)
        Me.grpDetail.Controls.Add(Me.lvwList)
        Me.grpDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetail.ForeColor = System.Drawing.Color.Blue
        Me.grpDetail.Location = New System.Drawing.Point(1, 120)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(1016, 496)
        Me.grpDetail.TabIndex = 41
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Detail Transaction"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.White
        Me.txtTotalPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Location = New System.Drawing.Point(832, 464)
        Me.txtTotalPrice.MaxLength = 10
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalPrice.Size = New System.Drawing.Size(180, 22)
        Me.txtTotalPrice.TabIndex = 65
        Me.txtTotalPrice.Text = "RP. 0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(736, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Total Price:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader6})
        Me.lvwList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(4, 28)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(1008, 420)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item No."
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Name"
        Me.ColumnHeader4.Width = 340
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "QTY"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 55
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Disc. %"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 71
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 180
        '
        'grpTransaction
        '
        Me.grpTransaction.Controls.Add(Me.lblLastChange)
        Me.grpTransaction.Controls.Add(Me.Label6)
        Me.grpTransaction.Controls.Add(Me.AxOPOSPOSPrinter1)
        Me.grpTransaction.Controls.Add(Me.chkPrint)
        Me.grpTransaction.Controls.Add(Me.Label2)
        Me.grpTransaction.Controls.Add(Me.Label5)
        Me.grpTransaction.Controls.Add(Me.lblTotalPrice)
        Me.grpTransaction.Controls.Add(Me.txtTransDate)
        Me.grpTransaction.Controls.Add(Me.txtPOSId)
        Me.grpTransaction.Controls.Add(Me.Label7)
        Me.grpTransaction.Controls.Add(Me.lblTransDate)
        Me.grpTransaction.Controls.Add(Me.AxOPOSCashDrawer1)
        Me.grpTransaction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTransaction.ForeColor = System.Drawing.Color.Blue
        Me.grpTransaction.Location = New System.Drawing.Point(1, 5)
        Me.grpTransaction.Name = "grpTransaction"
        Me.grpTransaction.Size = New System.Drawing.Size(1016, 115)
        Me.grpTransaction.TabIndex = 82
        Me.grpTransaction.TabStop = False
        Me.grpTransaction.Text = "Transaction Information"
        '
        'lblLastChange
        '
        Me.lblLastChange.AutoSize = True
        Me.lblLastChange.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastChange.ForeColor = System.Drawing.Color.Black
        Me.lblLastChange.Location = New System.Drawing.Point(768, 80)
        Me.lblLastChange.Name = "lblLastChange"
        Me.lblLastChange.Size = New System.Drawing.Size(70, 22)
        Me.lblLastChange.TabIndex = 104
        Me.lblLastChange.Text = "Rp. 0.00"
        Me.lblLastChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(536, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 19)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Last Change/Uang Kembali Terakhir:"
        '
        'AxOPOSPOSPrinter1
        '
        Me.AxOPOSPOSPrinter1.ContainingControl = Me
        Me.AxOPOSPOSPrinter1.Enabled = True
        Me.AxOPOSPOSPrinter1.Location = New System.Drawing.Point(424, 48)
        Me.AxOPOSPOSPrinter1.Name = "AxOPOSPOSPrinter1"
        Me.AxOPOSPOSPrinter1.OcxState = CType(resources.GetObject("AxOPOSPOSPrinter1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxOPOSPOSPrinter1.Size = New System.Drawing.Size(40, 24)
        Me.AxOPOSPOSPrinter1.TabIndex = 102
        '
        'chkPrint
        '
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.ForeColor = System.Drawing.Color.Black
        Me.chkPrint.Location = New System.Drawing.Point(896, 48)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.TabIndex = 101
        Me.chkPrint.Text = "Print Receipt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(191, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 61)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Rp. "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 46)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Total Price:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.Red
        Me.lblTotalPrice.Location = New System.Drawing.Point(289, 23)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(112, 61)
        Me.lblTotalPrice.TabIndex = 77
        Me.lblTotalPrice.Text = "0.00"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransDate
        '
        Me.txtTransDate.BackColor = System.Drawing.Color.White
        Me.txtTransDate.Enabled = False
        Me.txtTransDate.ForeColor = System.Drawing.Color.Black
        Me.txtTransDate.Location = New System.Drawing.Point(786, 17)
        Me.txtTransDate.MaxLength = 50
        Me.txtTransDate.Name = "txtTransDate"
        Me.txtTransDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTransDate.Size = New System.Drawing.Size(200, 21)
        Me.txtTransDate.TabIndex = 69
        Me.txtTransDate.Text = ""
        Me.txtTransDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPOSId
        '
        Me.txtPOSId.BackColor = System.Drawing.Color.White
        Me.txtPOSId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOSId.Enabled = False
        Me.txtPOSId.ForeColor = System.Drawing.Color.Black
        Me.txtPOSId.Location = New System.Drawing.Point(590, 17)
        Me.txtPOSId.MaxLength = 10
        Me.txtPOSId.Name = "txtPOSId"
        Me.txtPOSId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPOSId.Size = New System.Drawing.Size(87, 21)
        Me.txtPOSId.TabIndex = 68
        Me.txtPOSId.Text = ""
        Me.txtPOSId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(536, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "POS Id.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(692, 19)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(93, 17)
        Me.lblTransDate.TabIndex = 60
        Me.lblTransDate.Text = "Transaction Date:"
        '
        'AxOPOSCashDrawer1
        '
        Me.AxOPOSCashDrawer1.ContainingControl = Me
        Me.AxOPOSCashDrawer1.Enabled = True
        Me.AxOPOSCashDrawer1.Location = New System.Drawing.Point(424, 16)
        Me.AxOPOSCashDrawer1.Name = "AxOPOSCashDrawer1"
        Me.AxOPOSCashDrawer1.OcxState = CType(resources.GetObject("AxOPOSCashDrawer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxOPOSCashDrawer1.Size = New System.Drawing.Size(40, 24)
        Me.AxOPOSCashDrawer1.TabIndex = 92
        '
        'grpMaster
        '
        Me.grpMaster.Controls.Add(Me.Label4)
        Me.grpMaster.Controls.Add(Me.txtDisc)
        Me.grpMaster.Controls.Add(Me.btnClear)
        Me.grpMaster.Controls.Add(Me.lblPrice)
        Me.grpMaster.Controls.Add(Me.Label3)
        Me.grpMaster.Controls.Add(Me.btnClose)
        Me.grpMaster.Controls.Add(Me.lblItemName)
        Me.grpMaster.Controls.Add(Me.Label9)
        Me.grpMaster.Controls.Add(Me.txtQTY)
        Me.grpMaster.Controls.Add(Me.txtItemNo)
        Me.grpMaster.Controls.Add(Me.Label1)
        Me.grpMaster.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMaster.ForeColor = System.Drawing.Color.Blue
        Me.grpMaster.Location = New System.Drawing.Point(1, 616)
        Me.grpMaster.Name = "grpMaster"
        Me.grpMaster.Size = New System.Drawing.Size(1016, 96)
        Me.grpMaster.TabIndex = 91
        Me.grpMaster.TabStop = False
        Me.grpMaster.Text = "Master Transaction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(752, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Disc.:"
        '
        'txtDisc
        '
        Me.txtDisc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtDisc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(784, 32)
        Me.txtDisc.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(48, 22)
        Me.txtDisc.TabIndex = 2
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(912, 14)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 32)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear &Form"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Black
        Me.lblPrice.Location = New System.Drawing.Point(72, 61)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(70, 22)
        Me.lblPrice.TabIndex = 97
        Me.lblPrice.Text = "Rp. 0.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Price:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(912, 49)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 32)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(234, 35)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(86, 18)
        Me.lblItemName.TabIndex = 95
        Me.lblItemName.Text = "lblItemName"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(632, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "QTY:"
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtQTY.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(664, 32)
        Me.txtQTY.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtQTY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(48, 22)
        Me.txtQTY.TabIndex = 1
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQTY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemNo.Location = New System.Drawing.Point(66, 32)
        Me.txtItemNo.MaxLength = 20
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(160, 22)
        Me.txtItemNo.TabIndex = 0
        Me.txtItemNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Item No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(1018, 743)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpMaster)
        Me.Controls.Add(Me.grpTransaction)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.stsBar)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        CType(Me.stbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetail.ResumeLayout(False)
        Me.grpTransaction.ResumeLayout(False)
        CType(Me.AxOPOSPOSPrinter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxOPOSCashDrawer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaster.ResumeLayout(False)
        CType(Me.txtDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim svcPos As New POS.svcPOS
    Dim svcWarehouse As New Warehouse.svcWarehouse
    Dim dblPrice As Double
    Dim dblTotal As Double
    Dim dblTotalPrice As Double
    Dim adoDSStock As New DataSet
    Dim blnPrintReciept As Boolean = False
    Dim strPrinterName As String
    Dim strCashDrawerName As String
    Dim objCashDrawer As Object
    Dim objPOSPrinter As Object
    Public dblLastChange As Double = 0

    Private Sub tmrStatusBar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStatusBar.Tick
        stsBar.Panels(2).Text = Format(Now, "dddd, dd MMMM yyyy")
        stsBar.Panels(3).Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub frmPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtDate As Date

        Try
            Try
                Dim objCashDrawer As New OposCashDrawer_1_8_Lib.OPOSCashDrawerClass
                Dim objPOSPrinter As New OposPOSPrinter_1_8_Lib.OPOSPOSPrinterClass

                Me.objCashDrawer = objCashDrawer
                Me.objPOSPrinter = objPOSPrinter

                strPrinterName = ReadConfiguration("PRINTER_NAME")
                objPOSPrinter.Open(strPrinterName)
                objPOSPrinter.AsyncMode = True
                objPOSPrinter.ClaimDevice(1000)
                objPOSPrinter.DeviceEnabled = True

                strCashDrawerName = ReadConfiguration("CASHDRAWER_NAME")
                objCashDrawer.Open(strCashDrawerName)

                'Enable the device.
                objCashDrawer.DeviceEnabled = True

            Catch ex As Exception
                MessageBox.Show("Cannot connect to Cashdrawer or printer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End Try

            dtDate = svcPos.GetDate(APP_ID)
            svcWarehouse.Timeout = -1
            adoDSStock = svcWarehouse.GetStockListLOV("N", APP_ID)

            POSID = ReadConfiguration("POSID")
            txtPOSId.Text = POSID
            txtTransDate.Text = Format(dtDate, "dddd, dd MMMM yyyy")
            stsBar.Panels(0).Text = "User: " & EMPLOYEE_NAME
            lblItemName.Text = ""
            stsBar.Panels(1).Text = "QTY= 0"
            txtItemNo.Focus()

        Catch ex As Exception
            grpTransaction.Enabled = False
            grpDetail.Enabled = False
            grpMaster.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim adoDS As New DataSet
        Dim svcSystemSecurity As New SystemSecurity.svcSystemSecurity

        Try
            If lvwList.Items.Count > 0 Then
                adoDS = CreateEventRs()
                FillEvent(adoDS, "CLOSE FORM")
                svcSystemSecurity.Timeout = -1
                svcSystemSecurity.syseventprocedure(adoDS, APP_ID)
            End If

            Me.Dispose()

        Catch ex As Exception

        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (svcSystemSecurity Is Nothing) Then
                svcSystemSecurity.Dispose()
                svcSystemSecurity = Nothing
            End If
            If Not (svcPos Is Nothing) Then
                svcPos.Dispose()
                svcPos = Nothing
            End If
        End Try
    End Sub

    Private Sub txtItemNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemNo.TextChanged
        lblItemName.Text = ""
        stsBar.Panels(1).Text = "QTY= 0"
        lblPrice.Text = "Rp. 0.00"
        txtQTY.Text = "1"
        txtDisc.Text = "0"
    End Sub

    Private Sub txtItemNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemNo.KeyDown
        Dim adoDS As DataSet
        Dim adoDSHeader As DataSet
        Dim adoDSDetail As DataSet
        Dim adoRow As DataRow
        Dim myForm As New frmPOS01
        Dim data() As String

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                Dim adoDSLOV As New DataSet
                Dim myFormLOV As New frmLOV
                Dim adoRowLOV As DataRow

                Try
                    If e.KeyCode = e.KeyCode.F2 Then
                        'Gets Stock Item in the Stock Warehouse = N
                        myFormLOV.Initialize(txtItemNo.Text, adoDSStock, "STOCKLIST_LOV")

                        myFormLOV.ShowDialog()
                        If myFormLOV.GetCancelStatus = False Then
                            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                            adoDSLOV = myFormLOV.GetDataSet()
                            If adoDSLOV.Tables("RESOURCEINFO").Rows.Count > 0 Then
                                adoRowLOV = adoDSLOV.Tables("RESOURCEINFO").Rows(0)
                                txtItemNo.Text = adoRowLOV!RESOURCE_CODE
                                adoDSLOV.Dispose()
                            End If
                            txtItemNo_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
                        End If
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    End If

                Catch ex As Exception
                    ShowErrorMessage(ex.Message, ex.Source)
                Finally
                    If Not (adoDSLOV Is Nothing) Then
                        adoDSLOV.Dispose()
                        adoDSLOV = Nothing
                    End If
                    If Not (myFormLOV Is Nothing) Then
                        myFormLOV.Dispose()
                        myFormLOV = Nothing
                    End If
                End Try
            End If

            If e.KeyCode = e.KeyCode.Enter Then
                'Gets Item Data
                If Trim(txtItemNo.Text) <> "" Then
                    adoDS = svcPos.GetItemData(txtItemNo.Text, APP_ID)
                    If adoDS.Tables("ITEMDATA").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("ITEMDATA").Rows(0)

                        lblItemName.Text = adoRow!ITEM_NAME
                        If adoRow!STOCK_QTY > 0 Then
                            stsBar.Panels(1).Text = "QTY= " & adoRow!STOCK_QTY
                        Else
                            stsBar.Panels(1).Text = "QTY= " & adoRow!STOCK_QTY & " Minus"
                        End If

                        dblPrice = adoRow!SELL_PRICE
                        lblPrice.Text = "Rp. " & Format(dblPrice, "##,##0")
                        txtQTY.Focus()
                    Else
                        lblItemName.Text = ""
                        stsBar.Panels(1).Text = "QTY= 0"
                        lblPrice.Text = "Rp. 0.00"
                        txtQTY.Text = "1"

                        adoDS.Dispose()
                        adoDS = Nothing
                    End If
                End If

                'Transaction Payment Process
                If Trim(txtItemNo.Text) = "" And lvwList.Items.Count > 0 Then
                    Dim adoDSTransData As New DataSet

                    Try
                        myForm.FillField(dblTotalPrice, Me)

Form_Loop:
                        myForm.ShowDialog()
                        If myForm.GetCancelStatus = False Then
                            adoDSTransData = myForm.GetDataSet

                            adoDSHeader = CreateHeaderRs()
                            FillDataSet01(adoDSHeader, adoDSTransData)
                            adoDSDetail = CreateDetailRs()
                            FillDataSet02(adoDSDetail)
                            svcPos.AddNewTransaction(adoDSHeader, adoDSDetail, APP_ID)

                            Try
                                objCashDrawer.ClaimDevice(1000)
                                If objCashDrawer.ResultCode = 0& Then
                                    objCashDrawer.OpenDrawer()
                                Else
                                    Throw New Exception("Fail to claim the cash drawer")
                                End If
                                'Release the device exclusive control right.
                                objCashDrawer.ReleaseDevice()

                            Catch ex As Exception
                            End Try

                            If Me.chkPrint.Checked Then
                                blnPrintReciept = True
                            Else
                                blnPrintReciept = False
                            End If
                            If blnPrintReciept Then
                                Try
                                    data = PrintReciept(adoDSHeader, adoDSDetail)
                                    objPOSPrinter.TransactionPrint(2&, 11&)
                                    For _count As Int64 = data.GetLowerBound(0) To data.GetUpperBound(0)
                                        CDPrint(data(_count))
                                    Next
                                    CDPrint(" ")
                                    CDPrint(" ")
                                    CDPrint(" ")
                                    CDPrint(" ")
                                    objPOSPrinter.TransactionPrint(2&, 12&)

                                Catch ex As Exception
                                End Try
                            End If

                            'Clear form
                            If lvwList.Items.Count > 0 Then
                                lvwList.Items.Clear()
                            End If


                            dblPrice = "0.00"
                            dblTotal = "0.00"
                            dblTotalPrice = "0.00"


                            txtTotalPrice.Text = "Rp. " & Format(dblTotalPrice, "##,##0")
                            lblTotalPrice.Text = Format(dblTotalPrice, "##,##0")
                            lblLastChange.Text = "Rp. " & Format(dblLastChange, "##,##0")

                            txtItemNo.Text = ""
                            lblItemName.Text = ""
                            stsBar.Panels(1).Text = "QTY= 0"
                            lblPrice.Text = "Rp. 0.00"
                            txtQTY.Text = "1"
                            txtItemNo.Focus()

                        End If

                    Catch ex As Exception
                        ShowErrorMessage(ex.Message, ex.Source)
                        GoTo Form_Loop
                    Finally
                        If Not (adoDS Is Nothing) Then
                            adoDS.Dispose()
                            adoDS = Nothing
                        End If
                        If Not (myForm Is Nothing) Then
                            myForm.Dispose()
                            myForm = Nothing
                        End If
                        If Not (adoDSTransData Is Nothing) Then
                            adoDSTransData.Dispose()
                            adoDSTransData = Nothing
                        End If
                        If Not (adoDSHeader Is Nothing) Then
                            adoDSHeader.Dispose()
                            adoDSHeader = Nothing
                        End If
                        If Not (adoDSDetail Is Nothing) Then
                            adoDSDetail.Dispose()
                            adoDSDetail = Nothing
                        End If
                    End Try

                End If
            End If

        Catch ex As Exception
            grpTransaction.Enabled = False
            grpDetail.Enabled = False
            grpMaster.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
                myForm = Nothing
            End If
            If Not (adoDSHeader Is Nothing) Then
                adoDSHeader.Dispose()
                adoDSHeader = Nothing
            End If
            If Not (adoDSDetail Is Nothing) Then
                adoDSDetail.Dispose()
                adoDSDetail = Nothing
            End If
        End Try
    End Sub

    Private Sub txtQTY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQTY.KeyDown
        Try
            If e.KeyCode = e.KeyCode.Enter Then
                txtDisc.Focus()
                Exit Sub
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        Dim intSelectedItem As Integer
        Dim intCount As Integer
        Dim strResult As String
        Dim adoDS As New DataSet
        Dim svcSystemSecurity As New SystemSecurity.svcSystemSecurity

        Try
            If e.KeyCode = e.KeyCode.Enter Then
                txtItemNo.Focus()
            End If

            If e.KeyValue = 46 Then
                If lvwList.Items.Count = 0 Then
                    Exit Sub
                End If
                If lvwList.SelectedItems.Count = 0 Then
                    MessageBox.Show("Please select one of item in the list.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If lvwList.Items.Count > 0 Then
                    adoDS = CreateEventRs()
                    FillEvent(adoDS, "DELETE ITEM")
                    svcSystemSecurity.syseventprocedure(adoDS, APP_ID)
                End If

                dblTotal = lvwList.SelectedItems.Item(0).SubItems(6).Text
                dblTotalPrice = dblTotalPrice - dblTotal

                intSelectedItem = lvwList.SelectedItems.Item(0).Index
                lvwList.SelectedItems.Item(0).Remove()

                For intCount = 0 To lvwList.Items.Count - 1
                    lvwList.Items(intCount).Text = intCount + 1
                Next

                If lvwList.Items.Count > 0 Then
                    If (intSelectedItem) < lvwList.Items.Count Then
                        lvwList.Items(intSelectedItem).Selected = True
                    Else
                        If (intSelectedItem) = lvwList.Items.Count Then
                            lvwList.Items(intSelectedItem - 1).Selected = True
                        End If
                    End If
                End If

                txtTotalPrice.Text = "Rp. " & Format(dblTotalPrice, "##,##0")
                lblTotalPrice.Text = Format(dblTotalPrice, "##,##0")

                If lvwList.Items.Count = 0 Then
                    txtItemNo.Focus()
                End If

                'If lvwList.Items.Count > 15 Then
                '    lvwList.Columns(2).Width = 214
                'Else
                '    lvwList.Columns(2).Width = 230
                'End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (svcSystemSecurity Is Nothing) Then
                svcSystemSecurity.Dispose()
                svcSystemSecurity = Nothing
            End If
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim adoDS As New DataSet
        Dim svcSystemSecurity As New SystemSecurity.svcSystemSecurity

        Try
            If lvwList.Items.Count > 0 Then
                adoDS = CreateEventRs()
                FillEvent(adoDS, "CLEAR FORM")
                svcSystemSecurity.syseventprocedure(adoDS, APP_ID)

                lvwList.Items.Clear()
            End If

            dblPrice = "0.00"
            dblTotal = "0.00"
            dblTotalPrice = "0.00"

            'txtTotalPrice.Text = "Rp. " & Format(dblTotalPrice, "##,##0")
            txtTotalPrice.Text = "Rp. 0.00"
            'lblTotalPrice.Text = Format(dblTotalPrice, "##,##0")
            lblTotalPrice.Text = "0.00"

            txtItemNo.Text = ""
            lblItemName.Text = ""
            stsBar.Panels(1).Text = "QTY= 0"
            lblPrice.Text = "Rp. 0.00"
            txtQTY.Text = "1"
            txtDisc.Text = "0"
            txtItemNo.Focus()
        Catch ex As Exception

        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not (svcSystemSecurity Is Nothing) Then
                svcSystemSecurity.Dispose()
                svcSystemSecurity = Nothing
            End If
        End Try
    End Sub

    Private Function CreateHeaderRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("TRANS_HEADER")

        adoColumn = New DataColumn("TRANS_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TRANS_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("POS_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DISC")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TAX")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PAY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REMAIN")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("VOUCHER_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("CREATED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("CREATED_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("TRANS_HEADER").Columns.Add(adoColumn)

        CreateHeaderRs = adoDS
    End Function

    Private Function CreateDetailRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("TRANS_DETAIL")

        adoColumn = New DataColumn("TRANS_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ITEM_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DISC")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_DETAIL").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PRICE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("TRANS_DETAIL").Columns.Add(adoColumn)

        CreateDetailRs = adoDS
    End Function

    Private Function CreateEventRs() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("EVENT")

        adoColumn = New DataColumn("USER_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("DATE_TIME")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("TOTAL_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EVENT")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("EVENT").Columns.Add(adoColumn)

        CreateEventRs = adoDS
    End Function

    Private Sub FillDataSet01(ByRef adoDSHeader As DataSet, ByVal adoDSTransData As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable

        adoDataTable = adoDSHeader.Tables("TRANS_HEADER")
        adoDataRow = adoDataTable.NewRow()

        adoDataRow("POS_ID") = txtPOSId.Text
        adoDataRow("DISC") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("DISC")
        adoDataRow("TAX") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("TAX")
        adoDataRow("AMOUNT") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("AMOUNT")
        adoDataRow("PAY") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("PAY")
        adoDataRow("REMAIN") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("REMAIN")
        adoDataRow("MEMBERSHIP_NO") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("MEMBERSHIP_NO")
        adoDataRow("VOUCHER_NO") = adoDSTransData.Tables("PAYMENT_DATA").Rows(0)("VOUCHER_NO")
        adoDataRow("CREATED_BY") = USER_ID
        adoDataRow("REVIEWED_BY") = USER_ID

        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Sub FillDataSet02(ByRef adoDSDetail As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable
        Dim I As Integer
        Dim dblPrice As Double

        adoDataTable = adoDSDetail.Tables("TRANS_DETAIL")

        If lvwList.Items.Count > 0 Then
            For I = 0 To lvwList.Items.Count - 1
                adoDataRow = adoDataTable.NewRow()

                adoDataRow("ITEM_NO") = lvwList.Items(I).SubItems(1).Text
                adoDataRow("ITEM_NAME") = lvwList.Items(I).SubItems(2).Text
                adoDataRow("PRICE") = lvwList.Items(I).SubItems(3).Text
                adoDataRow("QTY") = lvwList.Items(I).SubItems(4).Text
                adoDataRow("DISC") = lvwList.Items(I).SubItems(5).Text
                adoDataTable.Rows.Add(adoDataRow)
            Next
        End If
    End Sub

    Private Sub FillEvent(ByRef adoDS As DataSet, ByVal strEvent As String)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable
        Dim I As Integer
        Dim dblPrice As Double
        Dim lngQTY As Long

        adoDataTable = adoDS.Tables("EVENT")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("USER_ID") = USER_ID
        If strEvent <> "DELETE ITEM" Then
            For I = 0 To lvwList.Items.Count - 1
                dblPrice = dblPrice + lvwList.Items(I).SubItems(6).Text
                lngQTY = lngQTY + lvwList.Items(I).SubItems(4).Text
            Next
        Else
            dblPrice = dblPrice + lvwList.Items(I).SubItems(6).Text
            lngQTY = lngQTY + lvwList.Items(I).SubItems(4).Text
        End If
        adoDataRow("AMOUNT") = dblPrice
        adoDataRow("TOTAL_QTY") = lngQTY
        adoDataRow("EVENT") = strEvent
        adoDataTable.Rows.Add(adoDataRow)

    End Sub

    Private Sub txtQTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.Enter
        txtQTY.Select(0, txtQTY.Text.Length)
    End Sub

    Private Sub frmPOS_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtItemNo.Focus()
    End Sub

    Private Function PrintReciept(ByVal adoDSHeader As DataSet, ByVal adoDSDetail As DataSet) As String()
        Dim frmPrint As New frmPOS02
        Dim AdoRow As DataRow
        Dim strData(8) As String
        Dim strTemp As String
        Dim Idx As Int16
        Dim strTransId As String = ""

        Try
            Array.Copy(frmPrint.rtbTrans.Lines(), strData, 4)
            Idx = frmPrint.rtbTrans.Lines.GetUpperBound(0) + 1
            strData(Idx) = New String("=", 33)
            Idx += 1
            strData(Idx) = "."
            Idx += 1
            For Each AdoRow In adoDSDetail.Tables(0).Rows
                strTransId = NullToString(AdoRow!TRANS_ID)
                strData(Idx) = RtL(NullToString(AdoRow!ITEM_NO) + "  -  " + NullToString(AdoRow!ITEM_NAME) + strData(Idx), 0)
                Idx += 1
                ReDim Preserve strData(Idx)
                strTemp = NullToString(AdoRow!QTY) + "  X  " + Format(CInt(NullToString(AdoRow!PRICE)), "##,##0")
                strData(Idx) = RtL(strTemp + " = " + Format((CInt(NullToString(AdoRow!QTY)) * CInt(NullToString(AdoRow!PRICE))), "##,##0"), 0)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = "."
                Idx += 1
                ReDim Preserve strData(Idx)
            Next
            If adoDSHeader.Tables("TRANS_HEADER").Rows.Count = 0 Then
                Throw New Exception("Illegal Trans -> AdoDSTransData is not avail.")
            Else
                strData(Idx) = New String("=", 33)
                Idx += 1
                ReDim Preserve strData(Idx)
                AdoRow = adoDSHeader.Tables("TRANS_HEADER").Rows(0)
                strData(Idx) = "Total : " & RtL(Format(CInt(AdoRow!AMOUNT), "##,##0"), 8)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = "Disc. : " & RtL(Format(CInt(AdoRow!DISC), "##,##0"), 8)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = "Tax   : " & RtL(Format(CInt(AdoRow!TAX), "##,##0"), 8)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = "Cash  : " & RtL(Format(CInt(AdoRow!PAY), "##,##0"), 8)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = "Change: " & RtL(Format(CInt(AdoRow!REMAIN), "##,##0"), 8)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = New String("-", 33)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = RtL("TransID:" & NullToString(strTransId) & " - Cashier: " & AdoRow!CREATED_BY, 0)
                Idx += 1
                ReDim Preserve strData(Idx)
                strData(Idx) = RtL("Date:" & Format(Now, "dd/MM/yyyy") & " - Time: " & Format(Now, "hh:mm"), 0)
                Idx += 1
                ReDim Preserve strData(Idx)
                'ReDim frmPrint.rtbTrans.Lines(200)
                'ReDim frmPrint.rtbTrans.Lines(Idx + 2)
                'frmPrint.rtbTrans.Lines() = strData
                ' Print the document.
                'frmPrint.pdTrans.Print()
                'frmPrint.ShowDialog()

                Return strData
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub txtDisc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc.Enter
        txtDisc.Select(0, txtDisc.Text.Length)
    End Sub

    Private Sub txtDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDisc.KeyDown
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            If e.KeyCode = e.KeyCode.Enter Then
                If txtQTY.Value > 0 And Trim(txtItemNo.Text) <> "" And (lblItemName.Text) <> "" Then
                    dblTotal = txtQTY.Value * dblPrice
                    If txtDisc.Value > 0 Then
                        dblTotal = dblTotal - ((dblTotal * txtDisc.Value) / 100)
                    End If

                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(txtItemNo.Text)
                    objItem.SubItems.Add(lblItemName.Text)
                    objItem.SubItems.Add(Format(dblPrice, "##0"))
                    objItem.SubItems.Add(txtQTY.Text)
                    objItem.SubItems.Add(txtDisc.Text)
                    objItem.SubItems.Add(Format(dblTotal, "##0"))
                    objItem.Selected = True

                    dblTotalPrice = dblTotalPrice + dblTotal

                    txtTotalPrice.Text = "Rp. " & Format(dblTotalPrice, "##,##0")
                    lblTotalPrice.Text = Format(dblTotalPrice, "##,##0")

                    txtItemNo.Text = ""
                    lblItemName.Text = ""
                    stsBar.Panels(1).Text = "QTY= 0"

                    lblPrice.Text = "Rp. 0.00"
                    txtQTY.Text = "1"
                    txtDisc.Text = "0"
                    txtItemNo.Focus()
                Else
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    'Private Sub OpenDrawer()
    '    ' Always wrap up working with Comm Ports in exception handlers.
    '    Try
    '        ' Enable the timer.
    '        ' Attempt to open the port.
    '        m_CommPort.Open(1, 9600, 8, clsRs232.DataParity.Parity_None, clsRs232.DataStopBit.StopBit_1, 4096)

    '        ' Write an user specified Command to the Port.
    '        m_CommPort.Write(Encoding.ASCII.GetBytes(Chr(127) & Chr(112) & "0" & Chr(48)))
    '        ' Sleep long enough for the modem to respond and the timer to fire.
    '        System.Threading.Thread.Sleep(200)
    '        Application.DoEvents()
    '        m_CommPort.Close()

    '    Catch ex As Exception
    '        ' Warn the user.
    '        MessageBox.Show("Unable to communicate with Drawer")
    '    Finally
    '        ' Disable the timer.
    '    End Try
    'End Sub

    Private Sub CDPrint(ByVal sValue As String)
        Try

            objPOSPrinter.PrintNormal(2&, sValue & Chr(13) & Chr(10))
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub Finalize()

        objCashDrawer.DeviceEnabled = False
        'Finish using the device.
        objCashDrawer.Close()

        'Back to the synchronous mode
        objPOSPrinter.AsyncMode = False
        objPOSPrinter.DeviceEnabled = False
        objPOSPrinter.ReleaseDevice()
        objPOSPrinter.Close()
        MyBase.Finalize()
    End Sub

    Private Sub txtDisc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisc.ValueChanged, txtDisc.TextChanged, txtDisc.Leave
        Try
            If CDbl(txtDisc.Text) > 10 Then
                txtDisc.Text = 10
            End If
        Catch ex As Exception
            txtDisc.Text = 10
        End Try
        If txtDisc.Text.Length > 2 Then
            txtDisc.Text = 0
        End If
    End Sub
End Class