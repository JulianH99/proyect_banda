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

            if (band.Gather())
            {
                Console.WriteLine("Band has gathered");
            }
            else
            {
                Console.WriteLine("Band could not gather");
            }

            
        }
    }
}
