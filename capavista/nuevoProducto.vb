Public Class nuevoProducto
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KioscoDataSet)

    End Sub

    Private Sub NuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
        Me.TipoProductoTableAdapter.Fill(Me.KioscoDataSet.tipoProducto)
        'TODO: esta línea de código carga datos en la tabla 'KioscoDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
        Me.TipoProductoTableAdapter.Fill(Me.KioscoDataSet.tipoProducto)
        'TODO: esta línea de código carga datos en la tabla 'KioscoDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.KioscoDataSet.productos)

    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

    End Sub
End Class