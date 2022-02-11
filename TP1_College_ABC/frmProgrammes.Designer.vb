<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProgrammes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgrammes))
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.numNbrHeures = New System.Windows.Forms.NumericUpDown()
        Me.numNbrUnites = New System.Windows.Forms.NumericUpDown()
        Me.lblNbrHeures = New System.Windows.Forms.Label()
        Me.lblNbrUnites = New System.Windows.Forms.Label()
        Me.txtNomProg = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.mskNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.dgProgEtu = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ds1 = New TP1_College_ABC.ds()
        Me.dgProg = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrunitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrheuresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daProgEtu = New System.Data.SqlClient.SqlDataAdapter()
        Me.cmdXML = New System.Windows.Forms.Button()
        Me.grpProgramme.SuspendLayout()
        CType(Me.numNbrHeures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNbrUnites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProgEtu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProgramme
        '
        Me.grpProgramme.Controls.Add(Me.numNbrHeures)
        Me.grpProgramme.Controls.Add(Me.numNbrUnites)
        Me.grpProgramme.Controls.Add(Me.lblNbrHeures)
        Me.grpProgramme.Controls.Add(Me.lblNbrUnites)
        Me.grpProgramme.Controls.Add(Me.txtNomProg)
        Me.grpProgramme.Controls.Add(Me.lblNom)
        Me.grpProgramme.Controls.Add(Me.mskNo)
        Me.grpProgramme.Controls.Add(Me.lblNo)
        Me.grpProgramme.Enabled = False
        Me.grpProgramme.Location = New System.Drawing.Point(12, 23)
        Me.grpProgramme.Name = "grpProgramme"
        Me.grpProgramme.Size = New System.Drawing.Size(426, 226)
        Me.grpProgramme.TabIndex = 0
        Me.grpProgramme.TabStop = False
        Me.grpProgramme.Text = "PROGRAMME"
        '
        'numNbrHeures
        '
        Me.numNbrHeures.Location = New System.Drawing.Point(143, 168)
        Me.numNbrHeures.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.numNbrHeures.Name = "numNbrHeures"
        Me.numNbrHeures.Size = New System.Drawing.Size(69, 28)
        Me.numNbrHeures.TabIndex = 8
        '
        'numNbrUnites
        '
        Me.numNbrUnites.DecimalPlaces = 2
        Me.numNbrUnites.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numNbrUnites.Location = New System.Drawing.Point(144, 127)
        Me.numNbrUnites.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numNbrUnites.Name = "numNbrUnites"
        Me.numNbrUnites.Size = New System.Drawing.Size(69, 28)
        Me.numNbrUnites.TabIndex = 7
        '
        'lblNbrHeures
        '
        Me.lblNbrHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrHeures.Location = New System.Drawing.Point(16, 169)
        Me.lblNbrHeures.Name = "lblNbrHeures"
        Me.lblNbrHeures.Size = New System.Drawing.Size(121, 28)
        Me.lblNbrHeures.TabIndex = 6
        Me.lblNbrHeures.Text = "Nbr d'heures :"
        '
        'lblNbrUnites
        '
        Me.lblNbrUnites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrUnites.Location = New System.Drawing.Point(16, 127)
        Me.lblNbrUnites.Name = "lblNbrUnites"
        Me.lblNbrUnites.Size = New System.Drawing.Size(121, 28)
        Me.lblNbrUnites.TabIndex = 4
        Me.lblNbrUnites.Text = "Nbr d'unités :"
        '
        'txtNomProg
        '
        Me.txtNomProg.Location = New System.Drawing.Point(144, 85)
        Me.txtNomProg.MaxLength = 50
        Me.txtNomProg.Name = "txtNomProg"
        Me.txtNomProg.Size = New System.Drawing.Size(255, 28)
        Me.txtNomProg.TabIndex = 3
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(16, 85)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(121, 28)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom :"
        '
        'mskNo
        '
        Me.mskNo.Location = New System.Drawing.Point(144, 45)
        Me.mskNo.Mask = ">LLL.0L"
        Me.mskNo.Name = "mskNo"
        Me.mskNo.ReadOnly = True
        Me.mskNo.Size = New System.Drawing.Size(69, 28)
        Me.mskNo.TabIndex = 1
        '
        'lblNo
        '
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNo.Location = New System.Drawing.Point(16, 45)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(121, 28)
        Me.lblNo.TabIndex = 0
        Me.lblNo.Text = "No :"
        '
        'cmdNouveau
        '
        Me.cmdNouveau.Location = New System.Drawing.Point(457, 40)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(136, 37)
        Me.cmdNouveau.TabIndex = 1
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Enabled = False
        Me.cmdOk.Location = New System.Drawing.Point(457, 83)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(136, 37)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(457, 126)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(136, 37)
        Me.cmdAnnuler.TabIndex = 3
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.Enabled = False
        Me.cmdModifier.Location = New System.Drawing.Point(457, 169)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(136, 37)
        Me.cmdModifier.TabIndex = 4
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdEnlever
        '
        Me.cmdEnlever.Enabled = False
        Me.cmdEnlever.Location = New System.Drawing.Point(457, 212)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(136, 37)
        Me.cmdEnlever.TabIndex = 5
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = True
        '
        'err1
        '
        Me.err1.ContainerControl = Me
        '
        'cmdFermer
        '
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Location = New System.Drawing.Point(1056, 656)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(203, 45)
        Me.cmdFermer.TabIndex = 8
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'dgProgEtu
        '
        Me.dgProgEtu.AllowUserToAddRows = False
        Me.dgProgEtu.AllowUserToDeleteRows = False
        Me.dgProgEtu.AutoGenerateColumns = False
        Me.dgProgEtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProgEtu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn1, Me.EtudaDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn})
        Me.dgProgEtu.DataMember = "T_etudiants"
        Me.dgProgEtu.DataSource = Me.Ds1
        Me.dgProgEtu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgProgEtu.Location = New System.Drawing.Point(622, 23)
        Me.dgProgEtu.MultiSelect = False
        Me.dgProgEtu.Name = "dgProgEtu"
        Me.dgProgEtu.ReadOnly = True
        Me.dgProgEtu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProgEtu.Size = New System.Drawing.Size(638, 613)
        Me.dgProgEtu.TabIndex = 10
        '
        'PronoDataGridViewTextBoxColumn1
        '
        Me.PronoDataGridViewTextBoxColumn1.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn1.HeaderText = "No Prog"
        Me.PronoDataGridViewTextBoxColumn1.Name = "PronoDataGridViewTextBoxColumn1"
        Me.PronoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuprenomDataGridViewTextBoxColumn.Width = 219
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtunomDataGridViewTextBoxColumn.Width = 219
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "ds"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgProg
        '
        Me.dgProg.AllowUserToAddRows = False
        Me.dgProg.AllowUserToDeleteRows = False
        Me.dgProg.AutoGenerateColumns = False
        Me.dgProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn, Me.PronomDataGridViewTextBoxColumn, Me.PronbrunitesDataGridViewTextBoxColumn, Me.PronbrheuresDataGridViewTextBoxColumn})
        Me.dgProg.DataMember = "T_programme"
        Me.dgProg.DataSource = Me.Ds1
        Me.dgProg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgProg.Location = New System.Drawing.Point(12, 267)
        Me.dgProg.MultiSelect = False
        Me.dgProg.Name = "dgProg"
        Me.dgProg.ReadOnly = True
        Me.dgProg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProg.ShowEditingIcon = False
        Me.dgProg.Size = New System.Drawing.Size(581, 369)
        Me.dgProg.TabIndex = 9
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No Prog"
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronomDataGridViewTextBoxColumn
        '
        Me.PronomDataGridViewTextBoxColumn.DataPropertyName = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.PronomDataGridViewTextBoxColumn.Name = "PronomDataGridViewTextBoxColumn"
        Me.PronomDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronomDataGridViewTextBoxColumn.Width = 240
        '
        'PronbrunitesDataGridViewTextBoxColumn
        '
        Me.PronbrunitesDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.HeaderText = "Unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.Name = "PronbrunitesDataGridViewTextBoxColumn"
        Me.PronbrunitesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrheuresDataGridViewTextBoxColumn
        '
        Me.PronbrheuresDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.HeaderText = "Heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.Name = "PronbrheuresDataGridViewTextBoxColumn"
        Me.PronbrheuresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "select * from T_Programme"
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daProg
        '
        Me.daProg.DeleteCommand = Me.SqlDeleteCommand1
        Me.daProg.InsertCommand = Me.SqlInsertCommand1
        Me.daProg.SelectCommand = Me.SqlSelectCommand1
        Me.daProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.daProg.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.cn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.VarChar, 6, "pro_no")})
        '
        'daProgEtu
        '
        Me.daProgEtu.SelectCommand = Me.SqlSelectCommand2
        Me.daProgEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom")})})
        '
        'cmdXML
        '
        Me.cmdXML.Location = New System.Drawing.Point(12, 656)
        Me.cmdXML.Name = "cmdXML"
        Me.cmdXML.Size = New System.Drawing.Size(208, 43)
        Me.cmdXML.TabIndex = 15
        Me.cmdXML.Text = "Exporter les données"
        Me.cmdXML.UseVisualStyleBackColor = True
        '
        'frmProgrammes
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.cmdFermer
        Me.ClientSize = New System.Drawing.Size(1282, 713)
        Me.Controls.Add(Me.cmdXML)
        Me.Controls.Add(Me.dgProgEtu)
        Me.Controls.Add(Me.dgProg)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.cmdEnlever)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.grpProgramme)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProgrammes"
        Me.Text = "Gestion des programmes"
        Me.grpProgramme.ResumeLayout(False)
        Me.grpProgramme.PerformLayout()
        CType(Me.numNbrHeures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNbrUnites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProgEtu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProgramme As GroupBox
    Friend WithEvents mskNo As MaskedTextBox
    Friend WithEvents lblNo As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents txtNomProg As TextBox
    Friend WithEvents numNbrHeures As NumericUpDown
    Friend WithEvents numNbrUnites As NumericUpDown
    Friend WithEvents lblNbrHeures As Label
    Friend WithEvents lblNbrUnites As Label
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdEnlever As Button
    Friend WithEvents err1 As ErrorProvider
    Friend WithEvents cmdFermer As Button
    Friend WithEvents dgProg As DataGridView
    Friend WithEvents dgProgEtu As DataGridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daProg As SqlClient.SqlDataAdapter
    Friend WithEvents Ds1 As ds
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents daProgEtu As SqlClient.SqlDataAdapter
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdXML As Button
End Class
