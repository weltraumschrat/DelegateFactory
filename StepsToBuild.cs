﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFactory
{
    class StepsToBuild
    {
        public static void rohKarrosse_bereitstellen(string auftragsnummer)
        {
            Console.WriteLine("Die Rohkarrosse bereitstellen {0}", auftragsnummer);
        }
        public static void motor_bereitstellen(string auftragsnummer)
        {
            Console.WriteLine("Motor bereitstellen {0}", auftragsnummer);
        }
        public static void achsen_montieren(string auftragsnummer)
        {
            Console.WriteLine("Achsen montieren {0}", auftragsnummer);
        }
        public static void motor_einsetzen(string auftragsnummer)
        {
            Console.WriteLine("Motor einsetzen {0}", auftragsnummer);
        }
        public static void Achsen_Getriebe_verbinden(string auftragsnummer)
        {
            Console.WriteLine("Die Achsen und das Getriebe verbinden {0}", auftragsnummer);
        }

    }
}
