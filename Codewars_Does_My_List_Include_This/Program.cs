using System;
using System.Linq;

namespace Codewars_Does_My_List_Include_This
{
    //##TASK DESCRIPTION##
    //Create a method that accepts a list and an item, and returns true if the item belongs to the list, otherwise false.


    class Program
    {
        static void Main(string[] args)
        {
            //MySolution
            bool Include(int[] arr, int item)
            {
                if (arr.Contains(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Codewars best solution + code review for myself

            bool Include2(int[] arr, int item)
            {
                return arr.Contains(item); //arr.Contians return true or false so i could simply put it in return. That was so obvious :(
            }
        }
    }
}
