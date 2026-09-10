<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaLibros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblCategoria = New Label()
        cboCategoria = New ComboBox()
        lblBuscar = New Label()
        txtBuscar = New TextBox()
        bsLibros = New BindingSource(components)
        grpFiltros = New GroupBox()
        grpDetalle = New GroupBox()
        stsEstado = New StatusStrip()
        lblRegistros = New ToolStripStatusLabel()
        dgvLibros = New DataGridView()
        tlpDetalle = New TableLayoutPanel()
        txtTitulo = New TextBox()
        txtCategoria = New TextBox()
        txtEjemplares = New TextBox()
        txtAutor = New TextBox()
        txtaño = New TextBox()
        txtPrecio = New TextBox()
        CType(bsLibros, ComponentModel.ISupportInitialize).BeginInit()
        grpFiltros.SuspendLayout()
        grpDetalle.SuspendLayout()
        stsEstado.SuspendLayout()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        tlpDetalle.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(12, 19)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(61, 15)
        lblCategoria.TabIndex = 0
        lblCategoria.Text = "Categoria:"
        ' 
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(89, 16)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(220, 23)
        cboCategoria.TabIndex = 1
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(328, 19)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(97, 15)
        lblBuscar.TabIndex = 2
        lblBuscar.Text = "Buscar por título:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Location = New Point(431, 19)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Escriba parte del título"
        txtBuscar.Size = New Size(260, 23)
        txtBuscar.TabIndex = 3
        ' 
        ' grpFiltros
        ' 
        grpFiltros.Controls.Add(lblCategoria)
        grpFiltros.Controls.Add(txtBuscar)
        grpFiltros.Controls.Add(cboCategoria)
        grpFiltros.Controls.Add(lblBuscar)
        grpFiltros.Dock = DockStyle.Top
        grpFiltros.Location = New Point(0, 0)
        grpFiltros.Name = "grpFiltros"
        grpFiltros.Size = New Size(884, 70)
        grpFiltros.TabIndex = 4
        grpFiltros.TabStop = False
        grpFiltros.Text = "Filtros de consulta"
        ' 
        ' grpDetalle
        ' 
        grpDetalle.Controls.Add(tlpDetalle)
        grpDetalle.Controls.Add(stsEstado)
        grpDetalle.Dock = DockStyle.Bottom
        grpDetalle.Location = New Point(0, 441)
        grpDetalle.Name = "grpDetalle"
        grpDetalle.Size = New Size(884, 140)
        grpDetalle.TabIndex = 5
        grpDetalle.TabStop = False
        grpDetalle.Text = "Detalle del regostro seleccionado"
        ' 
        ' stsEstado
        ' 
        stsEstado.Items.AddRange(New ToolStripItem() {lblRegistros})
        stsEstado.Location = New Point(3, 115)
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(878, 22)
        stsEstado.SizingGrip = False
        stsEstado.TabIndex = 0
        stsEstado.Text = "StatusStrip1"
        ' 
        ' lblRegistros
        ' 
        lblRegistros.Name = "lblRegistros"
        lblRegistros.Size = New Size(120, 17)
        lblRegistros.Text = "ToolStripStatusLabel1"
        ' 
        ' dgvLibros
        ' 
        dgvLibros.AllowUserToAddRows = False
        dgvLibros.AllowUserToDeleteRows = False
        dgvLibros.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(3, 111)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.RowHeadersVisible = False
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(878, 324)
        dgvLibros.TabIndex = 6
        ' 
        ' tlpDetalle
        ' 
        tlpDetalle.ColumnCount = 3
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.84013F))
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 54.15987F))
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 264F))
        tlpDetalle.Controls.Add(txtTitulo, 0, 0)
        tlpDetalle.Controls.Add(txtCategoria, 1, 0)
        tlpDetalle.Controls.Add(txtEjemplares, 2, 0)
        tlpDetalle.Controls.Add(txtAutor, 0, 1)
        tlpDetalle.Controls.Add(txtaño, 1, 1)
        tlpDetalle.Controls.Add(txtPrecio, 2, 1)
        tlpDetalle.Dock = DockStyle.Fill
        tlpDetalle.Location = New Point(3, 19)
        tlpDetalle.Name = "tlpDetalle"
        tlpDetalle.RowCount = 4
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpDetalle.Size = New Size(878, 96)
        tlpDetalle.TabIndex = 7
        ' 
        ' txtTitulo
        ' 
        txtTitulo.BackColor = SystemColors.Control
        txtTitulo.BorderStyle = BorderStyle.FixedSingle
        txtTitulo.Location = New Point(3, 3)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.ReadOnly = True
        txtTitulo.Size = New Size(100, 23)
        txtTitulo.TabIndex = 0
        txtTitulo.TabStop = False
        ' 
        ' txtCategoria
        ' 
        txtCategoria.BackColor = SystemColors.Control
        txtCategoria.BorderStyle = BorderStyle.FixedSingle
        txtCategoria.Location = New Point(284, 3)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.ReadOnly = True
        txtCategoria.Size = New Size(100, 23)
        txtCategoria.TabIndex = 1
        txtCategoria.TabStop = False
        ' 
        ' txtEjemplares
        ' 
        txtEjemplares.BackColor = SystemColors.Control
        txtEjemplares.BorderStyle = BorderStyle.FixedSingle
        txtEjemplares.Location = New Point(616, 3)
        txtEjemplares.Name = "txtEjemplares"
        txtEjemplares.ReadOnly = True
        txtEjemplares.Size = New Size(100, 23)
        txtEjemplares.TabIndex = 2
        txtEjemplares.TabStop = False
        ' 
        ' txtAutor
        ' 
        txtAutor.BackColor = SystemColors.Control
        txtAutor.BorderStyle = BorderStyle.FixedSingle
        txtAutor.Location = New Point(3, 31)
        txtAutor.Name = "txtAutor"
        txtAutor.ReadOnly = True
        txtAutor.Size = New Size(100, 23)
        txtAutor.TabIndex = 3
        txtAutor.TabStop = False
        ' 
        ' txtaño
        ' 
        txtaño.BorderStyle = BorderStyle.FixedSingle
        txtaño.Location = New Point(284, 31)
        txtaño.Name = "txtaño"
        txtaño.ReadOnly = True
        txtaño.Size = New Size(100, 23)
        txtaño.TabIndex = 4
        txtaño.TabStop = False
        ' 
        ' txtPrecio
        ' 
        txtPrecio.BackColor = SystemColors.Control
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Location = New Point(616, 31)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 5
        txtPrecio.TabStop = False
        ' 
        ' frmConsultaLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 581)
        Controls.Add(dgvLibros)
        Controls.Add(grpDetalle)
        Controls.Add(grpFiltros)
        MinimumSize = New Size(780, 560)
        Name = "frmConsultaLibros"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de libros - Biblioteca"
        CType(bsLibros, ComponentModel.ISupportInitialize).EndInit()
        grpFiltros.ResumeLayout(False)
        grpFiltros.PerformLayout()
        grpDetalle.ResumeLayout(False)
        grpDetalle.PerformLayout()
        stsEstado.ResumeLayout(False)
        stsEstado.PerformLayout()
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        tlpDetalle.ResumeLayout(False)
        tlpDetalle.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblCategoria As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents bsLibros As BindingSource
    Friend WithEvents grpFiltros As GroupBox
    Friend WithEvents grpDetalle As GroupBox
    Friend WithEvents stsEstado As StatusStrip
    Friend WithEvents lblRegistros As ToolStripStatusLabel
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents tlpDetalle As TableLayoutPanel
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtEjemplares As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtPrecio As TextBox

End Class
