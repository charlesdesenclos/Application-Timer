<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_heure_actuel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.Button_stop = New System.Windows.Forms.Button()
        Me.Button_pause = New System.Windows.Forms.Button()
        Me.Label_seconde = New System.Windows.Forms.Label()
        Me.Label_min = New System.Windows.Forms.Label()
        Me.Label_heure = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox_heure_chrono = New System.Windows.Forms.TextBox()
        Me.TextBox_minute_chrono = New System.Windows.Forms.TextBox()
        Me.TextBox_seconde_chrono = New System.Windows.Forms.TextBox()
        Me.Label_heure_chrono = New System.Windows.Forms.Label()
        Me.Label_minute_chrono = New System.Windows.Forms.Label()
        Me.Label_seconde_chrono = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Chrono = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Timer = New System.Windows.Forms.RadioButton()
        Me.Button_chrono = New System.Windows.Forms.Button()
        Me.GroupBox_prereglages_heures = New System.Windows.Forms.GroupBox()
        Me.RadioButton_3_heures = New System.Windows.Forms.RadioButton()
        Me.RadioButton_2_heures = New System.Windows.Forms.RadioButton()
        Me.RadioButton_1_heures = New System.Windows.Forms.RadioButton()
        Me.GroupBox_prereglages_minutes = New System.Windows.Forms.GroupBox()
        Me.RadioButton_45_min = New System.Windows.Forms.RadioButton()
        Me.RadioButton_30_min = New System.Windows.Forms.RadioButton()
        Me.RadioButton_15_min = New System.Windows.Forms.RadioButton()
        Me.Button_reset = New System.Windows.Forms.Button()
        Me.GroupBox_alarm = New System.Windows.Forms.GroupBox()
        Me.Label_alarm = New System.Windows.Forms.Label()
        Me.RadioButton_On = New System.Windows.Forms.RadioButton()
        Me.RadioButton_off = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_prereglages_heures.SuspendLayout()
        Me.GroupBox_prereglages_minutes.SuspendLayout()
        Me.GroupBox_alarm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label_heure_actuel
        '
        Me.Label_heure_actuel.AutoSize = True
        Me.Label_heure_actuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_heure_actuel.Location = New System.Drawing.Point(398, 9)
        Me.Label_heure_actuel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_heure_actuel.Name = "Label_heure_actuel"
        Me.Label_heure_actuel.Size = New System.Drawing.Size(0, 73)
        Me.Label_heure_actuel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(500, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TIME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "H"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(555, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(677, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "S"
        '
        'Button_start
        '
        Me.Button_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_start.Location = New System.Drawing.Point(92, 278)
        Me.Button_start.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(186, 48)
        Me.Button_start.TabIndex = 8
        Me.Button_start.Text = "START"
        Me.Button_start.UseVisualStyleBackColor = False
        '
        'Button_stop
        '
        Me.Button_stop.BackColor = System.Drawing.Color.Red
        Me.Button_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_stop.Location = New System.Drawing.Point(335, 278)
        Me.Button_stop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(166, 48)
        Me.Button_stop.TabIndex = 9
        Me.Button_stop.Text = "STOP"
        Me.Button_stop.UseVisualStyleBackColor = False
        '
        'Button_pause
        '
        Me.Button_pause.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_pause.Location = New System.Drawing.Point(560, 278)
        Me.Button_pause.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_pause.Name = "Button_pause"
        Me.Button_pause.Size = New System.Drawing.Size(190, 48)
        Me.Button_pause.TabIndex = 10
        Me.Button_pause.Text = "PAUSE"
        Me.Button_pause.UseVisualStyleBackColor = False
        '
        'Label_seconde
        '
        Me.Label_seconde.AutoSize = True
        Me.Label_seconde.Font = New System.Drawing.Font("Digital dream Fat Skew", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_seconde.Location = New System.Drawing.Point(610, 152)
        Me.Label_seconde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_seconde.Name = "Label_seconde"
        Me.Label_seconde.Size = New System.Drawing.Size(59, 30)
        Me.Label_seconde.TabIndex = 6
        Me.Label_seconde.Text = "00"
        '
        'Label_min
        '
        Me.Label_min.AutoSize = True
        Me.Label_min.Font = New System.Drawing.Font("Digital dream Fat Skew", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_min.Location = New System.Drawing.Point(488, 152)
        Me.Label_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_min.Name = "Label_min"
        Me.Label_min.Size = New System.Drawing.Size(59, 30)
        Me.Label_min.TabIndex = 4
        Me.Label_min.Text = "00"
        '
        'Label_heure
        '
        Me.Label_heure.AutoSize = True
        Me.Label_heure.Font = New System.Drawing.Font("Digital dream Fat Skew", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_heure.Location = New System.Drawing.Point(386, 152)
        Me.Label_heure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_heure.Name = "Label_heure"
        Me.Label_heure.Size = New System.Drawing.Size(59, 30)
        Me.Label_heure.TabIndex = 2
        Me.Label_heure.Text = "00"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TextBox_heure_chrono
        '
        Me.TextBox_heure_chrono.Font = New System.Drawing.Font("Digital dream Fat Skew", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_heure_chrono.Location = New System.Drawing.Point(285, 384)
        Me.TextBox_heure_chrono.Name = "TextBox_heure_chrono"
        Me.TextBox_heure_chrono.Size = New System.Drawing.Size(100, 29)
        Me.TextBox_heure_chrono.TabIndex = 12
        '
        'TextBox_minute_chrono
        '
        Me.TextBox_minute_chrono.Font = New System.Drawing.Font("Digital dream Fat Skew", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_minute_chrono.Location = New System.Drawing.Point(426, 384)
        Me.TextBox_minute_chrono.Name = "TextBox_minute_chrono"
        Me.TextBox_minute_chrono.Size = New System.Drawing.Size(100, 29)
        Me.TextBox_minute_chrono.TabIndex = 13
        '
        'TextBox_seconde_chrono
        '
        Me.TextBox_seconde_chrono.Font = New System.Drawing.Font("Digital dream Fat Skew", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_seconde_chrono.Location = New System.Drawing.Point(587, 384)
        Me.TextBox_seconde_chrono.Name = "TextBox_seconde_chrono"
        Me.TextBox_seconde_chrono.Size = New System.Drawing.Size(100, 29)
        Me.TextBox_seconde_chrono.TabIndex = 14
        '
        'Label_heure_chrono
        '
        Me.Label_heure_chrono.AutoSize = True
        Me.Label_heure_chrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_heure_chrono.Location = New System.Drawing.Point(392, 388)
        Me.Label_heure_chrono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_heure_chrono.Name = "Label_heure_chrono"
        Me.Label_heure_chrono.Size = New System.Drawing.Size(27, 25)
        Me.Label_heure_chrono.TabIndex = 15
        Me.Label_heure_chrono.Text = "H"
        '
        'Label_minute_chrono
        '
        Me.Label_minute_chrono.AutoSize = True
        Me.Label_minute_chrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_minute_chrono.Location = New System.Drawing.Point(533, 388)
        Me.Label_minute_chrono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_minute_chrono.Name = "Label_minute_chrono"
        Me.Label_minute_chrono.Size = New System.Drawing.Size(47, 25)
        Me.Label_minute_chrono.TabIndex = 16
        Me.Label_minute_chrono.Text = "Min"
        '
        'Label_seconde_chrono
        '
        Me.Label_seconde_chrono.AutoSize = True
        Me.Label_seconde_chrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_seconde_chrono.Location = New System.Drawing.Point(705, 388)
        Me.Label_seconde_chrono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_seconde_chrono.Name = "Label_seconde_chrono"
        Me.Label_seconde_chrono.Size = New System.Drawing.Size(26, 25)
        Me.Label_seconde_chrono.TabIndex = 17
        Me.Label_seconde_chrono.Text = "S"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_Chrono)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Timer)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'RadioButton_Chrono
        '
        Me.RadioButton_Chrono.AutoSize = True
        Me.RadioButton_Chrono.Location = New System.Drawing.Point(26, 57)
        Me.RadioButton_Chrono.Name = "RadioButton_Chrono"
        Me.RadioButton_Chrono.Size = New System.Drawing.Size(68, 16)
        Me.RadioButton_Chrono.TabIndex = 1
        Me.RadioButton_Chrono.TabStop = True
        Me.RadioButton_Chrono.Text = "TIMER"
        Me.RadioButton_Chrono.UseVisualStyleBackColor = True
        '
        'RadioButton_Timer
        '
        Me.RadioButton_Timer.AutoSize = True
        Me.RadioButton_Timer.Checked = True
        Me.RadioButton_Timer.Location = New System.Drawing.Point(26, 34)
        Me.RadioButton_Timer.Name = "RadioButton_Timer"
        Me.RadioButton_Timer.Size = New System.Drawing.Size(77, 16)
        Me.RadioButton_Timer.TabIndex = 0
        Me.RadioButton_Timer.TabStop = True
        Me.RadioButton_Timer.Text = "Chrono"
        Me.RadioButton_Timer.UseVisualStyleBackColor = True
        '
        'Button_chrono
        '
        Me.Button_chrono.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_chrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_chrono.Location = New System.Drawing.Point(376, 445)
        Me.Button_chrono.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_chrono.Name = "Button_chrono"
        Me.Button_chrono.Size = New System.Drawing.Size(186, 48)
        Me.Button_chrono.TabIndex = 19
        Me.Button_chrono.Text = "Chrono"
        Me.Button_chrono.UseVisualStyleBackColor = False
        '
        'GroupBox_prereglages_heures
        '
        Me.GroupBox_prereglages_heures.Controls.Add(Me.RadioButton_3_heures)
        Me.GroupBox_prereglages_heures.Controls.Add(Me.RadioButton_2_heures)
        Me.GroupBox_prereglages_heures.Controls.Add(Me.RadioButton_1_heures)
        Me.GroupBox_prereglages_heures.Location = New System.Drawing.Point(886, 355)
        Me.GroupBox_prereglages_heures.Name = "GroupBox_prereglages_heures"
        Me.GroupBox_prereglages_heures.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_prereglages_heures.TabIndex = 20
        Me.GroupBox_prereglages_heures.TabStop = False
        Me.GroupBox_prereglages_heures.Text = "Prereglages Heures"
        '
        'RadioButton_3_heures
        '
        Me.RadioButton_3_heures.AutoSize = True
        Me.RadioButton_3_heures.Location = New System.Drawing.Point(31, 66)
        Me.RadioButton_3_heures.Name = "RadioButton_3_heures"
        Me.RadioButton_3_heures.Size = New System.Drawing.Size(50, 16)
        Me.RadioButton_3_heures.TabIndex = 2
        Me.RadioButton_3_heures.TabStop = True
        Me.RadioButton_3_heures.Text = "3 H"
        Me.RadioButton_3_heures.UseVisualStyleBackColor = True
        '
        'RadioButton_2_heures
        '
        Me.RadioButton_2_heures.AutoSize = True
        Me.RadioButton_2_heures.Location = New System.Drawing.Point(31, 43)
        Me.RadioButton_2_heures.Name = "RadioButton_2_heures"
        Me.RadioButton_2_heures.Size = New System.Drawing.Size(50, 16)
        Me.RadioButton_2_heures.TabIndex = 1
        Me.RadioButton_2_heures.TabStop = True
        Me.RadioButton_2_heures.Text = "2 H"
        Me.RadioButton_2_heures.UseVisualStyleBackColor = True
        '
        'RadioButton_1_heures
        '
        Me.RadioButton_1_heures.AutoSize = True
        Me.RadioButton_1_heures.Location = New System.Drawing.Point(31, 20)
        Me.RadioButton_1_heures.Name = "RadioButton_1_heures"
        Me.RadioButton_1_heures.Size = New System.Drawing.Size(50, 16)
        Me.RadioButton_1_heures.TabIndex = 0
        Me.RadioButton_1_heures.TabStop = True
        Me.RadioButton_1_heures.Text = "1 H"
        Me.RadioButton_1_heures.UseVisualStyleBackColor = True
        '
        'GroupBox_prereglages_minutes
        '
        Me.GroupBox_prereglages_minutes.Controls.Add(Me.RadioButton_45_min)
        Me.GroupBox_prereglages_minutes.Controls.Add(Me.RadioButton_30_min)
        Me.GroupBox_prereglages_minutes.Controls.Add(Me.RadioButton_15_min)
        Me.GroupBox_prereglages_minutes.Location = New System.Drawing.Point(1120, 355)
        Me.GroupBox_prereglages_minutes.Name = "GroupBox_prereglages_minutes"
        Me.GroupBox_prereglages_minutes.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_prereglages_minutes.TabIndex = 21
        Me.GroupBox_prereglages_minutes.TabStop = False
        Me.GroupBox_prereglages_minutes.Text = "Prereglages Minutes"
        '
        'RadioButton_45_min
        '
        Me.RadioButton_45_min.AutoSize = True
        Me.RadioButton_45_min.Location = New System.Drawing.Point(31, 66)
        Me.RadioButton_45_min.Name = "RadioButton_45_min"
        Me.RadioButton_45_min.Size = New System.Drawing.Size(77, 16)
        Me.RadioButton_45_min.TabIndex = 2
        Me.RadioButton_45_min.TabStop = True
        Me.RadioButton_45_min.Text = "45 min"
        Me.RadioButton_45_min.UseVisualStyleBackColor = True
        '
        'RadioButton_30_min
        '
        Me.RadioButton_30_min.AutoSize = True
        Me.RadioButton_30_min.Location = New System.Drawing.Point(31, 43)
        Me.RadioButton_30_min.Name = "RadioButton_30_min"
        Me.RadioButton_30_min.Size = New System.Drawing.Size(77, 16)
        Me.RadioButton_30_min.TabIndex = 1
        Me.RadioButton_30_min.TabStop = True
        Me.RadioButton_30_min.Text = "30 min"
        Me.RadioButton_30_min.UseVisualStyleBackColor = True
        '
        'RadioButton_15_min
        '
        Me.RadioButton_15_min.AutoSize = True
        Me.RadioButton_15_min.Location = New System.Drawing.Point(31, 20)
        Me.RadioButton_15_min.Name = "RadioButton_15_min"
        Me.RadioButton_15_min.Size = New System.Drawing.Size(77, 16)
        Me.RadioButton_15_min.TabIndex = 0
        Me.RadioButton_15_min.TabStop = True
        Me.RadioButton_15_min.Text = "15 min"
        Me.RadioButton_15_min.UseVisualStyleBackColor = True
        '
        'Button_reset
        '
        Me.Button_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_reset.Location = New System.Drawing.Point(801, 278)
        Me.Button_reset.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(190, 48)
        Me.Button_reset.TabIndex = 22
        Me.Button_reset.Text = "RESET"
        Me.Button_reset.UseVisualStyleBackColor = False
        '
        'GroupBox_alarm
        '
        Me.GroupBox_alarm.Controls.Add(Me.RadioButton_off)
        Me.GroupBox_alarm.Controls.Add(Me.RadioButton_On)
        Me.GroupBox_alarm.Controls.Add(Me.Label_alarm)
        Me.GroupBox_alarm.Location = New System.Drawing.Point(1120, 30)
        Me.GroupBox_alarm.Name = "GroupBox_alarm"
        Me.GroupBox_alarm.Size = New System.Drawing.Size(227, 100)
        Me.GroupBox_alarm.TabIndex = 23
        Me.GroupBox_alarm.TabStop = False
        Me.GroupBox_alarm.Text = "Alarm"
        '
        'Label_alarm
        '
        Me.Label_alarm.AutoSize = True
        Me.Label_alarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_alarm.Location = New System.Drawing.Point(7, 44)
        Me.Label_alarm.Name = "Label_alarm"
        Me.Label_alarm.Size = New System.Drawing.Size(67, 25)
        Me.Label_alarm.TabIndex = 0
        Me.Label_alarm.Text = "Alarm"
        '
        'RadioButton_On
        '
        Me.RadioButton_On.AutoSize = True
        Me.RadioButton_On.Location = New System.Drawing.Point(80, 40)
        Me.RadioButton_On.Name = "RadioButton_On"
        Me.RadioButton_On.Size = New System.Drawing.Size(41, 16)
        Me.RadioButton_On.TabIndex = 1
        Me.RadioButton_On.Text = "ON"
        Me.RadioButton_On.UseVisualStyleBackColor = True
        '
        'RadioButton_off
        '
        Me.RadioButton_off.AutoSize = True
        Me.RadioButton_off.Checked = True
        Me.RadioButton_off.Location = New System.Drawing.Point(80, 62)
        Me.RadioButton_off.Name = "RadioButton_off"
        Me.RadioButton_off.Size = New System.Drawing.Size(50, 16)
        Me.RadioButton_off.TabIndex = 2
        Me.RadioButton_off.TabStop = True
        Me.RadioButton_off.Text = "OFF"
        Me.RadioButton_off.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 505)
        Me.Controls.Add(Me.GroupBox_alarm)
        Me.Controls.Add(Me.Button_reset)
        Me.Controls.Add(Me.GroupBox_prereglages_minutes)
        Me.Controls.Add(Me.GroupBox_prereglages_heures)
        Me.Controls.Add(Me.Button_chrono)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_seconde_chrono)
        Me.Controls.Add(Me.Label_minute_chrono)
        Me.Controls.Add(Me.Label_heure_chrono)
        Me.Controls.Add(Me.TextBox_seconde_chrono)
        Me.Controls.Add(Me.TextBox_minute_chrono)
        Me.Controls.Add(Me.TextBox_heure_chrono)
        Me.Controls.Add(Me.Button_pause)
        Me.Controls.Add(Me.Button_stop)
        Me.Controls.Add(Me.Button_start)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_seconde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_min)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_heure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_heure_actuel)
        Me.Font = New System.Drawing.Font("Digital dream Fat Skew", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Chrono"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox_prereglages_heures.ResumeLayout(False)
        Me.GroupBox_prereglages_heures.PerformLayout()
        Me.GroupBox_prereglages_minutes.ResumeLayout(False)
        Me.GroupBox_prereglages_minutes.PerformLayout()
        Me.GroupBox_alarm.ResumeLayout(False)
        Me.GroupBox_alarm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_heure_actuel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_start As Button
    Friend WithEvents Button_stop As Button
    Friend WithEvents Button_pause As Button
    Friend WithEvents Label_seconde As Label
    Friend WithEvents Label_min As Label
    Friend WithEvents Label_heure As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox_heure_chrono As TextBox
    Friend WithEvents TextBox_minute_chrono As TextBox
    Friend WithEvents TextBox_seconde_chrono As TextBox
    Friend WithEvents Label_heure_chrono As Label
    Friend WithEvents Label_minute_chrono As Label
    Friend WithEvents Label_seconde_chrono As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_Chrono As RadioButton
    Friend WithEvents RadioButton_Timer As RadioButton
    Friend WithEvents Button_chrono As Button
    Friend WithEvents GroupBox_prereglages_heures As GroupBox
    Friend WithEvents RadioButton_3_heures As RadioButton
    Friend WithEvents RadioButton_2_heures As RadioButton
    Friend WithEvents RadioButton_1_heures As RadioButton
    Friend WithEvents GroupBox_prereglages_minutes As GroupBox
    Friend WithEvents RadioButton_45_min As RadioButton
    Friend WithEvents RadioButton_30_min As RadioButton
    Friend WithEvents RadioButton_15_min As RadioButton
    Friend WithEvents Button_reset As Button
    Friend WithEvents GroupBox_alarm As GroupBox
    Friend WithEvents RadioButton_off As RadioButton
    Friend WithEvents RadioButton_On As RadioButton
    Friend WithEvents Label_alarm As Label
End Class
