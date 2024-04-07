using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Animal
    {
        // Protected constructor prevents direct instantiation
        protected Animal()
        {
            // Constructor logic specific to Animal
        }

        public abstract void MakeSound();
    }
}
