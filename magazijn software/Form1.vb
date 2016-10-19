Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item As New ListViewItem(txtgereedschap.Text$)
        item.SubItems.Add(txtnaam.Text)
        item.SubItems.Add(TimeString)
        ListView1.Items.Add(item)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.SelectedIndices.Clear()
    End Sub
End Class
