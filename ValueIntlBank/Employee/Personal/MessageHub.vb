Public Class MessageHub
    Private Sub MessageHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VibDataSet.messagehub' table. You can move, or remove it, as needed.
        Me.MessagehubTableAdapter.Fill(Me.VibDataSet.messagehub)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class