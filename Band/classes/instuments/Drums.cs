using System;

namespace BandProyect.classes.instuments
{
    public class Drums : Instrument
    {
        public Drums() : base(InstrumentType.Percusion)
        {
            this.Name = "Drums";
        }
        

        public override char Play()
        {
            return (char)(new Random()).Next(0, 127);
        }

        

    }
}
