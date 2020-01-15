using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace fxAtualizadorDanfeSAT
{
    public partial class fImportarArquivos : Form
    {
        public fImportarArquivos()
        {
            InitializeComponent();
        }

        private void btnCarregarArquivos_Click(object sender, EventArgs e)
        {
            PreparaParaCarregarDados();
            AbrePastaECarregaArquivos();
        }

        private void btnGerarScript_Click(object sender, EventArgs e)
        {
            LeArquivosEGeraResultado();
        }

        /// <summary>
        /// Essa função le os arquivos que foram carregados e gera o script de atualização
        /// </summary>
        public void LeArquivosEGeraResultado() {
            var itensSelecionados = listaArquivos.CheckedItems;
            if (itensSelecionados.Count <= 0) {
                MessageBox.Show("Não foram encontrados arquivos!");
                return;
            }
            foreach (var item in listaArquivos.CheckedItems) {
                var arquivoCupomFiscal = DevolveArquivo(item.ToString());
                if (File.Exists(arquivoCupomFiscal))
                {
                    try
                    {
                        XDocument cupomFiscal = XDocument.Load(arquivoCupomFiscal);
                        var numeroCFe = from cfe in cupomFiscal.Descendants("ide") select (string)cfe.Element("nCFe");
                        var nCFe = numeroCFe.FirstOrDefault();
                        var numeroSatCorreto = from cfe in cupomFiscal.Descendants("infCFe") select (string)cfe.Attribute("Id");
                        var nSat = numeroSatCorreto.FirstOrDefault();
                        resultadoTxt.Text += CriaComandoSQLParaAtualizarDados(nCFe, nSat);
                    }
                    catch {
                        MessageBox.Show("Falha ao ler o arquivo:" + arquivoCupomFiscal);                        
                    }                
                }
            }
            MostraMensagemProcessoFinalizado();        
        }

        /// <summary>
        /// Avisa para o usuário que o processo foi finalizado com sucesso
        /// </summary>
        public void MostraMensagemProcessoFinalizado() {
            MessageBox.Show("Comando gerado com sucesso!");
            tabControl1.SelectedIndex = 1;
        }

        /// <summary>
        /// Cria os comandos que serão executados no firebird
        /// </summary>
        /// <param name="campoDanfeAntigo">Campo que estava sendo usado de forma errada (nCFe)</param>
        /// <param name="campoDanfeNovo">Campo correto com dados do XMl (Atributo Id do campo infCFe)</param>
        /// <returns>Retorna o comando pronto e tratado</returns>
        public string CriaComandoSQLParaAtualizarDados(string campoDanfeAntigo, string campoDanfeNovo) {
            return String.Format("update notafiscalsaida set danfe = '{0}' where danfe = '{1}'; \n", campoDanfeNovo.Replace("CFe", ""), campoDanfeAntigo);            
        }

        /// <summary>
        /// Essa função devolve o arquivo já com o path
        /// </summary>
        /// <param name="nomeArquivo">Nome do arquivo que será unido ao path para letiura</param>
        /// <returns>Retorna o arquivo formatado</returns>
        public string DevolveArquivo(string nomeArquivo) {
            return txtCaminhoArquivos.Text + nomeArquivo;
        }

        /// <summary>
        /// Essa função serve para a limpeza inicial antes de ser feita toda a busca e preenchimento dos dados.
        /// </summary>
        public void PreparaParaCarregarDados() {
            listaArquivos.Items.Clear();
            resultadoTxt.Text = "";
        }

        /// <summary>
        /// Essa função carrega os abre a pasta e carrega os dados
        /// </summary>
        public void AbrePastaECarregaArquivos() {
            using (var pastaComArquivosXML = new FolderBrowserDialog())
            {
                if (pastaComArquivosXML.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(pastaComArquivosXML.SelectedPath))
                {
                    var arquivosXML = Directory.GetFiles(pastaComArquivosXML.SelectedPath).Where(w => w.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase)).ToList();
                    if (arquivosXML.Count <= 0) {
                        MessageBox.Show("Não foram encontrados arquivos!");
                        return;
                    }

                    txtCaminhoArquivos.Text = (pastaComArquivosXML.SelectedPath) + @"\";
                    foreach (var arquivo in arquivosXML)
                    {
                        listaArquivos.Items.Add(arquivo.Replace(txtCaminhoArquivos.Text, ""));
                    }
                    MarcaEDesmarcaTodos(MarcaTudo: true);
                }
            }
        }

        /// <summary>
        /// Essa função é responsavel por marcar e desmarcar todos os arquivos
        /// </summary>
        /// <param name="MarcaTudo"> Esse parametro determina se vai ser marcado ou desmarcado</param>
        public void MarcaEDesmarcaTodos(bool MarcaTudo = false) {
            for (int i = 0; i < listaArquivos.Items.Count; i++)
            {
                listaArquivos.SetItemChecked(i, MarcaTudo);
            }
        }
    }
}
