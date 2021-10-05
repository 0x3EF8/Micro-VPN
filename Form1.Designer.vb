<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vpn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vpn))
        Me.connect = New System.Windows.Forms.Button()
        Me.Diconnect = New System.Windows.Forms.Button()
        Me.Host = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'connect
        '
        Me.connect.BackColor = System.Drawing.SystemColors.Desktop
        Me.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.connect.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect.ForeColor = System.Drawing.Color.Lime
        Me.connect.Location = New System.Drawing.Point(6, 129)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(106, 31)
        Me.connect.TabIndex = 0
        Me.connect.Text = "Connect"
        Me.connect.UseVisualStyleBackColor = False
        '
        'Diconnect
        '
        Me.Diconnect.BackColor = System.Drawing.SystemColors.Desktop
        Me.Diconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Diconnect.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Diconnect.ForeColor = System.Drawing.Color.Lime
        Me.Diconnect.Location = New System.Drawing.Point(127, 129)
        Me.Diconnect.Name = "Diconnect"
        Me.Diconnect.Size = New System.Drawing.Size(106, 32)
        Me.Diconnect.TabIndex = 1
        Me.Diconnect.Text = "Disconnect"
        Me.Diconnect.UseVisualStyleBackColor = False
        '
        'Host
        '
        Me.Host.BackColor = System.Drawing.Color.Black
        Me.Host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Host.ForeColor = System.Drawing.Color.Lime
        Me.Host.Location = New System.Drawing.Point(5, 25)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(228, 20)
        Me.Host.TabIndex = 2
        Me.Host.Text = "pptp.ipjetable.net"
        Me.Host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Name
        '
        Me.Name.BackColor = System.Drawing.Color.Black
        Me.Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Name.ForeColor = System.Drawing.Color.Lime
        Me.Name.Location = New System.Drawing.Point(6, 64)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(227, 20)
        Me.Name.TabIndex = 3
        Me.Name.Text = "Levi"
        Me.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pass
        '
        Me.Pass.BackColor = System.Drawing.Color.Black
        Me.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pass.ForeColor = System.Drawing.Color.Lime
        Me.Pass.Location = New System.Drawing.Point(5, 103)
        Me.Pass.Name = "Pass"
        Me.Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Pass.Size = New System.Drawing.Size(228, 20)
        Me.Pass.TabIndex = 4
        Me.Pass.Text = "IamLev1"
        Me.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Host"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(2, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(239, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 27)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Temp Mail"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(239, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 27)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "IPjetable"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(239, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 27)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "HideBux"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(239, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 27)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Proxy"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(239, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 27)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Tutorial"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'vpn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(335, 164)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Diconnect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.Host)
        Me.Controls.Add(Me.connect)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)

        Me.Text = "Micro VPN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connect As Button
    Friend WithEvents Diconnect As Button
    Friend WithEvents Host As TextBox
    Friend WithEvents Name As TextBox
    Friend WithEvents Pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
