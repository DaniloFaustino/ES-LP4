namespace Cadastro_de_Contatos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cod1 = new System.Windows.Forms.Label();
            this.LabNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LabSobrenome = new System.Windows.Forms.Label();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.PicCoala = new System.Windows.Forms.PictureBox();
            this.LabCidade = new System.Windows.Forms.Label();
            this.LabEstado = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.LabNascimento = new System.Windows.Forms.Label();
            this.LabEmail = new System.Windows.Forms.Label();
            this.TxtNascimento = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCoala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtNascimento);
            this.groupBox1.Controls.Add(this.LabEmail);
            this.groupBox1.Controls.Add(this.LabNascimento);
            this.groupBox1.Controls.Add(this.TxtEstado);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.LabEstado);
            this.groupBox1.Controls.Add(this.LabCidade);
            this.groupBox1.Controls.Add(this.PicCoala);
            this.groupBox1.Controls.Add(this.TxtSobrenome);
            this.groupBox1.Controls.Add(this.LabSobrenome);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.LabNome);
            this.groupBox1.Controls.Add(this.Cod1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(650, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Cod1
            // 
            this.Cod1.AutoSize = true;
            this.Cod1.Location = new System.Drawing.Point(16, 16);
            this.Cod1.Name = "Cod1";
            this.Cod1.Size = new System.Drawing.Size(40, 13);
            this.Cod1.TabIndex = 0;
            this.Cod1.Text = "Código";
            // 
            // LabNome
            // 
            this.LabNome.AutoSize = true;
            this.LabNome.Enabled = false;
            this.LabNome.Location = new System.Drawing.Point(16, 43);
            this.LabNome.Name = "LabNome";
            this.LabNome.Size = new System.Drawing.Size(35, 13);
            this.LabNome.TabIndex = 1;
            this.LabNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(19, 59);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(177, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // LabSobrenome
            // 
            this.LabSobrenome.AutoSize = true;
            this.LabSobrenome.Enabled = false;
            this.LabSobrenome.Location = new System.Drawing.Point(211, 43);
            this.LabSobrenome.Name = "LabSobrenome";
            this.LabSobrenome.Size = new System.Drawing.Size(61, 13);
            this.LabSobrenome.TabIndex = 3;
            this.LabSobrenome.Text = "Sobrenome";
            this.LabSobrenome.Click += new System.EventHandler(this.LabSobrenome_Click);
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Location = new System.Drawing.Point(214, 59);
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(177, 20);
            this.TxtSobrenome.TabIndex = 4;
            // 
            // PicCoala
            // 
            this.PicCoala.Image = ((System.Drawing.Image)(resources.GetObject("PicCoala.Image")));
            this.PicCoala.Location = new System.Drawing.Point(430, 16);
            this.PicCoala.Name = "PicCoala";
            this.PicCoala.Size = new System.Drawing.Size(166, 162);
            this.PicCoala.TabIndex = 5;
            this.PicCoala.TabStop = false;
            // 
            // LabCidade
            // 
            this.LabCidade.AutoSize = true;
            this.LabCidade.Enabled = false;
            this.LabCidade.Location = new System.Drawing.Point(16, 91);
            this.LabCidade.Name = "LabCidade";
            this.LabCidade.Size = new System.Drawing.Size(40, 13);
            this.LabCidade.TabIndex = 6;
            this.LabCidade.Text = "Cidade";
            // 
            // LabEstado
            // 
            this.LabEstado.AutoSize = true;
            this.LabEstado.Enabled = false;
            this.LabEstado.Location = new System.Drawing.Point(211, 91);
            this.LabEstado.Name = "LabEstado";
            this.LabEstado.Size = new System.Drawing.Size(40, 13);
            this.LabEstado.TabIndex = 7;
            this.LabEstado.Text = "Estado";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(19, 107);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(177, 20);
            this.TxtCidade.TabIndex = 8;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(214, 107);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(177, 20);
            this.TxtEstado.TabIndex = 9;
            // 
            // LabNascimento
            // 
            this.LabNascimento.AutoSize = true;
            this.LabNascimento.Enabled = false;
            this.LabNascimento.Location = new System.Drawing.Point(16, 142);
            this.LabNascimento.Name = "LabNascimento";
            this.LabNascimento.Size = new System.Drawing.Size(63, 13);
            this.LabNascimento.TabIndex = 10;
            this.LabNascimento.Text = "Nascimento";
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.Enabled = false;
            this.LabEmail.Location = new System.Drawing.Point(211, 142);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(32, 13);
            this.LabEmail.TabIndex = 11;
            this.LabEmail.Text = "Email";
            // 
            // TxtNascimento
            // 
            this.TxtNascimento.Location = new System.Drawing.Point(19, 158);
            this.TxtNascimento.Name = "TxtNascimento";
            this.TxtNascimento.Size = new System.Drawing.Size(177, 20);
            this.TxtNascimento.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(214, 158);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(177, 20);
            this.TxtEmail.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 217);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(577, 95);
            this.listBox1.TabIndex = 14;
            this.listBox1.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCoala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabSobrenome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LabNome;
        private System.Windows.Forms.Label Cod1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNascimento;
        private System.Windows.Forms.Label LabEmail;
        private System.Windows.Forms.Label LabNascimento;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LabEstado;
        private System.Windows.Forms.Label LabCidade;
        private System.Windows.Forms.PictureBox PicCoala;
        private System.Windows.Forms.TextBox TxtSobrenome;
    }
}

