using System;
using System.Collections.Generic;
using System.Collections; // non-generic version of Data structures.
class ListUsage
{
    public static void main()
    {
        Console.WriteLine("Jai Shree Ram");

        string[] nums = { "54", "546", "548", "60" };
        List<string> numStrings = new List<string>(nums);
        Console.WriteLine(numStrings.Count);
        Console.WriteLine();
        numStrings.Sort(compare);
        Console.WriteLine(numStrings.Contains("54"));

        numStrings.Sort(delegate (string x, string y)
        {
            string xy = x + y;
            string yx = y + x;
            return yx.CompareTo(xy);
        });

        List<int> nums1 = new List<int>();
        nums1.Add(2);

        Console.WriteLine(nums1.Count);

        ArrayList al = new ArrayList();
        al.Add(1);
        al.Add("ashok");
        ArrayList al1 = new ArrayList() { 1, "bill" };
        al.AddRange(al1);

        int[] arr = { 900, 940, 950, 1100, 1500, 1800 };
        int[] dep = { 910, 1200, 1120, 1130, 1900, 2000 };
        int count = 0, maxcount = 0;

        SortedList<int, char> sl = new SortedList<int, char>();
        foreach (int i in arr)
        {
            sl.Add(i, 'a');
        }
        foreach (int i in dep)
        {
            sl.Add(i, 'd');
        }
        foreach (KeyValuePair<int, char> kvp in sl)
        {
            if (kvp.Value == 'a')
            {
                count++;
                if (count > maxcount)
                {
                    maxcount = count;
                }
            }
            else if (kvp.Value == 'd')
            {
                count--;

            }
        }

        static int compare(string x, string y)
        {
            string xy = x + y;
            string yx = y + x;
            return yx.CompareTo(xy);
        }
    }
}


// documentation for collections generic -- Dictionary, SortedList, List, LinkedList, HashSet, Stack , Queue
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0