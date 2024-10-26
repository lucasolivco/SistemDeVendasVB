Public Class Form1
    Private Sub FuncionárioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionárioToolStripMenuItem1.Click
        Funcionario.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Cliente.Show()
    End Sub

    Private Sub RegistroDeProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeProdutoToolStripMenuItem.Click
        Produto.Show()
    End Sub

    Private Sub RegistroDeVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVendaToolStripMenuItem.Click
        Venda.Show()
    End Sub

    Private Sub ProdutosVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosVendidosToolStripMenuItem.Click
        produtosVenda.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
