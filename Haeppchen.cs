using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen {
    class Haeppchen {
        private string name;
        private Broetchen zutat_1;
        private Butter zutat_2;
        private Kaese zutat_3;
        private Ei zutat_4;

        public Haeppchen(Broetchen br, Butter b, Kaese k, Ei ei) {
            zutat_1 = br;
            zutat_2 = b;
            zutat_3 = k;
            zutat_4 = ei;
            name = "ich bin Dein Brötchen";
        }

        public void ZeigeInhalt ( ) {
            Console.WriteLine ( this.name + " und ich bestehe aus:" );
            Console.WriteLine ( this.zutat_1.GetBezeichnung());
            Console.WriteLine ( this.zutat_2.GetBezeichnung());
            Console.WriteLine ( this.zutat_3.GetBezeichnung());
            Console.WriteLine ( this.zutat_4.GetBezeichnung());
        }
    }
}
