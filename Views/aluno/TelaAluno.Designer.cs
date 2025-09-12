namespace MinhaBiblioteca
{
    partial class TelaAluno
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
            this.btnEsc = new System.Windows.Forms.Button();
            this.viewResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnPegar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(12, 12);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 2;
            this.btnEsc.Text = "Voltar";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // viewResult
            // 
            this.viewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewResult.Location = new System.Drawing.Point(185, 89);
            this.viewResult.Name = "viewResult";
            this.viewResult.Size = new System.Drawing.Size(388, 267);
            this.viewResult.TabIndex = 3;
            this.viewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewResult_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIGITE TÍTULO DO LIVRO QUE VOCÊ BUSCA";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(262, 55);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(248, 20);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPegar
            // 
            this.btnPegar.Location = new System.Drawing.Point(307, 378);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(147, 38);
            this.btnPegar.TabIndex = 6;
            this.btnPegar.Text = "Pegar emprestado";
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // TelaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewResult);
            this.Controls.Add(this.btnEsc);
            this.Name = "TelaAluno";
            this.Text = "MinhaBiblioteca-Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.viewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.DataGridView viewResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnPegar;
    }
}