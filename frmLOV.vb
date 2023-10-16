Public Class frmLOV
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lvwList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLOV))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvwList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvwList)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Data"
        '
        'lvwList
        '
        Me.lvwList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvwList.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.lvwList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwList.FullRowSelect = True
        Me.lvwList.HideSelection = False
        Me.lvwList.Location = New System.Drawing.Point(0, 17)
        Me.lvwList.MultiSelect = False
        Me.lvwList.Name = "lvwList"
        Me.lvwList.Size = New System.Drawing.Size(525, 136)
        Me.lvwList.TabIndex = 2
        Me.lvwList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 35
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Id."
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 335
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(80, 168)
        Me.txtSearch.MaxLength = 5000
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(424, 21)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Search:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(416, 200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(312, 200)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 24)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&Ok"
        '
        'frmLOV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(528, 232)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLOV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Look Up Value"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnCancel As Boolean
    Dim g_adoDS As DataSet
    Dim g_strTableName As String
    Dim blnValidate As Boolean
    Dim blnSearch As Boolean

    Public Sub Initialize(ByVal strSearch As String, ByVal adoDS As DataSet, ByVal strTableName As String)
        g_adoDS = adoDS
        g_strTableName = strTableName
        blnValidate = True
        blnSearch = False
        txtSearch.Text = strSearch
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateResourceCodeRs()
            FillDataSet(myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        Try
            adoDS.Tables.Add("RESOURCEINFO")

            adoColumn = New DataColumn("RESOURCE_CODE")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("RESOURCEINFO").Columns.Add(adoColumn)

            adoColumn = New DataColumn("RESOURCE_DESC")
            adoColumn.DataType = System.Type.GetType("System.String")
            adoDS.Tables("RESOURCEINFO").Columns.Add(adoColumn)

            CreateResourceCodeRs = adoDS

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        Try
            adoDataTable = adoDS.Tables("RESOURCEINFO")
            adoDataRow = adoDataTable.NewRow()
            If lvwList.Items.Count > 0 Then
                adoDataRow("RESOURCE_CODE") = lvwList.SelectedItems.Item(0).SubItems(1).Text
                adoDataRow("RESOURCE_DESC") = lvwList.SelectedItems.Item(0).SubItems(2).Text
            Else
                adoDataRow("RESOURCE_CODE") = ""
                adoDataRow("RESOURCE_DESC") = ""
            End If
            adoDataTable.Rows.Add(adoDataRow)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub frmLOV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lngRow As Long
        Dim adoRow As DataRow
        Dim objItem As ListViewItem

        Try
            blnCancel = True
            If blnSearch = False Then
                If Not (g_adoDS Is Nothing) Then
                    If g_adoDS.Tables(g_strTableName).Rows.Count > 0 Then
                        For Each adoRow In g_adoDS.Tables(g_strTableName).Rows
                            objItem = New ListViewItem(lvwList.Items.Count + 1)
                            lvwList.Items.Add(objItem)
                            objItem.SubItems.Add(adoRow.Item(0))
                            objItem.SubItems.Add(adoRow.Item(1))
                            'objItem.Selected = True

                        Next
                    End If
                    g_adoDS.Dispose()
                End If

                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                End If

                If lvwList.Items.Count > 8 Then
                    lvwList.Columns(1).Width = 134
                Else
                    lvwList.Columns(1).Width = 150
                End If
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub lvwList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwList.DoubleClick
        blnValidate = False

        If lvwList.SelectedItems.Item(0).Selected = True And lvwList.SelectedItems.Item(0).SubItems(1).Text <> "" Then
            txtSearch.Text = lvwList.SelectedItems.Item(0).SubItems(1).Text & "-" & lvwList.SelectedItems.Item(0).SubItems(2).Text
            btnOK_Click(sender, e)
        End If
    End Sub

    Private Sub lvwList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwList.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            blnValidate = False

            If lvwList.SelectedItems.Item(0).Selected = True And lvwList.SelectedItems.Item(0).SubItems(1).Text <> "" Then
                txtSearch.Text = lvwList.SelectedItems.Item(0).SubItems(1).Text & "-" & lvwList.SelectedItems.Item(0).SubItems(2).Text
                btnOK_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim adoDataRow As DataRow
        Dim objItem As ListViewItem

        Try
            If blnValidate = True Then
                blnSearch = True

                lvwList.Items.Clear()
                For Each adoDataRow In g_adoDS.Tables(g_strTableName).Rows
                    If (UCase(adoDataRow.Item(0)) & UCase(adoDataRow.Item(1)) Like ("*" & ValidateString(UCase(txtSearch.Text)) & "*")) Then
                        objItem = New ListViewItem(lvwList.Items.Count + 1)
                        lvwList.Items.Add(objItem)
                        objItem.SubItems.Add(adoDataRow.Item(0))
                        objItem.SubItems.Add(adoDataRow.Item(1))
                        'objItem.Selected = True

                    End If
                Next
                If lvwList.Items.Count > 0 Then
                    lvwList.Items(0).Selected = True
                End If

                If lvwList.Items.Count > 8 Then
                    lvwList.Columns(1).Width = 134
                Else
                    lvwList.Columns(1).Width = 150
                End If
            End If
            blnValidate = True

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub frmLOV_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtSearch.Focus()
    End Sub
End Class
