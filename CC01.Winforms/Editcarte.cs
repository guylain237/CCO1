using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.Winforms
{
    public partial class Editcarte : Form
    {
        public Editcarte()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonajout_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte();
            carte.Show();
        }

        private void buttonmodif_Click(object sender, EventArgs e)
        {

        }
private void Editcarte_Load(object sender, EventArgs e)
        {

        }
        //{
        //    ECOLE modifier = new ECOLE();
        //    modifier.labeltitre.Text = "modifier la carte";
        //    modifier.buttonactual.Visible = false;
        //    modifier.ShowDialog();
    }
    }

