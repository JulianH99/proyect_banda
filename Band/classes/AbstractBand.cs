using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandProyect.classes
{
    abstract class AbstractBand
    {
        protected Musician musicians;

        public abstract bool Gather(Musician[] musicians);

        public abstract bool Test();

        public abstract void Play();

        public abstract bool ChooseSong();
    }
}
