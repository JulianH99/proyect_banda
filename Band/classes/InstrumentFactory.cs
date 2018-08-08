using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.classes.instuments;

namespace BandProyect.classes
{
    class InstrumentFactory
    {
        public static Instrument getInstrument(string instrument)
        {
            Instrument inst;

            switch(instrument.ToLower())
            {
                case "guittar":
                    inst = new Guittar();
                    break;
                case "bax":
                    inst = new Bax();
                    break;
                case "drums":
                    inst = new Drums();
                    break;
                case "piano":
                    inst = new Piano();
                    break;
                case "trumpet":
                    inst = new Trumpet();
                    break;
                default:
                    throw new ArgumentException("No existe un instrumento de tipo " + instrument);
            }
            return inst;
        }
    }
}
