namespace GoogleTelefono
{
    partial class Form1
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
            this.telefonos = new System.Windows.Forms.ComboBox();
            this.Listacamaras = new System.Windows.Forms.ComboBox();
            this.listamemorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblpreciocamaras = new System.Windows.Forms.Label();
            this.lblpreciomemorias = new System.Windows.Forms.Label();
            this.lbldescripcioncamara = new System.Windows.Forms.Label();
            this.lblnombretel = new System.Windows.Forms.Label();
            this.lbldescripcionmemorias = new System.Windows.Forms.Label();
            this.cantidadcamaras = new System.Windows.Forms.NumericUpDown();
            this.cantidadmemorias = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblpantallas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblpreciopantalla = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadcamaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadmemorias)).BeginInit();
            this.SuspendLayout();
            // 
            // telefonos
            // 
            this.telefonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.telefonos.FormattingEnabled = true;
            this.telefonos.Location = new System.Drawing.Point(15, 25);
            this.telefonos.Name = "telefonos";
            this.telefonos.Size = new System.Drawing.Size(121, 21);
            this.telefonos.TabIndex = 0;
            this.telefonos.SelectedIndexChanged += new System.EventHandler(this.telefonos_SelectedIndexChanged);
            // 
            // Listacamaras
            // 
            this.Listacamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Listacamaras.Enabled = false;
            this.Listacamaras.FormattingEnabled = true;
            this.Listacamaras.Location = new System.Drawing.Point(66, 98);
            this.Listacamaras.Name = "Listacamaras";
            this.Listacamaras.Size = new System.Drawing.Size(121, 21);
            this.Listacamaras.TabIndex = 1;
            this.Listacamaras.SelectedIndexChanged += new System.EventHandler(this.Listacamaras_SelectedIndexChanged);
            // 
            // listamemorias
            // 
            this.listamemorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listamemorias.Enabled = false;
            this.listamemorias.FormattingEnabled = true;
            this.listamemorias.Location = new System.Drawing.Point(66, 125);
            this.listamemorias.Name = "listamemorias";
            this.listamemorias.Size = new System.Drawing.Size(121, 21);
            this.listamemorias.TabIndex = 2;
            this.listamemorias.SelectedIndexChanged += new System.EventHandler(this.listamemorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Camaras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Memorias";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(196, 180);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(10, 13);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = ".";
            // 
            // lblpreciocamaras
            // 
            this.lblpreciocamaras.AutoSize = true;
            this.lblpreciocamaras.Location = new System.Drawing.Point(193, 101);
            this.lblpreciocamaras.Name = "lblpreciocamaras";
            this.lblpreciocamaras.Size = new System.Drawing.Size(13, 13);
            this.lblpreciocamaras.TabIndex = 7;
            this.lblpreciocamaras.Text = "0";
            // 
            // lblpreciomemorias
            // 
            this.lblpreciomemorias.AutoSize = true;
            this.lblpreciomemorias.Location = new System.Drawing.Point(193, 128);
            this.lblpreciomemorias.Name = "lblpreciomemorias";
            this.lblpreciomemorias.Size = new System.Drawing.Size(13, 13);
            this.lblpreciomemorias.TabIndex = 8;
            this.lblpreciomemorias.Text = "0";
            // 
            // lbldescripcioncamara
            // 
            this.lbldescripcioncamara.AutoSize = true;
            this.lbldescripcioncamara.Location = new System.Drawing.Point(275, 106);
            this.lbldescripcioncamara.Name = "lbldescripcioncamara";
            this.lbldescripcioncamara.Size = new System.Drawing.Size(10, 13);
            this.lbldescripcioncamara.TabIndex = 9;
            this.lbldescripcioncamara.Text = ".";
            // 
            // lblnombretel
            // 
            this.lblnombretel.AutoSize = true;
            this.lblnombretel.Location = new System.Drawing.Point(196, 54);
            this.lblnombretel.Name = "lblnombretel";
            this.lblnombretel.Size = new System.Drawing.Size(10, 13);
            this.lblnombretel.TabIndex = 10;
            this.lblnombretel.Text = ".";
            // 
            // lbldescripcionmemorias
            // 
            this.lbldescripcionmemorias.AutoSize = true;
            this.lbldescripcionmemorias.Location = new System.Drawing.Point(275, 133);
            this.lbldescripcionmemorias.Name = "lbldescripcionmemorias";
            this.lbldescripcionmemorias.Size = new System.Drawing.Size(10, 13);
            this.lbldescripcionmemorias.TabIndex = 11;
            this.lbldescripcionmemorias.Text = ".";
            // 
            // cantidadcamaras
            // 
            this.cantidadcamaras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidadcamaras.Enabled = false;
            this.cantidadcamaras.Location = new System.Drawing.Point(233, 101);
            this.cantidadcamaras.Name = "cantidadcamaras";
            this.cantidadcamaras.Size = new System.Drawing.Size(36, 16);
            this.cantidadcamaras.TabIndex = 12;
            this.cantidadcamaras.ValueChanged += new System.EventHandler(this.cantidadcamaras_ValueChanged);
            // 
            // cantidadmemorias
            // 
            this.cantidadmemorias.Enabled = false;
            this.cantidadmemorias.Location = new System.Drawing.Point(233, 126);
            this.cantidadmemorias.Name = "cantidadmemorias";
            this.cantidadmemorias.Size = new System.Drawing.Size(36, 20);
            this.cantidadmemorias.TabIndex = 13;
            this.cantidadmemorias.ValueChanged += new System.EventHandler(this.cantidadmemorias_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(68, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblpantallas
            // 
            this.lblpantallas.AutoSize = true;
            this.lblpantallas.Location = new System.Drawing.Point(12, 155);
            this.lblpantallas.Name = "lblpantallas";
            this.lblpantallas.Size = new System.Drawing.Size(50, 13);
            this.lblpantallas.TabIndex = 16;
            this.lblpantallas.Text = "Pantallas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Location = new System.Drawing.Point(47, 210);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 19;
            // 
            // btnenviar
            // 
            this.btnenviar.Enabled = false;
            this.btnenviar.Location = new System.Drawing.Point(47, 236);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 20;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Correo";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(247, 155);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(10, 13);
            this.lbldescripcion.TabIndex = 22;
            this.lbldescripcion.Text = ".";
            // 
            // lblpreciopantalla
            // 
            this.lblpreciopantalla.AutoSize = true;
            this.lblpreciopantalla.Location = new System.Drawing.Point(196, 155);
            this.lblpreciopantalla.Name = "lblpreciopantalla";
            this.lblpreciopantalla.Size = new System.Drawing.Size(13, 13);
            this.lblpreciopantalla.TabIndex = 23;
            this.lblpreciopantalla.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 268);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblpreciopantalla);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpantallas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidadmemorias);
            this.Controls.Add(this.cantidadcamaras);
            this.Controls.Add(this.lbldescripcionmemorias);
            this.Controls.Add(this.lblnombretel);
            this.Controls.Add(this.lbldescripcioncamara);
            this.Controls.Add(this.lblpreciomemorias);
            this.Controls.Add(this.lblpreciocamaras);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listamemorias);
            this.Controls.Add(this.Listacamaras);
            this.Controls.Add(this.telefonos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cantidadcamaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadmemorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox telefonos;
        private System.Windows.Forms.ComboBox Listacamaras;
        private System.Windows.Forms.ComboBox listamemorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblpreciocamaras;
        private System.Windows.Forms.Label lblpreciomemorias;
        private System.Windows.Forms.Label lbldescripcioncamara;
        private System.Windows.Forms.Label lblnombretel;
        private System.Windows.Forms.Label lbldescripcionmemorias;
        private System.Windows.Forms.NumericUpDown cantidadcamaras;
        private System.Windows.Forms.NumericUpDown cantidadmemorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblpantallas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblpreciopantalla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

