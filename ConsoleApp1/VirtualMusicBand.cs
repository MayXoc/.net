using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Coding.Exercise
{
    public class VirtualMusicBand
    {
        private List<Instrument> instruments;

        public VirtualMusicBand(List<Instrument> instruments)
        {
            this.instruments = instruments;
        }

        public void PlayAll()
        {
            foreach (Instrument instrument in instruments)
            {
                // Calling .Play() on each instrument is an example of polymorphism. 
                string currentInstrument = instrument.Play();
                int currentInstrumentVolume = instrument.GetVolume();

                Console.WriteLine($"Current instrument: {currentInstrument} | Volume: {currentInstrumentVolume}.");
            }
        }
    }
}
