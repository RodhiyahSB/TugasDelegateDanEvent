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
    public partial class Calkulator : Form
    {
        public Calkulator()
        {
            InitializeComponent();
            KalculatorInit();
        }
        private void KalculatorInit()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Penjumlahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.SelectedIndex = 0;
        }

        public delegate void Proses(int A, int B, string operasi, string operasiLabel, float hasil);

        public event Proses prosesEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int A = int.Parse(NilaiA.Text);
            int B = int.Parse(NilaiB.Text);
            string operasi = "";
            string operasiLabel = "";
            float hasil = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    hasil = Hitung.Penjumlahan(A, B);
                    operasiLabel = "Penjumlahan";
                    operasi = "+";
                    break;
                case 1:
                    hasil = Hitung.Pengurangan(A, B);
                    operasiLabel = "Pengurangan";
                    operasi = "-";
                    break;
                case 2:
                    hasil = Hitung.Perkalian(A, B);
                    operasiLabel = "Perkalian";
                    operasi = "x";
                    break;
                case 3:
                    hasil = (float)Hitung.Pembagian(A, B);
                    operasiLabel = "Pembagian";
                    operasi = "/";
                    break;

            }
            prosesEvent(A, B, operasi, operasiLabel, hasil);
        }
    }
}

