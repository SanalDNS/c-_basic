﻿using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System;
using SecondFile;  // this is name space
using others;
using carTesting;
using Learn;
using System.Reflection;
using System.ComponentModel;


namespace Twooo
{


    public class Car
    {
        public string brand;

        public void Start()
        {
            Console.WriteLine($"{brand} started");
        }
    }



    public class Ma
    {


        public static async Task Main(string[] args) // the main should contain async keyword to perform asyn operation
        {




            Car Xyza = new Car();
            Xyza.brand = "nsan";
            Xyza.Start();



            string[] arr = { "an", "sa", "sr" };


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("------------------");
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------------------");
            //iteration
            Array.ForEach(arr, x => Console.WriteLine(x));

            Console.WriteLine("----------------------");
            //iteration using ForEach
            Array.ForEach(arr, x => Console.WriteLine(x + " hello"));

            Console.WriteLine("----------------------");

            //the below is a dynamic array
            List<int> numb = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numb.Add(122);  // adding a  single number;
            foreach (var x in numb)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--------****--------****------");
            numb.AddRange(new int[] { 100, 200, 300 });

            foreach (var x in numb)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------****--------****------");

            //now we can convert it into an arry of fixed size

            int[] fixedSizeArray = numb.ToArray();

            foreach (var tt in fixedSizeArray)
            {
                Console.WriteLine(tt);
            }

            //list is not an array.  a list can be converted to array.
            //array is fixed length, list has no fixed length.

            //Console.WriteLine("FIRST:",{fixedSizeArray.Length});
            Console.WriteLine("FIRST: {0}", fixedSizeArray.Length);
            //In Console.WriteLine("FIRST: {0}", fixedSizeArray.Length);, {0} is replaced by the value fixedSizeArray.Length.


            Console.WriteLine("FIRST: {1}, fixed_array:{0}", numb.Count + 1, fixedSizeArray.Length);
            // the curly bracket value is usede to specift the order of data to be acessed

            //when we want to resize the array ,
            Array.Resize(ref fixedSizeArray, 20);

            Console.WriteLine(fixedSizeArray.Length);




            //-------------------------------------------------------------------------------------------
            // to convert array to list

            int[] a = { 1, 2, 3, 4, 5 };

            List<int> b = new List<int>(a);

            foreach (var s in b)
            {
                Console.WriteLine(s);
            }

            //or we can use  ToList methode

            List<int> c = a.ToList();
            foreach (var s in c)
            {
                Console.WriteLine(s);
            }

            //.............................................................................................................

            //to remove element from the array
            // there is no direct methode as the array is of fixed length, so we use itrative approach
            int[] g = { 10, 20, 30, 40, 50 };
            int toRemoveIndex = 2;

            //we have to declare a new array with predefined size.
            int[] newG = new int[g.Length - 1];
            // in the above we have createed an array of size one less than the parent array which is g.

            for (int i = 0, j = 0; i < g.Length; i++)
            {
                if (i != toRemoveIndex)
                {

                    // newG[i] = g[i]; // this wont work here as the size of two arrays are different, i will cause overwriting.

                    //in order to solve this issue we have declared a new variable j
                    newG[j++] = g[i];
                }
            }
            g = newG;


            foreach (var y in g)
            {
                Console.WriteLine(y);
            }

            //-----------------------------------------------------------------

            // the same thing can be achieved using List

            //1. remove element by value
            List<int> xyz = new List<int> { 100, 200, 300, 400, 500 };

            //just simply call listName.Remove(value)  => it will remove the first occurence of that value.

            xyz.Remove(200); // it will remove 200 from the list;
            foreach (var rr in xyz)
            {
                Console.WriteLine(rr);
            }

            Console.WriteLine("========================");
            //2. remove by index
            xyz.RemoveAt(0); // this will remove the element at 1st index

            foreach (var rr in xyz)
            {
                Console.WriteLine(rr);
            }

            //3. TO remove all elemnts in the list

            xyz.Clear();
            Console.WriteLine("the length of list now:{0}", xyz.Count);
            //---------------------------------------------------------

            //4.  removing a range of elements

            List<int> abc = new List<int> { 1000, 2000, 3000, 4000, 5000, 6000, 7000 };
            abc.RemoveRange(0, 2);  // it will remove element from index 0 to next 2 counts.
            foreach (var ttt in abc)
            {
                Console.WriteLine(ttt);
            }

            //an array or a List<T> in C# cannot hold multiple data types. In C#, arrays and lists are strongly typed collections, meaning that they can only store elements of a specific type.
            //Mixing different types would violate the type safety of C#. This would lead to runtime errors or unexpected behavior because the compiler cannot guarantee type consistency within an array or list.



            //.........................................................................................................
            //there is a approach called Object Array => it can store different datatypes

            object[] mixedArray = { 10, "dubai", 15.26, false };

            foreach (var yyyy in mixedArray)
            {
                Console.WriteLine(yyyy);
            }

            Console.WriteLine(mixedArray[1]);




            //......................................................

            //this the basic structure of the code writing
            // namespace projectName
            // {
            //     class Program{
            //         static void Main (string[] args){
            //             // the executable code has to be written inside main methode  here.
            //         }
            //     }

            // }

            //to read input from the console
            //Console.ReadLine();


            //datatypes
            string phrase = "helllo world this is c sharp";  //=> takes double quotes;
            char onlyone = 'g';// takes a single characte in single quotes;
                               // float, double, decimal.  => decimal is extremly precise.


            // working with strings
            //It is immutable, meaning that once a string object is created, its value cannot be changed. Instead of changing the value of a string, C# creates a new object with the desired value.

            Console.WriteLine(phrase.Length);

            // taking a substring from the string
            string SubStr = phrase.Substring(0, 6); // this will return first 6 characters
            string remaingSubStr = phrase.Substring(6);

            Console.WriteLine(SubStr);
            Console.WriteLine(remaingSubStr);

            string wordChange = remaingSubStr.Replace("is", "was"); // the first argument will be updated with the second argument.
            Console.WriteLine(wordChange);



            //the calling of a function in another .cs file.
            SecondFileClass.functions();


            string textss = "malayalam";

            bool ispali = SecondFileClass.Pali(textss);

            Console.WriteLine(ispali);

            await justOthers.runss();
            Console.WriteLine("after async");
            // 

            //objects in c#
            //In C#, object is the ultimate base type from which all types (both value types and reference types) derive. It is part of the System.Object class, and every type in C# either directly or indirectly inherits from it.




            Car Xyz = new Car();
            Xyz.brand = "nissan";
            Xyz.Start();


            testing.Calll();




            A.AA newvariableDeligation = A.Sayhello; // the function in class A is being assigned to a new variable,using the delegation reference AA in class A

            newvariableDeligation("helllllooo");



            //if i didnt use the static keywork on the methode this way of calling wont work.
            Console.WriteLine(Sum.Add(1, 2));
            //it will show an error like
            //An object reference is required for the non-static field, method, or property 'Sum.Add'


            //if i want to call the method without the static keyword, i would require to create a new instance of that class, then call the methode on that instance
            //Sum sumInstance = new Sum(); // Create an instance of the Sum class
            // Console.WriteLine(sumInstance.Add(1, 2)); //


            //string newGreat = new Greeets();
            //The compiler expects new Greeets() to return a string because you've declared the variable newGreat as a string. However, new Greeets() creates an object of type Greeets, not a string.

            Greeets newGreat = new Greeets();
            //custom datatype , newObjectName = new className;
            string ss = newGreat.Greet("sanal");
            Console.WriteLine(ss);

            const string wwww = "domain";  // no reassignment is possible
                                           // wwww="hellllo";
            Console.WriteLine(wwww);


            //PascalCase =>  HelloWorld

            //type conversion
            string sa = "123";
            int ssq = Convert.ToInt32(sa);
            Console.WriteLine(ssq);


double eeee = 10.0002;
double rrrr = eeee + 0.11;
Console.WriteLine(rrrr);




        }










    }
}