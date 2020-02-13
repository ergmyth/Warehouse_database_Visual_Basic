<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Товары
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
        Dim код_типаLabel As System.Windows.Forms.Label
        Dim срок_годностиLabel As System.Windows.Forms.Label
        Dim упаковкаLabel As System.Windows.Forms.Label
        Dim условия_храненияLabel As System.Windows.Forms.Label
        Dim наименованиеLabel As System.Windows.Forms.Label
        Dim производительLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Товары))
        Me.код_типаTextBox = New System.Windows.Forms.TextBox()
        Me.ТоварыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatkDBDataSet = New OptoviySklad.FatkDBDataSet()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.срок_годностиTextBox = New System.Windows.Forms.TextBox()
        Me.упаковкаTextBox = New System.Windows.Forms.TextBox()
        Me.условия_храненияTextBox = New System.Windows.Forms.TextBox()
        Me.наименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.производительTextBox = New System.Windows.Forms.TextBox()
        Me.ТоварыTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.ТоварыTableAdapter()
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
        Me.TableAdapterManager1 = New OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager()
        код_типаLabel = New System.Windows.Forms.Label()
        срок_годностиLabel = New System.Windows.Forms.Label()
        упаковкаLabel = New System.Windows.Forms.Label()
        условия_храненияLabel = New System.Windows.Forms.Label()
        наименованиеLabel = New System.Windows.Forms.Label()
        производительLabel = New System.Windows.Forms.Label()
        CType(Me.ТоварыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'код_типаLabel
        '
        код_типаLabel.AutoSize = True
        код_типаLabel.Location = New System.Drawing.Point(61, 140)
        код_типаLabel.Name = "код_типаLabel"
        код_типаLabel.Size = New System.Drawing.Size(55, 13)
        код_типаLabel.TabIndex = 39
        код_типаLabel.Text = "Код типа:"
        '
        'срок_годностиLabel
        '
        срок_годностиLabel.AutoSize = True
        срок_годностиLabel.Location = New System.Drawing.Point(61, 223)
        срок_годностиLabel.Name = "срок_годностиLabel"
        срок_годностиLabel.Size = New System.Drawing.Size(84, 13)
        срок_годностиLabel.TabIndex = 29
        срок_годностиLabel.Text = "Срок годности:"
        '
        'упаковкаLabel
        '
        упаковкаLabel.AutoSize = True
        упаковкаLabel.Location = New System.Drawing.Point(61, 284)
        упаковкаLabel.Name = "упаковкаLabel"
        упаковкаLabel.Size = New System.Drawing.Size(60, 13)
        упаковкаLabel.TabIndex = 27
        упаковкаLabel.Text = "Упаковка:"
        '
        'условия_храненияLabel
        '
        условия_храненияLabel.AutoSize = True
        условия_храненияLabel.Location = New System.Drawing.Point(61, 254)
        условия_храненияLabel.Name = "условия_храненияLabel"
        условия_храненияLabel.Size = New System.Drawing.Size(104, 13)
        условия_храненияLabel.TabIndex = 25
        условия_храненияLabel.Text = "Условия хранения:"
        '
        'наименованиеLabel
        '
        наименованиеLabel.AutoSize = True
        наименованиеLabel.Location = New System.Drawing.Point(61, 162)
        наименованиеLabel.Name = "наименованиеLabel"
        наименованиеLabel.Size = New System.Drawing.Size(86, 13)
        наименованиеLabel.TabIndex = 23
        наименованиеLabel.Text = "Наименование:"
        '
        'производительLabel
        '
        производительLabel.AutoSize = True
        производительLabel.Location = New System.Drawing.Point(61, 194)
        производительLabel.Name = "производительLabel"
        производительLabel.Size = New System.Drawing.Size(89, 13)
        производительLabel.TabIndex = 21
        производительLabel.Text = "Производитель:"
        '
        'код_типаTextBox
        '
        Me.код_типаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТоварыBindingSource, "Код_типа", True))
        Me.код_типаTextBox.Location = New System.Drawing.Point(253, 136)
        Me.код_типаTextBox.Name = "код_типаTextBox"
        Me.код_типаTextBox.Size = New System.Drawing.Size(279, 20)
        Me.код_типаTextBox.TabIndex = 40
        '
        'ТоварыBindingSource
        '
        Me.ТоварыBindingSource.DataMember = "Товары"
        Me.ТоварыBindingSource.DataSource = Me.FatkDBDataSet
        '
        'FatkDBDataSet
        '
        Me.FatkDBDataSet.DataSetName = "FatkDBDataSet"
        Me.FatkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(228, 396)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 38
        Me.button7.Text = "Сохранить"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(387, 352)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 23)
        Me.button6.TabIndex = 37
        Me.button6.Text = "Удалить"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(228, 352)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 36
        Me.button5.Text = "Следующая"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(64, 352)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 23)
        Me.button4.TabIndex = 35
        Me.button4.Text = "Последняя"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(387, 309)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 23)
        Me.button3.TabIndex = 34
        Me.button3.Text = "Добавить"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(228, 309)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 23)
        Me.button2.TabIndex = 33
        Me.button2.Text = "Предыдущая"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(64, 309)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 23)
        Me.button1.TabIndex = 32
        Me.button1.Text = "Первая"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(595, 59)
        Me.label1.TabIndex = 31
        Me.label1.Text = "Таблица ""Товары"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'срок_годностиTextBox
        '
        Me.срок_годностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТоварыBindingSource, "Производитель", True))
        Me.срок_годностиTextBox.Location = New System.Drawing.Point(253, 191)
        Me.срок_годностиTextBox.Name = "срок_годностиTextBox"
        Me.срок_годностиTextBox.Size = New System.Drawing.Size(279, 20)
        Me.срок_годностиTextBox.TabIndex = 30
        '
        'упаковкаTextBox
        '
        Me.упаковкаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТоварыBindingSource, "Упаковка", True))
        Me.упаковкаTextBox.Location = New System.Drawing.Point(253, 281)
        Me.упаковкаTextBox.Name = "упаковкаTextBox"
        Me.упаковкаTextBox.Size = New System.Drawing.Size(279, 20)
        Me.упаковкаTextBox.TabIndex = 28
        '
        'условия_храненияTextBox
        '
        Me.условия_храненияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТоварыBindingSource, "Условия_хранения", True))
        Me.условия_храненияTextBox.Location = New System.Drawing.Point(253, 247)
        Me.условия_храненияTextBox.Name = "условия_храненияTextBox"
        Me.условия_храненияTextBox.Size = New System.Drawing.Size(279, 20)
        Me.условия_храненияTextBox.TabIndex = 26
        '
        'наименованиеTextBox
        '
        Me.наименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТоварыBindingSource, "Срок_годности", True))
        Me.наименованиеTextBox.Location = New System.Drawing.Point(253, 216)
        Me.наименованиеTextBox.Name = "наименованиеTextBox"
        Me.наименованиеTextBox.Size = New System.Drawing.Size(279, 20)
        Me.наименованиеTextBox.TabIndex = 24
        '
        'производительTextBox
        '
        Me.производительTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТоварыBindingSource, "Наименование", True))
        Me.производительTextBox.Location = New System.Drawing.Point(253, 162)
        Me.производительTextBox.Name = "производительTextBox"
        Me.производительTextBox.Size = New System.Drawing.Size(279, 20)
        Me.производительTextBox.TabIndex = 22
        '
        'ТоварыTableAdapter
        '
        Me.ТоварыTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ТоварыBindingSource
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
        Me.BindingNavigator1.TabIndex = 41
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager1.ЗаказчикиTableAdapter = Nothing
        Me.TableAdapterManager1.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager1.СкладTableAdapter = Nothing
        Me.TableAdapterManager1.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager1.Типы_товаровTableAdapter = Nothing
        Me.TableAdapterManager1.ТоварыTableAdapter = Me.ТоварыTableAdapter
        '
        'Товары
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 506)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(код_типаLabel)
        Me.Controls.Add(Me.код_типаTextBox)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(срок_годностиLabel)
        Me.Controls.Add(Me.срок_годностиTextBox)
        Me.Controls.Add(упаковкаLabel)
        Me.Controls.Add(Me.упаковкаTextBox)
        Me.Controls.Add(условия_храненияLabel)
        Me.Controls.Add(Me.условия_храненияTextBox)
        Me.Controls.Add(наименованиеLabel)
        Me.Controls.Add(Me.наименованиеTextBox)
        Me.Controls.Add(производительLabel)
        Me.Controls.Add(Me.производительTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Товары"
        Me.Text = "Товары"
        CType(Me.ТоварыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents код_типаTextBox As TextBox
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents label1 As Label
    Private WithEvents срок_годностиTextBox As TextBox
    Private WithEvents упаковкаTextBox As TextBox
    Private WithEvents условия_храненияTextBox As TextBox
    Private WithEvents наименованиеTextBox As TextBox
    Private WithEvents производительTextBox As TextBox
    Friend WithEvents FatkDBDataSet As FatkDBDataSet
    Friend WithEvents ТоварыBindingSource As BindingSource
    Friend WithEvents ТоварыTableAdapter As FatkDBDataSetTableAdapters.ТоварыTableAdapter
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
    Friend WithEvents TableAdapterManager1 As FatkDBDataSetTableAdapters.TableAdapterManager
End Class
