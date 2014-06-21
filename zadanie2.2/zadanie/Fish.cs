using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace laba2
{
    // Класс рыбы
    class Fish : Animals
    {
        private string Water;       // Тип воды
        private string Kind;        // Вид

        public Fish(string Water, string Kind, string Area, int Weight, string Color)
            : base(Area, Weight, Color, Coordinates) {
            this.Water = Water;
            this.Kind = Kind;
        }

        // Переопределям метод Info(), абстрактного класса Animals
        public override string Info() {
            return "\nКласс рыбы" + "\n\tВид - " + this.Kind + "\n\tТип воды - " + this.Water +
                "\n\tВес - " + Weight + "\n\tОкрас - " + Color;
        }

        /// <summary>Вычисляет длину вектора</summary>
        /// <param name="Begin">Координаты начала вектора</param>
        /// <param name="End">Координаты конца вектора</param>
        /// <returns>Длина вектора</returns>
        public override double LengthVector(Point Begin, Point End) {
            return Math.Abs(Math.Sqrt(Math.Pow(End.X - Begin.X, 2) + Math.Pow(End.Y - Begin.Y, 2)));
        }
    }
}
