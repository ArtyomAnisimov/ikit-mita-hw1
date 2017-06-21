using Model;
using System;

namespace BuyCat
{
    public class BuyCat
    {
        Cat cat = new Cat();
        public  BuyCat()
        {
            cat.CatAge();
        }


        public void CatMenu()
        {
            Console.WriteLine("Кошка 2.0");
            Console.WriteLine("\nЧто с ней делать?");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Покормить;");
            Console.WriteLine("2. Наказать; ");
            Console.WriteLine("3. Задать имя; ");
            Console.WriteLine("4. Узнать состояние кошки; ");
            Console.WriteLine("0. Выход; ");
            Console.WriteLine("---------------");

            Cat cat = new Cat();
            UIFunctions uiFunc = new UIFunctions();
            uiFunc.ChoiseItem();
            

            do
            {
                switch (uiFunc.Item)
                {
                    //Покормить
                    case 1:
                        cat.Feed();
                        Console.WriteLine(cat);
                        uiFunc.ChoiseItem();
                        break;
                    //Наказать
                    case 2:
                        cat.Punish();
                        Console.WriteLine(cat.Color);
                        uiFunc.ChoiseItem();
                        break;
                    //Назначить имя кошке
                    case 3:
                        //Ввод имени только один раз
                        if (cat.Name == null)
                        {
                            Console.Write("Введите имя кошки: ");
                            cat.Name = Console.ReadLine();
                            uiFunc.ChoiseItem();
                        }
                        else
                        {

                            Console.Write($"У кошки уже есть имя: {cat.Name}");
                            uiFunc.ChoiseItem();
                        }
                        break;
                    case 4:
                        Console.WriteLine(cat);
                        uiFunc.ChoiseItem();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет");
                        uiFunc.ChoiseItem();
                        break;
                }
            } while (uiFunc.Item != 0);
        }
    }
}
