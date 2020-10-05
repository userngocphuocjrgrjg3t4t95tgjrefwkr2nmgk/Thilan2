using System;
using System.Collections.Generic;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            int c;
            do
            {
                Console.WriteLine("______________________________________");
                Console.WriteLine("1. New Order: ");
                Console.WriteLine("2. Update Order: ");
                Console.WriteLine("3. Cancel Order: ");
                Console.WriteLine("4. Search: ");
                System.Console.WriteLine("5. Pay: ");
                System.Console.WriteLine("6. Show:");
                Console.WriteLine("7. Exit..: ");
                Console.WriteLine("______________________________________");
                Console.WriteLine("Nhap so de chon: ");
                int.TryParse(Console.ReadLine(), out c);
                switch (c)
                {
                    case 1:
                        coffee.NewOrder();
                        break;
                    case 2:
                        coffee.UpdaterOrder();
                        break;
                    case 3:
                        coffee.CancelOrder();
                        break;
                    case 4:
                        coffee.Search();
                        break;
                    case 5:
                        coffee.Pay();
                        break;
                    case 6:
                        coffee.Show();
                        break;
                    case 7: return;

                }
            } while (c != 7);
        }
    }
}




