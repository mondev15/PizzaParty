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
        Me.TextBoxNomPizza = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelCategorie4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1000gr = New System.Windows.Forms.Label()
        Me.Label500gr = New System.Windows.Forms.Label()
        Me.Label250gr = New System.Windows.Forms.Label()
        Me.TextBox250gr = New System.Windows.Forms.TextBox()
        Me.TextBox500gr = New System.Windows.Forms.TextBox()
        Me.TextBox1000gr = New System.Windows.Forms.TextBox()
        Me.PanelResume.SuspendLayout()
        Me.PanelCuissonPate.SuspendLayout()
        CType(Me.PictureBoxRecommandation2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategorie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategorie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRecommandation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCategorie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRecommandation.SuspendLayout()
        Me.PanelCategorie.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelResume
        '
        Me.PanelResume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelResume.Controls.Add(Me.TextBoxResume)
        Me.PanelResume.Location = New System.Drawing.Point(1071, 142)
        Me.PanelResume.Name = "PanelResume"
        Me.PanelResume.Size = New System.Drawing.Size(140, 442)
        Me.PanelResume.TabIndex = 0
        '
        'TextBoxResume
        '
        Me.TextBoxResume.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBoxResume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxResume.Location = New System.Drawing.Point(-2, -2)
        Me.TextBoxResume.Multiline = True
        Me.TextBoxResume.Name = "TextBoxResume"
        Me.TextBoxResume.ReadOnly = True
        Me.TextBoxResume.Size = New System.Drawing.Size(140, 442)
        Me.TextBoxResume.TabIndex = 0
        '
        'labelHistorique
        '
        Me.labelHistorique.AutoSize = True
        Me.labelHistorique.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHistorique.Location = New System.Drawing.Point(1068, 105)
        Me.labelHistorique.Name = "labelHistorique"
        Me.labelHistorique.Size = New System.Drawing.Size(143, 18)
        Me.labelHistorique.TabIndex = 1
        Me.labelHistorique.Text = "Résumé commande"
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
        Me.ComboBoxPate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPate.FormattingEnabled = True
        Me.ComboBoxPate.Items.AddRange(New Object() {"Fine", "Moelleuse", "Epaisse"})
        Me.ComboBoxPate.Location = New System.Drawing.Point(151, 108)
        Me.ComboBoxPate.Name = "ComboBoxPate"
        Me.ComboBoxPate.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxPate.TabIndex = 5
        '
        'ComboBoxCuisson
        '
        Me.ComboBoxCuisson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCuisson.FormattingEnabled = True
        Me.ComboBoxCuisson.Items.AddRange(New Object() {"Classique", "Bien cuite", "Mi-cuite"})
        Me.ComboBoxCuisson.Location = New System.Drawing.Point(151, 60)
        Me.ComboBoxCuisson.Name = "ComboBoxCuisson"
        Me.ComboBoxCuisson.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCuisson.TabIndex = 6
        '
        'ButtonPasserCommand
        '
        Me.ButtonPasserCommand.Location = New System.Drawing.Point(1071, 594)
        Me.ButtonPasserCommand.Name = "ButtonPasserCommand"
        Me.ButtonPasserCommand.Size = New System.Drawing.Size(140, 36)
        Me.ButtonPasserCommand.TabIndex = 7
        Me.ButtonPasserCommand.Text = "Passer Commande"
        Me.ButtonPasserCommand.UseVisualStyleBackColor = True
        '
        'PanelCuissonPate
        '
        Me.PanelCuissonPate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCuissonPate.Controls.Add(Me.TextBoxNomPizza)
        Me.PanelCuissonPate.Controls.Add(Me.LabelNom)
        Me.PanelCuissonPate.Controls.Add(Me.LabelTypeCuisson)
        Me.PanelCuissonPate.Controls.Add(Me.LabelTypePate)
        Me.PanelCuissonPate.Controls.Add(Me.ComboBoxPate)
        Me.PanelCuissonPate.Controls.Add(Me.ComboBoxCuisson)
        Me.PanelCuissonPate.Location = New System.Drawing.Point(38, 142)
        Me.PanelCuissonPate.Name = "PanelCuissonPate"
        Me.PanelCuissonPate.Size = New System.Drawing.Size(439, 153)
        Me.PanelCuissonPate.TabIndex = 8
        '
        'PictureBoxRecommandation2
        '
        Me.PictureBoxRecommandation2.Image = CType(resources.GetObject("PictureBoxRecommandation2.Image"), System.Drawing.Image)
        Me.PictureBoxRecommandation2.Location = New System.Drawing.Point(18, 57)
        Me.PictureBoxRecommandation2.Name = "PictureBoxRecommandation2"
        Me.PictureBoxRecommandation2.Size = New System.Drawing.Size(154, 88)
        Me.PictureBoxRecommandation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRecommandation2.TabIndex = 20
        Me.PictureBoxRecommandation2.TabStop = False
        '
        'PictureBoxCategorie2
        '
        Me.PictureBoxCategorie2.Image = CType(resources.GetObject("PictureBoxCategorie2.Image"), System.Drawing.Image)
        Me.PictureBoxCategorie2.Location = New System.Drawing.Point(233, 102)
        Me.PictureBoxCategorie2.Name = "PictureBoxCategorie2"
        Me.PictureBoxCategorie2.Size = New System.Drawing.Size(138, 98)
        Me.PictureBoxCategorie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCategorie2.TabIndex = 19
        Me.PictureBoxCategorie2.TabStop = False
        '
        'LabelRecommandations
        '
        Me.LabelRecommandations.AutoSize = True
        Me.LabelRecommandations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecommandations.Location = New System.Drawing.Point(8, 11)
        Me.LabelRecommandations.Name = "LabelRecommandations"
        Me.LabelRecommandations.Size = New System.Drawing.Size(174, 17)
        Me.LabelRecommandations.TabIndex = 18
        Me.LabelRecommandations.Text = "Pizzas Recommandées"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nos Pizzas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelCategorie3
        '
        Me.LabelCategorie3.AutoSize = True
        Me.LabelCategorie3.Location = New System.Drawing.Point(478, 86)
        Me.LabelCategorie3.Name = "LabelCategorie3"
        Me.LabelCategorie3.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie3.TabIndex = 16
        Me.LabelCategorie3.Text = "Catégorie 3"
        '
        'LabelCategorie2
        '
        Me.LabelCategorie2.AutoSize = True
        Me.LabelCategorie2.Location = New System.Drawing.Point(270, 86)
        Me.LabelCategorie2.Name = "LabelCategorie2"
        Me.LabelCategorie2.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie2.TabIndex = 15
        Me.LabelCategorie2.Text = "Catégorie 2"
        '
        'LabelCategorie1
        '
        Me.LabelCategorie1.AutoSize = True
        Me.LabelCategorie1.Location = New System.Drawing.Point(57, 86)
        Me.LabelCategorie1.Name = "LabelCategorie1"
        Me.LabelCategorie1.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie1.TabIndex = 14
        Me.LabelCategorie1.Text = "Catégorie 1"
        '
        'PictureBoxCategorie3
        '
        Me.PictureBoxCategorie3.Image = CType(resources.GetObject("PictureBoxCategorie3.Image"), System.Drawing.Image)
        Me.PictureBoxCategorie3.Location = New System.Drawing.Point(441, 102)
        Me.PictureBoxCategorie3.Name = "PictureBoxCategorie3"
        Me.PictureBoxCategorie3.Size = New System.Drawing.Size(138, 98)
        Me.PictureBoxCategorie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCategorie3.TabIndex = 12
        Me.PictureBoxCategorie3.TabStop = False
        '
        'PictureBoxRecommandation1
        '
        Me.PictureBoxRecommandation1.Image = CType(resources.GetObject("PictureBoxRecommandation1.Image"), System.Drawing.Image)
        Me.PictureBoxRecommandation1.Location = New System.Drawing.Point(18, 163)
        Me.PictureBoxRecommandation1.Name = "PictureBoxRecommandation1"
        Me.PictureBoxRecommandation1.Size = New System.Drawing.Size(152, 91)
        Me.PictureBoxRecommandation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRecommandation1.TabIndex = 11
        Me.PictureBoxRecommandation1.TabStop = False
        '
        'PictureBoxCategorie1
        '
        Me.PictureBoxCategorie1.Image = CType(resources.GetObject("PictureBoxCategorie1.Image"), System.Drawing.Image)
        Me.PictureBoxCategorie1.Location = New System.Drawing.Point(20, 102)
        Me.PictureBoxCategorie1.Name = "PictureBoxCategorie1"
        Me.PictureBoxCategorie1.Size = New System.Drawing.Size(134, 98)
        Me.PictureBoxCategorie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCategorie1.TabIndex = 10
        Me.PictureBoxCategorie1.TabStop = False
        '
        'ButtonConsulter1
        '
        Me.ButtonConsulter1.BackColor = System.Drawing.Color.IndianRed
        Me.ButtonConsulter1.Location = New System.Drawing.Point(20, 206)
        Me.ButtonConsulter1.Name = "ButtonConsulter1"
        Me.ButtonConsulter1.Size = New System.Drawing.Size(134, 23)
        Me.ButtonConsulter1.TabIndex = 9
        Me.ButtonConsulter1.Text = "Consulter"
        Me.ButtonConsulter1.UseVisualStyleBackColor = False
        '
        'ButtonConsulter2
        '
        Me.ButtonConsulter2.BackColor = System.Drawing.Color.IndianRed
        Me.ButtonConsulter2.Location = New System.Drawing.Point(233, 207)
        Me.ButtonConsulter2.Name = "ButtonConsulter2"
        Me.ButtonConsulter2.Size = New System.Drawing.Size(138, 23)
        Me.ButtonConsulter2.TabIndex = 8
        Me.ButtonConsulter2.Text = "Consulter"
        Me.ButtonConsulter2.UseVisualStyleBackColor = False
        '
        'ButtonConsulter3
        '
        Me.ButtonConsulter3.BackColor = System.Drawing.Color.IndianRed
        Me.ButtonConsulter3.Location = New System.Drawing.Point(441, 207)
        Me.ButtonConsulter3.Name = "ButtonConsulter3"
        Me.ButtonConsulter3.Size = New System.Drawing.Size(138, 23)
        Me.ButtonConsulter3.TabIndex = 7
        Me.ButtonConsulter3.Text = "Consulter"
        Me.ButtonConsulter3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(529, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 31)
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
        Me.PanelRecommandation.Location = New System.Drawing.Point(38, 314)
        Me.PanelRecommandation.Name = "PanelRecommandation"
        Me.PanelRecommandation.Size = New System.Drawing.Size(187, 270)
        Me.PanelRecommandation.TabIndex = 21
        '
        'PanelCategorie
        '
        Me.PanelCategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCategorie.Controls.Add(Me.Button1)
        Me.PanelCategorie.Controls.Add(Me.LabelCategorie4)
        Me.PanelCategorie.Controls.Add(Me.PictureBox1)
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
        Me.PanelCategorie.Location = New System.Drawing.Point(250, 314)
        Me.PanelCategorie.Name = "PanelCategorie"
        Me.PanelCategorie.Size = New System.Drawing.Size(794, 270)
        Me.PanelCategorie.TabIndex = 22
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(17, 16)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(127, 18)
        Me.LabelNom.TabIndex = 7
        Me.LabelNom.Text = "Nom de la pizza : "
        '
        'TextBoxNomPizza
        '
        Me.TextBoxNomPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomPizza.Location = New System.Drawing.Point(151, 16)
        Me.TextBoxNomPizza.Name = "TextBoxNomPizza"
        Me.TextBoxNomPizza.Size = New System.Drawing.Size(121, 23)
        Me.TextBoxNomPizza.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(632, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'LabelCategorie4
        '
        Me.LabelCategorie4.AutoSize = True
        Me.LabelCategorie4.Location = New System.Drawing.Point(668, 86)
        Me.LabelCategorie4.Name = "LabelCategorie4"
        Me.LabelCategorie4.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie4.TabIndex = 21
        Me.LabelCategorie4.Text = "Catégorie 4"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(632, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Consulter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1000gr
        '
        Me.Label1000gr.AutoSize = True
        Me.Label1000gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1000gr.Location = New System.Drawing.Point(834, 91)
        Me.Label1000gr.Name = "Label1000gr"
        Me.Label1000gr.Size = New System.Drawing.Size(167, 17)
        Me.Label1000gr.TabIndex = 23
        Me.Label1000gr.Text = "1000 gr (3-4  personnes)"
        '
        'Label500gr
        '
        Me.Label500gr.AutoSize = True
        Me.Label500gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label500gr.Location = New System.Drawing.Point(620, 91)
        Me.Label500gr.Name = "Label500gr"
        Me.Label500gr.Size = New System.Drawing.Size(155, 17)
        Me.Label500gr.TabIndex = 24
        Me.Label500gr.Text = "500 gr (2-3 personnes)"
        '
        'Label250gr
        '
        Me.Label250gr.AutoSize = True
        Me.Label250gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label250gr.Location = New System.Drawing.Point(409, 91)
        Me.Label250gr.Name = "Label250gr"
        Me.Label250gr.Size = New System.Drawing.Size(135, 17)
        Me.Label250gr.TabIndex = 25
        Me.Label250gr.Text = "250 gr (1 personne)"
        '
        'TextBox250gr
        '
        Me.TextBox250gr.Location = New System.Drawing.Point(374, 91)
        Me.TextBox250gr.Name = "TextBox250gr"
        Me.TextBox250gr.Size = New System.Drawing.Size(29, 20)
        Me.TextBox250gr.TabIndex = 26
        Me.TextBox250gr.Text = "0"
        Me.TextBox250gr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox500gr
        '
        Me.TextBox500gr.Location = New System.Drawing.Point(579, 90)
        Me.TextBox500gr.Name = "TextBox500gr"
        Me.TextBox500gr.Size = New System.Drawing.Size(26, 20)
        Me.TextBox500gr.TabIndex = 27
        Me.TextBox500gr.Text = "0"
        Me.TextBox500gr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1000gr
        '
        Me.TextBox1000gr.Location = New System.Drawing.Point(803, 90)
        Me.TextBox1000gr.Name = "TextBox1000gr"
        Me.TextBox1000gr.Size = New System.Drawing.Size(25, 20)
        Me.TextBox1000gr.TabIndex = 28
        Me.TextBox1000gr.Text = "0"
        Me.TextBox1000gr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1223, 635)
        Me.Controls.Add(Me.TextBox1000gr)
        Me.Controls.Add(Me.TextBox500gr)
        Me.Controls.Add(Me.TextBox250gr)
        Me.Controls.Add(Me.Label250gr)
        Me.Controls.Add(Me.Label500gr)
        Me.Controls.Add(Me.Label1000gr)
        Me.Controls.Add(Me.PanelCategorie)
        Me.Controls.Add(Me.PanelRecommandation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelCuissonPate)
        Me.Controls.Add(Me.ButtonPasserCommand)
        Me.Controls.Add(Me.labelHistorique)
        Me.Controls.Add(Me.PanelResume)
        Me.MaximumSize = New System.Drawing.Size(1239, 673)
        Me.MinimumSize = New System.Drawing.Size(1239, 673)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBoxNomPizza As TextBox
    Friend WithEvents LabelNom As Label

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelCategorie4 As Label
    Friend WithEvents PictureBox1 As PictureBox


    Friend WithEvents Label1000gr As Label
    Friend WithEvents Label500gr As Label
    Friend WithEvents Label250gr As Label
    Friend WithEvents TextBox250gr As TextBox
    Friend WithEvents TextBox500gr As TextBox
    Friend WithEvents TextBox1000gr As TextBox


End Class
