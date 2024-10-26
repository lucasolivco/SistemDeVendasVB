<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venda
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
        Dim VENDAIDLabel As System.Windows.Forms.Label
        Dim DATAVENDALabel As System.Windows.Forms.Label
        Dim TOTAL_PEDIDOLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim CLIENTE_CPFLabel As System.Windows.Forms.Label
        Dim FUNC_CPFLabel As System.Windows.Forms.Label
        Dim PRECOUNITLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venda))
        Me.DatabaseVendasDataSet = New SistemaVendasVB.databaseVendasDataSet()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.VENDASTableAdapter()
        Me.TableAdapterManager = New SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager()
        Me.CLIENTESTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.CLIENTESTableAdapter()
        Me.VENDASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VENDASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VENDASCLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDAIDTextBox = New System.Windows.Forms.TextBox()
        Me.DATAVENDADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TOTAL_PEDIDOTextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.CLIENTE_CPFComboBox = New System.Windows.Forms.ComboBox()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUNC_CPFComboBox = New System.Windows.Forms.ComboBox()
        Me.FUNCIONARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUNCIONARIOSTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.FUNCIONARIOSTableAdapter()
        Me.VENDASDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PRODUTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.PRODUTOTableAdapter()
        Me.PRODUTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PRECOUNITTextBox = New System.Windows.Forms.TextBox()
        VENDAIDLabel = New System.Windows.Forms.Label()
        DATAVENDALabel = New System.Windows.Forms.Label()
        TOTAL_PEDIDOLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CLIENTE_CPFLabel = New System.Windows.Forms.Label()
        FUNC_CPFLabel = New System.Windows.Forms.Label()
        PRECOUNITLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VENDASBindingNavigator.SuspendLayout()
        CType(Me.VENDASCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VENDAIDLabel
        '
        VENDAIDLabel.AutoSize = True
        VENDAIDLabel.Location = New System.Drawing.Point(12, 71)
        VENDAIDLabel.Name = "VENDAIDLabel"
        VENDAIDLabel.Size = New System.Drawing.Size(58, 13)
        VENDAIDLabel.TabIndex = 1
        VENDAIDLabel.Text = "VENDAID:"
        '
        'DATAVENDALabel
        '
        DATAVENDALabel.AutoSize = True
        DATAVENDALabel.Location = New System.Drawing.Point(12, 98)
        DATAVENDALabel.Name = "DATAVENDALabel"
        DATAVENDALabel.Size = New System.Drawing.Size(76, 13)
        DATAVENDALabel.TabIndex = 3
        DATAVENDALabel.Text = "DATAVENDA:"
        '
        'TOTAL_PEDIDOLabel
        '
        TOTAL_PEDIDOLabel.AutoSize = True
        TOTAL_PEDIDOLabel.Location = New System.Drawing.Point(12, 123)
        TOTAL_PEDIDOLabel.Name = "TOTAL_PEDIDOLabel"
        TOTAL_PEDIDOLabel.Size = New System.Drawing.Size(89, 13)
        TOTAL_PEDIDOLabel.TabIndex = 5
        TOTAL_PEDIDOLabel.Text = "TOTAL PEDIDO:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(12, 149)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 7
        OBSLabel.Text = "OBS:"
        '
        'CLIENTE_CPFLabel
        '
        CLIENTE_CPFLabel.AutoSize = True
        CLIENTE_CPFLabel.Location = New System.Drawing.Point(12, 237)
        CLIENTE_CPFLabel.Name = "CLIENTE_CPFLabel"
        CLIENTE_CPFLabel.Size = New System.Drawing.Size(55, 13)
        CLIENTE_CPFLabel.TabIndex = 9
        CLIENTE_CPFLabel.Text = "CLIENTE:"
        AddHandler CLIENTE_CPFLabel.Click, AddressOf Me.CLIENTE_CPFLabel_Click
        '
        'FUNC_CPFLabel
        '
        FUNC_CPFLabel.AutoSize = True
        FUNC_CPFLabel.Location = New System.Drawing.Point(12, 264)
        FUNC_CPFLabel.Name = "FUNC_CPFLabel"
        FUNC_CPFLabel.Size = New System.Drawing.Size(84, 13)
        FUNC_CPFLabel.TabIndex = 11
        FUNC_CPFLabel.Text = "FUNCIONÁRIO:"
        '
        'PRECOUNITLabel
        '
        PRECOUNITLabel.AutoSize = True
        PRECOUNITLabel.Location = New System.Drawing.Point(12, 359)
        PRECOUNITLabel.Name = "PRECOUNITLabel"
        PRECOUNITLabel.Size = New System.Drawing.Size(73, 13)
        PRECOUNITLabel.TabIndex = 22
        PRECOUNITLabel.Text = "PRECOUNIT:"
        AddHandler PRECOUNITLabel.Click, AddressOf Me.PRECOUNITLabel_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 322)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 13)
        Label2.TabIndex = 24
        Label2.Text = "PRODUTO:"
        '
        'DatabaseVendasDataSet
        '
        Me.DatabaseVendasDataSet.DataSetName = "databaseVendasDataSet"
        Me.DatabaseVendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDASBindingSource
        '
        Me.VENDASBindingSource.DataMember = "VENDAS"
        Me.VENDASBindingSource.DataSource = Me.DatabaseVendasDataSet
        '
        'VENDASTableAdapter
        '
        Me.VENDASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUTOSVENDATableAdapter = Nothing
        Me.TableAdapterManager.PRODUTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'VENDASBindingNavigator
        '
        Me.VENDASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VENDASBindingNavigator.BindingSource = Me.VENDASBindingSource
        Me.VENDASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VENDASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VENDASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VENDASBindingNavigatorSaveItem})
        Me.VENDASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VENDASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VENDASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VENDASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VENDASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VENDASBindingNavigator.Name = "VENDASBindingNavigator"
        Me.VENDASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VENDASBindingNavigator.Size = New System.Drawing.Size(1385, 25)
        Me.VENDASBindingNavigator.TabIndex = 0
        Me.VENDASBindingNavigator.Text = "BindingNavigator1"
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
        'VENDASBindingNavigatorSaveItem
        '
        Me.VENDASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VENDASBindingNavigatorSaveItem.Image = CType(resources.GetObject("VENDASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VENDASBindingNavigatorSaveItem.Name = "VENDASBindingNavigatorSaveItem"
        Me.VENDASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VENDASBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'VENDASCLIENTESBindingSource
        '
        Me.VENDASCLIENTESBindingSource.DataMember = "VENDAS_CLIENTES"
        Me.VENDASCLIENTESBindingSource.DataSource = Me.VENDASBindingSource
        '
        'VENDAIDTextBox
        '
        Me.VENDAIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDASBindingSource, "VENDAID", True))
        Me.VENDAIDTextBox.Location = New System.Drawing.Point(107, 68)
        Me.VENDAIDTextBox.Name = "VENDAIDTextBox"
        Me.VENDAIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VENDAIDTextBox.TabIndex = 2
        '
        'DATAVENDADateTimePicker
        '
        Me.DATAVENDADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VENDASBindingSource, "DATAVENDA", True))
        Me.DATAVENDADateTimePicker.Location = New System.Drawing.Point(107, 94)
        Me.DATAVENDADateTimePicker.Name = "DATAVENDADateTimePicker"
        Me.DATAVENDADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATAVENDADateTimePicker.TabIndex = 4
        '
        'TOTAL_PEDIDOTextBox
        '
        Me.TOTAL_PEDIDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDASBindingSource, "TOTAL_PEDIDO", True))
        Me.TOTAL_PEDIDOTextBox.Enabled = False
        Me.TOTAL_PEDIDOTextBox.Location = New System.Drawing.Point(107, 120)
        Me.TOTAL_PEDIDOTextBox.Name = "TOTAL_PEDIDOTextBox"
        Me.TOTAL_PEDIDOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TOTAL_PEDIDOTextBox.TabIndex = 6
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDASBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(107, 146)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(200, 82)
        Me.OBSTextBox.TabIndex = 8
        '
        'CLIENTE_CPFComboBox
        '
        Me.CLIENTE_CPFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDASBindingSource, "CLIENTE_CPF", True))
        Me.CLIENTE_CPFComboBox.DataSource = Me.CLIENTESBindingSource
        Me.CLIENTE_CPFComboBox.DisplayMember = "NOME"
        Me.CLIENTE_CPFComboBox.FormattingEnabled = True
        Me.CLIENTE_CPFComboBox.Location = New System.Drawing.Point(107, 234)
        Me.CLIENTE_CPFComboBox.Name = "CLIENTE_CPFComboBox"
        Me.CLIENTE_CPFComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CLIENTE_CPFComboBox.TabIndex = 10
        Me.CLIENTE_CPFComboBox.ValueMember = "NOME"
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.DatabaseVendasDataSet
        '
        'FUNC_CPFComboBox
        '
        Me.FUNC_CPFComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDASBindingSource, "FUNC_CPF", True))
        Me.FUNC_CPFComboBox.DataSource = Me.FUNCIONARIOSBindingSource
        Me.FUNC_CPFComboBox.DisplayMember = "NOME"
        Me.FUNC_CPFComboBox.FormattingEnabled = True
        Me.FUNC_CPFComboBox.Location = New System.Drawing.Point(107, 261)
        Me.FUNC_CPFComboBox.Name = "FUNC_CPFComboBox"
        Me.FUNC_CPFComboBox.Size = New System.Drawing.Size(200, 21)
        Me.FUNC_CPFComboBox.TabIndex = 12
        Me.FUNC_CPFComboBox.ValueMember = "NOME"
        '
        'FUNCIONARIOSBindingSource
        '
        Me.FUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS"
        Me.FUNCIONARIOSBindingSource.DataSource = Me.DatabaseVendasDataSet
        '
        'FUNCIONARIOSTableAdapter
        '
        Me.FUNCIONARIOSTableAdapter.ClearBeforeFill = True
        '
        'VENDASDataGridView
        '
        Me.VENDASDataGridView.AutoGenerateColumns = False
        Me.VENDASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VENDASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VENDASDataGridView.DataSource = Me.VENDASBindingSource
        Me.VENDASDataGridView.Location = New System.Drawing.Point(353, 41)
        Me.VENDASDataGridView.Name = "VENDASDataGridView"
        Me.VENDASDataGridView.Size = New System.Drawing.Size(646, 331)
        Me.VENDASDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VENDAID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VENDAID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DATAVENDA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DATAVENDA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TOTAL_PEDIDO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TOTAL_PEDIDO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OBS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OBS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CLIENTE_CPF"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CLIENTE_CPF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FUNC_CPF"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FUNC_CPF"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PRODUTOBindingSource
        Me.ComboBox1.DisplayMember = "NOMEPRODUTO"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 314)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "PRODUTOID"
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
        'PRODUTOBindingSource1
        '
        Me.PRODUTOBindingSource1.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource1.DataSource = Me.DatabaseVendasDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 398)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "QUANTIDADE:"
        '
        'PRECOUNITTextBox
        '
        Me.PRECOUNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUTOBindingSource, "PRECOUNIT", True))
        Me.PRECOUNITTextBox.Enabled = False
        Me.PRECOUNITTextBox.Location = New System.Drawing.Point(107, 356)
        Me.PRECOUNITTextBox.Name = "PRECOUNITTextBox"
        Me.PRECOUNITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRECOUNITTextBox.TabIndex = 23
        '
        'Venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1385, 453)
        Me.Controls.Add(Label2)
        Me.Controls.Add(PRECOUNITLabel)
        Me.Controls.Add(Me.PRECOUNITTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.VENDASDataGridView)
        Me.Controls.Add(VENDAIDLabel)
        Me.Controls.Add(Me.VENDAIDTextBox)
        Me.Controls.Add(DATAVENDALabel)
        Me.Controls.Add(Me.DATAVENDADateTimePicker)
        Me.Controls.Add(TOTAL_PEDIDOLabel)
        Me.Controls.Add(Me.TOTAL_PEDIDOTextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(CLIENTE_CPFLabel)
        Me.Controls.Add(Me.CLIENTE_CPFComboBox)
        Me.Controls.Add(FUNC_CPFLabel)
        Me.Controls.Add(Me.FUNC_CPFComboBox)
        Me.Controls.Add(Me.VENDASBindingNavigator)
        Me.Name = "Venda"
        Me.Text = "Venda"
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VENDASBindingNavigator.ResumeLayout(False)
        Me.VENDASBindingNavigator.PerformLayout()
        CType(Me.VENDASCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseVendasDataSet As databaseVendasDataSet
    Friend WithEvents VENDASBindingSource As BindingSource
    Friend WithEvents VENDASTableAdapter As databaseVendasDataSetTableAdapters.VENDASTableAdapter
    Friend WithEvents TableAdapterManager As databaseVendasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VENDASBindingNavigator As BindingNavigator
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
    Friend WithEvents VENDASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CLIENTESTableAdapter As databaseVendasDataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents VENDASCLIENTESBindingSource As BindingSource
    Friend WithEvents VENDAIDTextBox As TextBox
    Friend WithEvents DATAVENDADateTimePicker As DateTimePicker
    Friend WithEvents TOTAL_PEDIDOTextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents CLIENTE_CPFComboBox As ComboBox
    Friend WithEvents FUNC_CPFComboBox As ComboBox
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents FUNCIONARIOSBindingSource As BindingSource
    Friend WithEvents FUNCIONARIOSTableAdapter As databaseVendasDataSetTableAdapters.FUNCIONARIOSTableAdapter
    Friend WithEvents VENDASDataGridView As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PRODUTOBindingSource As BindingSource
    Friend WithEvents PRODUTOTableAdapter As databaseVendasDataSetTableAdapters.PRODUTOTableAdapter
    Friend WithEvents PRODUTOBindingSource1 As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PRECOUNITTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
