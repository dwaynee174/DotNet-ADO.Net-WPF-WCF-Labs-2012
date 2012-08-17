using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CSharpFeatures
{
    class EvenNumberGenerator : IEnumerable
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        public IEnumerator GetEnumerator()
        {
            for (int i = StartValue; i < EndValue; i++)

            {
                if (i % 2 == 0)

                {
                    //yield return "Evennumber found =";
                    yield return i;
                }
            }
        }
    }
}
