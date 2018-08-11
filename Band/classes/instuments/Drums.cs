using System;

namespace BandProyect.classes.instuments
{
    public class Drums : Instrument
    {
        public Drums() : base(InstrumentType.Percusion)
        {
        }

        public override bool Play()
        {
            throw new NotImplementedException();
        }

        public override TuneStates Tune() => TuneStates.CantTune;

        public override string Name() => "Drums";
    }
}
