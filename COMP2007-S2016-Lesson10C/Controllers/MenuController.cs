﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Lesson10C.Models;

namespace COMP2007_S2016_Lesson10C.Controllers
{
/*
 * Author: Robert Page 200281838
 * Website: http://robcomp2007assignment2.azurewebsites.net/
 * Description: this displays the menu views
*/
    public class MenuController : Controller
    {

        MenuContext storeDB = new MenuContext();

        //
        // GET: /Menu/
        public ActionResult Index()
        {


            List<Album> food = storeDB.Albums.ToList();
            return View(food);

        }
        //
        // GET: /Menu/Browse?genre=Disco

        public ActionResult Browse(string genre = "Rock")
        {
            // Retrieve Genre and its Associated Albums from database
            Genre genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET: /Menu/Details/5

        public ActionResult Details(int id = 1)
        {
            Album album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}