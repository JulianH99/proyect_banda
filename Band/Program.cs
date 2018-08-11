using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandProyect.classes;
using BandProyect.classes.instuments;

namespace BandProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            // create band
            AbstractBand band = new Band();

            Console.WriteLine(band.Gather() ? "Band has gathered" 
                : "Band could not gather");

            if (band.Tune() && band.Test())
                band.Play();
        }
    }
}
