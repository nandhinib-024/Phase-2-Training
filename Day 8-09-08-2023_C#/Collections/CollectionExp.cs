using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class CollectionExp
    {
        List <int> numbers = new List <int>();
        public void AddNewElement()
        {
            numbers.Add (0);
            numbers.Add (1);
            numbers.Add (3);
            numbers.Add (4);
            numbers.Add (5);

        }
        public int FindAnElement()
        {
            return numbers.ElementAt(1);
        }
    }
}
