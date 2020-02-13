Public Class Сотрудники
    Private Sub Сотрудники_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.FatkDBDataSet.Должности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Заказчики". При необходимости она может быть перемещена или удалена.
        Me.ЗаказчикиTableAdapter.Fill(Me.FatkDBDataSet.Заказчики)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.FatkDBDataSet.Сотрудники)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        СотрудникиBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        СотрудникиBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        СотрудникиBindingSource.AddNew()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        СотрудникиBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        СотрудникиBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        СотрудникиBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.СотрудникиBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.FatkDBDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ФормаСотрудники.Show()

    End Sub
End Class