using System;
using BandProyect.classes.instuments;

namespace BandProyect.classes.factories
{
    public class InstrumentFactory
    {
        public static Instrument GetInstrument(string instrument)
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
