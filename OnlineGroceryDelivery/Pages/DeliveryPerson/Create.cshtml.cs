﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineGroceryDelivery;

namespace OnlineGroceryDelivery.Pages.DeliveryPerson
{
    public class CreateModel : PageModel
    {
        private readonly OnlineGroceryDelivery.OnlineGroceryDeliveryContext _context;

        public CreateModel(OnlineGroceryDelivery.OnlineGroceryDeliveryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.DeliveryPerson DeliveryPerson { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeliveryPerson.Add(DeliveryPerson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
