using System;

namespace BandProyect.classes.instuments
{
    public class Piano : Instrument
    {
        public Piano() : base(InstrumentType.Chords)
        {
            this.TuneState = TuneStates.CantTune;
            this.Name = "Piano";
        }

        

        public override char Play()
        {
            return (char)(new Random()).Next(0, 127);
        }
    }
}
