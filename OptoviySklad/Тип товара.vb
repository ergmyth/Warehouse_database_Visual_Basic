Public Class Тип_товара
    Private Sub Тип_товара_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "FatkDBDataSet.Типы_товаров". При необходимости она может быть перемещена или удалена.
        Me.Типы_товаровTableAdapter.Fill(Me.FatkDBDataSet.Типы_товаров)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ТипыТоваровBindingSource.MoveFirst()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ТипыТоваровBindingSource.MovePrevious()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ТипыТоваровBindingSource.AddNew()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        ТипыТоваровBindingSource.MoveLast()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ТипыТоваровBindingSource.MoveNext()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        ТипыТоваровBindingSource.RemoveCurrent()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Validate()
        Me.ТипыТоваровBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.FatkDBDataSet)
    End Sub
End Class