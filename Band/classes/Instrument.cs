using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.interfaces;

namespace BandProyect.classes
{
    public abstract class Instrument : ITuneable, IPlayable
    {
        private InstrumentType type;

        protected Instrument() { }

        protected Instrument(InstrumentType type)
        {
            this.type = type;
        }

        public abstract bool Play();
        public abstract TuneStates Tune();
    }
}
