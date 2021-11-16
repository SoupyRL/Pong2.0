'Fichier Pong2.0.sln
'Programmation Visual Basic
'Ecrit par Duncan Campbell
'Créer le 17/06/1
'Dernier modification le 17/06/1

Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.Keys


Public Class frmSnake

    Inherits System.Windows.Forms.Form

    Dim coordSnake As Point
    Dim TimeToEnd As Boolean
    Dim lngChrono As Long
    Dim intPoint As Integer
    Dim intNombre1 As Integer
    Dim intNombre2 As Integer
    Dim intNombre3 As Integer
    Dim intNombre4 As Integer
    Dim intNombre5 As Integer
    Dim intNombre6 As Integer
    Dim intNombre7 As Integer
    Dim intNombre8 As Integer
    Dim intNombre9 As Integer
    Dim intNombre10 As Integer
    Dim intNombre11 As Integer
    Dim intNombre12 As Integer
    Dim intNombre13 As Integer
    Dim intNombre14 As Integer
    Dim intNombre15 As Integer
    Dim intNombre16 As Integer
    Dim Longer(0) As Integer
    Dim bteLonger1 As Byte = 0

    'Utilisation de user32.dll pour déplacement du curseur
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short

    Private Const KEY_TOGGLED As Short = &H1
    Private Const KEY_DOWN As Short = &H1000

    Private Sub frmSnake_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblChrono.Visible = False
        lblPoint.Visible = False
        picSnakeHead.Visible = False
        picPomme1.Visible = False
        picPomme2.Visible = False
        picPomme3.Visible = False
        picPomme4.Visible = False
        picPomme5.Visible = False
        picPomme6.Visible = False
        picPomme7.Visible = False
        picPomme8.Visible = False
        picSnake1.Visible = False
        picSnake2.Visible = False
        picSnake3.Visible = False
        picSnake4.Visible = False
        picSnake5.Visible = False
        picSnake6.Visible = False
        picSnake7.Visible = False
        picSnake8.Visible = False
        picSnake9.Visible = False
        picSnake10.Visible = False
        picSnake11.Visible = False
        picSnake12.Visible = False
        picSnake13.Visible = False
        picSnake14.Visible = False
        picSnake15.Visible = False
        picSnake16.Visible = False
        picSnake17.Visible = False
        picSnake18.Visible = False
        picSnake19.Visible = False
        picSnake20.Visible = False

        KeyPreview = True

    End Sub

    Private Sub cmdCommencer_Click(sender As Object, e As EventArgs) Handles cmdCommencer.Click

        coordSnake = New Point(Me.Width / 2, Me.Height / 2)
        tmrJoue.Enabled = True
        tmrSnake.Enabled = True
        tmrChrono.Enabled = True

        cmdCommencer.Visible = False
        cmdQuitter.Height = 35
        cmdQuitter.Width = 110
        cmdQuitter.Location = New Point(674, 24)

        lblPoint.Visible = True
        lblChrono.Visible = True

        picSnakeHead.Location = New Point(Me.Width / 2, Me.Height / 2)
        picSnakeHead.Visible = True



        Randomize()
        intNombre1 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre2 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme1.Location = New Point(intNombre1, intNombre2)
        picPomme1.Visible = True

        Randomize()
        intNombre3 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre4 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme2.Location = New Point(intNombre3, intNombre4)
        picPomme2.Visible = True

        Randomize()
        intNombre5 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre6 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme3.Location = New Point(intNombre5, intNombre6)
        picPomme3.Visible = True

        Randomize()
        intNombre7 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre8 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme4.Location = New Point(intNombre7, intNombre8)
        picPomme4.Visible = True

        Randomize()
        intNombre9 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre10 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme5.Location = New Point(intNombre9, intNombre10)
        picPomme5.Visible = True

        Randomize()
        intNombre11 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre12 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme6.Location = New Point(intNombre11, intNombre12)
        picPomme6.Visible = True

        Randomize()
        intNombre13 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre14 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme7.Location = New Point(intNombre13, intNombre14)
        picPomme7.Visible = True

        Randomize()
        intNombre15 = Int((940 + 1 - 1) * Rnd() + 10)
        Randomize()
        intNombre16 = Int((450 + 1 - 1) * Rnd() + 30)

        picPomme8.Location = New Point(intNombre15, intNombre16)
        picPomme8.Visible = True


    End Sub



    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click

        tmrJoue.Enabled = False
        TimeToEnd = True
        tmrSnake.Enabled = False
        tmrChrono.Enabled = False
        Me.Close()
        frmPong.Close()
        frmSelection.Close()



        Dim Question = MessageBox.Show("Es-tu certain de vouloir quitter?", "Es-tu certain?", MessageBoxButtons.YesNo)

        tmrJoue.Enabled = False
        TimeToEnd = True
        tmrSnake.Enabled = False
        tmrChrono.Enabled = False

        If (Question = DialogResult.Yes) Then
            Me.Close()
            frmSelection.Close()
            frmPong.Close()

        ElseIf (Question = DialogResult.No) Then
            tmrJoue.Enabled = True
            TimeToEnd = False
            tmrSnake.Enabled = True
            tmrChrono.Enabled = True

        Else

        End If

    End Sub

    Private Sub tmrJoue_Tick(sender As Object, e As EventArgs) Handles tmrJoue.Tick

        If bteLonger1 = 1 Then
            Longer(0) = 1
        ElseIf bteLonger1 = 2 Then
            Longer(0) = 2
        ElseIf bteLonger1 = 3 Then
            Longer(0) = 3
        ElseIf bteLonger1 = 4 Then
            Longer(0) = 4
        ElseIf bteLonger1 = 5 Then
            Longer(0) = 5
        ElseIf bteLonger1 = 6 Then
            Longer(0) = 6
        ElseIf bteLonger1 = 7 Then
            Longer(0) = 7
        ElseIf bteLonger1 = 8 Then
            Longer(0) = 8
        ElseIf bteLonger1 = 9 Then
            Longer(0) = 9
        ElseIf bteLonger1 = 10 Then
            Longer(0) = 10
        ElseIf bteLonger1 = 11 Then
            Longer(0) = 11
        ElseIf bteLonger1 = 12 Then
            Longer(0) = 12
        ElseIf bteLonger1 = 13 Then
            Longer(0) = 13
        ElseIf bteLonger1 = 14 Then
            Longer(0) = 14
        ElseIf bteLonger1 = 15 Then
            Longer(0) = 15
        ElseIf bteLonger1 = 16 Then
            Longer(0) = 16
        ElseIf bteLonger1 = 17 Then
            Longer(0) = 17
        ElseIf bteLonger1 = 18 Then
            Longer(0) = 18
        ElseIf bteLonger1 = 19 Then
            Longer(0) = 19
        ElseIf bteLonger1 = 20 Then
            Longer(0) = 20
        Else
            Longer(0) = 0
        End If

        SnakeLonger()

        Longer(0) = bteLonger1

        If picSnakeHead.Bounds.IntersectsWith(picPomme1.Bounds) Then

            Randomize()
            intNombre1 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre2 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme1.Location = New Point(intNombre1, intNombre2)
            picPomme1.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1

        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme2.Bounds) Then
            Randomize()
            intNombre3 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre4 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme2.Location = New Point(intNombre3, intNombre4)
            picPomme2.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1

        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme3.Bounds) Then
            Randomize()
            intNombre5 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre6 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme3.Location = New Point(intNombre5, intNombre6)
            picPomme3.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1


        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme4.Bounds) Then
            Randomize()
            intNombre7 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre8 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme4.Location = New Point(intNombre7, intNombre8)
            picPomme4.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1

        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme5.Bounds) Then
            Randomize()
            intNombre9 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre10 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme5.Location = New Point(intNombre9, intNombre10)
            picPomme5.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1


        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme6.Bounds) Then
            Randomize()
            intNombre11 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre12 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme6.Location = New Point(intNombre11, intNombre12)
            picPomme6.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1

        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme7.Bounds) Then
            Randomize()
            intNombre13 = Int((+1 - 1) * Rnd() + 10)
            Randomize()
            intNombre14 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme7.Location = New Point(intNombre13, intNombre14)
            picPomme7.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1

        ElseIf picSnakeHead.Bounds.IntersectsWith(picPomme8.Bounds) Then
            Randomize()
            intNombre15 = Int((940 + 1 - 1) * Rnd() + 10)
            Randomize()
            intNombre16 = Int((450 + 1 - 1) * Rnd() + 30)

            picPomme8.Location = New Point(intNombre15, intNombre16)
            picPomme8.Visible = True
            intPoint = intPoint + 1
            lblPoint.Text = "Points : " + intPoint.ToString
            bteLonger1 = bteLonger1 + 1

        Else

        End If



    End Sub

    Private Sub tmrSnake_Tick(sender As Object, e As EventArgs) Handles tmrSnake.Tick

        'La mouvement des "Paddle" avec les clées "W, S" et "↑, ↓"
        Do
            'Mouvement pour la clé "Left"
            If ((GetKeyState(System.Windows.Forms.Keys.Left) And KEY_DOWN) And picSnakeHead.Location.X >= 0) Then

                coordSnake.X = (coordSnake.X - 1)
                picSnakeHead.Location = coordSnake
                System.Threading.Thread.Sleep(6)
                If KeyPreview = Up Then

                    picSnake1.Location = New Point(picSnakeHead.Location.X, picSnakeHead.Location.Y - 25)
                    Threading.Thread.Sleep(5)
                    picSnake1.Location = New Point(picSnakeHead.Location.X + 25, picSnakeHead.Location.Y)



                End If
                picSnake2.Location = New Point(picSnake1.Location.X + 25, picSnake1.Location.Y)
                picSnake3.Location = New Point(picSnake2.Location.X + 25, picSnake2.Location.Y)
                picSnake4.Location = New Point(picSnake3.Location.X + 25, picSnake3.Location.Y)
                picSnake5.Location = New Point(picSnake4.Location.X + 25, picSnake4.Location.Y)
                picSnake6.Location = New Point(picSnake5.Location.X + 25, picSnake5.Location.Y)
                picSnake7.Location = New Point(picSnake6.Location.X + 25, picSnake6.Location.Y)
                picSnake8.Location = New Point(picSnake7.Location.X + 25, picSnake7.Location.Y)
                picSnake9.Location = New Point(picSnake8.Location.X + 25, picSnake8.Location.Y)
                picSnake10.Location = New Point(picSnake9.Location.X + 25, picSnake9.Location.Y)
                picSnake11.Location = New Point(picSnake10.Location.X + 25, picSnake10.Location.Y)
                picSnake12.Location = New Point(picSnake11.Location.X + 25, picSnake11.Location.Y)
                picSnake13.Location = New Point(picSnake12.Location.X + 25, picSnake12.Location.Y)
                picSnake14.Location = New Point(picSnake13.Location.X + 25, picSnake13.Location.Y)
                picSnake15.Location = New Point(picSnake14.Location.X + 25, picSnake14.Location.Y)
                picSnake16.Location = New Point(picSnake15.Location.X + 25, picSnake15.Location.Y)
                picSnake17.Location = New Point(picSnake16.Location.X + 25, picSnake16.Location.Y)
                picSnake18.Location = New Point(picSnake17.Location.X + 25, picSnake17.Location.Y)
                picSnake19.Location = New Point(picSnake18.Location.X + 25, picSnake18.Location.Y)
                picSnake20.Location = New Point(picSnake19.Location.X + 25, picSnake19.Location.Y)

                'Mouvement pour la clé "Right"
            ElseIf ((GetKeyState(System.Windows.Forms.Keys.Right) And KEY_DOWN) And (picSnakeHead.Location.X <= 980 - (picSnakeHead.Width + 15))) Then
                coordSnake.X = (coordSnake.X + 1)
                picSnakeHead.Location = coordSnake
                System.Threading.Thread.Sleep(6)
                picSnake1.Location = New Point(picSnakeHead.Location.X - 25, picSnakeHead.Location.Y)
                picSnake2.Location = New Point(picSnake1.Location.X - 25, picSnake1.Location.Y)
                picSnake3.Location = New Point(picSnake2.Location.X - 25, picSnake2.Location.Y)
                picSnake4.Location = New Point(picSnake3.Location.X - 25, picSnake3.Location.Y)
                picSnake5.Location = New Point(picSnake4.Location.X - 25, picSnake4.Location.Y)
                picSnake6.Location = New Point(picSnake5.Location.X - 25, picSnake5.Location.Y)
                picSnake7.Location = New Point(picSnake6.Location.X - 25, picSnake6.Location.Y)
                picSnake8.Location = New Point(picSnake7.Location.X - 25, picSnake7.Location.Y)
                picSnake9.Location = New Point(picSnake8.Location.X - 25, picSnake8.Location.Y)
                picSnake10.Location = New Point(picSnake9.Location.X - 25, picSnake9.Location.Y)
                picSnake11.Location = New Point(picSnake10.Location.X - 25, picSnake10.Location.Y)
                picSnake12.Location = New Point(picSnake11.Location.X - 25, picSnake11.Location.Y)
                picSnake13.Location = New Point(picSnake12.Location.X - 25, picSnake12.Location.Y)
                picSnake14.Location = New Point(picSnake13.Location.X - 25, picSnake13.Location.Y)
                picSnake15.Location = New Point(picSnake14.Location.X - 25, picSnake14.Location.Y)
                picSnake16.Location = New Point(picSnake15.Location.X - 25, picSnake15.Location.Y)
                picSnake17.Location = New Point(picSnake16.Location.X - 25, picSnake16.Location.Y)
                picSnake18.Location = New Point(picSnake17.Location.X - 25, picSnake17.Location.Y)
                picSnake19.Location = New Point(picSnake18.Location.X - 25, picSnake18.Location.Y)
                picSnake20.Location = New Point(picSnake19.Location.X - 25, picSnake19.Location.Y)


                'Mouvement pour la clé "↑"
            ElseIf ((GetKeyState(System.Windows.Forms.Keys.Up) And KEY_DOWN) And (picSnakeHead.Location.Y > 0)) Then

                coordSnake.Y = (coordSnake.Y - 1)
                picSnakeHead.Location = coordSnake
                System.Threading.Thread.Sleep(6)
                picSnake1.Location = New Point(picSnakeHead.Location.X, picSnakeHead.Location.Y + 25)
                picSnake2.Location = New Point(picSnake1.Location.X, picSnake1.Location.Y + 25)
                picSnake3.Location = New Point(picSnake2.Location.X, picSnake2.Location.Y + 25)
                picSnake4.Location = New Point(picSnake3.Location.X, picSnake3.Location.Y + 25)
                picSnake5.Location = New Point(picSnake4.Location.X, picSnake4.Location.Y + 25)
                picSnake6.Location = New Point(picSnake5.Location.X, picSnake5.Location.Y + 25)
                picSnake7.Location = New Point(picSnake6.Location.X, picSnake6.Location.Y + 25)
                picSnake8.Location = New Point(picSnake7.Location.X, picSnake7.Location.Y + 25)
                picSnake9.Location = New Point(picSnake8.Location.X, picSnake8.Location.Y + 25)
                picSnake10.Location = New Point(picSnake9.Location.X, picSnake9.Location.Y + 25)
                picSnake11.Location = New Point(picSnake10.Location.X, picSnake10.Location.Y + 25)
                picSnake12.Location = New Point(picSnake11.Location.X, picSnake11.Location.Y + 25)
                picSnake13.Location = New Point(picSnake12.Location.X, picSnake12.Location.Y + 25)
                picSnake14.Location = New Point(picSnake13.Location.X, picSnake13.Location.Y + 25)
                picSnake15.Location = New Point(picSnake14.Location.X, picSnake14.Location.Y + 25)
                picSnake16.Location = New Point(picSnake15.Location.X, picSnake15.Location.Y + 25)
                picSnake17.Location = New Point(picSnake16.Location.X, picSnake16.Location.Y + 25)
                picSnake18.Location = New Point(picSnake17.Location.X, picSnake17.Location.Y + 25)
                picSnake19.Location = New Point(picSnake18.Location.X, picSnake18.Location.Y + 25)
                picSnake20.Location = New Point(picSnake19.Location.X, picSnake19.Location.Y + 25)
                'Mouvement pour la clé "↓"
            ElseIf ((GetKeyState(System.Windows.Forms.Keys.Down) And KEY_DOWN) And (picSnakeHead.Location.Y <= 518 - (picSnakeHead.Height + 40))) Then

                coordSnake.Y = (coordSnake.Y + 1)
                picSnakeHead.Location = coordSnake
                System.Threading.Thread.Sleep(6)
                picSnake1.Location = New Point(picSnakeHead.Location.X, picSnakeHead.Location.Y - 25)
                picSnake2.Location = New Point(picSnake1.Location.X, picSnake1.Location.Y - 25)
                picSnake3.Location = New Point(picSnake2.Location.X, picSnake2.Location.Y - 25)
                picSnake4.Location = New Point(picSnake3.Location.X, picSnake3.Location.Y - 25)
                picSnake5.Location = New Point(picSnake4.Location.X, picSnake4.Location.Y - 25)
                picSnake6.Location = New Point(picSnake5.Location.X, picSnake5.Location.Y - 25)
                picSnake7.Location = New Point(picSnake6.Location.X, picSnake6.Location.Y - 25)
                picSnake8.Location = New Point(picSnake7.Location.X, picSnake7.Location.Y - 25)
                picSnake9.Location = New Point(picSnake8.Location.X, picSnake8.Location.Y - 25)
                picSnake10.Location = New Point(picSnake9.Location.X, picSnake9.Location.Y - 25)
                picSnake11.Location = New Point(picSnake10.Location.X, picSnake10.Location.Y - 25)
                picSnake12.Location = New Point(picSnake11.Location.X, picSnake11.Location.Y - 25)
                picSnake13.Location = New Point(picSnake12.Location.X, picSnake12.Location.Y - 25)
                picSnake14.Location = New Point(picSnake13.Location.X, picSnake13.Location.Y - 25)
                picSnake15.Location = New Point(picSnake14.Location.X, picSnake14.Location.Y - 25)
                picSnake16.Location = New Point(picSnake15.Location.X, picSnake15.Location.Y - 25)
                picSnake17.Location = New Point(picSnake16.Location.X, picSnake16.Location.Y - 25)
                picSnake18.Location = New Point(picSnake17.Location.X, picSnake17.Location.Y - 25)
                picSnake19.Location = New Point(picSnake18.Location.X, picSnake18.Location.Y - 25)
                picSnake20.Location = New Point(picSnake19.Location.X, picSnake19.Location.Y - 25)



                If Keys.Right = KEY_DOWN Then

                    SendKeys.Send("{DOWN}")

                ElseIf Keys.Left = KEY_DOWN Then

                    SendKeys.Send("{DOWN}")

                ElseIf Keys.Right = KEY_DOWN Then

                    SendKeys.Send("{DOWN}")
                Else

                End If

            Else
                'Aucune code 
            End If

            'Assure que les mouvements sont faites
            System.Windows.Forms.Application.DoEvents()

            picSnakeHead.Location = coordSnake
            picSnakeHead.Refresh()

        Loop Until TimeToEnd

    End Sub

    Private Sub tmrChrono_Tick(sender As Object, e As EventArgs) Handles tmrChrono.Tick

        lngChrono = lngChrono + 1
        lblChrono.Text = "Chrono : " + lngChrono.ToString + " Sec"

    End Sub

    Sub Pause(ByVal seconds As Integer)

        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub tmrPause_Tick(sender As Object, e As EventArgs) Handles tmrPause.Tick

        tmrJoue.Enabled = True
        Threading.Thread.Sleep(5)
        tmrPause.Enabled = False

    End Sub

    Sub SnakeLonger()
        Select Case Longer(0)
            Case 1 : picSnake1.Visible = True
            Case 2 : picSnake2.Visible = True
            Case 3 : picSnake3.Visible = True
            Case 4 : picSnake4.Visible = True
            Case 5 : picSnake5.Visible = True
            Case 6 : picSnake6.Visible = True
            Case 7 : picSnake7.Visible = True
            Case 8 : picSnake8.Visible = True
            Case 9 : picSnake9.Visible = True
            Case 10 : picSnake10.Visible = True
            Case 11 : picSnake11.Visible = True
            Case 12 : picSnake12.Visible = True
            Case 13 : picSnake13.Visible = True
            Case 14 : picSnake14.Visible = True
            Case 15 : picSnake15.Visible = True
            Case 16 : picSnake16.Visible = True
            Case 17 : picSnake17.Visible = True
            Case 18 : picSnake18.Visible = True
            Case 19 : picSnake19.Visible = True
            Case 20 : picSnake20.Visible = True
        End Select
    End Sub
End Class