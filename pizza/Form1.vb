Public Class Form1
    'ATTRIBUT
    Private currentState As State
    ' les compteurs des pizza
    Private cpt250gr As Integer
    Private cpt500gr As Integer
    Private cpt1000gr As Integer

    Private Sub InitDialogue()
        currentState = State.INIT
        ButtonPasserCommand.Enabled = False

        ' initialisation des compteurs de pizza
        cpt250gr = 0
        cpt500gr = 0
        cpt1000gr = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDialogue()
        currentState = State.COMMANDE_ENCOURS
    End Sub

    Private Sub addToResumeCommande()
    End Sub

End Class

