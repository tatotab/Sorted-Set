using assig4.COMPE361;
using System;
using System.Collections.Generic;



namespace assig4
{
/// <summary>
/// Dimitri Tabagari
/// Comp E361 Assig4
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Creating First Set Using Default Constructor");
            Set<int> set1 = new Set<int>();
            Console.WriteLine($"First Set is empty: {set1.isEmpty}");
            int i;
            for(i =2; i<15; i +=2)
            {
                set1.Add(i);
            }
            //check add method, itshouldn't add same thing twice
            set1.Add(i);
            Console.WriteLine("Set1 is Empty after using Add(): " + set1.isEmpty);
            Console.Write("Displaying set1 : ");
            foreach (var datum in set1)
            {
                Console.Write(datum + ",  ");
            }
            Console.WriteLine($"\nCount Elements in Set: {set1.Count} ");


            int[] arrayCollection = new int[] { 1, 3, 4, 6, 7, 8, 4 };
            
            Console.WriteLine("\nCreating Second using parametrized constructor");
            Set<int> set2 = new Set<int>(arrayCollection);
            Console.WriteLine($"Second Set is empty: {set2.isEmpty}");
            Console.Write("Displaying set2 : ");
            foreach (var item in set2)
            {
                Console.Write(item + ",  ");
            }
            Console.WriteLine("\n5 is in the set and can be removed : " + set2.Remove(5));
            Console.WriteLine("8 is in the set and can be removed : " + set2.Remove(8));
            Console.Write("After executing code to remove 5 and 8 \nSecond Set : ");
            foreach (var item in set2)
            {
                Console.Write(item + ",  ");
            }
           
            Console.Write("\n\nUsing operator overloading to get Union of sets\nUnion of sets: ");
            
            Set<int> unionSet = set1 + set2;
            foreach (var item in unionSet)
            {
                Console.Write(item + ",  ");
            }
           
            

            static bool Filtering(int e)
            {
                if (e >8)
                    return true;
                else
                    return false;
            }
            
            Console.Write("\nCreating and Displaying Filtered Set(there should int>8): ");
            Set<int> filtered = unionSet.Filter(Filtering);
            foreach (var item in filtered)
            {
                Console.Write(item + ",  ");
            }
            Console.WriteLine($"\nFiltered list Contains 8: {filtered.Contains(8)}");
            Console.WriteLine($"Filtered list Contains 14: {filtered.Contains(14)}");

            
        }
    }
}
