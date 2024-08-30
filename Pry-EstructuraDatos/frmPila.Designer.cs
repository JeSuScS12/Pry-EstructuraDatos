namespace Pry_EstructuraDatos
{
    partial class frmPila
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTablaPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTraPila = new System.Windows.Forms.Label();
            this.lblNomPila = new System.Windows.Forms.Label();
            this.lblCodPila = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTraPila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomPila = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.dgvTablaPila);
            this.groupBox3.Controls.Add(this.lstPila);
            this.groupBox3.Location = new System.Drawing.Point(11, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 218);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y un  Grilla";
            // 
            // dgvTablaPila
            // 
            this.dgvTablaPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTablaPila.Location = new System.Drawing.Point(203, 18);
            this.dgvTablaPila.Name = "dgvTablaPila";
            this.dgvTablaPila.Size = new System.Drawing.Size(379, 186);
            this.dgvTablaPila.TabIndex = 11;
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
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(6, 18);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(190, 186);
            this.lstPila.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.lblTraPila);
            this.groupBox2.Controls.Add(this.lblNomPila);
            this.groupBox2.Controls.Add(this.lblCodPila);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEliminarP);
            this.groupBox2.Location = new System.Drawing.Point(415, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 210);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // lblTraPila
            // 
            this.lblTraPila.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTraPila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTraPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraPila.Location = new System.Drawing.Point(77, 116);
            this.lblTraPila.Name = "lblTraPila";
            this.lblTraPila.Size = new System.Drawing.Size(100, 22);
            this.lblTraPila.TabIndex = 9;
            this.lblTraPila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomPila
            // 
            this.lblNomPila.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNomPila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPila.Location = new System.Drawing.Point(77, 79);
            this.lblNomPila.Name = "lblNomPila";
            this.lblNomPila.Size = new System.Drawing.Size(100, 22);
            this.lblNomPila.TabIndex = 8;
            this.lblNomPila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodPila
            // 
            this.lblCodPila.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCodPila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPila.Location = new System.Drawing.Point(77, 43);
            this.lblCodPila.Name = "lblCodPila";
            this.lblCodPila.Size = new System.Drawing.Size(100, 22);
            this.lblCodPila.TabIndex = 7;
            this.lblCodPila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(44, 154);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(119, 33);
            this.btnEliminarP.TabIndex = 0;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtTraPila);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomPila);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodPila);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarP);
            this.groupBox1.Location = new System.Drawing.Point(214, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 210);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtTraPila
            // 
            this.txtTraPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraPila.Location = new System.Drawing.Point(78, 118);
            this.txtTraPila.Name = "txtTraPila";
            this.txtTraPila.Size = new System.Drawing.Size(100, 21);
            this.txtTraPila.TabIndex = 6;
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
            // txtNomPila
            // 
            this.txtNomPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPila.Location = new System.Drawing.Point(78, 81);
            this.txtNomPila.Name = "txtNomPila";
            this.txtNomPila.Size = new System.Drawing.Size(100, 21);
            this.txtNomPila.TabIndex = 4;
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
            // txtCodPila
            // 
            this.txtCodPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPila.Location = new System.Drawing.Point(78, 44);
            this.txtCodPila.Name = "txtCodPila";
            this.txtCodPila.Size = new System.Drawing.Size(100, 21);
            this.txtCodPila.TabIndex = 2;
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
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(44, 154);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(119, 33);
            this.btnAgregarP.TabIndex = 0;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::Pry_EstructuraDatos.Properties.Resources.pila;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTablaPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTraPila;
        private System.Windows.Forms.Label lblNomPila;
        private System.Windows.Forms.Label lblCodPila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTraPila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomPila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}