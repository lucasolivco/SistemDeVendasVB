Public Class Cliente
    Private Sub CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseVendasDataSet)
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTESTableAdapter.Fill(Me.DatabaseVendasDataSet.CLIENTES)

    End Sub

End Class