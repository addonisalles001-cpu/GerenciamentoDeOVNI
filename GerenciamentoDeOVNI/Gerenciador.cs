using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeOVNI
{
    public partial class Gerenciador : Form
    {

        // objetos globais:
        BibliotecaOVNI.OVNI ovni;


        public Gerenciador(BibliotecaOVNI.OVNI ovni) // Obrigatoriamente deve-se iniciar passando um OVNI
        {
            InitializeComponent();
            // "copiando" o ovni vindo da outra janela para um obj global:
            this.ovni = ovni;

            // Atualizar as informções:
            AtualizarInfomacoes();

            // Popular o combobox com os planetas validos:
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);

        }

        public void AtualizarInfomacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "Desligado")}";
            lblPlaneta.Text = $"Planeta atual: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;

            // Atualizar os botões ligar e desligar:
            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;

            // Ativar/desativar p grb de acordo com o status da nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;

            // Verificar se a nave está na terr:
            
                    
                
            

               pibTerra.Image = ovni.PlanetaAtual == "Terra" ? Properties.Resources.Terra : null;

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O OVNI foi ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está ligado!.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar as informções:
            AtualizarInfomacoes();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O OVNI foi desligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está desligado!.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar as informções:
            AtualizarInfomacoes();
        }

        private void btnAddTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adicionado",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A nave ja está lotada de tripulantes",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }
        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {

            if (ovni.RemoverTripulante())
            {
                MessageBox.Show("Tripulante foi removido",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("O tripulante não foi possível remover",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }    

        private void btnAddAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {
                MessageBox.Show("Tripulante abduzido",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("O tripulante não foi abdzido",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }

        private void btnRemoverAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {
                MessageBox.Show("Tripulante foi desabduzido",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("O tripulante não foi possível desabduzir",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {
                MessageBox.Show("Você Mudou de planeta",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Falha ao mudar de planeta",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem())
            {
                MessageBox.Show("Você retornou ao planeta de origem",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Não foi possível retornar ao planeta de origem",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }
    }
}   
    

