using System;
using System.Collections.Generic;
using System.Numerics;

namespace Javascript_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region JS-1
            //1. sum adlı funksiya yazın.
            //Funksiya ədədlərdən ibarət bir array i parametr kimi qəbul etməli
            //və array ın bütün elementlərinin cəmini qaytarmalıdır:

            ////Get the array size
            //Console.WriteLine("Please provide the array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] input_array = new int[size];
            //for(int i = 0; i < input_array.Length; i++)
            //{
            //    Console.WriteLine($"Please provide the element number {i}");
            //    input_array[i] = int.Parse(Console.ReadLine());
            //}
            ////Print out the result
            //Console.WriteLine($"Sum of the array elements is {sum_of_the_array(input_array)}");
            ////Function to calculate the sum
            //static int sum_of_the_array(int[] array)
            //{
            //    int sum = 0;
            //    foreach(int n in array)
            //    {
            //        sum += n;
            //    }
            //    return sum;
            //}
            #endregion
            #region JS-2
            //2. random adlı funksiya yazın.
            //Funksiya lower və upper adlı iki parametr qəbul etməli
            //və həmin iki ədəd arasında (hər ikisi daxil olmlaqla)
            //ixtiyari bir natural ədəd qaytarmalıdır:

            //Console.Write("Enter an integer: ");
            //int startNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the next integer: ");
            //int endNumber = int.Parse(Console.ReadLine());
            ////Print the result
            //Console.WriteLine($"Generated random number is {RandomGeneration(startNumber, endNumber)}");

            //static int RandomGeneration(int a, int b)
            //{
            //    Random rand = new Random();
            //    int randomNumber = rand.Next(a, b);
            //    return randomNumber;
            //}
            #endregion
            #region Js-3
            //3. arithmeticMean adlı funksiya yazın.
            //Funksiyanız ədədlərdən ibarət bir array i
            //parametr kimi qəbul etməli və array in
            //elementlərinin ədədi ortasını qaytarmalıdır:

            ////Array length
            //Int16 array_length = 0;
            ////Ask for the array length
            //Console.Write("Length of the array: ");
            //if(Int16.TryParse(Console.ReadLine(), out Int16 length))
            //{
            //    array_length = length;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!!!");
            //}
            ////Create the array
            //int[] numberArray = new int[array_length];
            ////Get the array elements
            //for(int i = 0; i < array_length; i++)
            //{
            //    //Ask for each  element
            //    Console.Write($"Number {i + 1} element of the array: ");
            //    if(int.TryParse(Console.ReadLine(), out int element))
            //    {
            //        //Store the element
            //        numberArray[i] = element;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input!!!");
            //    }
            //}
            ////Print the result
            //Console.WriteLine($"Arithmetic mean of the array elements is: {arithmetcMean(numberArray)}");
            ////Function to calculate the arithmetic mean
            //float arithmetcMean(int[] array)
            //{
            //    if(array.Length == 0)
            //    {
            //        return 0;
            //    }
            //    int sum = 0;
            //    //Loop to calculate the sum of all of the elements of the array
            //    for(int i = 0; i < array.Length; i++)
            //    {
            //        sum += array[i];
            //    }
            //    //Calculate the arithmetic mean
            //    return (float) sum / array.Length;
            //}
            #endregion
            #region JS-4
            //4. geometricMean adlı funksiya yazın.
            //Funksiyanız ədədlərdən ibarət bir array i p
            //arametr kimi qəbul etməli və
            //array in elementlərinin həndəsi ortasını qaytarmalıdır:


            ////Create the array length
            //Int16 array_length = 0;
            ////Get the array length
            //Console.Write("Input the length: ");
            //if(Int16.TryParse(Console.ReadLine(), out Int16 length))
            //{
            //    array_length = length;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!!!");
            //    return;
            //}
            ////Create the array
            //int [] number_array = new int[array_length];
            ////Get the array elements
            //for(int i = 0; i < array_length; i++)
            //{
            //    //Ask for the element
            //    Console.Write($"Input the Element {i + 1}: ");
            //    if(int.TryParse(Console.ReadLine(), out int element))
            //    {
            //        number_array[i] = element;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid element input!!!");
            //        return;
            //    }
            //}
            ////Print the result
            //Console.Write($"Geometric mean of the array is: {geometricMean(number_array)}");
            ////Create the function
            //double geometricMean(int[] array)
            //{
            //    //Variable to store the product of the integers
            //    int product = 1;
            //    //Loop to find the product of all integers in the array
            //    for(int i = 0; i < array.Length; i++)
            //    {
            //        product *= array[i];
            //    }
            //    float power = 1 / (float) array.Length;
            //    return Math.Pow(product, power);
            //}
            #endregion
            #region JS-5
            //5. euclideanDistance adlı funksiya yazın.
            //Funksiya iki vektoru parametr kimi qəbul etməli
            //və onlar arasındakı Evklid məsafəsini qaytarmalıdır.
            //Vektor dedikdə içərisində iki element olan array dən söhbət gedir.
            //Arrayin birinci elementi x ikinci elementi isə y i bildirir: [x, y]:

            ////Create vectors
            //Vector[] vectors = new Vector[2];
            ////Loop to assign both values of the vectors
            //for (int i = 0; i < 2; i++)
            //{
            //    vectors[i] = new Vector();
            //    Console.Write($"Enter X of {i + 1} st/nd vector: ");
            //    vectors[i].x = Convert.ToDouble(Console.ReadLine());
            //    Console.Write($"Enter Y of the {i + 1} st/nd vector: ");
            //    vectors[i].y = Convert.ToDouble(Console.ReadLine());
            //}
            ////Output the result
            //Console.WriteLine($"Euclidean distance equals to: {EuclideanDistance(vectors)}");
            ////Function to calculate the Euclidean Distance
            //float EuclideanDistance(Vector[] vectors)
            //{
            //    double differenceX = 0;
            //    double differenceY = 0;
            //    //Store the differences of each coordinates
            //    if (vectors[1].x > vectors[0].x)
            //    { differenceX = vectors[1].x - vectors[0].x; }
            //    else { differenceX = vectors[0].x - vectors[1].x; }
            //    if (vectors[1].y > vectors[0].y)
            //    { differenceY = vectors[1].y - vectors[0].y; }
            //    else { differenceY = vectors[0].y - vectors[1].y; }
            //    //Sum their squares
            //    double sum_of_differences = Math.Pow(differenceX, 2) + Math.Pow(differenceY, 2);
            //    //Return the result
            //    return (float)Math.Sqrt(sum_of_differences);
            //}
            #endregion
            #region JS-6
            //6. pickOne adlı funksiya yazın.
            //Funksiya bir ədəd array qəbul etməli
            //və içərisindən ixtiyari bir elementi qaytarmalıdır:

            ////Get the array length
            //Console.Write("How many elements will be in the array: ");
            //int arrayLength = Convert.ToInt16(Console.ReadLine());
            ////Create the array
            //string[] nameArray = new string[arrayLength];
            ////Get the elements
            //for(int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write($"{i + 1}. ");
            //    nameArray[i] = Console.ReadLine();
            //}
            ////Output
            //Console.WriteLine(pickOne(nameArray));
            ////Function to pick a random element
            //string pickOne(string[] array)
            //{
            //    Random random = new Random();
            //    int random_index = random.Next(array.Length);
            //    return array[random_index];
            //}

            //Resources
            //https://www.codegrepper.com/code-examples/csharp/select+random+element+from+array+c%23
            #endregion
            #region JS-7
            //7. includes adlı funksiya yazın.
            //Funksiya bir ədəd array
            //və bir ədəd axtarış üçün dəyər qəbul etməlidir.
            //Əgər həmin dəyər array in içərisində mövcuddursa,
            //true əks halda false qaytarmalıdır:

            ////Get array length
            //Console.Write("How many elements will be there: ");
            //int total_number_of_elements = Convert.ToInt16(Console.ReadLine());
            ////Create the array
            //int[] numberArray = new int[total_number_of_elements];
            ////Get each element
            //for(int i = 0; i < total_number_of_elements; i++)
            //{
            //    Console.Write($"{i + 1}. ");
            //    numberArray[i] = int.Parse(Console.ReadLine());
            //}
            ////Get the target value
            //Console.Write("Number to search for: ");
            //int numberToSearch = int.Parse(Console.ReadLine());
            ////Output result
            //if(Includes(numberArray, numberToSearch))
            //{
            //    Console.Write("Target found");
            //}
            //else
            //    Console.WriteLine("Target NOT found");
            ////Search function
            //bool Includes(int[] array, int target)
            //{
            //    bool find = false;
            //    //Loop to find the target
            //    for(int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] == target)
            //        {
            //            find = true;
            //            break;
            //        }
            //    }
            //    return find;
            //}
            #endregion
            #region JS-8
            ////8. unique adlı funksiya yazın.
            ////Funksiya bir ədəd array i parametr kim qəbul etməli
            ////içərisində təkrar elementlər olmayan yeni bir array qaytarmalıdır:

            ////Get the input type
            //Console.WriteLine("What kind of data do you want to check: ");
            //Console.WriteLine("1. Characters");
            //Console.WriteLine("2. Numbers");
            //byte choice = Convert.ToByte(Console.ReadLine());


            ////Get array size
            //byte array_size = 0;
            //Console.Write("Enter the length of the array: ");
            //string size_input = Console.ReadLine();
            ////Set Array size
            //if (byte.TryParse(size_input, out byte length))
            //{
            //    array_size = length;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!!!");
            //    return;
            //}

            ////Output the result
            //switch (choice)
            //{
            //    case 1:
            //        char[] characters = new char[array_size];
            //        UniqueCharacters(characters);
            //        break;
            //    case 2:
            //        short[] numbers = new short[array_size];
            //        UniqueNumbers(numbers);
            //        break;
            //}

            ////Function to print non-repeated chars
            //void UniqueCharacters(char[] char_array)
            //{
            //    //Get array elements
            //    for (byte i = 0; i < char_array.Length; i++)
            //    {
            //        Console.Write($"{i + 1}: ");
            //        if (char.TryParse(Console.ReadLine(), out char element))
            //        {
            //            char_array[i] = element;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input!");
            //        }
            //    }
            //    //A new list to store non-repeated elements
            //    List<char> unique_chars = new List<char>();
            //    //Loop to find non-repeated elements
            //    for(int i = 0; i < char_array.Length; i++)
            //    {
            //        //Store match
            //        bool match = false;
            //        for(int j = i + 1; j < char_array.Length; j++)
            //        {
            //            //Check if the current element matches with any of the rest
            //            if (char_array[i] == char_array[j])
            //            {
            //                match = true;
            //                break;
            //            }
            //        }
            //        if(match == false)
            //        {
            //            unique_chars.Add(char_array[i]);
            //        }
            //    }
            //    foreach(char c in unique_chars)
            //    {
            //        Console.Write($"{c}, ");
            //    }
            //}
            ////Function to print non-repeated numbers
            //void UniqueNumbers(short[] number_array)
            //{
            //    //Get elements
            //    for(byte i = 0; i < number_array.Length; i++)
            //    {
            //        Console.Write($"{i + 1}th number: ");
            //        if(short.TryParse(Console.ReadLine(), out short element))
            //        {
            //            number_array[i] = element;
            //        }
            //        else
            //            Console.WriteLine("Invalid input!!!");
            //    }
            //    //A new list to store non-repeated elements
            //    List<short> unique_numbers = new List<short>();
            //    //Loop to find non-repeated elements
            //    for (int i = 0; i < number_array.Length; i++)
            //    {
            //        //Store match
            //        bool match = false;
            //        for (int j = i + 1; j < number_array.Length; j++)
            //        {
            //            //Check if the current element matches with any of the rest
            //            if (number_array[i] == number_array[j])
            //            {
            //                match = true;
            //                break;
            //            }
            //        }
            //        if (match == false)
            //        {
            //            unique_numbers.Add(number_array[i]);
            //        }
            //    }
            //    foreach (short s in unique_numbers)
            //    {
            //        Console.Write($"{s}, ");
            //    }
            //}
            #endregion
            #region JS-9
            //intersection adlı funksiya yazın.
            //Funksiya iki array i parametr kimi
            //qəbul etməli və onların kəsişməsini
            //yeni array olaraq qaytarmalıdır:

            ////Array solution
            ////Inititalize two arrays
            //byte[] firstArray = new byte[4];
            //byte[] secondArray = new byte[7];
            ////Get firstarray elements
            //for(int i = 0; i < firstArray.Length; i++)
            //{
            //    Console.Write($"Inout element {i + 1} of the first array: ");
            //    firstArray[i] = byte.Parse(Console.ReadLine());
            //}
            ////Get secondarray elements
            //for (int i = 0; i < secondArray.Length; i++)
            //{
            //    Console.Write($"Inout element {i + 1} of the seccond array: ");
            //    secondArray[i] = byte.Parse(Console.ReadLine());
            //}

            ////Print the result
            //Console.Write("Common elements are: ");
            //Console.Write("[");
            //foreach(Byte b in Intersection(firstArray, secondArray))
            //{
            //    Console.Write($"{b}, ");
            //}
            //Console.Write("]");
            ////Find common elements
            //static List<byte> Intersection(byte[] firstArray, byte[] secondArray)
            //{
            //    List<byte> commonElements = new List<byte>();
            //    for(byte i = 0; i < firstArray.Length; i++)
            //    {
            //        for(int j = 0; j < secondArray.Length; j++)
            //        {
            //            if (firstArray[i] == secondArray[j])
            //            {
            //                commonElements.Add(firstArray[i]);
            //            }
            //        }
            //    }
            //    return commonElements;
            //}
            #endregion
            #region JS-10
            ////Get the array elements
            //Console.Write("Row size: ");
            //byte row = Convert.ToByte(Console.ReadLine());
            //Console.Write("Column size: ");
            //byte column = Convert.ToByte(Console.ReadLine());
            ////Initialize the array
            //short[,] numbers = new short[row, column];
            ////Loop to get each element
            //for(byte i = 0; i < row; i++)
            //{
            //    for(byte j = 0; j < column; j++)
            //    {
            //        Console.Write("Input an element: ");
            //        numbers[i, j] = byte.Parse(Console.ReadLine());
            //    }
            //}
            //Flat2D(numbers);
            ////Modify the array
            //static void Flat2D(short[,] twoDArray)
            //{
            //    //New array and counter for its indexes
            //    short index = 0;
            //    short[] oneDimension = new short[twoDArray.Length];
            //    //Loop to copy all remaining elements to the first dimensioj
            //    for(byte i = 0; i < twoDArray.GetLength(0); i++)
            //    {
            //        for(byte j = 0; j < twoDArray.GetLength(1); j++)
            //        {
            //            oneDimension[index] = twoDArray[i, j];
            //            index++;
            //        }
            //    }
            //    //Output
            //    Console.WriteLine();
            //    foreach (short s in oneDimension)
            //    {
            //        Console.Write($"{s} ");
            //    }
            //}
            #endregion
            #region JS-11
            ////Initialize sizes
            //byte firstLength = 0;
            //byte secondLength = 0;
            ////Get array sizes
            //do
            //{
            //    Console.Write("First array size: ");
            //    if (byte.TryParse(Console.ReadLine(), out byte length1))
            //        firstLength = length1;
            //    else
            //        Console.WriteLine("Invalid length!!!");
            //    Console.Write("Second array size: ");
            //    if (byte.TryParse(Console.ReadLine(), out byte length2))
            //        secondLength = length2;
            //    else
            //        Console.WriteLine("Invalid length!!!");
            //} while (firstLength == default || secondLength == default);
            ////Initialize arrays
            //byte[] firstArray = new byte[firstLength];
            //byte[] secondArray = new byte[secondLength];
            ////Get first array elements
            //for(int i = 0; i < firstLength; i++)
            //{
            //    Console.Write($"Element {i + 1} of the first array: ");
            //    if (byte.TryParse(Console.ReadLine(), out byte element))
            //        firstArray[i] = element;
            //    else
            //        Console.WriteLine("Invalid input!!!");
            //}
            ////Get second array elements
            //for(int j = 0; j < secondLength; j++)
            //{
            //    Console.Write($"Element {j + 1} of the second array: ");
            //    if (byte.TryParse(Console.ReadLine(), out byte element))
            //        secondArray[j] = element;
            //    else
            //        Console.WriteLine("Inavlid input!!!");
            //}
            ////Output the result
            //Console.Write("[");
            //foreach(byte b in ArrayCombine(firstArray, secondArray))
            //{
            //    Console.Write(b + " ");
            //}
            //Console.Write("]");
            ////Method to Combine Arrays
            //byte[] ArrayCombine(byte[] firstArray, byte[] secondArray)
            //{
            //    //A new array to store combined elements
            //    byte[] combinedArray = new byte[firstArray.Length + secondArray.Length];
            //    //Loop to copy the first array
            //    for(int i = 0; i < firstArray.Length; i++)
            //    {
            //        combinedArray[i] = firstArray[i];
            //    }
            //    //Loop to copy the second array

            //    for(int j = firstArray.Length, i = 0; j < combinedArray.Length; j++, i++)
            //    {
            //        combinedArray[j] = secondArray[i];
            //    }
            //    return combinedArray;
            //}
            #endregion
            #region Js-12
            //reverse adlı funksiya yazın.
            //Funksiya bir ədəd array i
            //parametr kimi qəbul etməli və
            //onun tərsini yeni bir array kimi qaytarmalıdır:

            //Ask for the length
            //Console.Write("Array Length: ");
            //byte length = byte.Parse(Console.ReadLine());
            ////Initialize the array and ask for the elements
            //int[] integerArray = new int[length];
            //for(int i = 0; i < length; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    integerArray[i] = int.Parse(Console.ReadLine());
            //}
            ////Output the result
            //foreach(int i in Reverse(integerArray))
            //{
            //    Console.Write($"{i} ");
            //}
            ////Method to reverse
            //static int[] Reverse(int[] integerArray)
            //{
            //    //Define a new array
            //    int[] reverseArray = new int[integerArray.Length];
            //    //Loop to copy elements in reverse order
            //    for(int i = 0; i < integerArray.Length; i++)
            //    {
            //        reverseArray[i] = integerArray[(integerArray.Length - 1) - i];
            //    }
            //    return reverseArray;
            //}
            #endregion
            #region JS-13
            //map adlı funksiya yazın.
            //Funksiya bir ədəd array i və
            //bir ədəd funksiyanı parametr kimi qəbul etməli,
            //funksiyanın nəticəsini arrayın hər bir elementinə
            //tətbiq etməli və yeni bir array qaytarmalıdır:

            //string[] numbers = { "Six", "Seven", "Nine" };
            //Func<string, string> multiply = (a => a += "ty");

            //foreach(string s in Map(numbers,multiply))
            //{
            //    Console.WriteLine(s);   
            //}

            ////Applying method to an array
            //string[] Map(string[] numbers, Func<string, string> multiply)
            //{
            //    for(int i = 0; i < numbers.Length; i++)
            //    {
            //        numbers[i] = multiply(numbers[i]);
            //    }
            //    return numbers;
            //}
            #endregion
            #region Js-14
            //filter adlı funksiya yazın. Funksiya bir array i və bir funksiyanı
            //parametr kimi qəbul etməli və geriyə yeni bir array qaytarmalıdır.
            //Verilmiş callback funksiyası arrayin hər bir elementini yoxlamalı
            //və onun true qaytardığı bütün elementlər yeni arrayə daxil edilməlidir:

            ////Define an array of ints
            //int[] integers = { 4, 7, 9, 12, 16, 20 };
            ////Define a function
            //Func<int, bool> EvenNumberCheck = (x => x % 2 == 0);
            ////Output the result
            //foreach(var element in Filter(integers, EvenNumberCheck))
            //{
            //    Console.WriteLine(element);
            //}
            ////Filtering method
            //static List<int> Filter(int[] integers, Func<int, bool> EvenNumberCheck)
            //{
            //    List<int> evenIntegers = new List<int>();
            //    foreach(int i in integers)
            //    {
            //        if(EvenNumberCheck(i))
            //        {
            //            evenIntegers.Add(i);
            //        }
            //    }
            //    return evenIntegers;
            //}
            #endregion
            #region JS-15
            //find adlı funksiya yazın. Funksiya bir ədəd array i
            //və bir funksiyanı parametr kimi qəbul etməlidir.
            //Verilmiş callback funksiyası arrayin hər bir elementini
            //yoxlamalı və onun true qaytardığı ilk element find funksiyasını cavabı olmalıdır:

            //Define an list
            //List<byte> bytes = new List<byte>()
            //{
            //    5, 14, 27, 31, 64, 128
            //};
            ////Define a func
            //Func<byte, bool> powerFinder = (b => Math.Log2(b) > 5);
            ////Display the output
            //Console.WriteLine(Find(bytes, powerFinder));
            //static byte Find(List<byte> byteArray, Func<byte,bool> validator)
            //{
            //    foreach(byte b in byteArray)
            //    {
            //        if (validator(b))
            //            return b;
            //    }
            //    return default;
            //}
            #endregion
            #region JS-16
            // some adlı funksiya yazın. Funksiya bir ədəd array i
            // və bir funksiyanı parametr kimi qəbul etməli və
            // geriyə Boolean tipli dəyər qaytarmalıdır.
            // Verilmiş callback funksiyası arrayin hər bir elementini yoxlamalı
            // və əgər ən azı bir element belə true nəticəsi versə,
            // some funksiyasının cavabı true olmalıdır.
            // Bütün digər hallarda some funksiyası false qaytarmalıdır:

            //Intitalize an array
            int[] integers = new int[] { 5, 11, 14, 22, 46, 59 };
            //Initialize a function (predicate previously)
            Func<int, bool> function = (i => i % 5 == 0);
            //Output the result
            Console.WriteLine(Some(integers, function));
            //Function to check each element of an array
            bool Some(int[] integers, Func<int, bool> function)
            {
                //Loop to check each element
                foreach(int i in integers)
                {
                    if (function(i))
                        return true;
                }
                return false;
            }
            #endregion
            #region JS-18
            
            #endregion
        }
    }
    //class Vector
    //{
    //    //Vector parameters
    //    public double x;
    //    public double y;
    //}
}
