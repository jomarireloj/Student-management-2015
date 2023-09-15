Imports System.Data.OleDb
Public Class k11
    Dim connection As OleDbConnection
    Dim mydb, mystr As String

    Private Sub K11BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.K11BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.STUDENTS1DataSet)

    End Sub

    Private Sub k11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.Recent_StudentsK12' table. You can move, or remove it, as needed.
        Me.Recent_StudentsK12TableAdapter.Fill(Me.STUDENTS1DataSet.Recent_StudentsK12)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K12Summer' table. You can move, or remove it, as needed.
        Me.K12SummerTableAdapter.Fill(Me.STUDENTS1DataSet.K12Summer)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K12' table. You can move, or remove it, as needed.
        Me.K12TableAdapter.Fill(Me.STUDENTS1DataSet.K12)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.Recent_StudentsK11' table. You can move, or remove it, as needed.
        Me.Recent_StudentsK11TableAdapter.Fill(Me.STUDENTS1DataSet.Recent_StudentsK11)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K11Summer' table. You can move, or remove it, as needed.
        Me.K11SummerTableAdapter.Fill(Me.STUDENTS1DataSet.K11Summer)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K11' table. You can move, or remove it, as needed.
        Me.K11TableAdapter.Fill(Me.STUDENTS1DataSet.K11)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.Recent_StudentsK11' table. You can move, or remove it, as needed.
        Me.Recent_StudentsK11TableAdapter.Fill(Me.STUDENTS1DataSet.Recent_StudentsK11)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K11Summer' table. You can move, or remove it, as needed.
        Me.K11SummerTableAdapter.Fill(Me.STUDENTS1DataSet.K11Summer)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K11' table. You can move, or remove it, as needed.
        Me.K11TableAdapter.Fill(Me.STUDENTS1DataSet.K11)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.Recent_StudentsK11' table. You can move, or remove it, as needed.
        Me.Recent_StudentsK11TableAdapter.Fill(Me.STUDENTS1DataSet.Recent_StudentsK11)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K11Summer' table. You can move, or remove it, as needed.
        Me.K11SummerTableAdapter.Fill(Me.STUDENTS1DataSet.K11Summer)
        'TODO: This line of code loads data into the 'STUDENTS1DataSet.K11' table. You can move, or remove it, as needed.
        Me.K11TableAdapter.Fill(Me.STUDENTS1DataSet.K11)

    End Sub
  
   

    Private Sub K11BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.K11BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.STUDENTS1DataSet)

    End Sub

    Private Sub K11BindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.K11BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.STUDENTS1DataSet)

    End Sub



    Private Sub AscButton9_Click(sender As Object, e As EventArgs) Handles AscButton9.Click
        K12BindingSource.AddNew()
    End Sub

    Private Sub AscButton12_Click(sender As Object, e As EventArgs) Handles AscButton12.Click
        K12SummerBindingSource.AddNew()
    End Sub

    Private Sub AscButton8_Click(sender As Object, e As EventArgs) Handles AscButton8.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()


        mydb = "INSERT INTO K12 (StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, Elective) values ('" & StudentIDTextBox2.Text & "', '" & FirstNameTextBox2.Text & "', '" & MiddleNameTextBox2.Text & "', '" & LastNameTextBox2.Text & "', '" & SectionTextBox2.Text & "','" & BirthDateDateTimePicker2.Text & "', '" & GuardianTextBox2.Text & "', '" & ContactTextBox2.Text & "', '" & AddressTextBox2.Text & "', '" & ElectivesTextBox2.Text & "', '" & EnglishTextBox2.Text & "','" & MathTextBox2.Text & "', '" & FilipinoTextBox2.Text & "', '" & ScienceTextBox2.Text & "', '" & PETextBox2.Text & "','" & ElectiveTextBox2.Text & "')"

        Dim run = New OleDb.OleDbCommand


        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Added", MsgBoxStyle.Information, "Success")




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub AscButton11_Click(sender As Object, e As EventArgs) Handles AscButton11.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()


        mydb = "INSERT INTO K12Summer (StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, Elective) values ('" & StudentIDTextBox3.Text & "', '" & FirstNameTextBox3.Text & "', '" & MiddleNameTextBox3.Text & "', '" & LastNameTextBox3.Text & "', '" & SectionTextBox3.Text & "','" & BirthDateDateTimePicker3.Text & "', '" & GuardianTextBox3.Text & "', '" & ContactTextBox3.Text & "', '" & AddressTextBox3.Text & "', '" & ElectivesTextBox2.Text & "', '" & EnglishTextBox3.Text & "','" & MathTextBox3.Text & "', '" & FilipinoTextBox3.Text & "', '" & ScienceTextBox3.Text & "', '" & PETextBox3.Text & "','" & ElectiveTextBox3.Text & "')"

        Dim run = New OleDb.OleDbCommand

        Try
            run = New OleDbCommand(mydb, connection)
            run.ExecuteNonQuery()
            MsgBox("Student Added", MsgBoxStyle.Information, "Success")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub AscButton7_Click(sender As Object, e As EventArgs) Handles AscButton7.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        mydb = "DELETE * FROM K12 WHERE StudentID = ('" & TextBox3.Text & "')"

        Dim run = New OleDb.OleDbCommand
        RadioButton1.Checked = True


        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Information Deleted", MsgBoxStyle.Information, "Message")
            K12BindingSource.RemoveCurrent()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
        TextBox3.Clear()
    End Sub


    Private Sub AscButton10_Click(sender As Object, e As EventArgs) Handles AscButton10.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        mydb = "DELETE * FROM K12Summer WHERE StudentID = ('" & TextBox19.Text & "')"

        Dim run = New OleDb.OleDbCommand
        Tester1.Checked = True


        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Information Deleted", MsgBoxStyle.Information, "Message")
            K12SummerBindingSource.RemoveCurrent()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
        TextBox19.Clear()
    End Sub

  
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If ThirteenComboBox1.Text = "Student ID" Then
            Me.K12BindingSource.Filter = "StudentID like '%" & TextBox3.Text & "%' "


        End If
        If ThirteenComboBox1.Text = "First Name" Then
            Me.K12BindingSource.Filter = "FirstName like '%" & TextBox3.Text & "%' "

        End If
        If ThirteenComboBox1.Text = "Last Name" Then
            Me.K12BindingSource.Filter = "LastName like '%" & TextBox3.Text & "%' "

        End If
        If ThirteenComboBox1.Text = "Elective" Then
            Me.K12BindingSource.Filter = "Electives like '%" & TextBox3.Text & "%' "

        End If
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        If List2.Text = "Student ID" Then
            Me.K12SummerBindingSource.Filter = "StudentID like '%" & TextBox19.Text & "%' "


        End If
        If List2.Text = "First Name" Then
            Me.K12SummerBindingSource.Filter = "FirstName like '%" & TextBox19.Text & "%' "

        End If
        If List2.Text = "Last Name" Then
            Me.K12SummerBindingSource.Filter = "LastName like '%" & TextBox19.Text & "%' "

        End If
        If List2.Text = "Elective" Then
            Me.K12SummerBindingSource.Filter = "Electives like '%" & TextBox19.Text & "%' "

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If tester.Checked = True Then
            Dim connection As OleDbConnection
            Dim mydb, mystr As String

            mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
            connection = New OleDb.OleDbConnection(mystr)
            connection.Open()


            mydb = "INSERT INTO Recent_StudentsK12 (StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, Elective) values ('" & StudentIDTextBox2.Text & "', '" & FirstNameTextBox2.Text & "', '" & MiddleNameTextBox2.Text & "', '" & LastNameTextBox2.Text & "', '" & SectionTextBox2.Text & "','" & BirthDateDateTimePicker2.Text & "', '" & GuardianTextBox2.Text & "', '" & ContactTextBox2.Text & "', '" & AddressTextBox2.Text & "', '" & ElectivesTextBox2.Text & "', '" & EnglishTextBox2.Text & "','" & MathTextBox2.Text & "', '" & FilipinoTextBox2.Text & "', '" & ScienceTextBox2.Text & "', '" & PETextBox2.Text & "','" & ElectiveTextBox2.Text & "')"

            Dim run = New OleDb.OleDbCommand


            Try
                run = New OleDbCommand(mydb, connection)

                run.ExecuteNonQuery()
                MsgBox("Student Added", MsgBoxStyle.Information, "Success")




            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            tester.Checked = False
        End If
    End Sub

    Private Sub Tester1_CheckedChanged(sender As Object, e As EventArgs) Handles Tester1.CheckedChanged
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()


        mydb = "INSERT INTO Recent_StudentsK12 (StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, Elective) values ('" & StudentIDTextBox3.Text & "', '" & FirstNameTextBox3.Text & "', '" & MiddleNameTextBox3.Text & "', '" & LastNameTextBox3.Text & "', '" & SectionTextBox3.Text & "','" & BirthDateDateTimePicker3.Text & "', '" & GuardianTextBox3.Text & "', '" & ContactTextBox3.Text & "', '" & AddressTextBox3.Text & "', '" & ElectivesTextBox2.Text & "', '" & EnglishTextBox3.Text & "','" & MathTextBox3.Text & "', '" & FilipinoTextBox3.Text & "', '" & ScienceTextBox3.Text & "', '" & PETextBox3.Text & "','" & ElectiveTextBox3.Text & "')"

        Dim run = New OleDb.OleDbCommand

        Try
            run = New OleDbCommand(mydb, connection)
            run.ExecuteNonQuery()
            MsgBox("Student Added", MsgBoxStyle.Information, "Success")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub AscButton1_Click_1(sender As Object, e As EventArgs) Handles AscButton1.Click
        K11BindingSource.AddNew()
    End Sub

    Private Sub AscButton6_Click_1(sender As Object, e As EventArgs) Handles AscButton6.Click
        K11SummerBindingSource.AddNew()
    End Sub

    Private Sub AscButton2_Click_1(sender As Object, e As EventArgs) Handles AscButton2.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        mydb = "INSERT INTO K11 (StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, YDP , Elective) values ('" & StudentIDTextBox.Text & "', '" & FirstNameTextBox.Text & "', '" & MiddleNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & SectionTextBox.Text & "','" & BirthDateDateTimePicker.Text & "', '" & GuardianTextBox.Text & "', '" & ContactTextBox.Text & "', '" & AddressTextBox.Text & "', '" & ElectivesTextBox.Text & "', '" & EnglishTextBox.Text & "','" & MathTextBox.Text & "', '" & FilipinoTextBox.Text & "', '" & ScienceTextBox.Text & "', '" & PETextBox.Text & "', '" & YDPTextBox.Text & "','" & ElectiveTextBox.Text & "')"

        Dim run = New OleDb.OleDbCommand


        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Added", MsgBoxStyle.Information, "Success")




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub AscButton5_Click(sender As Object, e As EventArgs) Handles AscButton5.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        mydb = "INSERT INTO K11Summer (StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, YDP , Elective) values ('" & StudentIDTextBox1.Text & "', '" & FirstNameTextBox1.Text & "', '" & MiddleNameTextBox1.Text & "', '" & LastNameTextBox1.Text & "', '" & SectionTextBox1.Text & "','" & BirthDateDateTimePicker1.Text & "', '" & GuardianTextBox1.Text & "', '" & ContactTextBox1.Text & "', '" & AddressTextBox1.Text & "', '" & ElectivesTextBox1.Text & "', '" & EnglishTextBox1.Text & "','" & MathTextBox1.Text & "', '" & FilipinoTextBox1.Text & "', '" & ScienceTextBox1.Text & "', '" & PETextBox1.Text & "', '" & YDPTextBox1.Text & "','" & ElectiveTextBox1.Text & "')"

        Dim run = New OleDb.OleDbCommand


        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Added", MsgBoxStyle.Information, "Success")




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub AscButton4_Click_1(sender As Object, e As EventArgs) Handles AscButton4.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        mydb = "DELETE * FROM K11Summer WHERE StudentID = ('" & TextBox2.Text & "')"

        Dim run = New OleDb.OleDbCommand


        Tester2.Checked = True
        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Information Deleted", MsgBoxStyle.Information, "Message")
            K11SummerBindingSource.RemoveCurrent()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub AscButton3_Click(sender As Object, e As EventArgs) Handles AscButton3.Click
        Dim connection As OleDbConnection
        Dim mydb, mystr As String

        mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
        connection = New OleDb.OleDbConnection(mystr)
        connection.Open()

        mydb = "DELETE * FROM K11 WHERE StudentID = ('" & TextBox1.Text & "')"

        Dim run = New OleDb.OleDbCommand

        tester.Checked = True
        Try
            run = New OleDbCommand(mydb, connection)

            run.ExecuteNonQuery()
            MsgBox("Student Information Deleted", MsgBoxStyle.Information, "Message")
            K11BindingSource.RemoveCurrent()




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If list.Text = "Student ID" Then
            Me.K11BindingSource.Filter = "StudentID like '%" & TextBox1.Text & "%' "

        End If
        If list.Text = "First Name" Then
            Me.K11BindingSource.Filter = "FirstName like '%" & TextBox1.Text & "%' "

        End If
        If list.Text = "Last Name" Then
            Me.K11BindingSource.Filter = "LastName like '%" & TextBox1.Text & "%' "

        End If
        If list.Text = "Elective" Then
            Me.K11BindingSource.Filter = "Electives like '%" & TextBox1.Text & "%' "
        End If
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If List1.Text = "Student ID" Then
            Me.K11SummerBindingSource.Filter = "StudentID like '%" & TextBox2.Text & "%' "

        End If
        If List1.Text = "First Name" Then
            Me.K11SummerBindingSource.Filter = "FirstName like '%" & TextBox2.Text & "%' "

        End If
        If List1.Text = "Last Name" Then
            Me.K11SummerBindingSource.Filter = "LastName like '%" & TextBox2.Text & "%' "

        End If
        If List1.Text = "Elective" Then
            Me.K11SummerBindingSource.Filter = "Electives like '%" & TextBox2.Text & "%' "
        End If
    End Sub

    Private Sub tester_CheckedChanged_1(sender As Object, e As EventArgs) Handles tester.CheckedChanged
        If tester.Checked = True Then
            Dim connection As OleDbConnection
            Dim mydb, mystr As String

            mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
            connection = New OleDb.OleDbConnection(mystr)
            connection.Open()

            mydb = "INSERT INTO Recent_StudentsK11(StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, YDP , Elective) values ('" & StudentIDTextBox.Text & "', '" & FirstNameTextBox.Text & "', '" & MiddleNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & SectionTextBox.Text & "','" & BirthDateDateTimePicker.Text & "', '" & GuardianTextBox.Text & "', '" & ContactTextBox.Text & "', '" & AddressTextBox.Text & "', '" & ElectivesTextBox.Text & "', '" & EnglishTextBox.Text & "','" & MathTextBox.Text & "', '" & FilipinoTextBox.Text & "', '" & ScienceTextBox.Text & "', '" & PETextBox.Text & "', '" & YDPTextBox.Text & "','" & ElectiveTextBox.Text & "')"

            Dim run = New OleDb.OleDbCommand


            Try
                run = New OleDbCommand(mydb, connection)

                run.ExecuteNonQuery()




            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            tester.Checked = False
        End If
    End Sub

    Private Sub Tester2_CheckedChanged(sender As Object, e As EventArgs) Handles Tester2.CheckedChanged
        If Tester2.Checked = True Then
            Dim connection As OleDbConnection
            Dim mydb, mystr As String

            mystr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jmrel\Desktop\Team 4 (Student Management)\Team 4 (Student Management)\STUDENTS1.accdb")
            connection = New OleDb.OleDbConnection(mystr)
            connection.Open()

            mydb = "INSERT INTO Recent_StudentsK11(StudentID, FirstName , MiddleName , LastName , [Section], BirthDate ,Guardian , Contact, Address , Electives,English , Math , Filipino , Science , PE, YDP , Elective) values ('" & StudentIDTextBox1.Text & "', '" & FirstNameTextBox1.Text & "', '" & MiddleNameTextBox1.Text & "', '" & LastNameTextBox1.Text & "', '" & SectionTextBox1.Text & "','" & BirthDateDateTimePicker1.Text & "', '" & GuardianTextBox1.Text & "', '" & ContactTextBox1.Text & "', '" & AddressTextBox1.Text & "', '" & ElectivesTextBox1.Text & "', '" & EnglishTextBox1.Text & "','" & MathTextBox1.Text & "', '" & FilipinoTextBox1.Text & "', '" & ScienceTextBox1.Text & "', '" & PETextBox1.Text & "', '" & YDPTextBox1.Text & "','" & ElectiveTextBox1.Text & "')"

            Dim run = New OleDb.OleDbCommand


            Try
                run = New OleDbCommand(mydb, connection)
                run.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            End Try
            Tester2.Checked = False
        End If
    End Sub

    
   
    Private Sub AscButton13_Click(sender As Object, e As EventArgs) Handles AscButton13.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class