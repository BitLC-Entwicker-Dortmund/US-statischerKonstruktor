using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_statischerKonstruktor {
    static class MeineStatischeKlasse {

        static MeineStatischeKlasse() {
            Console.WriteLine ( "Hallo vom statischen Konstruktor");
        }

        public static int Rechne ( int z1, int z2) {
            return z1 + z2;
        }

        public static void MachMal ( ) {
            Console.WriteLine ( "danach MachMal..." );
            Console.WriteLine ("Zuerst kommt der Konstruktor, dann alles Andere ...");
        }
    }
}
