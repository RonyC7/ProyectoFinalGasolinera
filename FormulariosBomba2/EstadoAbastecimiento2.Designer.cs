namespace ProyectoFinalGasolinera.FormulariosBomba2
{
    partial class EstadoAbastecimiento2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoAbastecimiento2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMostrarEstado2 = new System.Windows.Forms.Label();
            this.labelMostrarCantidadA2 = new System.Windows.Forms.Label();
            this.labelMostrarCantidadS2 = new System.Windows.Forms.Label();
            this.btncerrar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado del abastecimiento";
            // 
            // labelMostrarEstado2
            // 
            this.labelMostrarEstado2.AutoSize = true;
            this.labelMostrarEstado2.Location = new System.Drawing.Point(35, 78);
            this.labelMostrarEstado2.Name = "labelMostrarEstado2";
            this.labelMostrarEstado2.Size = new System.Drawing.Size(40, 13);
            this.labelMostrarEstado2.TabIndex = 2;
            this.labelMostrarEstado2.Text = "Estado";
            // 
            // labelMostrarCantidadA2
            // 
            this.labelMostrarCantidadA2.AutoSize = true;
            this.labelMostrarCantidadA2.Location = new System.Drawing.Point(35, 124);
            this.labelMostrarCantidadA2.Name = "labelMostrarCantidadA2";
            this.labelMostrarCantidadA2.Size = new System.Drawing.Size(105, 13);
            this.labelMostrarCantidadA2.TabIndex = 3;
            this.labelMostrarCantidadA2.Text = "Cantidad Abastecida";
            // 
            // labelMostrarCantidadS2
            // 
            this.labelMostrarCantidadS2.AutoSize = true;
            this.labelMostrarCantidadS2.Location = new System.Drawing.Point(35, 168);
            this.labelMostrarCantidadS2.Name = "labelMostrarCantidadS2";
            this.labelMostrarCantidadS2.Size = new System.Drawing.Size(98, 13);
            this.labelMostrarCantidadS2.TabIndex = 4;
            this.labelMostrarCantidadS2.Text = "Cantidad Solicitada";
            // 
            // btncerrar2
            // 
            this.btncerrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncerrar2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btncerrar2.FlatAppearance.BorderSize = 2;
            this.btncerrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar2.ForeColor = System.Drawing.Color.White;
            this.btncerrar2.Location = new System.Drawing.Point(262, 294);
            this.btncerrar2.Name = "btncerrar2";
            this.btncerrar2.Size = new System.Drawing.Size(97, 24);
            this.btncerrar2.TabIndex = 5;
            this.btncerrar2.Text = "Cerrar";
            this.btncerrar2.UseVisualStyleBackColor = false;
            this.btncerrar2.Click += new System.EventHandler(this.btncerrar2_Click);
            // 
            // EstadoAbastecimiento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.btncerrar2);
            this.Controls.Add(this.labelMostrarCantidadS2);
            this.Controls.Add(this.labelMostrarCantidadA2);
            this.Controls.Add(this.labelMostrarEstado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadoAbastecimiento2";
            this.Text = "Estado del abastecimiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMostrarEstado2;
        private System.Windows.Forms.Label labelMostrarCantidadA2;
        private System.Windows.Forms.Label labelMostrarCantidadS2;
        private System.Windows.Forms.Button btncerrar2;
    }
}