<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderingSystem
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderingSystem))
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblBalance1 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblBalance2 = New System.Windows.Forms.Label()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMenu
        '
        Me.dgvMenu.AllowUserToAddRows = False
        Me.dgvMenu.AllowUserToDeleteRows = False
        Me.dgvMenu.AllowUserToResizeColumns = False
        Me.dgvMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMenu.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvMenu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMenu.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvMenu.Location = New System.Drawing.Point(12, 87)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMenu.RowHeadersVisible = False
        Me.dgvMenu.RowHeadersWidth = 20
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvMenu.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMenu.RowTemplate.Height = 27
        Me.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMenu.Size = New System.Drawing.Size(618, 339)
        Me.dgvMenu.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "Column2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "菜品名称"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 96
        '
        'Column2
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "菜品规格"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 96
        '
        'Column3
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "菜品类型"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 96
        '
        'Column4
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "菜品价格"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 96
        '
        'Column5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "制作时间"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 96
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.NullValue = "⊕"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column8.HeaderText = "添加"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Width = 66
        '
        'lblBalance1
        '
        Me.lblBalance1.AutoSize = True
        Me.lblBalance1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblBalance1.Location = New System.Drawing.Point(199, 31)
        Me.lblBalance1.Name = "lblBalance1"
        Me.lblBalance1.Size = New System.Drawing.Size(109, 20)
        Me.lblBalance1.TabIndex = 9
        Me.lblBalance1.Text = "会员卡余额"
        '
        'lblPrice1
        '
        Me.lblPrice1.AutoSize = True
        Me.lblPrice1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPrice1.Location = New System.Drawing.Point(727, 31)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(129, 20)
        Me.lblPrice1.TabIndex = 11
        Me.lblPrice1.Text = "当前菜品总价"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPrice.Location = New System.Drawing.Point(862, 28)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(58, 25)
        Me.txtPrice.TabIndex = 12
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBalance.Location = New System.Drawing.Point(314, 28)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(63, 25)
        Me.txtBalance.TabIndex = 13
        '
        'lblTime1
        '
        Me.lblTime1.AutoSize = True
        Me.lblTime1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTime1.Location = New System.Drawing.Point(453, 31)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(129, 20)
        Me.lblTime1.TabIndex = 14
        Me.lblTime1.Text = "预计等候时间"
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTime.Location = New System.Drawing.Point(588, 28)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(56, 25)
        Me.txtTime.TabIndex = 15
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.AllowUserToResizeColumns = False
        Me.dgvOrder.AllowUserToResizeRows = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOrder.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvOrder.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column9, Me.Column7})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrder.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvOrder.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvOrder.Location = New System.Drawing.Point(703, 87)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrder.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvOrder.RowHeadersVisible = False
        Me.dgvOrder.RowHeadersWidth = 25
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvOrder.RowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvOrder.RowTemplate.Height = 27
        Me.dgvOrder.Size = New System.Drawing.Size(252, 339)
        Me.dgvOrder.TabIndex = 16
        '
        'Column6
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column6.HeaderText = "所点菜品"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 96
        '
        'Column9
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column9.HeaderText = "数量"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 66
        '
        'Column7
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.NullValue = "㊀"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column7.HeaderText = "删除"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 66
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSubmit.Font = New System.Drawing.Font("宋体", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(445, 467)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(166, 44)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "提交订单"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(650, 31)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(49, 20)
        Me.lblTime2.TabIndex = 18
        Me.lblTime2.Text = "分钟"
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPrice2.Location = New System.Drawing.Point(926, 33)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(29, 20)
        Me.lblPrice2.TabIndex = 19
        Me.lblPrice2.Text = "元"
        '
        'Timer1
        '
        '
        'lblBalance2
        '
        Me.lblBalance2.AutoSize = True
        Me.lblBalance2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblBalance2.Location = New System.Drawing.Point(383, 31)
        Me.lblBalance2.Name = "lblBalance2"
        Me.lblBalance2.Size = New System.Drawing.Size(29, 20)
        Me.lblBalance2.TabIndex = 20
        Me.lblBalance2.Text = "元"
        '
        'OrderingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1009, 578)
        Me.Controls.Add(Me.lblBalance2)
        Me.Controls.Add(Me.lblPrice2)
        Me.Controls.Add(Me.lblTime2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblTime1)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice1)
        Me.Controls.Add(Me.lblBalance1)
        Me.Controls.Add(Me.dgvMenu)
        Me.Name = "OrderingSystem"
        Me.Text = "点餐"
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents lblBalance1 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblTime1 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblTime2 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents lblBalance2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewButtonColumn
End Class
