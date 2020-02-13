Public Class Товары
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ТоварыBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ТоварыBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ТоварыBindingSource.AddNew()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ТоварыBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ТоварыBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        ТоварыBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.ТоварыBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.FatkDBDataSet)
    End Sub

    Private Sub Товары_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Товары". При необходимости она может быть перемещена или удалена.
        Me.ТоварыTableAdapter.Fill(Me.FatkDBDataSet.Товары)

    End Sub
End Class