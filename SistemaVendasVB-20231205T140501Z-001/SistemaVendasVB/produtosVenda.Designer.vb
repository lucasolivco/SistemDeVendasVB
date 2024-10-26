<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class produtosVenda
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
        Dim PRODUTOSVENDAIDLabel1 As System.Windows.Forms.Label
        Dim QUANTIDADELabel As System.Windows.Forms.Label
        Dim PRECOTOTALLabel As System.Windows.Forms.Label
        Dim OBSLabel1 As System.Windows.Forms.Label
        Dim VENDA_IDLabel As System.Windows.Forms.Label
        Dim PRODUTO_IDLabel1 As System.Windows.Forms.Label
        Dim PRECO_UNITLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(produtosVenda))
        Me.DatabaseVendasDataSet = New SistemaVendasVB.databaseVendasDataSet()
        Me.PRODUTOSVENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager()
        Me.PRODUTOSVENDATableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.PRODUTOSVENDATableAdapter()
        Me.PRODUTOTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.PRODUTOTableAdapter()
        Me.VENDASTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.VENDASTableAdapter()
        Me.PRODUTOSVENDABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PRODUTOSVENDABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTOSVENDAIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.QUANTIDADETextBox = New System.Windows.Forms.TextBox()
        Me.PRECOTOTALTextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.VENDA_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.VENDASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTO_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.PRODUTOBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseVendasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseVendasDataSet1 = New SistemaVendasVB.databaseVendasDataSet()
        Me.PRODUTOSVENDADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO_UNITTextBox = New System.Windows.Forms.TextBox()
        PRODUTOSVENDAIDLabel1 = New System.Windows.Forms.Label()
        QUANTIDADELabel = New System.Windows.Forms.Label()
        PRECOTOTALLabel = New System.Windows.Forms.Label()
        OBSLabel1 = New System.Windows.Forms.Label()
        VENDA_IDLabel = New System.Windows.Forms.Label()
        PRODUTO_IDLabel1 = New System.Windows.Forms.Label()
        PRECO_UNITLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRODUTOSVENDABindingNavigator.SuspendLayout()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseVendasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseVendasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUTOSVENDAIDLabel1
        '
        PRODUTOSVENDAIDLabel1.AutoSize = True
        PRODUTOSVENDAIDLabel1.Location = New System.Drawing.Point(45, 124)
        PRODUTOSVENDAIDLabel1.Name = "PRODUTOSVENDAIDLabel1"
        PRODUTOSVENDAIDLabel1.Size = New System.Drawing.Size(119, 13)
        PRODUTOSVENDAIDLabel1.TabIndex = 13
        PRODUTOSVENDAIDLabel1.Text = "PRODUTOSVENDAID:"
        '
        'QUANTIDADELabel
        '
        QUANTIDADELabel.AutoSize = True
        QUANTIDADELabel.Location = New System.Drawing.Point(46, 150)
        QUANTIDADELabel.Name = "QUANTIDADELabel"
        QUANTIDADELabel.Size = New System.Drawing.Size(81, 13)
        QUANTIDADELabel.TabIndex = 15
        QUANTIDADELabel.Text = "QUANTIDADE:"
        '
        'PRECOTOTALLabel
        '
        PRECOTOTALLabel.AutoSize = True
        PRECOTOTALLabel.Location = New System.Drawing.Point(45, 202)
        PRECOTOTALLabel.Name = "PRECOTOTALLabel"
        PRECOTOTALLabel.Size = New System.Drawing.Size(82, 13)
        PRECOTOTALLabel.TabIndex = 19
        PRECOTOTALLabel.Text = "PRECOTOTAL:"
        '
        'OBSLabel1
        '
        OBSLabel1.AutoSize = True
        OBSLabel1.Location = New System.Drawing.Point(45, 228)
        OBSLabel1.Name = "OBSLabel1"
        OBSLabel1.Size = New System.Drawing.Size(32, 13)
        OBSLabel1.TabIndex = 21
        OBSLabel1.Text = "OBS:"
        '
        'VENDA_IDLabel
        '
        VENDA_IDLabel.AutoSize = True
        VENDA_IDLabel.Location = New System.Drawing.Point(45, 336)
        VENDA_IDLabel.Name = "VENDA_IDLabel"
        VENDA_IDLabel.Size = New System.Drawing.Size(61, 13)
        VENDA_IDLabel.TabIndex = 23
        VENDA_IDLabel.Text = "VENDA ID:"
        '
        'PRODUTO_IDLabel1
        '
        PRODUTO_IDLabel1.AutoSize = True
        PRODUTO_IDLabel1.Location = New System.Drawing.Point(45, 363)
        PRODUTO_IDLabel1.Name = "PRODUTO_IDLabel1"
        PRODUTO_IDLabel1.Size = New System.Drawing.Size(78, 13)
        PRODUTO_IDLabel1.TabIndex = 25
        PRODUTO_IDLabel1.Text = "PRODUTO ID:"
        '
        'PRECO_UNITLabel
        '
        PRECO_UNITLabel.AutoSize = True
        PRECO_UNITLabel.Location = New System.Drawing.Point(45, 176)
        PRECO_UNITLabel.Name = "PRECO_UNITLabel"
        PRECO_UNITLabel.Size = New System.Drawing.Size(76, 13)
        PRECO_UNITLabel.TabIndex = 26
        PRECO_UNITLabel.Text = "PRECO UNIT:"
        '
        'DatabaseVendasDataSet
        '
        Me.DatabaseVendasDataSet.DataSetName = "databaseVendasDataSet"
        Me.DatabaseVendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUTOSVENDABindingSource
        '
        Me.PRODUTOSVENDABindingSource.DataMember = "PRODUTOSVENDA"
        Me.PRODUTOSVENDABindingSource.DataSource = Me.DatabaseVendasDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUTOSVENDATableAdapter = Me.PRODUTOSVENDATableAdapter
        Me.TableAdapterManager.PRODUTOTableAdapter = Me.PRODUTOTableAdapter
        Me.TableAdapterManager.UpdateOrder = SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
        '
        'PRODUTOSVENDATableAdapter
        '
        Me.PRODUTOSVENDATableAdapter.ClearBeforeFill = True
        '
        'PRODUTOTableAdapter
        '
        Me.PRODUTOTableAdapter.ClearBeforeFill = True
        '
        'VENDASTableAdapter
        '
        Me.VENDASTableAdapter.ClearBeforeFill = True
        '
        'PRODUTOSVENDABindingNavigator
        '
        Me.PRODUTOSVENDABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRODUTOSVENDABindingNavigator.BindingSource = Me.PRODUTOSVENDABindingSource
        Me.PRODUTOSVENDABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRODUTOSVENDABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRODUTOSVENDABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRODUTOSVENDABindingNavigatorSaveItem})
        Me.PRODUTOSVENDABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRODUTOSVENDABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRODUTOSVENDABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRODUTOSVENDABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRODUTOSVENDABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRODUTOSVENDABindingNavigator.Name = "PRODUTOSVENDABindingNavigator"
        Me.PRODUTOSVENDABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRODUTOSVENDABindingNavigator.Size = New System.Drawing.Size(1181, 25)
        Me.PRODUTOSVENDABindingNavigator.TabIndex = 0
        Me.PRODUTOSVENDABindingNavigator.Text = "BindingNavigator1"
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
        'PRODUTOSVENDABindingNavigatorSaveItem
        '
        Me.PRODUTOSVENDABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Image = CType(resources.GetObject("PRODUTOSVENDABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Name = "PRODUTOSVENDABindingNavigatorSaveItem"
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'VENDASBindingSource
        '
        Me.VENDASBindingSource.DataMember = "VENDAS"
        Me.VENDASBindingSource.DataSource = Me.DatabaseVendasDataSet
        '
        'PRODUTOBindingSource1
        '
        Me.PRODUTOBindingSource1.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource1.DataSource = Me.DatabaseVendasDataSet
        '
        'PRODUTOBindingSource
        '
        Me.PRODUTOBindingSource.DataMember = "PRODUTOSVENDA_PRODUTO"
        Me.PRODUTOBindingSource.DataSource = Me.PRODUTOSVENDABindingSource
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRECOUNIT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECOUNIT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PRODUTOSVENDAIDTextBox1
        '
        Me.PRODUTOSVENDAIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "PRODUTOSVENDAID", True))
        Me.PRODUTOSVENDAIDTextBox1.Location = New System.Drawing.Point(170, 121)
        Me.PRODUTOSVENDAIDTextBox1.Name = "PRODUTOSVENDAIDTextBox1"
        Me.PRODUTOSVENDAIDTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.PRODUTOSVENDAIDTextBox1.TabIndex = 14
        '
        'QUANTIDADETextBox
        '
        Me.QUANTIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "QUANTIDADE", True))
        Me.QUANTIDADETextBox.Location = New System.Drawing.Point(170, 147)
        Me.QUANTIDADETextBox.Name = "QUANTIDADETextBox"
        Me.QUANTIDADETextBox.Size = New System.Drawing.Size(121, 20)
        Me.QUANTIDADETextBox.TabIndex = 16
        '
        'PRECOTOTALTextBox
        '
        Me.PRECOTOTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "PRECOTOTAL", True))
        Me.PRECOTOTALTextBox.Enabled = False
        Me.PRECOTOTALTextBox.Location = New System.Drawing.Point(170, 199)
        Me.PRECOTOTALTextBox.Name = "PRECOTOTALTextBox"
        Me.PRECOTOTALTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PRECOTOTALTextBox.TabIndex = 20
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(170, 225)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(121, 102)
        Me.OBSTextBox.TabIndex = 22
        '
        'VENDA_IDComboBox
        '
        Me.VENDA_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "VENDA_ID", True))
        Me.VENDA_IDComboBox.DataSource = Me.VENDASBindingSource1
        Me.VENDA_IDComboBox.DisplayMember = "VENDAID"
        Me.VENDA_IDComboBox.FormattingEnabled = True
        Me.VENDA_IDComboBox.Location = New System.Drawing.Point(170, 333)
        Me.VENDA_IDComboBox.Name = "VENDA_IDComboBox"
        Me.VENDA_IDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VENDA_IDComboBox.TabIndex = 24
        Me.VENDA_IDComboBox.ValueMember = "VENDAID"
        '
        'VENDASBindingSource1
        '
        Me.VENDASBindingSource1.DataMember = "VENDAS"
        Me.VENDASBindingSource1.DataSource = Me.DatabaseVendasDataSet
        '
        'PRODUTO_IDComboBox
        '
        Me.PRODUTO_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "PRODUTO_ID", True))
        Me.PRODUTO_IDComboBox.DataSource = Me.PRODUTOBindingSource2
        Me.PRODUTO_IDComboBox.DisplayMember = "NOMEPRODUTO"
        Me.PRODUTO_IDComboBox.FormattingEnabled = True
        Me.PRODUTO_IDComboBox.Location = New System.Drawing.Point(170, 360)
        Me.PRODUTO_IDComboBox.Name = "PRODUTO_IDComboBox"
        Me.PRODUTO_IDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PRODUTO_IDComboBox.TabIndex = 26
        Me.PRODUTO_IDComboBox.ValueMember = "PRODUTOID"
        '
        'PRODUTOBindingSource2
        '
        Me.PRODUTOBindingSource2.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource2.DataSource = Me.DatabaseVendasDataSet
        '
        'DatabaseVendasDataSetBindingSource
        '
        Me.DatabaseVendasDataSetBindingSource.DataSource = Me.DatabaseVendasDataSet
        Me.DatabaseVendasDataSetBindingSource.Position = 0
        '
        'PRODUTOBindingSource3
        '
        Me.PRODUTOBindingSource3.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource3.DataSource = Me.DatabaseVendasDataSet1
        '
        'DatabaseVendasDataSet1
        '
        Me.DatabaseVendasDataSet1.DataSetName = "databaseVendasDataSet"
        Me.DatabaseVendasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUTOSVENDADataGridView
        '
        Me.PRODUTOSVENDADataGridView.AutoGenerateColumns = False
        Me.PRODUTOSVENDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUTOSVENDADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PRODUTOSVENDADataGridView.DataSource = Me.PRODUTOSVENDABindingSource
        Me.PRODUTOSVENDADataGridView.Location = New System.Drawing.Point(380, 87)
        Me.PRODUTOSVENDADataGridView.Name = "PRODUTOSVENDADataGridView"
        Me.PRODUTOSVENDADataGridView.Size = New System.Drawing.Size(745, 220)
        Me.PRODUTOSVENDADataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PRODUTOSVENDAID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRODUTOSVENDAID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "QUANTIDADE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "QUANTIDADE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRECO_UNIT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRECO_UNIT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PRECOTOTAL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRECOTOTAL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OBS"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OBS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VENDA_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "VENDA_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PRODUTO_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PRODUTO_ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'PRECO_UNITTextBox
        '
        Me.PRECO_UNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOSVENDABindingSource, "PRECO_UNIT", True))
        Me.PRECO_UNITTextBox.Location = New System.Drawing.Point(170, 173)
        Me.PRECO_UNITTextBox.Name = "PRECO_UNITTextBox"
        Me.PRECO_UNITTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PRECO_UNITTextBox.TabIndex = 30
        '
        'produtosVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 508)
        Me.Controls.Add(Me.PRECO_UNITTextBox)
        Me.Controls.Add(Me.PRODUTOSVENDADataGridView)
        Me.Controls.Add(PRECO_UNITLabel)
        Me.Controls.Add(PRODUTOSVENDAIDLabel1)
        Me.Controls.Add(Me.PRODUTOSVENDAIDTextBox1)
        Me.Controls.Add(QUANTIDADELabel)
        Me.Controls.Add(Me.QUANTIDADETextBox)
        Me.Controls.Add(PRECOTOTALLabel)
        Me.Controls.Add(Me.PRECOTOTALTextBox)
        Me.Controls.Add(OBSLabel1)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(VENDA_IDLabel)
        Me.Controls.Add(Me.VENDA_IDComboBox)
        Me.Controls.Add(PRODUTO_IDLabel1)
        Me.Controls.Add(Me.PRODUTO_IDComboBox)
        Me.Controls.Add(Me.PRODUTOSVENDABindingNavigator)
        Me.Name = "produtosVenda"
        Me.Text = "produtosVenda"
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRODUTOSVENDABindingNavigator.ResumeLayout(False)
        Me.PRODUTOSVENDABindingNavigator.PerformLayout()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseVendasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseVendasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseVendasDataSet As databaseVendasDataSet
    Friend WithEvents PRODUTOSVENDABindingSource As BindingSource
    Friend WithEvents PRODUTOSVENDATableAdapter As databaseVendasDataSetTableAdapters.PRODUTOSVENDATableAdapter
    Friend WithEvents TableAdapterManager As databaseVendasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUTOSVENDABindingNavigator As BindingNavigator
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
    Friend WithEvents PRODUTOSVENDABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PRODUTOTableAdapter As databaseVendasDataSetTableAdapters.PRODUTOTableAdapter
    Friend WithEvents PRODUTOBindingSource As BindingSource
    Friend WithEvents VENDASTableAdapter As databaseVendasDataSetTableAdapters.VENDASTableAdapter
    Friend WithEvents VENDASBindingSource As BindingSource
    Friend WithEvents PRODUTOBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUTOSVENDAIDTextBox1 As TextBox
    Friend WithEvents QUANTIDADETextBox As TextBox
    Friend WithEvents PRECOTOTALTextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents VENDA_IDComboBox As ComboBox
    Friend WithEvents PRODUTO_IDComboBox As ComboBox
    Friend WithEvents VENDASBindingSource1 As BindingSource
    Friend WithEvents PRODUTOBindingSource2 As BindingSource
    Friend WithEvents DatabaseVendasDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseVendasDataSet1 As databaseVendasDataSet
    Friend WithEvents PRODUTOBindingSource3 As BindingSource
    Friend WithEvents PRODUTOSVENDADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PRECO_UNITTextBox As TextBox
End Class
