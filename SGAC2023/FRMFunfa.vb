Public Class FRMFunfa
    Private Sub FUNCIONARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FUNCIONARIOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FUNCIONARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGAC2024DataSet)

    End Sub

    Private Sub FRMFunfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.FUNCIONARIOSTableAdapter.Fill(Me.SGAC2024DataSet.FUNCIONARIOS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub
End Class