using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            // throw new NotImplementedException();
            int result = 0;

            foreach (var x in numbers)
            {
                if (x % 2 == 0) { result += x; }
                if (x % 2 != 0) { result -= x; }
            }

            return result;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            // throw new NotImplementedException();

            //if(str1.Length < str2.Length && str1.Length < str3.Length && str1.Length < str4.Length) { return str1.Length; }
            //if(str2.Length < str1.Length && str2.Length < str3.Length && str2.Length < str4.Length) { return str2.Length; }
            //if(str3.Length < str1.Length && str3.Length < str2.Length && str3.Length < str4.Length) { return str3.Length; }
            //if(str4.Length < str1.Length && str4.Length < str2.Length && str4.Length < str3.Length) { return str4.Length; }

            string[] stringArr = new string[] { str1, str2, str3, str4 };
            int smallestStr = stringArr.Min(x => x.Length);
            return smallestStr;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            // throw new NotImplementedException();

            int[] intArr = new int[] { number1, number2, number3, number4 };
            int smallestNumber = intArr.Min(x => x);
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            // throw new NotImplementedException();

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // throw new NotImplementedException();

            if (sideLength1 < sideLength2 + sideLength3 && sideLength2 < sideLength3 + sideLength1 && sideLength3 < sideLength1 + sideLength2)
            { return true; }
            else { return false; }
        }

        public bool IsStringANumber(string input)
        {
            // throw new NotImplementedException();

            double doubleInput;
            return double.TryParse(input, out doubleInput);

            // note tryparse returns bool; true if conversion worked, false if didnt.
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();


        }

        public double AverageEvens(int[] numbers)
        {
             throw new NotImplementedException();
           
            if (numbers == null) { return 0; }

            double sum = 0;

            foreach (var item in numbers)
            {
                if ( item % 2 == 0) { return sum += item; }
            }

            int numberOfEvens = 0;

            foreach (var item2 in numbers)
            {
                if ( item2 % 2 == 0) { numberOfEvens++; }
            }

            if (numberOfEvens == 0) { return 0; }
            return sum / numberOfEvens;
        }

        public int Factorial(int number)
        {
             throw new NotImplementedException();

            //for (int i = number; i > 0; i--)
            //{
            //    number *= i;
            //}
            //return number;
        }
    }
}
