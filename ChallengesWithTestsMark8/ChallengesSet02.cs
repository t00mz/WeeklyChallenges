using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)   // done
        {
            //if (Char.IsLetter(c)) { return true; }
            //    return false;      

            return Char.IsLetter(c);

            // throw new NotImplementedException();

        }

        public bool CountOfElementsIsEven(string[] vals) // done
        {
            // throw new NotImplementedException();

            //if(vals.Length % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            // return vals.Length % 2 == 0 ? true : false;

            return vals.Length % 2 == 0;  //if RETURN TYPE IS BOOL, u dont need
                                          //the ? true : false;

        }

        public bool IsNumberEven(int number) // done
        {
            // throw new NotImplementedException();

            //if (number % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num) => (num % 2 != 0);

            // using LAMBDA makes the method a 1 liner, with no scope
        
           // throw new NotImplementedException();

        // {
            // return num % 2 != 0;
        // }

        public double SumOfMinAndMax(IEnumerable<double> numbers) // done
        {
            //  throw new NotImplementedException();

            //if (numbers == null || numbers.Count() == 0) { return 0; }

            //return numbers.Min() + numbers.Max();

            return (numbers == null || numbers.Count() == 0) ? 0 : (numbers.Min() + numbers.Max());
        
           
        }

        public int GetLengthOfShortestString(string str1, string str2) // done
        {
            // throw new NotImplementedException();

            //if (str1.Length > str2.Length)
            //{
            //    return str2.Length;
            //}
            //else
            //{
            //    return str1.Length;
            //}

            return str1.Length < str2.Length ? str1.Length : str2.Length;
       
        }

        public int Sum(int[] numbers)   // done, question
        {
            //throw new NotImplementedException();

            //if (numbers == null) { return 0; }

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) { sum += numbers[i]; }

            //return sum;

            return numbers?.Sum() ?? 0;

            // the "?" behind numbers makes it accept nulls
            // "??" null coalesing operator: says if everything infront of the "??" returns null, than return "0";

            // note if you wanted to return TRUE if code results in null, write: ?? true;
            // "?? 0" replaces "if (numbers == null) { return 0; };

        }

        public int SumEvens(int[] numbers)
        {
            // throw new NotImplementedException();

            //if (numbers == null) { return 0; }

            //var sumEvens = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) { sumEvens += numbers[i]; }
            //}

            //return sumEvens;

            return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;

            // the "?" behind numbers makes it accept nulls
            // "??" null coalesing operator: says if everything infront of the "??" returns null, than return "0";

                // note if you wanted to return TRUE if code results in null, write: ?? true;
                // "?? 0" replaces "if (numbers == null) { return 0; };
        }


        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();

            return (numbers == null) ? false : numbers.Sum() % 2 != 0;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();

            //if (number < 0)
            //{
            //    return 0;
            //}

            return (number < 0) ? 0 : number / 2;

        }
    }
}
