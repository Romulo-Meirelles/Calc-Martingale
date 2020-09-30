<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Icon_Pic = New System.Windows.Forms.PictureBox()
        Me.Title_lbl = New System.Windows.Forms.Label()
        Me.Minimize_Pic = New System.Windows.Forms.PictureBox()
        Me.OnTop_Pic = New System.Windows.Forms.PictureBox()
        Me.Close_Pic = New System.Windows.Forms.PictureBox()
        Me.Painel_Controle = New System.Windows.Forms.Panel()
        Me.Calcular_Ordens_btn = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Martingale_lbl = New System.Windows.Forms.Label()
        Me.Retorno_lbl = New System.Windows.Forms.Label()
        Me.Retorno_txb = New System.Windows.Forms.TextBox()
        Me.Payout_lbl = New System.Windows.Forms.Label()
        Me.Payout_txb = New System.Windows.Forms.TextBox()
        Me.Banca_lbl = New System.Windows.Forms.Label()
        Me.Banca_txb = New System.Windows.Forms.TextBox()
        Me.Painel_1º_Ordem = New System.Windows.Forms.Panel()
        Me.Painel_Ordem1 = New System.Windows.Forms.Panel()
        Me.Martingale_Panel = New System.Windows.Forms.Panel()
        Me.Martingale_Panel_lbl = New System.Windows.Forms.Label()
        Me.Ordem1_PayOut_lbl = New System.Windows.Forms.Label()
        Me.Ordem1_Pay_lbl = New System.Windows.Forms.Label()
        Me.Order1_Win_btn = New System.Windows.Forms.Button()
        Me.Ordem1_Valor_lbl = New System.Windows.Forms.Label()
        Me.Order1_Copiar_btn = New System.Windows.Forms.Button()
        Me.Order1_Loss_btn = New System.Windows.Forms.Button()
        Me.Order1_Ret_lbl = New System.Windows.Forms.Label()
        Me.Ordem1_Retorno_lbl = New System.Windows.Forms.Label()
        Me.Separador_1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Painel_Risco = New System.Windows.Forms.Panel()
        Me.Excluir_Ordem_btn = New System.Windows.Forms.Button()
        Me.Risco_da_Operacao_lbl = New System.Windows.Forms.Label()
        Me.Ordens_lbl = New System.Windows.Forms.Label()
        Me.Painel_Informacoes = New System.Windows.Forms.Panel()
        Me.Writen_lbl = New System.Windows.Forms.Label()
        Me.Informacoe_lbl = New System.Windows.Forms.Label()
        Me.Martingale_Swith = New Calculadora_Martingale.VizualSwitch3()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimize_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnTop_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Painel_Controle.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Painel_1º_Ordem.SuspendLayout()
        Me.Painel_Ordem1.SuspendLayout()
        Me.Martingale_Panel.SuspendLayout()
        Me.Painel_Risco.SuspendLayout()
        Me.Painel_Informacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Icon_Pic)
        Me.Panel1.Controls.Add(Me.Title_lbl)
        Me.Panel1.Controls.Add(Me.Minimize_Pic)
        Me.Panel1.Controls.Add(Me.OnTop_Pic)
        Me.Panel1.Controls.Add(Me.Close_Pic)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 29)
        Me.Panel1.TabIndex = 0
        '
        'Icon_Pic
        '
        Me.Icon_Pic.Image = Global.Calculadora_Martingale.My.Resources.Resources.estimate_24px
        Me.Icon_Pic.Location = New System.Drawing.Point(3, 3)
        Me.Icon_Pic.Name = "Icon_Pic"
        Me.Icon_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Icon_Pic.TabIndex = 3
        Me.Icon_Pic.TabStop = False
        '
        'Title_lbl
        '
        Me.Title_lbl.AutoSize = True
        Me.Title_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_lbl.ForeColor = System.Drawing.Color.White
        Me.Title_lbl.Location = New System.Drawing.Point(30, 8)
        Me.Title_lbl.Name = "Title_lbl"
        Me.Title_lbl.Size = New System.Drawing.Size(231, 14)
        Me.Title_lbl.TabIndex = 0
        Me.Title_lbl.Text = "Calculadora Martingale - Rômulo Meirelles"
        '
        'Minimize_Pic
        '
        Me.Minimize_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize_Pic.Dock = System.Windows.Forms.DockStyle.Right
        Me.Minimize_Pic.Image = Global.Calculadora_Martingale.My.Resources.Resources.Minimize
        Me.Minimize_Pic.Location = New System.Drawing.Point(596, 0)
        Me.Minimize_Pic.Name = "Minimize_Pic"
        Me.Minimize_Pic.Size = New System.Drawing.Size(24, 29)
        Me.Minimize_Pic.TabIndex = 2
        Me.Minimize_Pic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Minimize_Pic, "Minimixar.")
        '
        'OnTop_Pic
        '
        Me.OnTop_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OnTop_Pic.Dock = System.Windows.Forms.DockStyle.Right
        Me.OnTop_Pic.Image = Global.Calculadora_Martingale.My.Resources.Resources.UnTop_24x
        Me.OnTop_Pic.Location = New System.Drawing.Point(620, 0)
        Me.OnTop_Pic.Name = "OnTop_Pic"
        Me.OnTop_Pic.Size = New System.Drawing.Size(24, 29)
        Me.OnTop_Pic.TabIndex = 1
        Me.OnTop_Pic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.OnTop_Pic, "Sobrepor Aplicativo.")
        '
        'Close_Pic
        '
        Me.Close_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Pic.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_Pic.Image = Global.Calculadora_Martingale.My.Resources.Resources.Close
        Me.Close_Pic.Location = New System.Drawing.Point(644, 0)
        Me.Close_Pic.Name = "Close_Pic"
        Me.Close_Pic.Size = New System.Drawing.Size(24, 29)
        Me.Close_Pic.TabIndex = 0
        Me.Close_Pic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Close_Pic, "Fechar.")
        '
        'Painel_Controle
        '
        Me.Painel_Controle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Painel_Controle.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Painel_Controle.Controls.Add(Me.Calcular_Ordens_btn)
        Me.Painel_Controle.Controls.Add(Me.TrackBar1)
        Me.Painel_Controle.Controls.Add(Me.Martingale_Swith)
        Me.Painel_Controle.Controls.Add(Me.Martingale_lbl)
        Me.Painel_Controle.Controls.Add(Me.Retorno_lbl)
        Me.Painel_Controle.Controls.Add(Me.Retorno_txb)
        Me.Painel_Controle.Controls.Add(Me.Payout_lbl)
        Me.Painel_Controle.Controls.Add(Me.Payout_txb)
        Me.Painel_Controle.Controls.Add(Me.Banca_lbl)
        Me.Painel_Controle.Controls.Add(Me.Banca_txb)
        Me.Painel_Controle.Location = New System.Drawing.Point(8, 37)
        Me.Painel_Controle.Name = "Painel_Controle"
        Me.Painel_Controle.Size = New System.Drawing.Size(159, 330)
        Me.Painel_Controle.TabIndex = 1
        '
        'Calcular_Ordens_btn
        '
        Me.Calcular_Ordens_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Calcular_Ordens_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Calcular_Ordens_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calcular_Ordens_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calcular_Ordens_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular_Ordens_btn.ForeColor = System.Drawing.Color.White
        Me.Calcular_Ordens_btn.Location = New System.Drawing.Point(28, 278)
        Me.Calcular_Ordens_btn.Name = "Calcular_Ordens_btn"
        Me.Calcular_Ordens_btn.Size = New System.Drawing.Size(106, 38)
        Me.Calcular_Ordens_btn.TabIndex = 0
        Me.Calcular_Ordens_btn.Text = "Calcular Ordens"
        Me.Calcular_Ordens_btn.UseVisualStyleBackColor = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Enabled = False
        Me.TrackBar1.LargeChange = 0
        Me.TrackBar1.Location = New System.Drawing.Point(19, 220)
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(120, 45)
        Me.TrackBar1.SmallChange = 0
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 1
        '
        'Martingale_lbl
        '
        Me.Martingale_lbl.AutoSize = True
        Me.Martingale_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Martingale_lbl.ForeColor = System.Drawing.Color.White
        Me.Martingale_lbl.Location = New System.Drawing.Point(19, 197)
        Me.Martingale_lbl.Name = "Martingale_lbl"
        Me.Martingale_lbl.Size = New System.Drawing.Size(79, 14)
        Me.Martingale_lbl.TabIndex = 6
        Me.Martingale_lbl.Text = "Martingale: 1"
        '
        'Retorno_lbl
        '
        Me.Retorno_lbl.AutoSize = True
        Me.Retorno_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retorno_lbl.ForeColor = System.Drawing.Color.White
        Me.Retorno_lbl.Location = New System.Drawing.Point(19, 128)
        Me.Retorno_lbl.Name = "Retorno_lbl"
        Me.Retorno_lbl.Size = New System.Drawing.Size(79, 14)
        Me.Retorno_lbl.TabIndex = 5
        Me.Retorno_lbl.Text = "RETORNO: %"
        '
        'Retorno_txb
        '
        Me.Retorno_txb.Location = New System.Drawing.Point(19, 146)
        Me.Retorno_txb.MaxLength = 6
        Me.Retorno_txb.Name = "Retorno_txb"
        Me.Retorno_txb.Size = New System.Drawing.Size(120, 20)
        Me.Retorno_txb.TabIndex = 4
        '
        'Payout_lbl
        '
        Me.Payout_lbl.AutoSize = True
        Me.Payout_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payout_lbl.ForeColor = System.Drawing.Color.White
        Me.Payout_lbl.Location = New System.Drawing.Point(19, 73)
        Me.Payout_lbl.Name = "Payout_lbl"
        Me.Payout_lbl.Size = New System.Drawing.Size(70, 14)
        Me.Payout_lbl.TabIndex = 3
        Me.Payout_lbl.Text = "PAYOUT: %"
        '
        'Payout_txb
        '
        Me.Payout_txb.Location = New System.Drawing.Point(19, 91)
        Me.Payout_txb.MaxLength = 6
        Me.Payout_txb.Name = "Payout_txb"
        Me.Payout_txb.Size = New System.Drawing.Size(120, 20)
        Me.Payout_txb.TabIndex = 2
        '
        'Banca_lbl
        '
        Me.Banca_lbl.AutoSize = True
        Me.Banca_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banca_lbl.ForeColor = System.Drawing.Color.White
        Me.Banca_lbl.Location = New System.Drawing.Point(19, 18)
        Me.Banca_lbl.Name = "Banca_lbl"
        Me.Banca_lbl.Size = New System.Drawing.Size(60, 14)
        Me.Banca_lbl.TabIndex = 1
        Me.Banca_lbl.Text = "BANCA: $"
        '
        'Banca_txb
        '
        Me.Banca_txb.Location = New System.Drawing.Point(19, 36)
        Me.Banca_txb.MaxLength = 10
        Me.Banca_txb.Name = "Banca_txb"
        Me.Banca_txb.Size = New System.Drawing.Size(120, 20)
        Me.Banca_txb.TabIndex = 0
        '
        'Painel_1º_Ordem
        '
        Me.Painel_1º_Ordem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Painel_1º_Ordem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Painel_1º_Ordem.Controls.Add(Me.Painel_Ordem1)
        Me.Painel_1º_Ordem.Location = New System.Drawing.Point(171, 106)
        Me.Painel_1º_Ordem.Name = "Painel_1º_Ordem"
        Me.Painel_1º_Ordem.Size = New System.Drawing.Size(488, 173)
        Me.Painel_1º_Ordem.TabIndex = 2
        '
        'Painel_Ordem1
        '
        Me.Painel_Ordem1.BackColor = System.Drawing.Color.Indigo
        Me.Painel_Ordem1.Controls.Add(Me.Martingale_Panel)
        Me.Painel_Ordem1.Controls.Add(Me.Ordem1_PayOut_lbl)
        Me.Painel_Ordem1.Controls.Add(Me.Ordem1_Pay_lbl)
        Me.Painel_Ordem1.Controls.Add(Me.Order1_Win_btn)
        Me.Painel_Ordem1.Controls.Add(Me.Ordem1_Valor_lbl)
        Me.Painel_Ordem1.Controls.Add(Me.Order1_Copiar_btn)
        Me.Painel_Ordem1.Controls.Add(Me.Order1_Loss_btn)
        Me.Painel_Ordem1.Controls.Add(Me.Order1_Ret_lbl)
        Me.Painel_Ordem1.Controls.Add(Me.Ordem1_Retorno_lbl)
        Me.Painel_Ordem1.Controls.Add(Me.Separador_1)
        Me.Painel_Ordem1.Location = New System.Drawing.Point(8, 8)
        Me.Painel_Ordem1.Name = "Painel_Ordem1"
        Me.Painel_Ordem1.Size = New System.Drawing.Size(162, 155)
        Me.Painel_Ordem1.TabIndex = 9
        Me.Painel_Ordem1.Visible = False
        '
        'Martingale_Panel
        '
        Me.Martingale_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Martingale_Panel.Controls.Add(Me.Martingale_Panel_lbl)
        Me.Martingale_Panel.Location = New System.Drawing.Point(97, 32)
        Me.Martingale_Panel.Name = "Martingale_Panel"
        Me.Martingale_Panel.Size = New System.Drawing.Size(47, 26)
        Me.Martingale_Panel.TabIndex = 20
        '
        'Martingale_Panel_lbl
        '
        Me.Martingale_Panel_lbl.Dock = System.Windows.Forms.DockStyle.Left
        Me.Martingale_Panel_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Martingale_Panel_lbl.ForeColor = System.Drawing.Color.White
        Me.Martingale_Panel_lbl.Location = New System.Drawing.Point(0, 0)
        Me.Martingale_Panel_lbl.Name = "Martingale_Panel_lbl"
        Me.Martingale_Panel_lbl.Size = New System.Drawing.Size(47, 26)
        Me.Martingale_Panel_lbl.TabIndex = 0
        Me.Martingale_Panel_lbl.Text = "1º MG"
        Me.Martingale_Panel_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ordem1_PayOut_lbl
        '
        Me.Ordem1_PayOut_lbl.AutoSize = True
        Me.Ordem1_PayOut_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Ordem1_PayOut_lbl.ForeColor = System.Drawing.Color.Lime
        Me.Ordem1_PayOut_lbl.Location = New System.Drawing.Point(59, 135)
        Me.Ordem1_PayOut_lbl.Name = "Ordem1_PayOut_lbl"
        Me.Ordem1_PayOut_lbl.Size = New System.Drawing.Size(34, 13)
        Me.Ordem1_PayOut_lbl.TabIndex = 19
        Me.Ordem1_PayOut_lbl.Text = "100%"
        Me.Ordem1_PayOut_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ordem1_Pay_lbl
        '
        Me.Ordem1_Pay_lbl.AutoSize = True
        Me.Ordem1_Pay_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Ordem1_Pay_lbl.ForeColor = System.Drawing.Color.CadetBlue
        Me.Ordem1_Pay_lbl.Location = New System.Drawing.Point(17, 135)
        Me.Ordem1_Pay_lbl.Name = "Ordem1_Pay_lbl"
        Me.Ordem1_Pay_lbl.Size = New System.Drawing.Size(46, 13)
        Me.Ordem1_Pay_lbl.TabIndex = 18
        Me.Ordem1_Pay_lbl.Text = "Payout: "
        Me.Ordem1_Pay_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Order1_Win_btn
        '
        Me.Order1_Win_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Order1_Win_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Order1_Win_btn.Enabled = False
        Me.Order1_Win_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Order1_Win_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order1_Win_btn.ForeColor = System.Drawing.Color.White
        Me.Order1_Win_btn.Image = Global.Calculadora_Martingale.My.Resources.Resources.Up
        Me.Order1_Win_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Order1_Win_btn.Location = New System.Drawing.Point(19, 87)
        Me.Order1_Win_btn.Name = "Order1_Win_btn"
        Me.Order1_Win_btn.Size = New System.Drawing.Size(59, 26)
        Me.Order1_Win_btn.TabIndex = 13
        Me.Order1_Win_btn.Text = "Win"
        Me.Order1_Win_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Order1_Win_btn.UseVisualStyleBackColor = False
        '
        'Ordem1_Valor_lbl
        '
        Me.Ordem1_Valor_lbl.AutoSize = True
        Me.Ordem1_Valor_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Ordem1_Valor_lbl.ForeColor = System.Drawing.Color.White
        Me.Ordem1_Valor_lbl.Location = New System.Drawing.Point(16, 10)
        Me.Ordem1_Valor_lbl.Name = "Ordem1_Valor_lbl"
        Me.Ordem1_Valor_lbl.Size = New System.Drawing.Size(121, 17)
        Me.Ordem1_Valor_lbl.TabIndex = 11
        Me.Ordem1_Valor_lbl.Text = "1º Ordem: $ 0,00"
        '
        'Order1_Copiar_btn
        '
        Me.Order1_Copiar_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Order1_Copiar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Order1_Copiar_btn.Enabled = False
        Me.Order1_Copiar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Order1_Copiar_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order1_Copiar_btn.ForeColor = System.Drawing.Color.White
        Me.Order1_Copiar_btn.Image = Global.Calculadora_Martingale.My.Resources.Resources.copy_16px
        Me.Order1_Copiar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Order1_Copiar_btn.Location = New System.Drawing.Point(19, 32)
        Me.Order1_Copiar_btn.Name = "Order1_Copiar_btn"
        Me.Order1_Copiar_btn.Size = New System.Drawing.Size(72, 26)
        Me.Order1_Copiar_btn.TabIndex = 12
        Me.Order1_Copiar_btn.Text = "Copiar"
        Me.Order1_Copiar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Order1_Copiar_btn.UseVisualStyleBackColor = False
        '
        'Order1_Loss_btn
        '
        Me.Order1_Loss_btn.BackColor = System.Drawing.Color.Red
        Me.Order1_Loss_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Order1_Loss_btn.Enabled = False
        Me.Order1_Loss_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Order1_Loss_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order1_Loss_btn.ForeColor = System.Drawing.Color.White
        Me.Order1_Loss_btn.Image = Global.Calculadora_Martingale.My.Resources.Resources.Down
        Me.Order1_Loss_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Order1_Loss_btn.Location = New System.Drawing.Point(84, 87)
        Me.Order1_Loss_btn.Name = "Order1_Loss_btn"
        Me.Order1_Loss_btn.Size = New System.Drawing.Size(60, 26)
        Me.Order1_Loss_btn.TabIndex = 14
        Me.Order1_Loss_btn.Text = "Loss"
        Me.Order1_Loss_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Order1_Loss_btn.UseVisualStyleBackColor = False
        '
        'Order1_Ret_lbl
        '
        Me.Order1_Ret_lbl.AutoSize = True
        Me.Order1_Ret_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Order1_Ret_lbl.ForeColor = System.Drawing.Color.CadetBlue
        Me.Order1_Ret_lbl.Location = New System.Drawing.Point(16, 68)
        Me.Order1_Ret_lbl.Name = "Order1_Ret_lbl"
        Me.Order1_Ret_lbl.Size = New System.Drawing.Size(50, 13)
        Me.Order1_Ret_lbl.TabIndex = 15
        Me.Order1_Ret_lbl.Text = "Retorno: "
        '
        'Ordem1_Retorno_lbl
        '
        Me.Ordem1_Retorno_lbl.AutoSize = True
        Me.Ordem1_Retorno_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Ordem1_Retorno_lbl.ForeColor = System.Drawing.Color.White
        Me.Ordem1_Retorno_lbl.Location = New System.Drawing.Point(72, 67)
        Me.Ordem1_Retorno_lbl.Name = "Ordem1_Retorno_lbl"
        Me.Ordem1_Retorno_lbl.Size = New System.Drawing.Size(48, 17)
        Me.Ordem1_Retorno_lbl.TabIndex = 16
        Me.Ordem1_Retorno_lbl.Text = "$ 0,00"
        '
        'Separador_1
        '
        Me.Separador_1.BackColor = System.Drawing.Color.Lime
        Me.Separador_1.Location = New System.Drawing.Point(9, 128)
        Me.Separador_1.Name = "Separador_1"
        Me.Separador_1.Size = New System.Drawing.Size(143, 3)
        Me.Separador_1.TabIndex = 17
        '
        'Painel_Risco
        '
        Me.Painel_Risco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Painel_Risco.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Painel_Risco.Controls.Add(Me.Excluir_Ordem_btn)
        Me.Painel_Risco.Controls.Add(Me.Risco_da_Operacao_lbl)
        Me.Painel_Risco.Controls.Add(Me.Ordens_lbl)
        Me.Painel_Risco.Location = New System.Drawing.Point(171, 37)
        Me.Painel_Risco.Name = "Painel_Risco"
        Me.Painel_Risco.Size = New System.Drawing.Size(488, 63)
        Me.Painel_Risco.TabIndex = 32
        '
        'Excluir_Ordem_btn
        '
        Me.Excluir_Ordem_btn.BackColor = System.Drawing.Color.Transparent
        Me.Excluir_Ordem_btn.BackgroundImage = Global.Calculadora_Martingale.My.Resources.Resources.Lixo_24x
        Me.Excluir_Ordem_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Excluir_Ordem_btn.FlatAppearance.BorderSize = 0
        Me.Excluir_Ordem_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Excluir_Ordem_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Excluir_Ordem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Excluir_Ordem_btn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Excluir_Ordem_btn.ForeColor = System.Drawing.Color.White
        Me.Excluir_Ordem_btn.Location = New System.Drawing.Point(121, 8)
        Me.Excluir_Ordem_btn.Name = "Excluir_Ordem_btn"
        Me.Excluir_Ordem_btn.Size = New System.Drawing.Size(24, 24)
        Me.Excluir_Ordem_btn.TabIndex = 14
        Me.Excluir_Ordem_btn.UseVisualStyleBackColor = False
        '
        'Risco_da_Operacao_lbl
        '
        Me.Risco_da_Operacao_lbl.AutoSize = True
        Me.Risco_da_Operacao_lbl.ForeColor = System.Drawing.Color.SpringGreen
        Me.Risco_da_Operacao_lbl.Location = New System.Drawing.Point(5, 37)
        Me.Risco_da_Operacao_lbl.Name = "Risco_da_Operacao_lbl"
        Me.Risco_da_Operacao_lbl.Size = New System.Drawing.Size(135, 13)
        Me.Risco_da_Operacao_lbl.TabIndex = 10
        Me.Risco_da_Operacao_lbl.Text = "Risco Desta Operação: 0%"
        '
        'Ordens_lbl
        '
        Me.Ordens_lbl.AutoSize = True
        Me.Ordens_lbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Ordens_lbl.ForeColor = System.Drawing.Color.White
        Me.Ordens_lbl.Location = New System.Drawing.Point(5, 12)
        Me.Ordens_lbl.Name = "Ordens_lbl"
        Me.Ordens_lbl.Size = New System.Drawing.Size(115, 17)
        Me.Ordens_lbl.TabIndex = 8
        Me.Ordens_lbl.Text = "Limpar Ordens: "
        '
        'Painel_Informacoes
        '
        Me.Painel_Informacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Painel_Informacoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Painel_Informacoes.Controls.Add(Me.Writen_lbl)
        Me.Painel_Informacoes.Controls.Add(Me.Informacoe_lbl)
        Me.Painel_Informacoes.Location = New System.Drawing.Point(171, 285)
        Me.Painel_Informacoes.Name = "Painel_Informacoes"
        Me.Painel_Informacoes.Size = New System.Drawing.Size(488, 80)
        Me.Painel_Informacoes.TabIndex = 34
        '
        'Writen_lbl
        '
        Me.Writen_lbl.AutoSize = True
        Me.Writen_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Writen_lbl.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Writen_lbl.Location = New System.Drawing.Point(339, 60)
        Me.Writen_lbl.Name = "Writen_lbl"
        Me.Writen_lbl.Size = New System.Drawing.Size(142, 13)
        Me.Writen_lbl.TabIndex = 11
        Me.Writen_lbl.Text = "Writen By: Rômulo Meirelles."
        '
        'Informacoe_lbl
        '
        Me.Informacoe_lbl.AutoSize = True
        Me.Informacoe_lbl.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Informacoe_lbl.Location = New System.Drawing.Point(5, 14)
        Me.Informacoe_lbl.Name = "Informacoe_lbl"
        Me.Informacoe_lbl.Size = New System.Drawing.Size(159, 13)
        Me.Informacoe_lbl.TabIndex = 10
        Me.Informacoe_lbl.Text = "INFORMÇÕES IMPORTANTES"
        '
        'Martingale_Swith
        '
        Me.Martingale_Swith.Checked = False
        Me.Martingale_Swith.Colors = New Calculadora_Martingale.Bloom(-1) {}
        Me.Martingale_Swith.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Martingale_Swith.Customization = ""
        Me.Martingale_Swith.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Martingale_Swith.Image = Nothing
        Me.Martingale_Swith.Location = New System.Drawing.Point(105, 195)
        Me.Martingale_Swith.Name = "Martingale_Swith"
        Me.Martingale_Swith.NoRounding = False
        Me.Martingale_Swith.Size = New System.Drawing.Size(35, 19)
        Me.Martingale_Swith.TabIndex = 0
        Me.Martingale_Swith.Text = "VizualSwitch31"
        Me.Martingale_Swith.Transparent = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Painel_Informacoes)
        Me.Controls.Add(Me.Painel_1º_Ordem)
        Me.Controls.Add(Me.Painel_Risco)
        Me.Controls.Add(Me.Painel_Controle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Martingale - Rômulo Meirelles"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Icon_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimize_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnTop_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Painel_Controle.ResumeLayout(False)
        Me.Painel_Controle.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Painel_1º_Ordem.ResumeLayout(False)
        Me.Painel_Ordem1.ResumeLayout(False)
        Me.Painel_Ordem1.PerformLayout()
        Me.Martingale_Panel.ResumeLayout(False)
        Me.Painel_Risco.ResumeLayout(False)
        Me.Painel_Risco.PerformLayout()
        Me.Painel_Informacoes.ResumeLayout(False)
        Me.Painel_Informacoes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Minimize_Pic As PictureBox
    Friend WithEvents OnTop_Pic As PictureBox
    Friend WithEvents Close_Pic As PictureBox
    Friend WithEvents Icon_Pic As PictureBox
    Friend WithEvents Title_lbl As Label
    Friend WithEvents Painel_Controle As Panel
    Friend WithEvents Banca_txb As TextBox
    Friend WithEvents Painel_1º_Ordem As Panel
    Friend WithEvents Retorno_lbl As Label
    Friend WithEvents Retorno_txb As TextBox
    Friend WithEvents Payout_lbl As Label
    Friend WithEvents Payout_txb As TextBox
    Friend WithEvents Banca_lbl As Label
    Friend WithEvents Martingale_lbl As Label
    Friend WithEvents Martingale_Swith As VizualSwitch3
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Calcular_Ordens_btn As Button
    Friend WithEvents Ordem1_Valor_lbl As Label
    Friend WithEvents Order1_Copiar_btn As Button
    Friend WithEvents Order1_Loss_btn As Button
    Friend WithEvents Order1_Win_btn As Button
    Friend WithEvents Separador_1 As Panel
    Friend WithEvents Ordem1_Retorno_lbl As Label
    Friend WithEvents Order1_Ret_lbl As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Painel_Ordem1 As Panel
    Friend WithEvents Painel_2º_Ordem As Panel
    Friend WithEvents Ordem1_PayOut_lbl As Label
    Friend WithEvents Ordem1_Pay_lbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Painel_Risco As Panel
    Friend WithEvents Excluir_Ordem_btn As Button
    Friend WithEvents Risco_da_Operacao_lbl As Label
    Friend WithEvents Ordens_lbl As Label
    Friend WithEvents Painel_Informacoes As Panel
    Friend WithEvents Informacoe_lbl As Label
    Friend WithEvents Writen_lbl As Label
    Friend WithEvents Martingale_Panel As Panel
    Friend WithEvents Martingale_Panel_lbl As Label
End Class
