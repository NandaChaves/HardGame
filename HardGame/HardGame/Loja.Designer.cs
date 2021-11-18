
namespace HardGame
{
    partial class Loja
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
            this.tbx_cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.tbx_numero = new System.Windows.Forms.TextBox();
            this.tbx_rua = new System.Windows.Forms.TextBox();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_cidade
            // 
            this.tbx_cidade.Location = new System.Drawing.Point(61, 95);
            this.tbx_cidade.Name = "tbx_cidade";
            this.tbx_cidade.Size = new System.Drawing.Size(100, 20);
            this.tbx_cidade.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cidade";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(167, 92);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 36;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(167, 64);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 35;
            this.update.Text = "Atualizar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(167, 37);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 34;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(167, 10);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 33;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // tbx_numero
            // 
            this.tbx_numero.Location = new System.Drawing.Point(61, 67);
            this.tbx_numero.Name = "tbx_numero";
            this.tbx_numero.Size = new System.Drawing.Size(100, 20);
            this.tbx_numero.TabIndex = 32;
            // 
            // tbx_rua
            // 
            this.tbx_rua.Location = new System.Drawing.Point(61, 39);
            this.tbx_rua.Name = "tbx_rua";
            this.tbx_rua.Size = new System.Drawing.Size(100, 20);
            this.tbx_rua.TabIndex = 31;
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(61, 12);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(100, 20);
            this.tbx_id.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID";
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 133);
            this.Controls.Add(this.tbx_cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tbx_numero);
            this.Controls.Add(this.tbx_rua);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loja";
            this.Text = "Loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox tbx_numero;
        private System.Windows.Forms.TextBox tbx_rua;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}