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

        public abstract bool Test();

        public abstract void Play();

        public abstract bool ChooseSong();
    }
}
