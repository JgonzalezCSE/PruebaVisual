Module MOD_Funciones
    Public Function RetornarCero() As String
        Return "Esta es una prueba"
    End Function

    Public Sub ContarHasta5()
        For index As Integer = 1 To 5
            FRM_Principal.Label1.Text = index
            FRM_Principal.Refresh()
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    Public Sub LlenarListView()

    End Sub
End Module
