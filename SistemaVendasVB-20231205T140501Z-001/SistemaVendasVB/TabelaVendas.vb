Public Class TabelaVendas
    Private Sub PRODUTOSVENDABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRODUTOSVENDABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRODUTOSVENDABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseVendasDataSet)

    End Sub

    Private Sub TabelaVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.VENDASTableAdapter.Fill(Me.DatabaseVendasDataSet.VENDAS)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.PRODUTOSVENDA'. Você pode movê-la ou removê-la conforme necessário.
        Me.PRODUTOSVENDATableAdapter.Fill(Me.DatabaseVendasDataSet.PRODUTOSVENDA)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class