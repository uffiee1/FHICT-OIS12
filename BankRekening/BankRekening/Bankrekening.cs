using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    class Bankrekening
    {
        // Constructors
        public Bankrekening(string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;
            // we hogen het volgende vrije rekeningnummer met 1 op zodat de
            // volgende bankrekening een nummer krijgt dat 1 hoger is dan
            // deze bankrekening.

            volgendeVrijeRekeningnummer++;
        }
        public Bankrekening(string naam, int Saldo)
        {
            this.naam = naam;
            saldo = Saldo;
            // vul zelf in
        }


        // Fields
        private readonly int rekeningnummer;
        private readonly string naam;
        private readonly  int saldo; // het saldo in hele centen
        private static int volgendeVrijeRekeningnummer = 2001;

        // Methods
        public void NeemOp(double bedrag)
        {
            // bedrag in hele centen, negatieve bedragen worden genegeerd.
            // vul zelf in
        }
        public void Stort(double bedrag)
        {
            // bedrag in hele centen, negatieve bedragen worden genegeerd.
            // vul zelf in
        }
        public void MaakOver(Bankrekening andereRekening, double bedrag)
        {
            // bedrag in hele centen, negatieve bedragen worden genegeerd.
            // vul zelf in
        }


    }
}
