using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Class1
    {
        public class MusicalInstrument
        {
            public virtual void Play()
            {
                Console.WriteLine("Playing a musical instrument.");
            }
        }

        public class Guitar : MusicalInstrument
        {
            public override void Play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        public class Piano : MusicalInstrument
        {
            public override void Play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }

    }
}
