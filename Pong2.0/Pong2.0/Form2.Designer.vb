<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPong = New System.Windows.Forms.Button()
        Me.cmdSnake = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which game would you like to play?"
        '
        'cmdPong
        '
        Me.cmdPong.Font = New System.Drawing.Font("Rockwell Extra Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPong.Location = New System.Drawing.Point(30, 131)
        Me.cmdPong.Name = "cmdPong"
        Me.cmdPong.Size = New System.Drawing.Size(176, 78)
        Me.cmdPong.TabIndex = 1
        Me.cmdPong.Text = "Pong"
        Me.cmdPong.UseVisualStyleBackColor = True
        '
        'cmdSnake
        '
        Me.cmdSnake.Font = New System.Drawing.Font("Rockwell Extra Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSnake.Location = New System.Drawing.Point(289, 131)
        Me.cmdSnake.Name = "cmdSnake"
        Me.cmdSnake.Size = New System.Drawing.Size(176, 78)
        Me.cmdSnake.TabIndex = 2
        Me.cmdSnake.Text = "Snake"
        Me.cmdSnake.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Font = New System.Drawing.Font("Rockwell Extra Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.Location = New System.Drawing.Point(182, 266)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(119, 47)
        Me.cmdQuit.TabIndex = 3
        Me.cmdQuit.Text = "Quit"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'frmSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(489, 346)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdSnake)
        Me.Controls.Add(Me.cmdPong)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(505, 385)
        Me.MinimumSize = New System.Drawing.Size(505, 385)
        Me.Name = "frmSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPong As Button
    Friend WithEvents cmdSnake As Button
    Friend WithEvents cmdQuit As Button
End Class
