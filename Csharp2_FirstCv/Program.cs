using System;

namespace Csharp2_FirstCv
{
    delegate string Transform(string text);

    delegate int Operation(int a, int b);

    class Test
    {
        public static string ToUpper(string txt)
        {
            return txt.ToUpper();
        }

    }


    class Calculator
    {
        private int x;
        private int y;

        public void SetXY(int x,int y)
        {
            this.x = x;
            this.y = y;

        }

        public void Execute(Operation op)
        {
            int tmp = op(x, y);

            Console.WriteLine(tmp);
        }
       


    }
    class Program
    {
        

        static void Main(string[] args)
        {

            Transform a = Test.ToUpper;
            Console.WriteLine(a?.Invoke("jan"));

            Calculator c = new Calculator();
            c.SetXY(20, 5);
            c.Execute((a, b) => a * b);



        }
    }
}
