using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandProyect.classes
{
    public abstract class AbstractBand
    {
        protected Musician[] Musicians;

        public abstract bool Gather();

        public bool Tune()
        {
            var testSuccessful = true;

            foreach (var musician in Musicians)
            {
                var instName = musician.Instrument.Name();
                var tunedState = musician.Instrument.Tune();

                if (tunedState == TuneStates.NotTuned)
                    testSuccessful = false;
                Console.WriteLine($"{instName} tune state is {tunedState}");
            }

            return testSuccessful;
            
        }

        public abstract bool Test();

        public abstract void Play();

        public abstract bool ChooseSong();
    }
}
