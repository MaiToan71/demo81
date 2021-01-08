using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo81
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "";

            do
            {
                Console.WriteLine("===Nhap vao so bat ky de thuc hien chuc nang sau===");
                Console.WriteLine("1) chuc nang 1");
                Console.WriteLine("2) chuc nang 2");
                Console.WriteLine("3) chuc nang 3");
                Console.WriteLine("4) chuc nang 4 ");
                Console.WriteLine("5) chuc nang 5");
                Console.WriteLine("6) Thoat");
                input = Console.ReadLine();
                if (!"6".Equals(input))
                    processInput(input);
            }
            while (!"6".Equals(input));
            Console.WriteLine("Exit the program");
            Console.Write("Press any key to exit totally . . . ");
            Console.ReadKey(true);
        }
        public static void processInput(String input)
        {
            if ("1".Equals(input))
            {
                ChucNang1();
            }
            else if ("2".Equals(input))
            {
                ChucNang2();
            }
            else if ("3".Equals(input))
            {
                ChucNang3();
            }
            else if ("4".Equals(input))
            {
                ChucNang4();
            }
            else if ("5".Equals(input))
            {
                ChucNang5();
            }
            else
            {
                Console.WriteLine("Yeu cau nhap lai (1->6)");
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.WriteLine();
        }
        public static void ChucNang1()
        {
            Console.WriteLine("Chuc nang 1");
        }
        public static void ChucNang2()
        {
            Console.WriteLine("Chuc nang 2");
        }
        public static void ChucNang3()
        {
            Console.WriteLine("Chuc nang 3");
        }
        public static void ChucNang4()
        {
            Console.WriteLine("Chuc nang 4");
        }
        public static void ChucNang5()
        {
            Console.WriteLine("Chuc nang 5");
        }
    }
}
