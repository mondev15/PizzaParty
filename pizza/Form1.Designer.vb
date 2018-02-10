<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelResume = New System.Windows.Forms.Panel()
        Me.TextBoxResume = New System.Windows.Forms.TextBox()
        Me.labelHistorique = New System.Windows.Forms.Label()
        Me.LabelTypeCuisson = New System.Windows.Forms.Label()
        Me.LabelTypePate = New System.Windows.Forms.Label()
        Me.ComboBoxPate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCuisson = New System.Windows.Forms.ComboBox()
        Me.ButtonPasserCommand = New System.Windows.Forms.Button()
        Me.PanelCuissonPate = New System.Windows.Forms.Panel()
        Me.PictureBoxRecommandation2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCategorie2 = New System.Windows.Forms.PictureBox()
        Me.LabelRecommandations = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelCategorie3 = New System.Windows.Forms.Label()
        Me.LabelCategorie2 = New System.Windows.Forms.Label()
        Me.LabelCategorie1 = New System.Windows.Forms.Label()
        Me.PictureBoxCategorie3 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxRecommandation1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCategorie1 = New System.Windows.Forms.PictureBox()
        Me.ButtonConsulter1 = New System.Windows.Forms.Button()
        Me.ButtonConsulter2 = New System.Windows.Forms.Button()
        Me.ButtonConsulter3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelRecommandation = New System.Windows.Forms.Panel()
        Me.PanelCategorie = New System.Windows.Forms.Panel()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelResume.SuspendLayout()
        Me.PanelCuissonPate.SuspendLayout()
        CType(Me.PictureBoxRecommandation2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategorie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategorie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRecommandation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategorie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRecommandation.SuspendLayout()
        Me.PanelCategorie.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelResume
        '
        Me.PanelResume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelResume.Controls.Add(Me.TextBoxResume)
        Me.PanelResume.Location = New System.Drawing.Point(853, 78)
        Me.PanelResume.Name = "PanelResume"
        Me.PanelResume.Size = New System.Drawing.Size(140, 442)
        Me.PanelResume.TabIndex = 0
        '
        'TextBoxResume
        '
        Me.TextBoxResume.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBoxResume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResume.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxResume.Multiline = True
        Me.TextBoxResume.Name = "TextBoxResume"
        Me.TextBoxResume.ReadOnly = True
        Me.TextBoxResume.Size = New System.Drawing.Size(130, 432)
        Me.TextBoxResume.TabIndex = 0
        '
        'labelHistorique
        '
        Me.labelHistorique.AutoSize = True
        Me.labelHistorique.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHistorique.Location = New System.Drawing.Point(855, 48)
        Me.labelHistorique.Name = "labelHistorique"
        Me.labelHistorique.Size = New System.Drawing.Size(66, 17)
        Me.labelHistorique.TabIndex = 1
        Me.labelHistorique.Text = "Résumé"
        '
        'LabelTypeCuisson
        '
        Me.LabelTypeCuisson.AutoSize = True
        Me.LabelTypeCuisson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTypeCuisson.Location = New System.Drawing.Point(14, 64)
        Me.LabelTypeCuisson.Name = "LabelTypeCuisson"
        Me.LabelTypeCuisson.Size = New System.Drawing.Size(120, 17)
        Me.LabelTypeCuisson.TabIndex = 2
        Me.LabelTypeCuisson.Text = "Type de cuisson :"
        '
        'LabelTypePate
        '
        Me.LabelTypePate.AutoSize = True
        Me.LabelTypePate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTypePate.Location = New System.Drawing.Point(14, 112)
        Me.LabelTypePate.Name = "LabelTypePate"
        Me.LabelTypePate.Size = New System.Drawing.Size(100, 17)
        Me.LabelTypePate.TabIndex = 3
        Me.LabelTypePate.Text = "Type de pâte :"
        '
        'ComboBoxPate
        '
        Me.ComboBoxPate.FormattingEnabled = True
        Me.ComboBoxPate.Items.AddRange(New Object() {"Fine", "Moelleuse", "Epaisse"})
        Me.ComboBoxPate.Location = New System.Drawing.Point(151, 108)
        Me.ComboBoxPate.Name = "ComboBoxPate"
        Me.ComboBoxPate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPate.TabIndex = 5
        '
        'ComboBoxCuisson
        '
        Me.ComboBoxCuisson.FormattingEnabled = True
        Me.ComboBoxCuisson.Items.AddRange(New Object() {"Classique", "Bien cuite", "Mi-cuite (pas trop cuite)"})
        Me.ComboBoxCuisson.Location = New System.Drawing.Point(151, 60)
        Me.ComboBoxCuisson.Name = "ComboBoxCuisson"
        Me.ComboBoxCuisson.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCuisson.TabIndex = 6
        '
        'ButtonPasserCommand
        '
        Me.ButtonPasserCommand.Location = New System.Drawing.Point(881, 555)
        Me.ButtonPasserCommand.Name = "ButtonPasserCommand"
        Me.ButtonPasserCommand.Size = New System.Drawing.Size(112, 29)
        Me.ButtonPasserCommand.TabIndex = 7
        Me.ButtonPasserCommand.Text = "Passer Commande"
        Me.ButtonPasserCommand.UseVisualStyleBackColor = True
        '
        'PanelCuissonPate
        '
        Me.PanelCuissonPate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCuissonPate.Controls.Add(Me.TextBox1)
        Me.PanelCuissonPate.Controls.Add(Me.LabelNom)
        Me.PanelCuissonPate.Controls.Add(Me.LabelTypeCuisson)
        Me.PanelCuissonPate.Controls.Add(Me.LabelTypePate)
        Me.PanelCuissonPate.Controls.Add(Me.ComboBoxPate)
        Me.PanelCuissonPate.Controls.Add(Me.ComboBoxCuisson)
        Me.PanelCuissonPate.Location = New System.Drawing.Point(38, 74)
        Me.PanelCuissonPate.Name = "PanelCuissonPate"
        Me.PanelCuissonPate.Size = New System.Drawing.Size(439, 156)
        Me.PanelCuissonPate.TabIndex = 8
        '
        'PictureBoxRecommandation2
        '
        Me.PictureBoxRecommandation2.Image = CType(resources.GetObject("PictureBoxRecommandation2.Image"), System.Drawing.Image)
        Me.PictureBoxRecommandation2.Location = New System.Drawing.Point(19, 69)
        Me.PictureBoxRecommandation2.Name = "PictureBoxRecommandation2"
        Me.PictureBoxRecommandation2.Size = New System.Drawing.Size(109, 67)
        Me.PictureBoxRecommandation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRecommandation2.TabIndex = 20
        Me.PictureBoxRecommandation2.TabStop = False
        '
        'PictureBoxCategorie2
        '
        Me.PictureBoxCategorie2.Image = CType(resources.GetObject("PictureBoxCategorie2.Image"), System.Drawing.Image)
        Me.PictureBoxCategorie2.Location = New System.Drawing.Point(233, 117)
        Me.PictureBoxCategorie2.Name = "PictureBoxCategorie2"
        Me.PictureBoxCategorie2.Size = New System.Drawing.Size(117, 83)
        Me.PictureBoxCategorie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCategorie2.TabIndex = 19
        Me.PictureBoxCategorie2.TabStop = False
        '
        'LabelRecommandations
        '
        Me.LabelRecommandations.AutoSize = True
        Me.LabelRecommandations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecommandations.Location = New System.Drawing.Point(15, 24)
        Me.LabelRecommandations.Name = "LabelRecommandations"
        Me.LabelRecommandations.Size = New System.Drawing.Size(158, 20)
        Me.LabelRecommandations.TabIndex = 18
        Me.LabelRecommandations.Text = "Recommandations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nos Pizzas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelCategorie3
        '
        Me.LabelCategorie3.AutoSize = True
        Me.LabelCategorie3.Location = New System.Drawing.Point(438, 89)
        Me.LabelCategorie3.Name = "LabelCategorie3"
        Me.LabelCategorie3.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie3.TabIndex = 16
        Me.LabelCategorie3.Text = "Catégorie 3"
        '
        'LabelCategorie2
        '
        Me.LabelCategorie2.AutoSize = True
        Me.LabelCategorie2.Location = New System.Drawing.Point(230, 89)
        Me.LabelCategorie2.Name = "LabelCategorie2"
        Me.LabelCategorie2.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie2.TabIndex = 15
        Me.LabelCategorie2.Text = "Catégorie 2"
        '
        'LabelCategorie1
        '
        Me.LabelCategorie1.AutoSize = True
        Me.LabelCategorie1.Location = New System.Drawing.Point(17, 89)
        Me.LabelCategorie1.Name = "LabelCategorie1"
        Me.LabelCategorie1.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie1.TabIndex = 14
        Me.LabelCategorie1.Text = "Catégorie 1"
        '
        'PictureBoxCategorie3
        '
        Me.PictureBoxCategorie3.Image = CType(resources.GetObject("PictureBoxCategorie3.Image"), System.Drawing.Image)
        Me.PictureBoxCategorie3.Location = New System.Drawing.Point(441, 117)
        Me.PictureBoxCategorie3.Name = "PictureBoxCategorie3"
        Me.PictureBoxCategorie3.Size = New System.Drawing.Size(120, 83)
        Me.PictureBoxCategorie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCategorie3.TabIndex = 12
        Me.PictureBoxCategorie3.TabStop = False
        '
        'PictureBoxRecommandation1
        '
        Me.PictureBoxRecommandation1.Image = CType(resources.GetObject("PictureBoxRecommandation1.Image"), System.Drawing.Image)
        Me.PictureBoxRecommandation1.Location = New System.Drawing.Point(19, 163)
        Me.PictureBoxRecommandation1.Name = "PictureBoxRecommandation1"
        Me.PictureBoxRecommandation1.Size = New System.Drawing.Size(109, 67)
        Me.PictureBoxRecommandation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRecommandation1.TabIndex = 11
        Me.PictureBoxRecommandation1.TabStop = False
        '
        'PictureBoxCategorie1
        '
        Me.PictureBoxCategorie1.Image = CType(resources.GetObject("PictureBoxCategorie1.Image"), System.Drawing.Image)
        Me.PictureBoxCategorie1.Location = New System.Drawing.Point(20, 117)
        Me.PictureBoxCategorie1.Name = "PictureBoxCategorie1"
        Me.PictureBoxCategorie1.Size = New System.Drawing.Size(110, 83)
        Me.PictureBoxCategorie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCategorie1.TabIndex = 10
        Me.PictureBoxCategorie1.TabStop = False
        '
        'ButtonConsulter1
        '
        Me.ButtonConsulter1.Location = New System.Drawing.Point(20, 225)
        Me.ButtonConsulter1.Name = "ButtonConsulter1"
        Me.ButtonConsulter1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConsulter1.TabIndex = 9
        Me.ButtonConsulter1.Text = "Consulter"
        Me.ButtonConsulter1.UseVisualStyleBackColor = True
        '
        'ButtonConsulter2
        '
        Me.ButtonConsulter2.Location = New System.Drawing.Point(233, 225)
        Me.ButtonConsulter2.Name = "ButtonConsulter2"
        Me.ButtonConsulter2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConsulter2.TabIndex = 8
        Me.ButtonConsulter2.Text = "Consulter"
        Me.ButtonConsulter2.UseVisualStyleBackColor = True
        '
        'ButtonConsulter3
        '
        Me.ButtonConsulter3.Location = New System.Drawing.Point(441, 225)
        Me.ButtonConsulter3.Name = "ButtonConsulter3"
        Me.ButtonConsulter3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConsulter3.TabIndex = 7
        Me.ButtonConsulter3.Text = "Consulter"
        Me.ButtonConsulter3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pizza Party"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelRecommandation
        '
        Me.PanelRecommandation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRecommandation.Controls.Add(Me.PictureBoxRecommandation2)
        Me.PanelRecommandation.Controls.Add(Me.PictureBoxRecommandation1)
        Me.PanelRecommandation.Controls.Add(Me.LabelRecommandations)
        Me.PanelRecommandation.Location = New System.Drawing.Point(38, 250)
        Me.PanelRecommandation.Name = "PanelRecommandation"
        Me.PanelRecommandation.Size = New System.Drawing.Size(187, 270)
        Me.PanelRecommandation.TabIndex = 21
        '
        'PanelCategorie
        '
        Me.PanelCategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCategorie.Controls.Add(Me.Label2)
        Me.PanelCategorie.Controls.Add(Me.PictureBoxCategorie1)
        Me.PanelCategorie.Controls.Add(Me.ButtonConsulter1)
        Me.PanelCategorie.Controls.Add(Me.PictureBoxCategorie2)
        Me.PanelCategorie.Controls.Add(Me.LabelCategorie1)
        Me.PanelCategorie.Controls.Add(Me.LabelCategorie2)
        Me.PanelCategorie.Controls.Add(Me.LabelCategorie3)
        Me.PanelCategorie.Controls.Add(Me.ButtonConsulter2)
        Me.PanelCategorie.Controls.Add(Me.PictureBoxCategorie3)
        Me.PanelCategorie.Controls.Add(Me.ButtonConsulter3)
        Me.PanelCategorie.Location = New System.Drawing.Point(246, 250)
        Me.PanelCategorie.Name = "PanelCategorie"
        Me.PanelCategorie.Size = New System.Drawing.Size(590, 270)
        Me.PanelCategorie.TabIndex = 22
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(17, 16)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(121, 17)
        Me.LabelNom.TabIndex = 7
        Me.LabelNom.Text = "Nom de la pizza : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 605)
        Me.Controls.Add(Me.PanelCategorie)
        Me.Controls.Add(Me.PanelRecommandation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelCuissonPate)
        Me.Controls.Add(Me.ButtonPasserCommand)
        Me.Controls.Add(Me.labelHistorique)
        Me.Controls.Add(Me.PanelResume)
        Me.MinimumSize = New System.Drawing.Size(1021, 605)
        Me.Name = "Form1"
        Me.Text = "GSI - PizzaParty"
        Me.PanelResume.ResumeLayout(False)
        Me.PanelResume.PerformLayout()
        Me.PanelCuissonPate.ResumeLayout(False)
        Me.PanelCuissonPate.PerformLayout()
        CType(Me.PictureBoxRecommandation2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCategorie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCategorie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRecommandation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCategorie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRecommandation.ResumeLayout(False)
        Me.PanelRecommandation.PerformLayout()
        Me.PanelCategorie.ResumeLayout(False)
        Me.PanelCategorie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelResume As Panel
    Friend WithEvents labelHistorique As Label
    Friend WithEvents LabelTypeCuisson As Label
    Friend WithEvents LabelTypePate As Label
    Friend WithEvents ComboBoxPate As ComboBox
    Friend WithEvents ComboBoxCuisson As ComboBox
    Friend WithEvents ButtonPasserCommand As Button
    Friend WithEvents PanelCuissonPate As Panel
    Friend WithEvents ButtonConsulter1 As Button
    Friend WithEvents ButtonConsulter2 As Button
    Friend WithEvents ButtonConsulter3 As Button
    Friend WithEvents PictureBoxCategorie3 As PictureBox
    Friend WithEvents PictureBoxRecommandation1 As PictureBox
    Friend WithEvents PictureBoxCategorie1 As PictureBox
    Friend WithEvents LabelCategorie3 As Label
    Friend WithEvents LabelCategorie2 As Label
    Friend WithEvents LabelCategorie1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBoxRecommandation2 As PictureBox
    Friend WithEvents PictureBoxCategorie2 As PictureBox
    Friend WithEvents LabelRecommandations As Label
    Friend WithEvents TextBoxResume As TextBox

    Private Sub LabelCategorie3_Click(sender As Object, e As EventArgs) Handles LabelCategorie3.Click

    End Sub

    Friend WithEvents PanelRecommandation As Panel
    Friend WithEvents PanelCategorie As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelNom As Label
End Class
