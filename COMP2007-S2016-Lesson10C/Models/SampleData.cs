using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/* 
 * this file has been the bane of the whole project,
 * not only does it seem unessesary to have a file that
 * populates the database every time it runs, even when set
 * to always run it still refused to update things when told
*/
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
                new Album { Title = "Bread Sticks", Genre = genres.Single(g => g.Name == "Appetizer"), Price = 1.99M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Assets/images/breadSticks.jpg", AlbumThumbUrl = "/Assets/images/breadSticksThumbnail.jpg" },
                new Album { Title = "Pizza", Genre = genres.Single(g => g.Name == "Main Course"), Price = 20.00M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Assets/images/Pizza.jpg", AlbumThumbUrl = "/Assets/images/PizzaThumbnail.jpg" },
                new Album { Title = "Burger", Genre = genres.Single(g => g.Name == "Main Course"), Price = 15.95M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Assets/images/burger.jpg", AlbumThumbUrl = "/Assets/images/burgerThumbnail.jpg"},
                new Album { Title = "Caeser Salad", Genre = genres.Single(g => g.Name == "Main Course"), Price = 10.12M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Assets/images/caesarSalad.jpg", AlbumThumbUrl = "/Assets/images/caesarSaladThumbnail.jpg"},
                new Album { Title = "Ice Cream", Genre = genres.Single(g => g.Name == "Desserts"), Price = 4.75M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Assets/images/iceCream.jpg", AlbumThumbUrl = "/Assets/images/iceCreamThumbnail.jpg" },
                new Album { Title = "Water", Genre = genres.Single(g => g.Name == "Beverages"), Price = 0.50M, Artist = artists.Single(a => a.Name == "Temp"), AlbumArtUrl = "/Assets/images/water.jpg", AlbumThumbUrl = "/Assets/images/waterThumbnail.jpg" }
            }.ForEach(a => context.Albums.Add(a));
        }
    }
}