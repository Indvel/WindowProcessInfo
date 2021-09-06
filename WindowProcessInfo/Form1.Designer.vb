<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WindowText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HandleLabel = New System.Windows.Forms.Label()
        Me.ProcessId = New System.Windows.Forms.Label()
        Me.ModuleFile = New System.Windows.Forms.Label()
        Me.MousePos = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WindowText
        '
        Me.WindowText.ForeColor = System.Drawing.Color.SlateBlue
        Me.WindowText.Location = New System.Drawing.Point(12, 34)
        Me.WindowText.Name = "WindowText"
        Me.WindowText.Size = New System.Drawing.Size(504, 55)
        Me.WindowText.TabIndex = 0
        Me.WindowText.Text = "WindowText"
        Me.WindowText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Handle :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Process Id :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Main Module File :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Mouse Position :"
        '
        'HandleLabel
        '
        Me.HandleLabel.AutoSize = True
        Me.HandleLabel.ForeColor = System.Drawing.Color.Chocolate
        Me.HandleLabel.Location = New System.Drawing.Point(70, 113)
        Me.HandleLabel.Name = "HandleLabel"
        Me.HandleLabel.Size = New System.Drawing.Size(11, 12)
        Me.HandleLabel.TabIndex = 3
        Me.HandleLabel.Text = "-"
        '
        'ProcessId
        '
        Me.ProcessId.AutoSize = True
        Me.ProcessId.ForeColor = System.Drawing.Color.Red
        Me.ProcessId.Location = New System.Drawing.Point(92, 134)
        Me.ProcessId.Name = "ProcessId"
        Me.ProcessId.Size = New System.Drawing.Size(11, 12)
        Me.ProcessId.TabIndex = 3
        Me.ProcessId.Text = "-"
        '
        'ModuleFile
        '
        Me.ModuleFile.AutoSize = True
        Me.ModuleFile.ForeColor = System.Drawing.Color.ForestGreen
        Me.ModuleFile.Location = New System.Drawing.Point(130, 158)
        Me.ModuleFile.Name = "ModuleFile"
        Me.ModuleFile.Size = New System.Drawing.Size(11, 12)
        Me.ModuleFile.TabIndex = 3
        Me.ModuleFile.Text = "-"
        '
        'MousePos
        '
        Me.MousePos.AutoSize = True
        Me.MousePos.ForeColor = System.Drawing.Color.SteelBlue
        Me.MousePos.Location = New System.Drawing.Point(120, 181)
        Me.MousePos.Name = "MousePos"
        Me.MousePos.Size = New System.Drawing.Size(11, 12)
        Me.MousePos.TabIndex = 3
        Me.MousePos.Text = "-"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(247, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 203)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MousePos)
        Me.Controls.Add(Me.ModuleFile)
        Me.Controls.Add(Me.ProcessId)
        Me.Controls.Add(Me.HandleLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WindowText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "WindowProcessInfo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WindowText As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents HandleLabel As System.Windows.Forms.Label
    Friend WithEvents ProcessId As System.Windows.Forms.Label
    Friend WithEvents ModuleFile As System.Windows.Forms.Label
    Friend WithEvents MousePos As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
