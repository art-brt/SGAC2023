Public Class FRMDisponiveis
    Private Sub CONSULTADISPONIVELBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CONSULTADISPONIVELBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CONSULTADISPONIVELBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGAC2024DataSet)

    End Sub

    Private Sub FRMDisponiveis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.CONSULTADISPONIVEL'. Você pode movê-la ou removê-la conforme necessário.
        Me.CONSULTADISPONIVELTableAdapter.Fill(Me.SGAC2024DataSet.CONSULTADISPONIVEL)

    End Sub
End Class