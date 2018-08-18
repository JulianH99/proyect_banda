using System;

namespace BandProyect.classes.instuments
{
    public class Bax : Instrument
    {
        public Bax() : base(InstrumentType.Chords)
        {
            this.Name = "Bax";
        }

        
        

        public override char Play()
        {
            return (char)(new Random()).Next(0, 127);
        }
    }
}
