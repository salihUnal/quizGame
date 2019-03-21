using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class quizgame : Form
    {
        cevap1 c1 = new cevap1();
        cevap2 c2 = new cevap2();
        cevap3 c3 = new cevap3();
        cevap4 c4 = new cevap4();
        cevap5 c5 = new cevap5();
        cevap6 c6 = new cevap6();
        cevap7 c7 = new cevap7();
        cevap8 c8 = new cevap8();
        cevap9 c9 = new cevap9();
        cevap10 c10 = new cevap10();
        


        public quizgame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (s1cevap3.Checked == true)
            {

                c1.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void s1cevap3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (s2Cevap3.Checked == true)
            {

                c2.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s3Cevap1.Checked == true)
            {

                c3.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s4cevap1.Checked == true)
            {

                c4.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (s5cevap3.Checked == true)
            {

                c5.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (s6cevap3.Checked == true)
            {

                c6.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (s7cevap1.Checked == true)
            {

                c7.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (s8cevap3.Checked == true)
            {

                c8.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (s9cevap3.Checked == true)
            {

                c9.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (s10cevap2.Checked == true)
            {

                c6.Show();


            }

            else
            {

                MessageBox.Show("Bilemedin Güzel Kız Yeniden Dene  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("İŞTE SANA OLAN AŞKIM", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
