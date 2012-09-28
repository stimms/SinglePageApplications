using System;
using System.Linq;
using Raven.Client;
using System.Web.Mvc;
using FlaskList.Models;
using Raven.Client.Embedded;
using System.Collections.Generic;

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

        public ActionResult Delete(Guid id)
        {
            _session.Delete(_session.Load<Flask>(id));
            return new EmptyResult();
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
