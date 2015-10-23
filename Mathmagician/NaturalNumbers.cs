using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//added "public" to line 10 here to resolve build errors in NaturalNumbersTest
namespace Mathmagician
{
    public class NaturalNumbers
    {
        protected int first; //create data member with next line
        protected int increment;

        public NaturalNumbers() //define a constuctor
        {
            first = 1;
            increment = 1;
        }

        public virtual int GetNext(int x)
        {
            return x + increment;
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {

            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            {
                return output;
            }
        }
    }
}
