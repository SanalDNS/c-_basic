namespace others
{

    public class justOthers
    {
        public static async Task runss()
        {
            Console.WriteLine("async code");
            await Task.Delay(5000);
            Console.WriteLine("async code done");

        }


//assembly=> it is the output of the project, it will be generated after the successful compailation.
//namespace ->is used to avoid naming conflicts, when the complex types are going to have same names.
//complex types  => they are of 5 types
//class is a complex data type, it is a blueprint of an object that encapsulate data and behaviours.

//syntax
//   AccessModifier Modifier Class Identifier{
//     member variable
//     member function
//     properties
//   }






//members (also known as a method) => they are 3 types
//1. Instance Member Functions (Methods) => Operate on instance data and require an object.
//2. Static Member Functions (Methods) => Belong to the class itself and do not need an object to be called.
//3. Abstract Methods => Defined in abstract classes and must be implemented by derived classes.


//object is the instance of class

//syntax for object creation

//className objectName =new ClassName();


    }
}