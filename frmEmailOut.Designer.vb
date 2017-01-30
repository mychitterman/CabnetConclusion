<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailOut
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
        Me.TextBoxEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Validator1 = New Itboy.Components.Validator(Me.components)
        Me.SuspendLayout()
        '
        'TextBoxEmailAddress
        '
        Me.TextBoxEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailAddress.Location = New System.Drawing.Point(23, 49)
        Me.TextBoxEmailAddress.Name = "TextBoxEmailAddress"
        Me.Validator1.SetRegularExpression(Me.TextBoxEmailAddress, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
        Me.Validator1.SetRegularExpressionMessage(Me.TextBoxEmailAddress, "Not An Email Format")
        Me.Validator1.SetRequiredMessage(Me.TextBoxEmailAddress, "Please enter an email")
        Me.TextBoxEmailAddress.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxEmailAddress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the requester email address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send, Wait and Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Validator1
        '
        Me.Validator1.Form = Me
        '
        'frmEmailOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEmailAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmailOut"
        Me.Text = "frmEmailOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Validator1 As Itboy.Components.Validator
End Class
