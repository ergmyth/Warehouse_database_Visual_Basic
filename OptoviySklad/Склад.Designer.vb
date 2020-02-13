<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Склад
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
        Dim код_товараLabel As System.Windows.Forms.Label
        Dim ценаLabel As System.Windows.Forms.Label
        Dim объемLabel As System.Windows.Forms.Label
        Dim способ_доставкиLabel As System.Windows.Forms.Label
        Dim дата_отправкиLabel As System.Windows.Forms.Label
        Dim дата_заказаLabel As System.Windows.Forms.Label
        Dim дата_поступленияLabel As System.Windows.Forms.Label
        Dim Код_поставщикаLabel As System.Windows.Forms.Label
        Dim Код_заказчикаLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Склад))
        Me.код_товараTextBox = New System.Windows.Forms.TextBox()
        Me.СкладBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatkDBDataSet = New OptoviySklad.FatkDBDataSet()
        Me.ценаTextBox = New System.Windows.Forms.TextBox()
        Me.объемTextBox = New System.Windows.Forms.TextBox()
        Me.способ_доставкиTextBox = New System.Windows.Forms.TextBox()
        Me.дата_отправкиDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.дата_заказаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.дата_поступленияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.label1 = New System.Windows.Forms.Label()
        Me.СкладTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.СкладTableAdapter()
        Me.TableAdapterManager = New OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager()
        Me.Код_поставщикаTextBox = New System.Windows.Forms.TextBox()
        Me.Код_заказчикаTextBox = New System.Windows.Forms.TextBox()
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
        код_товараLabel = New System.Windows.Forms.Label()
        ценаLabel = New System.Windows.Forms.Label()
        объемLabel = New System.Windows.Forms.Label()
        способ_доставкиLabel = New System.Windows.Forms.Label()
        дата_отправкиLabel = New System.Windows.Forms.Label()
        дата_заказаLabel = New System.Windows.Forms.Label()
        дата_поступленияLabel = New System.Windows.Forms.Label()
        Код_поставщикаLabel = New System.Windows.Forms.Label()
        Код_заказчикаLabel = New System.Windows.Forms.Label()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'код_товараLabel
        '
        код_товараLabel.AutoSize = True
        код_товараLabel.Location = New System.Drawing.Point(72, 287)
        код_товараLabel.Name = "код_товараLabel"
        код_товараLabel.Size = New System.Drawing.Size(67, 13)
        код_товараLabel.TabIndex = 29
        код_товараLabel.Text = "Код товара:"
        '
        'ценаLabel
        '
        ценаLabel.AutoSize = True
        ценаLabel.Location = New System.Drawing.Point(72, 261)
        ценаLabel.Name = "ценаLabel"
        ценаLabel.Size = New System.Drawing.Size(36, 13)
        ценаLabel.TabIndex = 27
        ценаLabel.Text = "Цена:"
        '
        'объемLabel
        '
        объемLabel.AutoSize = True
        объемLabel.Location = New System.Drawing.Point(72, 236)
        объемLabel.Name = "объемLabel"
        объемLabel.Size = New System.Drawing.Size(45, 13)
        объемLabel.TabIndex = 25
        объемLabel.Text = "Объем:"
        '
        'способ_доставкиLabel
        '
        способ_доставкиLabel.AutoSize = True
        способ_доставкиLabel.Location = New System.Drawing.Point(72, 202)
        способ_доставкиLabel.Name = "способ_доставкиLabel"
        способ_доставкиLabel.Size = New System.Drawing.Size(136, 13)
        способ_доставкиLabel.TabIndex = 23
        способ_доставкиLabel.Text = "Способ доставки заказа:"
        '
        'дата_отправкиLabel
        '
        дата_отправкиLabel.AutoSize = True
        дата_отправкиLabel.Location = New System.Drawing.Point(72, 166)
        дата_отправкиLabel.Name = "дата_отправкиLabel"
        дата_отправкиLabel.Size = New System.Drawing.Size(125, 13)
        дата_отправкиLabel.TabIndex = 21
        дата_отправкиLabel.Text = "Дата отправки заказа:"
        '
        'дата_заказаLabel
        '
        дата_заказаLabel.AutoSize = True
        дата_заказаLabel.Location = New System.Drawing.Point(72, 132)
        дата_заказаLabel.Name = "дата_заказаLabel"
        дата_заказаLabel.Size = New System.Drawing.Size(142, 13)
        дата_заказаLabel.TabIndex = 18
        дата_заказаLabel.Text = "Дата оформления заказа:"
        '
        'дата_поступленияLabel
        '
        дата_поступленияLabel.AutoSize = True
        дата_поступленияLabel.Location = New System.Drawing.Point(72, 103)
        дата_поступленияLabel.Name = "дата_поступленияLabel"
        дата_поступленияLabel.Size = New System.Drawing.Size(189, 13)
        дата_поступленияLabel.TabIndex = 17
        дата_поступленияLabel.Text = "Дата поступления товара на склад:"
        '
        'Код_поставщикаLabel
        '
        Код_поставщикаLabel.AutoSize = True
        Код_поставщикаLabel.Location = New System.Drawing.Point(72, 313)
        Код_поставщикаLabel.Name = "Код_поставщикаLabel"
        Код_поставщикаLabel.Size = New System.Drawing.Size(94, 13)
        Код_поставщикаLabel.TabIndex = 30
        Код_поставщикаLabel.Text = "Код поставщика:"
        '
        'Код_заказчикаLabel
        '
        Код_заказчикаLabel.AutoSize = True
        Код_заказчикаLabel.Location = New System.Drawing.Point(72, 339)
        Код_заказчикаLabel.Name = "Код_заказчикаLabel"
        Код_заказчикаLabel.Size = New System.Drawing.Size(85, 13)
        Код_заказчикаLabel.TabIndex = 31
        Код_заказчикаLabel.Text = "Код заказчика:"
        '
        'код_товараTextBox
        '
        Me.код_товараTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Код_товара", True))
        Me.код_товараTextBox.Location = New System.Drawing.Point(271, 284)
        Me.код_товараTextBox.Name = "код_товараTextBox"
        Me.код_товараTextBox.Size = New System.Drawing.Size(304, 20)
        Me.код_товараTextBox.TabIndex = 30
        '
        'СкладBindingSource
        '
        Me.СкладBindingSource.DataMember = "Склад"
        Me.СкладBindingSource.DataSource = Me.FatkDBDataSet
        '
        'FatkDBDataSet
        '
        Me.FatkDBDataSet.DataSetName = "FatkDBDataSet"
        Me.FatkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ценаTextBox
        '
        Me.ценаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Цена", True))
        Me.ценаTextBox.Location = New System.Drawing.Point(271, 254)
        Me.ценаTextBox.Name = "ценаTextBox"
        Me.ценаTextBox.Size = New System.Drawing.Size(304, 20)
        Me.ценаTextBox.TabIndex = 28
        '
        'объемTextBox
        '
        Me.объемTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Объем", True))
        Me.объемTextBox.Location = New System.Drawing.Point(271, 229)
        Me.объемTextBox.Name = "объемTextBox"
        Me.объемTextBox.Size = New System.Drawing.Size(304, 20)
        Me.объемTextBox.TabIndex = 26
        '
        'способ_доставкиTextBox
        '
        Me.способ_доставкиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Способ_доставки", True))
        Me.способ_доставкиTextBox.Location = New System.Drawing.Point(271, 199)
        Me.способ_доставкиTextBox.Name = "способ_доставкиTextBox"
        Me.способ_доставкиTextBox.Size = New System.Drawing.Size(304, 20)
        Me.способ_доставкиTextBox.TabIndex = 24
        '
        'дата_отправкиDateTimePicker
        '
        Me.дата_отправкиDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Дата_отправки", True))
        Me.дата_отправкиDateTimePicker.Location = New System.Drawing.Point(271, 166)
        Me.дата_отправкиDateTimePicker.Name = "дата_отправкиDateTimePicker"
        Me.дата_отправкиDateTimePicker.Size = New System.Drawing.Size(304, 20)
        Me.дата_отправкиDateTimePicker.TabIndex = 22
        '
        'дата_заказаDateTimePicker
        '
        Me.дата_заказаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Дата_заказа", True))
        Me.дата_заказаDateTimePicker.Location = New System.Drawing.Point(271, 132)
        Me.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker"
        Me.дата_заказаDateTimePicker.Size = New System.Drawing.Size(304, 20)
        Me.дата_заказаDateTimePicker.TabIndex = 20
        '
        'дата_поступленияDateTimePicker
        '
        Me.дата_поступленияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Дата_поступления", True))
        Me.дата_поступленияDateTimePicker.Location = New System.Drawing.Point(271, 99)
        Me.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker"
        Me.дата_поступленияDateTimePicker.Size = New System.Drawing.Size(304, 20)
        Me.дата_поступленияDateTimePicker.TabIndex = 19
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 39)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(595, 66)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Таблица ""Склад"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'СкладTableAdapter
        '
        Me.СкладTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.ЗаказчикиTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Me.СкладTableAdapter
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.Типы_товаровTableAdapter = Nothing
        Me.TableAdapterManager.ТоварыTableAdapter = Nothing
        '
        'Код_поставщикаTextBox
        '
        Me.Код_поставщикаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Код_поставщика", True))
        Me.Код_поставщикаTextBox.Location = New System.Drawing.Point(271, 310)
        Me.Код_поставщикаTextBox.Name = "Код_поставщикаTextBox"
        Me.Код_поставщикаTextBox.Size = New System.Drawing.Size(304, 20)
        Me.Код_поставщикаTextBox.TabIndex = 31
        '
        'Код_заказчикаTextBox
        '
        Me.Код_заказчикаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "Код_заказчика", True))
        Me.Код_заказчикаTextBox.Location = New System.Drawing.Point(271, 336)
        Me.Код_заказчикаTextBox.Name = "Код_заказчикаTextBox"
        Me.Код_заказчикаTextBox.Size = New System.Drawing.Size(304, 20)
        Me.Код_заказчикаTextBox.TabIndex = 32
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.СкладBindingSource
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(627, 25)
        Me.BindingNavigator1.TabIndex = 33
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
        Me.button7.Location = New System.Drawing.Point(255, 460)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 59
        Me.button7.Text = "Сохранить"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(414, 416)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 23)
        Me.button6.TabIndex = 58
        Me.button6.Text = "Удалить"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(255, 416)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 57
        Me.button5.Text = "Следующая"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(91, 416)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 23)
        Me.button4.TabIndex = 56
        Me.button4.Text = "Последняя"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(414, 373)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 23)
        Me.button3.TabIndex = 55
        Me.button3.Text = "Добавить"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(255, 373)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 23)
        Me.button2.TabIndex = 54
        Me.button2.Text = "Предыдущая"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(91, 373)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 23)
        Me.button1.TabIndex = 53
        Me.button1.Text = "Первая"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Склад
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 506)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Код_заказчикаLabel)
        Me.Controls.Add(Me.Код_заказчикаTextBox)
        Me.Controls.Add(Код_поставщикаLabel)
        Me.Controls.Add(Me.Код_поставщикаTextBox)
        Me.Controls.Add(код_товараLabel)
        Me.Controls.Add(Me.код_товараTextBox)
        Me.Controls.Add(ценаLabel)
        Me.Controls.Add(Me.ценаTextBox)
        Me.Controls.Add(объемLabel)
        Me.Controls.Add(Me.объемTextBox)
        Me.Controls.Add(способ_доставкиLabel)
        Me.Controls.Add(Me.способ_доставкиTextBox)
        Me.Controls.Add(дата_отправкиLabel)
        Me.Controls.Add(Me.дата_отправкиDateTimePicker)
        Me.Controls.Add(дата_заказаLabel)
        Me.Controls.Add(Me.дата_заказаDateTimePicker)
        Me.Controls.Add(дата_поступленияLabel)
        Me.Controls.Add(Me.дата_поступленияDateTimePicker)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Склад"
        Me.Text = "Склад"
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents код_товараTextBox As TextBox
    Private WithEvents ценаTextBox As TextBox
    Private WithEvents объемTextBox As TextBox
    Private WithEvents способ_доставкиTextBox As TextBox
    Private WithEvents дата_отправкиDateTimePicker As DateTimePicker
    Private WithEvents дата_заказаDateTimePicker As DateTimePicker
    Private WithEvents дата_поступленияDateTimePicker As DateTimePicker
    Private WithEvents label1 As Label
    Friend WithEvents FatkDBDataSet As FatkDBDataSet
    Friend WithEvents СкладBindingSource As BindingSource
    Friend WithEvents СкладTableAdapter As FatkDBDataSetTableAdapters.СкладTableAdapter
    Friend WithEvents TableAdapterManager As FatkDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Код_поставщикаTextBox As TextBox
    Friend WithEvents Код_заказчикаTextBox As TextBox
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
End Class
