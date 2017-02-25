<<<<<<< HEAD
﻿Public Class FrmEjemplo02

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Definir Num, Cuadrado, Doble Como Entero;
        Dim Num As Integer, Cuadrado As Integer, Doble As Integer
        'Definir Mitad Como Real;
        Dim Mitad As Double

        'Leer Num;
        Num = TxtNumero.Text

        'Mitad <- Num / 2;
        Mitad = Num / 2
        'Doble <- Num * 2;
        Doble = Num * 2
        'Cuadrado <- Num * Num;
        Cuadrado = Num * Num

        'Escribir "La Mitad de ", Num, " es: ", Mitad;
        TxtMitad.Text = Mitad
        'Escribir "El Doble de ", Num, " es: ", Doble;
        TxtDoble.Text = Doble
        'Escribir "El Cuadrado de ", Num, " es: ", Cuadrado;
        TxtCuadrado.Text = Cuadrado
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtNumero.Text = ""
        TxtMitad.Text = ""
        TxtDoble.Text = ""
        TxtCuadrado.Text = ""
        'TxtNumero.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
=======
﻿Public Class FrmEjemplo02

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Definir Num, Cuadrado, Doble Como Entero;
        Dim Num As Integer, Cuadrado As Integer, Doble As Integer
        'Definir Mitad Como Real;
        Dim Mitad As Double

        'Leer Num;
        Num = TxtNumero.Text

        'Mitad <- Num / 2;
        Mitad = Num / 2
        'Doble <- Num * 2;
        Doble = Num * 2
        'Cuadrado <- Num * Num;
        Cuadrado = Num * Num

        'Escribir "La Mitad de ", Num, " es: ", Mitad;
        TxtMitad.Text = Mitad
        'Escribir "El Doble de ", Num, " es: ", Doble;
        TxtDoble.Text = Doble
        'Escribir "El Cuadrado de ", Num, " es: ", Cuadrado;
        TxtCuadrado.Text = Cuadrado
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtNumero.Text = ""
        TxtMitad.Text = ""
        TxtDoble.Text = ""
        TxtCuadrado.Text = ""
        'TxtNumero.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
>>>>>>> 64b580890980be05fe093352e7379d408227b737
End Class