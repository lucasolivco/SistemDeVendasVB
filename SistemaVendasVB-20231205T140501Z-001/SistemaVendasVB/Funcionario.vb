Public Class Funcionario
    Private Sub FUNCIONARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FUNCIONARIOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FUNCIONARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseVendasDataSet)
    End Sub

    Private Sub Funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.FUNCIONARIOSTableAdapter.Fill(Me.DatabaseVendasDataSet.FUNCIONARIOS)

    End Sub
End Class