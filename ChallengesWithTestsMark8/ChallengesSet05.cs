using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            if (startNumber % n != 0)
            {
                return ((startNumber / n) + 1) * n;
            }
           
            else
            {
                return startNumber + n;
            }

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses) 
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)

            {
                return false;
            }

            for(int i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i -1] > numbers[i])
                {
                    return false;
                }
            }
            
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0  )
                {
                    sum += numbers[i];
                }
                
            }
                 return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
           foreach (string word in words) 
            {  
                if (word.Trim().Length > 0) 
                {
                    sentence += word.Trim() + " ";
                }
               
            }
           if (sentence.Length == 0) 
            {
                return "";
            }
           sentence = sentence.Trim();
           sentence += ".";
           return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            var everyfourth = new List<double>();

            for (var i = 3; i < elements.Count; i += 4)
            {
                everyfourth.Add(elements[i]);
            }
            return everyfourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++) 
            {
                for(int j = i +1;  j < nums.Length; j++) 
                {
                    if (nums[i] + nums[j] == targetNumber)
                        {
                        return true;
                        }
                }
            }
            return false;
        }
    }
}
