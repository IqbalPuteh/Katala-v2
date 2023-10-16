Public Class frmMembershipSaving02
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
    Public WithEvents rtbTrans As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipSaving02))
        Me.rtbTrans = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'rtbTrans
        '
        Me.rtbTrans.Font = New System.Drawing.Font("SansSerif", 8.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rtbTrans.Location = New System.Drawing.Point(0, 0)
        Me.rtbTrans.Name = "rtbTrans"
        Me.rtbTrans.RightMargin = 900
        Me.rtbTrans.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbTrans.Size = New System.Drawing.Size(672, 584)
        Me.rtbTrans.TabIndex = 1
        Me.rtbTrans.Text = "" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "12345678901234567890123456789012345678901234567890123456789012345678901234567" & _
        "8901234567890123" & Microsoft.VisualBasic.ChrW(10) & "2" & Microsoft.VisualBasic.ChrW(10) & "3" & Microsoft.VisualBasic.ChrW(10) & "4." & Microsoft.VisualBasic.ChrW(10) & "5." & Microsoft.VisualBasic.ChrW(10) & "6." & Microsoft.VisualBasic.ChrW(10) & "7." & Microsoft.VisualBasic.ChrW(10) & "8." & Microsoft.VisualBasic.ChrW(10) & "9." & Microsoft.VisualBasic.ChrW(10) & "10." & Microsoft.VisualBasic.ChrW(10) & "1" & Microsoft.VisualBasic.ChrW(10) & "2" & Microsoft.VisualBasic.ChrW(10) & "3" & Microsoft.VisualBasic.ChrW(10) & "4" & Microsoft.VisualBasic.ChrW(10) & "5" & Microsoft.VisualBasic.ChrW(10) & "6" & Microsoft.VisualBasic.ChrW(10) & "7" & Microsoft.VisualBasic.ChrW(10) & "8" & Microsoft.VisualBasic.ChrW(10) & "9" & Microsoft.VisualBasic.ChrW(10) & "20." & Microsoft.VisualBasic.ChrW(10) & "1." & Microsoft.VisualBasic.ChrW(10) & "2" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1234567" & _
        "89012345678901234567890123456789012345678901234567890123456789012345678901234567" & _
        "890123" & Microsoft.VisualBasic.ChrW(10) & "2" & Microsoft.VisualBasic.ChrW(10) & "3" & Microsoft.VisualBasic.ChrW(10) & "4." & Microsoft.VisualBasic.ChrW(10) & "5." & Microsoft.VisualBasic.ChrW(10) & "6." & Microsoft.VisualBasic.ChrW(10) & "7." & Microsoft.VisualBasic.ChrW(10) & "8." & Microsoft.VisualBasic.ChrW(10) & "9." & Microsoft.VisualBasic.ChrW(10) & "10." & Microsoft.VisualBasic.ChrW(10) & "1" & Microsoft.VisualBasic.ChrW(10) & "2" & Microsoft.VisualBasic.ChrW(10) & "3" & Microsoft.VisualBasic.ChrW(10) & "4" & Microsoft.VisualBasic.ChrW(10) & "5" & Microsoft.VisualBasic.ChrW(10) & "6" & Microsoft.VisualBasic.ChrW(10) & "7" & Microsoft.VisualBasic.ChrW(10) & "8" & Microsoft.VisualBasic.ChrW(10) & "9" & Microsoft.VisualBasic.ChrW(10) & "20." & Microsoft.VisualBasic.ChrW(10) & "1." & Microsoft.VisualBasic.ChrW(10) & "2" & Microsoft.VisualBasic.ChrW(10) & "3" & Microsoft.VisualBasic.ChrW(10) & "412345678901234567" & _
        "89012345678901234567890123456789012345678901234567890123456789012345678901234567" & _
        "8"
        Me.rtbTrans.WordWrap = False
        '
        'frmMembershipSaving02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 592)
        Me.Controls.Add(Me.rtbTrans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipSaving02"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Pass Book"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub pdTrans_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim printFont = New Font("Monospac821 BT", 8.25)

        e.Graphics.DrawString(rtbTrans.Text, printFont, Brushes.Black, 5, 0, New StringFormat)
    End Sub
End Class
