using System;

namespace MathSquares
{
    public class Square
    {
        /// <summary>
        /// Поиск площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        public double sqrCircle(double radius)
        {

            double square = Math.PI * Math.Pow(radius, 2);
            return square;
        }
        
        /// <summary>
        /// Поиск площади круга по радиусу с указанным количесвом знаков для округления
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <param name="numDigits">Количество щнаков для округления</param>
        /// <returns>(double) Вычисленное значение площади</returns>
        public double sqrCircle(double radius, int numDigits)
        {

            double square = Math.Round(Math.PI * Math.Pow(radius, 2), numDigits);
            return square;

        }
        
        /// <summary>
        /// Поиск площади треугольника по трём сторонам
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <returns>(double) Значение площади</returns>
        public double sqrTriangle(double firstSide, double secondSide, double thirdSide)
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            double square = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return square;
        }

        /// <summary>
        /// Проверяет, прямоугольный ли треугольник. 
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <returns>true или false</returns>
        public bool isTriangleSquared(double firstSide, double secondSide, double thirdSide)
        { 
            if ((Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) || (Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)) || (Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(firstSide, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Поиск площади по одному значению (круг)
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>(double) Вычисленное значение площади</returns>
        public double findSquare(double radius)
        {
            double square = Math.PI * Math.Pow(radius, 2);
            return square;
        }

        /// <summary>
        /// Поиск площади треугольника по трём сторонам
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <returns>(double) Значение площади</returns>
        public double findSquare(double firstSide, double secondSide, double thirdSide)
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            double square = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return square;
        }
    }
}
