using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }
        /* 
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        } */

        bool move;
        int mouse_x;
        int mouse_y;
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move= false;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if(move)
            //{
            //    this.SetDesktopLocation(MousePOsition.X - mouse_x, MousePosition.Y - mouse_y);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length<5)
            {
                MessageBox.Show("karakter sayısı 5 ten küçük olamaz");
            }
            else 
            {
                this.Visible = false;
                Form2 frm = new Form2();
                frm.Show();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 frm = new Form1();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
