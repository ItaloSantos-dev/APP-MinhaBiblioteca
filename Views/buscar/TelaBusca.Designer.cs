namespace MinhaBiblioteca
{
    partial class TelaBusca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLTituloBuscado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTxtresult = new System.Windows.Forms.Label();
            this.viewResult = new System.Windows.Forms.DataGridView();
            this.btnEsc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE O TÍTULO DO LIVRO QUE VOCÊ BUSCA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLTituloBuscado
            // 
            this.txtLTituloBuscado.Location = new System.Drawing.Point(236, 97);
            this.txtLTituloBuscado.Name = "txtLTituloBuscado";
            this.txtLTituloBuscado.Size = new System.Drawing.Size(306, 20);
            this.txtLTituloBuscado.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(343, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 33);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTxtresult
            // 
            this.lblTxtresult.AutoSize = true;
            this.lblTxtresult.Location = new System.Drawing.Point(340, 215);
            this.lblTxtresult.Name = "lblTxtresult";
            this.lblTxtresult.Size = new System.Drawing.Size(0, 13);
            this.lblTxtresult.TabIndex = 5;
            // 
            // viewResult
            // 
            this.viewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewResult.Location = new System.Drawing.Point(187, 231);
            this.viewResult.Name = "viewResult";
            this.viewResult.Size = new System.Drawing.Size(399, 150);
            this.viewResult.TabIndex = 6;
            this.viewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewResult_CellContentClick);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(13, 13);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 7;
            this.btnEsc.Text = "Voltar";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // TelaBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.viewResult);
            this.Controls.Add(this.lblTxtresult);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtLTituloBuscado);
            this.Controls.Add(this.label1);
            this.Name = "TelaBusca";
            this.Text = "TelaBusca";
            ((System.ComponentModel.ISupportInitialize)(this.viewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLTituloBuscado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTxtresult;
        private System.Windows.Forms.DataGridView viewResult;
        private System.Windows.Forms.Button btnEsc;
    }
}