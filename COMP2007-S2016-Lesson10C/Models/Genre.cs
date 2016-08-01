using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
 * Author: Robert Page 200281838
 * Website: http://robcomp2007assignment2.azurewebsites.net/
 * Description: this file is technically menu subheadings, 
 *              as with albums, major edits, 
 *              or removal causes errors
*/
namespace COMP2007_S2016_Lesson10C.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Genre()
        {

        }

        /// <summary>
        /// This constructor takes one paramter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Genre(string Name)
        {
            this.Name = Name;
        }

        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}