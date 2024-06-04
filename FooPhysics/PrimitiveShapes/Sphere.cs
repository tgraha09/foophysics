//using FooPhysics.Measurements;
using FooPhysics.Measurements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FooPhysics.Measurements.Units;
using static FooPhysics.Measurements.Measurements;

//using static FooPhysics.GeometricPrimitives;

namespace FooPhysics
{
    public class Sphere : GeometricPrimitives
    {
        //privbate 
        private double radius;

        private double mass;

        private double temperature;
        
        private Units unitLength;

        private Units unitMass;

        private Units unitTemp;
        //default constructor
        public Sphere()
        {

            // Store radius
            this.radius = 5;

            unitLength = m;

        }
        //radius specified
        public Sphere(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than 0");

            this.radius = radius;

        }

        

        //full parameterized specification for sphere 
        public Sphere(double _radius, object _unitLength, double _mass ,object _unitMass, double _temp, object _unitTemp)
        {
            if (_radius <= 0)
                throw new ArgumentException("Radius must be greater than 0");

            if (_mass <= 0)
                throw new ArgumentException("Mass must be greater than 0");

            if ((IsImperialLengthUnit(_unitLength) || IsMetricLengthUnit(_unitLength))
                && ((IsImperialMassUnit(_unitMass) || IsMetricMassUnit(_unitMass)))
                && ((IsImperialTemperatureUnit(_unitTemp) || IsMetricTemperatureUnit(_unitTemp))))
            {
                // Store radius
                this.radius = _radius;
                unitLength = (Units)_unitLength;

                mass = _mass;
                unitMass = (Units)_unitMass;

                temperature = _temp;
                unitTemp = (Units)_unitTemp;
            }
            else
            {
                throw new ArgumentException("Invalid entry");
            }

        }


        // Properties
        public override double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public override double Mass
        {
            get
            {
                return mass;
            }

            set
            {
                mass = value;
            }
        }

        public double Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                temperature = value;
            }
        }


        //public properties
        public override double Volume => CalculateVolume();

        public override double Density => CalculateDensity();

        public override double SurfaceArea => CalculateSurfaceArea();

        public override double Circumference => CalculateCircumference();











        //Sphere Override
        protected override double CalculateVolume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }

        protected override double CalculateSurfaceArea()
        {
            return 4.0 * Math.PI * (radius * radius);
        }

        protected override double CalculateDensity()
        {
            return mass/Volume;
        }

        //Sphere Methods
        private double CalculateCircumference()
        {
            return 2.0 * (Math.PI * radius);
        }


      

        public override string ToString()
        {
            return string.Format("Radius: {0} {1} \nMass: {2} {3} \nTemperature: {4} {5}", radius, unitLength, mass, unitMass, temperature, unitTemp) + "\n" + 
                "Volume = " + Volume + " " + unitLength + "^3" + "\n" + "Surface Area = " + SurfaceArea + " " + unitLength + "^2" + "\n" + "Density = " + Density + " " + unitMass + "/" + unitLength + "^3";
        }




    }
}
