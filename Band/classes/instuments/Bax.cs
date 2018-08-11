using System;

namespace BandProyect.classes.instuments
{
    public class Bax : Instrument
    {
        public Bax() : base(InstrumentType.Chords)
        {
        }

        public override bool Play()
        {
            throw new NotImplementedException();
        }

        public override TuneStates Tune() => TuneStates.Tuned;

        public override string Name() => "Bax";
    }
}
