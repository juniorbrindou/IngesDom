using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IngesDom.Models;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace IngesDom.Pages.users
{
    public class AddUserModel : PageModel
    {
        private readonly ILogger<AddUserModel> _logger;
        private DataContext ctx;

        public AddUserModel(ILogger<AddUserModel> logger, DataContext ctx)
        {
            _logger = logger;
            this.ctx = ctx;
        }


        [BindProperty]
        public User User { get; set; }

        public void OnGet()

        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            ctx.Users.Add(User);
            _ = ctx.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
