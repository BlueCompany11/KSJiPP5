using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JNJiPP5
{
    public partial class UserControl1 : Button
    {
        int fontSize = 15;
        public UserControl1()
        {
            InitializeComponent();
            this.Font = new Font("Microsoft Sans Serif", fontSize);
            this.ForeColor = Color.Black;   //przycisk ma teraz domyślnie ustawiony kolor tekstu - jeżeli chcemy by wszystkie przyciski miały
            // taką opcję to nie musimy już tego wszędzie umieszczać, a korzystać z tej kontrolki
            this.Click += LowerFont;    //metoda LowerFont wywola sie przy kazdym kilknieciu
        }
        
        private void LowerFont(object sender, EventArgs e)
        {
            fontSize--;
            //kazde wcisniecie spowoduje ze font z bedzie sie zmniejszal o 1
            if (fontSize > 0)
            {
                this.Font = new Font("Microsoft Sans Serif", fontSize);
            }
            if (fontSize < 11)
            {
                fontSize = 10;
                return;
            }
        }
        public void PojazdZniszczony()
        {
            this.ForeColor = Color.Red;
        }

        public void PojazdUszkodzony()
        {
            this.ForeColor = Color.Yellow;
        }
    }
}
