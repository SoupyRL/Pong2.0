<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnake
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
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.cmdCommencer = New System.Windows.Forms.Button()
        Me.tmrJoue = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSnake = New System.Windows.Forms.Timer(Me.components)
        Me.tmrChrono = New System.Windows.Forms.Timer(Me.components)
        Me.picPomme1 = New System.Windows.Forms.PictureBox()
        Me.picSnakeHead = New System.Windows.Forms.PictureBox()
        Me.picPomme2 = New System.Windows.Forms.PictureBox()
        Me.picPomme3 = New System.Windows.Forms.PictureBox()
        Me.picPomme4 = New System.Windows.Forms.PictureBox()
        Me.picPomme5 = New System.Windows.Forms.PictureBox()
        Me.picPomme6 = New System.Windows.Forms.PictureBox()
        Me.picPomme7 = New System.Windows.Forms.PictureBox()
        Me.picPomme8 = New System.Windows.Forms.PictureBox()
        Me.tmrPause = New System.Windows.Forms.Timer(Me.components)
        Me.picSnake1 = New System.Windows.Forms.PictureBox()
        Me.picSnake2 = New System.Windows.Forms.PictureBox()
        Me.picSnake3 = New System.Windows.Forms.PictureBox()
        Me.picSnake4 = New System.Windows.Forms.PictureBox()
        Me.picSnake5 = New System.Windows.Forms.PictureBox()
        Me.picSnake6 = New System.Windows.Forms.PictureBox()
        Me.picSnake7 = New System.Windows.Forms.PictureBox()
        Me.picSnake8 = New System.Windows.Forms.PictureBox()
        Me.picSnake9 = New System.Windows.Forms.PictureBox()
        Me.picSnake10 = New System.Windows.Forms.PictureBox()
        Me.picSnake11 = New System.Windows.Forms.PictureBox()
        Me.picSnake12 = New System.Windows.Forms.PictureBox()
        Me.picSnake13 = New System.Windows.Forms.PictureBox()
        Me.picSnake14 = New System.Windows.Forms.PictureBox()
        Me.picSnake15 = New System.Windows.Forms.PictureBox()
        Me.picSnake16 = New System.Windows.Forms.PictureBox()
        Me.picSnake17 = New System.Windows.Forms.PictureBox()
        Me.picSnake18 = New System.Windows.Forms.PictureBox()
        Me.picSnake19 = New System.Windows.Forms.PictureBox()
        Me.picSnake20 = New System.Windows.Forms.PictureBox()
        CType(Me.picPomme1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnakeHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomme8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdQuitter
        '
        Me.cmdQuitter.BackColor = System.Drawing.Color.Red
        Me.cmdQuitter.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitter.Location = New System.Drawing.Point(271, 280)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(376, 156)
        Me.cmdQuitter.TabIndex = 11
        Me.cmdQuitter.Text = "Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = False
        '
        'lblChrono
        '
        Me.lblChrono.AutoSize = True
        Me.lblChrono.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.ForeColor = System.Drawing.Color.White
        Me.lblChrono.Location = New System.Drawing.Point(815, 54)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(76, 18)
        Me.lblChrono.TabIndex = 10
        Me.lblChrono.Text = "Chrono : "
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.White
        Me.lblPoint.Location = New System.Drawing.Point(824, 24)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(67, 18)
        Me.lblPoint.TabIndex = 9
        Me.lblPoint.Text = "Points : "
        '
        'cmdCommencer
        '
        Me.cmdCommencer.BackColor = System.Drawing.Color.Lime
        Me.cmdCommencer.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommencer.Location = New System.Drawing.Point(271, 79)
        Me.cmdCommencer.Name = "cmdCommencer"
        Me.cmdCommencer.Size = New System.Drawing.Size(376, 156)
        Me.cmdCommencer.TabIndex = 8
        Me.cmdCommencer.Text = "Commencer"
        Me.cmdCommencer.UseVisualStyleBackColor = False
        '
        'tmrJoue
        '
        Me.tmrJoue.Interval = 50
        '
        'tmrSnake
        '
        Me.tmrSnake.Interval = 1000
        '
        'tmrChrono
        '
        Me.tmrChrono.Interval = 1000
        '
        'picPomme1
        '
        Me.picPomme1.BackColor = System.Drawing.Color.Transparent
        Me.picPomme1.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme1.Location = New System.Drawing.Point(144, 101)
        Me.picPomme1.Name = "picPomme1"
        Me.picPomme1.Size = New System.Drawing.Size(25, 25)
        Me.picPomme1.TabIndex = 13
        Me.picPomme1.TabStop = False
        '
        'picSnakeHead
        '
        Me.picSnakeHead.BackColor = System.Drawing.Color.Lime
        Me.picSnakeHead.Location = New System.Drawing.Point(110, 3)
        Me.picSnakeHead.Name = "picSnakeHead"
        Me.picSnakeHead.Size = New System.Drawing.Size(25, 25)
        Me.picSnakeHead.TabIndex = 12
        Me.picSnakeHead.TabStop = False
        '
        'picPomme2
        '
        Me.picPomme2.BackColor = System.Drawing.Color.Transparent
        Me.picPomme2.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme2.Location = New System.Drawing.Point(219, 47)
        Me.picPomme2.Name = "picPomme2"
        Me.picPomme2.Size = New System.Drawing.Size(25, 25)
        Me.picPomme2.TabIndex = 14
        Me.picPomme2.TabStop = False
        '
        'picPomme3
        '
        Me.picPomme3.BackColor = System.Drawing.Color.Transparent
        Me.picPomme3.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme3.Location = New System.Drawing.Point(470, 227)
        Me.picPomme3.Name = "picPomme3"
        Me.picPomme3.Size = New System.Drawing.Size(25, 25)
        Me.picPomme3.TabIndex = 15
        Me.picPomme3.TabStop = False
        '
        'picPomme4
        '
        Me.picPomme4.BackColor = System.Drawing.Color.Transparent
        Me.picPomme4.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme4.Location = New System.Drawing.Point(478, 235)
        Me.picPomme4.Name = "picPomme4"
        Me.picPomme4.Size = New System.Drawing.Size(25, 25)
        Me.picPomme4.TabIndex = 16
        Me.picPomme4.TabStop = False
        '
        'picPomme5
        '
        Me.picPomme5.BackColor = System.Drawing.Color.Transparent
        Me.picPomme5.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme5.Location = New System.Drawing.Point(486, 243)
        Me.picPomme5.Name = "picPomme5"
        Me.picPomme5.Size = New System.Drawing.Size(25, 25)
        Me.picPomme5.TabIndex = 17
        Me.picPomme5.TabStop = False
        '
        'picPomme6
        '
        Me.picPomme6.BackColor = System.Drawing.Color.Transparent
        Me.picPomme6.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme6.Location = New System.Drawing.Point(494, 251)
        Me.picPomme6.Name = "picPomme6"
        Me.picPomme6.Size = New System.Drawing.Size(25, 25)
        Me.picPomme6.TabIndex = 18
        Me.picPomme6.TabStop = False
        '
        'picPomme7
        '
        Me.picPomme7.BackColor = System.Drawing.Color.Transparent
        Me.picPomme7.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme7.Location = New System.Drawing.Point(502, 259)
        Me.picPomme7.Name = "picPomme7"
        Me.picPomme7.Size = New System.Drawing.Size(25, 25)
        Me.picPomme7.TabIndex = 19
        Me.picPomme7.TabStop = False
        '
        'picPomme8
        '
        Me.picPomme8.BackColor = System.Drawing.Color.Transparent
        Me.picPomme8.BackgroundImage = Global.Pong2._0_fr.My.Resources.Resources.apple
        Me.picPomme8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPomme8.Location = New System.Drawing.Point(940, 280)
        Me.picPomme8.Name = "picPomme8"
        Me.picPomme8.Size = New System.Drawing.Size(25, 25)
        Me.picPomme8.TabIndex = 20
        Me.picPomme8.TabStop = False
        '
        'tmrPause
        '
        Me.tmrPause.Interval = 5000
        '
        'picSnake1
        '
        Me.picSnake1.BackColor = System.Drawing.Color.Yellow
        Me.picSnake1.Location = New System.Drawing.Point(510, 267)
        Me.picSnake1.Name = "picSnake1"
        Me.picSnake1.Size = New System.Drawing.Size(25, 25)
        Me.picSnake1.TabIndex = 21
        Me.picSnake1.TabStop = False
        '
        'picSnake2
        '
        Me.picSnake2.BackColor = System.Drawing.Color.Yellow
        Me.picSnake2.Location = New System.Drawing.Point(518, 275)
        Me.picSnake2.Name = "picSnake2"
        Me.picSnake2.Size = New System.Drawing.Size(25, 25)
        Me.picSnake2.TabIndex = 22
        Me.picSnake2.TabStop = False
        '
        'picSnake3
        '
        Me.picSnake3.BackColor = System.Drawing.Color.Yellow
        Me.picSnake3.Location = New System.Drawing.Point(526, 283)
        Me.picSnake3.Name = "picSnake3"
        Me.picSnake3.Size = New System.Drawing.Size(25, 25)
        Me.picSnake3.TabIndex = 23
        Me.picSnake3.TabStop = False
        '
        'picSnake4
        '
        Me.picSnake4.BackColor = System.Drawing.Color.Yellow
        Me.picSnake4.Location = New System.Drawing.Point(534, 291)
        Me.picSnake4.Name = "picSnake4"
        Me.picSnake4.Size = New System.Drawing.Size(25, 25)
        Me.picSnake4.TabIndex = 24
        Me.picSnake4.TabStop = False
        '
        'picSnake5
        '
        Me.picSnake5.BackColor = System.Drawing.Color.Yellow
        Me.picSnake5.Location = New System.Drawing.Point(542, 299)
        Me.picSnake5.Name = "picSnake5"
        Me.picSnake5.Size = New System.Drawing.Size(25, 25)
        Me.picSnake5.TabIndex = 25
        Me.picSnake5.TabStop = False
        '
        'picSnake6
        '
        Me.picSnake6.BackColor = System.Drawing.Color.Yellow
        Me.picSnake6.Location = New System.Drawing.Point(550, 307)
        Me.picSnake6.Name = "picSnake6"
        Me.picSnake6.Size = New System.Drawing.Size(25, 25)
        Me.picSnake6.TabIndex = 26
        Me.picSnake6.TabStop = False
        '
        'picSnake7
        '
        Me.picSnake7.BackColor = System.Drawing.Color.Yellow
        Me.picSnake7.Location = New System.Drawing.Point(558, 315)
        Me.picSnake7.Name = "picSnake7"
        Me.picSnake7.Size = New System.Drawing.Size(25, 25)
        Me.picSnake7.TabIndex = 27
        Me.picSnake7.TabStop = False
        '
        'picSnake8
        '
        Me.picSnake8.BackColor = System.Drawing.Color.Yellow
        Me.picSnake8.Location = New System.Drawing.Point(566, 323)
        Me.picSnake8.Name = "picSnake8"
        Me.picSnake8.Size = New System.Drawing.Size(25, 25)
        Me.picSnake8.TabIndex = 28
        Me.picSnake8.TabStop = False
        '
        'picSnake9
        '
        Me.picSnake9.BackColor = System.Drawing.Color.Yellow
        Me.picSnake9.Location = New System.Drawing.Point(574, 331)
        Me.picSnake9.Name = "picSnake9"
        Me.picSnake9.Size = New System.Drawing.Size(25, 25)
        Me.picSnake9.TabIndex = 29
        Me.picSnake9.TabStop = False
        '
        'picSnake10
        '
        Me.picSnake10.BackColor = System.Drawing.Color.Yellow
        Me.picSnake10.Location = New System.Drawing.Point(582, 339)
        Me.picSnake10.Name = "picSnake10"
        Me.picSnake10.Size = New System.Drawing.Size(25, 25)
        Me.picSnake10.TabIndex = 30
        Me.picSnake10.TabStop = False
        '
        'picSnake11
        '
        Me.picSnake11.BackColor = System.Drawing.Color.Yellow
        Me.picSnake11.Location = New System.Drawing.Point(590, 347)
        Me.picSnake11.Name = "picSnake11"
        Me.picSnake11.Size = New System.Drawing.Size(25, 25)
        Me.picSnake11.TabIndex = 31
        Me.picSnake11.TabStop = False
        '
        'picSnake12
        '
        Me.picSnake12.BackColor = System.Drawing.Color.Yellow
        Me.picSnake12.Location = New System.Drawing.Point(598, 355)
        Me.picSnake12.Name = "picSnake12"
        Me.picSnake12.Size = New System.Drawing.Size(25, 25)
        Me.picSnake12.TabIndex = 32
        Me.picSnake12.TabStop = False
        '
        'picSnake13
        '
        Me.picSnake13.BackColor = System.Drawing.Color.Yellow
        Me.picSnake13.Location = New System.Drawing.Point(606, 363)
        Me.picSnake13.Name = "picSnake13"
        Me.picSnake13.Size = New System.Drawing.Size(25, 25)
        Me.picSnake13.TabIndex = 33
        Me.picSnake13.TabStop = False
        '
        'picSnake14
        '
        Me.picSnake14.BackColor = System.Drawing.Color.Yellow
        Me.picSnake14.Location = New System.Drawing.Point(614, 371)
        Me.picSnake14.Name = "picSnake14"
        Me.picSnake14.Size = New System.Drawing.Size(25, 25)
        Me.picSnake14.TabIndex = 34
        Me.picSnake14.TabStop = False
        '
        'picSnake15
        '
        Me.picSnake15.BackColor = System.Drawing.Color.Yellow
        Me.picSnake15.Location = New System.Drawing.Point(622, 379)
        Me.picSnake15.Name = "picSnake15"
        Me.picSnake15.Size = New System.Drawing.Size(25, 25)
        Me.picSnake15.TabIndex = 35
        Me.picSnake15.TabStop = False
        '
        'picSnake16
        '
        Me.picSnake16.BackColor = System.Drawing.Color.Yellow
        Me.picSnake16.Location = New System.Drawing.Point(630, 387)
        Me.picSnake16.Name = "picSnake16"
        Me.picSnake16.Size = New System.Drawing.Size(25, 25)
        Me.picSnake16.TabIndex = 36
        Me.picSnake16.TabStop = False
        '
        'picSnake17
        '
        Me.picSnake17.BackColor = System.Drawing.Color.Yellow
        Me.picSnake17.Location = New System.Drawing.Point(638, 395)
        Me.picSnake17.Name = "picSnake17"
        Me.picSnake17.Size = New System.Drawing.Size(25, 25)
        Me.picSnake17.TabIndex = 37
        Me.picSnake17.TabStop = False
        '
        'picSnake18
        '
        Me.picSnake18.BackColor = System.Drawing.Color.Yellow
        Me.picSnake18.Location = New System.Drawing.Point(646, 403)
        Me.picSnake18.Name = "picSnake18"
        Me.picSnake18.Size = New System.Drawing.Size(25, 25)
        Me.picSnake18.TabIndex = 38
        Me.picSnake18.TabStop = False
        '
        'picSnake19
        '
        Me.picSnake19.BackColor = System.Drawing.Color.Yellow
        Me.picSnake19.Location = New System.Drawing.Point(654, 411)
        Me.picSnake19.Name = "picSnake19"
        Me.picSnake19.Size = New System.Drawing.Size(25, 25)
        Me.picSnake19.TabIndex = 39
        Me.picSnake19.TabStop = False
        '
        'picSnake20
        '
        Me.picSnake20.BackColor = System.Drawing.Color.Yellow
        Me.picSnake20.Location = New System.Drawing.Point(662, 419)
        Me.picSnake20.Name = "picSnake20"
        Me.picSnake20.Size = New System.Drawing.Size(25, 25)
        Me.picSnake20.TabIndex = 40
        Me.picSnake20.TabStop = False
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(964, 479)
        Me.Controls.Add(Me.picSnake20)
        Me.Controls.Add(Me.picSnake19)
        Me.Controls.Add(Me.picSnake18)
        Me.Controls.Add(Me.picSnake17)
        Me.Controls.Add(Me.picSnake16)
        Me.Controls.Add(Me.picSnake15)
        Me.Controls.Add(Me.picSnake14)
        Me.Controls.Add(Me.picSnake13)
        Me.Controls.Add(Me.picSnake12)
        Me.Controls.Add(Me.picSnake11)
        Me.Controls.Add(Me.picSnake10)
        Me.Controls.Add(Me.picSnake9)
        Me.Controls.Add(Me.picSnake8)
        Me.Controls.Add(Me.picSnake7)
        Me.Controls.Add(Me.picSnake6)
        Me.Controls.Add(Me.picSnake5)
        Me.Controls.Add(Me.picSnake4)
        Me.Controls.Add(Me.picSnake3)
        Me.Controls.Add(Me.picSnake2)
        Me.Controls.Add(Me.picSnake1)
        Me.Controls.Add(Me.picSnakeHead)
        Me.Controls.Add(Me.picPomme8)
        Me.Controls.Add(Me.picPomme7)
        Me.Controls.Add(Me.picPomme6)
        Me.Controls.Add(Me.picPomme5)
        Me.Controls.Add(Me.picPomme4)
        Me.Controls.Add(Me.picPomme3)
        Me.Controls.Add(Me.picPomme2)
        Me.Controls.Add(Me.picPomme1)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.cmdCommencer)
        Me.MaximumSize = New System.Drawing.Size(980, 518)
        Me.MinimumSize = New System.Drawing.Size(980, 518)
        Me.Name = "frmSnake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake"
        CType(Me.picPomme1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnakeHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomme8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdQuitter As Button
    Friend WithEvents lblChrono As Label
    Friend WithEvents lblPoint As Label
    Friend WithEvents cmdCommencer As Button
    Friend WithEvents tmrJoue As Timer
    Friend WithEvents picSnakeHead As PictureBox
    Friend WithEvents tmrSnake As Timer
    Friend WithEvents tmrChrono As Timer
    Friend WithEvents picPomme1 As PictureBox
    Friend WithEvents picPomme2 As PictureBox
    Friend WithEvents picPomme3 As PictureBox
    Friend WithEvents picPomme4 As PictureBox
    Friend WithEvents picPomme5 As PictureBox
    Friend WithEvents picPomme6 As PictureBox
    Friend WithEvents picPomme7 As PictureBox
    Friend WithEvents picPomme8 As PictureBox
    Friend WithEvents tmrPause As Timer
    Friend WithEvents picSnake1 As PictureBox
    Friend WithEvents picSnake2 As PictureBox
    Friend WithEvents picSnake3 As PictureBox
    Friend WithEvents picSnake4 As PictureBox
    Friend WithEvents picSnake5 As PictureBox
    Friend WithEvents picSnake6 As PictureBox
    Friend WithEvents picSnake7 As PictureBox
    Friend WithEvents picSnake8 As PictureBox
    Friend WithEvents picSnake9 As PictureBox
    Friend WithEvents picSnake10 As PictureBox
    Friend WithEvents picSnake11 As PictureBox
    Friend WithEvents picSnake12 As PictureBox
    Friend WithEvents picSnake13 As PictureBox
    Friend WithEvents picSnake14 As PictureBox
    Friend WithEvents picSnake15 As PictureBox
    Friend WithEvents picSnake16 As PictureBox
    Friend WithEvents picSnake17 As PictureBox
    Friend WithEvents picSnake18 As PictureBox
    Friend WithEvents picSnake19 As PictureBox
    Friend WithEvents picSnake20 As PictureBox
End Class
