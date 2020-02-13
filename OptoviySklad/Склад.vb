Public Class Склад
    Private Sub Склад_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Склад". При необходимости она может быть перемещена или удалена.
        Me.СкладTableAdapter.Fill(Me.FatkDBDataSet.Склад)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        СкладBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        СкладBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        СкладBindingSource.AddNew()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        СкладBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        СкладBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        СкладBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.СкладBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FatkDBDataSet)
    End Sub
End Class