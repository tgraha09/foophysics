using FooPhysics.Measurements;
//using static FooPhysics.Measurements.Units;
namespace FooPhysics
{
    public abstract class GeometricPrimitives
    {
        // Abstract Properties across all shapes
        public abstract double Radius { get; set; }
        public abstract double Mass { get; set; }
        public abstract double Volume { get;}
        public abstract double SurfaceArea { get; }
        public abstract double Circumference { get;}
        public abstract double Density { get; }


        // Abstract Methods across all shapes
        protected abstract double CalculateVolume();
        protected abstract double CalculateSurfaceArea();

        protected abstract double CalculateDensity();

        

    }
}
