using System;
using BandProyect.classes;

namespace BandProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Band proyect started");
            // create band
            AbstractBand band = new Band();

            Console.WriteLine(band.Gather() ? "Band has gathered" 
                : "Band could not gather");

            if (band.Tune() && band.Test())
            {
                Console.WriteLine("Band is now playing");
                band.Play();
            }
            else 
                Console.WriteLine("Band could not play");

            Console.ReadKey();
        }
    }
}
