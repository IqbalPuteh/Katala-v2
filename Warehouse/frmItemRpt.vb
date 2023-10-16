Public Class frmItemRpt
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaldo As System.Windows.Forms.Button
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblItemNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPrice As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemRpt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPrice = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblItemNo = New System.Windows.Forms.Label
        Me.lblItemName = New System.Windows.Forms.Label
        Me.btnSaldo = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnPrice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblItemNo)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.btnSaldo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 340)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(136, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Saldo Price Item"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(32, 120)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(96, 24)
        Me.btnPrice.TabIndex = 12
        Me.btnPrice.Text = "&Run Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(136, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Saldo Stock Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemNo
        '
        Me.lblItemNo.AutoSize = True
        Me.lblItemNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemNo.ForeColor = System.Drawing.Color.Black
        Me.lblItemNo.Location = New System.Drawing.Point(85, 26)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(54, 17)
        Me.lblItemNo.TabIndex = 10
        Me.lblItemNo.Text = "Item No."
        Me.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(258, 26)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(68, 17)
        Me.lblItemName.TabIndex = 9
        Me.lblItemName.Text = "Item Name"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(32, 64)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(96, 24)
        Me.btnSaldo.TabIndex = 7
        Me.btnSaldo.Text = "&Run Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(511, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'frmItemRpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(594, 376)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean

    Public Sub Initialize(ByVal strItemNo As String, ByVal strItemName As String)
        lblItemNo.Text = Trim(strItemNo)
        lblItemName.Text = Trim(strItemName)
        blnCancel = False
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Private Sub btnSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldo.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim DSRecieve As DataSet
        Dim DSMovement As DataSet
        Dim DSAdjust As DataSet
        Dim DSStock As DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If lblItemNo.Text = "" Or lblItemName.Text = "" Then
                Exit Sub
            End If

            DSRecieve = svcWarehouse.GetRptRecieveItem(Trim(lblItemNo.Text), APP_ID)
            DSMovement = svcWarehouse.GetRptMoveItem(Trim(lblItemNo.Text), APP_ID)
            DSAdjust = svcWarehouse.GetRptAdjustItem(Trim(lblItemNo.Text), APP_ID)
            DSStock = svcWarehouse.GetStockQTY(lblItemNo.Text, APP_ID)

            Generate_Report1(DSRecieve, DSMovement, DSAdjust, DSStock)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (DSRecieve Is Nothing) Then
                DSRecieve.Dispose()
            End If
            If Not (DSMovement Is Nothing) Then
                DSMovement.Dispose()
            End If
            If Not (DSAdjust Is Nothing) Then
                DSAdjust.Dispose()
            End If
            If Not (DSStock Is Nothing) Then
                DSStock.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report1(ByVal DSRecieve As DataSet, _
                                 ByVal DSMovement As DataSet, _
                                 ByVal DSAdjust As DataSet, _
                                 ByVal DSStock As DataSet)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        Dim intNou As Int16
        Dim I As Int16
        Dim intRecieve As Int16
        Dim intMovement As Int16
        Dim intAdjustAdd As Int16
        Dim intAdjustMinus As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String

        Try
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_SALDO_STOCK.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 8) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 8) = Format(Now, "hh:mm tt")

            xlWs.Cells(7, 1) = "'" & lblItemNo.Text
            xlWs.Cells(7, 2) = lblItemName.Text

            I = 11
            intNou = 1
            For Each adoRow In DSRecieve.Tables("RECIEVE_ITEM").Rows
                xlWs.Cells(I, 2) = Format(adoRow!RECIEVE_DATE, "dd/MMM/yyyy") & " - " & adoRow!WAREHOUSE_NAME
                xlWs.Cells(I, 3) = "'" & adoRow!PO_NO
                xlWs.Cells(I, 4) = "'" & adoRow!RECIEVE_QTY

                I = I + 1
                intNou = intNou + 1
                intRecieve = intRecieve + adoRow!RECIEVE_QTY
            Next
            I = 11
            For Each adoRow In DSMovement.Tables("MOVE_ITEM").Rows
                xlWs.Cells(I, 7) = Format(adoRow!MOV_DATE, "dd/MMM/yyyy") & " - From " & adoRow!WAREHOUSE_FROM & " to " & adoRow!WAREHOUSE_TO
                xlWs.Cells(I, 8) = "'" & adoRow!MOV_QTY

                I = I + 1
                If (I - 11) > intNou Then
                    intNou = intNou + 1
                End If
                intMovement = intMovement + adoRow!MOV_QTY
            Next
            I = 11
            For Each adoRow In DSAdjust.Tables("ADJUST_ITEM").Rows
                xlWs.Cells(I, 11) = Format(adoRow!ADJ_DATE, "dd/MMM/yyyy") & " - " & adoRow!WAREHOUSE_NAME
                If adoRow!ADD_QTY <> 0 Then
                    xlWs.Cells(I, 12) = "'" & adoRow!ADD_QTY
                Else
                    xlWs.Cells(I, 13) = "'" & adoRow!MINUS_QTY
                End If

                I = I + 1
                If (I - 11) > intNou Then
                    intNou = intNou + 1
                End If
                intAdjustAdd = intAdjustAdd + adoRow!ADD_QTY
                intAdjustMinus = intAdjustMinus + adoRow!MINUS_QTY
            Next
            For Each adoRow In DSStock.Tables("STOCK_QTY").Rows
                If adoRow!WAREHOUSE = "Y" Then
                    xlWs.Cells(7, 3) = "'" & adoRow!STOCK_QTY
                Else
                    xlWs.Cells(7, 4) = "'" & adoRow!STOCK_QTY
                End If
            Next

            I = 12 + intNou
            xlWs.Cells(I, 3) = "Total: "
            xlWs.Cells(I, 4) = "'" & intRecieve
            xlWs.Range(xlWs.Cells(I, 3), xlWs.Cells(I, 4)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
            xlWs.Cells(I, 7) = "Total: "
            xlWs.Cells(I, 8) = "'" & intMovement
            xlWs.Range(xlWs.Cells(I, 7), xlWs.Cells(I, 8)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

            xlWs.Cells(I, 11) = "Total: "
            xlWs.Cells(I, 12) = "'" & intAdjustAdd
            xlWs.Cells(I, 13) = "'" & intAdjustMinus
            xlWs.Range(xlWs.Cells(I, 11), xlWs.Cells(I, 13)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

            I = 13 + intNou
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
            Throw ex
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report2(ByVal DSPriceItem As DataSet)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String

        Try
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\WAREHOUSE_SALDO_PRICE.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 8) = Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 8) = Format(Now, "hh:mm tt")

            xlWs.Cells(7, 1) = "'" & lblItemNo.Text
            xlWs.Cells(7, 2) = lblItemName.Text

            I = 11
            For Each adoRow In DSPriceItem.Tables("PRICE_ITEM").Rows
                xlWs.Cells(I, 2) = Format(adoRow!REVIEWED_DATE, "dd/MMM/yyyy") & " - " & adoRow!REVIEWED_BY
                xlWs.Cells(I, 3) = Format(adoRow!BUY_PRICE, "#0")
                xlWs.Cells(I, 4) = "'" & Format(adoRow!GROSS_PRICE, "#0")
                xlWs.Cells(I, 5) = "'" & Format(adoRow!SELL_PRICE, "#0")
                xlWs.Cells(I, 6) = "'" & adoRow!MARK_UP
                xlWs.Cells(I, 7) = "'" & adoRow!MIN_VALUE
                xlWs.Cells(I, 8) = "'" & adoRow!MAX_VALUE

                I = I + 1
            Next

            I = I + 3
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
            Throw ex
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrice.Click
        Dim svcWarehouse As New Warehouse.svcWarehouse
        Dim DSPriceItem As DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If lblItemNo.Text = "" Or lblItemName.Text = "" Then
                Exit Sub
            End If

            DSPriceItem = svcWarehouse.GetRptPriceItem(Trim(lblItemNo.Text), APP_ID)

            Generate_Report2(DSPriceItem)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (DSPriceItem Is Nothing) Then
                DSPriceItem.Dispose()
            End If
            If Not (svcWarehouse Is Nothing) Then
                svcWarehouse.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
