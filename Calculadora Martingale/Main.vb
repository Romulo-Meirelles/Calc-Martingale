Imports System.Runtime.InteropServices

Public Class Main
    ''' <summary>
    '''BANCA = 300
    '''PAYOUT = 90%
    '''RETORNO PORCENTAGEM = 11%
    '''
    ''' SABER VALOR DE RETORNO LUCRO. (300 * 11% / 100) = VALOR DE RETORNO(R$ 33)
    ''' SABER VALOR DA ORDEM. (VALOR DE RETORNO(R$ 33) / 90% * 100) = VALOR DA ORDEM A SER ABERTA(36,67)
    ''' SABER MARTINGALE 2. (36,67 + 33 / 90% * 100) = 77,41
    ''' SABER MARTINGALE 3. (77,41 + 36,67 + 33 / 90% * 100) = 163,41
    ''' 
    ''' </summary>
    ''' 

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregaBordas({Painel_Controle, Painel_Risco, Excluir_Ordem_btn, Painel_1º_Ordem, Painel_Informacoes})

    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Title_lbl_MouseMove(sender As Object, e As MouseEventArgs) Handles Title_lbl.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Icon_Pic_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_Pic.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Minimize_Pic_Click(sender As Object, e As EventArgs) Handles Minimize_Pic.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OnTop_Pic_Click(sender As Object, e As EventArgs) Handles OnTop_Pic.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            OnTop_Pic.Image = My.Resources.OnTop_24x
        Else
            Me.TopMost = True
            OnTop_Pic.Image = My.Resources.UnTop_24x
        End If
    End Sub
    Private Sub Close_Pic_Click(sender As Object, e As EventArgs) Handles Close_Pic.Click
        End
    End Sub
    Private Sub Martingale_Swith_CheckedChanged(sender As Object) Handles Martingale_Swith.CheckedChanged
        Call CHECK_SWITH()
    End Sub
    Private Sub CHECK_SWITH()
        If Martingale_Swith.Checked = True Then
            TrackBar1.Enabled = True
        Else
            TrackBar1.Value = 1
            Martingale_lbl.Text = "Martingale: 1"
            TrackBar1.Enabled = False
        End If
        Calcular_Ordens_btn.Enabled = True
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Martingale_lbl.Text = "Martingale: " & TrackBar1.Value
    End Sub

    Private Sub Banca_txb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Banca_txb.KeyPress
        MaskApenasNumeros(e, sender)
    End Sub

    Private Sub Payout_txb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Payout_txb.KeyPress
        MaskApenasNumeros(e, sender)
    End Sub
    Private Sub Retorno_txb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Retorno_txb.KeyPress
        MaskApenasNumeros(e, sender)
    End Sub

    Private Sub Excluir_Ordem_btn_Click(sender As Object, e As EventArgs) Handles Excluir_Ordem_btn.Click
        Painel_1º_Ordem.Controls.Clear()
        Calcular_Ordens_btn.Enabled = True
        Call CHECK_SWITH()
        Informacoe_lbl.ForeColor = System.Drawing.Color.MediumSpringGreen
        Informacoe_lbl.Text = "ORDENS EXCLUÍDAS E PAINEL LIMPO."
        Risco_da_Operacao_lbl.Text = "Risco da Operação: 0%"
    End Sub
    Private Sub Calcular_Ordens_btn_Click(sender As Object, e As EventArgs) Handles Calcular_Ordens_btn.Click
        Try
            If Banca_txb.Text = "" Or Payout_txb.Text = "" Or Retorno_txb.Text = "" Then
                'MessageBox.Show("Preencha os campos em branco.", "Preencha.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Informacoe_lbl.ForeColor = System.Drawing.Color.LightCoral
                Informacoe_lbl.Text = "PREENCHA OS CAMPOS EM BRANCO."
                Exit Sub
            End If

            If CDbl(Banca_txb.Text) < 0 Then
                Informacoe_lbl.ForeColor = System.Drawing.Color.LightCoral
                Informacoe_lbl.Text = "O VALOR DE BANCA NÃO PODE SER NEGATIVO."
                Exit Sub
            End If

            CalcularTudo(Banca_txb.Text, Payout_txb.Text, Retorno_txb.Text)
        Catch ex As Exception
            Informacoe_lbl.ForeColor = System.Drawing.Color.LightCoral
            Informacoe_lbl.Text = ex.Message
        End Try

    End Sub
    Public Sub CalcularTudo(ByVal Banca As Double, Payout As Double, Retorno As Double)

        Painel_1º_Ordem.Controls.Clear()

        Dim RET, ORDEM As Double

        RET = Banca * Retorno / 100
        ORDEM = RET / Payout * 100
        Dim F As Boolean = True
        Dim CONTAGEMDEORDEM As Integer = 0

        For I As Integer = 1 To TrackBar1.Value
            Dim AP As New Paineis_Aportes
            Dim PANELCONTROL As Panel = AP.Aporte(I, FormatNumber(ORDEM, 2), FormatNumber(RET, 2), Payout)


            If Banca > ORDEM Then
                CONTAGEMDEORDEM = CONTAGEMDEORDEM + 1
            Else
            End If

            If F = True Then
                PANELCONTROL.BackColor = System.Drawing.Color.Indigo
                PANELCONTROL.Enabled = True
                F = False
            End If

            Painel_1º_Ordem.Controls.Add(PANELCONTROL)
            PANELCONTROL.BringToFront()
            RET = RET + ORDEM
            ORDEM = RET / Payout * 100

        Next

        Dim D As Double = Banca * CONTAGEMDEORDEM / 100
        Dim C As Double = 100 - D

        If C <= 100 And C >= 95 Then
            Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.LightCoral
        ElseIf C <= 95.0 And C >= 90.0 Then
            Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.Khaki
        ElseIf C <= 90.0 And C >= 0 Then
            Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.SpringGreen
        End If

        Risco_da_Operacao_lbl.Text = "Risco Desta Operação: " & FormatNumber(C, 2) & " %"



        Informacoe_lbl.ForeColor = System.Drawing.Color.MediumSpringGreen
        Informacoe_lbl.Text = "INFORMAÇÕES IMPORTANTES"
        Calcular_Ordens_btn.Enabled = False
        TrackBar1.Enabled = False
    End Sub

    Private Sub Writen_lbl_Click(sender As Object, e As EventArgs) Handles Writen_lbl.Click
        System.Diagnostics.Process.Start("https://github.com/Romulo-Meirelles")
    End Sub
End Class


