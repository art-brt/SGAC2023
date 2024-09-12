Public Class FRMMenu
    Private Sub CarroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarroToolStripMenuItem.Click
        FRMCarros.Show()
    End Sub

    Private Sub CarrosDisponíveisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrosDisponíveisToolStripMenuItem.Click
        FRMDisponiveis.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        FRMCliente.Show()
    End Sub

    Private Sub AluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AluguelToolStripMenuItem.Click
        FRMAluguel.Show()
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FRMFunfa.Show()
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FuncionárioToolStripMenuItem.Click
        FRMFunfa.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        FRMSobre.Show()
    End Sub
End Class
