using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.interfaces;

namespace BandProyect.classes
{
    public abstract class Instrument : IPlayable
    {
        private InstrumentType _type;
        public TuneStates TuneState { get; set; } = TuneStates.NotTuned;
        public string Name;

        protected Instrument() { }

        protected Instrument(InstrumentType type)
        {
            _type = type;
        }

        public abstract char Play();
    }
}
