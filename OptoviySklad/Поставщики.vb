Public Class Поставщики
    Private Sub Поставщики_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
        Me.ПоставщикиTableAdapter.Fill(Me.FatkDBDataSet.Поставщики)
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ПоставщикиBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ПоставщикиBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ПоставщикиBindingSource.AddNew()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ПоставщикиBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ПоставщикиBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        ПоставщикиBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.ПоставщикиBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.FatkDBDataSet)
    End Sub
End Class