Imports System.IO
Imports System.Drawing.Printing
Public Class frmMembershipSaving01
    Inherits System.Windows.Forms.Form

    Private streamToPrint As StreamReader
    Dim arrStrTemp() As String
    Private printFont As Font
    Private adoDS As DataSet
    Dim alStringVal As New System.Collections.ArrayList
    Dim intPage As Int16

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents txtPrint As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipSaving01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPrint = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrint)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 112)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Criteria"
        '
        'txtPrint
        '
        Me.txtPrint.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPrint.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrint.Location = New System.Drawing.Point(128, 48)
        Me.txtPrint.MaxLength = 2
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(56, 21)
        Me.txtPrint.TabIndex = 1
        Me.txtPrint.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start Print Line #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter data below and click on OK button !"
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(224, 117)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 19
        Me.btnPreview.Text = "&OK"
        '
        'frmMembershipSaving01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(306, 144)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipSaving01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Confirmation"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Initialize(ByVal AdoDS As DataSet)
        Me.adoDS = AdoDS
    End Sub

    Private Sub txtPrint_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrint.KeyDown
        If Asc(e.KeyCode) > 47 And Asc(e.KeyCode) < 58 Then
            'do nothing
            Me.btnPreview.Enabled = True
        Else
            txtPrint.Text = ""
            Me.btnPreview.Enabled = False
        End If
    End Sub

    Private Sub frmMembershipSaving01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtPrint.Text = 1
        Me.btnPreview.Enabled = False
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim myForm As New frmMembershipSaving02
        Dim pd As New PrintDocument

        Dim a As New System.Drawing.Printing.PageSettings
        Dim x As New System.Drawing.Printing.PrinterSettings
        Dim y As New System.Drawing.Printing.PaperSize("PassBook", 610, 700)
        Dim z As New System.Drawing.Printing.Margins(0, 0, 70, 10)
        Dim intRecordCount As Int32 = 0
        Dim str1, str2, str3, str4, str5, str6 As String
        Dim adoRow As DataRow
        Dim intPrintLoop As Int32
        Dim intCurrLine As Int16
        Dim intVal, intOrigVal As Int16
        Dim strTemp As String

        Try
            '*/ setup printing properties */
            a.PaperSize = y
            a.Margins = z
            x.Copies = 1
            a.PrinterSettings = x
            pd.DefaultPageSettings = a
            printFont = New Font("Courier New", 8)
            AddHandler pd.PrintPage, AddressOf Me.pdTrans_PrintPage

            '*/ validate start print line input /*
            intVal = Convert.ToInt16(Me.txtPrint.Text)
            If intVal > 47 Then
                MessageBox.Show("Maximum line print is 47, please change Print Line Value !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                Me.txtPrint.Focus()
                Exit Sub
            End If
            myForm.rtbTrans.Text = ""

            intVal = intVal - 1
            intOrigVal = intVal
            intPrintLoop = (adoDS.Tables("TRANSACTION").Rows.Count + intOrigVal) \ 47

            For intLoop As Int32 = 1 To intPrintLoop
                intPage = 1
                alStringVal.Clear()
                For intCurrLine = 1 To 22
                    If (intVal + 1) > intCurrLine Then
                        alStringVal.Add("?")
                    Else
                        intVal = 0
                        adoRow = adoDS.Tables("TRANSACTION").Rows(intRecordCount)
                        intRecordCount += 1
                        str1 = intCurrLine.ToString + "."
                        str1 = str1.PadRight(3)
                        str2 = Format(adoRow!TRANSACTION_DATE, "dd-MM-yyyy")
                        str2 = str2.PadRight(11)
                        str3 = NullToString(adoRow!TYPE_2)
                        str3 = str3.PadLeft(5)
                        If adoRow!TRANSACTION_TYPE = "CR" Then
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(40)
                        Else
                            strTemp = ""
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(20)
                            strTemp = strTemp.PadRight(20)
                            str4 = str4 + strTemp
                        End If
                        str5 = Format(adoRow!TOTAL, "#,##0")
                        str5 = str5.PadLeft(24)
                        str6 = NullToString(adoRow!REVIEWED_BY).Substring(0, 3)
                        str6 = str6.PadLeft(4)
                        alStringVal.Add(str1 + str2 + str3 + str4 + str5 + str6)
                    End If
                Next

                arrStrTemp = alStringVal.ToArray(System.Type.GetType("System.String"))
                pd.Print()

                intPage = 2
                alStringVal.Clear()
                For intCurrLine = 23 To 47
                    If (intVal + 1) > intCurrLine Then
                        alStringVal.Add("?")
                    Else
                        intVal = 0
                        adoRow = adoDS.Tables("TRANSACTION").Rows(intRecordCount)
                        intRecordCount += 1
                        str1 = intCurrLine.ToString + "."
                        str1 = str1.PadRight(3)
                        str2 = Format(adoRow!TRANSACTION_DATE, "dd-MM-yyyy")
                        str2 = str2.PadRight(11)
                        str3 = NullToString(adoRow!TYPE_2)
                        str3 = str3.PadLeft(5)
                        If adoRow!TRANSACTION_TYPE = "CR" Then
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(40)
                        Else
                            strTemp = ""
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(20)
                            strTemp = strTemp.PadRight(20)
                            str4 = str4 + strTemp
                        End If
                        str5 = Format(adoRow!TOTAL, "#,##0")
                        str5 = str5.PadLeft(24)
                        str6 = NullToString(adoRow!REVIEWED_BY).Substring(0, 3)
                        str6 = str6.PadLeft(4)
                        alStringVal.Add(str1 + str2 + str3 + str4 + str5 + str6)
                    End If
                Next

                arrStrTemp = alStringVal.ToArray(System.Type.GetType("System.String"))
                pd.Print()
            Next

            '/* Last page print */
            intPrintLoop = (adoDS.Tables("TRANSACTION").Rows.Count + intOrigVal) Mod 47
            If intPrintLoop > 22 Then
                intPage = 1
                alStringVal.Clear()
                For intCurrLine = 1 To 22
                    If (intVal + 1) > intCurrLine Then
                        alStringVal.Add("?")
                    Else
                        intVal = 0
                        adoRow = adoDS.Tables("TRANSACTION").Rows(intRecordCount)
                        intRecordCount += 1
                        str1 = intCurrLine.ToString + "."
                        str1 = str1.PadRight(3)
                        str2 = Format(adoRow!TRANSACTION_DATE, "dd-MM-yyyy")
                        str2 = str2.PadRight(11)
                        str3 = NullToString(adoRow!TYPE_2)
                        str3 = str3.PadLeft(5)
                        If adoRow!TRANSACTION_TYPE = "CR" Then
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(40)
                        Else
                            strTemp = ""
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(20)
                            strTemp = strTemp.PadRight(20)
                            str4 = str4 + strTemp
                        End If
                        str5 = Format(adoRow!TOTAL, "#,##0")
                        str5 = str5.PadLeft(24)
                        str6 = NullToString(adoRow!REVIEWED_BY).Substring(0, 3)
                        str6 = str6.PadLeft(4)
                        alStringVal.Add(str1 + str2 + str3 + str4 + str5 + str6)
                    End If
                Next

                arrStrTemp = alStringVal.ToArray(System.Type.GetType("System.String"))
                pd.Print()

                intPage = 2
                alStringVal.Clear()
                For intCurrLine = 23 To intPrintLoop
                    If (intVal + 1) > intCurrLine Then
                        alStringVal.Add("?")
                    Else
                        intVal = 0
                        adoRow = adoDS.Tables("TRANSACTION").Rows(intRecordCount)
                        intRecordCount += 1
                        str1 = intCurrLine.ToString + "."
                        str1 = str1.PadRight(3)
                        str2 = Format(adoRow!TRANSACTION_DATE, "dd-MM-yyyy")
                        str2 = str2.PadRight(11)
                        str3 = NullToString(adoRow!TYPE_2)
                        str3 = str3.PadLeft(5)
                        If adoRow!TRANSACTION_TYPE = "CR" Then
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(40)
                        Else
                            strTemp = ""
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(20)
                            strTemp = strTemp.PadRight(20)
                            str4 = str4 + strTemp
                        End If
                        str5 = Format(adoRow!TOTAL, "#,##0")
                        str5 = str5.PadLeft(24)
                        str6 = NullToString(adoRow!REVIEWED_BY).Substring(0, 3)
                        str6 = str6.PadLeft(4)
                        alStringVal.Add(str1 + str2 + str3 + str4 + str5 + str6)
                    End If
                Next

                arrStrTemp = alStringVal.ToArray(System.Type.GetType("System.String"))
                pd.Print()
            Else
                intPage = 1
                alStringVal.Clear()
                For intCurrLine = 1 To intPrintLoop
                    If (intVal + 1) > intCurrLine Then
                        alStringVal.Add("?")
                    Else
                        intVal = 0
                        adoRow = adoDS.Tables("TRANSACTION").Rows(intRecordCount)
                        intRecordCount += 1
                        str1 = intCurrLine.ToString + "."
                        str1 = str1.PadRight(3)
                        str2 = Format(adoRow!TRANSACTION_DATE, "dd-MM-yyyy")
                        str2 = str2.PadRight(11)
                        str3 = NullToString(adoRow!TYPE_2)
                        str3 = str3.PadLeft(5)
                        If adoRow!TRANSACTION_TYPE = "CR" Then
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(40)
                        Else
                            strTemp = ""
                            str4 = Format(adoRow!AMOUNT, "#,##0")
                            str4 = str4.PadLeft(20)
                            strTemp = strTemp.PadRight(20)
                            str4 = str4 + strTemp
                        End If
                        str5 = Format(adoRow!TOTAL, "#,##0")
                        str5 = str5.PadLeft(24)
                        str6 = NullToString(adoRow!REVIEWED_BY).Substring(0, 3)
                        str6 = str6.PadLeft(4)
                        alStringVal.Add(str1 + str2 + str3 + str4 + str5 + str6)
                    End If
                Next
                arrStrTemp = alStringVal.ToArray(System.Type.GetType("System.String"))
                pd.Print()
            End If
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pdTrans_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim line As String = ""
        Dim intAddLine = 0
        Const int1stPageFeed As Int16 = 0
        Const int2ndPageFeed As Int16 = 2

        If intPage = 1 Then
            linesPerPage = 22
            intAddLine = int1stPageFeed
        Else
            linesPerPage = 24
            intAddLine = int2ndPageFeed + 22
        End If

        ' Calculate the number of lines per page.
        'linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        'count = intVal - 1
        'If arrStrTemp.Length < linesPerPage Then
        '    linesPerPage = arrStrTemp.Length
        'End If
        For intCount As Int32 = 0 To arrStrTemp.Length - 1
            line = arrStrTemp(intCount)
            If line.Trim <> "?" Then
                yPos = topMargin + (intCount + intAddLine) * printFont.GetHeight(e.Graphics)
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat)
            End If
        Next


        '' If more lines exist, print another page.
        ''If arrStrTemp.Length > linesPerPage Then
        ''    e.HasMorePages = True
        ''Else
        ''    e.HasMorePages = False
        ''End If
        e.HasMorePages = False
    End Sub
End Class
