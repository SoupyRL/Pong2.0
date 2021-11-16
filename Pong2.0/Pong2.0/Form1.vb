'Fichier Pong2.0.sln
'Programmation Visual Basic
'Ecrit par Duncan Campbell
'Créer le 17/05/12
'Dernier modification le 17/05/31

REM Jeu de pong ou la ball vas de 1 cote a l'autre contre un AI ou une autre joueur
REM Jag vill dö
REM ^that statement remains true

'Autorisation de la conversion des types de données
Option Strict Off

'Précision que toutes les vairables doivent être déclarées explicetement
Option Explicit On


Public Class frmPrincipale

    Inherits System.Windows.Forms.Form

#Region "Variables Global"
    'Declaration des variables
    Dim strJoueur1 As String
    Dim strJoueur2 As String
    Dim intBall As Integer
    Dim coordBallon As Point
    Dim coordPaddle1 As Point
    Dim coordPaddle2 As Point
    Dim bteRandomize1 As Byte
    Dim TimeToEnd As Boolean
    Dim bteAI As Byte = 0
    Dim bteAI2 As Integer = 0
    Dim btePoint1 As Byte = 0
    Dim btePoint2 As Byte = 0
    Dim bteChrono As Byte = 3
    Dim bteAjoutVitesse As Byte = 0
    Dim intAIDifficulty1 As Integer
    Dim intAIDifficulty2 As Integer
    Dim intAIDifficulty3 As Integer
    Dim bteTick As Byte
    Dim Pause As Byte

    Dim sglVitesse As Single = 40                                       'Vitesse du ball avec une ajouteur
    Dim rndInst As New Random((85 - 1 + 1) * Rnd() + 20)                'Nombre choisi aléatoirement pour les rebondicement
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * sglVitesse     'Rebondicement du ball
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * sglVitesse     'Rebondicement du ball réversé

    Dim matriceDifficulty1(2) As Integer                                'Matrice pour la difficulté

    'Utilisation de user32.dll pour déplacement du curseur
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short

    Private Const KEY_TOGGLED As Short = &H1
    Private Const KEY_DOWN As Short = &H1000
#End Region

#Region "Forme Principale"
    'Action au commencement du jeu

    Private Sub frmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Rendre certain objets invisible
        picPaddle1.Visible = False
        picBall.Visible = False
        picPaddle2.Visible = False
        lblPoint1.Visible = False
        lblPoint2.Visible = False
        lblJoueur1.Visible = False
        lblJoueur2.Visible = False
        lblChrono.Visible = False
        cmdRandomizer.Visible = False
        cmdPause.Visible = False
        cmdDepart.Visible = False
        cmdRecommencer.Visible = False
        cmdQuitter.Visible = False

        'Assignation des coordonnées pour les "Paddle"
        coordPaddle1.Y = 198
        coordPaddle1.X = 12
        coordPaddle2.Y = 198
        coordPaddle2.X = 847

    End Sub
#End Region

#Region "Bouton d'Assigniation"
    'Action sur le bouton Assigniation des noms"
    Private Sub cmdAssignationNom_Click(sender As Object, e As EventArgs) Handles cmdAssignationNom.Click

        'Capture les noms
        strJoueur1 = txtNom1.Text
        strJoueur2 = txtNom2.Text

        'Démotre les nom au côté du jeu
        lblJoueur1.Text = strJoueur1.ToString
        lblJoueur2.Text = strJoueur2.ToString

        'Regarde si la deuxieme boite de text est vide 
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            bteAI = 1
        End If

        'Rendre certain objets visible
        picPaddle1.Visible = True
        picPaddle2.Visible = True
        lblPoint1.Visible = True
        lblPoint2.Visible = True
        lblJoueur1.Visible = True
        lblJoueur2.Visible = True
        cmdRandomizer.Visible = True

        'Garde/Rende certain objets invisible
        picBall.Visible = False
        lblTitreNom.Visible = False
        lblNom1.Visible = False
        lblNom2.Visible = False
        txtNom1.Visible = False
        txtNom2.Visible = False
        cmdAssignationNom.Visible = False
        cmdPause.Visible = False
        cmdRecommencer.Visible = False
        cmdDepart.Visible = False

        'Assign la location du ball au coordBallon
        picBall.Location = coordBallon

    End Sub
#End Region

#Region "Bouton Départ"
    'Action sur le bouton "Départ"
    Private Sub cmdDepart_Click(sender As Object, e As EventArgs) Handles cmdDepart.Click

        'Rende le bouton de Départ invisible
        cmdDepart.Visible = False
        'Rende le bouton Pause visible
        cmdPause.Visible = True

        'Réfrechie la programe
        Me.Show()
        Me.Refresh()

        'Commence le timer pour la jeu
        tmrJoue.Enabled = True

        'Commence la jeu
        TimeToEnd = False

        'Regarde si le deuxieme boite de text est vide, si oui commence le AI
        If bteAI = 1 Then

            tmrAI.Enabled = True
        End If

        'La mouvement des "Paddle" avec les clées "W, S" et "↑, ↓"
        Do
            'Mouvement pour la clé "W"
            If ((GetKeyState(System.Windows.Forms.Keys.W) And KEY_DOWN)) And (coordBallon.X >= 12) And (coordPaddle1.Y > 1) Then

                coordPaddle1.Y = (coordPaddle1.Y - 1)

                picPaddle1.Location = coordPaddle1
                picPaddle1.Refresh()

                'Mouvement pour la clé "S"
            ElseIf ((GetKeyState(System.Windows.Forms.Keys.S) And KEY_DOWN)) And (coordBallon.X >= 12) And (coordPaddle1.Y < 410) Then

                coordPaddle1.Y = (coordPaddle1.Y + 1)

                picPaddle1.Location = coordPaddle1
                picPaddle1.Refresh()
            Else

                'Aucune code
            End If

            'Mouvement pour la clé "↑"
            If ((GetKeyState(System.Windows.Forms.Keys.Up) And KEY_DOWN)) And (coordBallon.X >= 12) And (coordPaddle2.Y > 1) Or bteAI < 0 Then

                coordPaddle2.Y = (coordPaddle2.Y - 1)

                picPaddle2.Location = coordPaddle2
                picPaddle2.Refresh()

                'Mouvement pour la clé "↓"
            ElseIf ((GetKeyState(System.Windows.Forms.Keys.Down) And KEY_DOWN)) And (coordBallon.X >= 12) And (coordPaddle2.Y < 410) Or bteAI < 0 Then

                coordPaddle2.Y = (coordPaddle2.Y + 1)

                picPaddle2.Location = coordPaddle2
                picPaddle2.Refresh()

            Else

                'Aucune code 
            End If

            'Assure que les mouvements sont faites
            System.Windows.Forms.Application.DoEvents()

        Loop Until TimeToEnd

        'Réfraiche la jeux pour que les changement sont faites
        Me.Refresh()
    End Sub
#End Region

#Region "Timer Principale"
    Public Sub tmrJoue_Tick(sender As Object, e As EventArgs) Handles tmrJoue.Tick

        'Done la ball au côté qui là ressue aléatoirement
        If bteRandomize1 = 1 Then
            picBall.Location = New Point(picBall.Location.X + xVel, picBall.Location.Y + yVel)

        ElseIf bteRandomize1 = 2 Then
            picBall.Location = New Point(picBall.Location.X - xVel, picBall.Location.Y + yVel)

        Else

            'Aucune code
        End If


        'Haute Mur 
        If (picBall.Location.Y < 0) Then

            picBall.Location = New Point(picBall.Location.X, 0)
            yVel = -yVel

        ElseIf picBall.Location.Y > Me.Height - picBall.Size.Height - 45 Then
            picBall.Location = New Point(picBall.Location.X, Me.Height - picBall.Size.Height - 45)
            yVel = -yVel

            'Côté gauche
        ElseIf picBall.Location.X < -50 Then

            btePoint2 = btePoint2 + 1                            'Ajout une point
            lblPoint2.Text = btePoint2.ToString                  'Met les points sur la label
            lblPoint2.ForeColor = Color.White                    'Assure que la label est blanche
            picBall.Visible = False                              'Rende la ball invisible
            sglVitesse = 0                                       'Remettre la vitesse modification à 0

            'Assure la ballon garde sa vitesse
            picBall.Location = New Point(picBall.Location.X + xVel, picBall.Location.Y + yVel)

            'Regarde à les points pour voir juste qu'à 15
            If btePoint2 = 15 Then

                If bteAI = 1 Then
                    lblFinit.Text = "YOU LOSE!"                                                                                               'Message de perde contre le CPU
                    lblFinit.ForeColor = Color.Red                                                                                            'Change la couleur de text à rouge
                    lblFinit.Location = New Point((Me.Width / 2) - (lblFinit.Width / 2), (Me.Height / 2) - (lblFinit.Height / 2 + 50))        'Met la message center
                ElseIf bteAI = 0 Then
                    lblFinit.Text = strJoueur2 & " WINS"                                                                                      'Message de gagner pour la deuxième joueur
                    lblFinit.ForeColor = Color.Lime                                                                                           'Change la couleur de text à verte 
                    lblFinit.Location = New Point((Me.Width / 2) - (lblFinit.Width / 2), (Me.Height / 2) - (lblFinit.Height / 2 + 50))        'Met la message center
                Else

                End If

                'Arrête la jeu
                TimeToEnd = True
                tmrAI.Enabled = False
                tmrJoue.Enabled = False

            End If
            Me.Refresh()

            'Met la ball en avant du "Paddle"
            picBall.Location = New Point(34, picPaddle1.Location.Y - picPaddle1.Height / 10)

            'Conteur pour chaque but
            If btePoint2 < 15 Then
                lblChrono.Visible = True
                bteChrono = 3
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                System.Threading.Thread.Sleep(1000)
                bteChrono = bteChrono - 1
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                System.Threading.Thread.Sleep(1000)
                bteChrono = bteChrono - 1
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                System.Threading.Thread.Sleep(1000)
                bteChrono = bteChrono - 1
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                lblChrono.Visible = False

            End If
            picBall.Visible = True          'Remettre la ball come visible

            'But du droite
        ElseIf picBall.Location.X > 900 Then
            btePoint1 = btePoint1 + 1                       'Ajout point pour la joueur 1 
            lblPoint1.Text = btePoint1.ToString             'Affiche les points
            lblPoint1.ForeColor = Color.White               'Assure la couleurs du text est visible come blanche
            picBall.Visible = False                         'Rendre la ballon invisible 
            sglVitesse = 0                                  'Remettre la modification de vitesse à 0

            'Assure la ballon garde sa vitesse
            picBall.Location = New Point(picBall.Location.X - (xVel * -1), picBall.Location.Y + (yVel * -1))

            'Regard si les point sont à 15
            If btePoint1 = 15 Then

                If bteAI = 1 Then
                    lblFinit.Text = "YOU WIN!"                                                                                              'Message de gagner contre le CPU
                    lblFinit.ForeColor = Color.Lime                                                                                         'Change la couleur de text à verte
                    lblFinit.Location = New Point((Me.Width / 2) - (lblFinit.Width / 2), (Me.Height / 2) - (lblFinit.Height / 2 + 50))      'Met la message de gagner au centre du terrain

                ElseIf bteAI = 0 Then
                    lblFinit.Text = strJoueur1 + " WINS"                                                                                    'Message de gagner pour Joueur 1
                    lblFinit.ForeColor = Color.Lime                                                                                         'Change la couleur de text à verte
                    lblFinit.Location = New Point((Me.Width / 2) - (lblFinit.Width / 2), (Me.Height / 2) - (lblFinit.Height / 2 + 50))      'Met la message de gagner au centre du terrain

                End If

                'Arrête la jeu
                TimeToEnd = True
                tmrAI.Enabled = False
                tmrJoue.Enabled = False

            End If
            Me.Refresh()

            'Mettre la ballon en avant du "Paddle"
            picBall.Location = New Point(847, picPaddle2.Location.Y - picPaddle2.Height / 10)

            'Conteur pour chaque but
            If btePoint1 < 15 Then
                lblChrono.Visible = True
                bteChrono = 3
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                System.Threading.Thread.Sleep(1000)
                bteChrono = bteChrono - 1
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                System.Threading.Thread.Sleep(1000)
                bteChrono = bteChrono - 1
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                System.Threading.Thread.Sleep(1000)
                bteChrono = bteChrono - 1
                lblChrono.Text = bteChrono.ToString
                lblChrono.Refresh()
                lblChrono.Visible = False

            End If

            picBall.Visible = True          'Remettre la ball come visible

        Else

            'Aucune code
        End If

        'Code pour tester une "Feature"
        'lblBeta.Text = sglVitesse.ToString
        'lblBeta.Visible = True

        'Rebondicement sur les "Paddle"
        If picBall.Bounds.IntersectsWith(picPaddle1.Bounds) Then
            picBall.Location = New Point(picPaddle1.Location.X + picBall.Size.Width, picBall.Location.Y)            'Crée une nouvelle point pour la ball ou sa vas l'autre direction
            xVel = -xVel                                                                                            'Cause la ball d'aller l'autre direction

            sglVitesse = sglVitesse + 1                                                                             'Ajout la vitesse

        ElseIf picBall.Bounds.IntersectsWith(picPaddle2.Bounds) Then
            picBall.Location = New Point(picPaddle2.Location.X - picBall.Size.Width, picBall.Location.Y)            'Crée une nouvelle point pour la ball ou sa vas l'autre direction
            xVel = -xVel                                                                                            'Cause la ball d'aller l'autre direction

            sglVitesse = sglVitesse + 1                                                                             'Ajout la vitesse

        Else
            'Aucune code
        End If
    End Sub
#End Region

#Region "Bouton Randomizer"
    'Action sur la bouton "Démarreur aléatoire"
    Private Sub cmdRandomizer_Click(sender As Object, e As EventArgs) Handles cmdRandomizer.Click

        'Choisi un numéro aléatoirement
        Randomize()
        bteRandomize1 = Int((2 + 1 - 1) * Rnd() + 1)


        If (bteRandomize1 = 1) Then

            'Met la ball en avant du "Paddle"
            coordBallon.Y = 229
            coordBallon.X = 34

            picBall.Location = coordBallon              'Donnée les coord au ball

            'Rendre certain objets visible
            picBall.Visible = True
            cmdPause.Visible = True
            cmdDepart.Visible = True
            cmdRecommencer.Visible = True
            cmdQuitter.Visible = True

            'Rendre la bouton de "Démarreur aléatoire" invisible
            cmdRandomizer.Visible = False

        ElseIf (bteRandomize1 = 2) Then

            'Met la ball en avant du "Paddle"
            coordBallon.Y = 229
            coordBallon.X = 817

            picBall.Location = coordBallon              'Donnée les coord au ball

            'Rendre certain objets visible
            picBall.Visible = True
            cmdPause.Visible = True
            cmdDepart.Visible = True
            cmdRecommencer.Visible = True
            cmdQuitter.Visible = True

            'Rendre la bouton de "Démarreur aléatoire" invisible
            cmdRandomizer.Visible = False

        Else
            'Aucune Code
        End If

    End Sub
#End Region

#Region "Bouton Quitter"
    'Action sur la bouton "Quitter"
    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click

        'Déclare une boite de message
        Dim Question = MessageBox.Show("Are you sure you would like to quit?", "Are You Sure?", MessageBoxButtons.YesNo)

        'Arrête la jeu
        TimeToEnd = True
        tmrJoue.Enabled = False
        tmrAI.Enabled = False

        'Si la joueur sélectione 'Oui' la jeu ferme
        If (Question = DialogResult.Yes) Then

            Me.Close()
            frmSelection.Close()
            frmSnake.Close()

            'Si la joueur sélectione 'Non' la jeu commence au même place
        ElseIf (Question = DialogResult.No) Then

            TimeToEnd = False
            tmrAI.Enabled = True
            tmrJoue.Enabled = True
        End If

    End Sub
#End Region

#Region "Bouton Recommencer"
    'Action sur le bouton "Recommencer" 
    Private Sub cmdRecommencer_Click(sender As Object, e As EventArgs) Handles cmdRecommencer.Click

        'Arrête jeu qui joue
        tmrAI.Enabled = False
        tmrJoue.Enabled = False
        TimeToEnd = True

        'Delai pour que la code se fait pas exécuter tout en un moment
        System.Threading.Thread.Sleep(75)

        'Done la ball au personne qui avait ressu en premier

        If (bteRandomize1 = 1) Then

            'Donne les corodonnées au ballon
            coordBallon.Y = 229
            coordBallon.X = 34

            'Remettre les "Paddles" au milieu
            picPaddle2.Location = New Point(847, 199)
            picPaddle1.Location = New Point(12, 199)

            picBall.Location = coordBallon              'Donnée les coord au ball

            'Rendre certain objets visible
            picBall.Visible = True
            cmdPause.Visible = True
            cmdDepart.Visible = True
            cmdRecommencer.Visible = True
            cmdQuitter.Visible = True

            'Rendre la bouton de "Démarreur aléatoire" invisible
            cmdRandomizer.Visible = False

        ElseIf (bteRandomize1 = 2) Then

            'Donne les corodonnées au ballon
            coordBallon.Y = 229
            coordBallon.X = 817

            'Remettre les "Paddles" au milieu
            picPaddle2.Location = New Point(847, 199)
            picPaddle1.Location = New Point(12, 199)

            picBall.Location = coordBallon              'Donnée les coord au ball

            'Rendre certain objets visible
            picBall.Visible = True
            cmdPause.Visible = True
            cmdDepart.Visible = True
            cmdRecommencer.Visible = True
            cmdQuitter.Visible = True

            'Rendre la bouton de "Démarreur aléatoire" invisible
            cmdRandomizer.Visible = False

        Else
            'Aucune code
        End If

        'Remettre les points à 0
        btePoint1 = 0
        btePoint2 = 0
        lblPoint1.Text = btePoint1.ToString
        lblPoint2.Text = btePoint2.ToString

        'Rendre la bouton de départ visible
        cmdDepart.Visible = True

        'Rendre certain objets invisible
        cmdPause.Visible = False
        lblFinit.Visible = False
        lblFinit.Text = ""

    End Sub
#End Region

#Region "Timer AI"
    'Action sur la timer "AI"
    Private Sub tmrAI_Tick(sender As Object, e As EventArgs) Handles tmrAI.Tick
        If (bteAI = 1) Then
            'Choisi un numéro entre 1 et 1000 aléatoirement
            Randomize()
            bteAI2 = Int((1000 + 1 - 1) * Rnd() + 1)

            'Assign les coordonnées au ball
            coordBallon = picBall.Location
            coordPaddle2 = picPaddle2.Location
            coordPaddle1 = picPaddle1.Location

            'Choisi la matrice dépendent sur les points
            If btePoint2 >= btePoint1 Then
                matriceDifficulty1(0) = 1
            ElseIf btePoint1 - btePoint2 <= 0 Then
                matriceDifficulty1(0) = 1
            ElseIf btePoint1 - btePoint2 = 1 Then
                matriceDifficulty1(0) = 2
            ElseIf btePoint1 - btePoint2 = 2 Then
                matriceDifficulty1(0) = 3
            ElseIf btePoint1 - btePoint2 = 3 Then
                matriceDifficulty1(0) = 4
            ElseIf btePoint1 - btePoint2 = 4 Then
                matriceDifficulty1(0) = 5
            ElseIf btePoint1 - btePoint2 = 5 Then
                matriceDifficulty1(0) = 6
            ElseIf btePoint1 - btePoint2 = 6 Then
                matriceDifficulty1(0) = 7
            ElseIf btePoint1 - btePoint2 = 7 Then
                matriceDifficulty1(0) = 8
            ElseIf btePoint1 - btePoint2 = 8 Then
                matriceDifficulty1(0) = 9
            ElseIf btePoint1 - btePoint2 = 9 Then
                matriceDifficulty1(0) = 10
            ElseIf btePoint1 - btePoint2 = 10 Then
                matriceDifficulty1(0) = 11
            ElseIf btePoint1 - btePoint2 = 11 Then
                matriceDifficulty1(0) = 12
            ElseIf btePoint1 - btePoint2 = 12 Then
                matriceDifficulty1(0) = 13
            ElseIf btePoint1 - btePoint2 = 13 Then
                matriceDifficulty1(0) = 14
            ElseIf btePoint1 - btePoint2 = 14 Then
                matriceDifficulty1(0) = 15
            Else
                'Aucune Code
            End If

            'Choisi la matrice dépendent sur les points
            If btePoint2 >= btePoint1 Then
                matriceDifficulty1(1) = 1
            ElseIf btePoint1 - btePoint2 >= 0 Then
                matriceDifficulty1(1) = 1
            ElseIf btePoint1 - btePoint2 = 1 Then
                matriceDifficulty1(1) = 2
            ElseIf btePoint1 - btePoint2 = 2 Then
                matriceDifficulty1(1) = 3
            ElseIf btePoint1 - btePoint2 = 3 Then
                matriceDifficulty1(1) = 4
            ElseIf btePoint1 - btePoint2 = 4 Then
                matriceDifficulty1(1) = 5
            ElseIf btePoint1 - btePoint2 = 5 Then
                matriceDifficulty1(1) = 6
            ElseIf btePoint1 - btePoint2 = 6 Then
                matriceDifficulty1(1) = 7
            ElseIf btePoint1 - btePoint2 = 7 Then
                matriceDifficulty1(1) = 8
            ElseIf btePoint1 - btePoint2 = 8 Then
                matriceDifficulty1(1) = 9
            ElseIf btePoint1 - btePoint2 = 9 Then
                matriceDifficulty1(1) = 10
            ElseIf btePoint1 - btePoint2 = 10 Then
                matriceDifficulty1(1) = 11
            ElseIf btePoint1 - btePoint2 = 11 Then
                matriceDifficulty1(1) = 12
            ElseIf btePoint1 - btePoint2 = 12 Then
                matriceDifficulty1(1) = 13
            ElseIf btePoint1 - btePoint2 = 13 Then
                matriceDifficulty1(1) = 14
            ElseIf btePoint1 - btePoint2 = 14 Then
                matriceDifficulty1(1) = 15
            Else
                'Aucune code
            End If

            'Choisi la matrice dépendent sur les points
            If btePoint2 >= btePoint1 Then
                matriceDifficulty1(2) = 1
            ElseIf btePoint1 - btePoint2 >= 0 Then
                matriceDifficulty1(2) = 1
            ElseIf btePoint1 - btePoint2 = 1 Then
                matriceDifficulty1(2) = 2
            ElseIf btePoint1 - btePoint2 = 2 Then
                matriceDifficulty1(2) = 3
            ElseIf btePoint1 - btePoint2 = 3 Then
                matriceDifficulty1(2) = 4
            ElseIf btePoint1 - btePoint2 = 4 Then
                matriceDifficulty1(2) = 5
            ElseIf btePoint1 - btePoint2 = 5 Then
                matriceDifficulty1(2) = 6
            ElseIf btePoint1 - btePoint2 = 6 Then
                matriceDifficulty1(2) = 7
            ElseIf btePoint1 - btePoint2 = 7 Then
                matriceDifficulty1(2) = 8
            ElseIf btePoint1 - btePoint2 = 8 Then
                matriceDifficulty1(2) = 9
            ElseIf btePoint1 - btePoint2 = 9 Then
                matriceDifficulty1(2) = 10
            ElseIf btePoint1 - btePoint2 = 10 Then
                matriceDifficulty1(2) = 11
            ElseIf btePoint1 - btePoint2 = 11 Then
                matriceDifficulty1(2) = 12
            ElseIf btePoint1 - btePoint2 = 12 Then
                matriceDifficulty1(2) = 13
            ElseIf btePoint1 - btePoint2 = 13 Then
                matriceDifficulty1(2) = 14
            ElseIf btePoint1 - btePoint2 = 14 Then
                matriceDifficulty1(2) = 15
            Else
                'Aucune Code
            End If

            'Appel sur la fonction Difficulty()
            Difficulty()

            'Assign les variables au matrice
            intAIDifficulty1 = matriceDifficulty1(0)
            intAIDifficulty2 = matriceDifficulty1(1)
            intAIDifficulty3 = matriceDifficulty1(2)

            'Commencement de la A.I.
            If picBall.Location.Y > 5 And picBall.Location.Y <= Me.Height - 45 - picPaddle2.Height And coordBallon.X > 375 Then

                'Assez d'arrêter la ball
                If bteAI2 <= intAIDifficulty1 Then

                    'Change direction vers la haute
                    If coordBallon.Y > coordPaddle2.Y And picPaddle2.Location.Y < 900 Then

                        picPaddle2.Location = New Point(picPaddle2.Location.X, picPaddle2.Location.Y + 10)

                        'Change direction vers la bas
                    ElseIf picPaddle2.Location.Y > 0 Then

                        picPaddle2.Location = New Point(picPaddle2.Location.X, picPaddle2.Location.Y - 10)
                    Else
                        'Aucune code
                    End If

                    'Reste en place
                ElseIf bteAI2 > intAIDifficulty1 And bteAI2 <= intAIDifficulty2 Then
                    'Aucune Code

                    'Assez de manquer la ball
                ElseIf bteAI2 >= intAIDifficulty3 Then

                    'Change direction vers la haute
                    If coordBallon.Y > coordPaddle2.Y And picPaddle2.Location.Y <= 900 Then

                        picPaddle2.Location = New Point(picPaddle2.Location.X, picPaddle2.Location.Y - 12)

                        'Change direction vers la bas
                    ElseIf picPaddle2.Location.Y <= 920 Then

                        picPaddle2.Location = New Point(picPaddle2.Location.X, picPaddle2.Location.Y + 12)

                    Else
                        'Aucune code
                    End If
                End If
            Else
                'Aucune code
            End If
        End If
    End Sub
#End Region

#Region "MatriceDifficulté"
    'Sub pour énumérer les matrice pour l'A.I
    Sub Difficulty()

        'Sélection pour la nombre pour que l'A.I assez de frapper la ball
        Select Case matriceDifficulty1(0)
            Case 1 : matriceDifficulty1(0) = 500
            Case 2 : matriceDifficulty1(0) = 420
            Case 3 : matriceDifficulty1(0) = 500
            Case 4 : matriceDifficulty1(0) = 580
            Case 5 : matriceDifficulty1(0) = 660
            Case 6 : matriceDifficulty1(0) = 740
            Case 7 : matriceDifficulty1(0) = 820
            Case 8 : matriceDifficulty1(0) = 520
            Case 9 : matriceDifficulty1(0) = 900
            Case 10 : matriceDifficulty1(0) = 910
            Case 11 : matriceDifficulty1(0) = 920
            Case 12 : matriceDifficulty1(0) = 930
            Case 13 : matriceDifficulty1(0) = 940
            Case 14 : matriceDifficulty1(0) = 950
            Case 15 : matriceDifficulty1(0) = 975
        End Select

        'Sélection pour la nombre pour que l'A.I bouge pas
        Select Case matriceDifficulty1(1)
            Case 1 : matriceDifficulty1(1) = 580
            Case 2 : matriceDifficulty1(1) = 470
            Case 3 : matriceDifficulty1(1) = 580
            Case 4 : matriceDifficulty1(1) = 655
            Case 5 : matriceDifficulty1(1) = 735
            Case 6 : matriceDifficulty1(1) = 790
            Case 7 : matriceDifficulty1(1) = 870
            Case 8 : matriceDifficulty1(1) = 570
            Case 9 : matriceDifficulty1(1) = 950
            Case 10 : matriceDifficulty1(1) = 935
            Case 11 : matriceDifficulty1(1) = 945
            Case 12 : matriceDifficulty1(1) = 955
            Case 13 : matriceDifficulty1(1) = 965
            Case 14 : matriceDifficulty1(1) = 980
            Case 15 : matriceDifficulty1(1) = 985
        End Select

        'Sélection pour la nombre pour que l'A.I bouge à la direction opposé
        Select Case matriceDifficulty1(2)
            Case 1 : matriceDifficulty1(2) = 581
            Case 2 : matriceDifficulty1(2) = 471
            Case 3 : matriceDifficulty1(2) = 581
            Case 4 : matriceDifficulty1(2) = 656
            Case 5 : matriceDifficulty1(2) = 736
            Case 6 : matriceDifficulty1(2) = 791
            Case 7 : matriceDifficulty1(2) = 871
            Case 8 : matriceDifficulty1(2) = 571
            Case 9 : matriceDifficulty1(2) = 951
            Case 10 : matriceDifficulty1(2) = 936
            Case 11 : matriceDifficulty1(2) = 946
            Case 12 : matriceDifficulty1(2) = 956
            Case 13 : matriceDifficulty1(2) = 965
            Case 14 : matriceDifficulty1(2) = 981
            Case 15 : matriceDifficulty1(2) = 986
        End Select
    End Sub
#End Region

#Region "Bouton Pause"
    'Action sur la bouton "Pause"
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click
        'Arrêtage du jeu
        tmrAI.Enabled = False
        tmrJoue.Enabled = False
        TimeToEnd = True

        'Affichage du bouton de départ et rendre visible la bouton de "Pause"
        cmdPause.Visible = False
        cmdDepart.Visible = True
    End Sub
#End Region

End Class