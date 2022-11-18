using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) // done
        {
            // throw new NotImplementedException();

            return vals.Contains(false); //? true : false;          
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) // done
        {
            // throw new NotImplementedException();

            return (numbers == null) ? false : (numbers.Where(x => x % 2 != 0).Sum() % 2 != 0);

            // ----------- OR -------------------

            //var sum = 0;
            //if (numbers == null || numbers.Count() == 0) { return false; }

            //foreach (var item in numbers)
            //{
            //    if (item % 2 != 0) { sum += item; }
            //}

            //if (sum % 2 != 0) { return true; }
            //return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password) // done
        {
            // throw new NotImplementedException();

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber); //? true : false;
        }

        public char GetFirstLetterOfString(string val) // done
        {
            // throw new NotImplementedException();

             return val[0];

            // -------------------- OR -------------------

            // return val.First();
        }

        public char GetLastLetterOfString(string val) // done
        {
            // throw new NotImplementedException();

            return val[val.Length - 1];

            // -------------------- OR -------------------

            // return val.Last();

            // -------------------- OR -------------------

            // return val[^1];  // carrot indexing backwards, [^3] would be 3rd from last
        }

        public decimal Divide(decimal dividend, decimal divisor) // done
        {
            // throw new NotImplementedException();

            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums) // done
        {
            // throw new NotImplementedException();

            // return nums[nums.Length - 1] - nums[0];

            // ------------------ OR ---------------

            // return nums.Last() - nums[0];

            // ------------------ OR ---------------

            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            // throw new NotImplementedException();

            //var list = new List<int>();

            //for (int i = 0; i < 100; i++)
            //{
            //    if(i % 2 != 0) { list.Add(i); }
            //}

            //return list.ToArray();

            // ------------------ OR ---------------

            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();

                //Range generates numbers 0-100, Where filters collections to just odds,
                        //ToArray converts from Enumerable (which is needed to use range)
                            //to an Array
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           // throw new NotImplementedException();

           for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();      
            }

            // note if the scope was just words[i].ToUpper,
            // it just changes them temporarily

            // note foreach loop cannot be used bc it only 
            // changes each item temporarily
        }
    }
}
