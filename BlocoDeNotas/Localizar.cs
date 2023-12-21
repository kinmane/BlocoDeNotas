using System;
using System.Windows.Forms;
using System.Drawing;

namespace BlocoDeNotas
{
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubstitui_Click(object sender, EventArgs e)
        {
            String busca = txtBxLocaliza.Text;
            String texto = ((Form1)this.Owner).rchTxtBxConteudo.Text;

            RichTextBoxFinds regra = RichTextBoxFinds.None;
            if (chckBxCaseSensitive.Checked == true)
            {
                regra = RichTextBoxFinds.MatchCase;
            }
            if (chckBxPalavraInteira.Checked == true)
            {
                regra = RichTextBoxFinds.WholeWord;
            }
            int index = 0;

            while (index < ((Form1)this.Owner).rchTxtBxConteudo.Text.LastIndexOf(busca))
            {
                ((Form1)this.Owner).rchTxtBxConteudo.Find(busca, index, texto.Length, regra);
                ((Form1)this.Owner).rchTxtBxConteudo.SelectionBackColor = Color.Yellow;
                index = ((Form1)this.Owner).rchTxtBxConteudo.Text.IndexOf(busca, index) + 1;
            }
            this.Close();
        }
    }
}
