<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseObject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DropButton = New System.Windows.Forms.Button()
        Me.CourseName = New System.Windows.Forms.Label()
        Me.CourseCode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.SystemColors.Control
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(155, 58)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(68, 35)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "+"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DropButton
        '
        Me.DropButton.BackColor = System.Drawing.SystemColors.Control
        Me.DropButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DropButton.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropButton.Location = New System.Drawing.Point(4, 58)
        Me.DropButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(68, 35)
        Me.DropButton.TabIndex = 1
        Me.DropButton.Text = "-"
        Me.DropButton.UseVisualStyleBackColor = False
        '
        'CourseName
        '
        Me.CourseName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CourseName.AutoSize = True
        Me.CourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseName.Location = New System.Drawing.Point(61, 23)
        Me.CourseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CourseName.Name = "CourseName"
        Me.CourseName.Size = New System.Drawing.Size(105, 17)
        Me.CourseName.TabIndex = 2
        Me.CourseName.Text = "Course Name"
        '
        'CourseCode
        '
        Me.CourseCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CourseCode.AutoSize = True
        Me.CourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseCode.Location = New System.Drawing.Point(63, 9)
        Me.CourseCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CourseCode.Name = "CourseCode"
        Me.CourseCode.Size = New System.Drawing.Size(101, 17)
        Me.CourseCode.TabIndex = 3
        Me.CourseCode.Text = "Course Code"
        '
        'CourseObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.CourseCode)
        Me.Controls.Add(Me.CourseName)
        Me.Controls.Add(Me.DropButton)
        Me.Controls.Add(Me.AddButton)
        Me.Cursor = System.Windows.Forms.Cursors.Help
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CourseObject"
        Me.Size = New System.Drawing.Size(225, 93)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents DropButton As Button
    Friend WithEvents CourseName As Label
    Friend WithEvents CourseCode As Label
End Class
