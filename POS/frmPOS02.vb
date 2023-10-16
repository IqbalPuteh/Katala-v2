Public Class frmPOS02
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
    Friend WithEvents rtbTrans As System.Windows.Forms.RichTextBox
    Public WithEvents pdTrans As System.Drawing.Printing.PrintDocument
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPOS02))
        Me.pdTrans = New System.Drawing.Printing.PrintDocument
        Me.rtbTrans = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'pdTrans
        '
        Me.pdTrans.DocumentName = "Transaction"
        '
        'rtbTrans
        '
        Me.rtbTrans.Font = New System.Drawing.Font("Monospac821 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTrans.Location = New System.Drawing.Point(0, 0)
        Me.rtbTrans.Name = "rtbTrans"
        Me.rtbTrans.RightMargin = 265
        Me.rtbTrans.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbTrans.Size = New System.Drawing.Size(274, 704)
        Me.rtbTrans.TabIndex = 0
        Me.rtbTrans.Text = "      ** KOKAR KATALA **" & Microsoft.VisualBasic.ChrW(10) & "      Township,  Sumbawa" & Microsoft.VisualBasic.ChrW(10) & "Telepon: 0372-635318 ext.48007" & Microsoft.VisualBasic.ChrW(10) & _
        "Fax    : 0372-635318 ext.48013"
        Me.rtbTrans.WordWrap = False
        '
        'frmPOS02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(274, 304)
        Me.Controls.Add(Me.rtbTrans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS02"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Transaction"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub pdTrans_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdTrans.PrintPage
        Dim printFont = New Font("Monospac821 BT", 8.25)

        e.Graphics.DrawString(rtbTrans.Text, printFont, Brushes.Black, 5, 0, New StringFormat)

    End Sub

End Class
