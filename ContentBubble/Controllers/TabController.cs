using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Content_Bubble_Bot
{
    public class TabController : Controller
    {

        [Route("first")]
        public ActionResult First()
        {
            StringBuilder html = new StringBuilder();
            html.Append("<div> Hello world </div>");
            ViewBag.Message = html;
            return View();
        }
    }
}