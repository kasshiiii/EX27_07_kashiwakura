using System;

public class VariousSolids
{
    static void Main()
    {
        Console.WriteLine("直方体");
        Box box = new Box(InputFloat("幅を入力してください"), InputFloat("高さを入力してください"), InputFloat("奥行きを入力してください"));
        Console.WriteLine("表面積 = " + box.GetSurface());
        Console.WriteLine("体積 = " + box.GetVolume());

        Console.WriteLine("\n円柱");
        Cylinder cylinder = new Cylinder(InputFloat("底面の半径を入力してください"), InputFloat("高さを入力してください"));
        Console.WriteLine("表面積 = " + cylinder.GetSurface());
        Console.WriteLine("体積 = " + cylinder.GetVolume());

        Console.WriteLine("\n球");
        Sphere sphere = new Sphere(InputFloat("半径を入力して下さい"));
        Console.WriteLine("表面積 = " + sphere.GetSurface());
        Console.WriteLine("体積 = " + sphere.GetVolume());

        Console.WriteLine("\n三角柱");
        TriangularPrism triangularPrism = new TriangularPrism(InputFloat("底面の底辺を入力して下さい"), InputFloat("底面の高さを入力して下さい"), InputFloat("高さを入力して下さい"));
        Console.WriteLine("表面積 = " + triangularPrism.GetSurface());
        Console.WriteLine("体積 = " + triangularPrism.GetVolume());

    }

    static float InputFloat(string outputString)
    {
        float input;
        while (true)
        {
            Console.WriteLine(outputString);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
class Box
{
    float width, height, depth;
    public Box(float width, float height, float depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
    public float GetSurface()
    {
        return (width * height + width * depth + height * depth) * 2.0f;
    }
    public float GetVolume()
    {
        return width * height * depth;
    }
}

class Cylinder
{
    float bottom, height;
    public Cylinder(float bottom,float height)
    {
        this.bottom = bottom;
        this.height = height;
    }
    public float GetSurface()
    {
        return bottom * 2.0f * MathF.PI * height + bottom * bottom * MathF.PI*2.0f;
    }
    public float GetVolume()
    {
        return bottom * bottom * MathF.PI * height;
    }
}

class Sphere
{
    float radius;
    public Sphere(float radius)
    {
        this.radius = radius;
    }
    public float GetSurface()
    {
        return 4.0f * MathF.PI * radius * radius;
    }
    public float GetVolume()
    {
        return (4.0f/3.0f) * MathF.PI * radius * radius * radius;
    }
}

class TriangularPrism
{
    float bottom, bottomHeight, height;
    public TriangularPrism(float bottom, float bottomHeight,float height)
    {
        this.bottom = bottom;
        this.bottomHeight = bottomHeight;
        this.height = height;
    }
    public double GetSurface()
    {
        return bottom * bottomHeight + (bottom + bottomHeight + Math.Sqrt(bottom * bottom + bottomHeight * bottomHeight)) * height;
    }
    public float GetVolume()
    {
        return bottom * bottomHeight / 2.0f * height;
    }
}