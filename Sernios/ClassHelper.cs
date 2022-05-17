using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sernios
{
    public partial class ClassHelper : Form
    {
        public ClassHelper()
        {
            InitializeComponent();
            labelHab.Text = "Assassino\n\nHabilidades Iniciais\n\nArremesso de faca - Joga uma faca em alta velocidade\nque causa 5 % da vida maxima\n\nOlhar aguçado - Com todas as armas você tem uma\nchance maior de acertar\n\nPassos silenciosos - Pode usar essa habilidade para silenciar\nsua proxima habilidade";
        }

        private void habilidadesIniciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelHab.Text = 
                "Assassino\n\n" +
                "Habilidades Iniciais\n\n" +
                "Arremesso de faca - Joga uma faca em alta velocidade\nque causa 5 % da vida maxima\n\n" +
                "Passos silenciosos - Pode usar essa habilidade para silenciar\nsua proxima habilidade";
        }

        private void períciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelHab.Text =
                "Assassino\n\n" +
                "Perícias\n\n" +
                "Pernas Treinadas - Pode Fugir de lutas com 50% de chance\n\n" +
                "Olhar aguçado - Com todas as armas você tem uma\nchance maior de acertar";
        }

        private void habilidadesIniciaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelHab.Text =
                "Bispo\n\n" +
                "Habilidades Iniciais\n\n" +
                "Abençoar - leva suas bênçãos a algum jogador que pode\n" +
                " se sentir inspirado e ganhar 3 pontos de iniciativa\n\n" +
                "O poderoso dízimo - ganha dinheiro em cidades grandes dando fé as pessoas";
        }

        private void períciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Bispo\n\n" +
               "Perícias\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de\n" +
               " convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void habilidadesIniciaisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Ex-Piloto\n\n" +
               "Habilidades Iniciais\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void períciasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Ex-Piloto\n\n" +
               "Perícias\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void habilidadesIniciaisToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Policial\n\n" +
               "Habilidades Iniciais\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void períciasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Policial\n\n" +
               "Perícias\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void habilidadesIniciaisToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Religioso\n\n" +
               "Habilidades Iniciais\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void períciasToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Religioso\n\n" +
               "Perícias\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void habilidadesIniciaisToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Andarilho\n\n" +
               "Habilidades Iniciais\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void períciasToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Andarilho\n\n" +
               "Perícias\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void habilidadesIniciaisToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Monge\n\n" +
               "Habilidades Iniciais\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }

        private void períciasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            labelHab.Text =
               "Monge\n\n" +
               "Perícias\n\n" +
               "Converter fiéis - com isso em cada combate pode haver o efeito de convertido e o inimigo se rende a você se feito com sucesso\n\n" +
               "Proximidade de Deus - +5 de vitalidade base";
        }
    }
}
