
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class produtosVenda
    Private Sub PRODUTOSVENDABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRODUTOSVENDABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRODUTOSVENDABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseVendasDataSet)

    End Sub

    Private Sub produtosVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet1.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
        Me.PRODUTOTableAdapter.Fill(Me.DatabaseVendasDataSet1.PRODUTO)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.VENDASTableAdapter.Fill(Me.DatabaseVendasDataSet.VENDAS)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
        Me.PRODUTOTableAdapter.Fill(Me.DatabaseVendasDataSet.PRODUTO)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.PRODUTOSVENDA'. Você pode movê-la ou removê-la conforme necessário.
        Me.PRODUTOSVENDATableAdapter.Fill(Me.DatabaseVendasDataSet.PRODUTOSVENDA)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 
        CalcularMultiplicacao()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles QUANTIDADETextBox.TextChanged
        CalcularMultiplicacao()
    End Sub

    Private Sub CalcularMultiplicacao()
        ' Verificar se ambos os campos têm valores válidos
        If Double.TryParse(PRECO_UNITTextBox.Text, Nothing) AndAlso Double.TryParse(QUANTIDADETextBox.Text, Nothing) Then
            ' Realizar a multiplicação e exibir o resultado na TextBoxResultado
            Dim valor1 As Double = Convert.ToDouble(PRECO_UNITTextBox.Text)
            Dim valor2 As Double = Convert.ToDouble(QUANTIDADETextBox.Text)
            Dim resultado As Double = valor1 * valor2

            PRECOTOTALTextBox.Text = resultado.ToString()
        Else
            ' Se um dos valores não for numérico, limpar o resultado
            PRECOTOTALTextBox.Text = ""
        End If
    End Sub










    Private Sub PRODUTO_IDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PRODUTO_IDComboBox.SelectedIndexChanged

    End Sub





    Private Sub PRECOUNITTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillBy12ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PRODUTOTableAdapter.FillBy12(Me.DatabaseVendasDataSet.PRODUTO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy13ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PRODUTOTableAdapter.FillBy13(Me.DatabaseVendasDataSet.PRODUTO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy15ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PRODUTOTableAdapter.FillBy15(Me.DatabaseVendasDataSet1.PRODUTO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy15ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
    End Sub
End Class