Public Class Form1

    Dim currentState As State
    Dim currentPizza As Pizza
    '3 type de pizza
    Dim p1 As Pizza = New Pizza()
    Dim p2 As Pizza = New Pizza()
    Dim p3 As Pizza = New Pizza()

    Dim comman As String = " "

    Dim listPizza As New List(Of Pizza)

    Private Sub InitDialogue()
        currentState = State.INIT
        ButtonPasserCommand.Enabled = False
        'combobox
        DisableSizeComboBox()
        ' initialisation des quantité à 0
        initQuantity()
        ' personnalisation
        ComboBoxCuisson.Text = " "
        ComboBoxPate.Text = " "
        ComboBoxCuisson.Enabled = True
        ComboBoxPate.Enabled = True
        DisableSizeComboBox()
        Label4Fromages.BackColor = Color.White
        LabelBonplan.BackColor = Color.White
        LabelMargherita.BackColor = Color.White
        TextBoxResume.Text = ""
        ToolTip1.SetToolTip(ButtonConsulter1, "tomates, oignons, poivrons" + Environment.NewLine + "champignons
huile d’olive" + Environment.NewLine + "sel, poivre et épices")
        ToolTip2.SetToolTip(ButtonConsulter2, "maïs,courgettes,tofu" + Environment.NewLine + "brocolis
        " + Environment.NewLine + "tomates en rondelle")

        ToolTip3.SetToolTip(ButtonConsulter3, "bûche de chèvre,tomates" + Environment.NewLine + "lardons,parmesan")
        ToolTip4.SetToolTip(Button1, " d'oignons pelés,olives noires" + Environment.NewLine + "filets d'anchois,tomates")

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
                DisableBonPlanMargherita()
                EnableSizeComboBox()
                currentState = State.COMMANDE_ENCOURS
                'Debug.Print(currentState.ToString)
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
                currentPizza = p1
                DisableBonPlanMargherita()
                EnableSizeComboBox()
                currentState = State.COMMANDE_ENCOURS
                initQuantity()
                initCuissonPate()
                'Debug.Print(currentState.ToString)

        End Select

    End Sub

    Private Sub PictureBoxBonPlan_Click(sender As Object, e As EventArgs) Handles PictureBoxBonPlan.Click
        Select Case currentState
            Case State.INIT
                p2.CreatePizza("Bon Plan", "undefined", "Bien Cuite", "Fine")
                currentPizza = p2
                LabelBonplan.BackColor = Color.LightBlue
                listPizza.Add(p2)
                Disable4FromagesMargherita()
                EnableSizeComboBox()
                currentState = State.COMMANDE_ENCOURS
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
                listPizza.Add(p2)
                currentPizza = p2
                Disable4FromagesMargherita()
                EnableSizeComboBox()
                currentState = State.COMMANDE_ENCOURS
                initQuantity()
                initCuissonPate()
        End Select

    End Sub

    Private Sub PictureBoxMargherita_Click(sender As Object, e As EventArgs) Handles PictureBoxMargherita.Click
        Select Case currentState
            Case State.INIT
                p3.CreatePizza("Margherita", "undefined", "Bien Cuite", "Fine")
                LabelMargherita.BackColor = Color.LightBlue
                listPizza.Add(p3)
                currentPizza = p3
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
                LabelMargherita.BackColor = Color.LightBlue
                listPizza.Add(p3)
                currentPizza = p3
                currentState = State.COMMANDE_ENCOURS

                Disable4FromagesBonPlan()
                EnableSizeComboBox()
                initQuantity()
                initCuissonPate()
        End Select
    End Sub

#End Region

#Region "selection Quantité"

    Private Sub ComboBoxSmall_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSmall.SelectedValueChanged

        Select Case currentState
            Case State.INIT
            Case State.COMMANDE_ENCOURS
                If (Not (ComboBoxSmall.Text.Equals("0"))) Then
                    currentPizza.Taille = "Small"
                    TextBoxResume.AppendText(Environment.NewLine + currentPizza.Nom + " ( x " + ComboBoxSmall.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_SIZE
                End If
                ComboBoxSmall.Enabled = False
            Case State.COMMANDE_SIZE
                If (Not (ComboBoxSmall.Text.Equals("0"))) Then
                    currentPizza.Taille = "Small"
                    TextBoxResume.AppendText(Environment.NewLine + currentPizza.Nom + " ( x " + ComboBoxSmall.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_SIZE
                Else
                    currentState = State.COMMANDE_ENCOURS
                End If
                ComboBoxSmall.Enabled = False

            Case State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
    End Sub

    Private Sub ComboBoxMedium_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxMedium.SelectedValueChanged
        Select Case currentState
            Case State.INIT
            Case State.COMMANDE_ENCOURS
                If (Not (ComboBoxMedium.Text.Equals("0"))) Then
                    currentPizza.Taille = "Medium"
                    TextBoxResume.AppendText(Environment.NewLine + currentPizza.Nom + " ( x " + ComboBoxMedium.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_SIZE
                End If
                ComboBoxMedium.Enabled = False
            Case State.COMMANDE_SIZE
                If (Not (ComboBoxMedium.Text.Equals("0"))) Then
                    currentPizza.Taille = "Medium"
                    TextBoxResume.AppendText(Environment.NewLine + currentPizza.Nom + " ( x " + ComboBoxMedium.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_SIZE
                Else
                    currentState = State.COMMANDE_ENCOURS
                End If
                ComboBoxMedium.Enabled = False
            Case State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
    End Sub

    Private Sub ComboBoxLarge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLarge.SelectedIndexChanged
        Select Case currentState
            Case State.INIT
            Case State.COMMANDE_ENCOURS
                If (Not (ComboBoxLarge.Text.Equals("0"))) Then
                    currentPizza.Taille = "Large"
                    TextBoxResume.AppendText(Environment.NewLine + currentPizza.Nom + " ( x " + ComboBoxLarge.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_SIZE

                End If
                ComboBoxLarge.Enabled = False
            Case State.COMMANDE_SIZE
                If (Not (ComboBoxLarge.Text.Equals("0"))) Then
                    currentPizza.Taille = "Large"
                    TextBoxResume.AppendText(Environment.NewLine + currentPizza.Nom + " ( x " + ComboBoxLarge.Text + " " + currentPizza.Taille + ")")
                    currentState = State.COMMANDE_SIZE
                Else
                    currentState = State.COMMANDE_ENCOURS
                End If
                ComboBoxLarge.Enabled = False
            Case State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
    End Sub

#End Region


    Private Sub UpdateNumber(number As String)
        Dim newLine As String = " "

        For Each line In TextBoxResume.Lines

            If (line.Contains(currentPizza.Nom) And line.Contains(currentPizza.Taille)) Then
                If (Not number.Equals("0")) Then
                    newLine = currentPizza.Nom + "( x " + number + " " + currentPizza.Taille + ")"
                    If (Not (TextBoxResume.Text.Contains(newLine))) Then
                        TextBoxResume.Text = TextBoxResume.Text.Replace(line, newLine)
                    End If
                Else
                    TextBoxResume.Text = TextBoxResume.Text.Replace(line, " ")
                End If
            End If
        Next

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
                currentPizza.Cuisson = ComboBoxCuisson.Text
                TextBoxResume.AppendText(Environment.NewLine + "Cuisson : " + ComboBoxCuisson.Text)
                currentState = State.PERSONNALISER_COMMANDE
                ComboBoxCuisson.Enabled = False
            Case State.COMMANDE_SIZE
                currentState = State.PERSONNALISER_COMMANDE
                currentPizza.Cuisson = ComboBoxCuisson.Text
                TextBoxResume.AppendText(Environment.NewLine + "Cuisson : " + ComboBoxCuisson.Text)
            Case State.PERSONNALISER_COMMANDE
                ComboBoxCuisson.Enabled = False
                currentState = State.PERSONNALISER_COMMANDE
            Case State.PASSER_COMMANDE
        End Select
    End Sub

    Private Sub ComboBoxPate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPate.SelectedIndexChanged
        Select Case currentState
            Case State.INIT
                '
            Case State.COMMANDE_ENCOURS
                currentState = State.PERSONNALISER_COMMANDE
                currentPizza.Pate = ComboBoxPate.Text
                TextBoxResume.AppendText(Environment.NewLine + "Pate : " + ComboBoxPate.Text)
                TextBoxResume.AppendText(Environment.NewLine + "------------------" + Environment.NewLine)
                ButtonPasserCommand.Enabled = True
                ComboBoxPate.Enabled = False
            Case State.COMMANDE_SIZE
                currentState = State.PERSONNALISER_COMMANDE
                currentPizza.Pate = ComboBoxPate.Text
                TextBoxResume.AppendText(Environment.NewLine + "Pate : " + ComboBoxPate.Text)
                TextBoxResume.AppendText(Environment.NewLine + "------------------" + Environment.NewLine)
                ButtonPasserCommand.Enabled = True
                ComboBoxPate.Enabled = False
            Case State.PERSONNALISER_COMMANDE
                currentState = State.PERSONNALISER_COMMANDE
                currentPizza.Pate = ComboBoxPate.Text
                TextBoxResume.AppendText(Environment.NewLine + "Pate : " + ComboBoxPate.Text)
                TextBoxResume.AppendText(Environment.NewLine + "------------------" + Environment.NewLine)
                ButtonPasserCommand.Enabled = True
                ComboBoxPate.Enabled = False
            Case State.PASSER_COMMANDE
        End Select
    End Sub

#End Region

    Private Sub initQuantity()
        ComboBoxSmall.Text = "0"
        ComboBoxMedium.Text = "0"
        ComboBoxLarge.Text = "0"
    End Sub

    Private Sub initCuissonPate()
        ComboBoxCuisson.Text = " "
        ComboBoxPate.Text = " "
    End Sub

    Private Sub ButtonPasserCommand_Click(sender As Object, e As EventArgs) Handles ButtonPasserCommand.Click
        If (MessageBox.Show(TextBoxResume.Text + Environment.NewLine + "La commande vous sera livrée bientot" + Environment.NewLine + "Voulez-vous passer une nouvelle commande?", "Votre commande", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            InitDialogue()
        Else

            Application.Exit()
        End If
    End Sub
End Class

