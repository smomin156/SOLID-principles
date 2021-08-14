using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    //violates OCP as adding functionality og circle changes original class functionality which is to calculate area of rect
    //example 2of accounts class which needs 2types of acc

    //public class Rectangle
    //{
    //    public double Height { get; set; }
    //    public double Wight { get; set; }
    //}
    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}
    //public class AreaCalculator
    //{
    //    public double TotalArea(object[] arrObjects)
    //    {
    //        double area = 0;
    //        Rectangle objRectangle;
    //        Circle objCircle;
    //        foreach (var obj in arrObjects)
    //        {
    //            if (obj is Rectangle)
    //            {
    //                area += obj.Height * obj.Width;
    //            }
    //            else
    //            {
    //                objCircle = (Circle)obj;
    //                area += objCircle.Radius * objCircle.Radius * Math.PI;
    //            }
    //        }
    //        return area;
    //    }
    //}

    //so we make a abstract class and rect and circle class seperatly
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

    }
    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }
}
