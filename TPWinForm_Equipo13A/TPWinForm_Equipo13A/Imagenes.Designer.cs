namespace TPWinForm_Equipo13A
{
    partial class Imagenes
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
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.pcbImagenes = new System.Windows.Forms.PictureBox();
            this.lblnoImg = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.lblAgregarURL = new System.Windows.Forms.Label();
            this.txtAgregarNuevaURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.Location = new System.Drawing.Point(28, 61);
            this.dgvImagenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.RowHeadersWidth = 51;
            this.dgvImagenes.RowTemplate.Height = 24;
            this.dgvImagenes.Size = new System.Drawing.Size(722, 208);
            this.dgvImagenes.TabIndex = 0;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged_1);
            // 
            // pcbImagenes
            // 
            this.pcbImagenes.Location = new System.Drawing.Point(808, 61);
            this.pcbImagenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbImagenes.Name = "pcbImagenes";
            this.pcbImagenes.Size = new System.Drawing.Size(211, 208);
            this.pcbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagenes.TabIndex = 1;
            this.pcbImagenes.TabStop = false;
            // 
            // lblnoImg
            // 
            this.lblnoImg.AutoSize = true;
            this.lblnoImg.Location = new System.Drawing.Point(863, 156);
            this.lblnoImg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoImg.Name = "lblnoImg";
            this.lblnoImg.Size = new System.Drawing.Size(109, 13);
            this.lblnoImg.TabIndex = 2;
            this.lblnoImg.Text = "Sin imagen disponible";
            this.lblnoImg.Visible = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarImagen.Location = new System.Drawing.Point(444, 298);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(138, 44);
            this.btnAgregarImagen.TabIndex = 3;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarImagen.Location = new System.Drawing.Point(612, 298);
            this.btnEliminarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(138, 44);
            this.btnEliminarImagen.TabIndex = 4;
            this.btnEliminarImagen.Text = "Borrar Imagen";
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // lblAgregarURL
            // 
            this.lblAgregarURL.AutoSize = true;
            this.lblAgregarURL.Location = new System.Drawing.Point(26, 298);
            this.lblAgregarURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregarURL.Name = "lblAgregarURL";
            this.lblAgregarURL.Size = new System.Drawing.Size(189, 13);
            this.lblAgregarURL.TabIndex = 5;
            this.lblAgregarURL.Text = "Inserte la URL de la imagen a agregar:";
            // 
            // txtAgregarNuevaURL
            // 
            this.txtAgregarNuevaURL.Location = new System.Drawing.Point(28, 324);
            this.txtAgregarNuevaURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAgregarNuevaURL.Name = "txtAgregarNuevaURL";
            this.txtAgregarNuevaURL.Size = new System.Drawing.Size(385, 20);
            this.txtAgregarNuevaURL.TabIndex = 6;
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 376);
            this.Controls.Add(this.txtAgregarNuevaURL);
            this.Controls.Add(this.lblAgregarURL);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblnoImg);
            this.Controls.Add(this.pcbImagenes);
            this.Controls.Add(this.dgvImagenes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            this.Load += new System.EventHandler(this.Imagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.PictureBox pcbImagenes;
        private System.Windows.Forms.Label lblnoImg;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.Label lblAgregarURL;
        private System.Windows.Forms.TextBox txtAgregarNuevaURL;
    }
}