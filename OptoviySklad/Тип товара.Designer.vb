<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Тип_товара
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
        Dim особенностиLabel As System.Windows.Forms.Label
        Dim описаниеLabel As System.Windows.Forms.Label
        Dim наименованиеLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Тип_товара))
        Me.особенностиTextBox = New System.Windows.Forms.TextBox()
        Me.ТипыТоваровBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatkDBDataSet = New OptoviySklad.FatkDBDataSet()
        Me.описаниеTextBox = New System.Windows.Forms.TextBox()
        Me.наименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Типы_товаровTableAdapter = New OptoviySklad.FatkDBDataSetTableAdapters.Типы_товаровTableAdapter()
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
        особенностиLabel = New System.Windows.Forms.Label()
        описаниеLabel = New System.Windows.Forms.Label()
        наименованиеLabel = New System.Windows.Forms.Label()
        CType(Me.ТипыТоваровBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'особенностиLabel
        '
        особенностиLabel.AutoSize = True
        особенностиLabel.Location = New System.Drawing.Point(91, 223)
        особенностиLabel.Name = "особенностиLabel"
        особенностиLabel.Size = New System.Drawing.Size(77, 13)
        особенностиLabel.TabIndex = 21
        особенностиLabel.Text = "Особенности:"
        '
        'описаниеLabel
        '
        описаниеLabel.AutoSize = True
        описаниеLabel.Location = New System.Drawing.Point(91, 176)
        описаниеLabel.Name = "описаниеLabel"
        описаниеLabel.Size = New System.Drawing.Size(60, 13)
        описаниеLabel.TabIndex = 19
        описаниеLabel.Text = "Описание:"
        '
        'наименованиеLabel
        '
        наименованиеLabel.AutoSize = True
        наименованиеLabel.Location = New System.Drawing.Point(91, 134)
        наименованиеLabel.Name = "наименованиеLabel"
        наименованиеLabel.Size = New System.Drawing.Size(86, 13)
        наименованиеLabel.TabIndex = 18
        наименованиеLabel.Text = "Наименование:"
        '
        'особенностиTextBox
        '
        Me.особенностиTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТипыТоваровBindingSource, "Особенности", True))
        Me.особенностиTextBox.Location = New System.Drawing.Point(260, 220)
        Me.особенностиTextBox.Name = "особенностиTextBox"
        Me.особенностиTextBox.Size = New System.Drawing.Size(286, 20)
        Me.особенностиTextBox.TabIndex = 23
        '
        'ТипыТоваровBindingSource
        '
        Me.ТипыТоваровBindingSource.DataMember = "Типы товаров"
        Me.ТипыТоваровBindingSource.DataSource = Me.FatkDBDataSet
        '
        'FatkDBDataSet
        '
        Me.FatkDBDataSet.DataSetName = "FatkDBDataSet"
        Me.FatkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'описаниеTextBox
        '
        Me.описаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТипыТоваровBindingSource, "Описание", True))
        Me.описаниеTextBox.Location = New System.Drawing.Point(260, 176)
        Me.описаниеTextBox.Name = "описаниеTextBox"
        Me.описаниеTextBox.Size = New System.Drawing.Size(286, 20)
        Me.описаниеTextBox.TabIndex = 22
        '
        'наименованиеTextBox
        '
        Me.наименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТипыТоваровBindingSource, "Наименование", True))
        Me.наименованиеTextBox.Location = New System.Drawing.Point(260, 134)
        Me.наименованиеTextBox.Name = "наименованиеTextBox"
        Me.наименованиеTextBox.Size = New System.Drawing.Size(286, 20)
        Me.наименованиеTextBox.TabIndex = 20
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(595, 66)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Таблица ""Тип товара"""
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Типы_товаровTableAdapter
        '
        Me.Типы_товаровTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager1.Типы_товаровTableAdapter = Me.Типы_товаровTableAdapter
        Me.TableAdapterManager1.ТоварыTableAdapter = Nothing
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ТипыТоваровBindingSource
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
        Me.BindingNavigator1.TabIndex = 24
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
        Me.button7.Location = New System.Drawing.Point(246, 361)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(145, 23)
        Me.button7.TabIndex = 45
        Me.button7.Text = "Сохранить"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(405, 317)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(145, 23)
        Me.button6.TabIndex = 44
        Me.button6.Text = "Удалить"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(246, 317)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(145, 23)
        Me.button5.TabIndex = 43
        Me.button5.Text = "Следующая"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(82, 317)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(145, 23)
        Me.button4.TabIndex = 42
        Me.button4.Text = "Последняя"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(405, 274)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(145, 23)
        Me.button3.TabIndex = 41
        Me.button3.Text = "Добавить"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(246, 274)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(145, 23)
        Me.button2.TabIndex = 40
        Me.button2.Text = "Предыдущая"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(82, 274)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(145, 23)
        Me.button1.TabIndex = 39
        Me.button1.Text = "Первая"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Тип_товара
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
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(особенностиLabel)
        Me.Controls.Add(Me.особенностиTextBox)
        Me.Controls.Add(описаниеLabel)
        Me.Controls.Add(Me.описаниеTextBox)
        Me.Controls.Add(наименованиеLabel)
        Me.Controls.Add(Me.наименованиеTextBox)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Тип_товара"
        Me.Text = "Тип_товара"
        CType(Me.ТипыТоваровBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatkDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents особенностиTextBox As TextBox
    Private WithEvents описаниеTextBox As TextBox
    Private WithEvents наименованиеTextBox As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents FatkDBDataSet As FatkDBDataSet
    Friend WithEvents ТипыТоваровBindingSource As BindingSource
    Friend WithEvents Типы_товаровTableAdapter As FatkDBDataSetTableAdapters.Типы_товаровTableAdapter
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
End Class
