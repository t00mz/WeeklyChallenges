using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses) // done
        {
            // throw new NotImplementedException();

            foreach (var busi in businesses)
            {
                if(busi.TotalRevenue == 0) { busi.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers) // done
        {
            //throw new NotImplementedException();

            if (numbers == null || numbers.Length == 0) { return false; }

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i - 1] > numbers[i]) { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
             throw new NotImplementedException();

            List<double> sumList = new List<double>();

            for (int i = 0; i < elements.Count; i+=4)
            {
                elements.Add(elements[i]);
            }

            return sumList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
