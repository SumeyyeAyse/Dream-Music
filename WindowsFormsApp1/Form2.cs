using DAL.ConcreteDal.Context;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void muzikbaslama_Click(object sender, EventArgs e)
        {
            muzikbaslama.Visible = false;
            gerisar.Visible = false;
            ilerisar.Visible = false;
            baslat.Visible = false;
            muzikGorsel.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            muzikbaslama.Visible = true;
            gerisar.Visible = true;
        }

        private void homePage_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void yourLibrary_Click(object sender, EventArgs e)
        {


        }
        /*private void allList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog.
            }
        }*/

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
