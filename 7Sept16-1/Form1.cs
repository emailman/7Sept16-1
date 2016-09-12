using System;
using System.Windows.Forms;

namespace _7Sept16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxFlavors.Items.Add("vanilla");
            lbxFlavors.Items.Add("chocolate");
            lbxFlavors.Items.Add("strawberry");
            lbxFlavors.Items.Add("rocky road");
            lbxFlavors.Items.Add("fear sundae");
            lbxFlavors.Items.Add("peach");
        }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFlavor.Text = "Enjoy your " + lbxFlavors.SelectedItem.ToString()
                + " cone !";
        }
    }
}
