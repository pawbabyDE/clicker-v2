namespace Clicker
{
    public partial class Form1 : Form
    {
        int buttonlvl;
        int dzieci;
        public Form1()
        {
            InitializeComponent();
            dzieci = 0;
            buttonlvl = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dzieci ++;
            label1.Text = "Dzieci:" + dzieci.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int upgradeCost = (int)Math.Pow(2, buttonlvl);
            if(dzieci >= upgradeCost)
            {

                buttonlvl++;
                button1.Text = "lvl:" + buttonlvl.ToString();
                dzieci -= upgradeCost;
                label1.Text = "Dzieci:" + dzieci.ToString();
                string nextUpgradeCost =   Math.Pow(2, buttonlvl).ToString() + ")";
                button2.Text = "Upgrade\n" + nextUpgradeCost;

            }

            

        }
    }
}