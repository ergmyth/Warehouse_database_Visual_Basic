<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Поставщики
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
        Me.components = New System.ComponentModel.Container()
        Dim код_поставляемого_товара_3Label As System.Windows.Forms.Label
        Dim код_поставляемого_товара_2Label As System.Windows.Forms.Label
        Dim код_поставляемого_товара_1Label As System.Windows.Forms.Label
        Dim телефонLabel As System.Windows.Forms.Label
        Dim адресLabel As System.Windows.Forms.Label
        Dim наименованиеLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Поставщики))
        Me.код_поставляемого_товара_3TextBox = New System.Windows.Forms.TextBox()
        Me.ПоставщикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatkDBDataSet = New OptoviySklad.FatkDBDataSet()
        Me.код_поставляемого_товара_2TextBox = New System.Windows.Forms.TextBox()
        Me.код_поставляемого_товара_1TextBox = New System.Windows.Forms.TextBox()
        Me.адресTextBox = New System.Windows.Forms.TextBox()
        Me.наименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ПоставщикиTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.ПоставщикиTableAdapter()
        Me.TableAdapterManager1 = New OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        код_поставляемого_товара_3Label = New System.Windows.Forms.Label()
        код_поставляемого_товара_2Label = New System.Windows.Forms.Label()
        код_поставляемого_товара_1Label = New System.Windows.Forms.Label()
        телефонLabel = New System.Windows.Forms.Label()
        адресLabel = New System.Windows.Forms.Label()
        наименованиеLabel = New System.Windows.Forms.Label()
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'код_поставляемого_товара_3Label
        '
        код_поставляемого_товара_3Label.AutoSize = True
        код_поставляемого_товара_3Label.Location = New System.Drawing.Point(56, 290)
        код_поставляемого_товара_3Label.Name = "код_поставляемого_товара_3Label"
        код_поставляемого_товара_3Label.Size = New System.Drawing.Size(157, 13)
        код_поставляемого_товара_3Label.TabIndex = 33
        код_поставляемого_товара_3Label.Text = "Код поставляемого товара 3:"
        '
        'код_поставляемого_товара_2Label
        '
        код_поставляемого_товара_2Label.AutoSize = True
        код_поставляемого_товара_2Label.Location = New System.Drawing.Point(56, 249)
        код_поставляемого_товара_2Label.Name = "код_поставляемого_товара_2Label"
        код_поставляемого_товара_2Label.Size = New System.Drawing.Size(157, 13)
        код_поставляемого_товара_2Label.TabIndex = 31
        код_поставляемого_товара_2Label.Text = "Код поставляемого товара 2:"
        '
        'код_поставляемого_товара_1Label
        '
        код_поставляемого_товара_1Label.AutoSize = True
        код_поставляемого_товара_1Label.Location = New System.Drawing.Point(56, 209)
        код_поставляемого_товара_1Label.Name = "код_поставляемого_товара_1Label"
        код_поставляемого_товара_1Label.Size = New System.Drawing.Size(157, 13)
        код_поставляемого_товара_1Label.TabIndex = 29
        код_поставляемого_товара_1Label.Text = "Код поставляемого товара 1:"
        '
        'телефонLabel
        '
        телефонLabel.AutoSize = True
        телефонLabel.Location = New System.Drawing.Point(56, 173)
        телефонLabel.Name = "телефонLabel"
        телефонLabel.Size = New System.Drawing.Size(55, 13)
        телефонLabel.TabIndex = 27
        телефонLabel.Text = "Телефон:"
        '
        'адресLabel
        '
        адресLabel.AutoSize = True
        адресLabel.Location = New System.Drawing.Point(56, 328)
        адресLabel.Name = "адресLabel"
        адресLabel.Size = New System.Drawing.Size(41, 13)
        адресLabel.TabIndex = 25
        адресLabel.Text = "Адрес:"
        '
        'наименованиеLabel
        '
        наименованиеLabel.AutoSize = True
        наименованиеLabel.Location = New System.Drawing.Point(56, 133)
        наименованиеLabel.Name = "наименованиеLabel"
        наименованиеLabel.Size = New System.Drawing.Size(86, 13)
        наименованиеLabel.TabIndex = 24
        наименованиеLabel.Text = "Наименование:"
        '
        'код_поставляемого_товара_3TextBox
        '
        Me.код_поставляемого_товара_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПоставщикиBindingSource, "Код_поставляемого_товара_3", True))
        Me.код_поставляемого_товара_3TextBox.Location = New System.Drawing.Point(235, 283)
        Me.код_поставляемого_товара_3TextBox.Name = "код_поставляемого_товара_3TextBox"
        Me.код_поставляемого_товара_3TextBox.Size = New System.Drawing.Size(313, 20)
        Me.код_поставляемого_товара_3TextBox.TabIndex = 35
        '
        'ПоставщикиBindingSource
        '
        Me.ПоставщикиBindingSource.DataMember = "Поставщики"
        Me.ПоставщикиBindingSource.DataSource = Me.FatkDBDataSet
        '
        'FatkDBDataSet
        '
        Me.FatkDBDataSet.DataSetName = "FatkDBDataSet"
        Me.FatkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'код_поставляемого_товара_2TextBox
        '
        Me.код_поставляемого_товара_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПоставщикиBindingSource, "Код_поставляемого_товара_2", True))
        Me.код_поставляемого_товара_2TextBox.Location = New System.Drawing.Point(235, 242)
        Me.код_поставляемого_товара_2TextBox.Name = "код_поставляемого_товара_2TextBox"
        Me.код_поставляемого_товара_2TextBox.Size = New System.Drawing.Size(313, 20)
        Me.код_поставляемого_товара_2TextBox.TabIndex = 34
        '
        'код_поставляемого_товара_1TextBox
        '
        Me.код_поставляемого_товара_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПоставщикиBindingSource, "Код_поставляемого_товара_1", True))
        Me.код_поставляемого_товара_1TextBox.Location = New System.Drawing.Point(235, 206)
        Me.код_поставляемого_товара_1TextBox.Name = "код_поставляемого_товара_1TextBox"
        Me.код_поставляемого_товара_1TextBox.Size = New System.Drawing.Size(313, 20)
        Me.код_поставляемого_товара_1TextBox.TabIndex = 32
        '
        'адресTextBox
        '
        Me.адресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПоставщикиBindingSource, "Адрес", True))
        Me.адресTextBox.Location = New System.Drawing.Point(235, 325)
        Me.адресTextBox.Name = "адресTextBox"
        Me.адресTextBox.Size = New System.Drawing.Size(313, 20)
        Me.адресTextBox.TabIndex = 28
        '
        'наименованиеTextBox
        '
        Me.наименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПоставщикиBindingSource, "Наименование", True))
        Me.наименованиеTextBox.Location = New System.Drawing.Point(235, 130)
        Me.наименованиеTextBox.Name = "наименованиеTextBox"
        Me.наименованиеTextBox.Size = New System.Drawing.Size(313, 20)
        Me.наименованиеTextBox.TabIndex = 26
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(595, 66)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Таблица ""Поставщики"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ПоставщикиTableAdapter
        '
        Me.ПоставщикиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager1.ЗаказчикиTableAdapter = Nothing
        Me.TableAdapterManager1.ПоставщикиTableAdapter = Me.ПоставщикиTableAdapter
        Me.TableAdapterManager1.СкладTableAdapter = Nothing
        Me.TableAdapterManager1.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager1.Типы_товаровTableAdapter = Nothing
        Me.TableAdapterManager1.ТоварыTableAdapter = Nothing
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ПоставщикиBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(619, 25)
        Me.BindingNavigator1.TabIndex = 36
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(235, 441)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 66
        Me.button7.Text = "Сохранить"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(394, 397)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 23)
        Me.button6.TabIndex = 65
        Me.button6.Text = "Удалить"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(235, 397)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 64
        Me.button5.Text = "Следующая"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(71, 397)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 23)
        Me.button4.TabIndex = 63
        Me.button4.Text = "Последняя"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(394, 354)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 23)
        Me.button3.TabIndex = 62
        Me.button3.Text = "Добавить"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(235, 354)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 23)
        Me.button2.TabIndex = 61
        Me.button2.Text = "Предыдущая"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(71, 354)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 23)
        Me.button1.TabIndex = 60
        Me.button1.Text = "Первая"
        Me.button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПоставщикиBindingSource, "Телефон", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(235, 166)
        Me.MaskedTextBox1.Mask = "+7 (000) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(313, 20)
        Me.MaskedTextBox1.TabIndex = 75
        '
        'Поставщики
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 506)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(код_поставляемого_товара_3Label)
        Me.Controls.Add(Me.код_поставляемого_товара_3TextBox)
        Me.Controls.Add(код_поставляемого_товара_2Label)
        Me.Controls.Add(Me.код_поставляемого_товара_2TextBox)
        Me.Controls.Add(код_поставляемого_товара_1Label)
        Me.Controls.Add(Me.код_поставляемого_товара_1TextBox)
        Me.Controls.Add(телефонLabel)
        Me.Controls.Add(адресLabel)
        Me.Controls.Add(Me.адресTextBox)
        Me.Controls.Add(наименованиеLabel)
        Me.Controls.Add(Me.наименованиеTextBox)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Поставщики"
        Me.Text = "Поставщики"
        CType(Me.ПоставщикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents код_поставляемого_товара_3TextBox As TextBox
    Private WithEvents код_поставляемого_товара_2TextBox As TextBox
    Private WithEvents код_поставляемого_товара_1TextBox As TextBox
    Private WithEvents адресTextBox As TextBox
    Private WithEvents наименованиеTextBox As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents FatkDBDataSet As FatkDBDataSet
    Friend WithEvents ПоставщикиBindingSource As BindingSource
    Friend WithEvents ПоставщикиTableAdapter As FatkDBDataSetTableAdapters.ПоставщикиTableAdapter
    Friend WithEvents TableAdapterManager1 As FatkDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
