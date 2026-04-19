namespace TPWinForm_Equipo13A
{
    partial class Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lsbListadoArticulos = new System.Windows.Forms.ListBox();
            this.grpbDetalleProducto = new System.Windows.Forms.GroupBox();
            this.lblItemDescripcion = new System.Windows.Forms.Label();
            this.lblItemPrecio = new System.Windows.Forms.Label();
            this.lblItemCategoria = new System.Windows.Forms.Label();
            this.lblItemMarca = new System.Windows.Forms.Label();
            this.lblItemNombre = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.lblSubTittle = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pcbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.grpbDetalleProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(45, 22);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(237, 50);
            this.lblArticulos.TabIndex = 1;
            this.lblArticulos.Text = "ARTÍCULOS";
            // 
            // lsbListadoArticulos
            // 
            this.lsbListadoArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbListadoArticulos.FormattingEnabled = true;
            this.lsbListadoArticulos.ItemHeight = 27;
            this.lsbListadoArticulos.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3",
            "item4"});
            this.lsbListadoArticulos.Location = new System.Drawing.Point(53, 146);
            this.lsbListadoArticulos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lsbListadoArticulos.Name = "lsbListadoArticulos";
            this.lsbListadoArticulos.Size = new System.Drawing.Size(185, 490);
            this.lsbListadoArticulos.TabIndex = 2;
            this.lsbListadoArticulos.SelectedIndexChanged += new System.EventHandler(this.lsbListadoArticulos_SelectedIndexChanged);
            // 
            // grpbDetalleProducto
            // 
            this.grpbDetalleProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpbDetalleProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpbDetalleProducto.Controls.Add(this.lblItemDescripcion);
            this.grpbDetalleProducto.Controls.Add(this.lblItemPrecio);
            this.grpbDetalleProducto.Controls.Add(this.lblItemCategoria);
            this.grpbDetalleProducto.Controls.Add(this.lblItemMarca);
            this.grpbDetalleProducto.Controls.Add(this.lblItemNombre);
            this.grpbDetalleProducto.Controls.Add(this.lblItemId);
            this.grpbDetalleProducto.Controls.Add(this.lblCategoria);
            this.grpbDetalleProducto.Controls.Add(this.lblMarca);
            this.grpbDetalleProducto.Controls.Add(this.lblPrecioProducto);
            this.grpbDetalleProducto.Controls.Add(this.lblDescripcionProducto);
            this.grpbDetalleProducto.Controls.Add(this.lblNombreProducto);
            this.grpbDetalleProducto.Controls.Add(this.lblIDProducto);
            this.grpbDetalleProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpbDetalleProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetalleProducto.Location = new System.Drawing.Point(293, 146);
            this.grpbDetalleProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbDetalleProducto.Name = "grpbDetalleProducto";
            this.grpbDetalleProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbDetalleProducto.Size = new System.Drawing.Size(309, 320);
            this.grpbDetalleProducto.TabIndex = 3;
            this.grpbDetalleProducto.TabStop = false;
            this.grpbDetalleProducto.Text = "DETALLE";
            this.grpbDetalleProducto.Enter += new System.EventHandler(this.grpbDetalleProducto_Enter);
            // 
            // lblItemDescripcion
            // 
            this.lblItemDescripcion.AutoSize = true;
            this.lblItemDescripcion.Location = new System.Drawing.Point(28, 254);
            this.lblItemDescripcion.Name = "lblItemDescripcion";
            this.lblItemDescripcion.Size = new System.Drawing.Size(0, 30);
            this.lblItemDescripcion.TabIndex = 10;
            // 
            // lblItemPrecio
            // 
            this.lblItemPrecio.AutoSize = true;
            this.lblItemPrecio.Location = new System.Drawing.Point(99, 186);
            this.lblItemPrecio.Name = "lblItemPrecio";
            this.lblItemPrecio.Size = new System.Drawing.Size(0, 30);
            this.lblItemPrecio.TabIndex = 9;
            // 
            // lblItemCategoria
            // 
            this.lblItemCategoria.AutoSize = true;
            this.lblItemCategoria.Location = new System.Drawing.Point(115, 146);
            this.lblItemCategoria.Name = "lblItemCategoria";
            this.lblItemCategoria.Size = new System.Drawing.Size(0, 30);
            this.lblItemCategoria.TabIndex = 8;
            // 
            // lblItemMarca
            // 
            this.lblItemMarca.AutoSize = true;
            this.lblItemMarca.Location = new System.Drawing.Point(93, 116);
            this.lblItemMarca.Name = "lblItemMarca";
            this.lblItemMarca.Size = new System.Drawing.Size(0, 30);
            this.lblItemMarca.TabIndex = 7;
            // 
            // lblItemNombre
            // 
            this.lblItemNombre.AutoSize = true;
            this.lblItemNombre.Location = new System.Drawing.Point(109, 80);
            this.lblItemNombre.Name = "lblItemNombre";
            this.lblItemNombre.Size = new System.Drawing.Size(0, 30);
            this.lblItemNombre.TabIndex = 7;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(55, 41);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(0, 30);
            this.lblItemId.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(17, 153);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 23);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(17, 116);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 23);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(17, 192);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(76, 23);
            this.lblPrecioProducto.TabIndex = 3;
            this.lblPrecioProducto.Text = "Precio $";
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(17, 230);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(111, 23);
            this.lblDescripcionProducto.TabIndex = 2;
            this.lblDescripcionProducto.Text = "Descripción:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(17, 80);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(82, 23);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(17, 48);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(32, 23);
            this.lblIDProducto.TabIndex = 0;
            this.lblIDProducto.Text = "ID:";
            // 
            // lblSubTittle
            // 
            this.lblSubTittle.AutoSize = true;
            this.lblSubTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTittle.Location = new System.Drawing.Point(49, 103);
            this.lblSubTittle.Name = "lblSubTittle";
            this.lblSubTittle.Size = new System.Drawing.Size(217, 25);
            this.lblSubTittle.TabIndex = 0;
            this.lblSubTittle.Text = "Seleccione un producto";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(293, 502);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(309, 28);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(293, 551);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(309, 28);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(293, 607);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(309, 28);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar ";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // pcbImagenArticulo
            // 
            this.pcbImagenArticulo.Location = new System.Drawing.Point(651, 166);
            this.pcbImagenArticulo.Name = "pcbImagenArticulo";
            this.pcbImagenArticulo.Size = new System.Drawing.Size(216, 182);
            this.pcbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagenArticulo.TabIndex = 8;
            this.pcbImagenArticulo.TabStop = false;
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(651, 400);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnImagenAnterior.TabIndex = 9;
            this.btnImagenAnterior.Text = "Anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(792, 400);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnImagenSiguiente.TabIndex = 10;
            this.btnImagenSiguiente.Text = "Siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 798);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.pcbImagenArticulo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.lblSubTittle);
            this.Controls.Add(this.grpbDetalleProducto);
            this.Controls.Add(this.lsbListadoArticulos);
            this.Controls.Add(this.lblArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.grpbDetalleProducto.ResumeLayout(false);
            this.grpbDetalleProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.ListBox lsbListadoArticulos;
        private System.Windows.Forms.GroupBox grpbDetalleProducto;
        private System.Windows.Forms.Label lblSubTittle;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblItemNombre;
        private System.Windows.Forms.Label lblItemCategoria;
        private System.Windows.Forms.Label lblItemMarca;
        private System.Windows.Forms.Label lblItemPrecio;
        private System.Windows.Forms.Label lblItemDescripcion;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pcbImagenArticulo;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
    }
}