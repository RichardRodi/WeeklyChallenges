using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers) 
            { 
                if (number % 2 == 0)
                {
                    sum += number;
                }
                if (number % 2 != 0)
                {
                    sum-= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2,  number3, number4,};
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) &&
                (sideLength1 + sideLength3 > sideLength2))
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
          var isNumber = double.TryParse(input, out var number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;

            foreach ( var obj in objs ) 
            {
                if (obj == null)
                {  
                    count++; 
                }
                        
            }
            if (count >= majority) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)

                return 0;
            
            var evensAverage = numbers.Where(numbers => numbers % 2 == 0).ToList();

            if (evensAverage.Count == 0)

                return 0;


            return evensAverage.Average();


        }

        public int Factorial(int number)
        {
            if (number == 0)
            { 
            return 1;
            }
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
                return number * Factorial(number-1);
        }
    }
}
