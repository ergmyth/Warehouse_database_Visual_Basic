Public Class Заказчики
    Private Sub Заказчики_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Заказчики". При необходимости она может быть перемещена или удалена.
        Me.ЗаказчикиTableAdapter.Fill(Me.FatkDBDataSet.Заказчики)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ЗаказчикиBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ЗаказчикиBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ЗаказчикиBindingSource.AddNew()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ЗаказчикиBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ЗаказчикиBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        ЗаказчикиBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.ЗаказчикиBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.FatkDBDataSet)
    End Sub
End Class