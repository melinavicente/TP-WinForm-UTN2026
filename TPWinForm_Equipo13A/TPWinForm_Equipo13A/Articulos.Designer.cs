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
            this.lblSinImagen = new System.Windows.Forms.Label();
            this.grpbDetalleProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(34, 18);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(192, 40);
            this.lblArticulos.TabIndex = 1;
            this.lblArticulos.Text = "ARTÍCULOS";
            // 
            // lsbListadoArticulos
            // 
            this.lsbListadoArticulos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsbListadoArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbListadoArticulos.FormattingEnabled = true;
            this.lsbListadoArticulos.ItemHeight = 21;
            this.lsbListadoArticulos.Location = new System.Drawing.Point(40, 119);
            this.lsbListadoArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbListadoArticulos.Name = "lsbListadoArticulos";
            this.lsbListadoArticulos.Size = new System.Drawing.Size(140, 382);
            this.lsbListadoArticulos.TabIndex = 2;
            this.lsbListadoArticulos.SelectedIndexChanged += new System.EventHandler(this.lsbListadoArticulos_SelectedIndexChanged);
            // 
            // grpbDetalleProducto
            // 
            this.grpbDetalleProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.grpbDetalleProducto.Location = new System.Drawing.Point(248, 119);
            this.grpbDetalleProducto.Margin = new System.Windows.Forms.Padding(2);
            this.grpbDetalleProducto.Name = "grpbDetalleProducto";
            this.grpbDetalleProducto.Padding = new System.Windows.Forms.Padding(2);
            this.grpbDetalleProducto.Size = new System.Drawing.Size(330, 260);
            this.grpbDetalleProducto.TabIndex = 3;
            this.grpbDetalleProducto.TabStop = false;
            this.grpbDetalleProducto.Text = "DETALLE";            // 
            // lblItemDescripcion
            // 
            this.lblItemDescripcion.AutoSize = true;
            this.lblItemDescripcion.Location = new System.Drawing.Point(21, 206);
            this.lblItemDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemDescripcion.Name = "lblItemDescripcion";
            this.lblItemDescripcion.Size = new System.Drawing.Size(0, 25);
            this.lblItemDescripcion.TabIndex = 10;
            // 
            // lblItemPrecio
            // 
            this.lblItemPrecio.AutoSize = true;
            this.lblItemPrecio.Location = new System.Drawing.Point(74, 151);
            this.lblItemPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemPrecio.Name = "lblItemPrecio";
            this.lblItemPrecio.Size = new System.Drawing.Size(0, 25);
            this.lblItemPrecio.TabIndex = 9;
            // 
            // lblItemCategoria
            // 
            this.lblItemCategoria.AutoSize = true;
            this.lblItemCategoria.Location = new System.Drawing.Point(86, 119);
            this.lblItemCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemCategoria.Name = "lblItemCategoria";
            this.lblItemCategoria.Size = new System.Drawing.Size(0, 25);
            this.lblItemCategoria.TabIndex = 8;
            // 
            // lblItemMarca
            // 
            this.lblItemMarca.AutoSize = true;
            this.lblItemMarca.Location = new System.Drawing.Point(70, 94);
            this.lblItemMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemMarca.Name = "lblItemMarca";
            this.lblItemMarca.Size = new System.Drawing.Size(0, 25);
            this.lblItemMarca.TabIndex = 7;
            // 
            // lblItemNombre
            // 
            this.lblItemNombre.AutoSize = true;
            this.lblItemNombre.Location = new System.Drawing.Point(82, 65);
            this.lblItemNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemNombre.Name = "lblItemNombre";
            this.lblItemNombre.Size = new System.Drawing.Size(0, 25);
            this.lblItemNombre.TabIndex = 7;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(41, 33);
            this.lblItemId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(0, 25);
            this.lblItemId.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(13, 124);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 20);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(13, 94);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 20);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(13, 156);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(63, 20);
            this.lblPrecioProducto.TabIndex = 3;
            this.lblPrecioProducto.Text = "Precio $";
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(13, 187);
            this.lblDescripcionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(91, 20);
            this.lblDescripcionProducto.TabIndex = 2;
            this.lblDescripcionProducto.Text = "Descripción:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(13, 65);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(67, 20);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(13, 39);
            this.lblIDProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(27, 20);
            this.lblIDProducto.TabIndex = 0;
            this.lblIDProducto.Text = "ID:";
            // 
            // lblSubTittle
            // 
            this.lblSubTittle.AutoSize = true;
            this.lblSubTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTittle.Location = new System.Drawing.Point(37, 84);
            this.lblSubTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTittle.Name = "lblSubTittle";
            this.lblSubTittle.Size = new System.Drawing.Size(176, 20);
            this.lblSubTittle.TabIndex = 0;
            this.lblSubTittle.Text = "Seleccione un producto";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_eliminar.Location = new System.Drawing.Point(294, 401);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(232, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_modificar.Location = new System.Drawing.Point(294, 439);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(232, 23);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.Location = new System.Drawing.Point(294, 479);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(232, 23);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar ";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pcbImagenArticulo
            // 
            this.pcbImagenArticulo.Location = new System.Drawing.Point(670, 152);
            this.pcbImagenArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pcbImagenArticulo.Name = "pcbImagenArticulo";
            this.pcbImagenArticulo.Size = new System.Drawing.Size(162, 148);
            this.pcbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagenArticulo.TabIndex = 8;
            this.pcbImagenArticulo.TabStop = false;
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnImagenAnterior.Location = new System.Drawing.Point(670, 306);
            this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(74, 22);
            this.btnImagenAnterior.TabIndex = 9;
            this.btnImagenAnterior.Text = "Anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = false;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnImagenSiguiente.Location = new System.Drawing.Point(748, 306);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(74, 22);
            this.btnImagenSiguiente.TabIndex = 10;
            this.btnImagenSiguiente.Text = "Siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = false;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // lblSinImagen
            // 
            this.lblSinImagen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSinImagen.Location = new System.Drawing.Point(667, 152);
            this.lblSinImagen.Name = "lblSinImagen";
            this.lblSinImagen.Size = new System.Drawing.Size(165, 148);
            this.lblSinImagen.TabIndex = 11;
            this.lblSinImagen.Text = "Sin imagen disponible";
            this.lblSinImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinImagen.Visible = false;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 648);
            this.Controls.Add(this.lblSinImagen);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Articulos_FormClosed);
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
        private System.Windows.Forms.Label lblSinImagen;
    }
}