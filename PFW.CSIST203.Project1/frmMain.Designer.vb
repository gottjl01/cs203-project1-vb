<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnModulus = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.txtArray1 = New System.Windows.Forms.TextBox()
        Me.txtArray2 = New System.Windows.Forms.TextBox()
        Me.txtArray3 = New System.Windows.Forms.TextBox()
        Me.txtArray4 = New System.Windows.Forms.TextBox()
        Me.txtArray5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.btnShiftRight = New System.Windows.Forms.Button()
        Me.btnShiftLeft = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(54, 62)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(127, 20)
        Me.txtValue1.TabIndex = 0
        Me.txtValue1.Text = "0"
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(239, 62)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(126, 20)
        Me.txtValue2.TabIndex = 1
        Me.txtValue2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Value 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Value 2"
        '
        'txtResultant
        '
        Me.txtResultant.Enabled = False
        Me.txtResultant.Location = New System.Drawing.Point(435, 62)
        Me.txtResultant.Name = "txtResultant"
        Me.txtResultant.Size = New System.Drawing.Size(100, 20)
        Me.txtResultant.TabIndex = 4
        Me.txtResultant.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultant"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(54, 142)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(135, 142)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 7
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(216, 142)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 8
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(297, 142)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 9
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnModulus
        '
        Me.btnModulus.Location = New System.Drawing.Point(379, 142)
        Me.btnModulus.Name = "btnModulus"
        Me.btnModulus.Size = New System.Drawing.Size(75, 23)
        Me.btnModulus.TabIndex = 10
        Me.btnModulus.Text = "%"
        Me.btnModulus.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(461, 142)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(75, 23)
        Me.btnPower.TabIndex = 11
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'txtArray1
        '
        Me.txtArray1.Location = New System.Drawing.Point(45, 81)
        Me.txtArray1.Name = "txtArray1"
        Me.txtArray1.Size = New System.Drawing.Size(100, 20)
        Me.txtArray1.TabIndex = 12
        Me.txtArray1.Text = "first"
        '
        'txtArray2
        '
        Me.txtArray2.Location = New System.Drawing.Point(151, 81)
        Me.txtArray2.Name = "txtArray2"
        Me.txtArray2.Size = New System.Drawing.Size(100, 20)
        Me.txtArray2.TabIndex = 13
        Me.txtArray2.Text = "second"
        '
        'txtArray3
        '
        Me.txtArray3.Location = New System.Drawing.Point(258, 80)
        Me.txtArray3.Name = "txtArray3"
        Me.txtArray3.Size = New System.Drawing.Size(100, 20)
        Me.txtArray3.TabIndex = 14
        Me.txtArray3.Text = "third"
        '
        'txtArray4
        '
        Me.txtArray4.Location = New System.Drawing.Point(370, 80)
        Me.txtArray4.Name = "txtArray4"
        Me.txtArray4.Size = New System.Drawing.Size(100, 20)
        Me.txtArray4.TabIndex = 15
        Me.txtArray4.Text = "fourth"
        '
        'txtArray5
        '
        Me.txtArray5.Location = New System.Drawing.Point(477, 80)
        Me.txtArray5.Name = "txtArray5"
        Me.txtArray5.Size = New System.Drawing.Size(100, 20)
        Me.txtArray5.TabIndex = 16
        Me.txtArray5.Text = "fifth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Data 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Data 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Data 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(367, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Data 4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(474, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Data 5"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(45, 121)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Store"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(127, 121)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 23
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnRandomize
        '
        Me.btnRandomize.Location = New System.Drawing.Point(207, 121)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(75, 23)
        Me.btnRandomize.TabIndex = 24
        Me.btnRandomize.Text = "Randomize"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'btnShiftRight
        '
        Me.btnShiftRight.Location = New System.Drawing.Point(288, 121)
        Me.btnShiftRight.Name = "btnShiftRight"
        Me.btnShiftRight.Size = New System.Drawing.Size(75, 23)
        Me.btnShiftRight.TabIndex = 25
        Me.btnShiftRight.Text = "Shift Right"
        Me.btnShiftRight.UseVisualStyleBackColor = True
        '
        'btnShiftLeft
        '
        Me.btnShiftLeft.Location = New System.Drawing.Point(370, 121)
        Me.btnShiftLeft.Name = "btnShiftLeft"
        Me.btnShiftLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnShiftLeft.TabIndex = 26
        Me.btnShiftLeft.Text = "Shift Left"
        Me.btnShiftLeft.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(452, 121)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 23)
        Me.btnReverse.TabIndex = 27
        Me.btnReverse.Text = "Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOperator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtValue1)
        Me.GroupBox1.Controls.Add(Me.txtValue2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtResultant)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnSubtract)
        Me.GroupBox1.Controls.Add(Me.btnMultiply)
        Me.GroupBox1.Controls.Add(Me.btnDivide)
        Me.GroupBox1.Controls.Add(Me.btnModulus)
        Me.GroupBox1.Controls.Add(Me.btnPower)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 197)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mathematical Functions"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(204, 65)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(13, 13)
        Me.lblOperator.TabIndex = 12
        Me.lblOperator.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtArray1)
        Me.GroupBox2.Controls.Add(Me.btnReverse)
        Me.GroupBox2.Controls.Add(Me.txtArray2)
        Me.GroupBox2.Controls.Add(Me.btnShiftLeft)
        Me.GroupBox2.Controls.Add(Me.txtArray3)
        Me.GroupBox2.Controls.Add(Me.btnShiftRight)
        Me.GroupBox2.Controls.Add(Me.txtArray4)
        Me.GroupBox2.Controls.Add(Me.btnRandomize)
        Me.GroupBox2.Controls.Add(Me.txtArray5)
        Me.GroupBox2.Controls.Add(Me.btnLoad)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 196)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Array Functions"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 456)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtValue1 As Windows.Forms.TextBox
    Friend WithEvents txtValue2 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtResultant As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnSubtract As Windows.Forms.Button
    Friend WithEvents btnMultiply As Windows.Forms.Button
    Friend WithEvents btnDivide As Windows.Forms.Button
    Friend WithEvents btnModulus As Windows.Forms.Button
    Friend WithEvents btnPower As Windows.Forms.Button
    Friend WithEvents txtArray1 As Windows.Forms.TextBox
    Friend WithEvents txtArray2 As Windows.Forms.TextBox
    Friend WithEvents txtArray3 As Windows.Forms.TextBox
    Friend WithEvents txtArray4 As Windows.Forms.TextBox
    Friend WithEvents txtArray5 As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents btnLoad As Windows.Forms.Button
    Friend WithEvents btnRandomize As Windows.Forms.Button
    Friend WithEvents btnShiftRight As Windows.Forms.Button
    Friend WithEvents btnShiftLeft As Windows.Forms.Button
    Friend WithEvents btnReverse As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents lblOperator As Windows.Forms.Label
End Class
