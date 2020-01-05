<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim StockMinLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim InFechaLabel As System.Windows.Forms.Label
        Dim OutFechaLabel As System.Windows.Forms.Label
        Dim TipoProductoLabel As System.Windows.Forms.Label
        Me.KioscoDataSet = New capavista.KioscoDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New capavista.KioscoDataSetTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New capavista.KioscoDataSetTableAdapters.TableAdapterManager()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ultimoagregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.StockMinTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.InFechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OutFechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TipoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoProductoTableAdapter = New capavista.KioscoDataSetTableAdapters.tipoProductoTableAdapter()
        DescripcionLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        StockMinLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        InFechaLabel = New System.Windows.Forms.Label()
        OutFechaLabel = New System.Windows.Forms.Label()
        TipoProductoLabel = New System.Windows.Forms.Label()
        CType(Me.KioscoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TipoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KioscoDataSet
        '
        Me.KioscoDataSet.DataSetName = "KioscoDataSet"
        Me.KioscoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.KioscoDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detalleVentasTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tieneStockTableAdapter = Nothing
        Me.TableAdapterManager.tipoProductoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = capavista.KioscoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(449, 436)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(106, 71)
        Me.btnagregar.TabIndex = 21
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(629, 463)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(65, 44)
        Me.btnsalir.TabIndex = 22
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ultimoagregado})
        Me.DataGridView1.Location = New System.Drawing.Point(449, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(245, 349)
        Me.DataGridView1.TabIndex = 23
        '
        'ultimoagregado
        '
        Me.ultimoagregado.HeaderText = "Ultimo agregado"
        Me.ultimoagregado.Name = "ultimoagregado"
        Me.ultimoagregado.Width = 200
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(44, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 465)
        Me.Panel1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(OutFechaLabel)
        Me.Panel2.Controls.Add(InFechaLabel)
        Me.Panel2.Controls.Add(TipoProductoLabel)
        Me.Panel2.Controls.Add(PrecioLabel)
        Me.Panel2.Controls.Add(StockMinLabel)
        Me.Panel2.Controls.Add(DescripcionLabel)
        Me.Panel2.Controls.Add(StockLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 465)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.DescripcionTextBox)
        Me.Panel3.Controls.Add(Me.StockTextBox)
        Me.Panel3.Controls.Add(Me.StockMinTextBox)
        Me.Panel3.Controls.Add(Me.PrecioTextBox)
        Me.Panel3.Controls.Add(Me.InFechaDateTimePicker)
        Me.Panel3.Controls.Add(Me.OutFechaDateTimePicker)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(152, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 465)
        Me.Panel3.TabIndex = 0
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(17, 117)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(80, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "DESCRIPCION"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(13, 117)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(17, 170)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(119, 13)
        StockLabel.TabIndex = 6
        StockLabel.Text = "CANTIDAD EN STOCK"
        '
        'StockTextBox
        '
        Me.StockTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(13, 170)
        Me.StockTextBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.StockTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StockTextBox.TabIndex = 7
        '
        'StockMinLabel
        '
        StockMinLabel.AutoSize = True
        StockMinLabel.Location = New System.Drawing.Point(17, 225)
        StockMinLabel.Name = "StockMinLabel"
        StockMinLabel.Size = New System.Drawing.Size(86, 13)
        StockMinLabel.TabIndex = 8
        StockMinLabel.Text = "STOCK MINIMO"
        '
        'StockMinTextBox
        '
        Me.StockMinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockMinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stockMin", True))
        Me.StockMinTextBox.Location = New System.Drawing.Point(13, 225)
        Me.StockMinTextBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.StockMinTextBox.Name = "StockMinTextBox"
        Me.StockMinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.StockMinTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StockMinTextBox.TabIndex = 9
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(17, 283)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(47, 13)
        PrecioLabel.TabIndex = 10
        PrecioLabel.Text = "PRECIO"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(13, 283)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrecioTextBox.TabIndex = 11
        '
        'InFechaLabel
        '
        InFechaLabel.AutoSize = True
        InFechaLabel.Location = New System.Drawing.Point(17, 342)
        InFechaLabel.Name = "InFechaLabel"
        InFechaLabel.Size = New System.Drawing.Size(115, 13)
        InFechaLabel.TabIndex = 12
        InFechaLabel.Text = "FECHA DE ENTRADA"
        '
        'InFechaDateTimePicker
        '
        Me.InFechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "inFecha", True))
        Me.InFechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InFechaDateTimePicker.Location = New System.Drawing.Point(13, 342)
        Me.InFechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.InFechaDateTimePicker.Name = "InFechaDateTimePicker"
        Me.InFechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.InFechaDateTimePicker.TabIndex = 13
        '
        'OutFechaLabel
        '
        OutFechaLabel.AutoSize = True
        OutFechaLabel.Location = New System.Drawing.Point(9, 403)
        OutFechaLabel.Name = "OutFechaLabel"
        OutFechaLabel.Size = New System.Drawing.Size(137, 13)
        OutFechaLabel.TabIndex = 14
        OutFechaLabel.Text = "FECHA DE VENCIMIENTO"
        '
        'OutFechaDateTimePicker
        '
        Me.OutFechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "outFecha", True))
        Me.OutFechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.OutFechaDateTimePicker.Location = New System.Drawing.Point(13, 403)
        Me.OutFechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.OutFechaDateTimePicker.Name = "OutFechaDateTimePicker"
        Me.OutFechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.OutFechaDateTimePicker.TabIndex = 15
        '
        'TipoProductoLabel
        '
        TipoProductoLabel.AutoSize = True
        TipoProductoLabel.Location = New System.Drawing.Point(17, 65)
        TipoProductoLabel.Name = "TipoProductoLabel"
        TipoProductoLabel.Size = New System.Drawing.Size(96, 13)
        TipoProductoLabel.TabIndex = 2
        TipoProductoLabel.Text = "TIPO PRODUCTO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TipoProductoBindingSource
        Me.ComboBox1.DisplayMember = "descripTipo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.ValueMember = "codTipop"
        '
        'TipoProductoBindingSource
        '
        Me.TipoProductoBindingSource.DataMember = "tipoProducto"
        Me.TipoProductoBindingSource.DataSource = Me.KioscoDataSet
        '
        'TipoProductoTableAdapter
        '
        Me.TipoProductoTableAdapter.ClearBeforeFill = True
        '
        'nuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnagregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "nuevoProducto"
        Me.Text = "nuevoProducto"
        CType(Me.KioscoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TipoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KioscoDataSet As KioscoDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As KioscoDataSetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As KioscoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ultimoagregado As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents StockMinTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents InFechaDateTimePicker As DateTimePicker
    Friend WithEvents OutFechaDateTimePicker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TipoProductoBindingSource As BindingSource
    Friend WithEvents TipoProductoTableAdapter As KioscoDataSetTableAdapters.tipoProductoTableAdapter
End Class
