using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COMP2007_S2016_Lesson10C.Models
{
    public class SampleData : DropCreateDatabaseAlways<MusicStoreContext>
    {
        protected override void Seed(MusicStoreContext context)
        {

            var genres = new List<Genre>
            {
                new Genre { Name = "Appetizer" },
                new Genre { Name = "Main Course" },
                new Genre { Name = "Desserts" },
                new Genre { Name = "Beverages" },
            };

            var artists = new List<Artist>
            {
                new Artist { Name = "Temp" },
            };

            new List<Album>
            {
                new Album { Title = "Bread Sticks", Genre = genres.Single(g => g.Name == "Appetizer"), Price = 1.99M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                new Album { Title = "Test", Genre = genres.Single(g => g.Name == "Main Course"), Price = 1.99M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Content/Images/placeholder.gif" }
            }.ForEach(a => context.Albums.Add(a));
        }
    }
}