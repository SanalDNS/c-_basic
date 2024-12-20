using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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
List<int> xyz = new List<int>{100,200,300,400,500};

//just simply call listName.Remove(value)  => it will remove the first occurence of that value.

xyz.Remove(200); // it will remove 200 from the list;
foreach(var rr in xyz){
    Console.WriteLine(rr); 
}

Console.WriteLine("========================");
//2. remove by index
 xyz.RemoveAt(0); // this will remove the element at 1st index

 foreach(var rr in xyz){
    Console.WriteLine(rr);
 }

 //3. TO remove all elemnts in the list

 xyz.Clear();
 Console.WriteLine("the length of list now:{0}",xyz.Count());
//---------------------------------------------------------

//4.  removing a range of elements

List<int> abc =new List<int>{1000,2000,3000,4000,5000,6000,7000};
abc.RemoveRange(0,2);  // it will remove element from index 0 to next 2 counts.
foreach(var ttt in abc){
    Console.WriteLine(ttt);
}

//an array or a List<T> in C# cannot hold multiple data types. In C#, arrays and lists are strongly typed collections, meaning that they can only store elements of a specific type.
//Mixing different types would violate the type safety of C#. This would lead to runtime errors or unexpected behavior because the compiler cannot guarantee type consistency within an array or list.



//.........................................................................................................
//there is a approach called Object Array => it can store different datatypes

object [] mixedArray= {10,"dubai",15.26, false};

foreach(var yyyy in mixedArray){
    Console.WriteLine(yyyy);
}

Console.WriteLine(mixedArray[1]);




//......................................................
