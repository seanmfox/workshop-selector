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
        Me.lbWorkshop = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbLocation = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbCost = New System.Windows.Forms.ListBox()
        Me.lblTotalCostDescriptor = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbWorkshop
        '
        Me.lbWorkshop.FormattingEnabled = True
        Me.lbWorkshop.ItemHeight = 16
        Me.lbWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lbWorkshop.Location = New System.Drawing.Point(6, 21)
        Me.lbWorkshop.Name = "lbWorkshop"
        Me.lbWorkshop.Size = New System.Drawing.Size(144, 116)
        Me.lbWorkshop.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbWorkshop)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Workshop"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(190, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 148)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick a Location"
        '
        'lbLocation
        '
        Me.lbLocation.FormattingEnabled = True
        Me.lbLocation.ItemHeight = 16
        Me.lbLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lbLocation.Location = New System.Drawing.Point(6, 21)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(144, 116)
        Me.lbLocation.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbCost)
        Me.GroupBox3.Location = New System.Drawing.Point(354, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 148)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Costs"
        '
        'lbCost
        '
        Me.lbCost.FormattingEnabled = True
        Me.lbCost.ItemHeight = 16
        Me.lbCost.Location = New System.Drawing.Point(6, 21)
        Me.lbCost.Name = "lbCost"
        Me.lbCost.Size = New System.Drawing.Size(359, 116)
        Me.lbCost.TabIndex = 0
        '
        'lblTotalCostDescriptor
        '
        Me.lblTotalCostDescriptor.AutoSize = True
        Me.lblTotalCostDescriptor.Location = New System.Drawing.Point(235, 215)
        Me.lblTotalCostDescriptor.Name = "lblTotalCostDescriptor"
        Me.lblTotalCostDescriptor.Size = New System.Drawing.Size(76, 17)
        Me.lblTotalCostDescriptor.TabIndex = 4
        Me.lblTotalCostDescriptor.Text = "Total Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(331, 208)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(133, 31)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(58, 286)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(131, 47)
        Me.btnAddWorkshop.TabIndex = 6
        Me.btnAddWorkshop.Text = "Add Workshop"
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.Location = New System.Drawing.Point(215, 286)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(131, 47)
        Me.btnCalcTotal.TabIndex = 7
        Me.btnCalcTotal.Text = "Calculate Total"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(370, 286)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(131, 47)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(532, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 47)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 367)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcTotal)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostDescriptor)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Workshop Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbWorkshop As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbLocation As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbCost As ListBox
    Friend WithEvents lblTotalCostDescriptor As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnAddWorkshop As Button
    Friend WithEvents btnCalcTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
