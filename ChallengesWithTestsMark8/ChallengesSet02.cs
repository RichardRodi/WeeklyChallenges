using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0; 
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)

                return 0;

            return numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;

            return Math.Min(length1, length2);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)

            return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Count() == 0)

                return 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;

           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)

                return false;

            if (numbers.Sum() % 2 != 0) 
                return true;
            else return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = 0; i < number; i++) 
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
