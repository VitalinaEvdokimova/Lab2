using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace laba2
{
    // Абстрактный класс "Животные"
    abstract class Animals
    {
        protected string Area;      // Ареал обитания
        protected int Weight;       // Вес
        protected string Color;     // Окрас
        protected static Point Coordinates;// Координаты животного

        /// <summary>Конструктор</summary>
        /// <param name="Area">Ареал обитания</param>
        /// <param name="Weight">Вес</param>
        /// <param name="Color">Окрас</param>
        public Animals(string Area, int Weight, string Color, Point Coordinates1) {
            this.Area = Area;
            this.Weight = Weight;
            this.Color = Color;
            Coordinates = Coordinates1;
        }

        /// <summary> Абстрактный метод </summary>
        public abstract string Info();
        /// <summary>Вычисляет длину вектора</summary>
        /// <param name="Begin">Координаты начала вектора</param>
        /// <param name="End">Координаты конца вектора</param>
        /// <returns>Длина вектора</returns>
        public abstract double LengthVector(Point Begin, Point End);
    }
}
