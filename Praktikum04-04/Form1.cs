using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum04_04
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            char[] arrayhuruf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int nilaiHurufKonversi = 0;
            int nilaiHurufAwal = 0;
            int jarakKonversi = 0;
            int posisi;
            string[] konversiKeValue = new string[tBoxInput.Text.Length];
            labelOutput.Text = "";
            // Menghitung selisih konversi
            for (int j = 0; j < arrayhuruf.Length; j++)
            {
                if (tBoxHurufAwal.Text.ToLower()[0].CompareTo(arrayhuruf[j]) == 0)
                {
                    nilaiHurufAwal = j;
                }
                if (tBoxHurufKonversi.Text.ToLower()[0].CompareTo(arrayhuruf[j]) == 0)
                {
                    nilaiHurufKonversi = j;
                }
                jarakKonversi = nilaiHurufKonversi - nilaiHurufAwal;
            }

            // Konversi Huruf->Nilai->Huruf
            for (int i = 0; i < tBoxInput.Text.Length; i++)
            {
                for(int j = 0; j < arrayhuruf.Length; j++)
                {
                    if (char.IsLetter(tBoxInput.Text[i]))
                    {
                        if (tBoxInput.Text.ToLower()[i].CompareTo(arrayhuruf[j]) == 0)
                        {
                            posisi = (26 + j + jarakKonversi) % 26;
                            // konversiKeValue[i]= ((26+j+jarakKonversi)%26).ToString();
                            konversiKeValue[i] = arrayhuruf[posisi].ToString();
                        }
                    }
                    else
                    {
                        konversiKeValue[i]= tBoxInput.Text[i].ToString();
                    }
                }
                labelOutput.Text += konversiKeValue[i].ToUpper();
            }
        }

        private void FormQuizPanda_Load(object sender, EventArgs e)
        {
            labelOutput.Text = "";
        }
    }
}
