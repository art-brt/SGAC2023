Public Class FRMCarros
    Private Sub CARROSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CARROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGAC2024DataSet)

    End Sub

    Private Sub FRMCarros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGAC2024DataSet.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.SGAC2024DataSet.CARROS)

    End Sub

    Private Sub FABRICANTEComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FABRICANTEComboBox.SelectedIndexChanged

    End Sub

    Private Sub PLACAMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PLACAMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub PLACAMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles PLACAMaskedTextBox.TextChanged
        DISPONIBILIDADETextBox.Text = "Disponível"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub
End Class