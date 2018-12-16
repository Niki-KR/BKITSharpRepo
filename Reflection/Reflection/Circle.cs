﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection {
    public class Circle {
        public double Radius = 0;
        [PropAttr("Диаметр")]
        public double Diameter { get { return 2 * Radius; } }
        [PropAttr("Длина окружности")]
        public double Circumference { get { return Diameter * Math.PI; } }
        public double Area { get { return Radius * Radius * Math.PI; } }
        public override string ToString() {
            return $"Радиус: {Radius}.\nДлина окружности: {Circumference}.\nПлощадь: {Area}.";
        }
        public Circle(double r) {
            Radius = r;
        }
    }
}
