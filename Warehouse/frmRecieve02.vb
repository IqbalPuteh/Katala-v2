Public Class frmRecieve02
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecieveQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtTotalRecieve As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOutstandingQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecieve02))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtOutstandingQTY = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalRecieve = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRecieveQTY = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOrderQTY = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnInput = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtOutstandingQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalRecieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecieveQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtOrderQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtOutstandingQTY)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTotalRecieve)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtRecieveQTY)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 253)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recieve Information"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(650, 1)
        Me.Label6.TabIndex = 76
        '
        'txtOutstandingQTY
        '
        Me.txtOutstandingQTY.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtOutstandingQTY.Enabled = False
        Me.txtOutstandingQTY.Location = New System.Drawing.Point(344, 27)
        Me.txtOutstandingQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtOutstandingQTY.Name = "txtOutstandingQTY"
        Me.txtOutstandingQTY.Size = New System.Drawing.Size(54, 21)
        Me.txtOutstandingQTY.TabIndex = 7
        Me.txtOutstandingQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(248, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Outstanding QTY:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalRecieve
        '
        Me.txtTotalRecieve.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTotalRecieve.Enabled = False
        Me.txtTotalRecieve.Location = New System.Drawing.Point(80, 27)
        Me.txtTotalRecieve.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtTotalRecieve.Name = "txtTotalRecieve"
        Me.txtTotalRecieve.Size = New System.Drawing.Size(54, 21)
        Me.txtTotalRecieve.TabIndex = 6
        Me.txtTotalRecieve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Total Recieve:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecieveQTY
        '
        Me.txtRecieveQTY.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtRecieveQTY.Location = New System.Drawing.Point(80, 70)
        Me.txtRecieveQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtRecieveQTY.Name = "txtRecieveQTY"
        Me.txtRecieveQTY.Size = New System.Drawing.Size(54, 21)
        Me.txtRecieveQTY.TabIndex = 0
        Me.txtRecieveQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Recieve QTY:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOrderQTY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtItemNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 106)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information"
        '
        'txtOrderQTY
        '
        Me.txtOrderQTY.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrderQTY.Enabled = False
        Me.txtOrderQTY.Location = New System.Drawing.Point(81, 72)
        Me.txtOrderQTY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtOrderQTY.Name = "txtOrderQTY"
        Me.txtOrderQTY.Size = New System.Drawing.Size(54, 21)
        Me.txtOrderQTY.TabIndex = 5
        Me.txtOrderQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Order QTY:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(81, 48)
        Me.txtItemName.MaxLength = 10
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(322, 21)
        Me.txtItemName.TabIndex = 4
        Me.txtItemName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Item Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtItemNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemNo.Enabled = False
        Me.txtItemNo.Location = New System.Drawing.Point(81, 24)
        Me.txtItemNo.MaxLength = 10
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(112, 21)
        Me.txtItemNo.TabIndex = 3
        Me.txtItemNo.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Item No.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInput.Location = New System.Drawing.Point(502, 372)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(80, 24)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "&Input"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(590, 372)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Close"
        '
        'frmRecieve02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(674, 400)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecieve02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Recieve Item"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtOutstandingQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalRecieve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecieveQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtOrderQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim blnAddNew As Boolean
    Dim blnCancel As Boolean

    Public Sub Initialize(ByVal blnAdd As Boolean)
        blnAddNew = blnAdd
    End Sub

    Public Sub FillField(ByVal strItemNo As String, _
                         ByVal strItemName As String, _
                         ByVal strOrderQTY As String, _
                         ByVal strTotalRecieve As String, _
                         ByVal strOutstandingQTY As String, _
                         ByVal strRecieveQTY As String)

        Try
            txtItemNo.Text = strItemNo
            txtItemName.Text = strItemName
            txtOrderQTY.Text = strOrderQTY
            txtTotalRecieve.Text = strTotalRecieve
            txtRecieveQTY.Text = strRecieveQTY
            txtOutstandingQTY.Text = strOutstandingQTY

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Public Function GetDataSet() As DataSet
        Dim adoDSRecieve As New DataSet()

        Try
            adoDSRecieve = CreateResourceCodeRs()
            FillDataSet(adoDSRecieve)

            GetDataSet = adoDSRecieve

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("RECIEVE")

        adoColumn = New DataColumn("ITEM_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("RECIEVE_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("OUTSTANDING_QTY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("RECIEVE").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()

        Try
            adoDataTable = adoDS.Tables("RECIEVE")
            adoDataRow = adoDataTable.NewRow()

            adoDataRow("ITEM_NO") = txtItemNo.Text
            adoDataRow("RECIEVE_QTY") = txtRecieveQTY.Value
            adoDataRow("OUTSTANDING_QTY") = txtOutstandingQTY.Value
            adoDataTable.Rows.Add(adoDataRow)

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If txtRecieveQTY.Text = 0 Then
            MessageBox.Show("The Field can not be = 0, Please type the correct number.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRecieveQTY.Focus()
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Private Sub txtRecieveQTY_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecieveQTY.ValueChanged
        Dim lngOrder As Long
        Dim lngTotalRecieve As Long
        Dim lngOutstanding As Long
        Dim lngRecieve As Long

        lngOrder = txtOrderQTY.Value
        lngRecieve = txtRecieveQTY.Value
        lngTotalRecieve = txtTotalRecieve.Value + txtRecieveQTY.Value
        lngOutstanding = lngOrder - lngTotalRecieve

        If lngOutstanding > 0 Then
            txtOutstandingQTY.Text = lngOutstanding
        Else
            txtOutstandingQTY.Text = "0"
        End If
    End Sub

    Private Sub txtRecieveQTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRecieveQTY.Enter
        txtRecieveQTY.Select(0, txtRecieveQTY.Text.Length)
    End Sub

    Private Sub frmRecieve02_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtRecieveQTY.Focus()
    End Sub
End Class
