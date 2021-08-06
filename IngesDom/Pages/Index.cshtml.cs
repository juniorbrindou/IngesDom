using IngesDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient; //pour communiquer avec une bd SQLServer
//using RazorPages_CRUD_NO_EntityFramework.Models;


namespace IngesDom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private DataContext ctx;
        public IndexModel(ILogger<IndexModel> logger, DataContext ctx)
        {
            _logger = logger;
            this.ctx = ctx;
        }

        public void OnGet ()
        {
            var user = new User()
            {
                Name = "Roamba",
                FirstName = "Epaphras",
                Email = "hdfkhdkf@gmail.com",
                Sex = "Masculin",
            };
            //ctx.Users.Add(user);
            //ctx.SaveChanges();
        }
    }
}
