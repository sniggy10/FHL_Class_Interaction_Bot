using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Content_Bubble_Bot.Pages
{
    public class ContentBubbleModel : PageModel
    {
        [FromQuery(Name = "topic")]
        public string Topic { get; set; }
        public void OnGet()
        {
        }
    }
}
