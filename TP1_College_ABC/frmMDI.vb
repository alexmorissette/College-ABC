'Titre: Programme de gestion du Collège ABC 
'Description: Fênetre mère qui gère les fenêtres enfants grâce au menu. Elle gère également la conneion à la base de donnée.
'Fait par : Alex Morissette
'Le : 31/08/2021
'Révisé le : 06/09/2021

Imports System.Data.SqlClient
Public Class frmMDI
    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ' Se connecter à l'admin
            My.Forms.frmLogin.ShowDialog()

            ' Saluer l'utilisateur
            lblUser.Text = lblUser.Text & user

            ' Ouvrir la fenêtre de gestion des étudiants
            mnuEtudiants.PerformClick()

        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub mnuProgrammes_Click(sender As Object, e As EventArgs) Handles mnuProgrammes.Click
        Try
            'Vérifier si la fenetre est déjà ouverte
            Dim i As Integer
            For i = 0 To Me.MdiChildren.Count - 1
                If Me.MdiChildren(i).Text = "Gestion des programmes" Then
                    ' Le formulaire est déjà ouvert
                    Me.MdiChildren(i).Activate()
                    Exit Sub
                End If
            Next
            ' Ouvrir le form
            Dim frm As New frmProgrammes
            frm.MdiParent = Me
            frm.Show()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try

    End Sub

    Private Sub mnuEtudiants_Click(sender As Object, e As EventArgs) Handles mnuEtudiants.Click
        Try
            'Vérifier si la fenetre est déjà ouverte
            Dim i As Integer
            For i = 0 To Me.MdiChildren.Count - 1
                If Me.MdiChildren(i).Text = "Gestion des étudiants" Then
                    ' Le formulaire est déjà ouvert
                    Me.MdiChildren(i).Activate()
                    Exit Sub
                End If
            Next
            ' Ouvrir le form
            Dim frm As New frmEtudiants
            frm.MdiParent = Me
            frm.Show()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try

    End Sub

    Private Sub mnuQuitter_Click(sender As Object, e As EventArgs) Handles mnuQuitter.Click
        Dim rep As DialogResult
        rep = MsgBox("Voulez-vous vraiment quitter?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Fermeture")
        If rep = DialogResult.Yes Then
            My.Forms.frmMDI.Close()
        Else
            Return
        End If
    End Sub

    Private Sub mnuListeProgrammes_Click(sender As Object, e As EventArgs) Handles mnuListeProgrammes.Click
        'MsgBox("Cet item de menu n'est pas accessible dans cette version de l'application.", MsgBoxStyle.Exclamation, "Information")
        Try
            'Vérifier si la fenetre est déjà ouverte
            Dim i As Integer
            For i = 0 To Me.MdiChildren.Count - 1
                If Me.MdiChildren(i).Text = "Liste des programmes" Then
                    ' Le formulaire est déjà ouvert
                    Me.MdiChildren(i).Activate()
                    Exit Sub
                End If
            Next
            ' Ouvrir le form
            Dim frm As New frmApercu
            frm.Text = "Liste des programmes"
            frm.MdiParent = Me
            frm.NomRapport = "Liste_Programmes"
            frm.Show()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub mnuListeEtudiants_Click(sender As Object, e As EventArgs) Handles mnuListeEtudiants.Click
        Try
            'Vérifier si la fenetre est déjà ouverte
            Dim i As Integer
            For i = 0 To Me.MdiChildren.Count - 1
                If Me.MdiChildren(i).Text = "Liste des étudiants" Then
                    ' Le formulaire est déjà ouvert
                    Me.MdiChildren(i).Activate()
                    Exit Sub
                End If
            Next
            ' Ouvrir le form
            Dim frm As New frmApercu
            frm.Text = "Liste des étudiants"
            frm.MdiParent = Me
            frm.NomRapport = "Liste_Etudiants"
            frm.Show()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub mnuListeEtuParProg_Click(sender As Object, e As EventArgs) Handles mnuListeEtuParProg.Click
        Try
            'Vérifier si la fenetre est déjà ouverte
            Dim i As Integer
            For i = 0 To Me.MdiChildren.Count - 1
                If Me.MdiChildren(i).Text = "Liste des étudiants par programme" Then
                    ' Le formulaire est déjà ouvert
                    Me.MdiChildren(i).Activate()
                    Exit Sub
                End If
            Next
            ' Ouvrir le form
            Dim frm As New frmApercu
            frm.Text = "Liste des étudiants par programme"
            frm.MdiParent = Me
            frm.NomRapport = "Liste_Etudiants_Programme"
            frm.Show()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub ÀProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposToolStripMenuItem.Click
        My.Forms.frmApropos.ShowDialog()
    End Sub

End Class
