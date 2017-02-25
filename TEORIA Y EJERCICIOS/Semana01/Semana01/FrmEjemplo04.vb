<<<<<<< HEAD
﻿Public Class FrmEjemplo04
 
    Private Sub ChkOpcional_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOpcional.CheckedChanged
        If ChkOpcional.Checked Then
            MessageBox.Show("CHECK SELECCIONADO")
        Else
            MessageBox.Show("CHECK LIBERADO")
        End If
    End Sub


    Private Sub RbtOpcion01_CheckedChanged(sender As Object, e As EventArgs) Handles RbtOpcion01.CheckedChanged
        If RbtOpcion01.Checked Then MessageBox.Show("OPCION 01")
    End Sub

    Private Sub RbtOpcion02_CheckedChanged(sender As Object, e As EventArgs) Handles RbtOpcion02.CheckedChanged
        If RbtOpcion02.Checked Then MessageBox.Show("OPCION 02")
    End Sub

    Private Sub RbtOpcion03_CheckedChanged(sender As Object, e As EventArgs) Handles RbtOpcion03.CheckedChanged
        If RbtOpcion03.Checked Then MessageBox.Show("OPCION 03", "Mensaje")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVerificarRbt.Click
        'MessageBox.Show(ChkOpcional.Checked)
        If RbtOpcion01.Checked Then
            MessageBox.Show("OPCION 1", "Mensaje")
        Else
            If RbtOpcion02.Checked Then
                MessageBox.Show("OPCION 2", "Mensaje")
            Else
                If RbtOpcion03.Checked Then
                    MessageBox.Show("OPCION 3", "Mensaje")
                Else
                    MessageBox.Show("NINGUNO", "Mensaje")
                End If
            End If
        End If
    End Sub

    Private Sub BtnVerificarChk_Click(sender As Object, e As EventArgs) Handles BtnVerificarChk.Click
        If ChkOpcional.Checked Then
            MessageBox.Show("CHECK SELECCIONADO")
        Else
            MessageBox.Show("CHECK LIBERADO")
        End If
    End Sub


    Private Sub BtnLimpiarObj_Click(sender As Object, e As EventArgs) Handles BtnLimpiarObj.Click
        RbtOpcion01.Checked = False
        RbtOpcion02.Checked = False
        RbtOpcion03.Checked = False

        ChkOpcional.Checked = False
    End Sub
End Class
=======
﻿Public Class FrmEjemplo04
 
    Private Sub ChkOpcional_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOpcional.CheckedChanged
        If ChkOpcional.Checked Then
            MessageBox.Show("CHECK SELECCIONADO")
        Else
            MessageBox.Show("CHECK LIBERADO")
        End If
    End Sub


    Private Sub RbtOpcion01_CheckedChanged(sender As Object, e As EventArgs) Handles RbtOpcion01.CheckedChanged
        If RbtOpcion01.Checked Then MessageBox.Show("OPCION 01")
    End Sub

    Private Sub RbtOpcion02_CheckedChanged(sender As Object, e As EventArgs) Handles RbtOpcion02.CheckedChanged
        If RbtOpcion02.Checked Then MessageBox.Show("OPCION 02")
    End Sub

    Private Sub RbtOpcion03_CheckedChanged(sender As Object, e As EventArgs) Handles RbtOpcion03.CheckedChanged
        If RbtOpcion03.Checked Then MessageBox.Show("OPCION 03", "Mensaje")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVerificarRbt.Click
        'MessageBox.Show(ChkOpcional.Checked)
        If RbtOpcion01.Checked Then
            MessageBox.Show("OPCION 1", "Mensaje")
        Else
            If RbtOpcion02.Checked Then
                MessageBox.Show("OPCION 2", "Mensaje")
            Else
                If RbtOpcion03.Checked Then
                    MessageBox.Show("OPCION 3", "Mensaje")
                Else
                    MessageBox.Show("NINGUNO", "Mensaje")
                End If
            End If
        End If
    End Sub

    Private Sub BtnVerificarChk_Click(sender As Object, e As EventArgs) Handles BtnVerificarChk.Click
        If ChkOpcional.Checked Then
            MessageBox.Show("CHECK SELECCIONADO")
        Else
            MessageBox.Show("CHECK LIBERADO")
        End If
    End Sub


    Private Sub BtnLimpiarObj_Click(sender As Object, e As EventArgs) Handles BtnLimpiarObj.Click
        RbtOpcion01.Checked = False
        RbtOpcion02.Checked = False
        RbtOpcion03.Checked = False

        ChkOpcional.Checked = False
    End Sub
End Class
>>>>>>> 64b580890980be05fe093352e7379d408227b737
