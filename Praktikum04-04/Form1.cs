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

        char[] arrayhuruf = { 'a', 'b', 'c', 'd', 'e' ,'f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        public char Character;
        public int NilaiHuruf(char Character)
        {
            if (Character == 'a' || Character == 'A')
            {
                return 1;
            }
            else if (Character == 'b' || Character == 'B')
            {
                return 2;
            }
            else if (Character == 'c' || Character == 'C')
            {
                return 3;
            }
            else if (Character == 'd' || Character == 'D')
            {
                return 4;
            }
            else if (Character == 'e' || Character == 'E')
            {
                return 5;
            }
            else if (Character == 'f' || Character == 'F')
            {
                return 6;
            }
            else if (Character == 'g' || Character == 'G')
            {
                return 7;
            }
            else if (Character == 'h' || Character == 'H')
            {
                return 8;
            }
            else if (Character == 'i' || Character == 'I')
            {
                return 9;
            }
            else if (Character == 'j' || Character == 'J')
            {
                return 10;
            }
            else if (Character == 'k' || Character == 'K')
            {
                return 11;
            }
            else if (Character == 'l' || Character == 'L')
            {
                return 12;
            }
            else if (Character == 'm' || Character == 'M')
            {
                return 13;
            }
            else if (Character == 'n' || Character == 'N')
            {
                return 14;
            }
            else if (Character == 'o' || Character == 'O')
            {
                return 15;
            }
            else if (Character == 'p' || Character == 'P')
            {
                return 16;
            }
            else if (Character == 'q' || Character == 'Q')
            {
                return 17;
            }
            else if (Character == 'r' || Character == 'R')
            {
                return 18;
            }
            else if (Character == 's' || Character == 'S')
            {
                return 19;
            }
            else if (Character == 't' || Character == 'T')
            {
                return 20;
            }
            else if (Character == 'u' || Character == 'U')
            {
                return 21;
            }
            else if (Character == 'v' || Character == 'V')
            {
                return 22;
            }
            else if (Character == 'w' || Character == 'W')
            {
                return 23;
            }
            else if (Character == 'x' || Character == 'X')
            {
                return 24;
            }
            else if (Character == 'y' || Character == 'Y')
            {
                return 25;
            }
            else if (Character == 'z' || Character == 'Z')
            {
                return 26;
            }
            else
            {
                return 0;
            }
        }

        public int Nilai;
        public char Konversi(int Nilai)
        {
            if (Nilai == 1)
            {
                return 'A';
            }
            else if (Nilai == 2)
            {
                return 'B';
            }
            else if (Nilai == 3)
            {
                return 'C';
            }
            else if (Nilai == 4)
            {
                return 'D';
            }
            else if (Nilai == 5)
            {
                return 'E';
            }
            else if (Nilai == 6)
            {
                return 'F';
            }
            else if (Nilai == 7)
            {
                return 'G';
            }
            else if (Nilai == 8)
            {
                return 'H';
            }
            else if (Nilai == 9)
            {
                return 'I';
            }
            else if (Nilai == 10)
            {
                return 'J';
            }
            else if (Nilai == 11)
            {
                return 'K';
            }
            else if (Nilai == 12)
            {
                return 'L';
            }
            else if (Nilai == 13)
            {
                return 'M';
            }
            else if (Nilai == 14)
            {
                return 'N';
            }
            else if (Nilai == 15)
            {
                return 'O';
            }
            else if (Nilai == 16)
            {
                return 'P';
            }
            else if (Nilai == 17)
            {
                return 'Q';
            }
            else if (Nilai == 18)
            {
                return 'R';
            }
            else if (Nilai == 19)
            {
                return 'S';
            }
            else if (Nilai == 20)
            {
                return 'T';
            }
            else if (Nilai == 21)
            {
                return 'U';
            }
            else if (Nilai == 22)
            {
                return 'V';
            }
            else if (Nilai == 23)
            {
                return 'W';
            }
            else if (Nilai == 24)
            {
                return 'X';
            }
            else if (Nilai == 25)
            {
                return 'Y';
            }
            else if (Nilai == 26)
            {
                return 'Z';
            }
            else if (Nilai == 0)
            {
                return ' ';
            }
            else
            {
                return '!';
            }
        }
        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "";
            char[] karakterKalimat = new char[tBoxInput.Text.Length];
            int[] nilaiKarakter = new int[tBoxInput.Text.Length];
            string Kalimat = tBoxInput.Text;
            int hurufAwal;
            Character = tBoxHurufAwal.Text[0];
            hurufAwal = NilaiHuruf(Character);
            int hurufKonversi;
            Character = tBoxHurufKonversi.Text[0];
            hurufKonversi = NilaiHuruf(Character);
            int jarak=hurufKonversi-hurufAwal;
            for (int i = 0; i < tBoxInput.Text.Length; i++)
            {
                Character = Kalimat[i];
                nilaiKarakter[i] = NilaiHuruf(Character);
            }
            for (int i = 0; i < tBoxInput.Text.Length; i++)
            {
                if (nilaiKarakter[i] != 0)
                {
                    Nilai = (nilaiKarakter[i] + jarak+26)%26;
                    if (Nilai == 0)
                    {
                        Nilai = 26;
                    }
                }
                else
                {
                    Nilai = nilaiKarakter[i];
                }
                karakterKalimat[i] = Konversi(Nilai);
                labelOutput.Text += karakterKalimat[i];
            }
        }

        private void FormQuizPanda_Load(object sender, EventArgs e)
        {
            labelOutput.Text = "";
        }
    }
}
