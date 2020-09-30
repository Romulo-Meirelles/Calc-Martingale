Public Class Paineis_Aportes

    Private Painel_Ordem As New Panel
    Friend WithEvents Ordem_Copiar_btn As New Button
    Friend WithEvents Ordem_Win_btn As New Button
    Friend WithEvents Ordem_Loss_btn As New Button
    Private VALORDAORDEM As Double
    Private RETORNO As Double
    'Private BANCA As Double

    Private Sub Ordem_Copiar_btn_Click(sender As Object, e As EventArgs) Handles Ordem_Copiar_btn.Click
        Clipboard.SetText(VALORDAORDEM)
    End Sub
    Private Sub Ordem_Win_btn_Click(sender As Object, e As EventArgs) Handles Ordem_Win_btn.Click
        Main.Banca_txb.Text = CDbl(Main.Banca_txb.Text + RETORNO)
        Main.Painel_1º_Ordem.Controls.Clear()
        Main.CalcularTudo(Main.Banca_txb.Text, Main.Payout_txb.Text, Main.Retorno_txb.Text)
    End Sub
    Private Sub Ordem_Loss_btn_Click(sender As Object, e As EventArgs) Handles Ordem_Loss_btn.Click
        Dim COUNT As Integer = Main.Painel_1º_Ordem.Controls.Count - 1
        Main.Painel_1º_Ordem.Controls.RemoveAt(COUNT)
        Main.Banca_txb.Text = CDbl(Main.Banca_txb.Text - VALORDAORDEM)

        Dim O As Integer = 0
        If CDbl(Main.Banca_txb.Text) > VALORDAORDEM Then
            O = O + 1
        Else
        End If

        Dim D As Double = CDbl(Main.Banca_txb.Text) * O / 100
        Dim C As Double = 100 - D

        If C <= 100 And C >= 95 Then
            Main.Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.LightCoral
        ElseIf C <= 95.0 And C >= 90.0 Then
            Main.Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.Khaki
        ElseIf C <= 90.0 And C >= 0 Then
            Main.Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.SpringGreen
        End If

        Main.Risco_da_Operacao_lbl.Text = "Risco Desta Operação: " & FormatNumber(C, 2) & " %"

        If Main.Banca_txb.Text < 0 Then
            Main.Informacoe_lbl.ForeColor = System.Drawing.Color.LightCoral
            Main.Informacoe_lbl.Text = "CUIDADO! VOCÊ ESTÁ NEGATIVO." & vbCrLf & "BANCA QUEBRADA!"
            Main.Calcular_Ordens_btn.Enabled = True
            Main.TrackBar1.Enabled = True
            Main.Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.SpringGreen
            Main.Risco_da_Operacao_lbl.Text = "Risco Desta Operação: 0%"
        End If

        Dim IND As Integer = Main.Painel_1º_Ordem.Controls.Count - 1
        If IND = -1 Then
            Main.Informacoe_lbl.ForeColor = System.Drawing.Color.LightCoral
            Main.Informacoe_lbl.Text = "SUAS ORDENS ESGOTARAM, GERE NOVAS ORDENS."
            Main.Calcular_Ordens_btn.Enabled = True
            Main.TrackBar1.Enabled = True
            Main.Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.SpringGreen
            Main.Risco_da_Operacao_lbl.Text = "Risco Desta Operação: 0%"
        Else
            Main.Painel_1º_Ordem.Controls.Item(IND).Enabled = True
            Main.Painel_1º_Ordem.Controls.Item(IND).BackColor = System.Drawing.Color.Indigo
        End If





    End Sub

    Public Function Aporte(ByVal OrdemID As Integer, ValorOrdem As Double, ByVal RetornoOrdem As Double, ByVal PayOutOrdem As Integer) As Panel
        Dim Ordem_PayOut_lbl As New Label
        Dim Ordem_Pay_lbl As New Label
        Dim Ordem_Retorno_lbl As New Label
        Dim Ordem_Valor_lbl As New Label
        Dim Ordem_Ret_lbl As New Label
        Dim Martingale_Panel As New Panel
        Dim Martingale_Panel_lbl As New Label
        Dim Separador_1 As New Panel

        Painel_Ordem.Enabled = False
        Painel_Ordem.BackColor = System.Drawing.Color.Transparent
        Painel_Ordem.Dock = System.Windows.Forms.DockStyle.Left
        Painel_Ordem.Location = New System.Drawing.Point(8, 8)
        Painel_Ordem.Name = "Painel_Ordem_" & OrdemID
        Painel_Ordem.Size = New System.Drawing.Size(162, 155)
        Painel_Ordem.TabIndex = OrdemID

        'Ordem_Win
        Ordem_Win_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Ordem_Win_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Ordem_Win_btn.Enabled = True
        Ordem_Win_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Ordem_Win_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ordem_Win_btn.ForeColor = System.Drawing.Color.White
        Ordem_Win_btn.Image = Global.Calculadora_Martingale.My.Resources.Resources.Up
        Ordem_Win_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Ordem_Win_btn.Location = New System.Drawing.Point(19, 87)
        Ordem_Win_btn.Name = "Ordem_Win_btn_" & OrdemID
        Ordem_Win_btn.Size = New System.Drawing.Size(59, 26)
        Ordem_Win_btn.TabIndex = OrdemID
        Ordem_Win_btn.Text = "Win"
        Ordem_Win_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Ordem_Win_btn.UseVisualStyleBackColor = False
        '

        'Ordem_Valor_lbl
        Ordem_Valor_lbl.AutoSize = True
        Ordem_Valor_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.25!, System.Drawing.FontStyle.Bold)
        Ordem_Valor_lbl.ForeColor = System.Drawing.Color.White
        Ordem_Valor_lbl.Location = New System.Drawing.Point(16, 10)
        Ordem_Valor_lbl.Name = "Ordem_Valor_lbl_" & OrdemID
        Ordem_Valor_lbl.Size = New System.Drawing.Size(121, 17)
        Ordem_Valor_lbl.TabIndex = OrdemID
        Ordem_Valor_lbl.Text = OrdemID & "º Ordem: $ " & ValorOrdem
        VALORDAORDEM = ValorOrdem
        '
        'Ordem_Copiar_btn
        Ordem_Copiar_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(245, Byte), Integer))
        Ordem_Copiar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Ordem_Copiar_btn.Enabled = True
        Ordem_Copiar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Ordem_Copiar_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ordem_Copiar_btn.ForeColor = System.Drawing.Color.White
        Ordem_Copiar_btn.Image = Global.Calculadora_Martingale.My.Resources.Resources.copy_16px
        Ordem_Copiar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Ordem_Copiar_btn.Location = New System.Drawing.Point(19, 32)
        Ordem_Copiar_btn.Name = "Ordem_Copiar_btn_" & OrdemID
        Ordem_Copiar_btn.Size = New System.Drawing.Size(72, 26)
        Ordem_Copiar_btn.TabIndex = OrdemID
        Ordem_Copiar_btn.Text = "Copiar"
        Ordem_Copiar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Ordem_Copiar_btn.UseVisualStyleBackColor = False
        '
        'Ordem_Loss_btn
        Ordem_Loss_btn.BackColor = System.Drawing.Color.Red
        Ordem_Loss_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Ordem_Loss_btn.Enabled = True
        Ordem_Loss_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Ordem_Loss_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ordem_Loss_btn.ForeColor = System.Drawing.Color.White
        Ordem_Loss_btn.Image = Global.Calculadora_Martingale.My.Resources.Resources.Down
        Ordem_Loss_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Ordem_Loss_btn.Location = New System.Drawing.Point(84, 87)
        Ordem_Loss_btn.Name = "Ordem_Loss_btn_" & OrdemID
        Ordem_Loss_btn.Size = New System.Drawing.Size(60, 26)
        Ordem_Loss_btn.TabIndex = OrdemID
        Ordem_Loss_btn.Text = "Loss"
        Ordem_Loss_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Ordem_Loss_btn.UseVisualStyleBackColor = False
        '
        'Ordem_Ret_lbl
        Ordem_Ret_lbl.AutoSize = True
        Ordem_Ret_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Ordem_Ret_lbl.ForeColor = System.Drawing.Color.CadetBlue
        Ordem_Ret_lbl.Location = New System.Drawing.Point(16, 68)
        Ordem_Ret_lbl.Name = "Ordem_Ret_lbl_" & OrdemID
        Ordem_Ret_lbl.Size = New System.Drawing.Size(50, 13)
        Ordem_Ret_lbl.TabIndex = OrdemID
        Ordem_Ret_lbl.Text = "Retorno: "
        '
        'Ordem_Retorno_lbl
        Ordem_Retorno_lbl.AutoSize = True
        Ordem_Retorno_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.25!, System.Drawing.FontStyle.Bold)
        Ordem_Retorno_lbl.ForeColor = System.Drawing.Color.White
        Ordem_Retorno_lbl.Location = New System.Drawing.Point(72, 67)
        Ordem_Retorno_lbl.Name = "Ordem_Retorno_lbl_" & OrdemID
        Ordem_Retorno_lbl.Size = New System.Drawing.Size(48, 17)
        Ordem_Retorno_lbl.TabIndex = OrdemID
        Ordem_Retorno_lbl.Text = "$ " & RetornoOrdem
        RETORNO = RetornoOrdem
        '
        'Separador_1
        Separador_1.BackColor = System.Drawing.Color.Lime
        Separador_1.Location = New System.Drawing.Point(9, 128)
        Separador_1.Name = "Separador_1"
        Separador_1.Size = New System.Drawing.Size(143, 3)
        Separador_1.TabIndex = OrdemID
        '
        'Ordem_Pay_lbl
        Ordem_Pay_lbl.AutoSize = True
        Ordem_Pay_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Ordem_Pay_lbl.ForeColor = System.Drawing.Color.CadetBlue
        Ordem_Pay_lbl.Location = New System.Drawing.Point(17, 135)
        Ordem_Pay_lbl.Name = "Ordem_Pay_lbl"
        Ordem_Pay_lbl.Size = New System.Drawing.Size(46, 13)
        Ordem_Pay_lbl.TabIndex = OrdemID
        Ordem_Pay_lbl.Text = "Payout: "
        Ordem_Pay_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        'Ordem_PayOut_lbl
        Ordem_PayOut_lbl.AutoSize = True
        Ordem_PayOut_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Ordem_PayOut_lbl.ForeColor = System.Drawing.Color.Lime
        Ordem_PayOut_lbl.Location = New System.Drawing.Point(59, 135)
        Ordem_PayOut_lbl.Name = "Ordem_PayOut_lbl"
        Ordem_PayOut_lbl.Size = New System.Drawing.Size(34, 13)
        Ordem_PayOut_lbl.TabIndex = OrdemID
        Ordem_PayOut_lbl.Text = "+" & PayOutOrdem & "%"
        Ordem_PayOut_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        'Martingale_Panel
        '
        Martingale_Panel.BackColor = System.Drawing.Color.White 'FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Martingale_Panel.Controls.Add(Martingale_Panel_lbl)
        Martingale_Panel.Location = New System.Drawing.Point(97, 32)
        Martingale_Panel.Name = "Martingale_Panel" & OrdemID
        Martingale_Panel.Size = New System.Drawing.Size(47, 26)
        Martingale_Panel.TabIndex = OrdemID
        '
        'Martingale_Panel_lbl
        '
        Martingale_Panel_lbl.Dock = System.Windows.Forms.DockStyle.Left
        Martingale_Panel_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Martingale_Panel_lbl.ForeColor = System.Drawing.Color.Black
        Martingale_Panel_lbl.Location = New System.Drawing.Point(0, 0)
        Martingale_Panel_lbl.Name = "Martingale_Panel_lbl" & OrdemID
        Martingale_Panel_lbl.Size = New System.Drawing.Size(47, 26)
        Martingale_Panel_lbl.TabIndex = OrdemID
        Martingale_Panel_lbl.Text = OrdemID & "º MG"
        Martingale_Panel_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Painel_Ordem
        Painel_Ordem.Controls.Add(Ordem_PayOut_lbl)
        Painel_Ordem.Controls.Add(Ordem_Pay_lbl)
        Painel_Ordem.Controls.Add(Ordem_Win_btn)
        Painel_Ordem.Controls.Add(Ordem_Valor_lbl)
        Painel_Ordem.Controls.Add(Ordem_Copiar_btn)
        Painel_Ordem.Controls.Add(Ordem_Loss_btn)
        Painel_Ordem.Controls.Add(Ordem_Ret_lbl)
        Painel_Ordem.Controls.Add(Ordem_Retorno_lbl)
        Painel_Ordem.Controls.Add(Separador_1)
        Painel_Ordem.Controls.Add(Ordem_PayOut_lbl)
        Painel_Ordem.Controls.Add(Ordem_Pay_lbl)

        If OrdemID > 1 Then
            Painel_Ordem.Controls.Add(Martingale_Panel)
        End If

        CarregaBordas({Painel_Ordem, Martingale_Panel})
        Return Painel_Ordem
    End Function


End Class
