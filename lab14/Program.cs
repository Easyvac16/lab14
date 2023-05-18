namespace lab14
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What task you want to run:1 - work with file, 2 - random numbers in file:");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:cs1.task_1();
                    break;
                case 2:cs2.task_2();
                    break;
            }

            
            
        }
    }
}