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
    public partial class CharacterCreation : Form
    {
        private int AtributesSum;
        public CharacterCreation()
        {
            InitializeComponent();

            labelPointsAtr.Text = "75";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InteligenceTrackBar.Value = 0;
            VitalityTrackBar.Value = 0;
            MetabolsimTrackBar.Value = 0;

            InteligenceTrackBar.Enabled = true;
            VitalityTrackBar.Enabled = true;
            MetabolsimTrackBar.Enabled = true;

            labelControlMetabolism.Text = "0";
            labelControlnteligence.Text = "0";
            labelControlVitality.Text = "0";

            labelPointsNeg.Visible = false;
            labelTextNeg.Visible = false;
        }

        private void VitalityTrackBar_Scroll(object sender, EventArgs e)
        {
            labelControlVitality.Text = VitalityTrackBar.Value.ToString();
        }

        private void MetabolsimTrackBar_Scroll(object sender, EventArgs e)
        {
            labelControlMetabolism.Text = MetabolsimTrackBar.Value.ToString();
        }

        private void InteligenceTrackBar_Scroll(object sender, EventArgs e)
        {
            labelControlnteligence.Text = InteligenceTrackBar.Value.ToString();
        }
        private void MessageProblem()
        {
            AtributesSum = VitalityTrackBar.Value + MetabolsimTrackBar.Value + InteligenceTrackBar.Value;

            labelPointsNeg.Visible = true;
            labelTextNeg.Visible = true;
            labelPointsNeg.Text = Math.Abs(AtributesSum - 75).ToString();
        }
        private void UpdateData_Tick(object sender, EventArgs e)
        {
            AtributesSum = VitalityTrackBar.Value + MetabolsimTrackBar.Value + InteligenceTrackBar.Value;

            labelPointsAtr.Text = (75 - AtributesSum).ToString();

            if (int.Parse(labelPointsAtr.Text) < 0)
            {
                labelPointsAtr.ForeColor = Color.Red;
            }
            else
            {
                labelPointsAtr.ForeColor = Color.Black;
            }
        }

        private void checkboxListPlagues_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkboxListPlagues.Items.Count; ++ix)
                if (ix != e.Index) checkboxListPlagues.SetItemChecked(ix, false);
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox2.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox2.SetItemChecked(ix, false);
        }

        private void labelInteligenceShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Aumenta a técnica e a chance de revidar\n" +
                "◉ Técnica é usado para usar armas mais complexas", labelInteligenceShow);
        }

        private void labelMetabolismShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Aumenta a sua resistência e a iniciativa\n" +
                "◉ O jogador com a maior iniciativa no combate começa a luta", labelMetabolismShow);
        }

        private void labelVitalityShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Aumenta sua sáude e seu esforço:\n" +
                "◉ Esforço são os pontos que te dizem quantas ações você pode realizar por turno", labelVitalityShow);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Character.VITALITY = int.Parse(labelControlVitality.Text);
            Character.METABOLSIM = int.Parse(labelControlMetabolism.Text);
            Character.INTELLIGENCE = int.Parse(labelControlnteligence.Text);

            Character.Name = textBox1.Text;
            Character.Class = comboBoxClass.Text;
            Character.Lore = textBox2.Text;

            Character.Ancestor = checkedListBox2.SelectedIndex;
            Character.Plague = checkboxListPlagues.SelectedIndex;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            


            MessageBox.Show(Character.ToString());

            TextWriter txt = new StreamWriter(saveFileDialog.FileName);
            txt.Write(Character.ToString());
            txt.Close();
        }
        private void labelHelpClass_Click(object sender, EventArgs e)
        {
            ClassHelper ch = new();
            ch.Show();
        }
    }
}
