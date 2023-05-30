using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD4_LELIEVRE
{
    public partial class FormJeu : Form
    {
        public FormJeu()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox caseCouleur = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                caseCouleur.DoDragDrop(caseCouleur.Image,DragDropEffects.Copy);
            }
        }


        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox caseReceveuse = (PictureBox)sender;

            caseReceveuse.Image = (Image)e.Data.GetData("System.Drawing.Bitmap");
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox9.AllowDrop = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
