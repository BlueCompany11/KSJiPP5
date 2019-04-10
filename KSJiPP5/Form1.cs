using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JNJiPP5lib; //-	Użyć komponentów w formularzu albo na innych kontrolkach.

namespace JNJiPP5
{


    public partial class Form1 : Form
    {
        Autobus autobus;
        Tramwaj tramwaj;

        public Form1()
        {
            InitializeComponent();
            autobus = new Autobus();
            tramwaj = new Tramwaj();
            autobus.PrzekroczenieBezpiecznejPredkosci += Autobus_PrzekroczenieBezpiecznejPredkosci;
            autobus.ZniszczeniePojazdu += Autobus_ZniszczeniePojazdu;
            tramwaj.PrzekroczenieBezpiecznejPredkosci += Tramwaj_PrzekroczenieBezpiecznejPredkosci;
            tramwaj.ZniszczeniePojazdu += Tramwaj_ZniszczeniePojazdu;
        }

        private void Tramwaj_ZniszczeniePojazdu()
        {
            tramwajButton.PojazdZniszczony();
        }

        private void Tramwaj_PrzekroczenieBezpiecznejPredkosci()
        {
            tramwajButton.PojazdUszkodzony();
        }

        private void Autobus_ZniszczeniePojazdu()
        {
            autobusButton.PojazdZniszczony();
        }

        private void Autobus_PrzekroczenieBezpiecznejPredkosci()
        {
            autobusButton.PojazdUszkodzony();
        }

        private void autobusButton_Click(object sender, EventArgs e)
        {
            double wartoscZTextBoxa;
            bool konwersjaUdana = false;
            try
            {
                wartoscZTextBoxa = Convert.ToDouble(textBoxAutobus.Text);
                konwersjaUdana = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj wartosc liczbowa");
            }
            if (konwersjaUdana)
            {
                autobus.ZmienPredkosc(Convert.ToDouble(textBoxAutobus.Text));
            }
            
        }

        private void tramwajButton_Click(object sender, EventArgs e)
        {
            double wartoscZTextBoxa;
            bool konwersjaUdana = false;
            try
            {
                wartoscZTextBoxa = Convert.ToDouble(textBoxAutobus.Text);
                konwersjaUdana = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj wartosc liczbowa");
            }
            if (konwersjaUdana)
            {
                tramwaj.ZmienPredkosc(Convert.ToDouble(textBoxTramwaj.Text));
            }
        }
    }
}
