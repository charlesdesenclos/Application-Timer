'Projet : Application Timer
'Developpeur : Desenclos Charles


Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Media

Public Class Form1


    'Pour le son d'alarme
    Private soundPlayer As New SoundPlayer("..\..\..\Application Timer\AlarmTimer.wav")


    Dim compteur_seconde As Integer = 0
    Dim compteur_minute As Integer = 0
    Dim compteur_heure As Integer = 0
    Dim Heure, Minute, Seconde As Integer
    Dim RadioButt As Integer = 0

    Sub affiche_TextBox(ByVal Heure As Boolean, ByVal Minute As Boolean, ByVal Seconde As Boolean)
        TextBox_heure_chrono.Visible = Heure
        TextBox_minute_chrono.Visible = Minute
        TextBox_seconde_chrono.Visible = Seconde
        Label_heure_chrono.Visible = Heure
        Label_minute_chrono.Visible = Minute
        Label_seconde_chrono.Visible = Seconde
        Button_chrono.Visible = Seconde
    End Sub

    Sub affiche_Choix_(ByVal Heure_Chrono As Boolean, ByVal Minute_Chrono As Boolean, ByVal Seconde_Chrono As Boolean, ByVal lb_Heure_Chrono As Boolean,
                       ByVal lb_Minute_Chrono As Boolean, ByVal lb_seconde_chrono As Boolean, ByVal btn_Chrono As Boolean, ByVal gb_Prere_Heures As Boolean,
                       ByVal gb_prere_minutes As Boolean, ByVal gb_alarm As Integer)
        TextBox_heure_chrono.Visible = Heure_Chrono
        TextBox_minute_chrono.Visible = Minute_Chrono
        TextBox_seconde_chrono.Visible = Seconde_Chrono
        Label_heure_chrono.Visible = lb_Heure_Chrono
        Label_minute_chrono.Visible = lb_Minute_Chrono
        Label_seconde_chrono.Visible = lb_seconde_chrono
        Button_chrono.Visible = btn_Chrono
        GroupBox_prereglages_heures.Visible = gb_Prere_Heures
        GroupBox_prereglages_minutes.Visible = gb_prere_minutes
        GroupBox_alarm.Visible = gb_alarm
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Date et Heure actuelle au bon format
        Label_heure_actuel.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        Timer2.Start()

    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        Timer2.Stop()
        compteur_seconde = 0



    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If RadioButt = 1 Then
            compteur_seconde += 1
            If compteur_seconde > 59 Then
                compteur_seconde = 0
                compteur_minute += 1
                Label_min.Text = compteur_minute
                If compteur_minute > 59 Then
                    compteur_minute = 0
                    compteur_heure += 1
                    Label_heure.Text = compteur_heure
                    If compteur_heure > 59 Then
                        compteur_heure = 0
                        compteur_minute = 0
                        compteur_seconde = 0
                    End If
                End If

            End If

            Label_seconde.Text = compteur_seconde
        ElseIf RadioButt = 2 Then
            If Seconde <> 0 Then
                Seconde -= 1
            Else
                Seconde = 0
            End If

            If Seconde = 0 Then
                If Minute <> 0 Then
                    Minute -= 1
                    Seconde = 60
                Else
                    Minute = 0
                End If


                Label_min.Text = Minute
                If Minute = 0 Then
                    If Heure <> 0 Then
                        Heure -= 1
                        Minute = 60
                    Else
                        Heure = 0
                    End If

                    Label_heure.Text = Heure
                End If
            End If


            Label_seconde.Text = Seconde



        End If

        If RadioButton_On.Checked = True Then
            If Label_heure.Text = 0 And Label_min.Text = 0 And Label_seconde.Text = 0 Then
                soundPlayer.Play()
            End If
        End If






    End Sub

    Private Sub Button_pause_Click(sender As Object, e As EventArgs) Handles Button_pause.Click
        Timer2.Enabled = False
    End Sub

    Private Sub Button_chrono_Click(sender As Object, e As EventArgs) Handles Button_chrono.Click
        If TextBox_heure_chrono.Text = "" Then
            Heure = 0
        Else
            If TextBox_heure_chrono.Text <= 59 Or TextBox_heure_chrono.Text >= 0 Then
                Heure = TextBox_heure_chrono.Text
            Else
                MessageBox.Show("Les heures dépassent la limite")
            End If

        End If

        If TextBox_minute_chrono.Text = "" Then
            Minute = 0
        Else
            If TextBox_minute_chrono.Text <= 59 Or TextBox_minute_chrono.Text >= 0 Then
                Minute = TextBox_minute_chrono.Text
            Else
                MessageBox.Show("Les Minutes dépassent la limite")
            End If

        End If

        If TextBox_seconde_chrono.Text = "" Then
            Seconde = 0
        Else
            If TextBox_seconde_chrono.Text <= 59 Or TextBox_seconde_chrono.Text >= 0 Then
                Seconde = TextBox_seconde_chrono.Text
            Else
                MessageBox.Show("Les Secondes dépassent la limite")
            End If

        End If



        Label_heure.Text = Heure
        Label_min.Text = Minute
        Label_seconde.Text = Seconde
    End Sub

    Private Sub RadioButton_Timer_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Timer.CheckedChanged
        affiche_Choix_(False, False, False, False, False, False, False, False, False, False)

        RadioButt = 1
    End Sub

    Private Sub TextBox_heure_chrono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_heure_chrono.KeyPress
        If TextBox_heure_chrono.TextLength >= 2 Then
            ' Si le texte a déjà deux chiffres, bloquer la saisie
            e.Handled = True
        ElseIf (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Tab) Then
            ' Si ce n'est pas un chiffre, bloquer la saisie
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_minute_chrono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_minute_chrono.KeyPress
        If TextBox_minute_chrono.TextLength >= 2 Then
            ' Si le texte a déjà deux chiffres, bloquer la saisie
            e.Handled = True
        ElseIf (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Tab) Then
            ' Si ce n'est pas un chiffre, bloquer la saisie
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_seconde_chrono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_seconde_chrono.KeyPress
        If TextBox_seconde_chrono.TextLength >= 2 Then
            ' Si le texte a déjà deux chiffres, bloquer la saisie
            e.Handled = True
        ElseIf (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Tab) Then
            ' Si ce n'est pas un chiffre, bloquer la saisie
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton_1_heures_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_1_heures.CheckedChanged
        affiche_TextBox(False, False, False)
        If RadioButton_1_heures.Checked = True Then
            Heure = 1
            Label_heure.Text = Heure
        End If
    End Sub

    Private Sub RadioButton_2_heures_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_2_heures.CheckedChanged
        affiche_TextBox(False, False, False)
        If RadioButton_2_heures.Checked = True Then
            Heure = 2
            Label_heure.Text = Heure
        End If
    End Sub

    Private Sub RadioButton_3_heures_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_3_heures.CheckedChanged
        affiche_TextBox(False, False, False)
        If RadioButton_3_heures.Checked = True Then
            Heure = 3
            Label_heure.Text = Heure
        End If
    End Sub

    Private Sub RadioButton_15_min_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_15_min.CheckedChanged
        affiche_TextBox(False, False, False)
        If RadioButton_15_min.Checked = True Then
            Minute = 15
            Label_min.Text = Minute
        End If
    End Sub

    Private Sub RadioButton_30_min_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_30_min.CheckedChanged
        affiche_TextBox(False, False, False)
        If RadioButton_30_min.Checked = True Then
            Minute = 30
            Label_min.Text = Minute
        End If
    End Sub

    Private Sub RadioButton_45_min_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_45_min.CheckedChanged
        affiche_TextBox(False, False, False)
        If RadioButton_45_min.Checked = True Then
            Minute = 45
            Label_min.Text = Minute
        End If
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Heure = 0
        Minute = 0
        Seconde = 0

        Label_heure.Text = Heure
        Label_min.Text = Minute
        Label_seconde.Text = Seconde
        Timer2.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        affiche_Choix_(False, False, False, False, False, False, False, False, False, False)

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub RadioButton_Chrono_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Chrono.CheckedChanged

        affiche_Choix_(True, True, True, True, True, True, True, True, True, True)

        RadioButt = 2
    End Sub
End Class
