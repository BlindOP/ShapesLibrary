namespace ShapesLibrary
{
    public class Triangle : IShape
    {
        public double LengthA { get;}
        public double LengthB { get;}
        public double LengthC { get;}
        public bool IsRightTriangle { get;}

        public Triangle(double lengthA, double lengthB, double lengthC)
        {
            if (IsTriangle(lengthA, lengthB, lengthC) && lengthA > 0 && lengthB > 0 && lengthC > 0)
            {
                this.LengthA = lengthA;
                this.LengthB = lengthB;
                this.LengthC = lengthC;
            }
            else throw new ArgumentException("Incorrect triangle parameters");
            IsRightTriangle = CheckRightTriangle();
        }
        private bool IsTriangle(double lengthA, double lengthB, double lengthC)
        {
            if (lengthA + lengthB > lengthC && lengthA + lengthC > lengthB && lengthB + lengthC > lengthA)
            {
                return true;
            }
            else return false;
        }
        private bool CheckRightTriangle()
        {
            var sides = new double[] { this.LengthA, this.LengthB, this.LengthC };
            
            ////Расчитываем числовую размерность сторон треугольника, что бы динамически менять точность округления
            var numberDimension = (int)Math.Ceiling(Math.Log10(sides.Average()));
            var roundingAfterDot = 1;
            if (numberDimension < 0) roundingAfterDot = -numberDimension;
            
            Array.Sort(sides);
            
            return Math.Round(Math.Pow(sides[2], 2), roundingAfterDot) == Math.Round(Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2), roundingAfterDot);
        }
        public double GetArea()
        {
            var p = (this.LengthA + this.LengthB + this.LengthC) / 2;
            return Math.Sqrt(p * (p - this.LengthA) * (p - this.LengthB) * (p - this.LengthC));
        }
    }
}
