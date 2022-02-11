'Titre: Formulaire d'aperçu pour les rapports
'Description: Formulaire pour la gestion de l'affichage des rapports du programme.
'Fait par : Alex Morissette
'Le : 31/08/2021
'Révisé le : 06/09/2021

Public Class frmApercu
    Private _nomRapport As String
    Public Property NomRapport As String
        Get
            Return _nomRapport
        End Get
        Set(value As String)
            _nomRapport = value
        End Set
    End Property

    Private Sub frmApercu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case Me.NomRapport
                Case "Liste_Programmes"
                    'Remplir la table des clients du dataset
                    daProgrammes.Fill(DsRapports1.T_programme)
                    'Instanciation d'un rapport
                    Dim rap As New RapProgrammes
                    ' Associer la source de données au rapport
                    rap.SetDataSource(DsRapports1)
                    ' Placer le rapport dans l'aperçu avant impression (CRV)
                    crv.ReportSource = rap

                Case "Liste_Etudiants"
                    daEtudiants.Fill(DsRapports1.T_etudiants)
                    Dim rap As New RapEtudiants
                    rap.SetDataSource(DsRapports1)
                    crv.ReportSource = rap

                Case "Liste_Etudiants_Programme"
                    daProgEtu.Fill(DsRapportProgEtu1.T_etudiants)
                    Dim rap As New RapEtudiantsParProgramme
                    rap.SetDataSource(DsRapportProgEtu1)
                    crv.ReportSource = rap
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class