Public Class CourseSearch
    Private courseName As String
    Private courseCode As String

    Public course As CourseObject
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        course.connectSearch(Me)
        MCheckBox.Visible = False
        MdesLabel.Visible = False
        MtimeLabel.Visible = False
        MroomLabel.Visible = False
        MunitLabel.Visible = False
        MPictureBox.Visible = False
        MSection.Visible = False

        M2Checkbox.Visible = False
        M2DesLabel.Visible = False
        M2TimeLabel.Visible = False
        M2RoomLabel.Visible = False
        M2UnitLabel.Visible = False
        M2PictureBox.Visible = False
        M2Section.Visible = False

        P2CheckBox.Visible = False
        P2desLabel.Visible = False
        P2timeLabel.Visible = False
        P2roomLabel.Visible = False
        P2unitLabel.Visible = False
        P2PictureBox.Visible = False
        P2Section.Visible = False

        P4CheckBox.Visible = False
        P4desLabel.Visible = False
        P4timeLabel.Visible = False
        P4roomLabel.Visible = False
        P4unitLabel.Visible = False
        P4PictureBox.Visible = False
        P4Section.Visible = False

        PSY209CB.Visible = False
        P209Desc.Visible = False
        P209Time.Visible = False
        P209Room.Visible = False
        P209Unit.Visible = False
        P209Status.Visible = False
        P9Section.Visible = False

        searchTextBox.Select()


        Me.doneButton.Enabled = False
        Me.SwapButton.Enabled = False
        Me.ViewInfoButton.Enabled = False
    End Sub

    Public Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MCheckBox.CheckedChanged
        courseCode = MCheckBox.Text
        courseName = MdesLabel.Text

    End Sub

    Public Sub M2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles M2Checkbox.CheckedChanged
        courseCode = M2Checkbox.Text
        courseName = M2DesLabel.Text

    End Sub

    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click, SwapButton.Click
        course.CourseCode.Text = courseCode
        If course.CourseCode.Text = "PSY209" Then
            MessageBox.Show("You cannot enroll into this course because you did not complete prerequisite: PSY124", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            course.CourseName.Text = courseName
            course.changeState(CourseObject.State.enrolled)
            If course.CourseCode.Text = "MTH110" Then
                course.Course_Description = "This course covers the fundamentals of discrete mathematics with a focus on proof methods. Topics include: propositional and predicate logic, notation for modern algebra, naive set theory, relations, functions and proof techniques."
            ElseIf course.CourseCode.Text = "PSY202" Then
                course.Course_Description = "This course continues the introduction to psychology from PSY 102, with a focus on applying psychological principles in different contexts. The course surveys some core areas of psychology, including personality, development over the life span, behaviour in a social context, and psychological disorders."
            ElseIf course.CourseCode.Text = "PSY124" Then
                course.Course_Description = "This course examines the influence of social factors on the behaviour of the individual. Topics include affiliation, aggression, prejudice, social cognition, the development and measurement of attitudes, persuasion, socialization, conformity and group behaviour. These topics are explored from a North American and cross-cultural perspective."
            End If
        End If
        Me.Close()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If searchTextBox.Text.ToUpper = "MTH110" Or searchTextBox.Text.ToUpper = "MTH 110" Or searchTextBox.Text.ToUpper = "MTH" Then
            MCheckBox.Visible = True
            MdesLabel.Visible = True
            MtimeLabel.Visible = True
            MroomLabel.Visible = True
            MunitLabel.Visible = True
            MPictureBox.Visible = True
            MSection.Visible = True

            M2Checkbox.Visible = True
            M2DesLabel.Visible = True
            M2TimeLabel.Visible = True
            M2RoomLabel.Visible = True
            M2UnitLabel.Visible = True
            M2PictureBox.Visible = True
            M2Section.Visible = True

        ElseIf searchTextBox.Text.ToUpper = "PSY202" Or searchTextBox.Text.ToUpper = "PSY 202" Then
            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
            P2Section.Visible = True
        ElseIf searchTextBox.Text.ToUpper = "PSY214" Or searchTextBox.Text.ToUpper = "PSY 214" Then
            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True
            P4Section.Visible = True
        ElseIf searchTextBox.Text.ToUpper = "PSY" Then

            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
            P2Section.Visible = True

            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True
            P4Section.Visible = True

            PSY209CB.Visible = True
            P209Desc.Visible = True
            P209Time.Visible = True
            P209Room.Visible = True
            P209Unit.Visible = True
            P209Status.Visible = True
            P9Section.Visible = True
        Else
            MCheckBox.Visible = True
            MdesLabel.Visible = True
            MtimeLabel.Visible = True
            MroomLabel.Visible = True
            MunitLabel.Visible = True
            MPictureBox.Visible = True
            MSection.Visible = True

            M2Checkbox.Visible = True
            M2DesLabel.Visible = True
            M2TimeLabel.Visible = True
            M2RoomLabel.Visible = True
            M2UnitLabel.Visible = True
            M2PictureBox.Visible = True
            M2Section.Visible = True

            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
            P2Section.Visible = True

            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True
            P4Section.Visible = True

            'P2CheckBox.Visible = True
            'P2desLabel.Visible = True
            'P2timeLabel.Visible = True
            'P2roomLabel.Visible = True
            'P2unitLabel.Visible = True
            'P2PictureBox.Visible = True
            'P9Section.Visible = True

            'P4CheckBox.Visible = True
            'P4desLabel.Visible = True
            'P4timeLabel.Visible = True
            'P4roomLabel.Visible = True
            'P4unitLabel.Visible = True
            'P4PictureBox.Visible = True

            PSY209CB.Visible = True
            P209Desc.Visible = True
            P209Time.Visible = True
            P209Room.Visible = True
            P209Unit.Visible = True
            P209Status.Visible = True
            P9Section.Visible = True


        End If
    End Sub

    Private Sub SelectCourse(sender As Object, e As EventArgs) Handles P2CheckBox.CheckedChanged, P4CheckBox.CheckedChanged, MCheckBox.CheckedChanged, M2Checkbox.CheckedChanged, PSY209CB.CheckedChanged
        Dim tempBox As RadioButton
        tempBox = CType(sender, RadioButton)
        courseCode = tempBox.Text
        'Enable Buttons
        If tempBox.Checked Then
            Me.doneButton.Enabled = True
            Me.SwapButton.Enabled = True
            Me.ViewInfoButton.Enabled = True
        End If
    End Sub
    Private Sub P2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles P2CheckBox.CheckedChanged
        courseCode = P2CheckBox.Text
        courseName = P2desLabel.Text

    End Sub

    Private Sub P4CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles P4CheckBox.CheckedChanged
        courseCode = P4CheckBox.Text
        courseName = P4desLabel.Text

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Public Sub connectCourse(newCourse As CourseObject)
        Me.course = newCourse
    End Sub

    Private Sub EnterClick(sender As Object, e As KeyEventArgs) Handles searchTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            searchButton_Click(sender, e)
        End If
    End Sub

    Private Sub PSY209CB_CheckedChanged(sender As Object, e As EventArgs) Handles PSY209CB.CheckedChanged
        courseCode = PSY209CB.Text
        courseName = P209Desc.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewInfoButton.Click
        course.CourseCode.Text = courseCode
        If course.CourseCode.Text = "MTH110" Then
            MessageBox.Show("This course covers the fundamentals of discrete mathematics with a focus on proof methods. Topics include: propositional and predicate logic, notation for modern algebra, naive set theory, relations, functions and proof techniques.", "Course Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf course.CourseCode.Text = "PSY202" Then
            MessageBox.Show("This course continues the introduction to psychology from PSY 102, with a focus on applying psychological principles in different contexts. The course surveys some core areas of psychology, including personality, development over the life span, behaviour in a social context, and psychological disorders.", "Course Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf course.CourseCode.Text = "PSY124" Then
            MessageBox.Show("This course examines the influence of social factors on the behaviour of the individual. Topics include affiliation, aggression, prejudice, social cognition, the development and measurement of attitudes, persuasion, socialization, conformity and group behaviour. These topics are explored from a North American and cross-cultural perspective.", "Course Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf course.CourseCode.Text = "PSY209" Then
            MessageBox.Show("This course applies psychology to the history and problems of work; personnel selection and individual differences; training and evaluation; the role of motivation; and the structure, process, and dynamics of organizations.", "Course Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class