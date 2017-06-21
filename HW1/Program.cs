using BuyCat;
using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Покупка кошки
            string _continue;
            do
            {

                Console.Write("Желаете купить кошку?" + "\ny / n ");
                _continue = Console.ReadLine();
                switch (_continue)
                {
                    case "y":
                        BuyCat.BuyCat catMenu = new BuyCat.BuyCat();
                        //catMenu.BuyCat();
                        catMenu.CatMenu();
                        Console.ReadLine();
                        break;
                    case "n":
                        Console.WriteLine("Спасибо за визит!");
                        Console.ReadLine();
                        return;
                        
                        
                    default:
                        Console.WriteLine("Неверный ввод, попытайтесь еще раз.");
                        break;
                }
            } while (_continue != "n" || _continue != "y");
        }
    }
}
