<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Block
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCoor = New System.Windows.Forms.Label()
        Me.CastleIndicator = New System.Windows.Forms.PictureBox()
        Me.ResultIndicator = New System.Windows.Forms.PictureBox()
        Me.RoundCorner = New System.Windows.Forms.PictureBox()
        CType(Me.CastleIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoundCorner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCoor
        '
        Me.lblCoor.AutoSize = True
        Me.lblCoor.Font = New System.Drawing.Font("微软雅黑", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCoor.ForeColor = System.Drawing.Color.Gray
        Me.lblCoor.Location = New System.Drawing.Point(2, 2)
        Me.lblCoor.Name = "lblCoor"
        Me.lblCoor.Size = New System.Drawing.Size(22, 16)
        Me.lblCoor.TabIndex = 0
        Me.lblCoor.Text = "0,0"
        Me.lblCoor.Visible = False
        '
        'CastleIndicator
        '
        Me.CastleIndicator.BackColor = System.Drawing.Color.Transparent
        Me.CastleIndicator.Image = Global.EastFlow.My.Resources.Resources.castle
        Me.CastleIndicator.Location = New System.Drawing.Point(8, 8)
        Me.CastleIndicator.Name = "CastleIndicator"
        Me.CastleIndicator.Size = New System.Drawing.Size(32, 32)
        Me.CastleIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CastleIndicator.TabIndex = 3
        Me.CastleIndicator.TabStop = False
        Me.CastleIndicator.Visible = False
        '
        'ResultIndicator
        '
        Me.ResultIndicator.BackColor = System.Drawing.Color.DarkGray
        Me.ResultIndicator.Location = New System.Drawing.Point(10, 10)
        Me.ResultIndicator.Name = "ResultIndicator"
        Me.ResultIndicator.Size = New System.Drawing.Size(28, 28)
        Me.ResultIndicator.TabIndex = 2
        Me.ResultIndicator.TabStop = False
        Me.ResultIndicator.Visible = False
        '
        'RoundCorner
        '
        Me.RoundCorner.Image = Global.EastFlow.My.Resources.Resources.未标题_1
        Me.RoundCorner.Location = New System.Drawing.Point(0, 0)
        Me.RoundCorner.Name = "RoundCorner"
        Me.RoundCorner.Size = New System.Drawing.Size(48, 48)
        Me.RoundCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RoundCorner.TabIndex = 1
        Me.RoundCorner.TabStop = False
        '
        'Block
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.CastleIndicator)
        Me.Controls.Add(Me.ResultIndicator)
        Me.Controls.Add(Me.lblCoor)
        Me.Controls.Add(Me.RoundCorner)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Block"
        Me.Size = New System.Drawing.Size(48, 48)
        CType(Me.CastleIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoundCorner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCoor As Label
    Friend WithEvents RoundCorner As PictureBox
    Friend WithEvents ResultIndicator As PictureBox
    Friend WithEvents CastleIndicator As PictureBox
End Class
