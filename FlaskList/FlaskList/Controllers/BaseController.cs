using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client;
using Raven.Client.Embedded;

namespace FlaskList.Controllers
{
    public class BaseController : Controller
    {
        protected static readonly IDocumentStore documentStore;
        protected IDocumentSession _session;

        static BaseController()
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
    }
}