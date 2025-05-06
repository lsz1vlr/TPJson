namespace JSON
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txIdade = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.list_clientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(98, 50);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(348, 50);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(601, 50);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(34, 13);
            this.lbIdade.TabIndex = 2;
            this.lbIdade.Text = "Idade";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(101, 66);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(100, 20);
            this.txNome.TabIndex = 3;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(351, 66);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 20);
            this.txEmail.TabIndex = 4;
            // 
            // txIdade
            // 
            this.txIdade.Location = new System.Drawing.Point(604, 66);
            this.txIdade.Name = "txIdade";
            this.txIdade.Size = new System.Drawing.Size(100, 20);
            this.txIdade.TabIndex = 5;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(101, 123);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(603, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(101, 165);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(603, 23);
            this.btAtualizar.TabIndex = 7;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(101, 391);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(603, 23);
            this.btDeletar.TabIndex = 9;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // list_clientes
            // 
            this.list_clientes.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.list_clientes.FormattingEnabled = true;
            this.list_clientes.Location = new System.Drawing.Point(101, 217);
            this.list_clientes.Name = "list_clientes";
            this.list_clientes.Size = new System.Drawing.Size(603, 147);
            this.list_clientes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_clientes);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txIdade);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txIdade;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.ListBox list_clientes;
    }
}

