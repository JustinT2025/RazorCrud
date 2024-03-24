
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Data;
using RazorCrudUI.Models;

namespace RazorCrudUI.Pages.Items
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudUI.Data.IItemRepository _repository;

        public DetailsModel(RazorCrudUI.Data.IItemRepository repository)
        {
            _repository = repository;
        }

        public ItemModel ItemModel { get; set; } = default!;
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemmodel = await _repository.GetItemByIdAsync(id.Value);
            if (itemmodel == null)
            {
                return NotFound();
            }
            else
            {
                ItemModel = itemmodel;
            }
            return Page();
        }
        /*
        
        
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemmodel =  _context.Items.FirstOrDefault(m => m.Id == id);
            if (itemmodel == null)
            {
                return NotFound();
            }
            else
            {
                ItemModel = itemmodel;
            }
            return Page();
        }
        */
        
        
    
    }
}

