using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace zadanie
{
    // Абстрактный класс "Животные"
    abstract class Animals
    {
        protected string Area;      // Ареал обитания
        protected int Weight;       // Вес
        protected string Color;     // Окрас



        /// <summary>Конструктор</summary>
        /// <param name="Area">Ареал обитания</param>
        /// <param name="Weight">Вес</param>
        /// <param name="Color">Окрас</param>
        public Animals(string Area, int Weight, string Color) {
            this.Area = Area;
            this.Weight = Weight;
            this.Color = Color;
        }

        /// <summary> Абстрактный метод </summary>
        public abstract string Info();
    }

    // Класс млекопитающие
    class Mammal : Animals, IWalking
    {
        protected int Legs;           // Кол-во ног
        protected string Kind;        // Вид

        public Mammal(int Legs, string Kind, string Area, int Weight, string Color)
            : base(Area, Weight, Color) {
            this.Legs = Legs;
            this.Kind = Kind;
        }

        // Переопределям метод Info(), абстрактного класса Animals
        public override string Info() {
            return "\nКласс млекопитающие" + "\n\tВид - " + this.Kind + "\n\tКол-во ног - " + this.Legs +
                "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color;
        }

        // Ходить
        public string Walk() {
            return "\nХожу...";
        }
    }

    // Класс птицы
    class Bird : Animals, IFlaying
    {
        private string Kind;        // Вид
        private int Windspan;       // Размах крыла

        public Bird(int Windspan, string Kind, string Area, int Weight, string Color)
            : base(Area, Weight, Color) {
            this.Windspan = Windspan;
            this.Kind = Kind;
        }

        // Переопределям метод Info(), абстрактного класса Animals
        public override string Info() {
            return "\nКласс птицы" + "\n\tВид - " + this.Kind + "\n\tРазмах крыла - " + this.Windspan
                + "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color;
        }

        // Летать
        public string Flay() {
            return "\nЛечу...";
        }
        // Ходить
        public string Walk() {
            return "\nХожу...";
        }
    }

    // Класс рыбы
    class Fish : Animals
    {
        private string Water;       // Тип воды
        private string Kind;        // Вид

        public Fish(string Water, string Kind, string Area, int Weight, string Color)
            : base(Area, Weight, Color) {
            this.Water = Water;
            this.Kind = Kind;
        }

        // Переопределям метод Info(), абстрактного класса Animals
        public override string Info() {
            return "\nКласс птицы" + "\n\tВид - " + this.Kind + "\n\tТип воды - " + this.Water +
                "\n\tВес - " + Weight + "\n\tОкрас - " + Color;
        }
    }

    // Класс домашние животные
    class Pet : Mammal
    {
        private string Name;    // Имя
        private string Owner;   // Владелец
        //string Kind;    // Вид

        public Pet(string Name, string Owner, int Legs, string Kind, string Area, int Weight, string Color)
            : base(Legs, Kind, Area, Weight, Color) {
            this.Name = Name;
            this.Owner = Owner;
        }

        public override string Info() {
            return "\nКласс домашние животные" + "\n\tВид - " + this.Kind + "\n\tКол-во ног - " + this.Legs +
                "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color +
                "\n\tИмя - " + this.Name + "\n\tВладелец - " + this.Owner;
        }
    }

    // Класс дикие животные
    class Wild : Mammal
    {
        //string King;    // Вид

        public Wild(int Legs, string Kind, string Area, int Weight, string Color)
            : base(Legs, Kind, Area, Weight, Color) {
        }

        public override string Info() {
            return "\nКласс дикие животные" + "\n\tВид - " + this.Kind + "\n\tКол-во ног - " + this.Legs +
                "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color;
        }
    }

    /// Интерфейс летающие
    public interface IFlaying
    {
        // Летать
        string Flay();
        // Ходить
        string Walk();
    }

    // Интерфейс ходячие
    public interface IWalking
    {
        // Ходить
        string Walk();
    }

    class Program
    {
        static void Main(string[] args) {
            // Инициализируем классы
            Mammal mammal = new Mammal(4, "Лев", "Африка", 180, "Желто-серый");
            Bird bird = new Bird(50, "Орел", "Европа", 8, "Желто-коричневый");
            Fish fish = new Fish("Пресная", "Карась", "Европа", 500, "Коричневый");
            // Выводим информацию 
            Console.WriteLine(mammal.Info());
            Console.WriteLine(bird.Info());
            Console.WriteLine(fish.Info());

            // Инициализируем классы "Дикие животные и домашние"
            Pet pet = new Pet("Ласка", "Иванов В.В", 4, "Кошачьи", "Дом/улица", 3, "Белый");
            Wild wild = new Wild(4, "Кошачьи", "Леса", 3, "Черный");
            // Выводим информацию 
            Console.WriteLine(pet.Info());
            Console.WriteLine(wild.Info());


            // Выполним методы ходить летать
            Console.WriteLine("\nВыполним методы \"ходить, летать\" класса Mannal");
            Console.WriteLine(mammal.Walk());
            Console.WriteLine("\nВыполним метод \"летать\" класса Bird");
            Console.WriteLine(bird.Flay());
            Console.WriteLine(bird.Walk());

            Console.ReadKey();
        }
    }
}
