using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareObjects
{
    class Car : IEquatable<Car>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMoving { get; set; }

        /// <summary>
        /// Checks if given object is Car and is same as this instance
        /// </summary>
        /// <param name="o"></param>
        /// <returns>
        /// true if parameter is same as this instance
        /// false if parameter is null, or it is not a Car
        /// </returns>
        public bool Equals(Car o)
        { 
            if (o != null && o is Car)
            {
                    Car c =  o as Car;
                    return Id == c.Id && string.Equals(Name, c.Name) && IsMoving == c.IsMoving;
            }
            return false;
        }
    }
}
