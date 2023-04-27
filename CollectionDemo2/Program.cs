using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 2, 3, 2, 2, 52, 6, 7, 5, 3, 5, 7, 8, 9, 9, 7, 6, 5, 52, 1, 7 };
            Dictionary<int, int> numberOccurences = CountInstances(numberArray);
            foreach (KeyValuePair<int, int> value in numberOccurences)
            {
                Console.WriteLine($"Key:{value.Key} and value:{value.Value}");
            }
            Console.ReadLine();
        }

        public static Dictionary<int, int> CountInstances(int[] inputArray)
        {
            Dictionary<int, int> instancesDict = new Dictionary<int, int>();
            foreach (int item in inputArray)
            {
                if (instancesDict.ContainsKey(item))
                {
                    instancesDict[item] += 1;
                }
                else
                {
                    instancesDict[item] = 1;
                }
            }
            return instancesDict;
        }
    }
}
