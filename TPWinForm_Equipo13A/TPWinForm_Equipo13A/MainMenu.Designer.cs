namespace TPWinForm_Equipo13A
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListadoArt = new System.Windows.Forms.Button();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.Text_info = new System.Windows.Forms.Label();
            this.criterioBusqueda = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListadoArt
            // 
            this.btnListadoArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListadoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoArt.Location = new System.Drawing.Point(28, 307);
            this.btnListadoArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnListadoArt.Name = "btnListadoArt";
            this.btnListadoArt.Size = new System.Drawing.Size(172, 38);
            this.btnListadoArt.TabIndex = 0;
            this.btnListadoArt.Text = "Artículos";
            this.btnListadoArt.UseVisualStyleBackColor = false;
            this.btnListadoArt.Click += new System.EventHandler(this.btnListadoArt_Click);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(220, 31);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(153, 20);
            this.textBox_usuario.TabIndex = 1;
            // 
            // Text_info
            // 
            this.Text_info.AutoSize = true;
            this.Text_info.Location = new System.Drawing.Point(25, 34);
            this.Text_info.Name = "Text_info";
            this.Text_info.Size = new System.Drawing.Size(189, 13);
            this.Text_info.TabIndex = 2;
            this.Text_info.Text = "Ingrese el nombre del articulo a buscar";
            // 
            // criterioBusqueda
            // 
            this.criterioBusqueda.FormattingEnabled = true;
            this.criterioBusqueda.Location = new System.Drawing.Point(379, 31);
            this.criterioBusqueda.Name = "criterioBusqueda";
            this.criterioBusqueda.Size = new System.Drawing.Size(121, 21);
            this.criterioBusqueda.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_buscar.Location = new System.Drawing.Point(513, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(28, 73);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(547, 229);
            this.dgvArticulos.TabIndex = 5;
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(220, 307);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(169, 38);
            this.btnMarcas.TabIndex = 6;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(406, 307);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(169, 38);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.criterioBusqueda);
            this.Controls.Add(this.Text_info);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.btnListadoArt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Cargar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoArt;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label Text_info;
        private System.Windows.Forms.ComboBox criterioBusqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

