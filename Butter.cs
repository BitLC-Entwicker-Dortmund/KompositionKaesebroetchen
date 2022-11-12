using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen {
    class Butter {
        private string bezeichnung;

        public Butter ( string s ) {
            bezeichnung = s;
        }

        public string GetBezeichnung ( ) { return bezeichnung; }
    }
}
