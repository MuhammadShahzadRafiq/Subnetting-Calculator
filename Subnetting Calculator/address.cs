using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting_Calculator
{
    class address
    {
        public int firstOctect;
        public int secondOctect;
        public int thirdOctect;
        public int fourthOctect;

        public address(int first, int second, int third, int fourth)
        {
            this.firstOctect = first;
            this.secondOctect = second;
            this.thirdOctect = third;
            this.fourthOctect = fourth;
        }

        public String toString()
        {
            return firstOctect.ToString() + "." + secondOctect.ToString() + "." + thirdOctect.ToString() + "." + fourthOctect.ToString();
        }
    }
}
