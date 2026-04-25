namespace TPWinForm_Equipo13A
{
    partial class Categorias
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lsbCategorias = new System.Windows.Forms.ListBox();
            this.lblSubTittle = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(11, 9);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(216, 40);
            this.lblArticulos.TabIndex = 3;
            this.lblArticulos.Text = "CATEGORÍAS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(350, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 26);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificar.Location = new System.Drawing.Point(269, 243);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 26);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(188, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 26);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lsbCategorias
            // 
            this.lsbCategorias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsbCategorias.FormattingEnabled = true;
            this.lsbCategorias.Location = new System.Drawing.Point(18, 52);
            this.lsbCategorias.Name = "lsbCategorias";
            this.lsbCategorias.Size = new System.Drawing.Size(137, 368);
            this.lsbCategorias.TabIndex = 8;
            // 
            // lblSubTittle
            // 
            this.lblSubTittle.AutoSize = true;
            this.lblSubTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTittle.Location = new System.Drawing.Point(185, 102);
            this.lblSubTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTittle.Name = "lblSubTittle";
            this.lblSubTittle.Size = new System.Drawing.Size(108, 20);
            this.lblSubTittle.TabIndex = 13;
            this.lblSubTittle.Text = "Escriba algo...";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(189, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 96);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 491);
            this.Controls.Add(this.lblSubTittle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lsbCategorias);
            this.Controls.Add(this.lblArticulos);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Categorias_FormClosed_1);
            this.Load += new System.EventHandler(this.Categorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lsbCategorias;
        private System.Windows.Forms.Label lblSubTittle;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}