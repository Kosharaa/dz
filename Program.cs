using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 350;
            if (money >= 60)
            {
                Console.WriteLine("Живи кошерно у тебя хватило на Лефф ");
            }
            else if(money <= 59 & money >= 45)
            {
                Console.WriteLine("Извини брат, хватило на БАД");
            }
            else if (money <= 44 & money >= 30)
            {
                Console.WriteLine("По Стелле?");
            }
            else if (money <= 29 & money >= 20)
            {
                Console.WriteLine("ну черниговское на лавочке тоже норм");
            }
            else if(money <= 19 & money >= 7)
            {
                Console.WriteLine("Иди работай, у тебя еле на оболонь хватило");
            }


            double cost = 350;

            if (cost >= 0 & cost < 300)
            {
                Console.WriteLine("your diskont is 0%, total to pay " +  cost);
            }
            else if (cost >= 300 & cost < 400)
            {
                cost = cost - (cost * 0.05);
                Console.WriteLine("your diskont is 5%, total to pay " + cost);

            }


            Console.ReadKey();
         
        }
    }
}
