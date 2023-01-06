// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1
{
    class Prog2
    {
        public int num = 10;
        public string str = "C# Learning";
        public double db = 23.33;
        public bool bl = false;
        public char ch = 'a';
    }
    class Prog
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello You There");

            Class1 cls = new();
            cls.SetTutorial(9, "Heyyyy");


            Prog2 prog2 = new Prog2();
            Console.WriteLine(prog2.num);

            int number = 11;

            // If loop
            if (number > 12)
            {
                Console.WriteLine("Greater");
            }
            else
            {
                Console.WriteLine("Smaller");
            }

            // Switch
            switch (number)
            {
                case 10:
                    Console.WriteLine("10 value is there");
                    break;
                case 11:
                    Console.WriteLine("11 value is there");
                    break;
            }

            // 
            int[] arr = new int[4];
            arr[0] = 3;
            arr[1] = 4;
            arr[2] = 6;

            Console.WriteLine(string.Join(", ", arr));

        }
    }
}
