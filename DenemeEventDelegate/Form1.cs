using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeEventDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SayiKontrol sayiKontrol = new SayiKontrol();
            sayiKontrol.SayiDurumu += SayiKontrol_SayiDurumu;
            sayiKontrol.Sayi = Convert.ToInt32(textBox1.Text);

        }

        private void SayiKontrol_SayiDurumu()
        {
            MessageBox.Show("Sayı özelliği 10'dan küçük olamaz");
        }
    }
}
