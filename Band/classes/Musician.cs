using System;
using BandProyect.interfaces;

namespace BandProyect.classes
{
    public class Musician: IPlayer, ITuner
    {
        public Instrument Instrument { get; private set; }

        public Musician(Instrument instrument)
        {
            Instrument = instrument;
        }

        public bool PlayInstrument()
        {
            Console.WriteLine($"Tocando el instrumento {Instrument.Name}");

            return true;
        }

        public bool TuneInstrument()
        {

            if(Instrument.TuneState == TuneStates.CantTune)
            {
                Console.WriteLine($"El instrumento {Instrument.Name} no es afinable");
            }
            else
            {
                Console.WriteLine($"Afinando {Instrument.Name}");

                Instrument.TuneState = TuneStates.Tuned;
            }
            
            return true;
            
        }
    }
}
