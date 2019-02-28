namespace GoogleTelefono
{
    partial class Clientes
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btnnotificar = new System.Windows.Forms.Button();
            this.txtofertas = new System.Windows.Forms.TextBox();
            this.cbusuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(60, 26);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(60, 64);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correo";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(71, 90);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 4;
            this.btnenviar.Text = "Agregar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btnnotificar
            // 
            this.btnnotificar.Location = new System.Drawing.Point(135, 217);
            this.btnnotificar.Name = "btnnotificar";
            this.btnnotificar.Size = new System.Drawing.Size(75, 23);
            this.btnnotificar.TabIndex = 5;
            this.btnnotificar.Text = "Notificar";
            this.btnnotificar.UseVisualStyleBackColor = true;
            this.btnnotificar.Click += new System.EventHandler(this.btnnotificar_Click);
            // 
            // txtofertas
            // 
            this.txtofertas.Location = new System.Drawing.Point(84, 158);
            this.txtofertas.Multiline = true;
            this.txtofertas.Name = "txtofertas";
            this.txtofertas.Size = new System.Drawing.Size(172, 53);
            this.txtofertas.TabIndex = 6;
            this.txtofertas.TextChanged += new System.EventHandler(this.txtofertas_TextChanged);
            // 
            // cbusuarios
            // 
            this.cbusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbusuarios.FormattingEnabled = true;
            this.cbusuarios.Location = new System.Drawing.Point(344, 29);
            this.cbusuarios.Name = "cbusuarios";
            this.cbusuarios.Size = new System.Drawing.Size(121, 21);
            this.cbusuarios.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuarios";
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(344, 62);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 9;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 262);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbusuarios);
            this.Controls.Add(this.txtofertas);
            this.Controls.Add(this.btnnotificar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombre);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btnnotificar;
        private System.Windows.Forms.TextBox txtofertas;
        private System.Windows.Forms.ComboBox cbusuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnquitar;
    }
}