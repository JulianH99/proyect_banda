using System;
using System.Collections.Generic;
using System.Diagnostics;
using BandProyect.classes.generators;

namespace BandProyect.classes
{
    public class Band : AbstractBand
    {
        
        public override bool Gather()
        {
            var instrumentGenerator = new InstrumentGenerator();
            var musiciansList = new List<Musician>();

            var instrumentList = instrumentGenerator.GenerateInstruments();
            try
            {
                instrumentList.ForEach(instrument => { musiciansList.Add(new Musician(instrument)); });

                Musicians = musiciansList.ToArray();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override void Play()
        {
            foreach (var musician in Musicians)
            {
                musician.Instrument.Play();
            }
        }

        public override bool Test()
        {
            var testOk = true;
            foreach (var musician in Musicians)
            {
                if (!musician.Instrument.Play())
                    testOk = false;
            }

            return testOk;
        }
    }
}