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
        Me.txtTextBox1 = New System.Windows.Forms.TextBox()
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTextBox1
        '
        Me.txtTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.txtTextBox1.Name = "txtTextBox1"
        Me.txtTextBox1.Size = New System.Drawing.Size(243, 20)
        Me.txtTextBox1.TabIndex = 0
        '
        'btnButton1
        '
        Me.btnButton1.Location = New System.Drawing.Point(12, 53)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(243, 23)
        Me.btnButton1.TabIndex = 1
        Me.btnButton1.Text = "Enter your first and last names and press"
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.txtTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTextBox1 As TextBox
    Friend WithEvents btnButton1 As Button
End Class
