<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.top = New System.Windows.Forms.TextBox()
        Me.k = New System.Windows.Forms.TextBox()
        Me.rom = New System.Windows.Forms.TextBox()
        Me.roe = New System.Windows.Forms.TextBox()
        Me.r1 = New System.Windows.Forms.TextBox()
        Me.r2 = New System.Windows.Forms.TextBox()
        Me.teta1 = New System.Windows.Forms.TextBox()
        Me.teta2 = New System.Windows.Forms.TextBox()
        Me.fi1 = New System.Windows.Forms.TextBox()
        Me.fi2 = New System.Windows.Forms.TextBox()
        Me.a0 = New System.Windows.Forms.TextBox()
        Me.grafic = New System.Windows.Forms.Button()
        Me.descriere = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.materie = New System.Windows.Forms.TextBox()
        Me.energie = New System.Windows.Forms.TextBox()
        Me.tip = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.LightGray
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(31, 104)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(578, 489)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(667, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Factor scala initial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(667, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Timp Oprire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(667, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Curbura Universului"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(667, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Densitatea materiei"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(667, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Densitatea energiei"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(667, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Coordoonatele galaxiei"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(667, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "r1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(841, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "r2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(667, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Unghiul facut cu axele de coordonate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(667, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "teta1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(841, 411)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "teta2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(667, 468)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "phi1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(846, 466)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "phi2"
        '
        'top
        '
        Me.top.Location = New System.Drawing.Point(865, 106)
        Me.top.Name = "top"
        Me.top.Size = New System.Drawing.Size(100, 22)
        Me.top.TabIndex = 15
        '
        'k
        '
        Me.k.Location = New System.Drawing.Point(865, 134)
        Me.k.Name = "k"
        Me.k.Size = New System.Drawing.Size(100, 22)
        Me.k.TabIndex = 16
        '
        'rom
        '
        Me.rom.Location = New System.Drawing.Point(865, 160)
        Me.rom.Name = "rom"
        Me.rom.Size = New System.Drawing.Size(100, 22)
        Me.rom.TabIndex = 17
        '
        'roe
        '
        Me.roe.Location = New System.Drawing.Point(865, 188)
        Me.roe.Name = "roe"
        Me.roe.Size = New System.Drawing.Size(100, 22)
        Me.roe.TabIndex = 18
        '
        'r1
        '
        Me.r1.Location = New System.Drawing.Point(713, 282)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(100, 22)
        Me.r1.TabIndex = 19
        '
        'r2
        '
        Me.r2.Location = New System.Drawing.Point(889, 280)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(100, 22)
        Me.r2.TabIndex = 20
        '
        'teta1
        '
        Me.teta1.Location = New System.Drawing.Point(713, 406)
        Me.teta1.Name = "teta1"
        Me.teta1.Size = New System.Drawing.Size(100, 22)
        Me.teta1.TabIndex = 21
        '
        'teta2
        '
        Me.teta2.Location = New System.Drawing.Point(889, 406)
        Me.teta2.Name = "teta2"
        Me.teta2.Size = New System.Drawing.Size(100, 22)
        Me.teta2.TabIndex = 22
        '
        'fi1
        '
        Me.fi1.Location = New System.Drawing.Point(713, 463)
        Me.fi1.Name = "fi1"
        Me.fi1.Size = New System.Drawing.Size(100, 22)
        Me.fi1.TabIndex = 23
        '
        'fi2
        '
        Me.fi2.Location = New System.Drawing.Point(889, 463)
        Me.fi2.Name = "fi2"
        Me.fi2.Size = New System.Drawing.Size(100, 22)
        Me.fi2.TabIndex = 24
        '
        'a0
        '
        Me.a0.BackColor = System.Drawing.Color.White
        Me.a0.Location = New System.Drawing.Point(865, 78)
        Me.a0.Name = "a0"
        Me.a0.Size = New System.Drawing.Size(100, 22)
        Me.a0.TabIndex = 25
        '
        'grafic
        '
        Me.grafic.Location = New System.Drawing.Point(670, 519)
        Me.grafic.Name = "grafic"
        Me.grafic.Size = New System.Drawing.Size(232, 74)
        Me.grafic.TabIndex = 27
        Me.grafic.Text = "Graficul evolutiei distantei intre cele doua galaxii"
        Me.grafic.UseVisualStyleBackColor = True
        '
        'descriere
        '
        Me.descriere.Location = New System.Drawing.Point(1071, 519)
        Me.descriere.Name = "descriere"
        Me.descriere.Size = New System.Drawing.Size(220, 74)
        Me.descriere.TabIndex = 28
        Me.descriere.Text = "Descrierea Universului"
        Me.descriere.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(1129, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 17)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Descriere Univers"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(289, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 17)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Grafic"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(1023, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 17)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Ai ales Universul in care:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1040, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 17)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Materia este in proportie"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1040, 187)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(184, 17)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Energia este in proportie de"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1023, 239)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 17)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Iar universul este"
        '
        'materie
        '
        Me.materie.Location = New System.Drawing.Point(1262, 143)
        Me.materie.Name = "materie"
        Me.materie.Size = New System.Drawing.Size(44, 22)
        Me.materie.TabIndex = 37
        '
        'energie
        '
        Me.energie.Location = New System.Drawing.Point(1262, 182)
        Me.energie.Name = "energie"
        Me.energie.Size = New System.Drawing.Size(44, 22)
        Me.energie.TabIndex = 38
        '
        'tip
        '
        Me.tip.Location = New System.Drawing.Point(1262, 233)
        Me.tip.Name = "tip"
        Me.tip.Size = New System.Drawing.Size(100, 22)
        Me.tip.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1119, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 29)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Valori presetate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(1312, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 17)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "%"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1312, 185)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 17)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1374, 633)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tip)
        Me.Controls.Add(Me.energie)
        Me.Controls.Add(Me.materie)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.descriere)
        Me.Controls.Add(Me.grafic)
        Me.Controls.Add(Me.a0)
        Me.Controls.Add(Me.fi2)
        Me.Controls.Add(Me.fi1)
        Me.Controls.Add(Me.teta2)
        Me.Controls.Add(Me.teta1)
        Me.Controls.Add(Me.r2)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.roe)
        Me.Controls.Add(Me.rom)
        Me.Controls.Add(Me.k)
        Me.Controls.Add(Me.top)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents top As TextBox
	Friend WithEvents k As TextBox
	Friend WithEvents rom As TextBox
	Friend WithEvents roe As TextBox
	Friend WithEvents r1 As TextBox
	Friend WithEvents r2 As TextBox
	Friend WithEvents teta1 As TextBox
	Friend WithEvents teta2 As TextBox
	Friend WithEvents fi1 As TextBox
	Friend WithEvents fi2 As TextBox
	Friend WithEvents a0 As TextBox
	Friend WithEvents grafic As Button
	Friend WithEvents descriere As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents materie As TextBox
	Friend WithEvents energie As TextBox
	Friend WithEvents tip As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label20 As Label
	Friend WithEvents Label21 As Label
End Class
