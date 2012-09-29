using System;
using System.Linq;
using System.Web.Mvc;
using FlaskList.Models;
using System.Collections.Generic;

namespace FlaskList.Controllers
{
    public class FlaskController : BaseController
    {
        public ActionResult Index()
        {
            var flasks = _session.Query<Flask>().ToList(); 
            return View(flasks);
        }

        public ActionResult Add(Flask flask)
        {
            _session.Store(flask);
            return Json(_session.Query<Flask>().Count(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {
            var flasks = _session.Query<Flask>().ToList();
            return Json(flasks, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(Guid id)
        {
            _session.Delete(_session.Load<Flask>(id));
            return new EmptyResult();
        }
    }
}
