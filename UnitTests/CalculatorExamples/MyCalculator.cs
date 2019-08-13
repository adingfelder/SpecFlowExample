using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public List<int> numbers = new List<int>();

        public int total;
        public Calculator() { total = 0; }

        public int Add()
        {
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }

        public int Subtract()
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (count == 0)
                {
                    total += number;
                    count++;
                }
                else
                {
                    total -= number;
                }
            }
            return total;

        }

        public int Multiply()
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (count == 0)
                {
                    total += number;
                    count++;
                }
                else
                {
                    total *= number;
                }
            }
            return total;
        }

        public int Divide()
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (count == 0)
                {
                    total += number;
                    count++;
                }
                else
                {
                    try
                    {
                        total /= number;
                    }
                    catch (Exception e)
                    {
                        e = new Exception("no");
                    }
                }
            }
            return total;
        }
    }
}