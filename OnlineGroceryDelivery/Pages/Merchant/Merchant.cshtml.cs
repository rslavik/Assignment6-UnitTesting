using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using DeliveryCart.Models;

namespace Deliverycart.WebApp.Pages
{
    public class InventoryModel : PageModel
    {

        [BindProperty(SupportsGet = true)]

        public ItemModel items { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }

    }
}