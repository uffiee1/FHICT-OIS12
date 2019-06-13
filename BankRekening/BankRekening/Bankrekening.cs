using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    class Bankrekening
    {
        public Bankrekening(string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;

            volgendeVrijeRekeningnummer++;
        }
        private readonly int rekeningnummer;
        private readonly string naam;
        private readonly int saldo;
        private static int volgendeVrijeRekeningnummer = 2001;
    }
}
