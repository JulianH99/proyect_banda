using System;

namespace BandProyect.classes.instuments
{
    public class Guittar : Instrument
    {
        public Guittar(): base(InstrumentType.Chords)
        {
            this.Name = "Guittar";
        }

        

        public override char Play()
        {
            return (char)(new Random()).Next(0, 127);
        }

    }
}
