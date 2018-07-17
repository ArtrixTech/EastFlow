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
        '
        'Block
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.lblCoor)
        Me.Name = "Block"
        Me.Size = New System.Drawing.Size(48, 48)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCoor As Label
End Class
