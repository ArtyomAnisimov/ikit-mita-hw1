using System;

namespace BuyCat
{
    public class UIFunctions
    {
        public byte Item { get; set; }

        public void ChoiseItem()
        {

            do
            {

                try
                {
                    Console.Write("\nВыберите пункт меню: ");
                    Item = Byte.Parse(Console.ReadLine());
                    return;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + "\nПопробуйте еще раз!");
                }
            } while (true);
        }
    }
}
