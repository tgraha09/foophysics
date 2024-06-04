using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooPhysics.Measurements;

namespace FooPhysics.Measurements
{

    
    public enum Units
    {

        None = 0,
        // Metric
        cm = 1,
        m = 2,
        km = 3,
        ml = 4,
        l = 5,
        mg = 6,
        g = 7,
        kg = 8,
        C = 9,
        

        // Imperial
        inch = 10,
        ft = 11,
        yds = 12,
        mi = 13,
        oz = 14,
        lb = 15,
        gal = 16,
        F = 17
        
        
    }

    public enum MetricUnits
    {
        none = 0,
        milimeters = Units.ml,
        centimeters = Units.cm,
        meters = Units.m,
        kilometers = Units.km,
        liters = Units.l,
        miligrams = Units.mg,
        grams = Units.g,
        kilograms = Units.kg,
        mm = milimeters,
        cm = centimeters,
        m = meters,
        km = kilometers,

        l = liters,
        mg = miligrams,
        g = grams,
        kg = kilograms,

        C = Units.C
    }

    public enum MetricLengthUnits
    {
        none = 0,
        milimeters = Units.ml,
        centimeters = Units.cm,
        meters = Units.m,
        kilometers = Units.km,

        mm = milimeters,
        cm = centimeters,
        m = meters,
        km = kilometers,
    }

    public enum MetricMassUnits
    {
        none = 0,
        miligrams = Units.mg,
        grams = Units.g,
        kilograms = Units.kg,
        mg = miligrams,
        g = grams,
        kg = kilograms,
    }

    public enum MetricTemperatureUnits
    {
        C = Units.C
    }

    

    public enum ImperialUnits
    {
        none = 0,
        inches = Units.inch,
        feet = Units.ft,
        yards = Units.yds,
        miles = Units.mi,
        ounces = Units.oz,
        pounds = Units.lb,
        gallon = Units.gal,

        inch = inches,
        ft = feet,
        yds = yards,
        mi = miles,
        oz = ounces,
        lb = pounds,
        gal = gallon,
        F = Units.F
    }

    public enum ImperialLengthUnits
    {
        inches = Units.inch,
        feet = Units.ft,
        yards = Units.yds,
        miles = Units.mi,

        inch = inches,
        ft = feet,
        yds = yards,
        mi = miles,
    }

    public enum ImperialMassUnits
    {
        ounces = Units.oz,
        pounds = Units.lb,
        gallon = Units.gal,
        oz = ounces,
        lb = pounds,
        gal = gallon
    }

    public enum ImperialTemperatureUnits
    {
        F = Units.F
    }
}

