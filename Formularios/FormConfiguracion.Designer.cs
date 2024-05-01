namespace ProyectoFinalGasolinera
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSuper = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiesel = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegular = new System.Windows.Forms.PictureBox();
            this.txtSuper = new System.Windows.Forms.TextBox();
            this.txtDiesel = new System.Windows.Forms.TextBox();
            this.txtRegular = new System.Windows.Forms.TextBox();
            this.btnGuardarPrecios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarConfi = new System.Windows.Forms.Button();
            this.lblPrecioSuper = new System.Windows.Forms.Label();
            this.lblPrecioDiesel = new System.Windows.Forms.Label();
            this.lblPrecioRegular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precios de la gasolina por galon";
            // 
            // pictureBoxSuper
            // 
            this.pictureBoxSuper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSuper.Image")));
            this.pictureBoxSuper.Location = new System.Drawing.Point(30, 95);
            this.pictureBoxSuper.Name = "pictureBoxSuper";
            this.pictureBoxSuper.Size = new System.Drawing.Size(84, 40);
            this.pictureBoxSuper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSuper.TabIndex = 1;
            this.pictureBoxSuper.TabStop = false;
            // 
            // pictureBoxDiesel
            // 
            this.pictureBoxDiesel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDiesel.Image")));
            this.pictureBoxDiesel.Location = new System.Drawing.Point(146, 95);
            this.pictureBoxDiesel.Name = "pictureBoxDiesel";
            this.pictureBoxDiesel.Size = new System.Drawing.Size(84, 40);
            this.pictureBoxDiesel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDiesel.TabIndex = 2;
            this.pictureBoxDiesel.TabStop = false;
            // 
            // pictureBoxRegular
            // 
            this.pictureBoxRegular.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegular.Image")));
            this.pictureBoxRegular.Location = new System.Drawing.Point(266, 95);
            this.pictureBoxRegular.Name = "pictureBoxRegular";
            this.pictureBoxRegular.Size = new System.Drawing.Size(84, 40);
            this.pictureBoxRegular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegular.TabIndex = 3;
            this.pictureBoxRegular.TabStop = false;
            // 
            // txtSuper
            // 
            this.txtSuper.Location = new System.Drawing.Point(30, 187);
            this.txtSuper.Name = "txtSuper";
            this.txtSuper.Size = new System.Drawing.Size(84, 20);
            this.txtSuper.TabIndex = 4;
            // 
            // txtDiesel
            // 
            this.txtDiesel.Location = new System.Drawing.Point(146, 187);
            this.txtDiesel.Name = "txtDiesel";
            this.txtDiesel.Size = new System.Drawing.Size(84, 20);
            this.txtDiesel.TabIndex = 5;
            // 
            // txtRegular
            // 
            this.txtRegular.Location = new System.Drawing.Point(266, 187);
            this.txtRegular.Name = "txtRegular";
            this.txtRegular.Size = new System.Drawing.Size(84, 20);
            this.txtRegular.TabIndex = 6;
            // 
            // btnGuardarPrecios
            // 
            this.btnGuardarPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardarPrecios.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnGuardarPrecios.FlatAppearance.BorderSize = 2;
            this.btnGuardarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrecios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPrecios.Location = new System.Drawing.Point(137, 213);
            this.btnGuardarPrecios.Name = "btnGuardarPrecios";
            this.btnGuardarPrecios.Size = new System.Drawing.Size(103, 26);
            this.btnGuardarPrecios.TabIndex = 7;
            this.btnGuardarPrecios.Text = "Guardar Precios";
            this.btnGuardarPrecios.UseVisualStyleBackColor = false;
            this.btnGuardarPrecios.Click += new System.EventHandler(this.btnGuardarPrecios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarConfi
            // 
            this.btnCerrarConfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarConfi.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCerrarConfi.FlatAppearance.BorderSize = 2;
            this.btnCerrarConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarConfi.ForeColor = System.Drawing.Color.White;
            this.btnCerrarConfi.Location = new System.Drawing.Point(620, 13);
            this.btnCerrarConfi.Name = "btnCerrarConfi";
            this.btnCerrarConfi.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarConfi.TabIndex = 9;
            this.btnCerrarConfi.Text = "Cerrar";
            this.btnCerrarConfi.UseVisualStyleBackColor = false;
            this.btnCerrarConfi.Click += new System.EventHandler(this.btnCerrarConfi_Click);
            // 
            // lblPrecioSuper
            // 
            this.lblPrecioSuper.AutoSize = true;
            this.lblPrecioSuper.Location = new System.Drawing.Point(50, 153);
            this.lblPrecioSuper.Name = "lblPrecioSuper";
            this.lblPrecioSuper.Size = new System.Drawing.Size(35, 13);
            this.lblPrecioSuper.TabIndex = 10;
            this.lblPrecioSuper.Text = "label2";
            // 
            // lblPrecioDiesel
            // 
            this.lblPrecioDiesel.AutoSize = true;
            this.lblPrecioDiesel.Location = new System.Drawing.Point(168, 153);
            this.lblPrecioDiesel.Name = "lblPrecioDiesel";
            this.lblPrecioDiesel.Size = new System.Drawing.Size(35, 13);
            this.lblPrecioDiesel.TabIndex = 11;
            this.lblPrecioDiesel.Text = "label3";
            // 
            // lblPrecioRegular
            // 
            this.lblPrecioRegular.AutoSize = true;
            this.lblPrecioRegular.Location = new System.Drawing.Point(291, 153);
            this.lblPrecioRegular.Name = "lblPrecioRegular";
            this.lblPrecioRegular.Size = new System.Drawing.Size(35, 13);
            this.lblPrecioRegular.TabIndex = 12;
            this.lblPrecioRegular.Text = "label4";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 275);
            this.Controls.Add(this.lblPrecioRegular);
            this.Controls.Add(this.lblPrecioDiesel);
            this.Controls.Add(this.lblPrecioSuper);
            this.Controls.Add(this.btnCerrarConfi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarPrecios);
            this.Controls.Add(this.txtRegular);
            this.Controls.Add(this.txtDiesel);
            this.Controls.Add(this.txtSuper);
            this.Controls.Add(this.pictureBoxRegular);
            this.Controls.Add(this.pictureBoxDiesel);
            this.Controls.Add(this.pictureBoxSuper);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfiguracion";
            this.Text = "Formulario Configuracion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSuper;
        private System.Windows.Forms.PictureBox pictureBoxDiesel;
        private System.Windows.Forms.PictureBox pictureBoxRegular;
        private System.Windows.Forms.TextBox txtSuper;
        private System.Windows.Forms.TextBox txtDiesel;
        private System.Windows.Forms.TextBox txtRegular;
        private System.Windows.Forms.Button btnGuardarPrecios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarConfi;
        private System.Windows.Forms.Label lblPrecioSuper;
        private System.Windows.Forms.Label lblPrecioDiesel;
        private System.Windows.Forms.Label lblPrecioRegular;
    }
}