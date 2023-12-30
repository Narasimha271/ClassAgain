using System;

namespace ClassAgain
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Program Obj = new Program(); // ClassName Object_Name = new ClassName();
            Kittu obj2 = new Kittu();


            Console.WriteLine("Hello World!");
            Console.WriteLine("Test Theory");
            Obj.test();
            obj2.kiran();
            obj2.add();
            obj2.sub();
        }

        public void test() // Scope_of_the_Method  void   Method_Name() { } >> syntax of Method
        {
            Console.WriteLine("Theory");
        }
    }

    public class Kittu 
    {
        int Cat = 2;
        int bat = 1;

        string a = "test";
        string Mat2 = "test12345";
        string mat1 = "l";

        char c = 'a';

        bool ThisClass = true;
        bool YesterdayClass = false;


        public void add() 
        {
            int D = Cat + bat;
            Console.WriteLine(D);
            Console.WriteLine(Cat + bat);
        }

        public void sub() 
        {
            Console.WriteLine(Cat - bat);
        }


        public void kiran() 
        {
            Console.WriteLine("test12345");
            Console.WriteLine(Mat2);
        }
    }



    // C# has different kinds of Data types >> string, int, Char, boolean
}
