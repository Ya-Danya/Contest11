using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];
        double[] ratioVectorsLen = new double[n];
        for (int i = 0; i < n; i++)
        {
            points[i] = new Point(Console.ReadLine());
            ratioVectorsLen[i] = Math.Sqrt(points[i].X * points[i].X + points[i].Y * points[i].Y);
        }
        Array.Sort(ratioVectorsLen, points);
        Point[] points1 = new Point[k];
        for (int i = 0; i < k; i++)
        {
            points1[i] = points[i];
        }
        Array.Sort(points1, new PointsComparer());
        foreach (Point point in points1)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}

class PointsComparer : IComparer<Point>
{
    public int Compare(Point p1, Point p2)
    {
        if (p1.X < p2.X)
        {
            return -1;
        }
        else if (p1.X == p2.X)
        {
            if (p1.Y < p2.Y)
            {
                return -1;
            }
            else if (p1.Y == p2.Y)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 1;
        }
    }
}
public class Point
{
    public double X;
    public double Y;
    public Point(string input)
    {
        string[] contents = input.Split(' ');
        X = double.Parse(contents[0]);
        Y = double.Parse(contents[1]);
    }
}