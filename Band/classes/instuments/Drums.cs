using System;

namespace BandProyect.classes.instuments
{
    public class Drums : Instrument
    {
        public Drums() : base(InstrumentType.Percusion)
        {
        }

        public override TuneStates Tune() => TuneStates.CantTune;

        public override string Name() => "Drums";
    }
}
