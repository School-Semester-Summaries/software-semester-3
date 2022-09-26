using InterfaceTest.Animals;

namespace InterfaceTest
{
    public partial class Form1 : Form
    {
        Human human1 = new Human(new Cat());
        Human human2 = new Human(new Dog());

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Meow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(human1.Pet.Attack1());
        }
    }
}