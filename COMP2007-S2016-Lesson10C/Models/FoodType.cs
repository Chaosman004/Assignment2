using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Lesson10C.Models
{
    public class FoodType
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodType()
        {

        }

        /// <summary>
        /// This constructor takes one paramter - Name
        /// </summary>
        /// <param name="Name"></param>
        public FoodType(string Name)
        {
            this.Name = Name;
        }

        public virtual int FoodTypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}