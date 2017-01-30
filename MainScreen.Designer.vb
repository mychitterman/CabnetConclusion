<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.cmdActivateRecords = New System.Windows.Forms.Button()
        Me.CMDDOcument = New System.Windows.Forms.Button()
        Me.AddRecords = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdActivateRecords
        '
        Me.cmdActivateRecords.Location = New System.Drawing.Point(58, 34)
        Me.cmdActivateRecords.Name = "cmdActivateRecords"
        Me.cmdActivateRecords.Size = New System.Drawing.Size(126, 23)
        Me.cmdActivateRecords.TabIndex = 0
        Me.cmdActivateRecords.Text = "Organise Document"
        Me.cmdActivateRecords.UseVisualStyleBackColor = True
        '
        'CMDDOcument
        '
        Me.CMDDOcument.Location = New System.Drawing.Point(473, 34)
        Me.CMDDOcument.Name = "CMDDOcument"
        Me.CMDDOcument.Size = New System.Drawing.Size(111, 23)
        Me.CMDDOcument.TabIndex = 1
        Me.CMDDOcument.Text = "View Document List"
        Me.CMDDOcument.UseVisualStyleBackColor = True
        '
        'AddRecords
        '
        Me.AddRecords.Location = New System.Drawing.Point(473, 108)
        Me.AddRecords.Name = "AddRecords"
        Me.AddRecords.Size = New System.Drawing.Size(111, 23)
        Me.AddRecords.TabIndex = 2
        Me.AddRecords.Text = "Add New Records"
        Me.AddRecords.UseVisualStyleBackColor = True
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 385)
        Me.Controls.Add(Me.AddRecords)
        Me.Controls.Add(Me.CMDDOcument)
        Me.Controls.Add(Me.cmdActivateRecords)
        Me.Name = "MainScreen"
        Me.Text = "MainScreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdActivateRecords As System.Windows.Forms.Button
    Friend WithEvents CMDDOcument As System.Windows.Forms.Button
    Friend WithEvents AddRecords As System.Windows.Forms.Button
End Class
