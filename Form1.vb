Partial Public Class frmConsultaLibros

    Private bnLibros As New BindingNavigator(True)

    Private Sub frmConsultaLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bnLibros.Name = "bnLibros"
        bnLibros.Location = New Point(10, 100)
        bnLibros.BindingSource = bsLibros

        'Eliminar botones Agregar y Eliminar
        bnLibros.AddNewItem = Nothing
        bnLibros.DeleteItem = Nothing

        bnLibros.Dock = DockStyle.None
        bnLibros.Location = New Point(10, 100)
        Me.Controls.Add(bnLibros)
        bnLibros.BringToFront()

    End Sub

    Private Sub dgvLibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellContentClick

    End Sub

    Private Sub tlpDetalle_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class