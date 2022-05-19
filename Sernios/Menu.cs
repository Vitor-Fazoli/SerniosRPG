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
            Combat combat = new("Infectado",10,200,2,10);
            combat.Show();

            Weapon weapon1 = new(false,10,80,20,1);
            Weapon weapon2 = new(false, 100, 20, 50, 2);

            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}