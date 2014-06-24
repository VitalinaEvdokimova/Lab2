using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace laba2
{
    

    /// Интерфейс летающие
    public interface IFlying
    {
        /// <summary>Летать</summary>
        void Fly();
        /// <summary>Ходить</summary>
        void Walk();
        /// <summary>Летать в соответствии с заданным маршрутом</summary>
        void Fly(Point[] route);
        /// <summary>Ходить в соответствии с заданным маршрутом</summary>
        void Walk(Point[] route);
    }

    // Интерфейс ходячие
    public interface IWalking
    {
        /// <summary>Ходить</summary>
        void Walk();
        /// <summary>Ходить в соответствии с заданным маршрутом</summary>
        void Walk(Point[] route);
    }
}
