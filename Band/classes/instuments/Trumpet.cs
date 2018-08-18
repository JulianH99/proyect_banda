using System;

namespace BandProyect.classes.instuments
{
    public class Trumpet : Instrument
    {
        public Trumpet() : base(InstrumentType.Chords)
        {
            this.Name = "Trumpet";
        }

        public override char Play()
        {
            return (char)(new Random()).Next(0, 127);
        }
    }
}
