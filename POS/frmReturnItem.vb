Public Class frmReturnItem
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
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReturnItem))
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(561, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(472, 395)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(80, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.Location = New System.Drawing.Point(384, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lvwList)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(1, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 277)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return Item Information"
        '
        'lvwList
        '
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(3, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(636, 257)
        Me.lvwList.TabIndex = 4
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Return Id"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Return Date"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Return By"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Name"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Return QTY"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 112)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'dtpEnd
        '
        Me.dtpEnd.Checked = False
        Me.dtpEnd.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(257, 51)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowCheckBox = True
        Me.dtpEnd.Size = New System.Drawing.Size(127, 21)
        Me.dtpEnd.TabIndex = 1
        Me.dtpEnd.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(236, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "To"
        '
        'dtpStart
        '
        Me.dtpStart.Checked = False
        Me.dtpStart.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(104, 51)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowCheckBox = True
        Me.dtpStart.Size = New System.Drawing.Size(128, 21)
        Me.dtpStart.TabIndex = 0
        Me.dtpStart.Value = New Date(2003, 11, 21, 0, 0, 0, 0)
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(35, 54)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(69, 17)
        Me.lblTransDate.TabIndex = 67
        Me.lblTransDate.Text = "Return Date:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(536, 78)
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
        Me.Label1.Location = New System.Drawing.Point(48, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in the Item No. then click on the select button to view item information."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(104, 80)
        Me.txtItemCode.MaxLength = 20
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(152, 21)
        Me.txtItemCode.TabIndex = 2
        Me.txtItemCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(52, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReturnItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(644, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReturnItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Return Item"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim intAccessValue As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmReturnItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()

        Try
            dtpStart.Value = Now
            dtpEnd.Value = Now
            dtpStart.Checked = True
            dtpEnd.Checked = True
            dtpStart.Checked = False
            dtpEnd.Checked = False

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            intAccessValue = svcSecurity.GetUserAccessValue(USER_ID, "POS", APP_ID)
            btnAddNew.Enabled = True
            btnModify.Enabled = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        btnModify_Click(sender, e)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim svcPOS As New POS.svcPOS()
        Dim myDS As New DataSet()
        Dim adoRow As DataRow
        Dim objItem As ListViewItem
        Dim strItemNo As String
        Dim strReturnId As String
        Dim strStartDate As String
        Dim strEndDate As String

        Try
            If dtpStart.Checked = True And _
                dtpEnd.Checked = True Then
                If dtpStart.Value > dtpEnd.Value Then
                    MessageBox.Show("Start Date must be less or Equal than End Date. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lvwList.Items.Clear()
            If Trim(txtItemCode.Text) = "" Then
                strItemNo = ""
            Else
                strItemNo = txtItemCode.Text
            End If
            If dtpStart.Checked Then
                strStartDate = Format(dtpStart.Value, "dd/MM/yyyy")
            Else
                strStartDate = ""
            End If
            If dtpEnd.Checked Then
                strEndDate = Format(dtpEnd.Value, "dd/MM/yyyy")
            Else
                strEndDate = ""
            End If

            myDS = svcPOS.GetReturnItem(strStartDate, strEndDate, strItemNo, APP_ID)

            If myDS.Tables("RETURN_ITEM").Rows.Count > 0 Then
                For Each adoRow In myDS.Tables("RETURN_ITEM").Rows
                    strReturnId = adoRow!RETURN_ID

                    objItem = New ListViewItem(strReturnId)
                    lvwList.Items.Add(objItem)
                    objItem.SubItems.Add(Format(adoRow!RETURN_DATE, "dd-MMM-yyyy"))
                    objItem.SubItems.Add(adoRow!RETURN_BY)
                    objItem.SubItems.Add(NullToString(adoRow!ITEM_NAME))
                    objItem.SubItems.Add(adoRow!QTY)
                    objItem.Selected = True
                Next
            Else
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("Return Item Information is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If lvwList.Items.Count > 0 Then
                lvwList.Items(0).Selected = True
                btnAddNew.Enabled = True
                btnModify.Enabled = True
            Else
                btnAddNew.Enabled = True
                btnModify.Enabled = False
            End If
            'If lvwList.Items.Count > 15 Then
            '    lvwList.Columns(1).Width = 164
            'Else
            '    lvwList.Columns(1).Width = 180
            'End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (myDS Is Nothing) Then
                myDS.Dispose()
            End If
            If Not (svcPOS Is Nothing) Then
                svcPOS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim svcPOS As New POS.svcPOS()
        Dim adoDSReturn As New DataSet()
        Dim myForm As New frmReturnItem01()
        Dim adoRow As DataRow
        Dim strReturnId As String
        Dim adoDS As New DataSet()

        Try
            If lvwList.Items.Count = 0 Then
                Exit Sub
            End If
            If lvwList.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select one of item!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            strReturnId = lvwList.SelectedItems.Item(0).SubItems(0).Text
            adoDSReturn = svcPOS.GetReturnItemData(strReturnId, APP_ID)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            myForm.FillField(adoDSReturn, False)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

                adoDS = myForm.GetDataSet()
                svcPOS.UpdateReturn(adoDS, APP_ID)

                adoRow = adoDS.Tables("RETURN_ITEM").Rows(0)
                lvwList.SelectedItems.Item(0).SubItems(0).Text = adoRow!RETURN_ID
                lvwList.SelectedItems.Item(0).SubItems(1).Text = Format(adoRow!RETURN_DATE, "dd-MMM-yyyy")
                lvwList.SelectedItems.Item(0).SubItems(2).Text = adoRow!RETURN_BY
                lvwList.SelectedItems.Item(0).SubItems(3).Text = adoRow!ITEM_NAME
                lvwList.SelectedItems.Item(0).SubItems(4).Text = adoRow!QTY

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                    If intAccessValue = 9 Then
                        btnModify.Enabled = True
                    Else
                        btnModify.Enabled = False
                    End If
                Else
                    btnModify.Enabled = False
                End If
                'If lvwList.Items.Count > 15 Then
                '    lvwList.Columns(2).Width = 214
                'Else
                '    lvwList.Columns(2).Width = 230
                'End If
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
            GoTo Form_Loop
        Finally
            If Not (svcPOS Is Nothing) Then
                svcPOS.Dispose()
            End If
            If Not (adoDSReturn Is Nothing) Then
                adoDSReturn.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode.TextChanged
        lvwList.Items.Clear()
        btnModify.Enabled = False
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim svcPOS As New POS.svcPOS()
        Dim adoDS As New DataSet()
        Dim objItem As ListViewItem
        Dim strReturnId As String
        Dim myForm As New frmReturnItem01()
        Dim adoRow As DataRow

        Try
            adoDS = svcPOS.CheckItemStock(txtItemCode.Text, APP_ID)
            If adoDS.Tables("ITEM_STOCK").Rows.Count <= 0 Then
                MessageBox.Show("This Item is not available in the warehouse stock. ", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                adoDS.Dispose()
                Exit Sub
            End If
            myForm.Initialize(False)
            myForm.FillField(adoDS, True)

Form_Loop:
            myForm.ShowDialog()
            If myForm.GetCancelStatus = False Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS.Dispose()

                adoDS = myForm.GetDataSet()
                strReturnId = svcPOS.AddNewReturn(adoDS, APP_ID)
                adoDS.Dispose()

                adoDS = svcPOS.GetReturnItemData(strReturnId, APP_ID)
                adoRow = adoDS.Tables("RETURN_ITEM").Rows(0)

                lvwList.Items.Clear()
                objItem = New ListViewItem(strReturnId)
                lvwList.Items.Add(objItem)

                objItem.SubItems.Add(Format(adoRow!RETURN_DATE, "dd-MMM-yyyy"))
                objItem.SubItems.Add(adoRow!RETURN_BY)
                objItem.SubItems.Add(NullToString(adoRow!ITEM_NAME))
                objItem.SubItems.Add(adoRow!QTY)
                objItem.Selected = True

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                    If intAccessValue = 9 Then
                        btnModify.Enabled = True
                    Else
                        btnModify.Enabled = False
                    End If
                Else
                    btnModify.Enabled = False
                End If
                'If lvwList.Items.Count > 15 Then
                '    lvwList.Columns(2).Width = 214
                'Else
                '    lvwList.Columns(2).Width = 230
                'End If
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
            If Not (svcPOS Is Nothing) Then
                svcPOS.Dispose()
            End If
        End Try
    End Sub

    Private Sub frmReturnItem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnSelect.Focus()
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        lvwList.Items.Clear()
        btnModify.Enabled = False
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        lvwList.Items.Clear()
        btnModify.Enabled = False
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If lvwList.SelectedItems.Count <> 0 Then
            If e.KeyCode = e.KeyCode.Enter Then
                btnModify_Click(sender, e)
            End If
        End If
    End Sub
End Class
