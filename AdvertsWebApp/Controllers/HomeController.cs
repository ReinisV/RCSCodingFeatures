
using AdvertsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvertsWebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            adverts = new List<Advert>();

            Advert ad = new Advert();
            ad.AdvertId = 1;
            ad.Name = "bmw";
            ad.AdvertText = "šis ir labs BMW";
            ad.Price = 2000.95;
            ad.CreationTime = DateTime.Now;

            Advert homeAd = new Advert();
            homeAd.AdvertId = 2;
            homeAd.Name = "māja";
            homeAd.AdvertText = "liela māja";
            homeAd.Price = 12000;
            homeAd.CreationTime = new DateTime(1999, 12, 31);

            adverts.Add(ad);
            adverts.Add(homeAd);
        }

        private List<Advert> adverts;

        // šī funkcija tiek izsaukta, kad tiek pieprasīts weblapas bāzes ceļš
        // GET: Home (piemēram www.ss.lv)
        public ActionResult Index()
        {
            // izsaucam View() funkciju, lai uzģenerētu html rezultātu
            // no mūsu Index.cshtml faila, tajā iekšā izmantojot datus,
            // kas pieejami adverts sarakstā
            return View(adverts);
        }

        public ActionResult Advert(int advertId)
        {
            // apskatām katru sludinājumu sludinājumu sarakstā
            foreach(var ad in adverts)
            {
                // ja sludinājuma id ir tāds pats, kā tas, ko lietotājs pieprasījis
                if(ad.AdvertId == advertId)
                {
                    // tad izveidojam skatu izmantojot šī sludinājuma datus
                    // un atgriežam lietotājam
                    return View(ad);
                }
            }

            return View();
        }
    }
}