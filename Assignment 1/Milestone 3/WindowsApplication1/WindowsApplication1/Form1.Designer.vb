<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAddNext = New System.Windows.Forms.Button()
        Me.inpArr = New System.Windows.Forms.Label()
        Me.size_label = New System.Windows.Forms.Label()
        Me.inptSz = New System.Windows.Forms.TextBox()
        Me.Strt = New System.Windows.Forms.Button()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.txtElement = New System.Windows.Forms.TextBox()
        Me.btnNextIteration = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox8 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox9 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox10 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox20 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox19 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox18 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox17 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox16 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox15 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox14 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox13 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox12 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox11 = New System.Windows.Forms.RichTextBox()
        Me.lblIter = New System.Windows.Forms.Label()
        Me.txtSwappedIndices = New System.Windows.Forms.TextBox()
        Me.btnUnsortedDisp = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddNext
        '
        Me.btnAddNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNext.ForeColor = System.Drawing.Color.White
        Me.btnAddNext.Location = New System.Drawing.Point(481, 135)
        Me.btnAddNext.Name = "btnAddNext"
        Me.btnAddNext.Size = New System.Drawing.Size(127, 38)
        Me.btnAddNext.TabIndex = 17
        Me.btnAddNext.Text = "Add Element"
        Me.btnAddNext.UseVisualStyleBackColor = False
        Me.btnAddNext.Visible = False
        '
        'inpArr
        '
        Me.inpArr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.inpArr.AutoSize = True
        Me.inpArr.BackColor = System.Drawing.Color.Transparent
        Me.inpArr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpArr.Location = New System.Drawing.Point(82, 201)
        Me.inpArr.Name = "inpArr"
        Me.inpArr.Size = New System.Drawing.Size(105, 24)
        Me.inpArr.TabIndex = 16
        Me.inpArr.Text = "Input Array:"
        Me.inpArr.Visible = False
        '
        'size_label
        '
        Me.size_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.size_label.AutoSize = True
        Me.size_label.BackColor = System.Drawing.Color.Transparent
        Me.size_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.size_label.Location = New System.Drawing.Point(169, 74)
        Me.size_label.Name = "size_label"
        Me.size_label.Size = New System.Drawing.Size(276, 24)
        Me.size_label.TabIndex = 15
        Me.size_label.Text = "Enter the size of Array (max 10):"
        '
        'inptSz
        '
        Me.inptSz.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.inptSz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inptSz.Location = New System.Drawing.Point(485, 74)
        Me.inptSz.Name = "inptSz"
        Me.inptSz.Size = New System.Drawing.Size(100, 30)
        Me.inptSz.TabIndex = 14
        '
        'Strt
        '
        Me.Strt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Strt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Strt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Strt.Location = New System.Drawing.Point(485, 179)
        Me.Strt.Name = "Strt"
        Me.Strt.Size = New System.Drawing.Size(112, 46)
        Me.Strt.TabIndex = 13
        Me.Strt.Text = "Start"
        Me.Strt.UseVisualStyleBackColor = False
        '
        'lblElement
        '
        Me.lblElement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblElement.AutoSize = True
        Me.lblElement.BackColor = System.Drawing.Color.Transparent
        Me.lblElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElement.Location = New System.Drawing.Point(202, 141)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(100, 24)
        Me.lblElement.TabIndex = 19
        Me.lblElement.Text = "Element 1:"
        Me.lblElement.Visible = False
        '
        'txtElement
        '
        Me.txtElement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElement.Location = New System.Drawing.Point(329, 140)
        Me.txtElement.Name = "txtElement"
        Me.txtElement.Size = New System.Drawing.Size(116, 26)
        Me.txtElement.TabIndex = 20
        Me.txtElement.Visible = False
        '
        'btnNextIteration
        '
        Me.btnNextIteration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextIteration.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNextIteration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextIteration.ForeColor = System.Drawing.Color.White
        Me.btnNextIteration.Location = New System.Drawing.Point(961, 344)
        Me.btnNextIteration.Name = "btnNextIteration"
        Me.btnNextIteration.Size = New System.Drawing.Size(175, 48)
        Me.btnNextIteration.TabIndex = 21
        Me.btnNextIteration.Text = "Next Iteration"
        Me.btnNextIteration.UseVisualStyleBackColor = False
        Me.btnNextIteration.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.Location = New System.Drawing.Point(126, 241)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightMargin = 3
        Me.RichTextBox1.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        Me.RichTextBox1.ZoomFactor = 2.0!
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox2.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox2.Location = New System.Drawing.Point(206, 241)
        Me.RichTextBox2.Multiline = False
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.RightMargin = 3
        Me.RichTextBox2.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox2.TabIndex = 23
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        Me.RichTextBox2.ZoomFactor = 2.0!
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox3.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox3.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox3.Location = New System.Drawing.Point(286, 241)
        Me.RichTextBox3.Multiline = False
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.RightMargin = 3
        Me.RichTextBox3.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox3.TabIndex = 24
        Me.RichTextBox3.Text = ""
        Me.RichTextBox3.Visible = False
        Me.RichTextBox3.ZoomFactor = 2.0!
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox4.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox4.Location = New System.Drawing.Point(366, 241)
        Me.RichTextBox4.Multiline = False
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.RightMargin = 3
        Me.RichTextBox4.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox4.TabIndex = 25
        Me.RichTextBox4.Text = ""
        Me.RichTextBox4.Visible = False
        Me.RichTextBox4.ZoomFactor = 2.0!
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox5.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox5.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox5.Location = New System.Drawing.Point(446, 241)
        Me.RichTextBox5.Multiline = False
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.RightMargin = 3
        Me.RichTextBox5.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox5.TabIndex = 26
        Me.RichTextBox5.Text = ""
        Me.RichTextBox5.Visible = False
        Me.RichTextBox5.ZoomFactor = 2.0!
        '
        'RichTextBox6
        '
        Me.RichTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox6.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox6.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox6.Location = New System.Drawing.Point(526, 241)
        Me.RichTextBox6.Multiline = False
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.ReadOnly = True
        Me.RichTextBox6.RightMargin = 3
        Me.RichTextBox6.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox6.TabIndex = 27
        Me.RichTextBox6.Text = ""
        Me.RichTextBox6.Visible = False
        Me.RichTextBox6.ZoomFactor = 2.0!
        '
        'RichTextBox7
        '
        Me.RichTextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox7.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox7.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox7.Location = New System.Drawing.Point(606, 241)
        Me.RichTextBox7.Multiline = False
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.ReadOnly = True
        Me.RichTextBox7.RightMargin = 3
        Me.RichTextBox7.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox7.TabIndex = 28
        Me.RichTextBox7.Text = ""
        Me.RichTextBox7.Visible = False
        Me.RichTextBox7.ZoomFactor = 2.0!
        '
        'RichTextBox8
        '
        Me.RichTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox8.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox8.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox8.Location = New System.Drawing.Point(686, 241)
        Me.RichTextBox8.Multiline = False
        Me.RichTextBox8.Name = "RichTextBox8"
        Me.RichTextBox8.ReadOnly = True
        Me.RichTextBox8.RightMargin = 3
        Me.RichTextBox8.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox8.TabIndex = 29
        Me.RichTextBox8.Text = ""
        Me.RichTextBox8.Visible = False
        Me.RichTextBox8.ZoomFactor = 2.0!
        '
        'RichTextBox9
        '
        Me.RichTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox9.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox9.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox9.Location = New System.Drawing.Point(766, 241)
        Me.RichTextBox9.Multiline = False
        Me.RichTextBox9.Name = "RichTextBox9"
        Me.RichTextBox9.ReadOnly = True
        Me.RichTextBox9.RightMargin = 3
        Me.RichTextBox9.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox9.TabIndex = 30
        Me.RichTextBox9.Text = ""
        Me.RichTextBox9.Visible = False
        Me.RichTextBox9.ZoomFactor = 2.0!
        '
        'RichTextBox10
        '
        Me.RichTextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox10.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox10.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox10.Location = New System.Drawing.Point(846, 241)
        Me.RichTextBox10.Multiline = False
        Me.RichTextBox10.Name = "RichTextBox10"
        Me.RichTextBox10.ReadOnly = True
        Me.RichTextBox10.RightMargin = 3
        Me.RichTextBox10.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox10.TabIndex = 31
        Me.RichTextBox10.Text = ""
        Me.RichTextBox10.Visible = False
        Me.RichTextBox10.ZoomFactor = 2.0!
        '
        'RichTextBox20
        '
        Me.RichTextBox20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox20.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox20.Location = New System.Drawing.Point(846, 384)
        Me.RichTextBox20.Multiline = False
        Me.RichTextBox20.Name = "RichTextBox20"
        Me.RichTextBox20.ReadOnly = True
        Me.RichTextBox20.RightMargin = 3
        Me.RichTextBox20.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox20.TabIndex = 42
        Me.RichTextBox20.Text = ""
        Me.RichTextBox20.Visible = False
        Me.RichTextBox20.ZoomFactor = 2.0!
        '
        'RichTextBox19
        '
        Me.RichTextBox19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox19.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox19.Location = New System.Drawing.Point(766, 384)
        Me.RichTextBox19.Multiline = False
        Me.RichTextBox19.Name = "RichTextBox19"
        Me.RichTextBox19.ReadOnly = True
        Me.RichTextBox19.RightMargin = 3
        Me.RichTextBox19.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox19.TabIndex = 41
        Me.RichTextBox19.Text = ""
        Me.RichTextBox19.Visible = False
        Me.RichTextBox19.ZoomFactor = 2.0!
        '
        'RichTextBox18
        '
        Me.RichTextBox18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox18.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox18.Location = New System.Drawing.Point(686, 384)
        Me.RichTextBox18.Multiline = False
        Me.RichTextBox18.Name = "RichTextBox18"
        Me.RichTextBox18.ReadOnly = True
        Me.RichTextBox18.RightMargin = 3
        Me.RichTextBox18.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox18.TabIndex = 40
        Me.RichTextBox18.Text = ""
        Me.RichTextBox18.Visible = False
        Me.RichTextBox18.ZoomFactor = 2.0!
        '
        'RichTextBox17
        '
        Me.RichTextBox17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox17.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox17.Location = New System.Drawing.Point(606, 384)
        Me.RichTextBox17.Multiline = False
        Me.RichTextBox17.Name = "RichTextBox17"
        Me.RichTextBox17.ReadOnly = True
        Me.RichTextBox17.RightMargin = 3
        Me.RichTextBox17.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox17.TabIndex = 39
        Me.RichTextBox17.Text = ""
        Me.RichTextBox17.Visible = False
        Me.RichTextBox17.ZoomFactor = 2.0!
        '
        'RichTextBox16
        '
        Me.RichTextBox16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox16.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox16.Location = New System.Drawing.Point(526, 384)
        Me.RichTextBox16.Multiline = False
        Me.RichTextBox16.Name = "RichTextBox16"
        Me.RichTextBox16.ReadOnly = True
        Me.RichTextBox16.RightMargin = 3
        Me.RichTextBox16.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox16.TabIndex = 38
        Me.RichTextBox16.Text = ""
        Me.RichTextBox16.Visible = False
        Me.RichTextBox16.ZoomFactor = 2.0!
        '
        'RichTextBox15
        '
        Me.RichTextBox15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox15.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox15.Location = New System.Drawing.Point(446, 384)
        Me.RichTextBox15.Multiline = False
        Me.RichTextBox15.Name = "RichTextBox15"
        Me.RichTextBox15.ReadOnly = True
        Me.RichTextBox15.RightMargin = 3
        Me.RichTextBox15.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox15.TabIndex = 37
        Me.RichTextBox15.Text = ""
        Me.RichTextBox15.Visible = False
        Me.RichTextBox15.ZoomFactor = 2.0!
        '
        'RichTextBox14
        '
        Me.RichTextBox14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox14.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox14.Location = New System.Drawing.Point(366, 384)
        Me.RichTextBox14.Multiline = False
        Me.RichTextBox14.Name = "RichTextBox14"
        Me.RichTextBox14.ReadOnly = True
        Me.RichTextBox14.RightMargin = 3
        Me.RichTextBox14.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox14.TabIndex = 36
        Me.RichTextBox14.Text = ""
        Me.RichTextBox14.Visible = False
        Me.RichTextBox14.ZoomFactor = 2.0!
        '
        'RichTextBox13
        '
        Me.RichTextBox13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox13.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox13.Location = New System.Drawing.Point(286, 384)
        Me.RichTextBox13.Multiline = False
        Me.RichTextBox13.Name = "RichTextBox13"
        Me.RichTextBox13.ReadOnly = True
        Me.RichTextBox13.RightMargin = 3
        Me.RichTextBox13.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox13.TabIndex = 35
        Me.RichTextBox13.Text = ""
        Me.RichTextBox13.Visible = False
        Me.RichTextBox13.ZoomFactor = 2.0!
        '
        'RichTextBox12
        '
        Me.RichTextBox12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox12.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox12.Location = New System.Drawing.Point(206, 384)
        Me.RichTextBox12.Multiline = False
        Me.RichTextBox12.Name = "RichTextBox12"
        Me.RichTextBox12.ReadOnly = True
        Me.RichTextBox12.RightMargin = 3
        Me.RichTextBox12.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox12.TabIndex = 34
        Me.RichTextBox12.Text = ""
        Me.RichTextBox12.Visible = False
        Me.RichTextBox12.ZoomFactor = 2.0!
        '
        'RichTextBox11
        '
        Me.RichTextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox11.BackColor = System.Drawing.Color.SkyBlue
        Me.RichTextBox11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox11.Location = New System.Drawing.Point(126, 384)
        Me.RichTextBox11.Multiline = False
        Me.RichTextBox11.Name = "RichTextBox11"
        Me.RichTextBox11.ReadOnly = True
        Me.RichTextBox11.RightMargin = 3
        Me.RichTextBox11.Size = New System.Drawing.Size(55, 55)
        Me.RichTextBox11.TabIndex = 33
        Me.RichTextBox11.Text = ""
        Me.RichTextBox11.Visible = False
        Me.RichTextBox11.ZoomFactor = 2.0!
        '
        'lblIter
        '
        Me.lblIter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIter.AutoSize = True
        Me.lblIter.BackColor = System.Drawing.Color.Transparent
        Me.lblIter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIter.Location = New System.Drawing.Point(82, 344)
        Me.lblIter.Name = "lblIter"
        Me.lblIter.Size = New System.Drawing.Size(140, 24)
        Me.lblIter.TabIndex = 32
        Me.lblIter.Text = "Unsorted Array:"
        Me.lblIter.Visible = False
        '
        'txtSwappedIndices
        '
        Me.txtSwappedIndices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSwappedIndices.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSwappedIndices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSwappedIndices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSwappedIndices.ForeColor = System.Drawing.Color.Red
        Me.txtSwappedIndices.Location = New System.Drawing.Point(286, 490)
        Me.txtSwappedIndices.Multiline = True
        Me.txtSwappedIndices.Name = "txtSwappedIndices"
        Me.txtSwappedIndices.ReadOnly = True
        Me.txtSwappedIndices.Size = New System.Drawing.Size(490, 60)
        Me.txtSwappedIndices.TabIndex = 43
        Me.txtSwappedIndices.Text = "Swapped elements are shown here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtSwappedIndices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSwappedIndices.Visible = False
        '
        'btnUnsortedDisp
        '
        Me.btnUnsortedDisp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUnsortedDisp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUnsortedDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnsortedDisp.ForeColor = System.Drawing.Color.White
        Me.btnUnsortedDisp.Location = New System.Drawing.Point(961, 344)
        Me.btnUnsortedDisp.Name = "btnUnsortedDisp"
        Me.btnUnsortedDisp.Size = New System.Drawing.Size(175, 50)
        Me.btnUnsortedDisp.TabIndex = 44
        Me.btnUnsortedDisp.Text = "Start Sorting"
        Me.btnUnsortedDisp.UseVisualStyleBackColor = False
        Me.btnUnsortedDisp.Visible = False
        '
        'btnRestart
        '
        Me.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRestart.BackColor = System.Drawing.Color.Tan
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.btnRestart.Location = New System.Drawing.Point(644, 67)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(97, 38)
        Me.btnRestart.TabIndex = 45
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        Me.btnRestart.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1178, 583)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnUnsortedDisp)
        Me.Controls.Add(Me.txtSwappedIndices)
        Me.Controls.Add(Me.RichTextBox20)
        Me.Controls.Add(Me.RichTextBox19)
        Me.Controls.Add(Me.RichTextBox18)
        Me.Controls.Add(Me.RichTextBox17)
        Me.Controls.Add(Me.RichTextBox16)
        Me.Controls.Add(Me.RichTextBox15)
        Me.Controls.Add(Me.RichTextBox14)
        Me.Controls.Add(Me.RichTextBox13)
        Me.Controls.Add(Me.RichTextBox12)
        Me.Controls.Add(Me.RichTextBox11)
        Me.Controls.Add(Me.lblIter)
        Me.Controls.Add(Me.RichTextBox10)
        Me.Controls.Add(Me.RichTextBox9)
        Me.Controls.Add(Me.RichTextBox8)
        Me.Controls.Add(Me.RichTextBox7)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnNextIteration)
        Me.Controls.Add(Me.txtElement)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.btnAddNext)
        Me.Controls.Add(Me.inpArr)
        Me.Controls.Add(Me.size_label)
        Me.Controls.Add(Me.inptSz)
        Me.Controls.Add(Me.Strt)
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.Text = "Selection Sort Visualizer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddNext As System.Windows.Forms.Button
    Friend WithEvents inpArr As System.Windows.Forms.Label
    Friend WithEvents size_label As System.Windows.Forms.Label
    Friend WithEvents inptSz As System.Windows.Forms.TextBox
    Friend WithEvents Strt As System.Windows.Forms.Button
    Friend WithEvents lblElement As System.Windows.Forms.Label
    Friend WithEvents txtElement As System.Windows.Forms.TextBox
    Friend WithEvents btnNextIteration As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox8 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox9 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox10 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox20 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox19 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox18 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox17 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox16 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox15 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox14 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox13 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox12 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox11 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblIter As System.Windows.Forms.Label
    Friend WithEvents txtSwappedIndices As System.Windows.Forms.TextBox
    Friend WithEvents btnUnsortedDisp As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button

End Class
