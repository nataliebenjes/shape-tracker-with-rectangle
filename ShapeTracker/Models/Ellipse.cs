using System.Collections.Generic;

namespace ShapeTracker.Models
{
    public class Ellipse
    {
        private int _side1;
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        private int _side2;
        public int Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }


        private static List<Ellipse> _instances = new List<Ellipse> { };

        public Ellipse(int length1, int length2)
        {
            _side1 = length1;
            _side2 = length2;

            _instances.Add(this);
        }

        public static List<Ellipse> GetAll()
        {
            return _instances;
        }
        public const double PI = 3.1415926535897931;
        public double getEllipseArea()
        {
            return PI * Side2 * Side1;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}