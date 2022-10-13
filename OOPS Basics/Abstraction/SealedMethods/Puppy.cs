using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Puppy:Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine("Puppy Sound");
        }
        
    }
}