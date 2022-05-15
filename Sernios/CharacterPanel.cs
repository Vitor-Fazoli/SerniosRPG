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
    public partial class CharacterPanel : Form
    {
        public CharacterPanel()
        {
            InitializeComponent();
            progressBar1.Value = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int damage = (int)numericDamage.Value;
            if (progressBar1.Value <= damage)
            {
                progressBar1.Value = 0;
                MessageBox.Show("Você morreu");
                this.Opacity = 0.8f;
            }
            else
                progressBar1.Value -= damage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int heal = (int)numericDamage.Value;

            if (progressBar1.Value >= progressBar1.Maximum)
                MessageBox.Show("Sua vida está cheia");
            else
                progressBar1.Value += heal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(XpBar.Value + numericXP.Value >= XpBar.Maximum)
            {
                int left = (int)((numericXP.Value + XpBar.Value) - XpBar.Maximum);

                LevelUp();

                XpBar.Value += left;
            }
            else
            {
                XpBar.Value += (int)numericXP.Value;
            }
        }

        private void LevelUp()
        {
            XpBar.Value = 0;

            int lvl = int.Parse(Level.Text);
            lvl++;

            Level.Text = lvl.ToString();

           XpBar.Maximum = XpBar.Maximum + (int)Math.Pow(2, lvl);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CharacterPanel_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
