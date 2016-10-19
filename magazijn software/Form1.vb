Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtgereedschap.Text) = "" And (txtnaam.Text) = "" Then
            MessageBox.Show("Gelieve beide velden in te vullen")
        Else
            Dim item As New ListViewItem(txtgereedschap.Text$)
            item.SubItems.Add(txtnaam.Text)
            item.SubItems.Add(TimeString)
            ListView1.Items.Add(item)

            txtgereedschap.Clear()
            txtnaam.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
