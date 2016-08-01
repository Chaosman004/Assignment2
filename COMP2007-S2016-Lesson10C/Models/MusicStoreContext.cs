namespace COMP2007_S2016_Lesson10C.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
/*
 * Author: Robert Page 200281838
 * Website: http://robcomp2007assignment2.azurewebsites.net/
 * Description: this was supposed to be removed but refused to die so it has been left
*/
    public partial class MusicStoreContext : DbContext
    {
        public MusicStoreContext()
            : base("name=MusicStoreConnection")
        {
        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
    }
}
