using System.Diagnostics.Metrics;
using System.IO;

namespace assigment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            #region q1
            //Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.

            // interface is userdefine data type that its like a promise each segnitcher on it must implement it  and its like a contaract between the class and the interface;
            //because we want to depend on abstraction, not implementation.
            //multiple implementations,loose coupling,better testability
            #endregion
            #region q2
            //            a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            // we need another great function and  the class translator has to implement both interfaces but it cant implement both great, it has to choose one of them and implement it
            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            //explicit interface implementation
            //c) After applying your fix, can you call Greet() directly on a Translator object (e.g.translator.Greet())? Why or why not? How do you call each version?
            // no because the method is implemented explicitly so we have to cast the obj , 

            #endregion

            #endregion
        }
    }
}
