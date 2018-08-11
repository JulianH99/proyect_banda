using System;
using System.Collections.Generic;
using System.Diagnostics;
using BandProyect.classes.generators;

namespace BandProyect.classes
{
    public class Band : AbstractBand
    {
        public override bool ChooseSong()
        {
            throw new NotImplementedException();
        }

        public override bool Gather()
        {
            var instrumentGenerator = new InstrumentGenerator();
            var musiciansList = new List<Musician>();

            try
            {
                var instrumentList = instrumentGenerator.GenerateInstruments();
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
            throw new NotImplementedException();
        }

        public override bool Test()
        {
            return false;
        }
    }
}