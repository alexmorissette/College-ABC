<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEtudiants
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtudiants))
        Me.grpEtudiant = New System.Windows.Forms.GroupBox()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.mskCodePostal = New System.Windows.Forms.MaskedTextBox()
        Me.cbProvince = New System.Windows.Forms.ComboBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblCodePostal = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.grpGenre = New System.Windows.Forms.GroupBox()
        Me.optMasculin = New System.Windows.Forms.RadioButton()
        Me.optFeminin = New System.Windows.Forms.RadioButton()
        Me.txtEtuNom = New System.Windows.Forms.TextBox()
        Me.txtEtuPrenom = New System.Windows.Forms.TextBox()
        Me.cbEtuNoProg = New System.Windows.Forms.ComboBox()
        Me.Ds1 = New TP1_College_ABC.ds()
        Me.mskEtuDA = New System.Windows.Forms.MaskedTextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.dgEtu = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtusexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtucodepostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtutelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daEtu = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daNoProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.cmdXML = New System.Windows.Forms.Button()
        Me.grpEtudiant.SuspendLayout()
        Me.grpGenre.SuspendLayout()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEtudiant
        '
        Me.grpEtudiant.Controls.Add(Me.mskTel)
        Me.grpEtudiant.Controls.Add(Me.mskCodePostal)
        Me.grpEtudiant.Controls.Add(Me.cbProvince)
        Me.grpEtudiant.Controls.Add(Me.txtVille)
        Me.grpEtudiant.Controls.Add(Me.txtAdresse)
        Me.grpEtudiant.Controls.Add(Me.lblTelephone)
        Me.grpEtudiant.Controls.Add(Me.lblCodePostal)
        Me.grpEtudiant.Controls.Add(Me.lblProvince)
        Me.grpEtudiant.Controls.Add(Me.lblVille)
        Me.grpEtudiant.Controls.Add(Me.lblAdresse)
        Me.grpEtudiant.Controls.Add(Me.grpGenre)
        Me.grpEtudiant.Controls.Add(Me.txtEtuNom)
        Me.grpEtudiant.Controls.Add(Me.txtEtuPrenom)
        Me.grpEtudiant.Controls.Add(Me.cbEtuNoProg)
        Me.grpEtudiant.Controls.Add(Me.mskEtuDA)
        Me.grpEtudiant.Controls.Add(Me.lblNom)
        Me.grpEtudiant.Controls.Add(Me.lblPrenom)
        Me.grpEtudiant.Controls.Add(Me.lblNoProg)
        Me.grpEtudiant.Controls.Add(Me.Label1)
        Me.grpEtudiant.Enabled = False
        Me.grpEtudiant.Location = New System.Drawing.Point(24, 29)
        Me.grpEtudiant.Name = "grpEtudiant"
        Me.grpEtudiant.Size = New System.Drawing.Size(934, 281)
        Me.grpEtudiant.TabIndex = 0
        Me.grpEtudiant.TabStop = False
        Me.grpEtudiant.Text = "ÉTUDIANT"
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(545, 202)
        Me.mskTel.Mask = "(000) 000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(126, 28)
        Me.mskTel.TabIndex = 18
        '
        'mskCodePostal
        '
        Me.mskCodePostal.Location = New System.Drawing.Point(545, 161)
        Me.mskCodePostal.Mask = ">L0L-0L0"
        Me.mskCodePostal.Name = "mskCodePostal"
        Me.mskCodePostal.Size = New System.Drawing.Size(79, 28)
        Me.mskCodePostal.TabIndex = 17
        '
        'cbProvince
        '
        Me.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvince.FormattingEnabled = True
        Me.cbProvince.Items.AddRange(New Object() {"Alberta", "Colombie-Britannique", "Ile-du-Prince-Edouard", "Manitoba", "Nouveau-Brunswick", "Nouvelle-Écosse", "Ontario", "Québec", "Saskatchewan", "Terre-Neuve/Labrador"})
        Me.cbProvince.Location = New System.Drawing.Point(546, 120)
        Me.cbProvince.MaxDropDownItems = 10
        Me.cbProvince.Name = "cbProvince"
        Me.cbProvince.Size = New System.Drawing.Size(249, 28)
        Me.cbProvince.Sorted = True
        Me.cbProvince.TabIndex = 16
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(545, 81)
        Me.txtVille.MaxLength = 50
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(250, 28)
        Me.txtVille.TabIndex = 15
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(545, 42)
        Me.txtAdresse.MaxLength = 100
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(352, 28)
        Me.txtAdresse.TabIndex = 14
        '
        'lblTelephone
        '
        Me.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelephone.Location = New System.Drawing.Point(424, 202)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(115, 28)
        Me.lblTelephone.TabIndex = 13
        Me.lblTelephone.Text = "Téléphone :"
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodePostal
        '
        Me.lblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodePostal.Location = New System.Drawing.Point(424, 161)
        Me.lblCodePostal.Name = "lblCodePostal"
        Me.lblCodePostal.Size = New System.Drawing.Size(115, 28)
        Me.lblCodePostal.TabIndex = 12
        Me.lblCodePostal.Text = "Code Postal :"
        Me.lblCodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProvince
        '
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProvince.Location = New System.Drawing.Point(424, 120)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(115, 28)
        Me.lblProvince.TabIndex = 11
        Me.lblProvince.Text = "Province :"
        Me.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(424, 80)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(115, 28)
        Me.lblVille.TabIndex = 10
        Me.lblVille.Text = "Ville :"
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdresse
        '
        Me.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresse.Location = New System.Drawing.Point(424, 41)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(115, 28)
        Me.lblAdresse.TabIndex = 9
        Me.lblAdresse.Text = "Adresse :"
        Me.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpGenre
        '
        Me.grpGenre.Controls.Add(Me.optMasculin)
        Me.grpGenre.Controls.Add(Me.optFeminin)
        Me.grpGenre.Location = New System.Drawing.Point(22, 202)
        Me.grpGenre.Name = "grpGenre"
        Me.grpGenre.Size = New System.Drawing.Size(243, 57)
        Me.grpGenre.TabIndex = 8
        Me.grpGenre.TabStop = False
        Me.grpGenre.Text = "Genre"
        '
        'optMasculin
        '
        Me.optMasculin.AutoSize = True
        Me.optMasculin.Checked = True
        Me.optMasculin.Location = New System.Drawing.Point(122, 24)
        Me.optMasculin.Name = "optMasculin"
        Me.optMasculin.Size = New System.Drawing.Size(92, 24)
        Me.optMasculin.TabIndex = 1
        Me.optMasculin.TabStop = True
        Me.optMasculin.Tag = "M"
        Me.optMasculin.Text = "Masculin"
        Me.optMasculin.UseVisualStyleBackColor = True
        '
        'optFeminin
        '
        Me.optFeminin.AutoSize = True
        Me.optFeminin.Location = New System.Drawing.Point(7, 24)
        Me.optFeminin.Name = "optFeminin"
        Me.optFeminin.Size = New System.Drawing.Size(86, 24)
        Me.optFeminin.TabIndex = 0
        Me.optFeminin.Tag = "F"
        Me.optFeminin.Text = "Féminin"
        Me.optFeminin.UseVisualStyleBackColor = True
        '
        'txtEtuNom
        '
        Me.txtEtuNom.Location = New System.Drawing.Point(143, 161)
        Me.txtEtuNom.MaxLength = 20
        Me.txtEtuNom.Name = "txtEtuNom"
        Me.txtEtuNom.Size = New System.Drawing.Size(250, 28)
        Me.txtEtuNom.TabIndex = 7
        '
        'txtEtuPrenom
        '
        Me.txtEtuPrenom.Location = New System.Drawing.Point(144, 120)
        Me.txtEtuPrenom.MaxLength = 20
        Me.txtEtuPrenom.Name = "txtEtuPrenom"
        Me.txtEtuPrenom.Size = New System.Drawing.Size(250, 28)
        Me.txtEtuPrenom.TabIndex = 6
        '
        'cbEtuNoProg
        '
        Me.cbEtuNoProg.DataSource = Me.Ds1
        Me.cbEtuNoProg.DisplayMember = "T_programme.pro_no"
        Me.cbEtuNoProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEtuNoProg.FormattingEnabled = True
        Me.cbEtuNoProg.Location = New System.Drawing.Point(144, 80)
        Me.cbEtuNoProg.Name = "cbEtuNoProg"
        Me.cbEtuNoProg.Size = New System.Drawing.Size(92, 28)
        Me.cbEtuNoProg.TabIndex = 5
        Me.cbEtuNoProg.ValueMember = "T_programme.pro_no"
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "ds"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mskEtuDA
        '
        Me.mskEtuDA.Location = New System.Drawing.Point(144, 41)
        Me.mskEtuDA.Mask = "0000000"
        Me.mskEtuDA.Name = "mskEtuDA"
        Me.mskEtuDA.ReadOnly = True
        Me.mskEtuDA.Size = New System.Drawing.Size(92, 28)
        Me.mskEtuDA.TabIndex = 4
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(22, 161)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(115, 28)
        Me.lblNom.TabIndex = 3
        Me.lblNom.Text = "Nom :"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(22, 120)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(115, 28)
        Me.lblPrenom.TabIndex = 2
        Me.lblPrenom.Text = "Prénom :"
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoProg
        '
        Me.lblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoProg.Location = New System.Drawing.Point(22, 80)
        Me.lblNoProg.Name = "lblNoProg"
        Me.lblNoProg.Size = New System.Drawing.Size(115, 28)
        Me.lblNoProg.TabIndex = 1
        Me.lblNoProg.Text = "No Prog :"
        Me.lblNoProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(22, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DA :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdEnlever
        '
        Me.cmdEnlever.Location = New System.Drawing.Point(983, 218)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(136, 37)
        Me.cmdEnlever.TabIndex = 10
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.Location = New System.Drawing.Point(983, 175)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(136, 37)
        Me.cmdModifier.TabIndex = 9
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(983, 132)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(136, 37)
        Me.cmdAnnuler.TabIndex = 8
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Enabled = False
        Me.cmdOk.Location = New System.Drawing.Point(983, 89)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(136, 37)
        Me.cmdOk.TabIndex = 7
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdNouveau
        '
        Me.cmdNouveau.Location = New System.Drawing.Point(983, 46)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(136, 37)
        Me.cmdNouveau.TabIndex = 6
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = True
        '
        'err1
        '
        Me.err1.ContainerControl = Me
        '
        'cmdFermer
        '
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Location = New System.Drawing.Point(952, 775)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(172, 43)
        Me.cmdFermer.TabIndex = 12
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'dgEtu
        '
        Me.dgEtu.AllowUserToAddRows = False
        Me.dgEtu.AllowUserToDeleteRows = False
        Me.dgEtu.AutoGenerateColumns = False
        Me.dgEtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn, Me.EtusexeDataGridViewTextBoxColumn, Me.EtuadresseDataGridViewTextBoxColumn, Me.EtuvilleDataGridViewTextBoxColumn, Me.EtuprovinceDataGridViewTextBoxColumn, Me.EtucodepostalDataGridViewTextBoxColumn, Me.EtutelephoneDataGridViewTextBoxColumn})
        Me.dgEtu.DataMember = "T_etudiants"
        Me.dgEtu.DataSource = Me.Ds1
        Me.dgEtu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgEtu.Location = New System.Drawing.Point(24, 332)
        Me.dgEtu.MultiSelect = False
        Me.dgEtu.Name = "dgEtu"
        Me.dgEtu.ReadOnly = True
        Me.dgEtu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtu.ShowEditingIcon = False
        Me.dgEtu.Size = New System.Drawing.Size(1117, 423)
        Me.dgEtu.TabIndex = 13
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtudaDataGridViewTextBoxColumn.Width = 80
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No prog"
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronoDataGridViewTextBoxColumn.Width = 90
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuprenomDataGridViewTextBoxColumn.Width = 120
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtunomDataGridViewTextBoxColumn.Width = 120
        '
        'EtusexeDataGridViewTextBoxColumn
        '
        Me.EtusexeDataGridViewTextBoxColumn.DataPropertyName = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.EtusexeDataGridViewTextBoxColumn.Name = "EtusexeDataGridViewTextBoxColumn"
        Me.EtusexeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtusexeDataGridViewTextBoxColumn.Width = 50
        '
        'EtuadresseDataGridViewTextBoxColumn
        '
        Me.EtuadresseDataGridViewTextBoxColumn.DataPropertyName = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.Name = "EtuadresseDataGridViewTextBoxColumn"
        Me.EtuadresseDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuadresseDataGridViewTextBoxColumn.Width = 180
        '
        'EtuvilleDataGridViewTextBoxColumn
        '
        Me.EtuvilleDataGridViewTextBoxColumn.DataPropertyName = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.EtuvilleDataGridViewTextBoxColumn.Name = "EtuvilleDataGridViewTextBoxColumn"
        Me.EtuvilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprovinceDataGridViewTextBoxColumn
        '
        Me.EtuprovinceDataGridViewTextBoxColumn.DataPropertyName = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.EtuprovinceDataGridViewTextBoxColumn.Name = "EtuprovinceDataGridViewTextBoxColumn"
        Me.EtuprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtucodepostalDataGridViewTextBoxColumn
        '
        Me.EtucodepostalDataGridViewTextBoxColumn.DataPropertyName = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.HeaderText = "Code Postal"
        Me.EtucodepostalDataGridViewTextBoxColumn.Name = "EtucodepostalDataGridViewTextBoxColumn"
        Me.EtucodepostalDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtucodepostalDataGridViewTextBoxColumn.Width = 120
        '
        'EtutelephoneDataGridViewTextBoxColumn
        '
        Me.EtutelephoneDataGridViewTextBoxColumn.DataPropertyName = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.EtutelephoneDataGridViewTextBoxColumn.Name = "EtutelephoneDataGridViewTextBoxColumn"
        Me.EtutelephoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtutelephoneDataGridViewTextBoxColumn.Width = 120
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_etudiants.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=LAPTOP-ALEX\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=Tru" &
    "e"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEtu
        '
        Me.daEtu.DeleteCommand = Me.SqlDeleteCommand1
        Me.daEtu.InsertCommand = Me.SqlInsertCommand1
        Me.daEtu.SelectCommand = Me.SqlSelectCommand1
        Me.daEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.daEtu.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "select * from T_Programme"
        Me.SqlSelectCommand2.Connection = Me.cn
        '
        'daNoProg
        '
        Me.daNoProg.SelectCommand = Me.SqlSelectCommand2
        Me.daNoProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        '
        'cmdXML
        '
        Me.cmdXML.Location = New System.Drawing.Point(24, 775)
        Me.cmdXML.Name = "cmdXML"
        Me.cmdXML.Size = New System.Drawing.Size(208, 43)
        Me.cmdXML.TabIndex = 14
        Me.cmdXML.Text = "Exporter les données"
        Me.cmdXML.UseVisualStyleBackColor = True
        '
        'frmEtudiants
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.cmdFermer
        Me.ClientSize = New System.Drawing.Size(1153, 841)
        Me.Controls.Add(Me.cmdXML)
        Me.Controls.Add(Me.dgEtu)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.cmdEnlever)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.grpEtudiant)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEtudiants"
        Me.Text = "Gestion des étudiants"
        Me.grpEtudiant.ResumeLayout(False)
        Me.grpEtudiant.PerformLayout()
        Me.grpGenre.ResumeLayout(False)
        Me.grpGenre.PerformLayout()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEtudiant As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents txtEtuPrenom As TextBox
    Friend WithEvents cbEtuNoProg As ComboBox
    Friend WithEvents mskEtuDA As MaskedTextBox
    Friend WithEvents txtEtuNom As TextBox
    Friend WithEvents grpGenre As GroupBox
    Friend WithEvents optMasculin As RadioButton
    Friend WithEvents optFeminin As RadioButton
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblCodePostal As Label
    Friend WithEvents lblProvince As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents mskCodePostal As MaskedTextBox
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents cmdEnlever As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents err1 As ErrorProvider
    Friend WithEvents cmdFermer As Button
    Friend WithEvents dgEtu As DataGridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daEtu As SqlClient.SqlDataAdapter
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ds1 As ds
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents daNoProg As SqlClient.SqlDataAdapter
    Friend WithEvents cmdXML As Button
End Class
