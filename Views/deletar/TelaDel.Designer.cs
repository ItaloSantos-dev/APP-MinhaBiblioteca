namespace MinhaBiblioteca
{
    partial class TelaDel
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
            this.viewResult = new System.Windows.Forms.DataGridView();
            this.lblTxtresult = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtLTituloBuscado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEsc = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // viewResult
            // 
            this.viewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewResult.Location = new System.Drawing.Point(197, 233);
            this.viewResult.Name = "viewResult";
            this.viewResult.Size = new System.Drawing.Size(399, 150);
            this.viewResult.TabIndex = 11;
            this.viewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewResult_CellContentClick);
            // 
            // lblTxtresult
            // 
            this.lblTxtresult.AutoSize = true;
            this.lblTxtresult.Location = new System.Drawing.Point(350, 217);
            this.lblTxtresult.Name = "lblTxtresult";
            this.lblTxtresult.Size = new System.Drawing.Size(0, 13);
            this.lblTxtresult.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(353, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtLTituloBuscado
            // 
            this.txtLTituloBuscado.Location = new System.Drawing.Point(246, 99);
            this.txtLTituloBuscado.Name = "txtLTituloBuscado";
            this.txtLTituloBuscado.Size = new System.Drawing.Size(306, 20);
            this.txtLTituloBuscado.TabIndex = 8;
            this.txtLTituloBuscado.TextChanged += new System.EventHandler(this.txtLTituloBuscado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "DIGITE O TÍTULO DO LIVRO QUE DESEJA APAGAR";
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(13, 13);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 12;
            this.btnEsc.Text = "Voltar";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.Location = new System.Drawing.Point(353, 406);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 23);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.viewResult);
            this.Controls.Add(this.lblTxtresult);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtLTituloBuscado);
            this.Controls.Add(this.label1);
            this.Name = "TelaDel";
            this.Text = "TelaDel";
            ((System.ComponentModel.ISupportInitialize)(this.viewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewResult;
        private System.Windows.Forms.Label lblTxtresult;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtLTituloBuscado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnDel;
    }
}