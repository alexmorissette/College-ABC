<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApercu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApercu))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.daProgrammes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daEtudiants = New System.Data.SqlClient.SqlDataAdapter()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daProgEtu = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsRapports1 = New TP1_College_ABC.DsRapports()
        Me.DsRapportProgEtu1 = New TP1_College_ABC.dsRapportProgEtu()
        CType(Me.DsRapports1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRapportProgEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'daProgrammes
        '
        Me.daProgrammes.SelectCommand = Me.SqlSelectCommand1
        Me.daProgrammes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, etu_vil" &
    "le, etu_province, etu_telephone, etu_codepostal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants"
        Me.SqlSelectCommand2.Connection = Me.cn
        '
        'daEtudiants
        '
        Me.daEtudiants.SelectCommand = Me.SqlSelectCommand2
        Me.daEtudiants.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1324, 589)
        Me.crv.TabIndex = 0
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.cn
        '
        'daProgEtu
        '
        Me.daProgEtu.SelectCommand = Me.SqlSelectCommand3
        Me.daProgEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom")})})
        '
        'DsRapports1
        '
        Me.DsRapports1.DataSetName = "DsRapports"
        Me.DsRapports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsRapportProgEtu1
        '
        Me.DsRapportProgEtu1.DataSetName = "dsRapportProgEtu"
        Me.DsRapportProgEtu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmApercu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 589)
        Me.Controls.Add(Me.crv)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmApercu"
        Me.Text = "frmApercu"
        CType(Me.DsRapports1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRapportProgEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents daProgrammes As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapports1 As DsRapports
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents daEtudiants As SqlClient.SqlDataAdapter
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
    Friend WithEvents daProgEtu As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapportProgEtu1 As dsRapportProgEtu
End Class
