Public Class FrmEjemplo01

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Definir Lado, Area, Perimetro Como Entero;
        Dim Lado As Integer, Area As Integer, Perimetro As Integer

        'Leer Lado;
        Lado = TxtLado.Text

        'Area <- Lado * Lado;
        Area = Lado * Lado
        'Perimetro <- Lado * 4;
        Perimetro = Lado * 4

        'Escribir "El Area es: ", Area;
        TxtArea.Text = Area
        'Escribir "El Perimetro es: ", Perimetro;
        TxtPerimetro.Text = Perimetro
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtLado.Text = ""
        TxtArea.Text = ""
        TxtPerimetro.Text = ""
        TxtLado.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
