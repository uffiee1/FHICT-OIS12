using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Dagwaarde
{
    class Auto
    {
        public enum Brandstofsoort {
            benzine = 100,
            dizel = 90,
            lpg = 150,
            elektrishe = 130 }

        private Brandstofsoort Brandstof { get; set; }
        
        private int Dagwaarde { get; }
        //test
        private int KmStand { get; set; }
        private string Kenteken { get; }
        public Auto(string kenteken, Brandstofsoort soortbrandstof)
        {
            KmStand = 0;
            Kenteken = kenteken;
            Brandstof = soortbrandstof;
        }
        public int DagwaardeBerekenen()
        {
            return (500000 / KmStand) * (int)Brandstof;
        }

        public Auto(string kenteken, Brandstofsoort soortbrandstof, int kmstand)
        {
            KmStand = kmstand;
            Kenteken = kenteken;
            Brandstof = soortbrandstof;
        }


        private void RijdKilometers(int bedrag)
        {
            if (bedrag > 0)
            {
                //positief
                KmStand += bedrag;

                //KmStand = KmStand + bedrag;
            }
        }

        public override string ToString()
        {
            return $"Kenteken is  {Kenteken} , Brandstof: {Brandstof}, Kmstand: {KmStand} dagwaarde: {DagwaardeBerekenen()}";


            
        }





    }
}
