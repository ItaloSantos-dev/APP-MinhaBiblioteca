namespace MinhaBiblioteca.Forms.registrar
{
    partial class TelaRegistro
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
            this.radioProf = new System.Windows.Forms.RadioButton();
            this.radioAluno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIden = new System.Windows.Forms.TextBox();
            this.lbliden = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual seu tipo de registro";
            // 
            // radioProf
            // 
            this.radioProf.AutoSize = true;
            this.radioProf.Location = new System.Drawing.Point(303, 86);
            this.radioProf.Name = "radioProf";
            this.radioProf.Size = new System.Drawing.Size(69, 17);
            this.radioProf.TabIndex = 1;
            this.radioProf.TabStop = true;
            this.radioProf.Text = "Professor";
            this.radioProf.UseVisualStyleBackColor = true;
            this.radioProf.CheckedChanged += new System.EventHandler(this.radioProf_CheckedChanged);
            // 
            // radioAluno
            // 
            this.radioAluno.AutoSize = true;
            this.radioAluno.Location = new System.Drawing.Point(413, 86);
            this.radioAluno.Name = "radioAluno";
            this.radioAluno.Size = new System.Drawing.Size(52, 17);
            this.radioAluno.TabIndex = 2;
            this.radioAluno.TabStop = true;
            this.radioAluno.Text = "Aluno";
            this.radioAluno.UseVisualStyleBackColor = true;
            this.radioAluno.CheckedChanged += new System.EventHandler(this.radioAluno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(303, 206);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(162, 20);
            this.txtCpf.TabIndex = 4;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            this.txtCpf.Click += new System.EventHandler(this.txtCpf_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(362, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 5;
            this.label.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(303, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtIden
            // 
            this.txtIden.Location = new System.Drawing.Point(301, 262);
            this.txtIden.Name = "txtIden";
            this.txtIden.Size = new System.Drawing.Size(162, 20);
            this.txtIden.TabIndex = 5;
            this.txtIden.TextChanged += new System.EventHandler(this.txtIden_TextChanged);
            // 
            // lbliden
            // 
            this.lbliden.AutoSize = true;
            this.lbliden.Location = new System.Drawing.Point(354, 235);
            this.lbliden.Name = "lbliden";
            this.lbliden.Size = new System.Drawing.Size(68, 13);
            this.lbliden.TabIndex = 9;
            this.lbliden.Text = "Identificador:";
            this.lbliden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbliden.Click += new System.EventHandler(this.lbliden_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReg.Location = new System.Drawing.Point(344, 317);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(78, 23);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
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
            // TelaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtIden);
            this.Controls.Add(this.lbliden);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioAluno);
            this.Controls.Add(this.radioProf);
            this.Controls.Add(this.label1);
            this.Name = "TelaRegistro";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.TelaRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioProf;
        private System.Windows.Forms.RadioButton radioAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIden;
        private System.Windows.Forms.Label lbliden;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnEsc;
    }
}