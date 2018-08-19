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
            Console.WriteLine($"Playing instruments {Instrument.Name}");
            Instrument.Play();

            return true;
        }

        public bool TuneInstrument()
        {

            if(Instrument.TuneState == TuneStates.CantTune)
            {
                Console.WriteLine($"Instrument {Instrument.Name} is not afinable");
            }
            else
            {
                Console.WriteLine($"Tuning {Instrument.Name}");

                Instrument.TuneState = TuneStates.Tuned;
            }
            
            return true;
            
        }
    }
}
