using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeOVNI
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            // Adicionar os planetas no comboBox:
            cmbPlaneta.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Verificar se o número de tripulantes está vazio:
            if (txbTripulantes.Text == "")
            {
                MessageBox.Show("Informe o máximo de tripulantes!",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAbduzidos.Text == "")
            {
                MessageBox.Show("Informe a capacidade do compartimento de abduzidos!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbPlaneta.SelectedIndex == -1)
            {
                MessageBox.Show("Slecione o planeta de origem!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Variaveis para receber os valores do txbs:
                int maxTripulantes = int.Parse(txbTripulantes.Text);
                int maxAbduzidos = int.Parse(txbAbduzidos.Text);
                string planetaOrigem = cmbPlaneta.Text;
                
                // Instanciar o OVNI:
                BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes,maxAbduzidos,planetaOrigem);

            }

        }
    }
}
