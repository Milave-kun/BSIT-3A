'Imports
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

'Form1
Public Class Form1
    Private connectionString As String = "Data Source=DESKTOP-808QF8L\SQLEXPRESS;Initial Catalog=studentInfo;Integrated Security=True"

    'BindData
    Private Sub BindData(dataGridView As DataGridView, tableName As String)
        Dim query As String = $"SELECT * FROM {tableName}"
        Using con As SqlConnection = New SqlConnection(connectionString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dataGridView.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    'Form 1 Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData(GunaDataGridView1, "firstYear")
        BindData(GunaDataGridView2, "secondYear")
        BindData(GunaDataGridView3, "thirdYear")
        BindData(GunaDataGridView4, "fourthYear")
        roundCorners(Me)
    End Sub

    'Exit Button
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Insert Button
    Private Sub btnInsert_Click_1(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim gradeLevel As String = cmbGradeLevel.Text
        Dim semester As String = txtSemester.Text
        Dim daate As String = txtDate.Text
        Dim LRN As String = txtLRN.Text
        Dim status As String = cmbStatus.Text
        Dim schoolYear As String = txtSchoolYear.Text
        Dim lastName As String = txtLastName.Text
        Dim firstName As String = txtFirstName.Text
        Dim middleName As String = txtMiddleName.Text
        Dim gender As String = txtGender.Text
        Dim dateBirth As String = txtDateBirth.Text
        Dim civilStatus As String = txtCivilStatus.Text
        Dim citizenship As String = txtCitizenship.Text
        Dim religion As String = txtReligion.Text
        Dim address As String = txtAddress.Text
        Dim ZIP As String = txtZIP.Text
        Dim contactNumber As String = txtContact.Text
        Dim email As String = txtEmail.Text
        Dim guardianName As String = txtGuardianName.Text
        Dim guardianContact As String = txtGuardianContact.Text
        Dim currentlastSchool As String = txtCurrentLastSchool.Text

        Dim tableName As String = cmbGradeLevel.SelectedItem.ToString()
        Select Case gradeLevel
            Case "First Year"
                tableName = "firstYear"
            Case "Second Year"
                tableName = "secondYear"
            Case "Third Year"
                tableName = "thirdYear"
            Case "Fourth Year"
                tableName = "fourthYear"
            Case Else
                MessageBox.Show("Invalid grade level")
                Return
        End Select

        ' Check if LRN textbox is empty
        If String.IsNullOrWhiteSpace(txtLRN.Text) Then
            MessageBox.Show("LRN cannot be empty. Please enter a valid LRN.", "Empty LRN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim isDuplicate As Boolean = CheckDuplicateLRN(LRN, tableName)
        If isDuplicate Then
            MessageBox.Show("LRN already exists in the database. Please enter a unique LRN.", "Duplicate LRN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim query As String = $"INSERT INTO {tableName} (gradeLevel, semester, date, LRN, status, schoolYear,
                        lastName, firstName, middleName, gender, dateBirth, civilStatus, citizenship, religion, 
                        address, ZIP, contactNumber, email, guardianName, guardianContact, currentlastSchool) 
                        VALUES (@gradeLevel, @semester, @date, @LRN, @status, @schoolYear, @lastName, @firstName,
                        @middleName, @gender, @dateBirth, @civilStatus, @citizenship, @religion, @address, @ZIP,
                        @contactNumber, @email, @guardianName, @guardianContact, @currentlastSchool)"

            Using con As SqlConnection = New SqlConnection(connectionString)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@gradeLevel", gradeLevel)
                    cmd.Parameters.AddWithValue("@semester", semester)
                    cmd.Parameters.AddWithValue("@date", daate)
                    cmd.Parameters.AddWithValue("@LRN", LRN)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@schoolYear", schoolYear)
                    cmd.Parameters.AddWithValue("@lastName", lastName)
                    cmd.Parameters.AddWithValue("@firstName", firstName)
                    cmd.Parameters.AddWithValue("@middleName", middleName)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@dateBirth", dateBirth)
                    cmd.Parameters.AddWithValue("@civilStatus", civilStatus)
                    cmd.Parameters.AddWithValue("@citizenship", citizenship)
                    cmd.Parameters.AddWithValue("@religion", religion)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@ZIP", ZIP)
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@guardianName", guardianName)
                    cmd.Parameters.AddWithValue("@guardianContact", guardianContact)
                    cmd.Parameters.AddWithValue("@currentlastSchool", currentlastSchool)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully added")

                    BindData(GunaDataGridView1, "firstYear")
                    BindData(GunaDataGridView2, "secondYear")
                    BindData(GunaDataGridView3, "thirdYear")
                    BindData(GunaDataGridView4, "fourthYear")

                    ClearTextFields()
                End Using
            End Using
        End If
    End Sub

    'Check Duplicate Function
    Private Function CheckDuplicateLRN(LRN As String, tableName As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE LRN = @LRN"

        Using con As SqlConnection = New SqlConnection(connectionString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@LRN", LRN)

                con.Open()
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                con.Close()

                ' If count is greater than 0, it means the LRN already exists
                Return count > 0
            End Using
        End Using
    End Function

    'Clear Field Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextFields()
    End Sub

    'Search Button
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        ' Get the student's LRN from a textbox
        Dim LRN As String = txtSearch.Text

        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            MessageBox.Show("Please Enter LRN Number", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Determine the selected grade level
        Dim tableName As String = cmbGradeLevel.SelectedItem.ToString()
        Select Case tableName
            Case "First Year"
                tableName = "firstYear"
            Case "Second Year"
                tableName = "secondYear"
            Case "Third Year"
                tableName = "thirdYear"
            Case "Fourth Year"
                tableName = "fourthYear"
            Case Else
                MessageBox.Show("Invalid grade level")
                Return
        End Select

        ' Create a SQL query to fetch data for the specified student
        Dim query As String = $"SELECT * FROM {tableName} WHERE LRN = @LRN"

        Using con As SqlConnection = New SqlConnection(connectionString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@LRN", LRN)

                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Populate the textboxes with data from the database
                        txtSemester.Text = reader("semester").ToString()
                        txtDate.Text = reader("date").ToString()
                        txtLRN.Text = reader("LRN").ToString()
                        cmbStatus.Text = reader("status").ToString()
                        txtSchoolYear.Text = reader("schoolYear").ToString()
                        txtLastName.Text = reader("lastName").ToString()
                        txtFirstName.Text = reader("firstName").ToString()
                        txtMiddleName.Text = reader("middleName").ToString()
                        txtGender.Text = reader("gender").ToString()
                        txtDateBirth.Text = reader("dateBirth").ToString()
                        txtCivilStatus.Text = reader("civilStatus").ToString()
                        txtCitizenship.Text = reader("citizenship").ToString()
                        txtReligion.Text = reader("religion").ToString()
                        txtAddress.Text = reader("address").ToString()
                        txtZIP.Text = reader("ZIP").ToString()
                        txtContact.Text = reader("contactNumber").ToString()
                        txtEmail.Text = reader("email").ToString()
                        txtGuardianName.Text = reader("guardianName").ToString()
                        txtGuardianContact.Text = reader("guardianContact").ToString()
                        txtCurrentLastSchool.Text = reader("currentlastSchool").ToString()

                    Else
                        MessageBox.Show("Student not found")
                    End If
                End Using
                con.Close()
            End Using
        End Using
    End Sub

    'Update Button
    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim gradeLevel As String = cmbGradeLevel.Text
        Dim semester As String = txtSemester.Text
        Dim daate As String = txtDate.Text
        Dim LRN As String = txtLRN.Text
        Dim status As String = cmbStatus.Text
        Dim schoolYear As String = txtSchoolYear.Text
        Dim lastName As String = txtLastName.Text
        Dim firstName As String = txtFirstName.Text
        Dim middleName As String = txtMiddleName.Text
        Dim gender As String = txtGender.Text
        Dim dateBirth As String = txtDateBirth.Text
        Dim civilStatus As String = txtCivilStatus.Text
        Dim citizenship As String = txtCitizenship.Text
        Dim religion As String = txtReligion.Text
        Dim address As String = txtAddress.Text
        Dim ZIP As String = txtZIP.Text
        Dim contactNumber As String = txtContact.Text
        Dim email As String = txtEmail.Text
        Dim guardianName As String = txtGuardianName.Text
        Dim guardianContact As String = txtGuardianContact.Text
        Dim currentlastSchool As String = txtCurrentLastSchool.Text

        Dim tableName As String = cmbGradeLevel.SelectedItem.ToString()
        Select Case gradeLevel
            Case "First Year"
                tableName = "firstYear"
            Case "Second Year"
                tableName = "secondYear"
            Case "Third Year"
                tableName = "thirdYear"
            Case "Fourth Year"
                tableName = "fourthYear"
            Case Else
                MessageBox.Show("Invalid grade level")
                Return
        End Select
        ' Check if LRN textbox is empty
        If String.IsNullOrWhiteSpace(txtLRN.Text) Then
            MessageBox.Show("LRN cannot be empty. Please enter a valid LRN.", "Empty LRN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Display a confirmation message box
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to update this student's data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmationResult = DialogResult.Yes Then

            ' Create a SQL query to update the data for the specified student
            Dim query As String = $"UPDATE {tableName} 
                          SET semester = @semester, date = @date, 
                          status = @status, schoolYear = @schoolYear, 
                          lastName = @lastName, firstName = @firstName, 
                          middleName = @middleName, gender = @gender, 
                          dateBirth = @dateBirth, civilStatus = @civilStatus, 
                          citizenship = @citizenship, religion = @religion, 
                          address = @address, ZIP = @ZIP, 
                          contactNumber = @contactNumber, email = @email, 
                          guardianName = @guardianName, guardianContact = @guardianContact, 
                          currentlastSchool = @currentlastSchool 
                          WHERE LRN = @LRN"

            Using con As SqlConnection = New SqlConnection(connectionString)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@semester", semester)
                    cmd.Parameters.AddWithValue("@date", daate)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@schoolYear", schoolYear)
                    cmd.Parameters.AddWithValue("@lastName", lastName)
                    cmd.Parameters.AddWithValue("@firstName", firstName)
                    cmd.Parameters.AddWithValue("@middleName", middleName)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@dateBirth", dateBirth)
                    cmd.Parameters.AddWithValue("@civilStatus", civilStatus)
                    cmd.Parameters.AddWithValue("@citizenship", citizenship)
                    cmd.Parameters.AddWithValue("@religion", religion)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@ZIP", ZIP)
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@guardianName", guardianName)
                    cmd.Parameters.AddWithValue("@guardianContact", guardianContact)
                    cmd.Parameters.AddWithValue("@currentlastSchool", currentlastSchool)
                    cmd.Parameters.AddWithValue("@LRN", LRN)

                    con.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    con.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Student data updated successfully.")
                        ' Optionally, clear the textboxes after updating.
                        BindData(GunaDataGridView1, "firstYear")
                        BindData(GunaDataGridView2, "secondYear")
                        BindData(GunaDataGridView3, "thirdYear")
                        BindData(GunaDataGridView4, "fourthYear")
                        ClearTextFields()
                    Else
                        MessageBox.Show("Student not found or no changes made.")
                    End If
                End Using
            End Using
        Else
            ' The user clicked "No," do nothing or provide feedback.
        End If
    End Sub

    'Delete Button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Get the student's LRN from a textbox
        Dim deleteLRN As String = txtSearch.Text

        ' Check if LRN textbox is empty
        If String.IsNullOrWhiteSpace(txtLRN.Text) Then
            MessageBox.Show("LRN cannot be empty. Please enter a valid LRN.", "Empty LRN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Determine the selected grade level
        Dim tableName As String = cmbGradeLevel.SelectedItem.ToString()
        Select Case tableName
            Case "First Year"
                tableName = "firstYear"
            Case "Second Year"
                tableName = "secondYear"
            Case "Third Year"
                tableName = "thirdYear"
            Case "Fourth Year"
                tableName = "fourthYear"
            Case Else
                MessageBox.Show("Invalid grade level")
                Return
        End Select

        ' Display a confirmation message box
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this student's data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmationResult = DialogResult.Yes Then
            ' Create a SQL query to delete the data for the specified student
            Dim query As String = $"DELETE FROM {tableName} WHERE LRN = @LRN"

            Using con As SqlConnection = New SqlConnection(connectionString)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@LRN", deleteLRN)

                    con.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    con.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Student data deleted successfully.")
                        ' Optionally, clear the textboxes after deleting.
                        BindData(GunaDataGridView1, "firstYear")
                        BindData(GunaDataGridView2, "secondYear")
                        BindData(GunaDataGridView3, "thirdYear")
                        BindData(GunaDataGridView4, "fourthYear")
                        ClearTextFields()
                    Else
                        MessageBox.Show("Student not found or no data deleted.")
                    End If
                End Using
            End Using
        Else
            ' The user clicked "No," do nothing or provide feedback.
        End If
    End Sub

    'Clear Field Function
    Private Sub ClearTextFields()
        txtSemester.Text = String.Empty
        txtDate.Text = String.Empty
        txtLRN.Text = String.Empty
        txtSchoolYear.Text = String.Empty
        txtLastName.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtMiddleName.Text = String.Empty
        txtGender.Text = String.Empty
        txtDateBirth.Text = String.Empty
        txtCivilStatus.Text = String.Empty
        txtCitizenship.Text = String.Empty
        txtReligion.Text = String.Empty
        txtAddress.Text = String.Empty
        txtZIP.Text = String.Empty
        txtContact.Text = String.Empty
        txtEmail.Text = String.Empty
        txtGuardianName.Text = String.Empty
        txtGuardianContact.Text = String.Empty
        txtCurrentLastSchool.Text = String.Empty
        txtSearch.Text = String.Empty
    End Sub

    'Form Round Corners
    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.White ' Set the background color to white

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        ' Top left corner
        DGP.AddArc(New Rectangle(0, 0, 16, 16), 180, 90)
        DGP.AddLine(8, 0, obj.Width - 8, 0)

        ' Top right corner
        DGP.AddArc(New Rectangle(obj.Width - 16, 0, 16, 16), -90, 90)
        DGP.AddLine(obj.Width, 8, obj.Width, obj.Height - 8)

        ' Bottom right corner
        DGP.AddArc(New Rectangle(obj.Width - 16, obj.Height - 16, 16, 16), 0, 90)
        DGP.AddLine(obj.Width - 8, obj.Height, 8, obj.Height)

        ' Bottom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 16, 16, 16), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

End Class