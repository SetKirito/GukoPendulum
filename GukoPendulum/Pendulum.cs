using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GukoPendulum
{
    class Pendulum
    {
        // Начальная длина пружины или веревки маятника
        public double RestLength { get; set; }
        // Текущая длина пружины или веревки маятника
        public double Length { get; set; }
        // Масса маятника
        public double Mass { get; set; }
        // Радиус шара
        public int BallRadius { get; set; }
        // Координаты маятника
        public double Position { get; set; }
        // Начальная скорость маятника
        public double InitialVelocity { get; set; }
        // Скорость маятника
        public double Velocity { get; set; }
        //Ускорение маятника
        public double Acceleration { get; set; }
        // Коэффициент жесткости пружины
        public double SpringConstant { get; set; }
        // Коэффициент демпфирования
        public double DampingCoefficient { get; set; } = 1;
        // Нелинейная жесткость пружины
        public Func<double, double> NonlinearSpringFunction { get; set; }
        public double MaxLoad { get; set; }


    }
}
