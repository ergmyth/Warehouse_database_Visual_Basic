<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Сотрудники
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
        Dim код_должностиLabel As System.Windows.Forms.Label
        Dim паспортные_данныеLabel As System.Windows.Forms.Label
        Dim телефонLabel As System.Windows.Forms.Label
        Dim адресLabel As System.Windows.Forms.Label
        Dim полLabel As System.Windows.Forms.Label
        Dim возрастLabel As System.Windows.Forms.Label
        Dim фИОLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Сотрудники))
        Me.код_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.СотрудникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatkDBDataSet = New OptoviySklad.FatkDBDataSet()
        Me.адресTextBox = New System.Windows.Forms.TextBox()
        Me.возрастTextBox = New System.Windows.Forms.TextBox()
        Me.фИОTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.СотрудникиTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.СотрудникиTableAdapter()
        Me.TableAdapterManager1 = New OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.ПолComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ДолжностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗаказчикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗаказчикиTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.ЗаказчикиTableAdapter()
        Me.ДолжностиTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.ДолжностиTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        код_должностиLabel = New System.Windows.Forms.Label()
        паспортные_данныеLabel = New System.Windows.Forms.Label()
        телефонLabel = New System.Windows.Forms.Label()
        адресLabel = New System.Windows.Forms.Label()
        полLabel = New System.Windows.Forms.Label()
        возрастLabel = New System.Windows.Forms.Label()
        фИОLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.СотрудникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ДолжностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗаказчикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'код_должностиLabel
        '
        код_должностиLabel.AutoSize = True
        код_должностиLabel.Location = New System.Drawing.Point(42, 307)
        код_должностиLabel.Name = "код_должностиLabel"
        код_должностиLabel.Size = New System.Drawing.Size(87, 13)
        код_должностиLabel.TabIndex = 35
        код_должностиLabel.Text = "Код должности:"
        '
        'паспортные_данныеLabel
        '
        паспортные_данныеLabel.AutoSize = True
        паспортные_данныеLabel.Location = New System.Drawing.Point(42, 244)
        паспортные_данныеLabel.Name = "паспортные_данныеLabel"
        паспортные_данныеLabel.Size = New System.Drawing.Size(114, 13)
        паспортные_данныеLabel.TabIndex = 33
        паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'телефонLabel
        '
        телефонLabel.AutoSize = True
        телефонLabel.Location = New System.Drawing.Point(42, 276)
        телефонLabel.Name = "телефонLabel"
        телефонLabel.Size = New System.Drawing.Size(55, 13)
        телефонLabel.TabIndex = 31
        телефонLabel.Text = "Телефон:"
        '
        'адресLabel
        '
        адресLabel.AutoSize = True
        адресLabel.Location = New System.Drawing.Point(42, 212)
        адресLabel.Name = "адресLabel"
        адресLabel.Size = New System.Drawing.Size(41, 13)
        адресLabel.TabIndex = 29
        адресLabel.Text = "Адрес:"
        '
        'полLabel
        '
        полLabel.AutoSize = True
        полLabel.Location = New System.Drawing.Point(42, 180)
        полLabel.Name = "полLabel"
        полLabel.Size = New System.Drawing.Size(30, 13)
        полLabel.TabIndex = 27
        полLabel.Text = "Пол:"
        '
        'возрастLabel
        '
        возрастLabel.AutoSize = True
        возрастLabel.Location = New System.Drawing.Point(42, 149)
        возрастLabel.Name = "возрастLabel"
        возрастLabel.Size = New System.Drawing.Size(52, 13)
        возрастLabel.TabIndex = 25
        возрастLabel.Text = "Возраст:"
        '
        'фИОLabel
        '
        фИОLabel.AutoSize = True
        фИОLabel.Location = New System.Drawing.Point(42, 119)
        фИОLabel.Name = "фИОLabel"
        фИОLabel.Size = New System.Drawing.Size(37, 13)
        фИОLabel.TabIndex = 24
        фИОLabel.Text = "ФИО:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(42, 348)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(144, 13)
        Label2.TabIndex = 80
        Label2.Text = "Наименование должности:"
        '
        'код_должностиTextBox
        '
        Me.код_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Код_должности", True))
        Me.код_должностиTextBox.Location = New System.Drawing.Point(224, 307)
        Me.код_должностиTextBox.Name = "код_должностиTextBox"
        Me.код_должностиTextBox.Size = New System.Drawing.Size(309, 20)
        Me.код_должностиTextBox.TabIndex = 37
        '
        'СотрудникиBindingSource
        '
        Me.СотрудникиBindingSource.DataMember = "Сотрудники"
        Me.СотрудникиBindingSource.DataSource = Me.FatkDBDataSet
        '
        'FatkDBDataSet
        '
        Me.FatkDBDataSet.DataSetName = "FatkDBDataSet"
        Me.FatkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'адресTextBox
        '
        Me.адресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Адрес", True))
        Me.адресTextBox.Location = New System.Drawing.Point(224, 209)
        Me.адресTextBox.Name = "адресTextBox"
        Me.адресTextBox.Size = New System.Drawing.Size(309, 20)
        Me.адресTextBox.TabIndex = 32
        '
        'возрастTextBox
        '
        Me.возрастTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Возраст", True))
        Me.возрастTextBox.Location = New System.Drawing.Point(224, 146)
        Me.возрастTextBox.Name = "возрастTextBox"
        Me.возрастTextBox.Size = New System.Drawing.Size(309, 20)
        Me.возрастTextBox.TabIndex = 28
        '
        'фИОTextBox
        '
        Me.фИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "ФИО", True))
        Me.фИОTextBox.Location = New System.Drawing.Point(224, 112)
        Me.фИОTextBox.Name = "фИОTextBox"
        Me.фИОTextBox.Size = New System.Drawing.Size(309, 20)
        Me.фИОTextBox.TabIndex = 26
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 43)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(595, 66)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Таблица ""Сотрудники"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'СотрудникиTableAdapter
        '
        Me.СотрудникиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager1.ЗаказчикиTableAdapter = Nothing
        Me.TableAdapterManager1.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager1.СкладTableAdapter = Nothing
        Me.TableAdapterManager1.СотрудникиTableAdapter = Me.СотрудникиTableAdapter
        Me.TableAdapterManager1.Типы_товаровTableAdapter = Nothing
        Me.TableAdapterManager1.ТоварыTableAdapter = Nothing
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
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
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.СотрудникиBindingSource
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
        Me.BindingNavigator1.TabIndex = 38
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(221, 474)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 52
        Me.button7.Text = "Сохранить"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(380, 430)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 23)
        Me.button6.TabIndex = 51
        Me.button6.Text = "Удалить"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(221, 430)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 50
        Me.button5.Text = "Следующая"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(57, 430)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 23)
        Me.button4.TabIndex = 49
        Me.button4.Text = "Последняя"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(380, 387)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 23)
        Me.button3.TabIndex = 48
        Me.button3.Text = "Добавить"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(221, 387)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 23)
        Me.button2.TabIndex = 47
        Me.button2.Text = "Предыдущая"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(57, 387)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 23)
        Me.button1.TabIndex = 46
        Me.button1.Text = "Первая"
        Me.button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Телефон", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(224, 273)
        Me.MaskedTextBox1.Mask = "+7 (000) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(309, 20)
        Me.MaskedTextBox1.TabIndex = 76
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Паспортные_данные", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(224, 241)
        Me.MaskedTextBox2.Mask = "0000-000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(309, 20)
        Me.MaskedTextBox2.TabIndex = 77
        '
        'ПолComboBox
        '
        Me.ПолComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникиBindingSource, "Пол", True))
        Me.ПолComboBox.FormattingEnabled = True
        Me.ПолComboBox.Items.AddRange(New Object() {"Мужской", "Женский"})
        Me.ПолComboBox.Location = New System.Drawing.Point(224, 177)
        Me.ПолComboBox.Name = "ПолComboBox"
        Me.ПолComboBox.Size = New System.Drawing.Size(309, 21)
        Me.ПолComboBox.TabIndex = 78
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.СотрудникиBindingSource, "Код_должности", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Наименование_должности", True))
        Me.ComboBox1.DataSource = Me.ДолжностиBindingSource
        Me.ComboBox1.DisplayMember = "Наименование_должности"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(224, 345)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(309, 21)
        Me.ComboBox1.TabIndex = 79
        Me.ComboBox1.ValueMember = "Код_должности"
        '
        'ДолжностиBindingSource
        '
        Me.ДолжностиBindingSource.DataMember = "Должности"
        Me.ДолжностиBindingSource.DataSource = Me.FatkDBDataSet
        '
        'ЗаказчикиBindingSource
        '
        Me.ЗаказчикиBindingSource.DataMember = "Заказчики"
        Me.ЗаказчикиBindingSource.DataSource = Me.FatkDBDataSet
        '
        'ЗаказчикиTableAdapter
        '
        Me.ЗаказчикиTableAdapter.ClearBeforeFill = True
        '
        'ДолжностиTableAdapter
        '
        Me.ДолжностиTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(57, 474)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(145, 23)
        Me.Button8.TabIndex = 81
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Сотрудники
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 506)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ПолComboBox)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(код_должностиLabel)
        Me.Controls.Add(Me.код_должностиTextBox)
        Me.Controls.Add(паспортные_данныеLabel)
        Me.Controls.Add(телефонLabel)
        Me.Controls.Add(адресLabel)
        Me.Controls.Add(Me.адресTextBox)
        Me.Controls.Add(полLabel)
        Me.Controls.Add(возрастLabel)
        Me.Controls.Add(Me.возрастTextBox)
        Me.Controls.Add(фИОLabel)
        Me.Controls.Add(Me.фИОTextBox)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Сотрудники"
        Me.Text = "Сотрудники"
        CType(Me.СотрудникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ДолжностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗаказчикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents код_должностиTextBox As TextBox
    Private WithEvents адресTextBox As TextBox
    Private WithEvents возрастTextBox As TextBox
    Private WithEvents фИОTextBox As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents FatkDBDataSet As FatkDBDataSet
    Friend WithEvents СотрудникиBindingSource As BindingSource
    Friend WithEvents СотрудникиTableAdapter As FatkDBDataSetTableAdapters.СотрудникиTableAdapter
    Friend WithEvents TableAdapterManager1 As FatkDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents ПолComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ЗаказчикиBindingSource As BindingSource
    Friend WithEvents ЗаказчикиTableAdapter As FatkDBDataSetTableAdapters.ЗаказчикиTableAdapter
    Friend WithEvents ДолжностиBindingSource As BindingSource
    Friend WithEvents ДолжностиTableAdapter As FatkDBDataSetTableAdapters.ДолжностиTableAdapter
    Private WithEvents Button8 As Button
End Class
