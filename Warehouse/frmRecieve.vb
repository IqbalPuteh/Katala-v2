Public Class frmRecieve
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
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPONO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPOStatus As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnReports As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecieve))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPOStatus = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSupplierName = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPONO = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.btnReports = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPOStatus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblSupplierName)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPONO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 136)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(248, 48)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpEndDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(226, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "To"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Checked = False
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(104, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartDate.TabIndex = 0
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(28, 51)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(73, 17)
        Me.lblTransDate.TabIndex = 67
        Me.lblTransDate.Text = "Recieve Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(376, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PO Status:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPOStatus
        '
        Me.lblPOStatus.AutoSize = True
        Me.lblPOStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOStatus.ForeColor = System.Drawing.Color.Black
        Me.lblPOStatus.Location = New System.Drawing.Point(432, 81)
        Me.lblPOStatus.Name = "lblPOStatus"
        Me.lblPOStatus.Size = New System.Drawing.Size(71, 17)
        Me.lblPOStatus.TabIndex = 10
        Me.lblPOStatus.Text = "lblPOStatus"
        Me.lblPOStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Supplier Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierName.ForeColor = System.Drawing.Color.Black
        Me.lblSupplierName.Location = New System.Drawing.Point(104, 104)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(98, 17)
        Me.lblSupplierName.TabIndex = 8
        Me.lblSupplierName.Text = "lblSupplierName"
        Me.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(533, 102)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the PO No. then click on the select button to view Reicive Item Informati" & _
        "on."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPONO
        '
        Me.txtPONO.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPONO.Location = New System.Drawing.Point(104, 78)
        Me.txtPONO.MaxLength = 20
        Me.txtPONO.Name = "txtPONO"
        Me.txtPONO.Size = New System.Drawing.Size(136, 21)
        Me.txtPONO.TabIndex = 2
        Me.txtPONO.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PO NO.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(471, 413)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(375, 413)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(88, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Recieve Item"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(2, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 272)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recieve Detail Information"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader1})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 16)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(631, 250)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No."
        Me.ColumnHeader6.Width = 36
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Recieve Date"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Recieve By"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "PO No."
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Supplier Name"
        Me.ColumnHeader2.Width = 230
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RecId"
        Me.ColumnHeader1.Width = 0
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(5, 413)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(80, 24)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "&Reports"
        '
        'frmRecieve
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 440)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAddNew)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecieve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Recieve Item Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer
    Dim adoDsPO As DataSet

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        If lvwList.SelectedItems.Count <> 0 Then
            btnModify_Click(sender, e)
        End If
    End Sub

    Private Sub frmRecieve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity
        Dim svcWarehouse As New Warehouse.svcWarehouse

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            dtpStartDate.Value = Now
            dtpEndDate.Value = Now
            dtpStartDate.Checked = True
            dtpEndDate.Checked = True
            dtpStartDate.Checked = False
            dtpEndDate.Checked = False
            lblPOStatus.Text = ""
            lblSupplierName.Text = ""
            btnSelect.Enabled = True
            btnAddNew.Enabled = True
            adoDsPO = svcWarehouse.GetPOLOV("", APP_ID)
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "WAREHOUSE", APP_ID)
            If intAccessValue = 9 And lvwList.Items.Count > 0 Then
                'btnDelete.Enabled = True
            Else
                'btnDelete.Enabled = False
            End If
            btnReports.Enabled = False
            txtPONO.Focus()

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim myDS As New DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim strStartDate As String
        Dim strEndDate As String

        Try
            If dtpStartDate.Checked = True And _
                dtpEndDate.Checked = True Then
                If dtpStartDate.Value > dtpEndDate.Value Then
                    MessageBox.Show("Start Date must be equal or bigger than End Date. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            If Trim(txtPONO.Text) <> "" And lblSupplierName.Text = "" Then
                MessageBox.Show("Please type the correct PO No.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPONO.Focus()
                Exit Sub
            End If
            If dtpStartDate.Checked = True Then
                strStartDate = Format(dtpStartDate.Value, "dd/MM/yyyy")
            Else
                strStartDate = ""
            End If
            If dtpEndDate.Checked = True Then
                strEndDate = Format(dtpEndDate.Value, "dd/MM/yyyy")
            Else
                strEndDate = ""
            End If

            myDS = svcWarehouse.GetRecieveInfo(txtPONO.Text, strStartDate, strEndDate, APP_ID)
            If myDS.Tables("RECIEVEINFO").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("RECIEVEINFO").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adoRow!RECIEVE_DATE, "dd-MMM-yyyy"))
                    objItem.SubItems.Add(adoRow!RECIEVE_BY)
                    objItem.SubItems.Add(adoRow!PO_NO)
                    objItem.SubItems.Add(adoRow!SUPPLIER_NAME)
                    objItem.SubItems.Add(adoRow!REC_ID)
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("There is no recieving data found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            myDS.Dispose()

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnModify.Enabled = True
                If lvwList.Items.Count > 15 Then
                    lvwList.Columns(4).Width = 214
                Else
                    lvwList.Columns(4).Width = 230
                End If
                btnReports.Enabled = True
                If intAccessValue = 9 Then
                    'btnDelete.Enabled = True
                Else
                    'btnDelete.Enabled = False
                End If
            Else
                btnModify.Enabled = False
                btnReports.Enabled = False
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            btnAddNew.Enabled = False
            btnModify.Enabled = False
            'btnDelete.Enabled = False
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDSHeader As New DataSet
        Dim adoDSDetail As New DataSet
        Dim adoDS As New DataSet
        Dim objItem As ListViewItem
        Dim strResult As String
        Dim myForm As New frmRecieve01
        Dim adoRow As DataRow
        Dim lngMaxRecId As Long
        Dim strPONo As String

        Try
            'If Trim(txtPONO.Text) = "" Then
            '    lblPOStatus.Text = ""
            '    lblSupplierName.Text = ""
            '    btnSelect.Enabled = False
            '    btnAddNew.Enabled = False
            '    btnModify.Enabled = False
            '    Exit Sub
            'End If
            'If Trim(lblPOStatus.Text) = "" Or Trim(lblPOStatus.Text) = "Closed" Then
            '    MessageBox.Show("This PO has been closed, you can not recieve the Item.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            'adoDSHeader = svcWarehouse.GetPOHeadInfo("", "", txtPONO.Text, APP_ID)
            myForm.Initialize(True)
            'myForm.Recieve(adoDSHeader)
            'adoDSHeader.Dispose()
            'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDSHeader = myForm.GetDataSet01()
                adoDSDetail = myForm.GetDataSet02()
                strResult = svcWarehouse.AddNewRecieve(adoDSHeader, adoDSDetail, APP_ID)
                strPONo = adoDSHeader.Tables("RECIEVE_HEADER").Rows(0)("PO_NO")
                If strResult <> "" Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Form_Loop
                Else
                    adoDS = svcWarehouse.GetMaxRecId(strPONo, APP_ID)
                    If adoDS.Tables("MAX_RECID").Rows.Count > 0 Then
                        lngMaxRecId = adoDS.Tables("MAX_RECID").Rows(0)("MAX_REC_ID")
                    End If
                    adoDS.Dispose()

                    adoDS = svcWarehouse.GetRecieveHeader(strPONo, lngMaxRecId, APP_ID)
                    adoRow = adoDS.Tables("RECIEVEHEADER").Rows(0)
                    If adoDS.Tables("RECIEVEHEADER").Rows.Count > 0 Then
                        objItem = New ListViewItem(lvwList.Items.Count + 1)
                        lvwList.Items.Add(objItem)
                        objItem.SubItems.Add(Format(adoRow!RECIEVE_DATE, "dd MMM yyyy"))
                        objItem.SubItems.Add(adoRow!RECIEVE_BY)
                        objItem.SubItems.Add(adoRow!PO_NO)
                        objItem.SubItems.Add(adoRow!SUPPLIER_NAME)
                        objItem.SubItems.Add(adoRow!REC_ID)
                        objItem.Selected = True
                    End If
                    If adoRow!PO_STATUS = "C" And lblPOStatus.Text = "Open" Then
                        lblPOStatus.Text = "Closed"
                    End If
                    adoDS.Dispose()
                    If lvwList.Items.Count > 0 Then
                        lvwList.Items(0).Selected = True
                        btnModify.Enabled = True
                        If lvwList.Items.Count > 15 Then
                            lvwList.Columns(4).Width = 214
                        Else
                            lvwList.Columns(4).Width = 230
                        End If
                        btnReports.Enabled = True
                        If intAccessValue = 9 Then
                            'btnDelete.Enabled = True
                        Else
                            'btnDelete.Enabled = False
                        End If
                    Else
                        btnModify.Enabled = False
                        btnReports.Enabled = False
                    End If
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            myForm.grpPO.Enabled = False
            myForm.grpRecieve.Enabled = False
            myForm.grpItem.Enabled = False
            myForm.btnSave.Enabled = False
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (adoDSHeader Is Nothing) Then
                adoDSHeader.Dispose()
            End If
            If Not (adoDSDetail Is Nothing) Then
                adoDSDetail.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim adoDSPOHeader As New DataSet
        Dim adoDSPODetail As New DataSet
        Dim myForm As New frmRecieve01
        Dim adoDS As DataSet
        Dim adoRow As DataRow

        Try
            'If Trim(txtPONO.Text) = "" Then
            '    lblPOStatus.Text = ""
            '    lblSupplierName.Text = ""
            '    btnSelect.Enabled = False
            '    btnAddNew.Enabled = False
            '    btnModify.Enabled = False
            '    Exit Sub
            'End If
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item data in the list.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDSPOHeader = svcWarehouse.GetRecieveHeader(lvwList.SelectedItems.Item(0).SubItems(3).Text, lvwList.SelectedItems.Item(0).SubItems(5).Text, APP_ID)

            adoDSPODetail = svcWarehouse.GetRecieveDetail(lvwList.SelectedItems.Item(0).SubItems(3).Text, lvwList.SelectedItems.Item(0).SubItems(5).Text, APP_ID)
            If adoDSPODetail.Tables("RECIEVEDETAIL").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Fail while loading detail data!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            myForm.Initialize(False)
            myForm.FillField(adoDSPOHeader, adoDSPODetail)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDSPOHeader = myForm.GetDataSet01()
                adoDSPODetail = myForm.GetDataSet02()

                svcWarehouse.UpdateRecieve(adoDSPOHeader, adoDSPODetail, APP_ID)
                adoDS = svcWarehouse.GetRecieveHeader(lvwList.SelectedItems.Item(0).SubItems(3).Text, lvwList.SelectedItems.Item(0).SubItems(5).Text, APP_ID)

                If adoDS.Tables("RECIEVEHEADER").Rows.Count > 0 Then
                    For Each adoRow In adoDS.Tables("RECIEVEHEADER").Rows
                        lvwList.SelectedItems.Item(0).SubItems(1).Text = Format(adoRow!RECIEVE_DATE, "dd MMM yyyy")
                        lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!RECIEVE_BY
                        lvwList.SelectedItems.Item(0).SubItems(3).Text = adoRow!PO_NO
                        lvwList.SelectedItems.Item(0).SubItems(4).Text = adoRow!SUPPLIER_NAME
                        lvwList.SelectedItems.Item(0).SubItems(5).Text = adoRow!REC_ID
                    Next
                    If adoRow!PO_STATUS = "C" And lblPOStatus.Text = "Open" Then
                        lblPOStatus.Text = "Closed"
                    End If
                Else
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show("PO data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                adoDS.Dispose()

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                    btnModify.Enabled = True
                    If intAccessValue = 9 Then
                        'btnDelete.Enabled = True
                    Else
                        'btnDelete.Enabled = False
                    End If
                    btnReports.Enabled = True
                Else
                    btnModify.Enabled = False
                    btnReports.Enabled = False
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            myForm.grpPO.Enabled = False
            myForm.grpRecieve.Enabled = False
            myForm.grpItem.Enabled = False
            myForm.btnSave.Enabled = False
            GoTo Form_Loop
        Finally
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (adoDSPOHeader Is Nothing) Then
                adoDSPOHeader.Dispose()
            End If
            If Not (adoDSPODetail Is Nothing) Then
                adoDSPODetail.Dispose()
            End If
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
        End Try
    End Sub

    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '    Dim svcWarehouse As New Warehouse.svcWarehouse()
    '    Dim strResult As String
    '    Dim intSelectedItem As Integer
    '    Dim intCount As Integer
    '    Dim lngRecId As Long

    '    Try
    'If lvwList.Items.Count = 0 Then
    '    Exit Sub
    'End If
    'If lvwList.SelectedItems.Count = 0 Then
    '    MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Exit Sub
    'End If
    'If Trim(lblPOStatus.Text) = "Closed" Then
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '    MessageBox.Show("PO Status = Closed can not be delete!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Exit Sub
    'End If

    'If MessageBox.Show("Are you sure want to delete this Recieve Data?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    lngRecId = lvwList.SelectedItems.Item(0).SubItems(4).Text
    '    strResult = svcWarehouse.DeleteRecieve(lngRecId, APP_ID)
    '    If strResult <> "" Then
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '        MessageBox.Show(strResult, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    Else
    '        intSelectedItem = lvwList.SelectedItems.Item(0).Index
    '        lvwList.SelectedItems.Item(0).Remove()

    '        For intCount = 0 To lvwList.Items.Count - 1
    '            lvwList.Items(intCount).Text = intCount + 1
    '        Next

    '        If lvwList.Items.Count > 0 Then
    '            If (intSelectedItem) < lvwList.Items.Count Then
    '                lvwList.Items(intSelectedItem).Selected = True
    '            Else
    '                If (intSelectedItem) = lvwList.Items.Count Then
    '                    lvwList.Items(intSelectedItem - 1).Selected = True
    '                End If
    '            End If

    '            If intAccessValue = 9 Then
    '                btnDelete.Enabled = True
    '            Else
    '                btnDelete.Enabled = False
    '            End If
    '        Else
    '            btnModify.Enabled = False
    '            btnDelete.Enabled = False
    '        End If
    '    End If
    'End If
    'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    '    Catch ex As Exception
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '        ShowErrorMessage(ex.Message, ex.Source)
    '    Finally
    '        If Not (svcWarehouse Is Nothing) Then
    '            svcWarehouse.Dispose()
    '        End If
    '    End Try
    'End Sub

    Private Sub txtPONO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPONO.TextChanged
        lvwList.Items.Clear()
        lvwList.Columns(4).Width = 230
        lblPOStatus.Text = ""
        lblSupplierName.Text = ""
        btnSelect.Enabled = True
        btnModify.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub txtPONO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPONO.KeyDown
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim strResult As String
        Dim myForm As New frmLOV
        Dim adoDS As DataSet
        Dim adoRow As DataRow

        Try
            If e.KeyCode = e.KeyCode.F2 Then
                myForm.Initialize(txtPONO.Text, adoDsPO, "POLOV")

Form_Loop:
                myForm.ShowDialog()
                If myForm.GetCancelStatus = False Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    adoDS = myForm.GetDataSet()
                    If adoDS.Tables("RESOURCEINFO").Rows.Count > 0 Then
                        adoRow = adoDS.Tables("RESOURCEINFO").Rows(0)
                        txtPONO.Text = adoRow!RESOURCE_CODE
                        lblSupplierName.Text = adoRow!RESOURCE_DESC
                        adoDS.Dispose()

                        adoDS = svcWarehouse.GetPOHeadInfo("", "", txtPONO.Text, "", APP_ID)
                        If adoDS.Tables("POINFORMATION").Rows.Count > 0 Then
                            If Not IsDBNull(adoDS.Tables("POINFORMATION").Rows(0)("PO_STATUS")) Then
                                If adoDS.Tables("POINFORMATION").Rows(0)("PO_STATUS") = "O" Then
                                    lblPOStatus.Text = "Open"
                                Else
                                    lblPOStatus.Text = "Closed"
                                End If
                            End If
                        End If
                        adoDS.Dispose()
                    End If
                    btnSelect.Enabled = True
                    btnAddNew.Enabled = True
                    adoDS.Dispose()
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtPONO_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPONO.DoubleClick
        txtPONO_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.F2))
    End Sub

    Private Sub frmRecieve_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        lvwList.Items.Clear()
        lvwList.Columns(4).Width = 230
        btnSelect.Enabled = True
        btnModify.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        lvwList.Items.Clear()
        lvwList.Columns(4).Width = 230
        btnSelect.Enabled = True
        btnModify.Enabled = False
        btnReports.Enabled = False
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModify_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim myForm As New frmRecieveRpt

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            myForm.Initialize(lvwList.SelectedItems.Item(0).SubItems(1).Text, lvwList.SelectedItems.Item(0).SubItems(2).Text)
Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then

            End If

        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If Not (myForm Is Nothing) Then
                myForm.Dispose()
            End If
        End Try
    End Sub
End Class
