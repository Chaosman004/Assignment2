using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
 * Author: Robert Page 200281838
 * Website: http://robcomp2007assignment2.azurewebsites.net/
 * Description: left to prevent wierd database errors
*/
namespace COMP2007_S2016_Lesson10C.Models
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}