Public Class frmWarehouseRptStockList
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
    Friend WithEvents cboWarehouseName As System.Windows.Forms.ComboBox
    Friend WithEvents lblWhName As System.Windows.Forms.Label
    Friend WithEvents lblWarehouse As System.Windows.Forms.Label
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWarehouseRptStockList))
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.lblWhName = New System.Windows.Forms.Label
        Me.cboWarehouseName = New System.Windows.Forms.ComboBox
        Me.lblWarehouse = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(494, 390)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 26
        Me.btnPreview.Text = "&Preview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(582, 390)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.lvwList)
        Me.GroupBox1.Controls.Add(Me.lblWhName)
        Me.GroupBox1.Controls.Add(Me.cboWarehouseName)
        Me.GroupBox1.Controls.Add(Me.lblWarehouse)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 381)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(416, 40)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 38
        Me.btnSelect.Text = "&Select"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(4, 79)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(653, 296)
        Me.lvwList.TabIndex = 37
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item No."
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item Name"
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Category"
        Me.ColumnHeader4.Width = 165
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Stock QTY"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 75
        '
        'lblWhName
        '
        Me.lblWhName.AutoSize = True
        Me.lblWhName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhName.ForeColor = System.Drawing.Color.Black
        Me.lblWhName.Location = New System.Drawing.Point(216, 56)
        Me.lblWhName.Name = "lblWhName"
        Me.lblWhName.Size = New System.Drawing.Size(0, 17)
        Me.lblWhName.TabIndex = 36
        Me.lblWhName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboWarehouseName
        '
        Me.cboWarehouseName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboWarehouseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarehouseName.Location = New System.Drawing.Point(96, 40)
        Me.cboWarehouseName.Name = "cboWarehouseName"
        Me.cboWarehouseName.Size = New System.Drawing.Size(272, 21)
        Me.cboWarehouseName.TabIndex = 34
        '
        'lblWarehouse
        '
        Me.lblWarehouse.AutoSize = True
        Me.lblWarehouse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarehouse.ForeColor = System.Drawing.Color.Black
        Me.lblWarehouse.Location = New System.Drawing.Point(24, 42)
        Me.lblWarehouse.Name = "lblWarehouse"
        Me.lblWarehouse.Size = New System.Drawing.Size(68, 17)
        Me.lblWarehouse.TabIndex = 35
        Me.lblWarehouse.Text = "Warehouse :"
        Me.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please click on Preview button to view the report."
        '
        'frmWarehouseRptStockList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 416)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWarehouseRptStockList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock List - Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrWarehouseId() As String
    Dim arrDefaultValue() As String

    Private Sub frmWarehouseRptStockList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
        Dim AdoDS As New DataSet()
        Dim AdoRow As DataRow
        Dim I As Integer

        Try
            btnPreview.Enabled = False
            AdoDS = svcHouseKeeping.GetResourceCode("WAREHOUSE", "WAREHOUSE", APP_ID)
            If AdoDS.Tables(0).Rows.Count = 0 Then
                Close()
            End If

            ReDim arrWarehouseId(AdoDS.Tables("ResourceCode").Rows.Count - 1)
            ReDim arrDefaultValue(AdoDS.Tables("ResourceCode").Rows.Count - 1)
            I = 0
            For Each AdoRow In AdoDS.Tables(0).Rows
                cboWarehouseName.Items.Add(AdoRow!RESOURCE_DESC)
                arrWarehouseId(I) = AdoRow!RESOURCE_CODE
                arrDefaultValue(I) = AdoRow!DEFAULT_VALUE
                I = I + 1
            Next
            If cboWarehouseName.Items.Count >= 0 Then
                cboWarehouseName.SelectedIndex = 0
            End If
            btnPreview.Enabled = False

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(AdoDS) Then
                AdoDS.Dispose()
            End If
            If Not IsNothing(svcHouseKeeping) Then
                svcHouseKeeping.Dispose()
                svcHouseKeeping = Nothing
            End If
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim AdoDS As New DataSet()
        Dim svcWarehouse As New Warehouse.svcWarehouse()

        Try
            If lvwList.SelectedItems.Count = 0 Then
                Exit Sub
            End If
            If NullToString(cboWarehouseName.SelectedItem) = "" Then
                Exit Sub
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                svcWarehouse.Timeout = -1
                AdoDS = svcWarehouse.GetStockReport("", arrWarehouseId(cboWarehouseName.SelectedIndex), arrDefaultValue(cboWarehouseName.SelectedIndex), APP_ID)

                Generate_Report(AdoDS)
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            If Not IsNothing(AdoDS) Then
                AdoDS.Dispose()
            End If
            If Not IsNothing(svcWarehouse) Then
                svcWarehouse.Dispose()
                svcWarehouse = Nothing
            End If
        End Try

    End Sub

    'Private Sub cboWarehouseName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboWarehouseName.SelectionChangeCommitted
    '    Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
    '    Dim AdoDS As New DataSet()

    '    Try
    '        AdoDS = svcHouseKeeping.GetResourceCodeDetail("WAREHOUSE", "WAREHOUSE", NullToString(cboWarehouseName.SelectedItem), APP_ID)
    '        If AdoDS.Tables(0).Rows.Count <> 0 Then
    '            lblWhName.Text = AdoDS.Tables(0).Rows(0).Item("RESOURCE_DESC")
    '        End If

    '    Catch ex As Exception
    '        ShowErrorMessage(ex.Message, ex.Source)
    '    Finally
    '        If Not IsNothing(AdoDS) Then
    '            AdoDS.Dispose()
    '        End If
    '        If Not IsNothing(svcHouseKeeping) Then
    '            svcHouseKeeping.Dispose()
    '            svcHouseKeeping = Nothing
    '        End If
    '    End Try
    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
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
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_STOCK_LIST.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)
            'xlWs.Cells(5, 3) = cboWarehouseName.Text
            xlWs.Cells(3, 7) = "Print Date: " & Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 7) = "Print Time: " & Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1
            For Each adoRow In adoDS.Tables("STOCK").Rows
                xlWs.Cells(I, 1) = "'" & intNou & "."
                xlWs.Cells(I, 2) = "'" & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 3) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 4) = CStr(adoRow!STOCK_QTY)
                xlWs.Cells(I, 5) = NullToString(adoRow!CATEGORY)
                xlWs.Cells(I, 6) = CStr(adoRow!HARGA_BELI)
                xlWs.Cells(I, 7) = CStr(adoRow!HARGA_POKOK)
                xlWs.Cells(I, 8) = CStr(adoRow!HARGA_JUAL)
                xlWs.Cells(I, 9) = NullToString(adoRow!AREA_NAME)
                I = I + 1
                intNou = intNou + 1
            Next
            I = I + 1
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
            I = I + 1
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 6)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 7)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
            Throw ex
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim myDS As New DataSet
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim strActiveStatus As String

        Try
            If cboWarehouseName.Text = "" Then
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            myDS = svcWarehouse.GetStock("", arrWarehouseId(cboWarehouseName.SelectedIndex), arrDefaultValue(cboWarehouseName.SelectedIndex), APP_ID)

            If myDS.Tables("STOCK").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("STOCK").Rows
                    objItem = New ListViewItem(lvwList.Items.Count + 1)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(adoRow!ITEM_NO)
                    objItem.SubItems.Add(adoRow!ITEM_NAME)
                    objItem.SubItems.Add(adoRow!CATEGORY_NAME)
                    objItem.SubItems.Add(adoRow!STOCK_QTY)
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Stock data are not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnPreview.Enabled = True
            Else
                btnPreview.Enabled = False
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            myDS.Dispose()
            svcWarehouse.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cboWarehouseName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWarehouseName.SelectedIndexChanged
        lvwList.Items.Clear()
        btnPreview.Enabled = False
    End Sub
End Class
