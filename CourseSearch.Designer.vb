<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseSearch
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
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.doneButton = New System.Windows.Forms.Button()
        Me.courseListView = New System.Windows.Forms.ListView()
        Me.legendLabel = New System.Windows.Forms.Label()
        Me.openLabel = New System.Windows.Forms.Label()
        Me.closedLabel = New System.Windows.Forms.Label()
        Me.waitLabel = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.DescripLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.roomLabel = New System.Windows.Forms.Label()
        Me.UnitLabel = New System.Windows.Forms.Label()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.P2desLabel = New System.Windows.Forms.Label()
        Me.P4desLabel = New System.Windows.Forms.Label()
        Me.MdesLabel = New System.Windows.Forms.Label()
        Me.MtimeLabel = New System.Windows.Forms.Label()
        Me.P2timeLabel = New System.Windows.Forms.Label()
        Me.P4timeLabel = New System.Windows.Forms.Label()
        Me.MroomLabel = New System.Windows.Forms.Label()
        Me.P2roomLabel = New System.Windows.Forms.Label()
        Me.P4roomLabel = New System.Windows.Forms.Label()
        Me.MunitLabel = New System.Windows.Forms.Label()
        Me.P2unitLabel = New System.Windows.Forms.Label()
        Me.P4unitLabel = New System.Windows.Forms.Label()
        Me.MPictureBox = New System.Windows.Forms.PictureBox()
        Me.P2PictureBox = New System.Windows.Forms.PictureBox()
        Me.P4PictureBox = New System.Windows.Forms.PictureBox()
        Me.courseTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.P209Desc = New System.Windows.Forms.Label()
        Me.P209Time = New System.Windows.Forms.Label()
        Me.P209Room = New System.Windows.Forms.Label()
        Me.P209Unit = New System.Windows.Forms.Label()
        Me.P209Status = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MSection = New System.Windows.Forms.Label()
        Me.M2Section = New System.Windows.Forms.Label()
        Me.P2Section = New System.Windows.Forms.Label()
        Me.P4Section = New System.Windows.Forms.Label()
        Me.P9Section = New System.Windows.Forms.Label()
        Me.M2Checkbox = New System.Windows.Forms.RadioButton()
        Me.MCheckBox = New System.Windows.Forms.RadioButton()
        Me.P2CheckBox = New System.Windows.Forms.RadioButton()
        Me.P4CheckBox = New System.Windows.Forms.RadioButton()
        Me.PSY209CB = New System.Windows.Forms.RadioButton()
        Me.M2DesLabel = New System.Windows.Forms.Label()
        Me.M2RoomLabel = New System.Windows.Forms.Label()
        Me.M2UnitLabel = New System.Windows.Forms.Label()
        Me.M2PictureBox = New System.Windows.Forms.PictureBox()
        Me.M2TimeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SwapButton = New System.Windows.Forms.Button()
        Me.ViewInfoButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.courseTableLayoutPanel.SuspendLayout()
        CType(Me.P209Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(665, 72)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(5)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(124, 34)
        Me.searchButton.TabIndex = 0
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.searchTextBox.Location = New System.Drawing.Point(47, 72)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(608, 51)
        Me.searchTextBox.TabIndex = 1
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(619, 550)
        Me.cancelButton.Margin = New System.Windows.Forms.Padding(5)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(163, 46)
        Me.cancelButton.TabIndex = 3
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneButton.Location = New System.Drawing.Point(67, 550)
        Me.doneButton.Margin = New System.Windows.Forms.Padding(5)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(163, 46)
        Me.doneButton.TabIndex = 4
        Me.doneButton.Text = "Add"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'courseListView
        '
        Me.courseListView.Location = New System.Drawing.Point(47, 150)
        Me.courseListView.Margin = New System.Windows.Forms.Padding(5)
        Me.courseListView.Name = "courseListView"
        Me.courseListView.Size = New System.Drawing.Size(760, 372)
        Me.courseListView.TabIndex = 14
        Me.courseListView.UseCompatibleStateImageBehavior = False
        '
        'legendLabel
        '
        Me.legendLabel.AutoSize = True
        Me.legendLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.legendLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.legendLabel.Location = New System.Drawing.Point(349, 167)
        Me.legendLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.legendLabel.Name = "legendLabel"
        Me.legendLabel.Size = New System.Drawing.Size(119, 32)
        Me.legendLabel.TabIndex = 17
        Me.legendLabel.Text = "Legend:"
        '
        'openLabel
        '
        Me.openLabel.AutoSize = True
        Me.openLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.openLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openLabel.Location = New System.Drawing.Point(496, 167)
        Me.openLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.openLabel.Name = "openLabel"
        Me.openLabel.Size = New System.Drawing.Size(73, 29)
        Me.openLabel.TabIndex = 19
        Me.openLabel.Text = "Open"
        '
        'closedLabel
        '
        Me.closedLabel.AutoSize = True
        Me.closedLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closedLabel.Location = New System.Drawing.Point(621, 169)
        Me.closedLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.closedLabel.Name = "closedLabel"
        Me.closedLabel.Size = New System.Drawing.Size(90, 29)
        Me.closedLabel.TabIndex = 21
        Me.closedLabel.Text = "Closed"
        '
        'waitLabel
        '
        Me.waitLabel.AutoSize = True
        Me.waitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.waitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitLabel.Location = New System.Drawing.Point(743, 167)
        Me.waitLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.waitLabel.Name = "waitLabel"
        Me.waitLabel.Size = New System.Drawing.Size(90, 29)
        Me.waitLabel.TabIndex = 23
        Me.waitLabel.Text = "Waitlist"
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.yellow_circle1
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(698, 163)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 26)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(450, 163)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 26)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.blue_circle1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(568, 163)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 26)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'courseLabel
        '
        Me.courseLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.courseLabel.AutoSize = True
        Me.courseLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.courseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(8, 1)
        Me.courseLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(79, 37)
        Me.courseLabel.TabIndex = 24
        Me.courseLabel.Text = "Course"
        '
        'DescripLabel
        '
        Me.DescripLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DescripLabel.AutoSize = True
        Me.DescripLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DescripLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripLabel.Location = New System.Drawing.Point(102, 1)
        Me.DescripLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DescripLabel.Name = "DescripLabel"
        Me.DescripLabel.Size = New System.Drawing.Size(142, 37)
        Me.DescripLabel.TabIndex = 25
        Me.DescripLabel.Text = "Description"
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(262, 1)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(74, 37)
        Me.TimeLabel.TabIndex = 26
        Me.TimeLabel.Text = "Times"
        '
        'roomLabel
        '
        Me.roomLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roomLabel.AutoSize = True
        Me.roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomLabel.Location = New System.Drawing.Point(354, 1)
        Me.roomLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(106, 37)
        Me.roomLabel.TabIndex = 27
        Me.roomLabel.Text = "Room"
        '
        'UnitLabel
        '
        Me.UnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UnitLabel.AutoSize = True
        Me.UnitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitLabel.Location = New System.Drawing.Point(474, 1)
        Me.UnitLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(44, 37)
        Me.UnitLabel.TabIndex = 28
        Me.UnitLabel.Text = "Unit"
        '
        'statusLabel
        '
        Me.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.statusLabel.AutoSize = True
        Me.statusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(534, 1)
        Me.statusLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(78, 37)
        Me.statusLabel.TabIndex = 29
        Me.statusLabel.Text = "Status"
        '
        'P2desLabel
        '
        Me.P2desLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2desLabel.AutoSize = True
        Me.P2desLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2desLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2desLabel.Location = New System.Drawing.Point(114, 140)
        Me.P2desLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P2desLabel.Name = "P2desLabel"
        Me.P2desLabel.Size = New System.Drawing.Size(117, 48)
        Me.P2desLabel.TabIndex = 32
        Me.P2desLabel.Text = "Intro to Psy 110"
        Me.P2desLabel.Visible = False
        '
        'P4desLabel
        '
        Me.P4desLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4desLabel.AutoSize = True
        Me.P4desLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4desLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4desLabel.Location = New System.Drawing.Point(107, 189)
        Me.P4desLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P4desLabel.Name = "P4desLabel"
        Me.P4desLabel.Size = New System.Drawing.Size(131, 50)
        Me.P4desLabel.TabIndex = 33
        Me.P4desLabel.Text = "Social Psychology"
        Me.P4desLabel.Visible = False
        '
        'MdesLabel
        '
        Me.MdesLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MdesLabel.AutoSize = True
        Me.MdesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MdesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdesLabel.Location = New System.Drawing.Point(110, 39)
        Me.MdesLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MdesLabel.Name = "MdesLabel"
        Me.MdesLabel.Size = New System.Drawing.Size(126, 46)
        Me.MdesLabel.TabIndex = 34
        Me.MdesLabel.Text = "Discrete Math I"
        Me.MdesLabel.Visible = False
        '
        'MtimeLabel
        '
        Me.MtimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MtimeLabel.AutoSize = True
        Me.MtimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MtimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtimeLabel.Location = New System.Drawing.Point(259, 39)
        Me.MtimeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MtimeLabel.Name = "MtimeLabel"
        Me.MtimeLabel.Size = New System.Drawing.Size(80, 46)
        Me.MtimeLabel.TabIndex = 35
        Me.MtimeLabel.Text = "Wed 3-4," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Fri 12-2"
        Me.MtimeLabel.Visible = False
        '
        'P2timeLabel
        '
        Me.P2timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2timeLabel.AutoSize = True
        Me.P2timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2timeLabel.Location = New System.Drawing.Point(257, 140)
        Me.P2timeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P2timeLabel.Name = "P2timeLabel"
        Me.P2timeLabel.Size = New System.Drawing.Size(85, 48)
        Me.P2timeLabel.TabIndex = 36
        Me.P2timeLabel.Text = "Tues 12-1," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thur 2-4"
        Me.P2timeLabel.Visible = False
        '
        'P4timeLabel
        '
        Me.P4timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4timeLabel.AutoSize = True
        Me.P4timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4timeLabel.Location = New System.Drawing.Point(259, 189)
        Me.P4timeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P4timeLabel.Name = "P4timeLabel"
        Me.P4timeLabel.Size = New System.Drawing.Size(80, 50)
        Me.P4timeLabel.TabIndex = 37
        Me.P4timeLabel.Text = "Mon 8-10," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wed 12-1"
        Me.P4timeLabel.Visible = False
        '
        'MroomLabel
        '
        Me.MroomLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MroomLabel.AutoSize = True
        Me.MroomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MroomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MroomLabel.Location = New System.Drawing.Point(354, 39)
        Me.MroomLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MroomLabel.Name = "MroomLabel"
        Me.MroomLabel.Size = New System.Drawing.Size(105, 46)
        Me.MroomLabel.TabIndex = 38
        Me.MroomLabel.Text = "KHE321-C"
        Me.MroomLabel.Visible = False
        '
        'P2roomLabel
        '
        Me.P2roomLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2roomLabel.AutoSize = True
        Me.P2roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2roomLabel.Location = New System.Drawing.Point(360, 140)
        Me.P2roomLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P2roomLabel.Name = "P2roomLabel"
        Me.P2roomLabel.Size = New System.Drawing.Size(93, 48)
        Me.P2roomLabel.TabIndex = 39
        Me.P2roomLabel.Text = "VIC500"
        Me.P2roomLabel.Visible = False
        '
        'P4roomLabel
        '
        Me.P4roomLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4roomLabel.AutoSize = True
        Me.P4roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4roomLabel.Location = New System.Drawing.Point(354, 189)
        Me.P4roomLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P4roomLabel.Name = "P4roomLabel"
        Me.P4roomLabel.Size = New System.Drawing.Size(105, 50)
        Me.P4roomLabel.TabIndex = 40
        Me.P4roomLabel.Text = "KHE114"
        Me.P4roomLabel.Visible = False
        '
        'MunitLabel
        '
        Me.MunitLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MunitLabel.AutoSize = True
        Me.MunitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MunitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MunitLabel.Location = New System.Drawing.Point(481, 46)
        Me.MunitLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MunitLabel.Name = "MunitLabel"
        Me.MunitLabel.Size = New System.Drawing.Size(31, 32)
        Me.MunitLabel.TabIndex = 41
        Me.MunitLabel.Text = "1"
        Me.MunitLabel.Visible = False
        '
        'P2unitLabel
        '
        Me.P2unitLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2unitLabel.AutoSize = True
        Me.P2unitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2unitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2unitLabel.Location = New System.Drawing.Point(481, 148)
        Me.P2unitLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P2unitLabel.Name = "P2unitLabel"
        Me.P2unitLabel.Size = New System.Drawing.Size(31, 32)
        Me.P2unitLabel.TabIndex = 42
        Me.P2unitLabel.Text = "1"
        Me.P2unitLabel.Visible = False
        '
        'P4unitLabel
        '
        Me.P4unitLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4unitLabel.AutoSize = True
        Me.P4unitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4unitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4unitLabel.Location = New System.Drawing.Point(481, 198)
        Me.P4unitLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P4unitLabel.Name = "P4unitLabel"
        Me.P4unitLabel.Size = New System.Drawing.Size(31, 32)
        Me.P4unitLabel.TabIndex = 43
        Me.P4unitLabel.Text = "1"
        Me.P4unitLabel.Visible = False
        '
        'MPictureBox
        '
        Me.MPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MPictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.MPictureBox.Location = New System.Drawing.Point(563, 49)
        Me.MPictureBox.Margin = New System.Windows.Forms.Padding(5)
        Me.MPictureBox.Name = "MPictureBox"
        Me.MPictureBox.Size = New System.Drawing.Size(21, 26)
        Me.MPictureBox.TabIndex = 44
        Me.MPictureBox.TabStop = False
        Me.MPictureBox.Visible = False
        '
        'P2PictureBox
        '
        Me.P2PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.P2PictureBox.Location = New System.Drawing.Point(563, 151)
        Me.P2PictureBox.Margin = New System.Windows.Forms.Padding(5)
        Me.P2PictureBox.Name = "P2PictureBox"
        Me.P2PictureBox.Size = New System.Drawing.Size(21, 26)
        Me.P2PictureBox.TabIndex = 45
        Me.P2PictureBox.TabStop = False
        Me.P2PictureBox.Visible = False
        '
        'P4PictureBox
        '
        Me.P4PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.P4PictureBox.Location = New System.Drawing.Point(563, 201)
        Me.P4PictureBox.Margin = New System.Windows.Forms.Padding(5)
        Me.P4PictureBox.Name = "P4PictureBox"
        Me.P4PictureBox.Size = New System.Drawing.Size(21, 26)
        Me.P4PictureBox.TabIndex = 46
        Me.P4PictureBox.TabStop = False
        Me.P4PictureBox.Visible = False
        '
        'courseTableLayoutPanel
        '
        Me.courseTableLayoutPanel.AutoScroll = True
        Me.courseTableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.courseTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.courseTableLayoutPanel.ColumnCount = 7
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.88546!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.11454!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.courseTableLayoutPanel.Controls.Add(Me.courseLabel, 0, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.DescripLabel, 1, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.TimeLabel, 2, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.MPictureBox, 5, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.roomLabel, 3, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.UnitLabel, 4, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.statusLabel, 5, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.MunitLabel, 4, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.MroomLabel, 3, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.MdesLabel, 1, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Desc, 1, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Time, 2, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Room, 3, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Unit, 4, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Status, 5, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4desLabel, 1, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4timeLabel, 2, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4roomLabel, 3, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4unitLabel, 4, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4PictureBox, 5, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2desLabel, 1, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2timeLabel, 2, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2roomLabel, 3, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2unitLabel, 4, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.Label2, 6, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.MSection, 6, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2Section, 6, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2Section, 6, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4Section, 6, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P9Section, 6, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2Checkbox, 0, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.MCheckBox, 0, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2CheckBox, 0, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4CheckBox, 0, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.PSY209CB, 0, 5)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2DesLabel, 1, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2RoomLabel, 3, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2UnitLabel, 4, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2PictureBox, 5, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2PictureBox, 5, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.M2TimeLabel, 2, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.MtimeLabel, 2, 1)
        Me.courseTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.courseTableLayoutPanel.Location = New System.Drawing.Point(67, 204)
        Me.courseTableLayoutPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.courseTableLayoutPanel.Name = "courseTableLayoutPanel"
        Me.courseTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.courseTableLayoutPanel.RowCount = 6
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.courseTableLayoutPanel.Size = New System.Drawing.Size(722, 291)
        Me.courseTableLayoutPanel.TabIndex = 47
        '
        'P209Desc
        '
        Me.P209Desc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P209Desc.AutoSize = True
        Me.P209Desc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P209Desc.Location = New System.Drawing.Point(104, 240)
        Me.P209Desc.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P209Desc.Name = "P209Desc"
        Me.P209Desc.Size = New System.Drawing.Size(138, 50)
        Me.P209Desc.TabIndex = 48
        Me.P209Desc.Text = "Industrial Psychology"
        Me.P209Desc.Visible = False
        '
        'P209Time
        '
        Me.P209Time.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P209Time.AutoSize = True
        Me.P209Time.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P209Time.Location = New System.Drawing.Point(259, 240)
        Me.P209Time.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P209Time.Name = "P209Time"
        Me.P209Time.Size = New System.Drawing.Size(80, 50)
        Me.P209Time.TabIndex = 49
        Me.P209Time.Text = "Mon 8-10," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wed 12-1"
        Me.P209Time.Visible = False
        '
        'P209Room
        '
        Me.P209Room.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P209Room.AutoSize = True
        Me.P209Room.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Room.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P209Room.Location = New System.Drawing.Point(354, 240)
        Me.P209Room.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P209Room.Name = "P209Room"
        Me.P209Room.Size = New System.Drawing.Size(105, 50)
        Me.P209Room.TabIndex = 50
        Me.P209Room.Text = "KHE114"
        Me.P209Room.Visible = False
        '
        'P209Unit
        '
        Me.P209Unit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P209Unit.AutoSize = True
        Me.P209Unit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P209Unit.Location = New System.Drawing.Point(481, 249)
        Me.P209Unit.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.P209Unit.Name = "P209Unit"
        Me.P209Unit.Size = New System.Drawing.Size(31, 32)
        Me.P209Unit.TabIndex = 51
        Me.P209Unit.Text = "1"
        Me.P209Unit.Visible = False
        '
        'P209Status
        '
        Me.P209Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P209Status.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.P209Status.InitialImage = Nothing
        Me.P209Status.Location = New System.Drawing.Point(563, 252)
        Me.P209Status.Margin = New System.Windows.Forms.Padding(5)
        Me.P209Status.Name = "P209Status"
        Me.P209Status.Size = New System.Drawing.Size(21, 26)
        Me.P209Status.TabIndex = 52
        Me.P209Status.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(624, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 37)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Section"
        '
        'MSection
        '
        Me.MSection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MSection.AutoSize = True
        Me.MSection.Location = New System.Drawing.Point(647, 46)
        Me.MSection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MSection.Name = "MSection"
        Me.MSection.Size = New System.Drawing.Size(47, 32)
        Me.MSection.TabIndex = 54
        Me.MSection.Text = "01"
        '
        'M2Section
        '
        Me.M2Section.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2Section.AutoSize = True
        Me.M2Section.Location = New System.Drawing.Point(647, 96)
        Me.M2Section.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M2Section.Name = "M2Section"
        Me.M2Section.Size = New System.Drawing.Size(47, 32)
        Me.M2Section.TabIndex = 55
        Me.M2Section.Text = "02"
        '
        'P2Section
        '
        Me.P2Section.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2Section.AutoSize = True
        Me.P2Section.Location = New System.Drawing.Point(647, 148)
        Me.P2Section.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2Section.Name = "P2Section"
        Me.P2Section.Size = New System.Drawing.Size(47, 32)
        Me.P2Section.TabIndex = 56
        Me.P2Section.Text = "01"
        '
        'P4Section
        '
        Me.P4Section.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4Section.AutoSize = True
        Me.P4Section.Location = New System.Drawing.Point(647, 198)
        Me.P4Section.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P4Section.Name = "P4Section"
        Me.P4Section.Size = New System.Drawing.Size(47, 32)
        Me.P4Section.TabIndex = 57
        Me.P4Section.Text = "01"
        '
        'P9Section
        '
        Me.P9Section.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P9Section.AutoSize = True
        Me.P9Section.Location = New System.Drawing.Point(647, 249)
        Me.P9Section.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P9Section.Name = "P9Section"
        Me.P9Section.Size = New System.Drawing.Size(47, 32)
        Me.P9Section.TabIndex = 58
        Me.P9Section.Text = "01"
        '
        'M2Checkbox
        '
        Me.M2Checkbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2Checkbox.AutoSize = True
        Me.M2Checkbox.Location = New System.Drawing.Point(5, 94)
        Me.M2Checkbox.Margin = New System.Windows.Forms.Padding(4)
        Me.M2Checkbox.Name = "M2Checkbox"
        Me.M2Checkbox.Size = New System.Drawing.Size(86, 36)
        Me.M2Checkbox.TabIndex = 63
        Me.M2Checkbox.TabStop = True
        Me.M2Checkbox.Text = "MTH110"
        Me.M2Checkbox.UseVisualStyleBackColor = True
        '
        'MCheckBox
        '
        Me.MCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MCheckBox.AutoSize = True
        Me.MCheckBox.Location = New System.Drawing.Point(5, 44)
        Me.MCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MCheckBox.Name = "MCheckBox"
        Me.MCheckBox.Size = New System.Drawing.Size(86, 36)
        Me.MCheckBox.TabIndex = 59
        Me.MCheckBox.TabStop = True
        Me.MCheckBox.Text = "MTH110"
        Me.MCheckBox.UseVisualStyleBackColor = True
        '
        'P2CheckBox
        '
        Me.P2CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P2CheckBox.AutoSize = True
        Me.P2CheckBox.Location = New System.Drawing.Point(5, 146)
        Me.P2CheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.P2CheckBox.Name = "P2CheckBox"
        Me.P2CheckBox.Size = New System.Drawing.Size(86, 36)
        Me.P2CheckBox.TabIndex = 60
        Me.P2CheckBox.TabStop = True
        Me.P2CheckBox.Text = "PSY202"
        Me.P2CheckBox.UseVisualStyleBackColor = True
        '
        'P4CheckBox
        '
        Me.P4CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P4CheckBox.AutoSize = True
        Me.P4CheckBox.Location = New System.Drawing.Point(5, 196)
        Me.P4CheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.P4CheckBox.Name = "P4CheckBox"
        Me.P4CheckBox.Size = New System.Drawing.Size(86, 36)
        Me.P4CheckBox.TabIndex = 61
        Me.P4CheckBox.TabStop = True
        Me.P4CheckBox.Text = "PSY124"
        Me.P4CheckBox.UseVisualStyleBackColor = True
        '
        'PSY209CB
        '
        Me.PSY209CB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PSY209CB.AutoSize = True
        Me.PSY209CB.Location = New System.Drawing.Point(5, 247)
        Me.PSY209CB.Margin = New System.Windows.Forms.Padding(4)
        Me.PSY209CB.Name = "PSY209CB"
        Me.PSY209CB.Size = New System.Drawing.Size(86, 36)
        Me.PSY209CB.TabIndex = 62
        Me.PSY209CB.TabStop = True
        Me.PSY209CB.Text = "PSY209"
        Me.PSY209CB.UseVisualStyleBackColor = True
        '
        'M2DesLabel
        '
        Me.M2DesLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2DesLabel.AutoSize = True
        Me.M2DesLabel.Location = New System.Drawing.Point(110, 86)
        Me.M2DesLabel.Name = "M2DesLabel"
        Me.M2DesLabel.Size = New System.Drawing.Size(126, 53)
        Me.M2DesLabel.TabIndex = 64
        Me.M2DesLabel.Text = "Discrete Math I"
        '
        'M2RoomLabel
        '
        Me.M2RoomLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2RoomLabel.AutoSize = True
        Me.M2RoomLabel.Location = New System.Drawing.Point(354, 86)
        Me.M2RoomLabel.Name = "M2RoomLabel"
        Me.M2RoomLabel.Size = New System.Drawing.Size(105, 53)
        Me.M2RoomLabel.TabIndex = 66
        Me.M2RoomLabel.Text = "KHE225"
        '
        'M2UnitLabel
        '
        Me.M2UnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2UnitLabel.AutoSize = True
        Me.M2UnitLabel.Location = New System.Drawing.Point(481, 96)
        Me.M2UnitLabel.Name = "M2UnitLabel"
        Me.M2UnitLabel.Size = New System.Drawing.Size(31, 32)
        Me.M2UnitLabel.TabIndex = 67
        Me.M2UnitLabel.Text = "1"
        '
        'M2PictureBox
        '
        Me.M2PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.M2PictureBox.Location = New System.Drawing.Point(563, 99)
        Me.M2PictureBox.Name = "M2PictureBox"
        Me.M2PictureBox.Size = New System.Drawing.Size(21, 26)
        Me.M2PictureBox.TabIndex = 68
        Me.M2PictureBox.TabStop = False
        '
        'M2TimeLabel
        '
        Me.M2TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.M2TimeLabel.AutoSize = True
        Me.M2TimeLabel.Location = New System.Drawing.Point(255, 86)
        Me.M2TimeLabel.Name = "M2TimeLabel"
        Me.M2TimeLabel.Size = New System.Drawing.Size(88, 53)
        Me.M2TimeLabel.TabIndex = 65
        Me.M2TimeLabel.Text = "Mon 10-12," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tues 4-5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 33)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Please enter a course code:"
        '
        'SwapButton
        '
        Me.SwapButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwapButton.Location = New System.Drawing.Point(251, 550)
        Me.SwapButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SwapButton.Name = "SwapButton"
        Me.SwapButton.Size = New System.Drawing.Size(163, 46)
        Me.SwapButton.TabIndex = 49
        Me.SwapButton.Text = "Swap"
        Me.SwapButton.UseVisualStyleBackColor = True
        '
        'ViewInfoButton
        '
        Me.ViewInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewInfoButton.Location = New System.Drawing.Point(435, 550)
        Me.ViewInfoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewInfoButton.Name = "ViewInfoButton"
        Me.ViewInfoButton.Size = New System.Drawing.Size(163, 46)
        Me.ViewInfoButton.TabIndex = 50
        Me.ViewInfoButton.Text = "View info"
        Me.ViewInfoButton.UseVisualStyleBackColor = True
        '
        'CourseSearch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(850, 608)
        Me.Controls.Add(Me.ViewInfoButton)
        Me.Controls.Add(Me.SwapButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.courseTableLayoutPanel)
        Me.Controls.Add(Me.waitLabel)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.closedLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.openLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.legendLabel)
        Me.Controls.Add(Me.courseListView)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "CourseSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.courseTableLayoutPanel.ResumeLayout(False)
        Me.courseTableLayoutPanel.PerformLayout()
        CType(Me.P209Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents doneButton As Button
    Friend WithEvents courseListView As ListView
    Friend WithEvents legendLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents openLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents closedLabel As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents waitLabel As Label
    Friend WithEvents courseLabel As Label
    Friend WithEvents DescripLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents roomLabel As Label
    Friend WithEvents UnitLabel As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents P2desLabel As Label
    Friend WithEvents P4desLabel As Label
    Friend WithEvents MdesLabel As Label
    Friend WithEvents MtimeLabel As Label
    Friend WithEvents P2timeLabel As Label
    Friend WithEvents P4timeLabel As Label
    Friend WithEvents MroomLabel As Label
    Friend WithEvents P2roomLabel As Label
    Friend WithEvents P4roomLabel As Label
    Friend WithEvents MunitLabel As Label
    Friend WithEvents P2unitLabel As Label
    Friend WithEvents P4unitLabel As Label
    Friend WithEvents MPictureBox As PictureBox
    Friend WithEvents P2PictureBox As PictureBox
    Friend WithEvents P4PictureBox As PictureBox
    Public WithEvents courseTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents P209Desc As Label
    Friend WithEvents P209Time As Label
    Friend WithEvents P209Room As Label
    Friend WithEvents P209Unit As Label
    Friend WithEvents P209Status As PictureBox
    Friend WithEvents SwapButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MSection As Label
    Friend WithEvents M2Section As Label
    Friend WithEvents P2Section As Label
    Friend WithEvents P4Section As Label
    Friend WithEvents P9Section As Label
    Friend WithEvents MCheckBox As RadioButton
    Friend WithEvents P2CheckBox As RadioButton
    Friend WithEvents P4CheckBox As RadioButton
    Friend WithEvents PSY209CB As RadioButton
    Friend WithEvents M2Checkbox As RadioButton
    Friend WithEvents M2DesLabel As Label
    Friend WithEvents M2RoomLabel As Label
    Friend WithEvents M2UnitLabel As Label
    Friend WithEvents M2PictureBox As PictureBox
    Friend WithEvents M2TimeLabel As Label
    Friend WithEvents ViewInfoButton As Button
End Class
