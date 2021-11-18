
namespace HardGame
{
    partial class Cliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_nif = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_sobrenome = new System.Windows.Forms.TextBox();
            this.mostrar = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sobrenome";
            // 
            // tbx_nif
            // 
            this.tbx_nif.Location = new System.Drawing.Point(63, 10);
            this.tbx_nif.Name = "tbx_nif";
            this.tbx_nif.Size = new System.Drawing.Size(100, 20);
            this.tbx_nif.TabIndex = 3;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(63, 37);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(100, 20);
            this.tbx_nome.TabIndex = 4;
            this.tbx_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbx_sobrenome
            // 
            this.tbx_sobrenome.Location = new System.Drawing.Point(63, 65);
            this.tbx_sobrenome.Name = "tbx_sobrenome";
            this.tbx_sobrenome.Size = new System.Drawing.Size(100, 20);
            this.tbx_sobrenome.TabIndex = 5;
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(169, 90);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 12;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(169, 62);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 11;
            this.update.Text = "Atualizar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(169, 35);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 10;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(169, 8);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 9;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 138);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tbx_sobrenome);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_nif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_nif;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_sobrenome;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button adicionar;
    }
}