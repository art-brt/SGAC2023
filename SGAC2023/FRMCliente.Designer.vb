﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim CPFLabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim SOBRENOMELabel As System.Windows.Forms.Label
        Dim CELULARLabel As System.Windows.Forms.Label
        Dim CNHLabel As System.Windows.Forms.Label
        Dim ENDERECOLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMCliente))
        Me.SGAC2024DataSet = New SGAC2023.SGAC2024DataSet()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTESTableAdapter = New SGAC2023.SGAC2024DataSetTableAdapters.CLIENTESTableAdapter()
        Me.TableAdapterManager = New SGAC2023.SGAC2024DataSetTableAdapters.TableAdapterManager()
        Me.CLIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CLIENTESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NOMETextBox = New System.Windows.Forms.TextBox()
        Me.SOBRENOMETextBox = New System.Windows.Forms.TextBox()
        Me.CELULARMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CNHMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ENDERECOTextBox = New System.Windows.Forms.TextBox()
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CPFLabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        SOBRENOMELabel = New System.Windows.Forms.Label()
        CELULARLabel = New System.Windows.Forms.Label()
        CNHLabel = New System.Windows.Forms.Label()
        ENDERECOLabel = New System.Windows.Forms.Label()
        FOTOLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CType(Me.SGAC2024DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CLIENTESBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(68, 96)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(68, 122)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'SOBRENOMELabel
        '
        SOBRENOMELabel.AutoSize = True
        SOBRENOMELabel.Location = New System.Drawing.Point(68, 148)
        SOBRENOMELabel.Name = "SOBRENOMELabel"
        SOBRENOMELabel.Size = New System.Drawing.Size(79, 13)
        SOBRENOMELabel.TabIndex = 5
        SOBRENOMELabel.Text = "SOBRENOME:"
        '
        'CELULARLabel
        '
        CELULARLabel.AutoSize = True
        CELULARLabel.Location = New System.Drawing.Point(68, 174)
        CELULARLabel.Name = "CELULARLabel"
        CELULARLabel.Size = New System.Drawing.Size(59, 13)
        CELULARLabel.TabIndex = 7
        CELULARLabel.Text = "CELULAR:"
        '
        'CNHLabel
        '
        CNHLabel.AutoSize = True
        CNHLabel.Location = New System.Drawing.Point(68, 200)
        CNHLabel.Name = "CNHLabel"
        CNHLabel.Size = New System.Drawing.Size(33, 13)
        CNHLabel.TabIndex = 9
        CNHLabel.Text = "CNH:"
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(68, 226)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(70, 13)
        ENDERECOLabel.TabIndex = 11
        ENDERECOLabel.Text = "ENDERECO:"
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(68, 301)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 13
        FOTOLabel.Text = "FOTO:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(68, 393)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 15
        OBSLabel.Text = "OBS:"
        '
        'SGAC2024DataSet
        '
        Me.SGAC2024DataSet.DataSetName = "SGAC2024DataSet"
        Me.SGAC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.SGAC2024DataSet
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUGUELTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.CONSULTADISPONIVELTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGAC2023.SGAC2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CLIENTESBindingNavigator
        '
        Me.CLIENTESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CLIENTESBindingNavigator.BindingSource = Me.CLIENTESBindingSource
        Me.CLIENTESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CLIENTESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CLIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CLIENTESBindingNavigatorSaveItem})
        Me.CLIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CLIENTESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CLIENTESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CLIENTESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CLIENTESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CLIENTESBindingNavigator.Name = "CLIENTESBindingNavigator"
        Me.CLIENTESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CLIENTESBindingNavigator.Size = New System.Drawing.Size(330, 25)
        Me.CLIENTESBindingNavigator.TabIndex = 0
        Me.CLIENTESBindingNavigator.Text = "BindingNavigator1"
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
        'CLIENTESBindingNavigatorSaveItem
        '
        Me.CLIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CLIENTESBindingNavigatorSaveItem.Image = CType(resources.GetObject("CLIENTESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CLIENTESBindingNavigatorSaveItem.Name = "CLIENTESBindingNavigatorSaveItem"
        Me.CLIENTESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CLIENTESBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(153, 93)
        Me.CPFMaskedTextBox.Mask = "000.000.000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFMaskedTextBox.TabIndex = 2
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(153, 119)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'SOBRENOMETextBox
        '
        Me.SOBRENOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "SOBRENOME", True))
        Me.SOBRENOMETextBox.Location = New System.Drawing.Point(153, 145)
        Me.SOBRENOMETextBox.Name = "SOBRENOMETextBox"
        Me.SOBRENOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SOBRENOMETextBox.TabIndex = 6
        '
        'CELULARMaskedTextBox
        '
        Me.CELULARMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CELULAR", True))
        Me.CELULARMaskedTextBox.Location = New System.Drawing.Point(153, 171)
        Me.CELULARMaskedTextBox.Mask = "(00)0000-0000"
        Me.CELULARMaskedTextBox.Name = "CELULARMaskedTextBox"
        Me.CELULARMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CELULARMaskedTextBox.TabIndex = 8
        '
        'CNHMaskedTextBox
        '
        Me.CNHMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CNH", True))
        Me.CNHMaskedTextBox.Location = New System.Drawing.Point(153, 197)
        Me.CNHMaskedTextBox.Mask = "00000000000"
        Me.CNHMaskedTextBox.Name = "CNHMaskedTextBox"
        Me.CNHMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNHMaskedTextBox.TabIndex = 10
        '
        'ENDERECOTextBox
        '
        Me.ENDERECOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "ENDERECO", True))
        Me.ENDERECOTextBox.Location = New System.Drawing.Point(153, 223)
        Me.ENDERECOTextBox.Multiline = True
        Me.ENDERECOTextBox.Name = "ENDERECOTextBox"
        Me.ENDERECOTextBox.Size = New System.Drawing.Size(100, 72)
        Me.ENDERECOTextBox.TabIndex = 12
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CLIENTESBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(153, 301)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(100, 83)
        Me.FOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FOTOPictureBox.TabIndex = 14
        Me.FOTOPictureBox.TabStop = False
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(153, 390)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(100, 82)
        Me.OBSTextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Inserir..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 505)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(SOBRENOMELabel)
        Me.Controls.Add(Me.SOBRENOMETextBox)
        Me.Controls.Add(CELULARLabel)
        Me.Controls.Add(Me.CELULARMaskedTextBox)
        Me.Controls.Add(CNHLabel)
        Me.Controls.Add(Me.CNHMaskedTextBox)
        Me.Controls.Add(ENDERECOLabel)
        Me.Controls.Add(Me.ENDERECOTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.CLIENTESBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMCliente"
        Me.Text = "Cadastro de Clientes"
        CType(Me.SGAC2024DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CLIENTESBindingNavigator.ResumeLayout(False)
        Me.CLIENTESBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SGAC2024DataSet As SGAC2024DataSet
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As SGAC2024DataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As SGAC2024DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTESBindingNavigator As BindingNavigator
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
    Friend WithEvents CLIENTESBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents NOMETextBox As TextBox
    Friend WithEvents SOBRENOMETextBox As TextBox
    Friend WithEvents CELULARMaskedTextBox As MaskedTextBox
    Friend WithEvents CNHMaskedTextBox As MaskedTextBox
    Friend WithEvents ENDERECOTextBox As TextBox
    Friend WithEvents FOTOPictureBox As PictureBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
