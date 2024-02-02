Public Class Form1
    Private array() As Integer
    Private currentIndex As Integer = 0
    Private currentIteration As Integer = 0

    ' Perform one iteration of Selection Sort
    Private Sub SelectionSort()
        ' Perform only one iteration at a time
        If currentIteration < array.Length Then
            Dim minIndex As Integer = currentIteration

            ' Find the minimum index in the unsorted portion of the array
            For j As Integer = currentIteration + 1 To array.Length - 1
                DisplayMinIndexSearch(j)
                If array(j) < array(minIndex) Then
                    minIndex = j
                End If
            Next

            ' Swap the elements
            DisplaySwapping(minIndex)
            Dim temp As Integer = array(currentIteration)
            array(currentIteration) = array(minIndex)
            array(minIndex) = temp

            ' Update the labels
            If currentIteration = array.Length - 1 Then
                lblIter.Text = "Sorted Array:"
            Else
                lblIter.Text = "After Iteration " & (currentIteration + 1) & ":"
            End If

            ' Display the array after each iteration
            DisplayIteration()
        End If
    End Sub

    ' Handle the "Next Iteration" button click
    Private Sub btnNextIteration_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNextIteration.Click
        ' Call the SelectionSort method for the next iteration
        SelectionSort()
        currentIteration += 1

        ' Check if all iterations are completed
        If currentIteration > array.Length - 1 Then
            ' Disable the button or perform any other action when sorting is complete
            btnNextIteration.Text = "Array Sorted"
            btnNextIteration.Enabled = False
        End If
    End Sub

    ' Display the current state of the array in RichTextBox controls
    Private Sub DisplayIteration()
        ' Update RichTextBox controls for the current array state
        For i As Integer = 0 To array.Length - 1
            Dim richTextBox As RichTextBox = Me.Controls("RichTextBox" & (i + 11)) ' Assuming names like richTextBox1, richTextBox2, etc.

            ' Update the text
            richTextBox.Text = array(i).ToString()

            ' Set background color for elements
            If i < currentIteration + 1 Then
                richTextBox.BackColor = Color.LightGreen ' You can customize the color
            ElseIf i = currentIteration + 1 Then
                richTextBox.BackColor = Color.Red ' Highlighted (red) element
            Else
                richTextBox.BackColor = Color.LightYellow ' Elements to the right of the highlighted element
            End If
        Next

        ' Display the current iteration index
        If currentIteration = array.Length - 1 Then
            txtSwappedIndices.Text &= "Array is Sorted." & vbCrLf
        Else
            txtSwappedIndices.Text &= "Current Index: " & array(currentIteration + 1) & " (" & currentIteration + 1 & ") " & vbCrLf
        End If
    End Sub

    ' Highlight the current search for the minimum index
    Private Sub DisplayMinIndexSearch(ByVal j As Integer)
        Dim richTextBox As RichTextBox = Me.Controls("RichTextBox" & (j + 11))
        richTextBox.BackColor = Color.Orange
        Application.DoEvents() ' Allow the UI to process messages and update controls
        Threading.Thread.Sleep(500) ' Introduce a delay for visualization
        richTextBox.BackColor = Color.LightYellow
    End Sub

    ' Highlight the swapping of elements
    Private Sub DisplaySwapping(ByVal minIndex As Integer)
        Dim richTextBox As RichTextBox = Me.Controls("RichTextBox" & (minIndex + 11))
        richTextBox.BackColor = Color.OrangeRed
        Application.DoEvents() ' Allow the UI to process messages and update controls
        Threading.Thread.Sleep(1000) ' Introduce a delay for visualization
        richTextBox.BackColor = Color.White

        ' Display the indices of the swapped elements
        txtSwappedIndices.Text = ""
        If array(currentIteration) = array(minIndex) Then
            txtSwappedIndices.Text &= "Since " & array(minIndex) & " is minimum in unsorted part, No Swapping." & vbCrLf
        Else
            txtSwappedIndices.Text &= "Swapping the elements: " & array(currentIteration) & " (" & currentIteration & ") and " & array(minIndex) & " (" & minIndex & ") " & vbCrLf
        End If
    End Sub

    ' Initialize the array size and start the sorting process
    Private Sub Strt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Strt.Click
        Dim n As Integer
        Dim validSizeInput As Boolean = False

        ' Input array size with validation
        Do
            If Integer.TryParse(inptSz.Text, n) AndAlso n > 0 AndAlso n <= 10 Then
                validSizeInput = True
            Else
                Dim result As DialogResult = MessageBox.Show("Invalid array size. Please enter a valid positive integer between 1 and 10.", "Invalid Input", MessageBoxButtons.OK)
                If result = DialogResult.OK Then
                    ' Clear the invalid input and request user to re-enter
                    inptSz.Text = ""
                    inptSz.Focus()
                    ' User clicked Cancel, exit the method
                    Exit Sub
                End If
            End If
        Loop While Not validSizeInput

        ' Disable further input for array size
        inptSz.ReadOnly = True
        btnRestart.Visible = True
        ReDim array(n - 1)

        ' Configure existing Label and TextBox controls
        lblElement.Text = "Element 1:"
        txtElement.Text = "" ' Clear previous text

        ' Make controls visible
        txtElement.Visible = True
        lblElement.Visible = True
        Strt.Visible = False
        inpArr.Visible = False
        btnAddNext.Visible = True

        ' Focus on the TextBox for user input
        txtElement.Focus()

        ' Add event handler for KeyDown to handle Enter key press
        AddHandler txtElement.KeyDown, Sub(senderTextBox, eKeyDown)
                                           If eKeyDown.KeyCode = Keys.Enter Then
                                               btnAddNext.PerformClick()
                                           End If
                                       End Sub
    End Sub

    ' Handle the "Add Next" button click
    Private Sub btnAddNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddNext.Click
        ' Validate the input before updating the array
        Dim element As Integer
        If Integer.TryParse(txtElement.Text, element) AndAlso element >= -99 AndAlso element <= 100 Then
            array(currentIndex) = element

            ' Create and configure RichTextBox in a square-shaped, light green container
            Dim richTextBox As RichTextBox = Me.Controls("RichTextBox" & (currentIndex + 1))

            ' Set the visibility of the indexed RichTextBox and inpArr to True
            inpArr.Visible = True
            richTextBox.Visible = True

            ' Update the text of the RichTextBox
            richTextBox.Text = array(currentIndex).ToString()

            If currentIndex < array.Length - 1 Then
                ' Increase the index for the next element
                currentIndex += 1

                ' Update the Label and TextBox for the next element
                lblElement.Text = "Element " & (currentIndex + 1) & ":"
                txtElement.Text = ""

                ' Focus on the TextBox for user input
                txtElement.Focus()
            Else
                ' If all elements are entered, hide the "Add Next" button
                btnAddNext.Visible = False
                lblElement.Visible = False
                txtElement.Visible = False
                btnUnsortedDisp.Visible = True
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a number between -99 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Clear the invalid input and request the user to re-enter
            txtElement.Text = ""
            txtElement.Focus()
        End If
    End Sub

    ' Display the unsorted array state
    Private Sub btnUnsortedDisp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnsortedDisp.Click
        lblIter.Visible = True
        ' Update RichTextBox controls for the current array state
        For i As Integer = 0 To array.Length - 1
            Dim richTextBox As RichTextBox = Me.Controls("RichTextBox" & (i + 11)) ' Assuming names like richTextBox1, richTextBox2, etc.

            ' Update the text
            richTextBox.Text = array(i).ToString()
            richTextBox.Visible = True

            ' Highlight the first element in red
            If i = 0 Then
                richTextBox.BackColor = Color.Red
            Else
                richTextBox.BackColor = Color.LightYellow
            End If
        Next

        ' Show the "Next Iteration" button and the text box for swapped indices
        btnUnsortedDisp.Visible = False
        btnNextIteration.Visible = True
        txtSwappedIndices.Visible = True
        txtSwappedIndices.Text &= "Current Index: " & array(0) & " (1) " & vbCrLf
    End Sub

    ' Handle the "Restart" button click
    Private Sub btnRestart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestart.Click
        ' Display a warning message before restarting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to restart the application?", "Restart Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Restart the application
            Application.Restart()
        End If
    End Sub
End Class