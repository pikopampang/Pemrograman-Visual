<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtAngka1 = New System.Windows.Forms.TextBox()
        Me.cmbOperasi = New System.Windows.Forms.ComboBox()
        Me.txtAngka2 = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnBacaHistory = New System.Windows.Forms.Button()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'txtAngka1
        '
        Me.txtAngka1.Location = New System.Drawing.Point(141, 51)
        Me.txtAngka1.Name = "txtAngka1"
        Me.txtAngka1.Size = New System.Drawing.Size(179, 26)
        Me.txtAngka1.TabIndex = 2
        '
        'cmbOperasi
        '
        Me.cmbOperasi.FormattingEnabled = True
        Me.cmbOperasi.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cmbOperasi.Location = New System.Drawing.Point(326, 51)
        Me.cmbOperasi.Name = "cmbOperasi"
        Me.cmbOperasi.Size = New System.Drawing.Size(121, 28)
        Me.cmbOperasi.TabIndex = 3
        '
        'txtAngka2
        '
        Me.txtAngka2.Location = New System.Drawing.Point(453, 53)
        Me.txtAngka2.Name = "txtAngka2"
        Me.txtAngka2.Size = New System.Drawing.Size(179, 26)
        Me.txtAngka2.TabIndex = 4
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(326, 103)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(121, 43)
        Me.btnHitung.TabIndex = 5
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnBacaHistory
        '
        Me.btnBacaHistory.Location = New System.Drawing.Point(326, 217)
        Me.btnBacaHistory.Name = "btnBacaHistory"
        Me.btnBacaHistory.Size = New System.Drawing.Size(121, 43)
        Me.btnBacaHistory.TabIndex = 7
        Me.btnBacaHistory.Text = "Baca History"
        Me.btnBacaHistory.UseVisualStyleBackColor = True
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(647, 59)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(52, 20)
        Me.lblHasil.TabIndex = 9
        Me.lblHasil.Text = "Hasil :"
        '
        'txtHistory
        '
        Me.txtHistory.Location = New System.Drawing.Point(141, 152)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = True
        Me.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistory.Size = New System.Drawing.Size(491, 59)
        Me.txtHistory.TabIndex = 10
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnBacaHistory)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtAngka2)
        Me.Controls.Add(Me.cmbOperasi)
        Me.Controls.Add(Me.txtAngka1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents cmbOperasi As ComboBox
    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBacaHistory As Button

    Private Sub lblHasil_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents lblHasil As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents txtHistory As TextBox
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
End Class
