﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace laba2
{
    // Класс млекопитающие
    class Mammal : Animals, IWalking
    {
        protected int Legs;             // Кол-во ног
        protected string Kind;          // Вид
        private double MaxLenght;       // Максимальная дальность передвижения за один раз

        public Mammal(int Legs, string Kind, double MaxLenght, string Area, int Weight, string Color, Point Coordinates)
            : base(Area, Weight, Color, Coordinates) {
            this.Legs = Legs;
            this.Kind = Kind;
            this.MaxLenght = MaxLenght;
        }

        // Переопределям метод Info(), абстрактного класса Animals
        public override string Info() {
            return "\nКласс млекопитающие" + "\n\tВид - " + this.Kind + "\n\tКол-во ног - " + this.Legs +
                "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color + "\n\tКоординаты - " + Coordinates;
        }

        /// <summary>Вычисляет длину вектора</summary>
        /// <param name="Begin">Координаты начала вектора</param>
        /// <param name="End">Координаты конца вектора</param>
        /// <returns>Длина вектора</returns>
        public override double LengthVector(Point Begin, Point End){
            return Math.Abs(Math.Sqrt(Math.Pow(End.X - Begin.X, 2) + Math.Pow(End.Y - Begin.Y, 2)));
        }

        /// <summary>Метод перемещения в соответствии с заданным вектором координат перемещения</summary>
        /// <param name="route">маршрут перемещения (вектор координат)</param>
        private void Move(Point[] route) {
            // Перемещаем в соответствии с дальностью перемещения за один раз
            // Если млекопитающее не может переместиться за один раз, то заканчиваем перемещение
            for (int i = 0; i < route.Count(); i++) {
                double len = LengthVector(Coordinates, route[i]);
                // Если текущая длина перемещения не превышает макисмальную дальность перемещения
                if (this.MaxLenght >= len) {
                    // то перемещаем млекопитающее на заданные координаты
                    Coordinates = route[i];
                    Console.WriteLine("\tТекущие координаты - " + Coordinates);
                    Console.WriteLine("\tДлина перемещения составила - {0:F2}", len);
                }
                else {
                    Console.WriteLine("Максимальная дальность передвижения не позволяет переместиться на заданные координаты");
                    i = route.Count();
                }
            }
        }

        // Ходить
        public void Walk() {
            Point[] route = new Point[10];      // маршрут перемещения
            // Генерируем маршрут перемещения
            Random r = new Random();
            for (int i = 0; i < 10; i++) {
                route[i].X = r.Next(100);
                route[i].Y = r.Next(100);
            }
            Console.WriteLine(Info());
            Console.WriteLine("Начинаем рандомно ходить");
            Move(route);
        }

        // Ходить в соответствии с заданным маршрутом
        public void Walk(Point[] route) {
            Console.WriteLine(Info());
            Console.WriteLine("Начинаем передвигаться в соответствии с заднным вектором движения");
            Move(route);
        }
    }
}
