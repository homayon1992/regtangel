using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regtangel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double Tol, Arz;
        public double  GHaede, Ertefa, Zele1, Zele2, Zele3;

        private void TxtTol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMasahat_Click(object sender, EventArgs e)
        {
            
            ClassRegtangel r = new ClassRegtangel();
            if (txtTol.Text != "" & txtArz.Text != "")
            {
                Tol = double.Parse(txtTol.Text);
                Arz = double.Parse(txtArz.Text);
                R_Masahat_Regtangel.Text = (r.Masahat(Tol, Arz)).ToString();
            }
            else
                MessageBox.Show("لطفا مقادیر طول و عرض مستطیل را وارد نمایید");
        }


        private void btnMohit_Click(object sender, EventArgs e)
        {

            ClassRegtangel r = new ClassRegtangel();
            if (txtTol.Text != "" & txtArz.Text != "")
            {
                Tol = double.Parse(txtTol.Text);
                Arz = double.Parse(txtArz.Text);
                R_Mohit_Regtangel.Text = (r.Mohoit(Tol, Arz)).ToString();
            }
            else
                MessageBox.Show("لطفا مقادیر طول و عرض مستطیل را وارد نمایید");
        }
        private void btnMasahat_Mosalas_Click(object sender, EventArgs e)
        {
            ClassMosalas M = new  ClassMosalas ();
            if (txtGHaede.Text != "" & txtErtefa.Text != "")
            {
                GHaede = double.Parse(txtGHaede.Text);
                Ertefa = double.Parse(txtErtefa.Text);
                R_Masahat_Mosalas.Text = (M.Masahat(GHaede, Ertefa)).ToString();
            }
            else
                MessageBox.Show("لطفا مقادیر قاعده و ارتفاع را وارد نمایید");
        }
        private void btnMohit_Mosalas_Click(object sender, EventArgs e)
        {
            ClassMosalas M = new ClassMosalas();
            if (txtZele1.Text != "" & txtZele2.Text != "" & txtZele3.Text != "")
            {
                Zele1 = double.Parse(txtZele1.Text);
                Zele2 = double.Parse(txtZele2.Text);
                Zele3 = double.Parse(txtZele3.Text);

                R_Mohit_Mosalas.Text = (M.Mohoit(Zele1, Zele2,Zele3)).ToString();
            }
            else
                MessageBox.Show("لطفا مقادیر اضلاع را وارد نمایید");
        }

    }
}
