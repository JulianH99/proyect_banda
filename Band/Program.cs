using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.classes;
using BandProyect.classes.instuments;

namespace BandProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instuments
            Guittar guittar1 = new Guittar(InstrumentType.CHORDS);

            // create musicians
            Musician musician1 = new Musician(guittar1);

            // create band
            AbstractBand band = new BandProyect();

            
        }
    }
}
