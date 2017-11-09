using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestBackend.Repositories
{
    public class HomeRepository
    {
        ComplexData ComplexData;

        internal dynamic ArithmeticTypeCheck(ComplexData complexData)
        {
            ComplexData = complexData;
            
            if (ComplexData.What == "sum")
            {
                return SumData();
            }
            else if (ComplexData.What == "multiply")
            {
                return MultiplyData();
            }
            else if (ComplexData.What == "double")
            {
                return DoubleData();
            }
            else
            {
                return "Please provide what to do with the numbers!";
            }
        }

        private dynamic SumData()
        {
            return ComplexData.Numbers.Sum();
        }

        private dynamic DoubleData()
        {
            int?[] resultArray = new int?[ComplexData.Numbers.Length];
            for (int i = 0; i < ComplexData.Numbers.Length; i++)
            {
                resultArray[i] = ComplexData.Numbers[i] * 2;
            }
            return resultArray;
        }

        private dynamic MultiplyData()
        {
            dynamic result = 1;
            foreach (var number in ComplexData.Numbers)
            {
                result *= number;
            }
            return result;
        }
    }
}
