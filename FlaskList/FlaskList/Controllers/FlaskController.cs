using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlaskList.Models;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;

namespace FlaskList.Controllers
{
    public class FlaskController : Controller
    {

        public ActionResult Index()
        {
            var flasks = _session.Query<Flask>().ToList(); 
            return View(flasks);
        }

        public ActionResult Add(Flask flask)
        {
            _session.Store(flask);
            return Json(_session.Query<Flask>().Count());
        }

        #region Database stuff
        private static readonly IDocumentStore documentStore;
        private IDocumentSession _session;

        static FlaskController()
        {
            documentStore = new EmbeddableDocumentStore 
            {
                ConnectionStringName = "RavenDB"
            }.Initialize();
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _session = documentStore.OpenSession();
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _session.SaveChanges();
            _session.Dispose();
        }
        #endregion

    }
}
