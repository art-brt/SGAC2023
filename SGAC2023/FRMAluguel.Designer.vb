<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAluguel
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
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim FUNCIONARIOLabel As System.Windows.Forms.Label
        Dim CLIENTELabel As System.Windows.Forms.Label
        Dim PLACALabel As System.Windows.Forms.Label
        Dim DTALUGUELLabel As System.Windows.Forms.Label
        Dim DTPREVISAOLabel As System.Windows.Forms.Label
        Dim DTENTREGALabel As System.Windows.Forms.Label
        Dim ENTREGALabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim CPFLabel1 As System.Windows.Forms.Label
        Dim MODELOLabel As System.Windows.Forms.Label
        Dim ANOLabel As System.Windows.Forms.Label
        Dim DISPONIBILIDADELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMAluguel))
        Me.SGAC2024DataSet = New SGAC2023.SGAC2024DataSet()
        Me.ALUGUELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUGUELTableAdapter = New SGAC2023.SGAC2024DataSetTableAdapters.ALUGUELTableAdapter()
        Me.TableAdapterManager = New SGAC2023.SGAC2024DataSetTableAdapters.TableAdapterManager()
        Me.CARROSTableAdapter = New SGAC2023.SGAC2024DataSetTableAdapters.CARROSTableAdapter()
        Me.CLIENTESTableAdapter = New SGAC2023.SGAC2024DataSetTableAdapters.CLIENTESTableAdapter()
        Me.FUNCIONARIOSTableAdapter = New SGAC2023.SGAC2024DataSetTableAdapters.FUNCIONARIOSTableAdapter()
        Me.ALUGUELBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ALUGUELBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.FUNCIONARIOComboBox = New System.Windows.Forms.ComboBox()
        Me.FUNCIONARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTEComboBox = New System.Windows.Forms.ComboBox()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLACAComboBox = New System.Windows.Forms.ComboBox()
        Me.CARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTALUGUELDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DTPREVISAODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DTENTREGADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ENTREGAComboBox = New System.Windows.Forms.ComboBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CPFMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MODELOTextBox = New System.Windows.Forms.TextBox()
        Me.ANOMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DISPONIBILIDADETextBox = New System.Windows.Forms.TextBox()
        CODIGOLabel = New System.Windows.Forms.Label()
        FUNCIONARIOLabel = New System.Windows.Forms.Label()
        CLIENTELabel = New System.Windows.Forms.Label()
        PLACALabel = New System.Windows.Forms.Label()
        DTALUGUELLabel = New System.Windows.Forms.Label()
        DTPREVISAOLabel = New System.Windows.Forms.Label()
        DTENTREGALabel = New System.Windows.Forms.Label()
        ENTREGALabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        CPFLabel1 = New System.Windows.Forms.Label()
        MODELOLabel = New System.Windows.Forms.Label()
        ANOLabel = New System.Windows.Forms.Label()
        DISPONIBILIDADELabel = New System.Windows.Forms.Label()
        CType(Me.SGAC2024DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUGUELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUGUELBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALUGUELBindingNavigator.SuspendLayout()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(24, 119)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'FUNCIONARIOLabel
        '
        FUNCIONARIOLabel.AutoSize = True
        FUNCIONARIOLabel.Location = New System.Drawing.Point(24, 145)
        FUNCIONARIOLabel.Name = "FUNCIONARIOLabel"
        FUNCIONARIOLabel.Size = New System.Drawing.Size(84, 13)
        FUNCIONARIOLabel.TabIndex = 3
        FUNCIONARIOLabel.Text = "FUNCIONARIO:"
        '
        'CLIENTELabel
        '
        CLIENTELabel.AutoSize = True
        CLIENTELabel.Location = New System.Drawing.Point(24, 172)
        CLIENTELabel.Name = "CLIENTELabel"
        CLIENTELabel.Size = New System.Drawing.Size(55, 13)
        CLIENTELabel.TabIndex = 5
        CLIENTELabel.Text = "CLIENTE:"
        '
        'PLACALabel
        '
        PLACALabel.AutoSize = True
        PLACALabel.Location = New System.Drawing.Point(24, 199)
        PLACALabel.Name = "PLACALabel"
        PLACALabel.Size = New System.Drawing.Size(44, 13)
        PLACALabel.TabIndex = 7
        PLACALabel.Text = "PLACA:"
        '
        'DTALUGUELLabel
        '
        DTALUGUELLabel.AutoSize = True
        DTALUGUELLabel.Location = New System.Drawing.Point(24, 227)
        DTALUGUELLabel.Name = "DTALUGUELLabel"
        DTALUGUELLabel.Size = New System.Drawing.Size(75, 13)
        DTALUGUELLabel.TabIndex = 9
        DTALUGUELLabel.Text = "DTALUGUEL:"
        '
        'DTPREVISAOLabel
        '
        DTPREVISAOLabel.AutoSize = True
        DTPREVISAOLabel.Location = New System.Drawing.Point(24, 253)
        DTPREVISAOLabel.Name = "DTPREVISAOLabel"
        DTPREVISAOLabel.Size = New System.Drawing.Size(79, 13)
        DTPREVISAOLabel.TabIndex = 11
        DTPREVISAOLabel.Text = "DTPREVISAO:"
        '
        'DTENTREGALabel
        '
        DTENTREGALabel.AutoSize = True
        DTENTREGALabel.Location = New System.Drawing.Point(24, 279)
        DTENTREGALabel.Name = "DTENTREGALabel"
        DTENTREGALabel.Size = New System.Drawing.Size(77, 13)
        DTENTREGALabel.TabIndex = 13
        DTENTREGALabel.Text = "DTENTREGA:"
        '
        'ENTREGALabel
        '
        ENTREGALabel.AutoSize = True
        ENTREGALabel.Location = New System.Drawing.Point(24, 304)
        ENTREGALabel.Name = "ENTREGALabel"
        ENTREGALabel.Size = New System.Drawing.Size(62, 13)
        ENTREGALabel.TabIndex = 15
        ENTREGALabel.Text = "ENTREGA:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(24, 331)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 17
        OBSLabel.Text = "OBS:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(379, 148)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 19
        CPFLabel.Text = "CPF:"
        '
        'CPFLabel1
        '
        CPFLabel1.AutoSize = True
        CPFLabel1.Location = New System.Drawing.Point(379, 175)
        CPFLabel1.Name = "CPFLabel1"
        CPFLabel1.Size = New System.Drawing.Size(30, 13)
        CPFLabel1.TabIndex = 21
        CPFLabel1.Text = "CPF:"
        '
        'MODELOLabel
        '
        MODELOLabel.AutoSize = True
        MODELOLabel.Location = New System.Drawing.Point(379, 202)
        MODELOLabel.Name = "MODELOLabel"
        MODELOLabel.Size = New System.Drawing.Size(56, 13)
        MODELOLabel.TabIndex = 23
        MODELOLabel.Text = "MODELO:"
        '
        'ANOLabel
        '
        ANOLabel.AutoSize = True
        ANOLabel.Location = New System.Drawing.Point(552, 202)
        ANOLabel.Name = "ANOLabel"
        ANOLabel.Size = New System.Drawing.Size(33, 13)
        ANOLabel.TabIndex = 25
        ANOLabel.Text = "ANO:"
        '
        'DISPONIBILIDADELabel
        '
        DISPONIBILIDADELabel.AutoSize = True
        DISPONIBILIDADELabel.Location = New System.Drawing.Point(703, 202)
        DISPONIBILIDADELabel.Name = "DISPONIBILIDADELabel"
        DISPONIBILIDADELabel.Size = New System.Drawing.Size(103, 13)
        DISPONIBILIDADELabel.TabIndex = 27
        DISPONIBILIDADELabel.Text = "DISPONIBILIDADE:"
        '
        'SGAC2024DataSet
        '
        Me.SGAC2024DataSet.DataSetName = "SGAC2024DataSet"
        Me.SGAC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUGUELBindingSource
        '
        Me.ALUGUELBindingSource.DataMember = "ALUGUEL"
        Me.ALUGUELBindingSource.DataSource = Me.SGAC2024DataSet
        '
        'ALUGUELTableAdapter
        '
        Me.ALUGUELTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUGUELTableAdapter = Me.ALUGUELTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Me.CARROSTableAdapter
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.CONSULTADISPONIVELTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Me.FUNCIONARIOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = SGAC2023.SGAC2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CARROSTableAdapter
        '
        Me.CARROSTableAdapter.ClearBeforeFill = True
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'FUNCIONARIOSTableAdapter
        '
        Me.FUNCIONARIOSTableAdapter.ClearBeforeFill = True
        '
        'ALUGUELBindingNavigator
        '
        Me.ALUGUELBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALUGUELBindingNavigator.BindingSource = Me.ALUGUELBindingSource
        Me.ALUGUELBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALUGUELBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALUGUELBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALUGUELBindingNavigatorSaveItem})
        Me.ALUGUELBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALUGUELBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALUGUELBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALUGUELBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALUGUELBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALUGUELBindingNavigator.Name = "ALUGUELBindingNavigator"
        Me.ALUGUELBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALUGUELBindingNavigator.Size = New System.Drawing.Size(954, 25)
        Me.ALUGUELBindingNavigator.TabIndex = 0
        Me.ALUGUELBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ALUGUELBindingNavigatorSaveItem
        '
        Me.ALUGUELBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALUGUELBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALUGUELBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALUGUELBindingNavigatorSaveItem.Name = "ALUGUELBindingNavigatorSaveItem"
        Me.ALUGUELBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ALUGUELBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(114, 116)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(231, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'FUNCIONARIOComboBox
        '
        Me.FUNCIONARIOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "FUNCIONARIO", True))
        Me.FUNCIONARIOComboBox.DataSource = Me.FUNCIONARIOSBindingSource
        Me.FUNCIONARIOComboBox.DisplayMember = "NOME"
        Me.FUNCIONARIOComboBox.FormattingEnabled = True
        Me.FUNCIONARIOComboBox.Location = New System.Drawing.Point(114, 142)
        Me.FUNCIONARIOComboBox.Name = "FUNCIONARIOComboBox"
        Me.FUNCIONARIOComboBox.Size = New System.Drawing.Size(231, 21)
        Me.FUNCIONARIOComboBox.TabIndex = 4
        Me.FUNCIONARIOComboBox.ValueMember = "NOME"
        '
        'FUNCIONARIOSBindingSource
        '
        Me.FUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS"
        Me.FUNCIONARIOSBindingSource.DataSource = Me.SGAC2024DataSet
        '
        'CLIENTEComboBox
        '
        Me.CLIENTEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "CLIENTE", True))
        Me.CLIENTEComboBox.DataSource = Me.CLIENTESBindingSource
        Me.CLIENTEComboBox.DisplayMember = "NOME"
        Me.CLIENTEComboBox.FormattingEnabled = True
        Me.CLIENTEComboBox.Location = New System.Drawing.Point(114, 169)
        Me.CLIENTEComboBox.Name = "CLIENTEComboBox"
        Me.CLIENTEComboBox.Size = New System.Drawing.Size(231, 21)
        Me.CLIENTEComboBox.TabIndex = 6
        Me.CLIENTEComboBox.ValueMember = "NOME"
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.SGAC2024DataSet
        '
        'PLACAComboBox
        '
        Me.PLACAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "PLACA", True))
        Me.PLACAComboBox.DataSource = Me.CARROSBindingSource
        Me.PLACAComboBox.DisplayMember = "PLACA"
        Me.PLACAComboBox.FormattingEnabled = True
        Me.PLACAComboBox.Location = New System.Drawing.Point(114, 196)
        Me.PLACAComboBox.Name = "PLACAComboBox"
        Me.PLACAComboBox.Size = New System.Drawing.Size(231, 21)
        Me.PLACAComboBox.TabIndex = 8
        Me.PLACAComboBox.ValueMember = "PLACA"
        '
        'CARROSBindingSource
        '
        Me.CARROSBindingSource.DataMember = "CARROS"
        Me.CARROSBindingSource.DataSource = Me.SGAC2024DataSet
        '
        'DTALUGUELDateTimePicker
        '
        Me.DTALUGUELDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ALUGUELBindingSource, "DTALUGUEL", True))
        Me.DTALUGUELDateTimePicker.Location = New System.Drawing.Point(114, 223)
        Me.DTALUGUELDateTimePicker.Name = "DTALUGUELDateTimePicker"
        Me.DTALUGUELDateTimePicker.Size = New System.Drawing.Size(231, 20)
        Me.DTALUGUELDateTimePicker.TabIndex = 10
        '
        'DTPREVISAODateTimePicker
        '
        Me.DTPREVISAODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ALUGUELBindingSource, "DTPREVISAO", True))
        Me.DTPREVISAODateTimePicker.Location = New System.Drawing.Point(114, 249)
        Me.DTPREVISAODateTimePicker.Name = "DTPREVISAODateTimePicker"
        Me.DTPREVISAODateTimePicker.Size = New System.Drawing.Size(231, 20)
        Me.DTPREVISAODateTimePicker.TabIndex = 12
        '
        'DTENTREGADateTimePicker
        '
        Me.DTENTREGADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ALUGUELBindingSource, "DTENTREGA", True))
        Me.DTENTREGADateTimePicker.Location = New System.Drawing.Point(114, 275)
        Me.DTENTREGADateTimePicker.Name = "DTENTREGADateTimePicker"
        Me.DTENTREGADateTimePicker.Size = New System.Drawing.Size(231, 20)
        Me.DTENTREGADateTimePicker.TabIndex = 14
        '
        'ENTREGAComboBox
        '
        Me.ENTREGAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "ENTREGA", True))
        Me.ENTREGAComboBox.FormattingEnabled = True
        Me.ENTREGAComboBox.Items.AddRange(New Object() {"", "Sim", "Não"})
        Me.ENTREGAComboBox.Location = New System.Drawing.Point(114, 301)
        Me.ENTREGAComboBox.Name = "ENTREGAComboBox"
        Me.ENTREGAComboBox.Size = New System.Drawing.Size(231, 21)
        Me.ENTREGAComboBox.TabIndex = 16
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(114, 328)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(231, 83)
        Me.OBSTextBox.TabIndex = 18
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Enabled = False
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(415, 145)
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(126, 20)
        Me.CPFMaskedTextBox.TabIndex = 20
        '
        'CPFMaskedTextBox1
        '
        Me.CPFMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CPF", True))
        Me.CPFMaskedTextBox1.Enabled = False
        Me.CPFMaskedTextBox1.Location = New System.Drawing.Point(415, 172)
        Me.CPFMaskedTextBox1.Name = "CPFMaskedTextBox1"
        Me.CPFMaskedTextBox1.Size = New System.Drawing.Size(126, 20)
        Me.CPFMaskedTextBox1.TabIndex = 22
        '
        'MODELOTextBox
        '
        Me.MODELOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "MODELO", True))
        Me.MODELOTextBox.Enabled = False
        Me.MODELOTextBox.Location = New System.Drawing.Point(441, 199)
        Me.MODELOTextBox.Name = "MODELOTextBox"
        Me.MODELOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MODELOTextBox.TabIndex = 24
        '
        'ANOMaskedTextBox
        '
        Me.ANOMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "ANO", True))
        Me.ANOMaskedTextBox.Enabled = False
        Me.ANOMaskedTextBox.Location = New System.Drawing.Point(591, 199)
        Me.ANOMaskedTextBox.Name = "ANOMaskedTextBox"
        Me.ANOMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ANOMaskedTextBox.TabIndex = 26
        '
        'DISPONIBILIDADETextBox
        '
        Me.DISPONIBILIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "DISPONIBILIDADE", True))
        Me.DISPONIBILIDADETextBox.Enabled = False
        Me.DISPONIBILIDADETextBox.Location = New System.Drawing.Point(812, 199)
        Me.DISPONIBILIDADETextBox.Name = "DISPONIBILIDADETextBox"
        Me.DISPONIBILIDADETextBox.Size = New System.Drawing.Size(100, 20)
        Me.DISPONIBILIDADETextBox.TabIndex = 28
        '
        'FRMAluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 544)
        Me.Controls.Add(DISPONIBILIDADELabel)
        Me.Controls.Add(Me.DISPONIBILIDADETextBox)
        Me.Controls.Add(ANOLabel)
        Me.Controls.Add(Me.ANOMaskedTextBox)
        Me.Controls.Add(MODELOLabel)
        Me.Controls.Add(Me.MODELOTextBox)
        Me.Controls.Add(CPFLabel1)
        Me.Controls.Add(Me.CPFMaskedTextBox1)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(FUNCIONARIOLabel)
        Me.Controls.Add(Me.FUNCIONARIOComboBox)
        Me.Controls.Add(CLIENTELabel)
        Me.Controls.Add(Me.CLIENTEComboBox)
        Me.Controls.Add(PLACALabel)
        Me.Controls.Add(Me.PLACAComboBox)
        Me.Controls.Add(DTALUGUELLabel)
        Me.Controls.Add(Me.DTALUGUELDateTimePicker)
        Me.Controls.Add(DTPREVISAOLabel)
        Me.Controls.Add(Me.DTPREVISAODateTimePicker)
        Me.Controls.Add(DTENTREGALabel)
        Me.Controls.Add(Me.DTENTREGADateTimePicker)
        Me.Controls.Add(ENTREGALabel)
        Me.Controls.Add(Me.ENTREGAComboBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.ALUGUELBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMAluguel"
        Me.Text = "FRMAluguel"
        CType(Me.SGAC2024DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUGUELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUGUELBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALUGUELBindingNavigator.ResumeLayout(False)
        Me.ALUGUELBindingNavigator.PerformLayout()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SGAC2024DataSet As SGAC2024DataSet
    Friend WithEvents ALUGUELBindingSource As BindingSource
    Friend WithEvents ALUGUELTableAdapter As SGAC2024DataSetTableAdapters.ALUGUELTableAdapter
    Friend WithEvents TableAdapterManager As SGAC2024DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALUGUELBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ALUGUELBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FUNCIONARIOSTableAdapter As SGAC2024DataSetTableAdapters.FUNCIONARIOSTableAdapter
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents FUNCIONARIOComboBox As ComboBox
    Friend WithEvents CLIENTEComboBox As ComboBox
    Friend WithEvents PLACAComboBox As ComboBox
    Friend WithEvents DTALUGUELDateTimePicker As DateTimePicker
    Friend WithEvents DTPREVISAODateTimePicker As DateTimePicker
    Friend WithEvents DTENTREGADateTimePicker As DateTimePicker
    Friend WithEvents ENTREGAComboBox As ComboBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents FUNCIONARIOSBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As SGAC2024DataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CARROSTableAdapter As SGAC2024DataSetTableAdapters.CARROSTableAdapter
    Friend WithEvents CARROSBindingSource As BindingSource
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents CPFMaskedTextBox1 As MaskedTextBox
    Friend WithEvents MODELOTextBox As TextBox
    Friend WithEvents ANOMaskedTextBox As MaskedTextBox
    Friend WithEvents DISPONIBILIDADETextBox As TextBox
End Class
