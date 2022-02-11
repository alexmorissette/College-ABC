Public Class frmLogin

    ' TODO: insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Consultez https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    'Pour compter les essais
    Dim nbrEssais As Integer = 3
    Dim cpt As Integer = 0

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daLogin.Fill(Ds1.T_login)
        Barrer(OK, cmdRegister)
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            ' Valider qu'il y a du texte dans les champs
            If txtUser.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Un ou les deux champs sont manquants, veuillez les renseigner.")
                txtUser.Focus()
                Exit Sub
            End If
            ' Valider que les codes sont les bons, si oui, on ferme le login
            Dim L As ds.T_loginRow
            Dim i As Integer
            Dim userOK As Boolean = False
            For i = 0 To Ds1.T_login.Rows.Count - 1
                L = Ds1.T_login.Rows(i)
                If txtUser.Text.Trim.ToUpper = L.Utilisateur.ToString.ToUpper And
        txtPassword.Text.Trim.ToUpper = L.MotDePasse.ToString.ToUpper Then
                    userOK = True
                    Exit For
                    Debarrer(OK)
                End If
            Next
            If userOK Then
                user = L.Utilisateur
                Me.Close()
                cpt = 0
            Else ' Si codes ne sont pas bons, on décrémente le cpt et revient à l'état d'origine. Après cpt essais
                cpt += 1
                If cpt = nbrEssais Then
                    MsgBox("Désolé, vous avez atteint le nombre d'essais maximum de " & nbrEssais & ". Le programme va se fermer.")
                    End
                Else
                    MsgBox("Nom d'utilisateur ou mot de passe invalide. Nombre d'essais restants : " & nbrEssais - cpt)
                End If
                txtPassword.Clear()
                txtUser.Clear()
                txtUser.Focus()
            End If

        Catch ex As Exception
            GestionErreurs(ex)
        End Try

    End Sub

    Private Function ValiderRegister()

        If txtUser.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Un ou les deux champs sont manquants, veuillez les renseigner.")
            txtUser.Focus()
            Exit Function
        End If

        Dim L As ds.T_loginRow
        Dim i As Integer
        Dim userOK As Boolean = False
        For i = 0 To Ds1.T_login.Rows.Count - 1
            L = Ds1.T_login.Rows(i)
            If txtUser.Text.Trim.ToUpper = L.Utilisateur.ToString.ToUpper And
        txtPassword.Text.Trim.ToUpper = L.MotDePasse.ToString.ToUpper Then
                MsgBox("La combinaison de l'utilisateur et du mot de passe existe déjà.")
                Exit Function
            Else
                userOK = True
                Debarrer(OK)
            End If
        Next
        Return userOK
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        Try
            'ValiderChamps
            'Créer la ligne
            Dim L As ds.T_loginRow
            L = Ds1.T_login.NewT_loginRow
            ' Assigner les valeurs à la ligne
            L.Utilisateur = txtUser.Text
            L.MotDePasse = txtPassword.Text
            If ValiderRegister() Then
                ' Ajouter au Dataset
                Ds1.T_login.Rows.Add(L)
                'Mettre à jour la BD
                daLogin.Update(Ds1.T_login)
                MsgBox("Nouvel utilisateur créé avec succès!")
            End If
        Catch ex As Exception
            Ds1.T_login.RejectChanges()
            GestionErreurs(ex)
        End Try
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPassword.TextChanged
        If txtUser.Text.Trim <> "" Or txtPassword.Text.Trim <> "" Then
            Debarrer(OK, cmdRegister)
        Else
            Barrer(OK, cmdRegister)
        End If
    End Sub
End Class
