Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

	End Sub

	Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

	End Sub

	Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

	End Sub

	Function FactorScala(ByVal a01 As Single, ByVal top1 As Single, ByVal k1 As Single, ByVal ro1 As Single) As Single()
		Dim n, vf, dt, a, t As Single
		n = top1 / 0.1
		vf = 0
		dt = 0.1
		a = a01
		Dim v(n) As Single
        v(0) = a01
        Dim t1(n) As Single
        t1(0) = 0
        For i As Integer = 1 To n
            t = i * dt
            vf = Math.Sqrt((8 * System.Math.PI * ro1 * a) / 3 - k1)
            a = a + vf * dt
            t1(i) = t
            v(i) = a
        Next
        Return v
	End Function

    Function Distanta(ByVal a01 As Single, ByVal top1 As Single, ByVal k1 As Single, ByVal rom1 As Single,
                      ByVal roe1 As Single, ByVal r11 As Single, ByVal r21 As Single, ByVal teta11 As Single,
                      ByVal teta21 As Single, ByVal fi11 As Single, ByVal fi21 As Single) As Single()
        Dim n, ro, r, teta, dr, dteta, dfi, d1 As Single
        n = top1 / 0.1
        Dim d(n) As Single
        r = r11
        teta = teta11
        n = top1 / 0.1
        dr = r11 - r21
        dteta = teta11 - teta21
        dfi = fi11 - fi21
        ro = roe1 + rom1
        Dim a(n) As Single
        a = FactorScala(a01, top1, k1, ro)
        For i As Integer = 0 To n
            d1 = a(i) ^ 2 * (dr ^ 2 / (1 - k1 * r11 ^ 2) + r ^ 2 * (dteta ^ 2 + (System.Math.Sin(teta)) ^ 2 * dfi ^ 2))
            d(i) = Math.Sqrt(d1)
            Console.Write(d(i))
        Next
        Return d
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles grafic.Click


        Dim a0i, topi, ki, romi, roei, r1i, r2i, teta1i, teta2i, fi1i, fi2i As Single

        If String.IsNullOrEmpty(a0.Text) And String.IsNullOrEmpty(top.Text) And String.IsNullOrEmpty(rom.Text) And String.IsNullOrEmpty(roe.Text) And String.IsNullOrEmpty(k.Text) And String.IsNullOrEmpty(r1.Text) And String.IsNullOrEmpty(r2.Text) And String.IsNullOrEmpty(teta1.Text) And String.IsNullOrEmpty(teta2.Text) And String.IsNullOrEmpty(fi1.Text) And String.IsNullOrEmpty(fi2.Text) Then
			MessageBox.Show("Completati toate campurile")
		Else


			a0i = Convert.ToSingle(a0.Text)
			topi = Convert.ToSingle(top.Text)
			romi = Convert.ToSingle(rom.Text)
			roei = Convert.ToSingle(roe.Text)
			ki = Convert.ToSingle(k.Text)
			r1i = Convert.ToSingle(r1.Text)
			r2i = Convert.ToSingle(r2.Text)
			teta1i = Convert.ToSingle(teta1.Text)
			teta2i = Convert.ToSingle(teta2.Text)
			fi1i = Convert.ToSingle(fi1.Text)
			fi2i = Convert.ToSingle(fi2.Text)

			If (Not (romi + roei).Equals(1) Or romi < 0 Or roei < 0) Then
				MessageBox.Show("Densitatile sunt gresite")
			Else
				If (Not ki.Equals(0) And Not ki.Equals(1) And Not ki.Equals(-1)) Then
					MessageBox.Show("Curbura poate avea valorile 1, 0 sau -1")
				Else
					'setup the chart area

					Chart1.ChartAreas.Clear()
					Chart1.ChartAreas.Add("Default")

					With Chart1.ChartAreas("Default")
                        .AxisX.Title = "Timp" ' x label
                        .AxisX.MajorGrid.LineColor = Color.LightGray
                        .AxisY.MajorGrid.LineColor = Color.LightGray
                        .AxisY.Title = "Distanta" 'y label
                        .BorderColor = Color.White
                    End With

					'specify series plot lines 
					Chart1.Series.Clear()
					Chart1.Series.Add("Grafic distanta")
					Chart1.Series("Grafic distanta").Color = Color.LightSeaGreen



					Chart1.Series("Grafic distanta").ChartType = DataVisualization.Charting.SeriesChartType.Line
					Dim n As Integer = topi / 0.1
                    Dim t1(n) As Double
                    t1(0) = 0
                    Dim t As Double
                    For i As Integer = 1 To n
                        t = Math.Round(i * 0.1, 2)
                        t1(i) = t
                    Next
                    Dim d(n) As Single
					d = Distanta(a0i, topi, ki, romi, roei, r1i, r2i, teta1i, teta2i, fi1i, fi2i)
                    For i As Integer = 1 To n-1 Step 1
                        Chart1.Series("Grafic distanta").Points.AddXY(t1(i), d(i+1))

                    Next
                End If

			End If

		End If

	End Sub

	Private Sub top_TextChanged(sender As Object, e As EventArgs) Handles top.TextChanged

	End Sub

	Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles fi2.TextChanged

	End Sub

	Private Sub a0_TextChanged(sender As Object, e As EventArgs) Handles a0.TextChanged

	End Sub

	Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub descriere_Click(sender As Object, e As EventArgs) Handles descriere.Click
		Dim a0i, topi, ki, romi, roei, r1i, r2i, teta1i, teta2i, fi1i, fi2i As Single

		If String.IsNullOrEmpty(a0.Text) And String.IsNullOrEmpty(top.Text) And String.IsNullOrEmpty(rom.Text) And String.IsNullOrEmpty(roe.Text) And String.IsNullOrEmpty(k.Text) And String.IsNullOrEmpty(r1.Text) And String.IsNullOrEmpty(r2.Text) And String.IsNullOrEmpty(teta1.Text) And String.IsNullOrEmpty(teta2.Text) And String.IsNullOrEmpty(fi1.Text) And String.IsNullOrEmpty(fi2.Text) Then
			MessageBox.Show("Completati toate campurile")
		Else

			a0i = Convert.ToSingle(a0.Text)
			topi = Convert.ToSingle(top.Text)
			romi = Convert.ToSingle(rom.Text)
			roei = Convert.ToSingle(roe.Text)
			ki = Convert.ToSingle(k.Text)
			r1i = Convert.ToSingle(r1.Text)
			r2i = Convert.ToSingle(r2.Text)
			teta1i = Convert.ToSingle(teta1.Text)
			teta2i = Convert.ToSingle(teta2.Text)
			fi1i = Convert.ToSingle(fi1.Text)
			fi2i = Convert.ToSingle(fi2.Text)

			If (Not (romi + roei).Equals(1) Or romi < 0 Or roei < 0) Then
				MessageBox.Show("Densitatile sunt gresite")

			Else
				If (Not ki.Equals(0) And Not ki.Equals(1) And Not ki.Equals(-1)) Then
					MessageBox.Show("Curbura poate avea valorile 1, 0 sau -1")
				Else
					materie.Text = Convert.ToSingle(rom.Text) * 100
						energie.Text = Convert.ToSingle(roe.Text) * 100


					If (ki > 0) Then
						tip.Text = "deschis"
					Else
						If (ki < 0) Then
								tip.Text = "inchis"
							Else
								tip.Text = "plat"
							End If
						End If

					End If
				End If
			End If
	End Sub

	Private Sub materie_TextChanged(sender As Object, e As EventArgs) Handles materie.TextChanged

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		a0.Text = 1
        top.Text = 10
        k.Text = 0
		rom.Text = 0.25
		roe.Text = 0.75
        r1.Text = 0
        r2.Text = 1
        teta1.Text = 0
        teta2.Text = 0
        fi1.Text = 0
        fi2.Text = 0
    End Sub

    Private Sub r1_TextChanged(sender As Object, e As EventArgs) Handles r1.TextChanged

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class
