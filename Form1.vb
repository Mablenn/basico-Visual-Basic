Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' En la carga del formulario se carga el conjunto de datos
        DataSet21.Clear()
        SqlDataAdapter1.Fill(DataSet21)

        ' A partir de aquí el usuario utiliza el control DataGridView para leer,
        ' eliminar, insertar o modificar datos.
        ' Los datos trabajan sin conexión

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' Al cerrar el formulario se verifica si el usuario ha realizado algún cambio
        ' El método HasChanges no devuelve True cuando haya cambios pendientes de enviar
        ' al origen de datos
        If (DataSet21.HasChanges()) Then
            ' El adapatador de datos ya sabe que sentencia SQL debe utilizar para 
            ' modificar los cambios
            SqlDataAdapter1.Update(DataSet21)
            MessageBox.Show("No han habido cambios en los datos.")
        Else
            MessageBox.Show("Cambios pasados al origen de datos.")
        End If

    End Sub

End Class
