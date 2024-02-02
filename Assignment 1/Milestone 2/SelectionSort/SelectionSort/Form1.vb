Public Class Form1
    Private array() As Integer
    Private currentIndex As Integer = 0
    Private lblElement As New Label()
    Private txtElement As New TextBox()
    Private flowLayoutPanel As New FlowLayoutPanel()

    Private Sub SelectionSort()
        ' Implementation of Selection Sort algorithm
        For i As Integer = 0 To array.Length - 1
            Dim minIndex As Integer = i
            For j As Integer = i + 1 To array.Length - 1
                If array(j) < array(minIndex) Then
                    minIndex = j
                End If
            Next
            ' Swap the elements
            Dim temp As Integer = array(i)
            array(i) = array(minIndex)
            array(minIndex) = temp

            ' Update the form to display the array after each iteration
            UpdateFormAfterIteration(i)
        Next
    End Sub

    Private Sub UpdateFormAfterIteration(ByVal iter As Integer)
        ' Create and configure label for the iteration
        Dim lblIteration As New Label()
        lblIteration.Text = "At Iteration " & (iter + 1) & ":"
        lblIteration.Location = New Point(50, 350 + iter * 100) ' Adjust Y position
        Me.Controls.Add(lblIteration)

        ' Create and configure FlowLayoutPanel for the current array state
        Dim currentFlowLayoutPanel As New FlowLayoutPanel()
        currentFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight
        currentFlowLayoutPanel.WrapContents = False
        currentFlowLayoutPanel.Location = New Point(150, 350 + iter * 100) ' Adjust Y position
        currentFlowLayoutPanel.AutoSize = True
        Me.Controls.Add(currentFlowLayoutPanel)

        ' Create RichTextBox controls for the current array state
        For i As Integer = 0 To array.Length - 1
            Dim richTextBox As New RichTextBox()
            richTextBox.Text = array(i).ToString()
            richTextBox.Width = 50
            richTextBox.Height = 50
            richTextBox.Margin = New Padding(12)
            richTextBox.SelectionAlignment = HorizontalAlignment.Center

            ' Increase the text size
            Dim currentFont As Font = richTextBox.SelectionFont
            richTextBox.SelectionFont = New Font(currentFont.FontFamily, 30, FontStyle.Italic)

            ' Make the RichTextBox non-editable
            richTextBox.ReadOnly = True

            ' Set background color for elements to the left of the highlighted (red) element
            If i < iter Then
                richTextBox.BackColor = Color.LightBlue ' You can customize the color
            ElseIf i = iter Then
                richTextBox.BackColor = Color.Red ' Highlighted (red) element
            Else
                richTextBox.BackColor = Color.LightYellow ' Elements to the right of the highlighted element
            End If

            ' Add RichTextBox to the FlowLayoutPanel
            currentFlowLayoutPanel.Controls.Add(richTextBox)
        Next

        ' Increment the index for the next iteration
        currentIndex += 1
    End Sub



    Private Sub DisplaySortedArray()
        ' Sort the array using Selection Sort
        SelectionSort()

        ' Create and configure label for the sorted array
        Dim lblSortedArray As New Label()
        lblSortedArray.Text = "Sorted Array:"
        lblSortedArray.Location = New Point(50, 250)
        Me.Controls.Add(lblSortedArray)

        ' Create and configure FlowLayoutPanel for sorted array
        Dim sortedFlowLayoutPanel As New FlowLayoutPanel()
        sortedFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight
        sortedFlowLayoutPanel.WrapContents = False
        sortedFlowLayoutPanel.Location = New Point(150, 250)
        sortedFlowLayoutPanel.AutoSize = True
        Me.Controls.Add(sortedFlowLayoutPanel)

        ' Create RichTextBox controls for the sorted array
        For i As Integer = 0 To array.Length - 1
            Dim richTextBox As New RichTextBox()
            richTextBox.Text = array(i).ToString()
            richTextBox.BackColor = Color.LightBlue ' You can customize the color
            richTextBox.Width = 50
            richTextBox.Height = 50
            richTextBox.Margin = New Padding(12)
            richTextBox.SelectionAlignment = HorizontalAlignment.Center

            ' Increase the text size
            Dim currentFont As Font = richTextBox.SelectionFont
            richTextBox.SelectionFont = New Font(currentFont.FontFamily, 20, FontStyle.Italic)

            ' Make the RichTextBox non-editable
            richTextBox.ReadOnly = True

            ' Add RichTextBox to the FlowLayoutPanel
            sortedFlowLayoutPanel.Controls.Add(richTextBox)
        Next
    End Sub

    Private Sub Strt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Strt.Click
        Dim n As Integer
        Dim validSizeInput As Boolean = False

        ' Input array size with validation
        Do
            If Integer.TryParse(inptSz.Text, n) AndAlso n > 0 AndAlso n <= 15 Then
                validSizeInput = True
            Else
                Dim result As DialogResult = MessageBox.Show("Invalid array size. Please enter a valid positive integer between 1 and 15.", "Invalid Input", MessageBoxButtons.OK)
                If result = DialogResult.OK Then
                    ' Clear the invalid input and request user to re-enter
                    inptSz.Text = ""
                    inptSz.Focus()
                    ' User clicked Cancel, exit the method
                    Exit Sub
                End If
            End If
        Loop While Not validSizeInput

        ReDim array(n - 1)

        ' Create and add Label and TextBox controls
        lblElement.Text = "Element 1:"
        lblElement.Location = New Point(50, 100)
        Me.Controls.Add(lblElement)

        txtElement.Location = New Point(160, 100)
        Me.Controls.Add(txtElement)

        ' Add event handler for dynamic TextBox to capture user input
        AddHandler txtElement.TextChanged, Sub(senderTextBox, eTextBox)
                                               Dim element As Integer
                                               If Integer.TryParse(txtElement.Text, element) Then
                                                   ' Validate range
                                                   If element >= -99 AndAlso element <= 100 Then
                                                       array(currentIndex) = element
                                                   Else
                                                       MessageBox.Show("Invalid input. Please enter a number between -99 and 100.")
                                                   End If
                                               End If
                                           End Sub

        ' Add event handler for KeyDown to handle Enter key press
        AddHandler txtElement.KeyDown, Sub(senderTextBox, eKeyDown)
                                           If eKeyDown.KeyCode = Keys.Enter Then
                                               btnAddNext.PerformClick()
                                           End If
                                       End Sub

        ' Create and configure FlowLayoutPanel
        flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight
        flowLayoutPanel.WrapContents = False
        flowLayoutPanel.Location = New Point(150, 150)
        flowLayoutPanel.AutoSize = True
        Me.Controls.Add(flowLayoutPanel)

        currentIndex = 0 ' Reset the index for the first element

        Strt.Visible = False
        inpArr.Visible = False
        btnAddNext.Visible = True

    End Sub

    Private Sub btnAddNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddNext.Click
        ' Create and configure RichTextBox in a square-shaped, light green container
        Dim richTextBox As New RichTextBox()
        richTextBox.Text = array(currentIndex).ToString()
        richTextBox.BackColor = Color.LightGreen
        richTextBox.Width = 50
        richTextBox.Height = 50
        richTextBox.Margin = New Padding(12)
        richTextBox.SelectionAlignment = HorizontalAlignment.Center

        ' Increase the text size
        Dim currentFont As Font = richTextBox.SelectionFont
        richTextBox.SelectionFont = New Font(currentFont.FontFamily, 20, FontStyle.Italic)

        ' Make the RichTextBox non-editable
        richTextBox.ReadOnly = True

        ' Add RichTextBox to FlowLayoutPanel
        flowLayoutPanel.Controls.Add(richTextBox)

        inpArr.Visible = True

        If currentIndex < array.Length - 1 Then
            ' Update the Label and TextBox for the next element
            lblElement.Text = "Element " & (currentIndex + 1) & ":"
            txtElement.Text = ""

            ' Increase the index for the next element
            currentIndex += 1

            ' Focus on the TextBox for user input
            txtElement.Focus()
        Else
            ' If all elements are entered, hide the "Add Next" button
            btnAddNext.Visible = False
            lblElement.Visible = False
            txtElement.Visible = False
            btnSort.Visible = True
        End If

    End Sub

    Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSort.Click
        btnSort.Visible = False
        ' Display the sorted array
        DisplaySortedArray()
    End Sub
End Class