using System.ComponentModel;

namespace Learn{
    //lambda expression
//to write function in line

//(parameters) => expression_or_statement_block


// Func<int,int,int>Add =(z,w)=>z+w;

// Console.log(Add(1,2));
public class Sum{
public static Func<int,int,int>Add=(z,w)=> z+w;
}


}