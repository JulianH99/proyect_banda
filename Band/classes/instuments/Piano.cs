using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandProyect.classes.instuments
{
    public class Piano : Instrument
    {
        public Piano() : base(InstrumentType.CHORDS)
        {
        }

        public override bool Play()
        {
            throw new NotImplementedException();
        }

        public override TuneStates Tune()
        {
            throw new NotImplementedException();
        }
    }
}
