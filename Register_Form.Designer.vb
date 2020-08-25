<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabelold = New System.Windows.Forms.LinkLabel()
        Me.TextBoxsname = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonReg = New System.Windows.Forms.Button()
        Me.TextBoxcpass = New System.Windows.Forms.TextBox()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxemail = New System.Windows.Forms.TextBox()
        Me.TextBoxusername = New System.Windows.Forms.TextBox()
        Me.TextBoxothername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelReg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 389)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LinkLabelold)
        Me.Panel2.Controls.Add(Me.TextBoxsname)
        Me.Panel2.Controls.Add(Me.ButtonCancel)
        Me.Panel2.Controls.Add(Me.ButtonReg)
        Me.Panel2.Controls.Add(Me.TextBoxcpass)
        Me.Panel2.Controls.Add(Me.TextBoxpassword)
        Me.Panel2.Controls.Add(Me.TextBoxemail)
        Me.Panel2.Controls.Add(Me.TextBoxusername)
        Me.Panel2.Controls.Add(Me.TextBoxothername)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 383)
        Me.Panel2.TabIndex = 0
        '
        'LinkLabelold
        '
        Me.LinkLabelold.AutoSize = True
        Me.LinkLabelold.BackColor = System.Drawing.Color.FloralWhite
        Me.LinkLabelold.Location = New System.Drawing.Point(160, 45)
        Me.LinkLabelold.Name = "LinkLabelold"
        Me.LinkLabelold.Size = New System.Drawing.Size(265, 13)
        Me.LinkLabelold.TabIndex = 17
        Me.LinkLabelold.TabStop = True
        Me.LinkLabelold.Text = "I have an account already, please click here to Sign In"
        '
        'TextBoxsname
        '
        Me.TextBoxsname.Location = New System.Drawing.Point(86, 68)
        Me.TextBoxsname.Multiline = True
        Me.TextBoxsname.Name = "TextBoxsname"
        Me.TextBoxsname.Size = New System.Drawing.Size(160, 24)
        Me.TextBoxsname.TabIndex = 1
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancel.Location = New System.Drawing.Point(396, 332)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(125, 42)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonReg
        '
        Me.ButtonReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonReg.Location = New System.Drawing.Point(92, 332)
        Me.ButtonReg.Name = "ButtonReg"
        Me.ButtonReg.Size = New System.Drawing.Size(125, 42)
        Me.ButtonReg.TabIndex = 7
        Me.ButtonReg.Text = "SIGNUP"
        Me.ButtonReg.UseVisualStyleBackColor = False
        '
        'TextBoxcpass
        '
        Me.TextBoxcpass.Location = New System.Drawing.Point(396, 267)
        Me.TextBoxcpass.Multiline = True
        Me.TextBoxcpass.Name = "TextBoxcpass"
        Me.TextBoxcpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxcpass.Size = New System.Drawing.Size(177, 29)
        Me.TextBoxcpass.TabIndex = 6
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(92, 269)
        Me.TextBoxpassword.Multiline = True
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpassword.Size = New System.Drawing.Size(154, 27)
        Me.TextBoxpassword.TabIndex = 5
        '
        'TextBoxemail
        '
        Me.TextBoxemail.Location = New System.Drawing.Point(58, 201)
        Me.TextBoxemail.Multiline = True
        Me.TextBoxemail.Name = "TextBoxemail"
        Me.TextBoxemail.Size = New System.Drawing.Size(515, 25)
        Me.TextBoxemail.TabIndex = 4
        '
        'TextBoxusername
        '
        Me.TextBoxusername.Location = New System.Drawing.Point(102, 136)
        Me.TextBoxusername.Multiline = True
        Me.TextBoxusername.Name = "TextBoxusername"
        Me.TextBoxusername.Size = New System.Drawing.Size(469, 26)
        Me.TextBoxusername.TabIndex = 3
        '
        'TextBoxothername
        '
        Me.TextBoxothername.Location = New System.Drawing.Point(342, 66)
        Me.TextBoxothername.Multiline = True
        Me.TextBoxothername.Name = "TextBoxothername"
        Me.TextBoxothername.Size = New System.Drawing.Size(231, 24)
        Me.TextBoxothername.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(11, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(252, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CONFIRM PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(11, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(9, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(246, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OTHERNAME"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-3, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(583, 2)
        Me.Panel4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SURNAME"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelReg)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 41)
        Me.Panel3.TabIndex = 0
        '
        'LabelReg
        '
        Me.LabelReg.AutoSize = True
        Me.LabelReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReg.ForeColor = System.Drawing.Color.White
        Me.LabelReg.Location = New System.Drawing.Point(151, 7)
        Me.LabelReg.Name = "LabelReg"
        Me.LabelReg.Padding = New System.Windows.Forms.Padding(1)
        Me.LabelReg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelReg.Size = New System.Drawing.Size(243, 26)
        Me.LabelReg.TabIndex = 0
        Me.LabelReg.Text = "REGISTERATION FORM"
        Me.LabelReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Register_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 389)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(602, 428)
        Me.Name = "Register_Form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelReg As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents TextBoxemail As TextBox
    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents TextBoxothername As TextBox
    Friend WithEvents TextBoxsname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxcpass As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonReg As Button
    Friend WithEvents LinkLabelold As LinkLabel
End Class
