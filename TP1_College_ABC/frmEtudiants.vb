'Titre: Gestion des étudiants
'Description: Formulaire pour la gestion des étudiants du College ABC. Ici, l'utilisateur peut consulter, créer et modifier les étudiants.
'Fait par : Alex Morissette
'Le : 31/08/2021
'Révisé le : 06/09/2021

Imports System.Data.SqlClient

Public Class frmEtudiants
    ' Variable d'instance
    ' SQL
    'Dim sqlAllEtu As String = "Select * from T_Etudiants order by pro_no"
    Dim actionCourante As Action = Action.Aucune
    Dim pos As Integer = -1

    ''' <summary>
    ''' Procédure qui effectue les actions au chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Remplir le comboBox des programmes
            daNoProg.Fill(Ds1.T_programme)
            ' Remplir le ListView des étudiants
            daEtu.Fill(Ds1.T_etudiants)

            If Ds1.T_etudiants.Rows.Count > 0 Then
                pos = 0
                dgEtu.Focus()
                RecupererEtudiant(pos)
                Debarrer(cmdModifier, cmdEnlever)
            Else
                pos = -1
                Barrer(cmdAnnuler, cmdEnlever, cmdModifier, cmdOk, grpEtudiant)
            End If
            AddHandler dgEtu.SelectionChanged, AddressOf dgEtu_SelectionChanged
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    '******************** VALIDATION *********************************

    ''' <summary>
    ''' Function qui permet de valider le contenu des champs
    ''' </summary>
    ''' <returns>Vrai si tous les champs sont corrects</returns>
    Private Function ValiderChamps()
        Dim valide As Boolean = True
        Dim i As Integer = 0
        err1.Clear()
        '*****************DA ********************
        If mskEtuDA.MaskFull = False Then
            err1.SetError(mskEtuDA, "Entrez le DA.")
            valide = False
            mskEtuDA.Focus()
        End If
        '****************** PRENOM *****************
        If txtEtuPrenom.Text.Trim = "" Then
            err1.SetError(txtEtuPrenom, "Entrez le prénom")
            valide = False
            txtEtuPrenom.Focus()
        End If

        ' Valider qu'il n'y ai pas seulement des "-", ".", " " ou "'"
        valide = RefuserCaractereSeul(txtEtuPrenom)

        '******************NOM*********************
        If txtEtuNom.Text.Trim = "" Then
            err1.SetError(txtEtuNom, "Entrez le nom")
            valide = False
            txtEtuNom.Focus()
        End If

        ' Valider qu'il n'y ai pas seulement des "-", ".", " " ou "'"
        valide = RefuserCaractereSeul(txtEtuNom)

        '**********************ADRESSE******************
        If txtAdresse.Text.Trim = "" Then
            err1.SetError(txtAdresse, "Entrez l'adresse")
            valide = False
            txtAdresse.Focus()
        End If

        ' Valider qu'il n'y ai pas seulement des "-", ".", " " ou "'"
        valide = RefuserCaractereSeul(txtAdresse)

        '***********************VILLE*********************
        If txtVille.Text.Trim = "" Then
            err1.SetError(txtVille, "Entrez la ville")
            valide = False
            txtVille.Focus()
        End If

        ' Valider qu'il n'y ai pas seulement des "-", ".", " " ou "'"
        valide = RefuserCaractereSeul(txtVille)

        '*********************CODE POSTAL********************
        If mskCodePostal.MaskFull = False Then
            err1.SetError(mskCodePostal, "Entrez le code postal.")
            valide = False
            mskCodePostal.Focus()
        End If
        '*********************TELEPHONE********************
        If mskTel.MaskFull = False Then
            err1.SetError(mskTel, "Entrez le téléphone.")
            valide = False
            mskTel.Focus()
        End If
        Return valide
    End Function

    ''' <summary>
    ''' Fonction qui permet de valider que l'utilisateur n'entre pas seulement autre chose que les caractères permis. 
    ''' </summary>
    ''' <returns>Faux si erreur, vrai si pas d'erreur</returns>
    Public Function RefuserCaractereSeul(ctrl As Control) As Boolean
        Dim charCollection() As Char = {".", "-", "'"}
        Dim c As Char
        Dim valide As Boolean = True
        Dim cptChar As Integer = 0
        Dim cptSpace As Integer = 0
        ' Compter les espaces à l'intérieur de la string
        For Each c In ctrl.Text.Trim
            If c = " " Then
                cptSpace += 1
            End If
        Next
        ' Compter les char de la charCollection
        For i = 0 To charCollection.Length - 1
            For Each c In ctrl.Text.Trim
                If c = charCollection(i) Then
                    cptChar += 1
                End If
            Next
        Next
        If cptChar + cptSpace = ctrl.Text.Trim.Length Then
            err1.SetError(ctrl, "Entrée invalide")
            valide = False
            ctrl.Focus()
            cptChar = 0
            cptSpace = 0
        End If
        Return valide
    End Function

    ''' <summary>
    ''' Procédure qui permet de valider la saisie du prénom de l'étudiant.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValiderPrenom(sender As Object, e As KeyPressEventArgs) Handles txtEtuPrenom.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) Or
            Char.IsLetter(e.KeyChar) Or
            e.KeyChar = Chr(8) Or
            e.KeyChar = "-" Then
            Return
        Else
            e.KeyChar = ""
        End If
    End Sub

    ''' <summary>
    ''' Procédure qui permet de valider la saisie du nom de l'étudiant et du nom de la ville
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValiderNom(sender As Object, e As KeyPressEventArgs) Handles txtEtuNom.KeyPress, txtVille.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) Or
            Char.IsLetter(e.KeyChar) Or
            e.KeyChar = Chr(8) Or
            e.KeyChar = "-" Or
            e.KeyChar = "'" Then
            Return
        Else
            e.KeyChar = ""
        End If
    End Sub

    ''' <summary>
    ''' Procédure qui permet de valider la saisie de l'adresse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValiderAdresse(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) Or
            Char.IsLetterOrDigit(e.KeyChar) Or
            e.KeyChar = Chr(8) Or
            e.KeyChar = "-" Or
            e.KeyChar = "'" Or
            e.KeyChar = "." Then
            Return
        Else
            e.KeyChar = ""
        End If
    End Sub

    ''' <summary>
    ''' Fonction qui permet de valider le caractère unique du DA lors de l'ajout d'un étudiant.
    ''' </summary>
    ''' <returns>Vrai si le DA est unique, faux s'il ne l'est pas </returns>
    Private Function ValiderDA() As Boolean
        Dim ok As Boolean = True
        Dim i As Integer
        For i = 0 To dgEtu.Rows.Count - 1
            If dgEtu.Rows(i).Cells(0).Value = mskEtuDA.Text Then
                MsgBox("Ce DA existe déja. Veuillez en choisir un autre.")
                ok = False
                Exit For
            End If
        Next
        Return ok
    End Function

    '******************************** CMD ******************************

    ''' <summary>
    ''' Procédure qui permet d'activer les contrôles pour inscrire un nouvel étudiant.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Try
            ' Définir l'action courante 
            actionCourante = Action.Ajout
            ' Vider les champs
            ViderChamps(grpEtudiant)
            ' Mettre les valeurs par défaut
            mskEtuDA.ReadOnly = False
            cbProvince.SelectedIndex = 7 ' Québec
            cbEtuNoProg.SelectedIndex = 0 ' LEA.1A
            txtVille.Text = "Chicoutimi"
            Debarrer(cmdOk, cmdAnnuler, grpEtudiant)
            Barrer(dgEtu, cmdNouveau, cmdModifier, cmdEnlever)
            mskEtuDA.Focus()

            ' Garder la position dans le DG
            'dgEtu.Rows(dgEtu.CurrentCell.RowIndex).Selected = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet d'appeler les blocs de code selon l'action courante (ajout ou modification) afin de finaliser l'opération.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Try
            'Valider la présence de contenu dans les champs
            If ValiderChamps() = True Then
                err1.Clear()
                ' Si en mode ajout
                If actionCourante = Action.Ajout Then
                    ' Si le DA est unique
                    If ValiderDA() Then
                        ' ***** ON PEUT AJOUTER L'ÉTUDIANT *****
                        AjouterEtudiant()
                        ' Demander si l'utilisateur veut ajouter un aute étudiant
                        If MsgBox("Voulez-vous ajouter un autre étudiant?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Nouvel étudiant") = DialogResult.Yes Then
                            cmdNouveau.PerformClick()
                        End If
                    Else
                        mskEtuDA.Clear()
                        mskEtuDA.Focus()
                    End If
                Else
                    ' ***** ON PEUT MODIFIER LES INFORMATIONS DE L'ÉTUDIANT ****
                    ModifierEtudiant()
                End If
            End If
            dgEtu.Focus()
        Catch ex As Exception
            GestionErreurs(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Procédure qui permet d'annuler l'action courante
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click

        ' Barrer, débarrer les contrôles
        If dgEtu.Rows.Count > 0 Then
            Barrer(grpEtudiant, cmdAnnuler, cmdOk, cmdEnlever)
            Debarrer(dgEtu, cmdNouveau, cmdModifier, cmdEnlever)
            ' Se positionner sur l'étudiant comme avant
            'pos = dgEtu.CurrentCell.RowIndex
            RecupererEtudiant(pos)
            'AddHandler dgEtu.SelectionChanged, AddressOf dgEtu_SelectionChanged
        Else
            Barrer(grpEtudiant, cmdAnnuler, cmdOk, cmdEnlever, cmdModifier)
            Debarrer(dgEtu, cmdNouveau)
            ViderChamps(grpEtudiant)
            pos = -1
        End If
        dgEtu.Focus()
        err1.Clear()
        actionCourante = Action.Aucune
    End Sub

    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        ' Mode ajout
        actionCourante = Action.Modification
        ' barrer et débarrer les contrôles
        Debarrer(cmdOk, cmdAnnuler, grpEtudiant)
        Barrer(dgEtu, cmdModifier, cmdNouveau, cmdEnlever)
        txtEtuPrenom.Focus()
        'Garder la position dans le dg
        'dgEtu.Rows(dgEtu.CurrentCell.RowIndex).Selected = True

    End Sub

    ''' <summary>
    ''' Procédure qui demande la confirmation avant de supprimer un étudiant puis qui appelle la méthode EnleverEtudian()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
        ' Demander la confirmation
        If MsgBox("Voulez-vous vraiment supprimer cet étudiant " & "(" & txtEtuPrenom.Text & " " & txtEtuNom.Text & ") ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = DialogResult.Yes Then
            actionCourante = Action.Supprimer
            EnleverEtudiant()
            actionCourante = Action.Aucune
        Else
            dgEtu.Focus()
        End If
    End Sub

    Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
        Me.Close()
    End Sub


    '**************************** AUTRES SUBS ET FONCTIONS ******************************
    ''' <summary>
    ''' Procédure qui permet de récupérer un étudiant pour le faire afficher ses informations dans les champs
    ''' </summary>
    ''' <param name="no"></param>
    Private Sub RecupererEtudiant(no As Integer)
        Try

            Dim L As ds.T_etudiantsRow = Ds1.T_etudiants.Rows(no)
            ' 1 - assigner le contenu de la ligne aux champs
            mskEtuDA.Text = L.etu_da
            cbEtuNoProg.SelectedValue = L.pro_no
            txtEtuPrenom.Text = L.etu_prenom
            txtEtuNom.Text = L.etu_nom
            If L.etu_sexe.ToString = "M" Then
                optMasculin.Checked = True
            Else
                optFeminin.Checked = True
            End If
            txtAdresse.Text = L.etu_adresse
            txtVille.Text = L.etu_ville
            cbProvince.Text = L.etu_province
            mskCodePostal.Text = L.etu_codepostal
            mskTel.Text = L.etu_telephone

        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub



    ''' <summary>
    ''' Procédure permettant d'ajouter un étudiant
    ''' </summary>
    Private Sub AjouterEtudiant()
        Try

            ' Créer la ligne
            Dim L As ds.T_etudiantsRow
            L = Ds1.T_etudiants.NewT_etudiantsRow
            ' Assigner les valeurs à la ligne
            L.etu_da = mskEtuDA.Text
            L.pro_no = cbEtuNoProg.SelectedValue
            L.etu_prenom = txtEtuPrenom.Text
            L.etu_nom = txtEtuNom.Text
            If optMasculin.Checked = True Then
                L.etu_sexe = "M"
            Else
                L.etu_sexe = "F"
            End If
            L.etu_adresse = txtAdresse.Text
            L.etu_ville = txtVille.Text
            L.etu_province = cbProvince.Text
            L.etu_codepostal = mskCodePostal.Text
            L.etu_telephone = mskTel.Text

            ' Ajouter au Dataset
            Ds1.T_etudiants.Rows.Add(L)
            'Mettre à jour la BD
            daEtu.Update(Ds1.T_etudiants)
            'Mettre à jour le dg
            daEtu.Fill(Ds1.T_etudiants)
            ' ReadOnly le DA
            mskEtuDA.ReadOnly = True
            ' Se positionner sur le nouvel étudiant dans le dg
            dgEtu.Rows(dgEtu.Rows.Count - 1).Selected = True
            ' Remplir les champs du nouvel étudiant
            'RecupererEtudiant(pos)

            Barrer(grpEtudiant, cmdAnnuler, cmdOk, cmdEnlever)
            Debarrer(dgEtu, cmdNouveau, cmdModifier, cmdEnlever)

            MsgBox("Étudiant ajouté avec succès!")

        Catch ex As SqlException
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        Catch ex As Exception
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procédure permettant d'inscrire à la BD les modifications faites aux informations d'un étudiant.
    ''' </summary>
    Private Sub ModifierEtudiant()
        Try

            ' Assigner les valeurs à la ligne
            Dim L As ds.T_etudiantsRow
            L = Ds1.T_etudiants.Rows(pos)
            L.etu_da = mskEtuDA.Text
            L.pro_no = cbEtuNoProg.SelectedValue
            L.etu_prenom = txtEtuPrenom.Text
            L.etu_nom = txtEtuNom.Text
            If optMasculin.Checked = True Then
                L.etu_sexe = "M"
            Else
                L.etu_sexe = "F"
            End If
            L.etu_adresse = txtAdresse.Text
            L.etu_ville = txtVille.Text
            L.etu_province = cbProvince.Text
            L.etu_codepostal = mskCodePostal.Text
            L.etu_telephone = mskTel.Text
            'Mettre à jour la BD
            daEtu.Update(Ds1.T_etudiants)

            MsgBox("Étudiant modifié avec succès!")

            daEtu.Fill(Ds1.T_etudiants)

            mskEtuDA.ReadOnly = True

            Barrer(grpEtudiant, cmdAnnuler, cmdOk, cmdEnlever)
            Debarrer(dgEtu, cmdNouveau, cmdModifier, cmdEnlever)

        Catch ex As SqlException
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        Catch ex As Exception
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procédure permettant d'enlever un étudiant de la liste
    ''' </summary>
    Private Sub EnleverEtudiant()
        Try

            Ds1.T_etudiants.Rows(pos).Delete()
            daEtu.Update(Ds1.T_etudiants)

            If dgEtu.Rows.Count > 0 Then
                pos = dgEtu.CurrentCell.RowIndex
                RecupererEtudiant(pos)
                Barrer(grpEtudiant, cmdAnnuler, cmdOk, cmdEnlever)
                Debarrer(dgEtu, cmdNouveau, cmdModifier, cmdEnlever)
                dgEtu.Select()
            Else
                pos = -1
                ViderChamps(grpEtudiant)
                Barrer(dgEtu, cmdModifier, cmdEnlever)
            End If
            MsgBox("Étudiant enlevé avec succès!", MessageBoxIcon.Information, "Succès")

        Catch ex As SqlException
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        Catch ex As Exception
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub

    ' ************************* NAVIGATION **************************

    Private Sub dgEtu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEtu.CellClick
        Dim b As DataGridView = sender
        If dgEtu.Rows.Count > 0 Then
            pos = b.CurrentCell.RowIndex
            RecupererEtudiant(pos)
        End If
    End Sub

    Private Sub dgEtu_SelectionChanged(sender As Object, e As EventArgs) 'Handles dgEtu.SelectionChanged
        Dim b As DataGridView = sender
        If dgEtu.Rows.Count > 0 Then
            If actionCourante = Action.Ajout Then
                pos = dgEtu.Rows.Count - 1
                RecupererEtudiant(pos)
                actionCourante = Action.Aucune
            ElseIf actionCourante = Action.Supprimer Then
                pos = 0
            ElseIf actionCourante = Action.Modification Then
                pos = b.CurrentCell.RowIndex
                RecupererEtudiant(pos)
            Else
                pos = b.CurrentCell.RowIndex
                RecupererEtudiant(pos)
            End If
        End If
    End Sub

    Private Sub cmdXML_Click(sender As Object, e As EventArgs) Handles cmdXML.Click
        Try
            ' Confirmation
            If MsgBox("Vous allez exporter la liste des étudiants dans un fichier .xml et un fichier .xsd. " & vbCrLf & "Leur emplacement sera : '..\TP2_College_ABC\TP1_College_ABC\bin\Debug' ",
                      MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Confirmation") = DialogResult.Yes Then
                Ds1.T_etudiants.WriteXml("Etudiants.xml")
                Ds1.T_etudiants.WriteXmlSchema("Etudiants.xsd")
                MsgBox("Fichiers exportés avec succès!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class