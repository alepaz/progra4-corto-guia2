namespace Corto_guia2
{
    partial class Ejercicio2
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(129, 37);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(120, 20);
            this.txtNum.TabIndex = 0;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(155, 16);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(69, 16);
            this.lblnum.TabIndex = 4;
            this.lblnum.Text = "Número: 1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCalcular.Location = new System.Drawing.Point(129, 63);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Agregar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nota1,
            this.nota2,
            this.nota3,
            this.nota4,
            this.prome,
            this.desvi});
            this.dataGridView1.Location = new System.Drawing.Point(20, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(352, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // nota1
            // 
            this.nota1.HeaderText = "Primer nota";
            this.nota1.Name = "nota1";
            this.nota1.ReadOnly = true;
            // 
            // nota2
            // 
            this.nota2.HeaderText = "Segunda nota";
            this.nota2.Name = "nota2";
            this.nota2.ReadOnly = true;
            // 
            // nota3
            // 
            this.nota3.HeaderText = "Tercer nota";
            this.nota3.Name = "nota3";
            this.nota3.ReadOnly = true;
            // 
            // nota4
            // 
            this.nota4.HeaderText = "Cuarta Nota";
            this.nota4.Name = "nota4";
            this.nota4.ReadOnly = true;
            // 
            // prome
            // 
            this.prome.HeaderText = "Promedio";
            this.prome.Name = "prome";
            this.prome.ReadOnly = true;
            // 
            // desvi
            // 
            this.desvi.HeaderText = "Desviación Tipica";
            this.desvi.Name = "desvi";
            this.desvi.ReadOnly = true;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 275);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtNum);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn prome;
        private System.Windows.Forms.DataGridViewTextBoxColumn desvi;
    }
}