using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSJiPP5Lib;

namespace KSJiPP5
{
    public partial class Form1 : Form
    {
        Motor motor;
        Samochod samochod;

        public Form1()
        {
            InitializeComponent();
            userControl11.EndOfFun += UserControl11_EndOfFun;
            motor = new Motor();
            samochod = new Samochod();
        }

        private void UserControl11_EndOfFun(object sender, EventArgs e)
        {
            MessageBox.Show("Proszę przestać mnie wciskać");
        }

        private void buttonMotor_Click(object sender, EventArgs e)
        {
            if(textBoxMotor.Text != "")
            {
                motor.Przyspiesz(Convert.ToDouble(textBoxMotor.Text));
            }
            
        }

        private void buttonSamochod_Click(object sender, EventArgs e)
        {
            if(textBoxSamochod.Text != "")
            {
                samochod.Przyspiesz(Convert.ToDouble(textBoxSamochod.Text));
            }
        }
    }
}
