namespace Pry_EstructuraDatos
{
    partial class frmCola
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTraCola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTraCola = new System.Windows.Forms.Label();
            this.lblNomCola = new System.Windows.Forms.Label();
            this.lblCodCola = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTablaCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtTraCola);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomCola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodCola);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarC);
            this.groupBox1.Location = new System.Drawing.Point(215, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtTraCola
            // 
            this.txtTraCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCola.Location = new System.Drawing.Point(78, 118);
            this.txtTraCola.Name = "txtTraCola";
            this.txtTraCola.Size = new System.Drawing.Size(100, 21);
            this.txtTraCola.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tramite:";
            // 
            // txtNomCola
            // 
            this.txtNomCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCola.Location = new System.Drawing.Point(78, 81);
            this.txtNomCola.Name = "txtNomCola";
            this.txtNomCola.Size = new System.Drawing.Size(100, 21);
            this.txtNomCola.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtCodCola
            // 
            this.txtCodCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCola.Location = new System.Drawing.Point(78, 44);
            this.txtCodCola.Name = "txtCodCola";
            this.txtCodCola.Size = new System.Drawing.Size(100, 21);
            this.txtCodCola.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(44, 154);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(119, 33);
            this.btnAgregarC.TabIndex = 0;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.lblTraCola);
            this.groupBox2.Controls.Add(this.lblNomCola);
            this.groupBox2.Controls.Add(this.lblCodCola);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEliminarC);
            this.groupBox2.Location = new System.Drawing.Point(416, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // lblTraCola
            // 
            this.lblTraCola.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTraCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTraCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraCola.Location = new System.Drawing.Point(77, 116);
            this.lblTraCola.Name = "lblTraCola";
            this.lblTraCola.Size = new System.Drawing.Size(100, 22);
            this.lblTraCola.TabIndex = 9;
            this.lblTraCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomCola
            // 
            this.lblNomCola.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNomCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCola.Location = new System.Drawing.Point(77, 79);
            this.lblNomCola.Name = "lblNomCola";
            this.lblNomCola.Size = new System.Drawing.Size(100, 22);
            this.lblNomCola.TabIndex = 8;
            this.lblNomCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodCola
            // 
            this.lblCodCola.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCodCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCola.Location = new System.Drawing.Point(77, 43);
            this.lblCodCola.Name = "lblCodCola";
            this.lblCodCola.Size = new System.Drawing.Size(100, 22);
            this.lblCodCola.TabIndex = 7;
            this.lblCodCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tramite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Location = new System.Drawing.Point(44, 154);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(119, 33);
            this.btnEliminarC.TabIndex = 0;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.dgvTablaCola);
            this.groupBox3.Controls.Add(this.lstCola);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 218);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y un  Grilla";
            // 
            // dgvTablaCola
            // 
            this.dgvTablaCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTablaCola.Location = new System.Drawing.Point(203, 18);
            this.dgvTablaCola.Name = "dgvTablaCola";
            this.dgvTablaCola.Size = new System.Drawing.Size(379, 186);
            this.dgvTablaCola.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(6, 18);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(190, 186);
            this.lstCola.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::Pry_EstructuraDatos.Properties.Resources.cola;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.TextBox txtTraCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTablaCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblCodCola;
        private System.Windows.Forms.Label lblTraCola;
        private System.Windows.Forms.Label lblNomCola;
    }
}