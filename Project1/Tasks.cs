using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    public class Tasks
    {
        public static List<int> Task1Function(List<object> input)
        {

            for (int i = input.Count-1; i >= 0; --i)
            {
                if (input[i] is string)
                {
                    input.RemoveAt(i);
                }
            }
            var output = input.Cast<int>().ToList();
            return output;

        }

        public static char Task2Function(string input)
        {
            var output = ' ';
            for (int i =0; i <= input.Length-1; ++i) {
                var count = input.Count(x => x == input[i]);
                if (count == 1)
                    return input[i];
            }

            return output;

        }

        public static int Task3Function(int input)
        {
            if (input < 0)
                input = input * (-1);
            var output = 100;
            var num=input;
            while (output > 10)
            {
                List<int> listOfDigits = new List<int>();
                while (num > 0)
                {
                    listOfDigits.Add(num % 10);
                    num = num / 10;
                }
                listOfDigits.Reverse();
                output = listOfDigits.Take(listOfDigits.Count).Sum();
                num = output;
            }

            return output;
        }

        public static int Task4Function(List<int> inputArray, int target)
        {
            List<KeyValuePair<int, bool>> dict = new List<KeyValuePair<int, bool>>();

            inputArray.Sort();

            for (int i = 0; i < inputArray.Count; ++i)
            {
                dict.Insert(i, new KeyValuePair<int, bool>(inputArray[i], false));
            }
            var output = 0;
            var count = 0;

            for (int i = 0; i < dict.Count; ++i)
            {
                Console.WriteLine(dict[i].Key + dict[i].Value.ToString());
                if (dict[i].Key >= target)
                {
                    break;
                    Console.WriteLine("break");
                }
                if (dict[i].Value == false)
                {
                    Console.WriteLine(dict[i].Key + dict[i].Value.ToString());
                    count = dict.Where(temp => temp.Key.Equals(target - dict[i].Key) && temp.Value.Equals(false))
                    .Select(temp => temp)
                    .Count();
                    output += count;
                    Console.WriteLine(count + "" + output);
                    var key = dict[i].Key;
                    dict.Remove(new KeyValuePair<int, bool>(dict[i].Key, false));
                    dict.Insert(i, new KeyValuePair<int, bool>(key, true));
                    Console.WriteLine(dict[i].Key + dict[i].Value.ToString());
                }
            }
            Console.WriteLine(output);
            return output;
        }

        public static string Task5Function(string input)
        {
            string output = "";
            List<string> guestsSeparated = new List<string>();
            input = input.ToUpper();
            var semicolon = input.Length - 1;
            var colon = input.Length - 1;
            string surname = "";
            string name = "";
            for (int i = (input.Length - 1); i >= 0; --i)
            {
                if (input[i].Equals(':'))
                {
                    surname = input.Substring(i + 1, semicolon - i - 1);
                    colon = i;

                }
                if (input[i].Equals(';'))
                {
                    name = input.Substring(i + 1, colon - i - 1);
                    guestsSeparated.Add("(" + surname + "," + name + ")");
                    semicolon = i;
                }
                if (i == 0)
                {
                    name = input.Substring(i, colon - i);
                    guestsSeparated.Add("(" + surname + "," + name + ")");
                }


            }
            guestsSeparated.Sort();
            foreach (string item in guestsSeparated)
                output += item;
            return output;
        }

    }
}
