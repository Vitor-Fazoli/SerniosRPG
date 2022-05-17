namespace Sernios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewCharacter_Click(object sender, EventArgs e)
        {
            CharacterCreation creation = new();

            creation.Show();
        }

        private void buttonOpenCharacter_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}