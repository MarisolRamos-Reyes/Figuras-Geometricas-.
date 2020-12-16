using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_geometricas
{
    class Area
    {

        public decimal Cuadrado(decimal lado)
        {
            return lado * lado;
        }
        public decimal Rectangulo(decimal basea, decimal altura)
        {
            return basea * altura;
        }
        public decimal Triangulo(decimal basea, decimal altura)
        {
            return (basea * altura) / 2;
        }
        public decimal Circulo(decimal radio)
        {
            decimal v = radio * radio;
            return v * (decimal)Math.PI;
        }
        public decimal Romboide(decimal basea, decimal altura)
        {
            return basea * altura;
        }
        public decimal Trapcecio(decimal basemayor, decimal altura, decimal basemenor)
        {
            return ((basemayor * basemenor) * altura) / 2;
        }
        public decimal Pentagono(decimal lado, decimal altura)
        {
            decimal a = 5;
            return (a * lado * altura) / 2;
        }
        public decimal Hexagono(decimal lado, decimal altura)
        {
            decimal a = 6;
            return (a * lado * altura) / 2;
        }
    }
}

