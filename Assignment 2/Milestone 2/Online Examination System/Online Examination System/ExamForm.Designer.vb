﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamForm
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
        Me.components = New System.ComponentModel.Container()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.question_text = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReviewBtn = New System.Windows.Forms.Button()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.qNum_label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timer_count = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'opt4
        '
        Me.opt4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opt4.AutoSize = True
        Me.opt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt4.Location = New System.Drawing.Point(68, 283)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(92, 36)
        Me.opt4.TabIndex = 9
        Me.opt4.TabStop = True
        Me.opt4.Text = "opt4"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opt3.AutoSize = True
        Me.opt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt3.Location = New System.Drawing.Point(68, 243)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(92, 36)
        Me.opt3.TabIndex = 8
        Me.opt3.TabStop = True
        Me.opt3.Text = "opt3"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opt2.AutoSize = True
        Me.opt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt2.Location = New System.Drawing.Point(68, 198)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(92, 36)
        Me.opt2.TabIndex = 7
        Me.opt2.TabStop = True
        Me.opt2.Text = "opt2"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opt1.AutoSize = True
        Me.opt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt1.Location = New System.Drawing.Point(68, 155)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(92, 36)
        Me.opt1.TabIndex = 6
        Me.opt1.TabStop = True
        Me.opt1.Text = "opt1"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'question_text
        '
        Me.question_text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.question_text.BackColor = System.Drawing.SystemColors.Control
        Me.question_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question_text.Location = New System.Drawing.Point(68, 33)
        Me.question_text.Multiline = True
        Me.question_text.Name = "question_text"
        Me.question_text.ReadOnly = True
        Me.question_text.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.question_text.Size = New System.Drawing.Size(721, 74)
        Me.question_text.TabIndex = 4
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmitBtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(675, 468)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(127, 42)
        Me.SubmitBtn.TabIndex = 3
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(435, 468)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(166, 42)
        Me.SaveBtn.TabIndex = 2
        Me.SaveBtn.Text = "Save and Next"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1222, 41)
        Me.Panel1.TabIndex = 3
        '
        'ReviewBtn
        '
        Me.ReviewBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReviewBtn.BackColor = System.Drawing.Color.Violet
        Me.ReviewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewBtn.ForeColor = System.Drawing.Color.White
        Me.ReviewBtn.Location = New System.Drawing.Point(240, 468)
        Me.ReviewBtn.Name = "ReviewBtn"
        Me.ReviewBtn.Size = New System.Drawing.Size(189, 42)
        Me.ReviewBtn.TabIndex = 1
        Me.ReviewBtn.Text = "Mark for review"
        Me.ReviewBtn.UseVisualStyleBackColor = False
        '
        'PrevBtn
        '
        Me.PrevBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrevBtn.BackColor = System.Drawing.Color.Orange
        Me.PrevBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevBtn.ForeColor = System.Drawing.Color.White
        Me.PrevBtn.Location = New System.Drawing.Point(68, 468)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(166, 42)
        Me.PrevBtn.TabIndex = 0
        Me.PrevBtn.Text = "Previous"
        Me.PrevBtn.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Location = New System.Drawing.Point(-1, 73)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel2.Controls.Add(Me.qNum_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.opt4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.opt3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.opt2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.opt1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.question_text)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SubmitBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaveBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReviewBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PrevBtn)
        Me.SplitContainer1.Size = New System.Drawing.Size(1223, 539)
        Me.SplitContainer1.SplitterDistance = 378
        Me.SplitContainer1.TabIndex = 5
        '
        'qNum_label
        '
        Me.qNum_label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qNum_label.AutoSize = True
        Me.qNum_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qNum_label.Location = New System.Drawing.Point(28, 36)
        Me.qNum_label.Name = "qNum_label"
        Me.qNum_label.Size = New System.Drawing.Size(34, 29)
        Me.qNum_label.TabIndex = 10
        Me.qNum_label.Text = "1)"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.timer_count)
        Me.Panel2.Location = New System.Drawing.Point(-1, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1222, 44)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1032, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Time left: "
        '
        'timer_count
        '
        Me.timer_count.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timer_count.AutoSize = True
        Me.timer_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_count.ForeColor = System.Drawing.Color.Red
        Me.timer_count.Location = New System.Drawing.Point(1146, 11)
        Me.timer_count.Name = "timer_count"
        Me.timer_count.Size = New System.Drawing.Size(67, 25)
        Me.timer_count.TabIndex = 11
        Me.timer_count.Text = "00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ExamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ExamForm"
        Me.Text = "Exam Panel"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents question_text As System.Windows.Forms.TextBox
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReviewBtn As System.Windows.Forms.Button
    Friend WithEvents PrevBtn As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents timer_count As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents qNum_label As System.Windows.Forms.Label

End Class
