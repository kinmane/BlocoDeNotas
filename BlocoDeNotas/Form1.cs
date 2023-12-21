using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        bool alterado;
        int zoom = 100;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(Int32.Parse(config.AppSettings.Settings["windowPositionX"].Value),
                               Int32.Parse(config.AppSettings.Settings["windowPositionY"].Value));
            this.Size = new Size(Int32.Parse(config.AppSettings.Settings["sizeW"].Value),
                               Int32.Parse(config.AppSettings.Settings["sizeH"].Value));
            this.Text = "";

            barraDeStatusToolStripMenuItem.Checked = true;
            this.atualizaPosicao();
        }

        public void atualizaPosicao()
        {
            int linha = rchTxtBxConteudo.GetLineFromCharIndex(rchTxtBxConteudo.SelectionStart) + 1;
            int coluna = rchTxtBxConteudo.SelectionStart - rchTxtBxConteudo.GetFirstCharIndexOfCurrentLine() + 1;
            tlStrpSttsLblPosicionamento.Text = "Ln: " + linha.ToString() + " Col: " + coluna.ToString();
        }

        private void rchTxtBxConteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.abrir();
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                }
                else
                {
                    if (this.Text != "")
                    {
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }

            }
        }

        private void abrir()
        {
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //coloca o nome do arquivo ocmo titulo do formulario
                this.Text = opnFlDlgAbrir.FileName;
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    rchTxtBxConteudo.Rtf = reader.ReadToEnd();
                    alterado = false;
                }

            }
        }

        private void salvar(String arquivo)
        {
            if (arquivo != "")
            {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(rchTxtBxConteudo.Rtf);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            }
            else
            {
                MessageBox.Show("Nome de arquivo inválido!", "Salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarComo()
        {
            if (svFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.salvar(svFlDlgAbrir.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                this.salvar(this.Text);
            }
            else
            {
                this.salvarComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
                rchTxtBxConteudo.SelectedRtf = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rchTxtBxConteudo.SelectedRtf = (String)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                rchTxtBxConteudo.SelectedRtf = "";
            }
        }

        private void buscarComOBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                String texto = rchTxtBxConteudo.SelectedText;
                texto.Replace(" ", "+");
                System.Diagnostics.Process.Start("microsoft-edge:http://www.bing.com/search?q=" + texto);
            }
            else
            {
                MessageBox.Show("Selecione um texto para buscar!", "Buscar",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectAll();
        }

        private void horadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectedText = DateTime.Now.ToString();
        }

        private void quebraAutomáticaDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraAutomáticaDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rchTxtBxConteudo.WordWrap = false;
            }
            else
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                rchTxtBxConteudo.WordWrap = true;
            }
        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgStpDlgConfiguraPagina.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prntDlgImprimir.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Text = "";
                rchTxtBxConteudo.Text = "";
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    rchTxtBxConteudo.Text = "";
                }
                else
                {
                    if (this.Text != "")
                    {
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fntDlgFonte.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxConteudo.SelectionFont = fntDlgFonte.Font;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            config.AppSettings.Settings["windowPositionX"].Value = this.Location.X.ToString();
            config.AppSettings.Settings["windowPositionY"].Value = this.Location.Y.ToString();
            config.AppSettings.Settings["sizeW"].Value = this.Size.Width.ToString();
            config.AppSettings.Settings["sizeH"].Value = this.Size.Height.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            sttsStrpInformacoes.Visible = !sttsStrpInformacoes.Visible;
        }

        private void atualizaZoom()
        {
            tlStrpSttsLblZoom.Text = zoom.ToString() + "%";
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom++;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, rchTxtBxConteudo.Font.Size + 1, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom--;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, rchTxtBxConteudo.Font.Size - 1, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void restaurarZoomPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            rchTxtBxConteudo.Font = new Font(rchTxtBxConteudo.Font.FontFamily, 12, rchTxtBxConteudo.Font.Style);
            this.atualizaZoom();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clrDlgCor.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxConteudo.SelectionColor = clrDlgCor.Color;
            }
        }

        private void substituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Substituir frm = new Substituir();
            frm.txtBxLocaliza.Text = rchTxtBxConteudo.SelectedText;
            frm.Show(this);
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizar frm = new Localizar();
            frm.txtBxLocaliza.Text = rchTxtBxConteudo.SelectedText;
            frm.Show(this);
        }

        private void sobreOBlocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre frm = new Sobre();
            frm.Show(this);
        }
    }
}
