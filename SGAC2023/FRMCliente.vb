Public Class FRMCliente
    Private Sub CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGAC2024DataSet)

    End Sub

    Private Sub CLIENTESBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGAC2024DataSet)

    End Sub

    Private Sub FRMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTESTableAdapter.Fill(Me.SGAC2024DataSet.CLIENTES)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub
End Class