using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWithUnitTest.Models
{
    public class CalculatorModel
    {
        public bool fail { get; set; }
        public int Calculator(string rom)
        {
            //first, upper case
            rom = rom.ToUpper();
            //convert string to array
            List<int> intS = new List<int>();

            // Copy character by character into array  
            for (int i = 0; i < rom.Length; i++)
            {
                intS.Add(Converter(rom[i]));
            }
            if (fail)
                return -1;
            //in roman numerals, a smaller value before a larger decreases the overall value, a larger number increases its value
            int prev = 0;
            int sub = 0;
            for (int i = intS.Count - 1; i > -1; i--)
            {
                if (prev <= intS[i])
                {
                    sub = intS[i] + sub;
                }
                else
                    sub = sub - intS[i];
                if (sub < 0)
                    return -2;

                prev = intS[i];
            }
            return sub;
        }

        private int Converter(char str)
        {
            int ret = -1;
            switch (str)
            {
                case 'I':
                    ret = 1;
                    break;
                case 'V':
                    ret = 5;
                    break;
                case 'X':
                    ret = 10;
                    break;
                case 'C':
                    ret = 100;
                    break;
                case 'M':
                    ret = 1000;
                    break;
            }
            if (ret < 0)
                fail = true;
            return ret;
        }
    }
}