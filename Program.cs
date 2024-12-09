// 1112410005廖筠珊
using System;

class Program
{
    public static double CountPi(int n)
    {
        if (n < 4 || n > 15)
        {
            return -1;
        }
        double pi = 0.0;

        for (int i = 0; i < n; i++)
        {
            double term = 1.0 / (2 * i + 1);
            if (i % 2 == 0)
            {
                pi += term;
            }
            else
            {
                pi -= term;
            }
        }
        pi *= 4;
        return pi;
    }

    // 圓周長
    public static double GetCircumference(double r, int n)
    {
        if (r <= 0)
        {
            return -1;
        }

        double pi = CountPi(n);
        if (pi == -1)
        {
            return -1;
        }

        double circumference = pi * r;
        return circumference;
    }

    // 圓面積
    public static double GetCircleArea(double r, int n)
    {
        if (r <= 0)
        {
            return -1;
        }

        double pi = CountPi(n);
        if (pi == -1)
        {
            return -1;
        }

        double area = pi * r * r;
        return area;
    }

    static void Main(string[] args)
    {
        Console.Write("請輸入圓的半徑 (可以有小數點): ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("請輸入圓周率的精度 (n)，範圍在 4 到 15 之間: ");
        int n = int.Parse(Console.ReadLine());

        // 算圓周率
        double piResult = CountPi(n);
        if (piResult == -1)
        {
            return;
        }
        Console.WriteLine($"圓周率的精度設定為: {n}");
        Console.WriteLine($"由函式計算出來的圓周率值: {piResult:g}");
        // 算圓周長
        double circumferenceResult = GetCircumference(radius, n);
        Console.WriteLine($"半徑為 {radius} 的圓的周長是: {circumferenceResult}");
        // 算圓面積
        double areaResult = GetCircleArea(radius, n);
        Console.WriteLine($"半徑為 {radius} 的圓的面積是: {areaResult}");

    }
}
