﻿namespace ProyectoFinalGasolinera.FormulariosBomba4
{
    partial class EstadoAbastecimiento4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoAbastecimiento4_1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMostrarEstado4 = new System.Windows.Forms.Label();
            this.labelMostrarCantidadA4 = new System.Windows.Forms.Label();
            this.labelMostrarCantidad4 = new System.Windows.Forms.Label();
            this.btncerrar4 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado del abastecimiento";
            // 
            // labelMostrarEstado4
            // 
            this.labelMostrarEstado4.AutoSize = true;
            this.labelMostrarEstado4.Location = new System.Drawing.Point(13, 94);
            this.labelMostrarEstado4.Name = "labelMostrarEstado4";
            this.labelMostrarEstado4.Size = new System.Drawing.Size(40, 13);
            this.labelMostrarEstado4.TabIndex = 2;
            this.labelMostrarEstado4.Text = "Estado";
            // 
            // labelMostrarCantidadA4
            // 
            this.labelMostrarCantidadA4.AutoSize = true;
            this.labelMostrarCantidadA4.Location = new System.Drawing.Point(13, 139);
            this.labelMostrarCantidadA4.Name = "labelMostrarCantidadA4";
            this.labelMostrarCantidadA4.Size = new System.Drawing.Size(105, 13);
            this.labelMostrarCantidadA4.TabIndex = 3;
            this.labelMostrarCantidadA4.Text = "Cantidad Abastecida";
            // 
            // labelMostrarCantidad4
            // 
            this.labelMostrarCantidad4.AutoSize = true;
            this.labelMostrarCantidad4.Location = new System.Drawing.Point(13, 188);
            this.labelMostrarCantidad4.Name = "labelMostrarCantidad4";
            this.labelMostrarCantidad4.Size = new System.Drawing.Size(98, 13);
            this.labelMostrarCantidad4.TabIndex = 4;
            this.labelMostrarCantidad4.Text = "Cantidad Solicitada";
            // 
            // btncerrar4
            // 
            this.btncerrar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncerrar4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btncerrar4.FlatAppearance.BorderSize = 2;
            this.btncerrar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar4.ForeColor = System.Drawing.Color.White;
            this.btncerrar4.Location = new System.Drawing.Point(277, 291);
            this.btncerrar4.Name = "btncerrar4";
            this.btncerrar4.Size = new System.Drawing.Size(82, 30);
            this.btncerrar4.TabIndex = 5;
            this.btncerrar4.Text = "Cerrar";
            this.btncerrar4.UseVisualStyleBackColor = false;
            // 
            // EstadoAbastecimiento4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.btncerrar4);
            this.Controls.Add(this.labelMostrarCantidad4);
            this.Controls.Add(this.labelMostrarCantidadA4);
            this.Controls.Add(this.labelMostrarEstado4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadoAbastecimiento4_1";
            this.Text = "Estado del abastecimiento4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMostrarEstado4;
        private System.Windows.Forms.Label labelMostrarCantidadA4;
        private System.Windows.Forms.Label labelMostrarCantidad4;
        private System.Windows.Forms.Button btncerrar4;
    }
}