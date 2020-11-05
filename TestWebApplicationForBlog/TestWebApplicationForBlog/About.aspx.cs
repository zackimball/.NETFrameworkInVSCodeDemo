using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using System.Web.UI.WebControls;

namespace TestWebApplicationForBlog
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Loading about...");
        }
    }
}