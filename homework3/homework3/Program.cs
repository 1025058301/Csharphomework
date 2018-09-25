using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    abstract class Graph
    {
        
        public abstract double Getarea(double s1,double s2,double s3);
        
    }
    class Triangle : Graph{
        public override double Getarea(double s1, double s2, double s3)
        {
            double p = (s1 + s2 + s3) / 2;
            double area2 = p * (p - s1) * (p - s2) * (p - s3);
            return Math.Sqrt(area2);
        }
    }
    class Circular : Graph
    {
        
        public override double Getarea(double r,double s2=0,double s3=0)
        {
            double area = 3.14 * r * r;
            return area;
        }

    }
    class Square : Graph
    {
       
        public override double Getarea(double sidelength,double s2=0,double s3=0)
        {
            double area = sidelength * sidelength;
            return area;
        }
    }
    class Rectangle : Graph
    {
        public override double Getarea(double length,double width,double s3=0)
        {
            double area = length * width;
            return area;
        }
    }
    class Factory
    {
        public static Graph GetGraph(string arg)
        {
            Graph graph = null;
            if (arg=="triangle")
            {
                graph = new Triangle();

            }
            if (arg == "circular")
            {
                graph = new Circular();
            }
            if(arg== "square")
            {
                graph = new Square();
            }
            if (arg == "rectangle")
            {
                graph = new Rectangle();
            }
            return graph;
        }
    }
    class Client
    {
        public static void Main(string[] args)
        {
            Graph graph;
            graph = Factory.GetGraph("triangle");
            double area = graph.Getarea(5,5,5);
            graph = Factory.GetGraph("rectangle");
            double area1 = graph.Getarea(3, 4,0);
        }
    }
}
