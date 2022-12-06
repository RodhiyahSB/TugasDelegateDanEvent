using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class ApliaksiCalculator : Form
    {
        public ApliaksiCalculator()
        {
            InitializeComponent();
        }
        private void proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            listBox1.Items.Add(
                String.Format($"{operasiLabel} : {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calkulator kalkulator = new Calkulator();
            kalkulator.prosesEvent += proses;
            kalkulator.ShowDialog();
        }
    }
}
