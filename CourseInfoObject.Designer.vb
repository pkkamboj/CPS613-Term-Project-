<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseInfoObject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.NameCheckBox = New System.Windows.Forms.CheckBox()
        Me.Desc = New System.Windows.Forms.Label()
        Me.Unit = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.Times = New System.Windows.Forms.Label()
        Me.Room = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameCheckBox
        '
        Me.NameCheckBox.AutoSize = True
        Me.NameCheckBox.Location = New System.Drawing.Point(8, 4)
        Me.NameCheckBox.Name = "NameCheckBox"
        Me.NameCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.NameCheckBox.TabIndex = 0
        Me.NameCheckBox.Text = "Course Name"
        Me.NameCheckBox.UseVisualStyleBackColor = True
        '
        'Desc
        '
        Me.Desc.AutoSize = True
        Me.Desc.Location = New System.Drawing.Point(165, 6)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(60, 13)
        Me.Desc.TabIndex = 1
        Me.Desc.Text = "Description"
        '
        'Unit
        '
        Me.Unit.AutoSize = True
        Me.Unit.Location = New System.Drawing.Point(496, 6)
        Me.Unit.Name = "Unit"
        Me.Unit.Size = New System.Drawing.Size(26, 13)
        Me.Unit.TabIndex = 2
        Me.Unit.Text = "Unit"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(589, 6)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(37, 13)
        Me.Status.TabIndex = 3
        Me.Status.Text = "Status"
        '
        'Times
        '
        Me.Times.AutoSize = True
        Me.Times.Location = New System.Drawing.Point(292, 6)
        Me.Times.Name = "Times"
        Me.Times.Size = New System.Drawing.Size(35, 13)
        Me.Times.TabIndex = 4
        Me.Times.Text = "Times"
        '
        'Room
        '
        Me.Room.AutoSize = True
        Me.Room.Location = New System.Drawing.Point(394, 6)
        Me.Room.Name = "Room"
        Me.Room.Size = New System.Drawing.Size(35, 13)
        Me.Room.TabIndex = 5
        Me.Room.Text = "Room"
        '
        'CourseInfoObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Room)
        Me.Controls.Add(Me.Times)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Unit)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.NameCheckBox)
        Me.Name = "CourseInfoObject"
        Me.Size = New System.Drawing.Size(674, 75)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameCheckBox As CheckBox
    Friend WithEvents Desc As Label
    Friend WithEvents Unit As Label
    Friend WithEvents Status As Label
    Friend WithEvents Times As Label
    Friend WithEvents Room As Label
End Class
