using asp.net7.Interfaces;
using System.Threading;

namespace asp.net7
{
    public class ListPattern : IListPattern
    {
        bool one, two, three, four, five;

        public ListPattern()
        {
            var example1 = new int[] { 1, 10 };
            var example2 = new int[] { 1, 2, 10 };
            var example3 = new int[] { 1, 2777, 56,  10 };
            var example4 = new int[] { 2777, 56, 10 };
            var example5 = new int[] { 2777, 1, 56, 10 };

            one = Slice(example1);
            two = Slice(example2);
            three = Slice(example3);
            four = Slice(example4);
            five = Slice(example5);
        }

        public bool Slice(int[] myNumbers)
        {
            return myNumbers is [1, .., 10];
        }


        public bool Contains(int[] myNumbers)
        {
            if (myNumbers is [.., 5])
            {
                return true;
            }

            return myNumbers is [7];
        }

        public string SliceAndDiscard(string[] urls)
        {
            return urls switch
            {
                [_, .. string[] entries, _] => string.Join(" + ", entries)
            };


            //"DISCARD", "ONE", "TWO", "THREE", "DISCARD"
            // "ONE" + "TWO" + "THREE"

        }

        public string Discard()
        {
            var (_, _, country) = GetAddress();
            return country;
        }

        public (string, string, string) GetAddress()
        {
            return ("Poole", "Dorset", "England");
        }
    }
}
