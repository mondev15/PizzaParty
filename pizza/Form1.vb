Public Class Form1

    Dim currentState As State
    Dim currentPizza As Pizza
    '3 type de pizza
    Dim p1 As Pizza = New Pizza()
    Dim p2 As Pizza = New Pizza()
    Dim p3 As Pizza = New Pizza()


    Dim listPizza As New List(Of Pizza)

    Private Sub InitDialogue()
        currentState = State.INIT
        ButtonPasserCommand.Enabled = False
        'combobox
        DisableSizeComboBox()
        ' initialisation des quantité à 0
        initQuantity()
        ' personnalisation
        ComboBoxCuisson.Text = "Classique"
        ComboBoxPate.Text = "Fine"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDialogue()
    End Sub


#Region "selection de la pizza"

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox4Fromages.Click

        Select Case currentState
            Case State.INIT
                p1.CreatePizza("4Fromages", "undefined", "Bien Cuite", "Fine")
                Label4Fromages.BackColor = Color.LightBlue
                currentPizza = p1
                listPizza.Add(p1)
                currentState = State.COMMANDE_ENCOURS
                DisableBonPlanMargherita()
                EnableSizeComboBox()
                Debug.Print(currentState.ToString)
            Case State.COMMANDE_ENCOURS
                '
            Case State.CONSULTER_CATEGORIE
                '
            Case State.PASSER_COMMANDE
                '
            Case State.PERSONNALISER_COMMANDE
                p1.CreatePizza("4Fromages", "undefined", "Bien Cuite", "Fine")
                Label4Fromages.BackColor = Color.LightBlue
                listPizza.Add(p1)
                currentState = State.COMMANDE_ENCOURS
                DisableBonPlanMargherita()
                EnableSizeComboBox()
                Debug.Print(currentState.ToString)

        End Select

    End Sub

    Private Sub PictureBoxBonPlan_Click(sender As Object, e As EventArgs) Handles PictureBoxBonPlan.Click
        Select Case currentState
            Case State.INIT
                p2.CreatePizza("Bon Plan", "undefined", "Bien Cuite", "Fine")
                currentPizza = p2
                LabelBonplan.BackColor = Color.LightBlue
                listPizza.Add(p2)
                currentState = State.COMMANDE_ENCOURS
                Disable4FromagesMargherita()
                EnableSizeComboBox()
                '
            Case State.COMMANDE_ENCOURS
                '
            Case State.CONSULTER_CATEGORIE
                '
            Case State.PASSER_COMMANDE
                '
            Case State.PERSONNALISER_COMMANDE
                p2.CreatePizza("Bon Plan", "undefined", "Bien Cuite", "Fine")
                LabelBonplan.BackColor = Color.LightBlue
                currentPizza = p2
                initQuantity()
                listPizza.Add(p2)
                currentState = State.COMMANDE_ENCOURS
                Disable4FromagesMargherita()
                EnableSizeComboBox()
                TextBoxResume.AppendText(p1.ToString)
        End Select

    End Sub

    Private Sub PictureBoxMargherita_Click(sender As Object, e As EventArgs) Handles PictureBoxMargherita.Click
        Select Case currentState
            Case State.INIT
                p3.CreatePizza("Margherita", "undefined", "Bien Cuite", "Fine")
                LabelMargherita.BackColor = Color.LightBlue
                currentPizza = p3
                listPizza.Add(p3)
                currentState = State.COMMANDE_ENCOURS
                Disable4FromagesBonPlan()
                EnableSizeComboBox()
                'Debug.Print(currentState.ToString)
                '
            Case State.COMMANDE_ENCOURS
                '
            Case State.CONSULTER_CATEGORIE
                '
            Case State.PASSER_COMMANDE
                '
            Case State.PERSONNALISER_COMMANDE
                p3.CreatePizza("Margherita", "undefined", "Bien Cuite", "Fine")
                Label4Fromages.BackColor = Color.LightBlue
                currentPizza = p3
                initQuantity()
                listPizza.Add(p3)
                currentState = State.COMMANDE_ENCOURS
                Disable4FromagesBonPlan()
                EnableSizeComboBox()
        End Select
    End Sub


#End Region

#Region "selection Quantité"

    Private Sub ComboBoxSmall_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSmall.SelectedValueChanged

        Select Case currentState
            Case State.INIT
            Case State.COMMANDE_ENCOURS
                If (Not (ComboBoxSmall.Text.Equals("0"))) Then
                    p1.Taille = "Small"
                    TextBoxResume.AppendText(p1.Nom + " ( x " + ComboBoxSmall.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_ENCOURS
                    ButtonPasserCommand.Enabled = True
                End If
                UpdateTextBox()
            Case State.COMMANDE_SIZE
                UpdateTextBox()
            Case State.PERSONNALISER_COMMANDE
                UpdateTextBox()
            Case State.PASSER_COMMANDE
        End Select
    End Sub

    Private Sub ComboBoxMedium_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxMedium.SelectedValueChanged
        Select Case currentState
            Case State.INIT
            Case State.COMMANDE_ENCOURS
                If (Not (ComboBoxMedium.Text.Equals("0"))) Then
                    p1.Taille = "Medium"
                    TextBoxResume.AppendText(currentPizza.Nom + " ( x " + ComboBoxMedium.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_ENCOURS
                    ButtonPasserCommand.Enabled = True
                End If
                UpdateTextBox()
            Case State.COMMANDE_SIZE
                UpdateTextBox()
                currentState = State.COMMANDE_SIZE
            Case State.PERSONNALISER_COMMANDE
                UpdateTextBox()
                currentState = State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
    End Sub

    Private Sub ComboBoxLarge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLarge.SelectedIndexChanged
        Select Case currentState
            Case State.INIT
            Case State.COMMANDE_ENCOURS
                If (Not (ComboBoxLarge.Text.Equals("0"))) Then
                    p1.Taille = "Large"
                    TextBoxResume.AppendText(currentPizza.Nom + " ( x " + ComboBoxLarge.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_ENCOURS
                    ButtonPasserCommand.Enabled = True
                End If
                UpdateTextBox()
            Case State.COMMANDE_SIZE

                UpdateTextBox()
                currentState = State.COMMANDE_SIZE
            Case State.PERSONNALISER_COMMANDE
                UpdateTextBox()
                currentState = State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
    End Sub

#End Region


    Private Sub UpdateTextBox()
        TextBoxResume.Text = " "
        If (Not (ComboBoxSmall.Text.Equals("0"))) Then
            TextBoxResume.AppendText(currentPizza.Nom + " ( x " + ComboBoxSmall.Text + "  Small) ")
        ElseIf (ComboBoxSmall.Text.Equals("0")) Then
            TextBoxResume.AppendText(" ")
        End If

        If (Not (ComboBoxMedium.Text.Equals("0"))) Then
            TextBoxResume.AppendText(currentPizza.Nom + " ( x " + ComboBoxMedium.Text + "  Medium)")
            ButtonPasserCommand.Enabled = True
        Else
            TextBoxResume.AppendText(" ")
        End If
        If (Not (ComboBoxLarge.Text.Equals("0"))) Then
            TextBoxResume.AppendText(currentPizza.Nom + " ( x " + ComboBoxLarge.Text + "  Large)")
            ButtonPasserCommand.Enabled = True
        Else
            TextBoxResume.AppendText(" ")
        End If

        If (TextBoxResume.Text.Length <> 0) Then
            TextBoxResume.AppendText(Environment.NewLine + " Cuisson :" + ComboBoxCuisson.Text)
            TextBoxResume.AppendText(Environment.NewLine + " Pate :" + ComboBoxPate.Text)
            TextBoxResume.AppendText(Environment.NewLine + "-------------------")
        End If

    End Sub


#Region "activation selection de pizza"

    Private Sub EnableSizeComboBox()
        ComboBoxSmall.Enabled = True
        ComboBoxMedium.Enabled = True
        ComboBoxLarge.Enabled = True
    End Sub

    Private Sub DisableSizeComboBox()
        ComboBoxSmall.Enabled = False
        ComboBoxMedium.Enabled = False
        ComboBoxLarge.Enabled = False
    End Sub

    Private Sub DisableBonPlanMargherita()
        LabelBonplan.BackColor = Color.White
        LabelMargherita.BackColor = Color.White
    End Sub

    Private Sub Disable4FromagesBonPlan()
        LabelBonplan.BackColor = Color.White
        Label4Fromages.BackColor = Color.White
    End Sub

    Private Sub Disable4FromagesMargherita()
        LabelMargherita.BackColor = Color.White
        Label4Fromages.BackColor = Color.White
    End Sub

#End Region


#Region "Personnalisation"

    Private Sub ComboBoxCuisson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCuisson.SelectedIndexChanged

        Select Case currentState
            Case State.INIT
                '
            Case State.COMMANDE_ENCOURS
                p1.Cuisson = ComboBoxCuisson.Text
                currentState = State.PERSONNALISER_COMMANDE
                UpdateTextBox()
            Case State.COMMANDE_SIZE
                currentState = State.PERSONNALISER_COMMANDE
                p1.Cuisson = ComboBoxCuisson.Text
                UpdateTextBox()
            Case State.PERSONNALISER_COMMANDE
                UpdateTextBox()
                currentState = State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
        p1.Cuisson = ComboBoxCuisson.Text
    End Sub

    Private Sub ComboBoxPate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPate.SelectedIndexChanged
        Select Case currentState
            Case State.INIT
                '
            Case State.COMMANDE_ENCOURS
                currentState = State.PERSONNALISER_COMMANDE
                p1.Pate = ComboBoxPate.Text
                UpdateTextBox()
            Case State.COMMANDE_SIZE
                currentState = State.PERSONNALISER_COMMANDE
                p1.Pate = ComboBoxPate.Text
                UpdateTextBox()
            Case State.PERSONNALISER_COMMANDE
                currentState = State.PERSONNALISER_COMMANDE
                p1.Pate = ComboBoxPate.Text
                UpdateTextBox()
            Case State.PASSER_COMMANDE
        End Select
        p1.Pate = ComboBoxPate.Text
    End Sub

#End Region

    Private Sub initQuantity()
        ComboBoxSmall.Text = "0"
        ComboBoxMedium.Text = "0"
        ComboBoxLarge.Text = "0"
    End Sub

End Class

