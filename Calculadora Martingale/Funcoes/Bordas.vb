Public Module Bordas
    Private Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

    'DECLARAÇÃO REGIONHANDLE PARA BORDAS
    Private regionHandle As IntPtr

    'FUNÇÃO QUE CRIA BORDAS NOS OBJETOS, MODIFIQUE O 20, 20 PARA O TAMANHO DAS BORDAS.
    Public Sub CarregaBordas(ByVal Componente() As Object)
        For Index As Integer = 0 To Componente.Count - 1
            regionHandle = New IntPtr(CreateRoundRectRgn(0, 0, Componente(Index).Width, Componente(Index).Height, 10, 10))
            Componente(Index).Region = Region.FromHrgn(regionHandle)
            Componente(Index).Region.ReleaseHrgn(regionHandle)
        Next
    End Sub
End Module
