'Titre: Gestion des programmes
'Description: Formulaire pour la gestion des programmes scolaires du College ABC. Ici, l'utilisateur peut consulter, créer et modifier des programmes.
' Il peut aussi voir, en cliquant sur un programme, la liste des étudiants qui font partie de ce programme.
'Fait par : Alex Morissette
'Le : 31/08/2021
'Révisé le : 06/09/2021

Imports System.Data.SqlClient
Public Class frmProgrammes

    ' Variables d'instance
    Dim actionCourante As Action = Action.Aucune
    'Dim sqlAllProg As String = "ListerTousProgrammes"
    Dim pos As Integer = -1

    ''' <summary>
    ''' Procédure qui effectue les actions au chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmProgrammes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ' Remplirdg
            daProg.Fill(Ds1.T_programme)

            If Ds1.T_programme.Rows.Count <> 0 Then ' S'il y a des programmes dans le DataSet
                pos = 0
                RecupererProgramme(pos)
                ListerProgEtu()
                Debarrer(cmdModifier)
                'dgProg.Focus()
            Else
                ' S'il n'y a pas de programme
                pos = -1
                Barrer(cmdAnnuler, cmdEnlever, cmdModifier, cmdOk, grpProgramme)
            End If
            AddHandler dgProg.SelectionChanged, AddressOf dgProg_SelectionChanged
            dgProg.Focus()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procédure qui permet de valider la saisie du nom du programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtNomProg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomProg.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "-" Or e.KeyChar = Chr(8) Then
            Return
        Else
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Procedure qui permet d'activer les contrôles pour inscrire un nouveau programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Try
            ' Mode ajout
            actionCourante = Action.Ajout
            ' 2 vider les champs
            ViderChamps(grpProgramme)
            ' Mettre les valeur par défaut
            mskNo.ReadOnly = False
            numNbrUnites.Value = Val(53.66)
            numNbrHeures.Value = 1575
            mskNo.Text = "LEA"
            ' barrer et débarrer les contrôles
            Debarrer(cmdOk, cmdAnnuler, grpProgramme)
            Barrer(dgProg, dgProgEtu, cmdModifier, cmdNouveau, cmdEnlever)
            mskNo.Focus()
            '3 Garder sur quel programme nous étions avant de cliquer sur le bouton
            'If dgProg.Rows.Count > 0 Then
            '    pos =
            'Else
            '    noProg = -1
            'End If
            'lvProg.SelectedIndices.Clear()

        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet, en fonction de l'action courante, d'accéder aux procédures d'ajout ou de modification d'un programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Try
            ' Valider s'il y a du contenu dans les champs
            If ValiderChamps() Then
                err1.Clear()
                If actionCourante = Action.Ajout Then
                    If ValiderNoProg() Then ' Si (vrai) -> le code du programme n'est pas un doublon
                        '*** ON PEUT AJOUTER LE PROGRAME****
                        AjouterProgramme()
                        actionCourante = Action.Aucune
                        If MsgBox("Voulez-vous ajouter un autre programme?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Nouveau programme") = DialogResult.Yes Then
                            cmdNouveau.PerformClick()
                            ' Else
                            'pos = dgProg.Rows.Count - 1
                            'RecupererProgramme(pos)
                            'cmdAnnuler.PerformClick()
                        End If

                    Else ' Faux -> le code du programme est un doublon, on revient
                        mskNo.Text = "LEA"
                        mskNo.Focus()
                        Exit Sub
                    End If
                Else
                    '*** ON PEUT MODIFIER LE PROGRAMME
                    ModifierProgramme()
                    mskNo.ReadOnly = True
                    ' Revenir à l'état précedant l'action ajout
                    'Remplir_ListView(lvProg, sqlAllProg, "pro_no")
                    cmdAnnuler.PerformClick()
                End If
            End If
            dgProg.Focus()
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procédure qui permet d'ajouter un nouveau programme à la Base de données 
    ''' </summary>
    Private Sub AjouterProgramme()
        Try
            ' Créer la ligne
            Dim L As ds.T_programmeRow
            L = Ds1.T_programme.NewT_programmeRow
            ' Assigner les valeurs à la ligne
            L.pro_no = mskNo.Text
            L.pro_nom = txtNomProg.Text.Trim
            L.pro_nbr_unites = numNbrUnites.Value
            L.pro_nbr_heures = numNbrHeures.Value
            ' Ajouter au Dataset
            Ds1.T_programme.Rows.Add(L)
            'Mettre à jour la BD
            daProg.Update(Ds1.T_programme)
            daProg.Fill(Ds1.T_programme)

            ListerProgEtu()

            cmdEnlever.Enabled = dgProgEtu.Rows.Count = 0
            mskNo.ReadOnly = True

            ' Se positionner sur le nouvel étudiant dans le dg
            dgProg.Rows(dgProg.Rows.Count - 1).Selected = True
            pos = dgProg.Rows.Count - 1
            RecupererProgramme(pos)

            Barrer(grpProgramme, cmdAnnuler, cmdOk)
            Debarrer(dgProg, cmdNouveau, cmdModifier, dgProgEtu)

            MsgBox("Programme ajouté avec succès!")
            'cmdAnnuler.PerformClick()


        Catch ex As SqlException
            Ds1.T_programme.RejectChanges()
            GestionErreurs(ex)
        Catch ex As Exception
            Ds1.T_programme.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui valide le numéro de programme pour éviter les doublons
    ''' </summary>
    Private Function ValiderNoProg() As Boolean
        Dim ok As Boolean = True
        Dim i As Integer
        For i = 0 To dgProg.Rows.Count - 1
            If dgProg.Rows(i).Cells(0).Value = mskNo.Text Then
                MsgBox("Ce numéro de programme existe déja. Veuillez en choisir un autre.", MsgBoxStyle.Information, "Doublon")
                ok = False
                Return ok
            End If
        Next
        Return ok
    End Function

    ''' <summary>
    ''' Procédure qui permet de valider le contenu des champs
    ''' </summary>
    ''' <returns></returns>
    Private Function ValiderChamps()
        Dim valide As Boolean = True
        err1.Clear()
        '************** No du programme ***************
        If mskNo.MaskFull = False Then
            err1.SetError(mskNo, "Entrez le no du programme.")
            valide = False
        End If

        '************ Nom du programme ***********
        If txtNomProg.Text.Trim = "" Then
            err1.SetError(txtNomProg, "Entrez le nom du programme.")
            valide = False
        End If
        ' Valider qu'il n'y ai pas seulement des "-"
        Dim i As Integer
        Dim cpt As Integer = 0
        Dim nomProg As String = txtNomProg.Text.Trim.ToString
        For i = 0 To nomProg.Count - 1
            If nomProg.Chars(i) = "-" Then
                cpt += 1
            End If
        Next
        If cpt > 1 Then
            err1.SetError(txtNomProg, "Entrez un nom valide. Un tiret maximum est accepté.")
            valide = False
        End If
        If nomProg = "-" Then
            err1.SetError(txtNomProg, "Entrez un nom de programme significatif.")
            valide = False
        End If

        '*************Nbr Unités *************
        If numNbrUnites.Value = 0 Then
            err1.SetError(numNbrUnites, "Spécifiez le nombre d'unités.")
            valide = False
        End If
        Return valide
    End Function


    ''' <summary>
    ''' Procédure qui permet de récupérer les informations d'un programme pour les afficher dans les champs
    ''' </summary>
    ''' <param name="no">Position du programme</param>

    Private Sub RecupererProgramme(no As Integer)
        Try
            Dim L As ds.T_programmeRow = Ds1.T_programme.Rows(no)
            ' 1 - assigner le contenu de la ligne aux champs
            mskNo.Text = L.pro_no
            txtNomProg.Text = L.pro_nom
            numNbrUnites.Value = L.pro_nbr_unites
            numNbrHeures.Value = L.pro_nbr_heures

        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de lister les étudiants qui font partie du programme sélectionné.
    ''' </summary>
    Private Sub ListerProgEtu()
        Try
            Ds1.T_etudiants.Clear()
            daProgEtu.SelectCommand.Parameters("@ID").Value = mskNo.Text
            ' Remplir la table des étudiants
            daProgEtu.Fill(Ds1.T_etudiants)

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
        Try
            ' 2 Barrer, débarrer les contrôles
            If Ds1.T_programme.Rows.Count > 0 Then
                Barrer(grpProgramme, cmdAnnuler, cmdOk)
                Debarrer(dgProg, cmdNouveau, cmdModifier, dgProgEtu)
                '3 Se mettre sur le programme comme avant
                'PositionnerProgramme()
                'pos = dgProg.CurrentCell.RowIndex
                RecupererProgramme(pos)
                ' ListerProgEtu()
                'dgProg.ClearSelection()
                'PositionnerProgramme()
                cmdEnlever.Enabled = dgProgEtu.Rows.Count = 0
            Else
                Barrer(grpProgramme, cmdAnnuler, cmdOk, cmdModifier)
                Debarrer(dgProg, dgProgEtu, cmdNouveau)
                ViderChamps(grpProgramme)
                pos = -1
            End If
            dgProg.Focus()
            ' Effacer les messages d'erreurs
            err1.Clear()
            ' 1 indiquer l'action en cours
            actionCourante = Action.Aucune
        Catch ex As IndexOutOfRangeException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Procédure qui appel le code pour enlever un programme 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
        ' Demander une confirmation
        If MsgBox("Voulez-vous vraiment enlever ce programme (" & txtNomProg.Text & ") ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") _
                    = DialogResult.Yes Then
            actionCourante = Action.Supprimer
            EnleverProgramme()
            actionCourante = Action.Aucune

        Else
            dgProg.Select()

        End If
    End Sub

    ''' <summary>
    ''' Procédure qui permet d'enlever un programme à la BD
    ''' </summary>
    Private Sub EnleverProgramme()
        Try
            Ds1.T_programme.Rows(pos).Delete()
            daProg.Update(Ds1.T_programme)

            If Ds1.T_programme.Rows.Count > 0 Then
                pos = 0
                dgProg.Rows(0).Selected = True
                RecupererProgramme(pos)
                ListerProgEtu()
                'dgProg.CurrentRow.Selected = True
                Barrer(grpProgramme, cmdAnnuler, cmdOk)
                Debarrer(dgProg, cmdNouveau, cmdModifier, dgProgEtu)
                dgProg.Select()
            Else
                pos = -1
                ViderChamps(grpProgramme)
                Barrer(dgProg, cmdModifier, cmdEnlever)
            End If
            MsgBox("Programme enlevé avec succès!", MessageBoxIcon.Information, "Succès")

            'cmdAnnuler.PerformClick()
            'PositionnerProgramme()
            ' Se positionner sur un programme

        Catch ex As SqlException
            Ds1.T_programme.RejectChanges()
            GestionErreurs(ex)
        Catch ex As Exception
            Ds1.T_programme.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        ' Mode ajout
        actionCourante = Action.Modification
        ' barrer et débarrer les contrôles
        Debarrer(cmdOk, cmdAnnuler, grpProgramme)
        Barrer(dgProg, dgProgEtu, cmdModifier, cmdNouveau, cmdEnlever)
        mskNo.ReadOnly = True
        txtNomProg.Focus()
        pos = dgProg.SelectedRows(0).Index

    End Sub

    Private Sub ModifierProgramme()
        Try
            ' Assigner les valeurs à la ligne
            Dim L As ds.T_programmeRow
            L = Ds1.T_programme.Rows(pos)
            L.pro_no = mskNo.Text
            L.pro_nom = txtNomProg.Text.Trim
            L.pro_nbr_unites = numNbrUnites.Value
            L.pro_nbr_heures = numNbrHeures.Value
            'Mettre à jour la BD
            daProg.Update(Ds1.T_programme)
            daProg.Fill(Ds1.T_programme)

            MsgBox("Programme modifié avec succès!")

            cmdAnnuler.PerformClick()

        Catch ex As SqlException
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        Catch ex As Exception
            Ds1.T_etudiants.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub dgProg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProg.CellClick
        Dim b As DataGridView = sender
        If dgProg.Rows.Count <> 0 Then
            pos = b.CurrentRow.Index
            RecupererProgramme(pos)
            ListerProgEtu()
            ' Barrer ou débarrer cmdEnlever selon la présence ou non d'étudiants dans le programme
            cmdEnlever.Enabled = dgProgEtu.Rows.Count = 0
        End If

    End Sub

    Private Sub dgProg_SelectionChanged(sender As Object, e As EventArgs) 'Handles dgProg.SelectionChanged
        Dim b As DataGridView = sender
        If dgProg.Rows.Count > 0 Then
            Select Case actionCourante
                Case Action.Ajout
                    pos = dgProg.Rows.Count - 1
                    RecupererProgramme(pos)
                    ListerProgEtu()
                    actionCourante = Action.Aucune
                Case Action.Supprimer
                    pos = 0
                Case Action.Modification
                    pos = dgProg.CurrentCell.RowIndex
                    RecupererProgramme(pos)
                    ListerProgEtu()
                Case Else
                    pos = dgProg.CurrentCell.RowIndex
                    RecupererProgramme(pos)
                    ListerProgEtu()
            End Select
        End If
        ' Barrer ou débarrer cmdEnlever selon la présence ou non d'étudiants dans le programme
        cmdEnlever.Enabled = dgProgEtu.Rows.Count = 0
    End Sub

    Private Sub cmdXML_Click(sender As Object, e As EventArgs) Handles cmdXML.Click
        Try
            ' Confirmation
            If MsgBox("Vous allez exporter la liste des programmes dans un fichier .xml et un fichier .xsd. " & vbCrLf & "Leur emplacement sera : '..\TP2_College_ABC\TP1_College_ABC\bin\Debug' ",
                      MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Confirmation") = DialogResult.Yes Then
                Ds1.T_etudiants.WriteXml("Programmes.xml")
                Ds1.T_etudiants.WriteXmlSchema("Programmes.xsd")
                MsgBox("Fichiers exportés avec succès!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class