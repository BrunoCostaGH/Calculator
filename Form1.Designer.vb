<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadrãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.BtnPercentage = New System.Windows.Forms.Button()
        Me.BtnCE = New System.Windows.Forms.Button()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnMultiInverse = New System.Windows.Forms.Button()
        Me.BtnSquare = New System.Windows.Forms.Button()
        Me.BtnSquareRoot = New System.Windows.Forms.Button()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.BtnMultiply = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.BtnSum = New System.Windows.Forms.Button()
        Me.BtnNegate = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnDecimal = New System.Windows.Forms.Button()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.PnlCient = New System.Windows.Forms.Panel()
        Me.BtnPi = New System.Windows.Forms.Button()
        Me.Btne = New System.Windows.Forms.Button()
        Me.BtnMod = New System.Windows.Forms.Button()
        Me.BtnExpo = New System.Windows.Forms.Button()
        Me.BtnLog = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBCientifica = New System.Windows.Forms.RadioButton()
        Me.RBPadrao = New System.Windows.Forms.RadioButton()
        Me.BtnMC = New System.Windows.Forms.Button()
        Me.BtnMR = New System.Windows.Forms.Button()
        Me.BtnMAdd = New System.Windows.Forms.Button()
        Me.BtnMS = New System.Windows.Forms.Button()
        Me.TxtPanel = New System.Windows.Forms.TextBox()
        Me.TxtOperação = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.PnlCient.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.ColarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 23)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ColarToolStripMenuItem.Text = "Colar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadrãoToolStripMenuItem, Me.CientToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 23)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'PadrãoToolStripMenuItem
        '
        Me.PadrãoToolStripMenuItem.Name = "PadrãoToolStripMenuItem"
        Me.PadrãoToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PadrãoToolStripMenuItem.Text = "Padrão"
        '
        'CientToolStripMenuItem
        '
        Me.CientToolStripMenuItem.Name = "CientToolStripMenuItem"
        Me.CientToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CientToolStripMenuItem.Text = "Científica"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(34, 23)
        Me.AjudaToolStripMenuItem.Text = "❔"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.AcercaToolStripMenuItem.Text = "Acerca.."
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnlMain.Controls.Add(Me.BtnPercentage)
        Me.PnlMain.Controls.Add(Me.BtnCE)
        Me.PnlMain.Controls.Add(Me.BtnC)
        Me.PnlMain.Controls.Add(Me.BtnDelete)
        Me.PnlMain.Controls.Add(Me.BtnMultiInverse)
        Me.PnlMain.Controls.Add(Me.BtnSquare)
        Me.PnlMain.Controls.Add(Me.BtnSquareRoot)
        Me.PnlMain.Controls.Add(Me.BtnDivide)
        Me.PnlMain.Controls.Add(Me.Btn7)
        Me.PnlMain.Controls.Add(Me.Btn8)
        Me.PnlMain.Controls.Add(Me.Btn9)
        Me.PnlMain.Controls.Add(Me.BtnMultiply)
        Me.PnlMain.Controls.Add(Me.Btn4)
        Me.PnlMain.Controls.Add(Me.Btn5)
        Me.PnlMain.Controls.Add(Me.Btn6)
        Me.PnlMain.Controls.Add(Me.BtnMinus)
        Me.PnlMain.Controls.Add(Me.Btn1)
        Me.PnlMain.Controls.Add(Me.Btn2)
        Me.PnlMain.Controls.Add(Me.Btn3)
        Me.PnlMain.Controls.Add(Me.BtnSum)
        Me.PnlMain.Controls.Add(Me.BtnNegate)
        Me.PnlMain.Controls.Add(Me.Btn0)
        Me.PnlMain.Controls.Add(Me.BtnDecimal)
        Me.PnlMain.Controls.Add(Me.BtnEqual)
        Me.PnlMain.Controls.Add(Me.PnlCient)
        Me.PnlMain.Location = New System.Drawing.Point(2, 114)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(320, 320)
        Me.PnlMain.TabIndex = 25
        '
        'BtnPercentage
        '
        Me.BtnPercentage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPercentage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnPercentage.FlatAppearance.BorderSize = 0
        Me.BtnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPercentage.Location = New System.Drawing.Point(1, 5)
        Me.BtnPercentage.Name = "BtnPercentage"
        Me.BtnPercentage.Size = New System.Drawing.Size(78, 50)
        Me.BtnPercentage.TabIndex = 48
        Me.BtnPercentage.Tag = "%"
        Me.BtnPercentage.Text = "%"
        Me.BtnPercentage.UseVisualStyleBackColor = False
        '
        'BtnCE
        '
        Me.BtnCE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCE.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCE.FlatAppearance.BorderSize = 0
        Me.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCE.Location = New System.Drawing.Point(81, 5)
        Me.BtnCE.Name = "BtnCE"
        Me.BtnCE.Size = New System.Drawing.Size(78, 50)
        Me.BtnCE.TabIndex = 47
        Me.BtnCE.Text = "CE"
        Me.BtnCE.UseVisualStyleBackColor = False
        '
        'BtnC
        '
        Me.BtnC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnC.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnC.FlatAppearance.BorderSize = 0
        Me.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnC.Location = New System.Drawing.Point(161, 5)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(78, 50)
        Me.BtnC.TabIndex = 46
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(241, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 50)
        Me.BtnDelete.TabIndex = 45
        Me.BtnDelete.Text = "⌫"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnMultiInverse
        '
        Me.BtnMultiInverse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMultiInverse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMultiInverse.FlatAppearance.BorderSize = 0
        Me.BtnMultiInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMultiInverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiInverse.Location = New System.Drawing.Point(1, 57)
        Me.BtnMultiInverse.Name = "BtnMultiInverse"
        Me.BtnMultiInverse.Size = New System.Drawing.Size(78, 50)
        Me.BtnMultiInverse.TabIndex = 44
        Me.BtnMultiInverse.Text = "⅟𝒙"
        Me.BtnMultiInverse.UseVisualStyleBackColor = False
        '
        'BtnSquare
        '
        Me.BtnSquare.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSquare.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSquare.FlatAppearance.BorderSize = 0
        Me.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSquare.Location = New System.Drawing.Point(81, 57)
        Me.BtnSquare.Name = "BtnSquare"
        Me.BtnSquare.Size = New System.Drawing.Size(78, 50)
        Me.BtnSquare.TabIndex = 43
        Me.BtnSquare.Text = "𝒙²"
        Me.BtnSquare.UseVisualStyleBackColor = False
        '
        'BtnSquareRoot
        '
        Me.BtnSquareRoot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSquareRoot.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSquareRoot.FlatAppearance.BorderSize = 0
        Me.BtnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSquareRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSquareRoot.Location = New System.Drawing.Point(161, 57)
        Me.BtnSquareRoot.Name = "BtnSquareRoot"
        Me.BtnSquareRoot.Size = New System.Drawing.Size(78, 50)
        Me.BtnSquareRoot.TabIndex = 42
        Me.BtnSquareRoot.Text = "√𝒙"
        Me.BtnSquareRoot.UseVisualStyleBackColor = False
        '
        'BtnDivide
        '
        Me.BtnDivide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDivide.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDivide.FlatAppearance.BorderSize = 0
        Me.BtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDivide.Location = New System.Drawing.Point(241, 57)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(78, 50)
        Me.BtnDivide.TabIndex = 41
        Me.BtnDivide.Tag = "/"
        Me.BtnDivide.Text = "/"
        Me.BtnDivide.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn7.FlatAppearance.BorderSize = 0
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(1, 109)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(78, 50)
        Me.Btn7.TabIndex = 40
        Me.Btn7.Tag = ""
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn8.FlatAppearance.BorderSize = 0
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(81, 109)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(78, 50)
        Me.Btn8.TabIndex = 39
        Me.Btn8.Tag = ""
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn9.FlatAppearance.BorderSize = 0
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(161, 109)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(78, 50)
        Me.Btn9.TabIndex = 38
        Me.Btn9.Tag = ""
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'BtnMultiply
        '
        Me.BtnMultiply.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMultiply.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMultiply.FlatAppearance.BorderSize = 0
        Me.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiply.Location = New System.Drawing.Point(241, 109)
        Me.BtnMultiply.Name = "BtnMultiply"
        Me.BtnMultiply.Size = New System.Drawing.Size(78, 50)
        Me.BtnMultiply.TabIndex = 37
        Me.BtnMultiply.Tag = "*"
        Me.BtnMultiply.Text = "*"
        Me.BtnMultiply.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn4.FlatAppearance.BorderSize = 0
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(1, 161)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(78, 50)
        Me.Btn4.TabIndex = 36
        Me.Btn4.Tag = ""
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn5.FlatAppearance.BorderSize = 0
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(81, 161)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(78, 50)
        Me.Btn5.TabIndex = 35
        Me.Btn5.Tag = ""
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn6.FlatAppearance.BorderSize = 0
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(161, 161)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(78, 50)
        Me.Btn6.TabIndex = 34
        Me.Btn6.Tag = ""
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'BtnMinus
        '
        Me.BtnMinus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMinus.FlatAppearance.BorderSize = 0
        Me.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinus.Location = New System.Drawing.Point(241, 161)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(78, 50)
        Me.BtnMinus.TabIndex = 33
        Me.BtnMinus.Tag = "-"
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn1.FlatAppearance.BorderSize = 0
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(1, 213)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(78, 50)
        Me.Btn1.TabIndex = 32
        Me.Btn1.Tag = ""
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn2.FlatAppearance.BorderSize = 0
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(81, 213)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(78, 50)
        Me.Btn2.TabIndex = 31
        Me.Btn2.Tag = ""
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn3.FlatAppearance.BorderSize = 0
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(161, 213)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(78, 50)
        Me.Btn3.TabIndex = 30
        Me.Btn3.Tag = ""
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'BtnSum
        '
        Me.BtnSum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSum.FlatAppearance.BorderSize = 0
        Me.BtnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSum.Location = New System.Drawing.Point(241, 213)
        Me.BtnSum.Name = "BtnSum"
        Me.BtnSum.Size = New System.Drawing.Size(78, 50)
        Me.BtnSum.TabIndex = 29
        Me.BtnSum.Tag = "+"
        Me.BtnSum.Text = "+"
        Me.BtnSum.UseVisualStyleBackColor = False
        '
        'BtnNegate
        '
        Me.BtnNegate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNegate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnNegate.FlatAppearance.BorderSize = 0
        Me.BtnNegate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNegate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNegate.Location = New System.Drawing.Point(1, 265)
        Me.BtnNegate.Name = "BtnNegate"
        Me.BtnNegate.Size = New System.Drawing.Size(78, 50)
        Me.BtnNegate.TabIndex = 28
        Me.BtnNegate.Text = "∓"
        Me.BtnNegate.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn0.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn0.FlatAppearance.BorderSize = 0
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(81, 265)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(78, 50)
        Me.Btn0.TabIndex = 27
        Me.Btn0.Tag = ""
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'BtnDecimal
        '
        Me.BtnDecimal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDecimal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDecimal.FlatAppearance.BorderSize = 0
        Me.BtnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDecimal.Location = New System.Drawing.Point(161, 265)
        Me.BtnDecimal.Name = "BtnDecimal"
        Me.BtnDecimal.Size = New System.Drawing.Size(78, 50)
        Me.BtnDecimal.TabIndex = 26
        Me.BtnDecimal.Tag = ""
        Me.BtnDecimal.Text = "."
        Me.BtnDecimal.UseVisualStyleBackColor = False
        '
        'BtnEqual
        '
        Me.BtnEqual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEqual.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnEqual.FlatAppearance.BorderSize = 0
        Me.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEqual.Location = New System.Drawing.Point(241, 265)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(78, 50)
        Me.BtnEqual.TabIndex = 25
        Me.BtnEqual.Tag = ""
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = False
        '
        'PnlCient
        '
        Me.PnlCient.Controls.Add(Me.BtnPi)
        Me.PnlCient.Controls.Add(Me.Btne)
        Me.PnlCient.Controls.Add(Me.BtnMod)
        Me.PnlCient.Controls.Add(Me.BtnExpo)
        Me.PnlCient.Controls.Add(Me.BtnLog)
        Me.PnlCient.Location = New System.Drawing.Point(0, 3)
        Me.PnlCient.Name = "PnlCient"
        Me.PnlCient.Size = New System.Drawing.Size(320, 107)
        Me.PnlCient.TabIndex = 29
        Me.PnlCient.Visible = False
        '
        'BtnPi
        '
        Me.BtnPi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnPi.FlatAppearance.BorderSize = 0
        Me.BtnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPi.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPi.Location = New System.Drawing.Point(1, 2)
        Me.BtnPi.Name = "BtnPi"
        Me.BtnPi.Size = New System.Drawing.Size(78, 50)
        Me.BtnPi.TabIndex = 53
        Me.BtnPi.Tag = ""
        Me.BtnPi.Text = "𝜋"
        Me.BtnPi.UseVisualStyleBackColor = False
        '
        'Btne
        '
        Me.Btne.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btne.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btne.FlatAppearance.BorderSize = 0
        Me.Btne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btne.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btne.Location = New System.Drawing.Point(81, 2)
        Me.Btne.Name = "Btne"
        Me.Btne.Size = New System.Drawing.Size(78, 50)
        Me.Btne.TabIndex = 52
        Me.Btne.Text = "e"
        Me.Btne.UseVisualStyleBackColor = False
        '
        'BtnMod
        '
        Me.BtnMod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMod.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMod.FlatAppearance.BorderSize = 0
        Me.BtnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMod.Location = New System.Drawing.Point(81, 54)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.Size = New System.Drawing.Size(78, 50)
        Me.BtnMod.TabIndex = 51
        Me.BtnMod.Text = "|𝒙|"
        Me.BtnMod.UseVisualStyleBackColor = False
        '
        'BtnExpo
        '
        Me.BtnExpo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExpo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnExpo.FlatAppearance.BorderSize = 0
        Me.BtnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExpo.Location = New System.Drawing.Point(161, 54)
        Me.BtnExpo.Name = "BtnExpo"
        Me.BtnExpo.Size = New System.Drawing.Size(78, 50)
        Me.BtnExpo.TabIndex = 50
        Me.BtnExpo.Text = "10ˣ"
        Me.BtnExpo.UseVisualStyleBackColor = False
        '
        'BtnLog
        '
        Me.BtnLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLog.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLog.FlatAppearance.BorderSize = 0
        Me.BtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLog.Location = New System.Drawing.Point(241, 54)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(78, 50)
        Me.BtnLog.TabIndex = 49
        Me.BtnLog.Tag = ""
        Me.BtnLog.Text = "log"
        Me.BtnLog.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.RBCientifica)
        Me.Panel1.Controls.Add(Me.RBPadrao)
        Me.Panel1.Controls.Add(Me.BtnMC)
        Me.Panel1.Controls.Add(Me.BtnMR)
        Me.Panel1.Controls.Add(Me.BtnMAdd)
        Me.Panel1.Controls.Add(Me.BtnMS)
        Me.Panel1.Location = New System.Drawing.Point(2, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 30)
        Me.Panel1.TabIndex = 26
        '
        'RBCientifica
        '
        Me.RBCientifica.AutoSize = True
        Me.RBCientifica.Location = New System.Drawing.Point(68, 7)
        Me.RBCientifica.Name = "RBCientifica"
        Me.RBCientifica.Size = New System.Drawing.Size(70, 17)
        Me.RBCientifica.TabIndex = 54
        Me.RBCientifica.Text = "Científica"
        Me.RBCientifica.UseVisualStyleBackColor = True
        '
        'RBPadrao
        '
        Me.RBPadrao.AutoSize = True
        Me.RBPadrao.Checked = True
        Me.RBPadrao.Location = New System.Drawing.Point(3, 7)
        Me.RBPadrao.Name = "RBPadrao"
        Me.RBPadrao.Size = New System.Drawing.Size(59, 17)
        Me.RBPadrao.TabIndex = 53
        Me.RBPadrao.TabStop = True
        Me.RBPadrao.Text = "Padrão"
        Me.RBPadrao.UseVisualStyleBackColor = True
        '
        'BtnMC
        '
        Me.BtnMC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnMC.Enabled = False
        Me.BtnMC.FlatAppearance.BorderSize = 0
        Me.BtnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnMC.Location = New System.Drawing.Point(157, 3)
        Me.BtnMC.Name = "BtnMC"
        Me.BtnMC.Size = New System.Drawing.Size(37, 24)
        Me.BtnMC.TabIndex = 52
        Me.BtnMC.Text = "MC"
        Me.BtnMC.UseVisualStyleBackColor = False
        '
        'BtnMR
        '
        Me.BtnMR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMR.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnMR.Enabled = False
        Me.BtnMR.FlatAppearance.BorderSize = 0
        Me.BtnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnMR.Location = New System.Drawing.Point(198, 3)
        Me.BtnMR.Name = "BtnMR"
        Me.BtnMR.Size = New System.Drawing.Size(37, 24)
        Me.BtnMR.TabIndex = 51
        Me.BtnMR.Text = "MR"
        Me.BtnMR.UseVisualStyleBackColor = False
        '
        'BtnMAdd
        '
        Me.BtnMAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMAdd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnMAdd.FlatAppearance.BorderSize = 0
        Me.BtnMAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMAdd.Location = New System.Drawing.Point(239, 3)
        Me.BtnMAdd.Name = "BtnMAdd"
        Me.BtnMAdd.Size = New System.Drawing.Size(37, 24)
        Me.BtnMAdd.TabIndex = 50
        Me.BtnMAdd.Text = "M+"
        Me.BtnMAdd.UseVisualStyleBackColor = False
        '
        'BtnMS
        '
        Me.BtnMS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnMS.FlatAppearance.BorderSize = 0
        Me.BtnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMS.Location = New System.Drawing.Point(280, 3)
        Me.BtnMS.Name = "BtnMS"
        Me.BtnMS.Size = New System.Drawing.Size(37, 24)
        Me.BtnMS.TabIndex = 49
        Me.BtnMS.Text = "MS"
        Me.BtnMS.UseVisualStyleBackColor = False
        '
        'TxtPanel
        '
        Me.TxtPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtPanel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPanel.Location = New System.Drawing.Point(2, 28)
        Me.TxtPanel.Name = "TxtPanel"
        Me.TxtPanel.ReadOnly = True
        Me.TxtPanel.Size = New System.Drawing.Size(258, 53)
        Me.TxtPanel.TabIndex = 27
        Me.TxtPanel.TabStop = False
        Me.TxtPanel.Text = "0"
        Me.TxtPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOperação
        '
        Me.TxtOperação.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtOperação.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtOperação.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOperação.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtOperação.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperação.Location = New System.Drawing.Point(266, 36)
        Me.TxtOperação.Name = "TxtOperação"
        Me.TxtOperação.ReadOnly = True
        Me.TxtOperação.Size = New System.Drawing.Size(56, 38)
        Me.TxtOperação.TabIndex = 28
        Me.TxtOperação.TabStop = False
        Me.TxtOperação.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(324, 436)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.TxtOperação)
        Me.Controls.Add(Me.TxtPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(340, 475)
        Me.Name = "Calculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PnlMain.ResumeLayout(False)
        Me.PnlCient.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PadrãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnlMain As Panel
    Friend WithEvents BtnCE As Button
    Friend WithEvents BtnC As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnMultiInverse As Button
    Friend WithEvents BtnSquare As Button
    Friend WithEvents BtnSquareRoot As Button
    Friend WithEvents BtnDivide As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents BtnMultiply As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents BtnSum As Button
    Friend WithEvents BtnNegate As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnDecimal As Button
    Friend WithEvents BtnEqual As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBCientifica As RadioButton
    Friend WithEvents RBPadrao As RadioButton
    Friend WithEvents BtnMC As Button
    Friend WithEvents BtnMR As Button
    Friend WithEvents BtnMAdd As Button
    Friend WithEvents BtnMS As Button
    Friend WithEvents TxtOperação As TextBox
    Friend WithEvents TxtPanel As TextBox
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnlCient As Panel
    Friend WithEvents BtnPi As Button
    Friend WithEvents Btne As Button
    Friend WithEvents BtnMod As Button
    Friend WithEvents BtnExpo As Button
    Friend WithEvents BtnLog As Button
    Friend WithEvents BtnPercentage As Button
End Class
