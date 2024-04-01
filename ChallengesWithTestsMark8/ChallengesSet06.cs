using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
			if (string.Equals(words, null) || words.Contains(null))
			{
				return false;
			}
			bool containsWord = false;
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            if(ignoreCase == false) 
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
		}

		public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++) 
            { 
                if (num % i == 0)
                return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool unique;
           for (int i = 0; i < str.Length; i++) 
            {
                    unique = true;
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == str[j]  && i != j)
                    {
                        unique = false;
                    }
                        
                     }
                    if (unique == true)
                {
                    index = i; 
                }
			}
           return index;
            
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0; 
            for (var i = 0; i < numbers.Length; i++) 
            {
                int currentCount = 1;
                for(var j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null || n<= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i+= n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();

        }
    }
}
