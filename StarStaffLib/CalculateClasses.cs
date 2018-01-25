using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStaffLib
{
    //<summary>
    ///  Класс CalculateClass
    /// Основной класс инкапсулирующий функционал библиотеки.
    /// </summary>
    public class AreaTriangleClass : ComputeAreaShape
    {
        double a, b, c;
        //<summary>
        /// Конструктор AreaTriangleClass.
        /// проверяет правильность передаваемых данных в конструктор,
        /// и устанавливает поля в необходимое значение;
        /// <param> В качестве параметров передается три стороны в любом порядке</param>
        /// <exception cref="TriangleSideExeption">В случае передачи в качестве аргументов хотя бы одной стороны меньше или равной нулю 
        /// выкидывается исключение</exception> 
        /// <exception cref="TriangleTypeExeption">Если переданы стороны не образуют прямоугольный треугольник 
        /// выкидывается исключение </exception> 
        /// </summary>
        public AreaTriangleClass(double in_a, double in_b, double in_c)
        {
            if (in_a <= 0 || in_b <= 0 || in_c <= 0)
                throw new TriangleSideExeption("The side must be greater than zero!");
            else if ((in_a * in_a + in_b * in_b == in_c * in_c) || (in_a * in_a + in_c * in_c == in_b * in_b) || (in_c * in_c + in_b * in_b == in_a * in_a))
            {
                this.a = in_a;
                this.b = in_b;
                this.c = in_c;
            }
            else
                throw new TriangleTypeExeption("Triangle is not rectangular!");

        }
        //<summary>
        /// Функция Compute.
        /// Реализует бизнес-логику вычисления площади  прямоугольного треугольника.
        /// 
        /// </summary>
        public double Compute()
        {

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
    public class AreaCircleClass : ComputeAreaShape
    {
        double R;
        ///<summary>
        /// Конструктор 
        /// проверяет правильность передаваемых данных в конструктор,
        /// и устанавливает поля в необходимое значение;
        /// <param name="R">Радиус круга</param>
        ///  <exception cref="CircleRadiusExeption">Если переданный в качестве аргумента  радиус равен или меньше нуля,
        ///  то выкидывается исключение </exception> 

        /// </summary>
        public AreaCircleClass(double in_R)
        {
            if (in_R <= 0)
                throw new CircleRadiusExeption("The radius must be greater than zero!");
            this.R = in_R;
        }
        //<summary>
        ///  Функция Compute
        /// Реализует бизнес-логику вычисления площади  круга.
        /// </summary>
        public double Compute()
        {
            double S = Math.Pow(R, 2) * Math.PI;
            return S;
        }
    }
}

