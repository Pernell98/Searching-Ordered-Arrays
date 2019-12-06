using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Array_Of_Primitives
    {
        private int[] numbers = new int[10];
        Random randomNumberGenerator = new Random();

        public Array_Of_Primitives()
        {
            numbers = addRandomNumbers();

            numbers = bubbleSort(numbers);

            numbers = insertionSort(numbers);

            numbers = selectionSort(numbers);

            display("Bubble Sort ", numbers);
            display("Insertion Sort ", numbers);
            display("Selection Sort ", numbers);

             private int[] numbers = new int[10];


        Random randomNumberGenerator = new Random();

        public Array_Of_Primitives()
        {


            do
            {
                int options;
                Console.WriteLine("which sort would you like to run\n0-Exit\n1- Bubble Sort\n2- Insertion Sort\n3- Selection Sort\n");
                options = int.Parse(Console.ReadLine());

                switch (options)
                {


                    case 0:

                        System.Environment.Exit(0);
                        break;

                    case 1:

                        numbers = addRandomNumbers();

                        display("Unsorted Numbers: ", numbers);

                        numbers = bubbleSort(numbers);

                        display("Sorted Numbers: ", numbers);

                        Console.WriteLine("What would you liked to do next?\n0- Exit\n1- search For a number\n2- add a Number\n3- remove a Number");

                        secondaryOptions(int.Parse(Console.ReadLine()));

                        secondaryOptions(numbers, int.Parse(Console.ReadLine()));

                        break;

                    case 2:

                        numbers = addRandomNumbers();

                        display("unsorted numbers ", numbers);

                        numbers = insertionSort(numbers);

                        display("sorted Numbers: ", numbers);

                        Console.WriteLine("What would you liked to do next?\n0- Exit\n1- search For a number\n2- add a Number\n3- remove a Number");

                        secondaryOptions(int.Parse(Console.ReadLine()));

                        secondaryOptions(numbers, int.Parse(Console.ReadLine()));

                        break;


                    case 3:

                        numbers = addRandomNumbers();

                        display("unsorted numbers ", numbers);

                        numbers = selectionSort(numbers);

                        display("sorted Numbers: ", numbers);

                        Console.WriteLine("What would you liked to do next?\n0- Exit\n1- search For a number\n2- add a Number\n3- remove a Number");

                        secondaryOptions(int.Parse(Console.ReadLine()));

                        secondaryOptions(numbers, int.Parse(Console.ReadLine()));

                        break;

                    default:

                        break;
                }
            } while (true);
        }

        public void searchANumber(int number)
        {


            for(int a =0; a < numbers.Length; a++)
            {


                if (number == numbers[a])
                {
                    Console.WriteLine(number + " was found in the list");

                    return;
                }
            }
            Console.WriteLine(number + " was not found in the array");
        }

         public int[] addRandomNumbers()
         {
           for(int a = 0; a < numbers.Length; a++)
           {
                int temp = randomNumberGenerator.Next(100);
                numbers[a] = temp;

               for (int p = 0; p < a; p++)
               {
                   if (numbers[a] == numbers[p])
                       a--;
               }
           }
           return numbers;
         }
    
        public void removeNumber()



        public int[] removeNumber(int[] array, int index)
        {
            /*
             * continue working on this method
             * 
             */
            int[] orginal = new int[] { 113,111,12,32,53 };

            int[] newArray = new int[orginal.Length-1];

            int removeNumber = 2;


            for(int a =0; a < newArray.Length; a++)
            {
                newArray[a] = orginal[a];

            int [] newArray = new int[array.Length - 1];


                if (removeNumber == a)

            for (int a = 0, b = 0; a < newArray.Length; a++)
            {



                if (a == index)
                {
                    newArray[a] = orginal[a+1];

                    continue;
                }

                newArray[b++] = array[a];

            orginal = newArray;
            array = newArray;
            return newArray;
            }
        }

        public int[] addRandomNumbers()
        {
           for(int a = 0; a < numbers.Length; a++)
           {
               numbers[a] = randomNumberGenerator.Next(20);


               for (int p = 0; p < a; p++)
               {
                   if (numbers[a] == numbers[p])
                       a--;
               }
           }

           return numbers;
        }

        public int[] bubbleSort(int[] numbers)
        {
            int temp = 0;

            for(int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length - 1; b++)
                {
                    if (numbers[b] > numbers[b + 1])
                    {
                        temp = numbers[b + 1];
                        numbers[b + 1] = numbers[b];
                        numbers[b] = temp;
                    }
                }    
            }
            return numbers;
        }

         public int[] insertionSort(int[] array)
          

            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b > 0; b--)
                {
                    if (array[b - 1] > array[b])
                    {
                        int temp = array[b - 1];
                        array[b - 1] = array[b];
                        array[b] = temp;
                    }

                }

            }
            return array;
          
        }
        public int[] selectionSort(int[] array)
        {
            int temp;

            for(int a =0; a < array.Length -1; a++ )
            {
                int smallest = a;

                for(int b = a + 1; b < array.Length; b++)
                {
                    if(array[b] < array[smallest])
                    {
                        smallest = b;

                       
                    }
                    
                }

                temp = array[smallest];
                array[smallest] = array[a];
                array[a] = temp;
            }

            return array;
        }

        public void display(int[] array)
        {
            for(int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }

        public void display( string sort, int[] array)
        {
            string output = "";
            for (int a = 0; a < array.Length; a++)
            {
                output += array[a];
            }

            Console.WriteLine( sort + output);
        }

        public void secondaryOptions(int opt)
        {



          public void secondaryOptions(int[] array, int opt)
          { 



            switch (opt)
            {

                case 1:

                    Console.WriteLine("What number are you looking for");

                    int number = int.Parse(Console.ReadLine());

                    searchANumber(number);

                    break;


                case 2:

                    Console.WriteLine("what number would you like to insert into the array?");

                    int[] temp = addANumber(int.Parse(Console.ReadLine()));

                    int[] newArray = addANumber(array, int.Parse(Console.ReadLine()));
                    temp = bubbleSort(temp);
                   int[] temp = bubbleSort(newArray);

                    display("The new sets of numbers are " , temp);

                    break;


                case 3:

                    Console.WriteLine("what number would you like to insert into the array?");

                    int[] removedNumber = removeNumber(array, int.Parse(Console.ReadLine()));

                   int[] sort = bubbleSort(removedNumber);

                    display("new array with number removed: ", sort);

                   break;

                default:

                   break;
            }
          }
        }
    }
}
