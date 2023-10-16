Public Class frmRecommendedOrder
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
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecommendedOrder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvwList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvwList})
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 387)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Item Information"
        '
        'lvwList
        '
        Me.lvwList.AllowColumnReorder = True
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(0, 20)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(722, 360)
        Me.lvwList.TabIndex = 1
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
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Item Name"
        Me.ColumnHeader5.Width = 215
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Warehouse"
        Me.ColumnHeader3.Width = 145
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock QTY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Min. QTY"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Max. QTY"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 73
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(559, 394)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "&Preview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(647, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        '
        'frmRecommendedOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(730, 421)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPreview, Me.btnClose, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecommendedOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recommended Order - Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private adoDS As New DataSet()

    Private Sub frmRecommendedOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcWareHouse As New Warehouse.svcWarehouse()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            svcWareHouse.Timeout = -1
            adoDS = svcWareHouse.GetROItem(APP_ID)
            For Each adoRow In adoDS.Tables("LISTITEMRO").Rows
                objItem = New ListViewItem(lvwList.Items.Count + 1)
                lvwList.Items.Add(objItem)
                objItem.SubItems.Add(adoRow!ITEM_NO)
                objItem.SubItems.Add(adoRow!ITEM_NAME)
                objItem.SubItems.Add(adoRow!WAREHOUSE_NAME)
                objItem.SubItems.Add(adoRow!STOCK_QTY)
                objItem.SubItems.Add(adoRow!MIN_VALUE)
                objItem.SubItems.Add(adoRow!MAX_VALUE)
                objItem.Selected = True
            Next

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnPreview.Enabled = True
            Else
                btnPreview.Enabled = False
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (svcWareHouse Is Nothing) Then
                svcWareHouse.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If Not IsNothing(adoDS) Then
                Generate_Report(adoDS)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        Try
            If IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
        Catch ex As Exception
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
        Dim sngSumTotalPrice As Single

        Try
            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_RECOMENDED_ORDER.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 8) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 8) = Format(Now, "hh:mm tt")
            I = 7
            intNou = 1
            For Each adoRow In adoDS.Tables("LISTITEMRO").Rows
                xlWs.Cells(I, 1) = CInt(intNou) & "."
                xlWs.Cells(I, 2) = "'" & NullToString(adoRow!ITEM_NO)
                xlWs.Cells(I, 3) = NullToString(adoRow!ITEM_NAME)
                xlWs.Cells(I, 4) = NullToString(adoRow!STOCK_QTY)
                xlWs.Cells(I, 5) = NullToString(adoRow!MIN_VALUE)
                xlWs.Cells(I, 6) = NullToString(adoRow!MAX_VALUE)
                xlWs.Cells(I, 7) = NullToString(adoRow!WAREHOUSE_NAME)
                I += 1
                intNou += 1
            Next
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            I = I + 1
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).Merge()
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 8)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
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
