
namespace HardGame
{
    partial class Tem
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
            this.adicionar = new System.Windows.Forms.Button();
            this.tbx_loja = new System.Windows.Forms.TextBox();
            this.tbx_nif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(181, 54);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(75, 23);
            this.adicionar.TabIndex = 19;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // tbx_loja
            // 
            this.tbx_loja.Location = new System.Drawing.Point(72, 71);
            this.tbx_loja.Name = "tbx_loja";
            this.tbx_loja.Size = new System.Drawing.Size(100, 20);
            this.tbx_loja.TabIndex = 17;
            // 
            // tbx_nif
            // 
            this.tbx_nif.Location = new System.Drawing.Point(72, 44);
            this.tbx_nif.Name = "tbx_nif";
            this.tbx_nif.Size = new System.Drawing.Size(100, 20);
            this.tbx_nif.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adicionar um cliente a uma loja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Loja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "NIF Cliente";
            // 
            // Tem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 104);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tbx_loja);
            this.Controls.Add(this.tbx_nif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tem";
            this.Text = "Tem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox tbx_loja;
        private System.Windows.Forms.TextBox tbx_nif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}