using System;

namespace BandProyect.classes.instuments
{
    public class Trumpet : Instrument
    {
        public Trumpet() : base(InstrumentType.Chords)
        {
        }

        public override bool Play()
        {
            throw new NotImplementedException();
        }

        public override TuneStates Tune() => TuneStates.CantTune;

        public override string Name() => "Trumpet";
    }
}
