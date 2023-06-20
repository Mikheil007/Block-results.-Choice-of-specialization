using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Вводим первоначальный массив строк
        string[] initialArray = new string[] { "abc", "de", "fghij", "kl", "mnopq", "r", "st", "uvwxyz" };

        // Рассчитываем размер нового массива
        int newArraySize = 0;
        foreach (string s in initialArray)
        {
            if (s.Length <= 3)
            {
                newArraySize++;
            }
        }

        // Создаем и заполняем новый массив
        string[] newArray = new string[newArraySize];
        int j = 0;
        foreach (string s in initialArray)
        {
            if (s.Length <= 3)
            {
                newArray[j] = s;
                j++;
            }
        }

        // Выводим новый массив
        foreach (string s in newArray)
        {
            Console.WriteLine(s);
        }
    }
}
