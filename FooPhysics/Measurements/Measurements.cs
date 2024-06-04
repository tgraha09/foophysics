using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooPhysics.Measurements
{
    public class Measurements
    {
        //cheks if the unit is an imperial length
        public static bool IsImperialLengthUnit(object _unit)
        {

            if (Enum.IsDefined(typeof(ImperialUnits), (ImperialUnits)_unit) && Enum.IsDefined(typeof(ImperialLengthUnits), (ImperialLengthUnits)_unit))
            {
                return true;
            }


            return false;
        }

        //cheks if the unit is an imperial weight
        public static bool IsImperialMassUnit(object _unit)
        {

            if (Enum.IsDefined(typeof(ImperialUnits), (ImperialUnits)_unit) && Enum.IsDefined(typeof(ImperialMassUnits), (ImperialMassUnits)_unit))
            {
                return true;
            }


            return false;
        }

        public static bool IsImperialTemperatureUnit(object _unit)
        {

            if (Enum.IsDefined(typeof(ImperialUnits), (ImperialUnits)_unit) && Enum.IsDefined(typeof(ImperialTemperatureUnits), (ImperialTemperatureUnits)_unit))
            {
                return true;
            }


            return false;
        }


        //cheks if the unit is an metric length
        public static bool IsMetricLengthUnit(object _unit)
        {

            if(Enum.IsDefined(typeof(MetricUnits), (MetricUnits)_unit) && Enum.IsDefined(typeof(MetricLengthUnits), (MetricLengthUnits)_unit))
            {
                return true;
            }


            return false;
        }

        //cheks if the unit is an metric weight
        public static bool IsMetricMassUnit(object _unit)
        {

            if (Enum.IsDefined(typeof(MetricUnits), (MetricUnits)_unit) && Enum.IsDefined(typeof(MetricMassUnits), (MetricMassUnits)_unit))
            {
                return true;
            }


            return false;
        }

        public static bool IsMetricTemperatureUnit(object _unit)
        {

            if (Enum.IsDefined(typeof(MetricUnits), (MetricUnits)_unit) && Enum.IsDefined(typeof(MetricTemperatureUnits), (MetricTemperatureUnits)_unit))
            {
                return true;
            }


            return false;
        }
    }
  




}
