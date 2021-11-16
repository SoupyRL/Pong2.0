'Fichier Pong2.0.sln
'Programmation Visual Basic
'Ecrit par Duncan Campbell
'Créer le 17/05/30
'Dernier modification le 17/05/31

Public Class frmSelection
    Private Sub cmdPong_Click(sender As Object, e As EventArgs) Handles cmdPong.Click

        frmPong.Show()
        Me.Hide()
    End Sub

    Private Sub cmdSnake_Click(sender As Object, e As EventArgs) Handles cmdSnake.Click
        frmSnake.Show()

        Me.Hide()
    End Sub

    Private Sub cmdQuit_Click(sender As Object, e As EventArgs) Handles cmdQuit.Click

        Dim Question = MessageBox.Show("Es-tu certain de vouloir quitter?", "Es-tu certain?", MessageBoxButtons.YesNo)

        If Question = DialogResult.Yes Then
            Me.Close()
            frmPong.Close()
            frmSnake.Close()
        End If

    End Sub

    Private Sub frmSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
