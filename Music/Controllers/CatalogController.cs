using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Music.App_Start;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Controllers
{
    public class CatalogController : Controller
    {
        MongoContext _dbContext;

        // GET: Catalog
        public ActionResult Index()
        {
            //Initialisation de la base Mongo
            _dbContext = new MongoContext();
            var stats = _dbContext.database.GetStats();
            //On charge tout le catalogue

            var albumList = _dbContext.database.GetCollection<Albums>("albums").FindAll().ToList();

            //TODO: Crée la collection catalogue dans la base MongoDB
            //TODO: Ajouter l'image de la photo d'un album dans la collection en base
            //TODO: Le catalogue contiendra toutes les albums, qui eux contiendront tous les artistes


            return View(albumList.OrderBy(p=>p.albumPrice).ThenBy(v=>v.albumName).ToList());
        }

        //Retourne la liste des albums avec un tri sur l'année croissante
        public ActionResult Albums()
        {
            //Initialisation de la base Mongo
            _dbContext = new MongoContext();

            var albumSortedList = _dbContext.database.GetCollection<Albums>("albums").FindAll().ToList();

            return View(albumSortedList.OrderBy(p=>p.albumYear).ToList());
        }


        public ActionResult Artists()
        {
            _dbContext = new MongoContext();
            var artistSortedList = _dbContext.database.GetCollection<Artistes>("artistes").FindAll().ToList();
            return View(artistSortedList.OrderBy(p=>p.artistName).ToList());
        }
    }
}