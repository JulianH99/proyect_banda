﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.interfaces;

namespace BandProyect.classes
{
    public abstract class Instrument : ITuneable, IPlayable
    {
        private InstrumentType _type;

        protected Instrument() { }

        protected Instrument(InstrumentType type)
        {
            this._type = type;
        }

        public abstract bool Play();
        public abstract TuneStates Tune();
        public abstract string Name();
    }
}
