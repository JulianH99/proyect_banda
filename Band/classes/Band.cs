using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.classes.generators;

namespace BandProyect.classes
{
    public class Band : AbstractBand
    {
        public override bool ChooseSong()
        {
            throw new NotImplementedException();
        }

        public override bool Gather()
        {
            var instrumentGenerator = new InstrumentGenerator();
            var instrumentList = instrumentGenerator.GenerateInstruments();
            var musiciansList = new List<Musician>();
            
            instrumentList.ForEach(instrument =>
            {
                musiciansList.Add(new Musician(instrument));
            });

            this.Musicians = musiciansList.ToArray();

            return false;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override bool Test()
        {
            throw new NotImplementedException();
        }
    }
}
