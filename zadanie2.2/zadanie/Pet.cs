using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace laba2
{
    // Класс домашние животные
    class Pet : Mammal
    {
        private string Name;    // Имя
        private string Owner;   // Владелец
        //string Kind;    // Вид

        public Pet(string Name, string Owner, int Legs, string Kind, double MaxLenght, string Area, int Weight, string Color, Point Coordinates)
            : base(Legs, Kind, MaxLenght, Area, Weight, Color, Coordinates) {
            this.Name = Name;
            this.Owner = Owner;
        }

        public override string Info() {
            return "\nКласс домашние животные" + "\n\tВид - " + this.Kind + "\n\tКол-во ног - " + this.Legs +
                "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color +
                "\n\tИмя - " + this.Name + "\n\tВладелец - " + this.Owner + "\n\tКоординаты - " + Coordinates;
        }

    }
}
