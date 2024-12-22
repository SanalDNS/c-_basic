using System;
namespace SecondFile
{


    public class SecondFileClass
    {


        public static void functions()
        {
            string say = "hello";
            string name = "san";
            Console.WriteLine(say + " " + name);
        }


        public void funs()
        {
            Console.WriteLine("DONE SECOND FUNCTION");
        }


        public static bool Pali( string par)
        {


           for (int i = 0; i < par.Length / 2; i++)
            {
                if (par[i] != par[par.Length - 1 - i])
                {
                    return false;
                }
              
            }
              return true;
        }
    }
}