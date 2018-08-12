using System;

namespace BandProyect.classes.instuments
{
    public class Guittar : Instrument
    {
        public Guittar(): base(InstrumentType.Chords)
        {
        }

        public override TuneStates Tune() => TuneStates.Tuned;

        public override string Name() => "Guittar";
    }
}
