using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfWords
{
    class Program
    {
        public static void Main()
        {
            ArrayList ArrayOfWord = new ArrayList();
            ArrayOfWord.Add("Boat");
            ArrayOfWord.Add("house");
            ArrayOfWord.Add("cat");
            ArrayOfWord.Add("river"); ;
            ArrayOfWord.Add("cupboard");

            //Print the length of the array
            Console.WriteLine("Length Of Array : " + ArrayOfWord.Count+ "\n");
           


            //Printing plurals all the words
            Console.WriteLine("Plural Of Words : ");

            foreach (string word in ArrayOfWord)
            {
                Console.WriteLine( word+" : "+ word + "s");
            }

            ArrayOfWord.Add("Achieve");
            Console.WriteLine("\nLength Of Array After Insertion Of New Element : " + ArrayOfWord.Count+"\n");
            

            //Replace Of 2nd word with it's synonym and printing
            for (int i = 0; i < ArrayOfWord.Count; i++)
            {
                if ((string)ArrayOfWord[i] == "house")
                {
                    ArrayOfWord[i] = "home";
                }
            }
            Console.WriteLine("House Changed to its synonym :" + ArrayOfWord[1]+"\n");
           

            //Printing The List Words Having Length 7 Characters
            Console.WriteLine("Printing Words of Length 7");
            for (int i = 0; i < ArrayOfWord.Count; i++)
            {
                string w = (string)ArrayOfWord[i];
                if (w.Length == 7)
                {
                    Console.WriteLine(ArrayOfWord[i]);
                }

            }

            //printing the word in 3rd position
            Console.WriteLine("\nWord On 3rd Position :" + ArrayOfWord[2]+"\n");
            

            //Sorting The Words In Ascending Order
            Console.WriteLine("After sorting In Ascending Order :");
            for (int i = 0; i < ArrayOfWord.Count; i++)
            {

                ArrayOfWord.Sort();

                Console.WriteLine(ArrayOfWord[i]);
            }
            //Printing The Reverse Of Array
            Console.WriteLine("\nReverse Order Of Array :");
            for (int i = 0; i < ArrayOfWord.Count; i++)
            {
                ArrayOfWord.Reverse();
                Console.WriteLine(ArrayOfWord[i]);
            }
            Console.ReadKey();

        }

        private static void PrintValues(IEnumerable ArrayOfWord)
        {
            foreach (Object obj in ArrayOfWord)
            {
                Console.WriteLine("  {0}", obj);
                Console.WriteLine();
            }
        }
    }
}
