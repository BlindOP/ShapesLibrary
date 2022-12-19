namespace ShapesLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius > 0)
            {
                this.Radius = radius;
            }
            else throw new ArgumentException("Incorrect triangle parameters");
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}