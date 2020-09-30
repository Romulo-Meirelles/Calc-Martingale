Module Mascaras
    Public Sub MaskApenasNumeros(e As KeyPressEventArgs, Sender As Object)
        Dim TeclaPressionada As String
        Dim UltimoChar As String
        TeclaPressionada = e.KeyChar
        If Sender.SelectionStart - 1 <> -1 Then
            UltimoChar = Sender.text.chars(Sender.SelectionStart - 1)
        Else
            UltimoChar = ""
        End If
        'Rejeitando teclas que sejam diferentes de BACKSPACE e que não sejam algum numero

        If (AscW(e.KeyChar) < 48 Or AscW(e.KeyChar) > 57) And (AscW(e.KeyChar) <> 8) And (AscW(e.KeyChar) <> 44) Then
            e.KeyChar = ""
        End If

    End Sub
End Module
