
namespace GestionClientesAPP.Forms
{
    partial class FormArticulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnombreArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBtipoImpuesto = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Artículo";
            // 
            // TBnombreArticulo
            // 
            this.TBnombreArticulo.Location = new System.Drawing.Point(211, 132);
            this.TBnombreArticulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBnombreArticulo.Name = "TBnombreArticulo";
            this.TBnombreArticulo.Size = new System.Drawing.Size(481, 23);
            this.TBnombreArticulo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Precio";
            // 
            // TBprecio
            // 
            this.TBprecio.Location = new System.Drawing.Point(211, 173);
            this.TBprecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(199, 23);
            this.TBprecio.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo Impuesto";
            // 
            // CBtipoImpuesto
            // 
            this.CBtipoImpuesto.FormattingEnabled = true;
            this.CBtipoImpuesto.Location = new System.Drawing.Point(211, 216);
            this.CBtipoImpuesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBtipoImpuesto.Name = "CBtipoImpuesto";
            this.CBtipoImpuesto.Size = new System.Drawing.Size(199, 23);
            this.CBtipoImpuesto.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Image = global::GestionClientesAPP.Properties.Resources.search_free_icon_font;
            this.btnBuscar.Location = new System.Drawing.Point(606, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 62);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = global::GestionClientesAPP.Properties.Resources.cross_free_icon_font__1_;
            this.btnEliminar.Location = new System.Drawing.Point(511, 14);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 62);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Image = global::GestionClientesAPP.Properties.Resources.pencil_free_icon_font;
            this.btnModificar.Location = new System.Drawing.Point(416, 14);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 62);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.TabStop = false;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAñadir.Image = global::GestionClientesAPP.Properties.Resources.plus_small_free_icon_font__1_;
            this.btnAñadir.Location = new System.Drawing.Point(322, 14);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(88, 62);
            this.btnAñadir.TabIndex = 14;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // CBCliente
            // 
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Location = new System.Drawing.Point(211, 95);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(293, 23);
            this.CBCliente.TabIndex = 23;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 395);
            this.Controls.Add(this.CBCliente);
            this.Controls.Add(this.CBtipoImpuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBnombreArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormArticulos";
            this.Text = "Artículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnombreArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBtipoImpuesto;
        private System.Windows.Forms.ComboBox CBCliente;
    }
}