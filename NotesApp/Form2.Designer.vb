<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        notesGrid = New DataGridView()
        Panel2 = New Panel()
        lblHeader = New Label()
        CType(notesGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(217, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 29)
        Button1.TabIndex = 0
        Button1.Text = "Create New Note"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' notesGrid
        ' 
        notesGrid.BackgroundColor = SystemColors.Info
        notesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        notesGrid.Location = New Point(217, 241)
        notesGrid.Name = "notesGrid"
        notesGrid.RowHeadersWidth = 51
        notesGrid.RowTemplate.Height = 29
        notesGrid.Size = New Size(1111, 395)
        notesGrid.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(lblHeader)
        Panel2.Location = New Point(-1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1984, 74)
        Panel2.TabIndex = 2
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Location = New Point(767, 33)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(104, 20)
        lblHeader.TabIndex = 0
        lblHeader.Text = "My Notes App"
        lblHeader.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1589, 726)
        Controls.Add(Panel2)
        Controls.Add(notesGrid)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "My Notes App"
        CType(notesGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents notesGrid As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblHeader As Label
End Class
