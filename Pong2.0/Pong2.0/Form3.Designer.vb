<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSnake
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
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.cmdCommencer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdQuitter
        '
        Me.cmdQuitter.BackColor = System.Drawing.Color.Red
        Me.cmdQuitter.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitter.Location = New System.Drawing.Point(298, 272)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(376, 156)
        Me.cmdQuitter.TabIndex = 7
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = False
        '
        'lblChrono
        '
        Me.lblChrono.AutoSize = True
        Me.lblChrono.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.ForeColor = System.Drawing.Color.White
        Me.lblChrono.Location = New System.Drawing.Point(811, 50)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(76, 18)
        Me.lblChrono.TabIndex = 6
        Me.lblChrono.Text = "Chrono : "
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.White
        Me.lblPoint.Location = New System.Drawing.Point(820, 20)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(67, 18)
        Me.lblPoint.TabIndex = 5
        Me.lblPoint.Text = "Points : "
        '
        'cmdCommencer
        '
        Me.cmdCommencer.BackColor = System.Drawing.Color.Lime
        Me.cmdCommencer.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommencer.Location = New System.Drawing.Point(298, 71)
        Me.cmdCommencer.Name = "cmdCommencer"
        Me.cmdCommencer.Size = New System.Drawing.Size(376, 156)
        Me.cmdCommencer.TabIndex = 4
        Me.cmdCommencer.Text = "Commencer"
        Me.cmdCommencer.UseVisualStyleBackColor = False
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(964, 479)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.cmdCommencer)
        Me.Name = "frmSnake"
        Me.Text = "Snake"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdQuitter As Button
    Friend WithEvents lblChrono As Label
    Friend WithEvents lblPoint As Label
    Friend WithEvents cmdCommencer As Button
End Class
