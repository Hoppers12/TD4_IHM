using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD4_LELIEVRE
{
    public partial class FormParametrage : Form
    {
        public FormParametrage()
        {
            InitializeComponent();
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value % 2 != 0)
            {
                numericUpDown1.Value += 1;
            }
        }
       

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "")
            {
                numericUpDown1.Text = numericUpDown1.Value.ToString();
            }

        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && numericUpDown1.Text == "")
            {
                numericUpDown1.Text = numericUpDown1.Value.ToString();
            }
 
        }

        private void button_Click(object sender, EventArgs e)
        {
            FormJeu page2 = new FormJeu();
            page2.Show();
           button1.Visible= false;
        
        }
    }
}