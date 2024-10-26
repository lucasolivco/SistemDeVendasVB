<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produto
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
        Dim PRODUTOIDLabel As System.Windows.Forms.Label
        Dim NOMEPRODUTOLabel As System.Windows.Forms.Label
        Dim PRECOUNITLabel As System.Windows.Forms.Label
        Dim ESTOQUELabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produto))
        Me.DatabaseVendasDataSet = New SistemaVendasVB.databaseVendasDataSet()
        Me.PRODUTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.PRODUTOTableAdapter()
        Me.TableAdapterManager = New SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager()
        Me.PRODUTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PRODUTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PRODUTOIDTextBox = New System.Windows.Forms.TextBox()
        Me.NOMEPRODUTOTextBox = New System.Windows.Forms.TextBox()
        Me.PRECOUNITTextBox = New System.Windows.Forms.TextBox()
        Me.ESTOQUETextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PRODUTOIDLabel = New System.Windows.Forms.Label()
        NOMEPRODUTOLabel = New System.Windows.Forms.Label()
        PRECOUNITLabel = New System.Windows.Forms.Label()
        ESTOQUELabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRODUTOBindingNavigator.SuspendLayout()
        CType(Me.PRODUTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUTOIDLabel
        '
        PRODUTOIDLabel.AutoSize = True
        PRODUTOIDLabel.Location = New System.Drawing.Point(12, 72)
        PRODUTOIDLabel.Name = "PRODUTOIDLabel"
        PRODUTOIDLabel.Size = New System.Drawing.Size(75, 13)
        PRODUTOIDLabel.TabIndex = 1
        PRODUTOIDLabel.Text = "PRODUTOID:"
        '
        'NOMEPRODUTOLabel
        '
        NOMEPRODUTOLabel.AutoSize = True
        NOMEPRODUTOLabel.Location = New System.Drawing.Point(12, 98)
        NOMEPRODUTOLabel.Name = "NOMEPRODUTOLabel"
        NOMEPRODUTOLabel.Size = New System.Drawing.Size(96, 13)
        NOMEPRODUTOLabel.TabIndex = 3
        NOMEPRODUTOLabel.Text = "NOMEPRODUTO:"
        '
        'PRECOUNITLabel
        '
        PRECOUNITLabel.AutoSize = True
        PRECOUNITLabel.Location = New System.Drawing.Point(12, 124)
        PRECOUNITLabel.Name = "PRECOUNITLabel"
        PRECOUNITLabel.Size = New System.Drawing.Size(73, 13)
        PRECOUNITLabel.TabIndex = 5
        PRECOUNITLabel.Text = "PRECOUNIT:"
        '
        'ESTOQUELabel
        '
        ESTOQUELabel.AutoSize = True
        ESTOQUELabel.Location = New System.Drawing.Point(12, 150)
        ESTOQUELabel.Name = "ESTOQUELabel"
        ESTOQUELabel.Size = New System.Drawing.Size(62, 13)
        ESTOQUELabel.TabIndex = 7
        ESTOQUELabel.Text = "ESTOQUE:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(12, 176)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 9
        OBSLabel.Text = "OBS:"
        '
        'DatabaseVendasDataSet
        '
        Me.DatabaseVendasDataSet.DataSetName = "databaseVendasDataSet"
        Me.DatabaseVendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUTOBindingSource
        '
        Me.PRODUTOBindingSource.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource.DataSource = Me.DatabaseVendasDataSet
        '
        'PRODUTOTableAdapter
        '
        Me.PRODUTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUTOSVENDATableAdapter = Nothing
        Me.TableAdapterManager.PRODUTOTableAdapter = Me.PRODUTOTableAdapter
        Me.TableAdapterManager.UpdateOrder = SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDASTableAdapter = Nothing
        '
        'PRODUTOBindingNavigator
        '
        Me.PRODUTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRODUTOBindingNavigator.BindingSource = Me.PRODUTOBindingSource
        Me.PRODUTOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRODUTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRODUTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRODUTOBindingNavigatorSaveItem})
        Me.PRODUTOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRODUTOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRODUTOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRODUTOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRODUTOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRODUTOBindingNavigator.Name = "PRODUTOBindingNavigator"
        Me.PRODUTOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRODUTOBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PRODUTOBindingNavigator.TabIndex = 0
        Me.PRODUTOBindingNavigator.Text = "BindingNavigator1"
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
        'PRODUTOBindingNavigatorSaveItem
        '
        Me.PRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRODUTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("PRODUTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRODUTOBindingNavigatorSaveItem.Name = "PRODUTOBindingNavigatorSaveItem"
        Me.PRODUTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'PRODUTOIDTextBox
        '
        Me.PRODUTOIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOBindingSource, "PRODUTOID", True))
        Me.PRODUTOIDTextBox.Location = New System.Drawing.Point(114, 69)
        Me.PRODUTOIDTextBox.Name = "PRODUTOIDTextBox"
        Me.PRODUTOIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUTOIDTextBox.TabIndex = 2
        '
        'NOMEPRODUTOTextBox
        '
        Me.NOMEPRODUTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOBindingSource, "NOMEPRODUTO", True))
        Me.NOMEPRODUTOTextBox.Location = New System.Drawing.Point(114, 95)
        Me.NOMEPRODUTOTextBox.Name = "NOMEPRODUTOTextBox"
        Me.NOMEPRODUTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMEPRODUTOTextBox.TabIndex = 4
        '
        'PRECOUNITTextBox
        '
        Me.PRECOUNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOBindingSource, "PRECOUNIT", True))
        Me.PRECOUNITTextBox.Location = New System.Drawing.Point(114, 121)
        Me.PRECOUNITTextBox.Name = "PRECOUNITTextBox"
        Me.PRECOUNITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRECOUNITTextBox.TabIndex = 6
        '
        'ESTOQUETextBox
        '
        Me.ESTOQUETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOBindingSource, "ESTOQUE", True))
        Me.ESTOQUETextBox.Location = New System.Drawing.Point(114, 147)
        Me.ESTOQUETextBox.Name = "ESTOQUETextBox"
        Me.ESTOQUETextBox.Size = New System.Drawing.Size(100, 20)
        Me.ESTOQUETextBox.TabIndex = 8
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(114, 173)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(100, 114)
        Me.OBSTextBox.TabIndex = 10
        '
        'PRODUTODataGridView
        '
        Me.PRODUTODataGridView.AutoGenerateColumns = False
        Me.PRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PRODUTODataGridView.DataSource = Me.PRODUTOBindingSource
        Me.PRODUTODataGridView.Location = New System.Drawing.Point(249, 72)
        Me.PRODUTODataGridView.Name = "PRODUTODataGridView"
        Me.PRODUTODataGridView.Size = New System.Drawing.Size(539, 220)
        Me.PRODUTODataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PRODUTOID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRODUTOID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMEPRODUTO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMEPRODUTO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRECOUNIT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECOUNIT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ESTOQUE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ESTOQUE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "OBS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "OBS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PRODUTODataGridView)
        Me.Controls.Add(PRODUTOIDLabel)
        Me.Controls.Add(Me.PRODUTOIDTextBox)
        Me.Controls.Add(NOMEPRODUTOLabel)
        Me.Controls.Add(Me.NOMEPRODUTOTextBox)
        Me.Controls.Add(PRECOUNITLabel)
        Me.Controls.Add(Me.PRECOUNITTextBox)
        Me.Controls.Add(ESTOQUELabel)
        Me.Controls.Add(Me.ESTOQUETextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.PRODUTOBindingNavigator)
        Me.Name = "Produto"
        Me.Text = "Produto"
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRODUTOBindingNavigator.ResumeLayout(False)
        Me.PRODUTOBindingNavigator.PerformLayout()
        CType(Me.PRODUTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseVendasDataSet As databaseVendasDataSet
    Friend WithEvents PRODUTOBindingSource As BindingSource
    Friend WithEvents PRODUTOTableAdapter As databaseVendasDataSetTableAdapters.PRODUTOTableAdapter
    Friend WithEvents TableAdapterManager As databaseVendasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUTOBindingNavigator As BindingNavigator
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
    Friend WithEvents PRODUTOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PRODUTOIDTextBox As TextBox
    Friend WithEvents NOMEPRODUTOTextBox As TextBox
    Friend WithEvents PRECOUNITTextBox As TextBox
    Friend WithEvents ESTOQUETextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents PRODUTODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
