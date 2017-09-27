using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class SumClass
    {
        public int ListSum(List<int> inputList)
        {
            if (inputList != null)
            {
                return inputList.Sum();
            }
            return -1;
        }
    }
}
