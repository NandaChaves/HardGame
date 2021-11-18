
namespace HardGame
{
    partial class Funcionario
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
            this.mostrar = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.tbx_tipo = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_sexo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_loja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(168, 86);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 22;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(168, 58);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 21;
            this.update.Text = "Atualizar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(168, 31);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 20;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(168, 4);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 19;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // tbx_tipo
            // 
            this.tbx_tipo.Location = new System.Drawing.Point(62, 61);
            this.tbx_tipo.Name = "tbx_tipo";
            this.tbx_tipo.Size = new System.Drawing.Size(100, 20);
            this.tbx_tipo.TabIndex = 18;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(62, 33);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(100, 20);
            this.tbx_nome.TabIndex = 17;
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(62, 6);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(100, 20);
            this.tbx_id.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // tbx_sexo
            // 
            this.tbx_sexo.Location = new System.Drawing.Point(62, 89);
            this.tbx_sexo.Name = "tbx_sexo";
            this.tbx_sexo.Size = new System.Drawing.Size(100, 20);
            this.tbx_sexo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sexo";
            // 
            // tbx_loja
            // 
            this.tbx_loja.Location = new System.Drawing.Point(62, 115);
            this.tbx_loja.Name = "tbx_loja";
            this.tbx_loja.Size = new System.Drawing.Size(100, 20);
            this.tbx_loja.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Loja";
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 157);
            this.Controls.Add(this.tbx_loja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tbx_tipo);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox tbx_tipo;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_loja;
        private System.Windows.Forms.Label label5;
    }
}