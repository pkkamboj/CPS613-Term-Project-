<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Enter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Masked1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Enter
        '
        Me.Enter.Location = New System.Drawing.Point(58, 210)
        Me.Enter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Enter.Name = "Enter"
        Me.Enter.Size = New System.Drawing.Size(112, 35)
        Me.Enter.TabIndex = 0
        Me.Enter.Text = "Enter"
        Me.Enter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(266, 210)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(152, 83)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(254, 26)
        Me.Username.TabIndex = 4
        '
        'Masked1
        '
        Me.Masked1.Location = New System.Drawing.Point(152, 128)
        Me.Masked1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Masked1.Name = "Masked1"
        Me.Masked1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Masked1.Size = New System.Drawing.Size(254, 26)
        Me.Masked1.TabIndex = 5
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 326)
        Me.Controls.Add(Me.Masked1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Enter)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Enter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Masked1 As MaskedTextBox
End Class
