<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelaVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabelaVendas))
        Me.ClientesTableAdapter1 = New SistemaVendasVB.databaseVendasDataSetTableAdapters.CLIENTESTableAdapter()
        Me.DatabaseVendasDataSet = New SistemaVendasVB.databaseVendasDataSet()
        Me.PRODUTOSVENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOSVENDATableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.PRODUTOSVENDATableAdapter()
        Me.TableAdapterManager = New SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager()
        Me.PRODUTOSVENDABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PRODUTOSVENDABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASTableAdapter = New SistemaVendasVB.databaseVendasDataSetTableAdapters.VENDASTableAdapter()
        Me.VENDASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASCLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDASBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOSVENDAVENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUTOSVENDAVENDASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRODUTOSVENDABindingNavigator.SuspendLayout()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDASBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDAVENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOSVENDAVENDASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
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
        'PRODUTOSVENDATableAdapter
        '
        Me.PRODUTOSVENDATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUTOSVENDATableAdapter = Me.PRODUTOSVENDATableAdapter
        Me.TableAdapterManager.PRODUTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaVendasVB.databaseVendasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VENDASTableAdapter = Me.VENDASTableAdapter
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
        Me.PRODUTOSVENDABindingNavigator.Size = New System.Drawing.Size(1560, 25)
        Me.PRODUTOSVENDABindingNavigator.TabIndex = 0
        Me.PRODUTOSVENDABindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'PRODUTOSVENDABindingNavigatorSaveItem
        '
        Me.PRODUTOSVENDABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Image = CType(resources.GetObject("PRODUTOSVENDABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Name = "PRODUTOSVENDABindingNavigatorSaveItem"
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PRODUTOSVENDABindingNavigatorSaveItem.Text = "Salvar Dados"
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
        'VENDASBindingSource1
        '
        Me.VENDASBindingSource1.DataMember = "VENDAS"
        Me.VENDASBindingSource1.DataSource = Me.DatabaseVendasDataSet
        '
        'VENDASCLIENTESBindingSource
        '
        Me.VENDASCLIENTESBindingSource.DataMember = "VENDAS_CLIENTES"
        Me.VENDASCLIENTESBindingSource.DataSource = Me.VENDASBindingSource1
        '
        'VENDASBindingSource2
        '
        Me.VENDASBindingSource2.DataMember = "VENDAS"
        Me.VENDASBindingSource2.DataSource = Me.DatabaseVendasDataSet
        '
        'VENDASBindingSource3
        '
        Me.VENDASBindingSource3.DataMember = "VENDAS"
        Me.VENDASBindingSource3.DataSource = Me.DatabaseVendasDataSet
        '
        'PRODUTOSVENDAVENDASBindingSource
        '
        Me.PRODUTOSVENDAVENDASBindingSource.DataMember = "PRODUTOSVENDA_VENDAS"
        Me.PRODUTOSVENDAVENDASBindingSource.DataSource = Me.PRODUTOSVENDABindingSource
        '
        'PRODUTOSVENDAVENDASBindingSource1
        '
        Me.PRODUTOSVENDAVENDASBindingSource1.DataMember = "PRODUTOSVENDA_VENDAS"
        Me.PRODUTOSVENDAVENDASBindingSource1.DataSource = Me.PRODUTOSVENDABindingSource
        '
        'TabelaVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 577)
        Me.Controls.Add(Me.PRODUTOSVENDABindingNavigator)
        Me.Name = "TabelaVendas"
        Me.Text = "TabelaVendas"
        CType(Me.DatabaseVendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRODUTOSVENDABindingNavigator.ResumeLayout(False)
        Me.PRODUTOSVENDABindingNavigator.PerformLayout()
        CType(Me.VENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDASBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDAVENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOSVENDAVENDASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientesTableAdapter1 As databaseVendasDataSetTableAdapters.CLIENTESTableAdapter
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
    Friend WithEvents VENDASTableAdapter As databaseVendasDataSetTableAdapters.VENDASTableAdapter
    Friend WithEvents VENDASBindingSource As BindingSource
    Friend WithEvents VENDASBindingSource2 As BindingSource
    Friend WithEvents VENDASBindingSource1 As BindingSource
    Friend WithEvents VENDASCLIENTESBindingSource As BindingSource
    Friend WithEvents VENDASBindingSource3 As BindingSource
    Friend WithEvents PRODUTOSVENDAVENDASBindingSource As BindingSource
    Friend WithEvents PRODUTOSVENDAVENDASBindingSource1 As BindingSource
End Class
