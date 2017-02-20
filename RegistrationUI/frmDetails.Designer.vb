<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCar = New System.Windows.Forms.GroupBox()
        Me.txtMaxSpeed = New System.Windows.Forms.TextBox()
        Me.chkHybrid = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbTruck = New System.Windows.Forms.GroupBox()
        Me.chk4x4 = New System.Windows.Forms.CheckBox()
        Me.txtMaxCargo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbCar.SuspendLayout()
        Me.gbTruck.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(223, 222)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(304, 222)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtColor)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.txtMake)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 67)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(235, 39)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 7
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(234, 12)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 6
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(64, 41)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(100, 20)
        Me.txtMake.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(64, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Make"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'gbCar
        '
        Me.gbCar.Controls.Add(Me.txtMaxSpeed)
        Me.gbCar.Controls.Add(Me.chkHybrid)
        Me.gbCar.Controls.Add(Me.Label7)
        Me.gbCar.Location = New System.Drawing.Point(13, 85)
        Me.gbCar.Name = "gbCar"
        Me.gbCar.Size = New System.Drawing.Size(366, 57)
        Me.gbCar.TabIndex = 4
        Me.gbCar.TabStop = False
        Me.gbCar.Text = "Car"
        '
        'txtMaxSpeed
        '
        Me.txtMaxSpeed.Location = New System.Drawing.Point(70, 20)
        Me.txtMaxSpeed.Name = "txtMaxSpeed"
        Me.txtMaxSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxSpeed.TabIndex = 3
        '
        'chkHybrid
        '
        Me.chkHybrid.AutoSize = True
        Me.chkHybrid.Location = New System.Drawing.Point(235, 20)
        Me.chkHybrid.Name = "chkHybrid"
        Me.chkHybrid.Size = New System.Drawing.Size(56, 17)
        Me.chkHybrid.TabIndex = 2
        Me.chkHybrid.Text = "Hybrid"
        Me.chkHybrid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Max Speed"
        '
        'gbTruck
        '
        Me.gbTruck.Controls.Add(Me.chk4x4)
        Me.gbTruck.Controls.Add(Me.txtMaxCargo)
        Me.gbTruck.Controls.Add(Me.Label11)
        Me.gbTruck.Location = New System.Drawing.Point(13, 148)
        Me.gbTruck.Name = "gbTruck"
        Me.gbTruck.Size = New System.Drawing.Size(366, 57)
        Me.gbTruck.TabIndex = 6
        Me.gbTruck.TabStop = False
        Me.gbTruck.Text = "Truck"
        '
        'chk4x4
        '
        Me.chk4x4.AutoSize = True
        Me.chk4x4.Location = New System.Drawing.Point(235, 28)
        Me.chk4x4.Name = "chk4x4"
        Me.chk4x4.Size = New System.Drawing.Size(43, 17)
        Me.chk4x4.TabIndex = 3
        Me.chk4x4.Text = "4x4"
        Me.chk4x4.UseVisualStyleBackColor = True
        '
        'txtMaxCargo
        '
        Me.txtMaxCargo.Location = New System.Drawing.Point(70, 22)
        Me.txtMaxCargo.Name = "txtMaxCargo"
        Me.txtMaxCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxCargo.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Max Cargo"
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 265)
        Me.Controls.Add(Me.gbTruck)
        Me.Controls.Add(Me.gbCar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDetails"
        Me.Text = "Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbCar.ResumeLayout(False)
        Me.gbCar.PerformLayout()
        Me.gbTruck.ResumeLayout(False)
        Me.gbTruck.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbCar As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbTruck As System.Windows.Forms.GroupBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtMake As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMaxSpeed As System.Windows.Forms.TextBox
    Friend WithEvents chkHybrid As System.Windows.Forms.CheckBox
    Friend WithEvents chk4x4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtMaxCargo As System.Windows.Forms.TextBox
End Class
