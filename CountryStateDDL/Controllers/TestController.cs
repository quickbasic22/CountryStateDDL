using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CountryStateDDL.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.CountryList = new SelectList(GetCountryList(), "CountryId", "CountryName");

            return View();
        }


        public List<Country> GetCountryList()
        {

            CountryModel db = new CountryModel();

            List<Country> countries = db.Countries.ToList();

            return countries;


        }

        public ActionResult GetStateList(int CountryId)
        {
            CountryModel db = new CountryModel();

            List<State> stateList = db.States.Where(x => x.CountryId == CountryId).ToList();

            ViewBag.StateOptions = new SelectList(stateList, "StateId", "StateName");

            return PartialView("StateOptionPartial");

        }

    }
}