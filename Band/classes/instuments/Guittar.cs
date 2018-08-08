using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.classes;

namespace BandProyect.classes.instuments
{
    class Guittar : Instrument
    {
        public Guittar()
        {
            base(InstrumentType.CHORDS);
        }

        public override bool Play()
        {
            throw new NotImplementedException();
        }

        public override TuneStates Tune()
        {
            return TuneStates.TUNED;
        }
    }
}
