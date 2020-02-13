<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(385, 231)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(137, 23)
        Me.button7.TabIndex = 15
        Me.button7.Text = "Таблица ""Должности"""
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(385, 159)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(137, 23)
        Me.button6.TabIndex = 14
        Me.button6.Text = "Таблица ""Сотрудники"""
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(61, 159)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(137, 23)
        Me.button5.TabIndex = 13
        Me.button5.Text = "Таблица ""Товары"""
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(61, 231)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(137, 23)
        Me.button4.TabIndex = 12
        Me.button4.Text = "Таблица ""Тип товара"""
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(385, 78)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(137, 23)
        Me.button3.TabIndex = 11
        Me.button3.Text = "Таблица ""Поставщики"""
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(222, 78)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(137, 23)
        Me.button2.TabIndex = 10
        Me.button2.Text = "Таблица ""Склад"""
        Me.button2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(50, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(486, 66)
        Me.label1.TabIndex = 9
        Me.label1.Text = "База данных ""Оптовый склад"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(61, 78)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(137, 23)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Таблица ""Заказчики"""
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 506)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Оптовый склад"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
