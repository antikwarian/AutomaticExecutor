<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.executor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filePickerBS = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.selectBox = New System.Windows.Forms.ComboBox()
        Me.psInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.executorPS = New System.Windows.Forms.Button()
        Me.filePickerPS = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.backUp = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog4 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameInput
        '
        Me.nameInput.Location = New System.Drawing.Point(9, 62)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(175, 21)
        Me.nameInput.TabIndex = 0
        '
        'executor
        '
        Me.executor.Location = New System.Drawing.Point(208, 67)
        Me.executor.Name = "executor"
        Me.executor.Size = New System.Drawing.Size(107, 30)
        Me.executor.TabIndex = 1
        Me.executor.Text = "Execute"
        Me.executor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient Name (LastFirst):"
        '
        'filePickerBS
        '
        Me.filePickerBS.Location = New System.Drawing.Point(6, 6)
        Me.filePickerBS.Name = "filePickerBS"
        Me.filePickerBS.Size = New System.Drawing.Size(126, 34)
        Me.filePickerBS.TabIndex = 4
        Me.filePickerBS.Text = "Find File"
        Me.filePickerBS.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "open"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 135)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.filePickerBS)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.executor)
        Me.TabPage1.Controls.Add(Me.nameInput)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 105)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Billing Sheets"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.selectBox)
        Me.TabPage2.Controls.Add(Me.psInput)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.executorPS)
        Me.TabPage2.Controls.Add(Me.filePickerPS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(439, 105)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Provider Suite"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Select Type:"
        '
        'selectBox
        '
        Me.selectBox.FormattingEnabled = True
        Me.selectBox.Items.AddRange(New Object() {"Provider Day Sheet", "PT Accountability", "Appointment List"})
        Me.selectBox.Location = New System.Drawing.Point(186, 18)
        Me.selectBox.Name = "selectBox"
        Me.selectBox.Size = New System.Drawing.Size(129, 22)
        Me.selectBox.TabIndex = 22
        '
        'psInput
        '
        Me.psInput.Location = New System.Drawing.Point(9, 60)
        Me.psInput.Name = "psInput"
        Me.psInput.Size = New System.Drawing.Size(64, 21)
        Me.psInput.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Provider Initials:"
        '
        'executorPS
        '
        Me.executorPS.Location = New System.Drawing.Point(208, 67)
        Me.executorPS.Name = "executorPS"
        Me.executorPS.Size = New System.Drawing.Size(107, 30)
        Me.executorPS.TabIndex = 20
        Me.executorPS.Text = "Execute"
        Me.executorPS.UseVisualStyleBackColor = True
        '
        'filePickerPS
        '
        Me.filePickerPS.Location = New System.Drawing.Point(6, 6)
        Me.filePickerPS.Name = "filePickerPS"
        Me.filePickerPS.Size = New System.Drawing.Size(126, 34)
        Me.filePickerPS.TabIndex = 18
        Me.filePickerPS.Text = "Find File"
        Me.filePickerPS.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.backUp)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(439, 105)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Back it Up v.05"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'backUp
        '
        Me.backUp.Location = New System.Drawing.Point(116, 19)
        Me.backUp.Name = "backUp"
        Me.backUp.Size = New System.Drawing.Size(181, 56)
        Me.backUp.TabIndex = 0
        Me.backUp.Text = "BACK THAT TF UP"
        Me.backUp.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog3"
        '
        'OpenFileDialog4
        '
        Me.OpenFileDialog4.FileName = "OpenFileDialog4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(471, 157)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "The Automatic Executor v1.6"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameInput As TextBox
    Friend WithEvents executor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents filePickerBS As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents backUp As Button
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents selectBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents filePickerPS As Button
    Friend WithEvents executorPS As Button
    Friend WithEvents psInput As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog4 As OpenFileDialog
End Class
