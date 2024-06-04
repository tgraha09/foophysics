using FooPhysics;
using static FooPhysics.Measurements.Units;
Console.WriteLine("FooPhysics!\n");

Sphere sphere = new Sphere(5, m, 10, kg, 90, F);

Console.WriteLine(sphere.ToString());
