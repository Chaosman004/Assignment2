namespace COMP2007_S2016_Lesson10C.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
    }
}
