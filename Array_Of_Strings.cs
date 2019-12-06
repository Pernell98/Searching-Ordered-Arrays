using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Array_Of_Strings
    {
        private string[] words = { "friends", "romans", "and", "countrymen", "lend", "me", "your", "ears", "I", "come","to", "bury", "ceasar","not","to","praise", "him" };
        private string [] sortedWords;

        public Array_Of_Strings()
        {
            //bubbleSort();

            //display();

            insertionSort();

            Console.WriteLine("Which sort would you like to run?\n0- Exit\n1- Bubble Sort\n2- Insertion Sort\n3- Selection Sort");
              Console.WriteLine("Which sort would you like to run?\n0- Exit\n1- Bubble Sort\n2- Insertion Sort\n3- Selection Sort");


            switch (int.Parse(Console.ReadLine()))
            {

                case 0:

                    System.Environment.Exit(0);

                    break;


              switch (int.Parse(Console.ReadLine()))
              {
                  case 0:

                      System.Environment.Exit(0);

                      break;

                case 1:                   

                    display("unsorted words: ", words);

                  case 1:                   

                      display("unsorted words: ", words);

                    sortedWords = bubbleSort(words);

                    display("sorted words using Bubble sort: ", sortedWords);

                      sortedWords = bubbleSort(words);

                      display("sorted words using Bubble sort: ", sortedWords);

                    Console.WriteLine("what would you like to do next?\n0- Exit\n1- Search for a word\n2- add a word\n3- remove a word");

                      Console.WriteLine("what would you like to do next?\n0- Exit\n1- Search for a word\n2- add a word\n3- remove a word");

                    secondaryOptions(int.Parse(Console.ReadLine()));

                      secondaryOptions(sortedWords, int.Parse(Console.ReadLine()));

                    break;

                      break;

                case 2:

                  case 2:

                    display("unsorted words: ", words);

                      display("unsorted words: ", words);

                    sortedWords = insertionSort(words);

                    display("sorted words using Insertion sort: ", sortedWords);

                      sortedWords = insertionSort(words);

                      display("sorted words using Insertion sort: ", sortedWords);

                    Console.WriteLine("what would you like to do next?\n0- Exit\n1- Search for a word\n2- add a word\n3- remove a word");

                      Console.WriteLine("what would you like to do next?\n0- Exit\n1- Search for a word\n2- add a word\n3- remove a word");

                    secondaryOptions(int.Parse(Console.ReadLine()));

                      secondaryOptions(sortedWords, int.Parse(Console.ReadLine()));

                    break;

                      break;



                case 3:

                  case 3:

                    display("unsorted words: ", words);

                      display("unsorted words: ", words);

                    sortedWords = selectionSort(words);

                    display("sorted words using Selection sort: ", sortedWords);

                      sortedWords = selectionSort(words);

                      display("sorted words using Selection sort: ", sortedWords);

                    Console.WriteLine("what would you like to do next?\n0- Exit\n1- Search for a word\n2- add a word\n3- remove a word");

                      Console.WriteLine("what would you like to do next?\n0- Exit\n1- Search for a word\n2- add a word\n3- remove a word");

                    secondaryOptions(int.Parse(Console.ReadLine()));

                    break;
              }
                      secondaryOptions(sortedWords, int.Parse(Console.ReadLine()));
                      break;

                default:

                    break;
            }
        }

     

        public void searchForAWord(string searchWord)
        {
            int count = 1;

            for(int a = 0; a < words.Length; a++)
            {
                if (searchWord == words[a])
                {
                    Console.WriteLine("the search word is in index " + count);
                }
                count++;
            }
        }

         public string[] addAWord(string word)
         {         
            string[] newArray = new string[words.Length + 1];

            for (int a = 0; a < newArray.Length - 1; a++)
            {
                newArray[a] = words[a];
            }

            newArray[words.Length] = word;
            words = newArray;
            return words;
         }

        public void removeAWord(string[] words)

        public string[] removeAWord(string[] words, int index)
        {
            /*
            * Must continually work on this method
            * 
            */

            string[] newArray = new string[words.Length - 1];

            for (int a = 0; a < newArray.Length; a++)

            for (int a = 0, b = 0; a < newArray.Length; a++)
            {
                if (words[a].Equals("countrymen"))


                if(a == index)
                {
                    newArray[a] = words[a + 1];

                    continue;
                }



                else
                {
                    newArray[a] = words[a];
                }

                newArray[b++] = words[a];
            }
            return newArray;
        }

        public string[] bubbleSort()
        {
            for(int a  = 0;  a < words.Length-1; a++)
            {
                for (int b = a + 1; b < words.Length; b++)
                {
                    if(words[a].CompareTo(words[b]) > 0)
                    {
                        string temp = words[a];
                        words[a] = words[b];
                        words[b] = temp;

                    }

                }
            }

            return words;
        }

        public void insertionSort(string [] words)
        {

            for(int a = 0; a < words.Length - 1; a++)

            {
                for(int b = a + 1;  b > 0; b--)
                {
                    if(words[b-1].CompareTo(words[b]) > 0)
                    {
                        string temp = words[b-1];
                        words[b-1] = words[b];
                        words[b] = temp;
                    
                    }
                }
            }
        }

        public void SelectionSort(string [] array)
        {

            for(int a = 0; a < words.Length - 1; a++)

            {
                int smallest = a;
                {
                    for (int b = a + 1; b < array.Length; b++)
                    {
                        if (array[b].CompareTo(array[smallest]) < 0)
                        {
                            smallest = b;
                        }
                    
                    }

                    temp = array [smallest];
                    array[smallest] = array[a];
                    array[a] = temp;

                }
            }

            return array;
        }

        public void display()
        {
            for(int a = 0; a < words.Length; a++)
            {
                Console.WriteLine(words[a]); 
            }
        }

        public void secondaryOptions(int opt)

        public void secondaryOptions( string[] sortedArray, int opt)
        {
            switch (opt)
            {

                case 0:

                    System.Environment.Exit(0);

                    break;


                case 1:

                    Console.WriteLine("what word would you like to look for?");
                    searchForAWord(Console.ReadLine());

                    break;


                case 2:

                Console.WriteLine("What word would you like to add to the array?");

                    string[] newArray =  addAWord(Console.ReadLine());
                    string[] sortedArry =  addAWord(Console.ReadLine());
                    display(sortedArray);

                    break;


                case 3:

                    Console.WriteLine("What index would you like a word to be remvoed from?");

                    string[] newArray = removeAWord(sortedArray, int.Parse(Console.ReadLine()));

                    display(newArray);

                    break;

                default:

                    break;

            }
        }
    }
}
