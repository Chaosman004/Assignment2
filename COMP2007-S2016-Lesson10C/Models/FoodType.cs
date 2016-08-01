using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
 * Author: Robert Page 200281838
 * Website: http://robcomp2007assignment2.azurewebsites.net/
 * Description: was suposed to replace album and genre 
 *              but constantly gave errors - also gave errors when removed
*/
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