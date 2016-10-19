<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Gereedschap As System.Windows.Forms.ColumnHeader
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.txtnaam = New System.Windows.Forms.TextBox()
        Me.txtgereedschap = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Naam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tijd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Gereedschap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gereedschap
        '
        Gereedschap.Text = "Gereedschap"
        Gereedschap.Width = 187
        '
        'txtnaam
        '
        Me.txtnaam.Location = New System.Drawing.Point(95, 57)
        Me.txtnaam.Name = "txtnaam"
        Me.txtnaam.Size = New System.Drawing.Size(128, 20)
        Me.txtnaam.TabIndex = 0
        Me.txtnaam.Tag = "txtnaam"
        '
        'txtgereedschap
        '
        Me.txtgereedschap.Location = New System.Drawing.Point(95, 27)
        Me.txtgereedschap.Name = "txtgereedschap"
        Me.txtgereedschap.Size = New System.Drawing.Size(128, 20)
        Me.txtgereedschap.TabIndex = 1
        Me.txtgereedschap.Tag = "txtgereedschap"
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(51, 60)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(38, 13)
        Me.txt1.TabIndex = 3
        Me.txt1.Tag = ""
        Me.txt1.Text = "Naam:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(15, 30)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(74, 13)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Gereedschap:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnaam)
        Me.GroupBox1.Controls.Add(Me.txtgereedschap)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 56)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Inchecken"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Uitchecken"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Gereedschap, Me.Naam, Me.Tijd})
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.ListView1.Location = New System.Drawing.Point(40, 141)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(562, 286)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Naam
        '
        Me.Naam.Text = "Naam"
        Me.Naam.Width = 187
        '
        'Tijd
        '
        Me.Tijd.Text = "Tijd"
        Me.Tijd.Width = 187
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 466)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnaam As TextBox
    Friend WithEvents txtgereedschap As TextBox
    Friend WithEvents txt1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Naam As ColumnHeader
    Friend WithEvents Tijd As ColumnHeader
End Class
