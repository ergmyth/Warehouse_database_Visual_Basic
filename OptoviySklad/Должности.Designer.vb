<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Должности
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
        Dim наименование_должностиLabel As System.Windows.Forms.Label
        Dim окладLabel As System.Windows.Forms.Label
        Dim обязанностиLabel As System.Windows.Forms.Label
        Dim требованияLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Должности))
        Me.label1 = New System.Windows.Forms.Label()
        Me.FatkDBDataSet = New OptoviySklad.FatkDBDataSet()
        Me.ДолжностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ДолжностиTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.ДолжностиTableAdapter()
        Me.TableAdapterManager = New OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager()
        Me.наименование_должностиTextBox = New System.Windows.Forms.TextBox()
        Me.окладTextBox = New System.Windows.Forms.TextBox()
        Me.обязанностиTextBox = New System.Windows.Forms.TextBox()
        Me.требованияTextBox = New System.Windows.Forms.TextBox()
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
        наименование_должностиLabel = New System.Windows.Forms.Label()
        окладLabel = New System.Windows.Forms.Label()
        обязанностиLabel = New System.Windows.Forms.Label()
        требованияLabel = New System.Windows.Forms.Label()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДолжностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'наименование_должностиLabel
        '
        наименование_должностиLabel.AutoSize = True
        наименование_должностиLabel.Location = New System.Drawing.Point(55, 135)
        наименование_должностиLabel.Name = "наименование_должностиLabel"
        наименование_должностиLabel.Size = New System.Drawing.Size(144, 13)
        наименование_должностиLabel.TabIndex = 20
        наименование_должностиLabel.Text = "Наименование должности:"
        '
        'окладLabel
        '
        окладLabel.AutoSize = True
        окладLabel.Location = New System.Drawing.Point(55, 174)
        окладLabel.Name = "окладLabel"
        окладLabel.Size = New System.Drawing.Size(42, 13)
        окладLabel.TabIndex = 21
        окладLabel.Text = "Оклад:"
        '
        'обязанностиLabel
        '
        обязанностиLabel.AutoSize = True
        обязанностиLabel.Location = New System.Drawing.Point(55, 214)
        обязанностиLabel.Name = "обязанностиLabel"
        обязанностиLabel.Size = New System.Drawing.Size(77, 13)
        обязанностиLabel.TabIndex = 23
        обязанностиLabel.Text = "Обязанности:"
        '
        'требованияLabel
        '
        требованияLabel.AutoSize = True
        требованияLabel.Location = New System.Drawing.Point(55, 255)
        требованияLabel.Name = "требованияLabel"
        требованияLabel.Size = New System.Drawing.Size(71, 13)
        требованияLabel.TabIndex = 25
        требованияLabel.Text = "Требования:"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(595, 66)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Таблица ""Должности"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FatkDBDataSet
        '
        Me.FatkDBDataSet.DataSetName = "FatkDBDataSet"
        Me.FatkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ДолжностиBindingSource
        '
        Me.ДолжностиBindingSource.DataMember = "Должности"
        Me.ДолжностиBindingSource.DataSource = Me.FatkDBDataSet
        '
        'ДолжностиTableAdapter
        '
        Me.ДолжностиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = OptoviySklad.FatkDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ДолжностиTableAdapter = Me.ДолжностиTableAdapter
        Me.TableAdapterManager.ЗаказчикиTableAdapter = Nothing
        Me.TableAdapterManager.ПоставщикиTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.Типы_товаровTableAdapter = Nothing
        Me.TableAdapterManager.ТоварыTableAdapter = Nothing
        '
        'наименование_должностиTextBox
        '
        Me.наименование_должностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Наименование_должности", True))
        Me.наименование_должностиTextBox.Location = New System.Drawing.Point(255, 132)
        Me.наименование_должностиTextBox.Name = "наименование_должностиTextBox"
        Me.наименование_должностиTextBox.Size = New System.Drawing.Size(320, 20)
        Me.наименование_должностиTextBox.TabIndex = 22
        '
        'окладTextBox
        '
        Me.окладTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Оклад", True))
        Me.окладTextBox.Location = New System.Drawing.Point(255, 174)
        Me.окладTextBox.Name = "окладTextBox"
        Me.окладTextBox.Size = New System.Drawing.Size(320, 20)
        Me.окладTextBox.TabIndex = 24
        '
        'обязанностиTextBox
        '
        Me.обязанностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Обязанности", True))
        Me.обязанностиTextBox.Location = New System.Drawing.Point(255, 214)
        Me.обязанностиTextBox.Name = "обязанностиTextBox"
        Me.обязанностиTextBox.Size = New System.Drawing.Size(320, 20)
        Me.обязанностиTextBox.TabIndex = 26
        '
        'требованияTextBox
        '
        Me.требованияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДолжностиBindingSource, "Требования", True))
        Me.требованияTextBox.Location = New System.Drawing.Point(255, 255)
        Me.требованияTextBox.Name = "требованияTextBox"
        Me.требованияTextBox.Size = New System.Drawing.Size(320, 20)
        Me.требованияTextBox.TabIndex = 27
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ДолжностиBindingSource
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
        Me.BindingNavigator1.TabIndex = 28
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
        Me.button7.Location = New System.Drawing.Point(244, 382)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 80
        Me.button7.Text = "Сохранить"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(403, 338)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 23)
        Me.button6.TabIndex = 79
        Me.button6.Text = "Удалить"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(244, 338)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 78
        Me.button5.Text = "Следующая"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(80, 338)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 23)
        Me.button4.TabIndex = 77
        Me.button4.Text = "Последняя"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(403, 295)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 23)
        Me.button3.TabIndex = 76
        Me.button3.Text = "Добавить"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(244, 295)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 23)
        Me.button2.TabIndex = 75
        Me.button2.Text = "Предыдущая"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(80, 295)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 23)
        Me.button1.TabIndex = 74
        Me.button1.Text = "Первая"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Должности
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 533)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(требованияLabel)
        Me.Controls.Add(Me.требованияTextBox)
        Me.Controls.Add(обязанностиLabel)
        Me.Controls.Add(Me.обязанностиTextBox)
        Me.Controls.Add(окладLabel)
        Me.Controls.Add(Me.окладTextBox)
        Me.Controls.Add(наименование_должностиLabel)
        Me.Controls.Add(Me.наименование_должностиTextBox)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Должности"
        Me.Text = "Должности"
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДолжностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As Label
    Friend WithEvents FatkDBDataSet As FatkDBDataSet
    Friend WithEvents ДолжностиBindingSource As BindingSource
    Friend WithEvents ДолжностиTableAdapter As FatkDBDataSetTableAdapters.ДолжностиTableAdapter
    Friend WithEvents TableAdapterManager As FatkDBDataSetTableAdapters.TableAdapterManager
    Private WithEvents наименование_должностиTextBox As TextBox
    Private WithEvents окладTextBox As TextBox
    Private WithEvents обязанностиTextBox As TextBox
    Private WithEvents требованияTextBox As TextBox
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
