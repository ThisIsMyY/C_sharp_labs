using System;

namespace ThreeSorts
{
    internal class Program
    {
        //Animated examples of how sorts working

        static void ArrayCreating(ref int[] numArray, ref int arrayLength, ref int newElem, ref int arrayType, ref int searchNumber, ref string searchNumberIndex)
        {
            while (true)
            {
                Console.WriteLine("1.Random array\n2.My elements");
                Console.Write("Choose array type: ");

                try
                {
                    arrayType = Convert.ToInt32(Console.ReadLine());
                    if (arrayType > 0)
                    {
                        if (arrayType == 1)
                        {
                            Console.WriteLine("\nEnter array length(5-1000): ");
                            arrayLength = int.Parse(Console.ReadLine());
                            numArray = new int[arrayLength];

                            if (arrayLength < 5 || arrayLength > 1000)
                            {
                                Console.WriteLine("Wrong length! Try again.");
                            }
                            else
                            {
                                Random rand = new Random();
                                for (int arrIndex = 0; arrIndex < numArray.Length;)
                                {
                                    bool numExist = false;
                                    newElem = rand.Next(1, 1001);
                                    for (int i = 0; i < arrIndex; i++)
                                    {
                                        if (numArray[i] == newElem)
                                        {
                                            numExist = true;
                                            break;
                                        }
                                    }
                                    if (numExist == false)
                                    {
                                        numArray[arrIndex] = newElem;
                                        arrIndex++;
                                    }
                                }
                                break;
                            }
                        }
                        else if (arrayType == 2)
                        {
                            Console.WriteLine("\nEnter array length(5-1000): ");
                            arrayLength = int.Parse(Console.ReadLine());
                            numArray = new int[arrayLength];

                            if (arrayLength < 5 || arrayLength > 1000)
                            {
                                Console.WriteLine("Wrong length! Try again...");
                            }
                            else
                            {
                                for (int arrIndex = 0; arrIndex < arrayLength; arrIndex++)
                                {
                                    Console.Write("array[{0}]: ", arrIndex);
                                    numArray[arrIndex] = int.Parse(Console.ReadLine());
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong array type! Try again...\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again...\n");
                }
            }
            Console.WriteLine("\nYour arrray:\n" + string.Join(", ", numArray) + "\n");
        }

        static void Searches(ref int[] numArray, ref int searchType, ref int searchNumber, ref string searchNumberIndex)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("1.Linear search\n2.Binary search\n3.Interpolation search\n4.GallopSearch\n");
                    Console.Write("Which search type do you wish to use: ");

                    searchType = Convert.ToInt32(Console.ReadLine());
                    if (searchType > 0)
                    {

                        Console.Write("Enter one of numbers({0}): ", string.Join(", ", numArray));
                        searchNumber = Convert.ToInt32(Console.ReadLine());
                        if (searchNumber > 0)
                        {
                            Console.WriteLine("Index of number:");
                            switch (searchType)
                            {
                                case 1:
                                    Console.Write(LinearSearch(numArray, searchNumber, searchNumberIndex));
                                    break;
                                case 2:
                                    Console.Write(BinarySearch(numArray, searchNumber, searchNumberIndex, numArray.Length - 1));
                                    break;
                                case 3:
                                    Console.Write(InterpolationSearch(numArray, searchNumber, searchNumberIndex));
                                    break;
                                case 4:
                                    Console.Write(GallopSearch(numArray, searchNumber, searchNumberIndex));
                                    break;
                            }
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("This is not a number! Try again...");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Vrong value! Try again...");
                }
            }
        }

        //Sort functions
        static void Swap(ref int elem1, ref int elem2)
        {
            int temp = elem1;
            elem1 = elem2;
            elem2 = temp;
        }

        static void AnimationSettings(int[] array, out string[] row1, out string[] row2,out string[] row3)
        {
            row1 = new string[array.Length];
            row2 = new string[array.Length];
            row3 = new string[array.Length];

            DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            Console.WriteLine("\n" + string.Join("   ", row1));
            Console.WriteLine(string.Join("   ", row2));
            Console.WriteLine(string.Join("   ", row3));
            Console.ReadKey();
        }

        static void AnimationLinesOutput(string[] row1, string[] row2, string[] row3)
        {
            Console.WriteLine("\n" + string.Join("   ", row1));
            Console.WriteLine(string.Join("   ", row2));
            Console.WriteLine(string.Join("   ", row3));
        }
        
        static void DefaultArgsForAnimationLines(int[] array, ref string[] row1, ref string[] row2, ref string[] row3)
        {
            for (int i = 0; i < array.Length; i++)
            {
                row1[i] = "   ";
                row2[i] = array[i].ToString();
                row3[i] = "   ";
            }
        }

        static int[] LinearSortAnimated(int[] array)//5 2 0 3 1 8 6
        {
            string[] row1;
            string[] row2;
            string[] row3;
            AnimationSettings(array, out row1, out row2, out row3);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[i] = array[i].ToString();
                    row2[i] = "   ";
                    row2[j] = "   ";
                    row3[j] = array[j].ToString();

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();

                    if (array[j] > array[i])
                    {
                        Swap(ref array[j], ref array[i]);
                    }
                }
            }
            DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            AnimationLinesOutput(row1, row2, row3);
            Console.WriteLine("Конец сортировки!");

            return array;
        }

        static int[] BubbleSortAnimated(int[] array)
        {
            string[] row1;
            string[] row2;
            string[] row3;
            AnimationSettings(array, out row1, out row2, out row3);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[j] = array[j].ToString();
                    row2[j] = "   ";
                    row2[j + 1] = "   ";
                    row3[j + 1] = array[j + 1].ToString();

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();

                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            AnimationLinesOutput(row1, row2, row3);
            Console.WriteLine("Конец сортировки!");

            return array;
        }

        static int[] InsertionSortAnimated(int[] array)// 5, 2, 10, 3, 8, 1
        {
            int index;
            int currentElem;

            string[] row1;
            string[] row2;
            string[] row3;
            AnimationSettings(array, out row1, out row2, out row3);

            for (int i = 0; i < array.Length; i++)
            {
                index = i;
                currentElem = array[i];

                if(index > 0 && currentElem >= array[index - 1])
                {
                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[i] = array[i].ToString();
                    row2[i] = "   ";
                    row2[index-1] = "   ";
                    row3[index-1] = array[index-1].ToString();

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();
                }

                while (index > 0 && currentElem < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;

                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[i] = array[i].ToString();
                    row2[i] = "   ";
                    row2[index] = "   ";
                    row3[index] = array[index].ToString();

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();
                }
                array[index] = currentElem;
            }
            DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

            Console.Clear();
            AnimationLinesOutput(row1, row2, row3);
            Console.WriteLine("Конец сортировки!");

            return array;
        }

        static int FindPivotIndexAnimated(int[] array, int minIndex, int maxIndex)//-5 8 0 4 3 1 7; -5 0 4 3 1; -5 0
        {
            string[] row1;
            string[] row2;
            string[] row3;
            AnimationSettings(array, out row1, out row2, out row3);

            int lastElem = array[maxIndex];
            int pivotIndex = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < lastElem)
                {
                    pivotIndex++;//4; 1; 0

                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[maxIndex] = array[maxIndex].ToString();
                    row2[maxIndex] = "   ";
                    row2[i] = "   ";
                    row3[i] = array[i].ToString();

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();

                    Swap(ref array[i], ref array[pivotIndex]);

                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[maxIndex] = array[maxIndex].ToString();
                    row2[maxIndex] = "   ";
                    row2[i] = array[i].ToString();
                    row3[i] = "   ";

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[maxIndex] = array[maxIndex].ToString();
                    row2[maxIndex] = "   ";
                    row2[i] = "   ";
                    row3[i] = array[i].ToString();

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();

                    Console.Clear();
                    DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);

                    row1[maxIndex] = array[maxIndex].ToString();
                    row2[maxIndex] = "   ";
                    row2[i] = array[i].ToString();
                    row3[i] = "   ";

                    AnimationLinesOutput(row1, row2, row3);
                    Console.ReadLine();
                }
            } //-5 0 4 3 1 8 7; -5 0 3 4 1; -5 0
            pivotIndex++;//5; 2; 1
            Swap(ref array[maxIndex], ref array[pivotIndex]);

            Console.Clear();
            DefaultArgsForAnimationLines(array, ref row1, ref row2, ref row3);
            AnimationLinesOutput(row1, row2, row3);
            Console.ReadLine();

            // -5 0 4 3 1 7 8; -5 0 1 3 4; -5 0
            // pivot = 5; pivot = 2; pivot = 0

            return pivotIndex;
        }

        static int[] QuickSortAnimated(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array; // -5 0 1 3 4 7 8
            }

            int pivotIndex = FindPivotIndexAnimated(array, minIndex, maxIndex);
            QuickSortAnimated(array, minIndex, pivotIndex - 1); // -5 0 4 3 1 - снова ищем pivot; -5 0
            QuickSortAnimated(array, pivotIndex + 1, maxIndex); // 8 - сработает return array, так как minIndex = maxIndex;

            return array;
        }

        static int[] LinearSort(int[] array)//5 2 0 3 1 8 6
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {

                    if (array[j] > array[i])
                    {
                        Swap(ref array[j], ref array[i]);
                    }
                }
            }

            return array;
        }
        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        //Console.WriteLine(string.Join(", ", array));
                    }
                }
            }
            return array;
        }

        static int[] InsertionSort(int[] array)// 5, 2, 10, 3, 8, 1
        {
            int index;
            int currentElem;

            for (int i = 0; i < array.Length; i++)
            {
                index = i;
                currentElem = array[i];
                while(index > 0 && currentElem < array[index - 1])
                {
                    //Console.WriteLine(string.Join(", ", array));
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = currentElem;
            }
            return array;
        }

        //QuickSort
        static int FindPivotIndex(int[] array, int minIndex, int maxIndex)//-5 8 0 4 3 1 7; -5 0 4 3 1; -5 0
        {
            int lastElem = array[maxIndex];
            int pivotIndex = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if(array[i] < lastElem)
                {
                    pivotIndex++;//4; 1; 0
                    Swap(ref array[i], ref array[pivotIndex]);
                }
            } //-5 0 4 3 1 8 7; -5 0 3 4 1; -5 0
            pivotIndex++;//5; 2; 1
            Swap(ref array[maxIndex], ref array[pivotIndex]);
            // -5 0 4 3 1 7 8; -5 0 1 3 4; -5 0
            // pivot = 5; pivot = 2; pivot = 0

            return pivotIndex;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array; // -5 0 1 3 4 7 8
            }

            int pivotIndex = FindPivotIndex(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1); // -5 0 4 3 1 - снова ищем pivot; -5 0
            QuickSort(array, pivotIndex + 1, maxIndex); // 8 - сработает return array, так как minIndex = maxIndex;

            return array;
        }

        //Search types
        static string LinearSearch(int[] array, int searchNum, string searchNumIndex)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == searchNum)
                {
                    searchNumIndex = Convert.ToString(index);
                    break;
                }
            }
            return searchNumIndex;
        }

        static string BinarySearch(int[] array, int searchNum, string searchNumIndex, int right, int left = 0)
        {
            int middle;
                while (true)
                {
                    middle = left + (right - left) / 2;
                    if(left > right)
                    {
                        break;
                    }   
                    if(right - left == 1)
                    {
                        if(array[right] == searchNum) {
                            searchNumIndex = Convert.ToString(right);
                            break;
                        }
                        else if(array[left] == searchNum) {
                            searchNumIndex = Convert.ToString(left);
                            break;
                        }
                        else break;
                    }
                    if (array[middle] == searchNum)
                    {
                        searchNumIndex = Convert.ToString(middle);
                        break;
                    }
                    else if (array[middle] > searchNum)
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle;
                    }
                }
                return searchNumIndex;
        }
        
        static string InterpolationSearch(int[] array, int searchNum, string searchNumIndex)
        {
            int left = 0;
            int right = array.Length - 1;
            int middle;

                while (array[left] < searchNum && array[right] > searchNum)
                {
                    if(array[left] == array[right])
                    {
                        break;
                    }
                    middle = left + ((searchNum - array[left]) * (right - left)) / (array[right] - array[left]);

                    if (array[middle] == searchNum)
                    {
                        searchNumIndex = Convert.ToString(middle);
                        break;
                    }
                    else if (array[middle] > searchNum)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                if (array[left] == searchNum)
                    searchNumIndex = Convert.ToString(left);
                if (array[right] == searchNum)
                    searchNumIndex = Convert.ToString(right);

                return searchNumIndex;
        }

        static string GallopSearch(int[] array, int searchNum, string searchNumIndex)
        {
                for(int i = 1; i < array.Length; )
                {
                    if(array[0] == searchNum)
                    {
                        return searchNumIndex = "0";
                    }
                    if(array[i] == searchNum)
                    {
                        return searchNumIndex = Convert.ToString(i);
                    }
                    else if(array[i] > searchNum)
                    {
                        return BinarySearch(array, searchNum, searchNumIndex, i, i / 2);
                    }
                    if(i*2 >= array.Length)
                    {
                        i = array.Length - 1;
                    }
                    else i*=2;
                }
                return searchNumIndex;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int[] numArray = new int[10];
                int arrayLength = 0;
                int newElem = 0;
                int sortType = 1;
                int searchType = 1;
                int arrayType = 1;
                int searchNumber = 0;
                string searchNumberIndex = "There is no such number in the array!";
                bool isSorted = false;

                Console.WriteLine("\n1.Sorts with animations.\n2.Sorts without animation.\n3.Exit");
                try
                {
                    int mainMenuValue = Convert.ToInt32(Console.ReadLine());
                    if (mainMenuValue > 0)
                    {
                        if (mainMenuValue == 1)
                        {
                            ArrayCreating(ref numArray, ref arrayLength, ref newElem, ref arrayType, ref searchNumber, ref searchNumberIndex);
                            //Sortings
                            while (true)
                            {
                                if (!isSorted)
                                {
                                    Console.WriteLine("1.Linear sort\n2.Bubble sort\n3.insertion sort\n4.QuickSort");
                                    Console.Write("Which sort type do you wish to use: ");

                                    try
                                    {
                                        sortType = Convert.ToInt32(Console.ReadLine());
                                        if (sortType > 0)
                                        {
                                            switch (sortType)
                                            {
                                                case 1:
                                                    LinearSortAnimated(numArray);
                                                    isSorted = true;
                                                    break;
                                                case 2:
                                                    BubbleSortAnimated(numArray);
                                                    isSorted = true;
                                                    break;
                                                case 3:
                                                    InsertionSortAnimated(numArray);
                                                    isSorted = true;
                                                    break;
                                                case 4:
                                                    QuickSortAnimated(numArray, 0, numArray.Length - 1);
                                                    isSorted = true;
                                                    break;
                                                default:
                                                    LinearSortAnimated(numArray);
                                                    isSorted = true;
                                                    break;
                                            }
                                            Console.WriteLine("\nSorted arrray:\n" + string.Join(", ", numArray) + "\n");
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please, try again...");
                                    }
                                }
                            }
                            Searches(ref numArray, ref searchType, ref searchNumber, ref searchNumberIndex);
                        }
                        else if (mainMenuValue == 2)
                        {
                            ArrayCreating(ref numArray, ref arrayLength, ref newElem, ref arrayType, ref searchNumber, ref searchNumberIndex);
                            while (true)
                            {
                                if (!isSorted)
                                {
                                    Console.WriteLine("1.Linear sort\n2.Bubble sort\n3.insertion sort\n4.QuickSort");
                                    Console.Write("Which sort type do you wish to use: ");

                                    try
                                    {
                                        sortType = Convert.ToInt32(Console.ReadLine());
                                        if (sortType > 0)
                                        {
                                            switch (sortType)
                                            {
                                                case 1:
                                                    LinearSort(numArray);
                                                    isSorted = true;
                                                    break;
                                                case 2:
                                                    BubbleSort(numArray);
                                                    isSorted = true;
                                                    break;
                                                case 3:
                                                    InsertionSort(numArray);
                                                    isSorted = true;
                                                    break;
                                                case 4:
                                                    QuickSort(numArray, 0, numArray.Length - 1);
                                                    isSorted = true;
                                                    break;
                                                default:
                                                    LinearSort(numArray);
                                                    isSorted = true;
                                                    break;
                                            }
                                            Console.WriteLine("\nSorted arrray:\n" + string.Join(", ", numArray) + "\n");
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please, try again...");
                                    }
                                }
                            }
                            Searches(ref numArray, ref searchType, ref searchNumber, ref searchNumberIndex);
                        }
                        else if (mainMenuValue == 3)
                        {
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nWrong value!Try again...");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("\nWrong value!Try again...");
                }
            }

            Console.ReadKey();
        }
    }
}
