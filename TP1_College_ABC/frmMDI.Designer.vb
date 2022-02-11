<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
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
        Me.mnuMDI = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProgrammes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEtudiants = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeProgrammes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeEtudiants = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeEtuParProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daNomUser = New System.Data.SqlClient.SqlDataAdapter()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.Ds1 = New TP1_College_ABC.ds()
        Me.mnuMDI.SuspendLayout()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMDI
        '
        Me.mnuMDI.BackColor = System.Drawing.Color.LightYellow
        Me.mnuMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.ÀProposToolStripMenuItem})
        Me.mnuMDI.Location = New System.Drawing.Point(0, 0)
        Me.mnuMDI.Name = "mnuMDI"
        Me.mnuMDI.Size = New System.Drawing.Size(1223, 24)
        Me.mnuMDI.TabIndex = 1
        Me.mnuMDI.Text = "Menu"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgrammes, Me.mnuEtudiants, Me.ToolStripSeparator1, Me.mnuQuitter})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'mnuProgrammes
        '
        Me.mnuProgrammes.Name = "mnuProgrammes"
        Me.mnuProgrammes.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuProgrammes.Size = New System.Drawing.Size(183, 22)
        Me.mnuProgrammes.Text = "Programmes"
        '
        'mnuEtudiants
        '
        Me.mnuEtudiants.Name = "mnuEtudiants"
        Me.mnuEtudiants.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEtudiants.Size = New System.Drawing.Size(183, 22)
        Me.mnuEtudiants.Text = "Étudiants"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuQuitter.Size = New System.Drawing.Size(183, 22)
        Me.mnuQuitter.Text = "Quitter"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuListeProgrammes, Me.mnuListeEtudiants, Me.mnuListeEtuParProg})
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RapportsToolStripMenuItem.Text = "Rapports"
        '
        'mnuListeProgrammes
        '
        Me.mnuListeProgrammes.Name = "mnuListeProgrammes"
        Me.mnuListeProgrammes.Size = New System.Drawing.Size(257, 22)
        Me.mnuListeProgrammes.Text = "Liste des programmes"
        '
        'mnuListeEtudiants
        '
        Me.mnuListeEtudiants.Name = "mnuListeEtudiants"
        Me.mnuListeEtudiants.Size = New System.Drawing.Size(257, 22)
        Me.mnuListeEtudiants.Text = "Liste des étudiants"
        '
        'mnuListeEtuParProg
        '
        Me.mnuListeEtuParProg.Name = "mnuListeEtuParProg"
        Me.mnuListeEtuParProg.Size = New System.Drawing.Size(257, 22)
        Me.mnuListeEtuParProg.Text = "Liste des étudiants par programme"
        '
        'ÀProposToolStripMenuItem
        '
        Me.ÀProposToolStripMenuItem.Name = "ÀProposToolStripMenuItem"
        Me.ÀProposToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ÀProposToolStripMenuItem.Text = "À propos"
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUser.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(0, 613)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(1223, 19)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Utilisateur : "
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Utilisateur, No" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_login"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'daNomUser
        '
        Me.daNomUser.SelectCommand = Me.SqlSelectCommand1
        Me.daNomUser.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Utilisateur", "Utilisateur"), New System.Data.Common.DataColumnMapping("No", "No")})})
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=LAPTOP-ALEX\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=Tru" &
    "e"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "ds"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1223, 632)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.mnuMDI)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMDI
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMDI"
        Me.Text = "Programme de gestion du Collège ABC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMDI.ResumeLayout(False)
        Me.mnuMDI.PerformLayout()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMDI As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProgrammes As ToolStripMenuItem
    Friend WithEvents mnuEtudiants As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuQuitter As ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuListeProgrammes As ToolStripMenuItem
    Friend WithEvents mnuListeEtudiants As ToolStripMenuItem
    Friend WithEvents mnuListeEtuParProg As ToolStripMenuItem
    Friend WithEvents ÀProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUser As Label
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents daNomUser As SqlClient.SqlDataAdapter
    Friend WithEvents Ds1 As ds
End Class
