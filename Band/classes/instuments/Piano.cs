using System;

namespace BandProyect.classes.instuments
{
    public class Piano : Instrument
    {
        public Piano() : base(InstrumentType.Chords)
        {
        }

        public override bool Play()
        {
            throw new NotImplementedException();
        }

        public override TuneStates Tune() => TuneStates.Tuned;

        public override string Name() => "Piano";
    }
}
