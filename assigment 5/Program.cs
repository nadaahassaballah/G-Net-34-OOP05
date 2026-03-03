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
        #region q3

        //Q3: Explain the difference between a shallow copy and a deep copy.When would you use each one? What is the risk of using a shallow copy when the object has reference - type fields ?
        // a shallow copy creates a new object but it copies the reference ,if we change the reference it will changed in another , a deecopy creates a new object and it copies the value of the reference so if we change the reference it will not change in another one
        // we use a shallow copy when we want to create a copy of an object but we dont care about the reference type fields ,deepcopy when we create a copy of an obj and we care about the refrence type field 
        
            #endregion

            #endregion
        }
    }
}
