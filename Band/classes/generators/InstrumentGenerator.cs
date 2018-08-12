using System;
using System.Collections.Generic;
using BandProyect.classes.instuments;
using BandProyect.classes.factories;
using BandProyect.classes;

namespace BandProyect.classes.generators
{
    public class InstrumentGenerator
    {
        private readonly string[] _types =
        {
            "guittar",
            "bax",
            "drums",
            "piano",
            "trumpet"
        };
        
        
        public List<Instrument> GenerateInstruments()
        {
            var randomGen = new Random();
            var instNumber = randomGen.Next(5, 20); // random number of instruments
            var instList = new List<Instrument>();

            for (var i = 0; i < instNumber; i++)
            {
                var instType = randomGen.Next(this._types.Length);
                instList.Add(InstrumentFactory.GetInstrument(this._types[instType]));
            }

            return instList;
        }
        
    }
}