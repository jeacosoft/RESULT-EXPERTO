<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBJECT_LOADER
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GunaTextBoxsub = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GunaButtonSAVE = New Guna.UI.WinForms.GunaButton()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 662)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 356
        Me.Label9.Text = "Label9"
        '
        'GunaTextBoxsub
        '
        Me.GunaTextBoxsub.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBoxsub.BaseColor = System.Drawing.Color.White
        Me.GunaTextBoxsub.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBoxsub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBoxsub.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBoxsub.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBoxsub.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBoxsub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBoxsub.Location = New System.Drawing.Point(45, 61)
        Me.GunaTextBoxsub.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaTextBoxsub.Name = "GunaTextBoxsub"
        Me.GunaTextBoxsub.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBoxsub.Radius = 30
        Me.GunaTextBoxsub.Size = New System.Drawing.Size(431, 37)
        Me.GunaTextBoxsub.TabIndex = 346
        Me.GunaTextBoxsub.Text = "Subject"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.BackColor = System.Drawing.Color.Olive
        Me.GroupBox3.Controls.Add(Me.GunaButtonSAVE)
        Me.GroupBox3.Controls.Add(Me.GunaTextBoxsub)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(522, 202)
        Me.GroupBox3.TabIndex = 345
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ADD SUBJECTS"
        '
        'GunaButtonSAVE
        '
        Me.GunaButtonSAVE.AnimationHoverSpeed = 0.07!
        Me.GunaButtonSAVE.AnimationSpeed = 0.03!
        Me.GunaButtonSAVE.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonSAVE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButtonSAVE.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonSAVE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonSAVE.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonSAVE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonSAVE.ForeColor = System.Drawing.Color.White
        Me.GunaButtonSAVE.Image = Nothing
        Me.GunaButtonSAVE.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonSAVE.Location = New System.Drawing.Point(16, 142)
        Me.GunaButtonSAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaButtonSAVE.Name = "GunaButtonSAVE"
        Me.GunaButtonSAVE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonSAVE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonSAVE.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonSAVE.OnHoverImage = Nothing
        Me.GunaButtonSAVE.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonSAVE.Radius = 10
        Me.GunaButtonSAVE.Size = New System.Drawing.Size(490, 52)
        Me.GunaButtonSAVE.TabIndex = 374
        Me.GunaButtonSAVE.Text = "SAVE"
        Me.GunaButtonSAVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonSAVE.TextOffsetX = 30
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Khaki
        Me.GunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 5
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(530, 210)
        Me.GunaGradient2Panel1.TabIndex = 346
        '
        'SUBJECT_LOADER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 210)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(548, 534)
        Me.Name = "SUBJECT_LOADER"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBJECT LOADER"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents GunaTextBoxsub As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GunaButtonSAVE As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
