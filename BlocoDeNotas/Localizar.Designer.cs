namespace BlocoDeNotas
{
    partial class Localizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localizar));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSubstitui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxLocaliza = new System.Windows.Forms.TextBox();
            this.chckBxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chckBxPalavraInteira = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSubstitui
            // 
            this.btnSubstitui.Location = new System.Drawing.Point(270, 12);
            this.btnSubstitui.Name = "btnSubstitui";
            this.btnSubstitui.Size = new System.Drawing.Size(75, 23);
            this.btnSubstitui.TabIndex = 8;
            this.btnSubstitui.Text = "Localizar";
            this.btnSubstitui.UseVisualStyleBackColor = true;
            this.btnSubstitui.Click += new System.EventHandler(this.btnSubstitui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Localizar:";
            // 
            // txtBxLocaliza
            // 
            this.txtBxLocaliza.Location = new System.Drawing.Point(70, 6);
            this.txtBxLocaliza.Name = "txtBxLocaliza";
            this.txtBxLocaliza.Size = new System.Drawing.Size(177, 20);
            this.txtBxLocaliza.TabIndex = 6;
            // 
            // chckBxCaseSensitive
            // 
            this.chckBxCaseSensitive.AutoSize = true;
            this.chckBxCaseSensitive.Location = new System.Drawing.Point(12, 35);
            this.chckBxCaseSensitive.Name = "chckBxCaseSensitive";
            this.chckBxCaseSensitive.Size = new System.Drawing.Size(198, 17);
            this.chckBxCaseSensitive.TabIndex = 10;
            this.chckBxCaseSensitive.Text = "Diferenciar Maiúsculas e Minúsculas";
            this.chckBxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chckBxPalavraInteira
            // 
            this.chckBxPalavraInteira.AutoSize = true;
            this.chckBxPalavraInteira.Location = new System.Drawing.Point(12, 58);
            this.chckBxPalavraInteira.Name = "chckBxPalavraInteira";
            this.chckBxPalavraInteira.Size = new System.Drawing.Size(137, 17);
            this.chckBxPalavraInteira.TabIndex = 11;
            this.chckBxPalavraInteira.Text = "Coincidir Palavra Inteira";
            this.chckBxPalavraInteira.UseVisualStyleBackColor = true;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 81);
            this.Controls.Add(this.chckBxPalavraInteira);
            this.Controls.Add(this.chckBxCaseSensitive);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubstitui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLocaliza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Localizar";
            this.Text = "Localizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSubstitui;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBxLocaliza;
        private System.Windows.Forms.CheckBox chckBxCaseSensitive;
        private System.Windows.Forms.CheckBox chckBxPalavraInteira;
    }
}