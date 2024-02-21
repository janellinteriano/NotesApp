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
        txtBox = New TextBox()
        btnSave = New Button()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        lblHeader = New Label()
        Panel1 = New Panel()
        txtboxTitle = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBox
        ' 
        txtBox.Location = New Point(125, 297)
        txtBox.Multiline = True
        txtBox.Name = "txtBox"
        txtBox.PlaceholderText = "Description"
        txtBox.ScrollBars = ScrollBars.Vertical
        txtBox.Size = New Size(1318, 306)
        txtBox.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(1349, 636)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1187, 636)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "All Notes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(125, 176)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(196, 28)
        ComboBox1.TabIndex = 5
        ComboBox1.Text = "Assign Category"
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Location = New Point(758, 30)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(104, 20)
        lblHeader.TabIndex = 0
        lblHeader.Text = "My Notes App"
        lblHeader.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(lblHeader)
        Panel1.Location = New Point(-3, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2035, 74)
        Panel1.TabIndex = 1
        ' 
        ' txtboxTitle
        ' 
        txtboxTitle.Location = New Point(125, 236)
        txtboxTitle.Name = "txtboxTitle"
        txtboxTitle.PlaceholderText = "Title"
        txtboxTitle.Size = New Size(679, 27)
        txtboxTitle.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1589, 726)
        Controls.Add(txtboxTitle)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(btnSave)
        Controls.Add(txtBox)
        Controls.Add(Panel1)
        Enabled = False
        Name = "Form1"
        Text = "My Notes App"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtBox As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtboxTitle As TextBox
End Class
