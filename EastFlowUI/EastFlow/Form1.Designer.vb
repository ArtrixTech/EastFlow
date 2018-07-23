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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.lblCalc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalcTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ThreadUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgCalc = New System.Windows.Forms.PictureBox()
        Me.btnClearReturn = New EastFlow.FlatButton()
        Me.btnClose = New EastFlow.FlatButton()
        Me.btnAbort = New EastFlow.FlatButton()
        Me.Alert1 = New EastFlow.Alert()
        Me.btnCalc = New EastFlow.FlatButton()
        Me.btnLoad = New EastFlow.FlatButton()
        Me.btnGen = New EastFlow.FlatButton()
        Me.btnClear = New EastFlow.FlatButton()
        Me.Block57 = New EastFlow.Block()
        Me.Block58 = New EastFlow.Block()
        Me.Block59 = New EastFlow.Block()
        Me.Block60 = New EastFlow.Block()
        Me.Block61 = New EastFlow.Block()
        Me.Block62 = New EastFlow.Block()
        Me.Block63 = New EastFlow.Block()
        Me.Block64 = New EastFlow.Block()
        Me.Block49 = New EastFlow.Block()
        Me.Block50 = New EastFlow.Block()
        Me.Block51 = New EastFlow.Block()
        Me.Block52 = New EastFlow.Block()
        Me.Block53 = New EastFlow.Block()
        Me.Block54 = New EastFlow.Block()
        Me.Block55 = New EastFlow.Block()
        Me.Block56 = New EastFlow.Block()
        Me.Block41 = New EastFlow.Block()
        Me.Block42 = New EastFlow.Block()
        Me.Block43 = New EastFlow.Block()
        Me.Block44 = New EastFlow.Block()
        Me.Block45 = New EastFlow.Block()
        Me.Block46 = New EastFlow.Block()
        Me.Block47 = New EastFlow.Block()
        Me.Block48 = New EastFlow.Block()
        Me.Block33 = New EastFlow.Block()
        Me.Block34 = New EastFlow.Block()
        Me.Block35 = New EastFlow.Block()
        Me.Block36 = New EastFlow.Block()
        Me.Block37 = New EastFlow.Block()
        Me.Block38 = New EastFlow.Block()
        Me.Block39 = New EastFlow.Block()
        Me.Block40 = New EastFlow.Block()
        Me.Block25 = New EastFlow.Block()
        Me.Block26 = New EastFlow.Block()
        Me.Block27 = New EastFlow.Block()
        Me.Block28 = New EastFlow.Block()
        Me.Block29 = New EastFlow.Block()
        Me.Block30 = New EastFlow.Block()
        Me.Block31 = New EastFlow.Block()
        Me.Block32 = New EastFlow.Block()
        Me.Block17 = New EastFlow.Block()
        Me.Block18 = New EastFlow.Block()
        Me.Block19 = New EastFlow.Block()
        Me.Block20 = New EastFlow.Block()
        Me.Block21 = New EastFlow.Block()
        Me.Block22 = New EastFlow.Block()
        Me.Block23 = New EastFlow.Block()
        Me.Block24 = New EastFlow.Block()
        Me.Block9 = New EastFlow.Block()
        Me.Block10 = New EastFlow.Block()
        Me.Block11 = New EastFlow.Block()
        Me.Block12 = New EastFlow.Block()
        Me.Block13 = New EastFlow.Block()
        Me.Block14 = New EastFlow.Block()
        Me.Block15 = New EastFlow.Block()
        Me.Block16 = New EastFlow.Block()
        Me.Block5 = New EastFlow.Block()
        Me.Block6 = New EastFlow.Block()
        Me.Block7 = New EastFlow.Block()
        Me.Block8 = New EastFlow.Block()
        Me.Block3 = New EastFlow.Block()
        Me.Block4 = New EastFlow.Block()
        Me.Block2 = New EastFlow.Block()
        Me.Block1 = New EastFlow.Block()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadTimer
        '
        Me.LoadTimer.Enabled = True
        Me.LoadTimer.Interval = 10
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Gray
        Me.RichTextBox1.Location = New System.Drawing.Point(490, 240)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(80, 119)
        Me.RichTextBox1.TabIndex = 70
        Me.RichTextBox1.Text = "Input"
        Me.RichTextBox1.WordWrap = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Gray
        Me.RichTextBox2.Location = New System.Drawing.Point(576, 240)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox2.Size = New System.Drawing.Size(80, 119)
        Me.RichTextBox2.TabIndex = 71
        Me.RichTextBox2.Text = "Output"
        '
        'lblCalc
        '
        Me.lblCalc.AutoSize = True
        Me.lblCalc.Font = New System.Drawing.Font("微软雅黑 Light", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCalc.Location = New System.Drawing.Point(560, 429)
        Me.lblCalc.Name = "lblCalc"
        Me.lblCalc.Size = New System.Drawing.Size(85, 20)
        Me.lblCalc.TabIndex = 77
        Me.lblCalc.Text = "Calculating..."
        Me.lblCalc.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑 Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 46)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "00"
        '
        'CalcTimer
        '
        Me.CalcTimer.Interval = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑 Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(486, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 21)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Sec"
        '
        'ThreadUpdateTimer
        '
        Me.ThreadUpdateTimer.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 28.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 50)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "East"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑 Light", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(98, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 35)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Flow"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑 Light", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(160, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "东流的游戏"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.EastFlow.My.Resources.Resources.背景_拷贝
        Me.PictureBox4.Location = New System.Drawing.Point(619, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 85
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Orange
        Me.PictureBox3.Location = New System.Drawing.Point(-4, 541)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(706, 8)
        Me.PictureBox3.TabIndex = 83
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Orange
        Me.PictureBox2.Location = New System.Drawing.Point(553, 82)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 4)
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox1.Location = New System.Drawing.Point(490, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 4)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'imgCalc
        '
        Me.imgCalc.Image = Global.EastFlow.My.Resources.Resources._5_160914192R5_50
        Me.imgCalc.Location = New System.Drawing.Point(380, 376)
        Me.imgCalc.Name = "imgCalc"
        Me.imgCalc.Size = New System.Drawing.Size(302, 137)
        Me.imgCalc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCalc.TabIndex = 75
        Me.imgCalc.TabStop = False
        Me.imgCalc.Visible = False
        '
        'btnClearReturn
        '
        Me.btnClearReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnClearReturn.backgroundColorDimmingDuration = 75
        Me.btnClearReturn.backgroundColorDimmingRatio = 0.12R
        Me.btnClearReturn.blockColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearReturn.LblText = "Clear Ret"
        Me.btnClearReturn.Location = New System.Drawing.Point(576, 129)
        Me.btnClearReturn.Name = "btnClearReturn"
        Me.btnClearReturn.Size = New System.Drawing.Size(80, 31)
        Me.btnClearReturn.TabIndex = 84
        Me.btnClearReturn.textColor = System.Drawing.Color.Gray
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.backgroundColorDimmingDuration = 75
        Me.btnClose.backgroundColorDimmingRatio = 0.12R
        Me.btnClose.blockColor = System.Drawing.Color.Orange
        Me.btnClose.LblText = "  X"
        Me.btnClose.Location = New System.Drawing.Point(648, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(43, 29)
        Me.btnClose.TabIndex = 82
        Me.btnClose.textColor = System.Drawing.Color.White
        '
        'btnAbort
        '
        Me.btnAbort.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAbort.backgroundColorDimmingDuration = 75
        Me.btnAbort.backgroundColorDimmingRatio = 0.12R
        Me.btnAbort.blockColor = System.Drawing.Color.Tomato
        Me.btnAbort.LblText = "Abort"
        Me.btnAbort.Location = New System.Drawing.Point(605, 92)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(52, 31)
        Me.btnAbort.TabIndex = 81
        Me.btnAbort.textColor = System.Drawing.Color.White
        Me.btnAbort.Visible = False
        '
        'Alert1
        '
        Me.Alert1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Alert1.Location = New System.Drawing.Point(490, 365)
        Me.Alert1.Name = "Alert1"
        Me.Alert1.Size = New System.Drawing.Size(168, 40)
        Me.Alert1.TabIndex = 80
        Me.Alert1.Visible = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCalc.backgroundColorDimmingDuration = 75
        Me.btnCalc.backgroundColorDimmingRatio = 0.12R
        Me.btnCalc.blockColor = System.Drawing.Color.WhiteSmoke
        Me.btnCalc.LblText = "Calculate"
        Me.btnCalc.Location = New System.Drawing.Point(490, 92)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(168, 31)
        Me.btnCalc.TabIndex = 76
        Me.btnCalc.textColor = System.Drawing.Color.Gray
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLoad.backgroundColorDimmingDuration = 75
        Me.btnLoad.backgroundColorDimmingRatio = 0.12R
        Me.btnLoad.blockColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoad.LblText = "Load From Text"
        Me.btnLoad.Location = New System.Drawing.Point(490, 203)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(168, 31)
        Me.btnLoad.TabIndex = 72
        Me.btnLoad.textColor = System.Drawing.Color.Gray
        '
        'btnGen
        '
        Me.btnGen.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGen.backgroundColorDimmingDuration = 75
        Me.btnGen.backgroundColorDimmingRatio = 0.12R
        Me.btnGen.blockColor = System.Drawing.Color.WhiteSmoke
        Me.btnGen.LblText = "Generate"
        Me.btnGen.Location = New System.Drawing.Point(490, 166)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(168, 31)
        Me.btnGen.TabIndex = 69
        Me.btnGen.textColor = System.Drawing.Color.Gray
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnClear.backgroundColorDimmingDuration = 75
        Me.btnClear.backgroundColorDimmingRatio = 0.12R
        Me.btnClear.blockColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.LblText = "Clear All"
        Me.btnClear.Location = New System.Drawing.Point(490, 129)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 31)
        Me.btnClear.TabIndex = 68
        Me.btnClear.textColor = System.Drawing.Color.Gray
        '
        'Block57
        '
        Me.Block57.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block57.backgroundColorDimmingDuration = 75
        Me.Block57.backgroundColorDimmingRatio = 0.12R
        Me.Block57.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block57.colorID = 0
        Me.Block57.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block57.isCastle = False
        Me.Block57.Location = New System.Drawing.Point(248, 460)
        Me.Block57.Name = "Block57"
        Me.Block57.Size = New System.Drawing.Size(48, 48)
        Me.Block57.TabIndex = 63
        Me.Block57.xIndex = 4
        Me.Block57.yIndex = 7
        '
        'Block58
        '
        Me.Block58.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block58.backgroundColorDimmingDuration = 75
        Me.Block58.backgroundColorDimmingRatio = 0.12R
        Me.Block58.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block58.colorID = 0
        Me.Block58.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block58.isCastle = False
        Me.Block58.Location = New System.Drawing.Point(302, 460)
        Me.Block58.Name = "Block58"
        Me.Block58.Size = New System.Drawing.Size(48, 48)
        Me.Block58.TabIndex = 62
        Me.Block58.xIndex = 5
        Me.Block58.yIndex = 7
        '
        'Block59
        '
        Me.Block59.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block59.backgroundColorDimmingDuration = 75
        Me.Block59.backgroundColorDimmingRatio = 0.12R
        Me.Block59.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block59.colorID = 0
        Me.Block59.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block59.isCastle = False
        Me.Block59.Location = New System.Drawing.Point(356, 460)
        Me.Block59.Name = "Block59"
        Me.Block59.Size = New System.Drawing.Size(48, 48)
        Me.Block59.TabIndex = 61
        Me.Block59.xIndex = 6
        Me.Block59.yIndex = 7
        '
        'Block60
        '
        Me.Block60.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block60.backgroundColorDimmingDuration = 75
        Me.Block60.backgroundColorDimmingRatio = 0.12R
        Me.Block60.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block60.colorID = 0
        Me.Block60.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block60.isCastle = False
        Me.Block60.Location = New System.Drawing.Point(410, 460)
        Me.Block60.Name = "Block60"
        Me.Block60.Size = New System.Drawing.Size(48, 48)
        Me.Block60.TabIndex = 60
        Me.Block60.xIndex = 7
        Me.Block60.yIndex = 7
        '
        'Block61
        '
        Me.Block61.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block61.backgroundColorDimmingDuration = 75
        Me.Block61.backgroundColorDimmingRatio = 0.12R
        Me.Block61.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block61.colorID = 0
        Me.Block61.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block61.isCastle = False
        Me.Block61.Location = New System.Drawing.Point(140, 460)
        Me.Block61.Name = "Block61"
        Me.Block61.Size = New System.Drawing.Size(48, 48)
        Me.Block61.TabIndex = 59
        Me.Block61.xIndex = 2
        Me.Block61.yIndex = 7
        '
        'Block62
        '
        Me.Block62.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block62.backgroundColorDimmingDuration = 75
        Me.Block62.backgroundColorDimmingRatio = 0.12R
        Me.Block62.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block62.colorID = 0
        Me.Block62.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block62.isCastle = False
        Me.Block62.Location = New System.Drawing.Point(194, 460)
        Me.Block62.Name = "Block62"
        Me.Block62.Size = New System.Drawing.Size(48, 48)
        Me.Block62.TabIndex = 58
        Me.Block62.xIndex = 3
        Me.Block62.yIndex = 7
        '
        'Block63
        '
        Me.Block63.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block63.backgroundColorDimmingDuration = 75
        Me.Block63.backgroundColorDimmingRatio = 0.12R
        Me.Block63.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block63.colorID = 0
        Me.Block63.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block63.isCastle = False
        Me.Block63.Location = New System.Drawing.Point(86, 460)
        Me.Block63.Name = "Block63"
        Me.Block63.Size = New System.Drawing.Size(48, 48)
        Me.Block63.TabIndex = 57
        Me.Block63.xIndex = 1
        Me.Block63.yIndex = 7
        '
        'Block64
        '
        Me.Block64.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block64.backgroundColorDimmingDuration = 75
        Me.Block64.backgroundColorDimmingRatio = 0.12R
        Me.Block64.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block64.colorID = 0
        Me.Block64.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block64.isCastle = False
        Me.Block64.Location = New System.Drawing.Point(32, 460)
        Me.Block64.Name = "Block64"
        Me.Block64.Size = New System.Drawing.Size(48, 48)
        Me.Block64.TabIndex = 56
        Me.Block64.xIndex = 0
        Me.Block64.yIndex = 7
        '
        'Block49
        '
        Me.Block49.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block49.backgroundColorDimmingDuration = 75
        Me.Block49.backgroundColorDimmingRatio = 0.12R
        Me.Block49.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block49.colorID = 0
        Me.Block49.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block49.isCastle = False
        Me.Block49.Location = New System.Drawing.Point(248, 406)
        Me.Block49.Name = "Block49"
        Me.Block49.Size = New System.Drawing.Size(48, 48)
        Me.Block49.TabIndex = 55
        Me.Block49.xIndex = 4
        Me.Block49.yIndex = 6
        '
        'Block50
        '
        Me.Block50.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block50.backgroundColorDimmingDuration = 75
        Me.Block50.backgroundColorDimmingRatio = 0.12R
        Me.Block50.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block50.colorID = 0
        Me.Block50.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block50.isCastle = False
        Me.Block50.Location = New System.Drawing.Point(302, 406)
        Me.Block50.Name = "Block50"
        Me.Block50.Size = New System.Drawing.Size(48, 48)
        Me.Block50.TabIndex = 54
        Me.Block50.xIndex = 5
        Me.Block50.yIndex = 6
        '
        'Block51
        '
        Me.Block51.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block51.backgroundColorDimmingDuration = 75
        Me.Block51.backgroundColorDimmingRatio = 0.12R
        Me.Block51.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block51.colorID = 0
        Me.Block51.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block51.isCastle = False
        Me.Block51.Location = New System.Drawing.Point(356, 406)
        Me.Block51.Name = "Block51"
        Me.Block51.Size = New System.Drawing.Size(48, 48)
        Me.Block51.TabIndex = 53
        Me.Block51.xIndex = 6
        Me.Block51.yIndex = 6
        '
        'Block52
        '
        Me.Block52.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block52.backgroundColorDimmingDuration = 75
        Me.Block52.backgroundColorDimmingRatio = 0.12R
        Me.Block52.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block52.colorID = 0
        Me.Block52.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block52.isCastle = False
        Me.Block52.Location = New System.Drawing.Point(410, 406)
        Me.Block52.Name = "Block52"
        Me.Block52.Size = New System.Drawing.Size(48, 48)
        Me.Block52.TabIndex = 52
        Me.Block52.xIndex = 7
        Me.Block52.yIndex = 6
        '
        'Block53
        '
        Me.Block53.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block53.backgroundColorDimmingDuration = 75
        Me.Block53.backgroundColorDimmingRatio = 0.12R
        Me.Block53.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block53.colorID = 0
        Me.Block53.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block53.isCastle = False
        Me.Block53.Location = New System.Drawing.Point(140, 406)
        Me.Block53.Name = "Block53"
        Me.Block53.Size = New System.Drawing.Size(48, 48)
        Me.Block53.TabIndex = 51
        Me.Block53.xIndex = 2
        Me.Block53.yIndex = 6
        '
        'Block54
        '
        Me.Block54.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block54.backgroundColorDimmingDuration = 75
        Me.Block54.backgroundColorDimmingRatio = 0.12R
        Me.Block54.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block54.colorID = 0
        Me.Block54.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block54.isCastle = False
        Me.Block54.Location = New System.Drawing.Point(194, 406)
        Me.Block54.Name = "Block54"
        Me.Block54.Size = New System.Drawing.Size(48, 48)
        Me.Block54.TabIndex = 50
        Me.Block54.xIndex = 3
        Me.Block54.yIndex = 6
        '
        'Block55
        '
        Me.Block55.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block55.backgroundColorDimmingDuration = 75
        Me.Block55.backgroundColorDimmingRatio = 0.12R
        Me.Block55.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block55.colorID = 0
        Me.Block55.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block55.isCastle = False
        Me.Block55.Location = New System.Drawing.Point(86, 406)
        Me.Block55.Name = "Block55"
        Me.Block55.Size = New System.Drawing.Size(48, 48)
        Me.Block55.TabIndex = 49
        Me.Block55.xIndex = 1
        Me.Block55.yIndex = 6
        '
        'Block56
        '
        Me.Block56.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block56.backgroundColorDimmingDuration = 75
        Me.Block56.backgroundColorDimmingRatio = 0.12R
        Me.Block56.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block56.colorID = 0
        Me.Block56.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block56.isCastle = False
        Me.Block56.Location = New System.Drawing.Point(32, 406)
        Me.Block56.Name = "Block56"
        Me.Block56.Size = New System.Drawing.Size(48, 48)
        Me.Block56.TabIndex = 48
        Me.Block56.xIndex = 0
        Me.Block56.yIndex = 6
        '
        'Block41
        '
        Me.Block41.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block41.backgroundColorDimmingDuration = 75
        Me.Block41.backgroundColorDimmingRatio = 0.12R
        Me.Block41.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block41.colorID = 0
        Me.Block41.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block41.isCastle = False
        Me.Block41.Location = New System.Drawing.Point(248, 352)
        Me.Block41.Name = "Block41"
        Me.Block41.Size = New System.Drawing.Size(48, 48)
        Me.Block41.TabIndex = 47
        Me.Block41.xIndex = 4
        Me.Block41.yIndex = 5
        '
        'Block42
        '
        Me.Block42.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block42.backgroundColorDimmingDuration = 75
        Me.Block42.backgroundColorDimmingRatio = 0.12R
        Me.Block42.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block42.colorID = 0
        Me.Block42.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block42.isCastle = False
        Me.Block42.Location = New System.Drawing.Point(302, 352)
        Me.Block42.Name = "Block42"
        Me.Block42.Size = New System.Drawing.Size(48, 48)
        Me.Block42.TabIndex = 46
        Me.Block42.xIndex = 5
        Me.Block42.yIndex = 5
        '
        'Block43
        '
        Me.Block43.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block43.backgroundColorDimmingDuration = 75
        Me.Block43.backgroundColorDimmingRatio = 0.12R
        Me.Block43.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block43.colorID = 0
        Me.Block43.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block43.isCastle = False
        Me.Block43.Location = New System.Drawing.Point(356, 352)
        Me.Block43.Name = "Block43"
        Me.Block43.Size = New System.Drawing.Size(48, 48)
        Me.Block43.TabIndex = 45
        Me.Block43.xIndex = 6
        Me.Block43.yIndex = 5
        '
        'Block44
        '
        Me.Block44.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block44.backgroundColorDimmingDuration = 75
        Me.Block44.backgroundColorDimmingRatio = 0.12R
        Me.Block44.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block44.colorID = 0
        Me.Block44.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block44.isCastle = False
        Me.Block44.Location = New System.Drawing.Point(410, 352)
        Me.Block44.Name = "Block44"
        Me.Block44.Size = New System.Drawing.Size(48, 48)
        Me.Block44.TabIndex = 44
        Me.Block44.xIndex = 7
        Me.Block44.yIndex = 5
        '
        'Block45
        '
        Me.Block45.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block45.backgroundColorDimmingDuration = 75
        Me.Block45.backgroundColorDimmingRatio = 0.12R
        Me.Block45.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block45.colorID = 0
        Me.Block45.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block45.isCastle = False
        Me.Block45.Location = New System.Drawing.Point(140, 352)
        Me.Block45.Name = "Block45"
        Me.Block45.Size = New System.Drawing.Size(48, 48)
        Me.Block45.TabIndex = 43
        Me.Block45.xIndex = 2
        Me.Block45.yIndex = 5
        '
        'Block46
        '
        Me.Block46.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block46.backgroundColorDimmingDuration = 75
        Me.Block46.backgroundColorDimmingRatio = 0.12R
        Me.Block46.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block46.colorID = 0
        Me.Block46.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block46.isCastle = False
        Me.Block46.Location = New System.Drawing.Point(194, 352)
        Me.Block46.Name = "Block46"
        Me.Block46.Size = New System.Drawing.Size(48, 48)
        Me.Block46.TabIndex = 42
        Me.Block46.xIndex = 3
        Me.Block46.yIndex = 5
        '
        'Block47
        '
        Me.Block47.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block47.backgroundColorDimmingDuration = 75
        Me.Block47.backgroundColorDimmingRatio = 0.12R
        Me.Block47.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block47.colorID = 0
        Me.Block47.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block47.isCastle = False
        Me.Block47.Location = New System.Drawing.Point(86, 352)
        Me.Block47.Name = "Block47"
        Me.Block47.Size = New System.Drawing.Size(48, 48)
        Me.Block47.TabIndex = 41
        Me.Block47.xIndex = 1
        Me.Block47.yIndex = 5
        '
        'Block48
        '
        Me.Block48.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block48.backgroundColorDimmingDuration = 75
        Me.Block48.backgroundColorDimmingRatio = 0.12R
        Me.Block48.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block48.colorID = 0
        Me.Block48.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block48.isCastle = False
        Me.Block48.Location = New System.Drawing.Point(32, 352)
        Me.Block48.Name = "Block48"
        Me.Block48.Size = New System.Drawing.Size(48, 48)
        Me.Block48.TabIndex = 40
        Me.Block48.xIndex = 0
        Me.Block48.yIndex = 5
        '
        'Block33
        '
        Me.Block33.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block33.backgroundColorDimmingDuration = 75
        Me.Block33.backgroundColorDimmingRatio = 0.12R
        Me.Block33.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block33.colorID = 0
        Me.Block33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block33.isCastle = False
        Me.Block33.Location = New System.Drawing.Point(248, 298)
        Me.Block33.Name = "Block33"
        Me.Block33.Size = New System.Drawing.Size(48, 48)
        Me.Block33.TabIndex = 39
        Me.Block33.xIndex = 4
        Me.Block33.yIndex = 4
        '
        'Block34
        '
        Me.Block34.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block34.backgroundColorDimmingDuration = 75
        Me.Block34.backgroundColorDimmingRatio = 0.12R
        Me.Block34.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block34.colorID = 0
        Me.Block34.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block34.isCastle = False
        Me.Block34.Location = New System.Drawing.Point(302, 298)
        Me.Block34.Name = "Block34"
        Me.Block34.Size = New System.Drawing.Size(48, 48)
        Me.Block34.TabIndex = 38
        Me.Block34.xIndex = 5
        Me.Block34.yIndex = 4
        '
        'Block35
        '
        Me.Block35.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block35.backgroundColorDimmingDuration = 75
        Me.Block35.backgroundColorDimmingRatio = 0.12R
        Me.Block35.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block35.colorID = 0
        Me.Block35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block35.isCastle = False
        Me.Block35.Location = New System.Drawing.Point(356, 298)
        Me.Block35.Name = "Block35"
        Me.Block35.Size = New System.Drawing.Size(48, 48)
        Me.Block35.TabIndex = 37
        Me.Block35.xIndex = 6
        Me.Block35.yIndex = 4
        '
        'Block36
        '
        Me.Block36.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block36.backgroundColorDimmingDuration = 75
        Me.Block36.backgroundColorDimmingRatio = 0.12R
        Me.Block36.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block36.colorID = 0
        Me.Block36.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block36.isCastle = False
        Me.Block36.Location = New System.Drawing.Point(410, 298)
        Me.Block36.Name = "Block36"
        Me.Block36.Size = New System.Drawing.Size(48, 48)
        Me.Block36.TabIndex = 36
        Me.Block36.xIndex = 7
        Me.Block36.yIndex = 4
        '
        'Block37
        '
        Me.Block37.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block37.backgroundColorDimmingDuration = 75
        Me.Block37.backgroundColorDimmingRatio = 0.12R
        Me.Block37.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block37.colorID = 0
        Me.Block37.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block37.isCastle = False
        Me.Block37.Location = New System.Drawing.Point(140, 298)
        Me.Block37.Name = "Block37"
        Me.Block37.Size = New System.Drawing.Size(48, 48)
        Me.Block37.TabIndex = 35
        Me.Block37.xIndex = 2
        Me.Block37.yIndex = 4
        '
        'Block38
        '
        Me.Block38.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block38.backgroundColorDimmingDuration = 75
        Me.Block38.backgroundColorDimmingRatio = 0.12R
        Me.Block38.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block38.colorID = 0
        Me.Block38.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block38.isCastle = False
        Me.Block38.Location = New System.Drawing.Point(194, 298)
        Me.Block38.Name = "Block38"
        Me.Block38.Size = New System.Drawing.Size(48, 48)
        Me.Block38.TabIndex = 34
        Me.Block38.xIndex = 3
        Me.Block38.yIndex = 4
        '
        'Block39
        '
        Me.Block39.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block39.backgroundColorDimmingDuration = 75
        Me.Block39.backgroundColorDimmingRatio = 0.12R
        Me.Block39.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block39.colorID = 0
        Me.Block39.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block39.isCastle = False
        Me.Block39.Location = New System.Drawing.Point(86, 298)
        Me.Block39.Name = "Block39"
        Me.Block39.Size = New System.Drawing.Size(48, 48)
        Me.Block39.TabIndex = 33
        Me.Block39.xIndex = 1
        Me.Block39.yIndex = 4
        '
        'Block40
        '
        Me.Block40.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block40.backgroundColorDimmingDuration = 75
        Me.Block40.backgroundColorDimmingRatio = 0.12R
        Me.Block40.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block40.colorID = 0
        Me.Block40.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block40.isCastle = False
        Me.Block40.Location = New System.Drawing.Point(32, 298)
        Me.Block40.Name = "Block40"
        Me.Block40.Size = New System.Drawing.Size(48, 48)
        Me.Block40.TabIndex = 32
        Me.Block40.xIndex = 0
        Me.Block40.yIndex = 4
        '
        'Block25
        '
        Me.Block25.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block25.backgroundColorDimmingDuration = 75
        Me.Block25.backgroundColorDimmingRatio = 0.12R
        Me.Block25.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block25.colorID = 0
        Me.Block25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block25.isCastle = False
        Me.Block25.Location = New System.Drawing.Point(248, 244)
        Me.Block25.Name = "Block25"
        Me.Block25.Size = New System.Drawing.Size(48, 48)
        Me.Block25.TabIndex = 31
        Me.Block25.xIndex = 4
        Me.Block25.yIndex = 3
        '
        'Block26
        '
        Me.Block26.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block26.backgroundColorDimmingDuration = 75
        Me.Block26.backgroundColorDimmingRatio = 0.12R
        Me.Block26.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block26.colorID = 0
        Me.Block26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block26.isCastle = False
        Me.Block26.Location = New System.Drawing.Point(302, 244)
        Me.Block26.Name = "Block26"
        Me.Block26.Size = New System.Drawing.Size(48, 48)
        Me.Block26.TabIndex = 30
        Me.Block26.xIndex = 5
        Me.Block26.yIndex = 3
        '
        'Block27
        '
        Me.Block27.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block27.backgroundColorDimmingDuration = 75
        Me.Block27.backgroundColorDimmingRatio = 0.12R
        Me.Block27.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block27.colorID = 0
        Me.Block27.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block27.isCastle = False
        Me.Block27.Location = New System.Drawing.Point(356, 244)
        Me.Block27.Name = "Block27"
        Me.Block27.Size = New System.Drawing.Size(48, 48)
        Me.Block27.TabIndex = 29
        Me.Block27.xIndex = 6
        Me.Block27.yIndex = 3
        '
        'Block28
        '
        Me.Block28.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block28.backgroundColorDimmingDuration = 75
        Me.Block28.backgroundColorDimmingRatio = 0.12R
        Me.Block28.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block28.colorID = 0
        Me.Block28.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block28.isCastle = False
        Me.Block28.Location = New System.Drawing.Point(410, 244)
        Me.Block28.Name = "Block28"
        Me.Block28.Size = New System.Drawing.Size(48, 48)
        Me.Block28.TabIndex = 28
        Me.Block28.xIndex = 7
        Me.Block28.yIndex = 3
        '
        'Block29
        '
        Me.Block29.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block29.backgroundColorDimmingDuration = 75
        Me.Block29.backgroundColorDimmingRatio = 0.12R
        Me.Block29.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block29.colorID = 0
        Me.Block29.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block29.isCastle = False
        Me.Block29.Location = New System.Drawing.Point(140, 244)
        Me.Block29.Name = "Block29"
        Me.Block29.Size = New System.Drawing.Size(48, 48)
        Me.Block29.TabIndex = 27
        Me.Block29.xIndex = 2
        Me.Block29.yIndex = 3
        '
        'Block30
        '
        Me.Block30.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block30.backgroundColorDimmingDuration = 75
        Me.Block30.backgroundColorDimmingRatio = 0.12R
        Me.Block30.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block30.colorID = 0
        Me.Block30.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block30.isCastle = False
        Me.Block30.Location = New System.Drawing.Point(194, 244)
        Me.Block30.Name = "Block30"
        Me.Block30.Size = New System.Drawing.Size(48, 48)
        Me.Block30.TabIndex = 26
        Me.Block30.xIndex = 3
        Me.Block30.yIndex = 3
        '
        'Block31
        '
        Me.Block31.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block31.backgroundColorDimmingDuration = 75
        Me.Block31.backgroundColorDimmingRatio = 0.12R
        Me.Block31.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block31.colorID = 0
        Me.Block31.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block31.isCastle = False
        Me.Block31.Location = New System.Drawing.Point(86, 244)
        Me.Block31.Name = "Block31"
        Me.Block31.Size = New System.Drawing.Size(48, 48)
        Me.Block31.TabIndex = 25
        Me.Block31.xIndex = 1
        Me.Block31.yIndex = 3
        '
        'Block32
        '
        Me.Block32.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block32.backgroundColorDimmingDuration = 75
        Me.Block32.backgroundColorDimmingRatio = 0.12R
        Me.Block32.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block32.colorID = 0
        Me.Block32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block32.isCastle = False
        Me.Block32.Location = New System.Drawing.Point(32, 244)
        Me.Block32.Name = "Block32"
        Me.Block32.Size = New System.Drawing.Size(48, 48)
        Me.Block32.TabIndex = 24
        Me.Block32.xIndex = 0
        Me.Block32.yIndex = 3
        '
        'Block17
        '
        Me.Block17.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block17.backgroundColorDimmingDuration = 75
        Me.Block17.backgroundColorDimmingRatio = 0.12R
        Me.Block17.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block17.colorID = 0
        Me.Block17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block17.isCastle = False
        Me.Block17.Location = New System.Drawing.Point(248, 190)
        Me.Block17.Name = "Block17"
        Me.Block17.Size = New System.Drawing.Size(48, 48)
        Me.Block17.TabIndex = 23
        Me.Block17.xIndex = 4
        Me.Block17.yIndex = 2
        '
        'Block18
        '
        Me.Block18.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block18.backgroundColorDimmingDuration = 75
        Me.Block18.backgroundColorDimmingRatio = 0.12R
        Me.Block18.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block18.colorID = 0
        Me.Block18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block18.isCastle = False
        Me.Block18.Location = New System.Drawing.Point(302, 190)
        Me.Block18.Name = "Block18"
        Me.Block18.Size = New System.Drawing.Size(48, 48)
        Me.Block18.TabIndex = 22
        Me.Block18.xIndex = 5
        Me.Block18.yIndex = 2
        '
        'Block19
        '
        Me.Block19.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block19.backgroundColorDimmingDuration = 75
        Me.Block19.backgroundColorDimmingRatio = 0.12R
        Me.Block19.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block19.colorID = 0
        Me.Block19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block19.isCastle = False
        Me.Block19.Location = New System.Drawing.Point(356, 190)
        Me.Block19.Name = "Block19"
        Me.Block19.Size = New System.Drawing.Size(48, 48)
        Me.Block19.TabIndex = 21
        Me.Block19.xIndex = 6
        Me.Block19.yIndex = 2
        '
        'Block20
        '
        Me.Block20.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block20.backgroundColorDimmingDuration = 75
        Me.Block20.backgroundColorDimmingRatio = 0.12R
        Me.Block20.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block20.colorID = 0
        Me.Block20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block20.isCastle = False
        Me.Block20.Location = New System.Drawing.Point(410, 190)
        Me.Block20.Name = "Block20"
        Me.Block20.Size = New System.Drawing.Size(48, 48)
        Me.Block20.TabIndex = 20
        Me.Block20.xIndex = 7
        Me.Block20.yIndex = 2
        '
        'Block21
        '
        Me.Block21.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block21.backgroundColorDimmingDuration = 75
        Me.Block21.backgroundColorDimmingRatio = 0.12R
        Me.Block21.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block21.colorID = 0
        Me.Block21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block21.isCastle = False
        Me.Block21.Location = New System.Drawing.Point(140, 190)
        Me.Block21.Name = "Block21"
        Me.Block21.Size = New System.Drawing.Size(48, 48)
        Me.Block21.TabIndex = 19
        Me.Block21.xIndex = 2
        Me.Block21.yIndex = 2
        '
        'Block22
        '
        Me.Block22.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block22.backgroundColorDimmingDuration = 75
        Me.Block22.backgroundColorDimmingRatio = 0.12R
        Me.Block22.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block22.colorID = 0
        Me.Block22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block22.isCastle = False
        Me.Block22.Location = New System.Drawing.Point(194, 190)
        Me.Block22.Name = "Block22"
        Me.Block22.Size = New System.Drawing.Size(48, 48)
        Me.Block22.TabIndex = 18
        Me.Block22.xIndex = 3
        Me.Block22.yIndex = 2
        '
        'Block23
        '
        Me.Block23.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block23.backgroundColorDimmingDuration = 75
        Me.Block23.backgroundColorDimmingRatio = 0.12R
        Me.Block23.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block23.colorID = 0
        Me.Block23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block23.isCastle = False
        Me.Block23.Location = New System.Drawing.Point(86, 190)
        Me.Block23.Name = "Block23"
        Me.Block23.Size = New System.Drawing.Size(48, 48)
        Me.Block23.TabIndex = 17
        Me.Block23.xIndex = 1
        Me.Block23.yIndex = 2
        '
        'Block24
        '
        Me.Block24.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block24.backgroundColorDimmingDuration = 75
        Me.Block24.backgroundColorDimmingRatio = 0.12R
        Me.Block24.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block24.colorID = 0
        Me.Block24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block24.isCastle = False
        Me.Block24.Location = New System.Drawing.Point(32, 190)
        Me.Block24.Name = "Block24"
        Me.Block24.Size = New System.Drawing.Size(48, 48)
        Me.Block24.TabIndex = 16
        Me.Block24.xIndex = 0
        Me.Block24.yIndex = 2
        '
        'Block9
        '
        Me.Block9.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block9.backgroundColorDimmingDuration = 75
        Me.Block9.backgroundColorDimmingRatio = 0.12R
        Me.Block9.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block9.colorID = 0
        Me.Block9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block9.isCastle = False
        Me.Block9.Location = New System.Drawing.Point(248, 136)
        Me.Block9.Name = "Block9"
        Me.Block9.Size = New System.Drawing.Size(48, 48)
        Me.Block9.TabIndex = 15
        Me.Block9.xIndex = 4
        Me.Block9.yIndex = 1
        '
        'Block10
        '
        Me.Block10.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block10.backgroundColorDimmingDuration = 75
        Me.Block10.backgroundColorDimmingRatio = 0.12R
        Me.Block10.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block10.colorID = 0
        Me.Block10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block10.isCastle = False
        Me.Block10.Location = New System.Drawing.Point(302, 136)
        Me.Block10.Name = "Block10"
        Me.Block10.Size = New System.Drawing.Size(48, 48)
        Me.Block10.TabIndex = 14
        Me.Block10.xIndex = 5
        Me.Block10.yIndex = 1
        '
        'Block11
        '
        Me.Block11.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block11.backgroundColorDimmingDuration = 75
        Me.Block11.backgroundColorDimmingRatio = 0.12R
        Me.Block11.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block11.colorID = 0
        Me.Block11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block11.isCastle = False
        Me.Block11.Location = New System.Drawing.Point(356, 136)
        Me.Block11.Name = "Block11"
        Me.Block11.Size = New System.Drawing.Size(48, 48)
        Me.Block11.TabIndex = 13
        Me.Block11.xIndex = 6
        Me.Block11.yIndex = 1
        '
        'Block12
        '
        Me.Block12.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block12.backgroundColorDimmingDuration = 75
        Me.Block12.backgroundColorDimmingRatio = 0.12R
        Me.Block12.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block12.colorID = 0
        Me.Block12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block12.isCastle = False
        Me.Block12.Location = New System.Drawing.Point(410, 136)
        Me.Block12.Name = "Block12"
        Me.Block12.Size = New System.Drawing.Size(48, 48)
        Me.Block12.TabIndex = 12
        Me.Block12.xIndex = 7
        Me.Block12.yIndex = 1
        '
        'Block13
        '
        Me.Block13.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block13.backgroundColorDimmingDuration = 75
        Me.Block13.backgroundColorDimmingRatio = 0.12R
        Me.Block13.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block13.colorID = 0
        Me.Block13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block13.isCastle = False
        Me.Block13.Location = New System.Drawing.Point(140, 136)
        Me.Block13.Name = "Block13"
        Me.Block13.Size = New System.Drawing.Size(48, 48)
        Me.Block13.TabIndex = 11
        Me.Block13.xIndex = 2
        Me.Block13.yIndex = 1
        '
        'Block14
        '
        Me.Block14.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block14.backgroundColorDimmingDuration = 75
        Me.Block14.backgroundColorDimmingRatio = 0.12R
        Me.Block14.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block14.colorID = 0
        Me.Block14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block14.isCastle = False
        Me.Block14.Location = New System.Drawing.Point(194, 136)
        Me.Block14.Name = "Block14"
        Me.Block14.Size = New System.Drawing.Size(48, 48)
        Me.Block14.TabIndex = 10
        Me.Block14.xIndex = 3
        Me.Block14.yIndex = 1
        '
        'Block15
        '
        Me.Block15.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block15.backgroundColorDimmingDuration = 75
        Me.Block15.backgroundColorDimmingRatio = 0.12R
        Me.Block15.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block15.colorID = 0
        Me.Block15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block15.isCastle = False
        Me.Block15.Location = New System.Drawing.Point(86, 136)
        Me.Block15.Name = "Block15"
        Me.Block15.Size = New System.Drawing.Size(48, 48)
        Me.Block15.TabIndex = 9
        Me.Block15.xIndex = 1
        Me.Block15.yIndex = 1
        '
        'Block16
        '
        Me.Block16.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block16.backgroundColorDimmingDuration = 75
        Me.Block16.backgroundColorDimmingRatio = 0.12R
        Me.Block16.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block16.colorID = 0
        Me.Block16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block16.isCastle = False
        Me.Block16.Location = New System.Drawing.Point(32, 136)
        Me.Block16.Name = "Block16"
        Me.Block16.Size = New System.Drawing.Size(48, 48)
        Me.Block16.TabIndex = 8
        Me.Block16.xIndex = 0
        Me.Block16.yIndex = 1
        '
        'Block5
        '
        Me.Block5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block5.backgroundColorDimmingDuration = 75
        Me.Block5.backgroundColorDimmingRatio = 0.12R
        Me.Block5.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block5.colorID = 0
        Me.Block5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block5.isCastle = False
        Me.Block5.Location = New System.Drawing.Point(248, 82)
        Me.Block5.Name = "Block5"
        Me.Block5.Size = New System.Drawing.Size(48, 48)
        Me.Block5.TabIndex = 7
        Me.Block5.xIndex = 4
        Me.Block5.yIndex = 0
        '
        'Block6
        '
        Me.Block6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block6.backgroundColorDimmingDuration = 75
        Me.Block6.backgroundColorDimmingRatio = 0.12R
        Me.Block6.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block6.colorID = 0
        Me.Block6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block6.isCastle = False
        Me.Block6.Location = New System.Drawing.Point(302, 82)
        Me.Block6.Name = "Block6"
        Me.Block6.Size = New System.Drawing.Size(48, 48)
        Me.Block6.TabIndex = 6
        Me.Block6.xIndex = 5
        Me.Block6.yIndex = 0
        '
        'Block7
        '
        Me.Block7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block7.backgroundColorDimmingDuration = 75
        Me.Block7.backgroundColorDimmingRatio = 0.12R
        Me.Block7.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block7.colorID = 0
        Me.Block7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block7.isCastle = False
        Me.Block7.Location = New System.Drawing.Point(356, 82)
        Me.Block7.Name = "Block7"
        Me.Block7.Size = New System.Drawing.Size(48, 48)
        Me.Block7.TabIndex = 5
        Me.Block7.xIndex = 6
        Me.Block7.yIndex = 0
        '
        'Block8
        '
        Me.Block8.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block8.backgroundColorDimmingDuration = 75
        Me.Block8.backgroundColorDimmingRatio = 0.12R
        Me.Block8.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block8.colorID = 0
        Me.Block8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block8.isCastle = False
        Me.Block8.Location = New System.Drawing.Point(410, 82)
        Me.Block8.Name = "Block8"
        Me.Block8.Size = New System.Drawing.Size(48, 48)
        Me.Block8.TabIndex = 4
        Me.Block8.xIndex = 7
        Me.Block8.yIndex = 0
        '
        'Block3
        '
        Me.Block3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block3.backgroundColorDimmingDuration = 75
        Me.Block3.backgroundColorDimmingRatio = 0.12R
        Me.Block3.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block3.colorID = 0
        Me.Block3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block3.isCastle = False
        Me.Block3.Location = New System.Drawing.Point(140, 82)
        Me.Block3.Name = "Block3"
        Me.Block3.Size = New System.Drawing.Size(48, 48)
        Me.Block3.TabIndex = 3
        Me.Block3.xIndex = 2
        Me.Block3.yIndex = 0
        '
        'Block4
        '
        Me.Block4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block4.backgroundColorDimmingDuration = 75
        Me.Block4.backgroundColorDimmingRatio = 0.12R
        Me.Block4.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block4.colorID = 0
        Me.Block4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block4.isCastle = False
        Me.Block4.Location = New System.Drawing.Point(194, 82)
        Me.Block4.Name = "Block4"
        Me.Block4.Size = New System.Drawing.Size(48, 48)
        Me.Block4.TabIndex = 2
        Me.Block4.xIndex = 3
        Me.Block4.yIndex = 0
        '
        'Block2
        '
        Me.Block2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block2.backgroundColorDimmingDuration = 75
        Me.Block2.backgroundColorDimmingRatio = 0.12R
        Me.Block2.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block2.colorID = 0
        Me.Block2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block2.isCastle = False
        Me.Block2.Location = New System.Drawing.Point(86, 82)
        Me.Block2.Name = "Block2"
        Me.Block2.Size = New System.Drawing.Size(48, 48)
        Me.Block2.TabIndex = 1
        Me.Block2.xIndex = 1
        Me.Block2.yIndex = 0
        '
        'Block1
        '
        Me.Block1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Block1.backgroundColorDimmingDuration = 75
        Me.Block1.backgroundColorDimmingRatio = 0.12R
        Me.Block1.blockColor = System.Drawing.Color.WhiteSmoke
        Me.Block1.colorID = 0
        Me.Block1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Block1.isCastle = False
        Me.Block1.Location = New System.Drawing.Point(32, 82)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(48, 48)
        Me.Block1.TabIndex = 0
        Me.Block1.xIndex = 0
        Me.Block1.yIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(691, 545)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnClearReturn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.Alert1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCalc)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Block57)
        Me.Controls.Add(Me.Block58)
        Me.Controls.Add(Me.Block59)
        Me.Controls.Add(Me.Block60)
        Me.Controls.Add(Me.Block61)
        Me.Controls.Add(Me.Block62)
        Me.Controls.Add(Me.Block63)
        Me.Controls.Add(Me.Block64)
        Me.Controls.Add(Me.Block49)
        Me.Controls.Add(Me.Block50)
        Me.Controls.Add(Me.Block51)
        Me.Controls.Add(Me.Block52)
        Me.Controls.Add(Me.Block53)
        Me.Controls.Add(Me.Block54)
        Me.Controls.Add(Me.Block55)
        Me.Controls.Add(Me.Block56)
        Me.Controls.Add(Me.Block41)
        Me.Controls.Add(Me.Block42)
        Me.Controls.Add(Me.Block43)
        Me.Controls.Add(Me.Block44)
        Me.Controls.Add(Me.Block45)
        Me.Controls.Add(Me.Block46)
        Me.Controls.Add(Me.Block47)
        Me.Controls.Add(Me.Block48)
        Me.Controls.Add(Me.Block33)
        Me.Controls.Add(Me.Block34)
        Me.Controls.Add(Me.Block35)
        Me.Controls.Add(Me.Block36)
        Me.Controls.Add(Me.Block37)
        Me.Controls.Add(Me.Block38)
        Me.Controls.Add(Me.Block39)
        Me.Controls.Add(Me.Block40)
        Me.Controls.Add(Me.Block25)
        Me.Controls.Add(Me.Block26)
        Me.Controls.Add(Me.Block27)
        Me.Controls.Add(Me.Block28)
        Me.Controls.Add(Me.Block29)
        Me.Controls.Add(Me.Block30)
        Me.Controls.Add(Me.Block31)
        Me.Controls.Add(Me.Block32)
        Me.Controls.Add(Me.Block17)
        Me.Controls.Add(Me.Block18)
        Me.Controls.Add(Me.Block19)
        Me.Controls.Add(Me.Block20)
        Me.Controls.Add(Me.Block21)
        Me.Controls.Add(Me.Block22)
        Me.Controls.Add(Me.Block23)
        Me.Controls.Add(Me.Block24)
        Me.Controls.Add(Me.Block9)
        Me.Controls.Add(Me.Block10)
        Me.Controls.Add(Me.Block11)
        Me.Controls.Add(Me.Block12)
        Me.Controls.Add(Me.Block13)
        Me.Controls.Add(Me.Block14)
        Me.Controls.Add(Me.Block15)
        Me.Controls.Add(Me.Block16)
        Me.Controls.Add(Me.Block5)
        Me.Controls.Add(Me.Block6)
        Me.Controls.Add(Me.Block7)
        Me.Controls.Add(Me.Block8)
        Me.Controls.Add(Me.Block3)
        Me.Controls.Add(Me.Block4)
        Me.Controls.Add(Me.Block2)
        Me.Controls.Add(Me.Block1)
        Me.Controls.Add(Me.imgCalc)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Block1 As Block
    Friend WithEvents Block2 As Block
    Friend WithEvents Block3 As Block
    Friend WithEvents Block4 As Block
    Friend WithEvents Block5 As Block
    Friend WithEvents Block6 As Block
    Friend WithEvents Block7 As Block
    Friend WithEvents Block8 As Block
    Friend WithEvents Block9 As Block
    Friend WithEvents Block10 As Block
    Friend WithEvents Block11 As Block
    Friend WithEvents Block12 As Block
    Friend WithEvents Block13 As Block
    Friend WithEvents Block14 As Block
    Friend WithEvents Block15 As Block
    Friend WithEvents Block16 As Block
    Friend WithEvents Block17 As Block
    Friend WithEvents Block18 As Block
    Friend WithEvents Block19 As Block
    Friend WithEvents Block20 As Block
    Friend WithEvents Block21 As Block
    Friend WithEvents Block22 As Block
    Friend WithEvents Block23 As Block
    Friend WithEvents Block24 As Block
    Friend WithEvents Block25 As Block
    Friend WithEvents Block26 As Block
    Friend WithEvents Block27 As Block
    Friend WithEvents Block28 As Block
    Friend WithEvents Block29 As Block
    Friend WithEvents Block30 As Block
    Friend WithEvents Block31 As Block
    Friend WithEvents Block32 As Block
    Friend WithEvents Block33 As Block
    Friend WithEvents Block34 As Block
    Friend WithEvents Block35 As Block
    Friend WithEvents Block36 As Block
    Friend WithEvents Block37 As Block
    Friend WithEvents Block38 As Block
    Friend WithEvents Block39 As Block
    Friend WithEvents Block40 As Block
    Friend WithEvents Block41 As Block
    Friend WithEvents Block42 As Block
    Friend WithEvents Block43 As Block
    Friend WithEvents Block44 As Block
    Friend WithEvents Block45 As Block
    Friend WithEvents Block46 As Block
    Friend WithEvents Block47 As Block
    Friend WithEvents Block48 As Block
    Friend WithEvents Block49 As Block
    Friend WithEvents Block50 As Block
    Friend WithEvents Block51 As Block
    Friend WithEvents Block52 As Block
    Friend WithEvents Block53 As Block
    Friend WithEvents Block54 As Block
    Friend WithEvents Block55 As Block
    Friend WithEvents Block56 As Block
    Friend WithEvents Block57 As Block
    Friend WithEvents Block58 As Block
    Friend WithEvents Block59 As Block
    Friend WithEvents Block60 As Block
    Friend WithEvents Block61 As Block
    Friend WithEvents Block62 As Block
    Friend WithEvents Block63 As Block
    Friend WithEvents Block64 As Block
    Friend WithEvents btnClear As FlatButton
    Friend WithEvents btnGen As FlatButton
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnLoad As FlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents imgCalc As PictureBox
    Friend WithEvents btnCalc As FlatButton
    Friend WithEvents lblCalc As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CalcTimer As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Alert1 As Alert
    Friend WithEvents btnAbort As FlatButton
    Friend WithEvents ThreadUpdateTimer As Timer
    Friend WithEvents btnClose As FlatButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnClearReturn As FlatButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
