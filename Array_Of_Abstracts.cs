using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    class Array_Of_Abstracts
    {
        private Nodes[] arrayOfNodes = new Nodes[2];
        public Array_Of_Abstracts()
        {
            Console.WriteLine("which sort would you like to run?\n0- Exit\n1- Bubble Sort\n2- Inserstion Sort\n3- Selection Sort");

            switch (int.Parse(Console.ReadLine()))
            {
                 case 0:

                    System.Environment.Exit(0);

                    break;

                     case 1:

                    arrayOfNodes = addName();

                    Nodes[] sortedNodeBubble = bubbleSort(arrayOfNodes);

                    display("Sorted Nodes using Bubble Sort: ", sortedNodeBubble);

                    Console.WriteLine("What would like to do next\n0- Exit\n1- search for a node\n2- add a node\n3- remove a node");

                    int bubbleOpt = int.Parse(Console.ReadLine());

                    secondaryOptions(sortedNodeBubble, bubbleOpt);

                    break;


                    case 2:

                    arrayOfNodes = addName();

                    Nodes[] sortedNodeInsertion = bubbleSort(arrayOfNodes);

                    display("Sorted Nodes using Insertion Sort: ", sortedNodeInsertion);

                    Console.WriteLine("What would like to do next\n0- Exit\n1- search for a node\n2- add a node\n3- remove a node");

                    int insertionOpt = int.Parse(Console.ReadLine());

                    secondaryOptions(sortedNodeInsertion, insertionOpt);

                    break;

                     case 3:


                    arrayOfNodes = addName();

                    Nodes[] sortedNodeSelection = bubbleSort(arrayOfNodes);

                    display("Sorted Nodes using Selection Sort: ", sortedNodeSelection);

                    Console.WriteLine("What would like to do next\n0- Exit\n1- search for a node\n2- add a node\n3- remove a node");

                    int selectionOpt = int.Parse(Console.ReadLine());

                    secondaryOptions(sortedNodeSelection, selectionOpt);

                    break;

                     
                    default:

                         break;
            }

        }


        public void searchForAName(Nodes[] array, string name)
        {
            for (int a = 0; a < array.Length; a++)
            {


                if (name == array[a].firstName)
                {
                    Console.WriteLine("Found " + name);

                    return;
                }


                else
                {
                    Console.WriteLine(name + " is not in the array");

                    return;
                }
            }
        }

        public Nodes[] addANode(Nodes[] arrayOfNodes, string name)
        {
            Nodes[] newArray = new Nodes[arrayOfNodes.Length + 1];

            for(int a = 0; a < newArray.Length -1; a++)
            {
                newArray[a] = arrayOfNodes[a];
            }

            newArray[newArray.Length - 1] = new Nodes();

            newArray[newArray.Length-1].firstName = name;

            return arrayOfNodes = newArray;
        }

        public Nodes[] removeANode(Nodes[] array, int index)
        {
            Nodes[] newArray = new Nodes[array.Length - 1];

            for (int a = 0, b = 0; a < newArray.Length; a++)
            {
                if (a == index)
                {
                    continue;
                }

                newArray[b++] = array[a];

            }
           return array = newArray;
        }


        public Nodes[] addName()
        {
            for (int a = 0; a < arrayOfNodes.Length; a++)
            {
                Nodes temp = new Nodes();

                Console.WriteLine("PLease enter name");
                temp.firstName = Console.ReadLine();

                arrayOfNodes[a] = temp;
            }

            return arrayOfNodes;
        }

        public void display(Nodes[] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a].firstName);
            }
        }

        public void display(string comment, Nodes [] array)
        {
            string output = "";

            for (int a = 0; a < array.Length; a++)
            {
                output += array[a].firstName + " ";
            }

            Console.WriteLine(comment + output);
        }

        public Nodes[] BubbleSort(Nodes [] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    if (array[a].firstName.CompareTo(array[b].firstName) > 0)
                    {
                        Nodes temp = array[a];
                        array[a] = array[b];
                        array[b] = temp;
                    }
                }
            }

            return array;
        }

        public Nodes[] insertionSort(Nodes[] array)
        {
            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b < array.Length; b--)
                {
                    if (array[b-1].firstName.CompareTo(array[b].firstName) > 0)
                    {
                        Nodes temp = array[b-1];
                        array[b-1] = array[b];
                        array[b] = temp;
                    }
                }
            }

            return array;
        }

        public Nodes [] SelectionSort(Nodes [] array)
        {
            Nodes temp;

            for (int a = 0; a < array.Length - 1; a++)

            {
                int smallest = a;
                {
                    for (int b = a + 1; b < array.Length; b++)
                    {
                        if (array[b].firstName.CompareTo(array[smallest].firstName) < 0)
                        {
                            smallest = b;
                        }
                    }

                    temp = array[smallest];
                    array[smallest] = array[a];
                    array[a] = temp;

                }
            }

            return array;
        }

         public void secondaryOptions( Nodes[] arrayOfNodes, int opt)


        public void secondaryOptions(Nodes[] sortedNodeBubble, int opt)
        {

            switch (opt)  //Not sure why my switch statement is bleeding

                if (opt == 0)
                {
                case 0:

                System.Environment.Exit(0);
                 break;
                System.Environment.Exit(0);
                }
                else if (opt == 1)
                {
                Console.WriteLine("what name would you like to search for?");

                case 1:

                    searchForAName(arrayOfNodes, string name);
                    break;
                searchForAName(sortedNodeBubble, Console.ReadLine());
                }
                 else if (opt == 2)
                 {
                Console.WriteLine("what would you like to enter");
                 }

                Nodes[] newNode = addANode(sortedNodeBubble, Console.ReadLine());

                display("new node array with added word: ", newNode);
        
                
                else if (opt == 3)
                {

                Console.WriteLine("Enter the index number?");
                int index = int.Parse(Console.ReadLine());

                Nodes[] newNode = removeANode(sortedNodeBubble, index);
                display("new node array with word removed: ", newNode);
                }
                else
                {
                Console.WriteLine(opt + " is invalid");
                }
   
        }
    }
}