<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblOpeningHours = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblId.Location = New System.Drawing.Point(271, 152)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(87, 25)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "会员号"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(296, 195)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(62, 25)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "密码"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtId.Location = New System.Drawing.Point(364, 152)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(189, 25)
        Me.txtId.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPassword.Location = New System.Drawing.Point(364, 195)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(189, 25)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLog.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLog.Location = New System.Drawing.Point(353, 273)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(101, 44)
        Me.btnLog.TabIndex = 4
        Me.btnLog.Text = "登录"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.White
        Me.lblWelcome.Font = New System.Drawing.Font("宋体", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(260, 21)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(313, 37)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "欢迎使用点餐系统"
        '
        'lblOpeningHours
        '
        Me.lblOpeningHours.AutoEllipsis = True
        Me.lblOpeningHours.AutoSize = True
        Me.lblOpeningHours.BackColor = System.Drawing.Color.White
        Me.lblOpeningHours.Font = New System.Drawing.Font("宋体", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpeningHours.Location = New System.Drawing.Point(217, 74)
        Me.lblOpeningHours.Name = "lblOpeningHours"
        Me.lblOpeningHours.Size = New System.Drawing.Size(392, 37)
        Me.lblOpeningHours.TabIndex = 6
        Me.lblOpeningHours.Text = "营业时间：6:00-10:00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(780, 365)
        Me.Controls.Add(Me.lblOpeningHours)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblId)
        Me.Name = "Form1"
        Me.Text = "登陆"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblOpeningHours As Label
End Class
