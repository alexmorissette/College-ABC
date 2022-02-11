'Titre: Gestion des erreurs
'Description: Formulaire pour la gestion des erreurs qui peuvent survenir pendant l'exécution du programme.
'Fait par : Alex Morissette
'Le : 31/08/2021
'Révisé le : 06/09/2021

Imports System.Data.SqlClient
Module ModuleGestErr
    Public Sub GestionErreurs(err As Exception)
        MsgBox(err.Message & vbCrLf & vbCrLf & "Source : " & err.StackTrace, MsgBoxStyle.Information, "Erreur")
        End
    End Sub

    Public Sub GestionErreurs(err As SqlException)
        Select Case err.Number
            Case 0
                MsgBox("L'accès au serveur a été interrompu. Veuillez contacter l'administrateur du serveur." & vbCrLf & vbCrLf &
                   "Le programme va s'arrêter.", MsgBoxStyle.Critical, "Erreur")
                End
            Case -1, 26

                MsgBox("Le serveur est inaccessible. Veuillez vérifier s'il est en marche ou contactez Alex Morissette à 2036604@multihexa.ca." _
                   & vbCrLf & vbCrLf & "Voici le détail de l'erreur: " & vbCrLf & vbCrLf & "Erreur no. " & err.Number & " - " & err.Message _
                   & vbCrLf & vbCrLf & "Le programme va se terminer.", MsgBoxStyle.Critical, "Erreur du serveur")
                End
            Case Else
                MsgBox(err.Message & vbCrLf & vbCrLf & "Le programme va s'arrêter.")
                End
        End Select

    End Sub

    
End Module
