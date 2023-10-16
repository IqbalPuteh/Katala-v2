Public Class frmMainMenu
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
    Friend WithEvents tvwMainMenu As System.Windows.Forms.TreeView
    ' TODO MainMenu is no longer supported. Use MenuStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MainMenu
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuSystem As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuChangePassword As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuContents As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuIndex As System.Windows.Forms.MenuItem
    ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Public WithEvents imgList As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMainMenu))
        Me.tvwMainMenu = New System.Windows.Forms.TreeView
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        ' TODO MainMenu is no longer supported. Use MenuStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuMainMenu = New System.Windows.Forms.MainMenu
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuSystem = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuChangePassword = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuExit = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuContents = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuIndex = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuAbout = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'tvwMainMenu
        '
        Me.tvwMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.tvwMainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwMainMenu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwMainMenu.FullRowSelect = True
        Me.tvwMainMenu.HideSelection = False
        Me.tvwMainMenu.HotTracking = True
        Me.tvwMainMenu.ImageIndex = 2
        Me.tvwMainMenu.ImageList = Me.imgList
        Me.tvwMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.tvwMainMenu.Name = "tvwMainMenu"
        Me.tvwMainMenu.PathSeparator = ""
        Me.tvwMainMenu.SelectedImageIndex = 2
        Me.tvwMainMenu.Size = New System.Drawing.Size(328, 367)
        Me.tvwMainMenu.TabIndex = 0
        '
        'imgList
        '
        Me.imgList.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'mnuMainMenu
        '
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
                                Me.mnuMainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSystem, Me.mnuHelp})
        '
        'mnuSystem
        '
        Me.mnuSystem.Index = 0
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuSystem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChangePassword, Me.MenuItem4, Me.mnuExit})
        Me.mnuSystem.Text = "&System"
        '
        'mnuChangePassword
        '
        Me.mnuChangePassword.Index = 0
        Me.mnuChangePassword.Text = "&Change Password"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 2
        Me.mnuExit.Text = "&Exit"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 1
        ' TODO MenuItem is no longer supported. Use ToolStripMenuItem instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuContents, Me.mnuIndex, Me.MenuItem8, Me.mnuAbout})
        Me.mnuHelp.Text = "&Help"
        '
        'mnuContents
        '
        Me.mnuContents.Index = 0
        Me.mnuContents.Text = "&Contents"
        '
        'mnuIndex
        '
        Me.mnuIndex.Index = 1
        Me.mnuIndex.Text = "&Index"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "-"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 3
        Me.mnuAbout.Text = "&About"
        '
        'frmMainMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(328, 367)
        Me.Controls.Add(Me.tvwMainMenu)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.mnuMainMenu
        Me.Name = "frmMainMenu"
        Me.Text = "Koperasi Information Management System"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function CreateSystemSecuritySystemNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for System Security Module
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 7, 7)

        'Create TreeNode for System Security Module Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("User Access", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("User Profile", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
        Level2.Nodes.Add(Level3)

        If dtRow("ACCESS_VALUE") >= 5 Then
            'Create TreeNode for System Security Module System Maintenance
            Level2 = New TreeNode("System Maintenance", 4, 4)
            Level1.Nodes.Add(Level2)
            Level3 = New TreeNode("Resources Code Maintenance", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
            Level2.Nodes.Add(Level3)
        End If

        'Create TreeNode for Security Module Reporting System
        Level2 = New TreeNode("Reporting System", 5, 5)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("User Access Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "004"
        Level2.Nodes.Add(Level3)

        CreateSystemSecuritySystemNode = Level1
    End Function

    Private Function CreateMembershipSystemNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for Membership Module
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 8, 8)

        'Create TreeNode for Membership Module Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Koperasi Membership", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Change Membership Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Review Transaction", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Transaction Entry", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "006"
        Level2.Nodes.Add(Level3)

        'frmMembershipUploadSHUData

        If dtRow("ACCESS_VALUE") >= 5 Then
            Level3 = New TreeNode("Upload Membership Transaction", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "004"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Upload SHU Transaction", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "016"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Close Accounting Period", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "005"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("[New] Upload Iuran & Simpanan", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "019"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("[New] Upload Loan Deduction", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "020"
            Level2.Nodes.Add(Level3)

            'Create TreeNode for Membership Module System Maintenance
            Level2 = New TreeNode("System Maintenance", 4, 4)
            Level1.Nodes.Add(Level2)
            Level3 = New TreeNode("Resources Code Maintenance", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "007"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("System Parameters", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "008"
            Level2.Nodes.Add(Level3)
        End If

        'Create TreeNode for Membership Module Reporting System
        Level2 = New TreeNode("Reporting System", 5, 5)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Individual Member Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "010"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Members List Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "011"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Members Installment Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "012"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Monthly Transaction Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "013"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Monthly Member Transaction Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "015"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Members Summary Installment Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "014"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Monthly Intrest Payment Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "017"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Monthly Admin Fee Deduction Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "018"
        Level2.Nodes.Add(Level3)

        CreateMembershipSystemNode = Level1
    End Function

    Private Function CreateHRNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for HR Module
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 6, 6)

        'Create TreeNode for HR Module Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Employee Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Detail Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Position Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Salary Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "004"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Performance Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "007"
        Level2.Nodes.Add(Level3)

        If dtRow("ACCESS_VALUE") >= 5 Then
            'Create TreeNode for HR Module System Maintenance
            Level2 = New TreeNode("System Maintenance", 4, 4)
            Level1.Nodes.Add(Level2)
            Level3 = New TreeNode("Resources Code Maintenance", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "005"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Position Information", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "006"
            Level2.Nodes.Add(Level3)
        End If

        'Create TreeNode for Membership Module Reporting System
        Level2 = New TreeNode("Reporting System", 5, 5)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Employee Information Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "008"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Detail Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "009"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Position Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "010"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Salary Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "011"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Employee Performance Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "012"
        Level2.Nodes.Add(Level3)

        CreateHRNode = Level1
    End Function

    Private Function CreateLoanNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for Kredit Module
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 12, 12)

        'Create TreeNode for Kredit Module Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Loan Registration Entry", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)

        If dtRow("ACCESS_VALUE") >= 5 Then
            Level3 = New TreeNode("Review Loan Approval", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
            Level2.Nodes.Add(Level3)
        End If

        Level3 = New TreeNode("Set Loan Realization", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "006"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Loan Payment Data Upload", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Loan Transaction Entry", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "004"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Review Transaction History", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "005"
        Level2.Nodes.Add(Level3)

        If dtRow("ACCESS_VALUE") >= 5 Then
            'Create TreeNode for System Security Module System Maintenance
            Level2 = New TreeNode("System Maintenance", 4, 4)
            Level1.Nodes.Add(Level2)
            Level3 = New TreeNode("Resources Code Maintenance", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "007"
            Level2.Nodes.Add(Level3)
        End If

        ''Create TreeNode for Kredit Module Reporting System
        'Level2 = New TreeNode("Reporting System", 5, 5)
        'Level1.Nodes.Add(Level2)
        'Level3 = New TreeNode("Kredit Information Report", 2, 2)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "009"
        'Level2.Nodes.Add(Level3)

        CreateLoanNode = Level1
    End Function

    Private Function CreateWarehouseNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for Warehouse System Data
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 9, 9)

        'Create TreeNode for Warehouse System Data Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Item Description", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Supplier Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("PO - Purchase Order Information", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "004"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Recieve Item", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "008"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Movement Item", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "009"
        Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Adjustment Stock Item", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "011"
        Level2.Nodes.Add(Level3)

        If dtRow("ACCESS_VALUE") >= 5 Then
            'Create TreeNode for Warehouse System Data Maintenance
            Level2 = New TreeNode("System Maintenance", 4, 4)
            Level1.Nodes.Add(Level2)
            Level3 = New TreeNode("Resources Code Maintenance", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "005"
            Level2.Nodes.Add(Level3)
        End If

        'Create TreeNode for Warehouse System Data Reporting
        Level2 = New TreeNode("Reporting System", 5, 5)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Recommended Order - Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
        Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Supplier List - Report", 2, 2)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "006"
        'Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Purchase Order - Report", 2, 2)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "010"
        'Level2.Nodes.Add(Level3)
        Level3 = New TreeNode("Stock List - Report", 2, 2)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "007"
        Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Recived PO - Report", 2, 2)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "012"
        'Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Movement Item - Report", 2, 2)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "013"
        'Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Adjustment Item - Report", 2, 2)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "014"
        'Level2.Nodes.Add(Level3)

        CreateWarehouseNode = Level1
    End Function

    Private Function CreatePOSNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for POS Module
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 10, 10)

        'Create TreeNode for POS Module Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("POS - Point of Sales", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)

        If dtRow("ACCESS_VALUE") > 1 Then
            Level3 = New TreeNode("Review POS Transaction", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Return Item QTY", 1, 1)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
            Level2.Nodes.Add(Level3)

            'Create TreeNode for POS System Data Reporting
            Level2 = New TreeNode("Reporting System", 5, 5)
            Level1.Nodes.Add(Level2)
            Level3 = New TreeNode("Sales - Report", 2, 2)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "004"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Frequency - Report", 2, 2)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "005"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Item Sales Qty Perday - Report", 2, 2)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "006"
            Level2.Nodes.Add(Level3)
            Level3 = New TreeNode("Item Sales Qty PerPeriod - Report", 2, 2)
            Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "007"
            Level2.Nodes.Add(Level3)
        End If

        CreatePOSNode = Level1
    End Function

    Private Function CreateRetailNode(ByVal dtRow As DataRow) As TreeNode
        Dim Level1, Level2, Level3 As TreeNode

        'Create TreeNode for Retail Module
        Level1 = New TreeNode(dtRow("PROGRAM_NAME"), 11, 11)

        'Create TreeNode for Retail Module Screens Entry
        Level2 = New TreeNode("Screens Entry", 3, 3)
        Level1.Nodes.Add(Level2)
        Level3 = New TreeNode("Retail Member", 1, 1)
        Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "001"
        Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Review POS Transaction", 1, 1)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "002"
        'Level2.Nodes.Add(Level3)
        'Level3 = New TreeNode("Return Item QTY", 1, 1)
        'Level3.Tag = dtRow!PROGRAM_ID & Replicate(" ", (10 - Len(dtRow!PROGRAM_ID))) & "003"
        'Level2.Nodes.Add(Level3)

        CreateRetailNode = Level1
    End Function

    Public Sub CustomizeMainMenu()
        Dim TopNode, Level1 As TreeNode
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity
        Dim myDS As New DataSet
        Dim dataRow As DataRow

        Try
            Dim MyProx As New System.Net.WebProxy("http://192.168.30.128:80")
            MyProx.Credentials = New System.Net.NetworkCredential("IPUT4811", "Irysada01", "KATALA01-VR")
            svcSecurity.Proxy = MyProx

            myDS = svcSecurity.GetUserAccessRecord(USER_ID, APP_ID)

            'Create Top Node
            TopNode = New TreeNode("Main Menu (" & EMPLOYEE_NAME & ")", 0, 0)
            TopNode.Expand()

            For Each dataRow In myDS.Tables("USER_ACCESS").Rows
                Select Case dataRow("PROGRAM_ID")
                    Case "SECURITY"
                        Level1 = CreateSystemSecuritySystemNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                    Case "MEMBERSHIP"
                        Level1 = CreateMembershipSystemNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                    Case "HRMODULE"
                        Level1 = CreateHRNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                    Case "LOAN"
                        Level1 = CreateLoanNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                    Case "WAREHOUSE"
                        Level1 = CreateWarehouseNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                    Case "POS"
                        Level1 = CreatePOSNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                    Case "RETAIL"
                        Level1 = CreateRetailNode(dataRow)
                        TopNode.Nodes.Add(Level1)
                End Select
            Next
            tvwMainMenu.Nodes.Clear()
            tvwMainMenu.Nodes.Add(TopNode)
            If tvwMainMenu.Nodes(0).GetNodeCount(False) > 0 Then
                tvwMainMenu.Nodes(0).Nodes.Item(0).Expand()
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
        End Try
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub CallMembershipModule(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                Dim myForm As New frmMembership
                myForm.ShowDialog()
            Case "002"
                Dim myForm As New frmMembershipHistory
                myForm.ShowDialog()
            Case "003"
                Dim myForm As New frmMembershipSaving
                myForm.ShowDialog()
            Case "004"
                Dim myForm As New frmMembershipUploadTransaction
                myForm.ShowDialog()
            Case "005"
                Dim myForm As New frmMembershipClosing
                myForm.ShowDialog()
            Case "006"
                Dim myForm As New frmMembershipTransaction
                myForm.ShowDialog()
            Case "007"
                Dim myForm As New frmResourceCode
                myForm.strProgramId = "MEMBERSHIP"
                myForm.ShowDialog()
            Case "008"
                Dim myForm As New frmMembershipSystemSetup
                myForm.ShowDialog()
            Case "010"
                Dim myForm As New frmMembershipRptIndividual
                myForm.ShowDialog()
            Case "011"
                Dim myForm As New frmMembershipRptMemberList
                myForm.ShowDialog()
            Case "012"
                Dim myForm As New frmMembershipRptInstallment
                myForm.ShowDialog()
            Case "013"
                Dim myForm As New frmMembershipRptMontlyTransaction
                myForm.ShowDialog()
            Case "014"
                Dim myForm As New frmMembershipRptInstallmentSummary
                myForm.ShowDialog()
            Case "015"
                Dim myForm As New frmMembershipRptTransaction
                myForm.ShowDialog()
            Case "016"
                Dim myForm As New frmMembershipUploadSHUData
                myForm.ShowDialog()
            Case "017"
                Dim myForm As New frmMembershipRptMonthlyIntrestPay
                myForm.ShowDialog()
            Case "018"
                Dim myForm As New frmMembershipRptMonthlyAdminFee
                myForm.ShowDialog()
            Case "019"
                Dim myForm As New frmMembershipUploadTransactionNew
                myForm.ShowDialog()
            Case "020"
                Dim myForm As New frmMembershipLoanDeduction
                myForm.ShowDialog()

        End Select
    End Sub

    Private Sub CallPOSModule(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                'Dim myForm As New frmPOS
                'myForm.ShowDialog()
            Case "002"
                Dim myForm As New frmReviewTransaction
                myForm.ShowDialog()
            Case "003"
                Dim myForm As New frmReturnItem
                myForm.ShowDialog()
            Case "004"
                Dim myForm As New frmPOSRpt
                myForm.ShowDialog()
            Case "005"
                Dim myForm As New frmPOSRpt01
                myForm.ShowDialog()
            Case "006"
                Dim myForm As New frmReviewItemSales
                myForm.ShowDialog()
            Case "007"
                Dim myForm As New frmReviewItemSalesPeriod
                myForm.ShowDialog()
        End Select
    End Sub

    Private Sub CallSystemSecurityModule(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                Dim myForm As New frmUserAccess
                myForm.ShowDialog()
            Case "002"
                Dim myForm As New frmUserProfile
                myForm.ShowDialog()
            Case "003"
                Dim myForm As New frmResourceCode
                myForm.strProgramId = "SECURITY"
                myForm.ShowDialog()
            Case "004"
                Dim myForm As New frmRptUserAccess
                myForm.ShowDialog()
        End Select
    End Sub

    Private Sub CallHRModule(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                Dim myForm As New frmEmployeeInfo
                myForm.ShowDialog()
            Case "002"
                Dim myForm As New frmEmployeeDetail
                myForm.ShowDialog()
            Case "003"
                Dim myForm As New frmEmployeePosition
                myForm.ShowDialog()
            Case "004"
                Dim myForm As New frmEmployeeSalary
                myForm.ShowDialog()
            Case "005"
                Dim myForm As New frmResourceCode
                myForm.strProgramId = "HRIS"
                myForm.ShowDialog()
            Case "006"
                Dim myForm As New frmHRPosition
                myForm.ShowDialog()
            Case "007"
                Dim myForm As New frmEmployeeNote
                myForm.ShowDialog()
            Case "008"
                Dim myForm As New frmEmployeeRptGeneral
                myForm.ShowDialog()
            Case "009"
                Dim myForm As New frmEmployeeRptDetail
                myForm.ShowDialog()
            Case "010"
                Dim myForm As New frmEmployeeRptPosition
                myForm.ShowDialog()
            Case "011"
                Dim myForm As New frmEmployeeRptSalary
                myForm.ShowDialog()
            Case "012"
                Dim myForm As New frmEmployeeRptPerformance
                myForm.ShowDialog()
        End Select
    End Sub

    Private Sub CallKreditModule(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                Dim myForm As New frmRegistryCredit
                myForm.ShowDialog()
            Case "002"
                Dim myForm As New frmKreditApproval
                myForm.ShowDialog()
            Case "003"
                Dim myForm As New frmKreditUploadData
                myForm.ShowDialog()
            Case "004"
                Dim myForm As New frmKreditTransaction
                myForm.ShowDialog()
            Case "005"
                Dim myForm As New frmKreditTransactionHistory
                myForm.Show()
            Case "006"
                Dim myForm As New frmKreditRealization
                myForm.Show()
            Case "007"
                Dim myForm As New frmResourceCode
                myForm.strProgramId = "LOAN"
                myForm.ShowDialog()
        End Select
    End Sub

    Private Sub CallWarehouseSystemData(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                Dim myForm As New frmItem
                myForm.ShowDialog()
            Case "002"
                Dim myForm As New frmSupplier
                myForm.ShowDialog()
            Case "003"
                Dim myForm As New frmRecommendedOrder
                myForm.ShowDialog()
            Case "004"
                Dim myForm As New frmCreatePO
                myForm.ShowDialog()
            Case "005"
                Dim myForm As New frmResourceCode
                myForm.strProgramId = "WAREHOUSE"
                myForm.ShowDialog()
                'Case "006"
                '    Dim myForm As New frmWarehouseRptSupplier
                '    myForm.ShowDialog()
            Case "007"
                Dim myForm As New frmWarehouseRptStockList
                myForm.ShowDialog()
            Case "008"
                Dim myForm As New frmRecieve
                myForm.ShowDialog()
            Case "009"
                Dim myForm As New frmMovementItem
                myForm.ShowDialog()
            Case "011"
                Dim myForm As New frmAdjustmentItem
                myForm.ShowDialog()
                'Case "010"
                '    Dim myForm As New frmWarehouseRptPO
                '    myForm.ShowDialog()
                'Case "012"
                '    Dim myForm As New frmWarehouseRptRecivedPO
                '    myForm.ShowDialog()
                'Case "013"
                '    Dim myForm As New frmWarehouseMove
                '    myForm.ShowDialog()
                'Case "014"
                '    Dim myForm As New frmWarehouseRptAdjust
                '    myForm.ShowDialog()
        End Select
    End Sub

    Private Sub CallRetailModule(ByVal ProgramId As String)
        Select Case Microsoft.VisualBasic.Right(ProgramId, 3)
            Case "001"
                Dim myForm As New frmRetailMember
                myForm.ShowDialog()
                'Case "002"
                '    Dim myForm As New frmUserProfile
                '    myForm.ShowDialog()
                'Case "003"
                '    Dim myForm As New frmResourceCode
                '    myForm.strProgramId = "SECURITY"
                '    myForm.ShowDialog()
                'Case "004"
                '    Dim myForm As New frmRptUserAccess
                '    myForm.ShowDialog()
        End Select
    End Sub

    Private Sub tvwMainMenu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvwMainMenu.DoubleClick
        Dim strProgNo As String

        If tvwMainMenu.SelectedNode.Tag <> "" Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            strProgNo = Mid(tvwMainMenu.SelectedNode.Tag, 1, 10)
            Select Case strProgNo
                Case "MEMBERSHIP"
                    CallMembershipModule(tvwMainMenu.SelectedNode.Tag)
                Case "SECURITY  "
                    CallSystemSecurityModule(tvwMainMenu.SelectedNode.Tag)
                Case "HRMODULE  "
                    CallHRModule(tvwMainMenu.SelectedNode.Tag)
                Case "LOAN      "
                    CallKreditModule(tvwMainMenu.SelectedNode.Tag)
                Case "WAREHOUSE "
                    CallWarehouseSystemData(tvwMainMenu.SelectedNode.Tag)
                Case "POS       "
                    CallPOSModule(tvwMainMenu.SelectedNode.Tag)
                Case "RETAIL    "
                    CallRetailModule(tvwMainMenu.SelectedNode.Tag)
            End Select
        End If
    End Sub

    Private Sub tvwMainMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tvwMainMenu.KeyDown
        If e.KeyCode = Keys.Enter Then
            tvwMainMenu_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub frmMainMenu_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        If Me.Top < 0 Then
            Me.Top = 0
        End If
        If Me.Left < 0 Then
            Me.Left = 0
        End If
    End Sub

    Private Sub mnuChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangePassword.Click
        Dim myForm As New frmChangePassword
        myForm.ShowDialog()
    End Sub

End Class
