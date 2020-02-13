Public Class Должности
    Private Sub Должности_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.FatkDBDataSet.Должности)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ДолжностиBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ДолжностиBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ДолжностиBindingSource.AddNew()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ДолжностиBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ДолжностиBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        ДолжностиBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.ДолжностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FatkDBDataSet)
    End Sub
End Class