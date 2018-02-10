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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelCategorie4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1000gr = New System.Windows.Forms.Label()
        Me.Label500gr = New System.Windows.Forms.Label()
        Me.Label250gr = New System.Windows.Forms.Label()
        Me.ComboBox250gr = New System.Windows.Forms.ComboBox()
        Me.ComboBox500gr = New System.Windows.Forms.ComboBox()
        Me.ComboBox1000gr = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelSelectionPizza = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4Fromages = New System.Windows.Forms.Label()
        Me.LabelBonplan = New System.Windows.Forms.Label()
        Me.LabelMargherita = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelTypeCuisson.Location = New System.Drawing.Point(36, 61)
        Me.LabelTypeCuisson.Name = "LabelTypeCuisson"
        Me.LabelTypeCuisson.Size = New System.Drawing.Size(120, 17)
        Me.LabelTypeCuisson.TabIndex = 2
        Me.LabelTypeCuisson.Text = "Type de cuisson :"
        '
        'LabelTypePate
        '
        Me.LabelTypePate.AutoSize = True
        Me.LabelTypePate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTypePate.Location = New System.Drawing.Point(37, 102)
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
        Me.ComboBoxPate.Location = New System.Drawing.Point(201, 102)
        Me.ComboBoxPate.Name = "ComboBoxPate"
        Me.ComboBoxPate.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxPate.TabIndex = 5
        '
        'ComboBoxCuisson
        '
        Me.ComboBoxCuisson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCuisson.FormattingEnabled = True
        Me.ComboBoxCuisson.Items.AddRange(New Object() {"Classique", "Bien cuite", "Mi-cuite"})
        Me.ComboBoxCuisson.Location = New System.Drawing.Point(201, 61)
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
        Me.PanelCuissonPate.Controls.Add(Me.Label1)
        Me.PanelCuissonPate.Controls.Add(Me.LabelTypeCuisson)
        Me.PanelCuissonPate.Controls.Add(Me.LabelTypePate)
        Me.PanelCuissonPate.Controls.Add(Me.ComboBoxPate)
        Me.PanelCuissonPate.Controls.Add(Me.ComboBoxCuisson)
        Me.PanelCuissonPate.Location = New System.Drawing.Point(692, 142)
        Me.PanelCuissonPate.Name = "PanelCuissonPate"
        Me.PanelCuissonPate.Size = New System.Drawing.Size(352, 145)
        Me.PanelCuissonPate.TabIndex = 8
        '
        'PictureBoxRecommandation2
        '
        Me.PictureBoxRecommandation2.Image = CType(resources.GetObject("PictureBoxRecommandation2.Image"), System.Drawing.Image)
        Me.PictureBoxRecommandation2.Location = New System.Drawing.Point(18, 44)
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
        'LabelCategorie4
        '
        Me.LabelCategorie4.AutoSize = True
        Me.LabelCategorie4.Location = New System.Drawing.Point(668, 86)
        Me.LabelCategorie4.Name = "LabelCategorie4"
        Me.LabelCategorie4.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategorie4.TabIndex = 21
        Me.LabelCategorie4.Text = "Catégorie 4"
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
        'Label1000gr
        '
        Me.Label1000gr.AutoSize = True
        Me.Label1000gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1000gr.Location = New System.Drawing.Point(848, 92)
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
        'ComboBox250gr
        '
        Me.ComboBox250gr.FormattingEnabled = True
        Me.ComboBox250gr.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.ComboBox250gr.Location = New System.Drawing.Point(361, 91)
        Me.ComboBox250gr.Name = "ComboBox250gr"
        Me.ComboBox250gr.Size = New System.Drawing.Size(44, 21)
        Me.ComboBox250gr.TabIndex = 29
        '
        'ComboBox500gr
        '
        Me.ComboBox500gr.FormattingEnabled = True
        Me.ComboBox500gr.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.ComboBox500gr.Location = New System.Drawing.Point(571, 91)
        Me.ComboBox500gr.Name = "ComboBox500gr"
        Me.ComboBox500gr.Size = New System.Drawing.Size(43, 21)
        Me.ComboBox500gr.TabIndex = 30
        '
        'ComboBox1000gr
        '
        Me.ComboBox1000gr.FormattingEnabled = True
        Me.ComboBox1000gr.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.ComboBox1000gr.Location = New System.Drawing.Point(793, 91)
        Me.ComboBox1000gr.Name = "ComboBox1000gr"
        Me.ComboBox1000gr.Size = New System.Drawing.Size(37, 21)
        Me.ComboBox1000gr.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelMargherita)
        Me.Panel1.Controls.Add(Me.LabelBonplan)
        Me.Panel1.Controls.Add(Me.Label4Fromages)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelSelectionPizza)
        Me.Panel1.Location = New System.Drawing.Point(38, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 145)
        Me.Panel1.TabIndex = 32
        '
        'LabelSelectionPizza
        '
        Me.LabelSelectionPizza.AutoSize = True
        Me.LabelSelectionPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectionPizza.Location = New System.Drawing.Point(245, 10)
        Me.LabelSelectionPizza.Name = "LabelSelectionPizza"
        Me.LabelSelectionPizza.Size = New System.Drawing.Size(132, 20)
        Me.LabelSelectionPizza.TabIndex = 0
        Me.LabelSelectionPizza.Text = "Selection Pizza"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(249, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(118, 76)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(446, 46)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(130, 74)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Personnalisation"
        '
        'Label4Fromages
        '
        Me.Label4Fromages.AutoSize = True
        Me.Label4Fromages.Location = New System.Drawing.Point(46, 123)
        Me.Label4Fromages.Name = "Label4Fromages"
        Me.Label4Fromages.Size = New System.Drawing.Size(62, 13)
        Me.Label4Fromages.TabIndex = 4
        Me.Label4Fromages.Text = "4 Fromages"
        '
        'LabelBonplan
        '
        Me.LabelBonplan.AutoSize = True
        Me.LabelBonplan.Location = New System.Drawing.Point(281, 123)
        Me.LabelBonplan.Name = "LabelBonplan"
        Me.LabelBonplan.Size = New System.Drawing.Size(50, 13)
        Me.LabelBonplan.TabIndex = 5
        Me.LabelBonplan.Text = "Bon Plan"
        '
        'LabelMargherita
        '
        Me.LabelMargherita.AutoSize = True
        Me.LabelMargherita.Location = New System.Drawing.Point(483, 123)
        Me.LabelMargherita.Name = "LabelMargherita"
        Me.LabelMargherita.Size = New System.Drawing.Size(57, 13)
        Me.LabelMargherita.TabIndex = 6
        Me.LabelMargherita.Text = "Margherita"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1223, 635)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1000gr)
        Me.Controls.Add(Me.ComboBox500gr)
        Me.Controls.Add(Me.ComboBox250gr)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelCategorie4 As Label
    Friend WithEvents PictureBox1 As PictureBox


    Friend WithEvents Label1000gr As Label
    Friend WithEvents Label500gr As Label
    Friend WithEvents Label250gr As Label
    Friend WithEvents ComboBox250gr As ComboBox
    Friend WithEvents ComboBox500gr As ComboBox
    Friend WithEvents ComboBox1000gr As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelMargherita As Label
    Friend WithEvents LabelBonplan As Label
    Friend WithEvents Label4Fromages As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelSelectionPizza As Label
End Class
