'Titre: Module de variables globales et de méthodes publics
'Description: Module qui contient les variables globales ainsi que les méthodes
'                       communes utilisées dans les différents formulaires du programme.
'Fait par : Alex Morissette
'Le : 31/08/2021
'Révisé le : 06/09/2021

Imports System.Data.SqlClient
Module Module1
    Public Enum Action
        Ajout
        Modification
        Supprimer
        Aucune
    End Enum

    ' Variables pour Objets SQL 
    Public cn As SqlConnection
    Public DR As SqlDataReader

    ''' <summary>
    ''' Procédure qui permet de remplir les listviews
    ''' </summary>
    Public Sub Remplir_ListView(lv As ListView, comSQL As String, cp As String)
        Try
            'Vider le listview
            lv.Items.Clear()
            'Config de la command
            Dim com As New SqlCommand(comSQL, cn)
            ' Création du DataReader
            DR = com.ExecuteReader

            'Remplir le listview **********************
            Dim ligne As ListViewItem
            Do While DR.Read
                ' Populer l'item(ligne) associé à sa clé primaire
                ligne = New ListViewItem(DR(cp).ToString)
                ' Puis les subitems (colonnes)
                Dim i As Integer
                For i = 1 To DR.FieldCount - 1
                    ligne.SubItems.Add(DR(i).ToString)
                Next
                'Ajouter la ligne au listview
                lv.Items.Add(ligne)
            Loop
            'Fermer le dataReader
            DR.Close()
        Catch ex As SqlException
            GestionErreurs(ex)
        Catch ex As Exception
            GestionErreurs(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de barrer des contrôles
    ''' </summary>
    ''' <param name="ctrl">Les contrôles à barrer</param>
    Public Sub Barrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = False
        Next
    End Sub

    ''' <summary>
    ''' Procédure qui permet de débarrer des contrôles
    ''' </summary>
    ''' <param name="ctrl">Les contrôles à débarrer</param>
    Public Sub Debarrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = True
        Next
    End Sub


    ''' <summary>
    ''' Procédure qui permet de vider les champs d'un formulaire à partir du GroupBox dans lequel sont contenus les contrôles.
    ''' </summary>
    ''' <param name="grp">GroupBox des contrôles à vider</param>
    Public Sub ViderChamps(grp As GroupBox)
        Dim c As Control
        For Each c In grp.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is MaskedTextBox Then
                c.Text = ""
            ElseIf TypeOf (c) Is ComboBox Then
                Dim cb As ComboBox
                cb = c
                cb.SelectedIndex = -1
            End If
        Next
    End Sub


End Module
