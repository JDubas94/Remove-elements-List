using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "save", "delete", "save", "delete", "save", "delete" };

            var listArray = myArray.ToList();

            for (int i = listArray.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    listArray.RemoveAt(i);
                }
            }
            string[] newArray = listArray.ToArray();

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            Console.ReadLine();
        }
    }
}
