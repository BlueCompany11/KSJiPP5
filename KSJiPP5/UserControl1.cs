using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSJiPP5
{
    public partial class UserControl1 : Button
    {
        int fontSize = 15;
        public UserControl1()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", fontSize);
            this.ForeColor = Color.Red;   //przycisk ma teraz domyślnie ustawiony kolor tekstu - jeżeli chcemy by wszystkie przyciski miały
            // taką opcję to nie musimy już tego wszędzie umieszczać, a korzystać z tej kontrolki
            this.Click += LowerFont;    //metoda LowerFont wywola sie przy kazdym kilknieciu
        }

        private void LowerFont(object sender, EventArgs e)
        {
            fontSize--;
            //kazde wcisniecie spowoduje ze font z bedzie sie zmniejszal o 1
            this.Font = new Font("Microsoft Sans Serif", fontSize);
            if (fontSize <= 10 && fontSize >=0) //event triggeruje sie gdy font jest mniejszy od 11
            {
                if (EndOfFun != null)   //jak nic nie bedzie przypisane do tego zdarzenia to program by się wywalał. Więc gdy nic nie przypiszesz do tego zdarzenia to po prostu ono się nigdy nie wywoła
                {
                    EndOfFun(sender, e);
                }
            }
        }
        
        public event EventHandler EndOfFun;
        
        
    }
}
