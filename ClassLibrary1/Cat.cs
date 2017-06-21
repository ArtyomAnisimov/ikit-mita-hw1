using System;

namespace Model
{
    public class Cat
    {
        private string _name;
        //Один раз задаваемое имя
        public string Name
        {
            get { return _name; }
            set
            { _name = value; }
        }
        //Сделать поле только для чтения
        public byte Age { get; private set; }
        private sbyte _health = 0;
        //вычисляемое поле: красный < 5, желтый = 5, зеленый > 5 
        public string Color
        {
            get
            {
                if (_health < 5)
                {
                    if (_health > 0) { return "Надо покормить еще, пока что цвет: Красный"; }
                    return "Срочно покормите, цвет: Красный";

                }
                if (_health == 5) return "Желательно покормить, цвет: Желтый";
                return "Кошка в порядке, цвет: Зеленый";
            }
        }

        //Покормить
        public void Feed()
        { _health += 1; }
        //Наказать
        public void Punish()
        { _health -= 1; }
        //Купить кошку
        public void CatAge()
        {
            do
            {
                if (Age == 0)
                {

                    Console.Write("Перед покупкой\nВведите возраст кошки: ");
                    try
                    {
                        Age = Byte.Parse(Console.ReadLine());
                        return;
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message + "\nПопробуйте еще раз!");
                    }
                }
                else { return; }
            } while (true);
            
        }

        public override string ToString()
        {
            return "Name: " + Name +
                   "\nColor: " + Color;
        }

    }
}
