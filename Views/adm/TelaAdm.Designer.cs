namespace MinhaBiblioteca.Views.adm
{
    partial class TelaAdm
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
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnExibirlivros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(4, 5);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 5;
            this.btnEsc.Text = "Voltar";
            this.btnEsc.UseVisualStyleBackColor = true;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmp.Location = new System.Drawing.Point(292, 234);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(156, 53);
            this.btnEmp.TabIndex = 4;
            this.btnEmp.Text = "VER EMPRÉSTIMOS";
            this.btnEmp.UseVisualStyleBackColor = false;
            // 
            // btnExibirlivros
            // 
            this.btnExibirlivros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExibirlivros.Location = new System.Drawing.Point(292, 127);
            this.btnExibirlivros.Name = "btnExibirlivros";
            this.btnExibirlivros.Size = new System.Drawing.Size(156, 53);
            this.btnExibirlivros.TabIndex = 3;
            this.btnExibirlivros.Text = "VER LIVROS";
            this.btnExibirlivros.UseVisualStyleBackColor = false;
            // 
            // TelaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnExibirlivros);
            this.Name = "TelaAdm";
            this.Text = "TelaAdm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnExibirlivros;
    }
}