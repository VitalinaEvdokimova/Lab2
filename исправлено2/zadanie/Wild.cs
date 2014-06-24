using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace laba2
{
    // Класс дикие животные
    class Wild : Mammal
    {
        private Point Coordinates;      // Координаты животного
        //string King;    // Вид

        public Wild(int Legs, string Kind, double MaxLenght, string Area, int Weight, string Color, Point Coordinates)
            : base(Legs, Kind, MaxLenght, Area, Weight, Color, Coordinates) {
                this.Coordinates = Coordinates;
        }

        public override string Info() {
            return "\nКласс дикие животные" + "\n\tВид - " + this.Kind + "\n\tКол-во ног - " + this.Legs +
                "\n\tАреал обитания - " + Area + "\n\tВес - " + Weight + "\n\tОкрас - " + Color + "\n\tКоординаты - " + Coordinates;
        }


    }
}
