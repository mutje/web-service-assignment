using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceAssignment
{
    public class Thing
    {
        public Thing(int id, string name, int length, double? weight = null, bool? isActive = null)
        {
            ID = id;
            Name = name;
            Length = length;
            Weight = weight;
            IsActive = isActive;
        }

        public int ID {get; set;}
        public string Name {get; set;} 
        public int Length {get; set;} 
        public double? Weight {get; set;} 
        public bool? IsActive {get; set;}
    }
}
