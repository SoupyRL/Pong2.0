<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipale
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
        Me.lblBeta = New System.Windows.Forms.Label()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.picPaddle1 = New System.Windows.Forms.PictureBox()
        Me.picPaddle2 = New System.Windows.Forms.PictureBox()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.cmdRandomizer = New System.Windows.Forms.Button()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.lblJoueur2 = New System.Windows.Forms.Label()
        Me.lblJoueur1 = New System.Windows.Forms.Label()
        Me.cmdAssignationNom = New System.Windows.Forms.Button()
        Me.lblNom2 = New System.Windows.Forms.Label()
        Me.lblNom1 = New System.Windows.Forms.Label()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        Me.lblTitreNom = New System.Windows.Forms.Label()
        Me.cmdRecommencer = New System.Windows.Forms.Button()
        Me.cmdDepart = New System.Windows.Forms.Button()
        Me.lblPoint2 = New System.Windows.Forms.Label()
        Me.lblPoint1 = New System.Windows.Forms.Label()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.tmrJoue = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAI = New System.Windows.Forms.Timer(Me.components)
        Me.lblFinit = New System.Windows.Forms.Label()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBeta
        '
        Me.lblBeta.AutoSize = True
        Me.lblBeta.Location = New System.Drawing.Point(823, 466)
        Me.lblBeta.Name = "lblBeta"
        Me.lblBeta.Size = New System.Drawing.Size(19, 13)
        Me.lblBeta.TabIndex = 39
        Me.lblBeta.Text = "20"
        Me.lblBeta.Visible = False
        '
        'picBall
        '
        Me.picBall.BackColor = System.Drawing.Color.Transparent
        Me.picBall.BackgroundImage = Global.Pong2._0.My.Resources.Resources.Ball
        Me.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBall.Location = New System.Drawing.Point(429, 121)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(35, 35)
        Me.picBall.TabIndex = 20
        Me.picBall.TabStop = False
        '
        'picPaddle1
        '
        Me.picPaddle1.BackgroundImage = Global.Pong2._0.My.Resources.Resources.Paddle
        Me.picPaddle1.Location = New System.Drawing.Point(12, 199)
        Me.picPaddle1.Name = "picPaddle1"
        Me.picPaddle1.Size = New System.Drawing.Size(25, 100)
        Me.picPaddle1.TabIndex = 21
        Me.picPaddle1.TabStop = False
        Me.picPaddle1.Tag = "25,115"
        '
        'picPaddle2
        '
        Me.picPaddle2.BackgroundImage = Global.Pong2._0.My.Resources.Resources.Paddle
        Me.picPaddle2.Location = New System.Drawing.Point(847, 199)
        Me.picPaddle2.Name = "picPaddle2"
        Me.picPaddle2.Size = New System.Drawing.Size(25, 100)
        Me.picPaddle2.TabIndex = 22
        Me.picPaddle2.TabStop = False
        Me.picPaddle2.Tag = "25,115"
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitter.Location = New System.Drawing.Point(402, 475)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(82, 25)
        Me.cmdQuitter.TabIndex = 38
        Me.cmdQuitter.Text = "Quit"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'cmdRandomizer
        '
        Me.cmdRandomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRandomizer.Location = New System.Drawing.Point(382, 450)
        Me.cmdRandomizer.Name = "cmdRandomizer"
        Me.cmdRandomizer.Size = New System.Drawing.Size(116, 50)
        Me.cmdRandomizer.TabIndex = 36
        Me.cmdRandomizer.Text = "Ball Randomizer"
        Me.cmdRandomizer.UseVisualStyleBackColor = True
        '
        'lblChrono
        '
        Me.lblChrono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChrono.AutoSize = True
        Me.lblChrono.BackColor = System.Drawing.Color.Transparent
        Me.lblChrono.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.ForeColor = System.Drawing.Color.White
        Me.lblChrono.Location = New System.Drawing.Point(419, 169)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(51, 60)
        Me.lblChrono.TabIndex = 35
        Me.lblChrono.Text = "3"
        '
        'lblJoueur2
        '
        Me.lblJoueur2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJoueur2.AutoSize = True
        Me.lblJoueur2.BackColor = System.Drawing.Color.Transparent
        Me.lblJoueur2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueur2.ForeColor = System.Drawing.Color.White
        Me.lblJoueur2.Location = New System.Drawing.Point(761, 10)
        Me.lblJoueur2.Name = "lblJoueur2"
        Me.lblJoueur2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJoueur2.Size = New System.Drawing.Size(87, 23)
        Me.lblJoueur2.TabIndex = 34
        Me.lblJoueur2.Text = "Player 2"
        Me.lblJoueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJoueur1
        '
        Me.lblJoueur1.AutoSize = True
        Me.lblJoueur1.BackColor = System.Drawing.Color.Transparent
        Me.lblJoueur1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueur1.ForeColor = System.Drawing.Color.White
        Me.lblJoueur1.Location = New System.Drawing.Point(38, 10)
        Me.lblJoueur1.Name = "lblJoueur1"
        Me.lblJoueur1.Size = New System.Drawing.Size(87, 23)
        Me.lblJoueur1.TabIndex = 33
        Me.lblJoueur1.Text = "Player 1"
        '
        'cmdAssignationNom
        '
        Me.cmdAssignationNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAssignationNom.Location = New System.Drawing.Point(382, 339)
        Me.cmdAssignationNom.Name = "cmdAssignationNom"
        Me.cmdAssignationNom.Size = New System.Drawing.Size(116, 37)
        Me.cmdAssignationNom.TabIndex = 32
        Me.cmdAssignationNom.Text = "Assign Names"
        Me.cmdAssignationNom.UseVisualStyleBackColor = True
        '
        'lblNom2
        '
        Me.lblNom2.AutoSize = True
        Me.lblNom2.BackColor = System.Drawing.Color.Transparent
        Me.lblNom2.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom2.ForeColor = System.Drawing.Color.White
        Me.lblNom2.Location = New System.Drawing.Point(520, 219)
        Me.lblNom2.Name = "lblNom2"
        Me.lblNom2.Size = New System.Drawing.Size(69, 18)
        Me.lblNom2.TabIndex = 31
        Me.lblNom2.Text = "Player 2"
        '
        'lblNom1
        '
        Me.lblNom1.AutoSize = True
        Me.lblNom1.BackColor = System.Drawing.Color.Transparent
        Me.lblNom1.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom1.ForeColor = System.Drawing.Color.White
        Me.lblNom1.Location = New System.Drawing.Point(303, 219)
        Me.lblNom1.Name = "lblNom1"
        Me.lblNom1.Size = New System.Drawing.Size(69, 18)
        Me.lblNom1.TabIndex = 30
        Me.lblNom1.Text = "Player 1"
        '
        'txtNom2
        '
        Me.txtNom2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNom2.Location = New System.Drawing.Point(500, 257)
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(109, 20)
        Me.txtNom2.TabIndex = 29
        '
        'txtNom1
        '
        Me.txtNom1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNom1.Location = New System.Drawing.Point(282, 257)
        Me.txtNom1.Name = "txtNom1"
        Me.txtNom1.Size = New System.Drawing.Size(109, 20)
        Me.txtNom1.TabIndex = 28
        '
        'lblTitreNom
        '
        Me.lblTitreNom.AutoSize = True
        Me.lblTitreNom.BackColor = System.Drawing.Color.Transparent
        Me.lblTitreNom.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreNom.ForeColor = System.Drawing.Color.White
        Me.lblTitreNom.Location = New System.Drawing.Point(387, 179)
        Me.lblTitreNom.Name = "lblTitreNom"
        Me.lblTitreNom.Size = New System.Drawing.Size(120, 19)
        Me.lblTitreNom.TabIndex = 27
        Me.lblTitreNom.Text = "Player Names"
        '
        'cmdRecommencer
        '
        Me.cmdRecommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecommencer.Location = New System.Drawing.Point(523, 466)
        Me.cmdRecommencer.Name = "cmdRecommencer"
        Me.cmdRecommencer.Size = New System.Drawing.Size(109, 34)
        Me.cmdRecommencer.TabIndex = 26
        Me.cmdRecommencer.Text = "Restart"
        Me.cmdRecommencer.UseVisualStyleBackColor = True
        '
        'cmdDepart
        '
        Me.cmdDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDepart.Location = New System.Drawing.Point(254, 466)
        Me.cmdDepart.Name = "cmdDepart"
        Me.cmdDepart.Size = New System.Drawing.Size(109, 34)
        Me.cmdDepart.TabIndex = 25
        Me.cmdDepart.Text = "Start"
        Me.cmdDepart.UseVisualStyleBackColor = True
        '
        'lblPoint2
        '
        Me.lblPoint2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPoint2.AutoSize = True
        Me.lblPoint2.BackColor = System.Drawing.Color.Transparent
        Me.lblPoint2.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint2.ForeColor = System.Drawing.Color.White
        Me.lblPoint2.Location = New System.Drawing.Point(513, 10)
        Me.lblPoint2.Name = "lblPoint2"
        Me.lblPoint2.Size = New System.Drawing.Size(52, 60)
        Me.lblPoint2.TabIndex = 24
        Me.lblPoint2.Text = "0"
        '
        'lblPoint1
        '
        Me.lblPoint1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPoint1.AutoSize = True
        Me.lblPoint1.BackColor = System.Drawing.Color.Transparent
        Me.lblPoint1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint1.ForeColor = System.Drawing.Color.White
        Me.lblPoint1.Location = New System.Drawing.Point(311, 10)
        Me.lblPoint1.Name = "lblPoint1"
        Me.lblPoint1.Size = New System.Drawing.Size(52, 60)
        Me.lblPoint1.TabIndex = 23
        Me.lblPoint1.Text = "0"
        '
        'cmdPause
        '
        Me.cmdPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPause.Location = New System.Drawing.Point(254, 466)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(109, 34)
        Me.cmdPause.TabIndex = 37
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'tmrJoue
        '
        Me.tmrJoue.Interval = 40
        '
        'tmrAI
        '
        Me.tmrAI.Interval = 15
        '
        'lblFinit
        '
        Me.lblFinit.AutoSize = True
        Me.lblFinit.BackColor = System.Drawing.Color.Transparent
        Me.lblFinit.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinit.ForeColor = System.Drawing.Color.Lime
        Me.lblFinit.Location = New System.Drawing.Point(188, 143)
        Me.lblFinit.Name = "lblFinit"
        Me.lblFinit.Size = New System.Drawing.Size(0, 117)
        Me.lblFinit.TabIndex = 40
        '
        'frmPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pong2._0.My.Resources.Resources.Pong_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.lblFinit)
        Me.Controls.Add(Me.picPaddle2)
        Me.Controls.Add(Me.picPaddle1)
        Me.Controls.Add(Me.lblBeta)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.cmdRandomizer)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.lblJoueur2)
        Me.Controls.Add(Me.lblJoueur1)
        Me.Controls.Add(Me.cmdAssignationNom)
        Me.Controls.Add(Me.lblNom2)
        Me.Controls.Add(Me.lblNom1)
        Me.Controls.Add(Me.txtNom2)
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.lblTitreNom)
        Me.Controls.Add(Me.cmdRecommencer)
        Me.Controls.Add(Me.cmdDepart)
        Me.Controls.Add(Me.lblPoint2)
        Me.Controls.Add(Me.lblPoint1)
        Me.Controls.Add(Me.cmdPause)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 550)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "frmPrincipale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pong"
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBeta As Label
    Friend WithEvents picBall As PictureBox
    Friend WithEvents picPaddle1 As PictureBox
    Friend WithEvents picPaddle2 As PictureBox
    Friend WithEvents cmdQuitter As Button
    Friend WithEvents cmdRandomizer As Button
    Friend WithEvents lblChrono As Label
    Friend WithEvents lblJoueur2 As Label
    Friend WithEvents lblJoueur1 As Label
    Friend WithEvents cmdAssignationNom As Button
    Friend WithEvents lblNom2 As Label
    Friend WithEvents lblNom1 As Label
    Friend WithEvents txtNom2 As TextBox
    Friend WithEvents txtNom1 As TextBox
    Friend WithEvents lblTitreNom As Label
    Friend WithEvents cmdRecommencer As Button
    Friend WithEvents cmdDepart As Button
    Friend WithEvents lblPoint2 As Label
    Friend WithEvents lblPoint1 As Label
    Friend WithEvents cmdPause As Button
    Friend WithEvents tmrJoue As Timer
    Friend WithEvents tmrAI As Timer
    Friend WithEvents lblFinit As Label
End Class
