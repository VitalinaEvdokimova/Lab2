using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace laba2
{
    class Program
    {
        static void Main(string[] args) {
            // Инициализируем классы
            Mammal mammal = new Mammal(4, "Лев", 100, "Африка", 180, "Желто-серый", new Point(0, 0));
            Bird bird = new Bird(50, "Орел", 150, "Европа", 8, "Желто-коричневый", new Point(0,0));
            Fish fish = new Fish("Пресная", "Карась", "Европа", 500, "Коричневый");
            // Выводим информацию 
            Console.WriteLine(mammal.Info());
            Console.WriteLine(bird.Info());
            Console.WriteLine(fish.Info());

            // Инициализируем классы "Дикие животные и домашние"
            Pet pet = new Pet("Ласка", "Иванов В.В", 4, "Кошачьи", 60, "Дом/улица", 3, "Белый", new Point(0, 0));
            Wild wild = new Wild(4, "Кошачьи", 30, "Леса", 3, "Черный", new Point(0, 0));
            // Выводим информацию 
            Console.WriteLine(pet.Info());
            Console.WriteLine(wild.Info());


            // Выполним методы ходить
            Console.WriteLine("\nВыполним метод \"ходить\" класса Mannal");
            mammal.Walk();
            Console.WriteLine("\nВыполним метод \"ходить\" в соответствии с заданным вектором класса Mannal");
            Point[] p = new Point[4];
            p[0] = new Point(0, 0); p[1] = new Point(25, 25); p[2] = new Point(30, 30); p[3] = new Point(50, 55);
            mammal.Walk(p);
            Console.WriteLine("\nВыполним метод \"летать\" класса Bird");
            bird.Fly();
            Console.WriteLine("\nВыполним метод \"летать\" в соответствии с заданным вектором класса Bird");
            Point[] p1 = new Point[3];
            p1[0] = new Point(0, 0); p1[1] = new Point(70, 75); p1[2] = new Point(125, 100);
            bird.Fly(p1);

            Console.ReadKey();
        }
    }
}
