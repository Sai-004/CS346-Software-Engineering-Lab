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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnAddNext = New System.Windows.Forms.Button()
        Me.inpArr = New System.Windows.Forms.Label()
        Me.size_label = New System.Windows.Forms.Label()
        Me.inptSz = New System.Windows.Forms.TextBox()
        Me.Strt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(424, 291)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(74, 40)
        Me.btnSort.TabIndex = 12
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        Me.btnSort.Visible = False
        '
        'btnAddNext
        '
        Me.btnAddNext.Location = New System.Drawing.Point(407, 114)
        Me.btnAddNext.Name = "btnAddNext"
        Me.btnAddNext.Size = New System.Drawing.Size(104, 38)
        Me.btnAddNext.TabIndex = 11
        Me.btnAddNext.Text = "Add Element"
        Me.btnAddNext.UseVisualStyleBackColor = True
        Me.btnAddNext.Visible = False
        '
        'inpArr
        '
        Me.inpArr.AutoSize = True
        Me.inpArr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpArr.Location = New System.Drawing.Point(21, 183)
        Me.inpArr.Name = "inpArr"
        Me.inpArr.Size = New System.Drawing.Size(95, 20)
        Me.inpArr.TabIndex = 10
        Me.inpArr.Text = "Input Array:"
        Me.inpArr.Visible = False
        '
        'size_label
        '
        Me.size_label.AutoSize = True
        Me.size_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.size_label.Location = New System.Drawing.Point(108, 63)
        Me.size_label.Name = "size_label"
        Me.size_label.Size = New System.Drawing.Size(253, 20)
        Me.size_label.TabIndex = 9
        Me.size_label.Text = "Enter the size of Array (max 15):"
        '
        'inptSz
        '
        Me.inptSz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inptSz.Location = New System.Drawing.Point(424, 56)
        Me.inptSz.Name = "inptSz"
        Me.inptSz.Size = New System.Drawing.Size(100, 30)
        Me.inptSz.TabIndex = 8
        '
        'Strt
        '
        Me.Strt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strt.Location = New System.Drawing.Point(424, 183)
        Me.Strt.Name = "Strt"
        Me.Strt.Size = New System.Drawing.Size(87, 40)
        Me.Strt.TabIndex = 7
        Me.Strt.Text = "Start"
        Me.Strt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(864, 484)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnAddNext)
        Me.Controls.Add(Me.inpArr)
        Me.Controls.Add(Me.size_label)
        Me.Controls.Add(Me.inptSz)
        Me.Controls.Add(Me.Strt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnAddNext As System.Windows.Forms.Button
    Friend WithEvents inpArr As System.Windows.Forms.Label
    Friend WithEvents size_label As System.Windows.Forms.Label
    Friend WithEvents inptSz As System.Windows.Forms.TextBox
    Friend WithEvents Strt As System.Windows.Forms.Button

End Class
