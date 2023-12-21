namespace BlocoDeNotas
{
    partial class Substituir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Substituir));
            this.txtBxLocaliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSubstitui = new System.Windows.Forms.TextBox();
            this.btnSubstitui = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxLocaliza
            // 
            this.txtBxLocaliza.Location = new System.Drawing.Point(89, 6);
            this.txtBxLocaliza.Name = "txtBxLocaliza";
            this.txtBxLocaliza.Size = new System.Drawing.Size(177, 20);
            this.txtBxLocaliza.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Substituir por:";
            // 
            // txtBxSubstitui
            // 
            this.txtBxSubstitui.Location = new System.Drawing.Point(89, 39);
            this.txtBxSubstitui.Name = "txtBxSubstitui";
            this.txtBxSubstitui.Size = new System.Drawing.Size(177, 20);
            this.txtBxSubstitui.TabIndex = 3;
            // 
            // btnSubstitui
            // 
            this.btnSubstitui.Location = new System.Drawing.Point(289, 7);
            this.btnSubstitui.Name = "btnSubstitui";
            this.btnSubstitui.Size = new System.Drawing.Size(75, 23);
            this.btnSubstitui.TabIndex = 4;
            this.btnSubstitui.Text = "Substituir tudo";
            this.btnSubstitui.UseVisualStyleBackColor = true;
            this.btnSubstitui.Click += new System.EventHandler(this.btnSubstitui_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(289, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Substituir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 72);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubstitui);
            this.Controls.Add(this.txtBxSubstitui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLocaliza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Substituir";
            this.Text = "Substituir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSubstitui;
        private System.Windows.Forms.Button btnSubstitui;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtBxLocaliza;
    }
}