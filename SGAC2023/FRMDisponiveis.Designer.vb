<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDisponiveis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMDisponiveis))
        Me.SGAC2024DataSet = New SGAC2023.SGAC2024DataSet()
        Me.CONSULTADISPONIVELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTADISPONIVELTableAdapter = New SGAC2023.SGAC2024DataSetTableAdapters.CONSULTADISPONIVELTableAdapter()
        Me.TableAdapterManager = New SGAC2023.SGAC2024DataSetTableAdapters.TableAdapterManager()
        Me.CONSULTADISPONIVELBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CONSULTADISPONIVELBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CONSULTADISPONIVELDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SGAC2024DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTADISPONIVELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTADISPONIVELBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONSULTADISPONIVELBindingNavigator.SuspendLayout()
        CType(Me.CONSULTADISPONIVELDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SGAC2024DataSet
        '
        Me.SGAC2024DataSet.DataSetName = "SGAC2024DataSet"
        Me.SGAC2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTADISPONIVELBindingSource
        '
        Me.CONSULTADISPONIVELBindingSource.DataMember = "CONSULTADISPONIVEL"
        Me.CONSULTADISPONIVELBindingSource.DataSource = Me.SGAC2024DataSet
        '
        'CONSULTADISPONIVELTableAdapter
        '
        Me.CONSULTADISPONIVELTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUGUELTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.CONSULTADISPONIVELTableAdapter = Me.CONSULTADISPONIVELTableAdapter
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGAC2023.SGAC2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONSULTADISPONIVELBindingNavigator
        '
        Me.CONSULTADISPONIVELBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONSULTADISPONIVELBindingNavigator.BindingSource = Me.CONSULTADISPONIVELBindingSource
        Me.CONSULTADISPONIVELBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONSULTADISPONIVELBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONSULTADISPONIVELBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONSULTADISPONIVELBindingNavigatorSaveItem})
        Me.CONSULTADISPONIVELBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTADISPONIVELBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONSULTADISPONIVELBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONSULTADISPONIVELBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONSULTADISPONIVELBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONSULTADISPONIVELBindingNavigator.Name = "CONSULTADISPONIVELBindingNavigator"
        Me.CONSULTADISPONIVELBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONSULTADISPONIVELBindingNavigator.Size = New System.Drawing.Size(605, 25)
        Me.CONSULTADISPONIVELBindingNavigator.TabIndex = 0
        Me.CONSULTADISPONIVELBindingNavigator.Text = "BindingNavigator1"
        Me.CONSULTADISPONIVELBindingNavigator.Visible = False
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
        'CONSULTADISPONIVELBindingNavigatorSaveItem
        '
        Me.CONSULTADISPONIVELBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONSULTADISPONIVELBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONSULTADISPONIVELBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONSULTADISPONIVELBindingNavigatorSaveItem.Name = "CONSULTADISPONIVELBindingNavigatorSaveItem"
        Me.CONSULTADISPONIVELBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CONSULTADISPONIVELBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CONSULTADISPONIVELDataGridView
        '
        Me.CONSULTADISPONIVELDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CONSULTADISPONIVELDataGridView.AutoGenerateColumns = False
        Me.CONSULTADISPONIVELDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTADISPONIVELDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn10})
        Me.CONSULTADISPONIVELDataGridView.DataSource = Me.CONSULTADISPONIVELBindingSource
        Me.CONSULTADISPONIVELDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.CONSULTADISPONIVELDataGridView.Name = "CONSULTADISPONIVELDataGridView"
        Me.CONSULTADISPONIVELDataGridView.Size = New System.Drawing.Size(542, 570)
        Me.CONSULTADISPONIVELDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PLACA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PLACA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MODELO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MODELO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FABRICANTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FABRICANTE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "COR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "COR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ANO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ANO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CATEGORIA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CATEGORIA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MOTOR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MOTOR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "OPCIONAIS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "OPCIONAIS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DISPONIBILIDADE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DISPONIBILIDADE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "FOTO"
        Me.DataGridViewImageColumn1.HeaderText = "FOTO"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OBS"
        Me.DataGridViewTextBoxColumn10.HeaderText = "OBS"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'FRMDisponiveis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 611)
        Me.Controls.Add(Me.CONSULTADISPONIVELDataGridView)
        Me.Controls.Add(Me.CONSULTADISPONIVELBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMDisponiveis"
        Me.Text = "FRMDisponiveis"
        CType(Me.SGAC2024DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTADISPONIVELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTADISPONIVELBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONSULTADISPONIVELBindingNavigator.ResumeLayout(False)
        Me.CONSULTADISPONIVELBindingNavigator.PerformLayout()
        CType(Me.CONSULTADISPONIVELDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SGAC2024DataSet As SGAC2024DataSet
    Friend WithEvents CONSULTADISPONIVELBindingSource As BindingSource
    Friend WithEvents CONSULTADISPONIVELTableAdapter As SGAC2024DataSetTableAdapters.CONSULTADISPONIVELTableAdapter
    Friend WithEvents TableAdapterManager As SGAC2024DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTADISPONIVELBindingNavigator As BindingNavigator
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
    Friend WithEvents CONSULTADISPONIVELBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CONSULTADISPONIVELDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
