Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Venda
    Private Sub VENDASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENDASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VENDASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseVendasDataSet)
    End Sub

    Private Sub Venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
        Me.PRODUTOTableAdapter.Fill(Me.DatabaseVendasDataSet.PRODUTO)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.FUNCIONARIOSTableAdapter.Fill(Me.DatabaseVendasDataSet.FUNCIONARIOS)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTESTableAdapter.Fill(Me.DatabaseVendasDataSet.CLIENTES)
        'TODO: esta linha de código carrega dados na tabela 'DatabaseVendasDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.VENDASTableAdapter.Fill(Me.DatabaseVendasDataSet.VENDAS)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PRECOUNITTextBox.TextChanged
        CalcularMultiplicacao()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CalcularMultiplicacao()
    End Sub

    Private Sub CalcularMultiplicacao()
        ' Verificar se ambos os campos têm valores válidos
        If IsNumeric(TextBox1.Text) AndAlso IsNumeric(TextBox1.Text) Then
            ' Realizar a multiplicação e exibir o resultado na TextBoxResultado
            Dim valor1 As Double = Convert.ToDouble(PRECOUNITTextBox.Text)
            Dim valor2 As Double = Convert.ToDouble(TextBox1.Text)
            Dim resultado As Double = valor1 * valor2

            TOTAL_PEDIDOTextBox.Text = resultado.ToString()
        Else
            ' Se um dos valores não for numérico, limpar o resultado
            TOTAL_PEDIDOTextBox.Text = ""
        End If
    End Sub





    Private Sub CLIENTE_CPFLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TOTAL_PEDIDOTextBox_TextChanged(sender As Object, e As EventArgs) Handles TOTAL_PEDIDOTextBox.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub valorUnit_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PRODUTOTableAdapter.FillBy(Me.DatabaseVendasDataSet.PRODUTO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PRECOUNITTextBox_TextChanged(sender As Object, e As EventArgs) Handles PRECOUNITTextBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PRECOUNITLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class