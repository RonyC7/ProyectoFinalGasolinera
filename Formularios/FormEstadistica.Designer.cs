namespace ProyectoFinalGasolinera
{
    partial class FormEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadistica));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerCierreCajas = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewCierreCajas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarEstadistica = new System.Windows.Forms.Button();
            this.btnMostrarDCierre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewInformeAbaPrepa = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerInfoAbasPrepa = new System.Windows.Forms.DateTimePicker();
            this.buttonMAbasPre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMasUti = new System.Windows.Forms.Label();
            this.labelMenosUtil = new System.Windows.Forms.Label();
            this.btnMostrarBombas = new System.Windows.Forms.Button();
            this.btnActualizarBombas = new System.Windows.Forms.Button();
            this.labelMasUsada = new System.Windows.Forms.Label();
            this.labelMenosUsada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAbasLLeno = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerAbasTanqueLleno = new System.Windows.Forms.DateTimePicker();
            this.buttonMAbasTanq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCierreCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformeAbaPrepa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbasLLeno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre de cajas diarios";
            // 
            // dateTimePickerCierreCajas
            // 
            this.dateTimePickerCierreCajas.Location = new System.Drawing.Point(41, 48);
            this.dateTimePickerCierreCajas.Name = "dateTimePickerCierreCajas";
            this.dateTimePickerCierreCajas.Size = new System.Drawing.Size(449, 20);
            this.dateTimePickerCierreCajas.TabIndex = 1;
            // 
            // dataGridViewCierreCajas
            // 
            this.dataGridViewCierreCajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewCierreCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCierreCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewCierreCajas.Location = new System.Drawing.Point(41, 74);
            this.dataGridViewCierreCajas.Name = "dataGridViewCierreCajas";
            this.dataGridViewCierreCajas.Size = new System.Drawing.Size(449, 85);
            this.dataGridViewCierreCajas.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre_Cliente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad_Abastecida";
            this.Column4.Name = "Column4";
            // 
            // btnCerrarEstadistica
            // 
            this.btnCerrarEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarEstadistica.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCerrarEstadistica.FlatAppearance.BorderSize = 2;
            this.btnCerrarEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnCerrarEstadistica.Location = new System.Drawing.Point(1097, 12);
            this.btnCerrarEstadistica.Name = "btnCerrarEstadistica";
            this.btnCerrarEstadistica.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarEstadistica.TabIndex = 3;
            this.btnCerrarEstadistica.Text = "Cerrar";
            this.btnCerrarEstadistica.UseVisualStyleBackColor = false;
            this.btnCerrarEstadistica.Click += new System.EventHandler(this.btnCerrarEstadistica_Click);
            // 
            // btnMostrarDCierre
            // 
            this.btnMostrarDCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMostrarDCierre.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnMostrarDCierre.FlatAppearance.BorderSize = 2;
            this.btnMostrarDCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDCierre.ForeColor = System.Drawing.Color.White;
            this.btnMostrarDCierre.Location = new System.Drawing.Point(387, 12);
            this.btnMostrarDCierre.Name = "btnMostrarDCierre";
            this.btnMostrarDCierre.Size = new System.Drawing.Size(103, 23);
            this.btnMostrarDCierre.TabIndex = 4;
            this.btnMostrarDCierre.Text = "Mostrar Datos";
            this.btnMostrarDCierre.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(41, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe Abastecimiento \"Prepagos\"";
            // 
            // dataGridViewInformeAbaPrepa
            // 
            this.dataGridViewInformeAbaPrepa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewInformeAbaPrepa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformeAbaPrepa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewInformeAbaPrepa.Location = new System.Drawing.Point(45, 240);
            this.dataGridViewInformeAbaPrepa.Name = "dataGridViewInformeAbaPrepa";
            this.dataGridViewInformeAbaPrepa.Size = new System.Drawing.Size(445, 89);
            this.dataGridViewInformeAbaPrepa.TabIndex = 6;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hora";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre_Cliente";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Abastecimientos_Prepagos";
            this.Column8.Name = "Column8";
            // 
            // dateTimePickerInfoAbasPrepa
            // 
            this.dateTimePickerInfoAbasPrepa.Location = new System.Drawing.Point(45, 209);
            this.dateTimePickerInfoAbasPrepa.Name = "dateTimePickerInfoAbasPrepa";
            this.dateTimePickerInfoAbasPrepa.Size = new System.Drawing.Size(445, 20);
            this.dateTimePickerInfoAbasPrepa.TabIndex = 7;
            // 
            // buttonMAbasPre
            // 
            this.buttonMAbasPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMAbasPre.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMAbasPre.FlatAppearance.BorderSize = 2;
            this.buttonMAbasPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMAbasPre.ForeColor = System.Drawing.Color.White;
            this.buttonMAbasPre.Location = new System.Drawing.Point(401, 183);
            this.buttonMAbasPre.Name = "buttonMAbasPre";
            this.buttonMAbasPre.Size = new System.Drawing.Size(88, 23);
            this.buttonMAbasPre.TabIndex = 8;
            this.buttonMAbasPre.Text = "Mostrar Datos";
            this.buttonMAbasPre.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(574, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "informes de bomba";
            // 
            // labelMasUti
            // 
            this.labelMasUti.AutoSize = true;
            this.labelMasUti.Location = new System.Drawing.Point(575, 74);
            this.labelMasUti.Name = "labelMasUti";
            this.labelMasUti.Size = new System.Drawing.Size(106, 13);
            this.labelMasUti.TabIndex = 10;
            this.labelMasUti.Text = "Bomba Mas Utilizada";
            // 
            // labelMenosUtil
            // 
            this.labelMenosUtil.AutoSize = true;
            this.labelMenosUtil.Location = new System.Drawing.Point(575, 117);
            this.labelMenosUtil.Name = "labelMenosUtil";
            this.labelMenosUtil.Size = new System.Drawing.Size(118, 13);
            this.labelMenosUtil.TabIndex = 11;
            this.labelMenosUtil.Text = "Bomba Menos Utilizada";
            // 
            // btnMostrarBombas
            // 
            this.btnMostrarBombas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMostrarBombas.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnMostrarBombas.FlatAppearance.BorderSize = 2;
            this.btnMostrarBombas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarBombas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarBombas.Location = new System.Drawing.Point(962, 64);
            this.btnMostrarBombas.Name = "btnMostrarBombas";
            this.btnMostrarBombas.Size = new System.Drawing.Size(110, 23);
            this.btnMostrarBombas.TabIndex = 12;
            this.btnMostrarBombas.Text = "Mostrar Datos";
            this.btnMostrarBombas.UseVisualStyleBackColor = false;
            // 
            // btnActualizarBombas
            // 
            this.btnActualizarBombas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActualizarBombas.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnActualizarBombas.FlatAppearance.BorderSize = 2;
            this.btnActualizarBombas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarBombas.ForeColor = System.Drawing.Color.White;
            this.btnActualizarBombas.Location = new System.Drawing.Point(962, 112);
            this.btnActualizarBombas.Name = "btnActualizarBombas";
            this.btnActualizarBombas.Size = new System.Drawing.Size(110, 23);
            this.btnActualizarBombas.TabIndex = 13;
            this.btnActualizarBombas.Text = "Actualizar Bombas";
            this.btnActualizarBombas.UseVisualStyleBackColor = false;
            // 
            // labelMasUsada
            // 
            this.labelMasUsada.AutoSize = true;
            this.labelMasUsada.Location = new System.Drawing.Point(788, 69);
            this.labelMasUsada.Name = "labelMasUsada";
            this.labelMasUsada.Size = new System.Drawing.Size(68, 13);
            this.labelMasUsada.TabIndex = 14;
            this.labelMasUsada.Text = "Mas utilizada";
            this.labelMasUsada.Visible = false;
            // 
            // labelMenosUsada
            // 
            this.labelMenosUsada.AutoSize = true;
            this.labelMenosUsada.Location = new System.Drawing.Point(788, 117);
            this.labelMenosUsada.Name = "labelMenosUsada";
            this.labelMenosUsada.Size = new System.Drawing.Size(80, 13);
            this.labelMenosUsada.TabIndex = 15;
            this.labelMenosUsada.Text = "Menos utilizada";
            this.labelMenosUsada.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(574, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Informe Abastecimiento \"Tanque lleno\"";
            // 
            // dataGridViewAbasLLeno
            // 
            this.dataGridViewAbasLLeno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewAbasLLeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbasLLeno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewAbasLLeno.Location = new System.Drawing.Point(578, 240);
            this.dataGridViewAbasLLeno.Name = "dataGridViewAbasLLeno";
            this.dataGridViewAbasLLeno.Size = new System.Drawing.Size(494, 89);
            this.dataGridViewAbasLLeno.TabIndex = 17;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fecha";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Hora";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Nombre_Cliente";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Abastecimiento_Tlleno";
            this.Column12.Name = "Column12";
            // 
            // dateTimePickerAbasTanqueLleno
            // 
            this.dateTimePickerAbasTanqueLleno.Location = new System.Drawing.Point(578, 209);
            this.dateTimePickerAbasTanqueLleno.Name = "dateTimePickerAbasTanqueLleno";
            this.dateTimePickerAbasTanqueLleno.Size = new System.Drawing.Size(494, 20);
            this.dateTimePickerAbasTanqueLleno.TabIndex = 18;
            // 
            // buttonMAbasTanq
            // 
            this.buttonMAbasTanq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMAbasTanq.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMAbasTanq.FlatAppearance.BorderSize = 2;
            this.buttonMAbasTanq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMAbasTanq.ForeColor = System.Drawing.Color.White;
            this.buttonMAbasTanq.Location = new System.Drawing.Point(972, 182);
            this.buttonMAbasTanq.Name = "buttonMAbasTanq";
            this.buttonMAbasTanq.Size = new System.Drawing.Size(100, 23);
            this.buttonMAbasTanq.TabIndex = 19;
            this.buttonMAbasTanq.Text = "Mostrar Datos";
            this.buttonMAbasTanq.UseVisualStyleBackColor = false;
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 369);
            this.Controls.Add(this.buttonMAbasTanq);
            this.Controls.Add(this.dateTimePickerAbasTanqueLleno);
            this.Controls.Add(this.dataGridViewAbasLLeno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMenosUsada);
            this.Controls.Add(this.labelMasUsada);
            this.Controls.Add(this.btnActualizarBombas);
            this.Controls.Add(this.btnMostrarBombas);
            this.Controls.Add(this.labelMenosUtil);
            this.Controls.Add(this.labelMasUti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMAbasPre);
            this.Controls.Add(this.dateTimePickerInfoAbasPrepa);
            this.Controls.Add(this.dataGridViewInformeAbaPrepa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDCierre);
            this.Controls.Add(this.btnCerrarEstadistica);
            this.Controls.Add(this.dataGridViewCierreCajas);
            this.Controls.Add(this.dateTimePickerCierreCajas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstadistica";
            this.Text = "Formulario Estadistica";
            this.Load += new System.EventHandler(this.FormEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCierreCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformeAbaPrepa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbasLLeno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCierreCajas;
        private System.Windows.Forms.DataGridView dataGridViewCierreCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnCerrarEstadistica;
        private System.Windows.Forms.Button btnMostrarDCierre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewInformeAbaPrepa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DateTimePicker dateTimePickerInfoAbasPrepa;
        private System.Windows.Forms.Button buttonMAbasPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMasUti;
        private System.Windows.Forms.Label labelMenosUtil;
        private System.Windows.Forms.Button btnMostrarBombas;
        private System.Windows.Forms.Button btnActualizarBombas;
        private System.Windows.Forms.Label labelMasUsada;
        private System.Windows.Forms.Label labelMenosUsada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAbasLLeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbasTanqueLleno;
        private System.Windows.Forms.Button buttonMAbasTanq;
    }
}