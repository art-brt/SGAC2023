Public Class FRMAluguel
    Private Sub ALUGUELBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALUGUELBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUGUELBindingSource.EndEdit()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGAC2024DataSet)

    End Sub

    Private Sub FRMAluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.SGAC2024DataSet.CARROS)
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTESTableAdapter.Fill(Me.SGAC2024DataSet.CLIENTES)
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.FUNCIONARIOSTableAdapter.Fill(Me.SGAC2024DataSet.FUNCIONARIOS)
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.ALUGUEL'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUGUELTableAdapter.Fill(Me.SGAC2024DataSet.ALUGUEL)

    End Sub

    Private Sub ENTREGAComboBox_Leave(sender As Object, e As EventArgs) Handles ENTREGAComboBox.Leave
        If ENTREGAComboBox.Text = "Não" Then
            DISPONIBILIDADETextBox.Text = "Indisponível"
        End If
        If ENTREGAComboBox.Text = "Sim" Then
            DISPONIBILIDADETextBox.Text = "Disponível"
        End If

    End Sub

    Private Sub PLACAComboBox_Leave(sender As Object, e As EventArgs) Handles PLACAComboBox.Leave
        If DISPONIBILIDADETextBox.Text = "Indisponível" Then
            MsgBox("Este carro não está disponível. Escolha outro")
            PLACAComboBox.Focus()
        End If
    End Sub
End Class