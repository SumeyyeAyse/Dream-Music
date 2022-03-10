using DAL.ConcreteDal.Context;
using Entities;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataContext data;

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new DataContext();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

       /* private void kullaniciGirisi(string kAdi, string kSoyadi)
        {
            bool control = true;
            if(kAdi.Equals("") || kAdi.Equals(null)) 
            {
                uAd.Visible = true;
                control = false;
            }
            if (kSoyadi.Equals("") || kSoyadi.Equals(null))
            {
                uSoy.Visible = true;
                control = false;
            }
            if (control != true ) 
            {
                MessageBox.Show("It is mandatory to fill in the blank fields.");
            }
            else 
            { 
                
            }
            
        }*/

        private void button14_Click(object sender, EventArgs e)
        {
            //kullaniciGirisi(txtKAd.Text, txtKSoy.Text);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
    
}

