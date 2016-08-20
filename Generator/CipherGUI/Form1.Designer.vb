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
        Me.outputText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.generate = New System.Windows.Forms.RadioButton()
        Me.read = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'outputText
        '
        Me.outputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outputText.Location = New System.Drawing.Point(13, 291)
        Me.outputText.Multiline = True
        Me.outputText.Name = "outputText"
        Me.outputText.Size = New System.Drawing.Size(856, 167)
        Me.outputText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Output:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Generate or Read?"
        '
        'generate
        '
        Me.generate.AutoSize = True
        Me.generate.Checked = True
        Me.generate.Location = New System.Drawing.Point(16, 30)
        Me.generate.Name = "generate"
        Me.generate.Size = New System.Drawing.Size(69, 17)
        Me.generate.TabIndex = 3
        Me.generate.TabStop = True
        Me.generate.Text = "Generate"
        Me.generate.UseVisualStyleBackColor = True
        '
        'read
        '
        Me.read.AutoSize = True
        Me.read.Location = New System.Drawing.Point(16, 53)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(51, 17)
        Me.read.TabIndex = 4
        Me.read.TabStop = True
        Me.read.Text = "Read"
        Me.read.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Input:"
        '
        'input
        '
        Me.input.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input.Location = New System.Drawing.Point(12, 90)
        Me.input.Multiline = True
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(856, 121)
        Me.input.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(857, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Go!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 52)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "An interesting fact:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This program requires Python 3 to be on the path." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If this " &
    "doesn't work INSTALL PYTHON 3 TO THE PATH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "also, remove Python 2 from the path i" &
    "f it's there." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(857, 449)
        Me.ProgressBar1.TabIndex = 10
        Me.ProgressBar1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 470)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.read)
        Me.Controls.Add(Me.generate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.outputText)
        Me.Name = "Form1"
        Me.Text = "Cipher GUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents outputText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents generate As RadioButton
    Friend WithEvents read As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents input As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
