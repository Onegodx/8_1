// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
//Миньков Владимир 14 вариант базовый уровень 8_1
class Program
{
    static void Main(string[] args)
    {
        // открываем файл для чтения
        StreamReader reader = new StreamReader("films.txt");

        // создаем новый файл для записи
        StreamWriter writer = new StreamWriter("Кинолента.txt");

        // читаем файл построчно
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            // разбиваем строку на элементы по разделителю ";"
            string[] elements = line.Split(';');

            // проверяем, является ли режиссер Ежи Гофманом
            if (elements[1].Trim() + " " + elements[2].Trim() == "Гофман Ежи")
            {
                // выводим информацию о фильме в консоль и записываем ее в файл
                Console.WriteLine("{0}; {1} {2}; {3}; {4}; {5}; {6}; {7}",
                    elements[0], elements[1], elements[2], elements[3], elements[4], elements[5], elements[6], elements[7]);
                writer.WriteLine("{0}; {1} {2}; {3}; {4}; {5}; {6}; {7}",
                    elements[0], elements[1], elements[2], elements[3], elements[4], elements[5], elements[6], elements[7]);
            }
        }

        // закрываем файлы
        reader.Close();
        writer.Close();

        Console.WriteLine("Результаты сохранены в файл \"Кинолента.txt\"");
        Console.ReadKey();
    }
}
