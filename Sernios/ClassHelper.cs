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
                "Olhar aguçado - Com todas as armas você tem uma\nchance maior de acertar\n\n" +
                "Passos silenciosos - Pode usar essa habilidade para silenciar\nsua proxima habilidade";
        }

        private void períciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelHab.Text =
                "Assassino\n\n" +
                "Perícias\n\n" +
                "Escalar paredes (até 4 metros)\n\n" +
                "\n\n" +
                "Passos silenciosos - Pode usar essa habilidade para silenciar\nsua proxima habilidade";
        }
    }
}
