Public Class Enrollment
    Dim Year2InitLoc As Point
    Dim break = 5
    Dim Year1Opened As Boolean = False
    Dim Year2Opened As Boolean = False
    Dim Year3Opened As Boolean = False
    Dim Year4Opened As Boolean = False

    Public psy_minor As PsyCourses
    Private minorPage As Minors
    Private searchWindow As CourseSearch

    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadFirstYear()
        LoadSecondYear()
        LoadThirdYear()
        Year2InitLoc = Y2BigPanel.Location
        closeYear3()
        closeYear4()
    End Sub

    Sub LoadFirstYear()

        MTH110CO.changeState(CourseObject.State.failed)
        MTH207CO.changeState(CourseObject.State.passed)
        CPS109CO.changeState(CourseObject.State.passed)
        CPS209CO.changeState(CourseObject.State.passed)
        CPS213CO.changeState(CourseObject.State.passed)
        CPS310CO.changeState(CourseObject.State.passed)
        CPS412CO.changeState(CourseObject.State.passed)
        LL1CO.changeState(CourseObject.State.passed)
        LL2CO.changeState(CourseObject.State.passed)
        PCS110CO.changeState(CourseObject.State.passed)

        MTH207CO.Course_Grade = 3.27
        CPS109CO.Course_Grade = 3.0
        CPS209CO.Course_Grade = 2.67
        CPS213CO.Course_Grade = 3.67
        CPS310CO.Course_Grade = 3.27
        CPS412CO.Course_Grade = 3.0
        PCS110CO.Course_Grade = 3.27
        LL1CO.Course_Grade = 2.27
        LL2CO.Course_Grade = 3.33
        MTH110CO.Course_Grade = 1.27

        MTH110CO.Course_Description = "This course covers the fundamentals of discrete mathematics with a focus on proof methods. Topics include: propositional and predicate logic, notation for modern algebra, naive set theory, relations, functions and proof techniques."
        MTH207CO.Course_Description = "Calculus of functions of one variable and related numerical topics. Derivatives of algebraic, trigonometric and exponential functions. Differentiation techniques and applications of derivatives. Techniques of integration, numerical integration."
        CPS109CO.Course_Description = "An introductory programming course designed to introduce fundamental Computer Science concepts such as abstraction, modelling and algorithm design. Emphasis is placed on producing correct software. This course uses Java as its programming language."
        CPS209CO.Course_Description = "A continuation of CPS 109. Emphasis is placed on code structure, algorithm development, and Object Oriented design principles."
        CPS213CO.Course_Description = "This course introduces the students to the principles and fundamentals of digital system design. Topics covered include: Binary numbers, base conversions, signed numbers, Boolean algebra, logic gates, K-map method, combinational circuits, decoders/encoders, multiplexers, sequential circuits, flip-flops, state diagram, registers, counters and addressing techniques."
        CPS310CO.Course_Description = "A continuation of CPS 213. Memory; CPU architecture and instruction set; the instruction processing sequence; generic assembler level programming illustrated for specific CPUs; I/O essentials including interrupts and DMA; characteristics of major peripherals interfaces; RISC and CISC architectures compared; parallel processing. The laboratory requires using a specific assembler/editor for the creation of programs illustrating some of the principles discussed in lectures."
        CPS412CO.Course_Description = "This course will cover some of fundamental social, legal, and ethical issues inherent in the discipline of computing. Topics include social context, analytical tools, professional ethics, intellectual property, privacy and civil liberties, professional communication and sustainability."
        LL1CO.Course_Description = "This course introduces students to psychology by exploring several viewpoints within the discipline, such as the biological, behaviourist/learning, cognitive, and psychodynamic perspectives. The emphasis is on examining the ways in which these perspectives have influenced our understanding of how people act, think, and feel, and the contributions that each has made to psychology as a discipline."
        LL2CO.Course_Description = "This course involves an examination and critique of psychological theory and research related to gender. Broad topics to be addressed include: gender development, stereotyping and gender roles, sexism, and the impact of gender on intimate relationships, achievement, and psychological and physical health. A key goal of the course is to foster an appreciation for how gender may be relevant to students' working and personal lives."
        PCS110CO.Course_Description = "Units and vectors. Motion: linear, projectile, circular and oscillatory motion. Newton's laws: Force, mass and acceleration; work, energy and power; linear and angular momentum. Electrostatics: Electric force and field; potential and potential energy; capacitance. Electric current and DC circuits. Magnetic field and force: magnetic force on currents and charges; Hall effect; torque on current loops; Waves: classification of waves; energy transfer; light and electromagnetic waves; diffraction and interference. MAPLE used for simulation/visualization of physical phenomena and problem solving."

    End Sub

    Sub LoadSecondYear()
        MTH108CO.changeState(CourseObject.State.enrolled)
        CMN300CO.changeState(CourseObject.State.enrolled)
        CPS305CO.changeState(CourseObject.State.enrolled)
        CPS393CO.changeState(CourseObject.State.enrolled)
        CPS420CO.changeState(CourseObject.State.closed)
        CPS406CO.changeState(CourseObject.State.enrolled)
        CPS506CO.changeState(CourseObject.State.enrolled)
        CPS590CO.changeState(CourseObject.State.closed)
        OE1CO.changeState(CourseObject.State.open)
        OE2CO.changeState(CourseObject.State.open)

        MTH108CO.Course_Description = "Systems of linear equations, matrices determinants, vectors, geometry, linear transformations, linear independence, basis, dimension, eigenvalues and eigenvectors, complex numbers, applications."
        CMN300CO.Course_Description = "In this workshop course, students learn to present technical information to audiences with a range of technical knowledge. The course teaches students various forms and content strategies relevant to the computer industry so they can communicate clearly and persuasively in online and traditional media. Students analyze and respond to professional situations involving documentation plans, style guides, usability testing and project planning."
        CPS305CO.Course_Description = "Introduction to data structures and algorithms. Topics may include ADTs, restricted lists (stacks and queries), generalized lists, trees, searching, sorting, hashing, graphs, algorithm design, complexity analysis, recursion."
        CPS393CO.Course_Description = "The course covers various aspects of the C language such as: Arrays, strings, pointers, structures, etc. The second part of the course introduces UNIX operating systems. Topics include: I/O, redirection, processes, shell scripts, etc."
        CPS420CO.Course_Description = "Introduction to discrete structures and probability as they apply to design and analysis. Review of proof techniques: induction and recursion. Graphs and trees, and their applications in computing. Finite automata and computability. Counting: arithmetic and geometric progressions, permutations and combinations, modular arithmetic. Probability."
        CPS406CO.Course_Description = "This course introduces the study of Object-Oriented software engineering. Topics include software project management, requirements gathering, requirements analysis, modeling, design, implementation and testing. UML diagrams and design patterns are also discussed. A major portion of the course is a team project, taking a system from the initial requirements to the final implementation. (2 hr Lab every other week)."
        CPS506CO.Course_Description = "A survey of major programming paradigms, with emphasis on the functional paradigm.  Discussion of data typing, program decomposition, scoping rules, control structures parameter passing. Programming languages will likely include commercially important functional languages such as Haskell, Clojure and Erlang, with examples of others as time permits."
        CPS590CO.Course_Description = "Introduction to O/S (system calls, interrupts, synchronous and asynchronous traps, O/S structure), using processes (process communication and synchronization), primitive communications (signals and signal management calls), pipes, messages, semaphores, shared memory, memory management, file systems, and (time permitting) remote procedure calls."
    End Sub

    Sub LoadThirdYear()
        Y3S1PRCO.changeState(CourseObject.State.open)
        Y3S2PR1CO.changeState(CourseObject.State.open)
        Y3S2PR2CO.changeState(CourseObject.State.open)
        CPS616CO.changeState(CourseObject.State.closed)
        CPS633CO.changeState(CourseObject.State.closed)
        CPS706CO.changeState(CourseObject.State.closed)
        CPS721CO.changeState(CourseObject.State.closed)
        CPS510CO.changeState(CourseObject.State.closed)
        UL1CO.changeState(CourseObject.State.open)
        LL3CO.changeState(CourseObject.State.open)

        CPS616CO.Course_Description = "Order notations, the greedy method, job scheduling, correctness, exchange argument, divide and conquer techniques, recurrence equations, the master method, integer multiplications, dynamic programming, matrix chain-product, the knapsack problem, graph algorithms (minimum spanning trees, single-source shortest paths, all-pairs shortest paths), text processing and pattern matching techniques, approximation algorithms."
        CPS633CO.Course_Description = "History and examples of computer crime. Security policies and mechanisms. Access control models. Implementation and usability issues. Physical security. Authentication technologies. Operating system security. Encryption algorithms and protocols. External and internal firewalls. Software flaws and malware. Ethical issues in computer security. Sample privacy noncompliance litigation cases, Social implications of computing networked communication."
        CPS706CO.Course_Description = "Internet, the network edge, the network core, delay, loss and throughput, protocol layers. Application Layer: principles of network applications, web. Transport Layer -UDP, connection oriented transport TCP, TCP congestion control. Network layer -The internet protocol (IP): Forwarding and addressing in the Internet. Routing algorithms. The link layer and local area networks."
        CPS721CO.Course_Description = "This course provides introduction to several important AI problems and techniques, including knowledge representation and reasoning, constraints satisfaction, search, natural language understanding, planning, uncertainty, belief networks, learning."
        CPS510CO.Course_Description = "Advanced file management techniques involving fundamentals of database organization, design and management. Emphasis is given to Relational Database Management Systems including relational algebra, normal Forms, physical Database Structures and their implementation, and Relational Database Languages. Other types of Database Managers are also discussed such as Hierarchical, Network and Inverted Files."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Year1OpenButton.Click
        openYear1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Year2OpenButton.Click
        openYear2()
    End Sub

    Private Sub Year3OpenButton_Click(sender As Object, e As EventArgs) Handles Year3OpenButton.Click
        openYear3()
    End Sub

    Private Sub Year4OpenButton_Click(sender As Object, e As EventArgs) Handles Year4OpenButton.Click
        openYear4()
    End Sub

    Private Sub CloseYear1Button_Click(sender As Object, e As EventArgs) Handles Year1CloseButton.Click
        closeYear1()
    End Sub

    Private Sub CloseYear2Button_Click(sender As Object, e As EventArgs) Handles Year2CloseButton.Click
        closeYear2()
    End Sub

    Private Sub Year3CloseButton_Click(sender As Object, e As EventArgs) Handles Year3CloseButton.Click
        closeYear3()
    End Sub

    Private Sub Year4CloseButton_Click(sender As Object, e As EventArgs) Handles Year4CloseButton.Click
        closeYear4()
    End Sub

    Sub openYear1()
        Year1Opened = True
        Year1Panel.Visible = True
        Year1CloseButton.Visible = True
        Year1OpenButton.Visible = False
        Y2BigPanel.Location = Year2InitLoc
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y + Year1Panel.Height)
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y + Year1Panel.Height)
    End Sub

    Sub openYear2()
        Year2Opened = True
        Year2Panel.Visible = True
        Year2CloseButton.Visible = True
        Year2OpenButton.Visible = False
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y + Year2Panel.Height)
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y + Year2Panel.Height)
    End Sub

    Sub openYear3()
        Year3Opened = True
        Year3Panel.Visible = True
        Year3CloseButton.Visible = True
        Year3OpenButton.Visible = False
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y + Year3Panel.Height)
    End Sub

    Sub openYear4()
        Year4Opened = True
        Year4Panel.Visible = True
        Year4CloseButton.Visible = True
        Year4OpenButton.Visible = False
    End Sub

    Sub closeYear1()
        Year1Opened = False
        Year1Panel.Visible = False
        Year1OpenButton.Visible = True
        Year1CloseButton.Visible = False
        Y2BigPanel.Location = New Point(Y2BigPanel.Location.X, Year1Panel.Location.Y)
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y - Year1Panel.Height)
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y - Year1Panel.Height)
    End Sub

    Sub closeYear2()
        Year2Opened = False
        Year2Panel.Visible = False
        Year2CloseButton.Visible = False
        Year2OpenButton.Visible = True
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y - Year2Panel.Height)
        Year3BigPanel.BringToFront()
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y - Year2Panel.Height)
        Year4BigPanel.BringToFront()
    End Sub

    Sub closeYear3()
        Year3Opened = False
        Year3Panel.Visible = False
        Year3CloseButton.Visible = False
        Year3OpenButton.Visible = True
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y - Year3Panel.Height)
        Year4BigPanel.BringToFront()
    End Sub

    Sub closeYear4()
        Year4Opened = False
        Year4Panel.Visible = False
        Year4CloseButton.Visible = False
        Year4OpenButton.Visible = True
    End Sub

    Private Sub Year1Label_Click(sender As Object, e As EventArgs) Handles Year1Label.Click
        If Year1Opened Then
            closeYear1()
        Else openYear1()
        End If
    End Sub

    Private Sub Year2Label_Click(sender As Object, e As EventArgs) Handles Year2Label.Click
        If Year2Opened Then
            closeYear2()
        Else openYear2()
        End If
    End Sub

    Private Sub Year3Label_Click(sender As Object, e As EventArgs) Handles Year3Label.Click
        If Year3Opened Then
            closeYear3()
        Else openYear3()
        End If
    End Sub

    Private Sub Year4Label_Click(sender As Object, e As EventArgs) Handles Year4Label.Click
        If Year4Opened Then
            closeYear4()
        Else openYear4()
        End If
    End Sub

    Private Sub Y2S1AddButton_Click(sender As Object, e As EventArgs) Handles Y2S1AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.connectCourse(Y2S16thCO)
        searchWindow.Show()
        Y2S16thCO.Visible = True
        Y2S16thCO.CourseName.Text = searchWindow.course.CourseName.Text
        Y2S16thCO.changeState(CourseObject.State.enrolled)
        Y2S16thCO.Location = New Point(Y2S1AddButton.Location.X, MTH108CO.Location.Y)
        Y2S1AddButton.Visible = False
    End Sub

    Private Sub Y2S2AddButton_Click(sender As Object, e As EventArgs) Handles Y2S2AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.connectCourse(Y2S26thCO)
        searchWindow.Show()
        Y2S26thCO.Visible = True
        Y2S26thCO.CourseName.Text = searchWindow.course.CourseName.Text
        Y2S26thCO.changeState(CourseObject.State.enrolled)
        Y2S26thCO.Location = New Point(Y2S2AddButton.Location.X, OE2CO.Location.Y)
        Y2S2AddButton.Visible = False
    End Sub

    Private Sub MinorsButton_Click(sender As Object, e As EventArgs) Handles MinorsButton.Click
        minorPage = New Minors
        psy_minor = New PsyCourses
        minorPage.connectToEnroll(Me)

        psy_minor.connectToEnroll(Me)
        minorPage.Show()
    End Sub

    Public Sub connectToPSYMinor(page As PsyCourses)
        Me.psy_minor = page
    End Sub

    Public Sub connectToMinor(page As Minors)
        Me.minorPage = page
    End Sub
End Class