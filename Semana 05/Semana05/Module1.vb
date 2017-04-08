Module Module1
    Public oCn As SqlConnection

    Public Sub abrir_bd()
        oCn = New SqlConnection
        'oCn.ConnectionString = "Data Source=(local); Initial Catalog=BDFASTFOOD; User Id=sa; Password=alumno"
        oCn.ConnectionString = "Data Source=(local); Initial Catalog=BDFASTFOOD; Integrated Security=true"
        oCn.Open()
    End Sub

    Public Sub cerrar_bd()
        oCn.Close()
    End Sub
End Module
