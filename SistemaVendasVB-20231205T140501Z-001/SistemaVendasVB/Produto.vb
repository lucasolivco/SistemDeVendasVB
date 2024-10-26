Public Class Produto
    Private Sub PRODUTOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRODUTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRODUTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseVendasDataSet)

    End Sub

    Private Sub Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
        Me.PRODUTOTableAdapter.Fill(Me.DatabaseVendasDataSet.PRODUTO)

    End Sub
End Class